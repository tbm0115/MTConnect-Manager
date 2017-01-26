Public Class SelectView

    Private Sub btnDashboard_Click(sender As System.Object, e As System.EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        Dashboard.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnWatcher_Click(sender As System.Object, e As System.EventArgs) Handles btnWatcher.Click
        Watcher.Show()
        Watcher.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SelectView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuSettings_Click(sender As System.Object, e As System.EventArgs) Handles mnuSettings.Click
        Administrative_Settings.Show()
    End Sub
End Class