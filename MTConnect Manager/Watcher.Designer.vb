<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Watcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Watcher))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statWatchCnt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SessionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sessionLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.sessionStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.sessionStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlChangeRate = New System.Windows.Forms.ToolStripMenuItem()
        Me.WatchesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.watchAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.watchRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlClearLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlSaveLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlSession = New System.Windows.Forms.Panel()
        Me.folSave = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statWatchCnt})
        Me.StatusStrip1.Location = New System.Drawing.Point(5, 325)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(572, 25)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statWatchCnt
        '
        Me.statWatchCnt.Name = "statWatchCnt"
        Me.statWatchCnt.Size = New System.Drawing.Size(62, 20)
        Me.statWatchCnt.Text = "watches"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SessionsToolStripMenuItem, Me.WatchesToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(572, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SessionsToolStripMenuItem
        '
        Me.SessionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sessionLoad, Me.sessionStop, Me.sessionStart, Me.ToolStripSeparator1, Me.tlChangeRate})
        Me.SessionsToolStripMenuItem.Name = "SessionsToolStripMenuItem"
        Me.SessionsToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SessionsToolStripMenuItem.Text = "Sessions"
        '
        'sessionLoad
        '
        Me.sessionLoad.Name = "sessionLoad"
        Me.sessionLoad.Size = New System.Drawing.Size(171, 24)
        Me.sessionLoad.Text = "Load..."
        '
        'sessionStop
        '
        Me.sessionStop.Name = "sessionStop"
        Me.sessionStop.Size = New System.Drawing.Size(171, 24)
        Me.sessionStop.Text = "Stop"
        '
        'sessionStart
        '
        Me.sessionStart.Enabled = False
        Me.sessionStart.Name = "sessionStart"
        Me.sessionStart.Size = New System.Drawing.Size(171, 24)
        Me.sessionStart.Text = "Start"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'tlChangeRate
        '
        Me.tlChangeRate.Name = "tlChangeRate"
        Me.tlChangeRate.Size = New System.Drawing.Size(171, 24)
        Me.tlChangeRate.Text = "Change Rate..."
        Me.tlChangeRate.ToolTipText = "This is a temporary change for the current set of sessions"
        '
        'WatchesToolStripMenuItem
        '
        Me.WatchesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.watchAdd, Me.watchRemove})
        Me.WatchesToolStripMenuItem.Name = "WatchesToolStripMenuItem"
        Me.WatchesToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.WatchesToolStripMenuItem.Text = "Watches"
        '
        'watchAdd
        '
        Me.watchAdd.Name = "watchAdd"
        Me.watchAdd.Size = New System.Drawing.Size(141, 24)
        Me.watchAdd.Text = "Add..."
        '
        'watchRemove
        '
        Me.watchRemove.Name = "watchRemove"
        Me.watchRemove.Size = New System.Drawing.Size(141, 24)
        Me.watchRemove.Text = "Remove..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlClearLogs, Me.tlSaveLogs})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'tlClearLogs
        '
        Me.tlClearLogs.Name = "tlClearLogs"
        Me.tlClearLogs.Size = New System.Drawing.Size(156, 24)
        Me.tlClearLogs.Text = "Clear Logs..."
        '
        'tlSaveLogs
        '
        Me.tlSaveLogs.Name = "tlSaveLogs"
        Me.tlSaveLogs.Size = New System.Drawing.Size(156, 24)
        Me.tlSaveLogs.Text = "Save Logs..."
        '
        'pnlSession
        '
        Me.pnlSession.AutoScroll = True
        Me.pnlSession.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.pnlSession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSession.Location = New System.Drawing.Point(5, 33)
        Me.pnlSession.Name = "pnlSession"
        Me.pnlSession.Size = New System.Drawing.Size(572, 292)
        Me.pnlSession.TabIndex = 2
        '
        'Watcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(582, 355)
        Me.Controls.Add(Me.pnlSession)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Watcher"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "Watcher"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SessionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sessionLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WatchesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents watchAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents watchRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statWatchCnt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sessionStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sessionStart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlChangeRate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlClearLogs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlSaveLogs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents folSave As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents pnlSession As System.Windows.Forms.Panel
End Class
