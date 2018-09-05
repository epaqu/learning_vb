Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim length, cost As Double
        length = CDbl(InputBox("Duration of the call in munutes?"))
        If length < 1 Then
            cost = 0.46
        Else
            cost = 0.46 + (length - 1) * 0.36
        End If
        TextBox1.Text = "Cost of call: " & FormatCurrency(cost)
    End Sub
End Class
