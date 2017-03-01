Public Class SulfaroCH62Lab

    ' Program: CH 6.2 Lab
    ' Name: Anthony Sulfaro
    ' Date: 11/3/16
    ' Class: CS146.04

    'EX 6.2.1
    Private Sub btnDisplayEX621_Click(sender As Object, e As EventArgs) Handles btnDisplayEX621.Click

        Dim pop As Double = 300000
        For yr As Integer = 2015 To 2019
            lstTableEX621.Items.Add(yr & "     " & pop.ToString("N0"))
            pop += 0.03 * pop
        Next
    End Sub

    'EX 6.2.2
    Private Sub btnDisplayEX622_Click(sender As Object, e As EventArgs) Handles btnDisplayEX622.Click

        Dim n, s As Decimal
        n = CDec(txtEndEX622.Text)
        s = CDec(txtStepEX622.Text)
        lstValuesEX622.Items.Clear()
        For index As Decimal = 0 To n Step s
            lstValuesEX622.Items.Add(index)
        Next

    End Sub

    'EX 6.2.3
    Private Sub btnDisplayEX623_Click(sender As Object, e As EventArgs) Handles btnDisplayEX623.Click

        txtBackwardEX623.Text = Reverse(txtWordEX623.Text)

    End Sub
    Function Reverse(info As String) As String
        Dim m As Integer, temp As String = ""
        m = info.Length
        For j As Integer = m - 1 To 0 Step -1
            temp &= info.Substring(j, 1)
        Next
        Return temp
    End Function

    'EX 6.2.4
    Private Sub btnDisplayEX624_Click(sender As Object, e As EventArgs) Handles btnDisplayEX624.Click

        Dim row, entry As String
        lstTableEX624.Items.Clear()
        For j As Integer = 1 To 3
            row = ""
            For k As Integer = 1 To 3
                entry = j & " x " & k & " = " & (j * k)
                row &= entry & "   "
            Next
            lstTableEX624.Items.Add(row)
        Next

    End Sub
End Class
