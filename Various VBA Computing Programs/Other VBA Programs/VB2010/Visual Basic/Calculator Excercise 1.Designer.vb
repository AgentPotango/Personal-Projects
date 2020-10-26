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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo1 = New System.Windows.Forms.TextBox()
        Me.txtNo3 = New System.Windows.Forms.TextBox()
        Me.txtNo2 = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "C"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "B"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNo1
        '
        Me.txtNo1.Location = New System.Drawing.Point(213, 39)
        Me.txtNo1.Name = "txtNo1"
        Me.txtNo1.Size = New System.Drawing.Size(130, 20)
        Me.txtNo1.TabIndex = 3
        '
        'txtNo3
        '
        Me.txtNo3.Location = New System.Drawing.Point(213, 178)
        Me.txtNo3.Name = "txtNo3"
        Me.txtNo3.Size = New System.Drawing.Size(130, 20)
        Me.txtNo3.TabIndex = 4
        '
        'txtNo2
        '
        Me.txtNo2.Location = New System.Drawing.Point(213, 111)
        Me.txtNo2.Name = "txtNo2"
        Me.txtNo2.Size = New System.Drawing.Size(130, 20)
        Me.txtNo2.TabIndex = 5
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblAnswer.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(291, 330)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(141, 37)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnA
        '
        Me.btnA.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA.Location = New System.Drawing.Point(27, 269)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(231, 36)
        Me.btnA.TabIndex = 7
        Me.btnA.Text = "(A+B+C)/3"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(27, 390)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(231, 36)
        Me.btnC.TabIndex = 10
        Me.btnC.Text = "(A+(B*C))"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD.Location = New System.Drawing.Point(27, 330)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(231, 36)
        Me.btnD.TabIndex = 11
        Me.btnD.Text = "(A*B*C)"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 518)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtNo2)
        Me.Controls.Add(Me.txtNo3)
        Me.Controls.Add(Me.txtNo1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNo2 As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnD As System.Windows.Forms.Button

End Class
