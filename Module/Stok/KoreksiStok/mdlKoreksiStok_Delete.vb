Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlKoreksiStok_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub delete_adjust_stock(ByVal var_no_adjust_stock As String, ByVal var_date_trn As Date, ByVal var_id_warehouse As String, ByVal var_total_adjust As Double, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_id_item As String, ByVal var_notes As String, ByVal var_positive As Double, ByVal var_negative As Double, ByVal varloop As Integer, ByVal var_detail As Integer, ByVal var_desc As String, ByVal var_unit As String)

        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_stock_adjust ('" & var_no_adjust_stock & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_id_warehouse & "'," & var_total_adjust & ",'" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','" & var_id_item & "','" & var_notes & "'," & Replace(var_positive, ",", "") & "," & Replace(var_negative, ",", "") & ",'DELETE',1," & var_detail & ",'" & var_desc & "','" & var_unit & "')"
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
