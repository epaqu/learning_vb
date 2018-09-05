Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strName As String
        strName = InputBox("What is your name?", "name ")
        lstbox1.Items.Add("Hello " & strName & ". Have a great day.")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strTitle, strPrompt, strCapture As String
        strPrompt = txtbox1.text
        strTitle = txtbox2.Text
        strCapture = InputBox(strPrompt, strTitle)
        lstbox1.Items.Add(strCapture)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fmtStr As String = "{0,10} {1,15}"
        Dim strFName, strLName As String
        strFName = txtbox1.Text
        strLName = txtbox2.Text
        lstbox1.Items.Add(String.Format(fmtStr, strFName, strLName))
    End Sub
End Class
