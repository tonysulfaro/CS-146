Public Class frmBilling
    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click

        Dim customer As String = txtCustomer.Text
        Dim hours As Decimal = txtHours.Text * 35
        Dim supplies As Decimal = txtSupplies.Text * 1.05

        lstBill.Items.Add("Customer:    " & customer)
        lstBill.Items.Add("Labor Cost:  $" & FormatNumber((hours), 2))
        lstBill.Items.Add("Parts Cost:   $" & FormatNumber((supplies), 2))
        lstBill.Items.Add("Total Cost:   $" & FormatNumber((hours + supplies), 2))
    End Sub
End Class
