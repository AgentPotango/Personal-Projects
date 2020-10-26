Public Class frmRecursion

    Private Sub btnRecursion1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecursion1.Click
        Dim Start As Integer
        Start = InputBox("Enter a Start Value", "Recursion")
        Display.Text = "Calling PrintList(" & Start & ")" & vbNewLine
        Call PrintList(Start)
    End Sub
    Private Sub PrintList(ByVal N As Integer)
        If N > 1 Then
            Display.Text = Display.Text & "Calling PrintList(" & N - 1 & ")" & vbNewLine
            PrintList(N - 1)
        End If
        Display.Text = Display.Text & "N = " & N & vbNewLine
    End Sub

    Private Sub btnFactorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactorial.Click
        Dim PI As Integer
        Display.Text = "Factorials"
        PI = InputBox("Enter a positive integer", "Recursion")
        Display.Text = PI & "! = " & Factorial(PI)
    End Sub
    Private Function Factorial(ByVal I As Integer) As Integer
        If (I = 1) Or (I = 0) Then
            Factorial = 1
        Else
            Factorial = I * Factorial(I - 1)
        End If
    End Function

    Private Sub btnPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPower.Click
        Dim Nu As Integer
        Dim Po As Integer
        Display.Text = ""
        Nu = InputBox("Enter a positive number", "Recursion")
        Po = InputBox("Enter a positive or negative power", "Recursion")
        Display.Text = "Answer = " & Power(Nu, Po)
    End Sub

    Private Function Power(ByRef N As Single, ByVal P As Integer) As Single
        If P > 1 Then
            P = P - 1
            Power = N * Power(N, P)
        Else
            If P = 1 Then
                Power = N
            Else
                If P = 0 Then
                    Power = 1
                Else
                    P = P + 1
                    Power = Power(N, P) / N
                End If
            End If
        End If
    End Function

    Private Sub btnSimplePower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimplePower.Click
        Dim Nu As Integer
        Dim Po As Integer
        Display.Text = ""
        Nu = InputBox("Enter a positive number", "Recursion")
        Do
            Po = InputBox("Enter a positive power", "Recursion")
        Loop Until Po > 0
        Display.Text = "Answer = " & SimplePower(Nu, Po)
    End Sub
    Private Function SimplePower(ByRef N As Single, ByVal P As Integer) As Single
        If P > 1 Then
            SimplePower = N * SimplePower(N, P - 1)
        Else
            SimplePower = N
        End If
    End Function

    Private Sub btnBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBin.Click
        Dim ListSize As Integer
        Dim NoComparisons As Integer
        Display.Text = ""
        ListSize = InputBox("Enter a List Size", "Recursion")
        NoComparisons = Comparisons(ListSize)
        Display.Text = "List Size = " & ListSize & vbNewLine & "Comparsons = " & NoComparisons
    End Sub

    Private Function Comparisons(ByVal N As Integer) As Integer
        If N = 1 Then
            Comparisons = 1
        Else
            N = N \ 2
            Comparisons = 1 + Comparisons(N)
        End If
    End Function

    Private Sub btnExample2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExample2.Click
        Dim Start As Integer
        Display.Text = ""
        Start = InputBox("Enter a Start", "Recursion")
        Increase(Start)
    End Sub
    Sub Increase(ByVal N As Integer)
        If N < 50 Then
            N = N + 10
            Call Increase(N)
        End If
        Display.Text = Display.Text & "N = " & N & vbNewLine
    End Sub

End Class
