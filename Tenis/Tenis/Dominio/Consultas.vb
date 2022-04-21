Public Class Consultas
    'Lo mismo que resultados pero para otras cosas en específico

    ' Clase Jugadora
    Public Sub leerParticipacionEdiciones(j As Jugadora, t As Torneo)
        j.JugDAO.leerParticipacionEdiciones(j As Jugadora, t)
    End Sub

    Public Sub leerPosicion(j As Jugadora, e As Ediciones)
        j.JugDAO.leerPosicion(j As Jugadora, e)
    End Sub

    Public Sub leeParticipacionAño(j As Jugadora, a As Integer)
        j.JugDAO.leerParticipacionesAño(j As Jugadora, a)
    End Sub

    ' Clase JugadoraDAO



End Class
