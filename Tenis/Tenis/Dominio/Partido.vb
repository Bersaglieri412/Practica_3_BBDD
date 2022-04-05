Public Class Partido
    Public Property idPartido As Integer
    Public Property ganadora As Jugadora
    Public Property edicion As Ediciones 'Actúa como los dos atributos de la clave ajena de la tabla
    Public Property ronda As Char

    Public ReadOnly Property ParDAO As PartidoDAO


    Public Sub New()
        Me.ParDAO = New PartidoDAO
    End Sub

    Public Sub New(Id As String)
        Me.ParDAO = New PartidoDAO
        Me.idPartido = Id
    End Sub

    Public Sub LeerTodasPersonas()
        Me.ParDAO.LeerTodas()
    End Sub

    Public Sub LeerPartido()
        Me.ParDAO.Leer(Me)
    End Sub

    Public Function InsertarPartido() As Integer
        Return Me.ParDAO.Insertar(Me)
    End Function

    Public Function ActualizarPartido() As Integer
        Return Me.ParDAO.Actualizar(Me)
    End Function

    Public Function BorrarPartido() As Integer
        Return Me.ParDAO.Borrar(Me)
    End Function

End Class

