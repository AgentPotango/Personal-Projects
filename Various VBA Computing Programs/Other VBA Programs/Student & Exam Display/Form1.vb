Public Class Form1
    Dim Title As String
    Dim Prompt1 As String
    Dim Prompt2 As String
    Dim Student(5) As String
    Dim ExamMark(5) As Integer
    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Title = "Input Names and Marks"
        Prompt1 = "Enter the Name of the Student "
        Prompt2 = " Enter the Mark of the Student "
        For C = 1 To 5
            Student(C) = InputBox(Prompt1 & C, Title)
            ExamMark(C) = InputBox(Prompt2 & C, Title)
        Next C
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim Display As String
        Dim Total As Integer, Max As Integer, Min As Integer
        Dim MaxIndex As Integer, MinIndex As Integer
        Dim Average As Single

        Total = ExamMark(1)
        Max = ExamMark(1)
        Min = ExamMark(1)
        MaxIndex = 1
        MinIndex = 1

        For C = 2 To 5
            Total = Total + ExamMark(C)
            If Max < ExamMark(C) Then
                Max = ExamMark(C)
                MaxIndex = C
            End If
            If Min > ExamMark(C) Then
                Min = ExamMark(C)
                MinIndex = C
            End If
        Next C

        Average = Total / 5

        Display = "Grade Analysis" & vbNewLine
        Display = Display & "Average = " & Average & vbNewLine
        Display = Display & "Min = " & Min & vbNewLine
        Display = Display & "Name is " & Student(MinIndex) & vbNewLine
        Display = Display & "Max = " & Max & vbNewLine
        Display = Display & "Name is " & Student(MaxIndex) & vbNewLine
        lblDisplay.Text = Display
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Student(1) = "Shuaib Hamid"
        ExamMark(1) = 89
        Student(2) = "Kashif Hussain"
        ExamMark(2) = 92
        Student(3) = "Hasan Hayat"
        ExamMark(3) = 78
        Student(4) = "David Wotherspoon"
        ExamMark(4) = 96
        Student(5) = "Ahmed Rijab"
        ExamMark(5) = 32
    End Sub
End Class
