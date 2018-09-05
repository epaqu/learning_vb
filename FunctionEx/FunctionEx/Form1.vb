Public Class Form1

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Dim strFullName As String
        Dim strFirstName As String
        strFullName = txtbox1.Text
        strFirstName = FirstName(strFullName)
        lbl01.Text = strFirstName
    End Sub

    Function FirstName(ByVal strFullname As String) As String
        Dim intSpace As Integer
        intSpace = strFullname.IndexOf(" ")
        Return strFullname.Substring(0, intSpace)
    End Function
End Class
