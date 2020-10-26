Public Class Form1
    Dim CA As Single    'Circle Area
    Dim CC As Single    'Circle Circumference
    Dim R As Single     'Radius
    Dim RA As Single    'Rectangle Area
    Dim RP As Single    'Rectangle Perimeter
    Dim L As Single     'Length
    Dim W As Single     'Width
    Dim TA As Single    'Triangle Area
    Dim B As Single     'Base
    Dim H As Single     'Height
    Dim EuroEx As Single    'Euros Exchange Rate
    Dim RupeeEx As Single   'Rupees Exchange Rate
    Dim USEx As Single      'Dollars Exchange Rate
    Dim Country As String   'Which Country's Rate
    Dim AmountPounds As Single  'Amount of Pounds
    Dim AmountEuro As Single 'Amount of Euros
    Dim AmountDollars As Single 'Amount of Dollars
    Dim AmountRupees As Single 'Amount of Rupees

    Private Sub btnCircles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCircles.Click
        R = InputBox("Enter Radius", "Circles")
        Call Cirles()
        lblOutput.Text = "Circles" & vbNewLine & _
                         "Radius = " & R & vbNewLine & _
                         "Area = " & CA & vbNewLine & _
                         "Circumference = " & CC
    End Sub


    Private Sub btnRectangles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRectangles.Click
        L = InputBox("Enter Length", "Rectangles")
        W = InputBox("Enter Width", "Width")
        Call Rectangles()
        lblOutput.Text = "Rectangles" & vbNewLine & _
                         "Length = " & L & vbNewLine & _
                         "Width = " & W & vbNewLine & _
                         "Area = " & RA & vbNewLine & _
                         "Perimeter = " & RP
    End Sub

    Private Sub btnTriangles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTriangles.Click
        B = InputBox("Enter Base", "Triangles")
        H = InputBox("Enter Height", "Triangles")
        Call Triangles()
        lblOutput.Text = "Triangles" & vbNewLine & _
                         "Base = " & B & vbNewLine & _
                         "Height = " & H & vbNewLine & _
                         "Area = " & TA

    End Sub

    Private Sub btnCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCurrency.Click
        EuroEx = 1.2
        RupeeEx = 139
        USEx = 1.45
        Country = InputBox("Enter Country", "Country")
        AmountPounds = InputBox("Enter Amount of Pounds", "Amount")
        If Country = "Euro" Then
            AmountEuro = AmountPounds * EuroEx
        ElseIf Country = "USA" Then
            AmountDollars = AmountPounds * USEx
        ElseIf Country = "Pakistan" Then
            AmountRupees = AmountPounds * RupeeEx
        End If

        lblOutput.Text = "From Pounds to" & Country & "Currency" & vbNewLine & _
                         "Amount of Pounds: " = Format(AmountPounds, "#0.00") & vbNewLine & _
                         "New Currency: " = "Put into IF Statement you retard"

    End Sub
    Private Sub Cirles()
        CA = 3.142 * R * R
        CC = 2 * 3.142 * R
    End Sub

    Private Sub Rectangles()
        RA = L * W
        RP = 2 * (L + W)
    End Sub

    Private Sub Triangles()
        TA = (B * H) / 2
    End Sub
End Class
