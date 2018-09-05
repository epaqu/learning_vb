Public Class Form1

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Dim dblPaid, dblPound, dblNeedmore, dblChange As Double
        dblPound = (CDbl(InputBox("How many pounds of apple does your customer want?")))
        dblPaid = (CDbl(InputBox("How much did your customer pay?")))
        If (dblPound * 1.7) > dblPaid Then
            dblNeedmore = (dblPound * 1.7) - dblPaid
            MessageBox.Show("Your customer needs to pay $ " & (dblNeedmore) & " more.")
        Else
            dblChange = dblPaid - (dblPound * 1.7)
            MessageBox.Show("The change for your customer is $ " & dblChange)
        End If
    End Sub

    Private Sub lblTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitle.Click

    End Sub
End Class
