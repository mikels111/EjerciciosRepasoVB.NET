<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComercialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartnersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartnersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ChargeneticDataSet1 = New Reto.ChargeneticDataSet()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ChargeneticDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.PartnersToolStripMenuItem, Me.FacturasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComercialesToolStripMenuItem, Me.TransportesToolStripMenuItem, Me.PartnersToolStripMenuItem1, Me.ArticulosToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Gestión"
        '
        'ComercialesToolStripMenuItem
        '
        Me.ComercialesToolStripMenuItem.Name = "ComercialesToolStripMenuItem"
        Me.ComercialesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComercialesToolStripMenuItem.Text = "Comerciales"
        '
        'TransportesToolStripMenuItem
        '
        Me.TransportesToolStripMenuItem.Name = "TransportesToolStripMenuItem"
        Me.TransportesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TransportesToolStripMenuItem.Text = "Transportes"
        '
        'PartnersToolStripMenuItem1
        '
        Me.PartnersToolStripMenuItem1.Name = "PartnersToolStripMenuItem1"
        Me.PartnersToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PartnersToolStripMenuItem1.Text = "Partners"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArticulosToolStripMenuItem.Text = "Artículos"
        '
        'PartnersToolStripMenuItem
        '
        Me.PartnersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarToolStripMenuItem, Me.CrearToolStripMenuItem})
        Me.PartnersToolStripMenuItem.Name = "PartnersToolStripMenuItem"
        Me.PartnersToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PartnersToolStripMenuItem.Text = "Pedidos"
        '
        'ImportarToolStripMenuItem
        '
        Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ImportarToolStripMenuItem.Text = "Importar"
        '
        'CrearToolStripMenuItem
        '
        Me.CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        Me.CrearToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CrearToolStripMenuItem.Text = "Modificar"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturarToolStripMenuItem, Me.ImprimirFacturaToolStripMenuItem})
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'FacturarToolStripMenuItem
        '
        Me.FacturarToolStripMenuItem.Name = "FacturarToolStripMenuItem"
        Me.FacturarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.FacturarToolStripMenuItem.Text = "Agrupar Pedidos"
        '
        'ImprimirFacturaToolStripMenuItem
        '
        Me.ImprimirFacturaToolStripMenuItem.Name = "ImprimirFacturaToolStripMenuItem"
        Me.ImprimirFacturaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ImprimirFacturaToolStripMenuItem.Text = "Imprimir Factura"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(352, 162)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ChargeneticDataSet1
        '
        Me.ChargeneticDataSet1.DataSetName = "ChargeneticDataSet"
        Me.ChargeneticDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ChargeneticDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComercialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartnersToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartnersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSalir As Button
    Friend WithEvents ChargeneticDataSet1 As ChargeneticDataSet
    Friend WithEvents ImprimirFacturaToolStripMenuItem As ToolStripMenuItem
End Class
