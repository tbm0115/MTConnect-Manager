Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Threading

Public Class Dashboard_Real_Time_Graph
    Dim Cnn As New OleDbConnection
    Dim Cmd As New OleDbCommand
    Dim Reader As OleDbDataReader
    'Dim dispatcherTimer As DispatcherTimer
    Public Busy As Boolean
    Public blnUseSameConnection As Integer = 2
    Private db As String
    Private _clockspeed As Integer
    Public sDate, sTime As String

    Public ReadOnly Property ProcessSpeed As Integer
        Get
            Return _clockspeed
        End Get
    End Property

    Private Sub seriesAdd_Click(sender As System.Object, e As System.EventArgs) Handles seriesAdd.Click
        Real_Time_Graph_Add_Series.Chart = Me.Chart1
        Real_Time_Graph_Add_Series.Dashboard = Me
        Real_Time_Graph_Add_Series.ShowDialog()
    End Sub
    Private Sub seriesRemove_Click(sender As System.Object, e As System.EventArgs) Handles seriesRemove.Click
        RefreshTimer.Stop()
        Real_Time_Graph_Remove_Series.Chart = Me.Chart1
        Real_Time_Graph_Remove_Series.Dashboard = Me
        Real_Time_Graph_Remove_Series.ShowDialog()
        RefreshTimer.Start()
    End Sub

    'Private Sub Dashboard_Real_Time_Graph_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    dispatcherTimer.Stop()
    'End Sub
    Private Sub Dashboard_Real_Time_Graph_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Chart1.Series.Clear()
            'timeRange.ToolTipText = "Min=" & rangeMin.ToString & vbTab & "Max=" & rangeMax.ToString
            Chart1.ChartAreas(0).AxisX.Minimum = 0
            Chart1.ChartAreas(0).AxisX.Maximum = My.Settings.intMaxRec

            sDate = Dashboard.dateView.Value.ToString(("MM/dd/yyyy"))
            sTime = Dashboard.timeView.Value.ToString(("HH:mm.ss"))
            Debug.WriteLine("Real-Time Graph DateTime: " & sDate & " " & sTime)
            'InitializeTimer()
        Catch ex As Exception
            Local_Functions.Log("(Dashboard_Real-Time Graph){RangeMax=" & My.Settings.intMaxRec.ToString & "}[Load Form] ERROR = " & ex.Message)
            MessageBox.Show("An error occurred while attempting to load a new form..." & vbLf & "Review the Error Log for more details", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViewListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewListToolStripMenuItem.Click
        Dim cntSeries As Integer = Chart1.Series.Count
        Dim i As Integer
        'Dim message As String = ""
        Dim message As System.Text.StringBuilder
        For Each s As Series In Chart1.Series
            i += 1
            message.Append(i.ToString & "/" & cntSeries.ToString & vbTab & s.LegendText & vbLf)
        Next
        MessageBox.Show(message.ToString, "Series List", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Sub Refresh()
        Busy = True
        'Get most current DateTime
        sDate = Dashboard.dateView.Value.ToString(("MM/dd/yyyy"))
        sTime = Dashboard.timeView.Value.ToString(("HH:mm:ss"))
        Debug.WriteLine(sTime)
        Dim log(0 To 2) As String
        Dim prb As ProbeDataType
        Dim FILE As String
        Dim TABLE As String
        Dim COLUMN As String
        Dim MULTIPLY As Double
        Dim i As Integer
        Dim l, h, y As Double
        'Used to clock the process
        Dim tim As New Stopwatch
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

        If Chart1.Series.Count > 0 Then
            l = 0
            h = 0
            'Update each series in chart
            For Each s As Series In Chart1.Series
                'Get Column name from tag, this is used to find the Probe control
                COLUMN = s.Tag.ToString.Remove(0, s.Tag.ToString.LastIndexOf("|") + 1)
                'Find the probe control using the column name
                prb = pnlProbeContainer.Controls(COLUMN)
                'verify we found the probe
                If Not IsNothing(prb) Then
                    'get database information to avoid overuse of the Probe controls properties... Speeds up process a bit
                    FILE = prb.OleDbFile
                    TABLE = prb.OleDbTable
                    MULTIPLY = 1

                    log(0) = FILE
                    log(1) = TABLE
                    log(2) = COLUMN

                    'delete all existing points in chart
                    s.Points.Clear()

                    '------- SHARED CONNECTION VERIFICATION
                    '   Determine whether or not all controls in this View share the same connection string
                    '       if so, then save the connection string to "db" and leave the connection open
                    '           otherwise, open the new connection according to the Probe controls properties
                    '       If bln=2 then this view is either new or there is an error in keeping a value in "db"
                    '       If bln=0 then a shared connection string doesn't exist, so we have to recompile the connection string
                    If blnUseSameConnection = 2 Then
                        If Not String.IsNullOrEmpty(prb.OleDbConnection) Then
                        Else
                            prb.OleDbConnection = Local_Functions.CompileOleDbConnectionString(prb.OleDbProvider, prb.OleDbFile, prb.OleDbUser, prb.OleDbPassword)
                            If Not IsNothing(Cnn) Then
                                If Not prb.OleDbConnection = Cnn.ConnectionString Then
                                    MessageBox.Show("Warning! Accessing different databases within a single view can slow your computer. To avoid this, open a new view window for each database connection", "Memory Usage Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    blnUseSameConnection = 0
                                End If
                            End If
                        End If
                        db = prb.OleDbConnection
                        Cnn = New OleDbConnection(db)
                        Cnn.Open()
                    ElseIf blnUseSameConnection = 0 Then
                        'Reduce the number of times we compile the connection string by verifying it already exists
                        If String.IsNullOrEmpty(prb.OleDbConnection) Then
                            prb.OleDbConnection = Local_Functions.CompileOleDbConnectionString(prb.OleDbProvider, prb.OleDbFile, prb.OleDbUser, prb.OleDbPassword)
                        End If
                        db = prb.OleDbConnection
                        Cnn = New OleDbConnection(db)
                        Cnn.Open()
                    End If
                    '--------- END SHARED CONNECTION VERIFICATION

                    'Get data from whatever database
                    'Cmd = New OleDbCommand("SELECT " & COLUMN & " FROM (SELECT TOP " & rangeMax.ToString & " * FROM " & TABLE & " ORDER BY " & prb.OleDbPrimaryKey & " DESC) ORDER BY " & prb.OleDbPrimaryKey & " ASC;", Cnn)
                    Cmd = New OleDbCommand("SELECT " & COLUMN & ",logDate,logTime FROM " & TABLE & " WHERE logDate='" & sDate & "' ORDER BY " & prb.OleDbPrimaryKey & " ASC;", Cnn)
                    Reader = Cmd.ExecuteReader
                    i = 0
                    'Create a series point for each record that was returned from database connection
                    Dim blnBegin As Boolean = False
                    Dim tbCount As Integer = 0
                    For Each record As IDataRecord In Reader
                        If Not blnBegin Then
                            If DateTime.Compare(DateTime.Parse(record.Item("logDate").ToString & " " & record.Item("logTime").ToString.Replace(".", ":")), DateTime.Parse(sDate & " " & sTime.ToString)) >= 0 Then
                                Dashboard.lblFirstDT.Text = sDate & " " & sTime.ToString
                                'Dashboard.lblSelectedTime.Text = record.Item("logDate").ToString & " " & record.Item("logTime").ToString.Replace(".", ":")
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

                        If IsNumeric(record.Item(COLUMN).ToString) And blnBegin And tbCount > Dashboard.tbView.Value And i <= My.Settings.intMaxRec Then
                            y = Nothing
                            'Convert (as necessary) the record according to setting in Probe control
                            Select Case prb.cmbConvertRatio.Text
                                Case "Inches to mm"
                                    y = ConvertValue.InchesTomm(Convert.ToDouble(record.Item(COLUMN).ToString))
                                Case "mm to Inches"
                                    y = ConvertValue.mmToInches(Convert.ToDouble(record.Item(COLUMN).ToString))
                                Case "Farenheit to Celsius"
                                    y = ConvertValue.FahrenheitToCelsius(Convert.ToDouble(record.Item(COLUMN).ToString))
                                Case "Celsius to Farenheit"
                                    y = ConvertValue.CelsiusToFahrenheit(Convert.ToDouble(record.Item(COLUMN).ToString))
                                Case Else
                                    y = Convert.ToDouble(record.Item(COLUMN).ToString)
                            End Select
                            If y < l Or l = Nothing Then
                                l = y
                            End If
                            If Convert.ToDouble(record.Item(COLUMN).ToString) > h Or h = Nothing Then
                                h = y
                            End If
                            'add record to the series
                            s.Points.AddXY(record.Item("logTime"), y)
                            's.Points.Add(New DataPoint(i, y))
                            i += 1
                        End If
                    Next
                    Dashboard.tbView.Minimum = 0
                    Dashboard.tbView.Maximum = tbCount

                    Debug.WriteLine(i.ToString & " records found")
                    'close/dispose every new series to speed up process
                    Reader.Close()
                    Cmd.Dispose()

                    'if there are no shared connections, then close/dispose the connection also
                    '   if connection is shared, leave it open to speed up process.
                    If blnUseSameConnection = 0 Then
                        Cnn.Close()
                        Cnn.Dispose()
                    End If
                    s.BorderWidth = 5
                End If
            Next
            'Close the connection string if it hasn't already
            '   if the logic was indecisive, then assume that it is true now
            If Chart1.Series.Count > 1 Then
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

            'Provide feedback to Dashboard for process speed
            _clockspeed = CInt(tim.ElapsedMilliseconds)
            Dim dash As Dashboard = Me.MdiParent
            dash.Invoke(New CrossAppDomainDelegate(AddressOf dash.ClockSpeedCheck))
            tim.Stop()

            'Fix range if range is 0
            If l = h Then
                Chart1.ChartAreas("Main").AxisY.Minimum = l - 2
                Chart1.ChartAreas("Main").AxisY.Maximum = h + 2
            Else
                Chart1.ChartAreas("Main").AxisY.Minimum = l - ((h - l) * 0.1)
                Chart1.ChartAreas("Main").AxisY.Maximum = h + ((h - l) * 0.1)
            End If
        Else
            Dashboard.statStatus.Text = "No series to load..."
        End If
        Debug.WriteLine(vbTab & "Graph-Redrew:" & tim.ElapsedMilliseconds.ToString)
        Busy = False
    End Sub

    Private Sub saveImage_Click(sender As System.Object, e As System.EventArgs) Handles saveImage.Click
        RefreshTimer.Stop()
        ' Sets the current file name filter string, which determines 
        ' the choices that appear in the "Save as file type" or 
        ' "Files of type" box in the dialog box.
        filSave.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif|All Image Types (*)|*.bmp;*.jpg;*.emf;*.png;*.gif;*.tif"
        filSave.FilterIndex = 2
        filSave.RestoreDirectory = True

        ' Set image file format
        If filSave.ShowDialog() = DialogResult.OK Then
            Dim format As ChartImageFormat = ChartImageFormat.Bmp

            If filSave.FileName.EndsWith("bmp") Then
                format = ChartImageFormat.Bmp
            Else
                If filSave.FileName.EndsWith("jpg") Then
                    format = ChartImageFormat.Jpeg
                Else
                    If filSave.FileName.EndsWith("emf") Then
                        format = ChartImageFormat.Emf
                    Else
                        If filSave.FileName.EndsWith("gif") Then
                            format = ChartImageFormat.Gif
                        Else
                            If filSave.FileName.EndsWith("png") Then
                                format = ChartImageFormat.Png
                            Else
                                If filSave.FileName.EndsWith("tif") Then
                                    format = ChartImageFormat.Tiff
                                End If
                            End If ' Save image
                        End If
                    End If
                End If
            End If
            Chart1.SaveImage(filSave.FileName, format)
            RefreshTimer.Start()
            Process.Start(filSave.FileName)
        End If
    End Sub
    Private Sub saveCSV_Click(sender As System.Object, e As System.EventArgs) Handles saveCSV.Click
        RefreshTimer.Stop()
        ' Sets the current file name filter string, which determines 
        ' the choices that appear in the "Save as file type" or 
        ' "Files of type" box in the dialog box.
        filSave.Filter = "Comma Separated Values (*.csv)|*.csv"
        filSave.FilterIndex = 1
        filSave.RestoreDirectory = True
        filSave.ShowDialog()

        If String.IsNullOrEmpty(filSave.FileName) Or Not filSave.FileName.Contains("\") = False Then
            Exit Sub
        End If
        If IO.Directory.Exists(filSave.FileName.Remove(filSave.FileName.LastIndexOf("\"))) Then
            Dim LINES(0 To My.Settings.intMaxRec) As String
            Dim i As Integer
            For Each s As Series In Chart1.Series
                i = 0
                LINES(0) += s.Name + ","
                For Each p As DataPoint In s.Points
                    i += 1
                    LINES(i) += p.GetValueByName("Y").ToString + ","
                Next
            Next
            If IO.File.Exists(filSave.FileName) Then
                IO.File.Delete(filSave.FileName)
                Cursor = Cursors.WaitCursor
                Do Until IO.File.Exists(filSave.FileName) = False
                    Application.DoEvents()
                Loop
                Cursor = Cursors.Default
            End If
            For Each l As String In LINES
                IO.File.AppendAllText(filSave.FileName, l.Remove(l.LastIndexOf(",")) + vbLf)
            Next
        End If

        RefreshTimer.Start()
        Process.Start(filSave.FileName)
    End Sub

    Private Sub SplitContainer1_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer1.MouseDoubleClick
        SplitContainer1.Panel2Collapsed = True
        toggleDataPane.Checked = False
    End Sub
    Private Sub Chart1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Chart1.MouseClick
        Dim pos = e.Location
        pos = New Point(Chart1.ChartAreas("Main").AxisX.PixelPositionToValue(pos.X), Chart1.ChartAreas("Main").AxisY.PixelPositionToValue(pos.Y))
        Dim close As DataPoint = Nothing
        Dim name As String = ""
        For Each s As Series In Chart1.Series
            For i As Integer = 0 To s.Points.Count - 1
                If IsNothing(close) Then
                    close = s.Points(i)
                Else
                    If pos.X = s.Points(i).XValue Then
                        'x is close
                        If (pos.Y - s.Points(i).YValues(0)) <= (pos.Y - close.YValues(0)) And (pos.Y - s.Points(i).YValues(0)) > 0 Then

                            close = s.Points(i)
                            name = s.Name

                        ElseIf (s.Points(i).YValues(0) - pos.Y) <= (close.YValues(0) - pos.Y) And (s.Points(i).YValues(0) - pos.Y) > 0 Then
                            close = s.Points(i)
                            name = s.Name
                        End If
                    End If
                End If
            Next
        Next
        If IsNothing(close) Then
            Dashboard.statMousePos.Text = "X=" & pos.X.ToString & ", Y=" & pos.Y.ToString
        Else
            Dashboard.statMousePos.Text = "X=" & pos.X.ToString & ", Y=" & pos.Y.ToString & vbTab & "Closest=(" & close.XValue.ToString & "," & close.YValues(0).ToString & ") on " & name
        End If
    End Sub
    Private Sub toggleDataPane_Click(sender As System.Object, e As System.EventArgs) Handles toggleDataPane.Click
        If SplitContainer1.Panel2Collapsed Then
            SplitContainer1.Panel2Collapsed = False
        Else
            SplitContainer1.Panel2Collapsed = True
        End If
    End Sub


End Class
