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
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPuntos = New System.Windows.Forms.TextBox()
        Me.pcbAmarillo = New System.Windows.Forms.PictureBox()
        Me.pcbRojo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmrPato = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFinJuego = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pcbAmarillo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbRojo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(66, 34)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(75, 23)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(473, 34)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Puntos"
        '
        'txtPuntos
        '
        Me.txtPuntos.Location = New System.Drawing.Point(243, 50)
        Me.txtPuntos.Name = "txtPuntos"
        Me.txtPuntos.ReadOnly = True
        Me.txtPuntos.Size = New System.Drawing.Size(100, 20)
        Me.txtPuntos.TabIndex = 3
        '
        'pcbAmarillo
        '
        Me.pcbAmarillo.Image = CType(resources.GetObject("pcbAmarillo.Image"), System.Drawing.Image)
        Me.pcbAmarillo.Location = New System.Drawing.Point(66, 115)
        Me.pcbAmarillo.Name = "pcbAmarillo"
        Me.pcbAmarillo.Size = New System.Drawing.Size(144, 141)
        Me.pcbAmarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbAmarillo.TabIndex = 4
        Me.pcbAmarillo.TabStop = False
        Me.pcbAmarillo.Visible = False
        '
        'pcbRojo
        '
        Me.pcbRojo.Image = CType(resources.GetObject("pcbRojo.Image"), System.Drawing.Image)
        Me.pcbRojo.Location = New System.Drawing.Point(66, 288)
        Me.pcbRojo.Name = "pcbRojo"
        Me.pcbRojo.Size = New System.Drawing.Size(144, 141)
        Me.pcbRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbRojo.TabIndex = 5
        Me.pcbRojo.TabStop = False
        Me.pcbRojo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnInicio)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.txtPuntos)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 97)
        Me.Panel1.TabIndex = 6
        '
        'tmrPato
        '
        '
        'tmrFinJuego
        '
        Me.tmrFinJuego.Interval = 20000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 432)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pcbRojo)
        Me.Controls.Add(Me.pcbAmarillo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcbAmarillo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbRojo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInicio As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPuntos As TextBox
    Friend WithEvents pcbAmarillo As PictureBox
    Friend WithEvents pcbRojo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tmrPato As Timer
    Friend WithEvents tmrFinJuego As Timer
End Class
