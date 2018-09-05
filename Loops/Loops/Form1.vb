Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dblSum As Double
        Dim i, intNum As Integer
1:
        intNum = CInt(InputBox("How many numbers do you have?", "How many numbers do you have?"))
        If intNum Mod 2 = 0 Then
            Do While i < intNum
                dblSum += CDbl(InputBox("Add Number", "What is your number?"))
                i += 1
            Loop
            ListBox1.Items.Add(dblSum)
        Else
            MsgBox("Type an even number.")
            GoTo 1
        End If
    End Sub
End Class
