Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSO_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub insert_sales_order(ByVal var_no_sales_order As String, _
                              ByVal var_id_customer As String, ByVal var_date_trn As Date, _
                              ByVal var_notes As String, ByVal var_subtotal As Double, _
                              ByVal var_tax As Double, ByVal var_total As Double, _
                              ByVal var_modified_user As String, ByVal var_created_date As Date, _
                              ByVal var_modified_date As Date, ByVal var_created_user As String, _
                              ByVal var_number_asc As Integer, ByVal var_id_item As String, _
                              ByVal var_notes_det As String, ByVal var_qty As Integer, _
                              ByVal var_id_unit As String, ByVal var_price As Double, _
                              ByVal var_nominal As Double, ByVal var_id_curr As String, _
                              ByVal var_detail As Integer, ByVal varloop As Integer, _
                              ByVal var_kurs As Double, ByVal var_id_employee As String, _
                              ByVal var_item_name As String, ByVal var_id_itemdisc As String, _
                              ByVal var_item_namedisc As String, ByVal var_id_unitdisc As String, _
                              ByVal var_nom_discbrand As Double, ByVal var_nom_disctype As Double, ByVal var_nom_disccat As Double, _
                              ByVal var_discount As Double, ByVal var_nett_total As Double, _
                              ByVal var_is_discbrand As Integer, ByVal var_is_disctype As Integer, ByVal var_is_disccat As Integer, ByVal var_is_discitem As Integer, ByVal var_qty_discitem As Double, _
                              ByVal var_id_type As String, ByVal var_id_category As String, ByVal var_id_brand As String, _
                              ByVal var_uang_muka As Double, ByVal var_id_account As String, ByVal var_id_curr_um As String, ByVal var_kurs_um As Double, _
                              ByVal var_ekspedisi As String, ByVal var_freight As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_sales_order ('" & var_no_sales_order & "','" & var_id_customer & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_notes & "'," & var_subtotal & "," & var_tax & "," & var_total & ",'" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "'," & var_number_asc & ",'" & var_id_item & "','" & var_notes_det & "'," & var_qty & ",'" & var_id_unit & "'," & var_price & "," & var_nominal & ",'" & var_id_curr & "'," & var_detail & "," & varloop & ",'INSERT'," & var_kurs & ",'" & var_id_employee & "','" & _
                            var_item_name & "','" & var_id_itemdisc & "','" & var_item_namedisc & "','" & var_id_unitdisc & "'," & var_nom_discbrand & "," & var_nom_disctype & "," & var_nom_disccat & "," & var_discount & "," & var_nett_total & "," & var_is_discbrand & "," & var_is_disctype & "," & var_is_disccat & "," & var_is_discitem & "," & var_qty_discitem & ",'" & var_id_type & "','" & var_id_category & "','" & var_id_brand & "'," & var_uang_muka & ",'" & var_id_account & "','" & var_id_curr_um & "'," & var_kurs_um & ",'" & var_ekspedisi & "'," & var_freight & ")"
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
