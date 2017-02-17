Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlLaporanAset_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function get_first_aset() As String
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select id_aset, nama from mst_aset order by id_aset asc limit 1"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return ""
        End Try

    End Function

    Public Function get_last_aset() As String
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select id_aset, nama from mst_aset order by id_aset desc limit 1"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return ""
        End Try

    End Function



End Module
