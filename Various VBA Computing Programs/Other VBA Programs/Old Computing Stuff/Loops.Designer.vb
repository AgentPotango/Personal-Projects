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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnAnyTimesTable = New System.Windows.Forms.Button()
        Me.Alphabet = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAsciicodes = New System.Windows.Forms.Button()
        Me.btnnumber = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblOutput.Location = New System.Drawing.Point(281, 48)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(188, 349)
        Me.lblOutput.TabIndex = 0
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnyTimesTable
        '
        Me.btnAnyTimesTable.Location = New System.Drawing.Point(27, 47)
        Me.btnAnyTimesTable.Name = "btnAnyTimesTable"
        Me.btnAnyTimesTable.Size = New System.Drawing.Size(218, 46)
        Me.btnAnyTimesTable.TabIndex = 1
        Me.btnAnyTimesTable.Text = "Any Times Table"
        Me.btnAnyTimesTable.UseVisualStyleBackColor = True
        '
        'Alphabet
        '
        Me.Alphabet.Location = New System.Drawing.Point(27, 110)
        Me.Alphabet.Name = "Alphabet"
        Me.Alphabet.Size = New System.Drawing.Size(218, 46)
        Me.Alphabet.TabIndex = 2
        Me.Alphabet.Text = "Alphabet"
        Me.Alphabet.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Integers Task"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAsciicodes
        '
        Me.btnAsciicodes.Location = New System.Drawing.Point(27, 248)
        Me.btnAsciicodes.Name = "btnAsciicodes"
        Me.btnAsciicodes.Size = New System.Drawing.Size(218, 46)
        Me.btnAsciicodes.TabIndex = 4
        Me.btnAsciicodes.Text = "Ascii Codes"
        Me.btnAsciicodes.UseVisualStyleBackColor = True
        '
        'btnnumber
        '
        Me.btnnumber.Location = New System.Drawing.Point(27, 314)
        Me.btnnumber.Name = "btnnumber"
        Me.btnnumber.Size = New System.Drawing.Size(218, 46)
        Me.btnnumber.TabIndex = 5
        Me.btnnumber.Text = "Numberz"
        Me.btnnumber.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 453)
        Me.Controls.Add(Me.btnnumber)
        Me.Controls.Add(Me.btnAsciicodes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Alphabet)
        Me.Controls.Add(Me.btnAnyTimesTable)
        Me.Controls.Add(Me.lblOutput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnAnyTimesTable As System.Windows.Forms.Button
    Friend WithEvents Alphabet As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAsciicodes As System.Windows.Forms.Button
    Friend WithEvents btnnumber As System.Windows.Forms.Button

End Class
