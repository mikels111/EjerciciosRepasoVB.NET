<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamo
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
        Me.lstLibros = New System.Windows.Forms.ListBox()
        Me.LibrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BibliotecaDataSet = New ExamenPrestamoLibros.BibliotecaDataSet()
        Me.LibrosTableAdapter = New ExamenPrestamoLibros.BibliotecaDataSetTableAdapters.LibrosTableAdapter()
        Me.cmbSocios = New System.Windows.Forms.ComboBox()
        Me.SociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SociosTableAdapter = New ExamenPrestamoLibros.BibliotecaDataSetTableAdapters.SociosTableAdapter()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lstPrestamos = New System.Windows.Forms.ListBox()
        Me.LibrosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrestamosTableAdapter = New ExamenPrestamoLibros.BibliotecaDataSetTableAdapters.PrestamosTableAdapter()
        Me.label = New System.Windows.Forms.Label()
        Me.lblPrestados = New System.Windows.Forms.Label()
        Me.btnPrestamo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCopias = New System.Windows.Forms.Label()
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BibliotecaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstLibros
        '
        Me.lstLibros.DataSource = Me.LibrosBindingSource
        Me.lstLibros.DisplayMember = "Titulo"
        Me.lstLibros.FormattingEnabled = True
        Me.lstLibros.Location = New System.Drawing.Point(111, 52)
        Me.lstLibros.Name = "lstLibros"
        Me.lstLibros.Size = New System.Drawing.Size(163, 212)
        Me.lstLibros.TabIndex = 0
        Me.lstLibros.ValueMember = "id"
        '
        'LibrosBindingSource
        '
        Me.LibrosBindingSource.DataMember = "Libros"
        Me.LibrosBindingSource.DataSource = Me.BibliotecaDataSet
        '
        'BibliotecaDataSet
        '
        Me.BibliotecaDataSet.DataSetName = "BibliotecaDataSet"
        Me.BibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibrosTableAdapter
        '
        Me.LibrosTableAdapter.ClearBeforeFill = True
        '
        'cmbSocios
        '
        Me.cmbSocios.DataSource = Me.SociosBindingSource
        Me.cmbSocios.DisplayMember = "Nombre"
        Me.cmbSocios.FormattingEnabled = True
        Me.cmbSocios.Location = New System.Drawing.Point(440, 52)
        Me.cmbSocios.Name = "cmbSocios"
        Me.cmbSocios.Size = New System.Drawing.Size(121, 21)
        Me.cmbSocios.TabIndex = 1
        Me.cmbSocios.ValueMember = "Id"
        '
        'SociosBindingSource
        '
        Me.SociosBindingSource.DataMember = "Socios"
        Me.SociosBindingSource.DataSource = Me.BibliotecaDataSet
        '
        'SociosTableAdapter
        '
        Me.SociosTableAdapter.ClearBeforeFill = True
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Location = New System.Drawing.Point(440, 103)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(39, 13)
        Me.lblCiudad.TabIndex = 2
        Me.lblCiudad.Text = "Label1"
        '
        'lstPrestamos
        '
        Me.lstPrestamos.FormattingEnabled = True
        Me.lstPrestamos.Location = New System.Drawing.Point(440, 221)
        Me.lstPrestamos.Name = "lstPrestamos"
        Me.lstPrestamos.Size = New System.Drawing.Size(121, 43)
        Me.lstPrestamos.TabIndex = 3
        '
        'LibrosBindingSource1
        '
        Me.LibrosBindingSource1.DataMember = "Libros"
        Me.LibrosBindingSource1.DataSource = Me.BibliotecaDataSet
        '
        'PrestamosBindingSource
        '
        Me.PrestamosBindingSource.DataMember = "Prestamos"
        Me.PrestamosBindingSource.DataSource = Me.BibliotecaDataSet
        '
        'PrestamosTableAdapter
        '
        Me.PrestamosTableAdapter.ClearBeforeFill = True
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(440, 297)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(54, 13)
        Me.label.TabIndex = 4
        Me.label.Text = "Prestados"
        '
        'lblPrestados
        '
        Me.lblPrestados.AutoSize = True
        Me.lblPrestados.Location = New System.Drawing.Point(521, 296)
        Me.lblPrestados.Name = "lblPrestados"
        Me.lblPrestados.Size = New System.Drawing.Size(39, 13)
        Me.lblPrestados.TabIndex = 5
        Me.lblPrestados.Text = "Label1"
        '
        'btnPrestamo
        '
        Me.btnPrestamo.Location = New System.Drawing.Point(111, 344)
        Me.btnPrestamo.Name = "btnPrestamo"
        Me.btnPrestamo.Size = New System.Drawing.Size(75, 23)
        Me.btnPrestamo.TabIndex = 6
        Me.btnPrestamo.Text = "Prestamo"
        Me.btnPrestamo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Copias:"
        '
        'lblCopias
        '
        Me.lblCopias.AutoSize = True
        Me.lblCopias.Location = New System.Drawing.Point(159, 295)
        Me.lblCopias.Name = "lblCopias"
        Me.lblCopias.Size = New System.Drawing.Size(39, 13)
        Me.lblCopias.TabIndex = 8
        Me.lblCopias.Text = "Label2"
        '
        'frmPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCopias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrestamo)
        Me.Controls.Add(Me.lblPrestados)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.lstPrestamos)
        Me.Controls.Add(Me.lblCiudad)
        Me.Controls.Add(Me.cmbSocios)
        Me.Controls.Add(Me.lstLibros)
        Me.Name = "frmPrestamo"
        Me.Text = "frmPrestamo"
        CType(Me.LibrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BibliotecaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstLibros As ListBox
    Friend WithEvents BibliotecaDataSet As BibliotecaDataSet
    Friend WithEvents LibrosBindingSource As BindingSource
    Friend WithEvents LibrosTableAdapter As BibliotecaDataSetTableAdapters.LibrosTableAdapter
    Friend WithEvents cmbSocios As ComboBox
    Friend WithEvents SociosBindingSource As BindingSource
    Friend WithEvents SociosTableAdapter As BibliotecaDataSetTableAdapters.SociosTableAdapter
    Friend WithEvents lblCiudad As Label
    Friend WithEvents lstPrestamos As ListBox
    Friend WithEvents PrestamosBindingSource As BindingSource
    Friend WithEvents PrestamosTableAdapter As BibliotecaDataSetTableAdapters.PrestamosTableAdapter
    Friend WithEvents label As Label
    Friend WithEvents lblPrestados As Label
    Friend WithEvents LibrosBindingSource1 As BindingSource
    Friend WithEvents btnPrestamo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCopias As Label
End Class
