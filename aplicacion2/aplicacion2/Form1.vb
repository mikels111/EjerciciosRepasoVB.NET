Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim altura As Decimal
        Dim peso As Decimal
        Dim imc As Decimal

        altura = Val(txtAltura.Text)
        peso = Val(txtPeso.Text)


        imc = peso / (altura * altura)
        txtImc.Text = imc

        If imc < 18.5 Then
            pcbImagen.Image = pcbFlaco.Image
        ElseIf imc < 24.9 Then
            pcbImagen.Image = pcbNormal.Image
        ElseIf imc < 29.9 Then
            pcbImagen.Image = pcbSobrepeso.Image
        Else
            pcbNormal.Image = pcbObesidad.Image
        End If




    End Sub


End Class
