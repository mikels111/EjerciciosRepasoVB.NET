Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub ConciertosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConciertosToolStripMenuItem.Click
        frmConciertos.MdiParent = Me
        frmConciertos.Show()
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click
        frmEntradas.MdiParent = Me
        frmEntradas.Show()
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        frmVentas.MdiParent = Me
        frmVentas.Show()
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class
