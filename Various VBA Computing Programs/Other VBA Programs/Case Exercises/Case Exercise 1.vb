Public Class Form1
    Dim First As Integer
    Dim Second As Integer
    Dim Total As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPress.Click
        First = InputBox("Enter Your First Number", "Case Statements", 0)
        Second = InputBox("Enter Your Second Number", "Case Statements", 0)
        Total = First - Second
        Select Case Total
            Case Is = 0
                lblOutput.Text = "First and Second are Equal"
            Case Is > 0
                lblOutput.Text = "First is Bigger than the Second"
            Case Is < 0
                lblOutput.Text = "Second is Bigger than the First"
        End Select

    End Sub
End Class
