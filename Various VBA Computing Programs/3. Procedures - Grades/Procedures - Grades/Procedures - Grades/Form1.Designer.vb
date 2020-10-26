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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComp1 = New System.Windows.Forms.TextBox()
        Me.txtComp2 = New System.Windows.Forms.TextBox()
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comp 1 (Max 100)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comp 2 (Max 60)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtComp1
        '
        Me.txtComp1.Location = New System.Drawing.Point(201, 64)
        Me.txtComp1.Name = "txtComp1"
        Me.txtComp1.Size = New System.Drawing.Size(179, 20)
        Me.txtComp1.TabIndex = 2
        '
        'txtComp2
        '
        Me.txtComp2.Location = New System.Drawing.Point(201, 128)
        Me.txtComp2.Name = "txtComp2"
        Me.txtComp2.Size = New System.Drawing.Size(179, 20)
        Me.txtComp2.TabIndex = 3
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(48, 190)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(124, 45)
        Me.btnGrade.TabIndex = 4
        Me.btnGrade.Text = "Calculate Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(202, 187)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(177, 60)
        Me.lblDisplay.TabIndex = 5
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 319)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnGrade)
        Me.Controls.Add(Me.txtComp2)
        Me.Controls.Add(Me.txtComp1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtComp1 As System.Windows.Forms.TextBox
    Friend WithEvents txtComp2 As System.Windows.Forms.TextBox
    Friend WithEvents btnGrade As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
