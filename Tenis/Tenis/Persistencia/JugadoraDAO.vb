Public Class JugadoraDAO
    Public Sub LeerTodas()
        Dim p As Persona
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Personas ORDER BY IDPersona")
        For Each aux In col
            p = New Persona(aux(1).ToString)
            p.Nombre = aux(2).ToString
            Me.Personas.Add(p)

        Next
    End Sub

    Public Sub Leer(ByRef p As Jugadora)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Personas WHERE IDPersona='" & p.IDPersona & "';")
        For Each aux In col
            p.nombre = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras VALUES ('" & p.nombre & "', '" & p.Fecha & "');")
    End Function

    Public Function Actualizar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Personas SET NombrePersona='" & p.nombre & "' WHERE IDPersona='" & p.IDPersona & "';")
    End Function

    Public Function Borrar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Personas WHERE IDPersona='" & p.IDPersona & "';")
    End Function


End Class
