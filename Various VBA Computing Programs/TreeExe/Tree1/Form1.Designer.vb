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
        Me.Output = New System.Windows.Forms.Label()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnInOrder = New System.Windows.Forms.Button()
        Me.btnPreOrder = New System.Windows.Forms.Button()
        Me.btnPostOrder = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Output
        '
        Me.Output.BackColor = System.Drawing.Color.White
        Me.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Output.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.Location = New System.Drawing.Point(32, 118)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(620, 434)
        Me.Output.TabIndex = 0
        Me.Output.Text = "Output Area"
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(32, 21)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(87, 74)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "Setup Tree"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(140, 21)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(85, 74)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Tree"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnInOrder
        '
        Me.btnInOrder.Location = New System.Drawing.Point(352, 21)
        Me.btnInOrder.Name = "btnInOrder"
        Me.btnInOrder.Size = New System.Drawing.Size(85, 74)
        Me.btnInOrder.TabIndex = 3
        Me.btnInOrder.Text = "Traverse In Order"
        Me.btnInOrder.UseVisualStyleBackColor = True
        '
        'btnPreOrder
        '
        Me.btnPreOrder.Location = New System.Drawing.Point(458, 21)
        Me.btnPreOrder.Name = "btnPreOrder"
        Me.btnPreOrder.Size = New System.Drawing.Size(85, 74)
        Me.btnPreOrder.TabIndex = 4
        Me.btnPreOrder.Text = "Traverse Pre-Order"
        Me.btnPreOrder.UseVisualStyleBackColor = True
        '
        'btnPostOrder
        '
        Me.btnPostOrder.Location = New System.Drawing.Point(564, 21)
        Me.btnPostOrder.Name = "btnPostOrder"
        Me.btnPostOrder.Size = New System.Drawing.Size(85, 74)
        Me.btnPostOrder.TabIndex = 5
        Me.btnPostOrder.Text = "Traverse Post Order"
        Me.btnPostOrder.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(246, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 74)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Tree Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(686, 582)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnPostOrder)
        Me.Controls.Add(Me.btnPreOrder)
        Me.Controls.Add(Me.btnInOrder)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.Output)
        Me.Name = "Form1"
        Me.Text = "Binary Tree"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Output As System.Windows.Forms.Label
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnInOrder As System.Windows.Forms.Button
    Friend WithEvents btnPreOrder As System.Windows.Forms.Button
    Friend WithEvents btnPostOrder As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button

End Class
