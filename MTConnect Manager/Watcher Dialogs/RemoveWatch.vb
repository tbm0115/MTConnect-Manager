Imports System.Windows.Forms
Imports System.Xml

Public Class RemoveWatch

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If lstWatches.SelectedIndex < 0 Then
            Exit Sub
        End If
        Dim myXML As New XmlDocument
        Dim DELETE As XmlElement = Nothing
        myXML.Load(my.settings.startup + "\XML\Watch_Sessions.xml")
        For Each WATCH As XmlElement In myXML.SelectSingleNode("sessions").ChildNodes
            If WATCH.SelectSingleNode("name").InnerText = lstWatches.Text Then
                DELETE = WATCH
                Exit For
            End If
        Next
        If IsNothing(DELETE) = False Then
            myXML.SelectSingleNode("sessions").RemoveChild(DELETE)
            myXML.Save(my.settings.startup + "\XML\Watch_Sessions.xml")
        Else
            MessageBox.Show("Couldn't find the correct connection..." + vbLf + "Aborted removal", "Removal Aborted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub lstWatches_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstWatches.SelectedIndexChanged
        If lstWatches.SelectedIndex = -1 Then
            Exit Sub
        End If
        txtName.Text = Nothing
        txtPort.Text = Nothing
        txtRate.Text = Nothing
        txtType.Text = Nothing
        txtFilepath.Text = Nothing
        Dim myXML As New XmlDocument
        myXML.Load(my.settings.startup + "\XML\Watch_Sessions.xml")
        For Each WATCH As XmlElement In myXML.SelectSingleNode("sessions").ChildNodes
            If WATCH.SelectSingleNode("name").InnerText = lstWatches.Text Then

                txtName.Text = WATCH.SelectSingleNode("name").InnerText
                txtPort.Text = WATCH.SelectSingleNode("port").InnerText
                txtRate.Text = WATCH.SelectSingleNode("rate").InnerText
                txtType.Text = WATCH.SelectSingleNode("output").Attributes("type").Value
                txtFilepath.Text = WATCH.SelectSingleNode("output").SelectSingleNode("file").InnerText
                Exit For
            End If
        Next
    End Sub

    Private Sub RemoveWatch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstWatches.Items.Clear()
        Dim myXML As New XmlDocument
        myXML.Load(my.settings.startup + "\XML\Watch_Sessions.xml")
        For Each WATCH As XmlElement In myXML.SelectSingleNode("sessions").ChildNodes
            lstWatches.Items.Add(WATCH.SelectSingleNode("name").InnerText)
        Next
    End Sub
End Class
