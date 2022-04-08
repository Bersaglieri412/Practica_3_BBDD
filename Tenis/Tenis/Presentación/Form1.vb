Public Class Form1

    Private j As Jugadora
    Private p As Pais
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pAux As Jugadora
        Dim pAux1 As Pais
        Dim paises As Collection
        paises = New Collection
        Me.j = New Jugadora
        Me.p = New Pais
        Me.TxtID.Enabled = False
        Me.btnEliminarJugadora.Enabled = False
        Me.btnLimpiarJugadora.Enabled = False
        Me.btnModificarJugadora.Enabled = False
        Try
            Me.j.LeerTodasPersonas()
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
        Me.cbPaisJugadora.DataSource = paises
    End Sub

    Private Sub btnAnadirJugadora_Click(sender As Object, e As EventArgs) Handles btnAnadirJugadora.Click

        ' Si "txtID" NO está vacío y "txtNombre" NO está vacío
        If Me.txtNombreJugadora.Text <> String.Empty And Me.txtPuntosJugadora.Text <> String.Empty Then ' los "<>" significa que es distinto 

            j = New Jugadora
            j.nombre = txtNombreJugadora.Text
            j.puntos = txtPuntosJugadora.Text
            j.fechaNacimiento = DateTimeFechaNacJugadora.Value.ToString("yyyy-MM-dd HH:mm:ss.fff")
            p.nombre = cbPaisJugadora.SelectedItem.ToString
            p.PaisDAO.buscarID(p)
            j.pais_jug = New Pais(p.id)


            Try
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
        End If
        Me.btnAnadirJugadora.Enabled = False
        Me.btnEliminarJugadora.Enabled = True
        Me.btnLimpiarJugadora.Enabled = True
        Me.btnModificarJugadora.Enabled = True
    End Sub

    Private Sub btnLimpiarJugadora_Click(sender As Object, e As EventArgs) Handles btnLimpiarJugadora.Click
        Me.btnAnadirJugadora.Enabled = True
        Me.btnEliminarJugadora.Enabled = False
        Me.btnLimpiarJugadora.Enabled = False
        Me.btnModificarJugadora.Enabled = False
        Me.TxtID.Clear()
        Me.txtNombreJugadora.Clear()
        Me.txtPuntosJugadora.Clear()
        Me.DateTimeFechaNacJugadora.Value = Date.Now
    End Sub
End Class
