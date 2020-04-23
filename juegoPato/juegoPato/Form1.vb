Public Class Form1
    Dim coordenadas As Point
    Dim coordenadas2 As Point
    Dim puntos As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrPato.Tick
        coordenadas.X += 50
        pcbAmarillo.Location = coordenadas

        coordenadas2.X -= 10
        pcbRojo.Location = coordenadas2

        If coordenadas.X > Me.Size.Width Then
            coordenadas.X = 0
        End If

        If coordenadas2.X < Me.Size.Width Then
            coordenadas2.X = 
        End If
    End Sub
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        tmrPato.Start()
        tmrFinJuego.Start()
        pcbAmarillo.Visible = True
        pcbRojo.Visible = True


        coordenadas.Y = Panel1.Location.Y + Panel1.Height
        pcbAmarillo.Location = coordenadas


        coordenadas2.Y = Panel1.Location.Y + Panel1.Height + 160

        pcbRojo.Location = coordenadas2


    End Sub


    Private Sub tmrFinJuego_Tick(sender As Object, e As EventArgs) Handles tmrFinJuego.Tick

    End Sub

    Private Sub pcbAmarillo_Click(sender As Object, e As EventArgs) Handles pcbAmarillo.Click
        puntos += 1
        txtPuntos.Text = puntos

        If puntos = 10 Then

            MsgBox("Fin del juego")

        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub
End Class
