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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRevisar = New System.Windows.Forms.Button()
        Me.btnOtra = New System.Windows.Forms.Button()
        Me.txtSuma2 = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtSuma1 = New System.Windows.Forms.TextBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pcbImagen = New System.Windows.Forms.PictureBox()
        Me.pcbTriste = New System.Windows.Forms.PictureBox()
        Me.pcbFeliz = New System.Windows.Forms.PictureBox()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTriste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbFeliz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(71, 48)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(144, 72)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnRevisar
        '
        Me.btnRevisar.Location = New System.Drawing.Point(323, 366)
        Me.btnRevisar.Name = "btnRevisar"
        Me.btnRevisar.Size = New System.Drawing.Size(144, 72)
        Me.btnRevisar.TabIndex = 1
        Me.btnRevisar.Text = "Revisar"
        Me.btnRevisar.UseVisualStyleBackColor = True
        '
        'btnOtra
        '
        Me.btnOtra.Location = New System.Drawing.Point(540, 48)
        Me.btnOtra.Name = "btnOtra"
        Me.btnOtra.Size = New System.Drawing.Size(144, 72)
        Me.btnOtra.TabIndex = 2
        Me.btnOtra.Text = "Otra suma"
        Me.btnOtra.UseVisualStyleBackColor = True
        '
        'txtSuma2
        '
        Me.txtSuma2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuma2.Location = New System.Drawing.Point(335, 144)
        Me.txtSuma2.Multiline = True
        Me.txtSuma2.Name = "txtSuma2"
        Me.txtSuma2.Size = New System.Drawing.Size(115, 105)
        Me.txtSuma2.TabIndex = 3
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(335, 255)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(115, 105)
        Me.txtTotal.TabIndex = 4
        '
        'txtSuma1
        '
        Me.txtSuma1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuma1.Location = New System.Drawing.Point(335, 15)
        Me.txtSuma1.Multiline = True
        Me.txtSuma1.Name = "txtSuma1"
        Me.txtSuma1.Size = New System.Drawing.Size(115, 105)
        Me.txtSuma1.TabIndex = 5
        '
        'txtNota
        '
        Me.txtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.Location = New System.Drawing.Point(552, 333)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(219, 105)
        Me.txtNota.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Escribe el total--->"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 382)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Click en Revisar--->"
        '
        'pcbImagen
        '
        Me.pcbImagen.Location = New System.Drawing.Point(599, 166)
        Me.pcbImagen.Name = "pcbImagen"
        Me.pcbImagen.Size = New System.Drawing.Size(100, 105)
        Me.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbImagen.TabIndex = 9
        Me.pcbImagen.TabStop = False
        '
        'pcbTriste
        '
        Me.pcbTriste.Image = CType(resources.GetObject("pcbTriste.Image"), System.Drawing.Image)
        Me.pcbTriste.Location = New System.Drawing.Point(71, 144)
        Me.pcbTriste.Name = "pcbTriste"
        Me.pcbTriste.Size = New System.Drawing.Size(100, 105)
        Me.pcbTriste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbTriste.TabIndex = 10
        Me.pcbTriste.TabStop = False
        Me.pcbTriste.Visible = False
        '
        'pcbFeliz
        '
        Me.pcbFeliz.Image = CType(resources.GetObject("pcbFeliz.Image"), System.Drawing.Image)
        Me.pcbFeliz.Location = New System.Drawing.Point(71, 290)
        Me.pcbFeliz.Name = "pcbFeliz"
        Me.pcbFeliz.Size = New System.Drawing.Size(100, 105)
        Me.pcbFeliz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFeliz.TabIndex = 11
        Me.pcbFeliz.TabStop = False
        Me.pcbFeliz.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pcbFeliz)
        Me.Controls.Add(Me.pcbTriste)
        Me.Controls.Add(Me.pcbImagen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.txtSuma1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtSuma2)
        Me.Controls.Add(Me.btnOtra)
        Me.Controls.Add(Me.btnRevisar)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTriste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbFeliz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRevisar As Button
    Friend WithEvents btnOtra As Button
    Friend WithEvents txtSuma2 As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtSuma1 As TextBox
    Friend WithEvents txtNota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pcbImagen As PictureBox
    Friend WithEvents pcbTriste As PictureBox
    Friend WithEvents pcbFeliz As PictureBox
End Class
