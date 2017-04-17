Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

#Const USE_BASE64 = True

'
' A Class to encrypt/decrypt strings using the DES algorythm.
' Note: I don't like "Base 64" string format, so I often use hex strings
' instead
'
Public Class crypt

    ' The password is made up of a pair of arrays, each 8 bytes long
    Private TheKey() As Byte = {&H1F, &H27, &HB3, &H24, &H50, &H6, &H7A, &H88}
    Private Vector() As Byte = {&HF1, &H5E, &H33, &H30, &H2F, &H9A, &H99, &H81}

    '
    ' A simple DES string Encrytion routine
    '
    Public Function Encrypt(ByVal message As String) As String
        Dim des As New DESCryptoServiceProvider
        Dim ms As New MemoryStream
        Dim in_buf(), out_buf() As Byte

        ' a quick sanity check
        If message = "" Then
            Return ""
        End If

        ' put the cleartext into the input buffer
        in_buf = Encoding.ASCII.GetBytes(message)

        Try
            ' create an DES Encryptor output stream
            Dim crStream As New CryptoStream(ms, des.CreateEncryptor(TheKey, Vector), CryptoStreamMode.Write)

            ' push the cleartext into the "translator"
            crStream.Write(in_buf, 0, in_buf.Length)
            crStream.FlushFinalBlock()

            ' read the ciphertext out of the translator
            out_buf = ms.ToArray

            ms.Close()
            crStream.Close()
        Catch ex As System.Security.Cryptography.CryptographicException
            ' if encryption fails, just silently return an empty string
            Return ""
        End Try

#If USE_BASE64 Then
        Return Convert.ToBase64String(out_buf)
#Else
        Return BitConverter.ToString(out_buf).Replace("-", "")
#End If
    End Function

    '
    ' A simple DES decryption routine
    '
    Public Function Decrypt(ByVal message As String) As String
        Dim des As New DESCryptoServiceProvider
        Dim ms As New MemoryStream
        Dim in_buf(), out_buf() As Byte

        ' a quick sanity check
        If message = "" Then
            Return ""
        End If

        Try
            ' put the ciphertext into the input buffer
#If USE_BASE64 Then
            in_buf = Convert.FromBase64String(message)
#Else
            ' There's no easy way to convert a hex byte string back into
            ' a byte array, so we have parse each byte
            ReDim in_buf((message.Length \ 2) - 1)
            For i As Integer = 0 To in_buf.Length - 1
                in_buf(i) = Byte.Parse(message.Substring(i * 2, 2), Globalization.NumberStyles.HexNumber)
            Next
#End If
        Catch ex As System.FormatException
            ' if the string isn't in the correct format, then just silently fail
            Return ""
        End Try

        Try
            ' Create an DES Decryptor stream
            Dim crStream As New CryptoStream(ms, des.CreateDecryptor(TheKey, Vector), CryptoStreamMode.Write)

            ' push the ciphertext into the "translator" 
            crStream.Write(in_buf, 0, in_buf.Length)
            crStream.FlushFinalBlock()

            ' read the cleartext out of the translator
            out_buf = ms.ToArray

            ms.Close()
            crStream.Close()
        Catch ex As System.Security.Cryptography.CryptographicException
            ' if decryption fails, just silently return an empty string
            Return ""
        End Try

        Return Encoding.ASCII.GetString(out_buf)
    End Function
End Class
