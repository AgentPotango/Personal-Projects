Public Class frmAccounts
    Dim SAcc As New Savings
    Dim CAcc As New Account

    Private Sub btnCAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCAccount.Click
        Call CAcc.OpenAccount("1001", "Tim", "Smith")
        Call CAcc.AmendBalance(100)
        txtAccNo.Text = CAcc.Account
        txtForename.Text = CAcc.Forename
        txtSurname.Text = CAcc.Surname
        txtBalance.Text = CAcc.Balance
        txtInterest.Text = "No Interest Paid"
    End Sub

    Private Sub btnSavings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavings.Click
        Call SAcc.OpenAccount("1002", "Deborah", "Green")
        Call SAcc.AmendBalance(1500)
        Call SAcc.AddInterest(0.06)
        txtAccNo.Text = SAcc.Account
        txtForename.Text = SAcc.Forename
        txtSurname.Text = SAcc.Surname
        txtBalance.Text = SAcc.Balance
        txtInterest.Text = SAcc.Interest
    End Sub
End Class
