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
        Me.lstMoviles = New System.Windows.Forms.ListBox()
        Me.ilsMoviles = New System.Windows.Forms.ImageList(Me.components)
        Me.pcbMovil = New System.Windows.Forms.PictureBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.pcbMovil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstMoviles
        '
        Me.lstMoviles.FormattingEnabled = True
        Me.lstMoviles.Items.AddRange(New Object() {"Samsung Galaxy s10", "Iphone 10", "Sony Xperia z5", "Iphone 5s", "BlackBerry"})
        Me.lstMoviles.Location = New System.Drawing.Point(107, 100)
        Me.lstMoviles.Name = "lstMoviles"
        Me.lstMoviles.Size = New System.Drawing.Size(120, 95)
        Me.lstMoviles.TabIndex = 0
        '
        'ilsMoviles
        '
        Me.ilsMoviles.ImageStream = CType(resources.GetObject("ilsMoviles.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilsMoviles.TransparentColor = System.Drawing.Color.Transparent
        Me.ilsMoviles.Images.SetKeyName(0, "s10.jpg")
        Me.ilsMoviles.Images.SetKeyName(1, "iphoneX.jpg")
        Me.ilsMoviles.Images.SetKeyName(2, "sony.jpg")
        Me.ilsMoviles.Images.SetKeyName(3, "5s.jpg")
        Me.ilsMoviles.Images.SetKeyName(4, "blackberry.png")
        '
        'pcbMovil
        '
        Me.pcbMovil.Location = New System.Drawing.Point(293, 41)
        Me.pcbMovil.Name = "pcbMovil"
        Me.pcbMovil.Size = New System.Drawing.Size(164, 176)
        Me.pcbMovil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbMovil.TabIndex = 1
        Me.pcbMovil.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(127, 218)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 52)
        Me.txtDescripcion.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(550, 109)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.pcbMovil)
        Me.Controls.Add(Me.lstMoviles)
        Me.Name = "Form1"
        Me.Text = "Teléfono"
        CType(Me.pcbMovil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstMoviles As ListBox
    Friend WithEvents ilsMoviles As ImageList
    Friend WithEvents pcbMovil As PictureBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnSalir As Button
End Class
