Public Class clsTrapeziumArea
    'Data members
    Private decLowerSide As Decimal
    Private decUpperSide As Decimal
    Private decHeight As Decimal
    'Constructor
    Sub MySub()
        decLowerSide = 0
        decUpperSide = 0
        decHeight = 0
    End Sub
    'Properties
    Public Property _decLowerSide() As Decimal
        Get
            Return decLowerSide
        End Get
        Set(ByVal value As Decimal)
            decLowerSide = value
        End Set
    End Property
    Public Property _decUpperSide() As Decimal
        Get
            Return decUpperSide
        End Get
        Set(ByVal value As Decimal)
            decUpperSide = value
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
    'Method
    Public Function CalcTrapeziumArea() As Decimal
        Return 0.5 * (decLowerSide + decUpperSide) * decHeight
    End Function
End Class