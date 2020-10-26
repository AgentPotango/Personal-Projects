Public Class Form1
    Dim No1 As Single
    Dim No2 As Single
    Dim Answer As Single
    Private Sub btnBegin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBegin.Click

        No1 = InputBox("Enter Amount of Feet", "Average", 0)
        No2 = InputBox("Enter Second Number", "Average", 0)
        Answer = ((No1 * 12) + No2) * 2.54
        lblAnswer.Text = "Centimeters Conversion =  " & Format(Answer, "#0.00")
    End Sub

    Private Sub lblAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnswer.Click

    End Sub
End Class


