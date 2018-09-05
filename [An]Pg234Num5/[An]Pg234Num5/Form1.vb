Public Class Form1
    Dim score, intQuestion As Integer
    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        score = 0
        intQuestion = 1
        btnTest.Visible = False
        btnFalse.Visible = True
        btnTrue.Visible = True
        lblQuestion.Visible = True
        Question()
    End Sub

    Sub Question()
        If intQuestion = 1 Then
            lblQuestion.Text = "Q1. The squeaky wheel gets the grease."
        End If
        If intQuestion = 2 Then
            lblQuestion.Text = "Q2. Cry and you cry alone."
        End If
        If intQuestion = 3 Then
            lblQuestion.Text = "Q3. Opposites attract."
        End If
        If intQuestion = 4 Then
            lblQuestion.Text = "Q4. Spare the rod and spoil the child."
        End If
        If intQuestion = 5 Then
            lblQuestion.Text = "Q5. Actions speak louder than words."
        End If
        If intQuestion = 6 Then
            lblQuestion.Text = "Q6. Familiarity breed contempt."
        End If
        If intQuestion = 7 Then
            lblQuestion.Text = "Q7. Marry in haste, repent at leisure."
        End If

    End Sub
    Sub Scoring()
        score = score + 1
    End Sub
    Sub Result()
        If score = 7 Then
            MsgBox("Perfect!", Nothing, "Result")
        ElseIf score = 6 Then
            MsgBox("Excellent!", Nothing, "Result")
        ElseIf score = 5 Then
            MsgBox("Excellent!", Nothing, "Result")
        Else
            MsgBox("You might consider taking Psychology 101.", Nothing, "Result")
        End If
    End Sub
    Private Sub btnTrue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrue.Click
        If intQuestion = 1 Then
            Scoring()
        ElseIf intQuestion = 2 Then
            Scoring()
        ElseIf intQuestion = 5 Then
            Scoring()
        ElseIf intQuestion = 7 Then
            Scoring()
            Result()
            btnTrue.Visible = False
            btnFalse.Visible = False
            lblQuestion.Visible = False
            btnTest.Text = "Restart"
            btnTest.Visible = True
        End If
        intQuestion = intQuestion + 1
        Question()
    End Sub

    Private Sub btnFalse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFalse.Click
        If intQuestion = 3 Then
            Scoring()
        ElseIf intQuestion = 4 Then
            Scoring()
        ElseIf intQuestion = 6 Then
            Scoring()
        ElseIf intQuestion = 7 Then
            Result()
            btnTrue.Visible = False
            btnTrue.Visible = False
            btnFalse.Visible = False
            lblQuestion.Visible = False
            btnTest.Text = "Restart"
            btnTest.Visible = True
        End If
        intQuestion = intQuestion + 1
        Question()
    End Sub
End Class
