Public Class frmGestionCuentas

    Dim prestamo_seleccionado As Integer
    Dim deposito_seleccionado As Integer

    Private Sub frmGestionCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BancoDataSet.Prestamos' Puede moverla o quitarla según sea necesario.
        Me.PrestamosTableAdapter.Fill(Me.BancoDataSet.Prestamos)
        'TODO: esta línea de código carga datos en la tabla 'BancoDataSet.Depositos' Puede moverla o quitarla según sea necesario.
        Me.DepositosTableAdapter.Fill(Me.BancoDataSet.Depositos)
        'TODO: esta línea de código carga datos en la tabla 'BancoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BancoDataSet.Clientes)

        txtNombre.Text = cmbCliente.SelectedValue
        btnModificar.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged

        txtNombre.Text = cmbCliente.SelectedValue

        lstDescripcionDepositos.Items.Clear()

        lstDescripcionPrestamo.Items.Clear()


        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Banco.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select descripcion from depositos where dni='" & cmbCliente.Text & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                lstDescripcionDepositos.Items.Add(dr("descripcion"))

            End While

            dr.Close()

            cmd.CommandText = "select descripcion from prestamos where dni='" & cmbCliente.Text & "'"
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = cmd.ExecuteReader

            While dr1.Read
                lstDescripcionPrestamo.Items.Add(dr1("descripcion"))
            End While

            dr1.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try

        If lstDescripcionDepositos.SelectedItems.Count < 1 Then
            btnModificar.Enabled = False
        Else
            btnModificar.Enabled = True
        End If

        If lstDescripcionPrestamo.SelectedItems.Count < 1 Then
            btnCancelar.Enabled = False
        Else
            btnCancelar.Enabled = False
        End If

    End Sub


    Private Sub lstDescripcionDepositos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDescripcionDepositos.SelectedIndexChanged
        If lstDescripcionDepositos.SelectedItems.Count < 1 Then
            btnModificar.Enabled = False
        Else
            btnModificar.Enabled = True
        End If


    End Sub

    Private Sub lstDescripcionPrestamo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDescripcionPrestamo.SelectedIndexChanged
        If lstDescripcionPrestamo.SelectedItems.Count < 1 Then
            btnCancelar.Enabled = False
        Else
            btnCancelar.Enabled = True
        End If

    End Sub
    'Private Sub borrar_prestamo()
    '    Try
    '        Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Banco.mdb;")
    '        conexion.Open()

    '        Dim cmd As New OleDb.OleDbCommand
    '        cmd.Connection = conexion
    '        cmd.CommandType = CommandType.Text

    '        cmd.CommandText = "select idprestamo from prestamos where dni='" & cmbCliente.Text & "'"
    '        cmd.ExecuteNonQuery()


    '        conexion.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message & "Saliendo de la aplicación.")
    '        Me.Close()
    '    End Try
    'End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Banco.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            Dim a As Integer
            cmd.CommandText = "delete from prestamos where dni='" & cmbCliente.Text & "' and descripcion='" & lstDescripcionPrestamo.SelectedItem & "'"
            cmd.ExecuteNonQuery()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Banco.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select IdCuenta,descripcion,saldo from depositos where dni='" & cmbCliente.Text & "' and descripcion='" & lstDescripcionDepositos.SelectedItem & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                deposito.idCuenta = dr("IdCuenta")
                deposito.descripcion = dr("descripcion")
                deposito.saldo = dr("saldo")

            End If

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try

        deposito.dni = cmbCliente.Text

        frmDeposito.MdiParent = Form1
        frmDeposito.Show()
        Form1.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class