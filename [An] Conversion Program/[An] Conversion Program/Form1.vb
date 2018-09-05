Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim dblMiles, dblYards, dblFeet, dblInches, dblTotal, dblTotalMeter, dblMeters, dblKilo, dblCenti As Double
        dblMiles = CDbl(txtMiles.Text)
        dblYards = CDbl(txtYards.Text)
        dblFeet = CDbl(txtFeet.Text)
        dblInches = CDbl(txtInches.Text)
        dblTotal = (dblMiles * 63360) + (36 * dblYards) + (12 * dblFeet) + (dblInches)
        dblTotalMeter = dblTotal / 39.37
        dblKilo = Int(dblTotalMeter / 1000)
        dblMeters = Int(((dblTotalMeter / 1000) - dblKilo) * 1000)
        dblCenti = Int(((((dblTotalMeter / 1000) - dblKilo) * 1000) - dblMeters) * 1000) / 10
        lstboxResult.Items.Add("The metric length is")
        lstboxResult.Items.Add(dblKilo & " kilometers")
        lstboxResult.Items.Add(dblMeters & " meters")
        lstboxResult.Items.Add(dblCenti & " centimeters")
    End Sub
End Class
