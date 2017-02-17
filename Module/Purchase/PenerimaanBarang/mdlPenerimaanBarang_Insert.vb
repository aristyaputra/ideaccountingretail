Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPenerimaanBarang_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_rec(ByVal var_no_received_order As String, ByVal var_no_purchase_order As String, ByVal var_id_supplier As String, ByVal var_date_trn As Date, ByVal var_notes As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_number_asc As Integer, ByVal var_id_item As String, ByVal var_notes_det As String, ByVal var_qty As Integer, ByVal var_id_unit As String, ByVal var_detail As Integer, ByVal varloop As Integer, ByVal transid As String, ByVal var_received_qty As Integer, ByVal var_qty_before As Integer, ByVal gudang As String, ByVal id_gudang As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_received_order('" & var_no_received_order & "','" & var_no_purchase_order & "','" & var_id_supplier & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_notes & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "'," & var_number_asc & ",'" & var_id_item & "','" & var_notes_det & "'," & var_qty & ",'" & var_id_unit & "'," & var_detail & "," & varloop & ",'INSERT'," & var_received_qty & "," & var_qty_before & ",'" & gudang & "','" & id_gudang & "')"
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
