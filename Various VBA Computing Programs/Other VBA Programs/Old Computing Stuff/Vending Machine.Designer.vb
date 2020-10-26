<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl200 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl20 = New System.Windows.Forms.Label()
        Me.lbl50 = New System.Windows.Forms.Label()
        Me.lbl100 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vending Machine"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbloutput
        '
        Me.lbloutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbloutput.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutput.Location = New System.Drawing.Point(21, 389)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(245, 142)
        Me.lbloutput.TabIndex = 1
        Me.lbloutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Amount of £2.00 Change"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Amount of 20p Change"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Amount of 2p Change"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(245, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Amount of 50p Change"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Amount of £1.00 Change"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(294, 410)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(120, 109)
        Me.BtnCalculate.TabIndex = 15
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(245, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Amount of 1p Change"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(245, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Amount of 5p Change"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(245, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Amount of 10p Change"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label11.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(245, 27)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Price of Snack"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(294, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 23
        '
        'lbl200
        '
        Me.lbl200.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl200.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl200.Location = New System.Drawing.Point(290, 138)
        Me.lbl200.Name = "lbl200"
        Me.lbl200.Size = New System.Drawing.Size(135, 20)
        Me.lbl200.TabIndex = 24
        Me.lbl200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(290, 328)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(135, 20)
        Me.lbl2.TabIndex = 25
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(290, 296)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(135, 20)
        Me.lbl5.TabIndex = 26
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl10
        '
        Me.lbl10.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.Location = New System.Drawing.Point(290, 262)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(135, 20)
        Me.lbl10.TabIndex = 27
        Me.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl20
        '
        Me.lbl20.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl20.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl20.Location = New System.Drawing.Point(290, 230)
        Me.lbl20.Name = "lbl20"
        Me.lbl20.Size = New System.Drawing.Size(135, 20)
        Me.lbl20.TabIndex = 28
        Me.lbl20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl50
        '
        Me.lbl50.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl50.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl50.Location = New System.Drawing.Point(290, 200)
        Me.lbl50.Name = "lbl50"
        Me.lbl50.Size = New System.Drawing.Size(135, 20)
        Me.lbl50.TabIndex = 29
        Me.lbl50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl100
        '
        Me.lbl100.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl100.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl100.Location = New System.Drawing.Point(290, 171)
        Me.lbl100.Name = "lbl100"
        Me.lbl100.Size = New System.Drawing.Size(135, 20)
        Me.lbl100.TabIndex = 30
        Me.lbl100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbl1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(290, 359)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(135, 20)
        Me.lbl1.TabIndex = 31
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 540)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl100)
        Me.Controls.Add(Me.lbl50)
        Me.Controls.Add(Me.lbl20)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl200)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbloutput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbloutput As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl200 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl20 As System.Windows.Forms.Label
    Friend WithEvents lbl50 As System.Windows.Forms.Label
    Friend WithEvents lbl100 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label

End Class
