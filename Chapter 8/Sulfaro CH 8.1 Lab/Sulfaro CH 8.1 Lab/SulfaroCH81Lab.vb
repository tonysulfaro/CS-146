Public Class SulfaroCH81Lab

    'Anthony Sulfaro
    'Nancy Samolewski
    'CS 146.04
    '11/29/16
    'CH 8.1 Lab

    'EX 8.1.1
    Private Sub btn811Sort_Click(sender As Object, e As EventArgs) Handles btn811Sort.Click

        'Before
        Dim agesAtInaug() As String = IO.File.ReadAllLines("AgeAtInaug.txt")
        Dim query = From line In agesAtInaug
                    Let age = CInt(line.Split(","c)(1))
                    Order By age
                    Select line
        IO.File.WriteAllLines("Sorted.txt", query)

        For i As Integer = 0 To agesAtInaug.Length - 1
            lst811Before.Items.Add(agesAtInaug(i))
        Next

        'After
        Dim agesAtInaugSorted() As String = IO.File.ReadAllLines("Sorted.txt")
        Dim querySorted = From line In agesAtInaugSorted
                          Let age = CInt(line.Split(","c)(1))
                          Select line

        For i As Integer = 0 To agesAtInaugSorted.Length - 1
            lst811After.Items.Add(agesAtInaugSorted(i))
        Next

    End Sub

    'EX 8.1.2
    Private Sub btn812Sort_Click(sender As Object, e As EventArgs) Handles btn812Sort.Click

        Dim agesAtInaug() As String = IO.File.ReadAllLines("AgeAtInaug.txt")
        Dim query = From line In agesAtInaug
                    Let name = line.Split(","c)(0)
                    Let age = CInt(line.Split(","c)(1))
                    Order By age
                    Select name, age
        dgv812Output.DataSource = query.ToList
        dgv812Output.CurrentCell = Nothing
    End Sub

    'EX 8.1.5
    Dim firstSet() As String = IO.File.ReadAllLines("File1.txt")
    Dim secondSet() As String = IO.File.ReadAllLines("File2.txt")

    Dim Concat() As String = IO.File.ReadAllLines("Concat.txt")
    Dim Union() As String = IO.File.ReadAllLines("Union.txt")
    Dim Intersect() As String = IO.File.ReadAllLines("Intersect.txt")
    Dim Except() As String = IO.File.ReadAllLines("Except.txt")

    Private Sub btn815Concat_Click(sender As Object, e As EventArgs) Handles btn815Concat.Click
        IO.File.WriteAllLines("Concat.txt", firstSet.Concat(secondSet))

        For i As Integer = 0 To Concat.Length - 1
            lst815Concat.Items.Add(Concat(i))
        Next
    End Sub

    Private Sub btn815Union_Click(sender As Object, e As EventArgs) Handles btn815Union.Click
        IO.File.WriteAllLines("Union.txt", firstSet.Union(secondSet))

        For i As Integer = 0 To Union.Length - 1
            lst815Union.Items.Add(Union(i))
        Next
    End Sub

    Private Sub btn815Intersect_Click(sender As Object, e As EventArgs) Handles btn815Intersect.Click
        IO.File.WriteAllLines("Intersect.txt", firstSet.Intersect(secondSet))

        For i As Integer = 0 To Intersect.Length - 1
            lst815Inter.Items.Add(Intersect(i))
        Next
    End Sub

    Private Sub btn815Except_Click(sender As Object, e As EventArgs) Handles btn815Except.Click
        IO.File.WriteAllLines("Except.txt", firstSet.Except(secondSet))

        For i As Integer = 0 To Except.Length - 1
            lst815Except.Items.Add(Except(i))
        Next
    End Sub

    'EX 8.1.9
    Private Sub btn819Select_Click(sender As Object, e As EventArgs) Handles btn819Select.Click

        Dim textFile As String
        ofd819Select.ShowDialog()

        textFile = ofd819Select.FileName
        lst819Output.DataSource = IO.File.ReadAllLines(textFile)
        lst819Output.SelectedItem = Nothing

    End Sub
End Class
