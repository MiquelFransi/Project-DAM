Public Class Registrarse
    Private Sub RegistreInformatic_Click(sender As Object, e As EventArgs) Handles bt_Registrar2.Click
        Dim ConectarBD = New BD



        If usuariInf.Text <> Nothing And cognomInf.Text <> Nothing And dniInf.Text <> Nothing And nomInf.Text <> Nothing And contrasenyaInf.Text <> Nothing And poblacioInf.Text <> Nothing And provincaiInf.Text <> Nothing And VarBD.nomFitxer <> Nothing Then

            My.Computer.Network.UploadFile(VarBD.ruta, "FTP://ftp.provadam1.esy.es/" + VarBD.nomFitxer, "u922516961", "123456")


            If ConectarBD.InsertaInformatic(usuariInf, contrasenyaInf, dniInf, nomInf, cognomInf, poblacioInf, provincaiInf, VarBD.nomFitxer) Then

                If VarBD.actual = 0 Then
                    MsgBox("Informàtic Creat")
                Else
                    MsgBox("Informático Creado")
                End If
                Pantalla.Show()
                Me.Hide()

            Else
                If VarBD.actual = 0 Then
                    MsgBox("Dades NO valides per registrar-se")
                Else
                    MsgBox("Datos NO validos para registrarse")
                End If
            End If
        Else
            If VarBD.actual = 0 Then
                MsgBox("Has d'omplir tots els camps")
            Else
                MsgBox("Tienes  que rellenar todos los campos")

            End If
        End If

    End Sub

    Private Sub RegistreUsuari_Click(sender As Object, e As EventArgs) Handles bt_Registrar.Click
        Dim ConectarBD = New BD

        If usuariU.Text <> Nothing And ContrasenyaU.Text <> Nothing And DNIU.Text <> Nothing And nomU.Text <> Nothing And cognomU.Text <> Nothing And PoblacioU.Text <> Nothing And provinciaU.Text <> Nothing Then



            If ConectarBD.InsertaUsers(usuariU, ContrasenyaU, DNIU, nomU, cognomU, PoblacioU, provinciaU) Then
                If VarBD.actual = 0 Then
                    MsgBox("Usuari Creat")
                Else
                    MsgBox("Usuario Creado")
                End If

                Pantalla.Show()
                Me.Hide()

            Else
                If VarBD.actual = 0 Then
                    MsgBox("Dades NO valides per registrar-se")
                Else
                    MsgBox("Datos NO validos para registrarse")
                End If
            End If
        Else
            If VarBD.actual = 0 Then
                MsgBox("Has d'omplir tots els camps")
            Else
                MsgBox("Tienes  que rellernar todos los campos")

            End If

        End If

    End Sub

    Private Sub Registrarse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()

    End Sub

    Function cargar()
        PictureBox4.Image = Image.FromFile("back.png")
        BotoMenuVertical.Image = Image.FromFile("Menu2.png")
        PictureBox1.Image = Image.FromFile("interogacion.png")
        nomInf.Text = ""
        cognomInf.Text = ""
        usuariInf.Text = ""
        contrasenyaInf.Text = ""
        provincaiInf.Text = ""
        poblacioInf.Text = ""
        dniInf.Text = ""
        nomU.Text = ""
        cognomU.Text = ""
        usuariU.Text = ""
        ContrasenyaU.Text = ""
        provinciaU.Text = ""
        PoblacioU.Text = ""
        DNIU.Text = ""
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

    Private Sub Registrarse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            OpenFileDialog1.Filter = "Word Files (*.docx)|*.docx|Word Files(*.doc)|*.doc|PDF files(*.pdf)|*.pdf|RTF files(*.rtf)|*.rtf|Text files (*.txt)|*.txt"


            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)


                VarBD.nomFitxer = OpenFileDialog1.SafeFileName.ToString
                VarBD.ruta = OpenFileDialog1.FileName.ToString
                NomFitxer.Text = VarBD.nomFitxer


                sr.Close()

            End If

        Catch ex As Exception

            MsgBox("ERROR del archivo")

        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles darrere.Click
        Pantalla.Show()
        cargar()
        Me.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Pantalla.Show()
        cargar()
        Pantalla.cargar()
        Me.Hide()
    End Sub

    Private Sub dioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dioma.SelectedIndexChanged
        If dioma.Text = "Anglès" Or VarBD.actual = False Then
            idioma.es()
            VarBD.actual = True

        Else
            idioma.ca()
            VarBD.actual = False

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

    Private Sub FAQ_Click(sender As Object, e As EventArgs) Handles FAQ.Click
        cargar()
        Me.Hide()
        If VarBD.actual = 0 Then
            FAQS.Show()
        Else
            FAQSES.Show()

        End If
    End Sub
End Class