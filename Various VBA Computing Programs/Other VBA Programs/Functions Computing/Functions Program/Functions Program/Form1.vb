Public Class Form1
    Dim CA As Single
    Dim CC As Single

    Private Function CircleArea(ByVal Radius As Integer) As Single
        CircleArea = 3.142 * Radius * Radius
    End Function

    Private Function Circumference(ByVal Radius As Integer) As Single
        Circumference = 3.142 * 2 * Radius
    End Function

    Private Sub btnCircle_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnCircle.Click
        Dim R As Integer
        R = InputBox("Enter Circle Radius", "Circles")
        CA = CircleArea(R)
        CC = Circumference(R)
        lblDisplay.Text = "Radius = " & R & vbNewLine & _
                         "Area = " & Format(CA, "#0.00") & vbNewLine & _
                         "Circumference = " & Format(CC, "#0.00")
    End Sub
    Function RectangleArea(ByVal Height As Single, ByVal Width As Single) As Single
        RectangleArea = Width * Height

    End Function
    Function RectanglePerimeter(ByVal Height As Single, ByVal Width As Single) As Single
        RectanglePerimeter = 2 * Width + 2 * Height
    End Function

    Private Sub btnRectangle_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnRectangle.Click
        Dim RA As Single
        Dim RP As Single
        Dim W As Single
        Dim H As Single
        W = InputBox("Enter Width", "Width", 0)
        H = InputBox("Enter Height", "Height", 0)
        RA = RectangleArea(W, H)
        RP = RectanglePerimeter(W, H)
        lblDisplay.Text = "Rectangle Area = " & RA & vbNewLine & _
                          "Rectangle Perimeter = " & RP
    End Sub

    Function TriangleArea(ByVal Base As Single, ByVal Height As Single) As Single
        TriangleArea = 1 / 2 * Base * Height
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim H As Single
        Dim B As Single
        Dim TA As Single
        H = InputBox("Enter Height length")
        B = InputBox("Enter Base length")
        TA = TriangleArea(B, H)
        lblDisplay.Text = "Triangle Area = " & TA
    End Sub

End Class


   