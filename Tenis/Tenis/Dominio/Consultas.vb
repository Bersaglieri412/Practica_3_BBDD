Public Class Consultas
    'Lo mismo que resultados pero para otras cosas en específico

    ' Clase Jugadora
    Public Sub leerGanadas(j As Jugadora)
        j.JugDAO.leerGanadas(j)
    End Sub

    Public Sub leerFinales(j As Jugadora)
        j.JugDAO.leerFinales(j)
    End Sub

    Public Sub leerParticipaciones(j As Jugadora)
        j.JugDAO.leerParticipaciones(j)
    End Sub

    Public Sub leerParticipacionEdiciones(j As Jugadora, t As Torneo)
        j.JugDAO.leerParticipacionEdiciones(j, t)
    End Sub

    Public Sub leerPosicion(j As Jugadora, e As Ediciones)
        j.JugDAO.leerPosicion(j, e)
    End Sub

    Public Sub leeParticipacionAño(j As Jugadora, a As Integer)
        j.JugDAO.leerParticipacionesAño(j, a)
    End Sub

    Public Sub leerParticipacionAnos(j As Jugadora)
        j.JugDAO.leerAnos(j)
    End Sub

    Public Function añadirEdicion(t As Torneo, a As Integer)
        Dim ed As Ediciones = New Ediciones(a, t)
        ed.generarEdicion()
        Return t.TorDAO.insertarEdicion(ed)
    End Function

End Class
