Public Class Partido
    Public Property idPartido As Integer
    Public Property ganadora As Jugadora
    Public Property edicion As Ediciones 'Actúa como los dos atributos de la clave ajena de la tabla
    Public Property ronda As Char

    Public Property sets As Collection 'Debe tener al menos dos juegos, uno por jugadora

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

    Public Sub celebrarPartido(j As Jugadora, j1 As Jugadora, r As Char)
        sets = New Collection()
        ronda = r
        Dim g, g1 As Integer
        g = g1 = 0
        Dim s As Sets = New Sets(j)
        Dim s1 As Sets = New Sets(j1)
        Randomize()
        If (Int((2 * Rnd()) + 1)) = 1 Then
            s.set1 = 6
            s1.set1 = (Int((4 * Rnd()) + 1))
            g = g + 1
        Else
            s1.set1 = 6
            s.set1 = (Int((4 * Rnd()) + 1))
            g1 = g1 + 1
        End If

        If (Int((2 * Rnd()) + 1)) = 1 Then
            s.set2 = 6
            s1.set2 = (Int((4 * Rnd()) + 1))
            g = g + 1
        Else
            s1.set2 = 6
            s.set2 = (Int((4 * Rnd()) + 1))
            g1 = g1 + 1
        End If
        If g1 <> 2 Or g <> 2 Then
            If (Int((2 * Rnd()) + 1)) = 1 Then
                s.set3 = 6
                s1.set3 = (Int((4 * Rnd()) + 1))
                g = g + 1
            Else
                s1.set3 = 6
                s.set3 = (Int((4 * Rnd()) + 1))
                g1 = g1 + 1
            End If
        End If
        If g > g1 Then
            Me.ganadora = j
        Else
            Me.ganadora = j1
        End If
        sets.Add(s)
        sets.Add(s1)
    End Sub

End Class

