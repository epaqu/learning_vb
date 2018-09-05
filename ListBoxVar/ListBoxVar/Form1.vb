Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstbox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstbox1.SelectedIndexChanged

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        lstbox1.Items.Add(txt1.Text)
        Dim StrTextData As String
        StrTextData = txt1.Text
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txt1.Clear()
        lstbox1.Items.Clear()

    End Sub
End Class
