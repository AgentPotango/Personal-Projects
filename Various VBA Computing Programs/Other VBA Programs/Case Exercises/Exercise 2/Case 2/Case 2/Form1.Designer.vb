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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.cmbTicket = New System.Windows.Forms.ComboBox()
        Me.gbDestinations = New System.Windows.Forms.GroupBox()
        Me.optAmsterdam = New System.Windows.Forms.RadioButton()
        Me.optBerlin = New System.Windows.Forms.RadioButton()
        Me.optParis = New System.Windows.Forms.RadioButton()
        Me.Output = New System.Windows.Forms.Label()
        Me.optVenice = New System.Windows.Forms.RadioButton()
        Me.cmbTicketAmount = New System.Windows.Forms.ComboBox()
        Me.cbInsurance = New System.Windows.Forms.CheckBox()
        Me.cmbBags = New System.Windows.Forms.ComboBox()
        Me.gbDestinations.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(249, 199)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(110, 78)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Find Price"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'cmbTicket
        '
        Me.cmbTicket.FormattingEnabled = True
        Me.cmbTicket.Location = New System.Drawing.Point(249, 40)
        Me.cmbTicket.Name = "cmbTicket"
        Me.cmbTicket.Size = New System.Drawing.Size(127, 21)
        Me.cmbTicket.TabIndex = 1
        '
        'gbDestinations
        '
        Me.gbDestinations.Controls.Add(Me.optVenice)
        Me.gbDestinations.Controls.Add(Me.optAmsterdam)
        Me.gbDestinations.Controls.Add(Me.optBerlin)
        Me.gbDestinations.Controls.Add(Me.optParis)
        Me.gbDestinations.Location = New System.Drawing.Point(31, 44)
        Me.gbDestinations.Name = "gbDestinations"
        Me.gbDestinations.Size = New System.Drawing.Size(150, 180)
        Me.gbDestinations.TabIndex = 2
        Me.gbDestinations.TabStop = False
        Me.gbDestinations.Text = "GroupBox1"
        '
        'optAmsterdam
        '
        Me.optAmsterdam.AutoSize = True
        Me.optAmsterdam.Location = New System.Drawing.Point(15, 116)
        Me.optAmsterdam.Name = "optAmsterdam"
        Me.optAmsterdam.Size = New System.Drawing.Size(77, 17)
        Me.optAmsterdam.TabIndex = 3
        Me.optAmsterdam.TabStop = True
        Me.optAmsterdam.Text = "Amsterdam"
        Me.optAmsterdam.UseVisualStyleBackColor = True
        '
        'optBerlin
        '
        Me.optBerlin.AutoSize = True
        Me.optBerlin.Location = New System.Drawing.Point(15, 75)
        Me.optBerlin.Name = "optBerlin"
        Me.optBerlin.Size = New System.Drawing.Size(51, 17)
        Me.optBerlin.TabIndex = 3
        Me.optBerlin.TabStop = True
        Me.optBerlin.Text = "Berlin"
        Me.optBerlin.UseVisualStyleBackColor = True
        '
        'optParis
        '
        Me.optParis.AutoSize = True
        Me.optParis.Location = New System.Drawing.Point(15, 33)
        Me.optParis.Name = "optParis"
        Me.optParis.Size = New System.Drawing.Size(48, 17)
        Me.optParis.TabIndex = 0
        Me.optParis.TabStop = True
        Me.optParis.Text = "Paris"
        Me.optParis.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.Output.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Output.Location = New System.Drawing.Point(43, 297)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(317, 122)
        Me.Output.TabIndex = 3
        Me.Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optVenice
        '
        Me.optVenice.AutoSize = True
        Me.optVenice.Location = New System.Drawing.Point(15, 155)
        Me.optVenice.Name = "optVenice"
        Me.optVenice.Size = New System.Drawing.Size(58, 17)
        Me.optVenice.TabIndex = 4
        Me.optVenice.TabStop = True
        Me.optVenice.Text = "Venice"
        Me.optVenice.UseVisualStyleBackColor = True
        '
        'cmbTicketAmount
        '
        Me.cmbTicketAmount.FormattingEnabled = True
        Me.cmbTicketAmount.Location = New System.Drawing.Point(249, 76)
        Me.cmbTicketAmount.Name = "cmbTicketAmount"
        Me.cmbTicketAmount.Size = New System.Drawing.Size(127, 21)
        Me.cmbTicketAmount.TabIndex = 4
        '
        'cbInsurance
        '
        Me.cbInsurance.AutoSize = True
        Me.cbInsurance.Location = New System.Drawing.Point(261, 160)
        Me.cbInsurance.Name = "cbInsurance"
        Me.cbInsurance.Size = New System.Drawing.Size(79, 17)
        Me.cbInsurance.TabIndex = 5
        Me.cbInsurance.Text = "Insurance?"
        Me.cbInsurance.UseVisualStyleBackColor = True
        '
        'cmbBags
        '
        Me.cmbBags.FormattingEnabled = True
        Me.cmbBags.Location = New System.Drawing.Point(249, 119)
        Me.cmbBags.Name = "cmbBags"
        Me.cmbBags.Size = New System.Drawing.Size(127, 21)
        Me.cmbBags.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 428)
        Me.Controls.Add(Me.cmbBags)
        Me.Controls.Add(Me.cbInsurance)
        Me.Controls.Add(Me.cmbTicketAmount)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.gbDestinations)
        Me.Controls.Add(Me.cmbTicket)
        Me.Controls.Add(Me.btnFind)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbDestinations.ResumeLayout(False)
        Me.gbDestinations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents cmbTicket As System.Windows.Forms.ComboBox
    Friend WithEvents gbDestinations As System.Windows.Forms.GroupBox
    Friend WithEvents optAmsterdam As System.Windows.Forms.RadioButton
    Friend WithEvents optBerlin As System.Windows.Forms.RadioButton
    Friend WithEvents optParis As System.Windows.Forms.RadioButton
    Friend WithEvents Output As System.Windows.Forms.Label
    Friend WithEvents optVenice As System.Windows.Forms.RadioButton
    Friend WithEvents cmbTicketAmount As System.Windows.Forms.ComboBox
    Friend WithEvents cbInsurance As System.Windows.Forms.CheckBox
    Friend WithEvents cmbBags As System.Windows.Forms.ComboBox

End Class
