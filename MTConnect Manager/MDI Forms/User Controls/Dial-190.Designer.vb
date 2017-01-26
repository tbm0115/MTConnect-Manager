<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dial_190
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dial_190))
        Me.lblValue = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblValue
        '
        Me.lblValue.BackColor = System.Drawing.Color.Transparent
        Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(122, 163)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(88, 33)
        Me.lblValue.TabIndex = 0
        Me.lblValue.Text = "0"
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblData
        '
        Me.lblData.AutoEllipsis = True
        Me.lblData.BackColor = System.Drawing.Color.Transparent
        Me.lblData.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(3, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(340, 33)
        Me.lblData.TabIndex = 1
        Me.lblData.Text = "null"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dial_190
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblValue)
        Me.Name = "Dial_190"
        Me.Size = New System.Drawing.Size(346, 196)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label

End Class
