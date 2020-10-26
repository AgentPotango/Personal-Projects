Public Class btnGenerate
    Dim RandNos(50) As Integer
    Dim OneCount As Integer
    Dim TenCount As Integer
    Dim RangeFiveCount As Integer
    Dim Output As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For C = 1 To 5
            RandNos(C) = Int(Rnd() * 10) + 1
            If RandNos(C) = 1 Then
                OneCount = OneCount + 1
            End If

            If RandNos(C) < 5 Then
                RangeFiveCount = RangeFiveCount + 1
            End If

            If RandNos(C) = 10 Then
                TenCount = TenCount + 1
            End If
            Output = Output & RandNos(C) & vbNewLine
        Next C
        Output = Output & "Random Numbers Display" & vbNewLine
        Output = Output & "Occurance of Number One" & OneCount & "times." & vbNewLine
        Output = Output & "Occurance of Number Ten" & TenCount & "times." & vbNewLine
        Output = Output & "Occurance of Numbers 1 - 5" & RangeFiveCount & "times." & vbNewLine
        lblDisplay.Text = Output

    End Sub
End Class
