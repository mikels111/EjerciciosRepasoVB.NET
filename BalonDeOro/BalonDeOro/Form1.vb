Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BalonDeOro2014DataSet.Jugadores' Puede moverla o quitarla según sea necesario.
        Me.JugadoresTableAdapter.Fill(Me.BalonDeOro2014DataSet.Jugadores)
        'TODO: esta línea de código carga datos en la tabla 'BalonDeOro2014DataSet.Votantes' Puede moverla o quitarla según sea necesario.
        Me.VotantesTableAdapter.Fill(Me.BalonDeOro2014DataSet.Votantes)

        btnVotar.Enabled = False
        cmbPais.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList
        cmbJugador1.DropDownStyle = ComboBoxStyle.DropDownList
        cmbJugador2.DropDownStyle = ComboBoxStyle.DropDownList
        cmbJugador3.DropDownStyle = ComboBoxStyle.DropDownList

        cmbPais.SelectedValue = False
        cmbPuesto.SelectedValue = False
        cmbJugador1.SelectedValue = False
        cmbJugador2.SelectedValue = False
        cmbJugador3.SelectedValue = False



        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BalonDeOro2014.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT DISTINCT puesto FROM votantes"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                cmbPuesto.Items.Add(dr("puesto"))
            End While
            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub todoRellenado() Handles cmbPuesto.SelectedValueChanged, cmbPais.SelectedValueChanged, cmbJugador1.SelectedValueChanged, cmbJugador2.SelectedValueChanged, cmbJugador3.SelectedValueChanged, txtNombre.TextChanged
        If cmbPuesto.Text.Length > 0 And cmbPais.Text.Length > 0 And cmbJugador1.Text.Length > 0 And cmbJugador2.Text.Length > 0 And cmbJugador3.Text.Length > 0 And txtNombre.Text.Length > 0 Then
            btnVotar.Enabled = True
        Else
            btnVotar.Enabled = False
        End If
    End Sub

    Private Sub btnVotar_Click(sender As Object, e As EventArgs) Handles btnVotar.Click
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BalonDeOro2014.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            Dim idJugador1 As Integer
            Dim idJugador2 As Integer
            Dim idJugador3 As Integer
            Dim idVotante As Integer
            Dim votante As Integer

            cmd.CommandText = "SELECT Id FROM Votantes WHERE Nombre='" & txtNombre.Text & "' AND Puesto='" & cmbPuesto.Text & "' AND Pais='" & cmbPais.Text & "'"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader



            If dr.Read() Then
                idVotante = dr("Id")

                dr.Close()
                Dim dr0 As OleDb.OleDbDataReader
                cmd.CommandText = "SELECT Id,Apellido FROM Jugadores WHERE Apellido='" & cmbJugador1.Text & "' OR Apellido='" & cmbJugador2.Text & "' OR Apellido='" & cmbJugador3.Text & "'"
                If cmbJugador1.Text <> cmbJugador2.Text And cmbJugador1.Text <> cmbJugador3.Text And cmbJugador2.Text <> cmbJugador3.Text Then
                    dr0 = cmd.ExecuteReader
                    While dr0.Read
                        If dr0("Apellido") = cmbJugador1.Text Then
                            idJugador1 = dr0("Id")
                        ElseIf dr0("Apellido") = cmbJugador2.Text Then
                            idJugador2 = dr0("Id")
                        ElseIf dr0("Apellido") = cmbJugador3.Text Then
                            idJugador3 = dr0("Id")
                        End If

                    End While
                    dr0.Close()

                    cmd.CommandText = "UPDATE Votantes SET Primero=" & idJugador1 & ",Segundo=" & idJugador2 & ",Tercero=" & idJugador3 & " WHERE Id=" & idVotante & ""
                    cmd.ExecuteNonQuery()
                Else
                    MsgBox("Los jugadores tienen que ser diferentes")
                End If

                conexion.Close()
            Else
                MsgBox("Votante no encontrado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

End Class
