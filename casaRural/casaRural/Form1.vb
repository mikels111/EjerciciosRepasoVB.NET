Public Class bntDer
    Dim numImage As Integer
    Dim puls1 As Boolean


    Private Function cuenta() As Integer
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CasaRural.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "selection count(*) from registros where #" & dtpEntrada.Value.Date & "#"


            Dim contador As Integer
            contador = cmd.ExecuteScalar
            Return contador
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numImage = 0
        pcb1.Image = imlImagenes.Images(numImage)
        pcb2.Image = imlImagenes.Images(numImage + 1)
        pcb3.Image = imlImagenes.Images(numImage + 2)
        pcb4.Image = imlImagenes.Images(numImage + 3)

    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\casarural.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "insert into reservas(entrada,salida,nombre)
                                       values('" + dtpEntrada.Value.Date + "','" + dtpSalida.Value.Date + "','" + txtNombre.Text + "')"


            Dim contador As Integer
            contador = cmd.ExecuteNonQuery

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub pcb_Click(sender As Object, e As EventArgs) Handles pcb1.Click, pcb2.Click, pcb3.Click, pcb4.Click
        pcbCentral.Image = sender.image
    End Sub

    Private Sub btnDer_Click(sender As Object, e As EventArgs) Handles btnDer.Click
        puls1 = False
        pcb1.Image = imlImagenes.Images(numImage + 4)
        pcb2.Image = imlImagenes.Images(numImage + 5)
        pcb3.Image = imlImagenes.Images(numImage + 6)
        pcb4.Image = imlImagenes.Images(numImage + 7)

        If puls1 = False Then
            pcb1.Image = imlImagenes.Images(numImage + 8)
            pcb2.Image = imlImagenes.Images(numImage + 9)
            pcb3.Image = imlImagenes.Images(numImage + 10)
        End If
    End Sub

    Private Sub btnIzq_Click(sender As Object, e As EventArgs) Handles btnIzq.Click
        pcb1.Image = imlImagenes.Images(numImage)
        pcb2.Image = imlImagenes.Images(numImage + 1)
        pcb3.Image = imlImagenes.Images(numImage + 2)
        pcb4.Image = imlImagenes.Images(numImage + 3)
        puls1 = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
