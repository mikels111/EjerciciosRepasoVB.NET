Public Class Form1
    Dim PuntosUser As Integer
    Dim PuntoIa As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For Each imagen In pnlImagenes.Controls
        '    imagen.image = ImageList1.Images(int(imagen.tag))
        'Next
        pcbPiedra.Image = ImageList1.Images(0)
        pcbPapel.Image = ImageList1.Images(1)
        pcbTijera.Image = ImageList1.Images(2)
        inicio()
        Randomize()
    End Sub

    Private Sub Cosa(Sender As Object, e As EventArgs)
        Const PUNTMAX As Integer = 3
        Dim eleccionRandom As Integer
        Dim EleccionUsuario As Integer
        EleccionUsuario = Val(Sender.tag)
        eleccionRandom = Int((2 - 0 + 1) * Rnd() + 0)
        pcbIa.Image = ImageList1.Images(eleccionRandom)

        Select Case EleccionUsuario
            Case 0
                Select Case eleccionRandom
                    Case 0
                        MsgBox("Empate")
                    Case 1
                        PuntoIa = PuntoIa + 1
                        txtIa.Text = PuntoIa
                    Case 2
                        PuntosUser = PuntosUser + 1
                        txtUser.Text = PuntosUser

                End Select

            Case 1
                Select Case eleccionRandom
                    Case 0
                        PuntosUser = PuntosUser + 1
                        txtUser.Text = PuntosUser
                    Case 1
                        MsgBox("Empate")
                    Case 2
                        PuntoIa = PuntoIa + 1
                        txtIa.Text = PuntoIa


                End Select
            Case 2
                Select Case eleccionRandom
                    Case 0
                        PuntoIa = PuntoIa + 1
                        txtIa.Text = PuntoIa
                    Case 1
                        PuntosUser = PuntosUser + 1
                        txtUser.Text = PuntosUser
                    Case 2
                        MsgBox("Empate")



                End Select

        End Select
        If PuntoIa = PUNTMAX Or PuntosUser = PUNTMAX Then
            MsgBox("se  acabo")
            inicio()
        End If
    End Sub
    Private Sub inicio()
        PuntosUser = 0
        PuntoIa = 0
        txtIa.Text = PuntoIa
        txtUser.Text = PuntosUser
    End Sub
End Class
