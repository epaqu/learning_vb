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
        Me.btnQ21 = New System.Windows.Forms.Button
        Me.btnQ22 = New System.Windows.Forms.Button
        Me.lstbox1 = New System.Windows.Forms.ListBox
        Me.btnQ19 = New System.Windows.Forms.Button
        Me.btnQ20 = New System.Windows.Forms.Button
        Me.lblTitle = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnQ21
        '
        Me.btnQ21.Location = New System.Drawing.Point(12, 66)
        Me.btnQ21.Name = "btnQ21"
        Me.btnQ21.Size = New System.Drawing.Size(75, 23)
        Me.btnQ21.TabIndex = 0
        Me.btnQ21.Text = "Q21"
        Me.btnQ21.UseVisualStyleBackColor = True
        '
        'btnQ22
        '
        Me.btnQ22.Location = New System.Drawing.Point(197, 66)
        Me.btnQ22.Name = "btnQ22"
        Me.btnQ22.Size = New System.Drawing.Size(75, 23)
        Me.btnQ22.TabIndex = 1
        Me.btnQ22.Text = "Q22"
        Me.btnQ22.UseVisualStyleBackColor = True
        '
        'lstbox1
        '
        Me.lstbox1.FormattingEnabled = True
        Me.lstbox1.Location = New System.Drawing.Point(8, 95)
        Me.lstbox1.Name = "lstbox1"
        Me.lstbox1.Size = New System.Drawing.Size(264, 147)
        Me.lstbox1.TabIndex = 2
        '
        'btnQ19
        '
        Me.btnQ19.Location = New System.Drawing.Point(12, 37)
        Me.btnQ19.Name = "btnQ19"
        Me.btnQ19.Size = New System.Drawing.Size(75, 23)
        Me.btnQ19.TabIndex = 3
        Me.btnQ19.Text = "Q19"
        Me.btnQ19.UseVisualStyleBackColor = True
        '
        'btnQ20
        '
        Me.btnQ20.Location = New System.Drawing.Point(197, 37)
        Me.btnQ20.Name = "btnQ20"
        Me.btnQ20.Size = New System.Drawing.Size(75, 23)
        Me.btnQ20.TabIndex = 4
        Me.btnQ20.Text = "Q20"
        Me.btnQ20.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(56, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(174, 24)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Pg279 Homework"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnQ20)
        Me.Controls.Add(Me.btnQ19)
        Me.Controls.Add(Me.lstbox1)
        Me.Controls.Add(Me.btnQ22)
        Me.Controls.Add(Me.btnQ21)
        Me.Name = "Form1"
        Me.Text = "Jaewoo An"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQ21 As System.Windows.Forms.Button
    Friend WithEvents btnQ22 As System.Windows.Forms.Button
    Friend WithEvents lstbox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnQ19 As System.Windows.Forms.Button
    Friend WithEvents btnQ20 As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
