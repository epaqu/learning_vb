Public Class Form1
    Dim intNum As Integer
    Dim dblSum As Double
    Private Sub txtEnter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnter.TextChanged
        txtResult.Clear()
    End Sub

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        intNum += 1
        dblSum += CDbl(txtEnter.Text)
        txtEnter.Clear()
        txtEnter.Focus()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        txtResult.Text = CStr(dblSum / intNum)

    End Sub

    Private Sub txtResult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResult.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
