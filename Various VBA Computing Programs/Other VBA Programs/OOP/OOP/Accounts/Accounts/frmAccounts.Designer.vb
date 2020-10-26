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
        Me.cmdAccounts = New System.Windows.Forms.Button
        Me.txtAccNo = New System.Windows.Forms.TextBox
        Me.txtForename = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.cmdViewAccounts = New System.Windows.Forms.Button
        Me.cmdAmendBal = New System.Windows.Forms.Button
        Me.lblAccNo = New System.Windows.Forms.Label
        Me.lblForename = New System.Windows.Forms.Label
        Me.lblSurname = New System.Windows.Forms.Label
        Me.lblBal = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdAccounts
        '
        Me.cmdAccounts.Location = New System.Drawing.Point(12, 12)
        Me.cmdAccounts.Name = "cmdAccounts"
        Me.cmdAccounts.Size = New System.Drawing.Size(93, 62)
        Me.cmdAccounts.TabIndex = 0
        Me.cmdAccounts.Text = "New Accounts"
        Me.cmdAccounts.UseVisualStyleBackColor = True
        '
        'txtAccNo
        '
        Me.txtAccNo.Location = New System.Drawing.Point(139, 127)
        Me.txtAccNo.Name = "txtAccNo"
        Me.txtAccNo.Size = New System.Drawing.Size(158, 20)
        Me.txtAccNo.TabIndex = 1
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(140, 153)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(158, 20)
        Me.txtForename.TabIndex = 2
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(140, 179)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(158, 20)
        Me.txtSurname.TabIndex = 3
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(140, 205)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(158, 20)
        Me.txtBalance.TabIndex = 4
        '
        'cmdViewAccounts
        '
        Me.cmdViewAccounts.Enabled = False
        Me.cmdViewAccounts.Location = New System.Drawing.Point(121, 13)
        Me.cmdViewAccounts.Name = "cmdViewAccounts"
        Me.cmdViewAccounts.Size = New System.Drawing.Size(93, 61)
        Me.cmdViewAccounts.TabIndex = 5
        Me.cmdViewAccounts.Text = "View Accounts"
        Me.cmdViewAccounts.UseVisualStyleBackColor = True
        '
        'cmdAmendBal
        '
        Me.cmdAmendBal.Location = New System.Drawing.Point(240, 12)
        Me.cmdAmendBal.Name = "cmdAmendBal"
        Me.cmdAmendBal.Size = New System.Drawing.Size(113, 61)
        Me.cmdAmendBal.TabIndex = 6
        Me.cmdAmendBal.Text = "Amend Balance"
        Me.cmdAmendBal.UseVisualStyleBackColor = True
        '
        'lblAccNo
        '
        Me.lblAccNo.AutoSize = True
        Me.lblAccNo.Location = New System.Drawing.Point(55, 134)
        Me.lblAccNo.Name = "lblAccNo"
        Me.lblAccNo.Size = New System.Drawing.Size(64, 13)
        Me.lblAccNo.TabIndex = 7
        Me.lblAccNo.Text = "Account No"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Location = New System.Drawing.Point(55, 160)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(54, 13)
        Me.lblForename.TabIndex = 8
        Me.lblForename.Text = "Forename"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(55, 186)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblSurname.TabIndex = 9
        Me.lblSurname.Text = "Surname"
        '
        'lblBal
        '
        Me.lblBal.AutoSize = True
        Me.lblBal.Location = New System.Drawing.Point(55, 212)
        Me.lblBal.Name = "lblBal"
        Me.lblBal.Size = New System.Drawing.Size(46, 13)
        Me.lblBal.TabIndex = 10
        Me.lblBal.Text = "Balance"
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 273)
        Me.Controls.Add(Me.lblBal)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.lblAccNo)
        Me.Controls.Add(Me.cmdAmendBal)
        Me.Controls.Add(Me.cmdViewAccounts)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.txtAccNo)
        Me.Controls.Add(Me.cmdAccounts)
        Me.Name = "frmAccounts"
        Me.Text = "Bank Accounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAccounts As System.Windows.Forms.Button
    Friend WithEvents txtAccNo As System.Windows.Forms.TextBox
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents cmdViewAccounts As System.Windows.Forms.Button
    Friend WithEvents cmdAmendBal As System.Windows.Forms.Button
    Friend WithEvents lblAccNo As System.Windows.Forms.Label
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblBal As System.Windows.Forms.Label

End Class
