<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_Real_Time_Graph
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard_Real_Time_Graph))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SeriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.seriesAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.seriesRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimelineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timeRange = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveCSV = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toggleDataPane = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.filSave = New System.Windows.Forms.SaveFileDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlProbeContainer = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeriesToolStripMenuItem, Me.TimelineToolStripMenuItem, Me.SaveToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(582, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SeriesToolStripMenuItem
        '
        Me.SeriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.seriesAdd, Me.seriesRemove, Me.ViewListToolStripMenuItem})
        Me.SeriesToolStripMenuItem.Name = "SeriesToolStripMenuItem"
        Me.SeriesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SeriesToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.SeriesToolStripMenuItem.Text = "&Series"
        '
        'seriesAdd
        '
        Me.seriesAdd.Name = "seriesAdd"
        Me.seriesAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.seriesAdd.Size = New System.Drawing.Size(190, 24)
        Me.seriesAdd.Text = "&Add..."
        '
        'seriesRemove
        '
        Me.seriesRemove.Name = "seriesRemove"
        Me.seriesRemove.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.seriesRemove.Size = New System.Drawing.Size(190, 24)
        Me.seriesRemove.Text = "&Remove..."
        '
        'ViewListToolStripMenuItem
        '
        Me.ViewListToolStripMenuItem.Name = "ViewListToolStripMenuItem"
        Me.ViewListToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.ViewListToolStripMenuItem.Text = "View List..."
        '
        'TimelineToolStripMenuItem
        '
        Me.TimelineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.timeRange})
        Me.TimelineToolStripMenuItem.Name = "TimelineToolStripMenuItem"
        Me.TimelineToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TimelineToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.TimelineToolStripMenuItem.Text = "&Timeline"
        '
        'timeRange
        '
        Me.timeRange.Name = "timeRange"
        Me.timeRange.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.timeRange.Size = New System.Drawing.Size(201, 24)
        Me.timeRange.Text = "Set &Range..."
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.saveImage, Me.saveCSV})
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'saveImage
        '
        Me.saveImage.Name = "saveImage"
        Me.saveImage.Size = New System.Drawing.Size(292, 24)
        Me.saveImage.Text = "&Image..."
        '
        'saveCSV
        '
        Me.saveCSV.Name = "saveCSV"
        Me.saveCSV.Size = New System.Drawing.Size(292, 24)
        Me.saveCSV.Text = "Comma Separated &Value (CSV)..."
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toggleDataPane})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'toggleDataPane
        '
        Me.toggleDataPane.Checked = True
        Me.toggleDataPane.CheckOnClick = True
        Me.toggleDataPane.CheckState = System.Windows.Forms.CheckState.Checked
        Me.toggleDataPane.Name = "toggleDataPane"
        Me.toggleDataPane.Size = New System.Drawing.Size(186, 24)
        Me.toggleDataPane.Text = "Show Data Pane"
        '
        'RefreshTimer
        '
        Me.RefreshTimer.Interval = 1000
        '
        'filSave
        '
        Me.filSave.Title = "Save a file..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Chart1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Panel1MinSize = 300
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlProbeContainer)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Size = New System.Drawing.Size(582, 527)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 4
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "Main"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(2, 2)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "Main"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(574, 292)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'pnlProbeContainer
        '
        Me.pnlProbeContainer.AutoScroll = True
        Me.pnlProbeContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProbeContainer.Location = New System.Drawing.Point(2, 2)
        Me.pnlProbeContainer.Name = "pnlProbeContainer"
        Me.pnlProbeContainer.Size = New System.Drawing.Size(574, 209)
        Me.pnlProbeContainer.TabIndex = 0
        '
        'Dashboard_Real_Time_Graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(582, 555)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard_Real_Time_Graph"
        Me.Text = "Dashboard: Real-Time Graph"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SeriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents seriesAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents seriesRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimelineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents timeRange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshTimer As System.Windows.Forms.Timer
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents saveImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents saveCSV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents filSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toggleDataPane As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlProbeContainer As System.Windows.Forms.Panel
End Class
