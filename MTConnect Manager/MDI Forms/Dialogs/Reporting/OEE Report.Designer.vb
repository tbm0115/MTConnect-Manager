<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OEE_Report
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.chkDateRange = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dateStart = New System.Windows.Forms.DateTimePicker()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.chkWorkCenters = New System.Windows.Forms.CheckedListBox()
        Me.progDates = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 380)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(374, 52)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(4, 6)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(179, 40)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(191, 6)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(179, 40)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'chkDateRange
        '
        Me.chkDateRange.AutoSize = True
        Me.chkDateRange.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDateRange.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkDateRange.Location = New System.Drawing.Point(0, 0)
        Me.chkDateRange.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkDateRange.Name = "chkDateRange"
        Me.chkDateRange.Size = New System.Drawing.Size(374, 27)
        Me.chkDateRange.TabIndex = 1
        Me.chkDateRange.Text = "Report Date Range?"
        Me.chkDateRange.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblStart, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblEnd, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dateStart, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dateEnd, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(374, 100)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStart.Enabled = False
        Me.lblStart.Location = New System.Drawing.Point(3, 0)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(181, 50)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "Select a Start Date"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEnd.Location = New System.Drawing.Point(190, 0)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(181, 50)
        Me.lblEnd.TabIndex = 1
        Me.lblEnd.Text = "Select an End Date"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateStart
        '
        Me.dateStart.CustomFormat = "MM/dd/yyyy"
        Me.dateStart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dateStart.Enabled = False
        Me.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateStart.Location = New System.Drawing.Point(3, 53)
        Me.dateStart.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(181, 30)
        Me.dateStart.TabIndex = 2
        '
        'dateEnd
        '
        Me.dateEnd.CustomFormat = "MM/dd/yyyy"
        Me.dateEnd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateEnd.Location = New System.Drawing.Point(190, 53)
        Me.dateEnd.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(181, 30)
        Me.dateEnd.TabIndex = 3
        '
        'chkWorkCenters
        '
        Me.chkWorkCenters.CheckOnClick = True
        Me.chkWorkCenters.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkWorkCenters.FormattingEnabled = True
        Me.chkWorkCenters.Location = New System.Drawing.Point(0, 127)
        Me.chkWorkCenters.Name = "chkWorkCenters"
        Me.chkWorkCenters.Size = New System.Drawing.Size(374, 229)
        Me.chkWorkCenters.TabIndex = 3
        '
        'progDates
        '
        Me.progDates.Dock = System.Windows.Forms.DockStyle.Top
        Me.progDates.Location = New System.Drawing.Point(0, 356)
        Me.progDates.Name = "progDates"
        Me.progDates.Size = New System.Drawing.Size(374, 23)
        Me.progDates.TabIndex = 4
        '
        'OEE_Report
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(374, 432)
        Me.Controls.Add(Me.progDates)
        Me.Controls.Add(Me.chkWorkCenters)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.chkDateRange)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OEE_Report"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OEE Report"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents chkDateRange As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents dateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkWorkCenters As System.Windows.Forms.CheckedListBox
    Friend WithEvents progDates As System.Windows.Forms.ProgressBar

End Class
