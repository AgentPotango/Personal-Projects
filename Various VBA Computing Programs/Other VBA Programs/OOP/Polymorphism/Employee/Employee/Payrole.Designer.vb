<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdAdult = New System.Windows.Forms.Button
        Me.cmdJunior = New System.Windows.Forms.Button
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtForename = New System.Windows.Forms.TextBox
        Me.txtType = New System.Windows.Forms.TextBox
        Me.txtPay = New System.Windows.Forms.TextBox
        Me.txtGuardian = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmdAdult
        '
        Me.cmdAdult.Location = New System.Drawing.Point(37, 39)
        Me.cmdAdult.Name = "cmdAdult"
        Me.cmdAdult.Size = New System.Drawing.Size(63, 31)
        Me.cmdAdult.TabIndex = 0
        Me.cmdAdult.Text = "Adult"
        Me.cmdAdult.UseVisualStyleBackColor = True
        '
        'cmdJunior
        '
        Me.cmdJunior.Location = New System.Drawing.Point(251, 39)
        Me.cmdJunior.Name = "cmdJunior"
        Me.cmdJunior.Size = New System.Drawing.Size(63, 31)
        Me.cmdJunior.TabIndex = 1
        Me.cmdJunior.Text = "Junior"
        Me.cmdJunior.UseVisualStyleBackColor = True
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(99, 103)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(149, 20)
        Me.txtSurname.TabIndex = 2
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(99, 139)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(149, 20)
        Me.txtForename.TabIndex = 3
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(99, 180)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(149, 20)
        Me.txtType.TabIndex = 4
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(99, 219)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(149, 20)
        Me.txtPay.TabIndex = 5
        '
        'txtGuardian
        '
        Me.txtGuardian.Location = New System.Drawing.Point(99, 259)
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(149, 20)
        Me.txtGuardian.TabIndex = 6
        Me.txtGuardian.Visible = False
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 311)
        Me.Controls.Add(Me.txtGuardian)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.cmdJunior)
        Me.Controls.Add(Me.cmdAdult)
        Me.Name = "frmEmployee"
        Me.Text = "Employee - Polymorphism"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAdult As System.Windows.Forms.Button
    Friend WithEvents cmdJunior As System.Windows.Forms.Button
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtPay As System.Windows.Forms.TextBox
    Friend WithEvents txtGuardian As System.Windows.Forms.TextBox

End Class
