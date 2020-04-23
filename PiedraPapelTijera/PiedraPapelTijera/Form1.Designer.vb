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
        Me.pcbPapel = New System.Windows.Forms.PictureBox()
        Me.pcbPC = New System.Windows.Forms.PictureBox()
        Me.pcbTijera = New System.Windows.Forms.PictureBox()
        Me.pcbPiedra = New System.Windows.Forms.PictureBox()
        Me.txtPuntosUS = New System.Windows.Forms.TextBox()
        Me.txtPuntosPC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pcbPapel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbTijera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPiedra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbPapel
        '
        Me.pcbPapel.Image = CType(resources.GetObject("pcbPapel.Image"), System.Drawing.Image)
        Me.pcbPapel.Location = New System.Drawing.Point(189, 46)
        Me.pcbPapel.Name = "pcbPapel"
        Me.pcbPapel.Size = New System.Drawing.Size(156, 150)
        Me.pcbPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPapel.TabIndex = 0
        Me.pcbPapel.TabStop = False
        Me.pcbPapel.Tag = "2"
        '
        'pcbPC
        '
        Me.pcbPC.Location = New System.Drawing.Point(584, 46)
        Me.pcbPC.Name = "pcbPC"
        Me.pcbPC.Size = New System.Drawing.Size(156, 150)
        Me.pcbPC.TabIndex = 1
        Me.pcbPC.TabStop = False
        '
        'pcbTijera
        '
        Me.pcbTijera.Image = CType(resources.GetObject("pcbTijera.Image"), System.Drawing.Image)
        Me.pcbTijera.Location = New System.Drawing.Point(367, 46)
        Me.pcbTijera.Name = "pcbTijera"
        Me.pcbTijera.Size = New System.Drawing.Size(156, 150)
        Me.pcbTijera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbTijera.TabIndex = 2
        Me.pcbTijera.TabStop = False
        Me.pcbTijera.Tag = "3"
        '
        'pcbPiedra
        '
        Me.pcbPiedra.Image = CType(resources.GetObject("pcbPiedra.Image"), System.Drawing.Image)
        Me.pcbPiedra.Location = New System.Drawing.Point(12, 46)
        Me.pcbPiedra.Name = "pcbPiedra"
        Me.pcbPiedra.Size = New System.Drawing.Size(156, 150)
        Me.pcbPiedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbPiedra.TabIndex = 3
        Me.pcbPiedra.TabStop = False
        Me.pcbPiedra.Tag = "1"
        '
        'txtPuntosUS
        '
        Me.txtPuntosUS.Location = New System.Drawing.Point(395, 217)
        Me.txtPuntosUS.Name = "txtPuntosUS"
        Me.txtPuntosUS.Size = New System.Drawing.Size(100, 20)
        Me.txtPuntosUS.TabIndex = 5
        '
        'txtPuntosPC
        '
        Me.txtPuntosPC.Location = New System.Drawing.Point(613, 217)
        Me.txtPuntosPC.Name = "txtPuntosPC"
        Me.txtPuntosPC.Size = New System.Drawing.Size(100, 20)
        Me.txtPuntosPC.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(530, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Puntos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPuntosPC)
        Me.Controls.Add(Me.txtPuntosUS)
        Me.Controls.Add(Me.pcbPiedra)
        Me.Controls.Add(Me.pcbTijera)
        Me.Controls.Add(Me.pcbPC)
        Me.Controls.Add(Me.pcbPapel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcbPapel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbTijera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPiedra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcbPapel As PictureBox
    Friend WithEvents pcbPC As PictureBox
    Friend WithEvents pcbTijera As PictureBox
    Friend WithEvents pcbPiedra As PictureBox
    Friend WithEvents txtPuntosUS As TextBox
    Friend WithEvents txtPuntosPC As TextBox
    Friend WithEvents Label1 As Label
End Class
