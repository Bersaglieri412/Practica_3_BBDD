Public Class Form1
    Private p As Jugadora
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim pAux As Jugadora
        Me.p = New Jugadora
        Try
            Me.p.LeerTodasPersonas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In p.JugDAO.Jugadora
            Me.listaJugadoras.Items.Add(pAux.nombre)
        Next

    End Sub

    Private Sub btnAnadirJugadora_Click(sender As Object, e As EventArgs) Handles btnAnadirJugadora.Click
        pAux.
    End Sub
End Class
