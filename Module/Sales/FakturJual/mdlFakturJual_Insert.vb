Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlFakturJual_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_sales(ByVal var_no_sales As String, ByVal var_date_trn As Date, ByVal var_no_sales_order As String, ByVal var_id_customer As String, ByVal var_payment_method As Integer, ByVal var_subtotal As Double, ByVal var_discount As Double, ByVal var_tax As Double, ByVal var_total As Double, ByVal var_notes As String, ByVal var_created_user As String, ByVal var_created_date As Date, ByVal var_modified_user As String, ByVal var_modified_date As Date, ByVal var_number_asc As Integer, ByVal var_id_item As String, ByVal var_notes_det As String, ByVal var_qty As Integer, ByVal var_id_unit As String, ByVal var_price As Double, ByVal var_nominal As Double, ByVal var_id_curr As String, ByVal var_detail As Integer, ByVal varloop As Integer, ByVal var_cogs As Double, ByVal var_id_marketing As String, ByVal var_term As Integer, ByVal var_paytermdisc As Integer, ByVal var_paydisc As Integer, ByVal var_chk_so As Integer, ByVal var_id_account As String, ByVal var_kurs As Double, ByVal var_id_item_disc As String, ByVal var_item_name_disc As String, ByVal var_qty_disc As Double, ByVal var_id_unit_disc As String, ByVal um As Double, ByVal var_freight As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_sales ('" & var_no_sales & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_no_sales_order & "','" & var_id_customer & "'," & var_payment_method & "," & var_subtotal & "," & var_discount & "," & Replace(var_tax, "%", "") & "," & var_total & ",'" & var_notes & "','" & var_created_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & var_modified_user & "','" & Format(var_modified_date, "yyyy-MM-dd") & "'," & var_number_asc & ",'" & var_id_item & "','" & var_notes_det & "'," & var_qty & ",'" & var_id_unit & "'," & var_price & "," & var_nominal & ",'" & var_id_curr & "'," & var_detail & "," & varloop & ",'INSERT'," & var_cogs & "," & var_chk_so & ",'" & var_id_marketing & "'," & var_term & "," & var_paytermdisc & "," & var_paydisc & ",'" & var_id_account & "'," & var_kurs & ",'" & var_id_item_disc & "','" & var_item_name_disc & "'," & var_qty_disc & ",'" & var_id_unit_disc & "'," & um & "," & var_freight & ")"
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
