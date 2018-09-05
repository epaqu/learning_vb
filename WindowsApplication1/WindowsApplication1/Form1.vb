Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dbl1, dbl2, dbl3, dblAvg As Double
        Dim bol1Small, bol2Small, bol3Small As Boolean
        dbl1 = CDbl(InputBox("Enter the first value."))
        dbl2 = CDbl(InputBox("Enter the second value."))
        dbl3 = CDbl(InputBox("Enter the third value."))
        If dbl1 < dbl2 Then
            If dbl1 < dbl3 Then
                bol1Small = True
            Else
                bol3Small = True
            End If
        Else
            If dbl2 < dbl3 Then
                bol2Small = True
            Else
                bol3Small = True
            End If
        End If
        If bol1Small Then
            dblAvg = (dbl2 + dbl3) / 2
        End If
        If bol2Small Then
            dblAvg = (dbl1 + dbl3) / 2
        End If
        If bol3Small Then
            dblAvg = (dbl2 + dbl3) / 2
        End If
        TextBox1.Text = CStr(dblAvg)
    End Sub
End Class
