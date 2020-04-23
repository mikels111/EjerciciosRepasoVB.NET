<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestion
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
        Dim lblComercialID As System.Windows.Forms.Label
        Dim lblNombreComercial As System.Windows.Forms.Label
        Dim APELLIDO1Label As System.Windows.Forms.Label
        Dim APELLIDO2Label As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim TELEFONOLabel As System.Windows.Forms.Label
        Dim DIRECCIONLabel As System.Windows.Forms.Label
        Dim TRANSPORTISTAIDLabel As System.Windows.Forms.Label
        Dim NOMBRELabel1 As System.Windows.Forms.Label
        Dim APELLIDO1Label1 As System.Windows.Forms.Label
        Dim APELLIDO2Label1 As System.Windows.Forms.Label
        Dim DNILabel1 As System.Windows.Forms.Label
        Dim BASTIDORLabel As System.Windows.Forms.Label
        Dim CLIENTEIDLabel As System.Windows.Forms.Label
        Dim EMPRESALabel As System.Windows.Forms.Label
        Dim NOMBRELabel2 As System.Windows.Forms.Label
        Dim APELLIDO1Label2 As System.Windows.Forms.Label
        Dim APELLIDO2Label2 As System.Windows.Forms.Label
        Dim DNILabel2 As System.Windows.Forms.Label
        Dim CIUDADLabel As System.Windows.Forms.Label
        Dim DIRECCION1Label As System.Windows.Forms.Label
        Dim DIRECCION2Label As System.Windows.Forms.Label
        Dim FORMAPAGOIDLabel As System.Windows.Forms.Label
        Dim COMERCIALIDLabel2 As System.Windows.Forms.Label
        Dim CLIENTEIDLabel1 As System.Windows.Forms.Label
        Dim EMPRESALabel1 As System.Windows.Forms.Label
        Dim NOMBRELabel3 As System.Windows.Forms.Label
        Dim APELLIDO1Label3 As System.Windows.Forms.Label
        Dim APELLIDO2Label3 As System.Windows.Forms.Label
        Dim DNILabel3 As System.Windows.Forms.Label
        Dim CIUDADLabel1 As System.Windows.Forms.Label
        Dim DIRECCION1Label1 As System.Windows.Forms.Label
        Dim DIRECCION2Label1 As System.Windows.Forms.Label
        Dim FORMAPAGOIDLabel1 As System.Windows.Forms.Label
        Dim COMERCIALIDLabel1 As System.Windows.Forms.Label
        Dim ArticuloIDLabel As System.Windows.Forms.Label
        Dim CategoriaIDLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PrVentaLabel As System.Windows.Forms.Label
        Dim PrCompraLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim StockMinimoLabel As System.Windows.Forms.Label
        Dim UnidadIDLabel As System.Windows.Forms.Label
        Dim lblFoto As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestion))
        Me.ChargeneticDataSet = New Reto.ChargeneticDataSet()
        Me.ComercialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComercialTableAdapter = New Reto.ChargeneticDataSetTableAdapters.ComercialTableAdapter()
        Me.TableAdapterManager = New Reto.ChargeneticDataSetTableAdapters.TableAdapterManager()
        Me.ArticuloTableAdapter = New Reto.ChargeneticDataSetTableAdapters.ArticuloTableAdapter()
        Me.ClienteTableAdapter = New Reto.ChargeneticDataSetTableAdapters.ClienteTableAdapter()
        Me.TransportistaTableAdapter = New Reto.ChargeneticDataSetTableAdapters.TransportistaTableAdapter()
        Me.CTCABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComercialBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TransportistaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlComercial = New System.Windows.Forms.Panel()
        Me.txtComercialID = New System.Windows.Forms.TextBox()
        Me.txtNombreComercial = New System.Windows.Forms.TextBox()
        Me.APELLIDO1TextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDO2TextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.TELEFONOTextBox = New System.Windows.Forms.TextBox()
        Me.DIRECCIONTextBox = New System.Windows.Forms.TextBox()
        Me.pnlTransportista = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CLIENTEIDTextBox = New System.Windows.Forms.TextBox()
        Me.EMPRESATextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox2 = New System.Windows.Forms.TextBox()
        Me.APELLIDO1TextBox2 = New System.Windows.Forms.TextBox()
        Me.APELLIDO2TextBox2 = New System.Windows.Forms.TextBox()
        Me.DNITextBox2 = New System.Windows.Forms.TextBox()
        Me.CIUDADTextBox = New System.Windows.Forms.TextBox()
        Me.DIRECCION1TextBox = New System.Windows.Forms.TextBox()
        Me.DIRECCION2TextBox = New System.Windows.Forms.TextBox()
        Me.FORMAPAGOIDTextBox = New System.Windows.Forms.TextBox()
        Me.COMERCIALIDTextBox2 = New System.Windows.Forms.TextBox()
        Me.TRANSPORTISTAIDTextBox = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox1 = New System.Windows.Forms.TextBox()
        Me.APELLIDO1TextBox1 = New System.Windows.Forms.TextBox()
        Me.APELLIDO2TextBox1 = New System.Windows.Forms.TextBox()
        Me.DNITextBox1 = New System.Windows.Forms.TextBox()
        Me.BASTIDORTextBox = New System.Windows.Forms.TextBox()
        Me.pnlCliente = New System.Windows.Forms.Panel()
        Me.CLIENTEIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.EMPRESATextBox1 = New System.Windows.Forms.TextBox()
        Me.NOMBRETextBox3 = New System.Windows.Forms.TextBox()
        Me.APELLIDO1TextBox3 = New System.Windows.Forms.TextBox()
        Me.APELLIDO2TextBox3 = New System.Windows.Forms.TextBox()
        Me.DNITextBox3 = New System.Windows.Forms.TextBox()
        Me.CIUDADTextBox1 = New System.Windows.Forms.TextBox()
        Me.DIRECCION1TextBox1 = New System.Windows.Forms.TextBox()
        Me.DIRECCION2TextBox1 = New System.Windows.Forms.TextBox()
        Me.FORMAPAGOIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.COMERCIALIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.pnlArticulo = New System.Windows.Forms.Panel()
        Me.ArticuloIDTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaIDTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PrVentaTextBox = New System.Windows.Forms.TextBox()
        Me.PrCompraTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.StockMinimoTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadIDTextBox = New System.Windows.Forms.TextBox()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.pcbFoto = New System.Windows.Forms.PictureBox()
        lblComercialID = New System.Windows.Forms.Label()
        lblNombreComercial = New System.Windows.Forms.Label()
        APELLIDO1Label = New System.Windows.Forms.Label()
        APELLIDO2Label = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        TELEFONOLabel = New System.Windows.Forms.Label()
        DIRECCIONLabel = New System.Windows.Forms.Label()
        TRANSPORTISTAIDLabel = New System.Windows.Forms.Label()
        NOMBRELabel1 = New System.Windows.Forms.Label()
        APELLIDO1Label1 = New System.Windows.Forms.Label()
        APELLIDO2Label1 = New System.Windows.Forms.Label()
        DNILabel1 = New System.Windows.Forms.Label()
        BASTIDORLabel = New System.Windows.Forms.Label()
        CLIENTEIDLabel = New System.Windows.Forms.Label()
        EMPRESALabel = New System.Windows.Forms.Label()
        NOMBRELabel2 = New System.Windows.Forms.Label()
        APELLIDO1Label2 = New System.Windows.Forms.Label()
        APELLIDO2Label2 = New System.Windows.Forms.Label()
        DNILabel2 = New System.Windows.Forms.Label()
        CIUDADLabel = New System.Windows.Forms.Label()
        DIRECCION1Label = New System.Windows.Forms.Label()
        DIRECCION2Label = New System.Windows.Forms.Label()
        FORMAPAGOIDLabel = New System.Windows.Forms.Label()
        COMERCIALIDLabel2 = New System.Windows.Forms.Label()
        CLIENTEIDLabel1 = New System.Windows.Forms.Label()
        EMPRESALabel1 = New System.Windows.Forms.Label()
        NOMBRELabel3 = New System.Windows.Forms.Label()
        APELLIDO1Label3 = New System.Windows.Forms.Label()
        APELLIDO2Label3 = New System.Windows.Forms.Label()
        DNILabel3 = New System.Windows.Forms.Label()
        CIUDADLabel1 = New System.Windows.Forms.Label()
        DIRECCION1Label1 = New System.Windows.Forms.Label()
        DIRECCION2Label1 = New System.Windows.Forms.Label()
        FORMAPAGOIDLabel1 = New System.Windows.Forms.Label()
        COMERCIALIDLabel1 = New System.Windows.Forms.Label()
        ArticuloIDLabel = New System.Windows.Forms.Label()
        CategoriaIDLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrVentaLabel = New System.Windows.Forms.Label()
        PrCompraLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        StockMinimoLabel = New System.Windows.Forms.Label()
        UnidadIDLabel = New System.Windows.Forms.Label()
        lblFoto = New System.Windows.Forms.Label()
        CType(Me.ChargeneticDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComercialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTCABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTCABindingNavigator.SuspendLayout()
        CType(Me.TransportistaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlComercial.SuspendLayout()
        Me.pnlTransportista.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlCliente.SuspendLayout()
        Me.pnlArticulo.SuspendLayout()
        CType(Me.pcbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblComercialID
        '
        lblComercialID.AutoSize = True
        lblComercialID.Location = New System.Drawing.Point(9, 18)
        lblComercialID.Name = "lblComercialID"
        lblComercialID.Size = New System.Drawing.Size(83, 13)
        lblComercialID.TabIndex = 0
        lblComercialID.Text = "COMERCIALID:"
        '
        'lblNombreComercial
        '
        lblNombreComercial.AutoSize = True
        lblNombreComercial.Location = New System.Drawing.Point(9, 44)
        lblNombreComercial.Name = "lblNombreComercial"
        lblNombreComercial.Size = New System.Drawing.Size(57, 13)
        lblNombreComercial.TabIndex = 2
        lblNombreComercial.Text = "NOMBRE:"
        '
        'APELLIDO1Label
        '
        APELLIDO1Label.AutoSize = True
        APELLIDO1Label.Location = New System.Drawing.Point(9, 70)
        APELLIDO1Label.Name = "APELLIDO1Label"
        APELLIDO1Label.Size = New System.Drawing.Size(68, 13)
        APELLIDO1Label.TabIndex = 4
        APELLIDO1Label.Text = "APELLIDO1:"
        '
        'APELLIDO2Label
        '
        APELLIDO2Label.AutoSize = True
        APELLIDO2Label.Location = New System.Drawing.Point(9, 96)
        APELLIDO2Label.Name = "APELLIDO2Label"
        APELLIDO2Label.Size = New System.Drawing.Size(68, 13)
        APELLIDO2Label.TabIndex = 6
        APELLIDO2Label.Text = "APELLIDO2:"
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(11, 123)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 8
        DNILabel.Text = "DNI:"
        '
        'TELEFONOLabel
        '
        TELEFONOLabel.AutoSize = True
        TELEFONOLabel.Location = New System.Drawing.Point(9, 148)
        TELEFONOLabel.Name = "TELEFONOLabel"
        TELEFONOLabel.Size = New System.Drawing.Size(67, 13)
        TELEFONOLabel.TabIndex = 10
        TELEFONOLabel.Text = "TELEFONO:"
        '
        'DIRECCIONLabel
        '
        DIRECCIONLabel.AutoSize = True
        DIRECCIONLabel.Location = New System.Drawing.Point(9, 174)
        DIRECCIONLabel.Name = "DIRECCIONLabel"
        DIRECCIONLabel.Size = New System.Drawing.Size(69, 13)
        DIRECCIONLabel.TabIndex = 12
        DIRECCIONLabel.Text = "DIRECCION:"
        '
        'TRANSPORTISTAIDLabel
        '
        TRANSPORTISTAIDLabel.AutoSize = True
        TRANSPORTISTAIDLabel.Location = New System.Drawing.Point(6, 18)
        TRANSPORTISTAIDLabel.Name = "TRANSPORTISTAIDLabel"
        TRANSPORTISTAIDLabel.Size = New System.Drawing.Size(112, 13)
        TRANSPORTISTAIDLabel.TabIndex = 0
        TRANSPORTISTAIDLabel.Text = "TRANSPORTISTAID:"
        '
        'NOMBRELabel1
        '
        NOMBRELabel1.AutoSize = True
        NOMBRELabel1.Location = New System.Drawing.Point(6, 44)
        NOMBRELabel1.Name = "NOMBRELabel1"
        NOMBRELabel1.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel1.TabIndex = 2
        NOMBRELabel1.Text = "NOMBRE:"
        '
        'APELLIDO1Label1
        '
        APELLIDO1Label1.AutoSize = True
        APELLIDO1Label1.Location = New System.Drawing.Point(6, 70)
        APELLIDO1Label1.Name = "APELLIDO1Label1"
        APELLIDO1Label1.Size = New System.Drawing.Size(68, 13)
        APELLIDO1Label1.TabIndex = 4
        APELLIDO1Label1.Text = "APELLIDO1:"
        '
        'APELLIDO2Label1
        '
        APELLIDO2Label1.AutoSize = True
        APELLIDO2Label1.Location = New System.Drawing.Point(6, 96)
        APELLIDO2Label1.Name = "APELLIDO2Label1"
        APELLIDO2Label1.Size = New System.Drawing.Size(68, 13)
        APELLIDO2Label1.TabIndex = 6
        APELLIDO2Label1.Text = "APELLIDO2:"
        '
        'DNILabel1
        '
        DNILabel1.AutoSize = True
        DNILabel1.Location = New System.Drawing.Point(6, 122)
        DNILabel1.Name = "DNILabel1"
        DNILabel1.Size = New System.Drawing.Size(29, 13)
        DNILabel1.TabIndex = 8
        DNILabel1.Text = "DNI:"
        '
        'BASTIDORLabel
        '
        BASTIDORLabel.AutoSize = True
        BASTIDORLabel.Location = New System.Drawing.Point(6, 148)
        BASTIDORLabel.Name = "BASTIDORLabel"
        BASTIDORLabel.Size = New System.Drawing.Size(65, 13)
        BASTIDORLabel.TabIndex = 10
        BASTIDORLabel.Text = "BASTIDOR:"
        '
        'CLIENTEIDLabel
        '
        CLIENTEIDLabel.AutoSize = True
        CLIENTEIDLabel.Location = New System.Drawing.Point(11, 23)
        CLIENTEIDLabel.Name = "CLIENTEIDLabel"
        CLIENTEIDLabel.Size = New System.Drawing.Size(66, 13)
        CLIENTEIDLabel.TabIndex = 0
        CLIENTEIDLabel.Text = "CLIENTEID:"
        '
        'EMPRESALabel
        '
        EMPRESALabel.AutoSize = True
        EMPRESALabel.Location = New System.Drawing.Point(11, 49)
        EMPRESALabel.Name = "EMPRESALabel"
        EMPRESALabel.Size = New System.Drawing.Size(62, 13)
        EMPRESALabel.TabIndex = 2
        EMPRESALabel.Text = "EMPRESA:"
        '
        'NOMBRELabel2
        '
        NOMBRELabel2.AutoSize = True
        NOMBRELabel2.Location = New System.Drawing.Point(11, 75)
        NOMBRELabel2.Name = "NOMBRELabel2"
        NOMBRELabel2.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel2.TabIndex = 4
        NOMBRELabel2.Text = "NOMBRE:"
        '
        'APELLIDO1Label2
        '
        APELLIDO1Label2.AutoSize = True
        APELLIDO1Label2.Location = New System.Drawing.Point(11, 101)
        APELLIDO1Label2.Name = "APELLIDO1Label2"
        APELLIDO1Label2.Size = New System.Drawing.Size(68, 13)
        APELLIDO1Label2.TabIndex = 6
        APELLIDO1Label2.Text = "APELLIDO1:"
        '
        'APELLIDO2Label2
        '
        APELLIDO2Label2.AutoSize = True
        APELLIDO2Label2.Location = New System.Drawing.Point(11, 127)
        APELLIDO2Label2.Name = "APELLIDO2Label2"
        APELLIDO2Label2.Size = New System.Drawing.Size(68, 13)
        APELLIDO2Label2.TabIndex = 8
        APELLIDO2Label2.Text = "APELLIDO2:"
        '
        'DNILabel2
        '
        DNILabel2.AutoSize = True
        DNILabel2.Location = New System.Drawing.Point(11, 153)
        DNILabel2.Name = "DNILabel2"
        DNILabel2.Size = New System.Drawing.Size(29, 13)
        DNILabel2.TabIndex = 10
        DNILabel2.Text = "DNI:"
        '
        'CIUDADLabel
        '
        CIUDADLabel.AutoSize = True
        CIUDADLabel.Location = New System.Drawing.Point(11, 179)
        CIUDADLabel.Name = "CIUDADLabel"
        CIUDADLabel.Size = New System.Drawing.Size(51, 13)
        CIUDADLabel.TabIndex = 12
        CIUDADLabel.Text = "CIUDAD:"
        '
        'DIRECCION1Label
        '
        DIRECCION1Label.AutoSize = True
        DIRECCION1Label.Location = New System.Drawing.Point(11, 205)
        DIRECCION1Label.Name = "DIRECCION1Label"
        DIRECCION1Label.Size = New System.Drawing.Size(75, 13)
        DIRECCION1Label.TabIndex = 14
        DIRECCION1Label.Text = "DIRECCION1:"
        '
        'DIRECCION2Label
        '
        DIRECCION2Label.AutoSize = True
        DIRECCION2Label.Location = New System.Drawing.Point(11, 231)
        DIRECCION2Label.Name = "DIRECCION2Label"
        DIRECCION2Label.Size = New System.Drawing.Size(75, 13)
        DIRECCION2Label.TabIndex = 16
        DIRECCION2Label.Text = "DIRECCION2:"
        '
        'FORMAPAGOIDLabel
        '
        FORMAPAGOIDLabel.AutoSize = True
        FORMAPAGOIDLabel.Location = New System.Drawing.Point(11, 257)
        FORMAPAGOIDLabel.Name = "FORMAPAGOIDLabel"
        FORMAPAGOIDLabel.Size = New System.Drawing.Size(89, 13)
        FORMAPAGOIDLabel.TabIndex = 18
        FORMAPAGOIDLabel.Text = "FORMAPAGOID:"
        '
        'COMERCIALIDLabel2
        '
        COMERCIALIDLabel2.AutoSize = True
        COMERCIALIDLabel2.Location = New System.Drawing.Point(11, 283)
        COMERCIALIDLabel2.Name = "COMERCIALIDLabel2"
        COMERCIALIDLabel2.Size = New System.Drawing.Size(83, 13)
        COMERCIALIDLabel2.TabIndex = 20
        COMERCIALIDLabel2.Text = "COMERCIALID:"
        '
        'CLIENTEIDLabel1
        '
        CLIENTEIDLabel1.AutoSize = True
        CLIENTEIDLabel1.Location = New System.Drawing.Point(18, 19)
        CLIENTEIDLabel1.Name = "CLIENTEIDLabel1"
        CLIENTEIDLabel1.Size = New System.Drawing.Size(66, 13)
        CLIENTEIDLabel1.TabIndex = 0
        CLIENTEIDLabel1.Text = "CLIENTEID:"
        '
        'EMPRESALabel1
        '
        EMPRESALabel1.AutoSize = True
        EMPRESALabel1.Location = New System.Drawing.Point(18, 45)
        EMPRESALabel1.Name = "EMPRESALabel1"
        EMPRESALabel1.Size = New System.Drawing.Size(62, 13)
        EMPRESALabel1.TabIndex = 2
        EMPRESALabel1.Text = "EMPRESA:"
        '
        'NOMBRELabel3
        '
        NOMBRELabel3.AutoSize = True
        NOMBRELabel3.Location = New System.Drawing.Point(18, 71)
        NOMBRELabel3.Name = "NOMBRELabel3"
        NOMBRELabel3.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel3.TabIndex = 4
        NOMBRELabel3.Text = "NOMBRE:"
        '
        'APELLIDO1Label3
        '
        APELLIDO1Label3.AutoSize = True
        APELLIDO1Label3.Location = New System.Drawing.Point(18, 97)
        APELLIDO1Label3.Name = "APELLIDO1Label3"
        APELLIDO1Label3.Size = New System.Drawing.Size(68, 13)
        APELLIDO1Label3.TabIndex = 6
        APELLIDO1Label3.Text = "APELLIDO1:"
        '
        'APELLIDO2Label3
        '
        APELLIDO2Label3.AutoSize = True
        APELLIDO2Label3.Location = New System.Drawing.Point(18, 123)
        APELLIDO2Label3.Name = "APELLIDO2Label3"
        APELLIDO2Label3.Size = New System.Drawing.Size(68, 13)
        APELLIDO2Label3.TabIndex = 8
        APELLIDO2Label3.Text = "APELLIDO2:"
        '
        'DNILabel3
        '
        DNILabel3.AutoSize = True
        DNILabel3.Location = New System.Drawing.Point(18, 149)
        DNILabel3.Name = "DNILabel3"
        DNILabel3.Size = New System.Drawing.Size(29, 13)
        DNILabel3.TabIndex = 10
        DNILabel3.Text = "DNI:"
        '
        'CIUDADLabel1
        '
        CIUDADLabel1.AutoSize = True
        CIUDADLabel1.Location = New System.Drawing.Point(18, 175)
        CIUDADLabel1.Name = "CIUDADLabel1"
        CIUDADLabel1.Size = New System.Drawing.Size(51, 13)
        CIUDADLabel1.TabIndex = 12
        CIUDADLabel1.Text = "CIUDAD:"
        '
        'DIRECCION1Label1
        '
        DIRECCION1Label1.AutoSize = True
        DIRECCION1Label1.Location = New System.Drawing.Point(18, 201)
        DIRECCION1Label1.Name = "DIRECCION1Label1"
        DIRECCION1Label1.Size = New System.Drawing.Size(75, 13)
        DIRECCION1Label1.TabIndex = 14
        DIRECCION1Label1.Text = "DIRECCION1:"
        '
        'DIRECCION2Label1
        '
        DIRECCION2Label1.AutoSize = True
        DIRECCION2Label1.Location = New System.Drawing.Point(18, 227)
        DIRECCION2Label1.Name = "DIRECCION2Label1"
        DIRECCION2Label1.Size = New System.Drawing.Size(75, 13)
        DIRECCION2Label1.TabIndex = 16
        DIRECCION2Label1.Text = "DIRECCION2:"
        '
        'FORMAPAGOIDLabel1
        '
        FORMAPAGOIDLabel1.AutoSize = True
        FORMAPAGOIDLabel1.Location = New System.Drawing.Point(18, 253)
        FORMAPAGOIDLabel1.Name = "FORMAPAGOIDLabel1"
        FORMAPAGOIDLabel1.Size = New System.Drawing.Size(89, 13)
        FORMAPAGOIDLabel1.TabIndex = 18
        FORMAPAGOIDLabel1.Text = "FORMAPAGOID:"
        '
        'COMERCIALIDLabel1
        '
        COMERCIALIDLabel1.AutoSize = True
        COMERCIALIDLabel1.Location = New System.Drawing.Point(18, 279)
        COMERCIALIDLabel1.Name = "COMERCIALIDLabel1"
        COMERCIALIDLabel1.Size = New System.Drawing.Size(83, 13)
        COMERCIALIDLabel1.TabIndex = 20
        COMERCIALIDLabel1.Text = "COMERCIALID:"
        '
        'ArticuloIDLabel
        '
        ArticuloIDLabel.AutoSize = True
        ArticuloIDLabel.Location = New System.Drawing.Point(21, 19)
        ArticuloIDLabel.Name = "ArticuloIDLabel"
        ArticuloIDLabel.Size = New System.Drawing.Size(59, 13)
        ArticuloIDLabel.TabIndex = 0
        ArticuloIDLabel.Text = "Articulo ID:"
        '
        'CategoriaIDLabel
        '
        CategoriaIDLabel.AutoSize = True
        CategoriaIDLabel.Location = New System.Drawing.Point(21, 45)
        CategoriaIDLabel.Name = "CategoriaIDLabel"
        CategoriaIDLabel.Size = New System.Drawing.Size(69, 13)
        CategoriaIDLabel.TabIndex = 2
        CategoriaIDLabel.Text = "Categoria ID:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(21, 71)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'PrVentaLabel
        '
        PrVentaLabel.AutoSize = True
        PrVentaLabel.Location = New System.Drawing.Point(21, 97)
        PrVentaLabel.Name = "PrVentaLabel"
        PrVentaLabel.Size = New System.Drawing.Size(51, 13)
        PrVentaLabel.TabIndex = 6
        PrVentaLabel.Text = "Pr Venta:"
        '
        'PrCompraLabel
        '
        PrCompraLabel.AutoSize = True
        PrCompraLabel.Location = New System.Drawing.Point(21, 123)
        PrCompraLabel.Name = "PrCompraLabel"
        PrCompraLabel.Size = New System.Drawing.Size(59, 13)
        PrCompraLabel.TabIndex = 8
        PrCompraLabel.Text = "Pr Compra:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(21, 149)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 10
        StockLabel.Text = "Stock:"
        '
        'StockMinimoLabel
        '
        StockMinimoLabel.AutoSize = True
        StockMinimoLabel.Location = New System.Drawing.Point(21, 175)
        StockMinimoLabel.Name = "StockMinimoLabel"
        StockMinimoLabel.Size = New System.Drawing.Size(74, 13)
        StockMinimoLabel.TabIndex = 12
        StockMinimoLabel.Text = "Stock Minimo:"
        '
        'UnidadIDLabel
        '
        UnidadIDLabel.AutoSize = True
        UnidadIDLabel.Location = New System.Drawing.Point(21, 201)
        UnidadIDLabel.Name = "UnidadIDLabel"
        UnidadIDLabel.Size = New System.Drawing.Size(58, 13)
        UnidadIDLabel.TabIndex = 14
        UnidadIDLabel.Text = "Unidad ID:"
        '
        'lblFoto
        '
        lblFoto.AutoSize = True
        lblFoto.Location = New System.Drawing.Point(21, 227)
        lblFoto.Name = "lblFoto"
        lblFoto.Size = New System.Drawing.Size(31, 13)
        lblFoto.TabIndex = 16
        lblFoto.Text = "Foto:"
        '
        'ChargeneticDataSet
        '
        Me.ChargeneticDataSet.DataSetName = "ChargeneticDataSet"
        Me.ChargeneticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComercialBindingSource
        '
        Me.ComercialBindingSource.DataMember = "Comercial"
        Me.ComercialBindingSource.DataSource = Me.ChargeneticDataSet
        '
        'ComercialTableAdapter
        '
        Me.ComercialTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlbaranTableAdapter = Nothing
        Me.TableAdapterManager.ArticuloTableAdapter = Me.ArticuloTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Categorio_articuloTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.ComercialTableAdapter = Me.ComercialTableAdapter
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.FormapagoTableAdapter = Nothing
        Me.TableAdapterManager.LineaTableAdapter = Nothing
        Me.TableAdapterManager.TransportistaTableAdapter = Me.TransportistaTableAdapter
        Me.TableAdapterManager.UnidadTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Reto.ChargeneticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArticuloTableAdapter
        '
        Me.ArticuloTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TransportistaTableAdapter
        '
        Me.TransportistaTableAdapter.ClearBeforeFill = True
        '
        'CTCABindingNavigator
        '
        Me.CTCABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CTCABindingNavigator.BindingSource = Me.ComercialBindingSource
        Me.CTCABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CTCABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CTCABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ComercialBindingNavigatorSaveItem})
        Me.CTCABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CTCABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CTCABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CTCABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CTCABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CTCABindingNavigator.Name = "CTCABindingNavigator"
        Me.CTCABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CTCABindingNavigator.Size = New System.Drawing.Size(895, 25)
        Me.CTCABindingNavigator.TabIndex = 0
        Me.CTCABindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ComercialBindingNavigatorSaveItem
        '
        Me.ComercialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ComercialBindingNavigatorSaveItem.Image = CType(resources.GetObject("ComercialBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ComercialBindingNavigatorSaveItem.Name = "ComercialBindingNavigatorSaveItem"
        Me.ComercialBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ComercialBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TransportistaBindingSource
        '
        Me.TransportistaBindingSource.DataMember = "Transportista"
        Me.TransportistaBindingSource.DataSource = Me.ChargeneticDataSet
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.ChargeneticDataSet
        '
        'ArticuloBindingSource
        '
        Me.ArticuloBindingSource.DataMember = "Articulo"
        Me.ArticuloBindingSource.DataSource = Me.ChargeneticDataSet
        '
        'pnlComercial
        '
        Me.pnlComercial.Controls.Add(lblComercialID)
        Me.pnlComercial.Controls.Add(Me.txtComercialID)
        Me.pnlComercial.Controls.Add(lblNombreComercial)
        Me.pnlComercial.Controls.Add(Me.txtNombreComercial)
        Me.pnlComercial.Controls.Add(APELLIDO1Label)
        Me.pnlComercial.Controls.Add(Me.APELLIDO1TextBox)
        Me.pnlComercial.Controls.Add(APELLIDO2Label)
        Me.pnlComercial.Controls.Add(Me.APELLIDO2TextBox)
        Me.pnlComercial.Controls.Add(DNILabel)
        Me.pnlComercial.Controls.Add(Me.DNITextBox)
        Me.pnlComercial.Controls.Add(TELEFONOLabel)
        Me.pnlComercial.Controls.Add(Me.TELEFONOTextBox)
        Me.pnlComercial.Controls.Add(DIRECCIONLabel)
        Me.pnlComercial.Controls.Add(Me.DIRECCIONTextBox)
        Me.pnlComercial.Location = New System.Drawing.Point(1, 33)
        Me.pnlComercial.Name = "pnlComercial"
        Me.pnlComercial.Size = New System.Drawing.Size(200, 227)
        Me.pnlComercial.TabIndex = 67
        Me.pnlComercial.Visible = False
        '
        'txtComercialID
        '
        Me.txtComercialID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComercialBindingSource, "COMERCIALID", True))
        Me.txtComercialID.Location = New System.Drawing.Point(98, 15)
        Me.txtComercialID.Name = "txtComercialID"
        Me.txtComercialID.ReadOnly = True
        Me.txtComercialID.Size = New System.Drawing.Size(100, 20)
        Me.txtComercialID.TabIndex = 1
        '
        'txtNombreComercial
        '
        Me.txtNombreComercial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComercialBindingSource, "NOMBRE", True))
        Me.txtNombreComercial.Location = New System.Drawing.Point(98, 41)
        Me.txtNombreComercial.Name = "txtNombreComercial"
        Me.txtNombreComercial.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreComercial.TabIndex = 3
        '
        'APELLIDO1TextBox
        '
        Me.APELLIDO1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComercialBindingSource, "APELLIDO1", True))
        Me.APELLIDO1TextBox.Location = New System.Drawing.Point(98, 67)
        Me.APELLIDO1TextBox.Name = "APELLIDO1TextBox"
        Me.APELLIDO1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDO1TextBox.TabIndex = 5
        '
        'APELLIDO2TextBox
        '
        Me.APELLIDO2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComercialBindingSource, "APELLIDO2", True))
        Me.APELLIDO2TextBox.Location = New System.Drawing.Point(98, 93)
        Me.APELLIDO2TextBox.Name = "APELLIDO2TextBox"
        Me.APELLIDO2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDO2TextBox.TabIndex = 7
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComercialBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(98, 119)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(100, 20)
        Me.DNITextBox.TabIndex = 9
        '
        'TELEFONOTextBox
        '
        Me.TELEFONOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComercialBindingSource, "TELEFONO", True))
        Me.TELEFONOTextBox.Location = New System.Drawing.Point(98, 145)
        Me.TELEFONOTextBox.Name = "TELEFONOTextBox"
        Me.TELEFONOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TELEFONOTextBox.TabIndex = 11
        '
        'DIRECCIONTextBox
        '
        Me.DIRECCIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComercialBindingSource, "DIRECCION", True))
        Me.DIRECCIONTextBox.Location = New System.Drawing.Point(98, 171)
        Me.DIRECCIONTextBox.Name = "DIRECCIONTextBox"
        Me.DIRECCIONTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DIRECCIONTextBox.TabIndex = 13
        '
        'pnlTransportista
        '
        Me.pnlTransportista.Controls.Add(Me.Panel2)
        Me.pnlTransportista.Controls.Add(TRANSPORTISTAIDLabel)
        Me.pnlTransportista.Controls.Add(Me.TRANSPORTISTAIDTextBox)
        Me.pnlTransportista.Controls.Add(NOMBRELabel1)
        Me.pnlTransportista.Controls.Add(Me.NOMBRETextBox1)
        Me.pnlTransportista.Controls.Add(APELLIDO1Label1)
        Me.pnlTransportista.Controls.Add(Me.APELLIDO1TextBox1)
        Me.pnlTransportista.Controls.Add(APELLIDO2Label1)
        Me.pnlTransportista.Controls.Add(Me.APELLIDO2TextBox1)
        Me.pnlTransportista.Controls.Add(DNILabel1)
        Me.pnlTransportista.Controls.Add(Me.DNITextBox1)
        Me.pnlTransportista.Controls.Add(BASTIDORLabel)
        Me.pnlTransportista.Controls.Add(Me.BASTIDORTextBox)
        Me.pnlTransportista.Location = New System.Drawing.Point(203, 33)
        Me.pnlTransportista.Name = "pnlTransportista"
        Me.pnlTransportista.Size = New System.Drawing.Size(227, 227)
        Me.pnlTransportista.TabIndex = 68
        Me.pnlTransportista.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(CLIENTEIDLabel)
        Me.Panel2.Controls.Add(Me.CLIENTEIDTextBox)
        Me.Panel2.Controls.Add(EMPRESALabel)
        Me.Panel2.Controls.Add(Me.EMPRESATextBox)
        Me.Panel2.Controls.Add(NOMBRELabel2)
        Me.Panel2.Controls.Add(Me.NOMBRETextBox2)
        Me.Panel2.Controls.Add(APELLIDO1Label2)
        Me.Panel2.Controls.Add(Me.APELLIDO1TextBox2)
        Me.Panel2.Controls.Add(APELLIDO2Label2)
        Me.Panel2.Controls.Add(Me.APELLIDO2TextBox2)
        Me.Panel2.Controls.Add(DNILabel2)
        Me.Panel2.Controls.Add(Me.DNITextBox2)
        Me.Panel2.Controls.Add(CIUDADLabel)
        Me.Panel2.Controls.Add(Me.CIUDADTextBox)
        Me.Panel2.Controls.Add(DIRECCION1Label)
        Me.Panel2.Controls.Add(Me.DIRECCION1TextBox)
        Me.Panel2.Controls.Add(DIRECCION2Label)
        Me.Panel2.Controls.Add(Me.DIRECCION2TextBox)
        Me.Panel2.Controls.Add(FORMAPAGOIDLabel)
        Me.Panel2.Controls.Add(Me.FORMAPAGOIDTextBox)
        Me.Panel2.Controls.Add(COMERCIALIDLabel2)
        Me.Panel2.Controls.Add(Me.COMERCIALIDTextBox2)
        Me.Panel2.Location = New System.Drawing.Point(230, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 320)
        Me.Panel2.TabIndex = 69
        '
        'CLIENTEIDTextBox
        '
        Me.CLIENTEIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CLIENTEID", True))
        Me.CLIENTEIDTextBox.Location = New System.Drawing.Point(106, 20)
        Me.CLIENTEIDTextBox.Name = "CLIENTEIDTextBox"
        Me.CLIENTEIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CLIENTEIDTextBox.TabIndex = 1
        '
        'EMPRESATextBox
        '
        Me.EMPRESATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "EMPRESA", True))
        Me.EMPRESATextBox.Location = New System.Drawing.Point(106, 46)
        Me.EMPRESATextBox.Name = "EMPRESATextBox"
        Me.EMPRESATextBox.Size = New System.Drawing.Size(100, 20)
        Me.EMPRESATextBox.TabIndex = 3
        '
        'NOMBRETextBox2
        '
        Me.NOMBRETextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox2.Location = New System.Drawing.Point(106, 72)
        Me.NOMBRETextBox2.Name = "NOMBRETextBox2"
        Me.NOMBRETextBox2.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRETextBox2.TabIndex = 5
        '
        'APELLIDO1TextBox2
        '
        Me.APELLIDO1TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "APELLIDO1", True))
        Me.APELLIDO1TextBox2.Location = New System.Drawing.Point(106, 98)
        Me.APELLIDO1TextBox2.Name = "APELLIDO1TextBox2"
        Me.APELLIDO1TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDO1TextBox2.TabIndex = 7
        '
        'APELLIDO2TextBox2
        '
        Me.APELLIDO2TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "APELLIDO2", True))
        Me.APELLIDO2TextBox2.Location = New System.Drawing.Point(106, 124)
        Me.APELLIDO2TextBox2.Name = "APELLIDO2TextBox2"
        Me.APELLIDO2TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDO2TextBox2.TabIndex = 9
        '
        'DNITextBox2
        '
        Me.DNITextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DNI", True))
        Me.DNITextBox2.Location = New System.Drawing.Point(106, 150)
        Me.DNITextBox2.Name = "DNITextBox2"
        Me.DNITextBox2.Size = New System.Drawing.Size(100, 20)
        Me.DNITextBox2.TabIndex = 11
        '
        'CIUDADTextBox
        '
        Me.CIUDADTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CIUDAD", True))
        Me.CIUDADTextBox.Location = New System.Drawing.Point(106, 176)
        Me.CIUDADTextBox.Name = "CIUDADTextBox"
        Me.CIUDADTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CIUDADTextBox.TabIndex = 13
        '
        'DIRECCION1TextBox
        '
        Me.DIRECCION1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DIRECCION1", True))
        Me.DIRECCION1TextBox.Location = New System.Drawing.Point(106, 202)
        Me.DIRECCION1TextBox.Name = "DIRECCION1TextBox"
        Me.DIRECCION1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.DIRECCION1TextBox.TabIndex = 15
        '
        'DIRECCION2TextBox
        '
        Me.DIRECCION2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DIRECCION2", True))
        Me.DIRECCION2TextBox.Location = New System.Drawing.Point(106, 228)
        Me.DIRECCION2TextBox.Name = "DIRECCION2TextBox"
        Me.DIRECCION2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.DIRECCION2TextBox.TabIndex = 17
        '
        'FORMAPAGOIDTextBox
        '
        Me.FORMAPAGOIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "FORMAPAGOID", True))
        Me.FORMAPAGOIDTextBox.Location = New System.Drawing.Point(106, 254)
        Me.FORMAPAGOIDTextBox.Name = "FORMAPAGOIDTextBox"
        Me.FORMAPAGOIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FORMAPAGOIDTextBox.TabIndex = 19
        '
        'COMERCIALIDTextBox2
        '
        Me.COMERCIALIDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "COMERCIALID", True))
        Me.COMERCIALIDTextBox2.Location = New System.Drawing.Point(106, 280)
        Me.COMERCIALIDTextBox2.Name = "COMERCIALIDTextBox2"
        Me.COMERCIALIDTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.COMERCIALIDTextBox2.TabIndex = 21
        '
        'TRANSPORTISTAIDTextBox
        '
        Me.TRANSPORTISTAIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportistaBindingSource, "TRANSPORTISTAID", True))
        Me.TRANSPORTISTAIDTextBox.Location = New System.Drawing.Point(124, 15)
        Me.TRANSPORTISTAIDTextBox.Name = "TRANSPORTISTAIDTextBox"
        Me.TRANSPORTISTAIDTextBox.ReadOnly = True
        Me.TRANSPORTISTAIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TRANSPORTISTAIDTextBox.TabIndex = 1
        '
        'NOMBRETextBox1
        '
        Me.NOMBRETextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportistaBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox1.Location = New System.Drawing.Point(124, 41)
        Me.NOMBRETextBox1.Name = "NOMBRETextBox1"
        Me.NOMBRETextBox1.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRETextBox1.TabIndex = 3
        '
        'APELLIDO1TextBox1
        '
        Me.APELLIDO1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportistaBindingSource, "APELLIDO1", True))
        Me.APELLIDO1TextBox1.Location = New System.Drawing.Point(124, 67)
        Me.APELLIDO1TextBox1.Name = "APELLIDO1TextBox1"
        Me.APELLIDO1TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDO1TextBox1.TabIndex = 5
        '
        'APELLIDO2TextBox1
        '
        Me.APELLIDO2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportistaBindingSource, "APELLIDO2", True))
        Me.APELLIDO2TextBox1.Location = New System.Drawing.Point(124, 93)
        Me.APELLIDO2TextBox1.Name = "APELLIDO2TextBox1"
        Me.APELLIDO2TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDO2TextBox1.TabIndex = 7
        '
        'DNITextBox1
        '
        Me.DNITextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportistaBindingSource, "DNI", True))
        Me.DNITextBox1.Location = New System.Drawing.Point(124, 119)
        Me.DNITextBox1.Name = "DNITextBox1"
        Me.DNITextBox1.Size = New System.Drawing.Size(100, 20)
        Me.DNITextBox1.TabIndex = 9
        '
        'BASTIDORTextBox
        '
        Me.BASTIDORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportistaBindingSource, "BASTIDOR", True))
        Me.BASTIDORTextBox.Location = New System.Drawing.Point(124, 145)
        Me.BASTIDORTextBox.Name = "BASTIDORTextBox"
        Me.BASTIDORTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BASTIDORTextBox.TabIndex = 11
        '
        'pnlCliente
        '
        Me.pnlCliente.Controls.Add(CLIENTEIDLabel1)
        Me.pnlCliente.Controls.Add(Me.CLIENTEIDTextBox1)
        Me.pnlCliente.Controls.Add(EMPRESALabel1)
        Me.pnlCliente.Controls.Add(Me.EMPRESATextBox1)
        Me.pnlCliente.Controls.Add(NOMBRELabel3)
        Me.pnlCliente.Controls.Add(Me.NOMBRETextBox3)
        Me.pnlCliente.Controls.Add(APELLIDO1Label3)
        Me.pnlCliente.Controls.Add(Me.APELLIDO1TextBox3)
        Me.pnlCliente.Controls.Add(APELLIDO2Label3)
        Me.pnlCliente.Controls.Add(Me.APELLIDO2TextBox3)
        Me.pnlCliente.Controls.Add(DNILabel3)
        Me.pnlCliente.Controls.Add(Me.DNITextBox3)
        Me.pnlCliente.Controls.Add(CIUDADLabel1)
        Me.pnlCliente.Controls.Add(Me.CIUDADTextBox1)
        Me.pnlCliente.Controls.Add(DIRECCION1Label1)
        Me.pnlCliente.Controls.Add(Me.DIRECCION1TextBox1)
        Me.pnlCliente.Controls.Add(DIRECCION2Label1)
        Me.pnlCliente.Controls.Add(Me.DIRECCION2TextBox1)
        Me.pnlCliente.Controls.Add(FORMAPAGOIDLabel1)
        Me.pnlCliente.Controls.Add(Me.FORMAPAGOIDTextBox1)
        Me.pnlCliente.Controls.Add(COMERCIALIDLabel1)
        Me.pnlCliente.Controls.Add(Me.COMERCIALIDTextBox1)
        Me.pnlCliente.Location = New System.Drawing.Point(433, 33)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(233, 316)
        Me.pnlCliente.TabIndex = 69
        Me.pnlCliente.Visible = False
        '
        'CLIENTEIDTextBox1
        '
        Me.CLIENTEIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CLIENTEID", True))
        Me.CLIENTEIDTextBox1.Location = New System.Drawing.Point(113, 16)
        Me.CLIENTEIDTextBox1.Name = "CLIENTEIDTextBox1"
        Me.CLIENTEIDTextBox1.ReadOnly = True
        Me.CLIENTEIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CLIENTEIDTextBox1.TabIndex = 1
        '
        'EMPRESATextBox1
        '
        Me.EMPRESATextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "EMPRESA", True))
        Me.EMPRESATextBox1.Location = New System.Drawing.Point(113, 42)
        Me.EMPRESATextBox1.Name = "EMPRESATextBox1"
        Me.EMPRESATextBox1.Size = New System.Drawing.Size(100, 20)
        Me.EMPRESATextBox1.TabIndex = 3
        '
        'NOMBRETextBox3
        '
        Me.NOMBRETextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "NOMBRE", True))
        Me.NOMBRETextBox3.Location = New System.Drawing.Point(113, 68)
        Me.NOMBRETextBox3.Name = "NOMBRETextBox3"
        Me.NOMBRETextBox3.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRETextBox3.TabIndex = 5
        '
        'APELLIDO1TextBox3
        '
        Me.APELLIDO1TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "APELLIDO1", True))
        Me.APELLIDO1TextBox3.Location = New System.Drawing.Point(113, 94)
        Me.APELLIDO1TextBox3.Name = "APELLIDO1TextBox3"
        Me.APELLIDO1TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDO1TextBox3.TabIndex = 7
        '
        'APELLIDO2TextBox3
        '
        Me.APELLIDO2TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "APELLIDO2", True))
        Me.APELLIDO2TextBox3.Location = New System.Drawing.Point(113, 120)
        Me.APELLIDO2TextBox3.Name = "APELLIDO2TextBox3"
        Me.APELLIDO2TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDO2TextBox3.TabIndex = 9
        '
        'DNITextBox3
        '
        Me.DNITextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DNI", True))
        Me.DNITextBox3.Location = New System.Drawing.Point(113, 146)
        Me.DNITextBox3.Name = "DNITextBox3"
        Me.DNITextBox3.Size = New System.Drawing.Size(100, 20)
        Me.DNITextBox3.TabIndex = 11
        '
        'CIUDADTextBox1
        '
        Me.CIUDADTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CIUDAD", True))
        Me.CIUDADTextBox1.Location = New System.Drawing.Point(113, 172)
        Me.CIUDADTextBox1.Name = "CIUDADTextBox1"
        Me.CIUDADTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CIUDADTextBox1.TabIndex = 13
        '
        'DIRECCION1TextBox1
        '
        Me.DIRECCION1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DIRECCION1", True))
        Me.DIRECCION1TextBox1.Location = New System.Drawing.Point(113, 198)
        Me.DIRECCION1TextBox1.Name = "DIRECCION1TextBox1"
        Me.DIRECCION1TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.DIRECCION1TextBox1.TabIndex = 15
        '
        'DIRECCION2TextBox1
        '
        Me.DIRECCION2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DIRECCION2", True))
        Me.DIRECCION2TextBox1.Location = New System.Drawing.Point(113, 224)
        Me.DIRECCION2TextBox1.Name = "DIRECCION2TextBox1"
        Me.DIRECCION2TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.DIRECCION2TextBox1.TabIndex = 17
        '
        'FORMAPAGOIDTextBox1
        '
        Me.FORMAPAGOIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "FORMAPAGOID", True))
        Me.FORMAPAGOIDTextBox1.Location = New System.Drawing.Point(113, 250)
        Me.FORMAPAGOIDTextBox1.Name = "FORMAPAGOIDTextBox1"
        Me.FORMAPAGOIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.FORMAPAGOIDTextBox1.TabIndex = 19
        '
        'COMERCIALIDTextBox1
        '
        Me.COMERCIALIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "COMERCIALID", True))
        Me.COMERCIALIDTextBox1.Location = New System.Drawing.Point(113, 276)
        Me.COMERCIALIDTextBox1.Name = "COMERCIALIDTextBox1"
        Me.COMERCIALIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.COMERCIALIDTextBox1.TabIndex = 21
        '
        'pnlArticulo
        '
        Me.pnlArticulo.Controls.Add(Me.pcbFoto)
        Me.pnlArticulo.Controls.Add(ArticuloIDLabel)
        Me.pnlArticulo.Controls.Add(Me.ArticuloIDTextBox)
        Me.pnlArticulo.Controls.Add(CategoriaIDLabel)
        Me.pnlArticulo.Controls.Add(Me.CategoriaIDTextBox)
        Me.pnlArticulo.Controls.Add(DescripcionLabel)
        Me.pnlArticulo.Controls.Add(Me.DescripcionTextBox)
        Me.pnlArticulo.Controls.Add(PrVentaLabel)
        Me.pnlArticulo.Controls.Add(Me.PrVentaTextBox)
        Me.pnlArticulo.Controls.Add(PrCompraLabel)
        Me.pnlArticulo.Controls.Add(Me.PrCompraTextBox)
        Me.pnlArticulo.Controls.Add(StockLabel)
        Me.pnlArticulo.Controls.Add(Me.StockTextBox)
        Me.pnlArticulo.Controls.Add(StockMinimoLabel)
        Me.pnlArticulo.Controls.Add(Me.StockMinimoTextBox)
        Me.pnlArticulo.Controls.Add(UnidadIDLabel)
        Me.pnlArticulo.Controls.Add(Me.UnidadIDTextBox)
        Me.pnlArticulo.Controls.Add(lblFoto)
        Me.pnlArticulo.Controls.Add(Me.txtFoto)
        Me.pnlArticulo.Location = New System.Drawing.Point(672, 33)
        Me.pnlArticulo.Name = "pnlArticulo"
        Me.pnlArticulo.Size = New System.Drawing.Size(216, 416)
        Me.pnlArticulo.TabIndex = 70
        Me.pnlArticulo.Visible = False
        '
        'ArticuloIDTextBox
        '
        Me.ArticuloIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "ArticuloID", True))
        Me.ArticuloIDTextBox.Location = New System.Drawing.Point(101, 16)
        Me.ArticuloIDTextBox.Name = "ArticuloIDTextBox"
        Me.ArticuloIDTextBox.ReadOnly = True
        Me.ArticuloIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ArticuloIDTextBox.TabIndex = 1
        '
        'CategoriaIDTextBox
        '
        Me.CategoriaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "CategoriaID", True))
        Me.CategoriaIDTextBox.Location = New System.Drawing.Point(101, 42)
        Me.CategoriaIDTextBox.Name = "CategoriaIDTextBox"
        Me.CategoriaIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoriaIDTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(101, 68)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'PrVentaTextBox
        '
        Me.PrVentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "PrVenta", True))
        Me.PrVentaTextBox.Location = New System.Drawing.Point(101, 94)
        Me.PrVentaTextBox.Name = "PrVentaTextBox"
        Me.PrVentaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrVentaTextBox.TabIndex = 7
        '
        'PrCompraTextBox
        '
        Me.PrCompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "PrCompra", True))
        Me.PrCompraTextBox.Location = New System.Drawing.Point(101, 120)
        Me.PrCompraTextBox.Name = "PrCompraTextBox"
        Me.PrCompraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrCompraTextBox.TabIndex = 9
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(101, 146)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StockTextBox.TabIndex = 11
        '
        'StockMinimoTextBox
        '
        Me.StockMinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "StockMinimo", True))
        Me.StockMinimoTextBox.Location = New System.Drawing.Point(101, 172)
        Me.StockMinimoTextBox.Name = "StockMinimoTextBox"
        Me.StockMinimoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StockMinimoTextBox.TabIndex = 13
        '
        'UnidadIDTextBox
        '
        Me.UnidadIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "UnidadID", True))
        Me.UnidadIDTextBox.Location = New System.Drawing.Point(101, 198)
        Me.UnidadIDTextBox.Name = "UnidadIDTextBox"
        Me.UnidadIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UnidadIDTextBox.TabIndex = 15
        '
        'txtFoto
        '
        Me.txtFoto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticuloBindingSource, "Foto", True))
        Me.txtFoto.Location = New System.Drawing.Point(101, 224)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(100, 20)
        Me.txtFoto.TabIndex = 17
        '
        'pcbFoto
        '
        Me.pcbFoto.Location = New System.Drawing.Point(5, 250)
        Me.pcbFoto.Name = "pcbFoto"
        Me.pcbFoto.Size = New System.Drawing.Size(208, 163)
        Me.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFoto.TabIndex = 18
        Me.pcbFoto.TabStop = False
        '
        'frmGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 450)
        Me.Controls.Add(Me.pnlArticulo)
        Me.Controls.Add(Me.pnlCliente)
        Me.Controls.Add(Me.pnlTransportista)
        Me.Controls.Add(Me.pnlComercial)
        Me.Controls.Add(Me.CTCABindingNavigator)
        Me.Name = "frmGestion"
        Me.Text = "Gestión de Tablas"
        CType(Me.ChargeneticDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComercialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTCABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTCABindingNavigator.ResumeLayout(False)
        Me.CTCABindingNavigator.PerformLayout()
        CType(Me.TransportistaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlComercial.ResumeLayout(False)
        Me.pnlComercial.PerformLayout()
        Me.pnlTransportista.ResumeLayout(False)
        Me.pnlTransportista.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        Me.pnlArticulo.ResumeLayout(False)
        Me.pnlArticulo.PerformLayout()
        CType(Me.pcbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChargeneticDataSet As ChargeneticDataSet
    Friend WithEvents ComercialBindingSource As BindingSource
    Friend WithEvents ComercialTableAdapter As ChargeneticDataSetTableAdapters.ComercialTableAdapter
    Friend WithEvents TableAdapterManager As ChargeneticDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CTCABindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ComercialBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TransportistaTableAdapter As ChargeneticDataSetTableAdapters.TransportistaTableAdapter
    Friend WithEvents TransportistaBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As ChargeneticDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ArticuloTableAdapter As ChargeneticDataSetTableAdapters.ArticuloTableAdapter
    Friend WithEvents ArticuloBindingSource As BindingSource
    Friend WithEvents pnlComercial As Panel
    Friend WithEvents txtComercialID As TextBox
    Friend WithEvents txtNombreComercial As TextBox
    Friend WithEvents APELLIDO1TextBox As TextBox
    Friend WithEvents APELLIDO2TextBox As TextBox
    Friend WithEvents DNITextBox As TextBox
    Friend WithEvents TELEFONOTextBox As TextBox
    Friend WithEvents DIRECCIONTextBox As TextBox
    Friend WithEvents pnlTransportista As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CLIENTEIDTextBox As TextBox
    Friend WithEvents EMPRESATextBox As TextBox
    Friend WithEvents NOMBRETextBox2 As TextBox
    Friend WithEvents APELLIDO1TextBox2 As TextBox
    Friend WithEvents APELLIDO2TextBox2 As TextBox
    Friend WithEvents DNITextBox2 As TextBox
    Friend WithEvents CIUDADTextBox As TextBox
    Friend WithEvents DIRECCION1TextBox As TextBox
    Friend WithEvents DIRECCION2TextBox As TextBox
    Friend WithEvents FORMAPAGOIDTextBox As TextBox
    Friend WithEvents COMERCIALIDTextBox2 As TextBox
    Friend WithEvents TRANSPORTISTAIDTextBox As TextBox
    Friend WithEvents NOMBRETextBox1 As TextBox
    Friend WithEvents APELLIDO1TextBox1 As TextBox
    Friend WithEvents APELLIDO2TextBox1 As TextBox
    Friend WithEvents DNITextBox1 As TextBox
    Friend WithEvents BASTIDORTextBox As TextBox
    Friend WithEvents pnlCliente As Panel
    Friend WithEvents CLIENTEIDTextBox1 As TextBox
    Friend WithEvents EMPRESATextBox1 As TextBox
    Friend WithEvents NOMBRETextBox3 As TextBox
    Friend WithEvents APELLIDO1TextBox3 As TextBox
    Friend WithEvents APELLIDO2TextBox3 As TextBox
    Friend WithEvents DNITextBox3 As TextBox
    Friend WithEvents CIUDADTextBox1 As TextBox
    Friend WithEvents DIRECCION1TextBox1 As TextBox
    Friend WithEvents DIRECCION2TextBox1 As TextBox
    Friend WithEvents FORMAPAGOIDTextBox1 As TextBox
    Friend WithEvents COMERCIALIDTextBox1 As TextBox
    Friend WithEvents pnlArticulo As Panel
    Friend WithEvents ArticuloIDTextBox As TextBox
    Friend WithEvents CategoriaIDTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PrVentaTextBox As TextBox
    Friend WithEvents PrCompraTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents StockMinimoTextBox As TextBox
    Friend WithEvents UnidadIDTextBox As TextBox
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents pcbFoto As PictureBox
End Class
