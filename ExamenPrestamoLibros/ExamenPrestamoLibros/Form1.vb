Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PréstamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PréstamoToolStripMenuItem.Click
        frmPrestamo.MdiParent = Me
        frmPrestamo.Show()
        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub


End Class
