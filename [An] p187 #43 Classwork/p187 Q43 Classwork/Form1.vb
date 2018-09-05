Public Class Form1
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Dim inputvalue As String
        Dim num1 As Double
        inputvalue = InputBox("Type a number", "Conversion")
        If IsNumeric(inputvalue) Then
            num1 = 3 * CDbl(inputvalue)
            Triple(inputvalue, num1)
        Else
            lblResult.Text = "Please enter a numeric value."
        End If
    End Sub
    Sub Triple(ByVal inputvalue As String, ByVal num1 As Double)
        lblResult.Text = "3 x " & inputvalue & " = " & CStr(num1)
    End Sub
End Class