Public Class Torneo
    Public Property idTorneo As Integer
    Public Property nombreTorneo As String
    Public Property ciudadTorneo As String
    Public Property paisTorneo As Pais
    'Debe tener un conjunto de ediciones

    Public ReadOnly Property TorDAO As TorneoDAO

    Public Sub New()
        Me.TorDAO = New TorneoDAO
    End Sub

    Public Sub New(Id As Integer)
        Me.TorDAO = New TorneoDAO
        Me.idTorneo = Id
    End Sub

    Public Sub LeerTodasPersonas()
        Me.TorDAO.LeerTodas()
    End Sub

    Public Function buscarID()
        Me.TorDAO.buscarID(Me)
    End Function
    Public Sub LeerJugadora()
        Me.TorDAO.Leer(Me)
    End Sub

    Public Function leerEdiciones() As Integer
        Me.TorDAO.leerEdiciones(Me)
    End Function
    Public Function InsertarJugadora() As Integer
        Return Me.TorDAO.Insertar(Me)
    End Function

    Public Function ActualizarJugadora() As Integer
        Return Me.TorDAO.Actualizar(Me)
    End Function

    Public Sub leerGanadoras()
        Me.TorDAO.leerGanadoras(Me)
    End Sub
    Public Function BorrarJugadora() As Integer
        Return Me.TorDAO.Borrar(Me)
    End Function


End Class
