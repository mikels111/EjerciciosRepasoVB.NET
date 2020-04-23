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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstEstado = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFallos = New System.Windows.Forms.TextBox()
        Me.lstCapitales = New System.Windows.Forms.ListBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estado"
        '
        'lstEstado
        '
        Me.lstEstado.FormattingEnabled = True
        Me.lstEstado.Location = New System.Drawing.Point(126, 40)
        Me.lstEstado.Name = "lstEstado"
        Me.lstEstado.Size = New System.Drawing.Size(204, 95)
        Me.lstEstado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fallos"
        '
        'txtFallos
        '
        Me.txtFallos.Location = New System.Drawing.Point(209, 249)
        Me.txtFallos.Name = "txtFallos"
        Me.txtFallos.Size = New System.Drawing.Size(56, 20)
        Me.txtFallos.TabIndex = 3
        '
        'lstCapitales
        '
        Me.lstCapitales.FormattingEnabled = True
        Me.lstCapitales.Location = New System.Drawing.Point(431, 40)
        Me.lstCapitales.Name = "lstCapitales"
        Me.lstCapitales.Size = New System.Drawing.Size(202, 95)
        Me.lstCapitales.TabIndex = 4
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(366, 244)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 5
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(499, 244)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.lstCapitales)
        Me.Controls.Add(Me.txtFallos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstEstado)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstEstado As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFallos As TextBox
    Friend WithEvents lstCapitales As ListBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnSalir As Button
End Class
