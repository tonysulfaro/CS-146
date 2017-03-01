Public Class frmPhone

    ' Program: CH7-PP-10
    ' Name: Anthony Sulfaro
    ' Date: 11/20/16
    ' Class: CS146.04
    ' Program Def:
    ' Displays people and their extensions given user input.


    'Global Structure for employees
    Structure Employee
        Dim lastName As String
        Dim firstName As String
        Dim extension As String
        Dim Code As String
    End Structure

    'array for person structure
    Dim people() As Employee

    Dim Code As String = ""

    'Load Time
    Private Sub frmPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CodeAssign()

    End Sub

    'Handles employee code assingment
    Sub CodeAssign()

        Dim Employee() As String = IO.File.ReadAllLines("Employees.txt")
        Dim n As Integer = Employee.Count - 1
        ReDim people(n)
        Dim line As String
        Dim data(2) As String
        For i As Integer = 0 To n
            line = Employee(i)
            data = line.Split(","c)
            people(i).lastName = data(0)
            people(i).firstName = data(1)
            people(i).extension = data(2)
            people(i).Code = (people(i).lastName.Substring(0, 3).ToUpper & people(i).firstName.Substring(0, 1).ToUpper)


            For j As Integer = 0 To 3
                Select Case (people(i).lastName.Substring(0, 3).ToUpper & people(i).firstName.Substring(0, 1).ToUpper).Substring(j, 1)
                    Case "A", "B", "C"
                        people(i).Code += "2"
                    Case "D", "E", "F"
                        people(i).Code += "3"
                    Case "G", "H", "I"
                        people(i).Code += "4"
                    Case "J", "K", "L"
                        people(i).Code += "5"
                    Case "M", "N", "O"
                        people(i).Code += "6"
                    Case "P", "Q", "R", "S"
                        people(i).Code += "7"
                    Case "T", "U", "V"
                        people(i).Code += "8"
                    Case "W", "X", "Y", "Z"
                        people(i).Code += "9"
                End Select
            Next
            people(i).Code = people(i).Code.Substring(4, 4)
        Next
    End Sub

    'Handles code text changing
    Private Sub mtbCode_TextChanged(sender As Object, e As EventArgs) Handles mtbCode.TextChanged

        Dim query = From person In people
                    Where person.Code.StartsWith(Code)
                    Select person.lastName, person.firstName, person.extension

        dgvDirectory.DataSource = query.ToList
        dgvDirectory.CurrentCell = Nothing

        dgvDirectory.Columns("lastName").HeaderText = "Last Name"
        dgvDirectory.Columns("firstName").HeaderText = "First Name"
        dgvDirectory.Columns("extension").HeaderText = "Extension"

    End Sub

    'Display all directory
    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click
        'use a query to find the data that start with txtCode.txt
        'if txtCode is null then display all employees alphabetically by lastname and firstname
        'else display employees that start with txtCode.txt



        Dim query = From person In people
                    Where person.Code.Length = 4
                    Order By person.lastName
                    Select person.lastName, person.firstName, person.extension

        dgvDirectory.DataSource = query.ToList
        dgvDirectory.CurrentCell = Nothing

        dgvDirectory.Columns("lastName").HeaderText = "Last Name"
        dgvDirectory.Columns("firstName").HeaderText = "First Name"
        dgvDirectory.Columns("extension").HeaderText = "Extension"

    End Sub


    'Add Number onto Code
    Private Sub btn2ABC_Click(sender As Object, e As EventArgs) Handles btn2ABC.Click
        AddButton("2")
        mtbCode.Text = Code
    End Sub

    Private Sub btn3DEF_Click(sender As Object, e As EventArgs) Handles btn3DEF.Click
        AddButton("3")
        mtbCode.Text = Code
    End Sub

    Private Sub btn4GHI_Click(sender As Object, e As EventArgs) Handles btn4GHI.Click
        AddButton("4")
        mtbCode.Text = Code
    End Sub

    Private Sub btn5JKL_Click(sender As Object, e As EventArgs) Handles btn5JKL.Click
        AddButton("5")
        mtbCode.Text = Code
    End Sub

    Private Sub btn6MNO_Click(sender As Object, e As EventArgs) Handles btn6MNO.Click
        AddButton("6")
        mtbCode.Text = Code
    End Sub

    Private Sub btn7PQRS_Click(sender As Object, e As EventArgs) Handles btn7PQRS.Click
        AddButton("7")
        mtbCode.Text = Code
    End Sub

    Private Sub btn8TUV_Click(sender As Object, e As EventArgs) Handles btn8TUV.Click
        AddButton("8")
        mtbCode.Text = Code
    End Sub

    Private Sub btn9WXYZ_Click(sender As Object, e As EventArgs) Handles btn9WXYZ.Click
        AddButton("9")
        mtbCode.Text = Code
    End Sub

    'Checks to see if push-button code is greater than 4 and limits max length to 4
    Function AddButton(Num As String)
        If Code.Length < 4 Then
            Code += Num
        Else
            Code = Code
            MessageBox.Show("The Look up code cannot be longer than 4. Please press " &
                            "'Look Up Another Person' to enter in another code.", "Error")
        End If
        Return Code
    End Function

    'Clear Data grid and text box set Code to null
    Private Sub btnNewPerson_Click(sender As Object, e As EventArgs) Handles btnNewPerson.Click
        mtbCode.Clear()
        dgvDirectory.DataSource = Nothing
        Code = ""
    End Sub

    'User instructions
    Private Sub btnGetInstructions_Click(sender As Object, e As EventArgs) Handles btnGetInstructions.Click
        MessageBox.Show("Enter the first three letters of the person's last name" &
                        " followed by the first letter of the person's first name", "Instructions")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("The program will now close.", "Confirm")
        Me.Close()
    End Sub

End Class
