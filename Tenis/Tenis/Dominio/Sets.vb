Public Class Sets 'Lo mismo que la tabla juegos de la bd
    Public Property set1 As Integer
    Public Property set2 As Integer
    Public Property set3 As Integer
    Public Property jugadora As Jugadora

    Public Sub New(j As Jugadora)
        Me.jugadora = j
    End Sub

End Class
