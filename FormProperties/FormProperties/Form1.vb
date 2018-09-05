Public Class Form1

    Private Sub btnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRed.Click
        Me.BackColor = Color.Red

    End Sub

    Private Sub btnBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlue.Click
        Me.BackColor = Color.Blue

    End Sub

    Private Sub btnGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGreen.Click
        Me.BackColor = Color.Green

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Empty

    End Sub

    Private Sub txtOne_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOne.TextChanged

    End Sub

    Private Sub btnViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViolet.Click
        Me.BackColor = Color.Violet

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Me.BackColor = Color.Empty
        txtOne.Text = ""
        txtTwo.Clear()
        txtThree.Clear()
        txtOne.Clear()
        btnRed.BackColor = Color.White
        btnBlue.BackColor = Color.White
        btnViolet.BackColor = Color.White
        btnGreen.BackColor = Color.White


    End Sub

    Private Sub txtThree_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtThree.TextChanged
        txtOne.Text = txtThree.Text

    End Sub

    Private Sub txtTwo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTwo.TextChanged
        btnRed.BackColor = Color.Red
        btnBlue.BackColor = Color.Blue
        btnGreen.BackColor = Color.Green
        btnViolet.BackColor = Color.Violet

    End Sub
End Class

