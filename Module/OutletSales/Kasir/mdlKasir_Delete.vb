Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlKasir_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub delete_salon_service(ByVal var_no_service As String, ByVal var_id_customer As String, ByVal var_payment_method As Integer, ByVal var_subtotal As Double, ByVal var_discount As Double, ByVal var_tax As Double, ByVal var_total As Double, ByVal var_notes As String, ByVal var_created_user As String, ByVal var_created_date As Date, ByVal var_modified_user As String, ByVal var_modified_date As Date, ByVal var_date_trn As Date, ByVal var_number_asc As Integer, ByVal var_id_service As String, ByVal var_id_marketing As String, ByVal var_notes_det As String, ByVal var_qty As Integer, ByVal var_price As Double, ByVal var_nominal As Double, ByVal var_id_curr As String, ByVal var_notes_ledger As String, ByVal var_amount As Double, ByVal var_number_asc_item As Integer, ByVal var_id_item As String, ByVal var_notes_item As String, ByVal varloop As Integer, ByVal var_detail As Integer, ByVal transid As String, ByVal var_car_brand_id As String, ByVal var_car_name As String, ByVal var_car_nopol As String, ByVal var_cust_name As String, ByVal flag_member As Integer, ByVal cust_name As String, ByVal cust_phone As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_sales_service ('" & var_no_service & "','" & var_id_customer & "'," & var_payment_method & "," & var_subtotal & "," & var_discount & "," & var_tax & "," & var_total & ",'" & var_notes & "','" & var_created_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & var_modified_user & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & Format(var_date_trn, "yyyy-MM-dd") & "'," & var_number_asc & ",'" & var_id_service & "','" & var_id_marketing & "','" & var_notes_det & "'," & var_qty & "," & var_price & "," & var_nominal & ",'" & var_id_curr & "','" & var_notes_ledger & "'," & var_amount & "," & var_number_asc_item & ",'" & var_id_item & "','" & var_notes_item & "'," & varloop & "," & var_detail & ",'DELETE','" & var_car_brand_id & "','" & var_car_name & "','" & var_car_nopol & "','" & var_cust_name & "'," & flag_member & ",'" & cust_name & "','" & cust_phone & "')"
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


    Public Sub delete_cashier(ByVal var_no_sales As String, _
                              ByVal var_date_trn As Date,
                              ByVal var_customer As String,
                              ByVal var_cust_address As String,
                              ByVal var_cust_phone As String,
                              ByVal var_payment_method As Integer,
                              ByVal var_subtotal As Double,
                              ByVal var_discount As Double,
                              ByVal var_tax As Double,
                              ByVal var_total As Double,
                              ByVal var_notes As String,
                              ByVal var_created_user As String,
                              ByVal var_created_date As Date,
                              ByVal var_modified_user As String,
                              ByVal var_modified_date As Date,
                              ByVal var_number_asc As Integer,
                              ByVal var_id_item As String,
                              ByVal var_notes_det As String,
                              ByVal var_qty As Integer,
                              ByVal var_id_unit As String,
                              ByVal var_price As Double,
                              ByVal var_nominal As Double,
                              ByVal var_disc_nom As Double,
                              ByVal var_nominal_net As Double,
                              ByVal var_id_curr As String,
                              ByVal var_detail As Integer,
                              ByVal varloop As Integer,
                              ByVal var_cogs As Double,
                              ByVal var_term As Integer,
                              ByVal var_paytermdisc As Integer,
                              ByVal var_paydisc As Integer,
                              ByVal var_chk_so As Integer,
                              ByVal flag_member As Integer,
                              ByVal cust_id As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_cashier ('" & var_no_sales & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_customer & "','" & var_cust_address & "','" & var_cust_phone & "'," & var_payment_method & "," & var_subtotal & "," & var_discount & "," & Replace(var_tax, "%", "") & "," & var_total & ",'" & var_notes & "','" & var_created_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & var_modified_user & "','" & Format(var_modified_date, "yyyy-MM-dd") & "'," & var_number_asc & ",'" & var_id_item & "','" & var_notes_det & "'," & var_qty & ",'" & var_id_unit & "'," & var_price & "," & var_nominal & "," & var_disc_nom & "," & var_nominal_net & ",'" & var_id_curr & "'," & var_detail & "," & varloop & ",'DELETE'," & var_cogs & "," & var_chk_so & "," & var_term & "," & var_paytermdisc & "," & var_paydisc & "," & flag_member & ",'" & cust_id & "',0)"
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
