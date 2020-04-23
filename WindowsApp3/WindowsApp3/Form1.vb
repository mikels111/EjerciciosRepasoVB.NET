Public Class Form1
    Private llantas As Integer = 0
    Private asientos As Integer = 0
    Private Gps As Integer = 0
    Private faros As Integer = 0
    Private porta As Integer = 0
    Private reposa As Integer = 0
    Dim electrico As Integer = 0
    Dim total As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim modelo As Integer

        modelo = lstModelos.SelectedIndex
        txtIva.Text = "21%"

        Select Case modelo
            Case 0
                txtPrecio.Text = "10000"
            Case 1
                txtPrecio.Text = "14000"
            Case 2
                txtPrecio.Text = "41000"
            Case 3
                txtPrecio.Text = "18000"
            Case 4
                txtPrecio.Text = "22000"
            Case 5
                txtPrecio.Text = "9000"
        End Select

        Dim iva As Integer = txtPrecio.Text * 0.21
        total = txtPrecio.Text + llantas + asientos + Gps + faros + porta + reposa - electrico + iva
        txtTotal.Text = total


    End Sub

    Private Sub lstModelos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModelos.SelectedIndexChanged
        pcbImagen.Image = ilsCoches.Images(lstModelos.SelectedIndex)
    End Sub

    Private Sub chkLlantas_CheckedChanged(sender As Object, e As EventArgs) Handles chkLlantas.CheckedChanged
        If chkLlantas.Checked Then
            llantas = 400
        Else
            llantas = 0
        End If
    End Sub

    Private Sub chkAsientos_CheckedChanged(sender As Object, e As EventArgs) Handles chkAsientos.CheckedChanged
        If chkAsientos.Checked Then
            asientos = 300
        Else
            asientos = 0
        End If
    End Sub

    Private Sub chkGps_CheckedChanged(sender As Object, e As EventArgs) Handles chkGps.CheckedChanged
        If chkGps.Checked Then
            Gps = 100
        Else
            Gps = 0
        End If
    End Sub

    Private Sub chkFaros_CheckedChanged(sender As Object, e As EventArgs) Handles chkFaros.CheckedChanged
        If chkFaros.Checked Then
            faros = 200
        Else
            faros = 0
        End If
    End Sub

    Private Sub chkPortaEquipajes_CheckedChanged(sender As Object, e As EventArgs) Handles chkPortaEquipajes.CheckedChanged
        If chkPortaEquipajes.Checked Then
            porta = 90
        Else
            porta = 0
        End If
    End Sub

    Private Sub chkReposa_CheckedChanged(sender As Object, e As EventArgs) Handles chkReposa.CheckedChanged
        If chkReposa.Checked Then
            reposa = 60
        Else
            reposa = 0
        End If
    End Sub

    Private Sub rdbElectrico_CheckedChanged(sender As Object, e As EventArgs) Handles rdbElectrico.CheckedChanged
        electrico = txtPrecio.Text * 0.2
        txtDescuento.Text = "-20%"
    End Sub

    Private Sub rdbDiesel_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDiesel.CheckedChanged

    End Sub

    Private Sub rdbGasolina_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGasolina.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstModelos.SelectedIndex = 0
    End Sub

End Class
