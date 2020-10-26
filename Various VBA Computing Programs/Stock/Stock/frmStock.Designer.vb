<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtItemID = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtNoInStock = New System.Windows.Forms.TextBox
        Me.txtRetail = New System.Windows.Forms.TextBox
        Me.txtReOrder = New System.Windows.Forms.TextBox
        Me.btnMake = New System.Windows.Forms.Button
        Me.btnReadRec = New System.Windows.Forms.Button
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.radInUse = New System.Windows.Forms.RadioButton
        Me.radDelete = New System.Windows.Forms.RadioButton
        Me.btnAmend = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Records"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number in Stock"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Retail Price"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Re-Order Level"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItemID
        '
        Me.txtItemID.Location = New System.Drawing.Point(186, 67)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Size = New System.Drawing.Size(158, 20)
        Me.txtItemID.TabIndex = 6
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(187, 107)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(158, 20)
        Me.txtDescription.TabIndex = 7
        '
        'txtNoInStock
        '
        Me.txtNoInStock.Location = New System.Drawing.Point(187, 146)
        Me.txtNoInStock.Name = "txtNoInStock"
        Me.txtNoInStock.Size = New System.Drawing.Size(158, 20)
        Me.txtNoInStock.TabIndex = 8
        '
        'txtRetail
        '
        Me.txtRetail.Location = New System.Drawing.Point(187, 185)
        Me.txtRetail.Name = "txtRetail"
        Me.txtRetail.Size = New System.Drawing.Size(158, 20)
        Me.txtRetail.TabIndex = 9
        '
        'txtReOrder
        '
        Me.txtReOrder.Location = New System.Drawing.Point(186, 226)
        Me.txtReOrder.Name = "txtReOrder"
        Me.txtReOrder.Size = New System.Drawing.Size(158, 20)
        Me.txtReOrder.TabIndex = 10
        '
        'btnMake
        '
        Me.btnMake.Location = New System.Drawing.Point(368, 18)
        Me.btnMake.Name = "btnMake"
        Me.btnMake.Size = New System.Drawing.Size(100, 35)
        Me.btnMake.TabIndex = 11
        Me.btnMake.Text = "Make Test File"
        Me.btnMake.UseVisualStyleBackColor = True
        '
        'btnReadRec
        '
        Me.btnReadRec.Location = New System.Drawing.Point(368, 59)
        Me.btnReadRec.Name = "btnReadRec"
        Me.btnReadRec.Size = New System.Drawing.Size(100, 35)
        Me.btnReadRec.TabIndex = 12
        Me.btnReadRec.Text = "Read File"
        Me.btnReadRec.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(368, 181)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(100, 35)
        Me.btnPrevious.TabIndex = 13
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(368, 140)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 35)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(368, 100)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 35)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDelete)
        Me.GroupBox1.Controls.Add(Me.radInUse)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 74)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Record In Use"
        '
        'radInUse
        '
        Me.radInUse.AutoSize = True
        Me.radInUse.Checked = True
        Me.radInUse.Location = New System.Drawing.Point(17, 19)
        Me.radInUse.Name = "radInUse"
        Me.radInUse.Size = New System.Drawing.Size(56, 17)
        Me.radInUse.TabIndex = 0
        Me.radInUse.TabStop = True
        Me.radInUse.Text = "In Use"
        Me.radInUse.UseVisualStyleBackColor = True
        '
        'radDelete
        '
        Me.radDelete.AutoSize = True
        Me.radDelete.Location = New System.Drawing.Point(17, 42)
        Me.radDelete.Name = "radDelete"
        Me.radDelete.Size = New System.Drawing.Size(56, 17)
        Me.radDelete.TabIndex = 1
        Me.radDelete.Text = "Delete"
        Me.radDelete.UseVisualStyleBackColor = True
        '
        'btnAmend
        '
        Me.btnAmend.Location = New System.Drawing.Point(368, 226)
        Me.btnAmend.Name = "btnAmend"
        Me.btnAmend.Size = New System.Drawing.Size(100, 35)
        Me.btnAmend.TabIndex = 17
        Me.btnAmend.Text = "Amend"
        Me.btnAmend.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(368, 269)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 35)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 360)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAmend)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnReadRec)
        Me.Controls.Add(Me.btnMake)
        Me.Controls.Add(Me.txtReOrder)
        Me.Controls.Add(Me.txtRetail)
        Me.Controls.Add(Me.txtNoInStock)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtItemID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStock"
        Me.Text = "Stock Records"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtNoInStock As System.Windows.Forms.TextBox
    Friend WithEvents txtRetail As System.Windows.Forms.TextBox
    Friend WithEvents txtReOrder As System.Windows.Forms.TextBox
    Friend WithEvents btnMake As System.Windows.Forms.Button
    Friend WithEvents btnReadRec As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radDelete As System.Windows.Forms.RadioButton
    Friend WithEvents radInUse As System.Windows.Forms.RadioButton
    Friend WithEvents btnAmend As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
