Imports System.Windows.Forms
Imports System.Xml
Imports System.Data
Imports System.Data.OleDb

Public Class AddWatch
    Public replyStream As IO.Stream = Nothing
    Public strCol, strVal As String

    Private Sub rssReadCallback(ByVal sender As Object, ByVal e As System.Net.OpenReadCompletedEventArgs)
        Try
            replyStream = CType(e.Result, IO.Stream)
        Catch ex As Exception
            MsgBox("Error in replystream:" & vbLf & ex.Message)
            Local_Functions.Log("(ApplicationEvents)[rssReadCallback]" + vbTab + ex.Message)
        End Try
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ValidateForm() = False Then
            MessageBox.Show("Form not complete!" + vbLf + "Please fill out all appropriate information to continue or press Cancel", "Form not complete...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim myXML As New XmlDocument
        myXML.Load(My.Settings.StartUp + "\XML\Watch_Sessions.xml")
        For Each tWATCH As XmlElement In myXML.SelectSingleNode("sessions").ChildNodes
            If tWATCH.SelectSingleNode("name").InnerText = txtMACName.Text Then
                MessageBox.Show("A connection to " + txtMACName.Text + " has already been established!", "Cannot create another instance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtMACName.Focus()
                txtMACName.SelectAll()
                statStatus.Text = "A connection to " + txtMACName.Text + " has already been established!"
                Exit Sub
            End If
        Next

        Dim loc As String
        Dim tries As Integer = 0
        Dim maxAttempts As Integer = 5
        Try
            Dim myProbe As New XmlDocument
            Dim blnConnected As Boolean = False
            Do Until blnConnected = True
                Try
                    Dim w As New System.Net.WebClient
                    w.DownloadFile("http://" & txtMACName.Text & ":" & txtMACPort.Text & "/current", My.Settings.StartUp + "\XML\Temporary Read.xml")
                    myProbe.Load(My.Settings.StartUp + "\XML\Temporary Read.xml")
                    blnConnected = True
                    w.Dispose()
                Catch ex As Exception

                End Try
                tries += 1
                Debug.WriteLine("Attempt " & tries.ToString)
                If tries > 1 Then
                    statStatus.Text = "Having difficulties connecting, ensure machine is turned on...(" & tries.ToString & "/" & maxAttempts.ToString & ")"
                    Application.DoEvents()
                    If tries > maxAttempts Then
                        statStatus.Text = "Giving up trying to connect to 'http://" & txtMACName.Text & ":" & txtMACPort.Text & "/'..."
                        Exit Sub
                    End If
                End If
            Loop


            strCol = "[ID] AUTOINCREMENT PRIMARY KEY," & vbLf & "[logDate] TEXT(255)," & vbLf & _
                                        "[logTime] TEXT(255)," & vbLf
            For Each NODE As XmlElement In myProbe.ChildNodes(1).ChildNodes(1).ChildNodes(0).ChildNodes
                'due to data dump option, get contents from XML file for further review
                Get_Samples(NODE, myProbe)
                Get_Condition(NODE, myProbe)
                Get_Event(NODE, myProbe)
            Next
            Dim Cnn As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0; Data Source=" & txtMDBFile.Text & ";")
            Cnn.Open()
            Dim Cmd As New OleDbCommand("CREATE TABLE " & txtMDBTable.Text & vbLf & "(" & vbLf & _
                                         strCol.Remove(strCol.LastIndexOf(",")) & _
                                        vbLf & ");", Cnn)
            Cmd.ExecuteNonQuery()

            Cmd.Dispose()
            Cnn.Close()
            Cnn.Dispose()
        Catch ex As Exception
            MsgBox("An error occurred while attempting to setup the MS Access Database Table..." & vbLf & ex.Message)
            Debug.WriteLine("Couldn't add watch due to error:" & vbLf & vbTab & ex.Message)
        End Try


        Dim WATCH, NAME, PORT, RATE, OUTPUT, FILE, ACTION As XmlElement
        Dim TYPE As XmlAttribute
        WATCH = myXML.CreateElement("watch")
        NAME = myXML.CreateElement("name")
        PORT = myXML.CreateElement("port")
        RATE = myXML.CreateElement("rate")
        NAME.InnerText = txtMACName.Text
        PORT.InnerText = txtMACPort.Text
        RATE.InnerText = trcRate.Value.ToString

        OUTPUT = myXML.CreateElement("output")
        FILE = myXML.CreateElement("file")
        ACTION = myXML.CreateElement("action")

        TYPE = myXML.CreateAttribute("type")
        If radCSV.Checked = True Then
            TYPE.Value = "csv"
            FILE.InnerText = txtCSVFile.Text
            If radCSVOverwrite.Checked = True Then
                ACTION.InnerText = "overwrite"
            ElseIf radCSVAppend.Checked = True Then
                ACTION.InnerText = "append"
            ElseIf radCSVNewFile.Checked = True Then
                ACTION.InnerText = "new"
            Else
                'ERROR
            End If
        ElseIf radMDB.Checked = True Then
            TYPE.Value = "mdb"
            FILE.InnerText = txtMDBFile.Text
            ACTION.InnerText = txtMDBTable.Text
        Else
            'ERROR
        End If
        OUTPUT.AppendChild(FILE)
        OUTPUT.AppendChild(ACTION)
        OUTPUT.Attributes.Append(TYPE)
        WATCH.AppendChild(NAME)
        WATCH.AppendChild(PORT)
        WATCH.AppendChild(RATE)
        WATCH.AppendChild(OUTPUT)
        myXML.SelectSingleNode("sessions").AppendChild(WATCH)
        myXML.Save(My.Settings.StartUp + "\XML\Watch_Sessions.xml")

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Public Function ValidateForm() As Boolean
        If radCSV.Checked = True Then
            If String.IsNullOrEmpty(txtCSVFile.Text) = True Then
                Return False
            End If
            If radCSVOverwrite.Checked = False And radCSVAppend.Checked = False And radCSVNewFile.Checked = False Then
                Return False
            End If
        ElseIf radMDB.Checked = True Then
            If String.IsNullOrEmpty(txtMDBFile.Text) = True Or String.IsNullOrEmpty(txtMDBTable.Text) = True Then
                Return False
            End If
        Else
            Return False
        End If
        If String.IsNullOrEmpty(txtMACName.Text) = True Or String.IsNullOrEmpty(txtMACPort.Text) = True Then
            Return False
        End If
        Return True
    End Function
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub trcRate_Scroll(sender As System.Object, e As System.EventArgs) Handles trcRate.Scroll
        grpRate.Text = "Record Rate (" + trcRate.Value.ToString + " milliseconds)"
    End Sub
    Private Sub btnCSVFile_Click(sender As System.Object, e As System.EventArgs) Handles btnCSVFile.Click
        filOpen.ShowDialog()
        If IO.File.Exists(filOpen.FileName) = True Then
            txtCSVFile.Text = Local_Functions.GetUNCPath(filOpen.FileName)
        End If
    End Sub
    Private Sub btnMDBFile_Click(sender As System.Object, e As System.EventArgs) Handles btnMDBFile.Click
        filOpen.ShowDialog()
        If IO.File.Exists(filOpen.FileName) = True Then
            txtMDBFile.Text = Local_Functions.GetUNCPath(filOpen.FileName)
        End If
    End Sub
    Private Sub radMDB_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radMDB.CheckedChanged
        grpCSV.Enabled = False
        grpMDB.Enabled = True
    End Sub
    Private Sub radCSV_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radCSV.CheckedChanged
        grpMDB.Enabled = False
        grpCSV.Enabled = True
    End Sub


    Public Function Get_Event(ByVal NODE As XmlElement, ByVal DOC As XmlDocument) As String
        Dim strTemp, strOutPut As String
        Try
            For Each temp As XmlElement In NODE.ChildNodes
                If temp.Name = "Events" Then
                    For Each nod As XmlElement In temp.ChildNodes
                        If nod.HasAttribute("name") Then
                            If Not strCol.Contains(nod.Attributes("name").Value) Then
                                strCol += "[" & nod.Attributes("name").Value + "] TEXT(255)," & vbLf
                            End If
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine("Error for " + NODE.Attributes("component").Value + "-" + strTemp)
            Debug.WriteLine(ex.Message)
        End Try
        Return strOutPut
    End Function
    Public Function Get_Condition(ByVal NODE As XmlElement, ByVal DOC As XmlDocument) As String
        Dim strTemp, strOutPut As String
        Try
            For Each temp As XmlElement In NODE.ChildNodes
                If temp.Name = "Condition" Then
                    For Each nod As XmlElement In temp.ChildNodes
                        If nod.HasAttribute("name") Then
                            If Not strCol.Contains(nod.Attributes("name").Value & "s") And Not strCol.Contains(nod.Attributes("name").Value & "v") Then
                                strCol += "[" & nod.Attributes("name").Value + "s] TEXT(255)," & vbLf
                                strCol += "[" & nod.Attributes("name").Value + "v] TEXT(255)," & vbLf
                            End If
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine("Error for " + NODE.Attributes("component").Value + "-" + strTemp)
            Debug.WriteLine(ex.Message)
        End Try
        Return strOutPut
    End Function
    Public Function Get_Samples(ByVal NODE As XmlElement, ByVal DOC As XmlDocument) As String
        Dim strTemp, strOutPut As String
        Try
            For Each temp As XmlElement In NODE.ChildNodes
                If temp.Name = "Samples" Then
                    For Each nod As XmlElement In temp.ChildNodes
                        If nod.HasAttribute("name") Then
                            If Not strCol.Contains(nod.Attributes("name").Value) Then
                                strCol += "[" & nod.Attributes("name").Value + "] TEXT(255)," & vbLf
                            End If
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine("Error for " + NODE.Attributes("component").Value + "-" + NODE.Attributes("name").Value)
            Debug.WriteLine(ex.Message)
        End Try
        Return strOutPut
    End Function

    Private Sub AddWatch_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If My.Settings.intDefOutMeth = 0 Then
            radCSV.Checked = True
            radCSV_CheckedChanged(radCSV, Nothing)
        ElseIf My.Settings.intDefOutMeth = 1 Then
            radMDB.Checked = True
            radMDB_CheckedChanged(radMDB, Nothing)
        End If
        trcRate.Minimum = My.Settings.intMinRefresh
        trcRate.Maximum = My.Settings.intMaxRefresh
        If My.Settings.intDefRefresh >= My.Settings.intMinRefresh And My.Settings.intDefRefresh <= My.Settings.intMaxRefresh Then
            trcRate.Value = My.Settings.intDefRefresh
        Else
            trcRate.Value = Convert.ToInt32(((My.Settings.intMaxRefresh - My.Settings.intMinRefresh) / 2) + My.Settings.intMinRefresh)
        End If
        trcRate_Scroll(trcRate, Nothing)
        If Not String.IsNullOrEmpty(My.Settings.strDefDatFile) Then
            If radCSV.Checked Then
                txtCSVFile.Text = My.Settings.strDefDatFile
            ElseIf radMDB.Checked Then
                txtMDBFile.Text = My.Settings.strDefDatFile
            End If
            If Not IO.File.Exists(My.Settings.strDefDatFile) Then
                statStatus.Text = "The default output file does not exist (at least not from this computer). Please either change the specified output file or contact your system administrator to fix the potential issue."
            End If
        End If
    End Sub
End Class
