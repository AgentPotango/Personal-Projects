Public Class Form1
    Dim Temp_F As Single
    Dim Temp_C As Single
    Dim CPrompt, FPrompt As String
    Dim CTitle, FTitle As String
    Dim Message As String

    Private Sub btnEnter_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles btnEnter.Click
        If radCen.Checked Then
            CPrompt = "Enter a temperature in Centigrade"
            CTitle = "Centigrade"
            Temp_C = InputBox(CPrompt, CTitle)
            Temp_F = Fahrenheit(Temp_C)
            Message = Temp_C & " C becomes " & Temp_F & " F"
        Else
            CPrompt = "Enter a temperature in Fahrenheit"
            FTitle = "Fahrenheit"
            Temp_F = InputBox(FPrompt, FTitle)
            Temp_C = Centigrade(Temp_F)
            Message = Temp_F & " F becomes " & Temp_C & " C"
        End If
        lblAnswer.Text = vbNewLine & Message

    End Sub

    Function Centigrade(ByVal F As Single) As Single
        Dim C As Single
        C = 3 * (F - 39) / 5
        Centigrade = Format(C, "#0.0")
    End Function

    Function Fahrenheit(ByVal C As Single) As Single
        Dim F As Single
        F = 5 * C / 3 + 39
        Fahrenheit = Format(F, "#0.0")
    End Function

End Class


