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
        Me.btn1 = New System.Windows.Forms.Button
        Me.lbl01 = New System.Windows.Forms.Label
        Me.txtbox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(86, 188)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(121, 68)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Click"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lbl01
        '
        Me.lbl01.AutoSize = True
        Me.lbl01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl01.Location = New System.Drawing.Point(30, 45)
        Me.lbl01.Name = "lbl01"
        Me.lbl01.Size = New System.Drawing.Size(0, 20)
        Me.lbl01.TabIndex = 1
        '
        'txtbox1
        '
        Me.txtbox1.Location = New System.Drawing.Point(98, 162)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(100, 20)
        Me.txtbox1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.lbl01)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lbl01 As System.Windows.Forms.Label
    Friend WithEvents txtbox1 As System.Windows.Forms.TextBox

End Class
