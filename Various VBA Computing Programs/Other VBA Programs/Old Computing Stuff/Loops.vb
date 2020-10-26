Public Class Form1
    Dim Display As String
    Dim Total As Integer

    Private Sub btnAnyTimesTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnyTimesTable.Click
        Dim Timetable As Integer
        Dim Ans As Integer
        Display = "Multiplication Table" & vbNewLine
        Timetable = InputBox("Choose Your Time Tables")
        For C = 1 To 10
            Ans = Timetable * C
            Display = Display & C & " x " & Timetable & " = " & Ans & vbNewLine
        Next C
        lblOutput.Text = Display
    End Sub

    Private Sub Alphabet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alphabet.Click
        Dim Letter As String
        Display = "The Alphabet" & vbNewLine
        For C = 0 To 25
            Letter = Chr(65 + C)
            Display = Display & Letter & "   "
        Next C
        lblOutput.Text = Display
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Ans As Integer
        Dim A As Integer
        Dim B As Integer
        A = InputBox("Enter Your First Number Here", "Adding the numbers between Chosen Numbers", 0)
        B = InputBox("Enter Your Second Number Here", "Adding the numbers between Chosen Numbers", 0)
        Display = " The Sum of Numbers between " & A & " And " & B & " is equal to " & vbNewLine
        Ans = 0
        For C = A To B
            Ans = Ans + C
            Display = Display & C & "  -  " & Ans & vbNewLine
        Next C
        lblOutput.Text = Display
    End Sub
    Private Sub btnAsciicodes_Click(ByVal sender As System.Object,
  ByVal e As System.EventArgs) Handles btnAsciicodes.Click
        Dim Code As Long
        Display = "ASCII Codes" & vbNewLine
        For Code = Asc("A") To Asc("L")
            Display = Display & Code & " - " & Chr(Code) & vbNewLine
        Next Code
        lblOutput.Text = Display
    End Sub

    Private Sub btnnumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnumber.Click
        Dim N As Integer
        Dim MaxN As Integer
        Dim MinN As Integer
        Display = "" & vbNewLine
        Total = 0
        For C = 1 To 5
            N = InputBox("Enter A Number")
            If C = 1 Then
                MaxN = N
                MinN = N
            Else    If N > MaxN Then MaxN = N
                Else    If N < MinN Then MinN = N
        Next


        End If
        End If

    End Sub
End Class

