Public Class Form1
    Dim OrderNo As String
    Dim NoOfBags As Integer
    Dim Cost As Single

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OrderNo = InputBox("Enter Order Number", "Cement Purchase", 0)
        NoOfBags = InputBox("Enter Amount of Cement Bags Bought", "Cement Purchase", 0)
        Cost = NoOfBags * 2.45
        lblInvoice.Text = "Order Number = " & OrderNo & vbNewLine & _
                          "Number of Bags = " & Format(NoOfBags, "#0") & vbNewLine & _
                          "Price of Bags = " & Format(Cost, "£0.00")

    End Sub
End Class
