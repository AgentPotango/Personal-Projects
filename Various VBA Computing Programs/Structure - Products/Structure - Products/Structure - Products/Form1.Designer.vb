<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnAmend = New System.Windows.Forms.Button()
        Me.btnReorder = New System.Windows.Forms.Button()
        Me.lblProductNo = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblStockNo = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblReorder = New System.Windows.Forms.Label()
        Me.lblReOrderList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(28, 30)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(101, 43)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(28, 94)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 43)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(28, 164)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(101, 43)
        Me.btnPrev.TabIndex = 2
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnAmend
        '
        Me.btnAmend.Location = New System.Drawing.Point(28, 231)
        Me.btnAmend.Name = "btnAmend"
        Me.btnAmend.Size = New System.Drawing.Size(101, 43)
        Me.btnAmend.TabIndex = 3
        Me.btnAmend.Text = "Amend"
        Me.btnAmend.UseVisualStyleBackColor = True
        '
        'btnReorder
        '
        Me.btnReorder.Location = New System.Drawing.Point(28, 298)
        Me.btnReorder.Name = "btnReorder"
        Me.btnReorder.Size = New System.Drawing.Size(101, 43)
        Me.btnReorder.TabIndex = 4
        Me.btnReorder.Text = "Re-Order List"
        Me.btnReorder.UseVisualStyleBackColor = True
        '
        'lblProductNo
        '
        Me.lblProductNo.BackColor = System.Drawing.Color.White
        Me.lblProductNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductNo.Location = New System.Drawing.Point(181, 30)
        Me.lblProductNo.Name = "lblProductNo"
        Me.lblProductNo.Size = New System.Drawing.Size(105, 38)
        Me.lblProductNo.TabIndex = 5
        Me.lblProductNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProduct
        '
        Me.lblProduct.BackColor = System.Drawing.Color.White
        Me.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProduct.Location = New System.Drawing.Point(181, 96)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(105, 38)
        Me.lblProduct.TabIndex = 6
        Me.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStockNo
        '
        Me.lblStockNo.BackColor = System.Drawing.Color.White
        Me.lblStockNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStockNo.Location = New System.Drawing.Point(181, 166)
        Me.lblStockNo.Name = "lblStockNo"
        Me.lblStockNo.Size = New System.Drawing.Size(105, 38)
        Me.lblStockNo.TabIndex = 7
        Me.lblStockNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(181, 233)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(105, 38)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReorder
        '
        Me.lblReorder.BackColor = System.Drawing.Color.White
        Me.lblReorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReorder.Location = New System.Drawing.Point(181, 300)
        Me.lblReorder.Name = "lblReorder"
        Me.lblReorder.Size = New System.Drawing.Size(105, 38)
        Me.lblReorder.TabIndex = 9
        Me.lblReorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReOrderList
        '
        Me.lblReOrderList.BackColor = System.Drawing.Color.White
        Me.lblReOrderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReOrderList.Location = New System.Drawing.Point(350, 30)
        Me.lblReOrderList.Name = "lblReOrderList"
        Me.lblReOrderList.Size = New System.Drawing.Size(164, 222)
        Me.lblReOrderList.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 388)
        Me.Controls.Add(Me.lblReOrderList)
        Me.Controls.Add(Me.lblReorder)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblStockNo)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.lblProductNo)
        Me.Controls.Add(Me.btnReorder)
        Me.Controls.Add(Me.btnAmend)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnAmend As System.Windows.Forms.Button
    Friend WithEvents btnReorder As System.Windows.Forms.Button
    Friend WithEvents lblProductNo As System.Windows.Forms.Label
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents lblStockNo As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblReorder As System.Windows.Forms.Label
    Friend WithEvents lblReOrderList As System.Windows.Forms.Label

End Class
