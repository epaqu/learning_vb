Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOutput.BackColor = Color.LightGray
    End Sub

    Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        num1 = CDbl(txt1.Text)
        num2 = CDbl(txt2.Text)
        num3 = num1 + num2
        txtOutput.Text = txt1.Text & " + " & txt2.Text & " = " & num3
    End Sub

    Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        num1 = CDbl(txt1.Text)
        num2 = CDbl(txt2.Text)
        num3 = num1 - num2
        txtOutput.Text = txt1.Text & " - " & txt2.Text & " = " & num3
    End Sub

    Private Sub btnMulti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulti.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        num1 = CDbl(txt1.Text)
        num2 = CDbl(txt2.Text)
        num3 = num1 * num2
        txtOutput.Text = txt1.Text & " x " & txt2.Text & " = " & num3
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged
        txtOutput.Clear()
    End Sub

    Private Sub txt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.TextChanged
        txtOutput.Clear()
    End Sub

    Private Sub txtOutput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOutput.TextChanged


    End Sub
End Class
