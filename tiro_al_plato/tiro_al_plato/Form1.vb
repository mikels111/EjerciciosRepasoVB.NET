Public Class Form1
    Dim coordenadas As Point
    Dim ix As Integer
    Dim iy As Integer
    Dim contadorPlatos As Integer
    Dim contadorRotos As Long

    Private Sub disparar()

        contadorPlatos += 1
        txtPlatosLanzados.Text = contadorPlatos

        pcbPlato.Visible = True
        coordenadas.X = Panel2.Size.Width / 2 - pcbPlato.Size.Width / 2
        coordenadas.Y = Panel2.Size.Height - pcbPlato.Size.Height


        pcbPlato.Location = coordenadas

        ix = Int(90 * Rnd() - 40)
        iy = Int(10 * Rnd() + 20)

        tmrPlatos.Start()

        If contadorPlatos = 10 Then
            noHayPlatos()
        End If

    End Sub

    Private Sub noHayPlatos()


        txtPlatosLanzados.Text = 0
        tmrPlatos.Stop()
        pcbPlato.Visible = False
        pcbRoto.Visible = False
        MsgBox("No quedan platos, has roto " & CStr(txtPlatosRotos.Text))

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click

        disparar()
        contadorRotos = 0
        contadorPlatos = 0
        txtPlatosLanzados.Text = 0
        txtPlatosRotos.Text = 0
    End Sub

    Private Sub tmrPlatos_Tick(sender As Object, e As EventArgs) Handles tmrPlatos.Tick

        If pcbRoto.Visible = True Then
            pcbRoto.Visible = False
        End If

        coordenadas.X += ix
        coordenadas.Y -= iy

        pcbPlato.Location = coordenadas

        If coordenadas.X < 0 Or coordenadas.X > Panel2.Size.Width Or coordenadas.Y < 0 Then
            disparar()
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        contadorPlatos = 0
        txtPlatosLanzados.Text = contadorPlatos


        pcbRoto.Visible = False
        pcbPlato.Visible = False
        Randomize()

    End Sub

    Private Sub pcbPlato_Click(sender As Object, e As EventArgs) Handles pcbPlato.Click
        platoRoto()

    End Sub

    Private Sub platoRoto()

        pcbRoto.Visible = True
        pcbRoto.Location = pcbPlato.Location
        pcbPlato.Visible = False
        contadorRotos += 1
        txtPlatosRotos.Text = contadorRotos

    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        End
    End Sub
End Class
