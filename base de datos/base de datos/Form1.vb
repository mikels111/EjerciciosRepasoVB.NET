Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EEUU.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select estado from estados"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                lstEstados.Items.Add(dr("estado"))
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub lstEstados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEstados.SelectedIndexChanged
        If lstEstados.SelectedIndex <> -1 Then
            Try
                Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\EEUU.mdb;")
                conexion.Open()

                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = conexion
                cmd.CommandType = CommandType.Text

                cmd.CommandText = "select capital from estados where estado='" + lstEstados.SelectedItem + "'"


                Dim dr As OleDb.OleDbDataReader
                dr = cmd.ExecuteReader

                If dr.Read() Then
                    txtCapitales.Text = dr("capital")
                End If

                dr.Close()

                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message & "Saliendo de la aplicación.")
                Me.Close()
            End Try

        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub


End Class
