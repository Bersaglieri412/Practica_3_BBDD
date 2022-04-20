Public Class Form2

    Public Sub rellenar(e As Ediciones)
        Dim j, j1 As Jugadora
        j = New Jugadora(e.partidos(1).sets(1).jugadora.id)
        j.LeerJugadora()
        txtcuartos1.Text = j.nombre
        'Me.Sets1.Text = e.partidos(1).sets(2).set1 & "-" & e.partidos(1).sets(2).set2 & "-" & e.partidos(1).sets(2).set3
        j = New Jugadora(e.partidos(1).sets(2).jugadora.id)
        j.LeerJugadora()
        txtcuartos1_1.Text = j.nombre
        'Me.Sets1_1.Text = e.partidos(1).sets(1).set1 & "-" & e.partidos(1).sets(1).set2 & "-" & e.partidos(1).sets(1).set3
        j.id = e.partidos(4).sets(1).jugadora.id
        j.LeerJugadora()
        txtcuartos2.Text = j.nombre

        j.id = e.partidos(4).sets(2).jugadora.id
        j.LeerJugadora()
        txtcuartos2_1.Text = j.nombre

        j.id = e.partidos(2).sets(1).jugadora.id
        j.LeerJugadora()
        txtcuartos3.Text = j.nombre

        j.id = e.partidos(2).sets(2).jugadora.id
        j.LeerJugadora()
        TxtCuartos3_1.Text = j.nombre

        j.id = e.partidos(3).sets(1).jugadora.id
        j.LeerJugadora()
        txtcuartos4.Text = j.nombre

        j.id = e.partidos(3).sets(2).jugadora.id
        j.LeerJugadora()
        txtCuartos4_1.Text = j.nombre


        j.id = e.partidos(5).sets(1).jugadora.id
        j.LeerJugadora()
        j1 = New Jugadora(e.partidos(5).sets(2).jugadora.id)
        j1.LeerJugadora()
        If (j.id <> e.partidos(1).ganadora.id) Then
            txtSemi1.Text = j1.nombre
            txtsemi1_1.Text = j.nombre
        Else
            txtSemi1.Text = j.nombre
            txtsemi1_1.Text = j1.nombre
        End If

        j.id = e.partidos(6).sets(1).jugadora.id
        j.LeerJugadora()
        j1 = New Jugadora(e.partidos(6).sets(2).jugadora.id)
        j1.LeerJugadora()
        If (j.id <> e.partidos(2).ganadora.id) Then
            txtsemi2.Text = j1.nombre
            txtsemi2_1.Text = j.nombre
        Else
            txtsemi2.Text = j.nombre
            txtsemi2_1.Text = j1.nombre
        End If

        j.id = e.partidos(7).sets(1).jugadora.id
        j.LeerJugadora()
        j1 = New Jugadora(e.partidos(7).sets(2).jugadora.id)
        j1.LeerJugadora()
        If (j.id <> e.partidos(5).ganadora.id) Then
            txtFinal.Text = j1.nombre
            txtFinal2.Text = j.nombre
        Else
            txtFinal.Text = j.nombre
            txtFinal2.Text = j1.nombre
        End If

        j = e.ganadora
        j.LeerJugadora()
        Me.txtGanadora.Text = j.nombre





    End Sub

    Public Sub sets()

    End Sub
End Class