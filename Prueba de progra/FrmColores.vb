Public Class FrmColores
    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        txtColores.Backcolor = Color.Red
    End Sub

    Private Sub btnAzul_Click(sender As Object, e As EventArgs) Handles btnAzul.Click
        txtColores.Backcolor = Color.Blue
    End Sub

    Private Sub btnVerde_Click(sender As Object, e As EventArgs) Handles btnVerde.Click
        txtColores.BackColor = Color.Green
    End Sub

    Private Sub btnAnaranjado_Click(sender As Object, e As EventArgs) Handles btnAnaranjado.Click
        txtColores.BackColor = Color.Orange
    End Sub

    Private Sub btnRosado_Click(sender As Object, e As EventArgs) Handles btnRosado.Click
        txtColores.BackColor = Color.Pink
    End Sub
End Class
