Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPengirimanBarang_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub delete_do(ByVal var_no_delivery_order As String, ByVal var_no_sales_order As String, ByVal var_id_customer As String, ByVal var_date_trn As Date, ByVal var_notes As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_number_asc As Integer, ByVal var_id_item As String, ByVal var_notes_det As String, ByVal var_qty As Integer, ByVal var_id_unit As String, ByVal var_detail As Integer, ByVal varloop As Integer, ByVal transid As String, ByVal var_sent_qty As Integer, ByVal var_qty_before As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_delivered_item('" & var_no_delivery_order & "','" & var_no_sales_order & "','" & var_id_customer & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_notes & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "'," & var_number_asc & ",'" & var_id_item & "','" & var_notes_det & "'," & var_qty & ",'" & var_id_unit & "'," & var_detail & "," & varloop & ",'DELETE'," & var_sent_qty & "," & var_qty_before & ",'WH001','','',0,'','','','')"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqldelete.ExecuteNonQuery()
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
