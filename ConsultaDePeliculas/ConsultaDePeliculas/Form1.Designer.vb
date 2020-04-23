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
        Me.gbPeliculas = New System.Windows.Forms.GroupBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtArgumento = New System.Windows.Forms.TextBox()
        Me.txtValoracion = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtReparto = New System.Windows.Forms.TextBox()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.rdbGenero = New System.Windows.Forms.RadioButton()
        Me.rdbReparto = New System.Windows.Forms.RadioButton()
        Me.rdbDirector = New System.Windows.Forms.RadioButton()
        Me.rdbTitulo = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbPeliculas.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPeliculas
        '
        Me.gbPeliculas.Controls.Add(Me.txtDuracion)
        Me.gbPeliculas.Controls.Add(Me.Label7)
        Me.gbPeliculas.Controls.Add(Me.txtArgumento)
        Me.gbPeliculas.Controls.Add(Me.txtValoracion)
        Me.gbPeliculas.Controls.Add(Me.txtGenero)
        Me.gbPeliculas.Controls.Add(Me.txtReparto)
        Me.gbPeliculas.Controls.Add(Me.txtDirector)
        Me.gbPeliculas.Controls.Add(Me.txtTitulo)
        Me.gbPeliculas.Controls.Add(Me.Label6)
        Me.gbPeliculas.Controls.Add(Me.Label5)
        Me.gbPeliculas.Controls.Add(Me.Label4)
        Me.gbPeliculas.Controls.Add(Me.Label3)
        Me.gbPeliculas.Controls.Add(Me.Label2)
        Me.gbPeliculas.Controls.Add(Me.Label1)
        Me.gbPeliculas.Location = New System.Drawing.Point(66, 12)
        Me.gbPeliculas.Name = "gbPeliculas"
        Me.gbPeliculas.Size = New System.Drawing.Size(421, 241)
        Me.gbPeliculas.TabIndex = 0
        Me.gbPeliculas.TabStop = False
        Me.gbPeliculas.Text = "Películas"
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(258, 132)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(41, 20)
        Me.txtDuracion.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(193, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Duración"
        '
        'txtArgumento
        '
        Me.txtArgumento.Location = New System.Drawing.Point(115, 155)
        Me.txtArgumento.Multiline = True
        Me.txtArgumento.Name = "txtArgumento"
        Me.txtArgumento.Size = New System.Drawing.Size(300, 80)
        Me.txtArgumento.TabIndex = 11
        '
        'txtValoracion
        '
        Me.txtValoracion.Location = New System.Drawing.Point(115, 132)
        Me.txtValoracion.Name = "txtValoracion"
        Me.txtValoracion.Size = New System.Drawing.Size(41, 20)
        Me.txtValoracion.TabIndex = 10
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(115, 108)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(244, 20)
        Me.txtGenero.TabIndex = 9
        '
        'txtReparto
        '
        Me.txtReparto.Location = New System.Drawing.Point(115, 82)
        Me.txtReparto.Name = "txtReparto"
        Me.txtReparto.Size = New System.Drawing.Size(244, 20)
        Me.txtReparto.TabIndex = 8
        '
        'txtDirector
        '
        Me.txtDirector.Location = New System.Drawing.Point(115, 56)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(244, 20)
        Me.txtDirector.TabIndex = 7
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(115, 30)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(244, 20)
        Me.txtTitulo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Argumento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Valoracion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Genero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Reparto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Director"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titulo"
        '
        'gbFiltro
        '
        Me.gbFiltro.Controls.Add(Me.btnSiguiente)
        Me.gbFiltro.Controls.Add(Me.btnBuscar)
        Me.gbFiltro.Controls.Add(Me.txtFiltro)
        Me.gbFiltro.Controls.Add(Me.rdbGenero)
        Me.gbFiltro.Controls.Add(Me.rdbReparto)
        Me.gbFiltro.Controls.Add(Me.rdbDirector)
        Me.gbFiltro.Controls.Add(Me.rdbTitulo)
        Me.gbFiltro.Location = New System.Drawing.Point(66, 272)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(421, 175)
        Me.gbFiltro.TabIndex = 1
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(316, 79)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 11
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(214, 79)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(196, 32)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(176, 20)
        Me.txtFiltro.TabIndex = 9
        '
        'rdbGenero
        '
        Me.rdbGenero.AutoSize = True
        Me.rdbGenero.Location = New System.Drawing.Point(115, 79)
        Me.rdbGenero.Name = "rdbGenero"
        Me.rdbGenero.Size = New System.Drawing.Size(60, 17)
        Me.rdbGenero.TabIndex = 3
        Me.rdbGenero.TabStop = True
        Me.rdbGenero.Text = "Genero"
        Me.rdbGenero.UseVisualStyleBackColor = True
        '
        'rdbReparto
        '
        Me.rdbReparto.AutoSize = True
        Me.rdbReparto.Location = New System.Drawing.Point(16, 79)
        Me.rdbReparto.Name = "rdbReparto"
        Me.rdbReparto.Size = New System.Drawing.Size(63, 17)
        Me.rdbReparto.TabIndex = 2
        Me.rdbReparto.TabStop = True
        Me.rdbReparto.Text = "Reparto"
        Me.rdbReparto.UseVisualStyleBackColor = True
        '
        'rdbDirector
        '
        Me.rdbDirector.AutoSize = True
        Me.rdbDirector.Location = New System.Drawing.Point(115, 35)
        Me.rdbDirector.Name = "rdbDirector"
        Me.rdbDirector.Size = New System.Drawing.Size(62, 17)
        Me.rdbDirector.TabIndex = 1
        Me.rdbDirector.TabStop = True
        Me.rdbDirector.Text = "Director"
        Me.rdbDirector.UseVisualStyleBackColor = True
        '
        'rdbTitulo
        '
        Me.rdbTitulo.AutoSize = True
        Me.rdbTitulo.Location = New System.Drawing.Point(16, 35)
        Me.rdbTitulo.Name = "rdbTitulo"
        Me.rdbTitulo.Size = New System.Drawing.Size(51, 17)
        Me.rdbTitulo.TabIndex = 0
        Me.rdbTitulo.TabStop = True
        Me.rdbTitulo.Text = "Titulo"
        Me.rdbTitulo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(527, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Label8"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.gbFiltro)
        Me.Controls.Add(Me.gbPeliculas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbPeliculas.ResumeLayout(False)
        Me.gbPeliculas.PerformLayout()
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbPeliculas As GroupBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtArgumento As TextBox
    Friend WithEvents txtValoracion As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtReparto As TextBox
    Friend WithEvents txtDirector As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbFiltro As GroupBox
    Friend WithEvents rdbGenero As RadioButton
    Friend WithEvents rdbReparto As RadioButton
    Friend WithEvents rdbDirector As RadioButton
    Friend WithEvents rdbTitulo As RadioButton
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label8 As Label
End Class
