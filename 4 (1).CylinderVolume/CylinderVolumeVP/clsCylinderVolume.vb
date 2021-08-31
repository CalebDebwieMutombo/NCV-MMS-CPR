Public Class clsCylinderVolume
    'Declare  constant
    Public decPi As Decimal = 22 / 7
    'Declare data memebers
    Private decRadius As Decimal
    Private decHeight As Decimal
    'Constructor
    Sub MySub()
        decRadius = 0
        decHeight = 0
    End Sub
    'Properties
    Public Property _decRadius() As Decimal
        Get
            Return decRadius
        End Get
        Set(ByVal value As Decimal)
            decRadius = value
        End Set
    End Property
    Public Property _decHeight() As Decimal
        Get
            Return decHeight
        End Get
        Set(ByVal value As Decimal)
            decHeight = value
        End Set
    End Property
    Function CalcCylinderVolume() As Decimal
        Return (decPi * decRadius * decRadius) * decHeight
    End Function
End Class