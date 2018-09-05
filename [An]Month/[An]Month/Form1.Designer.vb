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
        Me.lstboxMonth = New System.Windows.Forms.ListBox
        Me.lblResponse = New System.Windows.Forms.Label
        Me.btnYes = New System.Windows.Forms.Button
        Me.btnNo = New System.Windows.Forms.Button
        Me.lblQuestion = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lstboxMonth
        '
        Me.lstboxMonth.FormattingEnabled = True
        Me.lstboxMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.lstboxMonth.Location = New System.Drawing.Point(26, 30)
        Me.lstboxMonth.Name = "lstboxMonth"
        Me.lstboxMonth.Size = New System.Drawing.Size(120, 212)
        Me.lstboxMonth.TabIndex = 0
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Location = New System.Drawing.Point(72, 274)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(55, 13)
        Me.lblResponse.TabIndex = 1
        Me.lblResponse.Text = "Response"
        Me.lblResponse.Visible = False
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(207, 108)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 2
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        Me.btnYes.Visible = False
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(289, 108)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        Me.btnNo.Visible = False
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(207, 89)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(84, 13)
        Me.lblQuestion.TabIndex = 4
        Me.lblQuestion.Text = "Is it a leap year?"
        Me.lblQuestion.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 324)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.lstboxMonth)
        Me.Name = "Form1"
        Me.Text = "An"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstboxMonth As System.Windows.Forms.ListBox
    Friend WithEvents lblResponse As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents lblQuestion As System.Windows.Forms.Label

End Class
