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
        Me.btnRectangles = New System.Windows.Forms.Button()
        Me.btnCircles = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnTriangles = New System.Windows.Forms.Button()
        Me.btnCurrency = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRectangles
        '
        Me.btnRectangles.Location = New System.Drawing.Point(41, 63)
        Me.btnRectangles.Name = "btnRectangles"
        Me.btnRectangles.Size = New System.Drawing.Size(151, 49)
        Me.btnRectangles.TabIndex = 0
        Me.btnRectangles.Text = "Rectangle"
        Me.btnRectangles.UseVisualStyleBackColor = True
        '
        'btnCircles
        '
        Me.btnCircles.Location = New System.Drawing.Point(41, 123)
        Me.btnCircles.Name = "btnCircles"
        Me.btnCircles.Size = New System.Drawing.Size(151, 49)
        Me.btnCircles.TabIndex = 1
        Me.btnCircles.Text = "Circle"
        Me.btnCircles.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(239, 63)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(268, 247)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTriangles
        '
        Me.btnTriangles.Location = New System.Drawing.Point(41, 188)
        Me.btnTriangles.Name = "btnTriangles"
        Me.btnTriangles.Size = New System.Drawing.Size(151, 49)
        Me.btnTriangles.TabIndex = 3
        Me.btnTriangles.Text = "Triangle"
        Me.btnTriangles.UseVisualStyleBackColor = True
        '
        'btnCurrency
        '
        Me.btnCurrency.Location = New System.Drawing.Point(41, 261)
        Me.btnCurrency.Name = "btnCurrency"
        Me.btnCurrency.Size = New System.Drawing.Size(151, 49)
        Me.btnCurrency.TabIndex = 4
        Me.btnCurrency.Text = "Currency Exchange"
        Me.btnCurrency.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 351)
        Me.Controls.Add(Me.btnCurrency)
        Me.Controls.Add(Me.btnTriangles)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCircles)
        Me.Controls.Add(Me.btnRectangles)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRectangles As System.Windows.Forms.Button
    Friend WithEvents btnCircles As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnTriangles As System.Windows.Forms.Button
    Friend WithEvents btnCurrency As System.Windows.Forms.Button

End Class
