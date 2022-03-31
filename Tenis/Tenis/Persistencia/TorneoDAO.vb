Public Class TorneoDAO
    Public ReadOnly Property Torneo As Collection

    Public Sub New()
        Me.Torneo = New Collection
    End Sub
    Public Sub LeerTodas()
        Dim p As Torneo
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Torneos ORDER BY idTorneo")
        For Each aux In col
            p = New Torneo(aux(1).ToString)
            p. = aux(2).ToString
            p.fechaNacimiento = aux(3).ToString
            p.puntos = aux(4)
            p.pais_jug = New Pais(aux(5))
            Me.Torneo.Add(p)

        Next
    End Sub

    Public Sub Leer(ByRef p As Torneo)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos WHERE IDPersona='" & p.id & "';")
        For Each aux In col
            p.nombre = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Torneos VALUES ('" & p.nombre & "', '" & p.fechaNacimiento & "', '" & p.puntos & "', '" & p.pais_jug.id & "');")
    End Function

    Public Function Actualizar(ByVal p As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Torneos Set NombrePersona='" & p.nombre & "' WHERE idTorneo='" & p.id & "';")
    End Function

    Public Function Borrar(ByVal p As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Torneos WHERE idTorneo='" & p.id & "';")
    End Function

End Class
