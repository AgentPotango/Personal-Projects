Public Class Form1
    Dim Handicap As Integer

    Private Sub BtnQ1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ1.Click
        Handicap = InputBox("Enter Your Handicap", "Golf")
        If Handicap < 13 Then
            lblOutput.Text = "You are a league 1 player."
        Else
            lblOutput.Text = "You are a league 2 player."
        End If

    End Sub
    Dim PayRate As Single
    Dim HoursWorked As Single
    Dim Age As Integer
    Dim Pay As Integer
    Private Sub btnQ2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ2.Click
        Age = InputBox("Enter Your Age", "Shop Worker")
        HoursWorked = InputBox("Enter the Amount of Hours You have Worked", "Shop Worker")
        If Age < 18 Then
            PayRate = 4.85
        Else
            PayRate = 6.35
        End If
        Pay = Age * HoursWorked
        lblOutput.Text = "Age: " & Age & vbNewLine & _
                        "Pay Rate: " & Format(PayRate, "Currency") & vbNewLine & _
                        "HoursWorked: " & HoursWorked & vbNewLine & _
                        "Pay: " & Format(Pay, "Currency")

    End Sub
    Dim Maths As Integer
    Dim Physics As Integer
    Dim English As Integer
    Dim Total As Integer
    Private Sub btnQ3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ3.Click
        Maths = InputBox("Enter Math Mark", "Mathematics")
        English = InputBox("Enter English Mark", "English")
        Physics = InputBox("Enter Physics Mark", "Physics")
        Total = Maths + English + Physics
        If Total > 160 Then
            lblOutput.Text = "Total: " & Total & vbNewLine & _
                             "You have Passed!"
        Else
            lblOutput.Text = "Total: " & Total & vbNewLine & _
                            "You Have Failed!"
        End If
    End Sub
    Dim Number As Single
    Private Sub btnQ4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ4.Click
        Number = InputBox("Enter Your Number", "Numbers", 0)
        If Number = 0 Then
            lblOutput.Text = "Your Number is Zero"
        Else
            If Number > 0 Then
                lblOutput.Text = "Your Number is Positive"
            Else
                If Number < 0 Then
                    lblOutput.Text = "Your Number is Negative"
                End If
            End If
        End If
    End Sub
End Class




