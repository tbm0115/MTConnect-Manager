Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.OleDb

Module Local_Functions
    Private Oees(0 To 100) As Graphics

    Declare Function WNetGetConnection Lib "mpr.dll" Alias "WNetGetConnectionA" (ByVal lpszLocalName As String, _
             ByVal lpszRemoteName As String, ByRef cbRemoteName As Integer) As Integer
    Public Function GetUNCPath(ByVal sFilePath As String) As String
        'reformat FTP location to '\\' format location string as needed. This avoids issues with mapped drives.
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
        Dim d As DriveInfo
        Dim DriveType, Ctr As Integer
        Dim DriveLtr, UNCName As String
        Dim StrBldr As New StringBuilder

        If sFilePath.StartsWith("\\") Then Return sFilePath

        UNCName = Space(160)
        GetUNCPath = ""

        DriveLtr = sFilePath.Substring(0, 3)

        For Each d In allDrives
            If d.Name = DriveLtr Then
                DriveType = d.DriveType
                Exit For
            End If
        Next

        If DriveType = 4 Then

            Ctr = WNetGetConnection(sFilePath.Substring(0, 2), UNCName, UNCName.Length)

            If Ctr = 0 Then
                UNCName = UNCName.Trim
                For Ctr = 0 To UNCName.Length - 1
                    Dim SingleChar As Char = UNCName(Ctr)
                    Dim asciiValue As Integer = Asc(SingleChar)
                    If asciiValue > 0 Then
                        StrBldr.Append(SingleChar)
                    Else
                        Exit For
                    End If
                Next
                StrBldr.Append(sFilePath.Substring(2))
                GetUNCPath = StrBldr.ToString
            Else
                MsgBox("Cannot Retrieve UNC path" & vbCrLf & "Must Use Mapped Drive of SQLServer", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Cannot Use Local Drive" & vbCrLf & "Must Use Mapped Drive of SQLServer", MsgBoxStyle.Critical)
        End If

    End Function

    Public Sub Log(ByVal MESSAGE As String)
        Try
            IO.File.AppendAllText(My.Settings.StartUp & "\Error Log.txt", DateTime.Now.ToString & " - " & MESSAGE & vbCrLf)
        Catch ex As Exception
            Debug.WriteLine("COULDN'T WRITE TO ERROR LOG DUE TO ERROR:" & vbLf & vbTab & ex.Message.ToUpper)
        End Try
    End Sub

    Public Function GetPicturePart(ByVal SourceImage As Image, ByVal Region As Rectangle) As Bitmap
        Dim ImagePart As Bitmap = New Bitmap(Region.Width, Region.Height)
        Using G As Graphics = Graphics.FromImage(ImagePart)
            Dim TargetRect As Rectangle = New Rectangle(0, 0, Region.Width, Region.Height)
            Dim SourceRect As Rectangle = Region

            G.DrawImage(SourceImage, TargetRect, SourceRect, GraphicsUnit.Pixel)
        End Using
        Return ImagePart
    End Function

    Public Function GetPrimaryKeyName(ByVal ConnectionString As String, ByVal TABLE As String) As String
        Dim returnList = New List(Of String)()
        Dim Cnn As New OleDbConnection(ConnectionString)

        If Not Cnn.State = ConnectionState.Closed Then
            Do Until Cnn.State = ConnectionState.Closed
                Cnn.ResetState()
                Application.DoEvents()
            Loop
        End If
        Cnn.Open()

        Dim mySchema As DataTable = TryCast(Cnn, OleDbConnection).GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, New [Object]() {Nothing, Nothing, TABLE})

        ' following is a lengthy form of the number '3'
        Dim columnOrdinalForName As Integer = mySchema.Columns("COLUMN_NAME").Ordinal

        For Each r As DataRow In mySchema.Rows
            returnList.Add(r.ItemArray(columnOrdinalForName).ToString())
        Next
        Cnn.Close()
        Cnn.Dispose()
        mySchema.Dispose()
        Return returnList.Item(0)
    End Function
    Private blnPlaying As Boolean = False
    Public Sub Attention(ByVal Message As String)
        If Not blnPlaying Then
            blnPlaying = True
            My.Settings.ATTENTION.PlayLooping()
            MessageBox.Show(Message, "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Settings.ATTENTION.Stop()
            blnPlaying = False
        End If
    End Sub

    Public Function OleDbSecurityExists(ByVal FilePath As String, Optional ByVal Provider As String = "Microsoft.Jet.OLEDB.4.0") As Boolean
        Dim Cnn As New OleDb.OleDbConnection("Provider=" & Provider & "; Data Source=" & FilePath & ";")
        Try
            If Not Cnn.State = ConnectionState.Closed Then
                Return False
            End If
            Cnn.Open()
            Cnn.Close()
            Cnn.Dispose()
            Return False
        Catch ex As Exception
            Cnn.Dispose()
            Return True
        End Try
    End Function

    Public Function OleDbSecurityTest(ByVal FilePath As String, ByVal User As String, ByVal Pass As String, Optional ByVal Provider As String = "Microsoft.Jet.OLEDB.4.0") As Boolean
        Dim Cnn As OleDbConnection
        If Not String.IsNullOrEmpty(User) Then
            If Not String.IsNullOrEmpty(Pass) Then
                Cnn = New OleDb.OleDbConnection("Provider=" & Provider & "; Data Source=" & FilePath & ";User Id=" & User & ";Jet OLEDB:Database Password=" & Pass & ";")
            Else
                Cnn = New OleDb.OleDbConnection("Provider=" & Provider & "; Data Source=" & FilePath & ";User Id=" & User & ";")
            End If
        Else
            If Not String.IsNullOrEmpty(Pass) Then
                Cnn = New OleDb.OleDbConnection("Provider=" & Provider & "; Data Source=" & FilePath & ";Jet OLEDB:Database Password=" & Pass & ";")
            Else
                Cnn = New OleDb.OleDbConnection("Provider=" & Provider & "; Data Source=" & FilePath & ";")
            End If
        End If
        Try
            Cnn.Open()
            Cnn.Close()
            Cnn.Dispose()
            Return True
        Catch ex As Exception
            Cnn.Dispose()
            Debug.WriteLine("Error testing OleDbSecurity:" & vbLf & vbTab & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetOleDbProvider(ByVal FilePath As String) As String
        Select Case FilePath.Remove(0, FilePath.LastIndexOf("."))
            Case ".mdb"
                Return "Microsoft.Jet.OLEDB.4.0"
            Case ".accdb"
                Return "Microsoft.ACE.OLEDB.12.0"
            Case Else
                Return Nothing
        End Select
    End Function

    Public Function CompileOleDbConnectionString(ByVal Provider As String, ByVal DataSource As String) As String
        If String.IsNullOrEmpty(Provider) Then
            Provider = GetOleDbProvider(DataSource)
        End If
        Return "Provider=" & Provider & "; Data Source=" & DataSource & ";"
    End Function
    Public Function CompileOleDbConnectionString(ByVal Provider As String, ByVal DataSource As String, ByVal UserId As String, ByVal Password As String) As String
        If String.IsNullOrEmpty(Provider) Then
            Provider = GetOleDbProvider(DataSource)
        End If
        If Provider.Contains("Jet") Then
            If Not String.IsNullOrEmpty(UserId) Then
                If Not String.IsNullOrEmpty(Password) Then
                    Return "Provider=" & Provider & "; Data Source=" & DataSource & ";User Id=" & UserId & ";Jet OLEDB:Database Password=" & Password & ";"
                Else
                    Return "Provider=" & Provider & "; Data Source=" & DataSource & ";User Id=" & UserId & ";Jet OLEDB:Database Password=" & Password & ";"
                End If
            Else
                If Not String.IsNullOrEmpty(Password) Then
                    Return "Provider=" & Provider & "; Data Source=" & DataSource & ";Jet OLEDB:Database Password=" & Password & ";"
                Else
                    Return "Provider=" & Provider & "; Data Source=" & DataSource & ";"
                End If
            End If
        Else
            If Not String.IsNullOrEmpty(UserId) Then
                If Not String.IsNullOrEmpty(Password) Then
                    Return "Provider=" & Provider & "; Data Source=" & DataSource & ";User Id=" & UserId & ";Password=" & Password & ";"
                Else
                    Return "Provider=" & Provider & "; Data Source=" & DataSource & ";User Id=" & UserId & ";Password=" & Password & ";"
                End If
            Else
                If Not String.IsNullOrEmpty(Password) Then
                    Return "Provider=" & Provider & "; Data Source=" & DataSource & ";Password=" & Password & ";"
                Else
                    Return "Provider=" & Provider & "; Data Source=" & DataSource & ";"
                End If
            End If
        End If
    End Function

    Public Function getWCName(ByVal O As OEE) As String
        Dim cn As New OleDbConnection()
        Dim Cmd As OleDbCommand
        Dim Read As OleDbDataReader
        Dim i As String
        Dim u, p, prov, db As String
        db = My.Resources.E2DatabaseLocation
        'Check if database is password protected. If so, then prompt for Username and Password
        prov = Local_Functions.GetOleDbProvider(db)
        If Local_Functions.OleDbSecurityExists(db, prov) Then
            u = InputBox("Enter the UserName available for this file (if there is a required UserName):" & vbLf & db, "Database Credentials")
            p = InputBox("Enter the Password available for this file (if there is a required Password):" & vbLf & db, "Database Credentials")
            If Not Local_Functions.OleDbSecurityTest(db, u, p, prov) Then
                MessageBox.Show("It appears that the credentials you provided were incorrect! Please review the credentials for this file and reselect the file to try again." & vbLf & "Provided Credentials:" & vbLf & "UserName=" & u & vbLf & "Password=" & p & vbLf & "File=" & db, "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
                db = Nothing
                Exit Function
            End If
        End If
        'O.OleDbConnection = Local_Functions.CompileOleDbConnectionString(prov, db, u, p)
        cn.ConnectionString = CompileOleDbConnectionString(prov, db, u, p)
        Debug.WriteLine("Connection String(getWcName)=" & O.OleDbConnection)
        'Connect to the Northwind database in SQL Server.
        'Be sure to use an account that has permission to list tables.
        cn.Open()

        Cmd = New OleDbCommand("SELECT TOP 1 ShortName FROM dbo_WorkCntr WHERE WorkCntr = " & Convert.ToInt32(O.WorkCenter) & ";", cn)
        Read = Cmd.ExecuteReader
        For Each Record As IDataRecord In Read
            i = Record.Item("ShortName").ToString
        Next
        Return i
    End Function
End Module

Module ConvertValue
    Public Function mmToInches(ByVal VALUE As Double) As Double
        Return VALUE * 0.0393701
    End Function

    Public Function InchesTomm(ByVal value As Double) As Double
        Return value * 25.4
    End Function

    Public Function CelsiusToFahrenheit(ByVal VALUE As Double) As Double
        Return (VALUE * (9 / 5)) + 32
    End Function

    Public Function FahrenheitToCelsius(ByVal VALUE As Double) As Double
        Return (VALUE - 32) * (5 / 9)
    End Function
End Module
