Module Module1

    Sub Main()
        Dim X As String
        Dim Y As String
        Dim LX As Integer 'Length of String X
        Dim LY As Integer ' Length of String Y
        Dim T As Integer 'Amount of times Word would fit into sentence
        Dim F As Boolean 'If Word is Found or Not
        Console.WriteLine("Enter A Sentence")
        X = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("Enter A String")
        Y = Console.ReadLine()

        LX = Len(X)
        LY = Len(Y)

        T = LX - LY + 1
        ' T is the ammount of times String Y can go into String X ie. if String X was 10 characters and String Y was 3
        ' then, starting from position 1, you would take 3 characters. There are 7 other ways of doing this.
        ' therefore, the length of LX - LY + 1 says Y can fit into X 8 times
        F = False
        For C = 1 To T
            If Y = Mid(X, C, LY) Then
                F = True
            Else
                MsgBox(Mid(X, C, LY))
                ' The above else is to show what the mid picks up if the if statement is not true

            End If
        Next

        If F = True Then
            MsgBox("In String")
        Else
            MsgBox("Not in String")
        End If

    End Sub

End Module
