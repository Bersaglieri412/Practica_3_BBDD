Public Class Ediciones
    Public Property anualidad As Integer
    Public Property torneo As Torneo
    Public Property ganadora As Jugadora
    Public Property partidos() As Partido 'Colección de partidos dentro de Edición
    Public ReadOnly Property EdDAO As EdicionesDAO
    Public Sub New()
        Me.EdDAO = New EdicionesDAO()
    End Sub

    Public Sub New(Anualidad As Integer)
        Me.EdDAO = New EdicionesDAO()
        Me.anualidad = Anualidad
    End Sub

    Public Sub LeerTodasPersonas()
        Me.EdDAO.LeerTodas()
    End Sub

    Public Sub LeerEdicion()
        Me.EdDAO.Leer(Me)
    End Sub

    Public Function InsertarEdicion() As Integer
        Return Me.EdDAO.Insertar(Me)
    End Function

    Public Function ActualizarEdicion() As Integer
        Return Me.EdDAO.Actualizar(Me)
    End Function

    Public Function BorrarEdicion() As Integer
        Return Me.EdDAO.Borrar(Me)
    End Function

End Class

