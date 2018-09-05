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
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblPizza = New System.Windows.Forms.Label
        Me.lblFries = New System.Windows.Forms.Label
        Me.lblDrink = New System.Windows.Forms.Label
        Me.lstbox1 = New System.Windows.Forms.ListBox
        Me.txtboxPizza = New System.Windows.Forms.TextBox
        Me.txtboxFries = New System.Windows.Forms.TextBox
        Me.txtboxDrink = New System.Windows.Forms.TextBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(246, 62)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(148, 31)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Compute Total Cost"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(246, 103)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(148, 31)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblPizza
        '
        Me.lblPizza.AutoSize = True
        Me.lblPizza.Location = New System.Drawing.Point(20, 65)
        Me.lblPizza.Name = "lblPizza"
        Me.lblPizza.Size = New System.Drawing.Size(131, 13)
        Me.lblPizza.TabIndex = 5
        Me.lblPizza.Text = "How many slices of pizza?"
        '
        'lblFries
        '
        Me.lblFries.AutoSize = True
        Me.lblFries.Location = New System.Drawing.Point(20, 91)
        Me.lblFries.Name = "lblFries"
        Me.lblFries.Size = New System.Drawing.Size(85, 13)
        Me.lblFries.TabIndex = 6
        Me.lblFries.Text = "How many fries?"
        '
        'lblDrink
        '
        Me.lblDrink.AutoSize = True
        Me.lblDrink.Location = New System.Drawing.Point(20, 117)
        Me.lblDrink.Name = "lblDrink"
        Me.lblDrink.Size = New System.Drawing.Size(114, 13)
        Me.lblDrink.TabIndex = 7
        Me.lblDrink.Text = "How many soft drinks?"
        '
        'lstbox1
        '
        Me.lstbox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbox1.FormattingEnabled = True
        Me.lstbox1.ItemHeight = 14
        Me.lstbox1.Location = New System.Drawing.Point(8, 141)
        Me.lstbox1.Name = "lstbox1"
        Me.lstbox1.Size = New System.Drawing.Size(386, 102)
        Me.lstbox1.TabIndex = 8
        '
        'txtboxPizza
        '
        Me.txtboxPizza.Location = New System.Drawing.Point(157, 62)
        Me.txtboxPizza.Name = "txtboxPizza"
        Me.txtboxPizza.Size = New System.Drawing.Size(30, 20)
        Me.txtboxPizza.TabIndex = 0
        '
        'txtboxFries
        '
        Me.txtboxFries.Location = New System.Drawing.Point(157, 88)
        Me.txtboxFries.Name = "txtboxFries"
        Me.txtboxFries.Size = New System.Drawing.Size(30, 20)
        Me.txtboxFries.TabIndex = 1
        '
        'txtboxDrink
        '
        Me.txtboxDrink.Location = New System.Drawing.Point(157, 114)
        Me.txtboxDrink.Name = "txtboxDrink"
        Me.txtboxDrink.Size = New System.Drawing.Size(30, 20)
        Me.txtboxDrink.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(24, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(275, 42)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Restaurant Bill"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 264)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtboxDrink)
        Me.Controls.Add(Me.txtboxFries)
        Me.Controls.Add(Me.txtboxPizza)
        Me.Controls.Add(Me.lstbox1)
        Me.Controls.Add(Me.lblDrink)
        Me.Controls.Add(Me.lblFries)
        Me.Controls.Add(Me.lblPizza)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "Form1"
        Me.Text = "[An] Restaurant Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblPizza As System.Windows.Forms.Label
    Friend WithEvents lblFries As System.Windows.Forms.Label
    Friend WithEvents lblDrink As System.Windows.Forms.Label
    Friend WithEvents lstbox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtboxPizza As System.Windows.Forms.TextBox
    Friend WithEvents txtboxFries As System.Windows.Forms.TextBox
    Friend WithEvents txtboxDrink As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
