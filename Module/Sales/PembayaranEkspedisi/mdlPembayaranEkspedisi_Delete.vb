Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPembayaranEkspedisi_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub delete_payment_expedisi(ByVal var_no_ekspedisi As String, ByVal var_date_trn As Date, ByVal var_total As Double, ByVal var_id_currency As String, ByVal var_id_account As String, ByVal var_notes As String, ByVal var_kurs As Double, ByVal var_created_date As Date, ByVal var_created_user As String, ByVal var_modified_date As Date, ByVal var_modified_user As String, ByVal var_no_do As String, ByVal var_no_resi As String, ByVal var_freight_address As String, ByVal var_freight_city As String, ByVal var_freight_cost As Double, ByVal var_detail As Integer, ByVal var_loop As Integer, ByVal transid As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_biaya_ekspedisi('" & var_no_ekspedisi & "','" & Format(var_date_trn, "yyyy-MM-dd") & "'," & var_total & ",'" & var_id_currency & "','" & var_id_account & "','" & var_notes & "'," & var_kurs & ",'" & Format(var_created_date, "yyyy-MM-dd") & "','" & var_created_user & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_modified_user & "','" & var_no_do & "','" & var_no_resi & "','" & var_freight_address & "','" & var_freight_city & "'," & var_freight_cost & "," & var_detail & "," & var_loop & ",'DELETE')"
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
