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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNo1 = New System.Windows.Forms.TextBox()
        Me.TxtNo2 = New System.Windows.Forms.TextBox()
        Me.btnaddition = New System.Windows.Forms.Button()
        Me.lblAddittion = New System.Windows.Forms.Label()
        Me.btnsubtraction = New System.Windows.Forms.Button()
        Me.lblSubtraction = New System.Windows.Forms.Label()
        Me.btnmultiplication = New System.Windows.Forms.Button()
        Me.lblMultiplication = New System.Windows.Forms.Label()
        Me.btndivision = New System.Windows.Forms.Button()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduction Program 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Second Number"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNo1
        '
        Me.txtNo1.Location = New System.Drawing.Point(174, 71)
        Me.txtNo1.Name = "txtNo1"
        Me.txtNo1.Size = New System.Drawing.Size(105, 20)
        Me.txtNo1.TabIndex = 3
        '
        'TxtNo2
        '
        Me.TxtNo2.Location = New System.Drawing.Point(174, 138)
        Me.TxtNo2.Name = "TxtNo2"
        Me.TxtNo2.Size = New System.Drawing.Size(106, 20)
        Me.TxtNo2.TabIndex = 4
        '
        'btnaddition
        '
        Me.btnaddition.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddition.Location = New System.Drawing.Point(12, 184)
        Me.btnaddition.Name = "btnaddition"
        Me.btnaddition.Size = New System.Drawing.Size(139, 55)
        Me.btnaddition.TabIndex = 6
        Me.btnaddition.Text = "Addittion"
        Me.btnaddition.UseVisualStyleBackColor = True
        '
        'lblAddittion
        '
        Me.lblAddittion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblAddittion.Location = New System.Drawing.Point(174, 184)
        Me.lblAddittion.Name = "lblAddittion"
        Me.lblAddittion.Size = New System.Drawing.Size(106, 55)
        Me.lblAddittion.TabIndex = 5
        '
        'btnsubtraction
        '
        Me.btnsubtraction.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubtraction.Location = New System.Drawing.Point(12, 255)
        Me.btnsubtraction.Name = "btnsubtraction"
        Me.btnsubtraction.Size = New System.Drawing.Size(139, 55)
        Me.btnsubtraction.TabIndex = 7
        Me.btnsubtraction.Text = "Subtraction"
        Me.btnsubtraction.UseVisualStyleBackColor = True
        '
        'lblSubtraction
        '
        Me.lblSubtraction.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblSubtraction.Location = New System.Drawing.Point(174, 255)
        Me.lblSubtraction.Name = "lblSubtraction"
        Me.lblSubtraction.Size = New System.Drawing.Size(106, 55)
        Me.lblSubtraction.TabIndex = 8
        '
        'btnmultiplication
        '
        Me.btnmultiplication.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmultiplication.Location = New System.Drawing.Point(12, 328)
        Me.btnmultiplication.Name = "btnmultiplication"
        Me.btnmultiplication.Size = New System.Drawing.Size(139, 55)
        Me.btnmultiplication.TabIndex = 9
        Me.btnmultiplication.Text = "Multiplication"
        Me.btnmultiplication.UseVisualStyleBackColor = True
        '
        'lblMultiplication
        '
        Me.lblMultiplication.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblMultiplication.Location = New System.Drawing.Point(174, 328)
        Me.lblMultiplication.Name = "lblMultiplication"
        Me.lblMultiplication.Size = New System.Drawing.Size(106, 55)
        Me.lblMultiplication.TabIndex = 10
        '
        'btndivision
        '
        Me.btndivision.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndivision.Location = New System.Drawing.Point(12, 395)
        Me.btndivision.Name = "btndivision"
        Me.btndivision.Size = New System.Drawing.Size(139, 55)
        Me.btndivision.TabIndex = 11
        Me.btndivision.Text = "Division"
        Me.btndivision.UseVisualStyleBackColor = True
        '
        'lblDivision
        '
        Me.lblDivision.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblDivision.Location = New System.Drawing.Point(174, 398)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(106, 55)
        Me.lblDivision.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 462)
        Me.Controls.Add(Me.lblDivision)
        Me.Controls.Add(Me.btndivision)
        Me.Controls.Add(Me.lblMultiplication)
        Me.Controls.Add(Me.btnmultiplication)
        Me.Controls.Add(Me.lblSubtraction)
        Me.Controls.Add(Me.btnsubtraction)
        Me.Controls.Add(Me.btnaddition)
        Me.Controls.Add(Me.lblAddittion)
        Me.Controls.Add(Me.TxtNo2)
        Me.Controls.Add(Me.txtNo1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNo1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNo2 As System.Windows.Forms.TextBox
    Friend WithEvents btnaddition As System.Windows.Forms.Button
    Friend WithEvents lblAddittion As System.Windows.Forms.Label
    Friend WithEvents btnsubtraction As System.Windows.Forms.Button
    Friend WithEvents lblSubtraction As System.Windows.Forms.Label
    Friend WithEvents btnmultiplication As System.Windows.Forms.Button
    Friend WithEvents lblMultiplication As System.Windows.Forms.Label
    Friend WithEvents btndivision As System.Windows.Forms.Button
    Friend WithEvents lblDivision As System.Windows.Forms.Label

End Class
