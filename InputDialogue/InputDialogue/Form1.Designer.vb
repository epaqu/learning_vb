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
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstbox1 = New System.Windows.Forms.ListBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtbox1 = New System.Windows.Forms.TextBox
        Me.txtbox2 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(265, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstbox1
        '
        Me.lstbox1.FormattingEnabled = True
        Me.lstbox1.Location = New System.Drawing.Point(29, 69)
        Me.lstbox1.Name = "lstbox1"
        Me.lstbox1.Size = New System.Drawing.Size(230, 160)
        Me.lstbox1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(265, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtbox1
        '
        Me.txtbox1.Location = New System.Drawing.Point(346, 119)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(100, 20)
        Me.txtbox1.TabIndex = 1
        '
        'txtbox2
        '
        Me.txtbox2.Location = New System.Drawing.Point(346, 149)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(100, 20)
        Me.txtbox2.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(265, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 348)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lstbox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstbox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtbox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
