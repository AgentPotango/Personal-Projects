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
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.btnRectangle = New System.Windows.Forms.Button()
        Me.lblCircle = New System.Windows.Forms.Label()
        Me.lblRectangle = New System.Windows.Forms.Label()
        Me.btnTriangle = New System.Windows.Forms.Button()
        Me.lblTriangle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCircle
        '
        Me.btnCircle.Location = New System.Drawing.Point(34, 40)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(156, 51)
        Me.btnCircle.TabIndex = 0
        Me.btnCircle.Text = "Circle"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'btnRectangle
        '
        Me.btnRectangle.Location = New System.Drawing.Point(34, 137)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(156, 52)
        Me.btnRectangle.TabIndex = 1
        Me.btnRectangle.Text = "Rectangle"
        Me.btnRectangle.UseVisualStyleBackColor = True
        '
        'lblCircle
        '
        Me.lblCircle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCircle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCircle.Location = New System.Drawing.Point(248, 30)
        Me.lblCircle.Name = "lblCircle"
        Me.lblCircle.Size = New System.Drawing.Size(270, 71)
        Me.lblCircle.TabIndex = 2
        Me.lblCircle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRectangle
        '
        Me.lblRectangle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRectangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRectangle.Location = New System.Drawing.Point(248, 129)
        Me.lblRectangle.Name = "lblRectangle"
        Me.lblRectangle.Size = New System.Drawing.Size(270, 69)
        Me.lblRectangle.TabIndex = 3
        Me.lblRectangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTriangle
        '
        Me.btnTriangle.Location = New System.Drawing.Point(34, 230)
        Me.btnTriangle.Name = "btnTriangle"
        Me.btnTriangle.Size = New System.Drawing.Size(156, 52)
        Me.btnTriangle.TabIndex = 4
        Me.btnTriangle.Text = "Triangle"
        Me.btnTriangle.UseVisualStyleBackColor = True
        '
        'lblTriangle
        '
        Me.lblTriangle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTriangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTriangle.Location = New System.Drawing.Point(248, 222)
        Me.lblTriangle.Name = "lblTriangle"
        Me.lblTriangle.Size = New System.Drawing.Size(270, 69)
        Me.lblTriangle.TabIndex = 5
        Me.lblTriangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 324)
        Me.Controls.Add(Me.lblTriangle)
        Me.Controls.Add(Me.btnTriangle)
        Me.Controls.Add(Me.lblRectangle)
        Me.Controls.Add(Me.lblCircle)
        Me.Controls.Add(Me.btnRectangle)
        Me.Controls.Add(Me.btnCircle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCircle As System.Windows.Forms.Button
    Friend WithEvents btnRectangle As System.Windows.Forms.Button
    Friend WithEvents lblCircle As System.Windows.Forms.Label
    Friend WithEvents lblRectangle As System.Windows.Forms.Label
    Friend WithEvents btnTriangle As System.Windows.Forms.Button
    Friend WithEvents lblTriangle As System.Windows.Forms.Label

End Class
