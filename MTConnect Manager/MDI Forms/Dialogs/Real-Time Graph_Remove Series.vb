Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Real_Time_Graph_Remove_Series
    Private graph As Chart
    Private dash As Form
    Property Chart() As Chart
        Get
            Return graph
        End Get
        Set(value As Chart)
            graph = value
        End Set
    End Property
    Property Dashboard() As Form
        Get
            Return dash
        End Get
        Set(value As Form)
            dash = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If lstSeries.SelectedIndex = -1 Then
            Exit Sub
        End If
        For Each s As Series In graph.Series
            If s.Name = lstSeries.Text Then
                Try
                    graph.Series.Remove(s)
                Catch ex As Exception
                    Local_Functions.Log("(Dashboard_Real-Time Graph_Remove Series){Series=" + s.Name + "}[Remove Series] ERROR = " + ex.Message)
                    MessageBox.Show("An error occurred while attempting to remove a series" + vbLf + "Please review the error log for more details", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Try
                    Dim pnl As Panel = dash.Controls.Find("pnlProbeContainer", True).First
                    For Each Cntrl As Control In pnl.Controls
                        Debug.WriteLine("Delete Control Function: Cntrl Name=" + Cntrl.Name)
                        If Cntrl.Name = s.Name Then
                            pnl.Controls.Remove(Cntrl)
                        End If
                    Next
                    'dash.Controls("SplitContainer1").Controls.Remove(dash.Controls("SplitContainer1").Controls(s.Name))
                Catch ex As Exception
                    Local_Functions.Log("(Dashboard_Real-Time Graph_Remove Series){Series=" + s.Name + "}[Remove ProbeDataType] ERROR = " + ex.Message)
                    MessageBox.Show("An error occurred while attempting to remove a series data type view" + vbLf + "Please review the error log for more details", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Exit For
            End If
        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Real_Time_Graph_Remove_Series_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstSeries.Items.Clear()
        For Each s As Series In graph.Series
            lstSeries.Items.Add(s.Name)
        Next
    End Sub
End Class
