<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts
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
        Me.txtAccNo = New System.Windows.Forms.TextBox
        Me.txtForename = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.txtInterest = New System.Windows.Forms.TextBox
        Me.btnCAccount = New System.Windows.Forms.Button
        Me.btnSavings = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtAccNo
        '
        Me.txtAccNo.Location = New System.Drawing.Point(23, 87)
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(190, 20)
        Me.txtAccNo.TabIndex = 1
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(24, 113)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(190, 20)
        Me.txtForename.TabIndex = 2
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(24, 139)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(190, 20)
        Me.txtSurname.TabIndex = 3
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(24, 165)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(190, 20)
        Me.txtBalance.TabIndex = 4
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(24, 197)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(189, 20)
        Me.txtInterest.TabIndex = 7
        '
        'btnCAccount
        '
        Me.btnCAccount.Location = New System.Drawing.Point(24, 12)
        Me.btnCAccount.Name = "btnCAccount"
        Me.btnCAccount.Size = New System.Drawing.Size(78, 51)
        Me.btnCAccount.TabIndex = 9
        Me.btnCAccount.Text = "Current Account"
        Me.btnCAccount.UseVisualStyleBackColor = True
        '
        'btnSavings
        '
        Me.btnSavings.Location = New System.Drawing.Point(135, 12)
        Me.btnSavings.Name = "btnSavings"
        Me.btnSavings.Size = New System.Drawing.Size(78, 51)
        Me.btnSavings.TabIndex = 10
        Me.btnSavings.Text = "Savings Account"
        Me.btnSavings.UseVisualStyleBackColor = True
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 258)
        Me.Controls.Add(Me.btnSavings)
        Me.Controls.Add(Me.btnCAccount)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.txtAccNo)
        Me.Name = "frmAccounts"
        Me.Text = "Bank Accounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAccNo As System.Windows.Forms.TextBox
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtInterest As System.Windows.Forms.TextBox
    Friend WithEvents btnCAccount As System.Windows.Forms.Button
    Friend WithEvents btnSavings As System.Windows.Forms.Button

End Class
