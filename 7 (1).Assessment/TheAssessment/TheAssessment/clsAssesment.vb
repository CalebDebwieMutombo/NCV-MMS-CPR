Public Class clsAssessment
    '1.1.1 a
    'Data members
    Private strStudentNo As String
    Private strName As String
    Private strSubject As String
    Private intAssessmentMark As Integer
    Private intFormalTestMark As Integer
    Private intPracticalMark As Integer
    Private intInternalExamMark As Integer
    'Constructor
    Sub MySub()
        strStudentNo = ""
        strName = ""
        strSubject = ""
        intAssessmentMark = 0
        intFormalTestMark = 0
        intPracticalMark = 0
        intInternalExamMark = 0
    End Sub
    '1.1.1 b
    'Properties
    Public Property _strStudentNo() As String
        Get
            Return strStudentNo
        End Get
        Set(ByVal value As String)
            strStudentNo = value
        End Set
    End Property
    Public Property _strName() As String
        Get
            Return strStudentNo
        End Get
        Set(ByVal value As String)
            strStudentNo = value
        End Set
    End Property
    Public Property _strSubject() As String
        Get
            Return strSubject
        End Get
        Set(ByVal value As String)
            strSubject = value
        End Set
    End Property
    Public Property _intAssessmentMark() As Integer
        Get
            Return intAssessmentMark
        End Get
        Set(ByVal value As Integer)
            intAssessmentMark = value
        End Set
    End Property
    Public Property _intFormalTestMark() As Integer
        Get
            Return intFormalTestMark
        End Get
        Set(ByVal value As Integer)
            intFormalTestMark = value
        End Set
    End Property
    Public Property _intPracticalMark() As Integer
        Get
            Return intPracticalMark
        End Get
        Set(ByVal value As Integer)
            intPracticalMark = value
        End Set
    End Property
    Public Property _intInternalExamMark() As Integer
        Get
            Return intInternalExamMark
        End Get
        Set(ByVal value As Integer)
            intInternalExamMark = value
        End Set
    End Property
    '1.1.2
    'Method
    Public Function CalcFinalMark() As Integer
        Return intAssessmentMark * 0.1 + intFormalTestMark * 0.1 + intPracticalMark * 0.2 + intInternalExamMark * 0.6
    End Function
    '1.1.3
    Public Function DetermineRating() As String
        Dim _strFeedback As String
        If CalcFinalMark() < 50 Then
            _strFeedback = "Not Yet Competent "
        Else
            _strFeedback = "Competent"
        End If
        Return _strFeedback
    End Function
End Class