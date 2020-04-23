Public Class frmPrestamo
    Private Sub frmPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BibliotecaDataSet.Prestamos' Puede moverla o quitarla según sea necesario.
        Me.PrestamosTableAdapter.Fill(Me.BibliotecaDataSet.Prestamos)
        'TODO: esta línea de código carga datos en la tabla 'BibliotecaDataSet.Socios' Puede moverla o quitarla según sea necesario.
        Me.SociosTableAdapter.Fill(Me.BibliotecaDataSet.Socios)
        'TODO: esta línea de código carga datos en la tabla 'BibliotecaDataSet.Libros' Puede moverla o quitarla según sea necesario.
        Me.LibrosTableAdapter.Fill(Me.BibliotecaDataSet.Libros)

    End Sub

    Private Sub lstPrestamos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrestamos.SelectedIndexChanged

    End Sub

    Private Sub cmbSocios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSocios.SelectedIndexChanged
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Biblioteca.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "Select ciudad from socios where id=" & cmbSocios.SelectedValue
            Dim dr0 As OleDb.OleDbDataReader
            dr0 = cmd.ExecuteReader
            While dr0.Read()
                lblCiudad.Text = dr0("ciudad")
            End While
            dr0.Close()


            Dim cmdAux As New OleDb.OleDbCommand
            cmdAux.Connection = conexion
            cmdAux.CommandType = CommandType.Text

            cmdAux.CommandText = "SELECT Prestamos.Id, Libros.Titulo, Prestamos.fechaPrestamo FROM Prestamos, Libros WHERE Prestamos.idSocio=" & cmbSocios.SelectedValue & " and Prestamos.Devuelto=False and Prestamos.idLibro=Libros.id"
            Dim dr As OleDb.OleDbDataReader
            dr = cmdAux.ExecuteReader
            While dr.Read()
                'lblCiudad.Text = dr("Ciudad")
                lstPrestamos.Items.Add(dr("Titulo"))
                'lblPrestados.Text = dr("num")
            End While
            dr.Close()

            'cmd.CommandText=""

            cmd.CommandText = "select count(*) from prestamos where (fechaPrestamo-sysdate)>15 and idSocio=" & cmbSocios.SelectedValue
            Dim dr2 As OleDb.OleDbDataReader
            dr2 = cmd.ExecuteReader

            Dim fueraPrestamo As Integer
            fueraPrestamo = cmdAux.ExecuteScalar

            While dr2.Read()
                If fueraPrestamo > 0 Then
                    btnPrestamo.Enabled = False
                    MsgBox("tienes algun libro fuera de plazo")
                Else
                    btnPrestamo.Enabled = True

                End If
            End While
            dr2.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub lstLibros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLibros.SelectedIndexChanged
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Biblioteca.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select copias from libros where id=" & lstLibros.SelectedValue
            Dim copias As Integer
            copias = cmd.ExecuteScalar
            lblCopias.Text = copias
            If copias <> 0 Then
                btnPrestamo.Enabled = True
            Else
                btnPrestamo.Enabled = False
            End If

            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader


            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
End Class
'cmd.CommandText = "select libros.titulo from libros,prestamos,socios where libros.id=prestamos.idlibro and socios.id=prestamos.idsocio"