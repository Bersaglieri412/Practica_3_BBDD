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
        Next
    End Sub

    Public Function Insertar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras(NombreJugadora,FechaNacimientoJugadora,PuntosJugadora,PaisJugadora) VALUES ('" & p.nombre & "', '" & p.fechaNacimiento & "', '" & p.puntos & "', '" & p.pais_jug.id & "');")
<<<<<<< HEAD
        ' "INSERT INTO Jugadoras VALUES ('" & 0 & "','" & p.nombre & "', '" & p.fechaNacimiento & "', '" & p.puntos & "', '" & p.pais_jug.id & "');")
=======
>>>>>>> cc5e961f9aad696b4520d63fd8b5f5150a40ec8d
    End Function

    Public Function Actualizar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras Set NombreJugadora='" & p.nombre & "' WHERE idJugadora='" & p.id & "';")
    End Function

    Public Function Borrar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Jugadoras WHERE idJugadora='" & p.id & "';")
    End Function


End Class
