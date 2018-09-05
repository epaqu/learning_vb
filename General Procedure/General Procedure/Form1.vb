Public Class Form1

    Private Sub txtbox01_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox01.TextChanged
        LockControl()
    End Sub

    Sub LockControl()
        'this procedure locks btn01 btn02 and lstbox01.'
        btn01.Enabled = False
        btn02.Enabled = False
        lstbox01.Enabled = False
        
    End Sub

    Private Sub txtbox02_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox02.TextChanged
        LockControl()
    End Sub

    Private Sub btn03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn03.Click
        lstbox01.Items.Add(txtbox01.Text)
        lstbox01.Items.Add(txtbox02.Text)
        txtbox01.Clear()
        txtbox02.Clear()
        unlockcontrol()
    End Sub

    Sub unlockcontrol()
        btn01.Enabled = True
        btn02.Enabled = True
        lstbox01.Enabled = True
    End Sub

    Private Sub btn02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn02.Click
        Dim intNum1, intNum2 As Integer
        CStr(intNum1) = txtbox01.Text

    End Sub

    Sub calcNumbers(ByVal intNum1 as integer, ByVal intnum2 As Integer)
        Dim intResult As Integer
        intResult = intNum1 * 2 + intnum2
        lstbox01.Items.Add(intResult)
    End Sub
End Class
