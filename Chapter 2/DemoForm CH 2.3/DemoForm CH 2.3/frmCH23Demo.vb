Public Class frmCH23Demo

    Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged

        txtFirst.ForeColor = Color.Blue

    End Sub

    Private Sub txtFirst_Leave(sender As Object, e As EventArgs) Handles txtFirst.Leave

        txtFirst.ForeColor = Color.Black

    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click

        txtFirst.ForeColor = Color.Red
        txtSecond.ForeColor = Color.Green

    End Sub

    Private Sub txtFirst_Enter(sender As Object, e As EventArgs) Handles txtFirst.Enter

        txtFirst.ForeColor = Color.Blue

    End Sub

End Class
