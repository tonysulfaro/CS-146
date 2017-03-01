Public Class SulfaroCH61Lab

    ' Program: CH6.1 Lab
    ' Name: Anthony Sulfaro
    ' Date: 9/1/16
    ' Class: CS146.04
    ' Def: Introduce and utilize loops in a program.

    'EX 6.1.1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplayEX611.Click


        'Display the numbers from 1 to 7
        Dim num As Integer = 1
        Do While num <= 7
            lstNumbersEX611.Items.Add(num)
            num += 1  'Add 1 to the value of num
        Loop
    End Sub

    'EX 6.1.2
    Private Sub btnDisplayEX612_Click(sender As Object, e As EventArgs) Handles btnDisplayEX612.Click

        Dim response As Integer = 0, quotation As String = ""
        Do While (response < 1) Or (response > 3)
            response = CInt(InputBox("Enter a number from 1 to 3."))
        Loop

        Select Case response
            Case 1
                quotation = "Plastics."
            Case 2
                quotation = "Rosebud."
            Case 3
                quotation = "That's all folks."
        End Select
        txtQuotationEX612.Text = quotation
    End Sub

    'EX 6.1.3
    Private Sub btnComputeEX613_Click(sender As Object, e As EventArgs) Handles btnComputeEX613.Click

        Dim num As Double = 0
        Dim count As Integer = 0
        Dim sum As Double = 0
        Dim prompt As String = "Enter a nonnegative number. " &
                                "Enter -1 to terminate entering numbers."

        num = CDbl(InputBox(prompt))
        Do While num <> -1
            count += 1
            sum += num
            num = CDbl(InputBox(prompt))
        Loop

        If count > 0 Then
            MessageBox.Show("Average: " & sum / count)
        Else
            MessageBox.Show("No nonnegative numbers were entered.")
        End If

    End Sub

    'EX 6.1.4
    Private Sub btnDisplayEX614_Click(sender As Object, e As EventArgs) Handles btnDisplayEX614.Click

        Dim response As Integer, quotation As String = ""
        Do
            response = CInt(InputBox("Enter a number from 1 to 3."))
        Loop Until (response >= 1) And (response <= 3)
        Select Case response
            Case 1
                quotation = "Plastics."
            Case 2
                quotation = "Rosebud."
            Case 3
                quotation = "That's all folks."
        End Select
        txtQuotationEX614.Text = quotation
    End Sub

    'EX 6.1.5
    Private Sub btnCalculateEX615_Click(sender As Object, e As EventArgs) Handles btnCalculateEX615.Click

        Dim balance As Decimal, numYears As Integer = 0
        balance = CDec(txtAmountEX615.Text)
        Do While balance < 1000000
            balance += 0.06D * balance
            numYears += 1
        Loop
        txtWhenEX615.Text = "In " & numYears &
                            " years you will have a million dollars."

    End Sub
End Class
