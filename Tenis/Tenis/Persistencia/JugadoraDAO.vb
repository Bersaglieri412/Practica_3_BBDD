Public Class JugadoraDAO
    Public ReadOnly Property Jugadora As Collection
    Public Property edicionesG As Collection
    Public Property edicionesF As Collection
    Public Property torneosP As Collection
    Public Property edicionesP As Collection

    Public Property anosParticicion As Collection
    Public Property torneosPa As Collection
    Public Sub New()
        Me.Jugadora = New Collection
        Me.torneosPa = New Collection
        Me.torneosP = New Collection
        Me.edicionesF = New Collection
        Me.edicionesG = New Collection
        Me.edicionesP = New Collection
        Me.anosParticicion = New Collection
    End Sub
    Public Sub LeerTodas()
        Jugadora.Clear()
        Dim p As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras ORDER BY nombreJugadora")
        For Each aux In col
            p = New Jugadora(aux(1).ToString)
            p.nombre = aux(2).ToString
            p.fechaNacimiento = aux(3).ToString
            p.puntos = aux(4)
            p.pais_jug = New Pais(aux(5))
            Me.Jugadora.Add(p)

        Next
    End Sub

    Public Sub leerTodasRanking()
        Jugadora.Clear()
        Dim p As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras ORDER BY PuntosJugadora desc")
        For Each aux In col
            p = New Jugadora(aux(1).ToString)
            p.nombre = aux(2).ToString
            p.fechaNacimiento = aux(3).ToString
            p.puntos = aux(4)
            p.pais_jug = New Pais(aux(5))
            Me.Jugadora.Add(p)

        Next
    End Sub

    Public Sub Leer(ByRef p As Jugadora)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras WHERE IdJugadora='" & p.id & "';")
        For Each aux In col
            p.nombre = aux(2).ToString
            p.fechaNacimiento = aux(3).ToString
            p.puntos = aux(4)
            p.pais_jug = New Pais(aux(5).ToString)
        Next
    End Sub

    Public Function Insertar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras(NombreJugadora,FechaNacimientoJugadora,PaisJugadora) VALUES ('" & p.nombre & "', '" & p.fechaNacimiento & "', '" & p.pais_jug.id & "');")
    End Function

    Public Function Actualizar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras Set NombreJugadora='" & p.nombre & "', FechaNacimientoJugadora='" & p.fechaNacimiento & "', PuntosJugadora='" & p.puntos.ToString & "', PaisJugadora='" & p.pais_jug.id & "' WHERE idJugadora='" & p.id & "';")
    End Function

    Public Function Borrar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Jugadoras WHERE idJugadora='" & p.id & "';")
    End Function

    Public Sub buscarID(ByRef p As Jugadora)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("Select idJugadora from Jugadoras where NombreJugadora='" & p.nombre & "';")
        For Each aux In col
            p.id = aux(1).ToString
        Next
    End Sub
    Public Function ActualizarPuntos(j As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras Set PuntosJugadora='" & j.puntos.ToString & "' WHERE idJugadora='" & j.id & "';")
    End Function

    Public Sub leerGanadas(j As Jugadora)
        Me.edicionesG = AgenteBD.ObtenerAgente.Leer("Select distinct NombreTorneo, Anualidad From jugadoras j, torneos t, ediciones e Where e.torneo = t.idTorneo And e.ganadora ='" & j.id & "';")
    End Sub

    Public Sub leerFinales(j As Jugadora)

        Me.edicionesF = AgenteBD.ObtenerAgente.Leer("Select distinct NombreTorneo, e.Anualidad
From jugadoras j, torneos t, ediciones e, partidos p, juegos ju
Where e.torneo = t.idTorneo And p.anualidad = e.anualidad And p.torneo = e.torneo And p.Ronda ='f' and ju.partido=p.idPartido and ju.jugadora='" & j.id & "' and p.ganadora!='" & j.id & "';")

    End Sub

    Public Sub leerParticipaciones(j As Jugadora)
        Me.torneosP = AgenteBD.ObtenerAgente.Leer("select distinct nombreTorneo 
from ediciones e, torneos t, jugadoras j, partidos p, juegos ju 
where e.Torneo=t.idTorneo and p.anualidad=e.anualidad and p.torneo=e.torneo and ju.partido=p.idPartido and ju.jugadora='" & j.id & "';")
    End Sub

    Public Sub leerParticipacionesAño(j As Jugadora, a As Integer)
        Me.torneosPa = AgenteBD.ObtenerAgente.Leer("select distinct nombreTorneo
from ediciones e, torneos t, partidos p, juegos j
where e.torneo=t.idTorneo and e.anualidad='" & a & "' and p.anualidad=e.anualidad and p.torneo=e.torneo and j.partido=p.idPartido and j.jugadora='" & j.id & "';
")
    End Sub
    Public Sub leerParticipacionEdiciones(j As Jugadora, t As Torneo)

        Me.edicionesP = AgenteBD.ObtenerAgente.Leer("select distinct e.Anualidad, nombreTorneo
from ediciones e, torneos t, jugadoras j, partidos p, juegos ju 
where t.idTorneo='" & t.idTorneo & "' and e.Torneo='" & t.idTorneo & "' and p.anualidad=e.anualidad and p.torneo=e.torneo and ju.partido=p.idPartido and ju.jugadora='" & j.id & "';")

    End Sub
    Public Sub leerPosicion(j As Jugadora, e As Ediciones)
        Dim col As Collection
        col = AgenteBD.ObtenerAgente.Leer("select ronda, ganadora from partidos where idPartido=(select max(p.idPartido)
                                            from ediciones e, partidos p, juegos j
                                            where e.anualidad='" & e.anualidad & "' and e.torneo='" & e.torneo.idTorneo & "' and e.anualidad=p.anualidad and e.torneo=p.torneo and p.idPartido and j.partido=p.idPartido and j.jugadora='" & j.id & "'
                                            group by e.anualidad);")
        j.posicion = col(1)(1)
        j.posicionPos = col(1)(2)
    End Sub

    Public Sub leerAnos(j As Jugadora)
        Me.anosParticicion.Clear()
        Dim col As Collection
        col = AgenteBD.ObtenerAgente.Leer("select distinct e.anualidad
from ediciones e, torneos t, partidos p, juegos j
where  p.anualidad=e.anualidad and p.torneo=e.torneo and j.partido=p.idPartido and j.jugadora='" & j.id & "'
order by e.anualidad;")
        For Each a In col
            Me.anosParticicion.Add(a(1))
        Next
    End Sub

End Class

