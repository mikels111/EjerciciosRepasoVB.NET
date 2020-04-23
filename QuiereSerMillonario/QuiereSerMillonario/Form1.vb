Public Class Form1
    Dim solucion As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        pregunta_aleatoria()
        lstPreguntas.SelectedIndex = 14
    End Sub

    Private Sub pregunta_aleatoria()

        Try

            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\millonario.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text


            Dim contador As Integer
            Dim aleatorio As Integer
            Dim preguntaActual As Integer



            cmd.CommandText = "SELECT COUNT(Id) as cont FROM Cuestionario"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                contador = dr("cont")
            End If
            dr.Close()

            aleatorio = Int(contador * Rnd())


            cmd.CommandText = "SELECT Pregunta,Id,Respuesta1,Respuesta2,Respuesta3,Respuesta4,solucion FROM Cuestionario WHERE Id=" & aleatorio & ""
            Dim dr0 As OleDb.OleDbDataReader
            dr0 = cmd.ExecuteReader
            If dr0.Read Then
                txbPregunta.Text = dr0("Pregunta")
                preguntaActual = dr0("Id")

                lblA.Text = dr0("respuesta1")
                lblB.Text = dr0("respuesta2")
                lblC.Text = dr0("respuesta3")
                lblD.Text = dr0("respuesta4")
                solucion = dr0("solucion")
                porcentajePublico.respuesta_correcta = solucion
            End If
            btnA.Enabled = True
            btnB.Enabled = True
            btnC.Enabled = True
            btnD.Enabled = True
            dr0.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter, btnA.Click, btnB.Click, btnC.Click, btnD.Click


        If sender.Tag = "1" Then
            If solucion = 1 Then
                pregunta_aleatoria()
                lstPreguntas.SelectedIndex = lstPreguntas.SelectedIndex - 1
            Else
                MsgBox("Tu record: " + tslRecord.Text)
                End
            End If
        ElseIf sender.tag = "2" Then
            If solucion = 2 Then
                pregunta_aleatoria()
                lstPreguntas.SelectedIndex = lstPreguntas.SelectedIndex - 1
            Else
                MsgBox("Tu record: " + tslRecord.Text)
                End
            End If

        ElseIf sender.tag = "3" Then
            If solucion = 3 Then
                pregunta_aleatoria()
                lstPreguntas.SelectedIndex = lstPreguntas.SelectedIndex - 1
            Else
                MsgBox("Tu record: " + tslRecord.Text)
                End
            End If
        ElseIf sender.tag = "4" Then
            If solucion = 4 Then
                pregunta_aleatoria()
                lstPreguntas.SelectedIndex = lstPreguntas.SelectedIndex - 1
            Else
                MsgBox("Tu record: " + tslRecord.Text)
                End
            End If
        End If
    End Sub

    Private Sub lstPreguntas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPreguntas.SelectedIndexChanged
        If lstPreguntas.SelectedIndex = 14 Then
            tslRecord.Text = 100
        ElseIf lstPreguntas.SelectedIndex = 13 Then
            tslRecord.Text = 200
        ElseIf lstPreguntas.SelectedIndex = 12 Then
            tslRecord.Text = 300
        ElseIf lstPreguntas.SelectedIndex = 11 Then
            tslRecord.Text = 400
        ElseIf lstPreguntas.SelectedIndex = 10 Then
            tslRecord.Text = 500
        ElseIf lstPreguntas.SelectedIndex = 9 Then
            tslRecord.Text = 1000
        ElseIf lstPreguntas.SelectedIndex = 8 Then
            tslRecord.Text = 1500
        ElseIf lstPreguntas.SelectedIndex = 7 Then
            tslRecord.Text = 2000
        ElseIf lstPreguntas.SelectedIndex = 6 Then
            tslRecord.Text = 4000
        ElseIf lstPreguntas.SelectedIndex = 5 Then
            tslRecord.Text = 5000
        ElseIf lstPreguntas.SelectedIndex = 4 Then
            tslRecord.Text = 1000
        ElseIf lstPreguntas.SelectedIndex = 3 Then
            tslRecord.Text = 20000
        ElseIf lstPreguntas.SelectedIndex = 2 Then
            tslRecord.Text = 40000
        ElseIf lstPreguntas.SelectedIndex = 1 Then
            tslRecord.Text = 80000
        ElseIf lstPreguntas.SelectedIndex = 0 Then
            tslRecord.Text = 15000
        End If
    End Sub

    Private Sub tsbPublico_Click(sender As Object, e As EventArgs) Handles tsbPublico.Click
        publico.Show()

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim aleatorio As Integer
        'For x = 1 To 4
        '    aleatorio = Int(Rnd() * (4 - 1 + 1)) + 1
        'If aleatorio <> solucion Then
        '    If aleatorio = 1 Then
        '        btnA.Enabled = False
        '    ElseIf aleatorio = 2 Then
        '        btnB.Enabled = False
        '    ElseIf aleatorio = 3 Then
        '        btnC.Enabled = False
        '    ElseIf aleatorio = 4 Then
        '        btnD.Enabled = False
        '    End If
        'End If
        While aleatorio <> solucion

            If aleatorio = 1 Then
                btnA.Enabled = False
            ElseIf aleatorio = 2 Then
                btnB.Enabled = False
            ElseIf aleatorio = 3 Then
                btnC.Enabled = False
            ElseIf aleatorio = 4 Then
                btnD.Enabled = False
            End If
            aleatorio = Int(Rnd() * (4 - 1 + 1)) + 1
        End While

        'Next
        ToolStripLabel1.Enabled = False
    End Sub
End Class
