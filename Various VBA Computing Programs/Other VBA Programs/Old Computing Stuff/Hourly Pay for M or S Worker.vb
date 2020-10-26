Public Class Form1

    Dim Rate As Single
    Dim Pay As Single
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If txtType.Text = "S" Then
            Rate = 7.5
            Pay = Rate * Val(txtHours.Text)
            lblDisplay.Text = "Skilled Worker - " & Format(Pay, "Currency")
        End If

        If txtType.Text = "M" Then
            Rate = 4.8
            Pay = Rate * Val(txtHours.Text)
            lblDisplay.Text = "Manual Worker - " & Format(Pay, "Currency")
        End If

        If Not ((txtType.Text = "M") Or (txtType.Text = "S")) Then
            lblDisplay.Text = "Data Input Error - Must be M or S"
        End If

    End Sub
End Class

