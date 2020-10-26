Public Class Form1
    Dim Message As String
    Dim A As Single, B As Single, C As Single
    Dim Area As Single

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        lblDisplay.Text = ""
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If radHero.Checked Then
            A = InputBox("Enter Value of Side A", "Triangle Side A", 0)
            B = InputBox("Enter Value of Side B", "Triangle Side B", 0)
            C = InputBox("Enter Value of Side C", "Triangle Side C", 0)
            Area = Hero(A, B, C)
            Message = "Area of Triangle = " & Area
        End If

        lblDisplay.Text = vbNewLine & Message
    End Sub

    Function Hero(ByVal A As Single, ByVal B As Single, ByVal C As Single) As Single
        Dim Area As Single
        Dim S As Single
        S = (A + B + C) / 2
        Area = Math.Sqrt(S * (S - A) * (S - B) * (S - C))
        Hero = Format(Area, "#0.00")
    End Function
End Class
