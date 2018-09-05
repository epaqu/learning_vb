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
        Me.btnCal = New System.Windows.Forms.Button
        Me.lstboxKind = New System.Windows.Forms.ListBox
        Me.txtboxFirst = New System.Windows.Forms.TextBox
        Me.lblFirst = New System.Windows.Forms.Label
        Me.lblCalArea = New System.Windows.Forms.Label
        Me.lblSecond = New System.Windows.Forms.Label
        Me.txtboxSecond = New System.Windows.Forms.TextBox
        Me.lblAnswer = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCal
        '
        Me.btnCal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.Location = New System.Drawing.Point(410, 43)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(101, 95)
        Me.btnCal.TabIndex = 3
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'lstboxKind
        '
        Me.lstboxKind.FormattingEnabled = True
        Me.lstboxKind.Items.AddRange(New Object() {"Square", "Rectangle", "Triangle", "Circle"})
        Me.lstboxKind.Location = New System.Drawing.Point(17, 43)
        Me.lstboxKind.Name = "lstboxKind"
        Me.lstboxKind.Size = New System.Drawing.Size(148, 95)
        Me.lstboxKind.TabIndex = 0
        '
        'txtboxFirst
        '
        Me.txtboxFirst.Location = New System.Drawing.Point(247, 59)
        Me.txtboxFirst.Name = "txtboxFirst"
        Me.txtboxFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtboxFirst.TabIndex = 1
        Me.txtboxFirst.Visible = False
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(213, 66)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(28, 13)
        Me.lblFirst.TabIndex = 4
        Me.lblFirst.Text = "Side"
        Me.lblFirst.Visible = False
        '
        'lblCalArea
        '
        Me.lblCalArea.AutoSize = True
        Me.lblCalArea.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalArea.Location = New System.Drawing.Point(175, 9)
        Me.lblCalArea.Name = "lblCalArea"
        Me.lblCalArea.Size = New System.Drawing.Size(205, 26)
        Me.lblCalArea.TabIndex = 6
        Me.lblCalArea.Text = "Calculate the Area"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(203, 115)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(38, 13)
        Me.lblSecond.TabIndex = 5
        Me.lblSecond.Text = "Height"
        Me.lblSecond.Visible = False
        '
        'txtboxSecond
        '
        Me.txtboxSecond.Location = New System.Drawing.Point(247, 108)
        Me.txtboxSecond.Name = "txtboxSecond"
        Me.txtboxSecond.Size = New System.Drawing.Size(100, 20)
        Me.txtboxSecond.TabIndex = 2
        Me.txtboxSecond.Visible = False
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(76, 173)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 17)
        Me.lblAnswer.TabIndex = 7
        Me.lblAnswer.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 233)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtboxSecond)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblCalArea)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtboxFirst)
        Me.Controls.Add(Me.lstboxKind)
        Me.Controls.Add(Me.btnCal)
        Me.Name = "Form1"
        Me.Text = "Jaewoo An"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents lstboxKind As System.Windows.Forms.ListBox
    Friend WithEvents txtboxFirst As System.Windows.Forms.TextBox
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblCalArea As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents txtboxSecond As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
