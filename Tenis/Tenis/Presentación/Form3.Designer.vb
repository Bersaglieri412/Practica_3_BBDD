<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.listaRanking = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListaTorneosFinalista = New System.Windows.Forms.ListBox()
        Me.listaEdicionesGanadas = New System.Windows.Forms.ListBox()
        Me.txtvecesganadora = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNfinales = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpuntos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.listaTorneos = New System.Windows.Forms.ListBox()
        Me.ListaEdiciones = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.txtPuntosObtenidos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtParticipaciones = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbAños = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listaRanking
        '
        Me.listaRanking.FormattingEnabled = True
        Me.listaRanking.ItemHeight = 16
        Me.listaRanking.Location = New System.Drawing.Point(11, 140)
        Me.listaRanking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listaRanking.Name = "listaRanking"
        Me.listaRanking.Size = New System.Drawing.Size(303, 164)
        Me.listaRanking.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ranking:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 16)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Ediciones finalista"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Ediciones ganadas"
        '
        'ListaTorneosFinalista
        '
        Me.ListaTorneosFinalista.FormattingEnabled = True
        Me.ListaTorneosFinalista.ItemHeight = 16
        Me.ListaTorneosFinalista.Location = New System.Drawing.Point(228, 336)
        Me.ListaTorneosFinalista.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListaTorneosFinalista.Name = "ListaTorneosFinalista"
        Me.ListaTorneosFinalista.Size = New System.Drawing.Size(246, 84)
        Me.ListaTorneosFinalista.TabIndex = 78
        '
        'listaEdicionesGanadas
        '
        Me.listaEdicionesGanadas.Cursor = System.Windows.Forms.Cursors.Default
        Me.listaEdicionesGanadas.FormattingEnabled = True
        Me.listaEdicionesGanadas.ItemHeight = 16
        Me.listaEdicionesGanadas.Location = New System.Drawing.Point(14, 336)
        Me.listaEdicionesGanadas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listaEdicionesGanadas.Name = "listaEdicionesGanadas"
        Me.listaEdicionesGanadas.Size = New System.Drawing.Size(208, 84)
        Me.listaEdicionesGanadas.TabIndex = 77
        '
        'txtvecesganadora
        '
        Me.txtvecesganadora.Location = New System.Drawing.Point(494, 144)
        Me.txtvecesganadora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtvecesganadora.Name = "txtvecesganadora"
        Me.txtvecesganadora.ReadOnly = True
        Me.txtvecesganadora.Size = New System.Drawing.Size(100, 22)
        Me.txtvecesganadora.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Veces ganadora"
        '
        'txtNfinales
        '
        Me.txtNfinales.Location = New System.Drawing.Point(494, 188)
        Me.txtNfinales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNfinales.Name = "txtNfinales"
        Me.txtNfinales.ReadOnly = True
        Me.txtNfinales.Size = New System.Drawing.Size(100, 22)
        Me.txtNfinales.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(356, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Finales disputadas"
        '
        'txtpuntos
        '
        Me.txtpuntos.Location = New System.Drawing.Point(494, 263)
        Me.txtpuntos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpuntos.Name = "txtpuntos"
        Me.txtpuntos.ReadOnly = True
        Me.txtpuntos.Size = New System.Drawing.Size(100, 22)
        Me.txtpuntos.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(428, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Puntos"
        '
        'listaTorneos
        '
        Me.listaTorneos.FormattingEnabled = True
        Me.listaTorneos.ItemHeight = 16
        Me.listaTorneos.Location = New System.Drawing.Point(27, 50)
        Me.listaTorneos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listaTorneos.Name = "listaTorneos"
        Me.listaTorneos.Size = New System.Drawing.Size(120, 84)
        Me.listaTorneos.TabIndex = 87
        '
        'ListaEdiciones
        '
        Me.ListaEdiciones.FormattingEnabled = True
        Me.ListaEdiciones.ItemHeight = 16
        Me.ListaEdiciones.Location = New System.Drawing.Point(27, 170)
        Me.ListaEdiciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListaEdiciones.Name = "ListaEdiciones"
        Me.ListaEdiciones.Size = New System.Drawing.Size(120, 84)
        Me.ListaEdiciones.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 16)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Ha participado en:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Ediciones:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(899, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Resultado:"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(982, 149)
        Me.txtResultado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(100, 22)
        Me.txtResultado.TabIndex = 92
        '
        'txtPuntosObtenidos
        '
        Me.txtPuntosObtenidos.Location = New System.Drawing.Point(982, 193)
        Me.txtPuntosObtenidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPuntosObtenidos.Name = "txtPuntosObtenidos"
        Me.txtPuntosObtenidos.ReadOnly = True
        Me.txtPuntosObtenidos.Size = New System.Drawing.Size(100, 22)
        Me.txtPuntosObtenidos.TabIndex = 94
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(854, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 16)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Puntos obtenidos:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(326, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 16)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Participaciones torneos"
        '
        'txtParticipaciones
        '
        Me.txtParticipaciones.Location = New System.Drawing.Point(494, 226)
        Me.txtParticipaciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtParticipaciones.Name = "txtParticipaciones"
        Me.txtParticipaciones.ReadOnly = True
        Me.txtParticipaciones.Size = New System.Drawing.Size(100, 22)
        Me.txtParticipaciones.TabIndex = 95
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(615, 118)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(216, 306)
        Me.TabControl1.TabIndex = 98
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage2.Controls.Add(Me.listaTorneos)
        Me.TabPage2.Controls.Add(Me.ListaEdiciones)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(208, 277)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vista total"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbAños)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(208, 277)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Vista anual"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbAños
        '
        Me.cbAños.FormattingEnabled = True
        Me.cbAños.Location = New System.Drawing.Point(85, 32)
        Me.cbAños.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbAños.Name = "cbAños"
        Me.cbAños.Size = New System.Drawing.Size(100, 24)
        Me.cbAños.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(52, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Torneos"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(55, 122)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(131, 84)
        Me.ListBox1.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(49, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Año"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Location = New System.Drawing.Point(17, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1065, 101)
        Me.Panel1.TabIndex = 103
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 68)
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Font = New System.Drawing.Font("Yu Gothic UI", 35.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(129, 1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(577, 78)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "RANKING TORNEOS"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1099, 480)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtParticipaciones)
        Me.Controls.Add(Me.txtPuntosObtenidos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpuntos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNfinales)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtvecesganadora)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListaTorneosFinalista)
        Me.Controls.Add(Me.listaEdicionesGanadas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listaRanking)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ranking e información general"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listaRanking As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListaTorneosFinalista As ListBox
    Friend WithEvents listaEdicionesGanadas As ListBox
    Friend WithEvents txtvecesganadora As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNfinales As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpuntos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents listaTorneos As ListBox
    Friend WithEvents ListaEdiciones As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents txtPuntosObtenidos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtParticipaciones As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbAños As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
End Class
