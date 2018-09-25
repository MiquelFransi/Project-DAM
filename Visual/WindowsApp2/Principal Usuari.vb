Imports System.IO

Public Class Principal
    Dim ConectarBD = New BD

    Private Sub Contacte_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Baixa_Click(sender As Object, e As EventArgs) Handles label_baixa.Click
        Me.Hide()

        BorrarUser.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles BotoMenuVertical.Click
        If Menu.Width = 150 Then
            Menu.Width = 50

        Else
            Menu.Width = 150

        End If
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()

    End Sub
    Public Function cargar()
        DescarregarCur.Enabled = False

        If VarBD.actual = 0 Then
            dioma.SelectedItem = "Català"
            idioma.ca()
        Else
            dioma.SelectedItem = "Anglès"
            idioma.es()

        End If
        ConectarBD.Categories(categoria)
        ConectarBD.Categories(cateinci)
        TitolInci.Text = ""
        titol.Text = ""
        PobIncidencia.Text = ""
        ProvInci.Text = ""
        descrip.Text = ""
        ConectarBD.CarregarIncidenciesComboBox(incidencies, Fetes)
        BotoMenuVertical.Image = Image.FromFile("Menu2.png")
        PictureBox1.Image = Image.FromFile("interogacion.png")
        PictureBox2.Image = Image.FromFile("creu.png")
        PictureBox4.Image = Image.FromFile("salir.png")
        nom.Text = VarBD.nom
        cognom.Text = VarBD.cognom
        categoria.SelectedItem = "Software"
        descripInici.Text = ""
        NomInformatic.Text = ""
        VarBD.dniInformatic = Nothing
        Pantalla.cargar()


    End Function


    Private Sub Menu_Paint(sender As Object, e As PaintEventArgs) Handles Menu.Paint

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim ConectarBD = New BD

        Dim nivell As Integer = 0
        If Baix.Checked Then
            nivell = 1
        ElseIf Mitja.Checked Then
            nivell = 2

        ElseIf Alt.Checked Then
            nivell = 3
        End If


        Dim cate = categoria.SelectedItem.ToString

        If titol.Text <> Nothing And descrip.Text <> Nothing And PobIncidencia.Text <> Nothing And ProvInci.Text <> Nothing Then
            If ConectarBD.CrearIncidencies(titol, descrip, PobIncidencia, ProvInci, nivell, cate) Then
                If VarBD.actual = 0 Then
                    MsgBox("Incidència Creada")
                Else
                    MsgBox("Incidencia Creada")
                End If

                cargar()


            Else
                If VarBD.actual = 0 Then
                    MsgBox("Incidència NO creada")
                Else
                    MsgBox("Incidencia NO creada")

                End If

            End If
        Else
            If VarBD.actual = 0 Then
                MsgBox("Has d'omplir tots els camps")
            Else
                MsgBox("Tienes  que rellenar todos los campos")

            End If

        End If

        ' ConectarBD.CarregarIncidenciesComboBox(incidencies)

    End Sub

    Private Sub incidencies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles incidencies.SelectedIndexChanged
        If ConectarBD.CarregarIncidencies(VarBD.IDS(incidencies.SelectedIndex)) Then
            TitolInci.Text = VarBD.titol
            descripInici.Text = VarBD.descripcioIni
            cateinci.SelectedItem = VarBD.categoriaIni
            ConectarBD.ObtenirInfoInformatic(VarBD.dniInformatic)
            If VarBD.dniInformatic <> Nothing Then
                NomInformatic.Text = VarBD.userInfo
                If VarBD.curriculum <> Nothing Then

                    DescarregarCur.Enabled = True
                Else
                    DescarregarCur.Enabled = False
                End If
                siFeta.Enabled = True
                noFeta.Enabled = True
            Else
                NomInformatic.Text = "Incidència No assignada"
                DescarregarCur.Enabled = False
                siFeta.Enabled = False
                noFeta.Enabled = False
                siFeta.Checked = False
                noFeta.Checked = True
            End If

            If VarBD.estatInici Then
                siFeta.Checked = False
                noFeta.Checked = True
                mal.Enabled = False
                be.Enabled = False
                regular.Enabled = False

            Else
                siFeta.Checked = True
                noFeta.Checked = False
                mal.Enabled = True
                be.Enabled = True
                regular.Enabled = True
            End If

            If VarBD.valoracioIni <> Nothing Then
                If VarBD.valoracioIni.Equals("Bé") Then
                    be.Checked = True
                ElseIf VarBD.valoracioIni.Equals("Regular") Then
                    regular.Checked = True
                ElseIf VarBD.valoracioIni.Equals("Malament") Then
                    mal.Checked = True

                End If
            End If


        End If
    End Sub

    Private Sub siFeta_CheckedChanged(sender As Object, e As EventArgs) Handles siFeta.CheckedChanged

        mal.Enabled = True
        be.Enabled = True
        regular.Enabled = True

    End Sub

    Private Sub noFeta_CheckedChanged(sender As Object, e As EventArgs) Handles noFeta.CheckedChanged
        mal.Enabled = False
        be.Enabled = False
        regular.Enabled = False



        mal.Checked = False
        regular.Checked = False
        be.Checked = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ConectarBD = New BD
        Dim cate = cateinci.SelectedItem.ToString
        Dim estat As Integer = True
        Dim valoracio As String = " "
        If siFeta.Checked = True Then
            estat = False


        End If
        If be.Checked = True Then
            valoracio = be.Text
        ElseIf mal.Checked = True Then
            valoracio = mal.Text
        ElseIf regular.Checked = True Then
            valoracio = regular.Text

        End If

        If valoracio <> " " Then
            If ConectarBD.UpdateValoracio(VarBD.numIncidencia, valoracio) Then
            Else
                MsgBox("Error valoracio update")
            End If
        End If


        If ConectarBD.ModificarIncidencies(VarBD.numIncidencia, TitolInci, descripInici, cate, estat) Then

            If VarBD.actual = 0 Then
                MsgBox("Incidència Modificada")
            Else
                MsgBox("Incidencia Modificada")
            End If

        Else
            If VarBD.actual = 0 Then
                MsgBox("Incidència NO Modificada")
            Else
                MsgBox("Incidencia NO Modificada")
            End If


        End If
        ConectarBD.CarregarIncidenciesComboBox(incidencies, Fetes)
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        VarBD.dniUsuari = Nothing
        VarBD.dniInformatic = Nothing
        Me.Hide()
        Pantalla.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles sortir.Click
        VarBD.dniUsuari = Nothing
        VarBD.dniInformatic = Nothing
        Me.Hide()
        Pantalla.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()

        BorrarUser.Show()

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

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cargar()
        Me.Hide()
        If VarBD.actual = 0 Then
            FAQS.Show()
        Else
            FAQSES.Show()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DescarregarCur.Click
        Try
            Dim saveFileDialog1 As New SaveFileDialog()

            saveFileDialog1.Filter = "Word Files (*.docx)|*.docx|Word Files(*.doc)|*.doc|PDF files(*.pdf)|*.pdf|RTF files(*.rtf)|*.rtf|Text files (*.txt)|*.txt"
            saveFileDialog1.Title = "Save an Image File"
            saveFileDialog1.FileName = VarBD.curriculum

            saveFileDialog1.ShowDialog()
            
            If saveFileDialog1.FileName <> "" Then
                ' Saves the Image via a FileStream created by the OpenFile method.
                Dim fs As System.IO.FileStream = CType _
                    (saveFileDialog1.OpenFile(), System.IO.FileStream)
                ' Saves the Image in the appropriate ImageFormat based upon the
                ' file type selected in the dialog box.
                ' NOTE that the FilterIndex property is one-based.  
                Dim desc = Path.Combine(saveFileDialog1.FileName)



                fs.Close()
                My.Computer.Network.DownloadFile("FTP://ftp.provadam1.esy.es/" + VarBD.curriculum, desc, "u922516961", "123456", True, 500, True)
            End If

        Catch ex As Exception

            'MsgBox("ERROR del archiu")

        End Try



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Fetes.CheckedChanged

        ConectarBD.CarregarIncidenciesComboBox(incidencies, Fetes)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        If dioma.Text = "Anglès" Or VarBD.actual = False Then
            idioma.es()
            VarBD.actual = True

        Else
            idioma.ca()
            VarBD.actual = False

        End If
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
End Class