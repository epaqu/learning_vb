Public Class Form1

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Dim sr As IO.StreamReader
        sr = IO.File.OpenText("IOTest.txt")
        Dim strVar As String
        Do While sr.Peek <> -1
            strVar = sr.ReadLine
            lstbox1.Items.Add(strVar)
        Loop
    End Sub
End Class
