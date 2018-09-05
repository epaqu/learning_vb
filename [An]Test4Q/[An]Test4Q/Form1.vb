Public Class Form1
    Private Sub btnTri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTri.Click
        Dim Inputvalue As String
        Dim Output As String = ""
        Dim i As String = 1
        Inputvalue = InputBox("Please type the number of asteriks.", "Please type the number of asteriks.")
        If IsNumeric(Inputvalue) Then
            Do While i < Inputvalue + 1
                Output = Output + "*"
                lblboxResult.Items.Add(Output)
                i += 1
            Loop
        Else
            MsgBox("Please type a numeric value.")
        End If
    End Sub

    Private Sub btnEvenSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvenSum.Click
        Dim value As String
        Dim sum As Double = 0
        Dim Stopper As Double = 0
        Do
            value = InputBox("What number do you have?", "What number do you have?")
            If IsNumeric(value) Then
                If value Mod 2 = 0 Then
                    sum = sum + value
                Else
                    Stopper = 1
                End If
            Else
                MsgBox("Please type a numeric value.")
            End If
        Loop Until Stopper = 1
        lblboxResult.Items.Add(sum)
    End Sub
End Class
