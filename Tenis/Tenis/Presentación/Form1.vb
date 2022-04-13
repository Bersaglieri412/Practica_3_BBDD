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
        Me.lblPuntosJugadora.Enabled = False
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
        Next
        For Each eAux In t.TorDAO.Torneo
            Me.listaTorneos.Items.Add(eAux.nombreTorneo)
        Next
        Me.cbPaisJugadora.DataSource = paises
    End Sub

    Private Sub btnAnadirJugadora_Click(sender As Object, e As EventArgs) Handles btnAnadirJugadora.Click

        ' Si "txtID" NO está vacío y "txtNombre" NO está vacío
        If Me.txtNombreJugadora.Text <> String.Empty And Me.txtPuntosJugadora.Text <> String.Empty Then ' los "<>" significa que es distinto 
            Try
                j = New Jugadora
                j.nombre = txtNombreJugadora.Text
                j.puntos = txtPuntosJugadora.Text
                j.fechaNacimiento = DateTimeFechaNacJugadora.Value.ToString("yyyy-MM-dd HH:mm:ss.fff")
                p.nombre = cbPaisJugadora.SelectedItem.ToString
                p.PaisDAO.buscarID(p)
                j.pais_jug = New Pais(p.id)
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
        Me.btnAnadirJugadora.Enabled = False
        Me.btnEliminarJugadora.Enabled = True
        Me.btnLimpiarJugadora.Enabled = True
        Me.btnModificarJugadora.Enabled = True
        Me.lblPuntosJugadora.Enabled = True
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

        If Not p Is Nothing Then
            If MessageBox.Show("¿Estás seguro de que quieres borrar " & Me.txtNombreJugadora.Text & "?", "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Try

                    j.id = TxtID.Text

                    If j.BorrarJugadora <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Exit Sub
                End Try
                Me.listaJugadoras.Items.RemoveAt(Me.listaJugadoras.FindString(Me.txtNombreJugadora.Text.ToString))
                MessageBox.Show(p.nombre & " eliminado correctamente")
            End If
            Me.btnLimpiarJugadora.PerformClick()
        End If
    End Sub
End Class
