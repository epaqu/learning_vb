Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOff.Click
        FrmActivate(False)
    End Sub

    Private Sub btnOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn.Click
        FrmActivate(True)
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

    End Sub

    Private Sub txtbox01_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox01.TextChanged

    End Sub

    Private Sub txtbox02_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox02.TextChanged

    End Sub
    Sub FrmActivate(ByVal bolON As Boolean)
        txtbox01.Enabled = bolON
        btnOff.Enabled = bolON
        txtbox02.Enabled = bolON
        btnCalc.Enabled = bolON
        btnOn.Enabled = Not (bolON)
    End Sub
End Class
