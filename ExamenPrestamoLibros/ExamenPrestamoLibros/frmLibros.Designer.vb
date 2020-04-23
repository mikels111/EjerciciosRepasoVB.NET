<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim IsbnLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim IdEditorialLabel As System.Windows.Forms.Label
        Dim IdAutorLabel As System.Windows.Forms.Label
        Dim SinopsisLabel As System.Windows.Forms.Label
        Dim CopiasLabel As System.Windows.Forms.Label
        Dim IdIdiomaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibros))
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibrosTableAdapter1 = New ExamenPrestamoLibros.BibliotecaDataSetTableAdapters.LibrosTableAdapter()
        Me.BibliotecaDataSet = New ExamenPrestamoLibros.BibliotecaDataSet()
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New ExamenPrestamoLibros.BibliotecaDataSetTableAdapters.TableAdapterManager()
        Me.AutoresTableAdapter = New ExamenPrestamoLibros.BibliotecaDataSetTableAdapters.AutoresTableAdapter()
        Me.EditorialesTableAdapter = New ExamenPrestamoLibros.BibliotecaDataSetTableAdapters.EditorialesTableAdapter()
        Me.IdiomasTableAdapter = New ExamenPrestamoLibros.BibliotecaDataSetTableAdapters.IdiomasTableAdapter()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.IsbnTextBox = New System.Windows.Forms.TextBox()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.IdEditorialTextBox = New System.Windows.Forms.TextBox()
        Me.IdAutorTextBox = New System.Windows.Forms.TextBox()
        Me.SinopsisTextBox = New System.Windows.Forms.TextBox()
        Me.CopiasTextBox = New System.Windows.Forms.TextBox()
        Me.IdIdiomaTextBox = New System.Windows.Forms.TextBox()
        Me.cmbEditorial = New System.Windows.Forms.ComboBox()
        Me.EditorialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbAutores = New System.Windows.Forms.ComboBox()
        Me.AutoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbIdioma = New System.Windows.Forms.ComboBox()
        Me.IdiomasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        IsbnLabel = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        IdEditorialLabel = New System.Windows.Forms.Label()
        IdAutorLabel = New System.Windows.Forms.Label()
        SinopsisLabel = New System.Windows.Forms.Label()
        CopiasLabel = New System.Windows.Forms.Label()
        IdIdiomaLabel = New System.Windows.Forms.Label()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BibliotecaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditorialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdiomasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(146, 79)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'IsbnLabel
        '
        IsbnLabel.AutoSize = True
        IsbnLabel.Location = New System.Drawing.Point(146, 105)
        IsbnLabel.Name = "IsbnLabel"
        IsbnLabel.Size = New System.Drawing.Size(29, 13)
        IsbnLabel.TabIndex = 3
        IsbnLabel.Text = "isbn:"
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Location = New System.Drawing.Point(146, 131)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(36, 13)
        TituloLabel.TabIndex = 5
        TituloLabel.Text = "Titulo:"
        '
        'IdEditorialLabel
        '
        IdEditorialLabel.AutoSize = True
        IdEditorialLabel.Location = New System.Drawing.Point(146, 157)
        IdEditorialLabel.Name = "IdEditorialLabel"
        IdEditorialLabel.Size = New System.Drawing.Size(58, 13)
        IdEditorialLabel.TabIndex = 7
        IdEditorialLabel.Text = "id Editorial:"
        '
        'IdAutorLabel
        '
        IdAutorLabel.AutoSize = True
        IdAutorLabel.Location = New System.Drawing.Point(146, 183)
        IdAutorLabel.Name = "IdAutorLabel"
        IdAutorLabel.Size = New System.Drawing.Size(46, 13)
        IdAutorLabel.TabIndex = 9
        IdAutorLabel.Text = "id Autor:"
        '
        'SinopsisLabel
        '
        SinopsisLabel.AutoSize = True
        SinopsisLabel.Location = New System.Drawing.Point(146, 209)
        SinopsisLabel.Name = "SinopsisLabel"
        SinopsisLabel.Size = New System.Drawing.Size(49, 13)
        SinopsisLabel.TabIndex = 11
        SinopsisLabel.Text = "Sinopsis:"
        '
        'CopiasLabel
        '
        CopiasLabel.AutoSize = True
        CopiasLabel.Location = New System.Drawing.Point(146, 235)
        CopiasLabel.Name = "CopiasLabel"
        CopiasLabel.Size = New System.Drawing.Size(42, 13)
        CopiasLabel.TabIndex = 13
        CopiasLabel.Text = "Copias:"
        '
        'IdIdiomaLabel
        '
        IdIdiomaLabel.AutoSize = True
        IdIdiomaLabel.Location = New System.Drawing.Point(146, 261)
        IdIdiomaLabel.Name = "IdIdiomaLabel"
        IdIdiomaLabel.Size = New System.Drawing.Size(52, 13)
        IdIdiomaLabel.TabIndex = 15
        IdIdiomaLabel.Text = "id Idioma:"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(800, 25)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LibrosTableAdapter1
        '
        Me.LibrosTableAdapter1.ClearBeforeFill = True
        '
        'BibliotecaDataSet
        '
        Me.BibliotecaDataSet.DataSetName = "BibliotecaDataSet"
        Me.BibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibrosBindingSource
        '
        Me.LibrosBindingSource.DataMember = "Libros"
        Me.LibrosBindingSource.DataSource = Me.BibliotecaDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutoresTableAdapter = Me.AutoresTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EditorialesTableAdapter = Me.EditorialesTableAdapter
        Me.TableAdapterManager.IdiomasTableAdapter = Me.IdiomasTableAdapter
        Me.TableAdapterManager.LibrosTableAdapter = Me.LibrosTableAdapter1
        Me.TableAdapterManager.PrestamosTableAdapter = Nothing
        Me.TableAdapterManager.SociosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ExamenPrestamoLibros.BibliotecaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AutoresTableAdapter
        '
        Me.AutoresTableAdapter.ClearBeforeFill = True
        '
        'EditorialesTableAdapter
        '
        Me.EditorialesTableAdapter.ClearBeforeFill = True
        '
        'IdiomasTableAdapter
        '
        Me.IdiomasTableAdapter.ClearBeforeFill = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(210, 76)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'IsbnTextBox
        '
        Me.IsbnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "isbn", True))
        Me.IsbnTextBox.Location = New System.Drawing.Point(210, 102)
        Me.IsbnTextBox.Name = "IsbnTextBox"
        Me.IsbnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IsbnTextBox.TabIndex = 4
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(210, 128)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TituloTextBox.TabIndex = 6
        '
        'IdEditorialTextBox
        '
        Me.IdEditorialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "idEditorial", True))
        Me.IdEditorialTextBox.Location = New System.Drawing.Point(210, 154)
        Me.IdEditorialTextBox.Name = "IdEditorialTextBox"
        Me.IdEditorialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdEditorialTextBox.TabIndex = 8
        '
        'IdAutorTextBox
        '
        Me.IdAutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "idAutor", True))
        Me.IdAutorTextBox.Location = New System.Drawing.Point(210, 180)
        Me.IdAutorTextBox.Name = "IdAutorTextBox"
        Me.IdAutorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdAutorTextBox.TabIndex = 10
        '
        'SinopsisTextBox
        '
        Me.SinopsisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "Sinopsis", True))
        Me.SinopsisTextBox.Location = New System.Drawing.Point(210, 206)
        Me.SinopsisTextBox.Name = "SinopsisTextBox"
        Me.SinopsisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SinopsisTextBox.TabIndex = 12
        '
        'CopiasTextBox
        '
        Me.CopiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "Copias", True))
        Me.CopiasTextBox.Location = New System.Drawing.Point(210, 232)
        Me.CopiasTextBox.Name = "CopiasTextBox"
        Me.CopiasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CopiasTextBox.TabIndex = 14
        '
        'IdIdiomaTextBox
        '
        Me.IdIdiomaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibrosBindingSource, "idIdioma", True))
        Me.IdIdiomaTextBox.Location = New System.Drawing.Point(210, 258)
        Me.IdIdiomaTextBox.Name = "IdIdiomaTextBox"
        Me.IdIdiomaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdIdiomaTextBox.TabIndex = 16
        '
        'cmbEditorial
        '
        Me.cmbEditorial.DataSource = Me.EditorialesBindingSource
        Me.cmbEditorial.DisplayMember = "Nombre"
        Me.cmbEditorial.FormattingEnabled = True
        Me.cmbEditorial.Location = New System.Drawing.Point(348, 154)
        Me.cmbEditorial.Name = "cmbEditorial"
        Me.cmbEditorial.Size = New System.Drawing.Size(121, 21)
        Me.cmbEditorial.TabIndex = 17
        Me.cmbEditorial.ValueMember = "Id"
        '
        'EditorialesBindingSource
        '
        Me.EditorialesBindingSource.DataMember = "Editoriales"
        Me.EditorialesBindingSource.DataSource = Me.BibliotecaDataSet
        '
        'LibrosBindingSource1
        '
        Me.LibrosBindingSource1.DataMember = "Libros"
        Me.LibrosBindingSource1.DataSource = Me.BibliotecaDataSet
        '
        'cmbAutores
        '
        Me.cmbAutores.DataSource = Me.AutoresBindingSource
        Me.cmbAutores.DisplayMember = "Nombre"
        Me.cmbAutores.FormattingEnabled = True
        Me.cmbAutores.Location = New System.Drawing.Point(348, 182)
        Me.cmbAutores.Name = "cmbAutores"
        Me.cmbAutores.Size = New System.Drawing.Size(121, 21)
        Me.cmbAutores.TabIndex = 18
        Me.cmbAutores.ValueMember = "Id"
        '
        'AutoresBindingSource
        '
        Me.AutoresBindingSource.DataMember = "Autores"
        Me.AutoresBindingSource.DataSource = Me.BibliotecaDataSet
        '
        'cmbIdioma
        '
        Me.cmbIdioma.DataSource = Me.IdiomasBindingSource
        Me.cmbIdioma.DisplayMember = "Nombre"
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.Location = New System.Drawing.Point(348, 261)
        Me.cmbIdioma.Name = "cmbIdioma"
        Me.cmbIdioma.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdioma.TabIndex = 19
        Me.cmbIdioma.ValueMember = "Id"
        '
        'IdiomasBindingSource
        '
        Me.IdiomasBindingSource.DataMember = "Idiomas"
        Me.IdiomasBindingSource.DataSource = Me.BibliotecaDataSet
        '
        'frmLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbIdioma)
        Me.Controls.Add(Me.cmbAutores)
        Me.Controls.Add(Me.cmbEditorial)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(IsbnLabel)
        Me.Controls.Add(Me.IsbnTextBox)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(IdEditorialLabel)
        Me.Controls.Add(Me.IdEditorialTextBox)
        Me.Controls.Add(IdAutorLabel)
        Me.Controls.Add(Me.IdAutorTextBox)
        Me.Controls.Add(SinopsisLabel)
        Me.Controls.Add(Me.SinopsisTextBox)
        Me.Controls.Add(CopiasLabel)
        Me.Controls.Add(Me.CopiasTextBox)
        Me.Controls.Add(IdIdiomaLabel)
        Me.Controls.Add(Me.IdIdiomaTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmLibros"
        Me.Text = "frmLibros"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BibliotecaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditorialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdiomasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents LibrosTableAdapter1 As BibliotecaDataSetTableAdapters.LibrosTableAdapter
    Friend WithEvents BibliotecaDataSet As BibliotecaDataSet
    Friend WithEvents LibrosBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As BibliotecaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EditorialesTableAdapter As BibliotecaDataSetTableAdapters.EditorialesTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents IsbnTextBox As TextBox
    Friend WithEvents TituloTextBox As TextBox
    Friend WithEvents IdEditorialTextBox As TextBox
    Friend WithEvents IdAutorTextBox As TextBox
    Friend WithEvents SinopsisTextBox As TextBox
    Friend WithEvents CopiasTextBox As TextBox
    Friend WithEvents IdIdiomaTextBox As TextBox
    Friend WithEvents cmbEditorial As ComboBox
    Friend WithEvents LibrosBindingSource1 As BindingSource
    Friend WithEvents EditorialesBindingSource As BindingSource
    Friend WithEvents AutoresTableAdapter As BibliotecaDataSetTableAdapters.AutoresTableAdapter
    Friend WithEvents cmbAutores As ComboBox
    Friend WithEvents AutoresBindingSource As BindingSource
    Friend WithEvents IdiomasTableAdapter As BibliotecaDataSetTableAdapters.IdiomasTableAdapter
    Friend WithEvents cmbIdioma As ComboBox
    Friend WithEvents IdiomasBindingSource As BindingSource
End Class
