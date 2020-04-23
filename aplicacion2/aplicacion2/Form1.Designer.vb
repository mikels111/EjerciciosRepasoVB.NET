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
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblImc = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtImc = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pcbFlaco = New System.Windows.Forms.PictureBox()
        Me.pcbSobrepeso = New System.Windows.Forms.PictureBox()
        Me.pcbObesidad = New System.Windows.Forms.PictureBox()
        Me.pcbNormal = New System.Windows.Forms.PictureBox()
        Me.pcbImagen = New System.Windows.Forms.PictureBox()
        CType(Me.pcbFlaco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSobrepeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbObesidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(127, 65)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(34, 13)
        Me.lblAltura.TabIndex = 0
        Me.lblAltura.Text = "Altura"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(127, 112)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(31, 13)
        Me.lblPeso.TabIndex = 1
        Me.lblPeso.Text = "Peso"
        '
        'lblImc
        '
        Me.lblImc.AutoSize = True
        Me.lblImc.Location = New System.Drawing.Point(127, 163)
        Me.lblImc.Name = "lblImc"
        Me.lblImc.Size = New System.Drawing.Size(26, 13)
        Me.lblImc.TabIndex = 2
        Me.lblImc.Text = "IMC"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(224, 58)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 20)
        Me.txtAltura.TabIndex = 3
        '
        'txtImc
        '
        Me.txtImc.Location = New System.Drawing.Point(224, 156)
        Me.txtImc.Name = "txtImc"
        Me.txtImc.ReadOnly = True
        Me.txtImc.Size = New System.Drawing.Size(100, 20)
        Me.txtImc.TabIndex = 4
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(224, 105)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 20)
        Me.txtPeso.TabIndex = 5
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(570, 58)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(570, 87)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pcbFlaco
        '
        Me.pcbFlaco.Image = CType(resources.GetObject("pcbFlaco.Image"), System.Drawing.Image)
        Me.pcbFlaco.Location = New System.Drawing.Point(58, 211)
        Me.pcbFlaco.Name = "pcbFlaco"
        Me.pcbFlaco.Size = New System.Drawing.Size(161, 138)
        Me.pcbFlaco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFlaco.TabIndex = 8
        Me.pcbFlaco.TabStop = False
        Me.pcbFlaco.Visible = False
        '
        'pcbSobrepeso
        '
        Me.pcbSobrepeso.Image = CType(resources.GetObject("pcbSobrepeso.Image"), System.Drawing.Image)
        Me.pcbSobrepeso.Location = New System.Drawing.Point(616, 211)
        Me.pcbSobrepeso.Name = "pcbSobrepeso"
        Me.pcbSobrepeso.Size = New System.Drawing.Size(172, 138)
        Me.pcbSobrepeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbSobrepeso.TabIndex = 9
        Me.pcbSobrepeso.TabStop = False
        Me.pcbSobrepeso.Visible = False
        '
        'pcbObesidad
        '
        Me.pcbObesidad.Image = CType(resources.GetObject("pcbObesidad.Image"), System.Drawing.Image)
        Me.pcbObesidad.Location = New System.Drawing.Point(417, 211)
        Me.pcbObesidad.Name = "pcbObesidad"
        Me.pcbObesidad.Size = New System.Drawing.Size(180, 138)
        Me.pcbObesidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbObesidad.TabIndex = 10
        Me.pcbObesidad.TabStop = False
        Me.pcbObesidad.Visible = False
        '
        'pcbNormal
        '
        Me.pcbNormal.Image = CType(resources.GetObject("pcbNormal.Image"), System.Drawing.Image)
        Me.pcbNormal.Location = New System.Drawing.Point(244, 211)
        Me.pcbNormal.Name = "pcbNormal"
        Me.pcbNormal.Size = New System.Drawing.Size(153, 138)
        Me.pcbNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbNormal.TabIndex = 13
        Me.pcbNormal.TabStop = False
        Me.pcbNormal.Visible = False
        '
        'pcbImagen
        '
        Me.pcbImagen.Location = New System.Drawing.Point(363, 58)
        Me.pcbImagen.Name = "pcbImagen"
        Me.pcbImagen.Size = New System.Drawing.Size(180, 138)
        Me.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImagen.TabIndex = 14
        Me.pcbImagen.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pcbImagen)
        Me.Controls.Add(Me.pcbNormal)
        Me.Controls.Add(Me.pcbObesidad)
        Me.Controls.Add(Me.pcbSobrepeso)
        Me.Controls.Add(Me.pcbFlaco)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtImc)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.lblImc)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.lblAltura)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcbFlaco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSobrepeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbObesidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAltura As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblImc As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtImc As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pcbFlaco As PictureBox
    Friend WithEvents pcbSobrepeso As PictureBox
    Friend WithEvents pcbObesidad As PictureBox
    Friend WithEvents pcbNormal As PictureBox
    Friend WithEvents pcbImagen As PictureBox
End Class
