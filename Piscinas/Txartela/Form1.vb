Public Class txartela
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim importe As Integer
        Dim descuento1 As Integer
        Dim descuento2 As Integer

        If rdbIndividual.Checked Then
            importe = 100
        ElseIf rdbFamiliar.Checked Then
            importe = 200
        ElseIf rdbJubilado.Checked Then
            importe = 75
        ElseIf rdbInfantil.Checked Then
            importe = 50
        End If

        If chkFamiliaNumerosa.Checked Then
            descuento1 = importe * (10 / 100)
        End If

        If chkDiscapacitados.Checked Then
            descuento2 = importe * (50 / 100)
        End If

        txtImporte.Text = importe - descuento1 - descuento2

    End Sub
End Class
