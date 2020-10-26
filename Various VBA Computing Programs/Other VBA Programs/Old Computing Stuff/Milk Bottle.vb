Public Class Form1
    Dim Price As Single
    Dim Priceperpint As Single
    Dim MilkQuantity As Integer
    Dim OutputWholesale As String
    Dim OutputSainsbury As String
    Dim OutputMorrison As String
    Dim OutputBooths As String

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        MilkQuantity = InputBox("Enter The Amount of Milk Bottles", "Milk Purchase", 0)

        OutputWholesale = "Customer: "
        If cboCustomer.SelectedItem = "Wholesale" Then
            If MilkQuantity < 1000 Then
                Priceperpint = 0.13
                Price = Priceperpint * MilkQuantity
                OutputWholesale = OutputWholesale & "Wholesale" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            ElseIf MilkQuantity < 2000 Then
                Priceperpint = 0.11
                Price = Priceperpint * MilkQuantity
                OutputWholesale = OutputWholesale & "Wholesale" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            ElseIf MilkQuantity >= 2000 Then
                Priceperpint = 0.1
                Price = Priceperpint * MilkQuantity
                OutputWholesale = OutputWholesale & "Wholesale" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            End If
        End If

        OutputSainsbury = "Customer: "
        If cboCustomer.SelectedItem = "Sainsbury" Then
            If MilkQuantity < 1000 Then
                Priceperpint = 0.12
                Price = Priceperpint * MilkQuantity
                OutputSainsbury = OutputSainsbury & "Sainsbury" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            ElseIf MilkQuantity < 2000 Then
                Priceperpint = 0.1
                Price = Priceperpint * MilkQuantity
                OutputSainsbury = OutputSainsbury & "Sainsbury" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            ElseIf MilkQuantity >= 2000 Then
                Priceperpint = 0.09
                Price = Priceperpint * MilkQuantity
                OutputSainsbury = OutputSainsbury & "Sainsbury" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            End If
        End If

        OutputMorrison = "Customer: "
        If cboCustomer.SelectedItem = "Morrison" Then
            If MilkQuantity < 1000 Then
                Priceperpint = 0.1
                Price = Priceperpint * MilkQuantity
                OutputMorrison = OutputMorrison & "Morrison" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            ElseIf MilkQuantity < 2000 Then
                Priceperpint = 0.09
                Price = Priceperpint * MilkQuantity
                OutputMorrison = OutputMorrison & "Morrison" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            ElseIf MilkQuantity >= 2000 Then
                Priceperpint = 0.07
                Price = Priceperpint * MilkQuantity
                OutputMorrison = OutputMorrison & "Morrison" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            End If
        End If

        OutputBooths = "Customer: "
        If cboCustomer.SelectedItem = "Booths" Then
            If MilkQuantity < 1000 Then
                Priceperpint = 0.15
                Price = Priceperpint * MilkQuantity
                OutputBooths = OutputBooths & "Booths" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            ElseIf MilkQuantity < 2000 Then
                Priceperpint = 0.14
                Price = Priceperpint * MilkQuantity
                OutputBooths = OutputBooths & "Booths" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            ElseIf MilkQuantity >= 2000 Then
                Priceperpint = 0.12
                Price = Priceperpint * MilkQuantity
                OutputBooths = OutputBooths & "Booths" & vbNewLine & _
                        "Price Per Pint: " & Format(Priceperpint, "currency") & vbNewLine & _
                        "Quantity: " & MilkQuantity & vbNewLine & _
                        "Total Cost: " & Format(Price, "currency")
            End If
        End If


        If cboCustomer.SelectedItem = "Wholesale" Then
            lblInvoice.Text = "Lamarck Dairy – Order" & vbNewLine & _
                              OutputWholesale
        End If

        If cboCustomer.SelectedItem = "Sainsbury" Then
            lblInvoice.Text = "Lamarck Dairy – Order" & vbNewLine & _
                              OutputSainsbury

        End If

        If cboCustomer.SelectedItem = "Morrison" Then
            lblInvoice.Text = "Lamarck Dairy – Order" & vbNewLine & _
                              OutputMorrison
        End If


        If cboCustomer.SelectedItem = "Booths" Then
            lblInvoice.Text = "Lamarck Dairy – Order" & vbNewLine & _
                              OutputBooths
        End If


    End Sub
End Class
