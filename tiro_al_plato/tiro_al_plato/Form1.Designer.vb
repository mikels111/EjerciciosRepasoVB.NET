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
        Me.pcbTirador = New System.Windows.Forms.PictureBox()
        Me.tmrPlatos = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPlatosLanzados = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.lblPlatos = New System.Windows.Forms.Label()
        Me.txtPlatosRotos = New System.Windows.Forms.TextBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.pcbPlato = New System.Windows.Forms.PictureBox()
        Me.pcbRoto = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.pcbTirador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbPlato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbRoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcbTirador
        '
        Me.pcbTirador.Image = CType(resources.GetObject("pcbTirador.Image"), System.Drawing.Image)
        Me.pcbTirador.Location = New System.Drawing.Point(400, 335)
        Me.pcbTirador.Name = "pcbTirador"
        Me.pcbTirador.Size = New System.Drawing.Size(100, 133)
        Me.pcbTirador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbTirador.TabIndex = 0
        Me.pcbTirador.TabStop = False
        '
        'tmrPlatos
        '
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPlatosLanzados)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnFin)
        Me.Panel1.Controls.Add(Me.lblPlatos)
        Me.Panel1.Controls.Add(Me.txtPlatosRotos)
        Me.Panel1.Controls.Add(Me.btnInicio)
        Me.Panel1.Location = New System.Drawing.Point(35, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 71)
        Me.Panel1.TabIndex = 1
        '
        'txtPlatosLanzados
        '
        Me.txtPlatosLanzados.Location = New System.Drawing.Point(470, 3)
        Me.txtPlatosLanzados.Multiline = True
        Me.txtPlatosLanzados.Name = "txtPlatosLanzados"
        Me.txtPlatosLanzados.Size = New System.Drawing.Size(100, 62)
        Me.txtPlatosLanzados.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "De"
        '
        'btnFin
        '
        Me.btnFin.Location = New System.Drawing.Point(651, 4)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(120, 61)
        Me.btnFin.TabIndex = 3
        Me.btnFin.Text = "Fin"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'lblPlatos
        '
        Me.lblPlatos.AutoSize = True
        Me.lblPlatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatos.Location = New System.Drawing.Point(171, 14)
        Me.lblPlatos.Name = "lblPlatos"
        Me.lblPlatos.Size = New System.Drawing.Size(90, 31)
        Me.lblPlatos.TabIndex = 2
        Me.lblPlatos.Text = "Platos"
        '
        'txtPlatosRotos
        '
        Me.txtPlatosRotos.Location = New System.Drawing.Point(267, 3)
        Me.txtPlatosRotos.Multiline = True
        Me.txtPlatosRotos.Name = "txtPlatosRotos"
        Me.txtPlatosRotos.Size = New System.Drawing.Size(100, 62)
        Me.txtPlatosRotos.TabIndex = 1
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(3, 4)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(120, 62)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'pcbPlato
        '
        Me.pcbPlato.Image = CType(resources.GetObject("pcbPlato.Image"), System.Drawing.Image)
        Me.pcbPlato.Location = New System.Drawing.Point(137, 369)
        Me.pcbPlato.Name = "pcbPlato"
        Me.pcbPlato.Size = New System.Drawing.Size(100, 50)
        Me.pcbPlato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPlato.TabIndex = 2
        Me.pcbPlato.TabStop = False
        '
        'pcbRoto
        '
        Me.pcbRoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbRoto.Image = CType(resources.GetObject("pcbRoto.Image"), System.Drawing.Image)
        Me.pcbRoto.Location = New System.Drawing.Point(93, 197)
        Me.pcbRoto.Name = "pcbRoto"
        Me.pcbRoto.Size = New System.Drawing.Size(206, 152)
        Me.pcbRoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbRoto.TabIndex = 3
        Me.pcbRoto.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.pcbRoto)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.pcbTirador)
        Me.Panel2.Controls.Add(Me.pcbPlato)
        Me.Panel2.Location = New System.Drawing.Point(-2, -4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(876, 561)
        Me.Panel2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(870, 462)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcbTirador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pcbPlato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbRoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbTirador As PictureBox
    Friend WithEvents tmrPlatos As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPlatosLanzados As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFin As Button
    Friend WithEvents lblPlatos As Label
    Friend WithEvents txtPlatosRotos As TextBox
    Friend WithEvents btnInicio As Button
    Friend WithEvents pcbPlato As PictureBox
    Friend WithEvents pcbRoto As PictureBox
    Friend WithEvents Panel2 As Panel
End Class
