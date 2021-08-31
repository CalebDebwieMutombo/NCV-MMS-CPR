Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Instantiation
        Dim objCylinderVolume As New clsCylinderVolume
        'Initialisation
        objCylinderVolume._decRadius = CDec(txtRadius.Text)
        objCylinderVolume._decHeight = CDec(txtHieght.Text)
        'Invoke and display result
        lblVolume.Text = objCylinderVolume.CalcCylinderVolume().ToString("N2")
    End Sub
End Class
