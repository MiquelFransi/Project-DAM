Imports System.Data.SqlClient
Public Class ConectarBD
    Public conectardb As SqlConnection
    Public dr As SqlDataReader
    Dim insertstr, selectstr, updatestr, deletestr As String
    Public dniUsuari As String
    Public dniInformatic As String
    Public poblacio As String
    Public provincia As String
    Public nom As String
    Public cognom As String




    Public Sub New()
        Dim str As String
        conectardb = New SqlConnection
        str = "Data Source=oracle.ilerna.com;Initial Catalog=MYTEC;Persist Security Info=True;User ID=DAM2_Mytec;Password=LluisGili!"
        Me.conectardb.ConnectionString = str
        openSQL()

    End Sub
    Public Sub openSQL()
        Try
            conectardb.Open()

        Catch ex As Exception
            MessageBox.Show("No s'ha pogut connectar a la base de dades.")
        End Try
    End Sub
    Public Sub closeSQL()
        Try
            conectardb.Close()
        Catch ex As Exception
            MessageBox.Show("S'ha intentat tancar la connexió a la base de dades.\nPot ser que no estigues connectat.")
        End Try
    End Sub
    '------------LOGIN-----
    Function ConsultarLoginInformatic(user As TextBox, password As TextBox) As Boolean
        Dim ok = False
        Dim query As String = "select Nom, Cognoms, poblacio, provincia, Informatic, Contrasenya, DNI from Informatics"
        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader

        While data.Read()
            Dim usuari = Convert.ToString(data("NomInformatic").ToString)

            Dim contrasenyaBD = Convert.ToString(data("Contrasenya").ToString)

            dniInformatic = Convert.ToString(data("DNI").ToString)
            nom = Convert.ToString(data("Nom").ToString)
            cognom = Convert.ToString(data("Cognoms").ToString)
            poblacio = Convert.ToString(data("poblacio").ToString)
            provincia = Convert.ToString(data("provincia").ToString)

            Dim passEncript As String = Seguretat.Encriptar(password.Text)

            If usuari.Equals(user.Text) Then
                If contrasenyaBD.Equals(passEncript) Then
                    ok = True

                End If

            End If

        End While
        data.Close()

        Return ok

    End Function

    Function ConsultarLoginUser(user As TextBox, password As TextBox) As Boolean
        Dim ok = False
        Dim query As String = "select Nom, Cognoms, poblacio, provincia, Informatic, Contrasenya, DNI from Usuaris"
        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader

        While data.Read()
            Dim usuari = Convert.ToString(data("NomUsuari").ToString)

            Dim contrasenyaBD = Convert.ToString(data("Contrasenya").ToString)

            dniUsuari = Convert.ToString(data("DNI").ToString)
            Nom = Convert.ToString(data("Nom").ToString)
            cognom = Convert.ToString(data("Cognoms").ToString)
            poblacio = Convert.ToString(data("poblacio").ToString)
            provincia = Convert.ToString(data("provincia").ToString)

            Dim passEncript As String = Seguretat.Encriptar(password.Text)

            If usuari.Equals(user.Text) Then
                If contrasenyaBD.Equals(passEncript) Then
                    ok = True

                End If

            End If

        End While
        data.Close()
        Return ok

    End Function

    '---------------------------------REGISTRAR--------------
    Function InsertaUsers(user As TextBox, pass As TextBox, DNI As TextBox, nom As TextBox, cognom As TextBox, poblacio As TextBox, provincia As TextBox) As Boolean
        Dim ok = False
        Dim passEncrip = Seguretat.Encriptar(pass.Text)
        Dim query As String = "insert into Usuaris (DNI, Nom, Cognoms, NomUsuari, Poblacio, Provincia, Contrasenya) values ('" & DNI.Text & "','" & nom.Text & "','" & cognom.Text & "','" & user.Text & "','" & poblacio.Text & "','" & provincia.Text & "','" & passEncrip & "')"
        Dim Consulta = New SqlCommand(query, conectardb)
        Try
            Dim data = Consulta.ExecuteNonQuery
            ok = True
        Catch ex As Exception
            ok = False

        End Try

        Return ok
    End Function

    Function InsertaInformatic(user As TextBox, pass As TextBox, DNI As TextBox, nom As TextBox, cognom As TextBox, poblacio As TextBox, provincia As TextBox, curriculum As String) As Boolean
        Dim ok = False
        Dim passEncrip = Seguretat.Encriptar(pass.Text)
        Dim query As String = "insert into Informatics (DNI, Nom, Cognoms, NomUsuari, Poblacio, Provincia, Contrasenya, curriculum) values ('" & DNI.Text & "','" & nom.Text & "','" & cognom.Text & "','" & user.Text & "','" & poblacio.Text & "','" & provincia.Text & "','" & passEncrip & "','" & curriculum & "')"
        Dim Consulta = New SqlCommand(query, conectardb)
        Try
            Dim data = Consulta.ExecuteNonQuery
            ok = True
        Catch ex As Exception
            ok = False

        End Try

        Return ok
    End Function

    ' -------------------INCIDENCIES------------------------

    Function CrearIncidencies(nom As TextBox, descripcio As TextBox, poblacio As TextBox, provincia As TextBox, nivell As CheckBox, categoria As ComboBox) As Boolean
        Dim ok As Boolean
        Dim query As String = "insert into incidencies(nom, dniUsuari, descripcio, poblacio, provincia, nivell) values ('" & nom.Text & "','" & dniUsuari & "','" & descripcio.Text & "','" & poblacio.Text & "','" & provincia.Text & "','" & nivell.Text & "','" & categoria.SelectedItem.ToString & "')"
        Dim Consulta = New SqlCommand(query, conectardb)
        Try
            Dim data = Consulta.ExecuteNonQuery
            ok = True
        Catch ex As Exception
            ok = False

        End Try

        Return ok

    End Function



End Class

