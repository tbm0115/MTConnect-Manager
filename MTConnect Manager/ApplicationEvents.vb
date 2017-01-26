Imports System.Xml
Imports System.Net
Imports System.IO

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Public replyStream As IO.Stream = Nothing

        Private Sub rssReadCallback(ByVal sender As Object, ByVal e As System.Net.OpenReadCompletedEventArgs)
            Try
                replyStream = CType(e.Result, IO.Stream)
            Catch ex As Exception
                Local_Functions.Log("(ApplicationEvents)[rssReadCallback]" + vbTab + ex.Message)
            End Try
        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Try
        'If System.Windows.Forms.Application.StartupPath = "C:\Users\Trais\Documents\Visual Studio 2010\Projects\MTConnect Manager\MTConnect Manager\bin\Debug" Then
        '    My.Settings.StartUp = "C:\Users\Trais\Documents\Visual Studio 2010\Projects\MTConnect Manager\MTConnect Manager\bin\Debug"
        'Else
        '    My.Settings.StartUp = "\\server\SHARE\Systems Database\MTConnect\MTConnect Manager"
        'End If
        My.Settings.StartUp = "C:\Users\Trais\Documents\Visual Studio 2010\Projects\MTConnect Manager\MTConnect Manager"
        If IsNothing(My.Settings.ATTENTION) Then
                    My.Settings.ATTENTION = New System.Media.SoundPlayer(My.Resources.HEY)
                End If
                Dim w As New System.Net.WebClient
                Dim myXML, myProbe, newProbe As New XmlDocument
                Dim blnSuccess As Boolean = True
                Dim newProbeMain As XmlElement
                newProbeMain = newProbe.CreateElement("ProbeDataTypes")

                AddHandler w.OpenReadCompleted, AddressOf rssReadCallback
                myXML.Load(My.Settings.StartUp + "\XML\Watch_Sessions.xml")
                If myXML.SelectSingleNode("sessions").HasChildNodes = True Then
                    blnSuccess = False
                    For Each WATCH As XmlElement In myXML.SelectSingleNode("sessions").ChildNodes
                        'Directly stream current XML
                        If IsNothing(replyStream) = False Then
                            replyStream.Dispose()
                        End If
                        Try
                            w.OpenReadAsync(New Uri("http://" + WATCH.SelectSingleNode("name").InnerText + ":" + WATCH.SelectSingleNode("port").InnerText + "/probe"))
                        Catch ex As Exception
                            Local_Functions.Log("(ApplicationEvents)[Startup]" + vbTab + ex.Message)
                            Continue For
                        End Try
                        'Adding timer as timeout
                        Dim ti As New Stopwatch
                        ti.Start()
                        Do Until IsNothing(replyStream) = False
                            Application.DoEvents()
                            If ti.ElapsedMilliseconds > 10000 Then
                                Debug.WriteLine("Timed out!")
                                blnSuccess = False
                                Continue For
                            End If
                        Loop
                        myProbe.Load(replyStream)
                        w.Dispose()
                        Dim OUTNODE As XmlElement
                        Dim attr As XmlAttribute
                        OUTNODE = newProbe.CreateElement("Probe")
                        attr = newProbe.CreateAttribute("name")
                        attr.Value = WATCH.SelectSingleNode("name").InnerText
                        OUTNODE.Attributes.Append(attr)
                        GetDataItem(myProbe.DocumentElement, OUTNODE, newProbe)
                        newProbeMain.AppendChild(OUTNODE)
                    Next
                    newProbe.AppendChild(newProbeMain)
                    If blnSuccess Then
                        If IO.File.Exists(My.Settings.StartUp + "\XML\Probe_Data-Types.xml") = True Then
                            IO.File.Delete(My.Settings.StartUp + "\XML\Probe_Data-Types.xml")
                            Do Until IO.File.Exists(My.Settings.StartUp + "\XML\Probe_Data-Types.xml") = False
                                Application.DoEvents()
                            Loop
                        End If
                        newProbe.Save(My.Settings.StartUp + "\XML\Probe_Data-Types.xml")
                        Debug.WriteLine("Finished saving new probe data types!")
                    Else
                        Debug.WriteLine("No Probes available, not overwriting Probe_Data-Type")
                    End If
                End If
            Catch ex As Exception
                Local_Functions.Log("(ApplicationEvents)[Startup]" + vbTab + ex.Message)
            End Try
            My.Application.SaveMySettingsOnExit = True
        End Sub

        Private Function GetDataItem(ByVal NODE As XmlElement, ByVal outNODE As XmlElement, ByVal DOC As XmlDocument) As XmlElement
            Try
                If NODE.GetType.ToString = "System.Xml.XmlElement" And Not NODE.FirstChild.GetType.ToString = "System.Xml.XmlText" Then
                    For Each nod As XmlElement In NODE.ChildNodes
                        If nod.GetType.ToString = "System.Xml.XmlElement" Then
                            If nod.Name = "DataItem" Then
                                If nod.HasAttribute("name") = True Then
                                    Dim newNode As XmlElement
                                    Dim attr As XmlAttribute
                                    newNode = DOC.CreateElement("DataItem")
                                    attr = DOC.CreateAttribute("name")
                                    attr.Value = nod.Attributes("name").Value
                                    newNode.Attributes.Append(attr)
                                    attr = DOC.CreateAttribute("units")
                                    If nod.HasAttribute("units") = True Then
                                        attr.Value = nod.Attributes("units").Value
                                    Else
                                        attr.Value = "null"
                                    End If
                                    newNode.Attributes.Append(attr)
                                    attr = DOC.CreateAttribute("cat")
                                    If nod.HasAttribute("category") = True Then
                                        attr.Value = nod.Attributes("category").Value
                                        If nod.Attributes("category").Value = "EVENT" Then
                                            If nod.HasChildNodes = True Then
                                                If nod.FirstChild.Name = "Constraints" Then
                                                    For Each VALUE As XmlElement In nod.FirstChild.ChildNodes
                                                        Dim newVal As XmlElement
                                                        newVal = DOC.CreateElement("EventValue")
                                                        newVal.InnerText = VALUE.InnerText
                                                        newNode.AppendChild(newVal)
                                                    Next
                                                End If
                                            End If
                                        End If
                                    Else
                                        attr.Value = "null"
                                    End If
                                    newNode.Attributes.Append(attr)
                                    attr = DOC.CreateAttribute("type")
                                    If nod.HasAttribute("type") = True Then
                                        attr.Value = nod.Attributes("type").Value
                                    Else
                                        attr.Value = "null"
                                    End If
                                    newNode.Attributes.Append(attr)
                                    outNODE.AppendChild(newNode)
                                End If
                            End If
                            If nod.HasChildNodes = True Then
                                outNODE = GetDataItem(nod, outNODE, DOC)
                            End If
                        End If
                    Next
                End If
            Catch ex As Exception
                Local_Functions.Log("(ApplicationEvents)[GetDataItem]" + vbTab + ex.Message)
                Return Nothing
            End Try
            Return outNODE
        End Function

    End Class


End Namespace

