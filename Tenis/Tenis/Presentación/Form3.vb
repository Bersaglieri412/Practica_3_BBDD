Public Class Form3
    Public Property j As Jugadora

    Public Sub rellenar()
        Try
            j.JugDAO.edicionesF.Clear()
            j.JugDAO.edicionesG.Clear()
            j.leerTodasRanking()
            Dim i As Integer = 1
            For Each jug In j.JugDAO.Jugadora
                Me.listaRanking.Items.Add(i & "º Posición:  " & jug.nombre)
                i += 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub listaRanking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaRanking.SelectedIndexChanged
        Try
            Me.cbAños.Items.Clear()
            Dim cad() = Me.listaRanking.SelectedItem.ToString.Split().ToArray
            If (cad.Length = 5) Then
                Me.j.nombre = cad(3) & " " & cad(4)
            ElseIf cad.Length = 4 Then
                Me.j.nombre = cad(3)
            Else
                Me.j.nombre = cad(3)
                For i = 4 To cad.Length - 1
                    Me.j.nombre = j.nombre & " " & cad(i)
                Next i
            End If
            j.buscarID()
            j.LeerJugadora()
            Me.ListaEdiciones.Items.Clear()
            Me.listaTorneos.Items.Clear()
            Me.ListaTorneosFinalista.Items.Clear()
            Me.listaEdicionesGanadas.Items.Clear()
            Me.ListBox1.Items.Clear()
            j.JugDAO.edicionesF.Clear()
            j.JugDAO.edicionesG.Clear()
            j.JugDAO.torneosP.Clear()
            Form1.consultas.leerFinales(j)
            Form1.consultas.leerGanadas(j)
            Form1.consultas.leerParticipaciones(j)
            Me.txtpuntos.Text = j.puntos
            Me.txtNfinales.Text = j.JugDAO.edicionesF.Count
            Me.txtvecesganadora.Text = j.JugDAO.edicionesG.Count
            Me.txtParticipaciones.Text = j.JugDAO.torneosP.Count
            Form1.consultas.leerParticipacionAnos(j)
            For Each a In j.JugDAO.anosParticicion
                Me.cbAños.Items.Add(a.ToString)
            Next

            For Each t In j.JugDAO.edicionesF
                Me.ListaTorneosFinalista.Items.Add(t(1) & " " & t(2))
            Next
            For Each t In j.JugDAO.edicionesG
                Me.listaEdicionesGanadas.Items.Add(t(1) & " " & t(2))
            Next
            For Each t In j.JugDAO.torneosP
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
                j.JugDAO.edicionesP.Clear()
                Dim t As Torneo
                t = New Torneo()
                t.nombreTorneo = Me.listaTorneos.SelectedItem.ToString
                t.buscarID()
                j.nombre = Me.listaRanking.SelectedItem.ToString
                j.buscarID()
                Form1.consultas.leerParticipacionEdiciones(j, t)
                For Each ed In j.JugDAO.edicionesP
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
                Form1.consultas.leerPosicion(j, ed)
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
                    Me.txtPuntosObtenidos.Text = "+10"

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


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbAños.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not Me.cbAños.SelectedItem Is Nothing And Not Me.ListBox1.SelectedItem Is Nothing Then
            Try
                Me.txtResultado.Text = String.Empty
                Me.txtPuntosObtenidos.Text = String.Empty
                Dim ed As Ediciones
                Dim t As Torneo
                t = New Torneo()
                t.nombreTorneo = Me.ListBox1.SelectedItem.ToString
                t.buscarID()
                ed = New Ediciones(Me.cbAños.SelectedItem.ToString, t)
                Form1.consultas.leerPosicion(j, ed)
                establecerPosicion(j)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            MsgBox("Debe seleccionar una edición")
        End If
    End Sub

    Private Sub cbAños_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAños.SelectedIndexChanged
        If Not Me.listaRanking.SelectedItem Is Nothing Then
            If Not Me.cbAños.SelectedItem Is Nothing Then
                Try
                    j.JugDAO.torneosPa.Clear()
                    Me.ListBox1.Items.Clear()
                    Form1.consultas.leeParticipacionAño(j, Me.cbAños.SelectedItem.ToString)
                    For Each p In j.JugDAO.torneosPa
                        Me.ListBox1.Items.Add(p(1))
                    Next
                Catch ex As Exception

                End Try
            End If
        Else
                MsgBox("Debe seleccionar antes una jugadora")
        End If
    End Sub
End Class