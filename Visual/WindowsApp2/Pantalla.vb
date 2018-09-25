Public Class Pantalla
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_iniciar.Click

        Dim ConectarBD = New BD


        If user.Text <> Nothing And Contrasenya.Text <> Nothing Then

            If ConectarBD.ConsultarLoginUser(user, Contrasenya) Then
                Principal.cargar()
                Principal.Show()
                Me.Hide()

            ElseIf ConectarBD.ConsultarLoginInformatic(user, Contrasenya) Then
                PrinInformaticvb.cargar()

                PrinInformaticvb.Show()
                Me.Hide()

            Else

                If VarBD.actual = 0 Then
                    MsgBox("Contrasenya / usuari incorrectes")
                Else
                    MsgBox("Password / User incorrectos")

                End If

            End If
                Else
            If VarBD.actual = 0 Then
                MsgBox("Camps Buits")

            Else
                MsgBox("Campos Vacios")

            End If
        End If





    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles bt_Registrar.Click
        Registrarse.Show()
        Me.Hide()
    End Sub

    Private Sub Pantalla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub
    Function cargar()
        BotoMenuVertical.Image = Image.FromFile("Menu2.png")
        PictureBox1.Image = Image.FromFile("interogacion.png")
        Contrasenya.Text = ""

        user.Text = ""
        If VarBD.actual = 0 Then
            dioma.SelectedItem = "Català"
            idioma.ca()
        Else
            dioma.SelectedItem = "Anglès"
            idioma.es()

        End If


    End Function


    Private Sub BotoMenuVertical_Click(sender As Object, e As EventArgs) Handles BotoMenuVertical.Click
        If Menu.Width = 150 Then
            Menu.Width = 50
        Else
            Menu.Width = 150


        End If
    End Sub

    Private Sub FAQ_Click(sender As Object, e As EventArgs) Handles FAQ.Click
        cargar()
        Me.Hide()
        If VarBD.actual = 0 Then
            FAQS.Show()
        Else
            FAQSES.Show()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cargar()
        Me.Hide()
        If VarBD.actual = 0 Then
            FAQS.Show()
        Else
            FAQSES.Show()

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dioma.SelectedIndexChanged
        If dioma.Text = "Anglès" Or VarBD.actual = False Then
            idioma.es()
            VarBD.actual = True

        Else
            idioma.ca()
            VarBD.actual = False

        End If
    End Sub
End Class
