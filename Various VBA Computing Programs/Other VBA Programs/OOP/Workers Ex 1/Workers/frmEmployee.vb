Public Class frmWorker
    Dim EmployeeID As String
    Dim EmployeeName As String
    Dim EmployeeRate As Single
    Dim EmployeeHours As Integer
    Dim EmployeeWage As Single
    Dim Emp1 As New Employee

    Private Sub cmdNEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNEmployee.Click
        EmployeeID = InputBox("Enter ID")
        EmployeeName = InputBox("Enter Name")
        EmployeeRate = InputBox("Enter Rate")
        Call Emp1.WKInitialise(EmployeeID, EmployeeName, EmployeeRate)
        txtID.Text = Emp1.ID
        txtName.Text = Emp1.Name
        txtRate.Text = Format(Emp1.Rate, "Currency")
    End Sub

    Private Sub cmdHours_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHours.Click
        EmployeeHours = InputBox("Enter Hours")
        Call Emp1.WKCalWage(EmployeeHours)
        txtHours.Text = Emp1.Hours
        txtWage.Text = Format(Emp1.Wage, "Currency")
    End Sub

    
   
End Class
