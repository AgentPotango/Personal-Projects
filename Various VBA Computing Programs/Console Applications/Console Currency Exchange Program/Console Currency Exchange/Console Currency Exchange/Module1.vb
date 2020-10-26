Module Module1
    Const Exchange = 1.08
    Dim Euro As Single
    Dim Pound As Single
    Dim Choice As String
    Dim Amount As Single

    Sub Main()
        Console.WriteLine("Exchange Currency")
        Console.WriteLine("=================")
        Console.WriteLine()
        Console.WriteLine("Type E if you want to exchange Pounds into Euros or type P if you want to" & vbNewLine & _
                           " exchange Euros into Pounds")
        Console.WriteLine()
        Console.Write("Choice: ")
        Choice = Console.ReadLine
        Console.WriteLine()
        If UCase(Choice) = "E" Then
            Console.Write("Enter the Amount of Pounds: ")
            Pound = Console.ReadLine()
            Console.WriteLine()
            Amount = Pound * Exchange
            Console.WriteLine("Amount of Euros obtained = " & Format(Amount, "#0.00"))
        Else
            Console.Write("Enter the Amount of Euros: ")
            Euro = Console.ReadLine()
            Console.WriteLine()
            Amount = Euro / Exchange
            Console.WriteLine("Amount of Pounds obtained = " & Format(Amount, "Currency"))
        End If
        Console.ReadLine()
    End Sub

End Module
