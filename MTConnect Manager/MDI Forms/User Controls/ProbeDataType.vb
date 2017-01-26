Public Class ProbeDataType
    Private unt As String = Nothing
    Private cat As String = Nothing
    Private typ As String = Nothing
    Private src As String = Nothing
    Private _base, _table, _col, _user, _pass, _provider, _Cnn, _pkey As String

    'Database Properties
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

    Public Property Units() As String
        Get
            Return unt
        End Get
        Set(ByVal Value As String)
            unt = Value
            txtUnits.Text = unt
        End Set
    End Property
    Public Property Category As String
        Get
            Return cat
        End Get
        Set(ByVal Value As String)
            cat = Value
            txtCategory.Text = cat
        End Set
    End Property
    Public Property DataItemType() As String
        Get
            Return typ
        End Get
        Set(ByVal Value As String)
            typ = Value
            txtType.Text = typ
        End Set
    End Property
    Public Property SourceName() As String
        Get
            Return src
        End Get
        Set(ByVal Value As String)
            src = Value
            grpProbe.Text = src
        End Set
    End Property

    Private Sub txtUnits_TextChanged(sender As Object, e As System.EventArgs) Handles txtUnits.TextChanged
        cmbConvertRatio.Items.Clear()
        cmbConvertRatio.Items.Add("Default")
        Select Case txtUnits.Text
            Case "mm"
                cmbConvertRatio.Items.Add("mm to Inches")
            Case "Inches"
                cmbConvertRatio.Items.Add("Inches to mm")
            Case "%"

            Case "mm/sec"
                cmbConvertRatio.Items.Add("mm to Inches")
            Case "Inches/sec"
                cmbConvertRatio.Items.Add("Inches to mm")
            Case "°/sec"

            Case "rpm"

            Case "C°"
                cmbConvertRatio.Items.Add("Celsius to Farenheit")
            Case "F°"
                cmbConvertRatio.Items.Add("Farenheit to Celsius")
            Case "°"

        End Select
    End Sub
End Class
