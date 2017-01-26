Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class OEE_Add
    Private dash As OEE_View
    Private _CNN As String
    Property Dashboard() As OEE_View
        Get
            Return dash
        End Get
        Set(value As OEE_View)
            dash = value
        End Set
    End Property
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim o As New OEE
        If Not IsNothing(txtDatabase.Text) And Not String.IsNullOrEmpty(txtDatabase.Text) Then
            o.OleDbProvider = Local_Functions.GetOleDbProvider(txtDatabase.Text)
            o.OleDbConnection = Local_Functions.CompileOleDbConnectionString(o.OleDbProvider, txtDatabase.Text)
            Debug.WriteLine("OleDbConnection added to OEE control")
            o.OleDbFile = txtDatabase.Text
            o.OleDbTable = txtTable.Text
        End If
        Dim wc As String = cmbWorkCenter.Text
        wc = Convert.ToInt32(wc.Remove(wc.IndexOf(")")).Remove(0, 1))
        o.Name = wc
        o.WorkCenter = wc
        o.WorkCenterName = getWCName(o)

        dash.pnlView.VerticalScroll.Value = 0
        Dim cnt As Integer = dash.pnlView.Controls.Count
        Debug.WriteLine("DASHBOARD Control Count=" + cnt.ToString)
        Dim r, c As Integer
        For Each cntrl As Control In dash.pnlView.Controls
            If c = My.Settings.ControlColumns - 1 Then
                c = -1
                r += 1
            End If
            c += 1
        Next
        o.Location = New Point((200 * (c)), (326 * r) + 30)
        o.Size = New Size(200, 326)
        dash.pnlView.Controls.Add(o)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub OEE_Add_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        cmbWorkCenter.Items.Clear()
        Dim cn As New OleDbConnection()
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
        _CNN = Local_Functions.CompileOleDbConnectionString(prov, db, u, p)
        cn.ConnectionString = _CNN
        Debug.WriteLine("Connection String (onload)=" & _CNN)
        'Connect to the Northwind database in SQL Server.
        'Be sure to use an account that has permission to list tables.
        cn.Open()

        Cmd = New OleDbCommand("SELECT Descrip FROM dbo_WorkCntr;", cn)
        Read = Cmd.ExecuteReader
        For Each Record As IDataRecord In Read
            cmbWorkCenter.Items.Add(Record.Item("Descrip").ToString)
        Next
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
            Debug.WriteLine("Connection String (ontextchange)=" + _CNN)
            'Connect to the Northwind database in SQL Server.
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
        Else
            txtTable.Enabled = False
        End If
    End Sub
End Class
