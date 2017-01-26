Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Threading

Public Class Dial_View
    Private db As String
    Dim Cnn As OleDbConnection
    Dim Cmd As OleDbCommand
    Dim Reader As OleDbDataReader
    Public blnUseSameConnection As Integer = 2
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
            Return GetPicturePart(My.Resources.Dial_190, New Rectangle(Convert.ToInt32(350 * 0), 0, Convert.ToInt32((350 * 0) + 350), 200))
        ElseIf GraphicsIndex > 35 Then
            Return GetPicturePart(My.Resources.Dial_190, New Rectangle(Convert.ToInt32(350 * 35), 0, Convert.ToInt32((350 * 35) + 350), 200))
        Else
            Return GetPicturePart(My.Resources.Dial_190, New Rectangle(Convert.ToInt32(350 * GraphicsIndex), 0, Convert.ToInt32((350 * GraphicsIndex) + 350), 200))
        End If
    End Function
    Private Sub Dial_View_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'dispatcherTimer.Stop()
    End Sub

    Private Sub tlAddDial190_Click(sender As System.Object, e As System.EventArgs) Handles tlAddDial190.Click
        Dial190_Add.Dashboard = Me
        Dial190_Add.ShowDialog()
    End Sub

    Public Sub Refresh()
        Busy = True
        'Get most current DateTime
        Dim parent As Dashboard = Me.MdiParent
        sDate = parent.dateView.Value.ToString(("MM/dd/yyyy"))
        sTime = parent.timeView.Value.ToString(("HH:mm:ss"))
        Debug.WriteLine(sTime)
        Dim tim As New Stopwatch
        Dim di As Dial_190
        Dim FILE As String
        Dim TABLE As String
        Dim COLUMN As String
        Dim i, tmp As Integer
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

        For Each d As Control In pnlView.Controls
            'Try
            'If TryCast(d, Dial_190) IsNot Nothing Then
            di = d
            FILE = di.OleDbFile
            TABLE = di.OleDbTable
            COLUMN = di.OleDbColumn

            '------- SHARED CONNECTION VERIFICATION
            '   Determine whether or not all controls in this View share the same connection string
            '       if so, then save the connection string to "db" and leave the connection open
            '           otherwise, open the new connection according to the Probe controls properties
            '       If bln=2 then this view is either new or there is an error in keeping a value in "db"
            '       If bln=0 then a shared connection string doesn't exist, so we have to recompile the connection string
            If blnUseSameConnection = 2 Then
                If Not String.IsNullOrEmpty(di.OleDbConnection) Then
                Else
                    di.OleDbConnection = Local_Functions.CompileOleDbConnectionString(di.OleDbProvider, di.OleDbFile, di.OleDbUser, di.OleDbPassword)
                    If Not IsNothing(Cnn) Then
                        If Not di.OleDbConnection = Cnn.ConnectionString Then
                            MessageBox.Show("Warning! Accessing different databases within a single view can slow your computer. To avoid this, open a new view window for each database connection", "Memory Usage Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            blnUseSameConnection = 0
                        End If
                    End If
                End If
                db = di.OleDbConnection
                Cnn = New OleDbConnection(db)
                Cnn.Open()
            ElseIf blnUseSameConnection = 0 Then
                'Reduce the number of times we compile the connection string by verifying it already exists
                If String.IsNullOrEmpty(di.OleDbConnection) Then
                    di.OleDbConnection = Local_Functions.CompileOleDbConnectionString(di.OleDbProvider, di.OleDbFile, di.OleDbUser, di.OleDbPassword)
                End If
                db = di.OleDbConnection
                Cnn = New OleDbConnection(db)
                Cnn.Open()
            End If
            '--------- END SHARED CONNECTION VERIFICATION
            Cmd = New OleDbCommand("SELECT " & COLUMN & ",logDate,logTime FROM " & TABLE & " WHERE logDate='" & sDate & "' ORDER BY " & di.OleDbPrimaryKey & " ASC;", Cnn)
            Reader = Cmd.ExecuteReader

            i = 0
            Debug.WriteLine("Records Affected: " & Reader.RecordsAffected.ToString)
            'Create a series point for each record that was returned from database connection
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

                If IsNumeric(record.Item(COLUMN).ToString) And blnBegin And tbCount > Dashboard.tbView.Value And i <= My.Settings.intMaxRec And Not blnSingle Then
                    Integer.TryParse(record.Item(COLUMN).ToString, tmp)
                    If tmp <= 190 Then
                        Dashboard.lblSelectedTime.Text = record.Item("logDate").ToString & " " & record.Item("logTime").ToString.Replace(".", ":")
                        di.DialValue = tmp
                        di.Invoke(New CrossAppDomainDelegate(AddressOf di.ReDraw))
                        'Get only a single record, then exit
                        blnSingle = True
                    Else
                        Debug.WriteLine("Skipped dial redraw")
                    End If

                    i += 1
                End If
            Next
            Dashboard.tbView.Minimum = 0
            Dashboard.tbView.Maximum = tbCount
            If Not i > 0 Then
                di.DialValue = 0
                di.Invoke(New CrossAppDomainDelegate(AddressOf di.ReDraw))
            End If
            Debug.WriteLine("Records Affected: " & i.ToString)
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

        'Debug.WriteLine("Dial-Total Timer: " & tim.ElapsedMilliseconds.ToString & vbLf & vbTab & "'" & db & "'")
        _clockspeed = CInt(tim.ElapsedMilliseconds)
        parent.Invoke(New CrossAppDomainDelegate(AddressOf parent.ClockSpeedCheck))
        tim.Stop()
        Debug.WriteLine(vbTab & "Dial-Redrew (ms): " & tim.ElapsedMilliseconds.ToString)
        Busy = False
        GC.Collect()
    End Sub

    Private Sub removeDial190_Click(sender As System.Object, e As System.EventArgs) Handles removeDial190.Click
        Dial190_Remove.MDIView = Me
        Dial190_Remove.ShowDialog()
        Relocate()
    End Sub

    Public Sub Relocate()
        pnlView.VerticalScroll.Value = 0
        Dim cnt As Integer = 0
        Dim row As Integer = 0
        Dim d As Dial_190
        For Each Child As Control In pnlView.Controls
            If (Child.GetType() Is GetType(Dial_190)) Then
                d = Child
                If cnt = My.Settings.ControlColumns Then
                    cnt = 0
                    row += 1
                End If
                cnt += 1
                d.Location = New Point((350 * (cnt - 1)), (200 * row) + 30)
            End If
        Next
    End Sub
End Class