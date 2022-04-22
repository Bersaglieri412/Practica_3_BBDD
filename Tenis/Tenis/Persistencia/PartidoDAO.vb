Public Class PartidoDAO
    Public ReadOnly Property Partido As Collection

    Public Sub New()
        Me.Partido = New Collection
    End Sub
    Public Sub LeerTodas()
        Dim p As Partido
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Partidos ORDER BY idPartido")
        For Each aux In col
            p.idPartido = aux(1).ToString
            p.ganadora = New Jugadora(aux(4).ToString)
            'p.edicion = New Ediciones(aux(2))
            p.ronda = aux(5).ToString
            Me.Partido.Add(p)

        Next
    End Sub

    Public Sub Leer(ByRef p As Partido)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Partidos WHERE IdPartido='" & p.idPartido & "';")
        For Each aux In col
            p.idPartido = aux(2).ToString
        Next
    End Sub

    Public Sub buscarID(ByRef p As Partido)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("Select idPartido from partidos where anualidad='" & p.edicion.anualidad & "' and ganadora='" & p.ganadora.id & "' and ronda='" & p.ronda & "';")
        For Each aux In col
            p.idPartido = aux(1).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Partido) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Partidos VALUES ('" & p.edicion.anualidad.ToString & "', '" & p.edicion.torneo.idTorneo & "', '" & p.ganadora.id & "', '" & p.ronda & "');")
    End Function

    Public Function Actualizar(ByVal p As Partido) As Integer 'No se que valores se actualizarian aqui, he puesto que basicamente se cambie el torneo
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Partidos Set Anualidad='" & p.edicion.anualidad.ToString & " Set Torneo='" & p.edicion.torneo.idTorneo & "' WHERE idPartido='" & p.idPartido & "';")
    End Function

    Public Function Borrar(ByVal p As Partido) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Partidos WHERE idPartido='" & p.idPartido & "';")
    End Function
End Class
