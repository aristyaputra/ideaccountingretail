Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSO_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub delete_sales_order(ByVal var_no_sales_order As String, ByVal var_id_customer As String, ByVal var_date_trn As Date, ByVal var_notes As String, ByVal var_subtotal As Double, ByVal var_tax As Double, ByVal var_total As Double, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_number_asc As Integer, ByVal var_id_item As String, ByVal var_notes_det As String, ByVal var_qty As Integer, ByVal var_id_unit As String, ByVal var_price As Double, ByVal var_nominal As Double, ByVal var_id_curr As String, ByVal var_detail As Integer, ByVal varloop As Integer, ByVal var_uang_muka As Double, ByVal var_id_account As String, ByVal var_id_curr_um As String, ByVal var_kurs_um As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_sales_order ('" & var_no_sales_order & "','" & var_id_customer & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_notes & "'," & var_subtotal & "," & var_tax & "," & var_total & ",'" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "'," & var_number_asc & ",'" & var_id_item & "','" & var_notes_det & "'," & var_qty & ",'" & var_id_unit & "'," & var_price & "," & var_nominal & ",'" & var_id_curr & "'," & var_detail & "," & varloop & ",'DELETE',1,'OFC', '', '', '', '', 0, 0, 0, 0, 0,0,0,0,0,0,'','',''," & var_uang_muka & ",'" & var_id_account & "','" & var_id_curr_um & "'," & var_kurs_um & ",'',0)"
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
            param_sukses = False
            oTransaction.Rollback()
        End Try
    End Sub


End Module
