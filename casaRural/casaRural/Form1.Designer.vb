<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bntDer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bntDer))
        Me.dtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpSalida = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkServicio = New System.Windows.Forms.CheckBox()
        Me.chkPack = New System.Windows.Forms.CheckBox()
        Me.chkTraslado = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pcbCentral = New System.Windows.Forms.PictureBox()
        Me.pcb1 = New System.Windows.Forms.PictureBox()
        Me.pcb3 = New System.Windows.Forms.PictureBox()
        Me.pcb2 = New System.Windows.Forms.PictureBox()
        Me.pcb4 = New System.Windows.Forms.PictureBox()
        Me.imlImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDer = New System.Windows.Forms.Button()
        Me.btnIzq = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbCentral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpEntrada
        '
        Me.dtpEntrada.Location = New System.Drawing.Point(34, 23)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.Size = New System.Drawing.Size(200, 20)
        Me.dtpEntrada.TabIndex = 0
        Me.dtpEntrada.Value = New Date(2019, 10, 31, 0, 0, 0, 0)
        '
        'dtpSalida
        '
        Me.dtpSalida.Location = New System.Drawing.Point(280, 23)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.Size = New System.Drawing.Size(200, 20)
        Me.dtpSalida.TabIndex = 1
        Me.dtpSalida.Value = New Date(2019, 10, 31, 0, 0, 0, 0)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(113, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(285, 57)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 4
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkServicio)
        Me.Panel1.Controls.Add(Me.chkPack)
        Me.Panel1.Controls.Add(Me.chkTraslado)
        Me.Panel1.Location = New System.Drawing.Point(285, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 6
        '
        'chkServicio
        '
        Me.chkServicio.AutoSize = True
        Me.chkServicio.Location = New System.Drawing.Point(24, 65)
        Me.chkServicio.Name = "chkServicio"
        Me.chkServicio.Size = New System.Drawing.Size(148, 17)
        Me.chkServicio.TabIndex = 2
        Me.chkServicio.Text = "Servicio Guardería (x día)"
        Me.chkServicio.UseVisualStyleBackColor = True
        '
        'chkPack
        '
        Me.chkPack.AutoSize = True
        Me.chkPack.Location = New System.Drawing.Point(24, 38)
        Me.chkPack.Name = "chkPack"
        Me.chkPack.Size = New System.Drawing.Size(126, 17)
        Me.chkPack.TabIndex = 1
        Me.chkPack.Text = "Pack Visitas Guiadas"
        Me.chkPack.UseVisualStyleBackColor = True
        '
        'chkTraslado
        '
        Me.chkTraslado.AutoSize = True
        Me.chkTraslado.Location = New System.Drawing.Point(24, 15)
        Me.chkTraslado.Name = "chkTraslado"
        Me.chkTraslado.Size = New System.Drawing.Size(132, 17)
        Me.chkTraslado.TabIndex = 0
        Me.chkTraslado.Text = "Traslado al aeropuerto"
        Me.chkTraslado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Extras"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Importe de estancia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Importe de extras"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(377, 236)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(377, 288)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(377, 262)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(484, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "euros"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(484, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "euros"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(484, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "euros"
        '
        'pcbCentral
        '
        Me.pcbCentral.Location = New System.Drawing.Point(41, 114)
        Me.pcbCentral.Name = "pcbCentral"
        Me.pcbCentral.Size = New System.Drawing.Size(206, 204)
        Me.pcbCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCentral.TabIndex = 17
        Me.pcbCentral.TabStop = False
        '
        'pcb1
        '
        Me.pcb1.Location = New System.Drawing.Point(36, 360)
        Me.pcb1.Name = "pcb1"
        Me.pcb1.Size = New System.Drawing.Size(100, 78)
        Me.pcb1.TabIndex = 18
        Me.pcb1.TabStop = False
        '
        'pcb3
        '
        Me.pcb3.Location = New System.Drawing.Point(280, 360)
        Me.pcb3.Name = "pcb3"
        Me.pcb3.Size = New System.Drawing.Size(100, 78)
        Me.pcb3.TabIndex = 19
        Me.pcb3.TabStop = False
        '
        'pcb2
        '
        Me.pcb2.Location = New System.Drawing.Point(163, 360)
        Me.pcb2.Name = "pcb2"
        Me.pcb2.Size = New System.Drawing.Size(100, 78)
        Me.pcb2.TabIndex = 20
        Me.pcb2.TabStop = False
        '
        'pcb4
        '
        Me.pcb4.Location = New System.Drawing.Point(412, 360)
        Me.pcb4.Name = "pcb4"
        Me.pcb4.Size = New System.Drawing.Size(100, 78)
        Me.pcb4.TabIndex = 21
        Me.pcb4.TabStop = False
        '
        'imlImagenes
        '
        Me.imlImagenes.ImageStream = CType(resources.GetObject("imlImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imlImagenes.Images.SetKeyName(0, "1.jpg")
        Me.imlImagenes.Images.SetKeyName(1, "2.jpg")
        Me.imlImagenes.Images.SetKeyName(2, "3.jpg")
        Me.imlImagenes.Images.SetKeyName(3, "4.jpg")
        Me.imlImagenes.Images.SetKeyName(4, "5.jpg")
        Me.imlImagenes.Images.SetKeyName(5, "6.jpg")
        Me.imlImagenes.Images.SetKeyName(6, "7.jpg")
        Me.imlImagenes.Images.SetKeyName(7, "8.jpg")
        Me.imlImagenes.Images.SetKeyName(8, "9.jpg")
        Me.imlImagenes.Images.SetKeyName(9, "10.jpg")
        Me.imlImagenes.Images.SetKeyName(10, "11.jpg")
        '
        'btnDer
        '
        Me.btnDer.Location = New System.Drawing.Point(516, 360)
        Me.btnDer.Name = "btnDer"
        Me.btnDer.Size = New System.Drawing.Size(28, 78)
        Me.btnDer.TabIndex = 22
        Me.btnDer.Text = ">"
        Me.btnDer.UseVisualStyleBackColor = True
        '
        'btnIzq
        '
        Me.btnIzq.Location = New System.Drawing.Point(2, 360)
        Me.btnIzq.Name = "btnIzq"
        Me.btnIzq.Size = New System.Drawing.Size(28, 78)
        Me.btnIzq.TabIndex = 23
        Me.btnIzq.Text = "<"
        Me.btnIzq.UseVisualStyleBackColor = True
        '
        'bntDer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 450)
        Me.Controls.Add(Me.btnIzq)
        Me.Controls.Add(Me.btnDer)
        Me.Controls.Add(Me.pcb4)
        Me.Controls.Add(Me.pcb2)
        Me.Controls.Add(Me.pcb3)
        Me.Controls.Add(Me.pcb1)
        Me.Controls.Add(Me.pcbCentral)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dtpSalida)
        Me.Controls.Add(Me.dtpEntrada)
        Me.Name = "bntDer"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pcbCentral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpEntrada As DateTimePicker
    Friend WithEvents dtpSalida As DateTimePicker
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkServicio As CheckBox
    Friend WithEvents chkPack As CheckBox
    Friend WithEvents chkTraslado As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pcbCentral As PictureBox
    Friend WithEvents pcb1 As PictureBox
    Friend WithEvents pcb3 As PictureBox
    Friend WithEvents pcb2 As PictureBox
    Friend WithEvents pcb4 As PictureBox
    Friend WithEvents imlImagenes As ImageList
    Friend WithEvents btnDer As Button
    Friend WithEvents btnIzq As Button
End Class
