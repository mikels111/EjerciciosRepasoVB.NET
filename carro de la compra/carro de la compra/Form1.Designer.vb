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
        Me.pcbImagen1 = New System.Windows.Forms.PictureBox()
        Me.pcbImagen3 = New System.Windows.Forms.PictureBox()
        Me.pcbImagen2 = New System.Windows.Forms.PictureBox()
        Me.pcb546974Imagen4 = New System.Windows.Forms.PictureBox()
        Me.pcbImagen = New System.Windows.Forms.PictureBox()
        Me.lstCarro = New System.Windows.Forms.ListBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pcbImagen1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbImagen3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbImagen2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb546974Imagen4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbImagen1
        '
        Me.pcbImagen1.Location = New System.Drawing.Point(24, 81)
        Me.pcbImagen1.Name = "pcbImagen1"
        Me.pcbImagen1.Size = New System.Drawing.Size(160, 96)
        Me.pcbImagen1.TabIndex = 0
        Me.pcbImagen1.TabStop = False
        '
        'pcbImagen3
        '
        Me.pcbImagen3.Location = New System.Drawing.Point(201, 81)
        Me.pcbImagen3.Name = "pcbImagen3"
        Me.pcbImagen3.Size = New System.Drawing.Size(160, 96)
        Me.pcbImagen3.TabIndex = 1
        Me.pcbImagen3.TabStop = False
        '
        'pcbImagen2
        '
        Me.pcbImagen2.Location = New System.Drawing.Point(24, 222)
        Me.pcbImagen2.Name = "pcbImagen2"
        Me.pcbImagen2.Size = New System.Drawing.Size(160, 96)
        Me.pcbImagen2.TabIndex = 2
        Me.pcbImagen2.TabStop = False
        '
        'pcb546974Imagen4
        '
        Me.pcb546974Imagen4.Location = New System.Drawing.Point(201, 222)
        Me.pcb546974Imagen4.Name = "pcb546974Imagen4"
        Me.pcb546974Imagen4.Size = New System.Drawing.Size(160, 96)
        Me.pcb546974Imagen4.TabIndex = 3
        Me.pcb546974Imagen4.TabStop = False
        '
        'pcbImagen
        '
        Me.pcbImagen.Location = New System.Drawing.Point(457, 222)
        Me.pcbImagen.Name = "pcbImagen"
        Me.pcbImagen.Size = New System.Drawing.Size(115, 96)
        Me.pcbImagen.TabIndex = 4
        Me.pcbImagen.TabStop = False
        '
        'lstCarro
        '
        Me.lstCarro.FormattingEnabled = True
        Me.lstCarro.Location = New System.Drawing.Point(694, 82)
        Me.lstCarro.Name = "lstCarro"
        Me.lstCarro.Size = New System.Drawing.Size(120, 95)
        Me.lstCarro.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(466, 81)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(91, 47)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "<--------"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(694, 298)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(120, 20)
        Me.txtImporte.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(611, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Importe"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lstCarro)
        Me.Controls.Add(Me.pcbImagen)
        Me.Controls.Add(Me.pcb546974Imagen4)
        Me.Controls.Add(Me.pcbImagen2)
        Me.Controls.Add(Me.pcbImagen3)
        Me.Controls.Add(Me.pcbImagen1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcbImagen1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbImagen3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbImagen2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb546974Imagen4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbImagen1 As PictureBox
    Friend WithEvents pcbImagen3 As PictureBox
    Friend WithEvents pcbImagen2 As PictureBox
    Friend WithEvents pcb546974Imagen4 As PictureBox
    Friend WithEvents pcbImagen As PictureBox
    Friend WithEvents lstCarro As ListBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label1 As Label
End Class
