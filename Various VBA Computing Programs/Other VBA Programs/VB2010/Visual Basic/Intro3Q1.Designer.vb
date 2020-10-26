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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnChelsea = New System.Windows.Forms.Button()
        Me.btnManU = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btnArsenal = New System.Windows.Forms.Button()
        Me.btnNetherlands = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(57, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(329, 48)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Football - Colour Scheme"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChelsea
        '
        Me.btnChelsea.Location = New System.Drawing.Point(26, 137)
        Me.btnChelsea.Name = "btnChelsea"
        Me.btnChelsea.Size = New System.Drawing.Size(125, 52)
        Me.btnChelsea.TabIndex = 1
        Me.btnChelsea.Text = "Chelsea"
        Me.btnChelsea.UseVisualStyleBackColor = True
        '
        'btnManU
        '
        Me.btnManU.Location = New System.Drawing.Point(166, 137)
        Me.btnManU.Name = "btnManU"
        Me.btnManU.Size = New System.Drawing.Size(125, 52)
        Me.btnManU.TabIndex = 2
        Me.btnManU.Text = "Manchester United"
        Me.btnManU.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(309, 137)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(125, 52)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnArsenal
        '
        Me.btnArsenal.Location = New System.Drawing.Point(26, 215)
        Me.btnArsenal.Name = "btnArsenal"
        Me.btnArsenal.Size = New System.Drawing.Size(125, 52)
        Me.btnArsenal.TabIndex = 4
        Me.btnArsenal.Text = "Arsenal"
        Me.btnArsenal.UseVisualStyleBackColor = True
        '
        'btnNetherlands
        '
        Me.btnNetherlands.Location = New System.Drawing.Point(166, 215)
        Me.btnNetherlands.Name = "btnNetherlands"
        Me.btnNetherlands.Size = New System.Drawing.Size(125, 52)
        Me.btnNetherlands.TabIndex = 5
        Me.btnNetherlands.Text = "Netherlands"
        Me.btnNetherlands.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 311)
        Me.Controls.Add(Me.btnNetherlands)
        Me.Controls.Add(Me.btnArsenal)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnManU)
        Me.Controls.Add(Me.btnChelsea)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnChelsea As System.Windows.Forms.Button
    Friend WithEvents btnManU As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnArsenal As System.Windows.Forms.Button
    Friend WithEvents btnNetherlands As System.Windows.Forms.Button

End Class
