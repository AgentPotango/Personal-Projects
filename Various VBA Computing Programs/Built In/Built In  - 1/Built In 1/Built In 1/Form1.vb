Public Class Form1
    Dim S As String
    Dim L As Integer
    Dim WordCount As Integer
    Dim VowelCount As Integer

    Private Sub btnVowels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVowels.Click
        S = InputBox("Enter Your Sentence Here", "VowelCounter")
        L = Len(S)
        VowelCount = 0
        WordCount = 1
        For C = 1 To L
            If Mid(UCase(S), C, 1) = "A" Or Mid(UCase(S), C, 1) = "E" Or Mid(UCase(S), C, 1) = "I" Or Mid(UCase(S), C, 1) = "O" Or Mid(UCase(S), C, 1) = "U" Then
                VowelCount = VowelCount + 1
            End If
            If Mid(S, C, 1) = " " Then
                WordCount = WordCount + 1
            End If
            lbldisplay.Text = "Sentence: " & S & vbNewLine & _
                              "Vowel Count: " & VowelCount & vbNewLine & _
                              "Word Count: " & WordCount
        Next
    End Sub

    Private Sub btnDateD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateD.Click
        Dim D1 As Date
        Dim D2 As Date
        Dim Days As Integer
        Dim Weeks As Single
        Dim Years As Single

        D1 = InputBox("Enter A Date", "Date Difference")
        D2 = InputBox("Enter A Date", "Date Difference")
        Years = DateDiff(DateInterval.Year, D1, D2)
        Weeks = DateDiff(DateInterval.Weekday, D1, D2)
        Days = DateDiff(DateInterval.Day, D1, D2)
        lbldisplay.Text = "Date 1: " & D1 & vbNewLine & _
                           "Date 2: " & D2 & vbNewLine & _
                           "Year Difference: " & Years & " Years" & vbNewLine & _
                           "Week Difference: " & Weeks & " Weeks" & vbNewLine & _
                           "Day Difference: " & Days & " Days"

    End Sub

    Private Sub StringLocator(ByVal String1 As String, ByVal String2 As String, ByRef StringLocator As String)
        StringLocator = Mid(UCase(String2), UCase(String1), Len(String2))
    End Sub

    Private Sub btnString_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnString.Click
        Dim String1 As String
        Dim String2 As String

        String1 = InputBox("Enter a Word", "String Locator")
        String2 = InputBox("Enter a Sentence", "String Locator")
        WordCount = 0
        L = Len(String2)
        WordCount = 0
        For C = 1 To L
            If Mid(UCase(String2), C, Len(String1)) = UCase(String1) Then
                WordCount = WordCount + 1
            End If
        Next
        lbldisplay.Text = "Sentence: " & String2 & vbNewLine & _
                          "Word: " & String1 & vbNewLine & _
                          "Word Count: " & WordCount
    End Sub
End Class
