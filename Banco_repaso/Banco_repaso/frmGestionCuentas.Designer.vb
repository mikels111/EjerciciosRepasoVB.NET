<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionCuentas
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
        Me.BancoDataSet = New Banco_repaso.BancoDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Banco_repaso.BancoDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Banco_repaso.BancoDataSetTableAdapters.TableAdapterManager()
        Me.DepositosTableAdapter = New Banco_repaso.BancoDataSetTableAdapters.DepositosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lstDescripcionDepositos = New System.Windows.Forms.ListBox()
        Me.DepositosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstDescripcionPrestamo = New System.Windows.Forms.ListBox()
        Me.PrestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestamosTableAdapter = New Banco_repaso.BancoDataSetTableAdapters.PrestamosTableAdapter()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepositosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "BancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BancoDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.DepositosTableAdapter = Me.DepositosTableAdapter
        Me.TableAdapterManager.PrestamosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Banco_repaso.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DepositosTableAdapter
        '
        Me.DepositosTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'cmbCliente
        '
        Me.cmbCliente.DataSource = Me.ClientesBindingSource
        Me.cmbCliente.DisplayMember = "DNI"
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(30, 90)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(121, 21)
        Me.cmbCliente.TabIndex = 2
        Me.cmbCliente.ValueMember = "Nombre"
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.BancoDataSet
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(213, 90)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(113, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Depositos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Prestamo"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(33, 333)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 23)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar deposito"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(213, 333)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(113, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar prestamo"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(33, 415)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 23)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(103, 415)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(52, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lstDescripcionDepositos
        '
        Me.lstDescripcionDepositos.FormattingEnabled = True
        Me.lstDescripcionDepositos.Location = New System.Drawing.Point(33, 208)
        Me.lstDescripcionDepositos.Name = "lstDescripcionDepositos"
        Me.lstDescripcionDepositos.Size = New System.Drawing.Size(120, 95)
        Me.lstDescripcionDepositos.TabIndex = 12
        '
        'DepositosBindingSource
        '
        Me.DepositosBindingSource.DataMember = "Depositos"
        Me.DepositosBindingSource.DataSource = Me.BancoDataSet
        '
        'ClientesBindingSource2
        '
        Me.ClientesBindingSource2.DataMember = "Clientes"
        Me.ClientesBindingSource2.DataSource = Me.BancoDataSet
        '
        'ClientesBindingSource3
        '
        Me.ClientesBindingSource3.DataMember = "Clientes"
        Me.ClientesBindingSource3.DataSource = Me.BancoDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Label5"
        '
        'lstDescripcionPrestamo
        '
        Me.lstDescripcionPrestamo.FormattingEnabled = True
        Me.lstDescripcionPrestamo.Location = New System.Drawing.Point(213, 208)
        Me.lstDescripcionPrestamo.Name = "lstDescripcionPrestamo"
        Me.lstDescripcionPrestamo.Size = New System.Drawing.Size(120, 95)
        Me.lstDescripcionPrestamo.TabIndex = 14
        '
        'PrestamosBindingSource
        '
        Me.PrestamosBindingSource.DataMember = "Prestamos"
        Me.PrestamosBindingSource.DataSource = Me.BancoDataSet
        '
        'PrestamosTableAdapter
        '
        Me.PrestamosTableAdapter.ClearBeforeFill = True
        '
        'frmGestionCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 450)
        Me.Controls.Add(Me.lstDescripcionPrestamo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstDescripcionDepositos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGestionCuentas"
        Me.Text = "frmGestionCuentas"
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepositosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BancoDataSet As BancoDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BancoDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As BancoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lstDescripcionDepositos As ListBox
    Friend WithEvents DepositosTableAdapter As BancoDataSetTableAdapters.DepositosTableAdapter
    Friend WithEvents DepositosBindingSource As BindingSource
    Friend WithEvents ClientesBindingSource2 As BindingSource
    Friend WithEvents ClientesBindingSource3 As BindingSource
    Friend WithEvents Label5 As Label
    Friend WithEvents lstDescripcionPrestamo As ListBox
    Friend WithEvents PrestamosBindingSource As BindingSource
    Friend WithEvents PrestamosTableAdapter As BancoDataSetTableAdapters.PrestamosTableAdapter
End Class
