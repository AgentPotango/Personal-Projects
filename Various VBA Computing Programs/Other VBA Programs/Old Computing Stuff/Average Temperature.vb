Public Class Form1
    Dim Display As String
    Dim Average As Single
    Dim Degrees(7) As Integer
    Dim Month As String
    Dim Output As String
    Dim ExpectedAverage As Single
    Dim Message As String
    Dim Change As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click
        Month = InputBox("Enter the Month Here", "Month")
        Display = "Average temperature result for " & Month & vbNewLine

        For C = 1 To 7
            Degrees(C) = InputBox("Enter the Current Temperature", "Degrees")
            Output = Output & Degrees(C) & " Degrees" & vbNewLine
        Next C


        Average = Format((Degrees(1) + Degrees(2) + Degrees(3) + Degrees(4) + Degrees(5) + Degrees(6) + Degrees(7)) / 7, "#0")

        If Month = "January" Then ExpectedAverage = 6
        Change = Average - ExpectedAverage
        If Average > ExpectedAverage Then
            Message = "Average Temperature is " & Change & " Degrees " & "Greater than Expected Average for" & Month

        ElseIf Average = ExpectedAverage Then
            Message = "Average Temperature is Equal to Expected Average for " & Month

        ElseIf Average < ExpectedAverage Then
            Message = "Average Temperature is " & Change & " Degrees " & "Less than Expected Average for" & Month

        End If

        If Month = "June" Then ExpectedAverage = 14
        Change = Average - ExpectedAverage
        If Average > ExpectedAverage Then
            Message = "Average Temperature is " & Change & " Degrees " & "Greater than Expected Average for" & Month

        ElseIf Average = ExpectedAverage Then
            Message = "Average Temperature is Equal to Expected Average for " & Month

        ElseIf Average < ExpectedAverage Then
            Message = "Average Temperature is " & Change & " Degrees " & "Less than Expected Average for" & Month

        End If


        Output = Output & Display & Average & " Degrees" & vbNewLine & _
                 "Analysis: " & Message & vbNewLine

        lbloutput.Text = Output

    End Sub
End Class
