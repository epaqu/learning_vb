Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Dim intNum As Integer
        intNum = CInt(txtbox1.Text)
        lstbox.Items.Add(intNum * 6)

    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        Dim StrOne, StrTwo As String
        Dim intResult As Integer
        StrOne = txtbox1.Text
        StrTwo = txtbox2.Text
        intResult = StrOne.IndexOf(StrTwo)
        lstbox.Items.Add(intResult)

    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        Dim StrOne As String
        StrOne = txtbox1.Text
        lstbox.Items.Add(StrOne.Substring(2, 3))

    End Sub
End Class
