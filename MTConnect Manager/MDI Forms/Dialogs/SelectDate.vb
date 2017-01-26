Imports System.Windows.Forms

Public Class SelectDate

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SelectDate_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        viewdate.MaxSelectionCount = 1
        viewdate.MaxDate = DateTime.Today
    End Sub
End Class
