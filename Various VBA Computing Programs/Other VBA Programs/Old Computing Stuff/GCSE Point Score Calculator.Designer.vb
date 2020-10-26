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
        Me.lblinvoice = New System.Windows.Forms.Label()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GCSE Point Score Calculator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblinvoice
        '
        Me.lblinvoice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblinvoice.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvoice.Location = New System.Drawing.Point(81, 306)
        Me.lblinvoice.Name = "lblinvoice"
        Me.lblinvoice.Size = New System.Drawing.Size(422, 250)
        Me.lblinvoice.TabIndex = 1
        Me.lblinvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncalc
        '
        Me.btncalc.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalc.Location = New System.Drawing.Point(127, 167)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(326, 71)
        Me.btncalc.TabIndex = 2
        Me.btncalc.Text = "Calculate my Results!"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 585)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.lblinvoice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblinvoice As System.Windows.Forms.Label
    Friend WithEvents btncalc As System.Windows.Forms.Button

End Class
