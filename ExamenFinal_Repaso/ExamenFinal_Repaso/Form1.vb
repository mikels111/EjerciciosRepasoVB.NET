Public Class Form1

    Dim correcto As Integer
    Dim preguntaActual As Integer
    Dim encuestaRealizada As Integer

    Private Sub lstEncuestas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEncuestas.SelectedIndexChanged
        correcto = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EncuestasDataSet.Encuestas' Puede moverla o quitarla según sea necesario.
        Me.EncuestasTableAdapter.Fill(Me.EncuestasDataSet.Encuestas)
        btnSiguiente.Enabled = False
        lblPregunta.Text = Date.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub btnHacerEncuesta_Click(sender As Object, e As EventArgs) Handles btnHacerEncuesta.Click

        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\encuestas.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT COUNT(CodEncuesta) as cont FROM Claves WHERE Clave='" & txtContrasena.Text & "' AND CodEncuesta=" & lstEncuestas.SelectedValue & ""
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            Dim fecha As Date
            fecha = Date.Now.ToString("dd-MM-yyyy")

            If dr.Read() Then
                If (dr("cont") > 0) Then
                    correcto = 1
                    btnSiguiente.Enabled = True

                    dr.Close()
                    cmd.CommandText = "INSERT INTO EncuestasRealizadas(codEncuesta,fecha) VALUES(" & lstEncuestas.SelectedValue & ",#" & fecha & "#)"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "DELETE FROM Claves WHERE Clave='" & txtContrasena.Text & "'"
                    cmd.ExecuteNonQuery()
                Else
                    correcto = 0
                End If
            End If


            Dim cmd1 As New OleDb.OleDbCommand
            cmd1.Connection = conexion
            cmd1.CommandType = CommandType.Text

            cmd1.CommandText = "SELECT numEncuesta FROM EncuestasRealizadas WHERE codEncuesta=" & lstEncuestas.SelectedValue & " and fecha=#" & fecha & "#"
            Dim dr1 As OleDb.OleDbDataReader
            dr1 = cmd1.ExecuteReader()

            If dr1.Read() Then
                encuestaRealizada = dr1("numEncuesta")
            End If
            dr1.Close()

            Dim cmd2 As New OleDb.OleDbCommand
            cmd2.Connection = conexion
            cmd2.CommandType = CommandType.Text

            cmd2.CommandText = "SELECT Pregunta,numPregunta,codEncuesta FROM Preguntas WHERE codEncuesta=" & lstEncuestas.SelectedValue & " and numPregunta>0 order by numPregunta"
            Dim dr2 As OleDb.OleDbDataReader
            dr2 = cmd2.ExecuteReader

            If dr2.Read() Then
                If correcto = 1 Then
                    lblPregunta.Text = dr2("Pregunta")
                    preguntaActual = dr2("numPregunta")

                Else
                    lblPregunta.Text = "Contraseña incorrecta"
                End If
            End If
            dr2.Close()


            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\encuestas.mdb;")
            conexion.Open()

            Dim cmd0 As New OleDb.OleDbCommand
            cmd0.Connection = conexion
            cmd0.CommandType = CommandType.Text

            'cmd0.CommandText = "SELECT Pregunta,numPregunta FROM Preguntas WHERE codEncuesta=" & lstEncuestas.SelectedValue & " and numPregunta=0"
            'Dim dr0 As OleDb.OleDbDataReader
            'dr0 = cmd0.ExecuteReader

            If correcto = 1 Then
                If preguntaActual = 1 Then
                    'preguntaActual = dr0("numPregunta")
                    'dr0.Close()

                    If rdbSiempre.Checked Then
                        cmd0.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) VALUES(" & encuestaRealizada & "," & preguntaActual & ",1)"
                        cmd0.ExecuteNonQuery()
                    ElseIf rdbAMenudo.Checked Then
                        cmd0.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) VALUES(" & encuestaRealizada & "," & preguntaActual & ",2)"
                        cmd0.ExecuteNonQuery()
                    ElseIf rdbAVeces.Checked Then
                        cmd0.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) VALUES(" & encuestaRealizada & "," & preguntaActual & ",3)"
                        cmd0.ExecuteNonQuery()
                    ElseIf rdbNunca.Checked Then
                        cmd0.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) VALUES(" & encuestaRealizada & "," & preguntaActual & ",4)"
                        cmd0.ExecuteNonQuery()
                    ElseIf rdbPocas.Checked Then
                        cmd0.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) VALUES(" & encuestaRealizada & "," & preguntaActual & ",5)"
                        cmd0.ExecuteNonQuery()
                    End If

                End If

            End If

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text


            cmd.CommandText = "SELECT Pregunta,numPregunta FROM Preguntas WHERE codEncuesta=" & lstEncuestas.SelectedValue & " and numPregunta>" & preguntaActual & " order by numPregunta"
            Dim dr As OleDb.OleDbDataReader

            dr = cmd.ExecuteReader
            If correcto = 1 Then
                If dr.Read() Then
                    lblPregunta.Text = dr("Pregunta")
                    preguntaActual = dr("numPregunta")
                    dr.Close()

                    If rdbSiempre.Checked Then
                        cmd.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) VALUES(" & encuestaRealizada & "," & preguntaActual & ",1)"
                        cmd.ExecuteNonQuery()
                    ElseIf rdbAMenudo.Checked Then
                        cmd.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) VALUES(" & encuestaRealizada & "," & preguntaActual & ",2)"
                        cmd.ExecuteNonQuery()
                    ElseIf rdbAVeces.Checked Then
                        cmd.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) VALUES(" & encuestaRealizada & "," & preguntaActual & ",3)"
                        cmd.ExecuteNonQuery()
                    ElseIf rdbNunca.Checked Then
                        cmd.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) VALUES(" & encuestaRealizada & "," & preguntaActual & ",4)"
                        cmd.ExecuteNonQuery()
                    ElseIf rdbPocas.Checked Then
                        cmd.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) VALUES(" & encuestaRealizada & "," & preguntaActual & ",5)"
                        cmd.ExecuteNonQuery()
                    End If
                Else
                    lblPregunta.Text = "No hay más preguntas"

                    btnSiguiente.Enabled = False

                End If

                conexion.Close()
            Else
                lblPregunta.Text = "Contraseña incorrecta"
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub


End Class
