Public Class Form1
    Dim No1 As Single
    Dim C As Single

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        No1 = InputBox("Enter Temperate in Celcius here")
        C = 1.8 * No1 + 32
        lblAnswer.Text = No1 & " Celsius " & "Is " & C & " In Fahrenheit "
    End Sub
End Class
