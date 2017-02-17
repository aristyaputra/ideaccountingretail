Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSettingCOAKasBank_Update

    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction

    Public Function select_cash_set() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select a.id_account,a.account_name,case when b.id_account is null or b.id_cashbank <> 1 then 'false' else 'true' end as pilih from mst_account a left join i_cashbank_setup b on b.id_account = a.id_account  where a.flag_header = 0"
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

    Public Function select_bank_set() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select a.id_account,a.account_name,case when b.id_account is null or b.id_cashbank <> 2 then 'false' else 'true' end as pilih from mst_account a left join i_cashbank_setup b on b.id_account = a.id_account  where a.flag_header = 0"
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


    Public Sub insert_cashbank_setup(ByVal var_id_account As String, ByVal varloop As Integer, ByVal var_user As String, ByVal var_date As Date, ByVal i As Integer)

        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_setup_cashbank ('" & var_id_account & "'," & varloop & ",'" & var_user & "','" & Format(var_date, "yyyy-MM-dd") & "'," & i & ")"
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
