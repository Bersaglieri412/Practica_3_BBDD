Public Class Ediciones
    Public Property anualidad As Integer
    Public Property torneo As Torneo
    Public Property ganadora As Jugadora
    Public Property partidos() As Partido 'Colección de partidos dentro de Edición

    Public Sub New(Anualidad As Integer, torneo As Integer)
        Me.torneo = New Torneo(torneo)
        Me.anualidad = Anualidad
    End Sub

    Public Sub generarEdicion()
        Dim jugadoras As Jugadora
        Dim participantes As Collection = New Collection
        Dim jugAux As Jugadora

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

        For Each jug In participantes
            MsgBox(jug.puntos & " " & jug.nombre)
        Next

    End Sub
    Function compareKeys(p As Integer, p1 As Integer)
        Dim mayor As Boolean
        mayor = False
        If p < p1 Then
            mayor = True
        End If

        Return mayor
    End Function

    Function ordenar(participantes As Collection)
        Dim vItm As Object
        Dim t As Integer, j As Integer
        Dim vTemp As Object

        For t = 1 To participantes.Count - 1
            For j = t + 1 To participantes.Count
                If compareKeys(participantes(t).puntos, participantes(j).puntos) Then

                    vTemp = participantes(j)


                    participantes.Remove(j)


                    participantes.Add(vTemp,, t)
                End If
            Next j
        Next t

        Return participantes
    End Function
End Class

