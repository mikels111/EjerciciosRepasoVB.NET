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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaxMañana = New System.Windows.Forms.TextBox()
        Me.txtMaxNoche = New System.Windows.Forms.TextBox()
        Me.txtMaxTarde = New System.Windows.Forms.TextBox()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.lstMañana = New System.Windows.Forms.ListBox()
        Me.lstTarde = New System.Windows.Forms.ListBox()
        Me.lstNoche = New System.Windows.Forms.ListBox()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mañana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tarde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(550, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Noche"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Maximo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(287, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Maximo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(550, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Maximo"
        '
        'txtMaxMañana
        '
        Me.txtMaxMañana.Location = New System.Drawing.Point(89, 236)
        Me.txtMaxMañana.Name = "txtMaxMañana"
        Me.txtMaxMañana.Size = New System.Drawing.Size(46, 20)
        Me.txtMaxMañana.TabIndex = 11
        '
        'txtMaxNoche
        '
        Me.txtMaxNoche.Location = New System.Drawing.Point(599, 240)
        Me.txtMaxNoche.Name = "txtMaxNoche"
        Me.txtMaxNoche.Size = New System.Drawing.Size(46, 20)
        Me.txtMaxNoche.TabIndex = 12
        '
        'txtMaxTarde
        '
        Me.txtMaxTarde.Location = New System.Drawing.Point(336, 236)
        Me.txtMaxTarde.Name = "txtMaxTarde"
        Me.txtMaxTarde.Size = New System.Drawing.Size(46, 20)
        Me.txtMaxTarde.TabIndex = 13
        '
        'btnTerminar
        '
        Me.btnTerminar.Location = New System.Drawing.Point(349, 424)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(75, 23)
        Me.btnTerminar.TabIndex = 14
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = True
        '
        'lstMañana
        '
        Me.lstMañana.FormattingEnabled = True
        Me.lstMañana.Location = New System.Drawing.Point(43, 50)
        Me.lstMañana.Name = "lstMañana"
        Me.lstMañana.Size = New System.Drawing.Size(181, 160)
        Me.lstMañana.TabIndex = 15
        '
        'lstTarde
        '
        Me.lstTarde.FormattingEnabled = True
        Me.lstTarde.Location = New System.Drawing.Point(290, 50)
        Me.lstTarde.Name = "lstTarde"
        Me.lstTarde.Size = New System.Drawing.Size(181, 160)
        Me.lstTarde.TabIndex = 16
        '
        'lstNoche
        '
        Me.lstNoche.FormattingEnabled = True
        Me.lstNoche.Location = New System.Drawing.Point(553, 50)
        Me.lstNoche.Name = "lstNoche"
        Me.lstNoche.Size = New System.Drawing.Size(181, 160)
        Me.lstNoche.TabIndex = 17
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(493, 131)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(54, 23)
        Me.btn4.TabIndex = 18
        Me.btn4.Tag = "4"
        Me.btn4.Text = "<---"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(493, 85)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(54, 23)
        Me.btn3.TabIndex = 19
        Me.btn3.Tag = "3"
        Me.btn3.Text = "--->"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(230, 131)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(54, 23)
        Me.btn2.TabIndex = 20
        Me.btn2.Tag = "2"
        Me.btn2.Text = "<---"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(230, 85)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(54, 23)
        Me.btn1.TabIndex = 21
        Me.btn1.Tag = "1"
        Me.btn1.Text = "--->"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 459)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.lstNoche)
        Me.Controls.Add(Me.lstTarde)
        Me.Controls.Add(Me.lstMañana)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.txtMaxTarde)
        Me.Controls.Add(Me.txtMaxNoche)
        Me.Controls.Add(Me.txtMaxMañana)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMaxMañana As TextBox
    Friend WithEvents txtMaxNoche As TextBox
    Friend WithEvents txtMaxTarde As TextBox
    Friend WithEvents btnTerminar As Button
    Friend WithEvents lstMañana As ListBox
    Friend WithEvents lstTarde As ListBox
    Friend WithEvents lstNoche As ListBox
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
End Class
