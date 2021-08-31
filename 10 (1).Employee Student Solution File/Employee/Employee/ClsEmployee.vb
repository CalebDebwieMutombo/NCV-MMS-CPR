Public MustInherit Class clsEmployee
    '1.1
    'Someone Programming
    '1.1.1
    'Data members
    Private strEmpNo As String
    Private strEmpName As String
    Private strEmpSurname As String
    '1.1.2
    'Constructor
    Sub MySub()
        strEmpNo = ""
        strEmpName = ""
        strEmpSurname = ""
    End Sub
    '1.1.3
    'Properties
    Public Property _strEmpNo() As String
        Get
            Return strEmpNo
        End Get
        Set(ByVal value As String)
            strEmpNo = value
        End Set
    End Property
    Public Property _strEmpName() As String
        Get
            Return strEmpName
        End Get
        Set(ByVal value As String)
            strEmpName = value
        End Set
    End Property
    Public Property _strEmpSurname() As String
        Get
            Return strEmpSurname
        End Get
        Set(ByVal value As String)
            strEmpSurname = value
        End Set
    End Property
    '1.1.4
    'Method
    Public Overridable Function CalcNetSalary() As Decimal
        Return 0
    End Function
End Class