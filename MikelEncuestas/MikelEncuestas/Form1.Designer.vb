<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHacerEncues = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.rdbSiempre = New System.Windows.Forms.RadioButton()
        Me.rdbAmenudo = New System.Windows.Forms.RadioButton()
        Me.rdbAveces = New System.Windows.Forms.RadioButton()
        Me.rdbPocas = New System.Windows.Forms.RadioButton()
        Me.rdbNunca = New System.Windows.Forms.RadioButton()
        Me.lstEncuestas = New System.Windows.Forms.ListBox()
        Me.EncuestasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncuestasDataSet = New MikelEncuestas.encuestasDataSet()
        Me.EncuestasTableAdapter = New MikelEncuestas.encuestasDataSetTableAdapters.EncuestasTableAdapter()
        CType(Me.EncuestasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncuestasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(235, 151)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtContraseña.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contraseña:"
        '
        'btnHacerEncues
        '
        Me.btnHacerEncues.Location = New System.Drawing.Point(142, 196)
        Me.btnHacerEncues.Name = "btnHacerEncues"
        Me.btnHacerEncues.Size = New System.Drawing.Size(121, 23)
        Me.btnHacerEncues.TabIndex = 3
        Me.btnHacerEncues.Text = "Hacer la encuesta"
        Me.btnHacerEncues.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(330, 196)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(406, 483)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 5
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Location = New System.Drawing.Point(160, 247)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(39, 13)
        Me.lblPregunta.TabIndex = 6
        Me.lblPregunta.Text = "Label2"
        '
        'rdbSiempre
        '
        Me.rdbSiempre.AutoSize = True
        Me.rdbSiempre.Location = New System.Drawing.Point(235, 309)
        Me.rdbSiempre.Name = "rdbSiempre"
        Me.rdbSiempre.Size = New System.Drawing.Size(63, 17)
        Me.rdbSiempre.TabIndex = 7
        Me.rdbSiempre.TabStop = True
        Me.rdbSiempre.Text = "Siempre"
        Me.rdbSiempre.UseVisualStyleBackColor = True
        '
        'rdbAmenudo
        '
        Me.rdbAmenudo.AutoSize = True
        Me.rdbAmenudo.Location = New System.Drawing.Point(235, 332)
        Me.rdbAmenudo.Name = "rdbAmenudo"
        Me.rdbAmenudo.Size = New System.Drawing.Size(73, 17)
        Me.rdbAmenudo.TabIndex = 8
        Me.rdbAmenudo.TabStop = True
        Me.rdbAmenudo.Text = "A menudo"
        Me.rdbAmenudo.UseVisualStyleBackColor = True
        '
        'rdbAveces
        '
        Me.rdbAveces.AutoSize = True
        Me.rdbAveces.Location = New System.Drawing.Point(235, 355)
        Me.rdbAveces.Name = "rdbAveces"
        Me.rdbAveces.Size = New System.Drawing.Size(64, 17)
        Me.rdbAveces.TabIndex = 9
        Me.rdbAveces.TabStop = True
        Me.rdbAveces.Text = "A veces"
        Me.rdbAveces.UseVisualStyleBackColor = True
        '
        'rdbPocas
        '
        Me.rdbPocas.AutoSize = True
        Me.rdbPocas.Location = New System.Drawing.Point(235, 378)
        Me.rdbPocas.Name = "rdbPocas"
        Me.rdbPocas.Size = New System.Drawing.Size(87, 17)
        Me.rdbPocas.TabIndex = 10
        Me.rdbPocas.TabStop = True
        Me.rdbPocas.Text = "Pocas veces"
        Me.rdbPocas.UseVisualStyleBackColor = True
        '
        'rdbNunca
        '
        Me.rdbNunca.AutoSize = True
        Me.rdbNunca.Location = New System.Drawing.Point(235, 401)
        Me.rdbNunca.Name = "rdbNunca"
        Me.rdbNunca.Size = New System.Drawing.Size(57, 17)
        Me.rdbNunca.TabIndex = 11
        Me.rdbNunca.TabStop = True
        Me.rdbNunca.Text = "Nunca"
        Me.rdbNunca.UseVisualStyleBackColor = True
        '
        'lstEncuestas
        '
        Me.lstEncuestas.DataSource = Me.EncuestasBindingSource
        Me.lstEncuestas.DisplayMember = "Descripción"
        Me.lstEncuestas.FormattingEnabled = True
        Me.lstEncuestas.Location = New System.Drawing.Point(78, 21)
        Me.lstEncuestas.Name = "lstEncuestas"
        Me.lstEncuestas.Size = New System.Drawing.Size(370, 95)
        Me.lstEncuestas.TabIndex = 12
        Me.lstEncuestas.ValueMember = "codEncuesta"
        '
        'EncuestasBindingSource
        '
        Me.EncuestasBindingSource.DataMember = "Encuestas"
        Me.EncuestasBindingSource.DataSource = Me.EncuestasDataSet
        '
        'EncuestasDataSet
        '
        Me.EncuestasDataSet.DataSetName = "encuestasDataSet"
        Me.EncuestasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EncuestasTableAdapter
        '
        Me.EncuestasTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 530)
        Me.Controls.Add(Me.lstEncuestas)
        Me.Controls.Add(Me.rdbNunca)
        Me.Controls.Add(Me.rdbPocas)
        Me.Controls.Add(Me.rdbAveces)
        Me.Controls.Add(Me.rdbAmenudo)
        Me.Controls.Add(Me.rdbSiempre)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnHacerEncues)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContraseña)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EncuestasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncuestasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHacerEncues As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents lblPregunta As Label
    Friend WithEvents rdbSiempre As RadioButton
    Friend WithEvents rdbAmenudo As RadioButton
    Friend WithEvents rdbAveces As RadioButton
    Friend WithEvents rdbPocas As RadioButton
    Friend WithEvents rdbNunca As RadioButton
    Friend WithEvents lstEncuestas As ListBox
    Friend WithEvents EncuestasDataSet As encuestasDataSet
    Friend WithEvents EncuestasBindingSource As BindingSource
    Friend WithEvents EncuestasTableAdapter As encuestasDataSetTableAdapters.EncuestasTableAdapter
End Class
