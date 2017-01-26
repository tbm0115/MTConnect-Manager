Imports System.Xml
Imports System.Data
Imports System.Data.OleDb
Imports System.Threading
Imports System.Windows.Forms
Imports System.IO.Stream
Imports System.Net

Public Class Watcher
    Private WatchList As New List(Of WatchItem)

    Private Sub watchAdd_Click(sender As System.Object, e As System.EventArgs) Handles watchAdd.Click
        Dim dg As DialogResult
        dg = AddWatch.ShowDialog()
        If dg = Windows.Forms.DialogResult.OK Then
            Call sessionLoad_Click(sessionLoad, Nothing)
        End If
    End Sub
    Private Sub sessionLoad_Click(sender As System.Object, e As System.EventArgs) Handles sessionLoad.Click
        pnlSession.Controls.Clear()
        Dim myXML As New XmlDocument
        myXML.Load(My.Settings.StartUp & "\XML\Watch_Sessions.xml")


    Dim watchcnt As Integer = 0
        Dim NAME, PORT, RATE, TYPE, FILE, ACTION As String
        Dim wi As New List(Of WatchItem)
        For Each WATCH As XmlElement In myXML.SelectSingleNode("sessions").ChildNodes
            NAME = WATCH.SelectSingleNode("name").InnerText
            PORT = WATCH.SelectSingleNode("port").InnerText
            RATE = WATCH.SelectSingleNode("rate").InnerText
            TYPE = WATCH.SelectSingleNode("output").Attributes("type").Value
            FILE = WATCH.SelectSingleNode("output").SelectSingleNode("file").InnerText
            ACTION = WATCH.SelectSingleNode("output").SelectSingleNode("action").InnerText
            Dim rtbLog As New RichTextBox
            Dim grpLog As New GroupBox
            With grpLog
                .Text = NAME & ":" & PORT
                .Name = "grp" & watchcnt.ToString
                .Size = New Size(100, 400)
                .Dock = DockStyle.Top
                .Padding = New Padding(3)
            End With
            With rtbLog
                .Name = "rtb" & watchcnt.ToString
                .Size = New Size(100, 100)
                .Dock = DockStyle.Fill
                .BackColor = Color.Black
                .ForeColor = Color.White
            End With
            grpLog.Controls.Add(rtbLog)
            pnlSession.Controls.Add(grpLog)
            pnlSession.Controls.SetChildIndex(grpLog, 0)
            Dim w As New WatchItem
            w.LogControl = rtbLog
            w.InputURL = "http://" & NAME & ":" & PORT & "/current"
            w.OutputType = TYPE
            w.OutputFilePath = FILE
            w.OutputAction = ACTION
            w.RefreshRate = RATE
            w.Start()
            WatchList.Add(w)
            rtbLog.AppendText("URL:" & w.InputURL & vbLf & "Rate:" & RATE & vbLf & "Type:" & TYPE & vbLf & "Filename:" & FILE & vbLf & "Actions:" & ACTION & vbLf)
            watchcnt += 1
        Next
        statWatchCnt.Text = "Watch Count:" & watchcnt.ToString
    End Sub
    Private Sub Watcher_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call sessionLoad_Click(sessionLoad, Nothing)
    End Sub
    Private Sub tlChangeRate_Click(sender As System.Object, e As System.EventArgs) Handles tlChangeRate.Click
        For Each w As WatchItem In WatchList
            Dim strTemp As String = InputBox("Enter a new refresh rate (in milliseconds) for " & w.InputURL & ":", "New Refresh Rate", w.RefreshRate.ToString)
            If IsNumeric(strTemp) = True Then
                w.RefreshRate = Convert.ToInt32(strTemp)
                w.StopMe()
                w.Start()
            End If
        Next
    End Sub
    Private Sub tlClearLogs_Click(sender As System.Object, e As System.EventArgs) Handles tlClearLogs.Click
        For Each grp As GroupBox In pnlSession.Controls
            Dim rtb As RichTextBox = grp.Controls.Find(grp.Name.Replace("grp", "rtb"), True).First
            rtb.Clear()
        Next
    End Sub
    Private Sub sessionStop_Click(sender As System.Object, e As System.EventArgs) Handles sessionStop.Click
        For Each c As WatchItem In WatchList
            c.StopMe()
        Next
        WatchList.Clear()
        sessionStart.Enabled = True
        sessionStop.Enabled = False
    End Sub
    Private Sub sessionStart_Click(sender As System.Object, e As System.EventArgs) Handles sessionStart.Click
        sessionStart.Enabled = False
        sessionStop.Enabled = True
        Call sessionLoad_Click(sessionLoad, Nothing)
    End Sub
    Private Sub watchRemove_Click(sender As System.Object, e As System.EventArgs) Handles watchRemove.Click
        Dim dg As DialogResult
        dg = RemoveWatch.ShowDialog()
        If dg = Windows.Forms.DialogResult.OK Then
            Call sessionLoad_Click(sessionLoad, Nothing)
        End If
    End Sub

    Public Class WatchItem
        Private AverageRecord As New Stopwatch
        Private AverageCount As Integer = 0
        Private AverageTotal As Decimal = 0

        Private blnText, blnData As Boolean
        Private strCol, strVal, tmpVal, tmpCol As String
        Private replyStream As IO.Stream = Nothing
        Private RefreshCnt, originalRefresh As Integer
        Private WithEvents Timer As System.Threading.Timer
        Private rtbLOG As RichTextBox
        Private OutFile, Action, OutType, URL As String
        Private oleCnn As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & OutFile & ";")
        Private oleCmd As OleDbCommand
        Private failedAttempts As Integer = 0
        Const Max_Attempts As Integer = 5
        Public ProcessStalled As Boolean = False

        Public Property RefreshRate As Integer
            Get
                Return RefreshCnt
            End Get
            Set(value As Integer)
                RefreshCnt = value
                originalRefresh = value
            End Set
        End Property
        Public Property LogControl As RichTextBox
            Get
                Return rtbLOG
            End Get
            Set(value As RichTextBox)
                rtbLOG = value
            End Set
        End Property
        Public Property InputURL As String
            Get
                Return URL
            End Get
            Set(value As String)
                URL = value
            End Set
        End Property
        Public Property OutputType As String
            Get
                Return OutType
            End Get
            Set(value As String)
                OutType = value
            End Set
        End Property
        Public Property OutputAction As String
            Get
                Return Action
            End Get
            Set(value As String)
                Action = value
            End Set
        End Property
        Public Property OutputFilePath As String
            Get
                Return OutFile
            End Get
            Set(value As String)
                OutFile = value
                oleCnn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & OutFile & ";"
            End Set
        End Property

        Private Sub ReportStatus(ByVal Cntrl As Control, ByVal MESSAGE As String)
            Dim rtb As RichTextBox = Cntrl
            rtb.AppendText(MESSAGE & vbLf)
        End Sub
        Private Sub rssReadCallback(ByVal sender As Object, ByVal e As System.Net.OpenReadCompletedEventArgs)
            Try
                replyStream = CType(e.Result, IO.Stream)
            Catch ex As Exception
                Debug.WriteLine("ReplyStream Error:" & ex.Message)
            End Try
        End Sub
        Public Sub Start()
            Dim TimerDelegate As New Threading.TimerCallback(AddressOf Refresh)
            Timer = New System.Threading.Timer(TimerDelegate, Nothing, RefreshRate, RefreshRate)
            AverageRecord.Start()
        End Sub
        Public Sub StopMe()
            'Reset failed attempts
            ProcessStalled = False
            failedAttempts = 0
            Timer.Dispose()
            AverageRecord.Stop()
        End Sub
        Private Function FailedCheck() As String
            If failedAttempts = Max_Attempts Then
                'Reset the refresh rate to try again at the 7:00 am mark the next day
                ProcessStalled = True
                failedAttempts = 0
                'set refresh rate to interval of time until the next 7:00am time
                Dim ts As TimeSpan = DateTime.Parse(Today.AddDays(1).ToString(("MM/dd/yyyy")) & " " & My.Settings.strTimerResume) - Now
                RefreshCnt = ts.TotalMilliseconds
                StopMe()
                Start()
                Return "This process has been greatly adjusted due to repeated failed attempts" & _
                                                     " to read the MTConnect data. The RefreshRate has been reduced to refresh once per hour" & _
                                                     " until a successful connection can be made. Please ensure the device is turned on and " & _
                                                     "available on the network." & _
                                                     " Another connection will be attempted in " & ts.Hours & ":" & ts.Minutes & ":" & ts.Seconds & "." & ts.Milliseconds & vbLf
            ElseIf failedAttempts = 1 And ProcessStalled Then
                'Next day assumed and therefore the ten minute double check begins before restarting if no connection made
                RefreshCnt = My.Settings.intSemiSuspend
                StopMe()
                Start()
            End If
            Return ""
        End Function
        Private Sub Refresh()
            Dim w As New System.Net.WebClient
            Dim myXML As New XmlDocument
            Dim blnUnique As Boolean
            Dim colDateTime, valDateTime, DEBUG As String
            Dim ProcTimer As New Stopwatch
            Dim intFiles As Integer = 0
            Dim rtbOut As String
            DEBUG = "1"
            'If CSV selected and New file option selected, append file name with file count
            If Action = "new" Then
                For Each f As String In IO.Directory.GetFiles(OutFile.Remove(OutFile.LastIndexOf("\")))
                    If f.Contains(OutFile.Remove(OutFile.LastIndexOf(".")).Remove(0, OutFile.LastIndexOf("\") + 1)) Then
                        intFiles += 1
                    End If
                Next
            End If
            AddHandler w.OpenReadCompleted, AddressOf rssReadCallback
            blnData = False
            blnText = False
            'Get potential startup arguments
            If OutType = "csv" Then
                blnText = True
            ElseIf OutType = "mdb" Then
                blnData = True
            End If
            DEBUG = "1.1"
            'Begin data dump loop

            Try
                ProcTimer.Start()
                'if text dump option selected, clear temp dump file.
                DEBUG = "1"
                If IO.File.Exists(OutFile) And blnText Then
                    IO.File.Delete(OutFile)
                End If
                'Directly stream current XML
                DEBUG = "2"
                w.OpenReadAsync(New Uri(URL))

                Dim ti As New Stopwatch
                ti.Start()
                Do Until IsNothing(replyStream) = False
                    Application.DoEvents()
                    If ti.ElapsedMilliseconds > (originalRefresh * 2) Then
                        failedAttempts += 1
                        rtbOut += FailedCheck()
                        Try
                            If rtbLOG.InvokeRequired Then
                                rtbLOG.BeginInvoke(Sub() ReportStatus(rtbLOG, rtbOut))
                            End If
                        Catch ex As Exception
                            System.Diagnostics.Debug.WriteLine("Writing to rtb error2:" & ex.Message)
                        End Try
                        Exit Sub
                    End If
                Loop
                ti.Stop()
                If ProcessStalled Then
                    ProcessStalled = False
                    'Connection must have just been made
                    failedAttempts = 0
                    RefreshRate = originalRefresh
                    StopMe()
                    Start()
                    Try
                        If rtbLOG.InvokeRequired Then
                            rtbLOG.BeginInvoke(Sub() ReportStatus(rtbLOG, rtbOut))
                        End If
                    Catch ex As Exception
                        System.Diagnostics.Debug.WriteLine("Writing to rtb error2:" & ex.Message)
                    End Try
                    Exit Sub
                End If
                DEBUG = "2.1"
                Try
                    myXML.Load(replyStream)
                Catch ex As Exception
                    failedAttempts += 1
                    rtbOut += FailedCheck()
                    Try
                        If rtbLOG.InvokeRequired Then
                            rtbLOG.BeginInvoke(Sub() ReportStatus(rtbLOG, rtbOut))
                        End If
                    Catch ex2 As Exception
                        System.Diagnostics.Debug.WriteLine("Writing to rtb error2:" & ex2.Message)
                    End Try
                    Exit Sub
                End Try
                DEBUG = "2.2"
                w.Dispose()
                DEBUG = "3"
                For Each NODE As XmlElement In myXML.ChildNodes(1).ChildNodes(1).ChildNodes(0).ChildNodes
                    'search for proper schema
                    If NODE.Name = "ComponentStream" Then
                        If NODE.HasAttribute("component") And NODE.HasAttribute("name") Then
                            DEBUG = "4"
                            If blnText Then
                                'due to text dump option, dump contents into textfile
                                Select Case Action
                                    Case "overwrite"
                                        IO.File.WriteAllText(OutFile, Get_Samples(NODE, myXML) & vbLf & Get_Condition(NODE, myXML) & vbLf & Get_Event(NODE, myXML))
                                    Case "append"
                                        IO.File.AppendAllText(OutFile, Get_Samples(NODE, myXML) & vbLf & Get_Condition(NODE, myXML) & vbLf & Get_Event(NODE, myXML))
                                    Case "new"
                                        IO.File.AppendAllText(OutFile.Remove(OutFile.LastIndexOf(".")) & intFiles.ToString + OutFile.Remove(0, OutFile.LastIndexOf(".")), Get_Samples(NODE, myXML) & vbLf & Get_Condition(NODE, myXML) & vbLf & Get_Event(NODE, myXML))
                                End Select
                            ElseIf blnData Then
                                'due to data dump option, get contents from XML file for further review
                                Get_Samples(NODE, myXML)
                                Get_Condition(NODE, myXML)
                                Get_Event(NODE, myXML)
                            End If
                        End If
                    End If
                Next
                If blnData Then
                    'check unique strings
                    'assume data is unique
                    'This check comes before setup of command and connection to avoid confusion with datetime fields
                    blnUnique = True
                    If Not String.IsNullOrEmpty(strVal) Then
                        If tmpVal = strVal Then
                            If tmpCol = strCol Then
                                'if nothing is unique then surely don't add data
                                blnUnique = False
                            Else
                                'even if data is not unique, if columns are unique then add data appropriately
                                blnUnique = False
                            End If
                        Else
                            'if data is unique, then surely add data
                            blnUnique = True
                        End If
                    Else
                        blnUnique = False
                    End If
                    Try
                        'Only setup connections and commands if data is unique. Hopefully speed things up
                        DEBUG = "5"
                        If blnUnique Then
                            'add datetime fields to front of command
                            colDateTime = "logDate,logTime,"
                            valDateTime = "'" + Format(DateTime.Now, "MM/dd/yyyy") & "','" & Format(DateTime.Now, "HH:mm.ss") & "',"
                            If oleCnn.State = ConnectionState.Closed Then
                                oleCnn.Open()
                            End If
                            oleCmd = New OleDbCommand("INSERT INTO " & Action & " (" & colDateTime & strCol.Remove(strCol.LastIndexOf(",")) & ") VALUES(" & valDateTime & strVal.Remove(strVal.LastIndexOf(",")) & ");", oleCnn)
                            'clear cache
                            oleCmd.ExecuteNonQuery()
                            oleCmd.Dispose()
                            oleCnn.Close()
                            AverageTotal += AverageRecord.ElapsedMilliseconds
                            AverageCount += 1
                            AverageRecord.Restart()
                            rtbOut += "Record successfully saved! Average Actual Recording Rate: " & (AverageTotal / AverageCount).ToString & "ms" & vbLf
                        Else
                            rtbOut += "No unique data found..." & vbLf
                        End If
                    Catch ex As Exception
                        rtbOut += "Error sending to database (" & DEBUG & "):" & ex.Message & vbLf
                    End Try
                End If
                rtbOut += "ProcTime:" & ProcTimer.ElapsedMilliseconds.ToString & "__Time:" & Format(DateTime.Now, "HH:mm.ss")
            Catch ex As Exception
                rtbOut += vbLf & "An error occurred in Refresh process (" & DEBUG & "): " & ex.Message & vbLf
            End Try
            Try
                If rtbLOG.InvokeRequired Then
                    rtbLOG.BeginInvoke(Sub() ReportStatus(rtbLOG, rtbOut))
                End If
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Writing to rtb error2:" & ex.Message)
            End Try
            'setup history for 'remove-dups'
            tmpCol = strCol
            tmpVal = strVal
            'clear data to avoid issue
            strCol = ""
            strVal = ""
        End Sub
        Private Function Get_Event(ByVal NODE As XmlElement, ByVal DOC As XmlDocument) As String
            Dim strTemp As String
            Dim strOutPut As String

            If Not IsNothing(NODE.ChildNodes) Then
                If NODE.ChildNodes.Count > 0 Then
                    For Each temp As XmlElement In NODE.ChildNodes
                        If TypeOf temp Is System.Xml.XmlElement Then
                            If temp.Name = "Events" Then
                                If temp.ChildNodes.Count > 1 Then
                                    For Each nod As XmlElement In temp.ChildNodes
                                        If TypeOf nod Is System.Xml.XmlElement Then
                                            If nod.HasAttribute("subType") Then
                                                strTemp = nod.Attributes("subType").Value
                                            Else
                                                strTemp = ""
                                            End If
                                            If blnText Then
                                                strOutPut += nod.Attributes("name").Value & "/" & nod.InnerText & vbLf
                                            ElseIf blnData Then
                                                If nod.HasAttribute("name") Then
                                                    If Not strCol.Contains(nod.Attributes("name").Value) Then
                                                        strCol += nod.Attributes("name").Value & ","
                                                        strVal += "'" & nod.InnerText & "',"
                                                        strOutPut += "'" & nod.InnerText & "',"
                                                    End If
                                                End If
                                            End If
                                        End If

                                    Next
                                End If
                            End If
                        End If
                    Next
                End If
            End If
            Return strOutPut
        End Function
        Private Function Get_Condition(ByVal NODE As XmlElement, ByVal DOC As XmlDocument) As String
            Dim strTemp, strOutPut As String
            For Each temp As XmlElement In NODE.ChildNodes
                If temp.Name = "Condition" Then
                    For Each nod As XmlElement In temp.ChildNodes
                        If nod.HasAttribute("type") = True Then
                            strTemp = nod.Attributes("type").Value
                        Else
                            strTemp = ""
                        End If
                        If blnText = True Then
                            strOutPut += nod.Attributes("name").Value & "s/" & nod.Name & vbLf
                            strOutPut += nod.Attributes("name").Value & "v/" & nod.InnerText & vbLf
                        ElseIf blnData = True Then
                            If strCol.Contains(nod.Attributes("name").Value) = False Then
                                strCol += nod.Attributes("name").Value & "s,"
                                strVal += "'" & nod.Name & "',"
                                strOutPut += "'" & nod.Name & "',"
                                strCol += nod.Attributes("name").Value & "v,"
                                strVal += "'" & nod.InnerText & "',"
                                strOutPut += "'" & nod.InnerText & "',"
                            End If
                        End If
                    Next
                End If
            Next
            Return strOutPut
        End Function
        Private Function Get_Samples(ByVal NODE As XmlElement, ByVal DOC As XmlDocument) As String
            Dim strTemp, strOutPut As String
            For Each temp As XmlElement In NODE.ChildNodes
                If temp.Name = "Samples" Then
                    For Each nod As XmlElement In temp.ChildNodes
                        If nod.HasAttribute("subType") = True Then
                            strTemp = "-" & nod.Attributes("subType").Value
                        Else
                            strTemp = ""
                        End If
                        If blnText = True Then
                            strOutPut += nod.Attributes("name").Value & "/" & nod.InnerText & vbLf
                        ElseIf blnData = True Then
                            If strCol.Contains(nod.Attributes("name").Value) = False Then
                                strCol += nod.Attributes("name").Value & ","
                                strVal += "'" & nod.InnerText & "',"
                                strOutPut += "'" & nod.InnerText & "',"
                            End If
                        End If
                    Next
                End If
            Next
            Return strOutPut
        End Function
    End Class

    Private Sub tlSaveLogs_Click(sender As System.Object, e As System.EventArgs) Handles tlSaveLogs.Click
        Dim dir As String
        folSave.ShowDialog()
        dir = folSave.SelectedPath
        If Not String.IsNullOrEmpty(dir) Then
            If IO.Directory.Exists(dir) Then
                For Each Grp As Control In pnlSession.Controls
                    If IO.File.Exists(dir & "\" & Grp.Text.Replace(":", "_") & ".rtf") Then
                        IO.File.Delete(dir & "\" & Grp.Text.Replace(":", "_") & ".rtf")
                        Do Until IO.File.Exists(dir + "\" & Grp.Text.Replace(":", "_") & ".rtf") = False
                            Application.DoEvents()
                        Loop
                    End If
                    Dim rtb As RichTextBox = Grp.Controls(0)
                    rtb.SelectAll()
                    rtb.ForeColor = Color.Black
                    rtb.SaveFile(dir & "\" & Grp.Text.Replace(":", "_") & ".rtf")
                    rtb.ForeColor = Color.White
                Next
            End If
        End If
        MessageBox.Show("Saved!", "Successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
