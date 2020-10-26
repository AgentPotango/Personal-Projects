<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorker
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
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.txtWage = New System.Windows.Forms.TextBox
        Me.txtHours = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdNEmployee = New System.Windows.Forms.Button
        Me.cmdHours = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(124, 90)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(143, 20)
        Me.txtID.TabIndex = 0
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(124, 164)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(143, 20)
        Me.txtRate.TabIndex = 1
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(124, 239)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(143, 20)
        Me.txtWage.TabIndex = 2
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(124, 200)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(143, 20)
        Me.txtHours.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(124, 128)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(143, 20)
        Me.txtName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Hours"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Wage"
        '
        'cmdNEmployee
        '
        Me.cmdNEmployee.Location = New System.Drawing.Point(12, 12)
        Me.cmdNEmployee.Name = "cmdNEmployee"
        Me.cmdNEmployee.Size = New System.Drawing.Size(119, 60)
        Me.cmdNEmployee.TabIndex = 10
        Me.cmdNEmployee.Text = "New Employee"
        Me.cmdNEmployee.UseVisualStyleBackColor = True
        '
        'cmdHours
        '
        Me.cmdHours.Location = New System.Drawing.Point(167, 16)
        Me.cmdHours.Name = "cmdHours"
        Me.cmdHours.Size = New System.Drawing.Size(117, 56)
        Me.cmdHours.TabIndex = 11
        Me.cmdHours.Text = "Calculate Pay"
        Me.cmdHours.UseVisualStyleBackColor = True
        '
        'frmWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 296)
        Me.Controls.Add(Me.cmdHours)
        Me.Controls.Add(Me.cmdNEmployee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtWage)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtID)
        Me.Name = "frmWorker"
        Me.Text = "Workers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtWage As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdNEmployee As System.Windows.Forms.Button
    Friend WithEvents cmdHours As System.Windows.Forms.Button

End Class
