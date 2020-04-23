<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chbTaquilla = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEntradas = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelfono = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lstConciertos = New System.Windows.Forms.ListBox()
        Me.ConciertosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DabadabaDataSet = New segundoExamenRepaso.dabadabaDataSet()
        Me.ConciertosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConciertosTableAdapter = New segundoExamenRepaso.dabadabaDataSetTableAdapters.ConciertosTableAdapter()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.ConciertosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DabadabaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConciertosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(138, 57)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(44, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "tlf"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "eMail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Entradas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(227, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(227, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total"
        '
        'chbTaquilla
        '
        Me.chbTaquilla.AutoSize = True
        Me.chbTaquilla.Location = New System.Drawing.Point(230, 197)
        Me.chbTaquilla.Name = "chbTaquilla"
        Me.chbTaquilla.Size = New System.Drawing.Size(63, 17)
        Me.chbTaquilla.TabIndex = 7
        Me.chbTaquilla.Text = "Taquilla"
        Me.chbTaquilla.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(230, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 8
        '
        'txtEntradas
        '
        Me.txtEntradas.Location = New System.Drawing.Point(230, 163)
        Me.txtEntradas.Name = "txtEntradas"
        Me.txtEntradas.Size = New System.Drawing.Size(100, 20)
        Me.txtEntradas.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(230, 129)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 10
        '
        'txtTelfono
        '
        Me.txtTelfono.Location = New System.Drawing.Point(230, 92)
        Me.txtTelfono.Name = "txtTelfono"
        Me.txtTelfono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelfono.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(359, 321)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(296, 237)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(34, 20)
        Me.txtPrecio.TabIndex = 13
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(296, 279)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(34, 20)
        Me.txtTotal.TabIndex = 14
        '
        'lstConciertos
        '
        Me.lstConciertos.DataSource = Me.ConciertosBindingSource1
        Me.lstConciertos.DisplayMember = "Grupo"
        Me.lstConciertos.FormattingEnabled = True
        Me.lstConciertos.Location = New System.Drawing.Point(417, 57)
        Me.lstConciertos.Name = "lstConciertos"
        Me.lstConciertos.Size = New System.Drawing.Size(128, 186)
        Me.lstConciertos.TabIndex = 15
        Me.lstConciertos.ValueMember = "Id"
        '
        'ConciertosBindingSource1
        '
        Me.ConciertosBindingSource1.DataMember = "Conciertos"
        Me.ConciertosBindingSource1.DataSource = Me.DabadabaDataSet
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
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(485, 321)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 16
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lstConciertos)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtTelfono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtEntradas)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.chbTaquilla)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "frmVentas"
        Me.Text = "Ventas"
        CType(Me.ConciertosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DabadabaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConciertosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chbTaquilla As CheckBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEntradas As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelfono As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lstConciertos As ListBox
    Friend WithEvents DabadabaDataSet As dabadabaDataSet
    Friend WithEvents ConciertosBindingSource As BindingSource
    Friend WithEvents ConciertosTableAdapter As dabadabaDataSetTableAdapters.ConciertosTableAdapter
    Friend WithEvents ConciertosBindingSource1 As BindingSource
    Friend WithEvents btnImprimir As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
