Imports System.Windows.Forms

Public Class OEE_Remove
    Private _view As Form
    Public Property MDIView As Form
        Get
            Return _view
        End Get
        Set(value As Form)
            _view = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If lstRemove.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim dg As DialogResult
        Do Until dg = Windows.Forms.DialogResult.Yes
            dg = MessageBox.Show("Are you sure you wish to remove '" & lstRemove.SelectedItem.ToString() & "'?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dg = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        Loop
        Dim child As Control = MDIView.Controls.Find(lstRemove.SelectedItem.ToString(), True).First
        If Not IsNothing(child) Then
            MDIView.Controls.Find("pnlView", True).First.Controls.Remove(child)
        Else
            MsgBox("Couldn't find '" & lstRemove.SelectedItem.ToString() & "' in the View")
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OEE_Remove_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstRemove.Items.Clear()
        For Each child As Control In MDIView.Controls.Find("pnlView", True).First.Controls
            If (child.GetType() Is GetType(OEE)) Then
                lstRemove.Items.Add(child.Name)
            End If
        Next
    End Sub
End Class
