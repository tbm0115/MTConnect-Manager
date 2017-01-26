<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveWatch
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
        Me.lstWatches = New System.Windows.Forms.ListBox()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtFilepath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 279)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(580, 56)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(6, 6)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(280, 44)
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
        Me.Cancel_Button.Size = New System.Drawing.Size(280, 44)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lstWatches
        '
        Me.lstWatches.Dock = System.Windows.Forms.DockStyle.Top
        Me.lstWatches.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWatches.FormattingEnabled = True
        Me.lstWatches.ItemHeight = 22
        Me.lstWatches.Location = New System.Drawing.Point(0, 0)
        Me.lstWatches.Name = "lstWatches"
        Me.lstWatches.Size = New System.Drawing.Size(580, 114)
        Me.lstWatches.TabIndex = 1
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.Panel5)
        Me.grpInfo.Controls.Add(Me.Panel4)
        Me.grpInfo.Controls.Add(Me.Panel3)
        Me.grpInfo.Controls.Add(Me.Panel2)
        Me.grpInfo.Controls.Add(Me.Panel1)
        Me.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpInfo.Location = New System.Drawing.Point(0, 114)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(580, 165)
        Me.grpInfo.TabIndex = 2
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Information"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtFilepath)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 130)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel5.Size = New System.Drawing.Size(574, 28)
        Me.Panel5.TabIndex = 4
        '
        'txtFilepath
        '
        Me.txtFilepath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFilepath.Enabled = False
        Me.txtFilepath.Location = New System.Drawing.Point(130, 2)
        Me.txtFilepath.Name = "txtFilepath"
        Me.txtFilepath.Size = New System.Drawing.Size(442, 22)
        Me.txtFilepath.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Filepath:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtType)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 102)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel4.Size = New System.Drawing.Size(574, 28)
        Me.Panel4.TabIndex = 3
        '
        'txtType
        '
        Me.txtType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtType.Enabled = False
        Me.txtType.Location = New System.Drawing.Point(130, 2)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(442, 22)
        Me.txtType.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Output Type:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtRate)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(574, 28)
        Me.Panel3.TabIndex = 2
        '
        'txtRate
        '
        Me.txtRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRate.Enabled = False
        Me.txtRate.Location = New System.Drawing.Point(130, 2)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(442, 22)
        Me.txtRate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Record Rate:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtPort)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(574, 28)
        Me.Panel2.TabIndex = 1
        '
        'txtPort
        '
        Me.txtPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPort.Enabled = False
        Me.txtPort.Location = New System.Drawing.Point(130, 2)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(442, 22)
        Me.txtPort.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Port:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(574, 28)
        Me.Panel1.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(130, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(442, 22)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RemoveWatch
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(580, 335)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.lstWatches)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RemoveWatch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Remove Watch"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpInfo.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lstWatches As System.Windows.Forms.ListBox
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtFilepath As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
