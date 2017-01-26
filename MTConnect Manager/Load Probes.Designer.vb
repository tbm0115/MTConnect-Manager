<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Load_Probes
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
        Me.DetailsLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DetailsLayoutPanel.SuspendLayout()
        Me.MainLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DetailsLayoutPanel
        '
        Me.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.DetailsLayoutPanel.ColumnCount = 1
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
        Me.DetailsLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.DetailsLayoutPanel.Controls.Add(Me.Version, 0, 0)
        Me.DetailsLayoutPanel.Controls.Add(Me.Copyright, 0, 1)
        Me.DetailsLayoutPanel.Location = New System.Drawing.Point(124, 257)
        Me.DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.DetailsLayoutPanel.Size = New System.Drawing.Size(247, 37)
        Me.DetailsLayoutPanel.TabIndex = 1
        '
        'Version
        '
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(3, 0)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(241, 18)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version {0}.{1:00}"
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(3, 18)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(241, 19)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(5, 157)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(486, 54)
        Me.ApplicationTitle.TabIndex = 2
        Me.ApplicationTitle.Text = "Application Title"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainLayoutPanel.ColumnCount = 1
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.MainLayoutPanel.Controls.Add(Me.ApplicationTitle, 0, 1)
        Me.MainLayoutPanel.Controls.Add(Me.DetailsLayoutPanel, 1, 1)
        Me.MainLayoutPanel.Controls.Add(Me.Panel1, 0, 0)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.MainLayoutPanel.RowCount = 3
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(496, 305)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.MTConnect_Manager.My.Resources.Resources.Logo_Final2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 149)
        Me.Panel1.TabIndex = 3
        '
        'Load_Probes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Load_Probes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.DetailsLayoutPanel.ResumeLayout(False)
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
