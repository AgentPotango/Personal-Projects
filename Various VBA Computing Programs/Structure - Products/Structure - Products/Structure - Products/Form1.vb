Public Class Form1
    Structure ProductRec
        Dim ProductNo As String
        Dim ProductName As String
        Dim StockNo As Integer
        Dim Price As Single
        Dim ReOrder As Integer
    End Structure
    Dim C As Integer
    Dim Prod(5) As ProductRec
    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        Dim NewProd As ProductRec
        NewProd.ProductNo = "156"
        NewProd.ProductName = "Ipod"
        NewProd.StockNo = 105
        NewProd.Price = 115.99
        NewProd.ReOrder = 20
        Prod(1) = NewProd

        NewProd.ProductNo = "999"
        NewProd.ProductName = "Police Car"
        NewProd.StockNo = 18
        NewProd.Price = 4999.99
        NewProd.ReOrder = 2
        Prod(2) = NewProd

        NewProd.ProductNo = "911"
        NewProd.ProductName = "American Police Car"
        NewProd.StockNo = 5
        NewProd.Price = 5999.99
        NewProd.ReOrder = 1
        Prod(3) = NewProd

        NewProd.ProductNo = "118"
        NewProd.ProductName = "Telephone"
        NewProd.StockNo = 27
        NewProd.Price = 15.99
        NewProd.ReOrder = 30
        Prod(4) = NewProd

        NewProd.ProductNo = "0800"
        NewProd.ProductName = "Expensive Telephone"
        NewProd.StockNo = 15
        NewProd.Price = 63.99
        NewProd.ReOrder = 40
        Prod(5) = NewProd
        C = 1
        Call DisplayProduct(1)
    End Sub

    Private Sub DisplayProduct(ByVal N As Integer)
        lblProductNo.Text = Prod(N).ProductNo
        lblProduct.Text = Prod(N).ProductName
        lblStockNo.Text = Prod(N).StockNo
        lblPrice.Text = Format(Prod(N).Price, "Currency")
        lblReorder.Text = Prod(N).ReOrder

    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Call DisplayProduct(C)
        C = C + 1
        If C > 5 Then C = 1
        Call DisplayProduct(C)
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        C = C - 1
        If C <= 0 Then C = 5
        Call DisplayProduct(C)
    End Sub

    Private Sub btnAmend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmend.Click

        Prod(C).ProductNo = InputBox("Enter New Product Number", "Product Amend")
        Prod(C).ProductName = InputBox("Enter New Product Name", "Product Amend")
        Prod(C).StockNo = InputBox("Enter New Product Stock Number", "Product Amend")
        Prod(C).Price = InputBox("Enter New Product Price", "Product Amend")
        Prod(C).ReOrder = InputBox("Enter New Product Re-Order Level", "Product Amend")

        Call DisplayProduct(C)
    End Sub


    Private Sub btnReorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReorder.Click
        For D = 1 To 5
            If Prod(D).StockNo < Prod(D).ReOrder Then
                lblReOrderList.Text = lblReOrderList.Text & vbNewLine & Prod(D).ProductNo & _
                    "  " & Prod(D).ProductName
            End If
        Next D
    End Sub
End Class
