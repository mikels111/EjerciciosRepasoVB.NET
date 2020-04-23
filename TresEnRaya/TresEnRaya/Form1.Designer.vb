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
        Me.ilsImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.pcb00 = New System.Windows.Forms.PictureBox()
        Me.pcb01 = New System.Windows.Forms.PictureBox()
        Me.pcb21 = New System.Windows.Forms.PictureBox()
        Me.pcb20 = New System.Windows.Forms.PictureBox()
        Me.pcb12 = New System.Windows.Forms.PictureBox()
        Me.pcb02 = New System.Windows.Forms.PictureBox()
        Me.pcb11 = New System.Windows.Forms.PictureBox()
        Me.pcb10 = New System.Windows.Forms.PictureBox()
        Me.pcb22 = New System.Windows.Forms.PictureBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlJuego = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.pcb00, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlJuego.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ilsImagenes
        '
        Me.ilsImagenes.ImageStream = CType(resources.GetObject("ilsImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsImagenes.Images.SetKeyName(0, "interrogante.png")
        Me.ilsImagenes.Images.SetKeyName(1, "índice.png")
        Me.ilsImagenes.Images.SetKeyName(2, "circulo.jpg")
        '
        'pcb00
        '
        Me.pcb00.Image = CType(resources.GetObject("pcb00.Image"), System.Drawing.Image)
        Me.pcb00.Location = New System.Drawing.Point(16, 14)
        Me.pcb00.Name = "pcb00"
        Me.pcb00.Size = New System.Drawing.Size(100, 81)
        Me.pcb00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb00.TabIndex = 0
        Me.pcb00.TabStop = False
        Me.pcb00.Tag = "0"
        '
        'pcb01
        '
        Me.pcb01.Image = CType(resources.GetObject("pcb01.Image"), System.Drawing.Image)
        Me.pcb01.Location = New System.Drawing.Point(136, 14)
        Me.pcb01.Name = "pcb01"
        Me.pcb01.Size = New System.Drawing.Size(100, 81)
        Me.pcb01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb01.TabIndex = 1
        Me.pcb01.TabStop = False
        Me.pcb01.Tag = "1"
        '
        'pcb21
        '
        Me.pcb21.Image = CType(resources.GetObject("pcb21.Image"), System.Drawing.Image)
        Me.pcb21.Location = New System.Drawing.Point(136, 221)
        Me.pcb21.Name = "pcb21"
        Me.pcb21.Size = New System.Drawing.Size(100, 81)
        Me.pcb21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb21.TabIndex = 2
        Me.pcb21.TabStop = False
        Me.pcb21.Tag = "7"
        '
        'pcb20
        '
        Me.pcb20.Image = CType(resources.GetObject("pcb20.Image"), System.Drawing.Image)
        Me.pcb20.Location = New System.Drawing.Point(16, 221)
        Me.pcb20.Name = "pcb20"
        Me.pcb20.Size = New System.Drawing.Size(100, 81)
        Me.pcb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb20.TabIndex = 3
        Me.pcb20.TabStop = False
        Me.pcb20.Tag = "6"
        '
        'pcb12
        '
        Me.pcb12.Image = CType(resources.GetObject("pcb12.Image"), System.Drawing.Image)
        Me.pcb12.Location = New System.Drawing.Point(257, 121)
        Me.pcb12.Name = "pcb12"
        Me.pcb12.Size = New System.Drawing.Size(100, 81)
        Me.pcb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb12.TabIndex = 4
        Me.pcb12.TabStop = False
        Me.pcb12.Tag = "5"
        '
        'pcb02
        '
        Me.pcb02.Image = CType(resources.GetObject("pcb02.Image"), System.Drawing.Image)
        Me.pcb02.Location = New System.Drawing.Point(257, 14)
        Me.pcb02.Name = "pcb02"
        Me.pcb02.Size = New System.Drawing.Size(100, 81)
        Me.pcb02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb02.TabIndex = 5
        Me.pcb02.TabStop = False
        Me.pcb02.Tag = "2"
        '
        'pcb11
        '
        Me.pcb11.Image = CType(resources.GetObject("pcb11.Image"), System.Drawing.Image)
        Me.pcb11.Location = New System.Drawing.Point(136, 121)
        Me.pcb11.Name = "pcb11"
        Me.pcb11.Size = New System.Drawing.Size(100, 81)
        Me.pcb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb11.TabIndex = 6
        Me.pcb11.TabStop = False
        Me.pcb11.Tag = "4"
        '
        'pcb10
        '
        Me.pcb10.Image = CType(resources.GetObject("pcb10.Image"), System.Drawing.Image)
        Me.pcb10.Location = New System.Drawing.Point(16, 121)
        Me.pcb10.Name = "pcb10"
        Me.pcb10.Size = New System.Drawing.Size(100, 81)
        Me.pcb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb10.TabIndex = 7
        Me.pcb10.TabStop = False
        Me.pcb10.Tag = "3"
        '
        'pcb22
        '
        Me.pcb22.Image = CType(resources.GetObject("pcb22.Image"), System.Drawing.Image)
        Me.pcb22.Location = New System.Drawing.Point(257, 221)
        Me.pcb22.Name = "pcb22"
        Me.pcb22.Size = New System.Drawing.Size(100, 81)
        Me.pcb22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb22.TabIndex = 8
        Me.pcb22.TabStop = False
        Me.pcb22.Tag = "8"
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(15, 17)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(75, 23)
        Me.btnInicio.TabIndex = 9
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(15, 47)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pnlJuego
        '
        Me.pnlJuego.Controls.Add(Me.pcb11)
        Me.pnlJuego.Controls.Add(Me.pcb00)
        Me.pnlJuego.Controls.Add(Me.pcb01)
        Me.pnlJuego.Controls.Add(Me.pcb22)
        Me.pnlJuego.Controls.Add(Me.pcb21)
        Me.pnlJuego.Controls.Add(Me.pcb10)
        Me.pnlJuego.Controls.Add(Me.pcb20)
        Me.pnlJuego.Controls.Add(Me.pcb12)
        Me.pnlJuego.Controls.Add(Me.pcb02)
        Me.pnlJuego.Location = New System.Drawing.Point(70, 30)
        Me.pnlJuego.Name = "pnlJuego"
        Me.pnlJuego.Size = New System.Drawing.Size(366, 321)
        Me.pnlJuego.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnInicio)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Location = New System.Drawing.Point(520, 251)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(126, 100)
        Me.Panel2.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlJuego)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcb00, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlJuego.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ilsImagenes As ImageList
    Friend WithEvents pcb00 As PictureBox
    Friend WithEvents pcb01 As PictureBox
    Friend WithEvents pcb21 As PictureBox
    Friend WithEvents pcb20 As PictureBox
    Friend WithEvents pcb12 As PictureBox
    Friend WithEvents pcb02 As PictureBox
    Friend WithEvents pcb11 As PictureBox
    Friend WithEvents pcb10 As PictureBox
    Friend WithEvents pcb22 As PictureBox
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnlJuego As Panel
    Friend WithEvents Panel2 As Panel
End Class
