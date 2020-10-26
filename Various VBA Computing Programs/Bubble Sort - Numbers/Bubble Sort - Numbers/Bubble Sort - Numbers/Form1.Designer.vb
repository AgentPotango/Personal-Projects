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
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.Display = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.chkDesc = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(46, 45)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(177, 63)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup Arrays"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'Display
        '
        Me.Display.Location = New System.Drawing.Point(283, 56)
        Me.Display.Multiline = True
        Me.Display.Name = "Display"
        Me.Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Display.Size = New System.Drawing.Size(210, 342)
        Me.Display.TabIndex = 1
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(48, 150)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(174, 69)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "Bubble Sort - Numbers"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'chkDesc
        '
        Me.chkDesc.AutoSize = True
        Me.chkDesc.Location = New System.Drawing.Point(73, 253)
        Me.chkDesc.Name = "chkDesc"
        Me.chkDesc.Size = New System.Drawing.Size(112, 17)
        Me.chkDesc.TabIndex = 3
        Me.chkDesc.Text = "Descending Order"
        Me.chkDesc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 422)
        Me.Controls.Add(Me.chkDesc)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents Display As System.Windows.Forms.TextBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents chkDesc As System.Windows.Forms.CheckBox

End Class
