Public Class Form1
    Dim ForeName As String
    Dim Surname As String
    Dim D As Integer
    Dim NoStudents As Integer
    


    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        NoStudents = InputBox("Enter the Amount of Names You Wish Too Add", "Student Names")
        FileOpen(1, "Q:\StudentNames.txt", OpenMode.Output)
        D = 0
        Do
            ForeName = InputBox("Enter Forename of Student", "Students")
            PrintLine(1, Encrypt(ForeName))
            Surname = InputBox("Enter Surname of Student", "Students")
            PrintLine(1, Encrypt(Surname))
            D = D + 1
        Loop Until D = NoStudents
        FileClose(1)
    End Sub
    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
        FileOpen(2, "Q:\StudentNames.txt", OpenMode.Input)
        lblDisplay.Text = "Student Names" & vbNewLine
        Do Until EOF(2)
            ForeName = LineInput(2)
            lblDisplay.Text = lblDisplay.Text & ForeName & vbNewLine
        Loop
        Do Until EOF(2)
            Surname = LineInput(2)
            lblDisplay.Text = lblDisplay.Text & ForeName & vbNewLine
        Loop
        FileClose(2)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FileIO.FileSystem.FileExists("Q:\StudentNames.txt") Then
            FileIO.FileSystem.DeleteFile("Q:\StudentNames.txt")
        Else
            MsgBox("File does not exist")
        End If

    End Sub

    Private Function Encrypt(ByVal S As String) As String
        Dim L As Integer
        L = Len(S)
        Encrypt = ""
        L = L - 1
        For C = L To 0 Step -1
            Encrypt = Encrypt & S(C)
        Next C
    End Function


    Private Function UnEncrypt(ByVal S As String) As String
        Dim L As Integer
        UnEncrypt = ""
        L = Len(S)
        L = 0
        For C = L To 0 Step 0
            UnEncrypt = UnEncrypt & S(C)
        Next C
    End Function
End Class






