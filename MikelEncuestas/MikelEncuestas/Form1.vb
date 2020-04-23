Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EncuestasDataSet.Encuestas' Puede moverla o quitarla según sea necesario.
        Me.EncuestasTableAdapter.Fill(Me.EncuestasDataSet.Encuestas)
        'lblPregunta.Visible = False


    End Sub

    Private Sub lstEncuestas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEncuestas.SelectedIndexChanged

    End Sub

    Private Sub btnHacerEncues_Click(sender As Object, e As EventArgs) Handles btnHacerEncues.Click
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\encuestas.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "SELECT * FROM Claves WHERE Claves.codEncuesta=" & lstEncuestas.SelectedValue & " and Claves.clave='" & txtContraseña.Text & "' "

            Dim dr0 As OleDb.OleDbDataReader
            dr0 = cmd.ExecuteReader
            If dr0.Read Then
                MsgBox("Contraseña correcta")

                siguientePregunta()
            Else
                MsgBox("Contraseña incorrecta")
            End If
            dr0.Close()



            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub habilitarBotonEncuesta() Handles txtContraseña.TextChanged
        If txtContraseña.TextLength = 0 Then
            btnHacerEncues.Enabled = False
        Else
            btnHacerEncues.Enabled = True
        End If
    End Sub

    Private Sub siguientePregunta() Handles btnSiguiente.Click

        Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\encuestas.mdb;")
        conexion.Open()

        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select Pregunta,numPregunta from Preguntas where codEncuesta=" & lstEncuestas.SelectedValue
        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            lblPregunta.Text = dr("Pregunta")

            Dim dr1 As OleDb.OleDbDataReader
            If rdbSiempre.Checked Then
                cmd.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) values(1," & dr("numPregunta") & ",1)"
                dr1 = cmd.ExecuteReader
            ElseIf rdbAmenudo.Checked Then
                cmd.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) values(1," & dr("numPregunta") & ",2)"
                dr1 = cmd.ExecuteReader
            ElseIf rdbAveces.Checked Then
                cmd.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) values(1," & dr("numPregunta") & ",3)"
                dr1 = cmd.ExecuteReader
            ElseIf rdbPocas.Checked Then
                cmd.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) values(1," & dr("numPregunta") & ",4)"
                dr1 = cmd.ExecuteReader
            ElseIf rdbNunca.Checked Then
                cmd.CommandText = "INSERT INTO PreguntasRespondidas(numEncuesta,numPregunta,respuesta) values(1," & dr("numPregunta") & ",5)"
                dr1 = cmd.ExecuteReader
            End If
            dr1.Close()

        End While
        dr.Close()



    End Sub
End Class
