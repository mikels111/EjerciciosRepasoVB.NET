Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.MdiParent = Me
        frmClientes.Show()
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem.Click
        frmGestionCuentas.MdiParent = Me
        frmGestionCuentas.Show()
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class
