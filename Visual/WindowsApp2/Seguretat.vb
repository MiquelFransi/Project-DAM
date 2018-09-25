Imports System.Security.Cryptography
Imports System.Text

Public Class Seguretat



    Public Shared Function Encriptar(ByVal stringEncriptar As String) As String

        Dim UE As New UnicodeEncoding
        Dim bHash As Byte()
        Dim ByteValue() As Byte


        Dim bCadena() As Byte = UE.GetBytes(stringEncriptar)

        ByteValue = System.Text.Encoding.UTF8.GetBytes(stringEncriptar)

        Dim s1Service As New SHA1CryptoServiceProvider


        bHash = s1Service.ComputeHash(ByteValue)

        Dim strTemp As New StringBuilder(bHash.Length * 2)

        For Each b As Byte In bHash
            strTemp.Append(b.ToString("X02"))
        Next
        Dim Resumen As String
        Resumen = strTemp.ToString().ToLower


        Return Resumen


    End Function

End Class