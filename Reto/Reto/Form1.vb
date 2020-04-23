Public Class Form1
    Private Sub PartnersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComercialesToolStripMenuItem.Click, TransportesToolStripMenuItem.Click, PartnersToolStripMenuItem1.Click, ArticulosToolStripMenuItem.Click

        frmGestion.Show()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub
End Class
