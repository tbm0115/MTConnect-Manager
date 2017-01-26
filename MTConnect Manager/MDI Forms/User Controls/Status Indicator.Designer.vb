<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status_Indicator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Status_Indicator))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDataName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoEllipsis = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(3, 68)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(203, 117)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "null"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataName
        '
        Me.lblDataName.AutoEllipsis = True
        Me.lblDataName.BackColor = System.Drawing.Color.Transparent
        Me.lblDataName.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataName.Location = New System.Drawing.Point(53, 11)
        Me.lblDataName.Name = "lblDataName"
        Me.lblDataName.Size = New System.Drawing.Size(94, 57)
        Me.lblDataName.TabIndex = 1
        Me.lblDataName.Text = "null"
        Me.lblDataName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Status_Indicator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblDataName)
        Me.Name = "Status_Indicator"
        Me.Size = New System.Drawing.Size(200, 200)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblStatus As System.Windows.Forms.Label
    Private WithEvents lblDataName As System.Windows.Forms.Label

End Class
