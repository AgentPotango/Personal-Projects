Module Module1
    Dim AmtUK As Single
    Dim AmtEuro As Single
    Dim MenuOpt As Integer
    Dim exrate As Single = 1.08

    Sub Main()
        Do
            Do
                menu(menuOpt)
            Loop Until MenuOpt = 9 Or MenuOpt = 1 Or MenuOpt = 2
            If MenuOpt = 1 Then
                Console.Write("Enter Amount in £: ")
                AmtUK = Console.ReadLine()
                AmtEuro = AmtUK * exrate
                Console.WriteLine("Amount in Euros: " & FormatNumber(AmtEuro, 2))
            End If
            Console.WriteLine("Press <Enter> to Continue")
            Console.ReadLine()
        Loop Until MenuOpt = 9
    End Sub

    Private Sub menu(ByRef opt As Integer)
        Console.Clear()
        Console.WriteLine("Currency Exchange")
        Console.WriteLine("___________________")
        Console.WriteLine()
        Console.WriteLine("1. Change Pounds to Euros")
        Console.WriteLine("2. Change Euros to Pounds")
        Console.WriteLine("9. Quit")
        Console.Write("Enter Options: ")
        opt = Console.ReadLine
    End Sub

End Module
