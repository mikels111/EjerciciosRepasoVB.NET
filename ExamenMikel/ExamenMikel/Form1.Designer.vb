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
        Me.cmbJornada = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.btnIzquierda = New System.Windows.Forms.Button()
        Me.lstBanquillo = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.cmbDemarcacion = New System.Windows.Forms.ComboBox()
        Me.chkCedido = New System.Windows.Forms.CheckBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pcbFoto = New System.Windows.Forms.PictureBox()
        Me.lstAlineacion = New System.Windows.Forms.ListBox()
        CType(Me.pcbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbJornada
        '
        Me.cmbJornada.FormattingEnabled = True
        Me.cmbJornada.Location = New System.Drawing.Point(48, 48)
        Me.cmbJornada.Name = "cmbJornada"
        Me.cmbJornada.Size = New System.Drawing.Size(84, 21)
        Me.cmbJornada.TabIndex = 0
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(48, 97)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(39, 13)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Jornada"
        '
        'btnDerecha
        '
        Me.btnDerecha.Location = New System.Drawing.Point(337, 60)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(75, 23)
        Me.btnDerecha.TabIndex = 4
        Me.btnDerecha.Text = ">"
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'btnIzquierda
        '
        Me.btnIzquierda.Location = New System.Drawing.Point(337, 110)
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(75, 23)
        Me.btnIzquierda.TabIndex = 5
        Me.btnIzquierda.Text = "<"
        Me.btnIzquierda.UseVisualStyleBackColor = True
        '
        'lstBanquillo
        '
        Me.lstBanquillo.FormattingEnabled = True
        Me.lstBanquillo.Location = New System.Drawing.Point(184, 48)
        Me.lstBanquillo.Name = "lstBanquillo"
        Me.lstBanquillo.Size = New System.Drawing.Size(120, 95)
        Me.lstBanquillo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Banquillo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Alineación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Demarcación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(123, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lugar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(123, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(123, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(197, 188)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 13
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Location = New System.Drawing.Point(197, 243)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.dtpNacimiento.TabIndex = 14
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(197, 289)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(100, 20)
        Me.txtLugar.TabIndex = 15
        '
        'cmbDemarcacion
        '
        Me.cmbDemarcacion.FormattingEnabled = True
        Me.cmbDemarcacion.Location = New System.Drawing.Point(199, 343)
        Me.cmbDemarcacion.Name = "cmbDemarcacion"
        Me.cmbDemarcacion.Size = New System.Drawing.Size(121, 21)
        Me.cmbDemarcacion.TabIndex = 16
        '
        'chkCedido
        '
        Me.chkCedido.AutoSize = True
        Me.chkCedido.Location = New System.Drawing.Point(126, 381)
        Me.chkCedido.Name = "chkCedido"
        Me.chkCedido.Size = New System.Drawing.Size(59, 17)
        Me.chkCedido.TabIndex = 17
        Me.chkCedido.Text = "Cedido"
        Me.chkCedido.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(337, 381)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(561, 415)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 19
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pcbFoto
        '
        Me.pcbFoto.Location = New System.Drawing.Point(460, 196)
        Me.pcbFoto.Name = "pcbFoto"
        Me.pcbFoto.Size = New System.Drawing.Size(100, 136)
        Me.pcbFoto.TabIndex = 20
        Me.pcbFoto.TabStop = False
        '
        'lstAlineacion
        '
        Me.lstAlineacion.FormattingEnabled = True
        Me.lstAlineacion.Location = New System.Drawing.Point(460, 60)
        Me.lstAlineacion.Name = "lstAlineacion"
        Me.lstAlineacion.Size = New System.Drawing.Size(120, 95)
        Me.lstAlineacion.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 450)
        Me.Controls.Add(Me.lstAlineacion)
        Me.Controls.Add(Me.pcbFoto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.chkCedido)
        Me.Controls.Add(Me.cmbDemarcacion)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.dtpNacimiento)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstBanquillo)
        Me.Controls.Add(Me.btnIzquierda)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmbJornada)
        Me.Name = "Form1"
        Me.Text = "Alineación"
        CType(Me.pcbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbJornada As ComboBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnIzquierda As Button
    Friend WithEvents lstBanquillo As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents txtLugar As TextBox
    Friend WithEvents cmbDemarcacion As ComboBox
    Friend WithEvents chkCedido As CheckBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pcbFoto As PictureBox
    Friend WithEvents lstAlineacion As ListBox
End Class
