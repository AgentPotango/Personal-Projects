<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecursion
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
        Me.Display = New System.Windows.Forms.Label()
        Me.btnRecursion1 = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnSimplePower = New System.Windows.Forms.Button()
        Me.btnBin = New System.Windows.Forms.Button()
        Me.btnExample2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Display
        '
        Me.Display.BackColor = System.Drawing.Color.White
        Me.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Display.Location = New System.Drawing.Point(169, 18)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(248, 404)
        Me.Display.TabIndex = 0
        '
        'btnRecursion1
        '
        Me.btnRecursion1.Location = New System.Drawing.Point(28, 18)
        Me.btnRecursion1.Name = "btnRecursion1"
        Me.btnRecursion1.Size = New System.Drawing.Size(133, 64)
        Me.btnRecursion1.TabIndex = 1
        Me.btnRecursion1.Text = "Recursion Example 1"
        Me.btnRecursion1.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Location = New System.Drawing.Point(28, 156)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(133, 62)
        Me.btnFactorial.TabIndex = 2
        Me.btnFactorial.Text = "Recursion - Factorial"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Location = New System.Drawing.Point(28, 224)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(133, 62)
        Me.btnPower.TabIndex = 3
        Me.btnPower.Text = "Power"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnSimplePower
        '
        Me.btnSimplePower.Location = New System.Drawing.Point(28, 292)
        Me.btnSimplePower.Name = "btnSimplePower"
        Me.btnSimplePower.Size = New System.Drawing.Size(133, 62)
        Me.btnSimplePower.TabIndex = 4
        Me.btnSimplePower.Text = "Simple Power"
        Me.btnSimplePower.UseVisualStyleBackColor = True
        '
        'btnBin
        '
        Me.btnBin.Location = New System.Drawing.Point(28, 360)
        Me.btnBin.Name = "btnBin"
        Me.btnBin.Size = New System.Drawing.Size(133, 62)
        Me.btnBin.TabIndex = 5
        Me.btnBin.Text = "Binary Seach Count"
        Me.btnBin.UseVisualStyleBackColor = True
        '
        'btnExample2
        '
        Me.btnExample2.Location = New System.Drawing.Point(28, 88)
        Me.btnExample2.Name = "btnExample2"
        Me.btnExample2.Size = New System.Drawing.Size(133, 62)
        Me.btnExample2.TabIndex = 6
        Me.btnExample2.Text = "Recursion Example 2"
        Me.btnExample2.UseVisualStyleBackColor = True
        '
        'frmRecursion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 449)
        Me.Controls.Add(Me.btnExample2)
        Me.Controls.Add(Me.btnBin)
        Me.Controls.Add(Me.btnSimplePower)
        Me.Controls.Add(Me.btnPower)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnRecursion1)
        Me.Controls.Add(Me.Display)
        Me.Name = "frmRecursion"
        Me.Text = "Recursion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Display As System.Windows.Forms.Label
    Friend WithEvents btnRecursion1 As System.Windows.Forms.Button
    Friend WithEvents btnFactorial As System.Windows.Forms.Button
    Friend WithEvents btnPower As System.Windows.Forms.Button
    Friend WithEvents btnSimplePower As System.Windows.Forms.Button
    Friend WithEvents btnBin As System.Windows.Forms.Button
    Friend WithEvents btnExample2 As System.Windows.Forms.Button

End Class
