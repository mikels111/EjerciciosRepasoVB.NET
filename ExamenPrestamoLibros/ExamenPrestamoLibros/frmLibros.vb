Public Class frmLibros
    Private Sub frmLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BibliotecaDataSet.Idiomas' Puede moverla o quitarla según sea necesario.
        Me.IdiomasTableAdapter.Fill(Me.BibliotecaDataSet.Idiomas)
        'TODO: esta línea de código carga datos en la tabla 'BibliotecaDataSet.Autores' Puede moverla o quitarla según sea necesario.
        Me.AutoresTableAdapter.Fill(Me.BibliotecaDataSet.Autores)
        'TODO: esta línea de código carga datos en la tabla 'BibliotecaDataSet.Editoriales' Puede moverla o quitarla según sea necesario.
        Me.EditorialesTableAdapter.Fill(Me.BibliotecaDataSet.Editoriales)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEditorial.SelectedIndexChanged
        IdEditorialTextBox.Text = cmbEditorial.SelectedValue
    End Sub

    Private Sub cmbAutores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAutores.SelectedIndexChanged
        IdAutorTextBox.Text = cmbAutores.SelectedValue
    End Sub

    Private Sub cmbIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdioma.SelectedIndexChanged
        IdIdiomaTextBox.Text = cmbIdioma.SelectedValue
    End Sub
End Class