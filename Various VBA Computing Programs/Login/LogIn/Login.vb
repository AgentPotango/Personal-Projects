Public Class frmLogin
    Dim L As String
    Dim Password As String
    Dim PWLen As Integer
    Dim PWC(4) As Integer
    Dim NewPWC As Integer
    Dim NewFound As Boolean
    Dim Temp As Integer
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For C = 1 To 26
            L = Chr(64 + C)
            P1.Items.Add(L)
            P2.Items.Add(L)
            P3.Items.Add(L)
            P4.Items.Add(L)
        Next C
        Password = "STMARYSCOLLEGE"
        Randomize()

        PWLen = Len(Password)
        For C = 1 To 4
            PWC(C) = 0
        Next

        For C = 1 To 4
            Do
                NewFound = True
                NewPWC = Int(Rnd() * PWLen) + 1
                For D = 1 To 4
                    If NewPWC = PWC(D) Then NewFound = False
                Next
            Loop Until NewFound
            PWC(C) = NewPWC
        Next C

        For C = 1 To 3
            For D = 1 To 3
                If PWC(D) > PWC(D + 1) Then
                    Temp = PWC(D)
                    PWC(D) = PWC(D + 1)
                    PWC(D + 1) = Temp
                End If
            Next D
        Next C


        Label1.Text = "Letter " & PWC(1)
        Label2.Text = "Letter " & PWC(2)
        Label3.Text = "Letter " & PWC(3)
        Label4.Text = "Letter " & PWC(4)

    End Sub



    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If P1.SelectedItem = Password((PWC(1) - 1)) And P2.SelectedItem = Password((PWC(2) - 1)) And P3.SelectedItem = Password((PWC(3) - 1)) And P4.SelectedItem = Password((PWC(4) - 1)) Then
            frmWelcome.Show()
        Else
            MsgBox("You Have Entered an Incorrect Password")
            Me.Close()
        End If

    End Sub
End Class
