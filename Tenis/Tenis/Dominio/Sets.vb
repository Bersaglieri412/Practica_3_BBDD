Public Class Sets 'Lo mismo que la tabla juegos de la base de datos
    Public Property set1 As Integer
    Public Property set2 As Integer
    Public Property set3 As Integer

    Public Property partido As Partido
    Public Property jugadora As Jugadora

    Public Sub New(j As Jugadora, p As Partido)
        Me.jugadora = j
        Me.partido = p
        Me.set3 = Nothing
    End Sub

End Class
