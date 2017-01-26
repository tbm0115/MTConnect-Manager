<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newRealTimeGraph = New System.Windows.Forms.ToolStripMenuItem()
        Me.newDial = New System.Windows.Forms.ToolStripMenuItem()
        Me.newStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.newOEE = New System.Windows.Forms.ToolStripMenuItem()
        Me.loadDashboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlControlColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsOuputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOutputOEE = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.statStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statMousePos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statProcessProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.statMemoryUsage = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSkipForward = New System.Windows.Forms.Button()
        Me.btnStepForward = New System.Windows.Forms.Button()
        Me.btnStepBack = New System.Windows.Forms.Button()
        Me.btnSkipBack = New System.Windows.Forms.Button()
        Me.filOpen = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbView = New System.Windows.Forms.TrackBar()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dateView = New System.Windows.Forms.DateTimePicker()
        Me.timeView = New System.Windows.Forms.DateTimePicker()
        Me.lblSelectedTime = New System.Windows.Forms.Label()
        Me.lblFirstDT = New System.Windows.Forms.Label()
        Me.lblLastDT = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tbView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.WindowsMenu, Me.ViewToolStripMenuItem, Me.ReportsOuputToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(757, 28)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newRealTimeGraph, Me.newDial, Me.newStatus, Me.newOEE, Me.loadDashboard})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'newRealTimeGraph
        '
        Me.newRealTimeGraph.Name = "newRealTimeGraph"
        Me.newRealTimeGraph.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.newRealTimeGraph.Size = New System.Drawing.Size(272, 24)
        Me.newRealTimeGraph.Text = "New Real-Time &Graph"
        '
        'newDial
        '
        Me.newDial.Name = "newDial"
        Me.newDial.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.newDial.Size = New System.Drawing.Size(272, 24)
        Me.newDial.Text = "New &Dial View"
        '
        'newStatus
        '
        Me.newStatus.Name = "newStatus"
        Me.newStatus.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.newStatus.Size = New System.Drawing.Size(272, 24)
        Me.newStatus.Text = "New &Status View"
        '
        'newOEE
        '
        Me.newOEE.Name = "newOEE"
        Me.newOEE.Size = New System.Drawing.Size(272, 24)
        Me.newOEE.Text = "New OEE View"
        '
        'loadDashboard
        '
        Me.loadDashboard.Name = "loadDashboard"
        Me.loadDashboard.Size = New System.Drawing.Size(272, 24)
        Me.loadDashboard.Text = "Load Dashboard Session..."
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ToolStripSeparator9})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(82, 24)
        Me.WindowsMenu.Text = "&Windows"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(173, 6)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlControlColumns})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'tlControlColumns
        '
        Me.tlControlColumns.Name = "tlControlColumns"
        Me.tlControlColumns.Size = New System.Drawing.Size(188, 24)
        Me.tlControlColumns.Text = "Control Columns"
        '
        'ReportsOuputToolStripMenuItem
        '
        Me.ReportsOuputToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOutputOEE})
        Me.ReportsOuputToolStripMenuItem.Name = "ReportsOuputToolStripMenuItem"
        Me.ReportsOuputToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.ReportsOuputToolStripMenuItem.Text = "Reports/Ouput"
        '
        'mnuOutputOEE
        '
        Me.mnuOutputOEE.Image = CType(resources.GetObject("mnuOutputOEE.Image"), System.Drawing.Image)
        Me.mnuOutputOEE.Name = "mnuOutputOEE"
        Me.mnuOutputOEE.Size = New System.Drawing.Size(105, 24)
        Me.mnuOutputOEE.Text = "OEE"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statStatus, Me.statMousePos, Me.statProcessProgress, Me.statMemoryUsage})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 529)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(757, 29)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'statStatus
        '
        Me.statStatus.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.statStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.statStatus.Name = "statStatus"
        Me.statStatus.Size = New System.Drawing.Size(53, 24)
        Me.statStatus.Text = "Status"
        '
        'statMousePos
        '
        Me.statMousePos.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.statMousePos.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.statMousePos.Name = "statMousePos"
        Me.statMousePos.Size = New System.Drawing.Size(114, 24)
        Me.statMousePos.Text = "Mouse Position"
        '
        'statProcessProgress
        '
        Me.statProcessProgress.AutoSize = False
        Me.statProcessProgress.Name = "statProcessProgress"
        Me.statProcessProgress.Size = New System.Drawing.Size(200, 23)
        Me.statProcessProgress.ToolTipText = "Memory Load ([Total Processing Time for each View] / [Refresh Rate])"
        '
        'statMemoryUsage
        '
        Me.statMemoryUsage.Name = "statMemoryUsage"
        Me.statMemoryUsage.Size = New System.Drawing.Size(100, 23)
        '
        'btnSkipForward
        '
        Me.btnSkipForward.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSkipForward.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSkipForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkipForward.Image = CType(resources.GetObject("btnSkipForward.Image"), System.Drawing.Image)
        Me.btnSkipForward.Location = New System.Drawing.Point(678, 3)
        Me.btnSkipForward.Name = "btnSkipForward"
        Me.btnSkipForward.Size = New System.Drawing.Size(70, 29)
        Me.btnSkipForward.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.btnSkipForward, "Forward one hour")
        Me.btnSkipForward.UseVisualStyleBackColor = False
        '
        'btnStepForward
        '
        Me.btnStepForward.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStepForward.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStepForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStepForward.Image = CType(resources.GetObject("btnStepForward.Image"), System.Drawing.Image)
        Me.btnStepForward.Location = New System.Drawing.Point(603, 3)
        Me.btnStepForward.Name = "btnStepForward"
        Me.btnStepForward.Size = New System.Drawing.Size(69, 29)
        Me.btnStepForward.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.btnStepForward, "Forward one minute")
        Me.btnStepForward.UseVisualStyleBackColor = False
        '
        'btnStepBack
        '
        Me.btnStepBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStepBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStepBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStepBack.Image = CType(resources.GetObject("btnStepBack.Image"), System.Drawing.Image)
        Me.btnStepBack.Location = New System.Drawing.Point(78, 3)
        Me.btnStepBack.Name = "btnStepBack"
        Me.btnStepBack.Size = New System.Drawing.Size(69, 29)
        Me.btnStepBack.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.btnStepBack, "Back one minute")
        Me.btnStepBack.UseVisualStyleBackColor = False
        '
        'btnSkipBack
        '
        Me.btnSkipBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSkipBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSkipBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkipBack.Image = CType(resources.GetObject("btnSkipBack.Image"), System.Drawing.Image)
        Me.btnSkipBack.Location = New System.Drawing.Point(3, 3)
        Me.btnSkipBack.Name = "btnSkipBack"
        Me.btnSkipBack.Size = New System.Drawing.Size(69, 29)
        Me.btnSkipBack.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.btnSkipBack, "Back one hour")
        Me.btnSkipBack.UseVisualStyleBackColor = False
        '
        'filOpen
        '
        Me.filOpen.FileName = "Open File"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbView, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFirstDT, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLastDT, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 83)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'tbView
        '
        Me.tbView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbView.Location = New System.Drawing.Point(116, 44)
        Me.tbView.Name = "tbView"
        Me.tbView.Size = New System.Drawing.Size(523, 36)
        Me.tbView.TabIndex = 0
        Me.tbView.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnSkipForward, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnStepForward, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnStepBack, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSkipBack, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dateView, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.timeView, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSelectedTime, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(751, 35)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'dateView
        '
        Me.dateView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dateView.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateView.Location = New System.Drawing.Point(303, 3)
        Me.dateView.Name = "dateView"
        Me.dateView.Size = New System.Drawing.Size(144, 22)
        Me.dateView.TabIndex = 4
        '
        'timeView
        '
        Me.timeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeView.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeView.Location = New System.Drawing.Point(453, 3)
        Me.timeView.Name = "timeView"
        Me.timeView.ShowUpDown = True
        Me.timeView.Size = New System.Drawing.Size(144, 22)
        Me.timeView.TabIndex = 5
        '
        'lblSelectedTime
        '
        Me.lblSelectedTime.AutoSize = True
        Me.lblSelectedTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSelectedTime.Location = New System.Drawing.Point(153, 0)
        Me.lblSelectedTime.Name = "lblSelectedTime"
        Me.lblSelectedTime.Size = New System.Drawing.Size(144, 35)
        Me.lblSelectedTime.TabIndex = 6
        Me.lblSelectedTime.Text = "Selected Time"
        Me.lblSelectedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFirstDT
        '
        Me.lblFirstDT.AutoSize = True
        Me.lblFirstDT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFirstDT.Location = New System.Drawing.Point(3, 41)
        Me.lblFirstDT.Name = "lblFirstDT"
        Me.lblFirstDT.Size = New System.Drawing.Size(107, 42)
        Me.lblFirstDT.TabIndex = 6
        Me.lblFirstDT.Text = "First Date/Time"
        Me.lblFirstDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastDT
        '
        Me.lblLastDT.AutoSize = True
        Me.lblLastDT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLastDT.Location = New System.Drawing.Point(645, 41)
        Me.lblLastDT.Name = "lblLastDT"
        Me.lblLastDT.Size = New System.Drawing.Size(109, 42)
        Me.lblLastDT.TabIndex = 7
        Me.lblLastDT.Text = "Last Date/Time"
        Me.lblLastDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 558)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(775, 600)
        Me.Name = "Dashboard"
        Me.Text = "MTConnect Dashboard"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.tbView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents statStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newRealTimeGraph As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statMousePos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents newDial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlControlColumns As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents loadDashboard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newOEE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents filOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents statProcessProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ReportsOuputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOutputOEE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbView As System.Windows.Forms.TrackBar
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSkipBack As System.Windows.Forms.Button
    Friend WithEvents btnSkipForward As System.Windows.Forms.Button
    Friend WithEvents btnStepForward As System.Windows.Forms.Button
    Friend WithEvents btnStepBack As System.Windows.Forms.Button
    Friend WithEvents dateView As System.Windows.Forms.DateTimePicker
    Friend WithEvents timeView As System.Windows.Forms.DateTimePicker
    Friend WithEvents statMemoryUsage As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblFirstDT As System.Windows.Forms.Label
    Friend WithEvents lblLastDT As System.Windows.Forms.Label
    Friend WithEvents lblSelectedTime As System.Windows.Forms.Label

End Class
