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
        Me.lstbox1 = New System.Windows.Forms.ListBox
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.btn1 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstbox1
        '
        Me.lstbox1.FormattingEnabled = True
        Me.lstbox1.Location = New System.Drawing.Point(3, 68)
        Me.lstbox1.Name = "lstbox1"
        Me.lstbox1.Size = New System.Drawing.Size(120, 186)
        Me.lstbox1.TabIndex = 3
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(146, 156)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(171, 182)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Add"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(171, 211)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 4
        Me.btn2.Text = "Clear"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lstbox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstbox1 As System.Windows.Forms.ListBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button

End Class
