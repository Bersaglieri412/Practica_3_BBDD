Public Class EdicionesDAO
    Public ReadOnly Property Edicion As Collection

    Public Sub New()
        Me.Edicion = New Collection
    End Sub
    Public Sub LeerTodas()
        Dim p As Ediciones
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Ediciones ORDER BY Anualidad")
        For Each aux In col
            p.anualidad = aux(1).ToString
            p.torneo = New Torneo(aux(2).ToString)
            p.ganadora = New Jugadora(aux(3).ToString)
            Me.Edicion.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Ediciones)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Ediciones WHERE Anualidad='" & p.anualidad & "';")
        For Each aux In col
            p.anualidad = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Ediciones) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Ediciones VALUES ('" & 0.ToString & "','" & p.torneo.idTorneo & "', '" & p.ganadora.id & "');")
    End Function

    Public Function Actualizar(ByVal p As Ediciones) As Integer 'No se que valores se actualizarian aqui, he puesto que basicamente se cambie el torneo
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Ediciones Set Torneo='" & p.torneo.idTorneo & " Set Ganadora='" & p.ganadora.id & "' WHERE Anualidad='" & p.anualidad & "';")
    End Function

    Public Function Borrar(ByVal p As Ediciones) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Ediciones WHERE Anualidad='" & p.anualidad & "';")
    End Function
End Class
