Public Class Ediciones
    Public Property anualidad As Integer
    Public Property torneo As Torneo
    Public Property ganadora As Jugadora
    Public Property partidos As Collection 'Colección de partidos dentro de Edición

    Public Sub New(Anualidad As Integer, torneo As Torneo)
        Me.partidos = New Collection
        Me.torneo = New Torneo(torneo.idTorneo)
        Me.anualidad = Anualidad
    End Sub

    Public Sub generarEdicion()
        Dim jugadoras As Jugadora
        Dim participantes As Collection = New Collection
        Dim jugAux As Jugadora
        Dim pAux As Partido
        partidos = New Collection
        jugadoras = New Jugadora()
        jugadoras.LeerTodasPersonas()
        Dim i As Integer = 8
        Randomize()

        Do
            Dim n As Integer = Int((Int((jugadoras.JugDAO.Jugadora.Count * Rnd()) + 1)))
            participantes.Add(jugadoras.JugDAO.Jugadora.Item(n))
            jugadoras.JugDAO.Jugadora.Remove(n)
            i = i - 1
        Loop While i <> 0

        participantes = ordenar(participantes)

        'Generar cuartos de final
        For i = 1 To 4
            pAux = New Partido()
            pAux.edicion = Me
            pAux.celebrarPartido(participantes(i), participantes(8 - (i - 1)), "c")
            partidos.Add(pAux)
        Next i

        'Generar Semifinales
        For i = 1 To 2
            pAux = New Partido()
            pAux.edicion = Me
            pAux.celebrarPartido(partidos(i).ganadora, partidos(4 - (i - 1)).ganadora, "s")
            partidos.Add(pAux)
        Next i

        'Generar Final
        pAux = New Partido()
            pAux.edicion = Me
        pAux.celebrarPartido(partidos(5).ganadora, partidos(6).ganadora, "f")
        partidos.Add(pAux)
        Me.ganadora = partidos(7).ganadora
        ganadora.puntos = ganadora.puntos + 100
        ganadora.ActualizarPuntos()


        For i = 1 To 7
            If i < 5 Then
                If partidos(i).ganadora.id <> partidos(i).sets(1).jugadora.id Then
                    partidos(i).sets(1).jugadora.puntos += 10
                    'MsgBox()
                    If partidos(i).sets(1).jugadora.ActualizarPuntos() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    partidos(i).sets(2).jugadora.puntos += 10
                    If partidos(i).sets(2).jugadora.ActualizarPuntos() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            ElseIf i < 7 Then
                If partidos(i).ganadora.id <> partidos(i).sets(1).jugadora.id Then
                    partidos(i).sets(1).jugadora.puntos += 25
                    If partidos(i).sets(1).jugadora.ActualizarPuntos() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    partidos(i).sets(2).jugadora.puntos += 25
                    If partidos(i).sets(2).jugadora.ActualizarPuntos() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            Else
                If partidos(i).ganadora.id <> partidos(i).sets(1).jugadora.id Then
                    partidos(i).sets(1).jugadora.puntos += 50
                    If partidos(i).sets(1).jugadora.ActualizarPuntos() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    partidos(i).sets(2).jugadora.puntos += 50
                    If partidos(i).sets(2).jugadora.ActualizarPuntos() <> 1 Then
                        MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If
        Next
        'Queda insertar el resultado de estas ediciones en la base de datos



    End Sub


    Function ordenar(participantes As Collection)
        Dim vItm As Object
        Dim t As Integer, j As Integer
        Dim vTemp As Object

        For t = 1 To participantes.Count - 1
            For j = t + 1 To participantes.Count
                If participantes(t).compareTo(participantes(j).puntos) Then

                    vTemp = participantes(j)


                    participantes.Remove(j)


                    participantes.Add(vTemp,, t)
                End If
            Next j
        Next t

        Return participantes
    End Function
End Class

