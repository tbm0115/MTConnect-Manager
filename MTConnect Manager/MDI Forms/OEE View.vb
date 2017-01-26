Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Threading

Public Class OEE_View
    'Dim dispatcherTimer As DispatcherTimer
    Dim ViewDate As DateTime = DateTime.Today
    'Private _img() As Bitmap

    Dim db As String = Local_Functions.CompileOleDbConnectionString(Local_Functions.GetOleDbProvider(My.Resources.E2DatabaseLocation), My.Resources.E2DatabaseLocation)
    Dim Cnn As New OleDbConnection(db)
    Dim Cmd As OleDbCommand
    Dim Reader As OleDbDataReader
    Private _clockspeed As Integer
    Public sDate, sTime As String
    Public Busy As Boolean

    Public ReadOnly Property ProcessSpeed As Integer
        Get
            Return _clockspeed
        End Get
    End Property

    Public Function GetImage(ByVal GraphicsIndex As Integer) As Bitmap
        'If GraphicsIndex <= 0 Then
        '    Return _img(0)
        'ElseIf GraphicsIndex > 100 Then
        '    Return _img(99)
        'Else
        '    Return _img(GraphicsIndex)
        'End If
    End Function

    Private Sub OEE_View_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        tlViewDate.Text = "Set Date:" & Format(ViewDate, "MM/dd/yyy")
        'InitializeTimer()
    End Sub

    Public Sub Refresh()
        Busy = True
        'Get most current DateTime
        Dim parent As Dashboard = Me.MdiParent
        sDate = parent.dateView.Value.ToString(("MM/dd/yyyy"))
        sTime = parent.timeView.Value.ToString(("HH:mm:ss"))
        ViewDate = DateTime.Parse(sDate)
        Debug.WriteLine("OEE ViewDate: " & ViewDate.ToString)
        Cnn.ConnectionString = db
        Cnn.Open()
        Dim tim As New Stopwatch
        tim.Start()
        Dim o As OEE
        Dim temp As Decimal
        For Each d As OEE In pnlView.Controls
            'Try
            '    If TryCast(d, OEE) IsNot Nothing Then
            o = d

            'Availability
            o.ShiftLength = 10
            o.Breaks = 0.83333
            SetDownTime(o)
            Debug.WriteLine("downtime set")
            temp = o.CalculatePlannedProductionTime()
            Debug.WriteLine("planned prod time set")
            o.OperatingTime = temp - o.DownTime
            Debug.WriteLine("oper time set")
            If Not temp <= 0 Then
                o.Availability = (temp - o.DownTime) / temp
            Else
                o.Availability = 0
            End If
            Debug.WriteLine("availability set")

            'Quality
            SetProductCounts(o)
            Debug.WriteLine("prod cnt set")
            If Not o.TotalProduct <= 0 Then
                o.Quality = o.GoodProduct / o.TotalProduct
            Else
                o.Quality = 0
            End If
            Debug.WriteLine("quality set")

            'Performance
            SetActualProductionTime(o)
            Debug.WriteLine("act prod time set")
            temp = GetTheoreticalOutput(o)
            Debug.WriteLine("got theo output set")
            If Not temp <= 0 Then
                o.Performance = temp
            Else
                o.Performance = 0
            End If
            Debug.WriteLine("performance set")

            o.QuickCalcOEE()
            Debug.WriteLine("oee set")
            o.Invoke(New CrossAppDomainDelegate(AddressOf o.ReDraw))
            Debug.WriteLine("redrew oee cntrl")
            '    End If
            'Catch ex As Exception
            '    Debug.WriteLine("Error enumerating OEE controls")
            '    Local_Functions.Log("(Dashboard_OEE)[Refresh]" + vbTab + ex.Message)
            'End Try
        Next
        Cnn.Close()
        Cnn.Dispose()
        'Debug.WriteLine("OEE-Total Timer: " + tim.ElapsedMilliseconds.ToString)
        _clockspeed = CInt(tim.ElapsedMilliseconds)
        parent.Invoke(New CrossAppDomainDelegate(AddressOf parent.ClockSpeedCheck))
        tim.Stop()
        Debug.WriteLine(vbTab & "OEE-Redrew:" & tim.ElapsedMilliseconds.ToString)
        Busy = False
    End Sub

    Private Sub SetDownTime(ByVal O As OEE)
        If Not IsNothing(O.OleDbConnection) Then
            Dim Cnn2 As New OleDbConnection(O.OleDbConnection)
            Cnn2.Open()
            '" + DateTime.Today.Month.ToString + "/" + DateTime.Today.Day.ToString + "/" + DateTime.Today.Year.ToString = "
            Cmd = New OleDbCommand("SELECT logID,execution,logTime FROM " + O.OleDbTable.ToString.Remove(O.OleDbTable.ToString.IndexOf(":") + 1) + "MTConnect WHERE logDate = '" + Format(ViewDate, "M/d/yyyy").ToString + "' ORDER BY logID ASC;", Cnn2)
            Reader = Cmd.ExecuteReader
            Dim FromTime, ToTime As DateTime
            Dim TotalTime As TimeSpan
            Dim blnACTIVE As Boolean = False
            For Each Record As IDataRecord In Reader
                ToTime = Convert.ToDateTime(Record.Item("logTime").ToString.Replace("::", ":"))
                If blnACTIVE = False Then
                    If Not IsNothing(FromTime) Then
                        TotalTime += (ToTime - FromTime)
                    End If
                End If
                If Not Record.Item("execution").ToString.ToUpper = "ACTIVE" Then
                    blnACTIVE = False
                Else
                    blnACTIVE = True
                End If
                FromTime = ToTime
            Next
            O.DownTime = Convert.ToDouble(TotalTime.TotalHours.ToString)
            Reader.Close()
            Cmd.Dispose()
            Cnn2.Close()
            Cnn2.Dispose()
        End If
    End Sub
    Private Sub SetProductCounts(ByVal O As OEE)
        Cmd = New OleDbCommand("SELECT PiecesFinished,PiecesScrapped,WorkCntr,JobNo FROM dbo_TimeTicketDet WHERE TicketDate = '" + Format(ViewDate, "MM/dd/yy") + "';", Cnn)
        Reader = Cmd.ExecuteReader
        Dim cnt As Integer = 0
        Dim gp, scrap, tmp As Integer
        gp = 0
        scrap = 0
        For Each Record As IDataRecord In Reader
            If O.WorkCenter.ToString = Record.Item("WorkCntr").ToString Then
                Integer.TryParse(Record.Item("PiecesFinished").ToString, tmp)
                gp += tmp
                Integer.TryParse(Record.Item("PiecesScrapped").ToString, tmp)
                scrap += tmp
                cnt += 1
            End If
        Next
        O.GoodProduct = gp
        O.TotalProduct = gp + scrap
        Cmd.Dispose()
        Reader.Close()
    End Sub
    Private Sub SetActualProductionTime(ByVal o As OEE)
        Dim Reader2 As OleDbDataReader
        Dim APT As Decimal = 0
        Try
            Cmd = New OleDbCommand("SELECT JobNo,TicketDate,WorkCntr FROM dbo_TimeTicketDet WHERE TicketDate = '" & Format(ViewDate, "MM/dd/yy") & "';", Cnn)
            Reader2 = Cmd.ExecuteReader
            Dim cnt As Integer = 0
            For Each Record As IDataRecord In Reader2
                'Process currently focused WorkCenter
                If Record.Item("WorkCntr").ToString = o.WorkCenter Then
                    Cmd = New OleDbCommand("SELECT TotalEstHrs,JobNo FROM dbo_OrderDet WHERE JobNo = '" & Record.Item("JobNo").ToString & "' ORDER BY OrderNo ASC;", Cnn)
                    Reader = Cmd.ExecuteReader
                    For Each Job As IDataRecord In Reader
                        APT += Convert.ToDecimal(Job.Item("TotalEstHrs").ToString)
                    Next
                    Cmd.Dispose()
                    Reader.Close()
                End If
                cnt += 1
            Next
            Cmd.Dispose()
            Reader2.Close()

            o.IdealCycleTime = APT
        Catch ex As Exception
            Debug.WriteLine("Connection string is probably being used" & vbLf & vbTab & ex.Message)
        End Try

    End Sub
    Private Function GetTheoreticalOutput(ByVal o As OEE) As Decimal
        Dim Cmd2 As OleDbCommand
        Dim Reader2 As OleDbDataReader
        Dim APT As Decimal = 0
        Dim Qty As Integer = 0
        Dim PiecesFinished As Integer = 0
        Dim ManHrs As Decimal = 0
        Cmd2 = New OleDbCommand("SELECT JobNo,TicketDate,WorkCntr,MachHrs,PiecesFinished FROM dbo_TimeTicketDet WHERE TicketDate = '" + Format(ViewDate, "MM/dd/yy") + "';", Cnn)
        Try
            Reader2 = Cmd2.ExecuteReader
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Dim cnt2 As Integer
        For Each Record As IDataRecord In Reader2
            If Record.Item("WorkCntr").ToString = o.WorkCenter.ToString Then
                ManHrs += Convert.ToDecimal(Record.Item("MachHrs").ToString)
                PiecesFinished += Convert.ToInt32(Record.Item("PiecesFinished").ToString)
                Cmd = New OleDbCommand("SELECT TotalEstHrs,JobNo,QtyToMake FROM dbo_OrderDet WHERE JobNo = '" + Record.Item("JobNo").ToString + "';", Cnn)
                Reader = Cmd.ExecuteReader
                For Each Job As IDataRecord In Reader
                    If Job.Item("JobNo").ToString = Record.Item("JobNo").ToString Then
                        APT += Convert.ToDecimal(Job.Item("TotalEstHrs").ToString)
                        Qty += Convert.ToInt32(Job.Item("QtyToMake").ToString)
                    End If
                Next
                cnt2 += 1
                Cmd.Dispose()
                Reader.Close()
            End If
        Next
        Cmd2.Dispose()
        Reader2.Close()
        o.QtyToMake = Qty
        o.TotalEstimatedHours = APT
        o.PiecesFinished = PiecesFinished
        o.MachineHours = ManHrs
        If APT = 0 Or Qty = 0 Or PiecesFinished = 0 Then
            Return Nothing
        Else
            Return ((APT * PiecesFinished) / Qty) / ManHrs
        End If
    End Function
    Private Sub tlAddIndicator_Click(sender As System.Object, e As System.EventArgs) Handles tlAddIndicator.Click
        OEE_Add.Dashboard = Me
        OEE_Add.ShowDialog()
    End Sub

    Public Sub Relocate()
        pnlView.VerticalScroll.Value = 0
        Dim cnt As Integer = 0
        Dim row As Integer = 0
        Dim o As OEE
        For Each Child As Control In pnlView.Controls
            If (Child.GetType() Is GetType(OEE)) Then
                o = Child
                If cnt = My.Settings.ControlColumns Then
                    cnt = 0
                    row += 1
                End If
                cnt += 1
                o.Location = New Point((200 * (cnt - 1)), (326 * row) + 30)
            End If
        Next
    End Sub
    Private Sub tlViewDate_Click(sender As System.Object, e As System.EventArgs) Handles tlViewDate.Click
        Dim dg As DialogResult
        dg = SelectDate.ShowDialog
        If dg = Windows.Forms.DialogResult.OK Then
            ViewDate = SelectDate.viewdate.SelectionEnd
            tlViewDate.Text = "Set Date:" + Format(ViewDate, "MM/dd/yyy")
        End If
    End Sub

    Private Sub removeIndicator_Click(sender As System.Object, e As System.EventArgs) Handles removeIndicator.Click
        OEE_Remove.MDIView = Me
        OEE_Remove.ShowDialog()
        Relocate()
    End Sub
End Class