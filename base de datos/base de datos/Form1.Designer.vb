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
        Me.lstEstados = New System.Windows.Forms.ListBox()
        Me.txtCapitales = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstEstados
        '
        Me.lstEstados.FormattingEnabled = True
        Me.lstEstados.Location = New System.Drawing.Point(329, 51)
        Me.lstEstados.Name = "lstEstados"
        Me.lstEstados.Size = New System.Drawing.Size(121, 147)
        Me.lstEstados.TabIndex = 0
        '
        'txtCapitales
        '
        Me.txtCapitales.Location = New System.Drawing.Point(329, 206)
        Me.txtCapitales.Name = "txtCapitales"
        Me.txtCapitales.Size = New System.Drawing.Size(100, 20)
        Me.txtCapitales.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(329, 266)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtCapitales)
        Me.Controls.Add(Me.lstEstados)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstEstados As ListBox
    Friend WithEvents txtCapitales As TextBox
    Friend WithEvents btnSalir As Button
End Class
