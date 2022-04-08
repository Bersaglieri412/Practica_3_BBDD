Public Class JugadoraDAO
    Public ReadOnly Property Jugadora As Collection

    Public Sub New()
        Me.Jugadora = New Collection
    End Sub
    Public Sub LeerTodas()
        Dim p As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras ORDER BY idJugadora")
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
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras(NombreJugadora,FechaNacimientoJugadora,PuntosJugadora,PaisJugadora) VALUES ('" & p.nombre & "', '" & p.fechaNacimiento & "', '" & p.puntos & "', '" & p.pais_jug.id & "');")
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

End Class
