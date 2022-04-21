Public Class Consultas
    'Lo mismo que resultados pero para otras cosas en específico

    ' Clase Jugadora
    Public Sub leerParticipaciones()
        JugDAO.leerParticipaciones(Me)
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

    ' Clase 


End Class
