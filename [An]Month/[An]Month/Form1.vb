Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstboxMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstboxMonth.SelectedIndexChanged
        If lstboxMonth.SelectedIndex = 0 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "January has 31 days."
            lblResponse.Visible = True
        ElseIf lstboxMonth.SelectedIndex = 1 Then
            lstboxMonth.Enabled = False
            lblQuestion.Visible = True
            btnNo.Visible = True
            btnYes.Visible = True
            lblResponse.Visible = False
        ElseIf lstboxMonth.SelectedIndex = 2 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "March has 31 days."
            lblResponse.Visible = True
        ElseIf lstboxMonth.SelectedIndex = 3 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "April has 30 days."
            lblResponse.Visible = True
        ElseIf lstboxMonth.SelectedIndex = 4 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "May has 31 days."
            lblResponse.Visible = True
        ElseIf lstboxMonth.SelectedIndex = 5 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "June has 30 days."
            lblResponse.Visible = True
        ElseIf lstboxMonth.SelectedIndex = 6 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "July has 31 days."
            lblResponse.Visible = True
        ElseIf lstboxMonth.SelectedIndex = 7 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "August has 31 days."
            lblResponse.Visible = True
        ElseIf lstboxMonth.SelectedIndex = 8 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "September has 30 days."
            lblResponse.Visible = True
        ElseIf lstboxMonth.SelectedIndex = 9 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "October has 31 days."
            lblResponse.Visible = True
        ElseIf lstboxMonth.SelectedIndex = 10 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "November has 30 days."
            lblResponse.Visible = True
        ElseIf lstboxMonth.SelectedIndex = 11 Then
            lblQuestion.Visible = False
            btnNo.Visible = False
            btnYes.Visible = False
            lblResponse.Text = "December has 31 days."
            lblResponse.Visible = True
        End If
    End Sub

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        lblResponse.Text = "February has 29 days."
        lblResponse.Visible = True
        lblQuestion.Visible = False
        btnNo.Visible = False
        btnYes.Visible = False
        lstboxMonth.Enabled = True
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        lblResponse.Text = "February has 28 days."
        lblResponse.Visible = True
        lblQuestion.Visible = False
        btnNo.Visible = False
        btnYes.Visible = False
        lstboxMonth.Enabled = True
    End Sub
End Class
