Public Class Form2

    Public Sub rellenar(e As Ediciones)
        Dim j, j1 As Jugadora
        j = New Jugadora(e.partidos(1).sets(1).jugadora.id)
        j.LeerJugadora()
        txtcuartos1.Text = j.nombre
        Me.Sets1.Text = setsRellenar(1, 1, e)

        j = New Jugadora(e.partidos(1).sets(2).jugadora.id)
        j.LeerJugadora()
        txtcuartos1_1.Text = j.nombre
        Me.Sets1_1.Text = setsRellenar(1, 2, e)

        j.id = e.partidos(4).sets(1).jugadora.id
        j.LeerJugadora()
        txtcuartos2.Text = j.nombre
        Me.Sets2.Text = setsRellenar(4, 1, e)

        j.id = e.partidos(4).sets(2).jugadora.id
        j.LeerJugadora()
        txtcuartos2_1.Text = j.nombre
        Me.Sets2_1.Text = setsRellenar(4, 2, e)

        j.id = e.partidos(2).sets(1).jugadora.id
        j.LeerJugadora()
        txtcuartos3.Text = j.nombre
        Me.Set3.Text = setsRellenar(2, 1, e)

        j.id = e.partidos(2).sets(2).jugadora.id
        j.LeerJugadora()
        TxtCuartos3_1.Text = j.nombre
        Me.Sets3_1.Text = setsRellenar(2, 2, e)

        j.id = e.partidos(3).sets(1).jugadora.id
        j.LeerJugadora()
        txtcuartos4.Text = j.nombre
        Me.Sets4.Text = setsRellenar(3, 1, e)

        j.id = e.partidos(3).sets(2).jugadora.id
        j.LeerJugadora()
        txtCuartos4_1.Text = j.nombre
        Me.Sets4_1.Text = setsRellenar(3, 2, e)

        j.id = e.partidos(5).sets(1).jugadora.id
        j.LeerJugadora()
        j1 = New Jugadora(e.partidos(5).sets(2).jugadora.id)
        j1.LeerJugadora()
        If (j.id <> e.partidos(1).ganadora.id) Then
            txtSemi1.Text = j1.nombre
            Me.setssemi1.Text = setsRellenar(5, 2, e)
            txtsemi1_1.Text = j.nombre
            Me.setssemi1_1.Text = setsRellenar(5, 1, e)
        Else
            txtSemi1.Text = j.nombre
            Me.setssemi1.Text = setsRellenar(5, 1, e)
            txtsemi1_1.Text = j1.nombre
            Me.setssemi1_1.Text = setsRellenar(5, 2, e)
        End If

        j.id = e.partidos(6).sets(1).jugadora.id
        j.LeerJugadora()
        j1 = New Jugadora(e.partidos(6).sets(2).jugadora.id)
        j1.LeerJugadora()
        If (j.id <> e.partidos(2).ganadora.id) Then
            txtsemi2.Text = j1.nombre
            Me.setssemi2.Text = setsRellenar(6, 2, e)
            txtsemi2_1.Text = j.nombre
            Me.setssemi2_1.Text = setsRellenar(6, 1, e)
        Else
            txtsemi2.Text = j.nombre
            Me.setssemi2.Text = setsRellenar(6, 1, e)
            txtsemi2_1.Text = j1.nombre
            Me.setssemi2_1.Text = setsRellenar(6, 2, e)
        End If

        j.id = e.partidos(7).sets(1).jugadora.id
        j.LeerJugadora()
        j1 = New Jugadora(e.partidos(7).sets(2).jugadora.id)
        j1.LeerJugadora()
        If (j.id <> e.partidos(5).ganadora.id) Then
            txtFinal.Text = j1.nombre
            Me.setsfinal.Text = setsRellenar(7, 2, e)
            txtFinal2.Text = j.nombre
            Me.setsfinal1.Text = setsRellenar(7, 1, e)
        Else
            txtFinal.Text = j.nombre
            Me.setsfinal.Text = setsRellenar(7, 1, e)
            txtFinal2.Text = j1.nombre
            Me.setsfinal1.Text = setsRellenar(7, 2, e)
        End If

        j = e.ganadora
        j.LeerJugadora()
        Me.txtGanadora.Text = j.nombre





    End Sub

    Public Function setsRellenar(p As Integer, s As Integer, e As Ediciones)
        If e.partidos(p).sets(s).set3 <> -1 Then
            Return e.partidos(p).sets(s).set1 & "-" & e.partidos(p).sets(s).set2 & "-" & e.partidos(p).sets(s).set3
        Else
            Return e.partidos(p).sets(s).set1 & "-" & e.partidos(p).sets(s).set2
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://youtu.be/dQw4w9WgXcQ")
    End Sub
End Class