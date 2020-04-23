Public Class Form1

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Dim mA As Integer
        Dim efecto As String
        Dim motivo As String

        mA = Val(txtmA.Text)
        If mA < 1 Then
            efecto = "Ninguno"
            motivo = "No se percibe la electricidad"
            pcbImagen.Image = pcbNinguno.Image
        ElseIf mA < 3 Then
            efecto = "Percepción"
            motivo = "El paso de la corriente produce cosquilleo. No existe peligro"
            pcbImagen.Image = pcbPercepcion.Image
        ElseIf mA < 10 Then
            efecto = "Electrización"
            motivo = "El paso de la corriente produce movimientos reflejos"
            pcbImagen.Image = pcbElectrizacion.Image
        ElseIf mA < 20 Then
            efecto = "Tetanización"
            motivo = "El paso de la corriente provoca contracciones musculares, agarrotamiento"
            pcbImagen.Image = pcbTetanizacion.Image
        ElseIf mA < 25 Then
            efecto = "Paro respiratorio"
            motivo = "Si la corriente atraviesa el cerebro"
            pcbImagen.Image = pcbParo.Image
        ElseIf mA < 60 Then
            efecto = "Asfixia"
            motivo = "Si la corriente atraviesa el torax"
            pcbImagen.Image = pcbAsfixia.Image
        ElseIf mA < 70 Then
            efecto = "Fibrilación ventricular"
            motivo = "Si la corriente atraviesa el corazon"
            pcbImagen.Image = pcbFibrilacion.Image
        Else
            efecto = "Muerte"
            motivo = "Instantanea"
            pcbImagen.Image = pcbMuerte.Image
        End If
        txtEfecto.Text = efecto
        txtMotivo.Text = motivo
    End Sub

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        txtmA.Text = " "
        txtEfecto.Text = " "
        txtMotivo.Text = " "
        pcbImagen.Image = pcbNinguno.Image
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
