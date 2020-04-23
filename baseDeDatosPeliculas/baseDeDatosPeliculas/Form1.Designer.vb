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
        Me.lstPeliculas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValoración = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtReparto = New System.Windows.Forms.TextBox()
        Me.txtArgumento = New System.Windows.Forms.TextBox()
        Me.pcbCartel = New System.Windows.Forms.PictureBox()
        CType(Me.pcbCartel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstPeliculas
        '
        Me.lstPeliculas.FormattingEnabled = True
        Me.lstPeliculas.Location = New System.Drawing.Point(12, 12)
        Me.lstPeliculas.Name = "lstPeliculas"
        Me.lstPeliculas.Size = New System.Drawing.Size(233, 95)
        Me.lstPeliculas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Reparto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Argumento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Director"
        '
        'txtDirector
        '
        Me.txtDirector.Location = New System.Drawing.Point(347, 9)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(141, 20)
        Me.txtDirector.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Año"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Duración"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(254, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Valoración"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(254, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Género"
        '
        'txtValoración
        '
        Me.txtValoración.Location = New System.Drawing.Point(347, 117)
        Me.txtValoración.Name = "txtValoración"
        Me.txtValoración.Size = New System.Drawing.Size(27, 20)
        Me.txtValoración.TabIndex = 12
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(347, 68)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(249, 20)
        Me.txtGenero.TabIndex = 13
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(347, 161)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(41, 20)
        Me.txtDuracion.TabIndex = 14
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(347, 197)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(41, 20)
        Me.txtAño.TabIndex = 15
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(15, 409)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtReparto
        '
        Me.txtReparto.Location = New System.Drawing.Point(12, 154)
        Me.txtReparto.Multiline = True
        Me.txtReparto.Name = "txtReparto"
        Me.txtReparto.Size = New System.Drawing.Size(233, 85)
        Me.txtReparto.TabIndex = 17
        '
        'txtArgumento
        '
        Me.txtArgumento.Location = New System.Drawing.Point(12, 289)
        Me.txtArgumento.Multiline = True
        Me.txtArgumento.Name = "txtArgumento"
        Me.txtArgumento.Size = New System.Drawing.Size(233, 85)
        Me.txtArgumento.TabIndex = 18
        '
        'pcbCartel
        '
        Me.pcbCartel.Location = New System.Drawing.Point(347, 261)
        Me.pcbCartel.Name = "pcbCartel"
        Me.pcbCartel.Size = New System.Drawing.Size(115, 154)
        Me.pcbCartel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCartel.TabIndex = 19
        Me.pcbCartel.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 450)
        Me.Controls.Add(Me.pcbCartel)
        Me.Controls.Add(Me.txtArgumento)
        Me.Controls.Add(Me.txtReparto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.txtValoración)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDirector)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPeliculas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcbCartel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstPeliculas As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDirector As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtValoración As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtReparto As TextBox
    Friend WithEvents txtArgumento As TextBox
    Friend WithEvents pcbCartel As PictureBox
End Class
