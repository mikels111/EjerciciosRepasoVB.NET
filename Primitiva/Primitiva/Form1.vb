Public Class Form1
    Dim boxSorteo(6) As Integer
    Dim i As Integer
    Private Sub marcados(sender As Object)
        Dim box As CheckBox
        If sender = 6 Then
            For Each box In pnlBoxUsuario.Controls
                If box.Checked = True Then
                    box.Checked = False
                End If
            Next

        End If
    End Sub

    Private Sub sorteo(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aleatorio As Integer

        i = 0
        For Each sorteos In pnlBoxesSorteo.Controls
            sorteos.text = Int((49 * Rnd()) + 1)
            boxSorteo(i) = sorteos.text
            i = i + 1
        Next

        Dim box_usuario As CheckBox
        Dim num As Integer
        Dim n As Integer
        Dim encontrado As Boolean
        Dim aciertos As Integer
        aciertos = 0
        Dim contador As Integer = 0


        For Each box_usuario In pnlBoxUsuario.Controls
            If box_usuario.Checked Then
                n = Int(box_usuario.Text)
                i = 0
                encontrado = False
                Do While Not encontrado And i < 6
                    If n = boxSorteo(i) Then
                        encontrado = True
                        aciertos = aciertos + 1
                    End If
                    i = i + 1

                Loop
                contador = contador + 1
            End If
        Next
        txtAciertos.Text = aciertos
        marcados(i)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub nuevo()
        For Each num In pnlBoxUsuario.Controls
            num.checked = False
        Next

        For Each num In pnlBoxesSorteo.Controls
            num.Text = ""
        Next
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevo()
    End Sub


End Class
