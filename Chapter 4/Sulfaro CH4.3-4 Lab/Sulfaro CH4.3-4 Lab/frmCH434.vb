Public Class frmCH434
    ' Program:CH4.3-4 Lab
    ' Name: Anthony Sulfaro
    ' Date: 10/16/16
    ' Class: CS146.04
    ' Program Def:
    ' Utilize new input methods. eg: check boxes, radio buttons, listboxes

    Private Sub btnEvaluateEX431_Click(sender As Object, e As EventArgs) Handles btnEvaluateEX431.Click

        Dim position As Integer = CInt(txtPositionEX431.Text)
        Select Case position
            Case 1
                txtOutcomeEX431.Text = "Gold medalist"
            Case 2
                txtOutcomeEX431.Text = "Silver medalist"
            Case 3
                txtOutcomeEX431.Text = "Bronze medalist"
            Case 4, 5
                txtOutcomeEX431.Text = "You almost won a medal."
            Case Else
                txtOutcomeEX431.Text = "Nice try."
        End Select
    End Sub

    Private Sub btnDetermineEX433_Click(sender As Object, e As EventArgs) Handles btnDetermineEX433.Click
        Dim month As Integer = CInt(mtbMonthEX433.Text)
        Dim yr As Integer = CInt(mtbYearEX433.Text)
        Dim dt1, dt2 As Date
        Dim numberOfDays As Integer

        Select Case month
            Case 9, 4, 6, 11
                numberOfDays = 30
            Case 2
                dt1 = CDate("1/1/" & yr)
                dt2 = dt1.AddYears(1)

                If DateDiff(DateInterval.Day, dt1, dt2) = 366 Then
                    numberOfDays = 29
                Else
                    numberOfDays = 28
                End If

            Case Else
                numberOfDays = 31
        End Select
        txtOutputEX433.Text = month & "/" & yr & " has " &
            numberOfDays & " days."
    End Sub

    Private Sub btnAnalyzeEX435_Click(sender As Object, e As EventArgs) Handles btnAnalyzeEX435.Click
        'Analyze the first character of a string.
        Dim anyString As String
        anyString = txtStringEX435.Text.ToUpper
        Select Case anyString.Substring(0, 1)
            Case "A", "E", "I", "O", "U"
                txtResultEX435.Text = "The string begins with a vowel."
            Case "A" To "Z"
                txtResultEX435.Text = "The string begins with a consonant."
            Case "0" To "9"
                txtResultEX435.Text = "The string begins with a digit."
        End Select
    End Sub

    Private Sub btnDetermineEX441_Click(sender As Object, e As EventArgs) Handles btnDetermineEX441.Click

        Dim daysInMonth As String
        Select Case lstMonths.Text
            Case "September", "April", "June", "November"
                daysInMonth = "30"
            Case "February"
                daysInMonth = "28 or 29"
            Case Else
                daysInMonth = "31"
        End Select
        txtDaysEX441.Text = daysInMonth

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If radChildEX443.Checked Then
            txtFeeEX443.Text = (0).ToString("C")
        ElseIf radMinorEX443.Checked Then
            txtFeeEX443.Text = (5).ToString("C")
        ElseIf radAdultEX443.Checked Then
            txtFeeEX443.Text = (10).ToString("C")
        ElseIf radSeniorEX443.Checked Then
            txtFeeEX443.Text = (7.5).ToString("C")
        Else
            MessageBox.Show("You must make a selection.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCostEX444.Click



        Dim sum As Decimal = 0
        If chkDrugsEX444.Checked Then
            sum += 39.15D
        End If
        If chkDentalEX444.Checked Then
            sum += 10.81D
        End If
        If chkVisionEX444.Checked Then
            sum += 2.25D
        End If
        If chkVisionEX444.Checked Then
            sum += 55.52D
        End If
        txtTotalEX444.Text = sum.ToString("C")

    End Sub

    Private Sub checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles chkDentalEX444.CheckedChanged,
        chkDrugsEX444.CheckedChanged, chkMedicalEX444.CheckedChanged, chkVisionEX444.CheckedChanged

        Dim sum As Decimal = 0
        If chkDrugsEX444.Checked Then
            sum += 39.15D
        End If
        If chkDentalEX444.Checked Then
            sum += 10.81D
        End If
        If chkVisionEX444.Checked Then
            sum += 2.25D
        End If
        If chkMedicalEX444.Checked Then
            sum += 55.52D
        End If
        txtTotalEX444.Text = sum.ToString("C")
    End Sub
End Class
