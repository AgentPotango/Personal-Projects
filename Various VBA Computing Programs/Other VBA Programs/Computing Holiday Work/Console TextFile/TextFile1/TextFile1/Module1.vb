Module Module1
    Dim StudentName As String
    Dim MenuOpt As Integer
    Dim Ans As String
    Sub Main()
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
                FileCopy("F:\Students.txt", "F:\Students.bak")
        End Select
    End Sub
    Private Sub Menu(ByRef Opt As Integer)
        Console.Clear()
        Console.WriteLine("Student File Menu")
        Console.WriteLine("1. Create New Student File")
        Console.WriteLine("2. Read Student File")
        Console.WriteLine("3. Add Student")
        Console.WriteLine("4. Delete File")
        Console.WriteLine("5. Make Backup")
        Console.WriteLine()
        Console.WriteLine("9. Quit")
        Do
            Opt = Console.ReadLine
        Loop Until (Opt = 1 Or Opt = 2 Or Opt = 3 Or Opt = 4 Or Opt = 5 Or Opt = 9)
    End Sub

    Private Sub CreateStudentFile()
        FileOpen(1, "F:\Students.txt", OpenMode.Output)
        Do
            Console.WriteLine("Do you wish to add a Student? (Y/N)")
            Ans = UCase(Console.ReadLine())
            If Ans <> "N" Then
                Console.WriteLine("Enter Student Name")
                StudentName = Console.ReadLine()
                PrintLine(1, StudentName)
            End If
        Loop Until Ans = "N"
        FileClose(1)
    End Sub

    Private Sub ReadStudentFile()
        FileOpen(2, "F:\Students.txt", OpenMode.Input)
        Console.Clear()
        Console.WriteLine("Student Names")
        Do Until EOF(2)
            StudentName = LineInput(2)
            Console.WriteLine(StudentName)
        Loop
        Console.WriteLine()
        Console.WriteLine("Press <Enter> to Continue")
        Ans = Console.ReadLine()
    End Sub

    Private Sub AppendStudent()
        FileOpen(3, "F:\Students.txt", OpenMode.Append)
        Do
            Console.WriteLine("Do you wish to add a Student? (Y/N)")
            Ans = UCase(Console.ReadLine())
            If Ans <> "N" Then
                Console.WriteLine("Enter Student Name")
                StudentName = Console.ReadLine()
                PrintLine(3, StudentName)
            End If
        Loop Until Ans = "N"
        FileClose(3)
    End Sub

    Private Sub DeleteStudent()
        Console.WriteLine("Do you want to delete the Student File? (Y/N)")
        Ans = Console.ReadLine()
        If UCase(Ans) = "Y" Then
            Kill("F:\Students.txt")
            Console.WriteLine("File Deleted")
        End If
    End Sub
End Module
