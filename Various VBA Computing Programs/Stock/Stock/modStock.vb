Module modStock
    Structure ProductRec
        Dim ItemID As Integer
        Dim Description As String
        Dim NoInStock As Integer
        Dim RetailPrice As Single
        Dim ReOrderLevel As Integer
        Dim InUse As Boolean
    End Structure
    Sub SaveRecord(ByVal Writer As System.IO.BinaryWriter, ByVal StockItem As ProductRec)
        Writer.Write(StockItem.ItemID)
        Writer.Write(StockItem.Description)
        Writer.Write(StockItem.NoInStock)
        Writer.Write(StockItem.RetailPrice)
        Writer.Write(StockItem.ReOrderLevel)
        Writer.Write(StockItem.InUse)
    End Sub
    Sub ReadRecord(ByVal Reader As System.IO.BinaryReader, ByRef StockItem As ProductRec)
        StockItem.ItemID = Reader.ReadInt32
        StockItem.Description = Reader.ReadString
        StockItem.NoInStock = Reader.ReadInt32
        StockItem.RetailPrice = Reader.ReadSingle
        StockItem.ReOrderLevel = Reader.ReadInt32
        StockItem.InUse = Reader.ReadBoolean
    End Sub
End Module
