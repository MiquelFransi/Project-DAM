Imports System.Data.SqlClient
Public Class BD
    Public conectardb As SqlConnection
    Public dr As SqlDataReader
    Dim insertstr, selectstr, updatestr, deletestr As String

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
    '------------LOGIN---------------------------------------------
    Function ConsultarLoginInformatic(user As TextBox, password As TextBox) As Boolean
        Dim ok = False
        Dim query As String = "select Nom, NomInformatic, Cognoms, poblacio, provincia,  Contrasenya, DNI from Informatics  where actiu = 1"
        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader

        While data.Read()
            VarBD.userInfo = Convert.ToString(data("NomInformatic").ToString)

            Dim contrasenyaBD = Convert.ToString(data("Contrasenya").ToString)



            Dim passEncript As String = Seguretat.Encriptar(password.Text)

            If VarBD.userInfo.Equals(user.Text) Then
                If contrasenyaBD.Equals(passEncript) Then
                    ok = True
                    VarBD.userInfo = Convert.ToString(data("NomInformatic").ToString)
                    VarBD.dniInformatic = Convert.ToString(data("DNI").ToString)
                    VarBD.nomInfo = Convert.ToString(data("Nom").ToString)
                    VarBD.cognomInfo = Convert.ToString(data("Cognoms").ToString)
                    VarBD.poblInfo = Convert.ToString(data("poblacio").ToString)
                    VarBD.provInfo = Convert.ToString(data("provincia").ToString)
                End If

            End If

        End While
        data.Close()

        Return ok

    End Function

    Function ConsultarLoginUser(user As TextBox, password As TextBox) As Boolean
        Dim ok = False
        Dim query As String = "select Nom, NomUsuari, Cognoms, poblacio, provincia,  Contrasenya, DNI from Usuaris where actiu = 1"
        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader

        While data.Read()
            Dim usuari = Convert.ToString(data("NomUsuari").ToString)

            Dim contrasenyaBD = Convert.ToString(data("Contrasenya").ToString)


            Dim passEncript As String = Seguretat.Encriptar(password.Text)

            If usuari.Equals(user.Text) Then
                If contrasenyaBD.Equals(passEncript) Then
                    ok = True
                    VarBD.Nomuser = Convert.ToString(data("NomUsuari").ToString)
                    VarBD.dniUsuari = Convert.ToString(data("DNI").ToString)
                    VarBD.nom = Convert.ToString(data("Nom").ToString)
                    VarBD.cognom = Convert.ToString(data("Cognoms").ToString)
                    VarBD.poblacio = Convert.ToString(data("poblacio").ToString)
                    VarBD.provincia = Convert.ToString(data("provincia").ToString)
                End If

            End If

        End While
        data.Close()
        Return ok

    End Function

    '---------------------------------REGISTRAR---------------------------------
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
        'curriculum = "c:/fgfd"
        Dim passEncrip = Seguretat.Encriptar(pass.Text)

        Dim query As String = "insert into Informatics (DNI, Nom, Cognoms, NomInformatic, Poblacio, Provincia, Contrasenya, curriculum) values ('" & DNI.Text & "','" & nom.Text & "','" & cognom.Text & "','" & user.Text & "','" & poblacio.Text & "','" & provincia.Text & "','" & passEncrip & "','" & curriculum & "')"

        Dim Consulta = New SqlCommand(query, conectardb)
        Try
            Dim data = Consulta.ExecuteNonQuery
            ok = True

        Catch ex As Exception
            ok = False

        End Try

        Return ok
    End Function
    '----------------CATEGORIES-----------

    Function Categories(cate As ComboBox)
        cate.Items.Clear()

        Dim query As String = "select nom from categoria"
        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader

        While data.Read()

            Dim nom = Convert.ToString(data("nom").ToString)

            cate.Items.Add(nom)



        End While
        data.Close()


    End Function


    ' -------------------INCIDENCIES------------------------------------------------------

    Function CarregarIncidenciesComboBox(incidencies As ComboBox, Fetes As CheckBox)
        incidencies.Items.Clear()
        Dim query As String = ""
        If Fetes.Checked = True Then
            query = "select numIncidencia, nom from incidencies where  dniUsuari = '" & VarBD.dniUsuari & "'"
        Else
            query = "select numIncidencia, nom from incidencies where estat = 1 AND dniUsuari = '" & VarBD.dniUsuari & "'"
        End If


        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader
        Dim a As Integer = 0
        While data.Read()

            Dim nom = Convert.ToString(data("nom").ToString)
            Dim id = Convert.ToString(data("numIncidencia").ToString)
            VarBD.IDS(a) = id
            incidencies.Items.Add(nom)

            a = a + 1

        End While

        data.Close()
    End Function



    Function CarregarIncidenciesComboBoxInformatic(incidencies As ComboBox)
        incidencies.Items.Clear()
        Dim query As String = "select numIncidencia, nom from incidencies where dniInformatic = '" & VarBD.dniInformatic & "'"
        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader
        Dim a As Integer = 0
        While data.Read()

            Dim nom = Convert.ToString(data("nom").ToString)
            Dim id = Convert.ToString(data("numIncidencia").ToString)
            VarBD.IDS(a) = id
            incidencies.Items.Add(nom)

            a = a + 1

        End While

        data.Close()
    End Function

    Function CarregarIncidencies(incidenciaId As String) As Boolean

        Dim query As String = "select i.numIncidencia, i.nom, i.dniUsuari, i.dniInformatic, i.descripcio, i.categoria, i.estat, v.valoracio, i.poblacio, i.provincia  from incidencies i full JOIN valoracio v ON i.numIncidencia = v.numIncidencia    where i.numIncidencia =  '" & incidenciaId & "'"
        Dim Consulta = New SqlCommand(query, conectardb)
        'Principal.titol.Text = query
        'MsgBox(query)
        Dim data = Consulta.ExecuteReader
        While data.Read()

            VarBD.titol = Convert.ToString(data("nom").ToString)
            VarBD.dniInformatic = Convert.ToString(data("dniInformatic").ToString)
            VarBD.descripcioIni = Convert.ToString(data("descripcio").ToString)
            VarBD.categoriaIni = Convert.ToString(data("categoria").ToString)
            VarBD.estatInici = Convert.ToString(data("estat").ToString)
            VarBD.numIncidencia = Convert.ToString(data("numIncidencia").ToString)
            VarBD.valoracioIni = Convert.ToString(data("valoracio").ToString)
            VarBD.dniUsuari = Convert.ToString(data("dniUsuari").ToString)
            VarBD.poblacioInci = Convert.ToString(data("poblacio").ToString)
            VarBD.provinciInci = Convert.ToString(data("provincia").ToString)


        End While
        data.Close()
        Return True
    End Function


    Function CrearIncidencies(nom As TextBox, descripcio As TextBox, poblacio As TextBox, provincia As TextBox, nivell As Integer, categoria As String) As Boolean
        Dim ok As Boolean
        Dim query As String = "insert into incidencies(nom, dniUsuari, descripcio, poblacio, provincia, nivell, categoria ) values('" & nom.Text & "','" & VarBD.dniUsuari & "','" & descripcio.Text & "','" & poblacio.Text & "','" & provincia.Text & "','" & nivell & "','" & categoria & "')"


        'Principal.titol.Text = query
        Dim Consulta = New SqlCommand(query, conectardb)

        Try
            Dim data = Consulta.ExecuteNonQuery

            ok = True
        Catch ex As Exception
            ok = False

        End Try

        Return ok

    End Function


    Function ModificarIncidencies(numIncidencia As Integer, nom As TextBox, descripcio As TextBox, categoria As String, estat As Boolean) As Boolean
        Dim ok As Boolean
        Dim query As String = "update incidencies set nom ='" & nom.Text & "', descripcio ='" & descripcio.Text & "', categoria='" & categoria & "', estat = '" & estat & "' where numIncidencia =  '" & numIncidencia & "' "

        'Principal.titol.Text = query
        Dim Consulta = New SqlCommand(query, conectardb)

        Try
            Dim data = Consulta.ExecuteNonQuery

            ok = True
        Catch ex As Exception
            ok = False

        End Try

        Return ok

    End Function


    Function CarregarIncidenciesDataGridView(datagrid As DataGridView, categoria As String)

        datagrid.Rows.Clear()

        Dim query As String
        If categoria <> Nothing Then
            query = "select i.numIncidencia,  i.nom, u.NomUsuari, i.poblacio, i.provincia, i.dataCreacio, i.categoria from incidencies i  inner join usuaris u on i.dniUsuari = u.dni where estat = 1 and i.dniInformatic is null and u.actiu = 1 and   categoria='" & categoria & "'"
        Else
            query = "select i.numIncidencia,  i.nom, u.NomUsuari, i.poblacio, i.provincia, i.dataCreacio, i.categoria from incidencies i  inner join usuaris u on i.dniUsuari = u.dni where estat = 1 and i.dniInformatic is null and u.actiu = 1 "

        End If
        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader
        Dim a As Integer = 0
        While data.Read()

            Dim nom = Convert.ToString(data("nom").ToString)
            Dim poblacio = Convert.ToString(data("poblacio").ToString)

            Dim provincia = Convert.ToString(data("provincia").ToString)

            Dim dataCreacio As DateTime = Convert.ToDateTime(data("dataCreacio"))



            'Dim dataCreacio = Convert.ToDateTime(data("dataCreacio").ToString)

            Dim id = Convert.ToString(data("numIncidencia").ToString)
            Dim nomUsuari = Convert.ToString(data("NomUsuari").ToString)
            Dim Cate = Convert.ToString(data("Categoria").ToString)


            VarBD.IDSView(a) = id

            datagrid.Rows.Add(nom, nomUsuari, Cate, poblacio, provincia, dataCreacio.ToString("dd/MM/yyyy"), "Assignar")



            a = a + 1

        End While

        data.Close()
    End Function

    Function assignar(numIncidencia As String)
        ' MsgBox(numIncidencia)


        Dim ok As Boolean
        Dim query As String = "update  incidencies  set   dniInformatic = '" & VarBD.dniInformatic & "' where numIncidencia = '" & numIncidencia & "'  "
        ' MsgBox(query)

        ' Principal.titol.Text = query
        Dim Consulta = New SqlCommand(query, conectardb)

        Try
            Dim data = Consulta.ExecuteNonQuery

            ok = True
        Catch ex As Exception
            ok = False

        End Try

        Return ok


    End Function

    '--------INFORMATIC INFO-----------------
    Function ObtenirInfoInformatic(dniINfoInce As String) As Boolean
        Dim ok = False
        Dim query As String = "Select Nom, NomInformatic, Cognoms, poblacio, provincia,   DNI, curriculum from Informatics where DNI = '" & dniINfoInce & "'"
        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader

        While data.Read()

            VarBD.userInfo = Convert.ToString(data("NomInformatic").ToString)
            VarBD.nomInfo = Convert.ToString(data("Nom").ToString)
            VarBD.cognomInfo = Convert.ToString(data("Cognoms").ToString)
            VarBD.poblInfo = Convert.ToString(data("poblacio").ToString)
            VarBD.provInfo = Convert.ToString(data("provincia").ToString)
            VarBD.curriculum = Convert.ToString(data("curriculum").ToString)

        End While
        data.Close()

        Return ok

    End Function
    '--------USER INFO-----------------

    Function ObtenirInfoUser(dniUser As String) As Boolean

        Dim ok = False
        Dim query As String = "select Nom, NomUsuari, Cognoms, poblacio, provincia,  DNI from Usuaris where DNI = '" & dniUser & "'"
        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader

        While data.Read()

            VarBD.Nomuser = Convert.ToString(data("NomUsuari").ToString)
            VarBD.nom = Convert.ToString(data("Nom").ToString)
            VarBD.cognom = Convert.ToString(data("Cognoms").ToString)
            VarBD.poblacio = Convert.ToString(data("poblacio").ToString)
            VarBD.provincia = Convert.ToString(data("provincia").ToString)

        End While
        data.Close()

        Return ok

    End Function


    '---------------VALORACIO----------------
    Function InsertarValoracio(numIncidencia As String) As Boolean
        Dim ok As Boolean
        ''SELECT----------------------

        Dim query As String
        query = "select dniUsuari from incidencies where numIncidencia = '" & numIncidencia & "'"


        Dim Consulta = New SqlCommand(query, conectardb)
        Dim data = Consulta.ExecuteReader
        While data.Read()

            VarBD.dniUsuari = Convert.ToString(data("dniUsuari").ToString)

        End While

        data.Close()



        ''UPDATE
        query = "insert into valoracio (numIncidencia,  VarBD.DniUsuari, DniInformatic) values ('" & numIncidencia & "','" & dniUsuari & "','" & VarBD.dniInformatic & "')"
        ' MsgBox(query)

        Consulta = New SqlCommand(query, conectardb)

        Try
            Dim data2 = Consulta.ExecuteNonQuery

            ok = True
        Catch ex As Exception
            ok = False

        End Try

        Return ok
    End Function
    '----------UPDATE VALORACIO-------
    Function UpdateValoracio(numIncidencia As String, valoracio As String)
        Dim ok As Boolean
        Dim query As String = "update  valoracio  set   valoracio = '" & valoracio & "' where numIncidencia = '" & numIncidencia & "'  "
        ' MsgBox(query)

        ' Principal.titol.Text = query
        Dim Consulta = New SqlCommand(query, conectardb)

        Try
            Dim data = Consulta.ExecuteNonQuery

            ok = True
        Catch ex As Exception
            ok = False

        End Try

        Return ok
    End Function

    Function BorrarInformatic()

        Dim ok As Boolean
        Dim query As String = "update informatics set actiu = 0  where dni = '" & VarBD.dniInformatic & "'"
        'MsgBox(query)

        ' Principal.titol.Text = query
        Dim Consulta = New SqlCommand(query, conectardb)


        Dim query2 As String = "update incidencies set estat = 0 where  dniInformatic= '" & VarBD.dniInformatic & "'"
        '' MsgBox(query)

        Dim Consulta2 = New SqlCommand(query2, conectardb)

        Try
            Dim data = Consulta.ExecuteNonQuery

            Dim data2 = Consulta2.ExecuteNonQuery

            ok = True
        Catch ex As Exception
            ok = False

        End Try

        Return ok

    End Function

    Function BorrarUsuari()

        Dim ok As Boolean
        Dim query As String = "update Usuaris set actiu = 0 where dni = '" & VarBD.dniUsuari & "'"
        '' MsgBox(query)

        Dim Consulta = New SqlCommand(query, conectardb)




        Dim query2 As String = "update incidencies set  estat = 0 where dniUsuari = '" & VarBD.dniUsuari & "'"
        '' MsgBox(query)

        Dim Consulta2 = New SqlCommand(query2, conectardb)

        Try
            Dim data = Consulta.ExecuteNonQuery
            Dim data2 = Consulta2.ExecuteNonQuery


            ok = True
        Catch ex As Exception
            ok = False

        End Try

        Return ok

    End Function



End Class
