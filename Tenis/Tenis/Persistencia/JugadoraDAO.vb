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
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras WHERE IDPersona='" & p.id & "';")
        For Each aux In col
            p.nombre = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras VALUES ('" & p.nombre & "', '" & p.fechaNacimiento & "', '" & p.puntos & "', '" & p.pais_jug.id & "');")
    End Function

    Public Function Actualizar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Personas Set NombrePersona='" & p.nombre & "' WHERE IDPersona='" & p.id & "';")
    End Function

    Public Function Borrar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Personas WHERE IDPersona='" & p.id & "';")
    End Function


End Class
