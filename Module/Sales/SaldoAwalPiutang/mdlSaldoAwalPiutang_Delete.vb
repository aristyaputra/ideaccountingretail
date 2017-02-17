Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSaldoAwalPiutang_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub delete_ar_init(ByVal var_cutoff_date As Date, ByVal var_invoice_no As String, ByVal var_id_supplier As String, ByVal var_amount_of As Double, ByVal var_notes As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal transid As String, ByVal amount_before As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_ar_initbalance('" & Format(var_cutoff_date, "yyyy-MM-dd") & "','" & var_invoice_no & "','" & var_id_supplier & "','" & var_amount_of & "','" & var_notes & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','DELETE'," & amount_before & ")"
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
