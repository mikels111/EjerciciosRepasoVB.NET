<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txartela
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
        Me.rdbIndividual = New System.Windows.Forms.RadioButton()
        Me.rdbFamiliar = New System.Windows.Forms.RadioButton()
        Me.rdbJubilado = New System.Windows.Forms.RadioButton()
        Me.rdbInfantil = New System.Windows.Forms.RadioButton()
        Me.chkFamiliaNumerosa = New System.Windows.Forms.CheckBox()
        Me.chkDiscapacitados = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbIndividual
        '
        Me.rdbIndividual.AutoSize = True
        Me.rdbIndividual.Location = New System.Drawing.Point(22, 19)
        Me.rdbIndividual.Name = "rdbIndividual"
        Me.rdbIndividual.Size = New System.Drawing.Size(70, 17)
        Me.rdbIndividual.TabIndex = 0
        Me.rdbIndividual.TabStop = True
        Me.rdbIndividual.Text = "Individual"
        Me.rdbIndividual.UseVisualStyleBackColor = True
        '
        'rdbFamiliar
        '
        Me.rdbFamiliar.AutoSize = True
        Me.rdbFamiliar.Location = New System.Drawing.Point(22, 57)
        Me.rdbFamiliar.Name = "rdbFamiliar"
        Me.rdbFamiliar.Size = New System.Drawing.Size(60, 17)
        Me.rdbFamiliar.TabIndex = 1
        Me.rdbFamiliar.TabStop = True
        Me.rdbFamiliar.Text = "Familiar"
        Me.rdbFamiliar.UseVisualStyleBackColor = True
        '
        'rdbJubilado
        '
        Me.rdbJubilado.AutoSize = True
        Me.rdbJubilado.Location = New System.Drawing.Point(22, 95)
        Me.rdbJubilado.Name = "rdbJubilado"
        Me.rdbJubilado.Size = New System.Drawing.Size(69, 17)
        Me.rdbJubilado.TabIndex = 2
        Me.rdbJubilado.TabStop = True
        Me.rdbJubilado.Text = "Jubilados"
        Me.rdbJubilado.UseVisualStyleBackColor = True
        '
        'rdbInfantil
        '
        Me.rdbInfantil.AutoSize = True
        Me.rdbInfantil.Location = New System.Drawing.Point(22, 139)
        Me.rdbInfantil.Name = "rdbInfantil"
        Me.rdbInfantil.Size = New System.Drawing.Size(56, 17)
        Me.rdbInfantil.TabIndex = 3
        Me.rdbInfantil.TabStop = True
        Me.rdbInfantil.Text = "Infantil"
        Me.rdbInfantil.UseVisualStyleBackColor = True
        '
        'chkFamiliaNumerosa
        '
        Me.chkFamiliaNumerosa.AutoSize = True
        Me.chkFamiliaNumerosa.Location = New System.Drawing.Point(16, 16)
        Me.chkFamiliaNumerosa.Name = "chkFamiliaNumerosa"
        Me.chkFamiliaNumerosa.Size = New System.Drawing.Size(107, 17)
        Me.chkFamiliaNumerosa.TabIndex = 6
        Me.chkFamiliaNumerosa.Text = "Familia numerosa"
        Me.chkFamiliaNumerosa.UseVisualStyleBackColor = True
        '
        'chkDiscapacitados
        '
        Me.chkDiscapacitados.AutoSize = True
        Me.chkDiscapacitados.Location = New System.Drawing.Point(16, 66)
        Me.chkDiscapacitados.Name = "chkDiscapacitados"
        Me.chkDiscapacitados.Size = New System.Drawing.Size(99, 17)
        Me.chkDiscapacitados.TabIndex = 7
        Me.chkDiscapacitados.Text = "Discapacitados"
        Me.chkDiscapacitados.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdbJubilado)
        Me.Panel1.Controls.Add(Me.rdbIndividual)
        Me.Panel1.Controls.Add(Me.rdbFamiliar)
        Me.Panel1.Controls.Add(Me.rdbInfantil)
        Me.Panel1.Location = New System.Drawing.Point(35, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 178)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkFamiliaNumerosa)
        Me.Panel2.Controls.Add(Me.chkDiscapacitados)
        Me.Panel2.Location = New System.Drawing.Point(35, 250)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 100)
        Me.Panel2.TabIndex = 9
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(50, 388)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 10
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(253, 388)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txartela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 450)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "txartela"
        Me.Text = "Piscinas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdbIndividual As RadioButton
    Friend WithEvents rdbFamiliar As RadioButton
    Friend WithEvents rdbJubilado As RadioButton
    Friend WithEvents rdbInfantil As RadioButton
    Friend WithEvents chkFamiliaNumerosa As CheckBox
    Friend WithEvents chkDiscapacitados As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents btnCalcular As Button
End Class
