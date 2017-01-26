Imports System.Drawing


Public Class Status_Indicator
    Private _stat As Integer
    Private strStat As Color
    Private lbl As String
    Private val As String
    Private txtClr As Drawing.Color
    Private _Values() As String
    Private _Status() As Color
    Private _base, _table, _col, _user, _pass, _provider, _Cnn, _pkey As String
    Private lastVal As String
    Private VIEW As Status_View

    Public Property OleDbPrimaryKey As String
        Get
            Return _pkey
        End Get
        Set(value As String)
            _pkey = value
        End Set
    End Property
    Public Property OleDbConnection As String
        Get
            Return _Cnn
        End Get
        Set(value As String)
            _Cnn = value
        End Set
    End Property
    Public Property OleDbUser As String
        Get
            Return _user
        End Get
        Set(value As String)
            _user = value
        End Set
    End Property
    Public Property OleDbProvider As String
        Get
            Return _provider
        End Get
        Set(value As String)
            _provider = value
        End Set
    End Property
    Public Property OleDbPassword As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property
    Public Property OleDbColumn As String
        Get
            Return _col
        End Get
        Set(value As String)
            _col = value
        End Set
    End Property
    Public Property OleDbTable As String
        Get
            Return _table
        End Get
        Set(value As String)
            _table = value
        End Set
    End Property
    Public Property OleDbFile As String
        Get
            Return _base
        End Get
        Set(value As String)
            _base = value
        End Set
    End Property

    Public Property TextColor As Drawing.Color
        Get
            Return txtClr
        End Get
        Set(value As Drawing.Color)
            txtClr = value
        End Set
    End Property
    Public Enum Color
        Green
        Cyan
        Blue
        Violet
        Yellow
        Red
    End Enum

    Public Property DataName As String
        Get
            Return lbl
        End Get
        Set(value As String)
            lbl = value
        End Set
    End Property

    Public Property DataValue As String
        Get
            Return val
        End Get
        Set(value As String)
            val = value
            'reset status index
            If _Values.Count > 0 Then
                If _Values.Contains(val) = True Then
                    For i = 0 To _Values.Count - 1 Step 1
                        If _Values(i) = val Then
                            _stat = _Status(i)
                            Exit For
                        End If
                    Next
                End If
            End If
        End Set
    End Property

    Public Function CheckOleDbSecurity(ByVal FilePath As String, ByVal ReturnType As System.Type, Optional ByVal Provider As String = "Microsoft.Jet.OLEDB.4.0")
        Dim bln As Boolean = Local_Functions.OleDbSecurityExists(FilePath, Provider)
        Select Case ReturnType
            Case GetType(String)
                If bln Then
                    Return "Password=" & _pass & ";"
                Else
                    Return Nothing
                End If
            Case GetType(Boolean)
                Return bln
            Case Else
                Return Nothing
        End Select
    End Function

    Public Sub ReDraw()
        If Not String.IsNullOrEmpty(lastVal) Then
            If Not lastVal = val Then
                'Redraws all of the controls within the user control
                '   Sets new Value text
                '   Sets new DataLabel text
                '   Sets new index of Control Image
                '   Determines necessity of the Attention message function
                If IsNothing(VIEW) Then
                    VIEW = Me.Parent.Parent
                End If
                Me.BackgroundImage = VIEW.GetImage(_stat)
                lastVal = val
            End If
        Else
            lastVal = val
        End If
        If Not IsNothing(lbl) Then
            lblDataName.Text = lbl
            lblDataName.ForeColor = txtClr
        Else
            lblDataName.Text = "Status"
            lblDataName.ForeColor = txtClr
        End If
        If Not IsNothing(val) Then
            lblStatus.ForeColor = txtClr
            lblStatus.Text = val
        End If
    End Sub

    Public Sub AddStatusValue(ByVal Value As String, ByVal IndicatorColor As Color)
        'Adds a new Status Value to the array
        '   Requires Value Text and associates it to the index of one of the Colors
        If String.IsNullOrEmpty(Value) = False And IsNothing(IndicatorColor) = False Then
            If IsNothing(_Values) = True Then
                Array.Resize(_Values, 1)
                Array.Resize(_Status, 1)
                _Values(0) = Value
                _Status(0) = IndicatorColor
            Else
                If _Values.Contains(Value) = False Then
                    Array.Resize(_Values, _Values.Count + 1)
                    Array.Resize(_Status, _Status.Count + 1)
                    _Values(_Values.Count - 1) = Value
                    _Status(_Status.Count - 1) = IndicatorColor
                End If
            End If

        End If
    End Sub

    Private Function GetColorIndex(ByVal IndicatorColor As Color) As Integer
        'Converts this User Controls Color value into an integer
        '   Returns zero if error
        Select Case IndicatorColor
            Case Color.Green
                Return 1
            Case Color.Cyan
                Return 2
            Case Color.Blue
                Return 3
            Case Color.Violet
                Return 4
            Case Color.Yellow
                Return 5
            Case Color.Red
                Return 6
            Case Else
                Return 0
        End Select
    End Function

    Public Sub RemoveStatusValue(ByVal Value As String)
        'Removes any unnecessary Status Values on the fly
        '   Removes the value and its associated color index from the arrays
        If String.IsNullOrEmpty(Value) = False Then
            If _Values.Contains(Value) = True Then
                Dim tmp() As String
                Dim tmpi() As Integer
                Array.Resize(tmp, _Values.Count - 1)
                Array.Resize(tmpi, _Status.Count - 1)
                Array.Resize(tmp, _Values.Count - 1)
                Array.Resize(tmpi, _Status.Count - 1)
                Dim j As Integer = 0
                For i = 0 To _Values.Count - 1 Step 1
                    If Not _Values(i) = Value Then
                        tmp(i) = _Values(i)
                    Else
                        j = i
                    End If
                Next
                System.Array.Clear(_Values, 0, _Values.Count - 1)
                Array.Resize(_Values, tmp.Count)
                _Values = tmp
                For i = 0 To _Status.Count - 1 Step 1
                    If Not i = j Then
                        tmpi(i) = _Status(i)
                    End If
                Next
                System.Array.Clear(_Status, 0, _Status.Count - 1)
                Array.Resize(_Status, tmpi.Count)
                _Status = tmpi
            End If
        End If
    End Sub

End Class
