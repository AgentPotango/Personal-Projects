Public Class Form1
    Dim RandNos(0 To 30) As Integer
    Dim N As Integer
    Dim Temp As String


    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        N = 30
        Display.Text = "Unsorted Numbers" & vbNewLine
        Display.Text = Display.Text & "==============" & vbNewLine

        For P = 1 To 30
            RandNos(P) = Math.Round(Rnd() * 100, 0)
        Next

        For P = 1 To 30
            Display.Text = Display.Text & RandNos(P) & vbNewLine
        Next P


    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        Dim Swap As Boolean
        Display.Text = ""
        N = 30
        If chkDesc.Checked = True Then
            Do
                Swap = False
                For P = 1 To N - 1
                    If RandNos(P) < RandNos(P + 1) Then
                        Swap = True
                        Temp = RandNos(P)
                        RandNos(P) = RandNos(P + 1)
                        RandNos(P + 1) = Temp
                    End If
                Next P
                N = N - 1
            Loop Until (Not (Swap) Or (N = 1))
            Display.Text = Display.Text & vbNewLine & "Sorted Numbers - Descending" & vbNewLine
            Display.Text = Display.Text & "============" & vbNewLine
            For P = 1 To 30
                Display.Text = Display.Text & RandNos(P) & vbNewLine
            Next P

        Else
            Do
                Swap = False
                For P = 1 To N - 1
                    If RandNos(P) > RandNos(P + 1) Then
                        Swap = True
                        Temp = RandNos(P)
                        RandNos(P) = RandNos(P + 1)
                        RandNos(P + 1) = Temp
                    End If
                Next P
                N = N - 1
            Loop Until (Not (Swap) Or (N = 1))
            Display.Text = Display.Text & vbNewLine & "Sorted Numbers - Ascending" & vbNewLine
            Display.Text = Display.Text & "============" & vbNewLine
            For P = 1 To 30
                Display.Text = Display.Text & RandNos(P) & vbNewLine
            Next P

        End If

    End Sub
End Class
