Public Class clsFullTime
    'Someone Programming
    '1.2
    'Inheritence
    Inherits clsEmployee
    'Data members
    Private decAnnualSalary As Decimal
    'Constructor
    Sub New()
        decAnnualSalary = 0
    End Sub
    'Property
    Public Property _decAnnualSalary() As Decimal
        Get
            Return decAnnualSalary
        End Get
        Set(ByVal value As Decimal)
            decAnnualSalary = value
        End Set
    End Property
    'Method
    Public Overrides Function CalcNetSalary() As Decimal
        Return decAnnualSalary / 12
    End Function
End Class