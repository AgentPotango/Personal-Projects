Public Class Form1
    Dim RandNos(0 To 100) As Integer
    Dim Message1 As String
    Dim Message2 As String
    Dim SV As Integer 'Search Value
    Dim Pos As Integer 'Position of the Found Item
    Dim Found As Boolean
    Dim C As Integer
    Dim Count As Integer

   Private Sub btnSetup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        Output.Text = "Array Setup Complete" & vbNewLine
        Randomize()
        'This subprogram randomly generates 100 numbers is the range 1 to 100.
        'The generated numbers are stored in the array RandNos.
        For P = 1 To 100
            RandNos(P) = Math.Round(Rnd() * 100, 0)
            Output.Text = Output.Text & RandNos(P) & " "
        Next P
        Message1 = "Enter the value you wish to find"
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object,
  ByVal e As System.EventArgs) Handles btnSearch.Click
        SV = 0
        Found = False
        Pos = 0
        C = 0
        Count = 0
        SV = InputBox(Message1, "Linear Search")
        Do
            C = C + 1
            If SV = RandNos(C) Then
                Pos = C
                Count = Count + 1
            End If
        Loop Until (C = 100)
        Message2 = SV & " Occurs " & Count & " Times"
        Output.Text = Message2
    End Sub

End Class

  