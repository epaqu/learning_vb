Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btndis2.Visible = False
    End Sub

    Private Sub btnred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnred.Click
        btnred.BackColor = Color.Red
        btnblue.BackColor = Color.Red
        btngreen.BackColor = Color.Red
        btnwhite.BackColor = Color.Red
        btndis1.BackColor = Color.Red
        btndis2.BackColor = Color.Red
    End Sub

    Private Sub btnwhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwhite.Click
        Me.BackColor = Color.White
    End Sub

    Private Sub btnblue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnblue.Click
        btnred.ForeColor = Color.Blue
        btndis1.ForeColor = Color.Blue
        btnblue.ForeColor = Color.Blue
        btngreen.ForeColor = Color.Blue
        btnwhite.ForeColor = Color.Blue
    End Sub

    Private Sub btngreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngreen.Click
        btnred.ForeColor = Color.Green
        btnblue.ForeColor = Color.Green
        btngreen.ForeColor = Color.Green
        btndis1.ForeColor = Color.Green
        btndis2.ForeColor = Color.Green
        btnwhite.ForeColor = Color.Green
    End Sub

    Private Sub Txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged
        btnred.BackColor = Color.LightGray
        btnwhite.BackColor = Color.LightGray
        btngreen.BackColor = Color.LightGray
        btnblue.BackColor = Color.LightGray
        btndis1.BackColor = Color.LightGray
        btndis2.BackColor = Color.LightGray
        Me.BackColor = Color.Yellow
        btnred.ForeColor = Color.White
        btndis1.ForeColor = Color.White
        btndis2.ForeColor = Color.White
        btnblue.ForeColor = Color.White
        btngreen.ForeColor = Color.White
        btnwhite.ForeColor = Color.White
    End Sub
    Private Sub Txt1_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.Leave
        txt1.Clear()
    End Sub

    Private Sub btndis1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndis1.Click
        btndis1.Visible = False
        btndis2.Visible = True
    End Sub

    Private Sub btndis2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndis2.Click
        btndis2.Visible = False
        btndis1.Visible = True
    End Sub
End Class

