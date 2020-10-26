Public Class frmStock
    Dim Product As ProductRec
    Dim Stock() As ProductRec
    Dim NoRecords As Integer = 0
    Dim P As Integer
    Private Sub btnMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMake.Click
        Dim FS As New System.IO.FileStream("Q:\StockFile.bin", IO.FileMode.Create, IO.FileAccess.Write)
        Dim BW As New System.IO.BinaryWriter(FS)
        Product.ItemID = 6984
        Product.Description = "Karlstad 2-Seat Sofa"
        Product.NoInStock = 6
        Product.RetailPrice = 120.0
        Product.ReOrderLevel = 4
        Product.InUse = True
        SaveRecord(BW, Product)
        Product.ItemID = 2367
        Product.Description = "Lumbar Cushions"
        Product.NoInStock = 78
        Product.RetailPrice = 15.45
        Product.ReOrderLevel = 40
        Product.InUse = True
        SaveRecord(BW, Product)
        Product.ItemID = 2698
        Product.Description = "Norrsten Dining Table"
        Product.NoInStock = 47
        Product.RetailPrice = 299.93
        Product.ReOrderLevel = 35
        Product.InUse = False
        SaveRecord(BW, Product)
        Product.ItemID = 4347
        Product.Description = "Grundton Reading Lamp"
        Product.NoInStock = 15
        Product.RetailPrice = 12.95
        Product.ReOrderLevel = 8
        Product.InUse = True
        SaveRecord(BW, Product)
        Product.ItemID = 8567
        Product.Description = "Aneboda Double Bed"
        Product.NoInStock = 27
        Product.RetailPrice = 139.99
        Product.ReOrderLevel = 10
        Product.InUse = True
        SaveRecord(BW, Product)
        Product.ItemID = 7233
        Product.Description = "Mysa Ronn Single Quilt"
        Product.NoInStock = 35
        Product.RetailPrice = 24.99
        Product.ReOrderLevel = 21
        Product.InUse = True
        SaveRecord(BW, Product)
        BW.Close()
        FS.Close()
    End Sub

    Private Sub btnReadRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadRec.Click
        Dim FS As New System.IO.FileStream("Q:\StockFile.bin", IO.FileMode.Open, IO.FileAccess.Read)
        Dim BR As New System.IO.BinaryReader(FS)
        NoRecords = 0
        Do While FS.Position < FS.Length
            NoRecords = NoRecords + 1
            ReadRecord(BR, Product)
            ReDim Preserve Stock(NoRecords)
            Stock(NoRecords) = Product
        Loop
        P = 1
        DisplayRecord(P)
        BR.Close()
        FS.Close()
    End Sub

    Sub DisplayRecord(ByVal Pos As Integer)
        txtItemID.Text = Stock(Pos).ItemID
        txtDescription.Text = Stock(Pos).Description
        txtNoInStock.Text = Stock(Pos).NoInStock
        txtRetail.Text = Stock(Pos).RetailPrice
        txtReOrder.Text = Stock(Pos).ReOrderLevel
        If Stock(Pos).InUse Then
            radInUse.Checked = True
            radDelete.Checked = False
        Else
            radInUse.Checked = False
            radDelete.Checked = True
        End If
    End Sub
 
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        P = P + 1
        If P = NoRecords + 1 Then P = 1
        DisplayRecord(P)
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        P = P - 1
        If P = 0 Then P = NoRecords
        DisplayRecord(P)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        NoRecords = NoRecords + 1
        ReDim Preserve Stock(NoRecords)
        Stock(NoRecords).ItemID = InputBox("Enter New Item ID", "Stock")
        Stock(NoRecords).Description = InputBox("Enter New Description", "Stock")
        Stock(NoRecords).NoInStock = InputBox("Enter New Number in Stock", "Stock")
        Stock(NoRecords).RetailPrice = InputBox("Enter New Retail Price", "Stock")
        Stock(NoRecords).ReOrderLevel = InputBox("Enter New Re-Order Level", "Stock")
        Stock(NoRecords).InUse = True
    End Sub

    Private Sub btnAmend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmend.Click
        Stock(P).ItemID = txtItemID.Text
        Stock(P).Description = txtDescription.Text
        Stock(P).NoInStock = txtNoInStock.Text
        Stock(P).RetailPrice = txtRetail.Text
        Stock(P).ReOrderLevel = txtReOrder.Text
        Stock(P).InUse = radInUse.Checked
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim FS As New System.IO.FileStream("Q:\StockFile.bin", IO.FileMode.Create, IO.FileAccess.Write)
        Dim BS As New System.IO.BinaryWriter(FS)
        For C = 1 To NoRecords
            If Stock(C).InUse Then
                SaveRecord(BS, Stock(C))
            End If
        Next
        BS.Close()
        FS.Close()
    End Sub
End Class
