<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEntradas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntradas))
        Dim IdLabel As System.Windows.Forms.Label
        Dim ConciertoLabel As System.Windows.Forms.Label
        Dim Nombre_CompletoLabel As System.Windows.Forms.Label
        Dim MovilLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim EntradasLabel As System.Windows.Forms.Label
        Dim TaquillaLabel As System.Windows.Forms.Label
        Me.DabadabaDataSet = New segundoExamenRepaso.dabadabaDataSet()
        Me.EntradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntradasTableAdapter = New segundoExamenRepaso.dabadabaDataSetTableAdapters.EntradasTableAdapter()
        Me.TableAdapterManager = New segundoExamenRepaso.dabadabaDataSetTableAdapters.TableAdapterManager()
        Me.EntradasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EntradasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ConciertoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_CompletoTextBox = New System.Windows.Forms.TextBox()
        Me.MovilTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EntradasTextBox = New System.Windows.Forms.TextBox()
        Me.TaquillaCheckBox = New System.Windows.Forms.CheckBox()
        Me.cmbConcierto = New System.Windows.Forms.ComboBox()
        Me.ConciertosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConciertosTableAdapter = New segundoExamenRepaso.dabadabaDataSetTableAdapters.ConciertosTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        ConciertoLabel = New System.Windows.Forms.Label()
        Nombre_CompletoLabel = New System.Windows.Forms.Label()
        MovilLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        EntradasLabel = New System.Windows.Forms.Label()
        TaquillaLabel = New System.Windows.Forms.Label()
        CType(Me.DabadabaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EntradasBindingNavigator.SuspendLayout()
        CType(Me.ConciertosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DabadabaDataSet
        '
        Me.DabadabaDataSet.DataSetName = "dabadabaDataSet"
        Me.DabadabaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EntradasBindingSource
        '
        Me.EntradasBindingSource.DataMember = "Entradas"
        Me.EntradasBindingSource.DataSource = Me.DabadabaDataSet
        '
        'EntradasTableAdapter
        '
        Me.EntradasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConciertosTableAdapter = Me.ConciertosTableAdapter
        Me.TableAdapterManager.EntradasTableAdapter = Me.EntradasTableAdapter
        Me.TableAdapterManager.UpdateOrder = segundoExamenRepaso.dabadabaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EntradasBindingNavigator
        '
        Me.EntradasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EntradasBindingNavigator.BindingSource = Me.EntradasBindingSource
        Me.EntradasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EntradasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EntradasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EntradasBindingNavigatorSaveItem})
        Me.EntradasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EntradasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EntradasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EntradasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EntradasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EntradasBindingNavigator.Name = "EntradasBindingNavigator"
        Me.EntradasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EntradasBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.EntradasBindingNavigator.TabIndex = 0
        Me.EntradasBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'EntradasBindingNavigatorSaveItem
        '
        Me.EntradasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EntradasBindingNavigatorSaveItem.Image = CType(resources.GetObject("EntradasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EntradasBindingNavigatorSaveItem.Name = "EntradasBindingNavigatorSaveItem"
        Me.EntradasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EntradasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(141, 84)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradasBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(241, 81)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(104, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'ConciertoLabel
        '
        ConciertoLabel.AutoSize = True
        ConciertoLabel.Location = New System.Drawing.Point(141, 110)
        ConciertoLabel.Name = "ConciertoLabel"
        ConciertoLabel.Size = New System.Drawing.Size(55, 13)
        ConciertoLabel.TabIndex = 3
        ConciertoLabel.Text = "Concierto:"
        '
        'ConciertoTextBox
        '
        Me.ConciertoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradasBindingSource, "Concierto", True))
        Me.ConciertoTextBox.Location = New System.Drawing.Point(241, 107)
        Me.ConciertoTextBox.Name = "ConciertoTextBox"
        Me.ConciertoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ConciertoTextBox.TabIndex = 4
        '
        'Nombre_CompletoLabel
        '
        Nombre_CompletoLabel.AutoSize = True
        Nombre_CompletoLabel.Location = New System.Drawing.Point(141, 136)
        Nombre_CompletoLabel.Name = "Nombre_CompletoLabel"
        Nombre_CompletoLabel.Size = New System.Drawing.Size(94, 13)
        Nombre_CompletoLabel.TabIndex = 5
        Nombre_CompletoLabel.Text = "Nombre Completo:"
        '
        'Nombre_CompletoTextBox
        '
        Me.Nombre_CompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradasBindingSource, "Nombre Completo", True))
        Me.Nombre_CompletoTextBox.Location = New System.Drawing.Point(241, 133)
        Me.Nombre_CompletoTextBox.Name = "Nombre_CompletoTextBox"
        Me.Nombre_CompletoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Nombre_CompletoTextBox.TabIndex = 6
        '
        'MovilLabel
        '
        MovilLabel.AutoSize = True
        MovilLabel.Location = New System.Drawing.Point(141, 162)
        MovilLabel.Name = "MovilLabel"
        MovilLabel.Size = New System.Drawing.Size(34, 13)
        MovilLabel.TabIndex = 7
        MovilLabel.Text = "movil:"
        '
        'MovilTextBox
        '
        Me.MovilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradasBindingSource, "movil", True))
        Me.MovilTextBox.Location = New System.Drawing.Point(241, 159)
        Me.MovilTextBox.Name = "MovilTextBox"
        Me.MovilTextBox.Size = New System.Drawing.Size(104, 20)
        Me.MovilTextBox.TabIndex = 8
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(141, 188)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradasBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(241, 185)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(104, 20)
        Me.EmailTextBox.TabIndex = 10
        '
        'EntradasLabel
        '
        EntradasLabel.AutoSize = True
        EntradasLabel.Location = New System.Drawing.Point(141, 214)
        EntradasLabel.Name = "EntradasLabel"
        EntradasLabel.Size = New System.Drawing.Size(51, 13)
        EntradasLabel.TabIndex = 11
        EntradasLabel.Text = "entradas:"
        '
        'EntradasTextBox
        '
        Me.EntradasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntradasBindingSource, "entradas", True))
        Me.EntradasTextBox.Location = New System.Drawing.Point(241, 211)
        Me.EntradasTextBox.Name = "EntradasTextBox"
        Me.EntradasTextBox.Size = New System.Drawing.Size(104, 20)
        Me.EntradasTextBox.TabIndex = 12
        '
        'TaquillaLabel
        '
        TaquillaLabel.AutoSize = True
        TaquillaLabel.Location = New System.Drawing.Point(141, 242)
        TaquillaLabel.Name = "TaquillaLabel"
        TaquillaLabel.Size = New System.Drawing.Size(43, 13)
        TaquillaLabel.TabIndex = 13
        TaquillaLabel.Text = "taquilla:"
        '
        'TaquillaCheckBox
        '
        Me.TaquillaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.EntradasBindingSource, "taquilla", True))
        Me.TaquillaCheckBox.Location = New System.Drawing.Point(241, 237)
        Me.TaquillaCheckBox.Name = "TaquillaCheckBox"
        Me.TaquillaCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.TaquillaCheckBox.TabIndex = 14
        Me.TaquillaCheckBox.Text = "CheckBox1"
        Me.TaquillaCheckBox.UseVisualStyleBackColor = True
        '
        'cmbConcierto
        '
        Me.cmbConcierto.DataSource = Me.ConciertosBindingSource
        Me.cmbConcierto.DisplayMember = "Grupo"
        Me.cmbConcierto.FormattingEnabled = True
        Me.cmbConcierto.Location = New System.Drawing.Point(367, 107)
        Me.cmbConcierto.Name = "cmbConcierto"
        Me.cmbConcierto.Size = New System.Drawing.Size(121, 21)
        Me.cmbConcierto.TabIndex = 15
        Me.cmbConcierto.ValueMember = "Id"
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
        'frmEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbConcierto)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(ConciertoLabel)
        Me.Controls.Add(Me.ConciertoTextBox)
        Me.Controls.Add(Nombre_CompletoLabel)
        Me.Controls.Add(Me.Nombre_CompletoTextBox)
        Me.Controls.Add(MovilLabel)
        Me.Controls.Add(Me.MovilTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(EntradasLabel)
        Me.Controls.Add(Me.EntradasTextBox)
        Me.Controls.Add(TaquillaLabel)
        Me.Controls.Add(Me.TaquillaCheckBox)
        Me.Controls.Add(Me.EntradasBindingNavigator)
        Me.Name = "frmEntradas"
        Me.Text = "Entradas"
        CType(Me.DabadabaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EntradasBindingNavigator.ResumeLayout(False)
        Me.EntradasBindingNavigator.PerformLayout()
        CType(Me.ConciertosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DabadabaDataSet As dabadabaDataSet
    Friend WithEvents EntradasBindingSource As BindingSource
    Friend WithEvents EntradasTableAdapter As dabadabaDataSetTableAdapters.EntradasTableAdapter
    Friend WithEvents TableAdapterManager As dabadabaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EntradasBindingNavigator As BindingNavigator
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
    Friend WithEvents EntradasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ConciertoTextBox As TextBox
    Friend WithEvents Nombre_CompletoTextBox As TextBox
    Friend WithEvents MovilTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EntradasTextBox As TextBox
    Friend WithEvents TaquillaCheckBox As CheckBox
    Friend WithEvents ConciertosTableAdapter As dabadabaDataSetTableAdapters.ConciertosTableAdapter
    Friend WithEvents cmbConcierto As ComboBox
    Friend WithEvents ConciertosBindingSource As BindingSource
End Class
