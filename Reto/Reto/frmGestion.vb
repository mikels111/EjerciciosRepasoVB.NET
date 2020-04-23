Public Class frmGestion

    Dim x As New Point
    Dim pantalla As New Size

    Private Sub ComercialBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ComercialBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.ComercialBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ChargeneticDataSet)

    End Sub

    Private Sub frmGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x.X = pnlComercial.Location.X
        x.Y = pnlComercial.Location.Y
        pantalla.Width = pnlComercial.Size.Width + 50
        pantalla.Height = Me.Size.Height
        Me.Size = pantalla
        If (Form1.ComercialesToolStripMenuItem.Pressed) Then

            pnlComercial.Visible = True
            Me.ComercialTableAdapter.Fill(Me.ChargeneticDataSet.Comercial)
            CTCABindingNavigator.BindingSource = ComercialBindingSource

        ElseIf (Form1.TransportesToolStripMenuItem.Pressed) Then

            pnlTransportista.Visible = True
            pnlTransportista.Location = x
            Me.TransportistaTableAdapter.Fill(Me.ChargeneticDataSet.Transportista)
            CTCABindingNavigator.BindingSource = TransportistaBindingSource

        ElseIf (Form1.PartnersToolStripMenuItem1.Pressed) Then

            pnlCliente.Visible = True
            pnlCliente.Location = x
            Me.ClienteTableAdapter.Fill(Me.ChargeneticDataSet.Cliente)
            CTCABindingNavigator.BindingSource = ClienteBindingSource

        ElseIf (Form1.ArticulosToolStripMenuItem.Pressed) Then

            pnlArticulo.Visible = True
            pnlArticulo.Location = x
            Me.ArticuloTableAdapter.Fill(Me.ChargeneticDataSet.Articulo)
            CTCABindingNavigator.BindingSource = ArticuloBindingSource

            pcbFoto.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Fotos\" & txtFoto.Text)

        End If

    End Sub

    Private Sub txtFoto_TextChanged(sender As Object, e As EventArgs) Handles txtFoto.TextChanged

        pcbFoto.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Fotos\" & txtFoto.Text)

    End Sub
End Class