Public Class Form1
    '2.4
    Private Sub btnCalc_Installment_Click(sender As Object, e As EventArgs) Handles btnCalc_Installment.Click
        If radLaptop.Checked = True Then
            'Declaration
            Dim objLaptop As New clsLaptop
            'Initialisation
            objLaptop._intProductNumber = CInt(txtProductNum.Text)
            objLaptop._strColour = txtColor.Text
            objLaptop._intDiskSize = CInt(txtDiskSize.Text)
            objLaptop._decCostPrice = CDec(txtCostPrice.Text)
            'Invoke and display
            lblMonthInstallment.Text = " Installment for " & objLaptop._strColour & " " & radLaptop.Text & Environment.NewLine &
                " Disksize " & objLaptop._intDiskSize & " Gig =  " & objLaptop.CalcMonthlyInstallments().ToString("C")
        End If
        If radPersonalComputer.Checked = True Then
            'Declaration
            Dim objPersonalComputer As New clsPersonalComputer
            'Initialisation
            objPersonalComputer._intProductNumber = CInt(txtProductNum.Text)
            objPersonalComputer._strColour = txtColor.Text
            objPersonalComputer._intDiskSize = CInt(txtDiskSize.Text)
            objPersonalComputer._decCostPrice = CDec(txtCostPrice.Text)
            'Invoke and display
            lblMonthInstallment.Text = " Installment for " & objPersonalComputer._strColour & " " & radPersonalComputer.Text & Environment.NewLine &
                " Disksize " & objPersonalComputer._intDiskSize & " Gig =  " & objPersonalComputer.CalcMonthlyInstallments().ToString("C")
        End If
        If radMainFrame.Checked = True Then
            'Declaration
            Dim objMainframe As New clsMainFrame
            'Initialisation
            objMainframe._intProductNumber = CInt(txtProductNum.Text)
            objMainframe._strColour = txtColor.Text
            objMainframe._intDiskSize = CInt(txtDiskSize.Text)
            objMainframe._decCostPrice = CDec(txtCostPrice.Text)
            'Invoke and display
            lblMonthInstallment.Text = " Installment for " & objMainframe._strColour & " " & radMainFrame.Text & Environment.NewLine &
                " Disksize " & objMainframe._intDiskSize & " Gig =  " & objMainframe.CalcMonthlyInstallments().ToString("C")
        End If
    End Sub




End Class