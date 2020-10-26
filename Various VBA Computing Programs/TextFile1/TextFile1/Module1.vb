Module Module1
    Dim MenuOpt As Integer
    Dim Ans As String
    Dim Forename As String
    Dim Surname As String
    Dim Mobile As String
    Dim Address As String
    Sub Main()
        Do
            Call Menu(MenuOpt)
            Select Case MenuOpt
                Case 1
                    Call CreateStudentFile()
                Case 2
                    Call ReadStudentFile()
                Case 3
                    Call AppendStudent()
                Case 4
                    Call DeleteStudent()
                Case 5
                    FileCopy("D:\Students.txt", "F:\Students.bak")
                Case 6
                    Call SearchStudent()
            End Select
        Loop Until MenuOpt = 9

    End Sub
    Private Sub Menu(ByRef Opt As Integer)
        Console.Clear()
        Console.WriteLine("Student File Menu")
        Console.WriteLine("1. Create New Student File")
        Console.WriteLine("2. Read Student File")
        Console.WriteLine("3. Add Student")
        Console.WriteLine("4. Delete File")
        Console.WriteLine("5. Make Backup")
        Console.WriteLine("6. Search For Student")
        Console.WriteLine()
        Console.WriteLine("9. Quit")
        Do
            Opt = Console.ReadLine
        Loop Until (Opt = 1 Or Opt = 2 Or Opt = 3 Or Opt = 4 Or Opt = 5 Or Opt = 6 Or Opt = 9)
    End Sub
    Private Sub CreateStudentFile()
        FileOpen(1, "D:\Students.txt", OpenMode.Output)
        Do
            Console.WriteLine("Do you wish to add a Student? (Y/N)")
            Ans = UCase(Console.ReadLine())
            If Ans = "Y" Then
                Console.WriteLine("Enter Student Forename")
                Forename = Console.ReadLine()
                PrintLine(1, Forename)
                Console.WriteLine()
                Console.WriteLine("Enter Student Surname")
                Surname = Console.ReadLine()
                PrintLine(1, Surname)
                Console.WriteLine()
                Console.WriteLine("Enter Student Mobile Number")
                Mobile = Console.ReadLine
                PrintLine(1, Mobile)
                Console.WriteLine()
                Console.WriteLine("Enter Student Address")
                Address = Console.ReadLine
                PrintLine(1, Address)
                Console.WriteLine()
            End If
        Loop Until Ans = "N"
        FileClose(1)
    End Sub

    Private Sub ReadStudentFile()
        FileOpen(2, "D:\Students.txt", OpenMode.Input)
        Console.Clear()
        Console.WriteLine("Student Details")
        Do Until EOF(2)
            Forename = LineInput(2)
            Console.WriteLine("Forename: " & Forename)
            Surname = LineInput(2)
            Console.WriteLine("Surname: " & Surname)
            Mobile = LineInput(2)
            Console.WriteLine("Mobile: " & Mobile)
            Address = LineInput(2)
            Console.WriteLine("Address: " & Address)
        Loop
        Console.WriteLine()
        Console.WriteLine("Press <Enter> to Continue")
        Ans = Console.ReadLine()
    End Sub

    Private Sub AppendStudent()
        FileOpen(3, "D:\Students.txt", OpenMode.Append)
        Do
            Console.WriteLine("Do you wish to add a Student? (Y/N)")
            Ans = UCase(Console.ReadLine())
            If Ans = "Y" Then
                Console.WriteLine()
                Console.WriteLine("Enter Student Forename")
                Forename = Console.ReadLine()
                PrintLine(3, Forename)
                Console.WriteLine()
                Console.WriteLine("Enter Student Surname")
                Surname = Console.ReadLine()
                PrintLine(3, Surname)
                Console.WriteLine()
                Console.WriteLine("Enter Student Mobile Number")
                Mobile = Console.ReadLine
                PrintLine(3, Mobile)
                Console.WriteLine()
                Console.WriteLine("Enter Student Address")
                Address = Console.ReadLine
                PrintLine(3, Address)
            End If
        Loop Until Ans = "N"
        FileClose(3)
    End Sub

    Private Sub DeleteStudent()
        Console.WriteLine("Do you want to delete the Student File? (Y/N)")
        Ans = Console.ReadLine()
        If UCase(Ans) = "Y" Then
            Kill("D:\Students.txt")
            Console.WriteLine("File Deleted")
        End If
    End Sub

    Private Sub SearchStudent()
        Dim SForename As String
        Dim SSurname As String
        Dim Found As Boolean
        FileOpen(4, "D:\Students.txt", OpenMode.Input)
        Console.WriteLine("Enter Student Forename")
        SForename = Console.ReadLine()
        Console.WriteLine("Enter Student Surname")
        SSurname = Console.ReadLine()
        Found = False
        Do Until EOF(4)
            Forename = LineInput(4)
            Surname = LineInput(4)
            Mobile = LineInput(4)
            Address = LineInput(4)
            If SForename = Forename And SSurname = Surname Then
                Found = True
                Console.WriteLine("Student Has Been Found!")
                Console.WriteLine("Forename: " & Forename)
                Console.WriteLine("Surname: " & Surname)
                Console.WriteLine("Mobile: " & Mobile)
                Console.WriteLine("Address: " & Address)
            End If
        Loop
        If Not Found Then
            Console.WriteLine("Student Has Not Been Found")
        End If

    End Sub
End Module
