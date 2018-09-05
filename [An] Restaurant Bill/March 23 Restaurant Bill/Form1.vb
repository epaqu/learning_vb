Public Class Form1
    Dim fmtStr As String = "{0,-15}{1,8}{2,17:C2}"
    Dim dblTotalCost As Double
    Dim intSlices, intFries, intDrink As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        If ChkForNums() = True Then
            ' continue with calculation '
            lstbox1.Items.Add(String.Format(fmtStr, "Item", "Quantity", "Price"))
            lstbox1.Items.Add(String.Format(fmtStr, "", "", ""))
            CalcPizza()
            lstbox1.Items.Add(String.Format(fmtStr, "", "", ""))
            intSlices = txtboxPizza.Text
            intDrink = txtboxDrink.Text
            intFries = txtboxFries.Text
            CalcTotal(intSlices, intFries, intDrink, dblTotalCost)
        Else
            lstbox1.Items.Add("Enter numeric data above.")
        End If
    End Sub
    Function CalcTotal(ByVal intOne As Integer, ByVal intTwo As Integer, ByVal intThree As Integer, ByVal dblTotalCost As Double) As Double
        dblTotalCost = 1.75 * intOne + 2 * intTwo + 1.25 * intThree
        Return lstbox1.Items.Add(String.Format(fmtStr, "Total", "", dblTotalCost))
    End Function
    Function ChkForNums() As Boolean
        If IsNumeric(txtboxPizza.Text) And IsNumeric(txtboxFries.Text) And IsNumeric(txtboxDrink.Text) Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub CalcPizza()
        Dim dblPizzaCost As Double = 1.75
        Dim dblFriesCost As Double = 2.0
        Dim dblDrinkCost As Double = 1.25
        intSlices = txtboxPizza.Text
        intDrink = txtboxDrink.Text
        intFries = txtboxFries.Text
        WriteToBill("Pizza Slices", intSlices, dblPizzaCost)
        WriteToBill("Fries", intFries, dblFriesCost)
        WriteToBill("Soft Drinks", intDrink, dblDrinkCost)
    End Sub
    Sub WriteToBill(ByVal strType As String, ByVal intNumItems As Integer, ByVal dblCost As Double)
        lstbox1.Items.Add(String.Format(fmtStr, strType, intNumItems, dblCost))
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstbox1.Items.Clear()
    End Sub
End Class
