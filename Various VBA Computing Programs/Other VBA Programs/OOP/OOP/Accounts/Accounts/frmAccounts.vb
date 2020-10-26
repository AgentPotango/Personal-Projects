Public Class frmAccounts
    Dim Acc1 As New Account
    Dim Acc2 As New Account
    Dim Acc3 As New Account
    Dim Acc(0 To 2) As Account
    Dim Counter As Integer = 0
    Private Sub cmdAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccounts.Click
        Call Acc1.OpenAccount("0001", "Phil", "Harker")
        Call Acc2.OpenAccount("0002", "Geoff", "Friar")
        Call Acc3.OpenAccount("0003", "Jennifer", "Holt")
        Acc(0) = Acc1
        Acc(1) = Acc2
        Acc(2) = Acc3
        MsgBox("Accounts Opened", MsgBoxStyle.OkOnly, "OOP")
        cmdViewAccounts.Enabled = True
    End Sub

    Private Sub cmdViewAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewAccounts.Click
        If Counter = 3 Then Counter = 0
        txtAccNo.Text = Acc(Counter).Account
        txtForename.Text = Acc(Counter).Forename
        txtSurname.Text = Acc(Counter).Surname
        txtBalance.Text = Acc(Counter).Balance
        If Counter = 2 Then
            Counter = 0
        Else
            Counter = Counter + 1
        End If
    End Sub

    Private Sub cmdAmendBal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAmendBal.Click
        Dim AmendAmount As Integer
        Dim AmendAccNo As String
        Dim C As Integer
        Dim Found As Boolean
        AmendAccNo = InputBox("Enter Account Number")
        AmendAmount = InputBox("Enter Amount")
        Found = False
        For C = 0 To 2
            If Acc(C).Account = AmendAccNo Then
                Acc(C).AmendBalance(AmendAmount)
                Found = True
            End If
        Next C
        If Found Then
            MsgBox("Account " & AmendAccNo & " Balances Update", MsgBoxStyle.OkOnly, "OOP")
        Else
            MsgBox("Account Not Found", MsgBoxStyle.Information, "OOP")
        End If
    End Sub
End Class
