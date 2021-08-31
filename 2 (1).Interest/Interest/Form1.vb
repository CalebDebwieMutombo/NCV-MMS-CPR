Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Instantiation
        Dim objInterest As New clsInterest
        'Initialisation
        objInterest._decPrincipal = CDec(txtPrincipal.Text)
        objInterest._decRate = CDec(txtRate.Text)
        objInterest._decTime = CDec(txtTime.Text)
        'Invoke and display result
        lblInterest.Text = objInterest.CalcInterest().ToString()
    End Sub

End Class
