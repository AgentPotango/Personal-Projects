Module Module1
    Dim N(25) As Integer
    Dim L As String
    Sub Main()
        For C = 0 To 25
            Console.WriteLine((Chr(65 + C)) & " = " & Asc(Chr(65 + C)))
            Console.ReadLine()
        Next C
        Console.ReadLine()
    End Sub

End Module
