Public Class Form1
    Const VATconst = 0.175
    Const Underlayconst = 3.99
    Const Fittingconst = 0.08
    Dim Make(9) As String
    Dim PatternName(9) As String
    Dim Code(9) As String
    Dim Priceper(9) As Single 'Price per Square Metre
    Dim TotalPrice As Single
    Dim VAT As Single
    Dim CarpetPPSM As Single ' Price Per Metre x Carpet Dimensions
    Dim Fitting As Single
    Dim Underlay As Single
    Dim Total As Single ' Total is the total CarpetPPSM + Underlay + Fitting (Not Including VAT)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Makes
        Make(0) = "Wilton"
        Make(1) = "Wilton"
        Make(2) = "Wilton"
        Make(3) = "Axminster"
        Make(4) = "Axminster"
        Make(5) = "Axminster"
        Make(6) = "Axminster"
        Make(7) = "Saxony"
        Make(8) = "Saxony"
        Make(9) = "Saxony"

        'Code
        Code(0) = "W301-3"
        Code(1) = "W563-8"
        Code(2) = "W678-6"
        Code(3) = "A788090"
        Code(4) = "A788990"
        Code(5) = "A345788"
        Code(6) = "A543667"
        Code(7) = "S90878"
        Code(8) = "S90654"
        Code(9) = "S90623"

        'Pattern Name
        PatternName(0) = "Buttermilk"
        PatternName(1) = "Carved Ivory"
        PatternName(2) = "Coconut"
        PatternName(3) = "Earth"
        PatternName(4) = "Hayrick"
        PatternName(5) = "Sesame"
        PatternName(6) = "Cinnamon"
        PatternName(7) = "Honey"
        PatternName(8) = "Juniper"
        PatternName(9) = "Paprika"

        'Price Per Square Metre
        Priceper(0) = 17.99
        Priceper(1) = 17.49
        Priceper(2) = 16.5
        Priceper(3) = 21.99
        Priceper(4) = 19.99
        Priceper(5) = 17.99
        Priceper(6) = 15.99
        Priceper(7) = 14.99
        Priceper(8) = 16.99
        Priceper(9) = 18.99

        For C = 0 To 9
            cboCarpets.Items.Add(Make(C) & " " & Code(C) & " " & PatternName(C))
        Next C
    End Sub

    Private Function UnderlayCost(ByVal L As Single, ByVal W As Single) As Single
        UnderlayCost = L * W * Underlayconst

    End Function

    Private Function FittingCost(ByVal PPSM As Single, ByVal Underlay As Single) As Single
        FittingCost = (PPSM + Underlay) * Fittingconst

    End Function

    Private Function TotalCost(ByVal PPSM As Single, ByVal Underlay As Single, ByVal Fitting As Single) As Single
        TotalCost = PPSM + Underlay + Fitting

    End Function

    Private Function PPSM(ByVal Length As Single, ByVal Width As Single, ByVal PricePer As Single) As Single
        PPSM = (Length * Width * PricePer)

    End Function

    Private Function FinalPrice(ByVal VAT As Single, ByVal Total As Single) As Single
        FinalPrice = Total + VAT

    End Function

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        For C = 0 To 9
            If cboCarpets.SelectedIndex = C Then
                CarpetPPSM = PPSM(txtLength.Text, txtWidth.Text, Priceper(C))
                If chkUnderlay.Checked = True Then
                    Underlay = UnderlayCost(txtLength.Text, txtWidth.Text)
                Else : Underlay = 0
                End If
                If chkFitting.Checked = True Then
                    Fitting = FittingCost(CarpetPPSM, Underlay)
                Else
                    Fitting = 0
                End If
                Total = TotalCost(CarpetPPSM, Underlay, Fitting)
                VAT = VATconst * Total
                TotalPrice = FinalPrice(VAT, Total)
                lblDisplay.Text = "Magic Carpets Limited Reciept" & vbNewLine & _
                                  "=============================" & vbNewLine & _
                                  "Make: " & Make(C) & vbNewLine & _
                                  "Code: " & Code(C) & vbNewLine & _
                                  "Pattern: " & PatternName(C) & vbNewLine & _
                                  "Price Per Square Metre: " & Format(Priceper(C), "Currency") & vbNewLine & _
                                  "Length: " & txtLength.Text & " Metres" & vbNewLine & _
                                  "Width: " & txtWidth.Text & " Metres" & vbNewLine & _
                                  "VAT: " & Format(VAT, "Currency") & vbNewLine & _
                                  "Fitting Cost: " & Format(Fitting, "Currency") & vbNewLine & _
                                  "Underlay Cost: " & Format(Underlay, "Currency") & vbNewLine & _
                                  "Total Price (Ex Vat): " & Format(Total, "Currency") & vbNewLine & _
                                  "Total Price(Inc Vat): " & Format(TotalPrice, "Currency")
            End If
            Next
    End Sub
End Class

