Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarId()


    End Sub

    Private Sub cmbJornada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJornada.SelectedIndexChanged
        mostraFecha()
        mostrarBanquillo()
        mostrarAlineacion()


    End Sub
    Private Sub mostrarId()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\erreala.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select id from jornadas"

            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            While dr.Read()
                cmbJornada.Items.Add(dr("id"))
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
        cmbJornada.SelectedIndex = 0
    End Sub
    Private Sub mostraFecha()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\erreala.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select fecha from jornadas where id=" & cmbJornada.SelectedItem

            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            If dr.Read() Then
                lblFecha.Text = dr("fecha")
            End If

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
    Private Sub mostrarAlineacion()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\erreala.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select jugador from alineacion where jornada=" & cmbJornada.SelectedItem

            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            lstAlineacion.Items.Clear()

            While dr.Read()
                lstAlineacion.Items.Add(dr("jugador"))
                lstBanquillo.Items.Remove(dr("jugador"))
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
    Private Sub mostrarBanquillo()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\erreala.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select nombre from jugadores"

            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            lstAlineacion.Items.Clear()

            While dr.Read()
                lstBanquillo.Items.Add(dr("nombre"))
            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        If lstBanquillo.SelectedIndex = -1 Then
            MsgBox("No has elegido ningun jugador")

        ElseIf lstAlineacion.Items.Count >= 11 Then
            MsgBox("La alineación está completa")
        Else
            añadirAlineacion()
            lstAlineacion.Items.Add(lstBanquillo.SelectedItem)
            lstBanquillo.Items.Remove(lstBanquillo.SelectedItem)
        End If

    End Sub

    Private Sub btnIzquierda_Click(sender As Object, e As EventArgs) Handles btnIzquierda.Click
        If lstAlineacion.SelectedIndex = -1 Then
            MsgBox("No has elegido ningun jugador")

        Else
            eliminarAlineacion()
            lstBanquillo.Items.Add(lstAlineacion.SelectedItem)
            lstAlineacion.Items.Remove(lstAlineacion.SelectedItem)
        End If

    End Sub

    Private Sub lstBanquillo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBanquillo.SelectedIndexChanged, lstAlineacion.SelectedIndexChanged
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\erreala.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select * from jugadores where nombre='" & sender.selectedItem & "'"

            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader


            If dr.Read() Then
                txtNombre.Text = dr("nombre")
                txtLugar.Text = dr("lugar_nacimiento")
                cmbDemarcacion.Text = dr("demarcacion")
                chkCedido.Checked = dr("cedido")
                pcbFoto.Load(Application.StartupPath & "\fotos\" & dr("foto"))
            End If

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\erreala.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "update jugadores set " &
                "nacimiento= #" & dtpNacimiento.Value.Date & "#, " &
                "lugar_nacimiento='" & txtLugar.Text & "', " &
                "demarcacion='" & cmbDemarcacion.Text & "', " &
                "cedido=" & chkCedido.Checked & " " &
                "where nombre= '" & txtNombre.Text & "'"

            Dim cont As Integer

            cont = cmd.ExecuteNonQuery()
            MsgBox("Se han modificado " & cont & " jugadores")
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
    Private Sub añadirAlineacion()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\erreala.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "insert into alineacion (jornada,jugador) values(" & cmbJornada.Text & ", '" & lstBanquillo.SelectedItem & "')"

            Dim cont As Integer

            cont = cmd.ExecuteNonQuery()
            MsgBox("Se han modificado " & cont & " jugadores")
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
    Private Sub eliminarAlineacion()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\erreala.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "delete from alineacion where jornada= " & cmbJornada.Text & " and jugador= '" & lstAlineacion.SelectedItem & "'"

            Dim cont As Integer

            cont = cmd.ExecuteNonQuery()
            MsgBox("Se ha quitado de la alineación " & cont & " jugadores")
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
End Class
