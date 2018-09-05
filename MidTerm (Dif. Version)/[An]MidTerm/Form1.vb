Public Class Form1
    Dim dblSquare, dblRec, dblTri, dblCircle As Double

    Private Sub lstboxKind_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstboxKind.SelectedIndexChanged
        If lstboxKind.SelectedIndex = -1 Then
            lblFirst.Visible = False
            lblSecond.Visible = False
            txtboxFirst.Visible = False
            txtboxSecond.Visible = False
            lblAnswer.Visible = False
        End If
        If lstboxKind.SelectedIndex = 0 Then
            lblFirst.Text = "Side"
            lblFirst.Visible = True
            lblSecond.Visible = False
            txtboxFirst.Visible = True
            txtboxSecond.Visible = False
            lblAnswer.Text = Nothing
        End If
        If lstboxKind.SelectedIndex = 1 Then
            lblFirst.Text = "Width"
            lblSecond.Text = "Height"
            lblFirst.Visible = True
            lblSecond.Visible = True
            txtboxFirst.Visible = True
            txtboxSecond.Visible = True
            lblAnswer.Text = Nothing
        End If
        If lstboxKind.SelectedIndex = 2 Then
            lblFirst.Text = "Base"
            lblSecond.Text = "Height"
            lblFirst.Visible = True
            lblSecond.Visible = True
            txtboxFirst.Visible = True
            txtboxSecond.Visible = True
            lblAnswer.Text = Nothing
        End If
        If lstboxKind.SelectedIndex = 3 Then
            lblFirst.Text = "Radius"
            lblFirst.Visible = True
            lblSecond.Visible = False
            txtboxFirst.Visible = True
            txtboxSecond.Visible = False
            lblAnswer.Text = Nothing
        End If
    End Sub

    Private Sub btnCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCal.Click
        If lstboxKind.SelectedIndex = -1 Then
            lblAnswer.Text = "Please select a shape."
            lblAnswer.Visible = True
        ElseIf lstboxKind.SelectedIndex = 0 Then
            If IsNumeric(txtboxFirst.Text) Then
                dblSquare = CDbl(txtboxFirst.Text) ^ 2
                lblAnswer.Text = "The area of the square is " & dblSquare
                lblAnswer.Visible = True
            Else
                lblAnswer.Text = "Please enter a number."
                lblAnswer.Visible = True
            End If
        ElseIf lstboxKind.SelectedIndex = 1 Then
            If IsNumeric(txtboxFirst.Text) And IsNumeric(txtboxSecond.Text) Then
                dblRec = CDbl(txtboxFirst.Text) * CDbl(txtboxSecond.Text)
                lblAnswer.Text = "The area of the rectangle is " & dblRec
                lblAnswer.Visible = True
            Else
                lblAnswer.Text = "Please enter a number."
                lblAnswer.Visible = True
            End If
        ElseIf lstboxKind.SelectedIndex = 2 Then
            If IsNumeric(txtboxFirst.Text) And IsNumeric(txtboxSecond.Text) Then
                dblTri = (CDbl(txtboxFirst.Text) * CDbl(txtboxSecond.Text)) / 2
                lblAnswer.Text = "The area of the triangle is " & dblTri
                lblAnswer.Visible = True
            Else
                lblAnswer.Text = "Please enter a number."
                lblAnswer.Visible = True
            End If
        ElseIf lstboxKind.SelectedIndex = 3 Then
            If IsNumeric(txtboxFirst.Text) Then
                dblCircle = 3.1417 * (CDbl(txtboxFirst.Text) ^ 2)
                lblAnswer.Text = "The area of the circle is " & dblCircle
                lblAnswer.Visible = True
            Else
                lblAnswer.Text = "Please enter a number."
                lblAnswer.Visible = True
            End If
        End If
    End Sub
End Class
