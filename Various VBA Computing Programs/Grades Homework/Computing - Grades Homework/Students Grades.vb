Public Class Form1
    Dim Surname(10) As String
    Dim Forename(10) As String
    Dim Unit(10, 4) As Integer
    Dim Mark(10) As Integer
    Dim Grade(10) As String
    Dim Search As String
    Private Sub btnStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStore.Click

        'Storing Grade And Mark Arrays

        For C = 1 To 10
            Mark(C) = Unit(C, 1) * 0.3 + Unit(C, 2) * 0.2 + Unit(C, 3) * 0.3 + Unit(C, 4) * 0.2
            Select Case Mark(C)
                Case Is < 40
                    Grade(C) = "U"
                Case Is < 50
                    Grade(C) = "E"
                Case Is < 60
                    Grade(C) = "D"
                Case Is < 70
                    Grade(C) = "C"
                Case Is < 80
                    Grade(C) = "B"
                Case Else
                    Grade(C) = "A"
            End Select
        Next

    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        'Search Function By Student Name

        Search = InputBox("Enter Student Surname", "Search Student Grades", 0)

        For C = 1 To 10
            If Search = Surname(C) Then
                txtDisplay.Text = "Student: " & Forename(C) & " " & Surname(C) & vbNewLine & _
                                  "Final Mark: " & Mark(C) & vbNewLine & _
                                  "Grade: " & Grade(C)
            End If
        Next C

    End Sub

    Private Sub btnAllDispay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllDisplay.Click

        For C = 1 To 10
            txtDisplay.Text = vbNewLine & "Student: " & Forename(C) & " " & Surname(C) & vbNewLine & _
                                "Final Mark: " & Mark(C) & vbNewLine & _
                                "Grade: " & Grade(C) & vbNewLine & txtDisplay.Text
        Next C

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Surnames

        Surname(1) = "Aslam"
        Surname(2) = "Bradshaw"
        Surname(3) = "Haworth"
        Surname(4) = "Hodkinson"
        Surname(5) = "Holden"
        Surname(6) = "Hounslow"
        Surname(7) = "Logde"
        Surname(8) = "O'Sullivan"
        Surname(8) = "Patel"
        Surname(10) = "Pritchard"

        'Forenames

        Forename(1) = "Muhdassar"
        Forename(2) = "Matthew"
        Forename(3) = "Matthew"
        Forename(4) = "Benjamin"
        Forename(5) = "James"
        Forename(6) = "Dominic"
        Forename(7) = "Aasim"
        Forename(8) = "Jack"
        Forename(9) = "Lukman"
        Forename(10) = "Matthew"

        'Unit Marks

        Unit(1, 1) = 56
        Unit(1, 2) = 65
        Unit(1, 3) = 57
        Unit(1, 4) = 45
        Unit(2, 1) = 45
        Unit(2, 2) = 89
        Unit(2, 3) = 89
        Unit(2, 4) = 67
        Unit(3, 1) = 78
        Unit(3, 2) = 67
        Unit(3, 3) = 98
        Unit(3, 4) = 87
        Unit(4, 1) = 89
        Unit(4, 2) = 75
        Unit(4, 3) = 78
        Unit(4, 4) = 89
        Unit(5, 1) = 93
        Unit(5, 2) = 54
        Unit(5, 3) = 84
        Unit(5, 4) = 67
        Unit(6, 1) = 78
        Unit(6, 2) = 39
        Unit(6, 3) = 80
        Unit(6, 4) = 45
        Unit(7, 1) = 76
        Unit(7, 2) = 67
        Unit(7, 3) = 67
        Unit(7, 4) = 78
        Unit(8, 1) = 69
        Unit(8, 2) = 70
        Unit(8, 3) = 45
        Unit(8, 4) = 87
        Unit(9, 1) = 94
        Unit(9, 2) = 77
        Unit(9, 3) = 67
        Unit(9, 4) = 56
        Unit(10, 1) = 49
        Unit(10, 2) = 64
        Unit(10, 3) = 59
        Unit(10, 4) = 78


    End Sub

End Class
