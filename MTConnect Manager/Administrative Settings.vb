Public Class Administrative_Settings

    Private Sub Administrative_Settings_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If radCSV.Checked Then
            My.Settings.intDefOutMeth = 0
        ElseIf radMDB.Checked Then
            My.Settings.intDefOutMeth = 1
        End If
        My.Settings.strDefDatFile = txtDefDatFile.Text
        My.Settings.intDefRefresh = Convert.ToInt32(txtDefRefresh.Text)
        My.Settings.intMinRefresh = Convert.ToInt32(txtMinRefresh.Text)
        My.Settings.intMaxRefresh = Convert.ToInt32(txtMaxRefresh.Text)

        My.Settings.intSemiSuspend = Convert.ToInt32(txtSemiSuspend.Text)
        My.Settings.strTimerResume = timeRecord.Value.ToString(("HH:mm:ss tt"))

        My.Settings.ControlColumns = Convert.ToInt32(txtControlColumns.Text)
        My.Settings.intMaxRec = Convert.ToInt32(txtMaxRec.Text)

        My.Settings.blnRptOEEHTML = chkblnOEE.Checked
        My.Settings.strRptOEEHTML = txtstrOEE.Text
    End Sub

    Private Sub Administrative_Settings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Settings.intDefOutMeth = 0 Then
            radCSV.Checked = True
        ElseIf My.Settings.intDefOutMeth = 1 Then
            radMDB.Checked = True
        End If
        txtDefDatFile.Text = My.Settings.strDefDatFile
        txtDefRefresh.Text = My.Settings.intDefRefresh.ToString
        txtMinRefresh.Text = My.Settings.intMinRefresh.ToString
        txtMaxRefresh.Text = My.Settings.intMaxRefresh.ToString

        txtSemiSuspend.Text = My.Settings.intSemiSuspend.ToString
        timeRecord.Value = DateTime.Parse(My.Settings.strTimerResume)

        txtControlColumns.Text = My.Settings.ControlColumns.ToString
        txtMaxRec.Text = My.Settings.intMaxRec.ToString

        chkblnOEE.Checked = My.Settings.blnRptOEEHTML
        txtstrOEE.Text = My.Settings.strRptOEEHTML


        'Add Number Handlers
        AddHandler txtDefRefresh.TextChanged, AddressOf NumbersOnly
        AddHandler txtMinRefresh.TextChanged, AddressOf NumbersOnly
        AddHandler txtMaxRefresh.TextChanged, AddressOf NumbersOnly
        AddHandler txtSemiSuspend.TextChanged, AddressOf NumbersOnly
        AddHandler txtControlColumns.TextChanged, AddressOf NumbersOnly
        AddHandler txtMaxRec.TextChanged, AddressOf NumbersOnly

    End Sub
    Public Sub NumbersOnly(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim txt As TextBox = sender
        If Not IsNumeric(txt.Text) Then
            Do Until IsNumeric(txt.Text)
                Debug.WriteLine(txt.Text)
                If txt.Text.Length > 0 Then
                    txt.Text = txt.Text.Remove(txt.Text.Length - 1)
                Else
                    Exit Sub
                End If
            Loop
        End If
        txt.Select(txt.Text.Length, 0)
    End Sub
End Class