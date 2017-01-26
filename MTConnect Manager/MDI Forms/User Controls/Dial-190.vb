Public Class Dial_190
    Private val As Integer = 1
    Private lastVal As Integer
    Private lbl As String
    Private fil As String = Nothing
    Private _base, _table, _col, _user, _pass, _provider, _Cnn, _pkey As String
    Private VIEW As Dial_View

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

    'Dial Properties
    Public Property DialValue As Integer
        Get
            Return val
        End Get
        Set(value As Integer)
            val = value
        End Set
    End Property
    Public Property DataName As String
        Get
            Return lbl
        End Get
        Set(value As String)
            lbl = value
        End Set
    End Property
   
    Public Sub ReDraw()
        If Not IsNothing(lastVal) Then
            If Not val = lastVal Then
                If IsNothing(VIEW) Then
                    VIEW = Me.Parent.Parent
                End If
                Me.BackgroundImage = VIEW.GetImage((val / 190) * 35)
                lblValue.Text = val.ToString
                lastVal = val
            End If
        Else
            lastVal = val
        End If
        If Not IsNothing(lbl) Then
            lblData.Text = lbl
        End If
    End Sub
End Class
