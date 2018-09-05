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
        Me.lstboxChoose = New System.Windows.Forms.ListBox
        Me.txtbox1 = New System.Windows.Forms.TextBox
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.txtbox2 = New System.Windows.Forms.TextBox
        Me.lblResult = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(180, 162)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 39)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lstboxChoose
        '
        Me.lstboxChoose.FormattingEnabled = True
        Me.lstboxChoose.Items.AddRange(New Object() {"Square", "Rectangle", "Triangle", "Circle"})
        Me.lstboxChoose.Location = New System.Drawing.Point(12, 78)
        Me.lstboxChoose.Name = "lstboxChoose"
        Me.lstboxChoose.Size = New System.Drawing.Size(91, 69)
        Me.lstboxChoose.TabIndex = 0
        '
        'txtbox1
        '
        Me.txtbox1.Location = New System.Drawing.Point(180, 78)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(100, 20)
        Me.txtbox1.TabIndex = 1
        Me.txtbox1.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(187, 62)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(28, 13)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Side"
        Me.lbl1.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(46, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(205, 26)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Calculate the Area"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(187, 105)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(38, 13)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "Height"
        Me.lbl2.Visible = False
        '
        'txtbox2
        '
        Me.txtbox2.Location = New System.Drawing.Point(180, 121)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(100, 20)
        Me.txtbox2.TabIndex = 2
        Me.txtbox2.Visible = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(24, 227)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(40, 13)
        Me.lblResult.TabIndex = 7
        Me.lblResult.Text = "LABEL"
        Me.lblResult.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.lstboxChoose)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "Form1"
        Me.Text = "Jaewoo An"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents lstboxChoose As System.Windows.Forms.ListBox
    Friend WithEvents txtbox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txtbox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
