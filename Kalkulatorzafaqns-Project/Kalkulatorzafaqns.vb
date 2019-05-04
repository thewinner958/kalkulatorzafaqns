Public Class Kalkulatorzafaqns

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblOutput = 2 * (Val(txtBathWidth.Text) + Val(txtBathLenght.Text))
    End Sub
End Class
