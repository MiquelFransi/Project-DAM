Public Class BorrarUser
    Private Sub BorrarUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox4.Image = Image.FromFile("back.png")
        If VarBD.actual = 0 Then
            idioma.ca()
        Else
            idioma.es()

        End If
    End Sub
    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles label_baixa.Click
        Dim bd = New BD
        Dim question As Integer

        question = MsgBox("Borrar?", vbYesNo + vbQuestion, "Empty Sheet")

        ' MsgBox question

        If question = vbYes Then

            bd.BorrarUsuari()
            Pantalla.Show()
            Me.Hide()

        Else
            Principal.Show()
            Me.Hide()

            Exit Sub
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Principal.Show()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles darrere.Click
        Me.Hide()
        Principal.Show()

    End Sub
End Class