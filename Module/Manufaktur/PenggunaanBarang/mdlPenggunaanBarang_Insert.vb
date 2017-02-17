Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPenggunaanBarang_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_material_usage(ByVal var_usage_no As String, ByVal var_wo_no As String, ByVal var_date_trn As Date, ByVal var_pic As String, ByVal var_department_id As Integer, ByVal var_notes As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_item_id As String, ByVal var_qty As Double, ByVal var_id_unit As String, ByVal var_cost As Double, ByVal var_total_cost As Double, ByVal var_material_type_id As Integer, ByVal var_detail As Integer, ByVal varloop As Integer, ByVal transid As String, ByVal var_head_cost As Double, ByVal var_id_item_production As String, ByVal var_id_warehouse As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_material_usage('" & var_usage_no & "','" & var_wo_no & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_pic & "'," & var_department_id & ",'" & var_notes & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','" & var_item_id & "'," & Replace(var_qty, ",", "") & ",'" & var_id_unit & "'," & var_cost & "," & var_total_cost & "," & var_material_type_id & "," & var_detail & "," & varloop & ",'" & transid & "'," & var_head_cost & ",'" & var_id_item_production & "','" & var_id_warehouse & "')"
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
