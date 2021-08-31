Public Class clsPersonalComputer
    Inherits clsComputer
    Public Overrides Function CalcMonthlyInstallments() As Decimal
        Return (_decCostPrice + 60) / 12
    End Function
End Class