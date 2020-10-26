Public Class Form1

    Dim A As Integer
    Dim B As Integer
    Dim C As Integer
    Private Sub btnCalculate_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnCalculate.Click
        A = Val(txtNo1.Text)
        B = Val(txtNo2.Text)
        C = Math.Sqrt(((A * A) + (B * B)))
        lblAnswer.Text = C
    End Sub

    Private Sub txtNo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNo1.TextChanged

    End Sub

    Private Sub lblAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnswer.Click

    End Sub
End Class
