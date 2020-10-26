Public Class Form1

    Dim A As Integer
    Dim B As Integer
    Dim C As Integer
    Dim G As Integer

    Private Sub btnA_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnA.Click
        A = Val(txtNo1.Text)
        B = Val(txtNo2.Text)
        C = Val(txtNo3.Text)
        G = (A + B + C) / 3
        lblAnswer.Text = G
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnC.Click
        A = Val(txtNo1.Text)
        B = Val(txtNo2.Text)
        C = Val(txtNo3.Text)
        G = (A + (B * C))
        lblAnswer.Text = G
    End Sub
    Private Sub btnD_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnD.Click
        A = Val(txtNo1.Text)
        B = Val(txtNo2.Text)
        C = Val(txtNo3.Text)
        G = (A * B * C)
        lblAnswer.Text = G
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtNo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNo1.TextChanged

    End Sub

    Private Sub lblAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnswer.Click

    End Sub

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click

    End Sub
End Class
