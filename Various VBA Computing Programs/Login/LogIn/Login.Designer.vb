<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.P1 = New System.Windows.Forms.ComboBox()
        Me.P2 = New System.Windows.Forms.ComboBox()
        Me.P3 = New System.Windows.Forms.ComboBox()
        Me.P4 = New System.Windows.Forms.ComboBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLogIn
        '
        Me.lblLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLogIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.Location = New System.Drawing.Point(32, 31)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(340, 45)
        Me.lblLogIn.TabIndex = 1
        Me.lblLogIn.Text = "Log-In"
        Me.lblLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P1
        '
        Me.P1.FormattingEnabled = True
        Me.P1.Location = New System.Drawing.Point(32, 111)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(52, 21)
        Me.P1.TabIndex = 2
        '
        'P2
        '
        Me.P2.FormattingEnabled = True
        Me.P2.Location = New System.Drawing.Point(133, 111)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(52, 21)
        Me.P2.TabIndex = 3
        '
        'P3
        '
        Me.P3.FormattingEnabled = True
        Me.P3.Location = New System.Drawing.Point(229, 111)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(52, 21)
        Me.P3.TabIndex = 4
        '
        'P4
        '
        Me.P4.FormattingEnabled = True
        Me.P4.Location = New System.Drawing.Point(320, 111)
        Me.P4.Name = "P4"
        Me.P4.Size = New System.Drawing.Size(52, 21)
        Me.P4.TabIndex = 5
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(32, 159)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(340, 64)
        Me.btnLogIn.TabIndex = 6
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Letter 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Letter 3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Letter 5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Letter 7"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 266)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.P4)
        Me.Controls.Add(Me.P3)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.lblLogIn)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Log-In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLogIn As System.Windows.Forms.Label
    Friend WithEvents P1 As System.Windows.Forms.ComboBox
    Friend WithEvents P2 As System.Windows.Forms.ComboBox
    Friend WithEvents P3 As System.Windows.Forms.ComboBox
    Friend WithEvents P4 As System.Windows.Forms.ComboBox
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
