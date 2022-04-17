Public Class PaisDAO
    Public ReadOnly Property Pais As Collection

    Public Sub New()
        Me.Pais = New Collection
    End Sub
    Public Sub LeerTodas()
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Paises ORDER BY idPais")
        For Each aux In col
            p = New Pais(aux(1).ToString)
            p.nombre = aux(2).ToString
            Me.Pais.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Paises WHERE idPais='" & p.id & "';")
        For Each aux In col
            p.nombre = aux(2).ToString
        Next
    End Sub

    Public Sub buscarID(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("Select idPais from Paises where NombrePais='" & p.nombre & "';")
        For Each aux In col
            p.id = aux(1).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Paises VALUES ('" & p.id & "','" & p.nombre & "');")
    End Function

    Public Function Actualizar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Paises Set NombrePais='" & p.nombre & "' WHERE idPais='" & p.id & "';")
    End Function

    Public Function Borrar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Paises WHERE idPais='" & p.id & "';")
    End Function

End Class
