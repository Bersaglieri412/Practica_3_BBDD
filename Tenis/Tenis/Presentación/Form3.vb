Public Class Form3
    Public Property j As Jugadora
    Public Sub rellenar()
        Try
            j.edicionesF.Clear()
            j.edicionesG.Clear()
            j.leerTodasRanking()
            For Each jug In j.JugDAO.Jugadora
                Me.listaRanking.Items.Add(jug.nombre)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub listaRanking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaRanking.SelectedIndexChanged
        Try
            Me.j.nombre = Me.listaRanking.SelectedItem.ToString
            j.buscarID()
            j.LeerJugadora()
            Me.ListaEdiciones.Items.Clear()
            Me.listaTorneos.Items.Clear()
            Me.ListaTorneosFinalista.Items.Clear()
            Me.listaEdicionesGanadas.Items.Clear()
            j.edicionesF.Clear()
            j.edicionesG.Clear()
            j.torneosP.Clear()
            j.leerFinales()
            j.leerGanadas()
            j.leerParticipaciones()
            Me.txtpuntos.Text = j.puntos
            Me.txtNfinales.Text = j.edicionesF.Count
            Me.txtvecesganadora.Text = j.edicionesG.Count
            Me.txtParticipaciones.Text = j.torneosP.Count

            For Each t In j.edicionesF
                Me.ListaTorneosFinalista.Items.Add(t(1) & " " & t(2))
            Next
            For Each t In j.edicionesG
                Me.listaEdicionesGanadas.Items.Add(t(1) & " " & t(2))
            Next
            For Each t In j.torneosP
                Me.listaTorneos.Items.Add(t(1))
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

    End Sub
    Private Sub listaTorneos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaTorneos.SelectedIndexChanged
        If Not Me.listaRanking.SelectedItem Is Nothing And Not Me.listaTorneos.SelectedItem Is Nothing Then
            Try
                Me.ListaEdiciones.Items.Clear()
                j.edicionesP.Clear()
                Dim t As Torneo
                t = New Torneo()
                t.nombreTorneo = Me.listaTorneos.SelectedItem.ToString
                t.buscarID()
                j.nombre = Me.listaRanking.SelectedItem.ToString
                j.buscarID()
                j.leerParticipacionEdiciones(t)
                For Each ed In j.edicionesP
                    Me.ListaEdiciones.Items.Add(ed(1))
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            MsgBox("Debe tener seleccionada una jugadora y un torneo")
        End If
    End Sub

    Private Sub ListaEdiciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaEdiciones.SelectedIndexChanged
        If Not Me.ListaEdiciones Is Nothing Then
            Try
                Me.txtResultado.Text = String.Empty
                Dim ed As Ediciones
                Dim t As Torneo
                t = New Torneo()
                t.nombreTorneo = Me.listaTorneos.SelectedItem.ToString
                t.buscarID()
                ed = New Ediciones(Me.ListaEdiciones.SelectedItem.ToString, t)
                j.leerPosicion(ed)
                Me.txtResultado.Text = j.posicion
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            MsgBox("Debe seleccionar una edición")
        End If
    End Sub
End Class