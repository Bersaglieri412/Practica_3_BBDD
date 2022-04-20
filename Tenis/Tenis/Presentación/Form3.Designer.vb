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
        Me.SuspendLayout()
        '
        'listaRanking
        '
        Me.listaRanking.FormattingEnabled = True
        Me.listaRanking.ItemHeight = 16
        Me.listaRanking.Location = New System.Drawing.Point(54, 95)
        Me.listaRanking.Name = "listaRanking"
        Me.listaRanking.Size = New System.Drawing.Size(176, 164)
        Me.listaRanking.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ranking:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(271, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Finalista"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Ganadas"
        '
        'ListaTorneosFinalista
        '
        Me.ListaTorneosFinalista.FormattingEnabled = True
        Me.ListaTorneosFinalista.ItemHeight = 16
        Me.ListaTorneosFinalista.Location = New System.Drawing.Point(271, 291)
        Me.ListaTorneosFinalista.Name = "ListaTorneosFinalista"
        Me.ListaTorneosFinalista.Size = New System.Drawing.Size(192, 84)
        Me.ListaTorneosFinalista.TabIndex = 78
        '
        'listaEdicionesGanadas
        '
        Me.listaEdicionesGanadas.FormattingEnabled = True
        Me.listaEdicionesGanadas.ItemHeight = 16
        Me.listaEdicionesGanadas.Location = New System.Drawing.Point(57, 291)
        Me.listaEdicionesGanadas.Name = "listaEdicionesGanadas"
        Me.listaEdicionesGanadas.Size = New System.Drawing.Size(179, 84)
        Me.listaEdicionesGanadas.TabIndex = 77
        '
        'txtvecesganadora
        '
        Me.txtvecesganadora.Location = New System.Drawing.Point(363, 95)
        Me.txtvecesganadora.Name = "txtvecesganadora"
        Me.txtvecesganadora.ReadOnly = True
        Me.txtvecesganadora.Size = New System.Drawing.Size(100, 22)
        Me.txtvecesganadora.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Veces ganadora"
        '
        'txtNfinales
        '
        Me.txtNfinales.Location = New System.Drawing.Point(363, 140)
        Me.txtNfinales.Name = "txtNfinales"
        Me.txtNfinales.ReadOnly = True
        Me.txtNfinales.Size = New System.Drawing.Size(100, 22)
        Me.txtNfinales.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Finales disputadas"
        '
        'txtpuntos
        '
        Me.txtpuntos.Location = New System.Drawing.Point(363, 215)
        Me.txtpuntos.Name = "txtpuntos"
        Me.txtpuntos.ReadOnly = True
        Me.txtpuntos.Size = New System.Drawing.Size(100, 22)
        Me.txtpuntos.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Puntos"
        '
        'listaTorneos
        '
        Me.listaTorneos.FormattingEnabled = True
        Me.listaTorneos.ItemHeight = 16
        Me.listaTorneos.Location = New System.Drawing.Point(527, 95)
        Me.listaTorneos.Name = "listaTorneos"
        Me.listaTorneos.Size = New System.Drawing.Size(120, 84)
        Me.listaTorneos.TabIndex = 87
        '
        'ListaEdiciones
        '
        Me.ListaEdiciones.FormattingEnabled = True
        Me.ListaEdiciones.ItemHeight = 16
        Me.ListaEdiciones.Location = New System.Drawing.Point(527, 215)
        Me.ListaEdiciones.Name = "ListaEdiciones"
        Me.ListaEdiciones.Size = New System.Drawing.Size(120, 84)
        Me.ListaEdiciones.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(527, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 16)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Ha participado en:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(527, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Ediciones:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(713, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Resultado:"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(791, 98)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(100, 22)
        Me.txtResultado.TabIndex = 92
        '
        'txtPuntosObtenidos
        '
        Me.txtPuntosObtenidos.Location = New System.Drawing.Point(791, 143)
        Me.txtPuntosObtenidos.Name = "txtPuntosObtenidos"
        Me.txtPuntosObtenidos.ReadOnly = True
        Me.txtPuntosObtenidos.Size = New System.Drawing.Size(100, 22)
        Me.txtPuntosObtenidos.TabIndex = 94
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(671, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 16)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Puntos obtenidos:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(257, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Participaciones"
        '
        'txtParticipaciones
        '
        Me.txtParticipaciones.Location = New System.Drawing.Point(363, 178)
        Me.txtParticipaciones.Name = "txtParticipaciones"
        Me.txtParticipaciones.ReadOnly = True
        Me.txtParticipaciones.Size = New System.Drawing.Size(100, 22)
        Me.txtParticipaciones.TabIndex = 95
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtParticipaciones)
        Me.Controls.Add(Me.txtPuntosObtenidos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListaEdiciones)
        Me.Controls.Add(Me.listaTorneos)
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
        Me.Name = "Form3"
        Me.Text = "Form3"
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
End Class
