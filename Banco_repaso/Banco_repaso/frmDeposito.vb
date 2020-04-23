Public Class frmDeposito
    Private Sub frmDeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtDescripcion.Text = deposito.descripcion
        txtSaldo.Text = deposito.saldo
        Label3.Text = deposito.idCuenta
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Banco.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "delete from depositos where IdCuenta=" & deposito.idCuenta & ""
            cmd.ExecuteNonQuery()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try

        Me.Close()


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Banco.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "delete from depositos where idCuenta=" & deposito.idCuenta & ""
            cmd.ExecuteNonQuery()

            cmd.CommandText = "insert into depositos(IdCuenta,dni,descripcion,saldo) values(" & deposito.idCuenta & ",'" & deposito.dni & "','" & txtDescripcion.Text & "','" & txtSaldo.Text & "')"
            cmd.ExecuteNonQuery()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " Saliendo de la aplicación.")
            Me.Close()
        End Try

    End Sub
End Class