Public Class Jugadora
    Public Property id As Integer
    Public Property pais_jug As Pais
    Public Property nombre As String
    Public Property puntos As Integer
    Public Property fechaNacimiento As Date

    Public ReadOnly Property JugDAO As JugadoraDAO

    Public Sub New()
        Me.JugDAO = New JugadoraDAO
    End Sub

    Public Sub New(Id As String)
        Me.JugDAO = New JugadoraDAO
        Me.id = Id
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
