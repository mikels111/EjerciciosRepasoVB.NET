<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConciertos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim GrupoLabel As System.Windows.Forms.Label
        Dim DiaLabel As System.Windows.Forms.Label
        Dim HoraLabel As System.Windows.Forms.Label
        Dim TaquillaLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConciertos))
        Me.DabadabaDataSet = New segundoExamenRepaso.dabadabaDataSet()
        Me.ConciertosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConciertosTableAdapter = New segundoExamenRepaso.dabadabaDataSetTableAdapters.ConciertosTableAdapter()
        Me.TableAdapterManager = New segundoExamenRepaso.dabadabaDataSetTableAdapters.TableAdapterManager()
        Me.ConciertosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ConciertosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoTextBox = New System.Windows.Forms.TextBox()
        Me.DiaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HoraTextBox = New System.Windows.Forms.TextBox()
        Me.TaquillaTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.ConciertosTableAdapter1 = New segundoExamenRepaso.dabadabaDataSetTableAdapters.ConciertosTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        GrupoLabel = New System.Windows.Forms.Label()
        DiaLabel = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        TaquillaLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.DabadabaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConciertosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConciertosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConciertosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(132, 103)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Location = New System.Drawing.Point(132, 129)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(39, 13)
        GrupoLabel.TabIndex = 3
        GrupoLabel.Text = "Grupo:"
        '
        'DiaLabel
        '
        DiaLabel.AutoSize = True
        DiaLabel.Location = New System.Drawing.Point(132, 156)
        DiaLabel.Name = "DiaLabel"
        DiaLabel.Size = New System.Drawing.Size(24, 13)
        DiaLabel.TabIndex = 5
        DiaLabel.Text = "dia:"
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Location = New System.Drawing.Point(132, 181)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(31, 13)
        HoraLabel.TabIndex = 7
        HoraLabel.Text = "hora:"
        '
        'TaquillaLabel
        '
        TaquillaLabel.AutoSize = True
        TaquillaLabel.Location = New System.Drawing.Point(132, 207)
        TaquillaLabel.Name = "TaquillaLabel"
        TaquillaLabel.Size = New System.Drawing.Size(43, 13)
        TaquillaLabel.TabIndex = 9
        TaquillaLabel.Text = "taquilla:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(132, 233)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(39, 13)
        PrecioLabel.TabIndex = 11
        PrecioLabel.Text = "precio:"
        '
        'DabadabaDataSet
        '
        Me.DabadabaDataSet.DataSetName = "dabadabaDataSet"
        Me.DabadabaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConciertosBindingSource
        '
        Me.ConciertosBindingSource.DataMember = "Conciertos"
        Me.ConciertosBindingSource.DataSource = Me.DabadabaDataSet
        '
        'ConciertosTableAdapter
        '
        Me.ConciertosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConciertosTableAdapter = Me.ConciertosTableAdapter
        Me.TableAdapterManager.EntradasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = segundoExamenRepaso.dabadabaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConciertosBindingNavigator
        '
        Me.ConciertosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ConciertosBindingNavigator.BindingSource = Me.ConciertosBindingSource
        Me.ConciertosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ConciertosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ConciertosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ConciertosBindingNavigatorSaveItem})
        Me.ConciertosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ConciertosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ConciertosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ConciertosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ConciertosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ConciertosBindingNavigator.Name = "ConciertosBindingNavigator"
        Me.ConciertosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ConciertosBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ConciertosBindingNavigator.TabIndex = 0
        Me.ConciertosBindingNavigator.Text = "BindingNavigator1"
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
        'ConciertosBindingNavigatorSaveItem
        '
        Me.ConciertosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConciertosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ConciertosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ConciertosBindingNavigatorSaveItem.Name = "ConciertosBindingNavigatorSaveItem"
        Me.ConciertosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ConciertosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConciertosBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(181, 100)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'GrupoTextBox
        '
        Me.GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConciertosBindingSource, "Grupo", True))
        Me.GrupoTextBox.Location = New System.Drawing.Point(181, 126)
        Me.GrupoTextBox.Name = "GrupoTextBox"
        Me.GrupoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GrupoTextBox.TabIndex = 4
        '
        'DiaDateTimePicker
        '
        Me.DiaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConciertosBindingSource, "dia", True))
        Me.DiaDateTimePicker.Location = New System.Drawing.Point(181, 152)
        Me.DiaDateTimePicker.Name = "DiaDateTimePicker"
        Me.DiaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DiaDateTimePicker.TabIndex = 6
        '
        'HoraTextBox
        '
        Me.HoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConciertosBindingSource, "hora", True))
        Me.HoraTextBox.Location = New System.Drawing.Point(181, 178)
        Me.HoraTextBox.Name = "HoraTextBox"
        Me.HoraTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HoraTextBox.TabIndex = 8
        '
        'TaquillaTextBox
        '
        Me.TaquillaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConciertosBindingSource, "taquilla", True))
        Me.TaquillaTextBox.Location = New System.Drawing.Point(181, 204)
        Me.TaquillaTextBox.Name = "TaquillaTextBox"
        Me.TaquillaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TaquillaTextBox.TabIndex = 10
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConciertosBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(181, 230)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrecioTextBox.TabIndex = 12
        '
        'ConciertosTableAdapter1
        '
        Me.ConciertosTableAdapter1.ClearBeforeFill = True
        '
        'frmConciertos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(GrupoLabel)
        Me.Controls.Add(Me.GrupoTextBox)
        Me.Controls.Add(DiaLabel)
        Me.Controls.Add(Me.DiaDateTimePicker)
        Me.Controls.Add(HoraLabel)
        Me.Controls.Add(Me.HoraTextBox)
        Me.Controls.Add(TaquillaLabel)
        Me.Controls.Add(Me.TaquillaTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(Me.ConciertosBindingNavigator)
        Me.Name = "frmConciertos"
        Me.Text = "conciertos"
        CType(Me.DabadabaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConciertosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConciertosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConciertosBindingNavigator.ResumeLayout(False)
        Me.ConciertosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DabadabaDataSet As dabadabaDataSet
    Friend WithEvents ConciertosBindingSource As BindingSource
    Friend WithEvents ConciertosTableAdapter As dabadabaDataSetTableAdapters.ConciertosTableAdapter
    Friend WithEvents TableAdapterManager As dabadabaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ConciertosBindingNavigator As BindingNavigator
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
    Friend WithEvents ConciertosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents GrupoTextBox As TextBox
    Friend WithEvents DiaDateTimePicker As DateTimePicker
    Friend WithEvents HoraTextBox As TextBox
    Friend WithEvents TaquillaTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents ConciertosTableAdapter1 As dabadabaDataSetTableAdapters.ConciertosTableAdapter
End Class
