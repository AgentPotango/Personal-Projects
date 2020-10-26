Public Class Form1
    Dim L(0 To 15) As Integer 'Left Pointer
    Dim R(0 To 15) As Integer 'Right Pointer
    Dim D(0 To 15) As String  'Tree Data
    Dim P As Integer
    Dim FindString As String
    Private Sub TreeSetup()
        L(1) = 2
        L(2) = 4
        L(3) = 5
        L(4) = 6
        L(5) = 0
        L(6) = 9
        L(7) = 11
        L(8) = 12
        L(9) = 0
        L(10) = 0
        L(11) = 0
        L(12) = 0
        L(13) = 0
        L(14) = 0
        L(15) = 0
        R(1) = 3
        R(2) = 0
        R(3) = 0
        R(4) = 7
        R(5) = 8
        R(6) = 10
        R(7) = 0
        R(8) = 13
        R(9) = 0
        R(10) = 0
        R(11) = 14
        R(12) = 0
        R(13) = 15
        R(14) = 0
        R(15) = 0
        D(1) = "Manchester United"
        D(2) = "Manchester City"
        D(3) = "Tottenham Hotspur"
        D(4) = "Chelsea"
        D(5) = "Newcastle"
        D(6) = "Aston Villa"
        D(7) = "Liverpool"
        D(8) = "Stoke City"
        D(9) = "Arsenal"
        D(10) = "Blackburn Rovers"
        D(11) = "Everton"
        D(12) = "Norwich City"
        D(13) = "Sunderland"
        D(14) = "Fulham"
        D(15) = "West Bromwich Albion"
      

    End Sub
    Private Sub InOrder(ByRef P As Integer)
        REM Traverse In Order
        If L(P) <> 0 Then InOrder(L(P))
        Output.Text = Output.Text & vbNewLine & D(P)
        If R(P) <> 0 Then InOrder(R(P))
    End Sub
    Private Sub PreOrder(ByRef P As Integer)
        REM Traverse Pre-Order
        Output.Text = Output.Text & vbNewLine & D(P)
        If L(P) <> 0 Then PreOrder(L(P))
        If R(P) <> 0 Then PreOrder(R(P))
        REM ADD CODE

    End Sub
    Private Sub PostOrder(ByRef P As Integer)
        REM Traverse Post Order
        If L(P) <> 0 Then PostOrder(L(P))
        If R(P) <> 0 Then PostOrder(L(P))
        Output.Text = Output.Text & vbNewLine & D(P)
        REM ADD CODE

    End Sub
    Private Sub TreeSearch(ByRef SearchString As String)
        Dim Found As Boolean = False
        P = 1
        Output.Text = "Finding - " & SearchString & vbNewLine & vbNewLine
        Do While (P <> 0 And D(P) <> SearchString)
            Output.Text = Output.Text & D(P) & vbNewLine
            If D(P) > SearchString Then
                P = L(P)
            Else
                P = R(P)
            End If
        Loop
        If P <> 0 Then
            Output.Text = Output.Text & vbNewLine & "Found - " & SearchString
        Else
            Output.Text = Output.Text & vbNewLine & "Not Found - " & SearchString
        End If
        REM ADD CODE FOR A TREE SEARCH

    End Sub
    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        Call TreeSetup()
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Output.Text = "Display Of Tree Structure" & vbNewLine
        For C = 1 To 15
            Output.Text = Output.Text & "D(" & C & ") = " & D(C) & _
                            "    L(" & C & ") = " & L(C) & _
                            "    R(" & C & ") = " & R(C) & vbNewLine
        Next
    End Sub

    Private Sub btnInOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInOrder.Click
        Output.Text = "Traverse In Order" & vbNewLine
        Call InOrder(1)
    End Sub

    Private Sub btnPreOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreOrder.Click
        Output.Text = "Traverse Pre-Order" & vbNewLine
        Call PreOrder(1)
    End Sub

    Private Sub btnPostOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPostOrder.Click
        Output.Text = "Traverse Post Order" & vbNewLine
        Call PostOrder(1)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FindString = InputBox("Enter the name to find", "Tree Search")
        Call TreeSearch(FindString)
    End Sub
End Class
