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
        Me.Pestañas = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.listJugadoras = New System.Windows.Forms.ListBox()
        Me.lblIDJugadora = New System.Windows.Forms.Label()
        Me.lblNombreJugadora = New System.Windows.Forms.Label()
        Me.lblFechaNacJugadora = New System.Windows.Forms.Label()
        Me.txtIDJugadora = New System.Windows.Forms.TextBox()
        Me.txtNombreJugadora = New System.Windows.Forms.TextBox()
        Me.DateTimeFechaNacJugadora = New System.Windows.Forms.DateTimePicker()
        Me.lblPaisJugadora = New System.Windows.Forms.Label()
        Me.Pestañas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pestañas
        '
        Me.Pestañas.Controls.Add(Me.TabPage1)
        Me.Pestañas.Controls.Add(Me.TabPage2)
        Me.Pestañas.Controls.Add(Me.TabPage3)
        Me.Pestañas.Controls.Add(Me.TabPage4)
        Me.Pestañas.Controls.Add(Me.TabPage5)
        Me.Pestañas.Cursor = System.Windows.Forms.Cursors.Default
        Me.Pestañas.Location = New System.Drawing.Point(-4, 4)
        Me.Pestañas.Name = "Pestañas"
        Me.Pestañas.SelectedIndex = 0
        Me.Pestañas.Size = New System.Drawing.Size(769, 404)
        Me.Pestañas.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblPaisJugadora)
        Me.TabPage1.Controls.Add(Me.DateTimeFechaNacJugadora)
        Me.TabPage1.Controls.Add(Me.txtNombreJugadora)
        Me.TabPage1.Controls.Add(Me.txtIDJugadora)
        Me.TabPage1.Controls.Add(Me.lblFechaNacJugadora)
        Me.TabPage1.Controls.Add(Me.lblNombreJugadora)
        Me.TabPage1.Controls.Add(Me.lblIDJugadora)
        Me.TabPage1.Controls.Add(Me.listJugadoras)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(761, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "JUGADORA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(761, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PAIS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(761, 375)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TORNEO"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(761, 375)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "EDICION"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(761, 375)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'listJugadoras
        '
        Me.listJugadoras.FormattingEnabled = True
        Me.listJugadoras.ItemHeight = 16
        Me.listJugadoras.Location = New System.Drawing.Point(33, 40)
        Me.listJugadoras.Name = "listJugadoras"
        Me.listJugadoras.Size = New System.Drawing.Size(202, 196)
        Me.listJugadoras.TabIndex = 0
        '
        'lblIDJugadora
        '
        Me.lblIDJugadora.AutoSize = True
        Me.lblIDJugadora.Location = New System.Drawing.Point(281, 53)
        Me.lblIDJugadora.Name = "lblIDJugadora"
        Me.lblIDJugadora.Size = New System.Drawing.Size(21, 17)
        Me.lblIDJugadora.TabIndex = 1
        Me.lblIDJugadora.Text = "ID"
        '
        'lblNombreJugadora
        '
        Me.lblNombreJugadora.AutoSize = True
        Me.lblNombreJugadora.Location = New System.Drawing.Point(281, 92)
        Me.lblNombreJugadora.Name = "lblNombreJugadora"
        Me.lblNombreJugadora.Size = New System.Drawing.Size(58, 17)
        Me.lblNombreJugadora.TabIndex = 2
        Me.lblNombreJugadora.Text = "Nombre"
        '
        'lblFechaNacJugadora
        '
        Me.lblFechaNacJugadora.AutoSize = True
        Me.lblFechaNacJugadora.Location = New System.Drawing.Point(281, 145)
        Me.lblFechaNacJugadora.Name = "lblFechaNacJugadora"
        Me.lblFechaNacJugadora.Size = New System.Drawing.Size(139, 17)
        Me.lblFechaNacJugadora.TabIndex = 3
        Me.lblFechaNacJugadora.Text = "Fecha de nacimiento"
        '
        'txtIDJugadora
        '
        Me.txtIDJugadora.Location = New System.Drawing.Point(456, 48)
        Me.txtIDJugadora.Name = "txtIDJugadora"
        Me.txtIDJugadora.Size = New System.Drawing.Size(171, 22)
        Me.txtIDJugadora.TabIndex = 4
        '
        'txtNombreJugadora
        '
        Me.txtNombreJugadora.Location = New System.Drawing.Point(456, 97)
        Me.txtNombreJugadora.Name = "txtNombreJugadora"
        Me.txtNombreJugadora.Size = New System.Drawing.Size(171, 22)
        Me.txtNombreJugadora.TabIndex = 5
        '
        'DateTimeFechaNacJugadora
        '
        Me.DateTimeFechaNacJugadora.Location = New System.Drawing.Point(456, 140)
        Me.DateTimeFechaNacJugadora.Name = "DateTimeFechaNacJugadora"
        Me.DateTimeFechaNacJugadora.Size = New System.Drawing.Size(171, 22)
        Me.DateTimeFechaNacJugadora.TabIndex = 6
        '
        'lblPaisJugadora
        '
        Me.lblPaisJugadora.AutoSize = True
        Me.lblPaisJugadora.Location = New System.Drawing.Point(287, 190)
        Me.lblPaisJugadora.Name = "lblPaisJugadora"
        Me.lblPaisJugadora.Size = New System.Drawing.Size(35, 17)
        Me.lblPaisJugadora.TabIndex = 7
        Me.lblPaisJugadora.Text = "País"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Pestañas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Pestañas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pestañas As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents listJugadoras As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DateTimeFechaNacJugadora As DateTimePicker
    Friend WithEvents txtNombreJugadora As TextBox
    Friend WithEvents txtIDJugadora As TextBox
    Friend WithEvents lblFechaNacJugadora As Label
    Friend WithEvents lblNombreJugadora As Label
    Friend WithEvents lblIDJugadora As Label
    Friend WithEvents lblPaisJugadora As Label
End Class
