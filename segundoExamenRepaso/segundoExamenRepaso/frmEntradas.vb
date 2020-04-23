Public Class frmEntradas
    Private Sub EntradasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EntradasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EntradasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DabadabaDataSet)

    End Sub

    Private Sub frmEntradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DabadabaDataSet.Conciertos' Puede moverla o quitarla según sea necesario.
        Me.ConciertosTableAdapter.Fill(Me.DabadabaDataSet.Conciertos)
        'TODO: esta línea de código carga datos en la tabla 'DabadabaDataSet.Entradas' Puede moverla o quitarla según sea necesario.
        Me.EntradasTableAdapter.Fill(Me.DabadabaDataSet.Entradas)

    End Sub

    Private Sub cmbConcierto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConcierto.SelectedIndexChanged
        ConciertoTextBox.Text = cmbConcierto.SelectedValue
    End Sub

    Private Sub ConciertoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConciertoTextBox.TextChanged
        cmbConcierto.SelectedValue = Val(ConciertoTextBox.Text)
    End Sub
End Class