Public Class frmCH32Demo

    'Anthony Sulfaro
    'CS 146.04
    'CH 3.2 Demo
    'Purpose is to learn and demonstrate string manipulation

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click


        Dim str As String = "Visual Basic"
        Dim n As Integer = str.IndexOf(" ")
        Dim firstword As String = str.Substring(0, n)
        Dim lastword As String = str.Substring(n + 1)

        lstBox.Items.Add(firstword)
        lstBox.Items.Add(lastword)


    End Sub
End Class
