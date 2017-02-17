Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSettingCOACashFlow_Update

    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction

    Public Function select_component_cashflow() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_component_cashflow"
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


    Public Function select_detail_component_cashflow(ByVal criteria As String, ByVal before_insert As Integer, ByVal id_account As String) As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                If before_insert = 0 Then
                    .CommandText = "select id_account,account_name,case when id_component = '" & criteria & "' then 1 else 0 end as id_component from view_detail_component_cashflow where account_name like '%" & id_account & "%'"
                Else
                    .CommandText = "select id_account,account_name,case when id_component = '" & criteria & "' then 1 else 0 end as id_component from view_detail_component_cashflow where id_component = '" & criteria & "' and account_name like '%" & id_account & "%'"
                End If
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

    Public Sub insert_cashflow_setup(ByVal var_id_component As String, ByVal var_id_account As String, ByVal varloop As Integer, ByVal var_modified_user As String, ByVal modified_date As DateTime)

        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_setup_cashflow ('" & var_id_component & "','" & var_id_account & "'," & varloop & ",'" & username & "','" & Format(server_datetime(), "yyyy-MM-dd hh:mm:ss") & "')"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlinsert.ExecuteNonQuery()
            oTransaction.Commit()
            param_sukses = True
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            oTransaction.Rollback()
            param_sukses = False
        End Try
    End Sub


End Module
