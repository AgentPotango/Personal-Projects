Public Class Form
    Dim PriceofSnack As Single
    Dim R As Integer
    Dim No200 As Integer
    Dim No100 As Integer
    Dim No50 As Integer
    Dim No20 As Integer
    Dim No10 As Integer
    Dim No5 As Integer
    Dim No2 As Integer
    Dim No1 As Integer


    Private Sub BtnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click
        No200 = PriceofSnack \ 200
        R = PriceofSnack Mod 200
        No100 = R \ 100
        R = PriceofSnack Mod 100
        No50 = R \ 50
        R = PriceofSnack Mod 50
        No20 = R \ 20
        R = PriceofSnack Mod 20
        No10 = R \ 10
        R = PriceofSnack Mod 10
        No5 = R \ 5
        R = PriceofSnack Mod 5
        No2 = R \ 5
        R = PriceofSnack Mod 2
        No1 = PriceofSnack Mod 1

        lbl200.Text = No200
        lbl100.Text = No100
        lbl50.Text = No50
        lbl20.Text = No20
        lbl5.Text = No5
        lbl2.Text = No2
        lbl1.Text = No1

    End Sub
End Class
