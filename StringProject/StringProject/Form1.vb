Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strVar1, strVar2 As String
        strVar1 = TextBox1.Text
        strVar2 = TextBox2.Text
        ListBox1.Items.Add(strVar1)
        ListBox1.Items.Add(strVar2)
        ListBox1.Items.Add("first" & "second")
        ListBox1.Items.Add(strVar1 & " " & strVar2)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strVar1, strVar2 As String
        ListBox1.Items.Add("TEXTBOX 1")
        strVar1 = TextBox1.Text
        ListBox1.Items.Add(strVar1.Length)
        ListBox1.Items.Add(strVar1.Trim.Length)
        ListBox1.Items.Add(strVar1.Trim)
        ListBox1.Items.Add(strVar1)
        strVar1 = strVar1.Trim
        ListBox1.Items.Add(strVar1)
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add("TEXTBOX 2")
        strVar2 = TextBox2.Text
        ListBox1.Items.Add(strVar2.Length)
        ListBox1.Items.Add(strVar2.Trim.Length)
        ListBox1.Items.Add(strVar2.Trim)
        ListBox1.Items.Add(strVar2)
        strVar2 = strVar2.Trim
        ListBox1.Items.Add(strVar2)

    End Sub
End Class
