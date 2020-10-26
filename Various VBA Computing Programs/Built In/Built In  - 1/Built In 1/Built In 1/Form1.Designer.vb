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
        Me.lbldisplay = New System.Windows.Forms.Label()
        Me.btnVowels = New System.Windows.Forms.Button()
        Me.btnDateD = New System.Windows.Forms.Button()
        Me.btnString = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbldisplay
        '
        Me.lbldisplay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldisplay.Location = New System.Drawing.Point(187, 50)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.Size = New System.Drawing.Size(208, 291)
        Me.lbldisplay.TabIndex = 0
        '
        'btnVowels
        '
        Me.btnVowels.Location = New System.Drawing.Point(24, 68)
        Me.btnVowels.Name = "btnVowels"
        Me.btnVowels.Size = New System.Drawing.Size(128, 56)
        Me.btnVowels.TabIndex = 1
        Me.btnVowels.Text = "Amount of Vowels And Words"
        Me.btnVowels.UseVisualStyleBackColor = True
        '
        'btnDateD
        '
        Me.btnDateD.Location = New System.Drawing.Point(24, 162)
        Me.btnDateD.Name = "btnDateD"
        Me.btnDateD.Size = New System.Drawing.Size(128, 56)
        Me.btnDateD.TabIndex = 2
        Me.btnDateD.Text = "Difference in Dates"
        Me.btnDateD.UseVisualStyleBackColor = True
        '
        'btnString
        '
        Me.btnString.Location = New System.Drawing.Point(24, 257)
        Me.btnString.Name = "btnString"
        Me.btnString.Size = New System.Drawing.Size(128, 56)
        Me.btnString.TabIndex = 3
        Me.btnString.Text = "String Word Check"
        Me.btnString.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 379)
        Me.Controls.Add(Me.btnString)
        Me.Controls.Add(Me.btnDateD)
        Me.Controls.Add(Me.btnVowels)
        Me.Controls.Add(Me.lbldisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbldisplay As System.Windows.Forms.Label
    Friend WithEvents btnVowels As System.Windows.Forms.Button
    Friend WithEvents btnDateD As System.Windows.Forms.Button
    Friend WithEvents btnString As System.Windows.Forms.Button

End Class
