Public Class Form1
    Dim f As Font

    Private Sub btnChelsea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChelsea.Click
        lblTitle.BackColor = Color.Blue
        lblTitle.ForeColor = Color.White
        lblTitle.Text = "Chelsea"
        FontDialog1.Font = lblTitle.Font
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblTitle.Font = FontDialog1.Font
        End If
    End Sub
    Private Sub btnManU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManU.Click
        lblTitle.BackColor = Color.Red
        lblTitle.ForeColor = Color.White
        lblTitle.Text = "Manchester United"
        FontDialog1.Font = lblTitle.Font
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblTitle.Font = FontDialog1.Font
        End If
    End Sub
    Private Sub btnArsenal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArsenal.Click
        lblTitle.BackColor = Color.Yellow
        lblTitle.ForeColor = Color.Black
        lblTitle.Text = "Arsenal"
        FontDialog1.Font = lblTitle.Font
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblTitle.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub btnNetherlands_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNetherlands.Click
        lblTitle.BackColor = Color.Orange
        lblTitle.ForeColor = Color.Black
        lblTitle.Text = "Netherlands"
        FontDialog1.Font = lblTitle.Font
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblTitle.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class






