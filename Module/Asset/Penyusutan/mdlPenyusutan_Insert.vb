Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPenyusutan_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_penyusutan(ByVal var_no_journal As String, ByVal var_date_trn As Date, ByVal var_created_user As String, ByVal var_created_date As Date, ByVal var_modified_user As String, ByVal var_modified_date As Date, ByVal var_id_aset As String, ByVal var_id_account_depr As String, ByVal var_id_account_akum As String, ByVal var_notes As String, ByVal var_amount As Double, ByVal var_detail As Integer, ByVal transid As String, ByVal varloop As Integer, ByVal var_total As Double, ByVal id_curr As String, ByVal var_kurs As Double, ByVal var_period As Double, ByVal var_years As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_journal_depreciation('" & var_no_journal & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_created_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & var_modified_user & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_id_aset & "','" & var_id_account_depr & "','" & var_id_account_akum & "','" & var_notes & "'," & var_amount & "," & var_detail & ",'INSERT'," & varloop & "," & var_total & ",'" & id_curr & "'," & var_kurs & "," & var_period & "," & var_years & ")"
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
