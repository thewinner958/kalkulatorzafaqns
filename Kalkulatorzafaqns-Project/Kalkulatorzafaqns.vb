Public Class Kalkulatorzafaqns

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblOutput.Text =
            Format((2 * (Val(txtBathWidth.Text) + Val(txtBathLenght.Text)) _
            * Val(txtBathHeight.Text)) - Val(txtDoorWidth.Text) * Val(txtDoorHeight.Text), "#####.## 'кв.м'")
    End Sub
End Class
