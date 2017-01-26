<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddWatch
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMDB = New System.Windows.Forms.RadioButton()
        Me.radCSV = New System.Windows.Forms.RadioButton()
        Me.grpRate = New System.Windows.Forms.GroupBox()
        Me.trcRate = New System.Windows.Forms.TrackBar()
        Me.grpCSV = New System.Windows.Forms.GroupBox()
        Me.radCSVNewFile = New System.Windows.Forms.RadioButton()
        Me.radCSVAppend = New System.Windows.Forms.RadioButton()
        Me.radCSVOverwrite = New System.Windows.Forms.RadioButton()
        Me.btnCSVFile = New System.Windows.Forms.Button()
        Me.txtCSVFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpMDB = New System.Windows.Forms.GroupBox()
        Me.txtMDBTable = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMDBFile = New System.Windows.Forms.Button()
        Me.txtMDBFile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filOpen = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtMACPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMACName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.statStatus = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpRate.SuspendLayout()
        CType(Me.trcRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCSV.SuspendLayout()
        Me.grpMDB.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 425)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(553, 55)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(6, 6)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(266, 43)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(280, 6)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(267, 43)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMDB)
        Me.GroupBox1.Controls.Add(Me.radCSV)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 52)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Output Method"
        '
        'radMDB
        '
        Me.radMDB.AutoSize = True
        Me.radMDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radMDB.Location = New System.Drawing.Point(252, 21)
        Me.radMDB.Name = "radMDB"
        Me.radMDB.Size = New System.Drawing.Size(298, 21)
        Me.radMDB.TabIndex = 1
        Me.radMDB.TabStop = True
        Me.radMDB.Text = "MS Access 2003-Earlier Compatible (MDB)"
        Me.radMDB.UseVisualStyleBackColor = True
        '
        'radCSV
        '
        Me.radCSV.AutoSize = True
        Me.radCSV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radCSV.Location = New System.Drawing.Point(12, 21)
        Me.radCSV.Name = "radCSV"
        Me.radCSV.Size = New System.Drawing.Size(234, 21)
        Me.radCSV.TabIndex = 0
        Me.radCSV.TabStop = True
        Me.radCSV.Text = "Comma Separated Values (CSV)"
        Me.radCSV.UseVisualStyleBackColor = True
        '
        'grpRate
        '
        Me.grpRate.Controls.Add(Me.trcRate)
        Me.grpRate.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRate.Location = New System.Drawing.Point(0, 52)
        Me.grpRate.Name = "grpRate"
        Me.grpRate.Size = New System.Drawing.Size(553, 65)
        Me.grpRate.TabIndex = 2
        Me.grpRate.TabStop = False
        Me.grpRate.Text = "Record Rate (1000 milliseconds)"
        '
        'trcRate
        '
        Me.trcRate.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.trcRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trcRate.LargeChange = 1000
        Me.trcRate.Location = New System.Drawing.Point(3, 18)
        Me.trcRate.Maximum = 60000
        Me.trcRate.Minimum = 100
        Me.trcRate.Name = "trcRate"
        Me.trcRate.Size = New System.Drawing.Size(547, 44)
        Me.trcRate.SmallChange = 100
        Me.trcRate.TabIndex = 0
        Me.trcRate.TickFrequency = 1000
        Me.trcRate.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.trcRate.Value = 1000
        '
        'grpCSV
        '
        Me.grpCSV.Controls.Add(Me.radCSVNewFile)
        Me.grpCSV.Controls.Add(Me.radCSVAppend)
        Me.grpCSV.Controls.Add(Me.radCSVOverwrite)
        Me.grpCSV.Controls.Add(Me.btnCSVFile)
        Me.grpCSV.Controls.Add(Me.txtCSVFile)
        Me.grpCSV.Controls.Add(Me.Label1)
        Me.grpCSV.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpCSV.Enabled = False
        Me.grpCSV.Location = New System.Drawing.Point(0, 117)
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.Size = New System.Drawing.Size(553, 77)
        Me.grpCSV.TabIndex = 4
        Me.grpCSV.TabStop = False
        Me.grpCSV.Text = "CSV Settings"
        '
        'radCSVNewFile
        '
        Me.radCSVNewFile.AutoSize = True
        Me.radCSVNewFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radCSVNewFile.Location = New System.Drawing.Point(190, 50)
        Me.radCSVNewFile.Name = "radCSVNewFile"
        Me.radCSVNewFile.Size = New System.Drawing.Size(257, 21)
        Me.radCSVNewFile.TabIndex = 5
        Me.radCSVNewFile.TabStop = True
        Me.radCSVNewFile.Text = "New File (Increment Filename Suffix)"
        Me.radCSVNewFile.UseVisualStyleBackColor = True
        '
        'radCSVAppend
        '
        Me.radCSVAppend.AutoSize = True
        Me.radCSVAppend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radCSVAppend.Location = New System.Drawing.Point(106, 50)
        Me.radCSVAppend.Name = "radCSVAppend"
        Me.radCSVAppend.Size = New System.Drawing.Size(78, 21)
        Me.radCSVAppend.TabIndex = 4
        Me.radCSVAppend.TabStop = True
        Me.radCSVAppend.Text = "Append"
        Me.radCSVAppend.UseVisualStyleBackColor = True
        '
        'radCSVOverwrite
        '
        Me.radCSVOverwrite.AutoSize = True
        Me.radCSVOverwrite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radCSVOverwrite.Location = New System.Drawing.Point(6, 50)
        Me.radCSVOverwrite.Name = "radCSVOverwrite"
        Me.radCSVOverwrite.Size = New System.Drawing.Size(89, 21)
        Me.radCSVOverwrite.TabIndex = 3
        Me.radCSVOverwrite.TabStop = True
        Me.radCSVOverwrite.Text = "Overwrite"
        Me.radCSVOverwrite.UseVisualStyleBackColor = True
        '
        'btnCSVFile
        '
        Me.btnCSVFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCSVFile.Location = New System.Drawing.Point(466, 22)
        Me.btnCSVFile.Name = "btnCSVFile"
        Me.btnCSVFile.Size = New System.Drawing.Size(75, 23)
        Me.btnCSVFile.TabIndex = 2
        Me.btnCSVFile.Text = "Browse..."
        Me.btnCSVFile.UseVisualStyleBackColor = True
        '
        'txtCSVFile
        '
        Me.txtCSVFile.Location = New System.Drawing.Point(106, 22)
        Me.txtCSVFile.Name = "txtCSVFile"
        Me.txtCSVFile.Size = New System.Drawing.Size(354, 22)
        Me.txtCSVFile.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Location:"
        '
        'grpMDB
        '
        Me.grpMDB.Controls.Add(Me.txtMDBTable)
        Me.grpMDB.Controls.Add(Me.Label3)
        Me.grpMDB.Controls.Add(Me.btnMDBFile)
        Me.grpMDB.Controls.Add(Me.txtMDBFile)
        Me.grpMDB.Controls.Add(Me.Label2)
        Me.grpMDB.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpMDB.Enabled = False
        Me.grpMDB.Location = New System.Drawing.Point(0, 194)
        Me.grpMDB.Name = "grpMDB"
        Me.grpMDB.Size = New System.Drawing.Size(553, 78)
        Me.grpMDB.TabIndex = 5
        Me.grpMDB.TabStop = False
        Me.grpMDB.Text = "MDB Settings"
        '
        'txtMDBTable
        '
        Me.txtMDBTable.Location = New System.Drawing.Point(106, 47)
        Me.txtMDBTable.Name = "txtMDBTable"
        Me.txtMDBTable.Size = New System.Drawing.Size(435, 22)
        Me.txtMDBTable.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Table Name:"
        '
        'btnMDBFile
        '
        Me.btnMDBFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMDBFile.Location = New System.Drawing.Point(466, 21)
        Me.btnMDBFile.Name = "btnMDBFile"
        Me.btnMDBFile.Size = New System.Drawing.Size(75, 23)
        Me.btnMDBFile.TabIndex = 5
        Me.btnMDBFile.Text = "Browse..."
        Me.btnMDBFile.UseVisualStyleBackColor = True
        '
        'txtMDBFile
        '
        Me.txtMDBFile.Location = New System.Drawing.Point(106, 21)
        Me.txtMDBFile.Name = "txtMDBFile"
        Me.txtMDBFile.Size = New System.Drawing.Size(354, 22)
        Me.txtMDBFile.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "File Location:"
        '
        'filOpen
        '
        Me.filOpen.FileName = "SelectFile"
        Me.filOpen.Title = "Select a file..."
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtMACPort)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtMACName)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 272)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(553, 66)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Machine Connection"
        '
        'txtMACPort
        '
        Me.txtMACPort.Location = New System.Drawing.Point(118, 38)
        Me.txtMACPort.Name = "txtMACPort"
        Me.txtMACPort.Size = New System.Drawing.Size(423, 22)
        Me.txtMACPort.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Data Port:"
        '
        'txtMACName
        '
        Me.txtMACName.Location = New System.Drawing.Point(118, 15)
        Me.txtMACName.Name = "txtMACName"
        Me.txtMACName.Size = New System.Drawing.Size(423, 22)
        Me.txtMACName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Computer Name:"
        '
        'statStatus
        '
        Me.statStatus.Location = New System.Drawing.Point(6, 344)
        Me.statStatus.Multiline = True
        Me.statStatus.Name = "statStatus"
        Me.statStatus.ReadOnly = True
        Me.statStatus.Size = New System.Drawing.Size(541, 74)
        Me.statStatus.TabIndex = 7
        '
        'AddWatch
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(553, 480)
        Me.Controls.Add(Me.statStatus)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.grpMDB)
        Me.Controls.Add(Me.grpCSV)
        Me.Controls.Add(Me.grpRate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddWatch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Watch"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpRate.ResumeLayout(False)
        Me.grpRate.PerformLayout()
        CType(Me.trcRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCSV.ResumeLayout(False)
        Me.grpCSV.PerformLayout()
        Me.grpMDB.ResumeLayout(False)
        Me.grpMDB.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radMDB As System.Windows.Forms.RadioButton
    Friend WithEvents radCSV As System.Windows.Forms.RadioButton
    Friend WithEvents grpRate As System.Windows.Forms.GroupBox
    Friend WithEvents trcRate As System.Windows.Forms.TrackBar
    Friend WithEvents grpCSV As System.Windows.Forms.GroupBox
    Friend WithEvents grpMDB As System.Windows.Forms.GroupBox
    Friend WithEvents filOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCSVFile As System.Windows.Forms.Button
    Friend WithEvents txtCSVFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMDBFile As System.Windows.Forms.Button
    Friend WithEvents txtMDBFile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radCSVNewFile As System.Windows.Forms.RadioButton
    Friend WithEvents radCSVAppend As System.Windows.Forms.RadioButton
    Friend WithEvents radCSVOverwrite As System.Windows.Forms.RadioButton
    Friend WithEvents txtMDBTable As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMACPort As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMACName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents statStatus As System.Windows.Forms.TextBox

End Class
