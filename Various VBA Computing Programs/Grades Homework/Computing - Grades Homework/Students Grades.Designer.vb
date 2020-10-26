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
        Me.btnStore = New System.Windows.Forms.Button()
        Me.btnAllDisplay = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStore
        '
        Me.btnStore.Location = New System.Drawing.Point(62, 75)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(167, 53)
        Me.btnStore.TabIndex = 0
        Me.btnStore.Text = " Mark and Grade Score Storage"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'btnAllDisplay
        '
        Me.btnAllDisplay.Location = New System.Drawing.Point(62, 285)
        Me.btnAllDisplay.Name = "btnAllDisplay"
        Me.btnAllDisplay.Size = New System.Drawing.Size(167, 53)
        Me.btnAllDisplay.TabIndex = 2
        Me.btnAllDisplay.Text = "Total Students Marks and Grades Display"
        Me.btnAllDisplay.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(295, 33)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplay.Size = New System.Drawing.Size(257, 399)
        Me.txtDisplay.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(62, 176)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(167, 53)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Student Search - Mark and Grade Score"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 486)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnAllDisplay)
        Me.Controls.Add(Me.btnStore)
        Me.Name = "Form1"
        Me.Text = "Students Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStore As System.Windows.Forms.Button
    Friend WithEvents btnAllDisplay As System.Windows.Forms.Button
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button

End Class
