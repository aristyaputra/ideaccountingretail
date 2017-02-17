Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlReturKasir_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub insert_cashier_return(ByVal var_no_sales_return As String, ByVal var_date_trn As Date, ByVal var_id_customer As String, ByVal var_payment_method As String, ByVal var_subtotal As Double, ByVal var_discount As Double, ByVal var_tax As Double, ByVal var_total As Double, ByVal var_notes As String, ByVal var_created_user As String, ByVal var_created_date As Date, ByVal var_modified_user As String, ByVal var_modified_date As Date, ByVal var_number_asc As Integer, ByVal var_id_item As String, ByVal var_notes_det As String, ByVal var_qty As Integer, ByVal var_id_unit As String, ByVal var_price As Double, ByVal var_nominal As Double, ByVal var_id_curr As String, ByVal var_no_so As String, ByVal var_detail As Integer, ByVal varloop As Integer, ByVal transid As String, ByVal nilai_retur_lalu As Double, ByVal var_kurs As Double, warehouse As String, cust_addr As String, disc_nom As Double, nominal_net As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_cashier_return('" & var_no_sales_return & "', '" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_id_customer & "', " & var_payment_method & ", " & var_subtotal & ", " & var_discount & "," & var_tax & "," & var_total & ", '" & var_notes & "', '" & var_created_user & "', '" & Format(var_created_date, "yyyy-MM-dd") & "', '" & var_modified_user & "','" & Format(var_modified_date, "yyyy-MM-dd") & "'," & var_number_asc & ",'" & var_id_item & "','" & var_notes_det & "'," & var_qty & ",'" & var_id_unit & "'," & var_price & ", " & var_nominal & ", '" & var_id_curr & "','" & var_no_so & "'," & var_detail & ", " & varloop & ", 'INSERT'," & nilai_retur_lalu & "," & var_kurs & ",'" & warehouse & "'," & disc_nom & "," & nominal_net & ",'" & cust_addr & "')"
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
