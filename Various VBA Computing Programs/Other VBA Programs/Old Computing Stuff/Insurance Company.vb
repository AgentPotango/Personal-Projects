Public Class Form1
    Dim Cost As Single

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        If txtgender.Text = "M" Then
            If txtage.Text < 20 Then
                Cost = 800
                lbloutput.Text = "Male Under 20 Insurance Cost - " & Format(Cost, "Currency")
            Else
                Cost = 450
                lbloutput.Text = "Male Older than 20 Insurance Cost - " & Format(Cost, "Currency")
            End If


            If txtgender.Text = "F" Then
                If txtage.Text < 20 Then
                    Cost = 750
                    lbloutput.Text = "Female Under 20 Insurance Cost - " & Format(Cost, "Currency")
                Else
                    Cost = 500
                    lbloutput.Text = "Female Older than 20 Insurance Cost - " & Format(Cost, "Currency")
                End If

            End If
        End If
    End Sub
End Class
