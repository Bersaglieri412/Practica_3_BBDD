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

End Class
