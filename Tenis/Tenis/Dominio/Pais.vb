Public Class Pais
    Public Property id As String
    Public Property nombre As String

    Public Property id_antiguo As String

    Public ReadOnly Property PaisDAO As PaisDAO

    Public Sub New()
        Me.PaisDAO = New PaisDAO
    End Sub

    Public Sub New(Id As String)
        Me.PaisDAO = New PaisDAO
        Me.id = Id

    End Sub

    Public Sub buscarId()
        Me.PaisDAO.buscarID(Me)
    End Sub
    Public Sub LeerTodasPersonas()
        Me.PaisDAO.LeerTodas()
    End Sub

    Public Sub LeerPais()
        Me.PaisDAO.Leer(Me)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.PaisDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PaisDAO.Actualizar(Me)
    End Function

    Public Function BorrarPais() As Integer
        Return Me.PaisDAO.Borrar(Me)
    End Function


End Class
