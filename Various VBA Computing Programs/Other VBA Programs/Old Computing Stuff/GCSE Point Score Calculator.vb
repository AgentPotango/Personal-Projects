Public Class Form1
    Dim Surname As String
    Dim Forename As String
    Dim NoOfGCSEs As Integer
    Dim Astargrade As Integer
    Dim Agrade As Integer
    Dim Bgrade As Integer
    Dim Cgrade As Integer
    Dim Dgrade As Integer
    Dim Egrade As Integer
    Dim Fgrade As Integer
    Dim Ggrade As Integer
    Dim ASlevels As String
    Dim Avgpointscore As Single


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalc.Click
        Surname = InputBox("Enter Your Surname", "GCSE Point Score Calculator", 0)
        Forename = InputBox("Enter Your Forename", "GCSE Point Score Calculator", 0)
        Astargrade = InputBox("Amount of A*'s", "GCSE Point Score Calculator", 0)
        Agrade = InputBox("Amount of A's", "GCSE Point Score Calculator", 0)
        Bgrade = InputBox("Amount of B's", "GCSE Point Score Calculator", 0)
        Cgrade = InputBox("Amount of C's", "GCSE Point Score Calculator", 0)
        Dgrade = InputBox("Amount of D's", "GCSE Point Score Calculator", 0)
        Egrade = InputBox("Amount of E's", "GCSE Point Score Calculator", 0)
        Fgrade = InputBox("Amount of F's", "GCSE Point Score Calculator", 0)
        Ggrade = InputBox("Amount of G's", "GCSE Point Score Calculator", 0)
        NoOfGCSEs = (Astargrade + Agrade + Bgrade + Cgrade + Dgrade + Egrade + Fgrade + Ggrade)
        Avgpointscore = (8 * Astargrade + 7 * Agrade + 6 * Bgrade + 5 * Cgrade + 4 * Dgrade + 3 * Egrade + 2 * Fgrade + 1 * Ggrade) / NoOfGCSEs
        ASlevels = InputBox(" Enter the A Levels Subjects You Are Taking", "GCSE Point Score Calculator", 0)
        lblinvoice.Text = "Student Details" & vbNewLine & _
                          "Surname: " & Surname & vbNewLine & _
                          "Forename: " & Forename & vbNewLine & _
                          "Number of GCSEs: " & Format(NoOfGCSEs, "#0") & vbNewLine & _
                          "Average GCSE Point Score: " & Avgpointscore & vbNewLine & _
                          "AS Subjects: " & ASlevels


    End Sub
End Class
