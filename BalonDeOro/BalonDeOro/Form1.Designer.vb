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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.VotantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BalonDeOro2014DataSet = New BalonDeOro.BalonDeOro2014DataSet()
        Me.cmbPuesto = New System.Windows.Forms.ComboBox()
        Me.cmbJugador1 = New System.Windows.Forms.ComboBox()
        Me.JugadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbJugador2 = New System.Windows.Forms.ComboBox()
        Me.JugadoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbJugador3 = New System.Windows.Forms.ComboBox()
        Me.JugadoresBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VotantesTableAdapter = New BalonDeOro.BalonDeOro2014DataSetTableAdapters.VotantesTableAdapter()
        Me.VotantesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JugadoresTableAdapter = New BalonDeOro.BalonDeOro2014DataSetTableAdapters.JugadoresTableAdapter()
        Me.BalonDeOro2014DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JugadoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VotantesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnVotar = New System.Windows.Forms.Button()
        Me.VotantesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.VotantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalonDeOro2014DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadoresBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotantesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalonDeOro2014DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotantesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotantesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "País"
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Puesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "1er Jugador"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "2do Jugador"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "3er Jugador"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(133, 124)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 20)
        Me.txtNombre.TabIndex = 8
        '
        'cmbPais
        '
        Me.cmbPais.DataSource = Me.VotantesBindingSource
        Me.cmbPais.DisplayMember = "Pais"
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(133, 33)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(121, 21)
        Me.cmbPais.TabIndex = 9
        Me.cmbPais.ValueMember = "Id"
        '
        'VotantesBindingSource
        '
        Me.VotantesBindingSource.DataMember = "Votantes"
        Me.VotantesBindingSource.DataSource = Me.BalonDeOro2014DataSet
        '
        'BalonDeOro2014DataSet
        '
        Me.BalonDeOro2014DataSet.DataSetName = "BalonDeOro2014DataSet"
        Me.BalonDeOro2014DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbPuesto
        '
        Me.cmbPuesto.FormattingEnabled = True
        Me.cmbPuesto.Location = New System.Drawing.Point(133, 77)
        Me.cmbPuesto.Name = "cmbPuesto"
        Me.cmbPuesto.Size = New System.Drawing.Size(121, 21)
        Me.cmbPuesto.TabIndex = 10
        '
        'cmbJugador1
        '
        Me.cmbJugador1.DataSource = Me.JugadoresBindingSource
        Me.cmbJugador1.DisplayMember = "Apellido"
        Me.cmbJugador1.FormattingEnabled = True
        Me.cmbJugador1.Location = New System.Drawing.Point(133, 175)
        Me.cmbJugador1.Name = "cmbJugador1"
        Me.cmbJugador1.Size = New System.Drawing.Size(121, 21)
        Me.cmbJugador1.TabIndex = 11
        Me.cmbJugador1.ValueMember = "Id"
        '
        'JugadoresBindingSource
        '
        Me.JugadoresBindingSource.DataMember = "Jugadores"
        Me.JugadoresBindingSource.DataSource = Me.BalonDeOro2014DataSet
        '
        'cmbJugador2
        '
        Me.cmbJugador2.DataSource = Me.JugadoresBindingSource1
        Me.cmbJugador2.DisplayMember = "Apellido"
        Me.cmbJugador2.FormattingEnabled = True
        Me.cmbJugador2.Location = New System.Drawing.Point(133, 220)
        Me.cmbJugador2.Name = "cmbJugador2"
        Me.cmbJugador2.Size = New System.Drawing.Size(121, 21)
        Me.cmbJugador2.TabIndex = 12
        Me.cmbJugador2.ValueMember = "Id"
        '
        'JugadoresBindingSource1
        '
        Me.JugadoresBindingSource1.DataMember = "Jugadores"
        Me.JugadoresBindingSource1.DataSource = Me.BalonDeOro2014DataSet
        '
        'cmbJugador3
        '
        Me.cmbJugador3.DataSource = Me.JugadoresBindingSource3
        Me.cmbJugador3.DisplayMember = "Apellido"
        Me.cmbJugador3.FormattingEnabled = True
        Me.cmbJugador3.Location = New System.Drawing.Point(133, 275)
        Me.cmbJugador3.Name = "cmbJugador3"
        Me.cmbJugador3.Size = New System.Drawing.Size(121, 21)
        Me.cmbJugador3.TabIndex = 13
        Me.cmbJugador3.ValueMember = "Id"
        '
        'JugadoresBindingSource3
        '
        Me.JugadoresBindingSource3.DataMember = "Jugadores"
        Me.JugadoresBindingSource3.DataSource = Me.BalonDeOro2014DataSet
        '
        'VotantesTableAdapter
        '
        Me.VotantesTableAdapter.ClearBeforeFill = True
        '
        'VotantesBindingSource1
        '
        Me.VotantesBindingSource1.DataMember = "Votantes"
        Me.VotantesBindingSource1.DataSource = Me.BalonDeOro2014DataSet
        '
        'JugadoresTableAdapter
        '
        Me.JugadoresTableAdapter.ClearBeforeFill = True
        '
        'BalonDeOro2014DataSetBindingSource
        '
        Me.BalonDeOro2014DataSetBindingSource.DataSource = Me.BalonDeOro2014DataSet
        Me.BalonDeOro2014DataSetBindingSource.Position = 0
        '
        'JugadoresBindingSource2
        '
        Me.JugadoresBindingSource2.DataMember = "Jugadores"
        Me.JugadoresBindingSource2.DataSource = Me.BalonDeOro2014DataSetBindingSource
        '
        'VotantesBindingSource2
        '
        Me.VotantesBindingSource2.DataMember = "Votantes"
        Me.VotantesBindingSource2.DataSource = Me.BalonDeOro2014DataSet
        '
        'btnVotar
        '
        Me.btnVotar.Location = New System.Drawing.Point(56, 337)
        Me.btnVotar.Name = "btnVotar"
        Me.btnVotar.Size = New System.Drawing.Size(75, 23)
        Me.btnVotar.TabIndex = 14
        Me.btnVotar.Text = "Votar"
        Me.btnVotar.UseVisualStyleBackColor = True
        '
        'VotantesBindingSource3
        '
        Me.VotantesBindingSource3.DataMember = "Votantes"
        Me.VotantesBindingSource3.DataSource = Me.BalonDeOro2014DataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 450)
        Me.Controls.Add(Me.btnVotar)
        Me.Controls.Add(Me.cmbJugador3)
        Me.Controls.Add(Me.cmbJugador2)
        Me.Controls.Add(Me.cmbJugador1)
        Me.Controls.Add(Me.cmbPuesto)
        Me.Controls.Add(Me.cmbPais)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.VotantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalonDeOro2014DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadoresBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotantesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalonDeOro2014DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotantesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotantesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents cmbPuesto As ComboBox
    Friend WithEvents cmbJugador1 As ComboBox
    Friend WithEvents cmbJugador2 As ComboBox
    Friend WithEvents cmbJugador3 As ComboBox
    Friend WithEvents BalonDeOro2014DataSet As BalonDeOro2014DataSet
    Friend WithEvents VotantesBindingSource As BindingSource
    Friend WithEvents VotantesTableAdapter As BalonDeOro2014DataSetTableAdapters.VotantesTableAdapter
    Friend WithEvents VotantesBindingSource1 As BindingSource
    Friend WithEvents JugadoresBindingSource As BindingSource
    Friend WithEvents JugadoresTableAdapter As BalonDeOro2014DataSetTableAdapters.JugadoresTableAdapter
    Friend WithEvents JugadoresBindingSource1 As BindingSource
    Friend WithEvents JugadoresBindingSource3 As BindingSource
    Friend WithEvents BalonDeOro2014DataSetBindingSource As BindingSource
    Friend WithEvents JugadoresBindingSource2 As BindingSource
    Friend WithEvents VotantesBindingSource2 As BindingSource
    Friend WithEvents btnVotar As Button
    Friend WithEvents VotantesBindingSource3 As BindingSource
End Class
