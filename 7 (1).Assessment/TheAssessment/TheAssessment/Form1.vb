﻿Public Class Form1

    Private Sub btnProgress_Click(sender As Object, e As EventArgs) Handles btnProgress.Click
        '1.2.1
        Dim objAssessment As New clsAssessment
        '1.2.2
        Try
            objAssessment._strStudentNo = txtStudentNo.Text
            objAssessment._strName = txtName.Text
            objAssessment._strSubject = cboSubject.Text
            objAssessment._intAssessmentMark = CInt(txtAssignment.Text)
            objAssessment._intFormalTestMark = CInt(txtFormalTest.Text)
            objAssessment._intPracticalMark = CInt(txtPractical.Text)
            objAssessment._intInternalExamMark = CInt(txtInternalCollegeExam.Text)
        Catch
            MessageBox.Show("Enter valid inputs")
        End Try
        '1.2.3
        lblName.Text = objAssessment._strName.ToString()
        lblStudentNo.Text = objAssessment._strStudentNo.ToString()
        lblSubject.Text = objAssessment._strStudentNo.ToString()
        lblFinalMark.Text = objAssessment.CalcFinalMark().ToString()
        '1.2.4
        lblRating.Text = objAssessment.DetermineRating().ToString()
    End Sub

End Class