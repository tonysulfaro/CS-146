Imports System.IO
Public Class frmPhone

    ' Program: CH8-PP-4
    ' Name: Anthony Sulfaro
    ' Date: 12/4/16
    ' Class: CS146.04
    ' Program Def: Generates and displays phone directories given user input..

    Structure Person
        Dim name As String
        Dim number As String
    End Structure

    Dim people() As Person

    'Load time
    Private Sub frmPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'read directories.txt
        Dim Directories() As String = File.ReadAllLines("Directories.txt")
        'query to readalllines and sort by name

        'display directories in list box
        For i As Integer = 0 To Directories.Length - 1
            lstFiles.Items.Add(Directories(i))
        Next
    End Sub

    'Create a new phone directory
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        'Define a directory array to store current directories text file
        'Use InputBox to “Enter a file name.”
        Dim fileName As String = InputBox("Enter in the name for the new file", "Enter File Name")
        Dim n As Integer = fileName.Length

        If fileName.Substring(n - 4, 4) = ".txt" Then
            fileName = fileName
        Else
            fileName += ".txt"
        End If
        'Check the directory array to see if new files already exist if so, display error message
        'Use StreamWriter to append to directories text file
        'Close StreamWriter files
        If fileName <> "" Then
            If IsInFile(fileName) Then
                MessageBox.Show(fileName & " is already in the file.", "Yes")
            Else
                'Use StreamWriter to .Create new text file
                'Display directories in list box
                Dim swCreate As StreamWriter = File.CreateText(fileName)
                lstFiles.Items.Add(fileName)
                swCreate.Close()

                Dim swAddToDir As StreamWriter = File.AppendText("Directories.txt")
                swAddToDir.WriteLine(fileName)
                swAddToDir.Close()
            End If
        Else
            MessageBox.Show("You must enter a file name.", "Information Incomplete")
        End If
    End Sub

    'Add person and number to file
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Test for null value in txtName And txtPhoneNumber
        'If null Then, display message To enter name And phone number
        Dim name As String = CStr(txtName.Text)
        Dim number As String = CStr(mtbPhoneNumber.Text)
        Dim currentDir As String = CStr(txtDirectory.Text)
        If name = "" Or number = "" Then
            MessageBox.Show("Please enter in the person's name and/or phone number.", "Enter Information")
        Else
            'Use StreamWriter to .append to text file
            Dim swName As StreamWriter = File.AppendText(currentDir)
            swName.WriteLine(name & "," & number)
            swName.Close()
            txtName.Clear()
            mtbPhoneNumber.Clear()

            MessageBox.Show("The person has been added to " & currentDir & " telephone directory.", "Person Added")
        End If

        dgvOutput.Columns.Clear()
        DisplayData()

    End Sub

    'remove person and number from file
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        'Text for null value in txtName if so, display message to enter name
        'Enter Name to be deleted in txtName
        Dim person As String = CStr(txtName.Text)
        Dim number As String = CStr(mtbPhoneNumber.Text)
        Dim currentDir As String = CStr(txtDirectory.Text)

        If person <> "" Then
            If PersonIsInFile(person) Then
                Dim sr As StreamReader = File.OpenText(currentDir)
                Dim sw As StreamWriter = File.CreateText("Temp.txt")
                Dim individual, fullInfo As String
                Do Until sr.EndOfStream
                    fullInfo = sr.ReadLine
                    individual = fullInfo.Split(","c)(0)
                    If individual <> person Then
                        sw.WriteLine(individual)
                    End If
                Loop
                sr.Close()
                sw.Close()
                File.Delete(currentDir)
                File.Move("Temp.txt", currentDir)
                MessageBox.Show(person & " removed from file.", "Name Removed")
            Else
                MessageBox.Show(person & " is not in the file.", "Name not Found")
            End If
        Else
            MessageBox.Show(person & " is not in the file.", "Information Incomplete")
        End If

        txtName.Clear()
        mtbPhoneNumber.Clear()
        dgvOutput.Columns.Clear()
        DisplayData()
        'Use query to ReadAllLines from selected directory text file
        'Use where option to omit name to delete

        'WriteAllLines back out to text file
        'Clear txtName & txtPhoneNumber boxes
        'Use Message box to display deleted message
    End Sub

    'Display all people in file
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        DisplayData()
    End Sub

    Sub DisplayData()

        'select file from directory list
        'check that directory exists else display message to select 
        Dim currentDir As String = CStr(txtDirectory.Text)
        Dim Directory() As String = File.ReadAllLines(currentDir)
        Dim n As Integer = Directory.Count - 1
        ReDim people(n)
        Dim line As String
        Dim data(1) As String

        For i As Integer = 0 To n
            line = Directory(i)
            data = line.Split(","c)
            people(i).name = data(0)
            people(i).number = data(1)
        Next

        'query to readall lines from selected directory text file
        'sort records by name
        Dim query = From person In people
                    Order By person.name
                    Select person.name, person.number


        'display names and phone numbers with data grid view
        dgvOutput.DataSource = query.ToList
        dgvOutput.CurrentCell = Nothing

        dgvOutput.Columns("name").HeaderText = "Name"
        dgvOutput.Columns("number").HeaderText = "Phone Number"
    End Sub

    'Checks to see if directory is in file
    Function IsInFile(fileName As String) As Boolean
        If File.Exists("Directories.txt") Then
            Dim sr As StreamReader = File.OpenText("Directories.txt")
            Dim individual As String
            Do Until sr.EndOfStream
                individual = sr.ReadLine
                If individual = fileName Then
                    sr.Close()
                    Return True
                End If
            Loop
            sr.Close()
        End If
        Return False
    End Function

    'Checks if person is in file
    Function PersonIsInFile(Name As String) As Boolean
        Dim currentDir As String = CStr(txtDirectory.Text)
        If File.Exists(currentDir) Then
            Dim sr As StreamReader = File.OpenText(currentDir)
            Dim fullInfo, personName As String
            Do Until sr.EndOfStream
                fullInfo = sr.ReadLine
                personName = fullInfo.Split(","c)(0)
                If personName = Name Then
                    sr.Close()
                    Return True
                End If
            Loop
            sr.Close()
        End If
        Return False
    End Function



    'Handles Current directory name
    Private Sub lstFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFiles.SelectedIndexChanged
        txtDirectory.Text = lstFiles.SelectedItem
    End Sub
End Class
