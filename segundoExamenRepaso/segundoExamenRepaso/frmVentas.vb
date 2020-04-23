Public Class frmVentas
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DabadabaDataSet.Conciertos' Puede moverla o quitarla según sea necesario.
        Me.ConciertosTableAdapter.Fill(Me.DabadabaDataSet.Conciertos)
        txtEntradas.Text = 1
    End Sub

    Private Sub lstConciertos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConciertos.SelectedIndexChanged, chbTaquilla.CheckedChanged
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dabadaba.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "select * from conciertos where id=" & lstConciertos.SelectedValue


            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader

            If dr.Read() Then
                If chbTaquilla.Checked Then
                    txtPrecio.Text = dr("taquilla")
                Else
                    txtPrecio.Text = dr("precio")
                End If

            End If
            txtTotal.Text = Val(txtEntradas.Text) * Val(txtPrecio.Text)
            dr.Close()

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dabadaba.accdb;")
            conexion.Open()

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text


            MsgBox(cmd.CommandText = "SELECT SUM(ENTRADAS) FROM ENTRADAS WHERE CONCIERTO = " & Val(lstConciertos.SelectedValue))
            Dim numEntradas As Integer
            numEntradas = cmd.ExecuteScalar
            If numEntradas < 150 Then
                cmd.CommandText = "INSERT INTO ENTRADAS(CONCIERTO, NOMBRECOMPLETO, MOVIL, EMAIL, ENTRADAS, TAQUILLA) VALUES(" & lstConciertos.SelectedValue & ", '" & txtNombre.Text & "', '" & txtTelfono.Text & "', '" & txtEmail.Text & "', " & txtEntradas.Text & ", " & chbTaquilla.Checked & ")"
                cmd.ExecuteNonQuery()
            Else
                MsgBox("El concierto está lleno")
            End If


            txtNombre.Clear()
            txtTelfono.Clear()
            txtEmail.Clear()

            txtEntradas.Text = 1
            'txtTotal.Text = Val(txtEntradas.Text) * Val(txtPrecio.Text)


            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "Saliendo de la aplicación.")
            Me.Close()
        End Try
    End Sub
    Private Sub botonGuardar()
        If txtNombre.TextLength Then

        End If
    End Sub

    Private Sub total() Handles lstConciertos.SelectedIndexChanged, chbTaquilla.CheckedChanged, txtEntradas.TextChanged, txtPrecio.TextChanged
        txtTotal.Text = Val(txtEntradas.Text) * Val(txtPrecio.Text)
    End Sub

    Private Sub habilitarBotonGuardar() Handles txtNombre.TextChanged, txtTelfono.TextChanged, txtEmail.TextChanged, txtEntradas.TextChanged, lstConciertos.SelectedIndexChanged
        If txtNombre.TextLength = 0 Or txtTelfono.TextLength = 0 Or txtEmail.TextLength = 0 Or txtEntradas.TextLength = 0 Or lstConciertos.SelectedIndex = False Then
            btnGuardar.Enabled = False
        Else
            btnGuardar.Enabled = True
        End If
    End Sub
    Dim texto As String
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            texto = vbCrLf & "NOMBRE: " & txtNombre.Text & vbCrLf &
                    vbCrLf & "TELEFONO: " & txtTelfono.Text & vbCrLf &
                    vbCrLf & "eMAIL: " & txtEmail.Text & vbCrLf &
                    vbCrLf & "Concierto: " & lstConciertos.SelectedIndex & vbCrLf &
                    vbCrLf & "Entradas: " & txtEntradas.Text & vbCrLf &
                    vbCrLf & "taquilla: " & chbTaquilla.Checked & vbCrLf &
                    vbCrLf & "precio: " & txtPrecio.Text & vbCrLf &
                    vbCrLf & "Total: " & txtTotal.Text & vbCrLf
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim LAPIZ As New SolidBrush(Color.Black)
        Dim AREA_IMPRESION As Graphics = e.Graphics
        AREA_IMPRESION.DrawString(texto, txtNombre.Font, LAPIZ, 0, 0)
    End Sub


End Class