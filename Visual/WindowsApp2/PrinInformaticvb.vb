Public Class PrinInformaticvb
    Dim bd = New BD

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IncidenciesInfor.SelectedIndexChanged
        Dim bd = New BD
        If bd.CarregarIncidencies(VarBD.IDS(IncidenciesInfor.SelectedIndex)) Then
            bd.ObtenirInfoUser(VarBD.dniUsuari)
            NomUser.Text = VarBD.Nomuser
            TitolInci.Text = VarBD.titol
            descripInici.Text = VarBD.descripcioIni
            cateinci.SelectedItem = VarBD.categoriaIni
            ProvInci.Text = VarBD.provinciInci
            PobIncidencia.Text = VarBD.provinciInci


            If VarBD.estatInici Then
                siFeta.Checked = False
                noFeta.Checked = True


            Else
                siFeta.Checked = True
                noFeta.Checked = False

            End If
            regular.Checked = False
            mal.Checked = False
            be.Checked = False

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

    Private Sub PrinInformaticvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar()

    End Sub

    Public Function cargar()

        If VarBD.actual = 0 Then
            dioma.SelectedItem = "Català"
            idioma.ca()
        Else
            dioma.SelectedItem = "Anglès"
            idioma.es()

        End If
        TitolInci.Text = ""
        descripInici.Text = ""
        ProvInci.Text = ""
        PobIncidencia.Text = ""
        PictureBox4.Image = Image.FromFile("salir.png")
        bd.CarregarIncidenciesComboBoxInformatic(IncidenciesInfor)
        BotoMenuVertical.Image = Image.FromFile("Menu2.png")
        FaqFoto.Image = Image.FromFile("interogacion.png")
        baixaFoto.Image = Image.FromFile("creu.png")
        nom.Text = VarBD.nomInfo
        cognom.Text = VarBD.cognomInfo
        bd.Categories(cateinci)
        bd.Categories(cateFiltreInci)
        bd.CarregarIncidenciesDataGridView(DataGridView1, cateFiltreInci.Text)
        NomUser.Text = Nothing

        Pantalla.cargar()
        VarBD.dniUsuari = Nothing

    End Function


    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cateFiltreInci.SelectedIndexChanged
        bd.CarregarIncidenciesDataGridView(DataGridView1, cateFiltreInci.Text)

    End Sub

    Private Sub DataGridView1_confirm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "Assignar" Then
            Dim num = e.RowIndex
            Dim id = VarBD.IDSView(e.RowIndex)
            bd.assignar(id)
            bd.InsertarValoracio(id)
            bd.CarregarIncidenciesComboBoxInformatic(IncidenciesInfor)
            bd.CarregarIncidenciesDataGridView(DataGridView1, cateFiltreInci.Text)

        End If
    End Sub

    Private Sub baixaFoto_Click(sender As Object, e As EventArgs) Handles baixaFoto.Click
        BorrarInfo.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles sortir.Click
        Me.Hide()
        VarBD.dniUsuari = Nothing
        VarBD.dniInformatic = Nothing
        Pantalla.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles label_baixa.Click
        BorrarInfo.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Pantalla.Show()
        Me.Hide()
        VarBD.dniUsuari = Nothing
        VarBD.dniInformatic = Nothing
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        cargar()
        Me.Hide()
        If VarBD.actual = 0 Then
            FAQS.Show()
        Else
            FAQSES.Show()

        End If
    End Sub

    Private Sub FaqFoto_Click(sender As Object, e As EventArgs) Handles FaqFoto.Click
        cargar()
        Me.Hide()
        If VarBD.actual = 0 Then
            FAQS.Show()
        Else
            FAQSES.Show()

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Fetes_CheckedChanged(sender As Object, e As EventArgs) Handles Fetes.CheckedChanged
        bd.CarregarIncidenciesComboBox(IncidenciesInfor, Fetes)
    End Sub

    Private Sub idioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dioma.SelectedIndexChanged
        If dioma.Text = "Anglès" Or VarBD.actual = False Then
            idioma.es()
            VarBD.actual = True

        Else
            idioma.ca()
            VarBD.actual = False

        End If
    End Sub
End Class