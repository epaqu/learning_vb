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
        Me.btnOn = New System.Windows.Forms.Button
        Me.btnOff = New System.Windows.Forms.Button
        Me.btnCalc = New System.Windows.Forms.Button
        Me.txtbox02 = New System.Windows.Forms.TextBox
        Me.txtbox01 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnOn
        '
        Me.btnOn.Location = New System.Drawing.Point(12, 65)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(75, 23)
        Me.btnOn.TabIndex = 0
        Me.btnOn.Text = "On"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Enabled = False
        Me.btnOff.Location = New System.Drawing.Point(109, 65)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(75, 23)
        Me.btnOff.TabIndex = 1
        Me.btnOff.Text = "Off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Enabled = False
        Me.btnCalc.Location = New System.Drawing.Point(205, 65)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtbox02
        '
        Me.txtbox02.Enabled = False
        Me.txtbox02.Location = New System.Drawing.Point(12, 94)
        Me.txtbox02.Name = "txtbox02"
        Me.txtbox02.Size = New System.Drawing.Size(100, 20)
        Me.txtbox02.TabIndex = 3
        '
        'txtbox01
        '
        Me.txtbox01.Enabled = False
        Me.txtbox01.Location = New System.Drawing.Point(180, 94)
        Me.txtbox01.Name = "txtbox01"
        Me.txtbox01.Size = New System.Drawing.Size(100, 20)
        Me.txtbox01.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 133)
        Me.Controls.Add(Me.txtbox01)
        Me.Controls.Add(Me.txtbox02)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnOn)
        Me.Name = "Form1"
        Me.Text = "s"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOn As System.Windows.Forms.Button
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents txtbox02 As System.Windows.Forms.TextBox
    Friend WithEvents txtbox01 As System.Windows.Forms.TextBox

End Class
