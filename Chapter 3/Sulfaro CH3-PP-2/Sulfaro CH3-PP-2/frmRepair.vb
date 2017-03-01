Public Class frmRepair

    ' Program:CH3-PP-2
    ' Name: Anthony Sulfaro
    ' Date: 10/4/16
    ' Class: CS146.04
    ' Program Def:
    ' Displays a car repair bill given user input.

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        '[constant variables]
        Const Rate As Double = 35
        Const Tax As Decimal = 0.05D

        '[declare working variables]
        Dim Customer As String
        Dim frmstr As String
        Dim Hours As Double
        Dim Cost As Double
        Dim LaborCost As Double
        Dim PartCost As Double
        Dim TotalCost As Double


        '[declare format string for output]
        'labels, space, then customer and costs
        'costs converted to currency
        frmstr = "{0,-10}{1,4}{2,12:C}"


        '[input]
        'read data store into variables
        Customer = txtCustomer.Text
        Hours = txtHours.Text
        Cost = txtCost.Text


        '[process variables]
        'calculate labor cost
        'calculate part cost
        'calculate total cost
        LaborCost = Hours * Rate
        PartCost = (Cost * Tax) + Cost
        TotalCost = LaborCost + PartCost


        '[display output]
        'clear listbox before displaying output
        lstOutput.Items.Clear()

        'display bill information to the listbox with string formatting
        lstOutput.Items.Add(String.Format(frmstr, "Customer", "", Customer))
        lstOutput.Items.Add(String.Format(frmstr, "Labor Cost", "", LaborCost))
        lstOutput.Items.Add(String.Format(frmstr, "Parts Cost", "", PartCost))
        lstOutput.Items.Add(String.Format(frmstr, "", "", "~~~~~~~~~~~~~"))
        lstOutput.Items.Add(String.Format(frmstr, "Total Cost", "", TotalCost))

    End Sub

    Private Sub btnExitProgram_Click(sender As Object, e As EventArgs) Handles btnExitProgram.Click

        'delcare working variables
        Dim prompt, title As String

        'sets the title and prompt for the messagebox
        prompt = "The program will now close."
        title = "Confirm"

        'displays a message box with the prompt and title
        MessageBox.Show(prompt, title)

        'closes the program and its dependancies
        Me.Close()

    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click


        'clears all text and listboxes
        lstOutput.Items.Clear()
        txtCost.Clear()
        txtCustomer.Clear()
        txtHours.Clear()

        'shifts focus to the first textbox with customer name
        txtCustomer.Focus()

    End Sub
End Class
