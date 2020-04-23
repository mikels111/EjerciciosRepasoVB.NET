Public Class publico
    Private Sub publico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim aleatorio As Integer
        Dim aleatorio2 As Integer
        Dim respuesta_correcta As Integer
        respuesta_correcta = porcentajePublico.respuesta_correcta
        aleatorio = Int(Rnd() * (10 - 1 + 1)) + 1
        If aleatorio > 3 Then
            Label2.Text = respuesta_correcta
        Else
            aleatorio2 = Int(Rnd() * (4 - 1 + 1)) + 1
            While aleatorio2 = respuesta_correcta
                aleatorio2 = Int(Rnd() * (4 - 1 + 1)) + 1
            End While
            Label2.Text = aleatorio2
        End If
    End Sub
End Class