Public Class clsInterest
    'Data members
    Private decPrincipal As Decimal
    Private decRate As Decimal
    Private decTime As Decimal
    'Constructor
    Sub MySub()
        decPrincipal = 0
        decRate = 0
        decTime = 0
    End Sub
    'Properties
    Public Property _decPrincipal() As Decimal
        Get
            Return decPrincipal
        End Get
        Set(ByVal value As Decimal)
            decPrincipal = value
        End Set
    End Property
    Public Property _decRate() As Decimal
        Get
            Return decRate
        End Get
        Set(ByVal value As Decimal)
            decRate = value
        End Set
    End Property
    Public Property _decTime() As Decimal
        Get
            Return decTime
        End Get
        Set(ByVal value As Decimal)
            decTime = value
        End Set
    End Property
    'Method
    Public Function CalcInterest() As Decimal
        Return decPrincipal * decRate * decTime
    End Function
End Class
