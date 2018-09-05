<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblParts
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
        Me.lblCustom = New System.Windows.Forms.Label
        Me.lblLabor = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCustom = New System.Windows.Forms.TextBox
        Me.txtLabor = New System.Windows.Forms.TextBox
        Me.txtParts = New System.Windows.Forms.TextBox
        Me.lstboxBill = New System.Windows.Forms.ListBox
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblCustom
        '
        Me.lblCustom.AutoSize = True
        Me.lblCustom.Location = New System.Drawing.Point(89, 20)
        Me.lblCustom.Name = "lblCustom"
        Me.lblCustom.Size = New System.Drawing.Size(54, 13)
        Me.lblCustom.TabIndex = 0
        Me.lblCustom.Text = "Customer:"
        '
        'lblLabor
        '
        Me.lblLabor.AutoSize = True
        Me.lblLabor.Location = New System.Drawing.Point(63, 47)
        Me.lblLabor.Name = "lblLabor"
        Me.lblLabor.Size = New System.Drawing.Size(80, 13)
        Me.lblLabor.TabIndex = 1
        Me.lblLabor.Text = "Hours of Labor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost of parts and supplies:"
        '
        'txtCustom
        '
        Me.txtCustom.Location = New System.Drawing.Point(149, 17)
        Me.txtCustom.Name = "txtCustom"
        Me.txtCustom.Size = New System.Drawing.Size(177, 20)
        Me.txtCustom.TabIndex = 3
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(149, 44)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(74, 20)
        Me.txtLabor.TabIndex = 4
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(149, 72)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(74, 20)
        Me.txtParts.TabIndex = 5
        '
        'lstboxBill
        '
        Me.lstboxBill.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxBill.FormattingEnabled = True
        Me.lstboxBill.ItemHeight = 16
        Me.lstboxBill.Location = New System.Drawing.Point(15, 98)
        Me.lstboxBill.Name = "lstboxBill"
        Me.lstboxBill.Size = New System.Drawing.Size(311, 68)
        Me.lstboxBill.TabIndex = 6
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(250, 47)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(76, 41)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display Bill"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 200)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lstboxBill)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.txtLabor)
        Me.Controls.Add(Me.txtCustom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLabor)
        Me.Controls.Add(Me.lblCustom)
        Me.Name = "lblParts"
        Me.Text = "An's Auto Repair"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustom As System.Windows.Forms.Label
    Friend WithEvents lblLabor As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustom As System.Windows.Forms.TextBox
    Friend WithEvents txtLabor As System.Windows.Forms.TextBox
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents lstboxBill As System.Windows.Forms.ListBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button

End Class
