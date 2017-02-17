Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlRekonsiliasiBank_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub insert_Reconcile(ByVal var_no_reconcile As String, ByVal var_date_trn As Date, ByVal var_id_account_head As String, ByVal var_balance_before As Double, ByVal var_reconcile As Double, ByVal var_balance_after As Double, ByVal var_created_user As String, ByVal var_created_date As Date, ByVal var_modified_user As String, ByVal var_modified_date As Date, ByVal var_id_account_det As String, ByVal var_notes As String, ByVal var_amount_in As Double, ByVal var_amount_out As Double, ByVal var_detail As Integer, ByVal var_loop As Integer, ByVal var_notes_head As String, ByVal var_curr As String, ByVal var_kurs As Double)

        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_reconcile ('" & var_no_reconcile & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_id_account_head & "'," & var_balance_before & "," & var_reconcile & "," & var_balance_after & ",'" & var_created_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & var_modified_user & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_id_account_det & "','" & var_notes & "'," & var_amount_in & "," & var_amount_out & "," & var_detail & "," & var_loop & ",'INSERT','" & var_notes_head & "','" & var_curr & "'," & var_kurs & ")"
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
