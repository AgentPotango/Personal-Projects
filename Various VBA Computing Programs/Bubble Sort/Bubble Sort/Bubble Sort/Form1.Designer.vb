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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.Display = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 43)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(124, 54)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup Arrays"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Setup Arrays"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(12, 120)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(124, 54)
        Me.btnSort.TabIndex = 1
        Me.btnSort.Text = "Bubble Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Display
        '
        Me.Display.Location = New System.Drawing.Point(197, 31)
        Me.Display.Multiline = True
        Me.Display.Name = "Display"
        Me.Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Display.Size = New System.Drawing.Size(193, 312)
        Me.Display.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 368)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "Form1"
        Me.Text = "Bubble Sort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents Display As System.Windows.Forms.TextBox

End Class
