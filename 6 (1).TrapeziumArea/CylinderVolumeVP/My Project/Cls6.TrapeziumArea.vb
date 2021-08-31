Public Class ClsTrapeziumArea
    Private decLowerSide As Decimal
    Private decHigherSide As Decimal
    Private decHight As Decimal

    Private newPropertyValue As String
    Public Property NewProperty() As String
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As String)
            newPropertyValue = value
        End Set
    End Property
End Class
