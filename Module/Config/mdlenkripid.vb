Module mdlenkripid

    Public Function EnkripsiID(ByVal teks As String) As String
        Dim EnkripsiKarakter As String, EnkripsiText As String
        Dim Teks_Asli As String, Teks_Sandi As String, PanjangTeks As Long
        Dim Pos As Long
        Teks_Sandi = "?!@#$%^&*()_+|;:,â€™.-`~1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "
        Teks_Asli = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890?!@#$%^&*()_+|;:,â€™.-`~"
        For PanjangTeks = 1 To Len(teks)
            Pos = InStr(Teks_Asli, Mid(teks, PanjangTeks, 1))
            If Pos > 0 Then
                EnkripsiKarakter = Mid(Teks_Sandi, Pos, 1)
                EnkripsiText = EnkripsiText + EnkripsiKarakter
            Else
                EnkripsiText = EnkripsiText + Mid(teks, PanjangTeks, 1)
            End If
        Next
        EnkripsiID = EnkripsiText
    End Function


    Public Function DekripsiID(ByVal Teks As String) As String
        Dim DekripsiKarakter As String, DekripsiText As String
        Dim Teks_Asli As String, Teks_Sandi As String, PanjangTeks As Long
        Dim Pos As Long

        Teks_Sandi = "?!@#$%^&*()_+|;:,â€™.-`~1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ "
        Teks_Asli = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890?!@#$%^&*()_+|;:,â€™.-`~"
        For PanjangTeks = 1 To Len(Teks)
            Pos = InStr(Teks_Sandi, Mid(Teks, PanjangTeks, 1))
            If Pos > 0 Then
                DekripsiKarakter = Mid(Teks_Asli, Pos, 1)
                DekripsiText = DekripsiText + DekripsiKarakter
            Else
                DekripsiText = DekripsiText + Mid(Teks, PanjangTeks, 1)
            End If
        Next
        DekripsiID = DekripsiText
    End Function
End Module
