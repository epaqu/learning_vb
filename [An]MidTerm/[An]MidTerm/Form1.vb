Public Class Form1
    Dim dblFirst, dblSecond, dblResult As Double

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl1.Click

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        If lstboxChoose.SelectedIndex = -1 Then
            lblResult.Text = "Please select a shape."
            lblResult.Visible = True
        ElseIf IsNumeric(txtbox1.Text) Then
            If lstboxChoose.SelectedIndex = 0 Then
                dblFirst = CDbl(txtbox1.Text)
                dblResult = dblFirst ^ 2
                lblResult.Visible = True
                lblResult.Text = "The area of the square is " & dblResult
            ElseIf lstboxChoose.SelectedIndex = 1 Then
                If IsNumeric(txtbox2.Text) Then
                    dblFirst = CDbl(txtbox1.Text)
                    dblSecond = CDbl(txtbox2.Text)
                    dblResult = dblFirst * dblSecond
                    lblResult.Visible = True
                    lblResult.Text = "The area of the rectangle is " & dblResult
                Else
                    lblResult.Visible = True
                    lblResult.Text = "Please enter a number."
                End If
            ElseIf lstboxChoose.SelectedIndex = 2 Then
                If IsNumeric(txtbox2.Text) Then
                    dblFirst = CDbl(txtbox1.Text)
                    dblSecond = CDbl(txtbox2.Text)
                    dblResult = (dblFirst * dblSecond) / 2
                    lblResult.Visible = True
                    lblResult.Text = "The area of the triangle is " & dblResult
                Else
                    lblResult.Visible = True
                    lblResult.Text = "Please enter a number."
                End If
            ElseIf lstboxChoose.SelectedIndex = 3 Then
                dblFirst = CDbl(txtbox1.Text)
                dblSecond = CDbl(txtbox2.Text)
                dblResult = 3.1417 * (dblFirst ^ 2)
                lblResult.Visible = True
                lblResult.Text = "The area of the circle is " & dblResult
            End If
        Else
            lblResult.Visible = True
            lblResult.Text = "Please enter a number."
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstboxChoose_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstboxChoose.SelectedIndexChanged
        If lstboxChoose.SelectedIndex = 0 Then
            lbl1.Text = "Side"
            lbl1.Visible = True
            txtbox1.Visible = True
            lbl2.Visible = False
            txtbox2.Visible = False
            lblResult.Text = " "
        End If
        If lstboxChoose.SelectedIndex = 1 Then
            lbl1.Text = "Width"
            lbl2.Text = "Height"
            lbl1.Visible = True
            txtbox1.Visible = True
            lbl2.Visible = True
            txtbox2.Visible = True
            lblResult.Text = " "
        End If
        If lstboxChoose.SelectedIndex = 2 Then
            lbl1.Text = "Base"
            lbl2.Text = "Height"
            lbl1.Visible = True
            txtbox1.Visible = True
            lbl2.Visible = True
            txtbox2.Visible = True
            lblResult.Text = " "
        End If
        If lstboxChoose.SelectedIndex = 3 Then
            lbl1.Text = "Radius"
            lbl1.Visible = True
            txtbox1.Visible = True
            lbl2.Visible = False
            txtbox2.Visible = False
            lblResult.Text = " "
        End If
    End Sub
End Class
