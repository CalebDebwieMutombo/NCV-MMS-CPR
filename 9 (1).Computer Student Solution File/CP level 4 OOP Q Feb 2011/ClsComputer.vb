Public MustInherit Class clsComputer

    'Data Member
    Private intProductNumber As Integer
    Private strColour As String
    Private intDiskSize As Integer
    Private decCostPrice As Decimal
    'Constructor
    Sub MySub()
        intProductNumber = 0
        intDiskSize = 0
        strColour = ""
        decCostPrice = 0

    End Sub
    'Property
    Public Property _intProductNumber() As Integer
        Get
            Return intProductNumber
        End Get
        Set(ByVal value As Integer)
            intProductNumber = value
        End Set
    End Property

    Public Property _strColour() As String
        Get
            Return strColour
        End Get
        Set(ByVal value As String)
            strColour = value
        End Set
    End Property

    Public Property _intDiskSize() As Integer
        Get
            Return intDiskSize
        End Get
        Set(ByVal value As Integer)
            intDiskSize = value
        End Set
    End Property

    Public Property _decCostPrice() As Decimal
        Get
            Return decCostPrice
        End Get
        Set(ByVal value As Decimal)
            decCostPrice = value
        End Set
    End Property
    'Method
    Overridable Function CalcMonthlyInstallments() As Decimal

        Return 0
    End Function

End Class