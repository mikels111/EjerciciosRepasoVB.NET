Public Class Form1
    Dim peliActual As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarPeli()
    End Sub
    Private Sub mostrarPeli()
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pelis.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT id_peli,titulo,id_director,reparto,genero,valoracion,duracion,argumento FROM Pelis WHERE id_peli>0 ORDER BY id_peli"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                peliActual = dr("id_peli")
                Dim cmd1 As New OleDb.OleDbCommand
                cmd1.Connection = conexion
                cmd1.CommandType = CommandType.Text

                cmd1.CommandText = "SELECT id_director,nombre FROM Directores WHERE id_director=" & dr("id_director") & ""
                Dim dr1 As OleDb.OleDbDataReader
                dr1 = cmd1.ExecuteReader
                If dr1.Read() Then
                    txtDirector.Text = dr1("nombre")
                End If
                dr1.Close()

                txtTitulo.Text = dr("titulo")
                txtReparto.Text = dr("reparto")
                txtGenero.Text = dr("genero")
                txtValoracion.Text = dr("valoracion")
                txtDuracion.Text = dr("duracion")
                txtArgumento.Text = dr("argumento")
            End If
            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pelis.mdb;")
        conexion.Open()

        'Dim cmd0 As New OleDb.OleDbCommand
        'cmd0.Connection = conexion
        'cmd0.CommandType = CommandType.Text

        'cmd0.CommandText = "SELECT id_director,nombre FROM directores WHERE nombre='" & txtFiltro.Text & "'"
        'Dim dr0 As OleDb.OleDbDataReader
        'dr0 = cmd0.ExecuteReader

        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text


        If rdbTitulo.Checked Then

            cmd.CommandText = "SELECT id_peli,titulo,id_director,reparto,genero,valoracion,duracion,argumento FROM Pelis WHERE id_peli>0 AND titulo LIKE '" & txtFiltro.Text & "' OR titulo LIKE '" & txtFiltro.Text & "%' OR titulo LIKE '%" & txtFiltro.Text & "' ORDER BY id_peli"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                peliActual = dr("id_peli")
                Dim cmd1 As New OleDb.OleDbCommand
                cmd1.Connection = conexion
                cmd1.CommandType = CommandType.Text

                cmd1.CommandText = "SELECT id_director,nombre FROM Directores WHERE id_director=" & dr("id_director") & ""
                Dim dr1 As OleDb.OleDbDataReader
                dr1 = cmd1.ExecuteReader
                If dr1.Read() Then
                    txtDirector.Text = dr1("nombre")
                End If
                dr1.Close()

                txtTitulo.Text = dr("titulo")
                txtReparto.Text = dr("reparto")
                txtGenero.Text = dr("genero")
                txtValoracion.Text = dr("valoracion")
                txtDuracion.Text = dr("duracion")
                txtArgumento.Text = dr("argumento")
            End If
            dr.Close()

        ElseIf rdbDirector.Checked Then

            Dim cmd1 As New OleDb.OleDbCommand
            cmd1.Connection = conexion
            cmd1.CommandType = CommandType.Text

            cmd1.CommandText = "SELECT id_director,nombre FROM Directores WHERE nombre LIKE '" & txtFiltro.Text & "' OR nombre LIKE '" & txtFiltro.Text & "%' OR nombre LIKE '%" & txtFiltro.Text & "'"
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = cmd1.ExecuteReader

            If dr1.Read() Then
                cmd.CommandText = "SELECT id_peli,titulo,id_director,reparto,genero,valoracion,duracion,argumento FROM Pelis WHERE id_peli>0 AND id_director=" & dr1("id_director") & " ORDER BY id_peli"
                Dim dr As OleDb.OleDbDataReader
                dr = cmd.ExecuteReader


                If dr.Read() Then
                    peliActual = dr("id_peli")

                    txtDirector.Text = dr1("nombre")
                    txtTitulo.Text = dr("titulo")
                    txtReparto.Text = dr("reparto")
                    txtGenero.Text = dr("genero")
                    txtValoracion.Text = dr("valoracion")
                    txtDuracion.Text = dr("duracion")
                    txtArgumento.Text = dr("argumento")
                End If
                dr.Close()
            End If
            dr1.Close()


        ElseIf rdbGenero.Checked Then
            Label8.Text = peliActual

            Dim cmd0 As New OleDb.OleDbCommand
            cmd0.Connection = conexion
            cmd0.CommandType = CommandType.Text

            cmd0.CommandText = "SELECT id_peli,titulo,id_director,reparto,genero,valoracion,duracion,argumento FROM Pelis WHERE id_peli>0 AND (genero LIKE '" & txtFiltro.Text & "%/%' OR genero LIKE '%/%" & txtFiltro.Text & "%/%' OR genero LIKE '%/%" & txtFiltro.Text & "' OR genero LIKE '" & txtFiltro.Text & "') ORDER BY id_peli"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd0.ExecuteReader

            If dr.Read() Then
                peliActual = dr("id_peli")

                Dim cmd1 As New OleDb.OleDbCommand
                cmd1.Connection = conexion
                cmd1.CommandType = CommandType.Text

                cmd1.CommandText = "SELECT id_director,nombre FROM Directores WHERE id_director=" & dr("id_director") & ""
                Dim dr1 As OleDb.OleDbDataReader
                dr1 = cmd1.ExecuteReader
                If dr1.Read() Then
                    txtDirector.Text = dr1("nombre")
                End If
                dr1.Close()

                txtTitulo.Text = dr("titulo")
                txtReparto.Text = dr("reparto")
                txtGenero.Text = dr("genero")
                txtValoracion.Text = dr("valoracion")
                txtDuracion.Text = dr("duracion")
                txtArgumento.Text = dr("argumento")
            End If
            dr.Close()
        ElseIf rdbReparto.Checked Then
            cmd.CommandText = "SELECT id_peli,titulo,id_director,reparto,genero,valoracion,duracion,argumento FROM Pelis WHERE id_peli>0 AND (reparto LIKE '" & txtFiltro.Text & "%,%' OR reparto LIKE '%,%" & txtFiltro.Text & "%,%' OR reparto LIKE '%,%" & txtFiltro.Text & "' OR reparto LIKE '" & txtFiltro.Text & "' OR reparto LIKE '%" & txtFiltro.Text & ",%' OR reparto LIKE '%,%" & txtFiltro.Text & "%') ORDER BY id_peli"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                peliActual = dr("id_peli")

                Dim cmd1 As New OleDb.OleDbCommand
                cmd1.Connection = conexion
                cmd1.CommandType = CommandType.Text

                cmd1.CommandText = "SELECT id_director,nombre FROM Directores WHERE id_director=" & dr("id_director") & ""
                Dim dr1 As OleDb.OleDbDataReader
                dr1 = cmd1.ExecuteReader
                If dr1.Read() Then
                    txtDirector.Text = dr1("nombre")
                End If
                dr1.Close()

                txtTitulo.Text = dr("titulo")
                txtReparto.Text = dr("reparto")
                txtGenero.Text = dr("genero")
                txtValoracion.Text = dr("valoracion")
                txtDuracion.Text = dr("duracion")
                txtArgumento.Text = dr("argumento")
            End If
            dr.Close()


        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pelis.mdb;")
        conexion.Open()

        'Dim cmd0 As New OleDb.OleDbCommand
        'cmd0.Connection = conexion
        'cmd0.CommandType = CommandType.Text

        'cmd0.CommandText = "SELECT id_director,nombre FROM directores WHERE nombre='" & txtFiltro.Text & "'"
        'Dim dr0 As OleDb.OleDbDataReader
        'dr0 = cmd0.ExecuteReader

        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text


        If rdbTitulo.Checked Then

            cmd.CommandText = "SELECT id_peli,titulo,id_director,reparto,genero,valoracion,duracion,argumento FROM Pelis WHERE id_peli>" & peliActual & " AND titulo LIKE '" & txtFiltro.Text & "' OR titulo LIKE '" & txtFiltro.Text & "%' OR titulo LIKE '%" & txtFiltro.Text & "' ORDER BY id_peli"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                peliActual = dr("id_peli")
                Dim cmd1 As New OleDb.OleDbCommand
                cmd1.Connection = conexion
                cmd1.CommandType = CommandType.Text

                cmd1.CommandText = "SELECT id_director,nombre FROM Directores WHERE id_director=" & dr("id_director") & ""
                Dim dr1 As OleDb.OleDbDataReader
                dr1 = cmd1.ExecuteReader
                If dr1.Read() Then
                    txtDirector.Text = dr1("nombre")
                End If
                dr1.Close()

                txtTitulo.Text = dr("titulo")
                txtReparto.Text = dr("reparto")
                txtGenero.Text = dr("genero")
                txtValoracion.Text = dr("valoracion")
                txtDuracion.Text = dr("duracion")
                txtArgumento.Text = dr("argumento")
            End If
            dr.Close()

        ElseIf rdbDirector.Checked Then

            Dim cmd1 As New OleDb.OleDbCommand
            cmd1.Connection = conexion
            cmd1.CommandType = CommandType.Text

            cmd1.CommandText = "SELECT id_director,nombre FROM Directores WHERE nombre LIKE '" & txtFiltro.Text & "' OR nombre LIKE '" & txtFiltro.Text & "% %' OR nombre LIKE '% %" & txtFiltro.Text & "'"
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = cmd1.ExecuteReader

            If dr1.Read() Then
                cmd.CommandText = "SELECT id_peli,titulo,id_director,reparto,genero,valoracion,duracion,argumento FROM Pelis WHERE id_peli>" & peliActual & " AND id_director=" & dr1("id_director") & " ORDER BY id_peli"
                Dim dr As OleDb.OleDbDataReader
                dr = cmd.ExecuteReader


                If dr.Read() Then
                    peliActual = dr("id_peli")

                    txtDirector.Text = dr1("nombre")
                    txtTitulo.Text = dr("titulo")
                    txtReparto.Text = dr("reparto")
                    txtGenero.Text = dr("genero")
                    txtValoracion.Text = dr("valoracion")
                    txtDuracion.Text = dr("duracion")
                    txtArgumento.Text = dr("argumento")
                End If
                dr.Close()
            End If
            dr1.Close()


        ElseIf rdbGenero.Checked Then

            Label8.Text = peliActual

            Dim cmd0 As New OleDb.OleDbCommand
            cmd0.Connection = conexion
            cmd0.CommandType = CommandType.Text

            cmd0.CommandText = "SELECT id_peli,titulo,id_director,reparto,genero,valoracion,duracion,argumento FROM Pelis WHERE id_peli>" & peliActual & " AND (genero LIKE '" & txtFiltro.Text & "%/%' OR genero LIKE '%/%" & txtFiltro.Text & "%/%' OR genero LIKE '%/%" & txtFiltro.Text & "' OR genero LIKE '" & txtFiltro.Text & "') ORDER BY id_peli"

            Dim dr As OleDb.OleDbDataReader
            dr = cmd0.ExecuteReader

            If dr.Read() Then
                peliActual = dr("id_peli")


                Dim cmd1 As New OleDb.OleDbCommand
                cmd1.Connection = conexion
                cmd1.CommandType = CommandType.Text

                cmd1.CommandText = "SELECT id_director,nombre FROM Directores WHERE id_director=" & dr("id_director") & ""
                Dim dr1 As OleDb.OleDbDataReader
                dr1 = cmd1.ExecuteReader
                If dr1.Read() Then
                    txtDirector.Text = dr1("nombre")
                End If
                dr1.Close()

                txtTitulo.Text = dr("titulo")
                txtReparto.Text = dr("reparto")
                txtGenero.Text = dr("genero")
                txtValoracion.Text = dr("valoracion")
                txtDuracion.Text = dr("duracion")
                txtArgumento.Text = dr("argumento")
            End If
            dr.Close()
        ElseIf rdbReparto.Checked Then
            cmd.CommandText = "SELECT id_peli,titulo,id_director,reparto,genero,valoracion,duracion,argumento FROM Pelis WHERE id_peli>" & peliActual & " AND (reparto LIKE '" & txtFiltro.Text & "%,%' OR reparto LIKE '%,%" & txtFiltro.Text & "%,%' OR reparto LIKE '%,%" & txtFiltro.Text & "' OR reparto LIKE '" & txtFiltro.Text & "' OR reparto LIKE '% " & txtFiltro.Text & ",%' OR reparto LIKE '%,%" & txtFiltro.Text & "%') ORDER BY id_peli"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                peliActual = dr("id_peli")

                Dim cmd1 As New OleDb.OleDbCommand
                cmd1.Connection = conexion
                cmd1.CommandType = CommandType.Text

                cmd1.CommandText = "SELECT id_director,nombre FROM Directores WHERE id_director=" & dr("id_director") & ""
                Dim dr1 As OleDb.OleDbDataReader
                dr1 = cmd1.ExecuteReader
                If dr1.Read() Then
                    txtDirector.Text = dr1("nombre")
                End If
                dr1.Close()

                txtTitulo.Text = dr("titulo")
                txtReparto.Text = dr("reparto")
                txtGenero.Text = dr("genero")
                txtValoracion.Text = dr("valoracion")
                txtDuracion.Text = dr("duracion")
                txtArgumento.Text = dr("argumento")
            End If
            dr.Close()

        End If
    End Sub


End Class
