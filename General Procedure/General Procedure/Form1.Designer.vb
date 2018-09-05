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
        Me.btn01 = New System.Windows.Forms.Button
        Me.btn02 = New System.Windows.Forms.Button
        Me.btn03 = New System.Windows.Forms.Button
        Me.lstbox01 = New System.Windows.Forms.ListBox
        Me.txtbox01 = New System.Windows.Forms.TextBox
        Me.txtbox02 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btn01
        '
        Me.btn01.Location = New System.Drawing.Point(131, 82)
        Me.btn01.Name = "btn01"
        Me.btn01.Size = New System.Drawing.Size(75, 23)
        Me.btn01.TabIndex = 0
        Me.btn01.Text = "Button1"
        Me.btn01.UseVisualStyleBackColor = True
        '
        'btn02
        '
        Me.btn02.Location = New System.Drawing.Point(213, 82)
        Me.btn02.Name = "btn02"
        Me.btn02.Size = New System.Drawing.Size(75, 23)
        Me.btn02.TabIndex = 1
        Me.btn02.Text = "Button2"
        Me.btn02.UseVisualStyleBackColor = True
        '
        'btn03
        '
        Me.btn03.Location = New System.Drawing.Point(295, 82)
        Me.btn03.Name = "btn03"
        Me.btn03.Size = New System.Drawing.Size(75, 23)
        Me.btn03.TabIndex = 2
        Me.btn03.Text = "Button3"
        Me.btn03.UseVisualStyleBackColor = True
        '
        'lstbox01
        '
        Me.lstbox01.FormattingEnabled = True
        Me.lstbox01.Location = New System.Drawing.Point(131, 140)
        Me.lstbox01.Name = "lstbox01"
        Me.lstbox01.Size = New System.Drawing.Size(239, 160)
        Me.lstbox01.TabIndex = 3
        '
        'txtbox01
        '
        Me.txtbox01.Location = New System.Drawing.Point(131, 114)
        Me.txtbox01.Name = "txtbox01"
        Me.txtbox01.Size = New System.Drawing.Size(100, 20)
        Me.txtbox01.TabIndex = 4
        '
        'txtbox02
        '
        Me.txtbox02.Location = New System.Drawing.Point(270, 114)
        Me.txtbox02.Name = "txtbox02"
        Me.txtbox02.Size = New System.Drawing.Size(100, 20)
        Me.txtbox02.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 368)
        Me.Controls.Add(Me.txtbox02)
        Me.Controls.Add(Me.txtbox01)
        Me.Controls.Add(Me.lstbox01)
        Me.Controls.Add(Me.btn03)
        Me.Controls.Add(Me.btn02)
        Me.Controls.Add(Me.btn01)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn01 As System.Windows.Forms.Button
    Friend WithEvents btn02 As System.Windows.Forms.Button
    Friend WithEvents btn03 As System.Windows.Forms.Button
    Friend WithEvents lstbox01 As System.Windows.Forms.ListBox
    Friend WithEvents txtbox01 As System.Windows.Forms.TextBox
    Friend WithEvents txtbox02 As System.Windows.Forms.TextBox

End Class
