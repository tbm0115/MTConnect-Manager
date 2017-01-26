Public Class Meter_Dial
    Private act As Double = 0
    Private min As Double = 0
    Private max As Double = 10
    Public Property Actual() As Double
        Get
            Return act
        End Get
        Set(ByVal Value As Double)
            act = Value
            txtValue.Text = Actual.ToString
            txtValue.TextAlign = HorizontalAlignment.Center
        End Set
    End Property
    Public Property AbsMinimum As Double
        Get
            Return min
        End Get
        Set(ByVal Value As Double)
            min = Value
        End Set
    End Property
    Public Property AbsMaximum As Double
        Get
            Return max
        End Get
        Set(ByVal Value As Double)
            max = Value
        End Set
    End Property

    Private Sub TestControl_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call Redraw_Meter()
    End Sub

    Public Function Redraw_Meter()
        imgDial.Image = My.Resources.Meter_Dial_SpriteSheet
        Dim img As New Bitmap(imgDial.Image)
        Dim frames As Bitmap
        Dim x As Integer = ((act - min) / (max - min)) * 43
        frames = New Bitmap(178, 90)
        Dim gr As Graphics = Graphics.FromImage(frames)
        gr.DrawImage(img, 0, 0, New RectangleF(x * 178, 0, (x * 178) + 178, 90), GraphicsUnit.Pixel)
        imgDial.Image = frames
        Return x
    End Function

End Class
