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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkReposa = New System.Windows.Forms.CheckBox()
        Me.chkPortaEquipajes = New System.Windows.Forms.CheckBox()
        Me.chkFaros = New System.Windows.Forms.CheckBox()
        Me.chkLlantas = New System.Windows.Forms.CheckBox()
        Me.chkAsientos = New System.Windows.Forms.CheckBox()
        Me.chkGps = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstModelos = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rdbElectrico = New System.Windows.Forms.RadioButton()
        Me.rdbGasolina = New System.Windows.Forms.RadioButton()
        Me.rdbDiesel = New System.Windows.Forms.RadioButton()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.ilsCoches = New System.Windows.Forms.ImageList(Me.components)
        Me.pcbImagen = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(178, 347)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(100, 20)
        Me.txtIva.TabIndex = 0
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(178, 294)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 1
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(178, 391)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 2
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(178, 241)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descuento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "IVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palace Script MT", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(650, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 45)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Extras"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkReposa)
        Me.Panel1.Controls.Add(Me.chkPortaEquipajes)
        Me.Panel1.Controls.Add(Me.chkFaros)
        Me.Panel1.Controls.Add(Me.chkLlantas)
        Me.Panel1.Controls.Add(Me.chkAsientos)
        Me.Panel1.Controls.Add(Me.chkGps)
        Me.Panel1.Location = New System.Drawing.Point(632, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(137, 142)
        Me.Panel1.TabIndex = 9
        '
        'chkReposa
        '
        Me.chkReposa.AutoSize = True
        Me.chkReposa.Location = New System.Drawing.Point(3, 120)
        Me.chkReposa.Name = "chkReposa"
        Me.chkReposa.Size = New System.Drawing.Size(94, 17)
        Me.chkReposa.TabIndex = 5
        Me.chkReposa.Text = "Reposabrazos"
        Me.chkReposa.UseVisualStyleBackColor = True
        '
        'chkPortaEquipajes
        '
        Me.chkPortaEquipajes.AutoSize = True
        Me.chkPortaEquipajes.Location = New System.Drawing.Point(3, 97)
        Me.chkPortaEquipajes.Name = "chkPortaEquipajes"
        Me.chkPortaEquipajes.Size = New System.Drawing.Size(96, 17)
        Me.chkPortaEquipajes.TabIndex = 4
        Me.chkPortaEquipajes.Text = "Portaequipajes"
        Me.chkPortaEquipajes.UseVisualStyleBackColor = True
        '
        'chkFaros
        '
        Me.chkFaros.AutoSize = True
        Me.chkFaros.Location = New System.Drawing.Point(3, 74)
        Me.chkFaros.Name = "chkFaros"
        Me.chkFaros.Size = New System.Drawing.Size(85, 17)
        Me.chkFaros.TabIndex = 3
        Me.chkFaros.Text = "Faros full led"
        Me.chkFaros.UseVisualStyleBackColor = True
        '
        'chkLlantas
        '
        Me.chkLlantas.AutoSize = True
        Me.chkLlantas.Location = New System.Drawing.Point(3, 51)
        Me.chkLlantas.Name = "chkLlantas"
        Me.chkLlantas.Size = New System.Drawing.Size(118, 17)
        Me.chkLlantas.TabIndex = 2
        Me.chkLlantas.Text = "Llantas de aleación"
        Me.chkLlantas.UseVisualStyleBackColor = True
        '
        'chkAsientos
        '
        Me.chkAsientos.AutoSize = True
        Me.chkAsientos.Location = New System.Drawing.Point(3, 28)
        Me.chkAsientos.Name = "chkAsientos"
        Me.chkAsientos.Size = New System.Drawing.Size(114, 17)
        Me.chkAsientos.TabIndex = 1
        Me.chkAsientos.Text = "Asientos De Cuero"
        Me.chkAsientos.UseVisualStyleBackColor = True
        '
        'chkGps
        '
        Me.chkGps.AutoSize = True
        Me.chkGps.Location = New System.Drawing.Point(3, 5)
        Me.chkGps.Name = "chkGps"
        Me.chkGps.Size = New System.Drawing.Size(48, 17)
        Me.chkGps.TabIndex = 0
        Me.chkGps.Text = "GPS"
        Me.chkGps.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lstModelos
        '
        Me.lstModelos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lstModelos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstModelos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstModelos.FormattingEnabled = True
        Me.lstModelos.ItemHeight = 20
        Me.lstModelos.Items.AddRange(New Object() {"Fiesta", "Focus", "Mustang", "Kuga", "Ranger", "Ka+"})
        Me.lstModelos.Location = New System.Drawing.Point(28, 93)
        Me.lstModelos.Name = "lstModelos"
        Me.lstModelos.Size = New System.Drawing.Size(120, 122)
        Me.lstModelos.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.rdbElectrico)
        Me.Panel2.Controls.Add(Me.rdbGasolina)
        Me.Panel2.Controls.Add(Me.rdbDiesel)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Location = New System.Drawing.Point(634, 288)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(132, 77)
        Me.Panel2.TabIndex = 12
        '
        'rdbElectrico
        '
        Me.rdbElectrico.AutoSize = True
        Me.rdbElectrico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdbElectrico.Location = New System.Drawing.Point(6, 49)
        Me.rdbElectrico.Name = "rdbElectrico"
        Me.rdbElectrico.Size = New System.Drawing.Size(66, 17)
        Me.rdbElectrico.TabIndex = 15
        Me.rdbElectrico.TabStop = True
        Me.rdbElectrico.Text = "Electrico"
        Me.rdbElectrico.UseVisualStyleBackColor = True
        '
        'rdbGasolina
        '
        Me.rdbGasolina.AutoSize = True
        Me.rdbGasolina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdbGasolina.Location = New System.Drawing.Point(6, 3)
        Me.rdbGasolina.Name = "rdbGasolina"
        Me.rdbGasolina.Size = New System.Drawing.Size(66, 17)
        Me.rdbGasolina.TabIndex = 13
        Me.rdbGasolina.TabStop = True
        Me.rdbGasolina.Text = "Gasolina"
        Me.rdbGasolina.UseVisualStyleBackColor = True
        '
        'rdbDiesel
        '
        Me.rdbDiesel.AutoSize = True
        Me.rdbDiesel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdbDiesel.Location = New System.Drawing.Point(6, 26)
        Me.rdbDiesel.Name = "rdbDiesel"
        Me.rdbDiesel.Size = New System.Drawing.Size(54, 17)
        Me.rdbDiesel.TabIndex = 14
        Me.rdbDiesel.TabStop = True
        Me.rdbDiesel.Text = "Diesel"
        Me.rdbDiesel.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(178, 185)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 32)
        Me.btnCalcular.TabIndex = 13
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'ilsCoches
        '
        Me.ilsCoches.ImageStream = CType(resources.GetObject("ilsCoches.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsCoches.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsCoches.Images.SetKeyName(0, "Fiesta.png")
        Me.ilsCoches.Images.SetKeyName(1, "focus.png")
        Me.ilsCoches.Images.SetKeyName(2, "mustang.png")
        Me.ilsCoches.Images.SetKeyName(3, "kuga.png")
        Me.ilsCoches.Images.SetKeyName(4, "ranger.png")
        Me.ilsCoches.Images.SetKeyName(5, "ka+.png")
        '
        'pcbImagen
        '
        Me.pcbImagen.Location = New System.Drawing.Point(301, 83)
        Me.pcbImagen.Name = "pcbImagen"
        Me.pcbImagen.Size = New System.Drawing.Size(310, 190)
        Me.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImagen.TabIndex = 14
        Me.pcbImagen.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(632, 397)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 432)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.pcbImagen)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lstModelos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtIva)
        Me.Name = "Form1"
        Me.Text = "Concesionario Ford"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIva As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkReposa As CheckBox
    Friend WithEvents chkPortaEquipajes As CheckBox
    Friend WithEvents chkFaros As CheckBox
    Friend WithEvents chkLlantas As CheckBox
    Friend WithEvents chkAsientos As CheckBox
    Friend WithEvents chkGps As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstModelos As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rdbGasolina As RadioButton
    Friend WithEvents rdbDiesel As RadioButton
    Friend WithEvents btnCalcular As Button
    Friend WithEvents ilsCoches As ImageList
    Friend WithEvents pcbImagen As PictureBox
    Friend WithEvents rdbElectrico As RadioButton
    Friend WithEvents btnSalir As Button
End Class
