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
        Me.btnRed = New System.Windows.Forms.Button
        Me.btnBlue = New System.Windows.Forms.Button
        Me.btnGreen = New System.Windows.Forms.Button
        Me.txtOne = New System.Windows.Forms.TextBox
        Me.txtTwo = New System.Windows.Forms.TextBox
        Me.btnViolet = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.txtThree = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(352, 118)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(75, 23)
        Me.btnRed.TabIndex = 3
        Me.btnRed.Text = "Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'btnBlue
        '
        Me.btnBlue.Location = New System.Drawing.Point(352, 147)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnBlue.TabIndex = 4
        Me.btnBlue.Text = "Blue"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'btnGreen
        '
        Me.btnGreen.Location = New System.Drawing.Point(352, 176)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(75, 23)
        Me.btnGreen.TabIndex = 5
        Me.btnGreen.Text = "Green"
        Me.btnGreen.UseVisualStyleBackColor = True
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(197, 178)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(100, 20)
        Me.txtOne.TabIndex = 1
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(197, 236)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtTwo.TabIndex = 2
        '
        'btnViolet
        '
        Me.btnViolet.Location = New System.Drawing.Point(352, 205)
        Me.btnViolet.Name = "btnViolet"
        Me.btnViolet.Size = New System.Drawing.Size(75, 23)
        Me.btnViolet.TabIndex = 6
        Me.btnViolet.Text = "Violet"
        Me.btnViolet.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(352, 234)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtThree
        '
        Me.txtThree.Location = New System.Drawing.Point(197, 120)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.Size = New System.Drawing.Size(100, 20)
        Me.txtThree.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 529)
        Me.Controls.Add(Me.txtThree)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnViolet)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtOne)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.btnRed)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRed As System.Windows.Forms.Button
    Friend WithEvents btnBlue As System.Windows.Forms.Button
    Friend WithEvents btnGreen As System.Windows.Forms.Button
    Friend WithEvents txtOne As System.Windows.Forms.TextBox
    Friend WithEvents txtTwo As System.Windows.Forms.TextBox
    Friend WithEvents btnViolet As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtThree As System.Windows.Forms.TextBox

End Class
