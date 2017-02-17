Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPembayaranHutang_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub delete_paymentAP(ByVal var_no_payment_ap As String, ByVal var_id_supplier As String, ByVal var_date_trn As Date, ByVal var_notes As String, ByVal var_total As Double, ByVal var_id_account As String, ByVal var_created_user As String, ByVal var_created_date As Date, ByVal var_modified_user As String, ByVal var_modified_date As Date, ByVal var_number_asc As Integer, ByVal var_no_purchase As String, ByVal var_invoice_date As Date, ByVal var_ap_amount As Double, ByVal var_ap_return As Double, ByVal var_discount As Double, ByVal var_ap_amount_net As Double, ByVal var_paid_amount As Double, ByVal var_detail As Integer, ByVal varloop As Integer, ByVal transid As String, ByVal var_curr As String, ByVal var_kurs As Double, ByVal var_flag_kurs As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_payment_ap('" & var_no_payment_ap & "', '" & var_id_supplier & "', '" & Format(var_date_trn, "yyyy-MM-dd") & "', '" & var_notes & "', " & var_total & ", '" & var_id_account & "', '" & var_created_user & "', '" & Format(var_created_date, "yyyy-MM-dd") & "', '" & var_modified_user & "', '" & Format(var_modified_date, "yyyy-MM-dd") & "', " & var_number_asc & ", '" & var_no_purchase & "', '" & Format(var_invoice_date, "yyyy-MM-dd") & "', " & var_ap_amount & "," & var_ap_return & ", " & var_discount & ", " & var_ap_amount_net & ", " & var_paid_amount & ", " & var_detail & ", " & varloop & ",'DELETE','" & var_curr & "'," & var_kurs & "," & var_flag_kurs & ",0,0)"
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
