Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pelis.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select titulo from pelis"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                lstPeliculas.Items.Add(dr("titulo"))

            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try

    End Sub

    Private Sub lstPeliculas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPeliculas.SelectedIndexChanged
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pelis.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select *, pelis.año as añoPelis
                               from pelis  
                               inner join directores on pelis.id_director=directores.id_director  
                               where titulo='" + lstPeliculas.SelectedItem + "'
                              "
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                txtReparto.Text = dr("reparto")
                txtArgumento.Text = dr("argumento")
                txtDirector.Text = dr("nombre")
                txtAño.Text = dr("añoPelis")
                txtDuracion.Text = dr("duracion")
                txtGenero.Text = dr("genero")
                txtValoración.Text = dr("valoracion")
                pcbCartel.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Carteles\" & dr("Cartel"))

            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
End Class
