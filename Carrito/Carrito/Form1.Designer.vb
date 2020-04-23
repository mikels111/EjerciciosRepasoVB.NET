<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carrito
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
        Me.lstArticulos = New System.Windows.Forms.ListBox()
        Me.lstCarrito = New System.Windows.Forms.ListBox()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstArticulos
        '
        Me.lstArticulos.FormattingEnabled = True
        Me.lstArticulos.Items.AddRange(New Object() {"Papel", "Papelera", "Lapiz", "Boligrafo", "Rotulador", "Carpeta", "Cuaderno", "Regla", "Tipex", "Cartabón"})
        Me.lstArticulos.Location = New System.Drawing.Point(164, 77)
        Me.lstArticulos.Name = "lstArticulos"
        Me.lstArticulos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstArticulos.Size = New System.Drawing.Size(120, 134)
        Me.lstArticulos.TabIndex = 0
        '
        'lstCarrito
        '
        Me.lstCarrito.FormattingEnabled = True
        Me.lstCarrito.Location = New System.Drawing.Point(521, 77)
        Me.lstCarrito.Name = "lstCarrito"
        Me.lstCarrito.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstCarrito.Size = New System.Drawing.Size(120, 134)
        Me.lstCarrito.TabIndex = 1
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(336, 87)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(124, 23)
        Me.btnAñadir.TabIndex = 4
        Me.btnAñadir.Text = "Añadir al carrito-->"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(336, 149)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(124, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "<--Eliminar del carrito"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Carrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.lstCarrito)
        Me.Controls.Add(Me.lstArticulos)
        Me.Name = "Carrito"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstArticulos As ListBox
    Friend WithEvents lstCarrito As ListBox
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnEliminar As Button
End Class
