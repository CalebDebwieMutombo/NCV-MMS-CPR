Public Class clsLaptop
    Inherits clsComputer

    Public Overrides Function CalcMonthlyInstallments() As Decimal
        Return (_decCostPrice + 50) / 12
    End Function
End Class