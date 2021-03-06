Public Class Form1

    Private j As Jugadora
    Private p As Pais
    Private t As Torneo
    Private ed As Ediciones
    Public Property consultas As Consultas
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultas = New Consultas()
        Dim pAux As Jugadora
        Dim pAux1 As Pais
        Dim paises As Collection
        paises = New Collection
        Me.j = New Jugadora
        Me.p = New Pais
        Me.t = New Torneo
        Me.btnLimpiarTorneo.PerformClick()
        Me.listaEdicionesGanadas.Items.Clear()
        Me.listaJugadoras.Items.Clear()
        Me.listaEdiciones.Items.Clear()
        Me.listaPaises.Items.Clear()
        Me.listaTorneos.Items.Clear()

        Me.generarEdicion.Enabled = False
        Me.txtAnoEdicion.Enabled = False
        Me.TxtID.Enabled = False
        Me.btnEliminarJugadora.Enabled = False
        Me.btnLimpiarJugadora.Enabled = False
        Me.btnModificarJugadora.Enabled = False
        Me.cbPaisJugadora.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cbPaisTorneo.DropDownStyle = ComboBoxStyle.DropDownList
        Me.txtPuntosJugadora.Enabled = False
        Me.txtIDTorneo.Enabled = False
        Me.txtIDPais.Enabled = False
        Me.btnModificarTorneo.Enabled = False
        Me.btnLimpiarTorneo.Enabled = False
        Me.btnEliminarTorneo.Enabled = False
        Me.btnModificarPais.Enabled = False
        Me.btnLimpiarPais.Enabled = False
        Me.btnEliminarPais.Enabled = False
        Try
            Me.j.LeerTodasPersonas()
            Me.t.LeerTodasPersonas()
            p.LeerTodasPersonas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In j.JugDAO.Jugadora
            Me.listaJugadoras.Items.Add(pAux.nombre)
        Next
        For Each pAux1 In p.PaisDAO.Pais
            paises.Add(pAux1.nombre)
            Me.listaPaises.Items.Add(pAux1.nombre)
        Next
        For Each eAux In t.TorDAO.Torneo
            Me.listaTorneos.Items.Add(eAux.nombreTorneo)
        Next

        Me.cbPaisJugadora.DataSource = paises
        Me.cbPaisTorneo.DataSource = paises
    End Sub

    Private Sub btnAnadirJugadora_Click(sender As Object, e As EventArgs) Handles btnAnadirJugadora.Click

        ' Si "txtID" NO está vacío y "txtNombre" NO está vacío
        If Me.txtNombreJugadora.Text <> String.Empty Then ' los "<>" significa que es distinto 
            Try
                j = New Jugadora
                j.nombre = txtNombreJugadora.Text
                j.fechaNacimiento = DateTimeFechaNacJugadora.Value.ToString("yyyy-MM-dd HH:mm:ss.fff")
                p.nombre = cbPaisJugadora.SelectedItem.ToString
                p.PaisDAO.buscarID(p)
                j.pais_jug = p
                'A lo mejor habría que añadir una excepción específica para decir que están mal los datos de entrada
                If j.InsertarJugadora() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            Me.listaJugadoras.Items.Add(j.nombre) ' Añadir a la lstPersonas, el ID de la persona añadida a la bd recientemente
        End If

    End Sub

    Private Sub listaJugadoras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaJugadoras.SelectedIndexChanged
        If Not Me.listaJugadoras.SelectedItem Is Nothing Then
            Me.btnAnadirJugadora.Enabled = False
            Me.btnEliminarJugadora.Enabled = True
            Me.btnLimpiarJugadora.Enabled = True
            Me.btnModificarJugadora.Enabled = True
            Me.lblPuntosJugadora.Enabled = True
            Me.listaEdicionesGanadas.Items.Clear()
            Me.ListaTorneosFinalista.Items.Clear()
            Me.j.nombre = listaJugadoras.SelectedItem.ToString
            Try
                Me.j.JugDAO.edicionesG.Clear()
                Me.j.JugDAO.edicionesF.Clear()
                Me.j.buscarID()
                Me.j.LeerJugadora()
                Me.consultas.leerGanadas(j)
                Me.consultas.leerFinales(j)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            For Each aux In j.JugDAO.edicionesG
                Me.listaEdicionesGanadas.Items.Add(aux(1) & " " & aux(2))
            Next
            For Each aux In j.JugDAO.edicionesF
                Me.ListaTorneosFinalista.Items.Add(aux(1) & " " & aux(2))
            Next
            Me.TxtID.Text = j.id
            Me.txtNombreJugadora.Text = j.nombre
            Me.txtPuntosJugadora.Text = j.puntos
            Me.DateTimeFechaNacJugadora.Value = j.fechaNacimiento
            Me.cbPaisJugadora.SelectedIndex = Me.cbPaisJugadora.FindString(j.pais_jug.id)
        End If

    End Sub

    Private Sub btnLimpiarJugadora_Click(sender As Object, e As EventArgs) Handles btnLimpiarJugadora.Click
        Me.btnAnadirJugadora.Enabled = True
        Me.btnEliminarJugadora.Enabled = False
        Me.btnLimpiarJugadora.Enabled = False
        Me.btnModificarJugadora.Enabled = False
        Me.listaEdicionesGanadas.Items.Clear()
        Me.ListaTorneosFinalista.Items.Clear()
        Me.TxtID.Clear()
        Me.txtNombreJugadora.Clear()
        Me.txtPuntosJugadora.Clear()
        Me.cbPaisJugadora.BringToFront()
        Me.listaJugadoras.ClearSelected()
        Me.DateTimeFechaNacJugadora.Value = Date.Now
    End Sub

    Private Sub btnModificarJugadora_Click(sender As Object, e As EventArgs) Handles btnModificarJugadora.Click
        If Me.listaJugadoras.SelectedItem <> String.Empty Then
            If Me.txtNombreJugadora.Text <> String.Empty And Me.txtPuntosJugadora.Text <> String.Empty Then

                Try
                    j = New Jugadora
                    j.id = TxtID.Text
                    j.nombre = txtNombreJugadora.Text
                    j.puntos = txtPuntosJugadora.Text
                    j.fechaNacimiento = DateTimeFechaNacJugadora.Value.ToString("yyyy-MM-dd HH:mm:ss.fff")
                    p.nombre = cbPaisJugadora.SelectedItem.ToString
                    p.PaisDAO.buscarID(p)
                    j.pais_jug = New Pais(p.id)
                    'Lo mismo aquí, a lo mejor vendría bien una excepción específica

                    If j.ActualizarJugadora() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Exit Sub
                End Try
                MessageBox.Show(j.nombre & " actualizado correctamente")

                If listaJugadoras.SelectedIndex.ToString() <> j.nombre.ToString() Then
                    Me.listaJugadoras.Items.Add(j.nombre)
                    Me.listaJugadoras.Items.Remove(listaJugadoras.SelectedItem)
                End If
            End If
        Else
            MsgBox("Debe seleccionar una jugadora de la lista para modificar", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnEliminarJugadora_Click(sender As Object, e As EventArgs) Handles btnEliminarJugadora.Click

        If MessageBox.Show("¿Estás seguro de que quieres borrar " & Me.txtNombreJugadora.Text & "?", "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Try

                    j.id = TxtID.Text
                j.nombre = txtNombreJugadora.Text
                If j.BorrarJugadora <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Exit Sub
                End Try
                Me.listaJugadoras.Items.RemoveAt(Me.listaJugadoras.FindString(Me.txtNombreJugadora.Text.ToString))
            MessageBox.Show(j.nombre & " eliminado correctamente")
        End If
        Me.btnLimpiarJugadora.PerformClick()
    End Sub

    Private Sub listaTorneos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaTorneos.SelectedIndexChanged
        If Not Me.listaTorneos.SelectedItem Is Nothing Then
            Me.btnModificarTorneo.Enabled = True
            Me.btnLimpiarTorneo.Enabled = True
            Me.btnEliminarTorneo.Enabled = True
            Me.listaEdiciones.Items.Clear()
            Me.btnAnadirTorneo.Enabled = False
            Me.generarEdicion.Enabled = True
            Me.txtAnoEdicion.Enabled = True

            Me.t.nombreTorneo = listaTorneos.SelectedItem.ToString
            Dim ed As Ediciones
            Try
                Me.t.buscarID()
                Me.t.TorDAO.Ediciones.Clear()
                Me.t.LeerJugadora()
                Me.t.paisTorneo.LeerPais()
                Me.t.leerGanadoras()
                Dim i As Integer = 0

                For Each ed In Me.t.TorDAO.Ediciones
                    ed.ganadora.LeerJugadora()
                    Me.listaEdiciones.Items.Add(ed.anualidad.ToString & " Ganadora:" & ed.ganadora.nombre)
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.txtIDTorneo.Text = t.idTorneo
            Me.txtNombreTorneo.Text = t.nombreTorneo
            Me.cbPaisTorneo.SelectedIndex = Me.cbPaisTorneo.FindString(t.paisTorneo.nombre)
            Me.txtCiudadTorneo.Text = t.ciudadTorneo
        Else
            Me.btnLimpiarTorneo.PerformClick()
        End If
    End Sub

    Private Sub btnLimpiarTorneo_Click(sender As Object, e As EventArgs) Handles btnLimpiarTorneo.Click
        Me.txtIDPais.Clear()
        Me.txtCiudadTorneo.Clear()
        Me.txtNombreTorneo.Clear()
        Me.cbPaisTorneo.BringToFront()
        Me.listaEdiciones.Items.Clear()
        Me.listaTorneos.ClearSelected()
        Me.btnModificarTorneo.Enabled = False
        Me.btnLimpiarTorneo.Enabled = False
        Me.btnEliminarTorneo.Enabled = False
        Me.btnAnadirTorneo.Enabled = True
        Me.generarEdicion.Enabled = False
        Me.txtAnoEdicion.Enabled = False
        Me.txtIDTorneo.Text = String.Empty
        Me.txtNombreTorneo.Text = String.Empty
        Me.txtCiudadTorneo.Text = String.Empty
    End Sub

    Private Sub btnModificarTorneo_Click(sender As Object, e As EventArgs) Handles btnModificarTorneo.Click
        If Me.listaTorneos.SelectedItem <> String.Empty Then
            If Me.txtCiudadTorneo.Text <> String.Empty And Me.txtNombreTorneo.Text <> String.Empty Then

                Try
                    t = New Torneo
                    t.idTorneo = Me.txtIDTorneo.Text
                    t.nombreTorneo = Me.txtNombreTorneo.Text
                    t.ciudadTorneo = Me.txtCiudadTorneo.Text
                    p = New Pais(Me.cbPaisTorneo.SelectedItem)
                    p.LeerPais()
                    t.paisTorneo = p

                    If t.ActualizarJugadora() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Exit Sub
                End Try
                MessageBox.Show(t.nombreTorneo & " actualizado correctamente")

                If listaTorneos.SelectedIndex.ToString() <> t.nombreTorneo.ToString() Then
                    Me.listaTorneos.Items.Add(t.nombreTorneo)
                    Me.listaTorneos.Items.Remove(listaTorneos.SelectedItem)
                End If
            End If
        Else
            MsgBox("Debe seleccionar un torneo de la lista para modificar", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnAnadirTorneo_Click(sender As Object, e As EventArgs) Handles btnAnadirTorneo.Click
        If Me.txtNombreTorneo.Text <> String.Empty And Me.txtCiudadTorneo.Text <> String.Empty Then ' los "<>" significa que es distinto 
            Try
                t = New Torneo
                t.nombreTorneo = Me.txtNombreTorneo.Text
                t.ciudadTorneo = Me.txtCiudadTorneo.Text
                p.nombre = cbPaisTorneo.SelectedItem.ToString
                p.PaisDAO.buscarID(p)
                t.paisTorneo = p
                'A lo mejor habría que añadir una excepción específica para decir que están mal los datos de entrada
                If t.InsertarJugadora() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            Me.listaTorneos.Items.Add(t.nombreTorneo) ' Añadir a la lstPersonas, el ID de la persona añadida a la bd recientemente
        End If

    End Sub

    Private Sub btnEliminarTorneo_Click(sender As Object, e As EventArgs) Handles btnEliminarTorneo.Click
        If MessageBox.Show("¿Estás seguro de que quieres borrar " & Me.txtNombreTorneo.Text & "?", "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Try

                t.idTorneo = Me.txtIDTorneo.Text
                t.nombreTorneo = Me.txtNombreTorneo.Text
                If t.BorrarJugadora <> 1 Then
                    MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Exit Sub
            End Try
            Me.listaTorneos.Items.RemoveAt(Me.listaTorneos.FindString(Me.txtNombreTorneo.Text.ToString))
            MessageBox.Show(t.nombreTorneo & " eliminado correctamente")
        End If
        Me.btnLimpiarTorneo.PerformClick()
    End Sub

    Private Sub btnAnadirPais_Click(sender As Object, e As EventArgs) Handles btnAnadirPais.Click
        If Me.txtNombrePais.Text <> String.Empty Then
            Me.p.nombre = Me.txtNombrePais.Text
            Me.p.id = Me.txtNombrePais.Text.Substring(0, 3).ToUpper
            Try
                If Me.p.InsertarPais() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.listaPaises.Items.Add(Me.p.nombre)
            'Me.cbPaisJugadora.DataSource = Me.listaPaises.Items
            'Me.cbPaisTorneo.DataSource = Me.listaPaises.Items
            Form1_Load(sender, e)
        End If
    End Sub

    Private Sub txtNombrePais_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePais.TextChanged
        If Not Me.txtNombrePais.Text = String.Empty Then
            If Not comprobarLetras(Me.txtNombrePais.Text.ToCharArray.GetValue(Me.txtNombrePais.Text.Length - 1)) Then
                If Me.txtNombrePais.Text.Length = 1 Then
                    Me.txtNombrePais.Text = String.Empty

                Else
                    Me.txtNombrePais.Text = Me.txtNombrePais.Text.Substring(0, Me.txtNombrePais.Text.Length - 1)
                End If
                MsgBox("El campo nombre no puede contener cifras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
        If Len(Me.txtNombrePais.Text) < 3 Then
            Me.txtIDPais.Text = Me.txtNombrePais.Text.Substring(0, Len(Me.txtNombrePais.Text)).ToUpper
        Else
            Me.txtIDPais.Text = Me.txtNombrePais.Text.Substring(0, 3).ToUpper
        End If

    End Sub

    Private Sub listaPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaPaises.SelectedIndexChanged
        If Not Me.listaPaises.SelectedItem Is Nothing Then
            Me.btnAnadirPais.Enabled = False
            Me.btnModificarPais.Enabled = True
            Me.btnLimpiarPais.Enabled = True
            Me.btnEliminarPais.Enabled = True
            Try
                Me.p.nombre = Me.listaPaises.SelectedItem.ToString()
                Me.p.buscarId()
                Me.p.id_antiguo = p.id
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.txtNombrePais.Text = p.nombre
        Else
            Me.btnLimpiarPais.PerformClick()
        End If
    End Sub

    Private Sub btnLimpiarPais_Click(sender As Object, e As EventArgs) Handles btnLimpiarPais.Click
        Me.btnAnadirPais.Enabled = True
        Me.btnModificarPais.Enabled = False
        Me.btnLimpiarPais.Enabled = False
        Me.btnEliminarPais.Enabled = False
        Me.txtNombrePais.Clear()
        Me.txtIDPais.Clear()
        Me.listaPaises.ClearSelected()
    End Sub

    Private Sub btnEliminarPais_Click(sender As Object, e As EventArgs) Handles btnEliminarPais.Click
        If MessageBox.Show("¿Estás seguro de que quieres borrar " & Me.txtNombrePais.Text & "?", "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Try
                p.id = Me.txtIDPais.Text
                p.nombre = Me.txtNombrePais.Text
                If p.BorrarPais <> 1 Then
                    MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Exit Sub
            End Try
            Me.listaPaises.Items.RemoveAt(Me.listaPaises.Items.IndexOf(p.nombre))
            Form1_Load(sender, e)
            MessageBox.Show(Me.p.nombre & " eliminado correctamente")
        End If
        Me.btnLimpiarPais.PerformClick()
    End Sub

    Private Sub btnModificarPais_Click(sender As Object, e As EventArgs) Handles btnModificarPais.Click
        If Me.listaPaises.SelectedItem <> String.Empty Then
            If Me.txtNombrePais.Text <> String.Empty Then

                Try
                    p.nombre = Me.txtNombrePais.Text
                    p.id = Me.txtIDPais.Text

                    If p.ActualizarPais() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Exit Sub
                End Try
                MessageBox.Show(p.nombre & " actualizado correctamente")
                Me.listaPaises.Items.Add(p.nombre)
                Me.listaPaises.Items.Remove(listaPaises.SelectedItem)
                Form1_Load(sender, e)

            End If
        Else
            MsgBox("Debe seleccionar un torneo de la lista para modificar", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub generarEdicion_Click(sender As Object, e As EventArgs) Handles generarEdicion.Click
        If Me.txtAnoEdicion.Text <> String.Empty Then
            Try
                If Convert.ToInt32(Me.txtAnoEdicion.Text) > 1900 And Convert.ToInt32(Me.txtAnoEdicion.Text) < 2100 Then
                    Dim tor As Torneo
                    tor = New Torneo(Me.txtIDTorneo.Text)

                    If consultas.añadirEdicion(tor, Me.txtAnoEdicion.Text) <> 1 Then
                        MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    Form1_Load(sender, e)
                    If MessageBox.Show("Gandora: " & tor.TorDAO.Ediciones(tor.TorDAO.Ediciones.Count).ganadora.nombre & Environment.NewLine & "Sus puntos suman: " & tor.TorDAO.Ediciones(tor.TorDAO.Ediciones.Count).ganadora.puntos & Environment.NewLine & "¿Desea ver el árbol de partidos detallado?", "¡Edición celebrada!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Form2.rellenar(tor.TorDAO.Ediciones(tor.TorDAO.Ediciones.Count))
                        Form2.Visible = True
                    End If


                Else
                    MsgBox("El año debe estar comprendido entre 1900 y 2100", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        Else
            MsgBox("Debes poner un valor en el campo año")
        End If

    End Sub

    Private Sub listaEdiciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaEdiciones.SelectedIndexChanged
        If Not Me.listaEdiciones.SelectedItem Is Nothing Then
            For Each edicion In t.TorDAO.Ediciones
                If edicion.anualidad = Me.listaEdiciones.SelectedItem.ToString.Split.ToArray(0) Then
                    ed = edicion
                    Exit For
                End If
            Next
            Form2.rellenar(ed)
            Form2.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.j = j
        Form3.rellenar()
        Form3.Visible = True
    End Sub

    Private Sub txtAnoEdicion_TextChanged(sender As Object, e As EventArgs) Handles txtAnoEdicion.TextChanged
        If Me.txtAnoEdicion.Text.Length > 4 Then
            Me.txtAnoEdicion.Text = Me.txtAnoEdicion.Text.Substring(0, 4)
            MsgBox("El campo año no debe tener más de 4 cifras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtCiudadTorneo_TextChanged(sender As Object, e As EventArgs) Handles txtCiudadTorneo.TextChanged
        If Not Me.txtCiudadTorneo.Text = String.Empty Then
            If Not comprobarLetras(Me.txtCiudadTorneo.Text.ToCharArray.GetValue(Me.txtCiudadTorneo.Text.Length - 1)) Then
                If Me.txtCiudadTorneo.Text.Length = 1 Then
                    Me.txtCiudadTorneo.Text = String.Empty

                Else
                    Me.txtCiudadTorneo.Text = Me.txtCiudadTorneo.Text.Substring(0, Me.txtCiudadTorneo.Text.Length - 1)
                End If
                MsgBox("El campo ciudad no puede contener cifras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
    Private Function comprobarLetras(c As Char) As Boolean
        If IsNumeric(c) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub txtNombreTorneo_TextChanged(sender As Object, e As EventArgs) Handles txtNombreTorneo.TextChanged
        If Not Me.txtNombreTorneo.Text = String.Empty Then
            If Not comprobarLetras(Me.txtNombreTorneo.Text.ToCharArray.GetValue(Me.txtNombreTorneo.Text.Length - 1)) Then
                If Me.txtNombreTorneo.Text.Length = 1 Then
                    Me.txtNombreTorneo.Text = String.Empty

                Else
                    Me.txtNombreTorneo.Text = Me.txtNombreTorneo.Text.Substring(0, Me.txtNombreTorneo.Text.Length - 1)
                End If
                MsgBox("El campo nombre no puede contener cifras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub txtNombreJugadora_TextChanged(sender As Object, e As EventArgs) Handles txtNombreJugadora.TextChanged
        If Not Me.txtNombreJugadora.Text = String.Empty Then
            If Not comprobarLetras(Me.txtNombreJugadora.Text.ToCharArray.GetValue(Me.txtNombreJugadora.Text.Length - 1)) Then
                If Me.txtNombreJugadora.Text.Length = 1 Then
                    Me.txtNombreJugadora.Text = String.Empty

                Else
                    Me.txtNombreJugadora.Text = Me.txtNombreJugadora.Text.Substring(0, Me.txtNombreJugadora.Text.Length - 1)
                End If
                MsgBox("El campo nombre no puede contener cifras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub txtIDPais_TextChanged(sender As Object, e As EventArgs) Handles txtIDPais.TextChanged
        p.id = Me.txtIDPais.Text
    End Sub
End Class
