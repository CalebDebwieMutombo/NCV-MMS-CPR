Public Class clsSalaryCalculator
    'Data members
    Private decSalary As Decimal
    Private strWorkerRank As String
    Private intIncrease As Integer
    'Constructor
    Sub MySub()
        decSalary = 0
        strWorkerRank = ""
        intIncrease = 0
    End Sub
    'Properties
    Public Property _decSalary() As Decimal
        Get
            Return decSalary
        End Get
        Set(ByVal value As Decimal)
            decSalary = value
        End Set
    End Property
    Public Property _strWorkerRank() As String
        Get
            Return strWorkerRank
        End Get
        Set(ByVal value As String)
            strWorkerRank = value
        End Set
    End Property
    Public Property _intIncrease() As Integer
        Get
            Return intIncrease
        End Get
        Set(ByVal value As Integer)
            intIncrease = value
        End Set
    End Property
    'Method
    Function CalcSalaryIncrease() As Decimal
        Return (intIncrease / 100 * decSalary) + decSalary
    End Function
End Class