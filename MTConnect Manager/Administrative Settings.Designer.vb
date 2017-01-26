<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrative_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrative_Settings))
        Me.tabSettings = New System.Windows.Forms.TabControl()
        Me.tabAddWatch = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbDesc3 = New System.Windows.Forms.RichTextBox()
        Me.txtDefRefresh = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMinRefresh = New System.Windows.Forms.TextBox()
        Me.txtMaxRefresh = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtbDesc2 = New System.Windows.Forms.RichTextBox()
        Me.txtDefDatFile = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbDesc1 = New System.Windows.Forms.RichTextBox()
        Me.radCSV = New System.Windows.Forms.RadioButton()
        Me.radMDB = New System.Windows.Forms.RadioButton()
        Me.tabRecWatch = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rtbDesc5 = New System.Windows.Forms.RichTextBox()
        Me.timeRecord = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtbDesc4 = New System.Windows.Forms.RichTextBox()
        Me.txtSemiSuspend = New System.Windows.Forms.TextBox()
        Me.tabDash = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rtbDesc7 = New System.Windows.Forms.RichTextBox()
        Me.txtMaxRec = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rtbDesc6 = New System.Windows.Forms.RichTextBox()
        Me.txtControlColumns = New System.Windows.Forms.TextBox()
        Me.tabReports = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rtbDesc8 = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtstrOEE = New System.Windows.Forms.Label()
        Me.chkblnOEE = New System.Windows.Forms.CheckBox()
        Me.btnstrOEE = New System.Windows.Forms.Button()
        Me.tabSettings.SuspendLayout()
        Me.tabAddWatch.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabRecWatch.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.tabDash.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.tabReports.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.tabAddWatch)
        Me.tabSettings.Controls.Add(Me.tabRecWatch)
        Me.tabSettings.Controls.Add(Me.tabDash)
        Me.tabSettings.Controls.Add(Me.tabReports)
        Me.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSettings.Location = New System.Drawing.Point(0, 0)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.SelectedIndex = 0
        Me.tabSettings.Size = New System.Drawing.Size(482, 427)
        Me.tabSettings.TabIndex = 0
        '
        'tabAddWatch
        '
        Me.tabAddWatch.Controls.Add(Me.TableLayoutPanel3)
        Me.tabAddWatch.Controls.Add(Me.TableLayoutPanel2)
        Me.tabAddWatch.Controls.Add(Me.TableLayoutPanel1)
        Me.tabAddWatch.Location = New System.Drawing.Point(4, 25)
        Me.tabAddWatch.Name = "tabAddWatch"
        Me.tabAddWatch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAddWatch.Size = New System.Drawing.Size(474, 398)
        Me.tabAddWatch.TabIndex = 0
        Me.tabAddWatch.Text = "Adding Watches"
        Me.tabAddWatch.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.rtbDesc3, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txtDefRefresh, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtMinRefresh, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtMaxRefresh, 1, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 238)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.02041!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(468, 152)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Default Refresh Rate:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbDesc3
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.rtbDesc3, 3)
        Me.rtbDesc3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDesc3.Location = New System.Drawing.Point(3, 75)
        Me.rtbDesc3.Name = "rtbDesc3"
        Me.rtbDesc3.ReadOnly = True
        Me.rtbDesc3.Size = New System.Drawing.Size(462, 74)
        Me.rtbDesc3.TabIndex = 1
        Me.rtbDesc3.Text = resources.GetString("rtbDesc3.Text")
        '
        'txtDefRefresh
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtDefRefresh, 2)
        Me.txtDefRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDefRefresh.Location = New System.Drawing.Point(190, 3)
        Me.txtDefRefresh.Name = "txtDefRefresh"
        Me.txtDefRefresh.Size = New System.Drawing.Size(275, 22)
        Me.txtDefRefresh.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Minimum Refresh Rate:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Maximum Refresh Rate:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMinRefresh
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtMinRefresh, 2)
        Me.txtMinRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMinRefresh.Location = New System.Drawing.Point(190, 27)
        Me.txtMinRefresh.Name = "txtMinRefresh"
        Me.txtMinRefresh.Size = New System.Drawing.Size(275, 22)
        Me.txtMinRefresh.TabIndex = 5
        '
        'txtMaxRefresh
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtMaxRefresh, 2)
        Me.txtMaxRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMaxRefresh.Location = New System.Drawing.Point(190, 51)
        Me.txtMaxRefresh.Name = "txtMaxRefresh"
        Me.txtMaxRefresh.Size = New System.Drawing.Size(275, 22)
        Me.txtMaxRefresh.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rtbDesc2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDefDatFile, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 109)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(468, 129)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Default Output File:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbDesc2
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.rtbDesc2, 3)
        Me.rtbDesc2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDesc2.Location = New System.Drawing.Point(3, 35)
        Me.rtbDesc2.Name = "rtbDesc2"
        Me.rtbDesc2.ReadOnly = True
        Me.rtbDesc2.Size = New System.Drawing.Size(462, 91)
        Me.rtbDesc2.TabIndex = 1
        Me.rtbDesc2.Text = "The default file location to save the recorded data. Ensure this location is acce" & _
    "ssible amongst all computers that may use this application."
        '
        'txtDefDatFile
        '
        Me.txtDefDatFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDefDatFile.Location = New System.Drawing.Point(190, 3)
        Me.txtDefDatFile.Name = "txtDefDatFile"
        Me.txtDefDatFile.ReadOnly = True
        Me.txtDefDatFile.Size = New System.Drawing.Size(134, 22)
        Me.txtDefDatFile.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(330, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Browse..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rtbDesc1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.radCSV, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.radMDB, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(468, 106)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Default Output Method:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbDesc1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.rtbDesc1, 3)
        Me.rtbDesc1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDesc1.Location = New System.Drawing.Point(3, 29)
        Me.rtbDesc1.Name = "rtbDesc1"
        Me.rtbDesc1.ReadOnly = True
        Me.rtbDesc1.Size = New System.Drawing.Size(462, 74)
        Me.rtbDesc1.TabIndex = 1
        Me.rtbDesc1.Text = "The default selection when adding a new Watch. Select between a Comma Separated V" & _
    "alues (CSV) file or MS Access 2003 and Earlier Database (MDB) file."
        '
        'radCSV
        '
        Me.radCSV.AutoSize = True
        Me.radCSV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radCSV.Location = New System.Drawing.Point(190, 3)
        Me.radCSV.Name = "radCSV"
        Me.radCSV.Size = New System.Drawing.Size(134, 20)
        Me.radCSV.TabIndex = 2
        Me.radCSV.TabStop = True
        Me.radCSV.Text = "CSV"
        Me.radCSV.UseVisualStyleBackColor = True
        '
        'radMDB
        '
        Me.radMDB.AutoSize = True
        Me.radMDB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radMDB.Location = New System.Drawing.Point(330, 3)
        Me.radMDB.Name = "radMDB"
        Me.radMDB.Size = New System.Drawing.Size(135, 20)
        Me.radMDB.TabIndex = 3
        Me.radMDB.TabStop = True
        Me.radMDB.Text = "MDB"
        Me.radMDB.UseVisualStyleBackColor = True
        '
        'tabRecWatch
        '
        Me.tabRecWatch.Controls.Add(Me.TableLayoutPanel5)
        Me.tabRecWatch.Controls.Add(Me.TableLayoutPanel4)
        Me.tabRecWatch.Location = New System.Drawing.Point(4, 25)
        Me.tabRecWatch.Name = "tabRecWatch"
        Me.tabRecWatch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRecWatch.Size = New System.Drawing.Size(474, 398)
        Me.tabRecWatch.TabIndex = 1
        Me.tabRecWatch.Text = "Recording Watches"
        Me.tabRecWatch.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.rtbDesc5, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.timeRecord, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 109)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(468, 106)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Record Resume Time:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbDesc5
        '
        Me.TableLayoutPanel5.SetColumnSpan(Me.rtbDesc5, 3)
        Me.rtbDesc5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDesc5.Location = New System.Drawing.Point(3, 29)
        Me.rtbDesc5.Name = "rtbDesc5"
        Me.rtbDesc5.ReadOnly = True
        Me.rtbDesc5.Size = New System.Drawing.Size(462, 74)
        Me.rtbDesc5.TabIndex = 1
        Me.rtbDesc5.Text = resources.GetString("rtbDesc5.Text")
        '
        'timeRecord
        '
        Me.TableLayoutPanel5.SetColumnSpan(Me.timeRecord, 2)
        Me.timeRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeRecord.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeRecord.Location = New System.Drawing.Point(190, 3)
        Me.timeRecord.Name = "timeRecord"
        Me.timeRecord.ShowUpDown = True
        Me.timeRecord.Size = New System.Drawing.Size(275, 22)
        Me.timeRecord.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.rtbDesc4, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtSemiSuspend, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(468, 106)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Semi-Suspension Rate:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbDesc4
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.rtbDesc4, 3)
        Me.rtbDesc4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDesc4.Location = New System.Drawing.Point(3, 29)
        Me.rtbDesc4.Name = "rtbDesc4"
        Me.rtbDesc4.ReadOnly = True
        Me.rtbDesc4.Size = New System.Drawing.Size(462, 74)
        Me.rtbDesc4.TabIndex = 1
        Me.rtbDesc4.Text = resources.GetString("rtbDesc4.Text")
        '
        'txtSemiSuspend
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.txtSemiSuspend, 2)
        Me.txtSemiSuspend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSemiSuspend.Location = New System.Drawing.Point(190, 3)
        Me.txtSemiSuspend.Name = "txtSemiSuspend"
        Me.txtSemiSuspend.Size = New System.Drawing.Size(275, 22)
        Me.txtSemiSuspend.TabIndex = 2
        '
        'tabDash
        '
        Me.tabDash.Controls.Add(Me.TableLayoutPanel7)
        Me.tabDash.Controls.Add(Me.TableLayoutPanel6)
        Me.tabDash.Location = New System.Drawing.Point(4, 25)
        Me.tabDash.Name = "tabDash"
        Me.tabDash.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDash.Size = New System.Drawing.Size(474, 398)
        Me.tabDash.TabIndex = 2
        Me.tabDash.Text = "Dashboard"
        Me.tabDash.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.rtbDesc7, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.txtMaxRec, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 109)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(468, 106)
        Me.TableLayoutPanel7.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 26)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Trackbar Record Limit:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbDesc7
        '
        Me.TableLayoutPanel7.SetColumnSpan(Me.rtbDesc7, 3)
        Me.rtbDesc7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDesc7.Location = New System.Drawing.Point(3, 29)
        Me.rtbDesc7.Name = "rtbDesc7"
        Me.rtbDesc7.ReadOnly = True
        Me.rtbDesc7.Size = New System.Drawing.Size(462, 74)
        Me.rtbDesc7.TabIndex = 1
        Me.rtbDesc7.Text = resources.GetString("rtbDesc7.Text")
        '
        'txtMaxRec
        '
        Me.TableLayoutPanel7.SetColumnSpan(Me.txtMaxRec, 2)
        Me.txtMaxRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMaxRec.Location = New System.Drawing.Point(190, 3)
        Me.txtMaxRec.Name = "txtMaxRec"
        Me.txtMaxRec.Size = New System.Drawing.Size(275, 22)
        Me.txtMaxRec.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.rtbDesc6, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txtControlColumns, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(468, 106)
        Me.TableLayoutPanel6.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "View-Control Columns:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbDesc6
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.rtbDesc6, 3)
        Me.rtbDesc6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDesc6.Location = New System.Drawing.Point(3, 29)
        Me.rtbDesc6.Name = "rtbDesc6"
        Me.rtbDesc6.ReadOnly = True
        Me.rtbDesc6.Size = New System.Drawing.Size(462, 74)
        Me.rtbDesc6.TabIndex = 1
        Me.rtbDesc6.Text = resources.GetString("rtbDesc6.Text")
        '
        'txtControlColumns
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.txtControlColumns, 2)
        Me.txtControlColumns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtControlColumns.Location = New System.Drawing.Point(190, 3)
        Me.txtControlColumns.Name = "txtControlColumns"
        Me.txtControlColumns.Size = New System.Drawing.Size(275, 22)
        Me.txtControlColumns.TabIndex = 2
        '
        'tabReports
        '
        Me.tabReports.Controls.Add(Me.TableLayoutPanel8)
        Me.tabReports.Location = New System.Drawing.Point(4, 25)
        Me.tabReports.Name = "tabReports"
        Me.tabReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReports.Size = New System.Drawing.Size(474, 398)
        Me.tabReports.TabIndex = 3
        Me.tabReports.Text = "Reports"
        Me.tabReports.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.rtbDesc8, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.txtstrOEE, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.chkblnOEE, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btnstrOEE, 2, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 3
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(468, 116)
        Me.TableLayoutPanel8.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 29)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Alternate Report Location:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtbDesc8
        '
        Me.TableLayoutPanel8.SetColumnSpan(Me.rtbDesc8, 3)
        Me.rtbDesc8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDesc8.Location = New System.Drawing.Point(3, 61)
        Me.rtbDesc8.Name = "rtbDesc8"
        Me.rtbDesc8.ReadOnly = True
        Me.rtbDesc8.Size = New System.Drawing.Size(462, 52)
        Me.rtbDesc8.TabIndex = 1
        Me.rtbDesc8.Text = "Optionally automatically open the report immediately after it is generated. An al" & _
    "ternate location to save the report may be specified to aid user convenience."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.TableLayoutPanel8.SetColumnSpan(Me.Label11, 2)
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(321, 29)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Open OEE report upon save?"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtstrOEE
        '
        Me.txtstrOEE.AutoEllipsis = True
        Me.txtstrOEE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtstrOEE.Location = New System.Drawing.Point(190, 29)
        Me.txtstrOEE.Name = "txtstrOEE"
        Me.txtstrOEE.Size = New System.Drawing.Size(134, 29)
        Me.txtstrOEE.TabIndex = 3
        '
        'chkblnOEE
        '
        Me.chkblnOEE.AutoSize = True
        Me.chkblnOEE.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkblnOEE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkblnOEE.Location = New System.Drawing.Point(330, 3)
        Me.chkblnOEE.Name = "chkblnOEE"
        Me.chkblnOEE.Size = New System.Drawing.Size(135, 23)
        Me.chkblnOEE.TabIndex = 4
        Me.chkblnOEE.UseVisualStyleBackColor = True
        '
        'btnstrOEE
        '
        Me.btnstrOEE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnstrOEE.Location = New System.Drawing.Point(330, 32)
        Me.btnstrOEE.Name = "btnstrOEE"
        Me.btnstrOEE.Size = New System.Drawing.Size(135, 23)
        Me.btnstrOEE.TabIndex = 5
        Me.btnstrOEE.Text = "Browse..."
        Me.btnstrOEE.UseVisualStyleBackColor = True
        '
        'Administrative_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 427)
        Me.Controls.Add(Me.tabSettings)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Administrative_Settings"
        Me.Text = "Administrative Settings"
        Me.tabSettings.ResumeLayout(False)
        Me.tabAddWatch.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tabRecWatch.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.tabDash.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.tabReports.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabSettings As System.Windows.Forms.TabControl
    Friend WithEvents tabAddWatch As System.Windows.Forms.TabPage
    Friend WithEvents tabRecWatch As System.Windows.Forms.TabPage
    Friend WithEvents tabDash As System.Windows.Forms.TabPage
    Friend WithEvents tabReports As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rtbDesc1 As System.Windows.Forms.RichTextBox
    Friend WithEvents radCSV As System.Windows.Forms.RadioButton
    Friend WithEvents radMDB As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtbDesc2 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtDefDatFile As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtbDesc3 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtDefRefresh As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMinRefresh As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxRefresh As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rtbDesc4 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSemiSuspend As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rtbDesc5 As System.Windows.Forms.RichTextBox
    Friend WithEvents timeRecord As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rtbDesc6 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtControlColumns As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rtbDesc7 As System.Windows.Forms.RichTextBox
    Friend WithEvents txtMaxRec As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rtbDesc8 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtstrOEE As System.Windows.Forms.Label
    Friend WithEvents chkblnOEE As System.Windows.Forms.CheckBox
    Friend WithEvents btnstrOEE As System.Windows.Forms.Button
End Class
