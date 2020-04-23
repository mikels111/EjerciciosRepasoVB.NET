Public Class Form1
    Dim respuestaCorrecta As Integer
    Dim contador As Integer
    Dim cod_bloque As Integer
    Dim acertadas As Integer
    Dim preguntas As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TestInformaticaDataSet.Bloque_Tests' Puede moverla o quitarla según sea necesario.
        Me.Bloque_TestsTableAdapter.Fill(Me.TestInformaticaDataSet.Bloque_Tests)
        Randomize()
        nuevoTemaPregunta()


    End Sub

    Private Sub nuevoTemaPregunta()

        Try

            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TestInformatica.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            Dim temas As Integer

            cmd.CommandText = "SELECT COUNT(cod) as cont FROM bloque_tests"
            Dim dr0 As OleDb.OleDbDataReader
            dr0 = cmd.ExecuteReader
            If dr0.Read Then
                temas = dr0("cont")
            End If
            dr0.Close()
            Dim aleatorio As Integer
            aleatorio = Int(temas * Rnd())


            cmd.CommandText = "SELECT cod FROM Bloque_Tests WHERE cod=" & aleatorio & " AND cod<>" & cod_bloque & ""
            Label3.Text = aleatorio
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                Dim aleatorio2 As Integer
                Dim primero As Integer
                Dim ultimo As Integer

                cod_bloque = dr("cod")
                lstTemas.SelectedValue = dr("cod")

                dr.Close()

                cmd.CommandText = "SELECT TOP 1 cod FROM tests WHERE cod_bloque=" & cod_bloque & " ORDER BY cod DESC"
                Dim dr2 As OleDb.OleDbDataReader
                dr2 = cmd.ExecuteReader
                If dr2.Read Then

                    ultimo = dr2("cod")
                    dr2.Close()
                    cmd.CommandText = "SELECT cod FROM tests WHERE cod_bloque=" & cod_bloque & " ORDER BY cod"
                    Dim dr3 As OleDb.OleDbDataReader
                    dr3 = cmd.ExecuteReader
                    If dr3.Read Then
                        primero = dr3("cod")
                    End If
                    dr3.Close()
                    aleatorio2 = Int((ultimo - primero + 1) * Rnd()) + primero
                    cmd.CommandText = "SELECT enunciado,r1,r2,r3,r4,solucion FROM tests WHERE cod=" & aleatorio2 & ""
                    Dim dr4 As OleDb.OleDbDataReader
                    dr4 = cmd.ExecuteReader
                    If dr4.Read Then
                        contador = contador + 1             'prueba
                        Label4.Text = contador              'prueba
                        lblPregunta.Text = dr4("enunciado")
                        rdbA.Text = "A - " + dr4("r1")
                        rdbB.Text = "B - " + dr4("r2")
                        rdbC.Text = "C - " + dr4("r3")
                        rdbD.Text = "D - " + dr4("r4")
                        respuestaCorrecta = dr4("solucion")
                    End If
                    dr4.Close()
                End If
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try


    End Sub
    Private Sub mismoTema()
        Try

            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TestInformatica.mdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text


            cmd.CommandText = "SELECT cod FROM Bloque_Tests WHERE cod=" & cod_bloque & ""
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                Dim aleatorio2 As Integer
                Dim primero As Integer
                Dim ultimo As Integer

                cod_bloque = dr("cod")
                lstTemas.SelectedValue = dr("cod")

                dr.Close()

                cmd.CommandText = "SELECT TOP 1 cod FROM tests WHERE cod_bloque=" & cod_bloque & " ORDER BY cod DESC"
                Dim dr2 As OleDb.OleDbDataReader
                dr2 = cmd.ExecuteReader
                If dr2.Read Then

                    ultimo = dr2("cod")
                    dr2.Close()
                    cmd.CommandText = "SELECT cod FROM tests WHERE cod_bloque=" & cod_bloque & " ORDER BY cod"
                    Dim dr3 As OleDb.OleDbDataReader
                    dr3 = cmd.ExecuteReader
                    If dr3.Read Then
                        primero = dr3("cod")
                    End If
                    dr3.Close()
                    aleatorio2 = Int((ultimo - primero + 1) * Rnd()) + primero
                    cmd.CommandText = "SELECT enunciado,r1,r2,r3,r4,solucion FROM tests WHERE cod=" & aleatorio2 & ""
                    Dim dr4 As OleDb.OleDbDataReader
                    dr4 = cmd.ExecuteReader
                    If dr4.Read Then
                        contador = contador + 1             'prueba
                        Label4.Text = contador              'prueba
                        lblPregunta.Text = dr4("enunciado")
                        rdbA.Text = "A - " + dr4("r1")
                        rdbB.Text = "B - " + dr4("r2")
                        rdbC.Text = "C - " + dr4("r3")
                        rdbD.Text = "D - " + dr4("r4")
                        respuestaCorrecta = dr4("solucion")
                    End If
                    dr4.Close()
                End If
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter, rdbA.CheckedChanged, rdbB.CheckedChanged, rdbC.CheckedChanged, rdbD.CheckedChanged
        If rdbA.Checked Then
            If respuestaCorrecta = 1 Then
                acertadas = acertadas + 1
                Threading.Thread.Sleep(500)
                rdbA.Checked = False
                rdbB.Checked = False
                rdbC.Checked = False
                rdbD.Checked = False
                nuevoTemaPregunta()
                preguntas = preguntas + 1
            Else
                Threading.Thread.Sleep(500)
                rdbA.Checked = False
                rdbB.Checked = False
                rdbC.Checked = False
                rdbD.Checked = False
                mismoTema()
                preguntas = preguntas + 1
            End If

        ElseIf rdbB.Checked Then
            If respuestaCorrecta = 2 Then
                acertadas = acertadas + 1
                Threading.Thread.Sleep(500)
                rdbA.Checked = False
                rdbB.Checked = False
                rdbC.Checked = False
                rdbD.Checked = False
                nuevoTemaPregunta()
                preguntas = preguntas + 1
            Else
                Threading.Thread.Sleep(500)
                rdbA.Checked = False
                rdbB.Checked = False
                rdbC.Checked = False
                rdbD.Checked = False
                mismoTema()
                preguntas = preguntas + 1
            End If

        ElseIf rdbC.Checked Then
            If respuestaCorrecta = 3 Then
                acertadas = acertadas + 1
                Threading.Thread.Sleep(500)
                rdbA.Checked = False
                rdbB.Checked = False
                rdbC.Checked = False
                rdbD.Checked = False
                nuevoTemaPregunta()
                preguntas = preguntas + 1
            Else
                Threading.Thread.Sleep(500)
                rdbA.Checked = False
                rdbB.Checked = False
                rdbC.Checked = False
                rdbD.Checked = False
                mismoTema()
                preguntas = preguntas + 1
            End If

        ElseIf rdbD.Checked Then
            If respuestaCorrecta = 4 Then
                acertadas = acertadas + 1
                Threading.Thread.Sleep(500)
                rdbA.Checked = False
                rdbB.Checked = False
                rdbC.Checked = False
                rdbD.Checked = False
                nuevoTemaPregunta()
                preguntas = preguntas + 1
            Else
                Threading.Thread.Sleep(500)
                rdbA.Checked = False
                rdbB.Checked = False
                rdbC.Checked = False
                rdbD.Checked = False
                mismoTema()
                preguntas = preguntas + 1
            End If
        End If
        lblAciertos.Text = acertadas
        lblPreguntas.Text = preguntas

        If preguntas = 20 Then
            End
        End If
    End Sub
End Class

