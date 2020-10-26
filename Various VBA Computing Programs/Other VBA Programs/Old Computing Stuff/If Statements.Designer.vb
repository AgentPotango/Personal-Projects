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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnQ1 = New System.Windows.Forms.Button()
        Me.btnQ2 = New System.Windows.Forms.Button()
        Me.btnQ3 = New System.Windows.Forms.Button()
        Me.btnQ4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "If Statements"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblOutput.Location = New System.Drawing.Point(301, 139)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(245, 298)
        Me.lblOutput.TabIndex = 1
        '
        'btnQ1
        '
        Me.btnQ1.Location = New System.Drawing.Point(35, 146)
        Me.btnQ1.Name = "btnQ1"
        Me.btnQ1.Size = New System.Drawing.Size(165, 59)
        Me.btnQ1.TabIndex = 2
        Me.btnQ1.Text = "Question 1"
        Me.btnQ1.UseVisualStyleBackColor = True
        '
        'btnQ2
        '
        Me.btnQ2.Location = New System.Drawing.Point(35, 223)
        Me.btnQ2.Name = "btnQ2"
        Me.btnQ2.Size = New System.Drawing.Size(165, 59)
        Me.btnQ2.TabIndex = 3
        Me.btnQ2.Text = "Question 2"
        Me.btnQ2.UseVisualStyleBackColor = True
        '
        'btnQ3
        '
        Me.btnQ3.Location = New System.Drawing.Point(35, 300)
        Me.btnQ3.Name = "btnQ3"
        Me.btnQ3.Size = New System.Drawing.Size(165, 59)
        Me.btnQ3.TabIndex = 4
        Me.btnQ3.Text = "Question 3"
        Me.btnQ3.UseVisualStyleBackColor = True
        '
        'btnQ4
        '
        Me.btnQ4.Location = New System.Drawing.Point(35, 378)
        Me.btnQ4.Name = "btnQ4"
        Me.btnQ4.Size = New System.Drawing.Size(165, 59)
        Me.btnQ4.TabIndex = 5
        Me.btnQ4.Text = "Question 4"
        Me.btnQ4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 486)
        Me.Controls.Add(Me.btnQ4)
        Me.Controls.Add(Me.btnQ3)
        Me.Controls.Add(Me.btnQ2)
        Me.Controls.Add(Me.btnQ1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnQ1 As System.Windows.Forms.Button
    Friend WithEvents btnQ2 As System.Windows.Forms.Button
    Friend WithEvents btnQ3 As System.Windows.Forms.Button
    Friend WithEvents btnQ4 As System.Windows.Forms.Button

End Class
