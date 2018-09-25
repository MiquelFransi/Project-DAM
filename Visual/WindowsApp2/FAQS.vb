Public Class FAQS
    Private Sub FAQS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox7.Image = Image.FromFile("Menu2.png")
        PictureBox4.Image = Image.FromFile("back.png")
    End Sub


    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If Menu.Width = 150 Then
            Menu.Width = 50
        Else
            Menu.Width = 150


        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles darrere.Click
        Pantalla.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click


        If VarBD.dniInformatic <> Nothing Then
            PrinInformaticvb.Show()


        ElseIf VarBD.dniUsuari <> Nothing Then
            Principal.Show()
        Else
            Pantalla.Show()


        End If
        Me.Hide()

    End Sub
End Class