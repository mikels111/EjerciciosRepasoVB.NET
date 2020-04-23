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
        Me.lstTemas = New System.Windows.Forms.ListBox()
        Me.BloqueTestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestInformaticaDataSet = New TestInformatico.TestInformaticaDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.rdbD = New System.Windows.Forms.RadioButton()
        Me.rdbC = New System.Windows.Forms.RadioButton()
        Me.rdbB = New System.Windows.Forms.RadioButton()
        Me.rdbA = New System.Windows.Forms.RadioButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPreguntas = New System.Windows.Forms.Label()
        Me.lblAciertos = New System.Windows.Forms.Label()
        Me.Bloque_TestsTableAdapter = New TestInformatico.TestInformaticaDataSetTableAdapters.Bloque_TestsTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.BloqueTestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestInformaticaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstTemas
        '
        Me.lstTemas.DataSource = Me.BloqueTestsBindingSource
        Me.lstTemas.DisplayMember = "titulo"
        Me.lstTemas.FormattingEnabled = True
        Me.lstTemas.Location = New System.Drawing.Point(12, 12)
        Me.lstTemas.Name = "lstTemas"
        Me.lstTemas.Size = New System.Drawing.Size(263, 290)
        Me.lstTemas.TabIndex = 0
        Me.lstTemas.ValueMember = "cod"
        '
        'BloqueTestsBindingSource
        '
        Me.BloqueTestsBindingSource.DataMember = "Bloque_Tests"
        Me.BloqueTestsBindingSource.DataSource = Me.TestInformaticaDataSet
        '
        'TestInformaticaDataSet
        '
        Me.TestInformaticaDataSet.DataSetName = "TestInformaticaDataSet"
        Me.TestInformaticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPregunta)
        Me.GroupBox1.Controls.Add(Me.rdbD)
        Me.GroupBox1.Controls.Add(Me.rdbC)
        Me.GroupBox1.Controls.Add(Me.rdbB)
        Me.GroupBox1.Controls.Add(Me.rdbA)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 264)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Marca la opción que consideres correcta"
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Location = New System.Drawing.Point(26, 34)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(0, 13)
        Me.lblPregunta.TabIndex = 4
        '
        'rdbD
        '
        Me.rdbD.AutoSize = True
        Me.rdbD.Location = New System.Drawing.Point(26, 200)
        Me.rdbD.Name = "rdbD"
        Me.rdbD.Size = New System.Drawing.Size(33, 17)
        Me.rdbD.TabIndex = 3
        Me.rdbD.TabStop = True
        Me.rdbD.Text = "D"
        Me.rdbD.UseVisualStyleBackColor = True
        '
        'rdbC
        '
        Me.rdbC.AutoSize = True
        Me.rdbC.Location = New System.Drawing.Point(26, 159)
        Me.rdbC.Name = "rdbC"
        Me.rdbC.Size = New System.Drawing.Size(32, 17)
        Me.rdbC.TabIndex = 2
        Me.rdbC.TabStop = True
        Me.rdbC.Text = "C"
        Me.rdbC.UseVisualStyleBackColor = True
        '
        'rdbB
        '
        Me.rdbB.AutoSize = True
        Me.rdbB.Location = New System.Drawing.Point(26, 117)
        Me.rdbB.Name = "rdbB"
        Me.rdbB.Size = New System.Drawing.Size(32, 17)
        Me.rdbB.TabIndex = 1
        Me.rdbB.TabStop = True
        Me.rdbB.Text = "B"
        Me.rdbB.UseVisualStyleBackColor = True
        '
        'rdbA
        '
        Me.rdbA.AutoSize = True
        Me.rdbA.Location = New System.Drawing.Point(26, 75)
        Me.rdbA.Name = "rdbA"
        Me.rdbA.Size = New System.Drawing.Size(32, 17)
        Me.rdbA.TabIndex = 0
        Me.rdbA.TabStop = True
        Me.rdbA.Text = "A"
        Me.rdbA.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(172, 310)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Preguntas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Aciertos:"
        '
        'lblPreguntas
        '
        Me.lblPreguntas.AutoSize = True
        Me.lblPreguntas.Location = New System.Drawing.Point(237, 309)
        Me.lblPreguntas.Name = "lblPreguntas"
        Me.lblPreguntas.Size = New System.Drawing.Size(0, 13)
        Me.lblPreguntas.TabIndex = 4
        '
        'lblAciertos
        '
        Me.lblAciertos.AutoSize = True
        Me.lblAciertos.Location = New System.Drawing.Point(327, 310)
        Me.lblAciertos.Name = "lblAciertos"
        Me.lblAciertos.Size = New System.Drawing.Size(0, 13)
        Me.lblAciertos.TabIndex = 5
        '
        'Bloque_TestsTableAdapter
        '
        Me.Bloque_TestsTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(512, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(401, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 418)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAciertos)
        Me.Controls.Add(Me.lblPreguntas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstTemas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BloqueTestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestInformaticaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstTemas As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPregunta As Label
    Friend WithEvents rdbD As RadioButton
    Friend WithEvents rdbC As RadioButton
    Friend WithEvents rdbB As RadioButton
    Friend WithEvents rdbA As RadioButton
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPreguntas As Label
    Friend WithEvents lblAciertos As Label
    Friend WithEvents TestInformaticaDataSet As TestInformaticaDataSet
    Friend WithEvents BloqueTestsBindingSource As BindingSource
    Friend WithEvents Bloque_TestsTableAdapter As TestInformaticaDataSetTableAdapters.Bloque_TestsTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
