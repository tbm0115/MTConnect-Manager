Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Imports System.Data.OleDb
Imports System.Xml

Public Class Real_Time_Graph_Add_Series
    Private graph As Chart
    Private dash As Form
    Private _CNN As String
    Property Chart() As Chart
        Get
            Return graph
        End Get
        Set(value As Chart)
            graph = value
        End Set
    End Property
    Property Dashboard() As Dashboard_Real_Time_Graph
        Get
            Return dash
        End Get
        Set(value As Dashboard_Real_Time_Graph)
            dash = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If String.IsNullOrEmpty(txtDatabase.Text) = True Or String.IsNullOrEmpty(txtTable.Text) = True Or String.IsNullOrEmpty(txtColumn.Text) = True Then
            MessageBox.Show("You must fill out all information to continue...", "Not enough information available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If IO.File.Exists(txtDatabase.Text) = False Then
            MessageBox.Show("The database you've entered does not exists..." + vbLf + "Please provide a filepath that exists.", "File doesn't exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDatabase.Focus()
            txtDatabase.SelectAll()
            Exit Sub
        End If
        For Each s As Series In graph.Series
            If txtColumn.Text = s.Name Then
                MessageBox.Show("Series has already been added...", "Cannot add duplicate series", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next
        Try
            Dim newSeries As New Series
            newSeries.Name = txtColumn.Text
            newSeries.ChartType = SeriesChartType.Line
            newSeries.ChartArea = "Main"
            newSeries.Tag = txtDatabase.Text + "|" + txtTable.Text + "|" + txtColumn.Text
            newSeries.LegendText = txtTable.Text + "_" + txtColumn.Text
            'newSeries.Points.Add(0, 0)
            graph.Series.Add(newSeries)
        Catch ex As Exception
            Local_Functions.Log("(Dashboard_Real-Time Graph_Add Series){DataFile=" + txtDatabase.Text + ", Table=" + txtTable.Text + ", Column=" + txtColumn.Text + "}[Add Series] ERROR = " + ex.Message)
            MessageBox.Show("An error occurred while attempting to add new series..." + vbLf + "Review the Error Log for more details", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Get Watch Name to get proper Probe Unit types
        Dim myProbe As New XmlDocument
        myProbe.Load(My.Settings.StartUp + "\XML\Watch_Sessions.xml")
        Dim tmpName As String = Nothing
        Try
            For Each WATCH As XmlElement In myProbe.SelectSingleNode("sessions").ChildNodes
                If WATCH.SelectSingleNode("output").Attributes("type").Value = "mdb" Then
                    If WATCH.SelectSingleNode("output").SelectSingleNode("file").InnerText = txtDatabase.Text And WATCH.SelectSingleNode("output").SelectSingleNode("action").InnerText = txtTable.Text Then
                        tmpName = WATCH.SelectSingleNode("name").InnerText
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            Local_Functions.Log("(Dashboard_Real-Time Graph_Add Series){DataFile=" + txtDatabase.Text + ", Table=" + txtTable.Text + ", Column=" + txtColumn.Text + "}[Get Watch Name] ERROR = " + ex.Message)
            MessageBox.Show("An error occurred while attempting to get a matching watcher..." + vbLf + "Review the Error Log for more details", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Get Probe Data Types
        If String.IsNullOrEmpty(tmpName) = False Then
            myProbe.Load(My.Settings.StartUp + "\XML\Probe_Data-Types.xml")
            For Each PROBE As XmlElement In myProbe.SelectSingleNode("ProbeDataTypes").ChildNodes
                If PROBE.Attributes("name").Value = tmpName Then
                    For Each DATAITEM As XmlElement In PROBE.ChildNodes
                        If DATAITEM.Attributes("name").Value = txtColumn.Text Then
                            Dim pnl As Panel = dash.Controls.Find("pnlProbeContainer", True).First
                            Dim prbData As New ProbeDataType
                            prbData.OleDbFile = txtDatabase.Text
                            prbData.OleDbTable = txtTable.Text
                            prbData.OleDbColumn = txtColumn.Text
                            prbData.OleDbProvider = Local_Functions.GetOleDbProvider(txtDatabase.Text)
                            prbData.OleDbConnection = _CNN
                            prbData.OleDbPrimaryKey = Local_Functions.GetPrimaryKeyName(_CNN, txtTable.Text)
                            prbData.Name = txtColumn.Text
                            prbData.SourceName = txtTable.Text + " - " + txtColumn.Text
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
                            pnl.Controls.Add(prbData)
                            pnl.Controls.SetChildIndex(prbData, 0)
                            Dashboard.Refresh()
                            Exit For
                        End If
                    Next
                    Exit For
                End If
            Next
        End If

        Debug.WriteLine("Series Added" + vbLf + vbTab + "FILE=" + txtDatabase.Text + vbLf + vbTab + "TABLE=" + txtTable.Text + vbLf + vbTab + "COLUMN=" + txtColumn.Text)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnFileOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnFileOpen.Click
        filOpen.Filter = "MS Access Database 2003 (*.mdb)|*.mdb"
        filOpen.FilterIndex = 1
        filOpen.ShowDialog()
        If IO.File.Exists(filOpen.FileName) = True Then
            txtDatabase.Text = Local_Functions.GetUNCPath(filOpen.FileName)
        End If
    End Sub

    Private Sub txtDatabase_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDatabase.TextChanged
        If IO.File.Exists(txtDatabase.Text) = True Then
            txtTable.Items.Clear()
            Dim cn As New OleDbConnection()
            Dim schemaTable As DataTable
            Dim i As Integer


            Dim u, p, prov As String
            'Check if database is password protected. If so, then prompt for Username and Password
            prov = Local_Functions.GetOleDbProvider(txtDatabase.Text)
            If Local_Functions.OleDbSecurityExists(txtDatabase.Text) = True Then
                u = InputBox("Enter the UserName available for this file (if there is a required UserName):" + vbLf + txtDatabase.Text, "Database Credentials")
                p = InputBox("Enter the Password available for this file (if there is a required Password):" + vbLf + txtDatabase.Text, "Database Credentials")
                If Local_Functions.OleDbSecurityTest(txtDatabase.Text, u, p, prov) = False Then
                    MessageBox.Show("It appears that the credentials you provided were incorrect! Please review the credentials for this file and reselect the file to try again." + vbLf + "Provided Credentials:" + vbLf + "UserName=" + u + vbLf + "Password=" + p + vbLf + "File=" + txtDatabase.Text, "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtDatabase.Text = Nothing
                    Exit Sub
                End If
            End If
            _CNN = Local_Functions.CompileOleDbConnectionString(prov, txtDatabase.Text, u, p)
            cn.ConnectionString = _CNN
            Debug.WriteLine("Connection String=" + _CNN)
            'Be sure to use an account that has permission to list tables.
            cn.Open()

            'Retrieve schema information about tables.
            'Because tables include tables, views, and other objects,
            'restrict to just TABLE in the Object array of restrictions.
            schemaTable = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, _
                          New Object() {Nothing, Nothing, Nothing, "TABLE"})

            'List the table name from each row in the schema table.
            For i = 0 To schemaTable.Rows.Count - 1
                txtTable.Items.Add(schemaTable.Rows(i)!TABLE_NAME.ToString)
            Next i

            'Explicitly close - don't wait on garbage collection.
            cn.Close()
            txtTable.Enabled = True
            If txtTable.Items.Count = 1 Then
                txtTable.SelectedIndex = 0
            End If
        Else
            txtTable.Enabled = False
            txtColumn.Enabled = False
        End If
    End Sub

    Private Sub txtTable_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtTable.SelectedIndexChanged
        If txtTable.SelectedIndex = -1 Then
            txtColumn.Enabled = False
            Exit Sub
        End If
        Dim cn As New OleDbConnection()
        Dim schemaTable As DataTable
        Dim i As Integer
        Dim myXML As New XmlDocument
        myXML.Load(My.Settings.StartUp + "\XML\Probe_Data-Types.xml")

        cn.ConnectionString = _CNN
        cn.Open()

        'Retrieve schema information about columns.
        schemaTable = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, _
                      New Object() {Nothing, Nothing, txtTable.Text, Nothing})

        txtColumn.Items.Clear()
        Dim blnFound As Boolean
        'List the column name from each row in the schema table.
        For i = 0 To schemaTable.Rows.Count - 1
            'txtColumn.Items.Add(schemaTable.Rows(i)!COLUMN_NAME.ToString)
            'Reset flag
            blnFound = False
            For Each NODE As XmlElement In myXML.SelectSingleNode("ProbeDataTypes").ChildNodes
                For Each cNODE As XmlElement In NODE.ChildNodes
                    If cNODE.HasAttribute("name") Then
                        'If contains, because conditions have appended column names of 's' and 'v' for status and value
                        If (schemaTable.Rows(i)!COLUMN_NAME.ToString = (cNODE.Attributes("name").Value)) Or (schemaTable.Rows(i)!COLUMN_NAME.ToString = (cNODE.Attributes("name").Value) & "s") Or (schemaTable.Rows(i)!COLUMN_NAME.ToString = (cNODE.Attributes("name").Value) & "v") Then
                            If cNODE.HasAttribute("units") Then
                                If Not cNODE.Attributes("units").Value.ToString.ToUpper = "NULL" Then
                                    txtColumn.Items.Add(schemaTable.Rows(i)!COLUMN_NAME.ToString)
                                    blnFound = True
                                    Exit For
                                End If
                            End If
                        End If
                    End If
                Next
                If blnFound Then
                    Exit For
                End If
            Next
        Next i

        'Explicitly close - don't wait on garbage collection.
        cn.Close()
        txtColumn.Enabled = True
    End Sub

    Private Sub Real_Time_Graph_Add_Series_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IO.File.Exists(My.Settings.strDefDatFile) Then
            txtDatabase.Text = My.Settings.strDefDatFile
        End If
    End Sub
End Class
