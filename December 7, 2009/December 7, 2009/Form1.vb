Public Class Form1
    Dim intCntr As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim intX As Integer
        intX = CInt(TextBox1.Text)
        ListBox1.Items.Add(intX)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        intCntr = intCntr + 1
        ListBox1.Items.Add(intCntr)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim intx As Integer
        ListBox1.Items.Add(intx * 10)
        intx = CInt(textbox2.Text) + 3
        ListBox1.Items.Add(intx)
    End Sub
End Class
