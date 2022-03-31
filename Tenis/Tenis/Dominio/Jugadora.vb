Public Class Jugadora
    Private id As Integer
    Private pais_jug As Pais
    Private nombre As String
    Private puntos As Integer
    Private dechaNacimiento As Date

    Public ReadOnly Property JugDAO As JugadoraDAO

    Public Sub New()
        Me.JugDAO = New JugadoraDAO
    End Sub

    Public Sub New(id As String)
        Me.JugDAO = New JugadoraDAO
        Me.id = id
    End Sub

    Public Sub LeerTodasPersonas()
        Me.JugDAO.LeerTodas()
    End Sub

    Public Sub LeerJugadora()
        Me.JugDAO.Leer(Me)
    End Sub

    Public Function InsertarJugadora() As Integer
        Return Me.JugDAO.Insertar(Me)
    End Function

    Public Function ActualizarJugadora() As Integer
        Return Me.JugDAO.Actualizar(Me)
    End Function

    Public Function BorrarJugadora() As Integer
        Return Me.JugDAO.Borrar(Me)
    End Function

End Class
