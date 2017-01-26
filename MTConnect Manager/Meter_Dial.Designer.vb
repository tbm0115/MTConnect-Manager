<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meter_Dial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Meter_Dial))
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.imgDial = New System.Windows.Forms.PictureBox()
        CType(Me.imgDial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtValue
        '
        Me.txtValue.Enabled = False
        Me.txtValue.Location = New System.Drawing.Point(0, 89)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(177, 22)
        Me.txtValue.TabIndex = 0
        '
        'imgDial
        '
        Me.imgDial.Image = CType(resources.GetObject("imgDial.Image"), System.Drawing.Image)
        Me.imgDial.Location = New System.Drawing.Point(0, 0)
        Me.imgDial.Name = "imgDial"
        Me.imgDial.Size = New System.Drawing.Size(177, 83)
        Me.imgDial.TabIndex = 1
        Me.imgDial.TabStop = False
        '
        'TestControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.imgDial)
        Me.Controls.Add(Me.txtValue)
        Me.Name = "TestControl"
        Me.Size = New System.Drawing.Size(177, 108)
        CType(Me.imgDial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents imgDial As System.Windows.Forms.PictureBox

End Class
