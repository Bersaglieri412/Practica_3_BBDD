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
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listaRanking
        '
        Me.listaRanking.FormattingEnabled = True
        Me.listaRanking.Location = New System.Drawing.Point(9, 74)
        Me.listaRanking.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listaRanking.Name = "listaRanking"
        Me.listaRanking.Size = New System.Drawing.Size(228, 134)
        Me.listaRanking.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ranking:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(172, 213)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Finalista"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 215)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Ganadas"
        '
        'ListaTorneosFinalista
        '
        Me.ListaTorneosFinalista.FormattingEnabled = True
        Me.ListaTorneosFinalista.Location = New System.Drawing.Point(172, 233)
        Me.ListaTorneosFinalista.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListaTorneosFinalista.Name = "ListaTorneosFinalista"
        Me.ListaTorneosFinalista.Size = New System.Drawing.Size(145, 69)
        Me.ListaTorneosFinalista.TabIndex = 78
        '
        'listaEdicionesGanadas
        '
        Me.listaEdicionesGanadas.Cursor = System.Windows.Forms.Cursors.Default
        Me.listaEdicionesGanadas.FormattingEnabled = True
        Me.listaEdicionesGanadas.Location = New System.Drawing.Point(11, 233)
        Me.listaEdicionesGanadas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listaEdicionesGanadas.Name = "listaEdicionesGanadas"
        Me.listaEdicionesGanadas.Size = New System.Drawing.Size(135, 69)
        Me.listaEdicionesGanadas.TabIndex = 77
        '
        'txtvecesganadora
        '
        Me.txtvecesganadora.Location = New System.Drawing.Point(371, 77)
        Me.txtvecesganadora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtvecesganadora.Name = "txtvecesganadora"
        Me.txtvecesganadora.ReadOnly = True
        Me.txtvecesganadora.Size = New System.Drawing.Size(76, 20)
        Me.txtvecesganadora.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Veces ganadora"
        '
        'txtNfinales
        '
        Me.txtNfinales.Location = New System.Drawing.Point(371, 113)
        Me.txtNfinales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNfinales.Name = "txtNfinales"
        Me.txtNfinales.ReadOnly = True
        Me.txtNfinales.Size = New System.Drawing.Size(76, 20)
        Me.txtNfinales.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(268, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Finales disputadas"
        '
        'txtpuntos
        '
        Me.txtpuntos.Location = New System.Drawing.Point(371, 174)
        Me.txtpuntos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtpuntos.Name = "txtpuntos"
        Me.txtpuntos.ReadOnly = True
        Me.txtpuntos.Size = New System.Drawing.Size(76, 20)
        Me.txtpuntos.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 179)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Puntos"
        '
        'listaTorneos
        '
        Me.listaTorneos.FormattingEnabled = True
        Me.listaTorneos.Location = New System.Drawing.Point(20, 41)
        Me.listaTorneos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listaTorneos.Name = "listaTorneos"
        Me.listaTorneos.Size = New System.Drawing.Size(91, 69)
        Me.listaTorneos.TabIndex = 87
        '
        'ListaEdiciones
        '
        Me.ListaEdiciones.FormattingEnabled = True
        Me.ListaEdiciones.Location = New System.Drawing.Point(20, 138)
        Me.ListaEdiciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListaEdiciones.Name = "ListaEdiciones"
        Me.ListaEdiciones.Size = New System.Drawing.Size(91, 69)
        Me.ListaEdiciones.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 23)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Ha participado en:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 120)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Ediciones:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(675, 85)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Resultado:"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(737, 81)
        Me.txtResultado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(76, 20)
        Me.txtResultado.TabIndex = 92
        '
        'txtPuntosObtenidos
        '
        Me.txtPuntosObtenidos.Location = New System.Drawing.Point(737, 117)
        Me.txtPuntosObtenidos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPuntosObtenidos.Name = "txtPuntosObtenidos"
        Me.txtPuntosObtenidos.ReadOnly = True
        Me.txtPuntosObtenidos.Size = New System.Drawing.Size(76, 20)
        Me.txtPuntosObtenidos.TabIndex = 94
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(641, 121)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Puntos obtenidos:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(245, 151)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 13)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Participaciones torneos"
        '
        'txtParticipaciones
        '
        Me.txtParticipaciones.Location = New System.Drawing.Point(371, 144)
        Me.txtParticipaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtParticipaciones.Name = "txtParticipaciones"
        Me.txtParticipaciones.ReadOnly = True
        Me.txtParticipaciones.Size = New System.Drawing.Size(76, 20)
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
        Me.TabControl1.Location = New System.Drawing.Point(462, 56)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(162, 249)
        Me.TabControl1.TabIndex = 98
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.listaTorneos)
        Me.TabPage2.Controls.Add(Me.ListaEdiciones)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(154, 223)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vista total"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbAños)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(154, 223)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Vista anual"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cbAños
        '
        Me.cbAños.FormattingEnabled = True
        Me.cbAños.Location = New System.Drawing.Point(64, 26)
        Me.cbAños.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbAños.Name = "cbAños"
        Me.cbAños.Size = New System.Drawing.Size(76, 21)
        Me.cbAños.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(39, 72)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Torneos"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(41, 99)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(99, 69)
        Me.ListBox1.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 28)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Año"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 316)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
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
End Class
