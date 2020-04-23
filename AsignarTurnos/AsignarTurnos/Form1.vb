Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMaxMañana.Text = 10
        txtMaxTarde.Text = 10
        txtMaxNoche.Text = 10

        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\empresa.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select nombre,turno
                                from trabajadores"
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            While dr.Read()
                If (dr("turno") = "M") Then
                    lstMañana.Items.Add(dr("nombre"))
                ElseIf (dr("turno") = "T") Then
                    lstTarde.Items.Add(dr("nombre"))
                ElseIf (dr("turno") = "N") Then
                    lstNoche.Items.Add(dr("nombre"))
                End If

            End While

            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try

        maximo()

    End Sub

    Private Sub botonClick(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click
        Dim seleccionado As String
        Dim cont As Integer

        If sender.tag = 1 Then
            seleccionado = lstMañana.Items(lstMañana.SelectedIndex)

            cont = lstMañana.Items.Count + lstTarde.SelectedItems.Count
            If cont <= txtMaxMañana.Text Then
                MsgBox("hola")

                lstMañana.Items.Remove(seleccionado)
                lstTarde.Items.Add(seleccionado)
            End If

        ElseIf sender.tag = 2 Then
            seleccionado = lstTarde.Items(lstTarde.SelectedIndex)
            lstTarde.Items.Remove(seleccionado)
            lstMañana.Items.Add(seleccionado)

        ElseIf sender.tag = 3 Then
            seleccionado = lstTarde.Items(lstTarde.SelectedIndex)
            lstTarde.Items.Remove(seleccionado)
            lstNoche.Items.Add(seleccionado)
        ElseIf sender.tag = 4 Then
            seleccionado = lstNoche.Items(lstNoche.SelectedIndex)
            lstNoche.Items.Remove(seleccionado)
            lstTarde.Items.Add(seleccionado)
        End If

    End Sub

    Private Sub _seleccionado()
        If lstMañana.Items(lstMañana.SelectedIndex) = False Then
            btn1.Enabled = False
        Else
            btn1.Enabled = True
        End If

        If lstTarde.Items(lstTarde.SelectedIndex) = False Then
            btn2.Enabled = False
            btn3.Enabled = False
        Else
            btn2.Enabled = True
            btn3.Enabled = True
        End If

        If lstNoche.Items(lstNoche.SelectedIndex) = False Then
            btn4.Enabled = False
        Else
            btn4.Enabled = True
        End If
    End Sub

    Private Sub maximo()



    End Sub
End Class
