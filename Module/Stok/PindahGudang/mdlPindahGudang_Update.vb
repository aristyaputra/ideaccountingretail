Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPindahGudang_Update

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub update_transfer_stock(ByVal var_no_transfer_stock As String, ByVal var_date_trn As Date, ByVal var_id_warehouse_from As String, ByVal var_id_warehouse_to As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_id_item As String, ByVal var_notes As String, ByVal var_qty As Double, ByVal var_unit As String, ByVal transid As String, ByVal varloop As Integer, ByVal var_detail As Integer, ByVal var_desc As String)

        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_stock_transfer ('" & var_no_transfer_stock & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_id_warehouse_from & "','" & var_id_warehouse_to & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','" & var_id_item & "','" & var_notes & "'," & Replace(var_qty, ",", "") & ",'" & var_unit & "','UPDATE',1," & var_detail & ",'" & var_desc & "')"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlupdate.ExecuteNonQuery()
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
