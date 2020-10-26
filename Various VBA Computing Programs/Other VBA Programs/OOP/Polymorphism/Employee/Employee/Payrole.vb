Public Class frmEmployee
    Dim Emp1 As New Employee
    Dim Emp2 As New Junior

    Private Sub cmdAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdult.Click
        Dim HoursWorked As Integer
        Emp1.Forename = InputBox("Enter Forename", "Payrole")
        Emp1.Surname = InputBox("Enter Surname", "Payrole")
        Emp1.Type = "Adult"
        HoursWorked = InputBox("Enter Hours Worked", "Payrole")
        txtForename.Text = Emp1.Forename
        txtSurname.Text = Emp1.Surname
        txtType.Text = Emp1.Type
        txtPay.Text = Emp1.Pay(HoursWorked)
        txtGuardian.Visible = False
    End Sub

    Private Sub cmdJunior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdJunior.Click
        Dim HoursWorked As Integer
        Emp2.Forename = InputBox("Enter Forename", "Payrole")
        Emp2.Surname = InputBox("Enter Surname", "Payrole")
        Emp2.Guardian = InputBox("Enter Guardian", "Payrole")
        Emp2.Type = "Junior"
        HoursWorked = InputBox("Enter Hours Worked", "Payrole")
        txtForename.Text = Emp2.Forename
        txtSurname.Text = Emp2.Surname
        txtType.Text = Emp2.Type
        txtPay.Text = Emp2.Pay(HoursWorked)
        txtGuardian.Visible = True
        txtGuardian.Text = Emp2.Guardian
    End Sub
End Class
