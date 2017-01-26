<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OEE_Add
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
        Me.filOpen = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbWorkCenter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.btnFileOpen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTable = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 108)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(580, 62)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(6, 6)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(280, 50)
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
        Me.Cancel_Button.Size = New System.Drawing.Size(280, 50)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'filOpen
        '
        Me.filOpen.FileName = "Open File"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbWorkCenter)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(580, 29)
        Me.Panel1.TabIndex = 1
        '
        'cmbWorkCenter
        '
        Me.cmbWorkCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbWorkCenter.FormattingEnabled = True
        Me.cmbWorkCenter.Location = New System.Drawing.Point(221, 2)
        Me.cmbWorkCenter.Name = "cmbWorkCenter"
        Me.cmbWorkCenter.Size = New System.Drawing.Size(357, 24)
        Me.cmbWorkCenter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a WorkCenter:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtDatabase)
        Me.Panel2.Controls.Add(Me.btnFileOpen)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(580, 35)
        Me.Panel2.TabIndex = 2
        '
        'txtDatabase
        '
        Me.txtDatabase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDatabase.Location = New System.Drawing.Point(221, 2)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(274, 27)
        Me.txtDatabase.TabIndex = 2
        '
        'btnFileOpen
        '
        Me.btnFileOpen.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFileOpen.Location = New System.Drawing.Point(495, 2)
        Me.btnFileOpen.Name = "btnFileOpen"
        Me.btnFileOpen.Size = New System.Drawing.Size(83, 31)
        Me.btnFileOpen.TabIndex = 1
        Me.btnFileOpen.Text = "Browse..."
        Me.btnFileOpen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "MTConnectDatabase File:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtTable)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(580, 35)
        Me.Panel3.TabIndex = 3
        '
        'txtTable
        '
        Me.txtTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTable.Enabled = False
        Me.txtTable.FormattingEnabled = True
        Me.txtTable.Location = New System.Drawing.Point(221, 2)
        Me.txtTable.Name = "txtTable"
        Me.txtTable.Size = New System.Drawing.Size(357, 28)
        Me.txtTable.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Table Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OEE_Add
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(580, 170)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OEE_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dashboard: OEE     -     Add OEE"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents filOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbWorkCenter As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents btnFileOpen As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTable As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
