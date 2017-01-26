Imports System.Windows.Forms
Imports System.Xml
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    Private MaxMDI As Integer = 20
    Public MyProc As Process = Process.GetCurrentProcess()

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Public Sub ClockSpeedCheck()
        'Working Memory / 2GB Allocated Memory
        MyProc.Refresh()
        If Not (MyProc.WorkingSet64 * 0.001) > 2000000 Then
            statMemoryUsage.Value = ((MyProc.WorkingSet64 * 0.001) / 2000000) * 100
        ElseIf (MyProc.WorkingSet64 * 0.001) < statMemoryUsage.Minimum Then
            statMemoryUsage.Value = statMemoryUsage.Minimum
        Else
            statMemoryUsage.Value = statMemoryUsage.Maximum
        End If
        Debug.WriteLine("Working Set64: " & MyProc.WorkingSet64.ToString & " (bytes)" & _
                        vbLf & "Peak Paged Memory64: " & MyProc.PeakPagedMemorySize64.ToString & " (bytes)" & _
                        vbLf & "Peak Working Set64: " & MyProc.PeakWorkingSet64.ToString & " (bytes)" & _
                        vbLf & "Paged System Memory64: " & MyProc.PagedSystemMemorySize64.ToString & " (bytes)" & _
                        vbLf & "NonPaged System Memory64: " & MyProc.NonpagedSystemMemorySize64.ToString & " (bytes)")
    End Sub

    Private m_ChildFormNumber As Integer
    Private Sub ChildCountDown()
        m_ChildFormNumber -= 1
    End Sub

    Private Sub newRealTimeGraph_Click(sender As System.Object, e As System.EventArgs) Handles newRealTimeGraph.Click
        'Add new RealTimeGraph form to the Dashboard
        '   Increment counter for controls
        'If m_ChildFormNumber > MaxMDI Then
        '    MessageBox.Show("I'm sorry, you can only have '" & (maxmdi + 1).tostring & "' Dashboard windows open at a time. Please close at least one open window to continue", "Maximum Windows", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        m_ChildFormNumber += 1
        Dim rtg As New Dashboard_Real_Time_Graph
        rtg.MdiParent = Me

        rtg.Show()
        AddHandler rtg.Disposed, AddressOf ChildCountDown
    End Sub
    Private Sub newDial_Click(sender As System.Object, e As System.EventArgs) Handles newDial.Click
        'Add new DialView form to the Dashboard
        '   Increment counter for controls
        'If m_ChildFormNumber > MaxMDI Then
        '    MessageBox.Show("I'm sorry, you can only have '" & (maxmdi + 1).tostring & "' Dashboard windows open at a time. Please close at least one open window to continue", "Maximum Windows", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        m_ChildFormNumber += 1
        Dim dil As New Dial_View
        dil.MdiParent = Me
        dil.Show()
        AddHandler dil.Disposed, AddressOf ChildCountDown
    End Sub
    Private Sub newStatus_Click(sender As System.Object, e As System.EventArgs) Handles newStatus.Click
        'Add new StatusView form to the Dashboard
        '   Increment counter for controls
        'If m_ChildFormNumber > MaxMDI Then
        '    MessageBox.Show("I'm sorry, you can only have '" & (maxmdi + 1).tostring & "' Dashboard windows open at a time. Please close at least one open window to continue", "Maximum Windows", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        m_ChildFormNumber += 1
        Dim stat As New Status_View
        stat.MdiParent = Me
        stat.Show()
        AddHandler stat.Disposed, AddressOf ChildCountDown
    End Sub
    Private Sub newOEE_Click(sender As System.Object, e As System.EventArgs) Handles newOEE.Click
        'Add new OEEView form to the Dashboard
        '   Increment counter for controls
        'If m_ChildFormNumber > MaxMDI Then
        '    MessageBox.Show("I'm sorry, you can only have '" & (maxmdi + 1).tostring & "' Dashboard windows open at a time. Please close at least one open window to continue", "Maximum Windows", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        m_ChildFormNumber += 1
        Dim o As New OEE_View
        o.MdiParent = Me
        o.Show()
        AddHandler o.Disposed, AddressOf ChildCountDown
    End Sub

    Private Sub tlControlColumns_Click(sender As System.Object, e As System.EventArgs) Handles tlControlColumns.Click
        'Sets the number of columns of User Controls to allow in each MDI child form that accepts smaller controls
        '   This is only applied to newly drawn MDI child forms
        Dim tmp As String = InputBox("Enter the number of columns of controls to display in a given view:" & vbLf & "(Changes made to new views)", "Control Column Adjustment", My.Settings.ControlColumns.ToString)
        If IsNumeric(tmp) = False Then
            MessageBox.Show("Column count MUST be an integer value!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'Check the input is greater than zero to avoid error
            If Convert.ToInt32(tmp) > 0 Then
                My.Settings.ControlColumns = Convert.ToInt32(tmp)
                tlControlColumns.Text = "Control Columns: " + tmp
                'Force each child View to relocate their child controls using the new column index
                For Each MDI As Form In Me.MdiChildren
                    Dim view As Object = MDI
                    view.Invoke(New CrossAppDomainDelegate(AddressOf view.Relocate))
                Next
            Else
                MessageBox.Show("Column count MUST be larger than 0!", "Positive Reference Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub Dashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Setup basic display for Dashboard
        tlControlColumns.Text = "Control Columns: " & My.Settings.ControlColumns.ToString
        ClockSpeedCheck()
    End Sub
    Private Sub loadDashboard_Click(sender As System.Object, e As System.EventArgs) Handles loadDashboard.Click
        Cursor = Cursors.WaitCursor
        'Load a saved session of the Dashboard by adding the controls
        Dim myXML As New XmlDocument
        myXML.Load(My.Settings.StartUp & "\XML\Dashboard_Sessions.xml")
        'Loaded Dashboard session xml file
        If myXML.SelectSingleNode("Dashboard").HasChildNodes = True Then
            For Each MDI As XmlElement In myXML.SelectSingleNode("Dashboard").ChildNodes
                'For each MDI element, determine what "type" of control is to be made
                If MDI.Name = "MDI" Then
                    'Verify correct syntax
                    Select Case MDI.Attributes("type").Value
                        Case "GRAPH"
                            If (m_ChildFormNumber + 2) > MaxMDI + 1 Then
                                Exit Select
                            End If
                            'Create a new RealTimeGraph Form
                            m_ChildFormNumber += 2
                            Dim rtg As New Dashboard_Real_Time_Graph
                            rtg.MdiParent = Me
                            rtg.Show()
                            Application.DoEvents()
                            AddHandler rtg.Disposed, AddressOf ChildCountDown
                            For Each Series As XmlElement In MDI.ChildNodes
                                'Loading each new series into the graph
                                LoadSession.AddGraph(rtg, Series)
                            Next
                        Case "DIAL190"
                            If (m_ChildFormNumber + 1) > MaxMDI + 1 Then
                                Exit Select
                            End If
                            'Create a new DailView form
                            m_ChildFormNumber += 1
                            Dim dil As New Dial_View
                            dil.MdiParent = Me
                            dil.Show()
                            Application.DoEvents()
                            AddHandler dil.Disposed, AddressOf ChildCountDown
                            For Each Dial190 As XmlElement In MDI.ChildNodes
                                'Loading each new dial User Control into the form
                                LoadSession.AddDial190(dil, Dial190)
                            Next
                        Case "STATUS"
                            If (m_ChildFormNumber + 1) > MaxMDI + 1 Then
                                Exit Select
                            End If
                            'Create a new StatusView
                            m_ChildFormNumber += 1
                            Dim stat As New Status_View
                            stat.MdiParent = Me
                            stat.Show()
                            Application.DoEvents()
                            AddHandler stat.Disposed, AddressOf ChildCountDown
                            For Each Status As XmlElement In MDI.ChildNodes
                                'Loading each new status indicator User Control into the form
                                LoadSession.AddStatus(stat, Status)
                            Next
                        Case "OEE"
                            If (m_ChildFormNumber + 2) > MaxMDI + 1 Then
                                Exit Select
                            End If
                            'Create a new OEE
                            m_ChildFormNumber += 2
                            Dim OEE As New OEE_View
                            OEE.MdiParent = Me
                            OEE.Show()
                            Application.DoEvents()
                            AddHandler OEE.Disposed, AddressOf ChildCountDown
                            For Each Status As XmlElement In MDI.ChildNodes
                                'Loading each new status indicator User Control into the form
                                LoadSession.AddOEE(OEE, Status)
                            Next
                    End Select
                    System.Threading.Thread.Sleep(5000)
                End If
            Next
        End If
        Cursor = Cursors.Default
        ClockSpeedCheck()
    End Sub

    Private Sub mnuOutputOEE_Click(sender As System.Object, e As System.EventArgs) Handles mnuOutputOEE.Click
        OEE_Report.ShowDialog()
    End Sub

    Private Sub dateView_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dateView.ValueChanged
        'Force each MDI to redraw their datatables based on the selected date and time
        If DateTime.Compare(DateTime.Parse(dateView.Value.ToString(("MM/dd/yyyy")) & " " & timeView.Value.ToString(("HH:mm:ss"))), DateTime.Now) <= 0 Then
            RefreshMDIs()
            statStatus.Text = "Finished ReDrawing controls..."
        Else
            dateView.Value = DateTime.Now
            statStatus.Text = "Cannot predict future...(Yet)"
        End If
    End Sub
    Private Sub timeView_ValueChanged(sender As System.Object, e As System.EventArgs) Handles timeView.ValueChanged
        'Force each MDI to redraw their datatables based on the selected date and time
        If DateTime.Compare(DateTime.Parse(dateView.Value.ToString(("MM/dd/yyyy")) & " " & timeView.Value.ToString(("HH:mm:ss"))), DateTime.Now) <= 0 Then
            RefreshMDIs()
            statStatus.Text = "Finished ReDrawing controls..."
        Else
            timeView.Value = DateTime.Now
            statStatus.Text = "Cannot predict future...(Yet)"
        End If
    End Sub

    Private Sub tbView_ValueChanged(sender As Object, e As System.EventArgs) Handles tbView.ValueChanged
        'Force each MDI to redraw their controls based on the index of the trackbar
        RefreshMDIs()
    End Sub
    Private Sub RefreshMDIs()
        Cursor = Cursors.WaitCursor
        For Each Child As Object In Me.MdiChildren
            Debug.WriteLine(Child.name)
            Try
                If Not Child.Busy Then
                    Child.Refresh()
                Else
                    Debug.WriteLine("Child is busy...")
                End If
            Catch ex As Exception
                Debug.WriteLine("Couldn't refresh child control: " & Child.name.ToString)
            End Try
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub btnStepForward_Click(sender As System.Object, e As System.EventArgs) Handles btnStepForward.Click
        Dim tv As DateTime = DateTime.Parse(dateView.Value.ToShortDateString & " " & timeView.Value.ToShortTimeString)
        tv = tv.AddMinutes(1)
        dateView.Value = tv
        timeView.Value = tv
        tbView.Value = tbView.Minimum
    End Sub
    Private Sub btnSkipForward_Click(sender As System.Object, e As System.EventArgs) Handles btnSkipForward.Click
        Dim tv As DateTime = DateTime.Parse(dateView.Value.ToShortDateString & " " & timeView.Value.ToShortTimeString)
        tv = tv.AddHours(1)
        dateView.Value = tv
        timeView.Value = tv
        tbView.Value = tbView.Minimum
    End Sub
    Private Sub btnStepBack_Click(sender As System.Object, e As System.EventArgs) Handles btnStepBack.Click
        Dim tv As DateTime = DateTime.Parse(dateView.Value.ToShortDateString & " " & timeView.Value.ToShortTimeString)
        tv = tv.AddMinutes(-1)
        dateView.Value = tv
        timeView.Value = tv
        tbView.Value = tbView.Minimum
    End Sub
    Private Sub btnSkipBack_Click(sender As System.Object, e As System.EventArgs) Handles btnSkipBack.Click
        Dim tv As DateTime = DateTime.Parse(dateView.Value.ToShortDateString & " " & timeView.Value.ToShortTimeString)
        tv = tv.AddHours(-1)
        dateView.Value = tv
        timeView.Value = tv
        tbView.Value = tbView.Minimum
    End Sub
End Class
Module LoadSession
    Public Sub AddGraph(ByVal DASH As Dashboard_Real_Time_Graph, ByVal MDI As XmlElement)
        Try
            'Declare a new series for the associated MDI child form
            Dim newSeries As New Series
            newSeries.Name = MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
            newSeries.ChartType = SeriesChartType.Line
            newSeries.ChartArea = "Main"
            newSeries.Tag = MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText & "|" + MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText & "|" & MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
            newSeries.LegendText = MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText & "_" & MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
            DASH.Chart1.Series.Add(newSeries)
        Catch ex As Exception
            Local_Functions.Log("(Dashboard_Real-Time Graph_Add Series){DataFile=" & MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText & ", Table=" & MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText & ", Column=" & MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText & "}[Add Series] ERROR = " & ex.Message)
            MessageBox.Show("An error occurred while attempting to add new series..." & vbLf & "Review the Error Log for more details", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Get Watch Name to get proper Probe Unit types
        Dim myProbe As New XmlDocument
        myProbe.Load(My.Settings.StartUp + "\XML\Watch_Sessions.xml")
        Dim tmpName As String = Nothing
        Try
            For Each WATCH As XmlElement In myProbe.SelectSingleNode("sessions").ChildNodes
                If WATCH.SelectSingleNode("output").Attributes("type").Value = "mdb" Then
                    If WATCH.SelectSingleNode("output").SelectSingleNode("file").InnerText = MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText And WATCH.SelectSingleNode("output").SelectSingleNode("action").InnerText = MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText Then
                        tmpName = WATCH.SelectSingleNode("name").InnerText
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            Local_Functions.Log("(Dashboard_Real-Time Graph_Add Series){DataFile=" & MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText & ", Table=" & MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText & ", Column=" & MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText & "}[Get Watch Name] ERROR = " & ex.Message)
            MessageBox.Show("An error occurred while attempting to get a matching watcher..." & vbLf & "Review the Error Log for more details", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Get Probe Data Types for the User Control ProbeDataType
        '   This control helps filter the contents of each series
        Try
            If String.IsNullOrEmpty(tmpName) = False Then
                myProbe.Load(My.Settings.StartUp & "\XML\Probe_Data-Types.xml")
                'Load the Probe Data compiled when the program started
                For Each PROBE As XmlElement In myProbe.SelectSingleNode("ProbeDataTypes").ChildNodes
                    If PROBE.Attributes("name").Value = tmpName Then
                        For Each DATAITEM As XmlElement In PROBE.ChildNodes
                            If DATAITEM.Attributes("name").Value = MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText Then
                                Dim splt As SplitContainer = DASH.Controls("SplitContainer1")
                                Dim prbData As New ProbeDataType
                                prbData.Name = MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
                                prbData.SourceName = MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText & " - " & MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
                                prbData.OleDbColumn = MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
                                prbData.OleDbFile = MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText
                                prbData.OleDbPassword = MDI.SelectSingleNode("Data").SelectSingleNode("Password").InnerText
                                prbData.OleDbTable = MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText
                                prbData.OleDbUser = MDI.SelectSingleNode("Data").SelectSingleNode("User").InnerText
                                prbData.OleDbProvider = Local_Functions.GetOleDbProvider(prbData.OleDbFile)
                                prbData.OleDbConnection = Local_Functions.CompileOleDbConnectionString(prbData.OleDbProvider, prbData.OleDbFile, prbData.OleDbUser, prbData.OleDbPassword)
                                prbData.OleDbPrimaryKey = Local_Functions.GetPrimaryKeyName(prbData.OleDbConnection, prbData.OleDbTable)
                                Select Case DATAITEM.Attributes("units").Value
                                    Case "null"
                                        prbData.Units = Nothing
                                    Case "MILLIMETER"
                                        prbData.Units = "mm"
                                    Case "PERCENT"
                                        prbData.Units = "%"
                                    Case "MILLIMETER/SECOND"
                                        prbData.Units = "mm/sec"
                                    Case "DEGREE/SECOND"
                                        prbData.Units = "°/sec"
                                    Case "REVOLUTION/MINUTE"
                                        prbData.Units = "rpm"
                                    Case "CELSIUS"
                                        prbData.Units = "C°"
                                    Case "DEGREE"
                                        prbData.Units = "°"
                                End Select
                                Select Case DATAITEM.Attributes("cat").Value
                                    Case "CONDITION"
                                        prbData.Category = "Condition"
                                    Case "SAMPLE"
                                        prbData.Category = "Sample"
                                    Case "EVENT"
                                        prbData.Category = "Event"
                                End Select
                                Select Case DATAITEM.Attributes("type").Value
                                    Case "ACTUATOR"
                                        prbData.DataItemType = "Actuator Condition"
                                    Case "POSITION"
                                        prbData.DataItemType = "Position"
                                    Case "LOAD"
                                        prbData.DataItemType = "Load"
                                    Case "AXIS_FEEDRATE"
                                        prbData.DataItemType = "Axis Feedrate"
                                    Case "SPINDLE_SPEED"
                                        prbData.DataItemType = "Spindle Speed"
                                    Case "TEMPERATURE"
                                        prbData.DataItemType = "Temperature"
                                    Case "ANGLE"
                                        prbData.DataItemType = "Angle Position"
                                    Case "ROTARY_MODE"
                                        prbData.DataItemType = "Mode of Rotary Axis"
                                    Case "ANGULAR_VELOCITY"
                                        prbData.DataItemType = "Angular Velocity"
                                    Case "LOGIC_PROGRAM"
                                        prbData.DataItemType = ""
                                    Case "SYSTEM"
                                        prbData.DataItemType = "System Data"
                                    Case "EMERGENCY_STOP"
                                        prbData.DataItemType = "E-Stop Condition"
                                    Case "PROGRAM"
                                        prbData.DataItemType = "CNC Program Data"
                                    Case "LINE"
                                        prbData.DataItemType = ""
                                    Case "x:UNIT"
                                        prbData.DataItemType = ""
                                    Case "x:SEQUENCE_NUMBER"
                                        prbData.DataItemType = "Process Sequence Number"
                                    Case "PART_COUNT"
                                        prbData.DataItemType = "System Part Count"
                                    Case "PATH_FEEDRATE"
                                        prbData.DataItemType = "Feedrate Data"
                                    Case "TOOL_ID"
                                        prbData.DataItemType = "Selected Tool Data"
                                    Case "x:TOOL_GROUP"
                                        prbData.DataItemType = "Selected Tool Group"
                                    Case "x:TOOL_SUFFIX"
                                        prbData.DataItemType = "Selected Tool Suffix"
                                    Case "EXECUTION"
                                        prbData.DataItemType = "Execution State"
                                    Case "CONTROLLER_MODE"
                                        prbData.DataItemType = "Controller State"
                                    Case "MESSAGE"
                                        prbData.DataItemType = "Available Message"
                                    Case "x:DURATION"
                                        prbData.DataItemType = "System Duration"
                                    Case "MOTION_PROGRAM"
                                        prbData.DataItemType = ""
                                    Case "POWER_STATE"
                                        prbData.DataItemType = "Machine Power State"
                                    Case "PRESSURE"
                                        prbData.DataItemType = "Component Pressure Data"
                                    Case "LEVEL"
                                        prbData.DataItemType = "Component Fill Level Data"
                                    Case "COMMUNICATIONS"
                                        prbData.DataItemType = "System Communications Data"
                                End Select
                                prbData.Dock = DockStyle.Left
                                splt.Panel2.Controls.Add(prbData)
                                splt.Panel2.Controls.SetChildIndex(prbData, 0)
                                Exit For
                            End If
                        Next
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            Local_Functions.Log("(Dashboard_Real-Time Graph_Add Series){DataFile=" & MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText & ", Table=" & MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText & ", Column=" & MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText & "}[Get Probe Data Types] ERROR = " & ex.Message)
            MessageBox.Show("An error occurred while attempting to get the data types..." & vbLf & "Review the Error Log for more details", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub AddDial190(ByVal DASH As Dial_View, ByVal MDI As XmlElement)
        Dim d As New Dial_190
        d.Tag = MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText & "|" & MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText & "|" & MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
        d.Name = MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
        d.DataName = MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
        d.OleDbColumn = MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
        d.OleDbTable = MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText
        d.OleDbFile = MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText
        d.OleDbUser = MDI.SelectSingleNode("Data").SelectSingleNode("User").InnerText
        d.OleDbPassword = MDI.SelectSingleNode("Data").SelectSingleNode("Password").InnerText
        d.OleDbProvider = Local_Functions.GetOleDbProvider(d.OleDbFile)
        d.OleDbConnection = Local_Functions.CompileOleDbConnectionString(d.OleDbProvider, d.OleDbFile, d.OleDbUser, d.OleDbPassword)
        d.OleDbPrimaryKey = Local_Functions.GetPrimaryKeyName(d.OleDbConnection, d.OleDbTable)

        Dim cnt As Integer = DASH.pnlView.Controls.Count
        Dim r, c As Integer
        For Each cntrl As Control In DASH.pnlView.Controls
            If c = My.Settings.ControlColumns Then
                c = -1
                r += 1
            End If
            c += 1
        Next
        d.Location = New Point((350 * (c)), (200 * r) + 30)
        d.Size = New Size(350, 200)
        DASH.pnlView.Controls.Add(d)
    End Sub
    Public Sub AddStatus(ByVal DASH As Status_View, ByVal MDI As XmlElement)
        Dim d As New Status_Indicator
        d.OleDbFile = MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText
        d.OleDbTable = MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText
        d.OleDbColumn = MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
        d.OleDbProvider = Local_Functions.GetOleDbProvider(d.OleDbFile)
        d.OleDbConnection = Local_Functions.CompileOleDbConnectionString(d.OleDbPrimaryKey, d.OleDbFile)
        d.OleDbPrimaryKey = Local_Functions.GetPrimaryKeyName(d.OleDbConnection, d.OleDbTable)
        d.Name = MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
        d.DataName = MDI.SelectSingleNode("Data").SelectSingleNode("Column").InnerText
        Dim i As Integer = 1
        For Each stat As XmlElement In MDI.SelectSingleNode("Values").ChildNodes
            If String.IsNullOrEmpty(stat.InnerText) = False Then
                d.AddStatusValue(stat.InnerText, GetIndicatorColor(i - 1))
            End If
            i += 1
        Next
        d.TextColor = Color.FromArgb(Convert.ToInt32(MDI.SelectSingleNode("TextColor").SelectSingleNode("R").InnerText), Convert.ToInt32(MDI.SelectSingleNode("TextColor").SelectSingleNode("G").InnerText), Convert.ToInt32(MDI.SelectSingleNode("TextColor").SelectSingleNode("B").InnerText))
        Dim cnt As Integer = DASH.pnlView.Controls.Count
        Dim r, c As Integer
        For Each cntrl As Control In DASH.pnlView.Controls
            If c = My.Settings.ControlColumns Then
                c = -1
                r += 1
            End If
            c += 1
        Next
        d.Location = New Point((200 * (c)), (200 * r) + 30)
        d.Size = New Size(200, 200)
        DASH.pnlView.Controls.Add(d)
    End Sub
    Public Sub AddOEE(ByVal DASH As OEE_View, ByVal MDI As XmlElement)
        If Not String.IsNullOrEmpty(MDI.SelectSingleNode("WorkCenterNumber").InnerText) Then
            Dim o As New OEE
            o.OleDbFile = MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText
            o.OleDbTable = MDI.SelectSingleNode("Data").SelectSingleNode("Table").InnerText
            If Not IsNothing(MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText) And Not String.IsNullOrEmpty(MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText) Then
                o.OleDbProvider = Local_Functions.GetOleDbProvider(MDI.SelectSingleNode("Data").SelectSingleNode("Base").InnerText)
                o.OleDbConnection = Local_Functions.CompileOleDbConnectionString(o.OleDbProvider, o.OleDbFile, o.OleDbUser, o.OleDbPassword)
            End If
            Dim wc As String = MDI.SelectSingleNode("WorkCenterNumber").InnerText
            o.Name = wc
            o.WorkCenter = wc
            If String.IsNullOrEmpty(MDI.SelectSingleNode("WorkCenterName").InnerText) Then
                o.WorkCenterName = getWCName(o)
            Else
                o.WorkCenterName = MDI.SelectSingleNode("WorkCenterName").InnerText
            End If


            Dim cnt As Integer = DASH.pnlView.Controls.Count
            Debug.WriteLine("DASHBOARD Control Count=" + cnt.ToString)
            Dim r, c As Integer
            For Each cntrl As Control In DASH.pnlView.Controls
                If c = My.Settings.ControlColumns Then
                    c = -1
                    r += 1
                End If
                c += 1
            Next

            o.Location = New Point((200 * (c)), (326 * r) + 30)
            o.Size = New Size(200, 326)
            Try
                DASH.pnlView.Controls.Add(o)
            Catch ex As Exception
                Debug.WriteLine("Failed to add OEE" & ex.Message)
            End Try
        End If
    End Sub

    Private Function GetIndicatorColor(ByVal IndicatorColor As Integer) As Status_Indicator.Color
        Select Case IndicatorColor
            Case 0
                Return Status_Indicator.Color.Green
            Case 1
                Return Status_Indicator.Color.Cyan
            Case 2
                Return Status_Indicator.Color.Blue
            Case 3
                Return Status_Indicator.Color.Violet
            Case 4
                Return Status_Indicator.Color.Yellow
            Case 5
                Return Status_Indicator.Color.Red
            Case Else
                Return 0
        End Select
    End Function
End Module