﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.listaGanadoras = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnoEdicion = New System.Windows.Forms.TextBox()
        Me.txtCiudadTorneo = New System.Windows.Forms.TextBox()
        Me.txtNombreTorneo = New System.Windows.Forms.TextBox()
        Me.txtIDTorneo = New System.Windows.Forms.TextBox()
        Me.generarEdicion = New System.Windows.Forms.Button()
        Me.cbPaisTorneo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listaEdiciones = New System.Windows.Forms.ListBox()
        Me.btnLimpiarTorneo = New System.Windows.Forms.Button()
        Me.btnEliminarTorneo = New System.Windows.Forms.Button()
        Me.btnModificarTorneo = New System.Windows.Forms.Button()
        Me.btnAnadirTorneo = New System.Windows.Forms.Button()
        Me.lblPaisTorneo = New System.Windows.Forms.Label()
        Me.lblCiudadTorneo = New System.Windows.Forms.Label()
        Me.lblNombreTorneo = New System.Windows.Forms.Label()
        Me.lblIDTorneo = New System.Windows.Forms.Label()
        Me.listaTorneos = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnLimpiarPais = New System.Windows.Forms.Button()
        Me.btnEliminarPais = New System.Windows.Forms.Button()
        Me.btnModificarPais = New System.Windows.Forms.Button()
        Me.btnAnadirPais = New System.Windows.Forms.Button()
        Me.txtNombrePais = New System.Windows.Forms.TextBox()
        Me.txtIDPais = New System.Windows.Forms.TextBox()
        Me.lblNombrePais = New System.Windows.Forms.Label()
        Me.lblIDPais = New System.Windows.Forms.Label()
        Me.listaPaises = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListaTorneosFinalista = New System.Windows.Forms.ListBox()
        Me.listaEdicionesGanadas = New System.Windows.Forms.ListBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.txtPuntosJugadora = New System.Windows.Forms.TextBox()
        Me.txtNombreJugadora = New System.Windows.Forms.TextBox()
        Me.lblIDJugadora = New System.Windows.Forms.Label()
        Me.cbPaisJugadora = New System.Windows.Forms.ComboBox()
        Me.btnLimpiarJugadora = New System.Windows.Forms.Button()
        Me.btnEliminarJugadora = New System.Windows.Forms.Button()
        Me.btnModificarJugadora = New System.Windows.Forms.Button()
        Me.btnAnadirJugadora = New System.Windows.Forms.Button()
        Me.lblPuntosJugadora = New System.Windows.Forms.Label()
        Me.lblPaisJugadora = New System.Windows.Forms.Label()
        Me.DateTimeFechaNacJugadora = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacJugadora = New System.Windows.Forms.Label()
        Me.lblNombreJugadora = New System.Windows.Forms.Label()
        Me.lblIDJugadoraa = New System.Windows.Forms.Label()
        Me.listaJugadoras = New System.Windows.Forms.ListBox()
        Me.Pestañas = New System.Windows.Forms.TabControl()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Pestañas.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.listaGanadoras)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.txtAnoEdicion)
        Me.TabPage3.Controls.Add(Me.txtCiudadTorneo)
        Me.TabPage3.Controls.Add(Me.txtNombreTorneo)
        Me.TabPage3.Controls.Add(Me.txtIDTorneo)
        Me.TabPage3.Controls.Add(Me.generarEdicion)
        Me.TabPage3.Controls.Add(Me.cbPaisTorneo)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.listaEdiciones)
        Me.TabPage3.Controls.Add(Me.btnLimpiarTorneo)
        Me.TabPage3.Controls.Add(Me.btnEliminarTorneo)
        Me.TabPage3.Controls.Add(Me.btnModificarTorneo)
        Me.TabPage3.Controls.Add(Me.btnAnadirTorneo)
        Me.TabPage3.Controls.Add(Me.lblPaisTorneo)
        Me.TabPage3.Controls.Add(Me.lblCiudadTorneo)
        Me.TabPage3.Controls.Add(Me.lblNombreTorneo)
        Me.TabPage3.Controls.Add(Me.lblIDTorneo)
        Me.TabPage3.Controls.Add(Me.listaTorneos)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(828, 375)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TORNEO"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'listaGanadoras
        '
        Me.listaGanadoras.Cursor = System.Windows.Forms.Cursors.Default
        Me.listaGanadoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaGanadoras.FormattingEnabled = True
        Me.listaGanadoras.ItemHeight = 16
        Me.listaGanadoras.Location = New System.Drawing.Point(160, 236)
        Me.listaGanadoras.Name = "listaGanadoras"
        Me.listaGanadoras.Size = New System.Drawing.Size(124, 132)
        Me.listaGanadoras.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Ganadoras"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(308, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Año"
        '
        'txtAnoEdicion
        '
        Me.txtAnoEdicion.Location = New System.Drawing.Point(369, 260)
        Me.txtAnoEdicion.Name = "txtAnoEdicion"
        Me.txtAnoEdicion.Size = New System.Drawing.Size(100, 22)
        Me.txtAnoEdicion.TabIndex = 37
        '
        'txtCiudadTorneo
        '
        Me.txtCiudadTorneo.Location = New System.Drawing.Point(369, 136)
        Me.txtCiudadTorneo.Name = "txtCiudadTorneo"
        Me.txtCiudadTorneo.Size = New System.Drawing.Size(171, 22)
        Me.txtCiudadTorneo.TabIndex = 25
        '
        'txtNombreTorneo
        '
        Me.txtNombreTorneo.Location = New System.Drawing.Point(369, 88)
        Me.txtNombreTorneo.Name = "txtNombreTorneo"
        Me.txtNombreTorneo.Size = New System.Drawing.Size(171, 22)
        Me.txtNombreTorneo.TabIndex = 22
        '
        'txtIDTorneo
        '
        Me.txtIDTorneo.Location = New System.Drawing.Point(369, 39)
        Me.txtIDTorneo.Name = "txtIDTorneo"
        Me.txtIDTorneo.Size = New System.Drawing.Size(171, 22)
        Me.txtIDTorneo.TabIndex = 21
        '
        'generarEdicion
        '
        Me.generarEdicion.Location = New System.Drawing.Point(369, 298)
        Me.generarEdicion.Name = "generarEdicion"
        Me.generarEdicion.Size = New System.Drawing.Size(100, 52)
        Me.generarEdicion.TabIndex = 36
        Me.generarEdicion.Text = "Generar Edición"
        Me.generarEdicion.UseVisualStyleBackColor = True
        '
        'cbPaisTorneo
        '
        Me.cbPaisTorneo.FormattingEnabled = True
        Me.cbPaisTorneo.Location = New System.Drawing.Point(369, 191)
        Me.cbPaisTorneo.Name = "cbPaisTorneo"
        Me.cbPaisTorneo.Size = New System.Drawing.Size(171, 24)
        Me.cbPaisTorneo.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Ediciones"
        '
        'listaEdiciones
        '
        Me.listaEdiciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.listaEdiciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaEdiciones.FormattingEnabled = True
        Me.listaEdiciones.ItemHeight = 16
        Me.listaEdiciones.Location = New System.Drawing.Point(31, 236)
        Me.listaEdiciones.Name = "listaEdiciones"
        Me.listaEdiciones.Size = New System.Drawing.Size(110, 132)
        Me.listaEdiciones.TabIndex = 33
        '
        'btnLimpiarTorneo
        '
        Me.btnLimpiarTorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarTorneo.Location = New System.Drawing.Point(623, 236)
        Me.btnLimpiarTorneo.Name = "btnLimpiarTorneo"
        Me.btnLimpiarTorneo.Size = New System.Drawing.Size(151, 46)
        Me.btnLimpiarTorneo.TabIndex = 32
        Me.btnLimpiarTorneo.Text = "LIMPIAR CAMPOS"
        Me.btnLimpiarTorneo.UseVisualStyleBackColor = True
        '
        'btnEliminarTorneo
        '
        Me.btnEliminarTorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTorneo.Location = New System.Drawing.Point(623, 169)
        Me.btnEliminarTorneo.Name = "btnEliminarTorneo"
        Me.btnEliminarTorneo.Size = New System.Drawing.Size(151, 46)
        Me.btnEliminarTorneo.TabIndex = 31
        Me.btnEliminarTorneo.Text = "ELIMINAR TORNEO"
        Me.btnEliminarTorneo.UseVisualStyleBackColor = True
        '
        'btnModificarTorneo
        '
        Me.btnModificarTorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarTorneo.Location = New System.Drawing.Point(623, 100)
        Me.btnModificarTorneo.Name = "btnModificarTorneo"
        Me.btnModificarTorneo.Size = New System.Drawing.Size(151, 46)
        Me.btnModificarTorneo.TabIndex = 30
        Me.btnModificarTorneo.Text = "MODIFICAR TORNEO"
        Me.btnModificarTorneo.UseVisualStyleBackColor = True
        '
        'btnAnadirTorneo
        '
        Me.btnAnadirTorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirTorneo.Location = New System.Drawing.Point(623, 39)
        Me.btnAnadirTorneo.Name = "btnAnadirTorneo"
        Me.btnAnadirTorneo.Size = New System.Drawing.Size(151, 46)
        Me.btnAnadirTorneo.TabIndex = 29
        Me.btnAnadirTorneo.Text = "AÑADIR TORNEO"
        Me.btnAnadirTorneo.UseVisualStyleBackColor = True
        '
        'lblPaisTorneo
        '
        Me.lblPaisTorneo.AutoSize = True
        Me.lblPaisTorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaisTorneo.Location = New System.Drawing.Point(305, 190)
        Me.lblPaisTorneo.Name = "lblPaisTorneo"
        Me.lblPaisTorneo.Size = New System.Drawing.Size(38, 16)
        Me.lblPaisTorneo.TabIndex = 24
        Me.lblPaisTorneo.Text = "País"
        '
        'lblCiudadTorneo
        '
        Me.lblCiudadTorneo.AutoSize = True
        Me.lblCiudadTorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudadTorneo.Location = New System.Drawing.Point(286, 136)
        Me.lblCiudadTorneo.Name = "lblCiudadTorneo"
        Me.lblCiudadTorneo.Size = New System.Drawing.Size(56, 16)
        Me.lblCiudadTorneo.TabIndex = 23
        Me.lblCiudadTorneo.Text = "Ciudad"
        '
        'lblNombreTorneo
        '
        Me.lblNombreTorneo.AutoSize = True
        Me.lblNombreTorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreTorneo.Location = New System.Drawing.Point(280, 88)
        Me.lblNombreTorneo.Name = "lblNombreTorneo"
        Me.lblNombreTorneo.Size = New System.Drawing.Size(62, 16)
        Me.lblNombreTorneo.TabIndex = 20
        Me.lblNombreTorneo.Text = "Nombre"
        '
        'lblIDTorneo
        '
        Me.lblIDTorneo.AutoSize = True
        Me.lblIDTorneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDTorneo.Location = New System.Drawing.Point(321, 42)
        Me.lblIDTorneo.Name = "lblIDTorneo"
        Me.lblIDTorneo.Size = New System.Drawing.Size(22, 16)
        Me.lblIDTorneo.TabIndex = 19
        Me.lblIDTorneo.Text = "ID"
        '
        'listaTorneos
        '
        Me.listaTorneos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaTorneos.FormattingEnabled = True
        Me.listaTorneos.ItemHeight = 16
        Me.listaTorneos.Location = New System.Drawing.Point(31, 19)
        Me.listaTorneos.Name = "listaTorneos"
        Me.listaTorneos.Size = New System.Drawing.Size(202, 180)
        Me.listaTorneos.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnLimpiarPais)
        Me.TabPage2.Controls.Add(Me.btnEliminarPais)
        Me.TabPage2.Controls.Add(Me.btnModificarPais)
        Me.TabPage2.Controls.Add(Me.btnAnadirPais)
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
        'btnLimpiarPais
        '
        Me.btnLimpiarPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarPais.Location = New System.Drawing.Point(637, 238)
        Me.btnLimpiarPais.Name = "btnLimpiarPais"
        Me.btnLimpiarPais.Size = New System.Drawing.Size(151, 46)
        Me.btnLimpiarPais.TabIndex = 22
        Me.btnLimpiarPais.Text = "LIMPIAR CAMPOS"
        Me.btnLimpiarPais.UseVisualStyleBackColor = True
        '
        'btnEliminarPais
        '
        Me.btnEliminarPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPais.Location = New System.Drawing.Point(637, 171)
        Me.btnEliminarPais.Name = "btnEliminarPais"
        Me.btnEliminarPais.Size = New System.Drawing.Size(151, 46)
        Me.btnEliminarPais.TabIndex = 21
        Me.btnEliminarPais.Text = "ELIMINAR PAÍS"
        Me.btnEliminarPais.UseVisualStyleBackColor = True
        '
        'btnModificarPais
        '
        Me.btnModificarPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPais.Location = New System.Drawing.Point(637, 102)
        Me.btnModificarPais.Name = "btnModificarPais"
        Me.btnModificarPais.Size = New System.Drawing.Size(151, 46)
        Me.btnModificarPais.TabIndex = 20
        Me.btnModificarPais.Text = "MODIFICAR PAÍS"
        Me.btnModificarPais.UseVisualStyleBackColor = True
        '
        'btnAnadirPais
        '
        Me.btnAnadirPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirPais.Location = New System.Drawing.Point(637, 41)
        Me.btnAnadirPais.Name = "btnAnadirPais"
        Me.btnAnadirPais.Size = New System.Drawing.Size(151, 46)
        Me.btnAnadirPais.TabIndex = 19
        Me.btnAnadirPais.Text = "AÑADIR PAÍS"
        Me.btnAnadirPais.UseVisualStyleBackColor = True
        '
        'txtNombrePais
        '
        Me.txtNombrePais.Location = New System.Drawing.Point(355, 102)
        Me.txtNombrePais.Name = "txtNombrePais"
        Me.txtNombrePais.Size = New System.Drawing.Size(171, 22)
        Me.txtNombrePais.TabIndex = 18
        '
        'txtIDPais
        '
        Me.txtIDPais.Location = New System.Drawing.Point(355, 53)
        Me.txtIDPais.Name = "txtIDPais"
        Me.txtIDPais.Size = New System.Drawing.Size(171, 22)
        Me.txtIDPais.TabIndex = 17
        '
        'lblNombrePais
        '
        Me.lblNombrePais.AutoSize = True
        Me.lblNombrePais.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePais.Location = New System.Drawing.Point(266, 105)
        Me.lblNombrePais.Name = "lblNombrePais"
        Me.lblNombrePais.Size = New System.Drawing.Size(62, 16)
        Me.lblNombrePais.TabIndex = 16
        Me.lblNombrePais.Text = "Nombre"
        '
        'lblIDPais
        '
        Me.lblIDPais.AutoSize = True
        Me.lblIDPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDPais.Location = New System.Drawing.Point(307, 56)
        Me.lblIDPais.Name = "lblIDPais"
        Me.lblIDPais.Size = New System.Drawing.Size(22, 16)
        Me.lblIDPais.TabIndex = 15
        Me.lblIDPais.Text = "ID"
        '
        'listaPaises
        '
        Me.listaPaises.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaPaises.FormattingEnabled = True
        Me.listaPaises.ItemHeight = 16
        Me.listaPaises.Location = New System.Drawing.Point(34, 41)
        Me.listaPaises.Name = "listaPaises"
        Me.listaPaises.Size = New System.Drawing.Size(202, 196)
        Me.listaPaises.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.ListaTorneosFinalista)
        Me.TabPage1.Controls.Add(Me.listaEdicionesGanadas)
        Me.TabPage1.Controls.Add(Me.TxtID)
        Me.TabPage1.Controls.Add(Me.txtPuntosJugadora)
        Me.TabPage1.Controls.Add(Me.txtNombreJugadora)
        Me.TabPage1.Controls.Add(Me.lblIDJugadora)
        Me.TabPage1.Controls.Add(Me.cbPaisJugadora)
        Me.TabPage1.Controls.Add(Me.btnLimpiarJugadora)
        Me.TabPage1.Controls.Add(Me.btnEliminarJugadora)
        Me.TabPage1.Controls.Add(Me.btnModificarJugadora)
        Me.TabPage1.Controls.Add(Me.btnAnadirJugadora)
        Me.TabPage1.Controls.Add(Me.lblPuntosJugadora)
        Me.TabPage1.Controls.Add(Me.lblPaisJugadora)
        Me.TabPage1.Controls.Add(Me.DateTimeFechaNacJugadora)
        Me.TabPage1.Controls.Add(Me.lblFechaNacJugadora)
        Me.TabPage1.Controls.Add(Me.lblNombreJugadora)
        Me.TabPage1.Controls.Add(Me.lblIDJugadoraa)
        Me.TabPage1.Controls.Add(Me.listaJugadoras)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(828, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "JUGADORA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(652, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 47)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Mostrar Ranking"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Finalista"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Ganadas"
        '
        'ListaTorneosFinalista
        '
        Me.ListaTorneosFinalista.FormattingEnabled = True
        Me.ListaTorneosFinalista.ItemHeight = 16
        Me.ListaTorneosFinalista.Location = New System.Drawing.Point(183, 272)
        Me.ListaTorneosFinalista.Name = "ListaTorneosFinalista"
        Me.ListaTorneosFinalista.Size = New System.Drawing.Size(147, 84)
        Me.ListaTorneosFinalista.TabIndex = 74
        '
        'listaEdicionesGanadas
        '
        Me.listaEdicionesGanadas.FormattingEnabled = True
        Me.listaEdicionesGanadas.ItemHeight = 16
        Me.listaEdicionesGanadas.Location = New System.Drawing.Point(33, 272)
        Me.listaEdicionesGanadas.Name = "listaEdicionesGanadas"
        Me.listaEdicionesGanadas.Size = New System.Drawing.Size(147, 84)
        Me.listaEdicionesGanadas.TabIndex = 73
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(449, 52)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(171, 22)
        Me.TxtID.TabIndex = 72
        '
        'txtPuntosJugadora
        '
        Me.txtPuntosJugadora.Location = New System.Drawing.Point(449, 230)
        Me.txtPuntosJugadora.Name = "txtPuntosJugadora"
        Me.txtPuntosJugadora.Size = New System.Drawing.Size(171, 22)
        Me.txtPuntosJugadora.TabIndex = 10
        '
        'txtNombreJugadora
        '
        Me.txtNombreJugadora.Location = New System.Drawing.Point(449, 97)
        Me.txtNombreJugadora.Name = "txtNombreJugadora"
        Me.txtNombreJugadora.Size = New System.Drawing.Size(171, 22)
        Me.txtNombreJugadora.TabIndex = 5
        '
        'lblIDJugadora
        '
        Me.lblIDJugadora.AutoSize = True
        Me.lblIDJugadora.Location = New System.Drawing.Point(446, 55)
        Me.lblIDJugadora.Name = "lblIDJugadora"
        Me.lblIDJugadora.Size = New System.Drawing.Size(0, 16)
        Me.lblIDJugadora.TabIndex = 71
        '
        'cbPaisJugadora
        '
        Me.cbPaisJugadora.FormattingEnabled = True
        Me.cbPaisJugadora.Location = New System.Drawing.Point(449, 190)
        Me.cbPaisJugadora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbPaisJugadora.Name = "cbPaisJugadora"
        Me.cbPaisJugadora.Size = New System.Drawing.Size(171, 24)
        Me.cbPaisJugadora.TabIndex = 70
        '
        'btnLimpiarJugadora
        '
        Me.btnLimpiarJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarJugadora.Location = New System.Drawing.Point(652, 218)
        Me.btnLimpiarJugadora.Name = "btnLimpiarJugadora"
        Me.btnLimpiarJugadora.Size = New System.Drawing.Size(151, 46)
        Me.btnLimpiarJugadora.TabIndex = 14
        Me.btnLimpiarJugadora.Text = "LIMPIAR CAMPOS"
        Me.btnLimpiarJugadora.UseVisualStyleBackColor = True
        '
        'btnEliminarJugadora
        '
        Me.btnEliminarJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarJugadora.Location = New System.Drawing.Point(652, 154)
        Me.btnEliminarJugadora.Name = "btnEliminarJugadora"
        Me.btnEliminarJugadora.Size = New System.Drawing.Size(151, 46)
        Me.btnEliminarJugadora.TabIndex = 13
        Me.btnEliminarJugadora.Text = "ELIMINAR JUGADORA"
        Me.btnEliminarJugadora.UseVisualStyleBackColor = True
        '
        'btnModificarJugadora
        '
        Me.btnModificarJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarJugadora.Location = New System.Drawing.Point(652, 92)
        Me.btnModificarJugadora.Name = "btnModificarJugadora"
        Me.btnModificarJugadora.Size = New System.Drawing.Size(151, 46)
        Me.btnModificarJugadora.TabIndex = 12
        Me.btnModificarJugadora.Text = "MODIFICAR JUGADORA"
        Me.btnModificarJugadora.UseVisualStyleBackColor = True
        '
        'btnAnadirJugadora
        '
        Me.btnAnadirJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirJugadora.Location = New System.Drawing.Point(652, 28)
        Me.btnAnadirJugadora.Name = "btnAnadirJugadora"
        Me.btnAnadirJugadora.Size = New System.Drawing.Size(151, 46)
        Me.btnAnadirJugadora.TabIndex = 11
        Me.btnAnadirJugadora.Text = "AÑADIR JUGADORA"
        Me.btnAnadirJugadora.UseVisualStyleBackColor = True
        '
        'lblPuntosJugadora
        '
        Me.lblPuntosJugadora.AutoSize = True
        Me.lblPuntosJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntosJugadora.Location = New System.Drawing.Point(359, 233)
        Me.lblPuntosJugadora.Name = "lblPuntosJugadora"
        Me.lblPuntosJugadora.Size = New System.Drawing.Size(58, 16)
        Me.lblPuntosJugadora.TabIndex = 9
        Me.lblPuntosJugadora.Text = "Puntos "
        '
        'lblPaisJugadora
        '
        Me.lblPaisJugadora.AutoSize = True
        Me.lblPaisJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaisJugadora.Location = New System.Drawing.Point(383, 193)
        Me.lblPaisJugadora.Name = "lblPaisJugadora"
        Me.lblPaisJugadora.Size = New System.Drawing.Size(38, 16)
        Me.lblPaisJugadora.TabIndex = 7
        Me.lblPaisJugadora.Text = "País"
        '
        'DateTimeFechaNacJugadora
        '
        Me.DateTimeFechaNacJugadora.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.DateTimeFechaNacJugadora.Location = New System.Drawing.Point(449, 140)
        Me.DateTimeFechaNacJugadora.MaxDate = New Date(2022, 12, 31, 0, 0, 0, 0)
        Me.DateTimeFechaNacJugadora.Name = "DateTimeFechaNacJugadora"
        Me.DateTimeFechaNacJugadora.Size = New System.Drawing.Size(171, 22)
        Me.DateTimeFechaNacJugadora.TabIndex = 6
        '
        'lblFechaNacJugadora
        '
        Me.lblFechaNacJugadora.AutoSize = True
        Me.lblFechaNacJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacJugadora.Location = New System.Drawing.Point(264, 145)
        Me.lblFechaNacJugadora.Name = "lblFechaNacJugadora"
        Me.lblFechaNacJugadora.Size = New System.Drawing.Size(151, 16)
        Me.lblFechaNacJugadora.TabIndex = 3
        Me.lblFechaNacJugadora.Text = "Fecha de nacimiento"
        '
        'lblNombreJugadora
        '
        Me.lblNombreJugadora.AutoSize = True
        Me.lblNombreJugadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreJugadora.Location = New System.Drawing.Point(358, 102)
        Me.lblNombreJugadora.Name = "lblNombreJugadora"
        Me.lblNombreJugadora.Size = New System.Drawing.Size(62, 16)
        Me.lblNombreJugadora.TabIndex = 2
        Me.lblNombreJugadora.Text = "Nombre"
        '
        'lblIDJugadoraa
        '
        Me.lblIDJugadoraa.AutoSize = True
        Me.lblIDJugadoraa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDJugadoraa.Location = New System.Drawing.Point(399, 55)
        Me.lblIDJugadoraa.Name = "lblIDJugadoraa"
        Me.lblIDJugadoraa.Size = New System.Drawing.Size(22, 16)
        Me.lblIDJugadoraa.TabIndex = 1
        Me.lblIDJugadoraa.Text = "ID"
        '
        'listaJugadoras
        '
        Me.listaJugadoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaJugadoras.FormattingEnabled = True
        Me.listaJugadoras.ItemHeight = 16
        Me.listaJugadoras.Location = New System.Drawing.Point(33, 40)
        Me.listaJugadoras.Name = "listaJugadoras"
        Me.listaJugadoras.Size = New System.Drawing.Size(202, 196)
        Me.listaJugadoras.TabIndex = 0
        '
        'Pestañas
        '
        Me.Pestañas.Controls.Add(Me.TabPage1)
        Me.Pestañas.Controls.Add(Me.TabPage2)
        Me.Pestañas.Controls.Add(Me.TabPage3)
        Me.Pestañas.Cursor = System.Windows.Forms.Cursors.Default
        Me.Pestañas.Location = New System.Drawing.Point(-4, 4)
        Me.Pestañas.Name = "Pestañas"
        Me.Pestañas.SelectedIndex = 0
        Me.Pestañas.Size = New System.Drawing.Size(836, 404)
        Me.Pestañas.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 450)
        Me.Controls.Add(Me.Pestañas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Gestor torneos tenis femenino"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Pestañas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents listaGanadoras As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnoEdicion As TextBox
    Friend WithEvents txtCiudadTorneo As TextBox
    Friend WithEvents txtNombreTorneo As TextBox
    Friend WithEvents txtIDTorneo As TextBox
    Friend WithEvents generarEdicion As Button
    Friend WithEvents cbPaisTorneo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents listaEdiciones As ListBox
    Friend WithEvents btnLimpiarTorneo As Button
    Friend WithEvents btnEliminarTorneo As Button
    Friend WithEvents btnModificarTorneo As Button
    Friend WithEvents btnAnadirTorneo As Button
    Friend WithEvents lblPaisTorneo As Label
    Friend WithEvents lblCiudadTorneo As Label
    Friend WithEvents lblNombreTorneo As Label
    Friend WithEvents lblIDTorneo As Label
    Friend WithEvents listaTorneos As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnLimpiarPais As Button
    Friend WithEvents btnEliminarPais As Button
    Friend WithEvents btnModificarPais As Button
    Friend WithEvents btnAnadirPais As Button
    Friend WithEvents txtNombrePais As TextBox
    Friend WithEvents txtIDPais As TextBox
    Friend WithEvents lblNombrePais As Label
    Friend WithEvents lblIDPais As Label
    Friend WithEvents listaPaises As ListBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtID As TextBox
    Friend WithEvents txtPuntosJugadora As TextBox
    Friend WithEvents txtNombreJugadora As TextBox
    Friend WithEvents lblIDJugadora As Label
    Friend WithEvents cbPaisJugadora As ComboBox
    Friend WithEvents btnLimpiarJugadora As Button
    Friend WithEvents btnEliminarJugadora As Button
    Friend WithEvents btnModificarJugadora As Button
    Friend WithEvents btnAnadirJugadora As Button
    Friend WithEvents lblPuntosJugadora As Label
    Friend WithEvents lblPaisJugadora As Label
    Friend WithEvents DateTimeFechaNacJugadora As DateTimePicker
    Friend WithEvents lblFechaNacJugadora As Label
    Friend WithEvents lblNombreJugadora As Label
    Friend WithEvents lblIDJugadoraa As Label
    Friend WithEvents listaJugadoras As ListBox
    Friend WithEvents Pestañas As TabControl
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListaTorneosFinalista As ListBox
    Friend WithEvents listaEdicionesGanadas As ListBox
End Class
