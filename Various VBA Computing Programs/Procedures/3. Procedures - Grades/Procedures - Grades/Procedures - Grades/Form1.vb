Public Class Form1
    Dim C1 As Integer
    Dim C2 As Integer
    Dim PerMark As Integer
    Dim Grade As String

    Private Sub CalculateGrade(ByVal COMP1 As Integer, ByVal COMP2 As Integer,
  ByRef PM As Integer, ByRef G As String)
        REM COMP1 maximum mark 100
        REM COMP2 maximum mark 60
        REM COMP1 is 60% and COMP2 is 40% of AS mark
        Dim sngPM As Single
        sngPM = (COMP1 / 100) * 60 + (COMP2 / 60) * 40
        PM = Int(sngPM)
        Select Case PM
            Case Is >= 80
                G = "A"
            Case Is >= 70
                G = "B"
            Case Is >= 60
                G = "C"
            Case Is >= 50
                G = "D"
            Case Is >= 40
                G = "E"
            Case Else
                G = "U"
        End Select
    End Sub


    Private Sub btnGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrade.Click
        PerMark = 0
        Grade = ""

        If Len(txtComp1.Text) = 0 Or Len(txtComp2.Text) = 0 Then
            MsgBox("Error 1 - No Marks Entered")
        ElseIf Not (IsNumeric(txtComp1.Text) And IsNumeric(txtComp2.Text)) Then
            MsgBox("Error 2 - Must Enter Numeric Characters")
        ElseIf Val(txtComp1.Text) < 0 Or (txtComp1.Text) > 100 Or _
               Val(txtComp2.Text) < 0 Or (txtComp2.Text) > 60 Then
            MsgBox("Error 3 - Marks Are Out of Allocated Range")
        Else
            C1 = Val(txtComp1.Text)
            C2 = Val(txtComp2.Text)
            Call CalculateGrade(C1, C2, PerMark, Grade)
            lblDisplay.Text = "Percentage is " & PerMark & vbNewLine
            lblDisplay.Text = lblDisplay.Text & "Grade is " & Grade
        End If
    End Sub

End Class
