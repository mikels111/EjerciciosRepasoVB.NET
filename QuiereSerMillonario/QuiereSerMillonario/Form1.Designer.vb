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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLlamada = New System.Windows.Forms.ToolStripButton()
        Me.tsbPublico = New System.Windows.Forms.ToolStripButton()
        Me.tsbPlantarse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tslRecord = New System.Windows.Forms.ToolStripLabel()
        Me.txbPregunta = New System.Windows.Forms.TextBox()
        Me.lstPreguntas = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.lblC = New System.Windows.Forms.Label()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.MillonarioDataSet = New QuiereSerMillonario.millonarioDataSet()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MillonarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.tsbLlamada, Me.tsbPublico, Me.tsbPlantarse, Me.ToolStripSeparator2, Me.tsbNuevo, Me.tsbSalir, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.tslRecord})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(417, 38)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(34, 35)
        Me.ToolStripLabel1.Text = "50:50"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'tsbLlamada
        '
        Me.tsbLlamada.Image = CType(resources.GetObject("tsbLlamada.Image"), System.Drawing.Image)
        Me.tsbLlamada.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLlamada.Name = "tsbLlamada"
        Me.tsbLlamada.Size = New System.Drawing.Size(56, 35)
        Me.tsbLlamada.Text = "Llamada"
        Me.tsbLlamada.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.tsbLlamada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbPublico
        '
        Me.tsbPublico.Image = CType(resources.GetObject("tsbPublico.Image"), System.Drawing.Image)
        Me.tsbPublico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPublico.Name = "tsbPublico"
        Me.tsbPublico.Size = New System.Drawing.Size(51, 35)
        Me.tsbPublico.Text = "Público"
        Me.tsbPublico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbPlantarse
        '
        Me.tsbPlantarse.Image = CType(resources.GetObject("tsbPlantarse.Image"), System.Drawing.Image)
        Me.tsbPlantarse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPlantarse.Name = "tsbPlantarse"
        Me.tsbPlantarse.Size = New System.Drawing.Size(59, 35)
        Me.tsbPlantarse.Text = "Plantarse"
        Me.tsbPlantarse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(46, 35)
        Me.tsbNuevo.Text = "Nuevo"
        Me.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(33, 35)
        Me.tsbSalir.Text = "Salir"
        Me.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(47, 35)
        Me.ToolStripLabel2.Text = "Record:"
        '
        'tslRecord
        '
        Me.tslRecord.Name = "tslRecord"
        Me.tslRecord.Size = New System.Drawing.Size(56, 35)
        Me.tslRecord.Text = "tslRecord"
        '
        'txbPregunta
        '
        Me.txbPregunta.Location = New System.Drawing.Point(12, 50)
        Me.txbPregunta.Multiline = True
        Me.txbPregunta.Name = "txbPregunta"
        Me.txbPregunta.Size = New System.Drawing.Size(264, 71)
        Me.txbPregunta.TabIndex = 1
        '
        'lstPreguntas
        '
        Me.lstPreguntas.FormattingEnabled = True
        Me.lstPreguntas.Items.AddRange(New Object() {"15" & Global.Microsoft.VisualBasic.ChrW(9) & "15000", "14" & Global.Microsoft.VisualBasic.ChrW(9) & "80000", "13" & Global.Microsoft.VisualBasic.ChrW(9) & "40000", "12" & Global.Microsoft.VisualBasic.ChrW(9) & "20000", "11" & Global.Microsoft.VisualBasic.ChrW(9) & "1000", "10" & Global.Microsoft.VisualBasic.ChrW(9) & "5000", "9" & Global.Microsoft.VisualBasic.ChrW(9) & "4000", "8" & Global.Microsoft.VisualBasic.ChrW(9) & "2000", "7" & Global.Microsoft.VisualBasic.ChrW(9) & "1500", "6" & Global.Microsoft.VisualBasic.ChrW(9) & "1000", "5" & Global.Microsoft.VisualBasic.ChrW(9) & "500", "4" & Global.Microsoft.VisualBasic.ChrW(9) & "400", "3" & Global.Microsoft.VisualBasic.ChrW(9) & "300", "2" & Global.Microsoft.VisualBasic.ChrW(9) & "200", "1" & Global.Microsoft.VisualBasic.ChrW(9) & "100"})
        Me.lstPreguntas.Location = New System.Drawing.Point(308, 50)
        Me.lstPreguntas.Name = "lstPreguntas"
        Me.lstPreguntas.Size = New System.Drawing.Size(94, 199)
        Me.lstPreguntas.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblD)
        Me.GroupBox1.Controls.Add(Me.btnA)
        Me.GroupBox1.Controls.Add(Me.btnC)
        Me.GroupBox1.Controls.Add(Me.lblC)
        Me.GroupBox1.Controls.Add(Me.btnB)
        Me.GroupBox1.Controls.Add(Me.btnD)
        Me.GroupBox1.Controls.Add(Me.lblB)
        Me.GroupBox1.Controls.Add(Me.lblA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 176)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elige una respuesta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Location = New System.Drawing.Point(66, 148)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(39, 13)
        Me.lblD.TabIndex = 7
        Me.lblD.Text = "Label4"
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(32, 19)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(28, 23)
        Me.btnA.TabIndex = 0
        Me.btnA.Tag = "1"
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(32, 103)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(28, 23)
        Me.btnC.TabIndex = 2
        Me.btnC.Tag = "3"
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(66, 108)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(39, 13)
        Me.lblC.TabIndex = 6
        Me.lblC.Text = "Label3"
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(32, 62)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(28, 23)
        Me.btnB.TabIndex = 1
        Me.btnB.Tag = "2"
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(32, 143)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(28, 23)
        Me.btnD.TabIndex = 3
        Me.btnD.Tag = "4"
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(66, 67)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(39, 13)
        Me.lblB.TabIndex = 5
        Me.lblB.Text = "Label2"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(66, 24)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(39, 13)
        Me.lblA.TabIndex = 4
        Me.lblA.Text = "Label1"
        '
        'MillonarioDataSet
        '
        Me.MillonarioDataSet.DataSetName = "millonarioDataSet"
        Me.MillonarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 316)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstPreguntas)
        Me.Controls.Add(Me.txbPregunta)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Quien quiere ser millonario"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MillonarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbLlamada As ToolStripButton
    Friend WithEvents tsbPublico As ToolStripButton
    Friend WithEvents tsbPlantarse As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents tslRecord As ToolStripLabel
    Friend WithEvents txbPregunta As TextBox
    Friend WithEvents lstPreguntas As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnD As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnA As Button
    Friend WithEvents lblD As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblA As Label
    Friend WithEvents MillonarioDataSet As millonarioDataSet
    Friend WithEvents Label1 As Label
End Class
