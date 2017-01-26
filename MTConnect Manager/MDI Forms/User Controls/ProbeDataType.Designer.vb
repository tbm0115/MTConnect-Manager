<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProbeDataType
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.grpProbe = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbConvertRatio = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlUnits = New System.Windows.Forms.Panel()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tt = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpProbe.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlUnits.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpProbe
        '
        Me.grpProbe.BackColor = System.Drawing.Color.Transparent
        Me.grpProbe.Controls.Add(Me.Panel3)
        Me.grpProbe.Controls.Add(Me.Panel2)
        Me.grpProbe.Controls.Add(Me.Panel1)
        Me.grpProbe.Controls.Add(Me.pnlUnits)
        Me.grpProbe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProbe.Location = New System.Drawing.Point(5, 5)
        Me.grpProbe.Name = "grpProbe"
        Me.grpProbe.Size = New System.Drawing.Size(301, 174)
        Me.grpProbe.TabIndex = 0
        Me.grpProbe.TabStop = False
        Me.grpProbe.Text = "ProbeDataType"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.cmbConvertRatio)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 128)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel3.Size = New System.Drawing.Size(295, 34)
        Me.Panel3.TabIndex = 3
        '
        'cmbConvertRatio
        '
        Me.cmbConvertRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbConvertRatio.FormattingEnabled = True
        Me.cmbConvertRatio.Location = New System.Drawing.Point(102, 2)
        Me.cmbConvertRatio.Name = "cmbConvertRatio"
        Me.cmbConvertRatio.Size = New System.Drawing.Size(191, 33)
        Me.cmbConvertRatio.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 30)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Convert: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.txtType)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel2.Size = New System.Drawing.Size(295, 34)
        Me.Panel2.TabIndex = 2
        '
        'txtType
        '
        Me.txtType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtType.Enabled = False
        Me.txtType.Location = New System.Drawing.Point(102, 2)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(191, 30)
        Me.txtType.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Type:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txtCategory)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(295, 34)
        Me.Panel1.TabIndex = 1
        '
        'txtCategory
        '
        Me.txtCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCategory.Enabled = False
        Me.txtCategory.Location = New System.Drawing.Point(102, 2)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(191, 30)
        Me.txtCategory.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Category:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlUnits
        '
        Me.pnlUnits.BackColor = System.Drawing.Color.Transparent
        Me.pnlUnits.Controls.Add(Me.txtUnits)
        Me.pnlUnits.Controls.Add(Me.Label1)
        Me.pnlUnits.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUnits.Location = New System.Drawing.Point(3, 26)
        Me.pnlUnits.Name = "pnlUnits"
        Me.pnlUnits.Padding = New System.Windows.Forms.Padding(2)
        Me.pnlUnits.Size = New System.Drawing.Size(295, 34)
        Me.pnlUnits.TabIndex = 0
        '
        'txtUnits
        '
        Me.txtUnits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUnits.Enabled = False
        Me.txtUnits.Location = New System.Drawing.Point(102, 2)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(191, 30)
        Me.txtUnits.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Units:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProbeDataType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.grpProbe)
        Me.MinimumSize = New System.Drawing.Size(300, 140)
        Me.Name = "ProbeDataType"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(333, 188)
        Me.grpProbe.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlUnits.ResumeLayout(False)
        Me.pnlUnits.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpProbe As System.Windows.Forms.GroupBox
    Friend WithEvents pnlUnits As System.Windows.Forms.Panel
    Friend WithEvents txtUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbConvertRatio As System.Windows.Forms.ComboBox
    Friend WithEvents tt As System.Windows.Forms.ToolTip

End Class
