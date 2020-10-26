Public Class Form1
    Dim No1 As Integer
    Dim No2 As Integer
    Dim P As Single
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        No1 = InputBox("Enter Your First Number")
        No2 = InputBox("Enter Your Second Number Number")
        P = (No2 / No1) * 100
        lblAnswer.Text = "Percentage = " & P & "%"

    End Sub
End Class
