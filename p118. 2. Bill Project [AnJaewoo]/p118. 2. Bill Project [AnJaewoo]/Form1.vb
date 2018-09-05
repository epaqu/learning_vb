Public Class lblParts

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstboxBill.SelectedIndexChanged

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim fmtStr As String = "{0,-15}{1,15:C2}"
        Dim strName As String
        Dim dblLabor, dblParts, dblTotal As Double
        dblLabor = 35 * CDbl(txtLabor.Text)
        dblParts = 1.05 * CDbl(txtParts.Text)
        dblTotal = dblLabor + dblParts
        strName = txtCustom.text
        lstboxBill.Items.Add(String.Format(fmtStr, "Customer", strName))
        lstboxBill.Items.Add(String.Format(fmtStr, "Labor cost", dblLabor))
        lstboxBill.Items.Add(String.Format(fmtStr, "Parts cost", dblParts))
        lstboxBill.Items.Add(String.Format(fmtStr, "Total cost", dblTotal))
    End Sub
End Class
