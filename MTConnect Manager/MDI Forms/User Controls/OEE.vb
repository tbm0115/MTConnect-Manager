Public Class OEE
    Private _GP, _TP, _RP, _OEE As Integer
    Private _PT, _SL, _B, _DT, _RT, _OT, _A, _P, _Q As Double
    Private _qtm, _pf As Integer
    Private _teh, _mh As Double
    Private _base, _table, _user, _pass, _provider, _Cnn, _WorkCntr, _WCName As String
    Private lastVal As Integer

    'Database Properties
    Public Property WorkCenter As String
        Get
            Return _WorkCntr
        End Get
        Set(value As String)
            _WorkCntr = value
        End Set
    End Property
    Public Property WorkCenterName As String
        Get
            Return _WCName
        End Get
        Set(value As String)
            _WCName = value
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

    'OEE Properties
    Public Property OverallEquipmentEfficiency As Decimal
        Get
            Return _OEE
        End Get
        Set(value As Decimal)
            _OEE = value
        End Set
    End Property
    Public Property Availability As Double
        Get
            Return _A
        End Get
        Set(value As Double)
            _A = value
        End Set
    End Property
    Public Property Performance As Double
        Get
            Return _P
        End Get
        Set(value As Double)
            _P = value
        End Set
    End Property
    Public Property Quality As Double
        Get
            Return _Q
        End Get
        Set(value As Double)
            _Q = value
        End Set
    End Property
    Public Property QtyToMake As Integer
        Get
            Return _qtm
        End Get
        Set(value As Integer)
            _qtm = value
        End Set
    End Property
    Public Property PiecesFinished As Integer
        Get
            Return _pf
        End Get
        Set(value As Integer)
            _pf = value
        End Set
    End Property
    Public Property MachineHours As Double
        Get
            Return _mh
        End Get
        Set(value As Double)
            _mh = value
        End Set
    End Property
    Public Property TotalEstimatedHours As Double
        Get
            Return _teh
        End Get
        Set(value As Double)
            _teh = value
        End Set
    End Property
    Public Property PlannedProductionTime As Double
        Get
            Return _PT
        End Get
        Set(value As Double)
            _PT = value
        End Set
    End Property
    Public Property OperatingTime As Double
        Get
            Return _OT
        End Get
        Set(value As Double)
            _OT = value
        End Set
    End Property
    Public Property ShiftLength As Double
        Get
            Return _SL
        End Get
        Set(value As Double)
            _SL = value
        End Set
    End Property
    Public Property Breaks As Double
        Get
            Return _B
        End Get
        Set(value As Double)
            _B = value
        End Set
    End Property
    Public Property DownTime As Double
        Get
            Return _DT
        End Get
        Set(value As Double)
            _DT = value
        End Set
    End Property
    Public Property GoodProduct As Integer
        Get
            Return _GP
        End Get
        Set(value As Integer)
            _GP = value
        End Set
    End Property
    Public Property TotalProduct As Integer
        Get
            Return _TP
        End Get
        Set(value As Integer)
            _TP = value
        End Set
    End Property
    Public Property RejectedProduct As Integer
        Get
            Return _RP
        End Get
        Set(value As Integer)
            _RP = value
        End Set
    End Property
    Public Property IdealCycleTime As Double
        Get
            Return _RT
        End Get
        Set(value As Double)
            _RT = value
        End Set
    End Property

    'Main subroutine
    Public Sub ReDraw()
        prgA.Value = 0
        prgP.Value = 0
        prgQ.Value = 0
        lblVal.Text = "0%"
        If IsNothing(_OEE) Then
            _OEE = 0
        End If
        If Not IsNothing(lastVal) Then
            If Not _OEE = lastVal Then
                'Set OEE values into labels
                If IsNothing(_OEE) = False Then
                    lblVal.Text = _OEE.ToString & "%"
                End If
                If IsNothing(_A) = False Then
                    If (_A * 100) > 100 Then
                        prgA.Value = 100
                    ElseIf (_A * 100) < 0 Then
                        prgA.Value = 0
                    Else
                        prgA.Value = _A * 100
                    End If
                    'Set ToolTips for details on what the data means
                    tTip.SetToolTip(prgA, (_A * 100).ToString & "%")
                    tTip.SetToolTip(lblAvailability, "Operating Time(OT) / Planned Production Time(PT)" & vbLf & vbLf & _
                                    "PT = Shift Length (in minutes) - Breaks (in minutes)" & vbLf & _
                                    "OT = PT(in minutes) - Downtime(in minutes)" & vbLf & vbLf & _
                                    "((" & _SL.ToString + " - " & _B.ToString + ") -" & _DT.ToString + ") / (" & _SL.ToString & " - " & _B.ToString & ")")
                End If
                If Not IsNothing(_P) Then
                    If (_P * 100) > 100 Then
                        prgP.Value = 100
                    ElseIf (_P * 100) < 0 Then
                        prgP.Value = 0
                    Else
                        prgP.Value = _P * 100
                    End If
                    'Set ToolTips for details on what the data means
                    tTip.SetToolTip(prgP, (_P * 100).ToString & "%")
                    tTip.SetToolTip(lblPerformance, "Operating Rate(OR) / Current Runtime(PR)" & vbLf & vbLf & _
                                    "OR = (Total Estimated Hours * Pieces Finished) / Quantity to Make" & vbLf & vbLf & _
                                    "((" & _teh.ToString + " * " & _pf.ToString & ") / " & _qtm.ToString & " ) / " & _mh.ToString & "")
                End If
                If Not IsNothing(_Q) Then
                    prgQ.Minimum = 0
                    If Not _TP > 0 Then
                        prgQ.Maximum = 1
                    Else
                        prgQ.Maximum = _TP
                    End If
                    prgQ.Value = _GP
                    'Set ToolTips for details on what the data means
                    tTip.SetToolTip(prgQ, (_Q * 100).ToString & "%")
                    tTip.SetToolTip(lblQuality, "Good Product(GP) / Total Product(TP)" & vbLf & vbLf & _
                                    "TP = Total Product(in units)" & vbLf & _
                                    "GP = Total Product(in units) - Rejected Product(in units)" & vbLf & vbLf & _
                                    _GP.ToString & " / " & _TP.ToString)
                End If
                If Not IsNothing(_WorkCntr) Then
                    lblTitle.Text = _WorkCntr & ":" & _WCName
                    tTip.SetToolTip(lblTitle, "Overall Equipment Effectiveness" & vbLf & _WCName)
                End If
                '_OEE = lastVal
            End If
        Else
            'Set lastval to avoid refreshing redundant data
            lastVal = _OEE
        End If
        'Set image sprite
        '   Don't preload sprites to View Form as it takes too much space
        If _OEE > 99 Then
            picOEE.Image = GetPicturePart(My.Resources.OEE, New Rectangle(Convert.ToInt32(200 * 99), 0, Convert.ToInt32((200 * 0) + 200), 200))
        ElseIf _OEE < 0 Then
            picOEE.Image = GetPicturePart(My.Resources.OEE, New Rectangle(Convert.ToInt32(200 * 0), 0, Convert.ToInt32((200 * 0) + 200), 200))
        Else
            picOEE.Image = GetPicturePart(My.Resources.OEE, New Rectangle(Convert.ToInt32(200 * _OEE), 0, Convert.ToInt32((200 * _OEE) + 200), 200))
        End If
    End Sub

    'OEE Calculations
    Public Sub QuickCalcOEE()
        _OEE = (_A * _P * _Q) * 100
    End Sub
    Public Overloads Function CalculateGoodProduct() As Integer
        _GP = _TP - _RP
        Return _GP
    End Function
    Public Overloads Function CalculateGoodProduct(ByVal TotalProducts As Integer, ByVal RejectedProduct As Integer) As Integer
        _GP = TotalProduct - RejectedProduct
        Return _GP
    End Function
    Public Overloads Function CalculatePlannedProductionTime() As Decimal
        _PT = _SL - _B
        Return _PT
    End Function
    Public Overloads Function CalculatePlannedProductionTime(ByVal ShiftLength As Decimal, ByVal Breaks As Decimal) As Decimal
        _PT = ShiftLength - Breaks
        Return _PT
    End Function
    Public Overloads Function CalculateOperatingTime() As Decimal
        _OT = (_SL - _B) - _DT
        Return _OT
    End Function
    Public Overloads Function CalculateOperatingTime(ByVal ShiftLength As Decimal, ByVal Breaks As Decimal, ByVal DownTime As Decimal) As Decimal
        _OT = (ShiftLength - Breaks) - DownTime
        Return _OT
    End Function
    Public Overloads Function CalculateOperatingTime(ByVal PlannedProductionTime As Decimal, ByVal DownTime As Decimal) As Decimal
        _OT = PlannedProductionTime - DownTime
        Return _OT
    End Function
    Public Overloads Function CalculatePerformance() As Decimal
        _P = _RT \ (_OT \ _TP)
        Return _P
    End Function
    Public Overloads Function CalculatePerformance(ByVal IdealCycleTime As Decimal, ByVal OperatingTime As Decimal, ByVal TotalProduct As Integer) As Decimal
        _P = IdealCycleTime \ (OperatingTime \ TotalProduct)
        Return _P
    End Function
    Public Overloads Function CalculateAvailability() As Decimal
        _A = (_OT \ _PT)
        Return _A
    End Function
    Public Overloads Function CalculateAvailability(ByVal OperatingTime As Decimal, ByVal PlannedProductionTime As Decimal) As Decimal
        _A = OperatingTime \ PlannedProductionTime
        Return _A
    End Function
    Public Overloads Function CalculateOEE() As Integer
        _OEE = (_A * _P * _Q) * 100
        Return _OEE
    End Function
    Public Overloads Function CalculateOEE(ByVal Availability As Integer, ByVal Performance As Integer, ByVal Quality As Integer) As Integer
        _OEE = ((Availability / 100) * (Performance / 100) * (Quality / 100)) * 100
        Return _OEE
    End Function
    Public Overloads Function CalculateOEE(ByVal OperatingTime As Decimal, ByVal PlannedProductionTime As Decimal, ByVal IdealCycleTime As Decimal, ByVal TotalProduct As Integer, ByVal GoodProduct As Integer) As Integer
        _OEE = ((OperatingTime / PlannedProductionTime) * (TotalProduct / OperatingTime) * (GoodProduct / TotalProduct)) * 100
        Return _OEE
    End Function

End Class
