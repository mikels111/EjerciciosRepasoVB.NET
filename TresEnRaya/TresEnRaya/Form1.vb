Public Class Form1
    Dim turno As Integer
    Dim tabla(2, 2) As Integer
    Dim contador As Integer

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        iniciar()
    End Sub
    Private Sub iniciarImagenes()

        For Each imagen In pnlJuego.Controls
            imagen.enabled = True
            imagen.image = ilsImagenes.Images(0)
        Next
    End Sub

    Private Sub bloquearImagenes()

        For Each imagen In pnlJuego.Controls
            imagen.enabled = False
            imagen.image = ilsImagenes.Images(0)
        Next
        btnInicio.Enabled = True
    End Sub

    Private Sub iniciar()
        turno = 1
        contador = 0
        btnInicio.Enabled = False

        iniciarImagenes()

        For i = 0 To 2
            For j = 0 To 2
                tabla(i, j) = 0
            Next
        Next

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub pcbnn_Click(sender As Object, e As EventArgs) Handles pcb00.Click, pcb01.Click, pcb02.Click, pcb10.Click, pcb11.Click, pcb12.Click, pcb20.Click, pcb21.Click, pcb22.Click
        contador = contador + 1
        sender.enabled = False
        sender.Image = ilsImagenes.Images(turno)


        Dim n As Integer
        Dim c As Integer
        Dim f As Integer
        n = Val(sender.tag)
        c = n Mod 3
        f = Int(n / 3)

        tabla(f, c) = turno
        gana(turno)
        turno = IIf(turno = 1, 2, 1)

        'If turno = 1 Then
        '    turno = 2
        'Else
        '    turno = 1
        'End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloquearImagenes()

    End Sub
    Private Sub gana(ByVal turno As Integer)

        If tabla(0, 0) = turno And tabla(0, 1) = turno And tabla(0, 2) = turno Or
           tabla(1, 0) = turno And tabla(1, 1) = turno And tabla(1, 2) = turno Or
           tabla(2, 0) = turno And tabla(2, 1) = turno And tabla(2, 2) = turno Or
           tabla(0, 0) = turno And tabla(1, 0) = turno And tabla(2, 0) = turno Or
           tabla(0, 1) = turno And tabla(1, 1) = turno And tabla(2, 1) = turno Or
           tabla(0, 2) = turno And tabla(1, 2) = turno And tabla(2, 2) = turno Or
           tabla(0, 0) = turno And tabla(1, 1) = turno And tabla(2, 2) = turno Or
           tabla(0, 2) = turno And tabla(1, 1) = turno And tabla(2, 0) = turno Then
            MsgBox("Has ganado")
            iniciar()
            bloquearImagenes()
        ElseIf contador = 9 Then
            MsgBox("Empate")
            iniciar()
            bloquearImagenes()
        End If

    End Sub
End Class
'pcb00.Enabled = True
'pcb01.Enabled = True
'pcb02.Enabled = True
'pcb10.Enabled = True
'pcb11.Enabled = True
'pcb12.Enabled = True
'pcb20.Enabled = True
'pcb21.Enabled = True
'pcb22.Enabled = True
'pcb00.Image = ilsImagenes.Images(0)
'pcb01.Image = ilsImagenes.Images(0)
'pcb02.Image = ilsImagenes.Images(0)
'pcb10.Image = ilsImagenes.Images(0)
'pcb11.Image = ilsImagenes.Images(0)
'pcb12.Image = ilsImagenes.Images(0)
'pcb20.Image = ilsImagenes.Images(0)
'pcb21.Image = ilsImagenes.Images(0)
'pcb22.Image = ilsImagenes.Images(0)
