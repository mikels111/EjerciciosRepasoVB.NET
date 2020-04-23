Public Class frmConciertos
    Private Sub ConciertosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ConciertosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DabadabaDataSet)

    End Sub

    Private Sub ConciertosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ConciertosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ConciertosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DabadabaDataSet)

    End Sub

    Private Sub frmConciertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DabadabaDataSet.Conciertos' Puede moverla o quitarla según sea necesario.
        Me.ConciertosTableAdapter.Fill(Me.DabadabaDataSet.Conciertos)

    End Sub
End Class