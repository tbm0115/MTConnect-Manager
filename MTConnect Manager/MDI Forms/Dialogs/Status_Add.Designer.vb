<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status_Add
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.grpDatabase = New System.Windows.Forms.GroupBox()
        Me.grpStatusValues = New System.Windows.Forms.GroupBox()
        Me.stat6 = New System.Windows.Forms.Panel()
        Me.cmbStatus6 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbValue6 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.stat5 = New System.Windows.Forms.Panel()
        Me.cmbStatus5 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbValue5 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.stat4 = New System.Windows.Forms.Panel()
        Me.cmbStatus4 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbValue4 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.stat3 = New System.Windows.Forms.Panel()
        Me.cmbStatus3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbValue3 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.stat2 = New System.Windows.Forms.Panel()
        Me.cmbStatus2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbValue2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.stat1 = New System.Windows.Forms.Panel()
        Me.cmbStatus1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbValue1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtColumn = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTable = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.btnFileOpen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filOpen = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpDatabase.SuspendLayout()
        Me.grpStatusValues.SuspendLayout()
        Me.stat6.SuspendLayout()
        Me.stat5.SuspendLayout()
        Me.stat4.SuspendLayout()
        Me.stat3.SuspendLayout()
        Me.stat2.SuspendLayout()
        Me.stat1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 350)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(580, 60)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(6, 6)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(280, 48)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(294, 6)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(280, 48)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'grpDatabase
        '
        Me.grpDatabase.Controls.Add(Me.grpStatusValues)
        Me.grpDatabase.Controls.Add(Me.Panel3)
        Me.grpDatabase.Controls.Add(Me.Panel2)
        Me.grpDatabase.Controls.Add(Me.Panel1)
        Me.grpDatabase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDatabase.Location = New System.Drawing.Point(0, 0)
        Me.grpDatabase.Name = "grpDatabase"
        Me.grpDatabase.Size = New System.Drawing.Size(580, 350)
        Me.grpDatabase.TabIndex = 3
        Me.grpDatabase.TabStop = False
        Me.grpDatabase.Text = "Database"
        '
        'grpStatusValues
        '
        Me.grpStatusValues.Controls.Add(Me.stat6)
        Me.grpStatusValues.Controls.Add(Me.stat5)
        Me.grpStatusValues.Controls.Add(Me.stat4)
        Me.grpStatusValues.Controls.Add(Me.stat3)
        Me.grpStatusValues.Controls.Add(Me.stat2)
        Me.grpStatusValues.Controls.Add(Me.stat1)
        Me.grpStatusValues.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpStatusValues.Location = New System.Drawing.Point(3, 123)
        Me.grpStatusValues.Name = "grpStatusValues"
        Me.grpStatusValues.Size = New System.Drawing.Size(574, 220)
        Me.grpStatusValues.TabIndex = 3
        Me.grpStatusValues.TabStop = False
        Me.grpStatusValues.Text = "Status Values"
        '
        'stat6
        '
        Me.stat6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stat6.Controls.Add(Me.cmbStatus6)
        Me.stat6.Controls.Add(Me.Label10)
        Me.stat6.Controls.Add(Me.cmbValue6)
        Me.stat6.Controls.Add(Me.Label11)
        Me.stat6.Dock = System.Windows.Forms.DockStyle.Top
        Me.stat6.Enabled = False
        Me.stat6.Location = New System.Drawing.Point(3, 193)
        Me.stat6.Name = "stat6"
        Me.stat6.Size = New System.Drawing.Size(568, 35)
        Me.stat6.TabIndex = 5
        '
        'cmbStatus6
        '
        Me.cmbStatus6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStatus6.FormattingEnabled = True
        Me.cmbStatus6.Items.AddRange(New Object() {"Green", "Cyan", "Blue", "Violet", "Yellow", "Red"})
        Me.cmbStatus6.Location = New System.Drawing.Point(409, 0)
        Me.cmbStatus6.Name = "cmbStatus6"
        Me.cmbStatus6.Size = New System.Drawing.Size(157, 24)
        Me.cmbStatus6.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(279, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 33)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Status Color 6:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbValue6
        '
        Me.cmbValue6.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbValue6.DropDownWidth = 350
        Me.cmbValue6.FormattingEnabled = True
        Me.cmbValue6.Location = New System.Drawing.Point(130, 0)
        Me.cmbValue6.Name = "cmbValue6"
        Me.cmbValue6.Size = New System.Drawing.Size(149, 24)
        Me.cmbValue6.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 33)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Status Value 6:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'stat5
        '
        Me.stat5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stat5.Controls.Add(Me.cmbStatus5)
        Me.stat5.Controls.Add(Me.Label12)
        Me.stat5.Controls.Add(Me.cmbValue5)
        Me.stat5.Controls.Add(Me.Label13)
        Me.stat5.Dock = System.Windows.Forms.DockStyle.Top
        Me.stat5.Enabled = False
        Me.stat5.Location = New System.Drawing.Point(3, 158)
        Me.stat5.Name = "stat5"
        Me.stat5.Size = New System.Drawing.Size(568, 35)
        Me.stat5.TabIndex = 4
        '
        'cmbStatus5
        '
        Me.cmbStatus5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStatus5.FormattingEnabled = True
        Me.cmbStatus5.Items.AddRange(New Object() {"Green", "Cyan", "Blue", "Violet", "Yellow", "Red"})
        Me.cmbStatus5.Location = New System.Drawing.Point(409, 0)
        Me.cmbStatus5.Name = "cmbStatus5"
        Me.cmbStatus5.Size = New System.Drawing.Size(157, 24)
        Me.cmbStatus5.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(279, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 33)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Status Color 5:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbValue5
        '
        Me.cmbValue5.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbValue5.DropDownWidth = 350
        Me.cmbValue5.FormattingEnabled = True
        Me.cmbValue5.Location = New System.Drawing.Point(130, 0)
        Me.cmbValue5.Name = "cmbValue5"
        Me.cmbValue5.Size = New System.Drawing.Size(149, 24)
        Me.cmbValue5.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 33)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Status Value 5:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'stat4
        '
        Me.stat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stat4.Controls.Add(Me.cmbStatus4)
        Me.stat4.Controls.Add(Me.Label14)
        Me.stat4.Controls.Add(Me.cmbValue4)
        Me.stat4.Controls.Add(Me.Label15)
        Me.stat4.Dock = System.Windows.Forms.DockStyle.Top
        Me.stat4.Enabled = False
        Me.stat4.Location = New System.Drawing.Point(3, 123)
        Me.stat4.Name = "stat4"
        Me.stat4.Size = New System.Drawing.Size(568, 35)
        Me.stat4.TabIndex = 3
        '
        'cmbStatus4
        '
        Me.cmbStatus4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStatus4.FormattingEnabled = True
        Me.cmbStatus4.Items.AddRange(New Object() {"Green", "Cyan", "Blue", "Violet", "Yellow", "Red"})
        Me.cmbStatus4.Location = New System.Drawing.Point(409, 0)
        Me.cmbStatus4.Name = "cmbStatus4"
        Me.cmbStatus4.Size = New System.Drawing.Size(157, 24)
        Me.cmbStatus4.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(279, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 33)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Status Color 4:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbValue4
        '
        Me.cmbValue4.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbValue4.DropDownWidth = 350
        Me.cmbValue4.FormattingEnabled = True
        Me.cmbValue4.Location = New System.Drawing.Point(130, 0)
        Me.cmbValue4.Name = "cmbValue4"
        Me.cmbValue4.Size = New System.Drawing.Size(149, 24)
        Me.cmbValue4.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 33)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Status Value 4:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'stat3
        '
        Me.stat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stat3.Controls.Add(Me.cmbStatus3)
        Me.stat3.Controls.Add(Me.Label8)
        Me.stat3.Controls.Add(Me.cmbValue3)
        Me.stat3.Controls.Add(Me.Label9)
        Me.stat3.Dock = System.Windows.Forms.DockStyle.Top
        Me.stat3.Enabled = False
        Me.stat3.Location = New System.Drawing.Point(3, 88)
        Me.stat3.Name = "stat3"
        Me.stat3.Size = New System.Drawing.Size(568, 35)
        Me.stat3.TabIndex = 2
        '
        'cmbStatus3
        '
        Me.cmbStatus3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStatus3.FormattingEnabled = True
        Me.cmbStatus3.Items.AddRange(New Object() {"Green", "Cyan", "Blue", "Violet", "Yellow", "Red"})
        Me.cmbStatus3.Location = New System.Drawing.Point(409, 0)
        Me.cmbStatus3.Name = "cmbStatus3"
        Me.cmbStatus3.Size = New System.Drawing.Size(157, 24)
        Me.cmbStatus3.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(279, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 33)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Status Color 3:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbValue3
        '
        Me.cmbValue3.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbValue3.DropDownWidth = 350
        Me.cmbValue3.FormattingEnabled = True
        Me.cmbValue3.Location = New System.Drawing.Point(130, 0)
        Me.cmbValue3.Name = "cmbValue3"
        Me.cmbValue3.Size = New System.Drawing.Size(149, 24)
        Me.cmbValue3.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 33)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Status Value 3:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'stat2
        '
        Me.stat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stat2.Controls.Add(Me.cmbStatus2)
        Me.stat2.Controls.Add(Me.Label6)
        Me.stat2.Controls.Add(Me.cmbValue2)
        Me.stat2.Controls.Add(Me.Label7)
        Me.stat2.Dock = System.Windows.Forms.DockStyle.Top
        Me.stat2.Enabled = False
        Me.stat2.Location = New System.Drawing.Point(3, 53)
        Me.stat2.Name = "stat2"
        Me.stat2.Size = New System.Drawing.Size(568, 35)
        Me.stat2.TabIndex = 1
        '
        'cmbStatus2
        '
        Me.cmbStatus2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStatus2.FormattingEnabled = True
        Me.cmbStatus2.Items.AddRange(New Object() {"Green", "Cyan", "Blue", "Violet", "Yellow", "Red"})
        Me.cmbStatus2.Location = New System.Drawing.Point(409, 0)
        Me.cmbStatus2.Name = "cmbStatus2"
        Me.cmbStatus2.Size = New System.Drawing.Size(157, 24)
        Me.cmbStatus2.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 33)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Status Color 2:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbValue2
        '
        Me.cmbValue2.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbValue2.DropDownWidth = 350
        Me.cmbValue2.FormattingEnabled = True
        Me.cmbValue2.Location = New System.Drawing.Point(130, 0)
        Me.cmbValue2.Name = "cmbValue2"
        Me.cmbValue2.Size = New System.Drawing.Size(149, 24)
        Me.cmbValue2.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 33)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Status Value 2:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'stat1
        '
        Me.stat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stat1.Controls.Add(Me.cmbStatus1)
        Me.stat1.Controls.Add(Me.Label5)
        Me.stat1.Controls.Add(Me.cmbValue1)
        Me.stat1.Controls.Add(Me.Label4)
        Me.stat1.Dock = System.Windows.Forms.DockStyle.Top
        Me.stat1.Enabled = False
        Me.stat1.Location = New System.Drawing.Point(3, 18)
        Me.stat1.Name = "stat1"
        Me.stat1.Size = New System.Drawing.Size(568, 35)
        Me.stat1.TabIndex = 0
        '
        'cmbStatus1
        '
        Me.cmbStatus1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStatus1.FormattingEnabled = True
        Me.cmbStatus1.Items.AddRange(New Object() {"Green", "Cyan", "Blue", "Violet", "Yellow", "Red"})
        Me.cmbStatus1.Location = New System.Drawing.Point(409, 0)
        Me.cmbStatus1.Name = "cmbStatus1"
        Me.cmbStatus1.Size = New System.Drawing.Size(157, 24)
        Me.cmbStatus1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(279, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 33)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Status Color 1:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbValue1
        '
        Me.cmbValue1.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbValue1.DropDownWidth = 350
        Me.cmbValue1.FormattingEnabled = True
        Me.cmbValue1.Location = New System.Drawing.Point(130, 0)
        Me.cmbValue1.Name = "cmbValue1"
        Me.cmbValue1.Size = New System.Drawing.Size(149, 24)
        Me.cmbValue1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 33)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Status Value 1:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtColumn)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(3, 88)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(574, 35)
        Me.Panel3.TabIndex = 2
        '
        'txtColumn
        '
        Me.txtColumn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtColumn.Enabled = False
        Me.txtColumn.FormattingEnabled = True
        Me.txtColumn.Location = New System.Drawing.Point(132, 2)
        Me.txtColumn.Name = "txtColumn"
        Me.txtColumn.Size = New System.Drawing.Size(440, 28)
        Me.txtColumn.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Column Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtTable)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(574, 35)
        Me.Panel2.TabIndex = 1
        '
        'txtTable
        '
        Me.txtTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTable.Enabled = False
        Me.txtTable.FormattingEnabled = True
        Me.txtTable.Location = New System.Drawing.Point(132, 2)
        Me.txtTable.Name = "txtTable"
        Me.txtTable.Size = New System.Drawing.Size(440, 28)
        Me.txtTable.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Table Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDatabase)
        Me.Panel1.Controls.Add(Me.btnFileOpen)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(574, 35)
        Me.Panel1.TabIndex = 0
        '
        'txtDatabase
        '
        Me.txtDatabase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDatabase.Location = New System.Drawing.Point(132, 2)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(357, 27)
        Me.txtDatabase.TabIndex = 2
        '
        'btnFileOpen
        '
        Me.btnFileOpen.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFileOpen.Location = New System.Drawing.Point(489, 2)
        Me.btnFileOpen.Name = "btnFileOpen"
        Me.btnFileOpen.Size = New System.Drawing.Size(83, 31)
        Me.btnFileOpen.TabIndex = 1
        Me.btnFileOpen.Text = "Browse..."
        Me.btnFileOpen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database File:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'filOpen
        '
        Me.filOpen.FileName = "Select Database"
        '
        'Status_Add
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(580, 410)
        Me.Controls.Add(Me.grpDatabase)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Status_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dashboard: Status View     -     Add Status Indicator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpDatabase.ResumeLayout(False)
        Me.grpStatusValues.ResumeLayout(False)
        Me.stat6.ResumeLayout(False)
        Me.stat5.ResumeLayout(False)
        Me.stat4.ResumeLayout(False)
        Me.stat3.ResumeLayout(False)
        Me.stat2.ResumeLayout(False)
        Me.stat1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents grpDatabase As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtColumn As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTable As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents btnFileOpen As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpStatusValues As System.Windows.Forms.GroupBox
    Friend WithEvents stat1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbValue1 As System.Windows.Forms.ComboBox
    Friend WithEvents stat6 As System.Windows.Forms.Panel
    Friend WithEvents cmbStatus6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbValue6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents stat5 As System.Windows.Forms.Panel
    Friend WithEvents cmbStatus5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbValue5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents stat4 As System.Windows.Forms.Panel
    Friend WithEvents cmbStatus4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbValue4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents stat3 As System.Windows.Forms.Panel
    Friend WithEvents cmbStatus3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbValue3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents stat2 As System.Windows.Forms.Panel
    Friend WithEvents cmbStatus2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbValue2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents filOpen As System.Windows.Forms.OpenFileDialog

End Class
