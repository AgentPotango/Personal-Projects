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
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Location = New System.Drawing.Point(72, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insurance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtgender
        '
        Me.txtgender.Location = New System.Drawing.Point(329, 116)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(148, 20)
        Me.txtgender.TabIndex = 1
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(326, 166)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(151, 20)
        Me.txtage.TabIndex = 2
        '
        'lbloutput
        '
        Me.lbloutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbloutput.Location = New System.Drawing.Point(38, 231)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(227, 151)
        Me.lbloutput.TabIndex = 3
        Me.lbloutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label4.Location = New System.Drawing.Point(85, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Gender"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Location = New System.Drawing.Point(85, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Age"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(329, 242)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(137, 128)
        Me.btncalculate.TabIndex = 7
        Me.btncalculate.Text = "Calculate Cost"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 404)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbloutput)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents lbloutput As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btncalculate As System.Windows.Forms.Button

End Class
