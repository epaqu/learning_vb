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
        Me.lblEnter = New System.Windows.Forms.Label
        Me.lblResult = New System.Windows.Forms.Label
        Me.txtEnter = New System.Windows.Forms.TextBox
        Me.btnRecord = New System.Windows.Forms.Button
        Me.btnCalc = New System.Windows.Forms.Button
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(31, 19)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(73, 13)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter a score:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(44, 121)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(79, 13)
        Me.lblResult.TabIndex = 1
        Me.lblResult.Text = "Average score:"
        '
        'txtEnter
        '
        Me.txtEnter.Location = New System.Drawing.Point(110, 16)
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(39, 20)
        Me.txtEnter.TabIndex = 2
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(48, 44)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(184, 33)
        Me.btnRecord.TabIndex = 3
        Me.btnRecord.Text = "Record the Score"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(48, 83)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(184, 33)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate the Average Score"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(142, 123)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 177)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblEnter)
        Me.Name = "Form1"
        Me.Text = "Jaewoo An"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtEnter As System.Windows.Forms.TextBox
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
