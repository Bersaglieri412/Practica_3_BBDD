Public Class Form1

    Private j As Jugadora
    Private p As Pais
    Private t As Torneo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pAux As Jugadora
        Dim pAux1 As Pais
        Dim paises As Collection
        paises = New Collection
        Me.j = New Jugadora
        Me.p = New Pais
        Me.t = New Torneo
        Me.TxtID.Enabled = False
        Me.btnEliminarJugadora.Enabled = False
        Me.btnLimpiarJugadora.Enabled = False
        Me.btnModificarJugadora.Enabled = False
        Me.cbPaisJugadora.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cbPaisTorneo.DropDownStyle = ComboBoxStyle.DropDownList
        Me.txtPuntosJugadora.Enabled = False
        Me.txtIDTorneo.Enabled = False
        Me.btnModificarTorneo.Enabled = False
        Me.btnLimpiarTorneo.Enabled = False
        Me.btnEliminarTorneo.Enabled = False
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
            Me.j.nombre = listaJugadoras.SelectedItem.ToString
            Try
                Me.j.buscarID()
                Me.j.LeerJugadora()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
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
        Me.TxtID.Clear()
        Me.txtNombreJugadora.Clear()
        Me.txtPuntosJugadora.Clear()
        Me.cbPaisJugadora.BringToFront()
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

            Me.t.nombreTorneo = listaTorneos.SelectedItem.ToString
            Dim ed As Ediciones
            Try
                Me.t.buscarID()
                Me.t.ediciones.Clear()
                Me.t.LeerJugadora()
                Me.t.paisTorneo.LeerPais()
                For Each ed In Me.t.ediciones
                    Me.listaEdiciones.Items.Add(ed.anualidad.ToString)
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.txtIDTorneo.Text = t.idTorneo
            Me.txtNombreTorneo.Text = t.nombreTorneo
            Me.cbPaisTorneo.SelectedIndex = Me.cbPaisTorneo.FindString(t.paisTorneo.nombre)
            Me.txtCiudadTorneo.Text = t.ciudadTorneo
        Else
            Me.btnLimpiarJugadora.PerformClick()
        End If
    End Sub

    Private Sub btnLimpiarTorneo_Click(sender As Object, e As EventArgs) Handles btnLimpiarTorneo.Click
        Me.txtIDPais.Clear()
        Me.txtCiudadTorneo.Clear()
        Me.txtNombreTorneo.Clear()
        Me.cbPaisTorneo.BringToFront()
        Me.listaEdiciones.Items.Clear()
        Me.btnModificarTorneo.Enabled = False
        Me.btnLimpiarTorneo.Enabled = False
        Me.btnEliminarTorneo.Enabled = False
        Me.btnAnadirTorneo.Enabled = True
    End Sub

    Private Sub btnModificarTorneo_Click(sender As Object, e As EventArgs) Handles btnModificarTorneo.Click
        If Me.listaTorneos.SelectedItem <> String.Empty Then
            If Me.txtCiudadTorneo.Text <> String.Empty And Me.txtNombreTorneo.Text <> String.Empty Then

                Try
                    t = New Torneo
                    t.idTorneo = Me.txtIDTorneo.Text
                    t.nombreTorneo = Me.txtNombreTorneo.Text
                    t.ciudadTorneo = txtPuntosJugadora.Text
                    p = New Pais(Me.cbPaisTorneo.SelectedItem)
                    p.LeerPais()
                    t.paisTorneo = p
                    'Lo mismo aquí, a lo mejor vendría bien una excepción específica

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
        If Not p Is Nothing Then
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
            Me.btnLimpiarJugadora.PerformClick()
        End If
    End Sub

End Class
