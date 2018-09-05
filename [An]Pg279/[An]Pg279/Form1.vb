Public Class Form1
    Dim Answered As Object
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnQ19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ19.Click
        lstbox1.Items.Clear()
        Dim i As Integer
        Dim strOutput As String = ""
        For i = 1 To 10
            strOutput = strOutput & "*"
        Next
        lstbox1.Items.Add(strOutput)
    End Sub
    Private Sub btnQ20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ20.Click
        lstbox1.Items.Clear()
        Dim Answered As Object
        Dim strOutput As String = ""
        Dim i As Integer
        Answered = InputBox("Choose any number from 1 to 20")
        If IsNumeric(Answered) = False Then
            MsgBox("Please type a numeric value.")
            Exit Sub
        End If
        If Answered > 20 Then
            MsgBox("Please type a number less than 20")
        ElseIf Answered < 1 Then
            MsgBox("You need to type a number that is larger than 1")
        End If
        For i = 1 To Answered
            strOutput = strOutput & "*"
        Next
        lstbox1.Items.Add(strOutput)
    End Sub
    Private Sub btnQ21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ21.Click
        lstbox1.Items.Clear()
        Dim NumRow As String
        For i As Integer = 1 To 10
            NumRow = ""
            For j As Integer = 1 To 10
                NumRow &= "*"
            Next
            lstbox1.Items.Add(NumRow)
        Next
    End Sub
    Private Sub btnQ22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ22.Click
        lstbox1.Items.Clear()
        Dim strOutput As String = ""
        Answered = InputBox("Please choose a number")
        If IsNumeric(Answered) = False Then
            MsgBox("Please type a numeric value.")
        Else
            Call Rectangle()
        End If
    End Sub
    Sub Rectangle()
        Dim NumRow As String
        For i As Integer = 1 To Answered
            NumRow = ""
            For j As Integer = 1 To Answered
                NumRow &= "*"
            Next
            lstbox1.Items.Add(NumRow)
        Next
    End Sub
End Class
