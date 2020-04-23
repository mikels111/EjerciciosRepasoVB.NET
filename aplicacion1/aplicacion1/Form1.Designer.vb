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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblmA = New System.Windows.Forms.Label()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.lblEf = New System.Windows.Forms.Label()
        Me.txtmA = New System.Windows.Forms.TextBox()
        Me.pcbImagen = New System.Windows.Forms.PictureBox()
        Me.txtEfecto = New System.Windows.Forms.TextBox()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.pcbElectrizacion = New System.Windows.Forms.PictureBox()
        Me.pcbParo = New System.Windows.Forms.PictureBox()
        Me.pcbTetanizacion = New System.Windows.Forms.PictureBox()
        Me.pcbAsfixia = New System.Windows.Forms.PictureBox()
        Me.pcbPercepcion = New System.Windows.Forms.PictureBox()
        Me.pcbFibrilacion = New System.Windows.Forms.PictureBox()
        Me.pcbNinguno = New System.Windows.Forms.PictureBox()
        Me.pcbMuerte = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbElectrizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbParo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTetanizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbAsfixia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPercepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFibrilacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbNinguno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbMuerte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmA
        '
        Me.lblmA.AutoSize = True
        Me.lblmA.Location = New System.Drawing.Point(186, 64)
        Me.lblmA.Name = "lblmA"
        Me.lblmA.Size = New System.Drawing.Size(22, 13)
        Me.lblmA.TabIndex = 0
        Me.lblmA.Text = "mA"
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.Location = New System.Drawing.Point(186, 154)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(39, 13)
        Me.lblMotivo.TabIndex = 1
        Me.lblMotivo.Text = "Motivo"
        '
        'lblEf
        '
        Me.lblEf.AutoSize = True
        Me.lblEf.Location = New System.Drawing.Point(186, 110)
        Me.lblEf.Name = "lblEf"
        Me.lblEf.Size = New System.Drawing.Size(38, 13)
        Me.lblEf.TabIndex = 4
        Me.lblEf.Text = "Efecto"
        '
        'txtmA
        '
        Me.txtmA.Location = New System.Drawing.Point(276, 57)
        Me.txtmA.Name = "txtmA"
        Me.txtmA.Size = New System.Drawing.Size(100, 20)
        Me.txtmA.TabIndex = 5
        '
        'pcbImagen
        '
        Me.pcbImagen.Location = New System.Drawing.Point(427, 110)
        Me.pcbImagen.Name = "pcbImagen"
        Me.pcbImagen.Size = New System.Drawing.Size(154, 78)
        Me.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImagen.TabIndex = 6
        Me.pcbImagen.TabStop = False
        '
        'txtEfecto
        '
        Me.txtEfecto.Location = New System.Drawing.Point(276, 110)
        Me.txtEfecto.Name = "txtEfecto"
        Me.txtEfecto.ReadOnly = True
        Me.txtEfecto.Size = New System.Drawing.Size(100, 20)
        Me.txtEfecto.TabIndex = 7
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(243, 151)
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.ReadOnly = True
        Me.txtMotivo.Size = New System.Drawing.Size(165, 20)
        Me.txtMotivo.TabIndex = 8
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(427, 59)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicar.TabIndex = 9
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'btnVaciar
        '
        Me.btnVaciar.Location = New System.Drawing.Point(524, 59)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(75, 23)
        Me.btnVaciar.TabIndex = 10
        Me.btnVaciar.Text = "Vaciar"
        Me.btnVaciar.UseVisualStyleBackColor = True
        '
        'pcbElectrizacion
        '
        Me.pcbElectrizacion.Image = CType(resources.GetObject("pcbElectrizacion.Image"), System.Drawing.Image)
        Me.pcbElectrizacion.Location = New System.Drawing.Point(222, 210)
        Me.pcbElectrizacion.Name = "pcbElectrizacion"
        Me.pcbElectrizacion.Size = New System.Drawing.Size(154, 78)
        Me.pcbElectrizacion.TabIndex = 11
        Me.pcbElectrizacion.TabStop = False
        Me.pcbElectrizacion.Visible = False
        '
        'pcbParo
        '
        Me.pcbParo.Image = CType(resources.GetObject("pcbParo.Image"), System.Drawing.Image)
        Me.pcbParo.Location = New System.Drawing.Point(71, 325)
        Me.pcbParo.Name = "pcbParo"
        Me.pcbParo.Size = New System.Drawing.Size(154, 78)
        Me.pcbParo.TabIndex = 12
        Me.pcbParo.TabStop = False
        Me.pcbParo.Visible = False
        '
        'pcbTetanizacion
        '
        Me.pcbTetanizacion.Image = CType(resources.GetObject("pcbTetanizacion.Image"), System.Drawing.Image)
        Me.pcbTetanizacion.Location = New System.Drawing.Point(445, 210)
        Me.pcbTetanizacion.Name = "pcbTetanizacion"
        Me.pcbTetanizacion.Size = New System.Drawing.Size(154, 78)
        Me.pcbTetanizacion.TabIndex = 13
        Me.pcbTetanizacion.TabStop = False
        Me.pcbTetanizacion.Visible = False
        '
        'pcbAsfixia
        '
        Me.pcbAsfixia.Image = CType(resources.GetObject("pcbAsfixia.Image"), System.Drawing.Image)
        Me.pcbAsfixia.Location = New System.Drawing.Point(243, 325)
        Me.pcbAsfixia.Name = "pcbAsfixia"
        Me.pcbAsfixia.Size = New System.Drawing.Size(154, 78)
        Me.pcbAsfixia.TabIndex = 14
        Me.pcbAsfixia.TabStop = False
        Me.pcbAsfixia.Visible = False
        '
        'pcbPercepcion
        '
        Me.pcbPercepcion.Image = CType(resources.GetObject("pcbPercepcion.Image"), System.Drawing.Image)
        Me.pcbPercepcion.Location = New System.Drawing.Point(12, 210)
        Me.pcbPercepcion.Name = "pcbPercepcion"
        Me.pcbPercepcion.Size = New System.Drawing.Size(154, 78)
        Me.pcbPercepcion.TabIndex = 15
        Me.pcbPercepcion.TabStop = False
        Me.pcbPercepcion.Visible = False
        '
        'pcbFibrilacion
        '
        Me.pcbFibrilacion.Image = CType(resources.GetObject("pcbFibrilacion.Image"), System.Drawing.Image)
        Me.pcbFibrilacion.Location = New System.Drawing.Point(445, 325)
        Me.pcbFibrilacion.Name = "pcbFibrilacion"
        Me.pcbFibrilacion.Size = New System.Drawing.Size(154, 78)
        Me.pcbFibrilacion.TabIndex = 16
        Me.pcbFibrilacion.TabStop = False
        Me.pcbFibrilacion.Visible = False
        '
        'pcbNinguno
        '
        Me.pcbNinguno.Location = New System.Drawing.Point(619, 210)
        Me.pcbNinguno.Name = "pcbNinguno"
        Me.pcbNinguno.Size = New System.Drawing.Size(154, 78)
        Me.pcbNinguno.TabIndex = 17
        Me.pcbNinguno.TabStop = False
        '
        'pcbMuerte
        '
        Me.pcbMuerte.Image = CType(resources.GetObject("pcbMuerte.Image"), System.Drawing.Image)
        Me.pcbMuerte.Location = New System.Drawing.Point(619, 325)
        Me.pcbMuerte.Name = "pcbMuerte"
        Me.pcbMuerte.Size = New System.Drawing.Size(154, 113)
        Me.pcbMuerte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMuerte.TabIndex = 18
        Me.pcbMuerte.TabStop = False
        Me.pcbMuerte.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(634, 59)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.pcbMuerte)
        Me.Controls.Add(Me.pcbNinguno)
        Me.Controls.Add(Me.pcbFibrilacion)
        Me.Controls.Add(Me.pcbPercepcion)
        Me.Controls.Add(Me.pcbAsfixia)
        Me.Controls.Add(Me.pcbTetanizacion)
        Me.Controls.Add(Me.pcbParo)
        Me.Controls.Add(Me.pcbElectrizacion)
        Me.Controls.Add(Me.btnVaciar)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.txtEfecto)
        Me.Controls.Add(Me.pcbImagen)
        Me.Controls.Add(Me.txtmA)
        Me.Controls.Add(Me.lblEf)
        Me.Controls.Add(Me.lblMotivo)
        Me.Controls.Add(Me.lblmA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbElectrizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbParo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTetanizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbAsfixia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPercepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFibrilacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbNinguno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbMuerte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblmA As Label
    Friend WithEvents lblMotivo As Label
    Friend WithEvents lblEf As Label
    Friend WithEvents txtmA As TextBox
    Friend WithEvents pcbImagen As PictureBox
    Friend WithEvents txtEfecto As TextBox
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents btnAplicar As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents pcbElectrizacion As PictureBox
    Friend WithEvents pcbParo As PictureBox
    Friend WithEvents pcbTetanizacion As PictureBox
    Friend WithEvents pcbAsfixia As PictureBox
    Friend WithEvents pcbPercepcion As PictureBox
    Friend WithEvents pcbFibrilacion As PictureBox
    Friend WithEvents pcbNinguno As PictureBox
    Friend WithEvents pcbMuerte As PictureBox
    Friend WithEvents btnSalir As Button
End Class
