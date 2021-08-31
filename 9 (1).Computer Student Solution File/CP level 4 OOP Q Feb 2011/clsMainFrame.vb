Public Class clsMainFrame
    Inherits clsComputer
    Public Overrides Function CalcMonthlyInstallments() As Decimal
        Return (_decCostPrice + 200) / 12
    End Function
End Class