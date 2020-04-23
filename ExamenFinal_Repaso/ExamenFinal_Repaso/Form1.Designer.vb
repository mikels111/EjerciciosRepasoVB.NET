<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lstEncuestas = New System.Windows.Forms.ListBox()
        Me.EncuestasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncuestasDataSet = New ExamenFinal_Repaso.encuestasDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnHacerEncuesta = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.EncuestasTableAdapter = New ExamenFinal_Repaso.encuestasDataSetTableAdapters.EncuestasTableAdapter()
        Me.gbRespuestas = New System.Windows.Forms.GroupBox()
        Me.rdbNunca = New System.Windows.Forms.RadioButton()
        Me.rdbPocas = New System.Windows.Forms.RadioButton()
        Me.rdbAVeces = New System.Windows.Forms.RadioButton()
        Me.rdbAMenudo = New System.Windows.Forms.RadioButton()
        Me.rdbSiempre = New System.Windows.Forms.RadioButton()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.EncuestasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncuestasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRespuestas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstEncuestas
        '
        Me.lstEncuestas.DataSource = Me.EncuestasBindingSource
        Me.lstEncuestas.DisplayMember = "Descripción"
        Me.lstEncuestas.FormattingEnabled = True
        Me.lstEncuestas.Location = New System.Drawing.Point(95, 25)
        Me.lstEncuestas.Name = "lstEncuestas"
        Me.lstEncuestas.Size = New System.Drawing.Size(312, 95)
        Me.lstEncuestas.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contraseña"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(256, 144)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 2
        '
        'btnHacerEncuesta
        '
        Me.btnHacerEncuesta.Location = New System.Drawing.Point(121, 188)
        Me.btnHacerEncuesta.Name = "btnHacerEncuesta"
        Me.btnHacerEncuesta.Size = New System.Drawing.Size(134, 23)
        Me.btnHacerEncuesta.TabIndex = 3
        Me.btnHacerEncuesta.Text = "Hacer encuesta"
        Me.btnHacerEncuesta.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(288, 188)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Location = New System.Drawing.Point(36, 247)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(0, 13)
        Me.lblPregunta.TabIndex = 5
        '
        'EncuestasTableAdapter
        '
        Me.EncuestasTableAdapter.ClearBeforeFill = True
        '
        'gbRespuestas
        '
        Me.gbRespuestas.Controls.Add(Me.rdbNunca)
        Me.gbRespuestas.Controls.Add(Me.rdbPocas)
        Me.gbRespuestas.Controls.Add(Me.rdbAVeces)
        Me.gbRespuestas.Controls.Add(Me.rdbAMenudo)
        Me.gbRespuestas.Controls.Add(Me.rdbSiempre)
        Me.gbRespuestas.Location = New System.Drawing.Point(150, 333)
        Me.gbRespuestas.Name = "gbRespuestas"
        Me.gbRespuestas.Size = New System.Drawing.Size(147, 168)
        Me.gbRespuestas.TabIndex = 6
        Me.gbRespuestas.TabStop = False
        Me.gbRespuestas.Text = "Valoración"
        '
        'rdbNunca
        '
        Me.rdbNunca.AutoSize = True
        Me.rdbNunca.Location = New System.Drawing.Point(26, 124)
        Me.rdbNunca.Name = "rdbNunca"
        Me.rdbNunca.Size = New System.Drawing.Size(57, 17)
        Me.rdbNunca.TabIndex = 4
        Me.rdbNunca.TabStop = True
        Me.rdbNunca.Text = "Nunca"
        Me.rdbNunca.UseVisualStyleBackColor = True
        '
        'rdbPocas
        '
        Me.rdbPocas.AutoSize = True
        Me.rdbPocas.Location = New System.Drawing.Point(26, 101)
        Me.rdbPocas.Name = "rdbPocas"
        Me.rdbPocas.Size = New System.Drawing.Size(87, 17)
        Me.rdbPocas.TabIndex = 3
        Me.rdbPocas.TabStop = True
        Me.rdbPocas.Text = "Pocas veces"
        Me.rdbPocas.UseVisualStyleBackColor = True
        '
        'rdbAVeces
        '
        Me.rdbAVeces.AutoSize = True
        Me.rdbAVeces.Location = New System.Drawing.Point(26, 78)
        Me.rdbAVeces.Name = "rdbAVeces"
        Me.rdbAVeces.Size = New System.Drawing.Size(64, 17)
        Me.rdbAVeces.TabIndex = 2
        Me.rdbAVeces.TabStop = True
        Me.rdbAVeces.Text = "A veces"
        Me.rdbAVeces.UseVisualStyleBackColor = True
        '
        'rdbAMenudo
        '
        Me.rdbAMenudo.AutoSize = True
        Me.rdbAMenudo.Location = New System.Drawing.Point(26, 55)
        Me.rdbAMenudo.Name = "rdbAMenudo"
        Me.rdbAMenudo.Size = New System.Drawing.Size(73, 17)
        Me.rdbAMenudo.TabIndex = 1
        Me.rdbAMenudo.TabStop = True
        Me.rdbAMenudo.Text = "A menudo"
        Me.rdbAMenudo.UseVisualStyleBackColor = True
        '
        'rdbSiempre
        '
        Me.rdbSiempre.AutoSize = True
        Me.rdbSiempre.Location = New System.Drawing.Point(26, 32)
        Me.rdbSiempre.Name = "rdbSiempre"
        Me.rdbSiempre.Size = New System.Drawing.Size(63, 17)
        Me.rdbSiempre.TabIndex = 0
        Me.rdbSiempre.TabStop = True
        Me.rdbSiempre.Text = "Siempre"
        Me.rdbSiempre.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(311, 480)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 7
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(402, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 546)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.gbRespuestas)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnHacerEncuesta)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstEncuestas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EncuestasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncuestasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRespuestas.ResumeLayout(False)
        Me.gbRespuestas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstEncuestas As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnHacerEncuesta As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblPregunta As Label
    Friend WithEvents EncuestasDataSet As encuestasDataSet
    Friend WithEvents EncuestasBindingSource As BindingSource
    Friend WithEvents EncuestasTableAdapter As encuestasDataSetTableAdapters.EncuestasTableAdapter
    Friend WithEvents gbRespuestas As GroupBox
    Friend WithEvents rdbNunca As RadioButton
    Friend WithEvents rdbPocas As RadioButton
    Friend WithEvents rdbAVeces As RadioButton
    Friend WithEvents rdbAMenudo As RadioButton
    Friend WithEvents rdbSiempre As RadioButton
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents Label2 As Label
End Class
