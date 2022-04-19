﻿Public Class TorneoDAO
    Public ReadOnly Property Torneo As Collection
    Public ReadOnly Property Ediciones As Collection
    Public Sub New()
        Me.Torneo = New Collection
        Me.Ediciones = New Collection
    End Sub
    Public Sub LeerTodas()
        Ediciones.Clear()
        Dim p As Torneo
        Dim col, cole, aux, auxe As Collection
        Dim e As Ediciones
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Torneos ORDER BY idTorneo")
        For Each aux In col
            p = New Torneo(aux(1).ToString)
            p.nombreTorneo = aux(2).ToString
            p.ciudadTorneo = aux(3).ToString
            p.paisTorneo = New Pais(aux(4).ToString)
            cole = AgenteBD.ObtenerAgente().Leer("Select * from ediciones where Torneo='" & aux(1) & "'")
            For Each auxe In cole
                e = New Ediciones(auxe(1), p)
                e.torneo = New Torneo(auxe(2))
                e.ganadora = New Jugadora(auxe(3))
                Me.Ediciones.Add(e)
            Next
            p.ediciones = Me.Ediciones
            Me.Torneo.Add(p)

        Next
    End Sub


    Public Sub Leer(ByRef p As Torneo)
        Ediciones.Clear()
        Dim col, cole, auxe As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos WHERE idTorneo='" & p.idTorneo & "';")
        For Each aux In col
            p.nombreTorneo = aux(2).ToString
            p.ciudadTorneo = aux(3).ToString
            p.paisTorneo = New Pais(aux(4).ToString)
            leerEdiciones(p)
        Next
    End Sub

    Public Sub buscarID(ByRef p As Torneo)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("Select idTorneo from Torneos where nombreTorneo='" & p.nombreTorneo & "';")
        For Each aux In col
            p.idTorneo = aux(1).ToString
        Next
    End Sub

    Public Sub leerEdiciones(ByRef p As Torneo)
        Dim e As Ediciones
        Dim cole, auxe As Collection
        Dim contador As Integer
        contador = 1
        Ediciones.Clear()
        cole = AgenteBD.ObtenerAgente().Leer("Select * from ediciones where Torneo='" & p.idTorneo & "'")
        For Each auxe In cole
            e = New Ediciones(auxe(1), p)
            e.torneo = New Torneo(auxe(2))
            e.ganadora = New Jugadora(auxe(3))
            Me.Ediciones.Add(e)
            contador = contador + 1
        Next
        p.ediciones = Ediciones

    End Sub
    Public Function Insertar(ByVal p As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Torneos(nombreTorneo,ciudadTorneo,paisTorneo) VALUES ('" & p.nombreTorneo.ToString & "', '" & p.ciudadTorneo.ToString & "', '" & p.paisTorneo.id.ToString & "');")
    End Function

    Public Function Actualizar(ByVal p As Torneo) As Integer 'Aquí lo mismo, solo actualizao el nombre del torneo
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Torneos Set nombreTorneo='" & p.nombreTorneo & "' WHERE idTorneo='" & p.idTorneo & "';")
    End Function

    Public Function Borrar(ByVal p As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Torneos WHERE idTorneo='" & p.idTorneo & "';")
    End Function

    Public Function insertarEdicion(e As Ediciones)
        Dim r As Integer
        r = 0
        If r = AgenteBD.ObtenerAgente.Modificar("INSERT INTO ediciones VALUES ('" & e.anualidad.ToString & "','" & e.torneo.idTorneo.ToString & "','" & e.ganadora.id.ToString & "');") <> 1 Then
            MsgBox("Error en el insert -1")
            Exit Function
        End If
        For Each p In e.partidos
            If AgenteBD.ObtenerAgente.Modificar("Insert INTO Partidos(Anualidad,Torneo,Ganadora,Ronda) Values('" & e.anualidad & "', '" & e.torneo.idTorneo.ToString & "' ,'" & p.ganadora.id.ToString & "', '" & p.ronda & "');") <> 1 Then
                MsgBox("Error en el insert 0")
                Exit Function
            Else
                MsgBox("si")
            End If
            For Each s In p.sets
                If AgenteBD.ObtenerAgente.Modificar("Insert INTO Juegos(Jugadora,Partido,SET1,SET2,SET3) Values('" & s.jugadora.id & "', '" & p.idPartido.ToString & "', '" & s.set1.ToString & "' ,'" & s.set2.ToString & "', '" & s.set3.ToString & "');") <> 1 Then
                    MsgBox("Error en el insert 1")
                    Exit Function
                Else
                    MsgBox("si")
                End If
            Next
        Next
        MsgBox("fuera")
        Return r
    End Function
End Class
