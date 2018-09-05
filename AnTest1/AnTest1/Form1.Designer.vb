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
        Me.btnred = New System.Windows.Forms.Button
        Me.btnwhite = New System.Windows.Forms.Button
        Me.btnblue = New System.Windows.Forms.Button
        Me.btngreen = New System.Windows.Forms.Button
        Me.btndis1 = New System.Windows.Forms.Button
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.btndis2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnred
        '
        Me.btnred.Location = New System.Drawing.Point(38, 45)
        Me.btnred.Name = "btnred"
        Me.btnred.Size = New System.Drawing.Size(75, 23)
        Me.btnred.TabIndex = 0
        Me.btnred.Text = "Red"
        Me.btnred.UseVisualStyleBackColor = True
        '
        'btnwhite
        '
        Me.btnwhite.Location = New System.Drawing.Point(38, 75)
        Me.btnwhite.Name = "btnwhite"
        Me.btnwhite.Size = New System.Drawing.Size(75, 23)
        Me.btnwhite.TabIndex = 1
        Me.btnwhite.Text = "White"
        Me.btnwhite.UseVisualStyleBackColor = True
        '
        'btnblue
        '
        Me.btnblue.Location = New System.Drawing.Point(167, 45)
        Me.btnblue.Name = "btnblue"
        Me.btnblue.Size = New System.Drawing.Size(75, 23)
        Me.btnblue.TabIndex = 2
        Me.btnblue.Text = "Blue"
        Me.btnblue.UseVisualStyleBackColor = True
        '
        'btngreen
        '
        Me.btngreen.Location = New System.Drawing.Point(167, 75)
        Me.btngreen.Name = "btngreen"
        Me.btngreen.Size = New System.Drawing.Size(75, 23)
        Me.btngreen.TabIndex = 3
        Me.btngreen.Text = "Green"
        Me.btngreen.UseVisualStyleBackColor = True
        '
        'btndis1
        '
        Me.btndis1.Location = New System.Drawing.Point(38, 175)
        Me.btndis1.Name = "btndis1"
        Me.btndis1.Size = New System.Drawing.Size(75, 23)
        Me.btndis1.TabIndex = 4
        Me.btndis1.Text = "Disappear"
        Me.btndis1.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(38, 127)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(204, 20)
        Me.txt1.TabIndex = 5
        '
        'btndis2
        '
        Me.btndis2.Location = New System.Drawing.Point(167, 175)
        Me.btndis2.Name = "btndis2"
        Me.btndis2.Size = New System.Drawing.Size(75, 23)
        Me.btndis2.TabIndex = 6
        Me.btndis2.Text = "Disappear"
        Me.btndis2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btndis2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btndis1)
        Me.Controls.Add(Me.btngreen)
        Me.Controls.Add(Me.btnblue)
        Me.Controls.Add(Me.btnwhite)
        Me.Controls.Add(Me.btnred)
        Me.Name = "Form1"
        Me.Text = "An"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnred As System.Windows.Forms.Button
    Friend WithEvents btnwhite As System.Windows.Forms.Button
    Friend WithEvents btnblue As System.Windows.Forms.Button
    Friend WithEvents btngreen As System.Windows.Forms.Button
    Friend WithEvents btndis1 As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents btndis2 As System.Windows.Forms.Button

End Class
