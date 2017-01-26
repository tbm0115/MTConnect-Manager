Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Xml

Public Class Dial190_Add
    Private dash As Dial_View
    Private _CNN As String
    Property Dashboard() As Dial_View
        Get
            Return dash
        End Get
        Set(value As Dial_View)
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
        For Each s As Control In dash.pnlView.Controls
            If txtColumn.Text = s.Name Then
                MessageBox.Show("Dial has already been added...", "Cannot add duplicate dials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next
        Dim d As New Dial_190
        d.Tag = txtDatabase.Text + "|" + txtTable.Text + "|" + txtColumn.Text
        d.Name = txtColumn.Text
        d.DataName = txtColumn.Text
        d.OleDbColumn = txtColumn.Text
        d.OleDbTable = txtTable.Text
        d.OleDbFile = txtDatabase.Text
        d.OleDbConnection = _CNN
        d.OleDbPrimaryKey = Local_Functions.GetPrimaryKeyName(_CNN, txtTable.Text)

        dash.pnlView.VerticalScroll.Value = 0
        Dim cnt As Integer = dash.pnlView.Controls.Count
        Dim r, c As Integer
        For Each cntrl As Control In dash.pnlView.Controls
            If c = My.Settings.ControlColumns - 1 Then
                c = -1
                r += 1
            End If
            c += 1
        Next
        d.Location = New Point((350 * (c)), (200 * r) + 30)
        d.Size = New Size(350, 200)
        dash.pnlView.Controls.Add(d)
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

        'Connect to the Northwind database in SQL Server.
        'Be sure to use an account that has permission 
        'to list the columns in the Employees table.
        cn.ConnectionString = _CNN
        cn.Open()

        'Retrieve schema information about columns.
        'Restrict to just the Employees TABLE.
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
                                If cNODE.Attributes("units").Value.ToString.ToUpper = "PERCENT" Then
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

    Private Sub Dial190_Add_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IO.File.Exists(My.Settings.strDefDatFile) Then
            txtDatabase.Text = My.Settings.strDefDatFile
        End If
    End Sub
End Class
