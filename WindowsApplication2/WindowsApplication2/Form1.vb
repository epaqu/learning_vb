Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim intSpot As Integer
        intSpot = CInt(textbox1.text)
        Select Case intSpot
            Case 1
                TextBox2.Text = "Win"
            Case 2
                TextBox2.Text = "place"
            Case 3
                TextBox2.Text = "show"
            Case 4 To 5
                TextBox2.Text = "almost..."
            Case 7, 8
                TextBox2.Text = "terrible"
        End Select
    End Sub
End Class
