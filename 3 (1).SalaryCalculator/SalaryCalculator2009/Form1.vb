Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instanciation 
        Dim objectSalaryCalculator As New ClsCalculater

        'Initialisation
        objectSalaryCalculator._decSalalry = CDec(txtSalary.Text)
        objectSalaryCalculator._strWorkerRank = CStr(txtRank.Text)
        objectSalaryCalculator._intIncrease = CInt(txtSalaryIncrease.Text)

    End Sub
End Class
