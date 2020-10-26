Public Class Form1
    Dim Ticket As Single
    Dim TicketPrice As Single
    Dim TotalPrice As Single
    Dim Invoice As String
    Dim NoBags As Single
    Dim NoTickets As Integer
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If optParis.Checked = True Then
            If cmbTicket.SelectedIndex = 0 Then
                Ticket = 1
            Else
                Ticket = 2
            End If
        ElseIf optBerlin.Checked = True Then
            If cmbTicket.SelectedIndex = 0 Then
                Ticket = 3
            Else
                Ticket = 4
            End If
        ElseIf optAmsterdam.Checked = True Then
            If cmbTicket.SelectedIndex = 0 Then
                Ticket = 5
            Else
                Ticket = 6
            End If
        ElseIf optVenice.Checked = True Then
            If cmbTicket.SelectedIndex = 0 Then
                Ticket = 7
            Else
                Ticket = 8
            End If
        End If
        Select Case Ticket
            Case 1
                Invoice = "Paris Single - £25.00"
                TicketPrice = 25
            Case 2
                Invoice = "Paris Return - £45.00"
                TicketPrice = 45
            Case 3
                Invoice = "Berlin Single - £30.00"
                TicketPrice = 30
            Case 4
                Invoice = "Berlin Return - £55.00"
                TicketPrice = 55
            Case 5
                Invoice = "Amsterdam Single - £18.00"
                TicketPrice = 18
            Case 6
                Invoice = "Amsterdam Return - £34.00"
                TicketPrice = 34
            Case 7
                Invoice = "Venice Single - £22.00"
                TicketPrice = 22
            Case 8
                Invoice = "Venice Return - £39.00"
                TicketPrice = 39
        End Select
        NoTickets = cmbTicketAmount.SelectedIndex
        NoBags = cmbBags.SelectedIndex
        Invoice = Invoice & vbNewLine & NoTickets & "Tickets"
        Invoice = Invoice & vbNewLine & "Number of Bags: " & NoBags
        TotalPrice = NoTickets * TicketPrice
        If cmbTicket.SelectedIndex = 0 Then
            TotalPrice = TotalPrice + (NoBags * 6)
        Else
            TotalPrice = TotalPrice + (NoBags * 12)
        End If
        If cbInsurance.Checked Then
            Invoice = Invoice & vbNewLine & "Insurance Wanted"
            TotalPrice = TotalPrice + 16.5
        End If
        Invoice = Invoice & vbNewLine & "Total Price: " & Format(TotalPrice, "Currency")
        Output.Text = Invoice
    End Sub



    Private Sub frmForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmbTicket.Items.Add("Single")
        cmbTicket.Items.Add("Return")
        cmbTicketAmount.Items.Add("Number Of Tickets")
        cmbTicketAmount.Items.Add("1 Ticket")
        cmbTicketAmount.Items.Add("2 Tickets")
        cmbTicketAmount.Items.Add("3 Tickets")
        cmbTicketAmount.Items.Add("4 Tickets")
        cmbTicketAmount.Items.Add("5 Tickets")
        cmbBags.Items.Add("Number Of Bags")
        cmbBags.Items.Add("1 Suitcase")
        cmbBags.Items.Add("2 Suitcases")
        cmbBags.Items.Add("3 Suitcases")
        cmbBags.Items.Add("4 Suitcases")
        cmbBags.Items.Add("5 Suitcases")
        optParis.Checked = True
        cmbTicket.SelectedIndex = 0
        cmbTicketAmount.SelectedIndex = 0
        cmbBags.SelectedIndex = 0
    End Sub
    Private Sub cbInsurance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbInsurance.CheckedChanged
      
    End Sub
    Private Sub cmbBags_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBags.SelectedIndexChanged

    End Sub
End Class


