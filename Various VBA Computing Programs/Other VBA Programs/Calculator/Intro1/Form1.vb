Public Class Form1
    Dim A As Integer
    Dim B As Integer
    Dim C As Integer
    Private Sub btnaddition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddition.Click
        A = Val(txtNo1.Text)
        B = Val(TxtNo2.Text)
        C = A + B
        lblAddittion.Text = C
    End Sub

    Private Sub btnsubtraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubtraction.Click
        A = Val(txtNo1.Text)
        B = Val(TxtNo2.Text)
        C = A - B
        lblSubtraction.Text = C
    End Sub

    Private Sub btnmultiplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmultiplication.Click
        A = Val(txtNo1.Text)
        B = Val(TxtNo2.Text)
        C = A * B
        lblMultiplication.Text = C
    End Sub

    Private Sub btndivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndivision.Click
        A = Val(txtNo1.Text)
        B = Val(TxtNo2.Text)
        C = A / B
        lblDivision.Text = C
    End Sub
    Private Sub txtNo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNo1.TextChanged

    End Sub

    Private Sub lblSubtraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSubtraction.Click

    End Sub

    Private Sub lblMultiplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMultiplication.Click

    End Sub

    Private Sub lblDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDivision.Click

    End Sub
End Class
