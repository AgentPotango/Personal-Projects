Public Class Form1
    Dim nextGo As String
    Dim Tile(9) As Label


    Private Sub T1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.Click
        For C = 1 To 9
            If Len(Tile(C)) = "" Then
                If nextGo = "O" Then
                    Tile(C).Text = "O"
                    nextGo = "X"
                Else
                    Tile(C).Text = "X"
                    nextGo = "O"
                End If
            End If
            If Winner("X") Then
                lblDisplay.Text = "X wins"
            End If
            If Winner("O") Then
                lblDisplay.Text = "O wins"
            End If
        Next C

    End Sub

    Private Function Winner(ByVal W As String) As Boolean
        If Tile(1).Text = Tile(4).Text And Tile(1).Text = Tile(7).Text And Tile(1).Text = W Or _
           Tile(2).Text = Tile(5).Text And Tile(2).Text = Tile(8).Text And Tile(2).Text = W Or _
           Tile(3).Text = Tile(6).Text And Tile(3).Text = Tile(9).Text And Tile(3).Text = W Then
            Winner = True
        Else
            Winner = False
        End If
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nextGo = "O"
        Tile(1) = T1
        Tile(2) = T2
        Tile(3) = T3
        Tile(4) = T11
        Tile(5) = T12
        Tile(6) = T13
        Tile(7) = T21
        Tile(8) = T22
        Tile(9) = T23
    End Sub

    Private Sub T2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T2.Click

    End Sub
End Class

