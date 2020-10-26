Module Module1
    Dim Temp As Integer
    Dim N(3) As Integer
    Dim Count As Integer
    Dim Swap As Boolean
    Sub Main()
        Console.WriteLine("Enter A Number")
        N(1) = Console.ReadLine
        Console.WriteLine()
        Console.WriteLine("Enter Your Second Number")
        N(2) = Console.ReadLine
        Console.WriteLine()
        Console.WriteLine("Enter Your Third Number")
        N(3) = Console.ReadLine
        Console.WriteLine()

        Count = 3
        Do
            Swap = False
            For C = 1 To Count - 1
                If N(C) > N(C + 1) Then
                    Swap = True
                    Temp = N(C)
                    N(C) = N(C + 1)
                    N(C + 1) = Temp
                End If
            Next C
            Count = Count - 1
        Loop Until (Not (Swap) Or (Count = 1))

        For C = 1 To 3
            Console.WriteLine(N(C) & " ")
        Next
        Console.ReadLine()
    End Sub

End Module
