Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pelis.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select nombre from directores"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                lstDirectores.Items.Add(dr("nombre"))
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub lstDirectores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDirectores.SelectedIndexChanged
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pelis.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select *
                               from pelis  
                               inner join directores on pelis.id_director=directores.id_director  
                               where directores.nombre='" + lstDirectores.SelectedItem + "' 
                                "
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                lstPeliculas.Items.Add(dr("titulo"))

                ' txtPeliculas.Text = dr("pelis.titulo")

            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
End Class



