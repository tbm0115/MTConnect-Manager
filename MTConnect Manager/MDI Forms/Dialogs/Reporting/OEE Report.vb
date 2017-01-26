Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports HTML, HTML.HTMLWriter, HTML.HTMLWriter.HTMLTable

Public Class OEE_Report

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If Not chkDateRange.Checked Then
      dateStart.Value = dateEnd.Value
    End If
    'Setup Reporting variables
    Dim rowColor As Integer = 0
    Dim Report As New HTMLWriter
    Dim Header As New HTMLHeader("Overall Equipment Effeciency Report", HTMLHeader.HeaderSize.H1,
                                     New AttributeList({"font-size", "color", "text-align"},
                                                       {"3em", "Green", "Center"}, True))
    Dim Table As New HTMLTable
    Dim TH As New HTMLTableRow(New AttributeList({"background-color"},
                                                              {"LightBlue"}, True))

    Report.AddToHTMLMarkup(Header)
    TH.AddTableCell(New HTMLTableCell("Work Center", HTMLTableCell.CellType.Header))
    TH.AddTableCell(New HTMLTableCell("Availability (%)", HTMLTableCell.CellType.Header))
    TH.AddTableCell(New HTMLTableCell("Performance (%)", HTMLTableCell.CellType.Header))
    TH.AddTableCell(New HTMLTableCell("Quality (%)", HTMLTableCell.CellType.Header))
    TH.AddTableCell(New HTMLTableCell("OEE (%)", HTMLTableCell.CellType.Header))
    Table.AddTableRow(TH)

    'Setup time values
    Dim ts As New TimeSpan
    Dim dt As New DateTime
    ts = dateEnd.Value - dateStart.Value
    'Begin IrongateApplications database connection
    Dim Cnn As New OleDbConnection(CompileOleDbConnectionString(GetOleDbProvider(My.Resources.E2DatabaseLocation), My.Resources.E2DatabaseLocation))
    Cnn.Open()
    Dim Cmd As OleDbCommand
    Dim days As Integer
    'Cycle through selected workcenters
    For Each WorkC As String In chkWorkCenters.CheckedItems
      'reset wc to wc#
      Dim wc As String = WorkC.Remove(WorkC.IndexOf(")")).Remove(0, 1)
      Dim A, Q, P, OEE As Integer
      A = Nothing
      Q = Nothing
      P = Nothing
      OEE = Nothing
      'Cycle through selected day(s)
      days = Nothing
      For i = 0 To ts.Days Step 1
        dt = dateStart.Value.AddDays(i)
        progDates.Value = (i / ts.Days) * 100
        Application.DoEvents()
        If dt.DayOfWeek = DayOfWeek.Friday Or dt.DayOfWeek = DayOfWeek.Saturday Or dt.DayOfWeek = DayOfWeek.Sunday Then
          Continue For
        End If
        'Availability doesn't change until we can calculate Down Time
        A += (((10 - 0.83333) - 0) / (10 - 0.83333)) * 100
        'Quality
        Cmd = New OleDbCommand("SELECT PiecesFinished,PiecesScrapped,WorkCntr,JobNo FROM dbo_TimeTicketDet WHERE TicketDate = '" & dt.ToString(("MM/dd/yy")) & "';", Cnn)
        Dim Reader As OleDbDataReader = Cmd.ExecuteReader
        Dim gp, scrap, tmp As Integer
        gp = 0
        scrap = 0
        For Each Record As IDataRecord In Reader
          If wc = Record.Item("WorkCntr").ToString Then
            Integer.TryParse(Record.Item("PiecesFinished").ToString, tmp)
            gp += tmp
            Integer.TryParse(Record.Item("PiecesScrapped").ToString, tmp)
            scrap += tmp
          End If
        Next
        If gp > 0 Then
          Q += (gp / (gp + scrap)) * 100
        ElseIf scrap > 0 Then
          Q += 0
        Else
          Q += 100
        End If
        Reader.Close()
        Cmd.Dispose()

        'Performance
        Dim APT As Decimal = 0
        Dim Qty As Integer = 0
        Dim PiecesFinished As Integer = 0
        Dim ManHrs As Decimal = 0
        Cmd = New OleDbCommand("SELECT JobNo,TicketDate,WorkCntr,MachHrs,PiecesFinished FROM dbo_TimeTicketDet WHERE TicketDate = '" & dt.ToString(("MM/dd/yy")) & "';", Cnn)
        Reader = Cmd.ExecuteReader
        For Each Record As IDataRecord In Reader
          If Record.Item("WorkCntr").ToString = wc Then
            ManHrs += Convert.ToDecimal(Record.Item("MachHrs").ToString)
            PiecesFinished += Convert.ToInt32(Record.Item("PiecesFinished"))
            Cmd = New OleDbCommand("SELECT TotalEstHrs,JobNo,QtyToMake FROM dbo_OrderDet WHERE JobNo = '" + Record.Item("JobNo").ToString + "';", Cnn)
            Reader = Cmd.ExecuteReader
            For Each Job As IDataRecord In Reader
              If Job.Item("JobNo").ToString = Record.Item("JobNo").ToString Then
                APT += Convert.ToDecimal(Job.Item("TotalEstHrs").ToString)
                Qty += Convert.ToInt32(Job.Item("QtyToMake").ToString)
              End If
            Next
            Cmd.Dispose()
            Reader.Close()
          End If
        Next
        Cmd.Dispose()
        Reader.Close()
        If APT > 0 And PiecesFinished > 0 Then
          P += (((APT * PiecesFinished) / Qty) / ManHrs) * 100
        Else
          P += 0
        End If
        days += 1
      Next
      'Write part of report
      Dim TR As HTMLTable.HTMLTableRow
      If rowColor And 1 Then
        TR = New HTMLTable.HTMLTableRow(New AttributeList({"background-color"}, {"Gray"}, True))
      Else
        TR = New HTMLTable.HTMLTableRow()
      End If
      'Overall Equipment Effectiveness
      If Q > 0 And A > 0 And P > 0 Then
        OEE += ((Convert.ToInt32(A / days) / 100) * (Convert.ToInt32(P / days) / 100) * (Convert.ToInt32(Q / days) / 100)) * 100
      Else
        OEE += 0
      End If
      TR.AddTableColumn(WorkC)
      TR.AddTableColumn(Convert.ToInt32(A / (days)).ToString)
      TR.AddTableColumn(Convert.ToInt32(P / (days)).ToString)
      TR.AddTableColumn(Convert.ToInt32(Q / (days)).ToString)
      TR.AddTableColumn(Convert.ToInt32(OEE).ToString)
      Table.AddTableRow(TR)
      Debug.WriteLine("A=" & A.ToString & vbLf & _
                      "P=" & P.ToString & vbLf & _
                      "Q=" & Q.ToString & vbLf & _
                      "OEE=" & OEE.ToString)
      rowColor += 1
      progDates.Value = (rowColor / chkWorkCenters.CheckedItems.Count) * 100
      Application.DoEvents()
    Next
    Report.AddToHTMLMarkup("<p>This report presents an average Overall Equipment Effectiveness scores for the selected Work Center(s)" & _
                           " for the date range of " & dateStart.Value.ToString(("MM/dd/yyyy")) & " to " & dateEnd.Value.ToString(("MM/dd/yyyy")) & " excluding Fridays, Saturdays and Sundays")
    Report.AddToHTMLMarkup("<p>Total # of days in calculation = " & days.ToString & "</p>")
    Report.AddToHTMLMarkup("<p>Availability = (((Shift Length - Break(s) Length) - Down Time) / (Shift Length - Break(s))) x 100</p>")
    Report.AddToHTMLMarkup("<p>Performance = (((Total Estimated Hours x Pieces Finished) / Quantity to Make) / Total Current Man Hours) x 100</p>")
    Report.AddToHTMLMarkup("<p>Quality = (Good Product / (Good Product + Scrap Product)) x 100</p>")
    Report.AddToHTMLMarkup("<p>Overall Equipment Effectiveness = (Availability x Performance x Quality) x 100</p>")
    Report.AddToHTMLMarkup(Table)
    IO.File.WriteAllText(My.Settings.StartUp & "\OEE Report.html", Report.HTMLMarkup)
    If Not String.IsNullOrEmpty(My.Settings.strRptOEEHTML) Then IO.File.WriteAllText(My.Settings.strRptOEEHTML & "\OEE Report.html", Report.HTMLMarkup)
    If My.Settings.blnRptOEEHTML Then
      Try
        Process.Start(My.Settings.StartUp & "\OEE Report.html")
      Catch ex As Exception
        MessageBox.Show("Couldn't open the report due to error:" & vbLf & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If

    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub chkDateRange_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDateRange.CheckedChanged
    lblStart.Enabled = chkDateRange.Checked
    dateStart.Enabled = chkDateRange.Checked
  End Sub

  Private Sub OEE_Report_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
    chkWorkCenters.Items.Clear()
    Dim Cnn As New OleDbConnection
    Dim Cmd As OleDbCommand
    Dim Read As OleDbDataReader
    Dim i As String
    Dim u, p, prov, db As String
    db = My.Resources.E2DatabaseLocation
    'Check if database is password protected. If so, then prompt for Username and Password
    prov = Local_Functions.GetOleDbProvider(db)
    If Local_Functions.OleDbSecurityExists(db, prov) Then
      u = InputBox("Enter the UserName available for this file (if there is a required UserName):" & vbLf & db, "Database Credentials")
      p = InputBox("Enter the Password available for this file (if there is a required Password):" & vbLf & db, "Database Credentials")
      If Not Local_Functions.OleDbSecurityTest(db, u, p, prov) Then
        MessageBox.Show("It appears that the credentials you provided were incorrect! Please review the credentials for this file and reselect the file to try again." & vbLf & "Provided Credentials:" & vbLf & "UserName=" & u & vbLf & "Password=" & p & vbLf & "File=" & db, "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
        db = Nothing
        Exit Sub
      End If
    End If
    Cnn.ConnectionString = Local_Functions.CompileOleDbConnectionString(prov, db, u, p)
    Debug.WriteLine("Connection String=" & Cnn.ConnectionString)
    'Connect to the Northwind database in SQL Server.
    'Be sure to use an account that has permission to list tables.
    Cnn.Open()

    Cmd = New OleDbCommand("SELECT Descrip FROM dbo_WorkCntr;", Cnn)
    Read = Cmd.ExecuteReader
    For Each Record As IDataRecord In Read
      chkWorkCenters.Items.Add(Record.Item("Descrip").ToString, False)
    Next
  End Sub
End Class
