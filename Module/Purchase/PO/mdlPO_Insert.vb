Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPO_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_po(ByVal var_no_purchase_order As String, ByVal var_id_supplier As String, ByVal var_date_trn As Date, ByVal var_notes As String, ByVal var_subtotal As Double, ByVal var_freight As Double, ByVal var_tax As Double, ByVal var_total As Double, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_number_asc As Integer, ByVal var_id_item As String, ByVal var_notes_det As String, ByVal var_qty As Integer, ByVal var_id_unit As String, ByVal var_price As Double, ByVal var_nominal As Double, ByVal var_id_curr As String, ByVal var_detail As Integer, ByVal varloop As Integer, ByVal var_no_request As String, ByVal var_kurs As Double, ByVal var_um As Double, ByVal var_account_um As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_po('" & var_no_purchase_order & "','" & var_id_supplier & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_notes & "'," & var_subtotal & "," & var_freight & "," & Replace(var_tax, "%", "") & "," & var_total & ",'" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "'," & var_number_asc & ",'" & var_id_item & "','" & var_notes_det & "'," & var_qty & ",'" & var_id_unit & "'," & var_price & "," & var_nominal & ",'" & var_id_curr & "'," & var_detail & "," & varloop & ",'INSERT','" & var_no_request & "'," & var_kurs & "," & var_um & ",'" & var_account_um & "')"
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
