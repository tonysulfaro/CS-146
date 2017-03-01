Public Class SulfaroCH63Lab

    'Anthony Sulfaro
    'Nancy Samolewski
    'CS 146.04
    'CH 6.3 Lab

    'Last Modified: 11/9/16

    'EX 6.3.1 States
    Private Sub btnDisplay631_Click(sender As Object, e As EventArgs) Handles btnDisplay631.Click

        lstLastTen631.Items.Clear()

        Dim n As Integer = lstStates631.Items.Count
        For i As Integer = (n - 1) To (n - 10) Step -1
            lstLastTen631.Items.Add(lstStates631.Items(i))
        Next

    End Sub

    'EX 6.3.2 - States
    Private Sub btnSearch632_Click(sender As Object, e As EventArgs) Handles btnSearch632.Click

        Dim letters As String = mtbFirstTwoLetters632.Text.ToUpper
        Dim foundFlag As Boolean = False
        Dim i As Integer = -1
        Do Until (foundFlag) Or (i = lstStates632.Items.Count - 1)
            i += 1
            If CStr(lstStates632.Items(i)).ToUpper.StartsWith(letters) Then
                foundFlag = True

            End If
        Loop
        If foundFlag Then
            txtOutput632.Text = CStr(lstStates632.Items(i)) & " is state #" & (i + 1) & "."
        Else
            txtOutput632.Text = "No state begins with " & mtbFirstTwoLetters632.Text & "."
        End If

    End Sub

    'EX 6.3.3 - Grades
    Private Sub btnRecord633_Click(sender As Object, e As EventArgs) Handles btnRecord633.Click

        lstGrades633.Items.Add(txtGrade633.Text)
        txtGrade633.Clear()
        txtGrade633.Focus()

    End Sub

    Private Sub btnCalculate633_Click(sender As Object, e As EventArgs) Handles btnCalculate633.Click

        Dim sum As Double = 0
        Dim maxGrade As Double = 0
        If lstGrades633.Items.Count > 0 Then
            For i As Integer = 0 To lstGrades633.Items.Count - 1
                sum += CDbl(lstGrades633.Items(i))
                If CDbl(lstGrades633.Items(i)) > maxGrade Then
                    maxGrade = CDbl(lstGrades633.Items(i))
                End If
            Next
            txtAverage633.Text = (sum / lstGrades633.Items.Count).ToString("N")
            txtHighest633.Text = CStr(maxGrade)
        Else
            MessageBox.Show("You must first enter some grades.")
        End If
    End Sub

    'EX 6.3.4 - US States
    Private Sub btnSearch634_Click(sender As Object, e As EventArgs) Handles btnSearch634.Click

        Dim letters As String = mtbFirstTwoLetters634.Text.ToUpper
        Dim i As Integer = 0
        Do Until (CStr(lstStates634.Items(i)).ToUpper > letters) Or
                (i = lstStates634.Items.Count - 1)
            i += 1
        Loop
        If CStr(lstStates634.Items(i)).ToUpper.StartsWith(letters) Then
            txtOutput634.Text = CStr(lstStates634.Items(i)) & " begins with " &
                mtbFirstTwoLetters634.Text & "."
        Else
            txtOutput634.Text = "No state begins with " & mtbFirstTwoLetters634.Text & "."
        End If
    End Sub
End Class
