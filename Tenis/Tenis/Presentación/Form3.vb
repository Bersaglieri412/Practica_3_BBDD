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
            Me.TextBox1.ReadOnly = False
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
        If Not Me.ListaEdiciones Is Nothing And Not Me.listaTorneos Is Nothing Then
            Try
                Me.txtResultado.Text = String.Empty
                Dim ed As Ediciones
                Dim t As Torneo
                t = New Torneo()
                t.nombreTorneo = Me.listaTorneos.SelectedItem.ToString
                t.buscarID()
                ed = New Ediciones(Me.ListaEdiciones.SelectedItem.ToString, t)
                j.leerPosicion(ed)
                establecerPosicion(j)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            MsgBox("Debe seleccionar una edición")
        End If
    End Sub
    Public Function establecerPosicion(j As Jugadora) As String
        Dim c As Char = j.posicion
        Select Case c
            Case "c"
                If j.id = j.posicionPos Then
                    Me.txtResultado.Text = "Semifinalista"
                    Me.txtPuntosObtenidos.Text = "+25"
                Else
                    Me.txtResultado.Text = "Cuartofinalista"
                    Me.txtPuntosObtenidos.Text = "+15"

                End If

            Case "s"
                If j.id = j.posicionPos Then
                    Me.txtResultado.Text = "Finalista"
                    Me.txtPuntosObtenidos.Text = "+50"

                Else
                    Me.txtResultado.Text = "Semifinalista"
                    Me.txtPuntosObtenidos.Text = "+25"

                End If

            Case "f"
                If j.id = j.posicionPos Then
                    Me.txtResultado.Text = "Ganadora"
                    Me.txtPuntosObtenidos.Text = "+100"

                Else
                    Me.txtResultado.Text = "Finalista"
                    Me.txtPuntosObtenidos.Text = "+50"

                End If
        End Select
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not Me.listaRanking.SelectedItem Is Nothing Then
            Try
                j.torneosPa.Clear()
                Me.ListBox1.Items.Clear()
                j.leeParticipacionAño(Me.TextBox1.Text)
                For Each p In j.torneosPa
                    Me.ListBox1.Items.Add(p(1))
                Next
            Catch ex As Exception

            End Try
        Else
            MsgBox("Debe seleccionar antes una jugadora")
        End If

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.ReadOnly = True
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not Me.ListBox1 Is Nothing And Not Me.TextBox1 Is Nothing Then
            Try
                Me.txtResultado.Text = String.Empty
                Me.txtPuntosObtenidos.Text = String.Empty
                Dim ed As Ediciones
                Dim t As Torneo
                t = New Torneo()
                t.nombreTorneo = Me.ListBox1.SelectedItem.ToString
                t.buscarID()
                ed = New Ediciones(Me.TextBox1.Text, t)
                j.leerPosicion(ed)
                establecerPosicion(j)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            MsgBox("Debe seleccionar una edición")
        End If
    End Sub
End Class