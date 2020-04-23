Public Class Form1
    Private Sub btnRevisar_Click(sender As Object, e As EventArgs) Handles btnRevisar.Click
        Dim suma1 As Integer
        Dim suma2 As Integer
        Dim total As Integer
        Dim respuesta As Integer
        Dim nota As String

        suma1 = Val(txtSuma1.Text)
        suma2 = Val(txtSuma2.Text)
        respuesta = Val(txtTotal.Text)

        total = suma1 + suma2

        If total = respuesta Then
            nota = "Bien"
            pcbImagen.Image = pcbFeliz.Image
        Else
            nota = "Mal"
            pcbImagen.Image = pcbTriste.Image
        End If

        txtNota.Text = nota
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnOtra_Click(sender As Object, e As EventArgs) Handles btnOtra.Click
        Dim suma1 As Integer
        Dim suma2 As Integer


        suma1 = Int(Rnd() * 10) + 1
        suma2 = Int(Rnd() * 10) + 1

        txtSuma1.Text = suma1
        txtSuma2.Text = suma2
    End Sub
End Class
