Public Class Form1

    Private Sub lstMoviles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMoviles.SelectedIndexChanged
        pcbMovil.Image = ilsMoviles.Images(lstMoviles.SelectedIndex)
        Select Case lstMoviles.SelectedIndex
            Case 0
                txtDescripcion.Text = "Nuevo galaxy s10; está to guapo"
            Case 1
                txtDescripcion.Text = "Demasiado caro"
            Case 2
                txtDescripcion.Text = "Pantalla más pequeña"
            Case 3
                txtDescripcion.Text = "Movil más pequeño"
            Case 4
                txtDescripcion.Text = "Blackberry clasica"
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstMoviles.SelectedIndex = 2

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub


End Class
