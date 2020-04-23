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
        Me.lstDirectores = New System.Windows.Forms.ListBox()
        Me.pcbDirectores = New System.Windows.Forms.PictureBox()
        Me.txtPeliculas = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lstPeliculas = New System.Windows.Forms.ListBox()
        CType(Me.pcbDirectores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstDirectores
        '
        Me.lstDirectores.FormattingEnabled = True
        Me.lstDirectores.Location = New System.Drawing.Point(99, 12)
        Me.lstDirectores.Name = "lstDirectores"
        Me.lstDirectores.Size = New System.Drawing.Size(217, 186)
        Me.lstDirectores.TabIndex = 0
        '
        'pcbDirectores
        '
        Me.pcbDirectores.Location = New System.Drawing.Point(486, 14)
        Me.pcbDirectores.Name = "pcbDirectores"
        Me.pcbDirectores.Size = New System.Drawing.Size(120, 184)
        Me.pcbDirectores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbDirectores.TabIndex = 1
        Me.pcbDirectores.TabStop = False
        '
        'txtPeliculas
        '
        Me.txtPeliculas.Location = New System.Drawing.Point(448, 258)
        Me.txtPeliculas.Multiline = True
        Me.txtPeliculas.Name = "txtPeliculas"
        Me.txtPeliculas.Size = New System.Drawing.Size(302, 115)
        Me.txtPeliculas.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(243, 409)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lstPeliculas
        '
        Me.lstPeliculas.FormattingEnabled = True
        Me.lstPeliculas.Location = New System.Drawing.Point(99, 258)
        Me.lstPeliculas.Name = "lstPeliculas"
        Me.lstPeliculas.Size = New System.Drawing.Size(219, 95)
        Me.lstPeliculas.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstPeliculas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtPeliculas)
        Me.Controls.Add(Me.pcbDirectores)
        Me.Controls.Add(Me.lstDirectores)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcbDirectores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDirectores As ListBox
    Friend WithEvents pcbDirectores As PictureBox
    Friend WithEvents txtPeliculas As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents lstPeliculas As ListBox
End Class
