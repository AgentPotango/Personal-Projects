Public Class Form1
    Const Pi = 3.142
    Dim CirArea As Single
    Dim CirCircumference As Single
    Dim RecPerimeter As Single
    Dim RecArea As Single
    Dim TriArea As Single
    Dim TriHypotenuse As Single


    Private Sub btnCircle_Click(ByVal sender As System.Object,
  ByVal e As System.EventArgs) Handles btnCircle.Click
        Dim R As Integer
        R = InputBox("Enter Circle Radius", "Circles")
        CirArea = CircleArea(R)
        CirCircumference = Circumference(R)
        lblCircle.Text = "Radius = " & R & vbNewLine & _
                "Area = " & Format(CirArea, "#0.00") & vbNewLine & _
                "Circumference = " & Format(CirCircumference, "#0.00")
    End Sub

    Private Function CircleArea(ByVal Radius As Integer) As Single
        CircleArea = Pi * Radius * Radius
    End Function

    Private Function Circumference(ByVal Radius As Integer) As Single
        Circumference = Pi * 2 * Radius
    End Function

    Private Sub Rectangle(ByVal RL As Integer, ByVal RW As Integer, _
                          ByRef RP As Single, ByRef RA As Single)
        RP = 2 * (RL + RW)
        RA = RL * RW
    End Sub

    Private Sub Triangle(ByVal A As Single, ByVal B As Single, _
                         ByRef C As Single, ByRef TArea As Single)
        C = Math.Sqrt((A * A) + (B * B))
        TArea = 1 / 2 * A * B

    End Sub


    Private Sub btnRectangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRectangle.Click
        Dim L As Integer, W As Integer
        L = InputBox("Enter Rectangle Length", "Rectangles")
        W = InputBox("Enter Rectangle Width", "Rectangles")

        Call Rectangle(L, W, RecPerimeter, RecArea)
        lblRectangle.Text = "Length = " & L & vbNewLine & _
            "Width =  " & W & vbNewLine & _
            "Area = " & Format(RecArea, "#0.00") & vbNewLine & _
            "Perimeter = " & Format(RecPerimeter, "#0.00")
    End Sub

    Private Sub btnTriangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTriangle.Click
        Dim Base As Single
        Dim Height As Single

        Base = InputBox("Enter Length of Triangle Base", "Triangles")
        Height = InputBox("Enter Height of Triangle", "Triangles")

        Call Triangle(Base, Height, TriHypotenuse, TriArea)
        lblTriangle.Text = "Base = " & Base & vbNewLine & _
            "Height = " & Height & vbNewLine & _
            "Area = " & Format(TriArea, "#0.00") & vbNewLine & _
            "Hypotenuse Length = " & Format(TriHypotenuse, "#0.00")



    End Sub
End Class
