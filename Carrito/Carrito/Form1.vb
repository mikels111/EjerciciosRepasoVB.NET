Public Class Carrito

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim producto As String

        producto = lstArticulos.Items(lstArticulos.SelectedIndex)
        lstCarrito.Items.Add(producto)
        lstArticulos.Items.Remove(producto)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim compra As String

        compra = lstCarrito.Items(lstCarrito.SelectedIndex)
        lstArticulos.Items.Add(compra)
        lstCarrito.Items.Remove(compra)
    End Sub


End Class
