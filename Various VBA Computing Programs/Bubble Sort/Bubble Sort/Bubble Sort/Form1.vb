Public Class Form1
    Dim Names(0 To 10) As String
    Dim C As Integer
    Dim N As Integer 'Number of Names
    Dim Temp As String
    Private Sub btnSetup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        N = 10
        Names(1) = "Fred"
        Names(2) = "Tameena"
        Names(3) = "Philp"
        Names(4) = "Ashley"
        Names(5) = "Imran"
        Names(6) = "Moaz"
        Names(7) = "Mohammed"
        Names(8) = "John"
        Names(9) = "Lauren"
        Names(10) = "Kevin"
        Display.Text = "Unsorted Names" & vbNewLine
        Display.Text = Display.Text & "==============" & vbNewLine
        For Me.C = 1 To 10
            Display.Text = Display.Text & Names(C) & vbNewLine
        Next C
    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        Dim Swap As Boolean

        'Perform the Bubble Sort
        Do
            Swap = False
            For Me.C = 1 To N - 1
                If Names(C) > Names(C + 1) Then
                    Swap = True
                    Temp = Names(C)
                    Names(C) = Names(C + 1)
                    Names(C + 1) = Temp
                End If
            Next C
            N = N - 1
        Loop Until (Not (Swap))

        'Displaying Sorted Names
        Display.Text = Display.Text & vbNewLine & "Sorted Names" & vbNewLine
        Display.Text = Display.Text & "============" & vbNewLine
        For Me.C = 1 To 10
            Display.Text = Display.Text & Names(C) & vbNewLine
        Next C
    End Sub


End Class
