Public Class Jugadora
    Public Property id As Integer
    Public Property pais_jug As Pais
    Public Property nombre As String
    Public Property puntos As Integer
    Public Property fechaNacimiento As String
    Public Property posicion As Char
    Public Property posicionPos As Integer
    Public Property edicionesG As Collection
    Public Property edicionesF As Collection
    Public Property torneosP As Collection
    Public Property edicionesP As Collection

    Public Property torneosPa As Collection

    Public ReadOnly Property JugDAO As JugadoraDAO

    Public Sub New()
        Me.JugDAO = New JugadoraDAO
        Me.edicionesG = New Collection
        Me.edicionesF = New Collection
        Me.edicionesP = New Collection
        Me.torneosP = New Collection
        Me.torneosPa = New Collection
        puntos = 0
    End Sub

    Public Sub New(Id As String)
        Me.JugDAO = New JugadoraDAO
        Me.edicionesG = New Collection
        Me.edicionesF = New Collection
        Me.edicionesP = New Collection
        Me.torneosP = New Collection
        Me.torneosPa = New Collection
        Me.id = Id
        puntos = 0
    End Sub
    Public Sub New(Id As String, pais_jug As Pais, nombre As String, puntos As Integer, fechaNacimiento As String)
        Me.id = Id
        Me.pais_jug = pais_jug
        Me.nombre = nombre
        Me.puntos = puntos
        Me.fechaNacimiento = fechaNacimiento
        Me.JugDAO = New JugadoraDAO
        Me.edicionesG = New Collection
        Me.edicionesF = New Collection
        Me.edicionesP = New Collection
        Me.torneosP = New Collection
        Me.torneosPa = New Collection

    End Sub

    Public Sub LeerTodasPersonas()
        Me.JugDAO.LeerTodas()
    End Sub

    Public Sub leerTodasRanking()
        Me.JugDAO.leerTodasRanking()
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
    Public Function ActualizarPuntos() As Integer
        Return Me.JugDAO.ActualizarPuntos(Me)
    End Function
    Public Function BorrarJugadora() As Integer
        Return Me.JugDAO.Borrar(Me)
    End Function

    Public Function buscarID()
        Me.JugDAO.buscarID(Me)
    End Function

    Public Sub leerGanadas()
        JugDAO.leerGanadas(Me)
    End Sub
    Public Sub leerFinales()
        JugDAO.leerFinales(Me)
    End Sub
    Public Sub leerParticipaciones()
        JugDAO.leerParticipaciones(Me)
    End Sub

    Public Sub leerParticipacionEdiciones(t As Torneo)
        JugDAO.leerParticipacionEdiciones(Me, t)
    End Sub

    Public Sub leerPosicion(e As Ediciones)
        JugDAO.leerPosicion(Me, e)
    End Sub

    Public Sub leeParticipacionAño(a As Integer)
        Me.JugDAO.leerParticipacionesAño(Me, a)
    End Sub
    Function compareTo(p As Integer)
        Dim mayor As Boolean
        mayor = False
        If Me.puntos < p Then
            mayor = True
        End If

        Return mayor
    End Function

End Class
