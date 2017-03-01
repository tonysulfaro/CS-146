Imports System.IO

Public Class SulfaroCH82Lab

    'Anthony Sulfaro
    'Nancy Samolewski
    'CS 146.04
    'CH 8.2 Lab

    'EX 8.2.1
    Private Sub btn821Find_Click(sender As Object, e As EventArgs) Handles btn821Find.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("USStates.txt")
        Dim abbr As String = mtb821Abbr.Text.ToUpper
        Dim line As String
        Dim foundFlag As Boolean = False
        Do Until foundFlag Or sr.EndOfStream
            line = sr.ReadLine
            If line.Split(","c)(1) = abbr Then
                txt821Name.Text = line.Split(","c)(0)
                foundFlag = True
            End If
        Loop
        If Not foundFlag Then
            Dim str As String = " is not a valid state abbreviation."
            MessageBox.Show(mtb821Abbr.Text.ToUpper & str, "Error")
            mtb821Abbr.Clear()
            mtb821Abbr.Focus()
        End If
        sr.Close()
    End Sub

    'EX 8.2.2
    Private Sub btn822CreateFile_Click(sender As Object, e As EventArgs) Handles btn822CreateFile.Click

        Dim sw As IO.StreamWriter = IO.File.CreateText("Pioneers.txt")
        sw.WriteLine("Atanasoff")
        sw.WriteLine("Babbage")
        sw.WriteLine("Codd")
        sw.WriteLine("Dijkstra")
        sw.WriteLine("Eckert")
        sw.WriteLine("Faggin")
        sw.WriteLine("Gates")
        sw.WriteLine("Hollerith")
        sw.Close()
        MessageBox.Show("Names recorded in file", "File Status")
    End Sub

    Private Sub btn822DisplayFile_Click(sender As Object, e As EventArgs) Handles btn822DisplayFile.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("Pioneers.txt")
        lst822Names.Items.Clear()
        Do Until sr.EndOfStream
            lst822Names.Items.Add(sr.ReadLine)
        Loop
    End Sub

    'EX 8.2.3
    Private Sub btn823Add_Click(sender As Object, e As EventArgs) Handles btn823Add.Click

        Dim person As String = txt823Name.Text
        If person <> "" Then
            If IsInFile(person) Then
                MessageBox.Show(person & " is already in the file.", "Alert")
            Else
                Dim sw As StreamWriter = File.AppendText("Names.txt")
                sw.WriteLine(person)
                sw.Close()
                MessageBox.Show(person & " added to file.", "Name Added")
                txt823Name.Clear()
                txt823Name.Focus()
            End If
        Else
            MessageBox.Show("You must enter a name.", "Information Incomplete")
        End If
    End Sub

    Private Sub btn823Determine_Click(sender As Object, e As EventArgs) Handles btn823Determine.Click

        Dim person As String = txt823Name.Text
        If person <> "" Then
            If isinfile(person) Then
                MessageBox.Show(person & " is in the file.", "Yes")
            Else
                MessageBox.Show(person & " is not in the file.", "No")
            End If
        Else
            MessageBox.Show("You must enter a name.", "Information Incomplete")
        End If
        txt823Name.Clear()
        txt823Name.Focus()
    End Sub

    Private Sub btn823Delete_Click(sender As Object, e As EventArgs) Handles btn823Delete.Click

        Dim person As String = txt823Name.Text
        If person <> "" Then
            If IsInFile(person) Then
                Dim sr As StreamReader = File.OpenText("Names.txt")
                Dim sw As StreamWriter = File.CreateText("Temp.txt")
                Dim individual As String
                Do Until sr.EndOfStream
                    individual = sr.ReadLine
                    If individual <> person Then
                        sw.WriteLine(individual)
                    End If
                Loop
                sr.Close()
                sw.Close()
                File.Delete("Names.txt")
                File.Move("Temp.txt", "Names.txt")
                MessageBox.Show(person & " removed from file.", "Name Removed")
            Else
                MessageBox.Show(person & " is not in the file.", "Name not Found")
            End If
        Else
            MessageBox.Show(person & " is not in the file.", "Information Incomplete")
        End If
        txt823Name.Clear()
        txt823Name.Focus()
    End Sub

    Function IsInFile(person As String) As Boolean
        If File.Exists("Names.txt") Then
            Dim sr As StreamReader = File.OpenText("Names.txt")
            Dim individual As String
            Do Until sr.EndOfStream
                individual = sr.ReadLine
                If individual = person Then
                    sr.Close()
                    Return True
                End If
            Loop
            sr.Close()
        End If
        Return False
    End Function

    'EX 8.2.4
    Private Sub btn824Display_Click(sender As Object, e As EventArgs) Handles btn824Display.Click

        Dim sr As IO.StreamReader
        Dim message As String
        Try
            sr = IO.File.OpenText("F:\DataFiles\USPres.txt")
            message = "The first president was " & sr.ReadLine & "."
            MessageBox.Show(message, "President")
        Catch exp As IO.FileNotFoundException
            message = "The file is not in the specified folder of the flash drive."
            MessageBox.Show(message, "Error")
        Catch exp As IO.IOException
            message = "Check to see if there is a flash drive in drive F:."
            MessageBox.Show(message, "Error")
        Finally
            Try
                sr.Close()
            Catch
            End Try
        End Try
    End Sub
End Class
