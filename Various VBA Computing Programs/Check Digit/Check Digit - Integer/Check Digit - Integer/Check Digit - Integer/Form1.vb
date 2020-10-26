Public Class Form1
    REM Valid Examples
    REM 4734K  1234I
    REM 3727I  1589B
    REM 7462H  9394E

    Public Function CheckDigit(ByVal IDNo As Integer) As Boolean
        Dim Valid As Boolean
        Dim CheckNumber As String
        Dim ProdTotal As Integer
        Dim Remainder As Integer

        Valid = True
        If Valid Then
            ProdTotal = Mid(IDNo, 1, 1) * 9 + Mid(IDNo, 2, 1) * 7 + Mid(IDNo, 3, 1) * 5 + Mid(IDNo, 4, 1) * 3 + Mid(IDNo, 5, 1) * 2
            Remainder = ProdTotal Mod 9
            CheckNumber = Remainder
            If CheckNumber <> Mid(IDNo, 6, 1) Then
                Valid = False
            End If
        End If



    End Function


    Private Sub btnCheckDigit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckDigit.Click
        If CheckDigit(txtIDNumber.Text) Then
            MsgBox("Valid ID Number")
        Else
            MsgBox("Invalid ID Number")
        End If
    End Sub
End Class





