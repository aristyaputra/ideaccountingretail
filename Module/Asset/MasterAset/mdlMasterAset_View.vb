Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlMasterAset_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function cek_nilaibuku_aset(ByVal var_id_golongan As String, ByVal var_nilai_perolehan As Double, ByVal var_tgl_perolehan As Date) As Double
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call sp_cek_nilaibuku_aset('" & var_id_golongan & "'," & var_nilai_perolehan & ",'" & Format(var_tgl_perolehan, "yyyy-MM-dd") & "')"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT.Rows(0).Item(0)
        End Try

    End Function


End Module
