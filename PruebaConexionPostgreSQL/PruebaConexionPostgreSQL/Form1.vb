Public Class Form1
    Private mCon As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MyCon As New Odbc.OdbcConnection
        MyCon.ConnectionString = "Driver={PostgreSQL ANSI};database=database_name;server=127.0.0.1;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;User ID=postgres;password=password;"

        MyCon.Open()
        If mCon.State = ConnectionState.Open Then
            MsgBox("Connected To PostGres", MsgBoxStyle.MsgBoxSetForeground)
        End If




    End Sub
End Class
