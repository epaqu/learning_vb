Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        lblMessage.Text = ("Hello " & txtName.Text() & ". You are " & txtAge.Text() & " years old. Your phone number is " & txtPhone.Text() & ".")
    End Sub

    Private Sub lblName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblName.Click

    End Sub

    Private Sub lblAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAge.Click

    End Sub

    Private Sub lblPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPhone.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtAge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged

    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.TextChanged

    End Sub
End Class
