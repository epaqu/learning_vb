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
        Me.btnTest = New System.Windows.Forms.Button
        Me.lblQuestion = New System.Windows.Forms.Label
        Me.btnTrue = New System.Windows.Forms.Button
        Me.btnFalse = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(12, 12)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(221, 87)
        Me.btnTest.TabIndex = 0
        Me.btnTest.Text = "Start Testing"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(12, 23)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(17, 13)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "lbl"
        Me.lblQuestion.Visible = False
        '
        'btnTrue
        '
        Me.btnTrue.Location = New System.Drawing.Point(158, 66)
        Me.btnTrue.Name = "btnTrue"
        Me.btnTrue.Size = New System.Drawing.Size(75, 23)
        Me.btnTrue.TabIndex = 2
        Me.btnTrue.Text = "True"
        Me.btnTrue.UseVisualStyleBackColor = True
        Me.btnTrue.Visible = False
        '
        'btnFalse
        '
        Me.btnFalse.Location = New System.Drawing.Point(158, 95)
        Me.btnFalse.Name = "btnFalse"
        Me.btnFalse.Size = New System.Drawing.Size(75, 23)
        Me.btnFalse.TabIndex = 3
        Me.btnFalse.Text = "False"
        Me.btnFalse.UseVisualStyleBackColor = True
        Me.btnFalse.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 130)
        Me.Controls.Add(Me.btnFalse)
        Me.Controls.Add(Me.btnTrue)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnTest)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnTrue As System.Windows.Forms.Button
    Friend WithEvents btnFalse As System.Windows.Forms.Button

End Class
