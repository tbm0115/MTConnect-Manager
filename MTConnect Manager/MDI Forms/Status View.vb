Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Threading

Public Class Status_View
    'Public rangeMin As Double = 0
    'Public rangeMax As Double = 30
    'Private RefreshCnt As Integer = 0
    Dim Cnn As OleDbConnection
    Dim Cmd As OleDbCommand
    Public blnUseSameConnection As Integer = 2
    Private db As String
    'Dim dispatcherTimer As DispatcherTimer
    Private _clockspeed As Integer
    Public sDate, sTime As String
    Public Busy As Boolean

    Public ReadOnly Property ProcessSpeed As Integer
        Get
            Return _clockspeed
        End Get
    End Property

    Public Function GetImage(ByVal GraphicsIndex As Integer) As Bitmap
        If GraphicsIndex <= 0 Then
            Return GetPicturePart(My.Resources.Status_Indicator, New Rectangle(Convert.ToInt32(200 * 0), 0, Convert.ToInt32((200 * 0) + 200), 200))
        ElseIf GraphicsIndex > 5 Then
            Return GetPicturePart(My.Resources.Status_Indicator, New Rectangle(Convert.ToInt32(200 * 5), 0, Convert.ToInt32((200 * 5) + 200), 200))
        Else
            Return GetPicturePart(My.Resources.Status_Indicator, New Rectangle(Convert.ToInt32(200 * GraphicsIndex), 0, Convert.ToInt32((200 * GraphicsIndex) + 200), 200))
        End If
    End Function

    Public Sub Refresh()
        Busy = True
        'Get most current DateTime
        Dim parent As Dashboard = Me.MdiParent
        sDate = parent.dateView.Value.ToString(("MM/dd/yyyy"))
        sTime = parent.timeView.Value.ToString(("HH:mm:ss"))
        Debug.WriteLine(sTime)
        Dim si As Status_Indicator
        Dim Reader As OleDbDataReader
        Dim tim As New Stopwatch
        Dim i As Integer
        tim.Start()
        'Determine if controls share connection string
        '   If true (1) then setup the connection
        '       If the connection string is currently empty, then raise flag (2)
        If blnUseSameConnection = 1 Then
            If String.IsNullOrEmpty(db) Then
                blnUseSameConnection = 2
            Else
                Cnn.ConnectionString = db
                Cnn.Open()
            End If
        End If

        For Each s As Control In pnlView.Controls
            'If TryCast(s, Status_Indicator) IsNot Nothing Then
            si = s
            '------- SHARED CONNECTION VERIFICATION
            '   Determine whether or not all controls in this View share the same connection string
            '       if so, then save the connection string to "db" and leave the connection open
            '           otherwise, open the new connection according to the Probe controls properties
            '       If bln=2 then this view is either new or there is an error in keeping a value in "db"
            '       If bln=0 then a shared connection string doesn't exist, so we have to recompile the connection string
            If blnUseSameConnection = 2 Then
                If Not String.IsNullOrEmpty(si.OleDbConnection) Then
                Else
                    si.OleDbConnection = Local_Functions.CompileOleDbConnectionString(si.OleDbProvider, si.OleDbFile, si.OleDbUser, si.OleDbPassword)
                    If Not IsNothing(Cnn) Then
                        If Not si.OleDbConnection = Cnn.ConnectionString Then
                            MessageBox.Show("Warning! Accessing different databases within a single view can slow your computer. To avoid this, open a new view window for each database connection", "Memory Usage Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            blnUseSameConnection = 0
                        End If
                    End If
                End If
                db = si.OleDbConnection
                Cnn = New OleDbConnection(db)
                Cnn.Open()
            ElseIf blnUseSameConnection = 0 Then
                'Reduce the number of times we compile the connection string by verifying it already exists
                If String.IsNullOrEmpty(si.OleDbConnection) Then
                    si.OleDbConnection = Local_Functions.CompileOleDbConnectionString(si.OleDbProvider, si.OleDbFile, si.OleDbUser, si.OleDbPassword)
                End If
                db = si.OleDbConnection
                Cnn = New OleDbConnection(db)
                Cnn.Open()
            End If
            '--------- END SHARED CONNECTION VERIFICATION
            Cmd = New OleDbCommand("SELECT " & si.OleDbColumn & ",logDate,logTime FROM " & si.OleDbTable & " WHERE logDate='" & sDate & "' ORDER BY " & si.OleDbPrimaryKey & " ASC;", Cnn)
            Reader = Cmd.ExecuteReader

            i = 0
            Dim blnBegin, blnSingle As Boolean
            Dim tbCount As Integer = 0
            blnBegin = False
            blnSingle = False
            For Each record As IDataRecord In Reader
                If Not blnBegin Then
                    If DateTime.Compare(DateTime.Parse(record.Item("logDate").ToString & " " & record.Item("logTime").ToString.Replace(".", ":")), DateTime.Parse(sDate & " " & sTime.ToString)) >= 0 Then
                        Dashboard.lblFirstDT.Text = sDate & " " & sTime.ToString
                        blnBegin = True
                        tbCount = 1
                    End If
                Else
                    If DateTime.Compare(DateTime.Parse(record.Item("logDate").ToString & " " & record.Item("logTime").ToString.Replace(".", ":")), DateTime.Parse(sDate & " " & sTime.ToString).AddMinutes(1)) >= 0 Then
                        'only provide records in sequences of one minute
                        Exit For
                    End If
                    Dashboard.lblLastDT.Text = record.Item("logDate").ToString & " " & record.Item("logTime").ToString.Replace(".", ":")
                    tbCount += 1
                End If
                If blnBegin And tbCount > Dashboard.tbView.Value And i <= My.Settings.intMaxRec And Not blnSingle Then
                    Dashboard.lblSelectedTime.Text = record.Item("logDate").ToString & " " & record.Item("logTime").ToString.Replace(".", ":")
                    If Not IsNothing(record.Item(si.OleDbColumn)) Then
                        si.DataValue = record.Item(si.OleDbColumn).ToString
                    Else
                        si.DataValue = "null"
                    End If

                    si.Invoke(New CrossAppDomainDelegate(AddressOf si.ReDraw))
                    'Get only a single record, then exit
                    blnSingle = True
                    i += 1
                End If
            Next
            Dashboard.tbView.Minimum = 0
            Dashboard.tbView.Maximum = tbCount
            If Not i > 0 Then
                si.DataValue = "null"
                si.Invoke(New CrossAppDomainDelegate(AddressOf si.ReDraw))
            End If
            Reader.Close()
            Cmd.Dispose()
            'if there are no shared connections, then close/dispose the connection also
            '   if connection is shared, leave it open to speed up process.
            If blnUseSameConnection = 0 Then
                Cnn.Close()
                Cnn.Dispose()
            End If
            'End If
        Next
        'Close the connection string if it hasn't already
        '   if the logic was indecisive, then assume that it is true now
        If Me.Controls.Count > 1 Then
            If blnUseSameConnection = 2 Then
                blnUseSameConnection = 1
            End If
            If blnUseSameConnection = 1 Then
                Cnn.Close()
                Cnn.Dispose()
            End If
        Else
            blnUseSameConnection = 2
        End If

        'Debug.WriteLine("Status-Total Timer: " & tim.ElapsedMilliseconds.ToString & vbLf & vbTab & "'" & db & "'")
        _clockspeed = CInt(tim.ElapsedMilliseconds)
        parent.Invoke(New CrossAppDomainDelegate(AddressOf parent.ClockSpeedCheck))
        tim.Stop()
        Debug.WriteLine(vbTab & "Status-Redrew:" & tim.ElapsedMilliseconds.ToString)
        Busy = False
        GC.Collect()
    End Sub

    Private Sub tlAddIndicator_Click(sender As System.Object, e As System.EventArgs) Handles tlAddIndicator.Click
        Status_Add.Dashboard = Me
        Status_Add.ShowDialog()
    End Sub
    Public Sub Relocate()
        pnlView.VerticalScroll.Value = 0
        Dim cnt As Integer = 0
        Dim row As Integer = 0
        Dim s As Status_Indicator
        For Each Child As Control In pnlView.Controls
            If (Child.GetType() Is GetType(Status_Indicator)) Then
                s = Child
                If cnt = My.Settings.ControlColumns Then
                    cnt = 0
                    row += 1
                End If
                cnt += 1
                s.Location = New Point((200 * (cnt - 1)), (200 * row) + 30)
            End If
        Next
    End Sub

    Private Sub removeIndicator_Click(sender As System.Object, e As System.EventArgs) Handles removeIndicator.Click
        Status_Remove.MDIView = Me
        Status_Remove.ShowDialog()
        Relocate()
    End Sub
End Class