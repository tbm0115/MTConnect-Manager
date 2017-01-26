<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status_View
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Status_View))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlAddIndicator = New System.Windows.Forms.ToolStripMenuItem()
        Me.removeIndicator = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlView = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DialsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(282, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DialsToolStripMenuItem
        '
        Me.DialsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlAddIndicator, Me.removeIndicator})
        Me.DialsToolStripMenuItem.Name = "DialsToolStripMenuItem"
        Me.DialsToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.DialsToolStripMenuItem.Text = "Indicators"
        '
        'tlAddIndicator
        '
        Me.tlAddIndicator.Name = "tlAddIndicator"
        Me.tlAddIndicator.Size = New System.Drawing.Size(210, 24)
        Me.tlAddIndicator.Text = "Add Indicators..."
        '
        'removeIndicator
        '
        Me.removeIndicator.Name = "removeIndicator"
        Me.removeIndicator.Size = New System.Drawing.Size(210, 24)
        Me.removeIndicator.Text = "Remove Indicators..."
        '
        'pnlView
        '
        Me.pnlView.AutoScroll = True
        Me.pnlView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlView.Location = New System.Drawing.Point(0, 28)
        Me.pnlView.Name = "pnlView"
        Me.pnlView.Size = New System.Drawing.Size(282, 227)
        Me.pnlView.TabIndex = 4
        '
        'Status_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.pnlView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Status_View"
        Me.Text = "Dashboard: Status View"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DialsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlAddIndicator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents removeIndicator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlView As System.Windows.Forms.Panel
End Class
