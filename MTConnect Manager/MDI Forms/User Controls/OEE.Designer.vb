<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OEE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OEE))
        Me.lblVal = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picOEE = New System.Windows.Forms.PictureBox()
        Me.pnlA = New System.Windows.Forms.Panel()
        Me.prgA = New System.Windows.Forms.ProgressBar()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.pnlP = New System.Windows.Forms.Panel()
        Me.prgP = New System.Windows.Forms.ProgressBar()
        Me.lblPerformance = New System.Windows.Forms.Label()
        Me.pnlQ = New System.Windows.Forms.Panel()
        Me.prgQ = New System.Windows.Forms.ProgressBar()
        Me.lblQuality = New System.Windows.Forms.Label()
        Me.tTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picOEE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlA.SuspendLayout()
        Me.pnlP.SuspendLayout()
        Me.pnlQ.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVal
        '
        Me.lblVal.BackColor = System.Drawing.Color.LightGray
        Me.lblVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVal.Location = New System.Drawing.Point(39, 145)
        Me.lblVal.Name = "lblVal"
        Me.lblVal.Size = New System.Drawing.Size(122, 35)
        Me.lblVal.TabIndex = 1
        Me.lblVal.Text = "0%"
        Me.lblVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(200, 28)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "OEE"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tTip.SetToolTip(Me.lblTitle, "Overall Equipment Effectiveness")
        '
        'picOEE
        '
        Me.picOEE.Dock = System.Windows.Forms.DockStyle.Top
        Me.picOEE.Image = Global.MTConnect_Manager.My.Resources.Resources.OEE
        Me.picOEE.Location = New System.Drawing.Point(0, 28)
        Me.picOEE.Name = "picOEE"
        Me.picOEE.Size = New System.Drawing.Size(200, 200)
        Me.picOEE.TabIndex = 3
        Me.picOEE.TabStop = False
        '
        'pnlA
        '
        Me.pnlA.BackColor = System.Drawing.Color.Transparent
        Me.pnlA.Controls.Add(Me.prgA)
        Me.pnlA.Controls.Add(Me.lblAvailability)
        Me.pnlA.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlA.Location = New System.Drawing.Point(0, 228)
        Me.pnlA.Name = "pnlA"
        Me.pnlA.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlA.Size = New System.Drawing.Size(200, 32)
        Me.pnlA.TabIndex = 4
        '
        'prgA
        '
        Me.prgA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prgA.Location = New System.Drawing.Point(94, 1)
        Me.prgA.Name = "prgA"
        Me.prgA.Size = New System.Drawing.Size(105, 30)
        Me.prgA.TabIndex = 1
        '
        'lblAvailability
        '
        Me.lblAvailability.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAvailability.Location = New System.Drawing.Point(1, 1)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(93, 30)
        Me.lblAvailability.TabIndex = 0
        Me.lblAvailability.Text = "Availability:"
        Me.lblAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tTip.SetToolTip(Me.lblAvailability, "Operating Time(OT) / Planned Production Time(PT)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PT = Shift Length (in minutes" & _
        ") - Breaks (in minutes)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OT = PT(in minutes) - Downtime(in minutes)")
        '
        'pnlP
        '
        Me.pnlP.BackColor = System.Drawing.Color.Transparent
        Me.pnlP.Controls.Add(Me.prgP)
        Me.pnlP.Controls.Add(Me.lblPerformance)
        Me.pnlP.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlP.Location = New System.Drawing.Point(0, 260)
        Me.pnlP.Name = "pnlP"
        Me.pnlP.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlP.Size = New System.Drawing.Size(200, 32)
        Me.pnlP.TabIndex = 5
        '
        'prgP
        '
        Me.prgP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prgP.Location = New System.Drawing.Point(94, 1)
        Me.prgP.Name = "prgP"
        Me.prgP.Size = New System.Drawing.Size(105, 30)
        Me.prgP.TabIndex = 1
        '
        'lblPerformance
        '
        Me.lblPerformance.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPerformance.Location = New System.Drawing.Point(1, 1)
        Me.lblPerformance.Name = "lblPerformance"
        Me.lblPerformance.Size = New System.Drawing.Size(93, 30)
        Me.lblPerformance.TabIndex = 0
        Me.lblPerformance.Text = "Performance:"
        Me.lblPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tTip.SetToolTip(Me.lblPerformance, resources.GetString("lblPerformance.ToolTip"))
        '
        'pnlQ
        '
        Me.pnlQ.BackColor = System.Drawing.Color.Transparent
        Me.pnlQ.Controls.Add(Me.prgQ)
        Me.pnlQ.Controls.Add(Me.lblQuality)
        Me.pnlQ.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlQ.Location = New System.Drawing.Point(0, 292)
        Me.pnlQ.Name = "pnlQ"
        Me.pnlQ.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlQ.Size = New System.Drawing.Size(200, 32)
        Me.pnlQ.TabIndex = 6
        '
        'prgQ
        '
        Me.prgQ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prgQ.Location = New System.Drawing.Point(94, 1)
        Me.prgQ.Name = "prgQ"
        Me.prgQ.Size = New System.Drawing.Size(105, 30)
        Me.prgQ.TabIndex = 1
        '
        'lblQuality
        '
        Me.lblQuality.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblQuality.Location = New System.Drawing.Point(1, 1)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(93, 30)
        Me.lblQuality.TabIndex = 0
        Me.lblQuality.Text = "Quality:"
        Me.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tTip.SetToolTip(Me.lblQuality, "Good Product(GP) / Total Product(TP)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TP = Total Product(in units)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GP = Total " & _
        "Product(in units) - Rejected Product(in units)")
        '
        'OEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlQ)
        Me.Controls.Add(Me.pnlP)
        Me.Controls.Add(Me.pnlA)
        Me.Controls.Add(Me.lblVal)
        Me.Controls.Add(Me.picOEE)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "OEE"
        Me.Size = New System.Drawing.Size(200, 326)
        CType(Me.picOEE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlA.ResumeLayout(False)
        Me.pnlP.ResumeLayout(False)
        Me.pnlQ.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblVal As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picOEE As System.Windows.Forms.PictureBox
    Friend WithEvents pnlA As System.Windows.Forms.Panel
    Friend WithEvents lblAvailability As System.Windows.Forms.Label
    Friend WithEvents prgA As System.Windows.Forms.ProgressBar
    Friend WithEvents pnlP As System.Windows.Forms.Panel
    Friend WithEvents prgP As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPerformance As System.Windows.Forms.Label
    Friend WithEvents pnlQ As System.Windows.Forms.Panel
    Friend WithEvents prgQ As System.Windows.Forms.ProgressBar
    Friend WithEvents lblQuality As System.Windows.Forms.Label
    Friend WithEvents tTip As System.Windows.Forms.ToolTip

End Class
