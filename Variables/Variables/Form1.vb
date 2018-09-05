Public Class Form1

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Dim dblNumOne As string
        Dim dblNumTwo As String
        Dim dblResult As String
        dblNumOne = CSTr(txt1.Text)
        dblNumTwo = CStr(txt2.Text)
        dblResult = (dblNumOne & dblNumTwo)
        lst1.Items.Add(CDbl(dblResult))
    End Sub

    Private Sub lst1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst1.SelectedIndexChanged
        BackColor = Color.BlanchedAlmond
    End Sub
End Class
