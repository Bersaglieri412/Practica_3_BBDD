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
        Me.btnLimpiarJugadora = New System.Windows.Forms.Button()
        Me.btnEliminarJugadora = New System.Windows.Forms.Button()
        Me.bntModificarJugadora = New System.Windows.Forms.Button()
        Me.btnAnadirJugadora = New System.Windows.Forms.Button()
        Me.txtPuntosJugadora = New System.Windows.Forms.TextBox()
        Me.lblPuntosJugadora = New System.Windows.Forms.Label()
        Me.txtPaisJugadora = New System.Windows.Forms.TextBox()
        Me.lblPaisJugadora = New System.Windows.Forms.Label()
        Me.DateTimeFechaNacJugadora = New System.Windows.Forms.DateTimePicker()
        Me.txtNombreJugadora = New System.Windows.Forms.TextBox()
        Me.txtIDJugadora = New System.Windows.Forms.TextBox()
        Me.lblFechaNacJugadora = New System.Windows.Forms.Label()
        Me.lblNombreJugadora = New System.Windows.Forms.Label()
        Me.lblIDJugadora = New System.Windows.Forms.Label()
        Me.listaJugadoras = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.listaPaises = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtNombrePais = New System.Windows.Forms.TextBox()
        Me.txtIDPais = New System.Windows.Forms.TextBox()
        Me.lblNombrePais = New System.Windows.Forms.Label()
        Me.lblIDPais = New System.Windows.Forms.Label()
        Me.Pestañas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.Pestañas.Size = New System.Drawing.Size(836, 404)
        Me.Pestañas.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnLimpiarJugadora)
        Me.TabPage1.Controls.Add(Me.btnEliminarJugadora)
        Me.TabPage1.Controls.Add(Me.bntModificarJugadora)
        Me.TabPage1.Controls.Add(Me.btnAnadirJugadora)
        Me.TabPage1.Controls.Add(Me.txtPuntosJugadora)
        Me.TabPage1.Controls.Add(Me.lblPuntosJugadora)
        Me.TabPage1.Controls.Add(Me.txtPaisJugadora)
        Me.TabPage1.Controls.Add(Me.lblPaisJugadora)
        Me.TabPage1.Controls.Add(Me.DateTimeFechaNacJugadora)
        Me.TabPage1.Controls.Add(Me.txtNombreJugadora)
        Me.TabPage1.Controls.Add(Me.txtIDJugadora)
        Me.TabPage1.Controls.Add(Me.lblFechaNacJugadora)
        Me.TabPage1.Controls.Add(Me.lblNombreJugadora)
        Me.TabPage1.Controls.Add(Me.lblIDJugadora)
        Me.TabPage1.Controls.Add(Me.listaJugadoras)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(828, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "JUGADORA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnLimpiarJugadora
        '
        Me.btnLimpiarJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarJugadora.Location = New System.Drawing.Point(652, 233)
        Me.btnLimpiarJugadora.Name = "btnLimpiarJugadora"
        Me.btnLimpiarJugadora.Size = New System.Drawing.Size(151, 46)
        Me.btnLimpiarJugadora.TabIndex = 14
        Me.btnLimpiarJugadora.Text = "LIMPIAR CAMPOS"
        Me.btnLimpiarJugadora.UseVisualStyleBackColor = True
        '
        'btnEliminarJugadora
        '
        Me.btnEliminarJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarJugadora.Location = New System.Drawing.Point(652, 166)
        Me.btnEliminarJugadora.Name = "btnEliminarJugadora"
        Me.btnEliminarJugadora.Size = New System.Drawing.Size(151, 46)
        Me.btnEliminarJugadora.TabIndex = 13
        Me.btnEliminarJugadora.Text = "ELIMINAR JUGADORA"
        Me.btnEliminarJugadora.UseVisualStyleBackColor = True
        '
        'bntModificarJugadora
        '
        Me.bntModificarJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntModificarJugadora.Location = New System.Drawing.Point(652, 97)
        Me.bntModificarJugadora.Name = "bntModificarJugadora"
        Me.bntModificarJugadora.Size = New System.Drawing.Size(151, 46)
        Me.bntModificarJugadora.TabIndex = 12
        Me.bntModificarJugadora.Text = "MODIFICAR JUGADORA"
        Me.bntModificarJugadora.UseVisualStyleBackColor = True
        '
        'btnAnadirJugadora
        '
        Me.btnAnadirJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirJugadora.Location = New System.Drawing.Point(652, 40)
        Me.btnAnadirJugadora.Name = "btnAnadirJugadora"
        Me.btnAnadirJugadora.Size = New System.Drawing.Size(151, 46)
        Me.btnAnadirJugadora.TabIndex = 11
        Me.btnAnadirJugadora.Text = "AÑADIR JUGADORA"
        Me.btnAnadirJugadora.UseVisualStyleBackColor = True
        '
        'txtPuntosJugadora
        '
        Me.txtPuntosJugadora.Location = New System.Drawing.Point(456, 230)
        Me.txtPuntosJugadora.Name = "txtPuntosJugadora"
        Me.txtPuntosJugadora.Size = New System.Drawing.Size(171, 22)
        Me.txtPuntosJugadora.TabIndex = 10
        '
        'lblPuntosJugadora
        '
        Me.lblPuntosJugadora.AutoSize = True
        Me.lblPuntosJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntosJugadora.Location = New System.Drawing.Point(281, 233)
        Me.lblPuntosJugadora.Name = "lblPuntosJugadora"
        Me.lblPuntosJugadora.Size = New System.Drawing.Size(63, 17)
        Me.lblPuntosJugadora.TabIndex = 9
        Me.lblPuntosJugadora.Text = "Puntos "
        '
        'txtPaisJugadora
        '
        Me.txtPaisJugadora.Location = New System.Drawing.Point(456, 190)
        Me.txtPaisJugadora.Name = "txtPaisJugadora"
        Me.txtPaisJugadora.Size = New System.Drawing.Size(171, 22)
        Me.txtPaisJugadora.TabIndex = 8
        '
        'lblPaisJugadora
        '
        Me.lblPaisJugadora.AutoSize = True
        Me.lblPaisJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaisJugadora.Location = New System.Drawing.Point(281, 190)
        Me.lblPaisJugadora.Name = "lblPaisJugadora"
        Me.lblPaisJugadora.Size = New System.Drawing.Size(39, 17)
        Me.lblPaisJugadora.TabIndex = 7
        Me.lblPaisJugadora.Text = "País"
        '
        'DateTimeFechaNacJugadora
        '
        Me.DateTimeFechaNacJugadora.Location = New System.Drawing.Point(456, 140)
        Me.DateTimeFechaNacJugadora.Name = "DateTimeFechaNacJugadora"
        Me.DateTimeFechaNacJugadora.Size = New System.Drawing.Size(171, 22)
        Me.DateTimeFechaNacJugadora.TabIndex = 6
        '
        'txtNombreJugadora
        '
        Me.txtNombreJugadora.Location = New System.Drawing.Point(456, 97)
        Me.txtNombreJugadora.Name = "txtNombreJugadora"
        Me.txtNombreJugadora.Size = New System.Drawing.Size(171, 22)
        Me.txtNombreJugadora.TabIndex = 5
        '
        'txtIDJugadora
        '
        Me.txtIDJugadora.Location = New System.Drawing.Point(456, 48)
        Me.txtIDJugadora.Name = "txtIDJugadora"
        Me.txtIDJugadora.Size = New System.Drawing.Size(171, 22)
        Me.txtIDJugadora.TabIndex = 4
        '
        'lblFechaNacJugadora
        '
        Me.lblFechaNacJugadora.AutoSize = True
        Me.lblFechaNacJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacJugadora.Location = New System.Drawing.Point(281, 145)
        Me.lblFechaNacJugadora.Name = "lblFechaNacJugadora"
        Me.lblFechaNacJugadora.Size = New System.Drawing.Size(158, 17)
        Me.lblFechaNacJugadora.TabIndex = 3
        Me.lblFechaNacJugadora.Text = "Fecha de nacimiento"
        '
        'lblNombreJugadora
        '
        Me.lblNombreJugadora.AutoSize = True
        Me.lblNombreJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreJugadora.Location = New System.Drawing.Point(375, 102)
        Me.lblNombreJugadora.Name = "lblNombreJugadora"
        Me.lblNombreJugadora.Size = New System.Drawing.Size(64, 17)
        Me.lblNombreJugadora.TabIndex = 2
        Me.lblNombreJugadora.Text = "Nombre"
        '
        'lblIDJugadora
        '
        Me.lblIDJugadora.AutoSize = True
        Me.lblIDJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDJugadora.Location = New System.Drawing.Point(416, 55)
        Me.lblIDJugadora.Name = "lblIDJugadora"
        Me.lblIDJugadora.Size = New System.Drawing.Size(23, 17)
        Me.lblIDJugadora.TabIndex = 1
        Me.lblIDJugadora.Text = "ID"
        '
        'listaJugadoras
        '
        Me.listaJugadoras.FormattingEnabled = True
        Me.listaJugadoras.ItemHeight = 16
        Me.listaJugadoras.Location = New System.Drawing.Point(33, 40)
        Me.listaJugadoras.Name = "listaJugadoras"
        Me.listaJugadoras.Size = New System.Drawing.Size(202, 196)
        Me.listaJugadoras.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.txtNombrePais)
        Me.TabPage2.Controls.Add(Me.txtIDPais)
        Me.TabPage2.Controls.Add(Me.lblNombrePais)
        Me.TabPage2.Controls.Add(Me.lblIDPais)
        Me.TabPage2.Controls.Add(Me.listaPaises)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(828, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PAIS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(828, 375)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TORNEO"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(828, 375)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "EDICION"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(828, 375)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'listaPaises
        '
        Me.listaPaises.FormattingEnabled = True
        Me.listaPaises.ItemHeight = 16
        Me.listaPaises.Location = New System.Drawing.Point(34, 41)
        Me.listaPaises.Name = "listaPaises"
        Me.listaPaises.Size = New System.Drawing.Size(202, 196)
        Me.listaPaises.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(637, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 46)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "LIMPIAR CAMPOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(637, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 46)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "ELIMINAR JUGADORA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(637, 102)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 46)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "MODIFICAR JUGADORA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(637, 41)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 46)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "AÑADIR JUGADORA"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtNombrePais
        '
        Me.txtNombrePais.Location = New System.Drawing.Point(441, 102)
        Me.txtNombrePais.Name = "txtNombrePais"
        Me.txtNombrePais.Size = New System.Drawing.Size(171, 22)
        Me.txtNombrePais.TabIndex = 18
        '
        'txtIDPais
        '
        Me.txtIDPais.Location = New System.Drawing.Point(441, 53)
        Me.txtIDPais.Name = "txtIDPais"
        Me.txtIDPais.Size = New System.Drawing.Size(171, 22)
        Me.txtIDPais.TabIndex = 17
        '
        'lblNombrePais
        '
        Me.lblNombrePais.AutoSize = True
        Me.lblNombrePais.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePais.Location = New System.Drawing.Point(266, 102)
        Me.lblNombrePais.Name = "lblNombrePais"
        Me.lblNombrePais.Size = New System.Drawing.Size(64, 17)
        Me.lblNombrePais.TabIndex = 16
        Me.lblNombrePais.Text = "Nombre"
        '
        'lblIDPais
        '
        Me.lblIDPais.AutoSize = True
        Me.lblIDPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDPais.Location = New System.Drawing.Point(266, 56)
        Me.lblIDPais.Name = "lblIDPais"
        Me.lblIDPais.Size = New System.Drawing.Size(23, 17)
        Me.lblIDPais.TabIndex = 15
        Me.lblIDPais.Text = "ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 450)
        Me.Controls.Add(Me.Pestañas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Pestañas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pestañas As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents listaJugadoras As ListBox
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
    Friend WithEvents txtPaisJugadora As TextBox
    Friend WithEvents btnLimpiarJugadora As Button
    Friend WithEvents btnEliminarJugadora As Button
    Friend WithEvents bntModificarJugadora As Button
    Friend WithEvents btnAnadirJugadora As Button
    Friend WithEvents txtPuntosJugadora As TextBox
    Friend WithEvents lblPuntosJugadora As Label
    Friend WithEvents listaPaises As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtNombrePais As TextBox
    Friend WithEvents txtIDPais As TextBox
    Friend WithEvents lblNombrePais As Label
    Friend WithEvents lblIDPais As Label
End Class
