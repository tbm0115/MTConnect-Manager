Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Xml

Public Class Status_Add
    Private dash As Status_View
    Private _CNN As String
    Property Dashboard() As Status_View
        Get
            Return dash
        End Get
        Set(value As Status_View)
            dash = value
        End Set
    End Property
    Private Function GetIndicatorColor(ByVal IndicatorColor As Integer) As Status_Indicator.Color
        Select Case IndicatorColor
            Case 0
                Return Status_Indicator.Color.Green
            Case 1
                Return Status_Indicator.Color.Cyan
            Case 2
                Return Status_Indicator.Color.Blue
            Case 3
                Return Status_Indicator.Color.Violet
            Case 4
                Return Status_Indicator.Color.Yellow
            Case 5
                Return Status_Indicator.Color.Red
            Case Else
                Return 0
        End Select
    End Function

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
                MessageBox.Show("Indicator has already been added...", "Cannot add duplicate indicator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next
        Dim d As New Status_Indicator
        d.OleDbFile = txtDatabase.Text
        d.OleDbTable = txtTable.Text
        d.OleDbColumn = txtColumn.Text
        d.OleDbProvider = Local_Functions.GetOleDbProvider(txtDatabase.Text)
        d.OleDbConnection = _CNN
        d.OleDbPrimaryKey = Local_Functions.GetPrimaryKeyName(_CNN, txtTable.Text)
        d.Name = txtColumn.Text
        d.DataName = txtColumn.Text
        For Each cntrl As Control In grpStatusValues.Controls
            Dim pnl As Panel = cntrl
            If pnl.Enabled = True Then
                If String.IsNullOrEmpty(pnl.Controls.Find("cmbValue" + pnl.Name.Replace("stat", Nothing), True).First.Text) = False Then
                    If String.IsNullOrEmpty(pnl.Controls.Find("cmbStatus" + pnl.Name.Replace("stat", Nothing), True).First.Text) = False Then
                        Dim val, stat As ComboBox
                        val = pnl.Controls.Find("cmbValue" + pnl.Name.Replace("stat", Nothing), True).First
                        stat = pnl.Controls.Find("cmbStatus" + pnl.Name.Replace("stat", Nothing), True).First
                        d.AddStatusValue(val.Text, GetIndicatorColor(stat.SelectedIndex))
                        'Debug.WriteLine(val.Text + "," + (stat.SelectedIndex).ToString)

                    End If
                End If
            End If
        Next
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
        d.Location = New Point((200 * (c)), (200 * r) + 30)
        d.Size = New Size(200, 200)
        dash.pnlView.Controls.Add(d)
        dash.blnUseSameConnection = 2
        ClearCombos()
        DisableStatus()
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
        ClearCombos()
        DisableStatus()
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
                                If cNODE.Attributes("units").Value.ToString.ToUpper = "NULL" Then
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

    Private Sub txtColumn_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtColumn.SelectedIndexChanged
        If txtColumn.SelectedIndex = -1 Then
            stat1.Enabled = False
            Exit Sub
        End If
        Dim Cnn As New OleDbConnection(_CNN)
        Dim Cmd As New OleDbCommand("SELECT DISTINCT " + txtColumn.Text + " FROM " + txtTable.Text + ";", Cnn)
        Dim Reader As OleDbDataReader
        Cnn.Open()
        Reader = Cmd.ExecuteReader
        ClearCombos()
        DisableStatus()
        Dim i As Integer = 0
        For Each record As IDataRecord In Reader
            cmbValue1.Items.Add(record.Item(txtColumn.Text).ToString)
            cmbValue2.Items.Add(record.Item(txtColumn.Text).ToString)
            cmbValue3.Items.Add(record.Item(txtColumn.Text).ToString)
            cmbValue4.Items.Add(record.Item(txtColumn.Text).ToString)
            cmbValue5.Items.Add(record.Item(txtColumn.Text).ToString)
            cmbValue6.Items.Add(record.Item(txtColumn.Text).ToString)
            i += 1
        Next
        If i <= 6 Then
            For n = 1 To i Step 1
                Dim cmb As ComboBox = Me.Controls.Find("cmbValue" & n.ToString, True).First()
                If Not IsNothing(cmb) Then
                    cmb.SelectedIndex = n - 1
                End If
                cmb = Me.Controls.Find("cmbStatus" & n.ToString, True).First()
                If Not IsNothing(cmb) Then
                    cmb.SelectedIndex = n - 1
                End If
            Next
        End If
        stat1.Enabled = True
        'Explicitly close - don't wait on garbage collection.
        Cnn.Close()
    End Sub

    Sub DisableStatus()
        stat1.Enabled = False
        stat2.Enabled = False
        stat3.Enabled = False
        stat4.Enabled = False
        stat5.Enabled = False
        stat6.Enabled = False

    End Sub
    Sub ClearCombos()
        cmbValue1.Items.Clear()
        cmbValue2.Items.Clear()
        cmbValue3.Items.Clear()
        cmbValue4.Items.Clear()
        cmbValue5.Items.Clear()
        cmbValue6.Items.Clear()
        cmbValue1.Text = Nothing
        cmbValue2.Text = Nothing
        cmbValue3.Text = Nothing
        cmbValue4.Text = Nothing
        cmbValue5.Text = Nothing
        cmbValue6.Text = Nothing

        cmbStatus1.Text = Nothing
        cmbStatus2.Text = Nothing
        cmbStatus3.Text = Nothing
        cmbStatus4.Text = Nothing
        cmbStatus5.Text = Nothing
        cmbStatus6.Text = Nothing

    End Sub
    Private Sub Values_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Dim focus As ComboBox = sender
        Dim i As Integer = Convert.ToInt32(focus.Name.Replace("cmbValue", Nothing))
        If focus.SelectedIndex = -1 Then
            'reset all subsequent panels
            For j = (i + 1) To 6 Step 1
                If grpStatusValues.Controls.Find("stat" + j.ToString, True).First.Enabled = True Then
                    Dim pnl As Panel = grpStatusValues.Controls.Find("stat" + j.ToString, True).First
                    pnl.Controls.Find("cmbValue" + j.ToString, True).First.Text = Nothing
                    pnl.Controls.Find("cmbStatus" + j.ToString, True).First.Text = Nothing
                    pnl.Enabled = False
                End If
            Next
            Exit Sub
        End If
        If i > 1 Then
            For j = i - 1 To 1 Step -1
                If grpStatusValues.Controls.Find("cmbValue" + j.ToString, True).First.Text = focus.Text Then
                    MessageBox.Show("Cannot have multiple status indicators for the same status value!", "No Duplicates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    focus.Text = Nothing
                    focus.Parent.Controls.Find("cmbStatus" + i.ToString, True).First.Text = Nothing
                    Exit Sub
                End If
            Next
        End If
        If i < 6 Then
            grpStatusValues.Controls.Find("stat" + (i + 1).ToString, True).First.Enabled = True
        End If


    End Sub

    Private Sub Status_Add_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler cmbValue1.SelectedIndexChanged, AddressOf Values_SelectedIndexChanged
        AddHandler cmbValue2.SelectedIndexChanged, AddressOf Values_SelectedIndexChanged
        AddHandler cmbValue3.SelectedIndexChanged, AddressOf Values_SelectedIndexChanged
        AddHandler cmbValue4.SelectedIndexChanged, AddressOf Values_SelectedIndexChanged
        AddHandler cmbValue5.SelectedIndexChanged, AddressOf Values_SelectedIndexChanged
        AddHandler cmbValue6.SelectedIndexChanged, AddressOf Values_SelectedIndexChanged

        If IO.File.Exists(My.Settings.strDefDatFile) Then
            txtDatabase.Text = My.Settings.strDefDatFile
        End If
    End Sub
End Class
