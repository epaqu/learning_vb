Public Class Form1

    Private Sub txt3_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt3.Leave
        txt3.BackColor = Color.DarkGray
        txt2.BackColor = Color.Yellow
        
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt3.BackColor = Color.Green
        txt2.BackColor = Color.DarkGray
        txt1.BackColor = Color.DarkGray

    End Sub

    Private Sub txt2_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.Leave
        txt2.BackColor = Color.DarkGray
        txt1.BackColor = Color.Red
    End Sub

    Private Sub txt1_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.Leave
        txt1.BackColor = Color.DarkGray
        txt3.BackColor = Color.Green
    End Sub
End Class
