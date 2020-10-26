Public Class Form1
    REM Valid Examples
    REM 4734K  1234I
    REM 3727I  1589B
    REM 7462H  9394E

    Public Function CheckDigit(ByVal IDNo As String) As Boolean
        Dim Valid As Boolean
        Dim AsciiVal As Integer
        Dim CheckLetter As String
        Dim IDString(5) As String
        Dim IDInteger(5) As Integer
        Dim ProdTotal As Integer
        Dim Remainder As Integer
        Dim C As Integer

        Valid = True
        For C = 1 To 5
            IDString(C) = Mid(IDNo, C, 1)
            AsciiVal = Asc(IDString(C))
            If ((AsciiVal < 48) Or (AsciiVal > 57)) Then
                Valid = False
            End If
        Next C

        If Valid Then
            For C = 1 To 5
                IDInteger(C) = Asc(IDString(C)) - 48
            Next C
            ProdTotal = IDInteger(1) * 9 + IDInteger(2) * 7 + IDInteger(3) * 5 + IDInteger(4) * 3 + IDInteger(5) * 2
            Remainder = ProdTotal Mod 9
            CheckLetter = Chr(Remainder + 65)
            If CheckLetter <> Mid(IDNo, 5, 1) Then
                Valid = False
            End If
        End If

        CheckDigit = Valid

    End Function


    Private Sub btnCheckDigit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckDigit.Click
        If CheckDigit(txtIDNumber.Text) Then
            MsgBox("Valid ID Number")
        Else
            MsgBox("Invalid ID Number")
        End If
    End Sub
End Class

