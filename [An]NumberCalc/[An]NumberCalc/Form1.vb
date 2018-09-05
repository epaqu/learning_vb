Public Class Form1
    Dim fmtStr As String = "{0,-20}{1,10:N0}"
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        EvenSum()
    End Sub
    Sub EvenSum()
        Dim num As Integer
        Dim count As Integer = 0
        Dim EvenSum, OddSum, value As Double
        Dim largest As Double = 0
        Dim smallest As Double = 0
        Dim input1, input2 As String
        input1 = InputBox("How many numbers do you have?")
        If IsNumeric(input1) Then
            If input1 Mod 1 < 1 And input1 Mod 1 > 0 Then
                MsgBox("Please enter an integer value.")
            Else
                num = CDbl(input1)
                Do While count < num
Line1:
                    input2 = InputBox("Add Number", "What is your number?")
                    If IsNumeric(input2) Then
                        If input2 Mod 1 < 1 And input2 Mod 1 > 0 Then
                            MsgBox("Please enter an integer value.")
                            GoTo Line1
                        Else
                            value = CDbl(input2)
                            If value Mod 2 = 0 Then
                                EvenSum += value
                            Else
                                OddSum += value
                            End If
                            If count = 0 Then
                                largest = value
                            ElseIf count <> 0 And largest < value Then
                                largest = value
                            ElseIf count <> 0 And largest > value Then
                            End If
                            If count = 0 Then
                                smallest = value
                            ElseIf count <> 0 And smallest > value Then
                                smallest = value
                            ElseIf count <> 0 And smallest < value Then
                            End If
                        End If
                    Else
                        MsgBox("Please enter a numeric value.")
                        GoTo Line1
                    End If
                    count += 1
                Loop
                lstbox1.Items.Add(String.Format(fmtStr, "Sum of even numbers", EvenSum))
                lstbox1.Items.Add(String.Format(fmtStr, "Sum of odd numbers", OddSum))
                lstbox1.Items.Add(String.Format(fmtStr, "Largest Number", largest))
                lstbox1.Items.Add(String.Format(fmtStr, "Smallest Number", smallest))
                lstbox1.Items.Add(String.Format(fmtStr, " ", " "))
            End If
        Else
            MsgBox("Please enter a number.")
        End If
    End Sub
End Class
