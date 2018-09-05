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
        Me.btnTri = New System.Windows.Forms.Button
        Me.btnEvenSum = New System.Windows.Forms.Button
        Me.lblboxResult = New System.Windows.Forms.ListBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnTri
        '
        Me.btnTri.Location = New System.Drawing.Point(42, 59)
        Me.btnTri.Name = "btnTri"
        Me.btnTri.Size = New System.Drawing.Size(75, 23)
        Me.btnTri.TabIndex = 0
        Me.btnTri.Text = "Triangle"
        Me.btnTri.UseVisualStyleBackColor = True
        '
        'btnEvenSum
        '
        Me.btnEvenSum.Location = New System.Drawing.Point(161, 59)
        Me.btnEvenSum.Name = "btnEvenSum"
        Me.btnEvenSum.Size = New System.Drawing.Size(75, 23)
        Me.btnEvenSum.TabIndex = 1
        Me.btnEvenSum.Text = "Sum"
        Me.btnEvenSum.UseVisualStyleBackColor = True
        '
        'lblboxResult
        '
        Me.lblboxResult.FormattingEnabled = True
        Me.lblboxResult.Location = New System.Drawing.Point(12, 88)
        Me.lblboxResult.Name = "lblboxResult"
        Me.lblboxResult.Size = New System.Drawing.Size(260, 173)
        Me.lblboxResult.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(90, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(102, 25)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Test 4 Q"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblboxResult)
        Me.Controls.Add(Me.btnEvenSum)
        Me.Controls.Add(Me.btnTri)
        Me.Name = "Form1"
        Me.Text = "Jaewoo An"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTri As System.Windows.Forms.Button
    Friend WithEvents btnEvenSum As System.Windows.Forms.Button
    Friend WithEvents lblboxResult As System.Windows.Forms.ListBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
