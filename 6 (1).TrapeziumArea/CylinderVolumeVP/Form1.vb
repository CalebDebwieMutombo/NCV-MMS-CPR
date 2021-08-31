Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Instantiation
        Dim objTrapeziumArea As New clsTrapeziumArea
        'Validation and initialisation
        Try
            objTrapeziumArea._decLowerSide = CDec(txtLowerSide.Text)
            objTrapeziumArea._decUpperSide = CDec(txtUpperSide.Text)
            objTrapeziumArea._decHeight = CDec(txtHeight.Text)
        Catch
            MessageBox.Show("Enter numeric inputs")
        End Try
        'Invoke and display
        lblArea.Text = objTrapeziumArea.CalcTrapeziumArea().ToString()
    End Sub
End Class