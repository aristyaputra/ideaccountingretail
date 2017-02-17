Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSettingCOADefault_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_def_account() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select a.notes,case when a.id_account is null then '' else a.id_account end as id_account,case when b.account_name is null then '' else b.account_name end as account_name,a.acc_parameter from i_set_account_def a left join mst_account b on b.id_account = a.id_account"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT
        End Try

    End Function


End Module
