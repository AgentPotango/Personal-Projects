Public Class Form1
    Dim A As Integer
    Dim B As Integer
    Private Sub btnArea_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnArea.Click
        A = Val(txtNo1.Text)
        B = 3.142 * Math.Sqrt(A)
        lblAnswer.Text = B
    End Sub

    Private Sub btnCircumference_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnCircumference.Click
        A = Val(txtNo1.Text)
        B = 2 * 3.142 * A
        lblAnswer.Text = B
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnswer.Click, Label3.Click

    End Sub
End Class
