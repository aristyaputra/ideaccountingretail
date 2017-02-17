Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlItem_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String



    Public Sub dalete_item(ByVal var_id_item As String, ByVal var_item_name As String, ByVal var_id_category As String, ByVal var_id_brand As String, ByVal var_id_account As String, ByVal var_main_unit As String, ByVal var_buy_unit As String, ByVal var_sell_unit As String, ByVal var_flag_buy As Integer, ByVal var_flag_sell As Integer, ByVal var_flag_inv As Integer, ByVal var_blob_image As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_id_wh As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_item ('" & var_id_item & "','" & var_item_name & "','" & var_id_category & "','" & var_id_brand & "','" & var_id_account & "','" & var_main_unit & "','" & var_buy_unit & "','" & var_sell_unit & "','" & var_flag_buy & "','" & var_flag_sell & "','" & var_flag_inv & "','" & var_blob_image & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','DELETE','" & var_id_wh & "')"
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


    Public Sub delete_item(ByVal var_id_item As String, ByVal var_item_name As String, ByVal var_id_category As String, ByVal var_id_brand As String, ByVal var_id_account As String, ByVal var_main_unit As String, ByVal var_buy_unit As String, ByVal var_sell_unit As String, ByVal var_flag_buy As Integer, ByVal var_flag_sell As Integer, ByVal var_flag_inv As Integer, ByVal var_blob_image As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_wh As String, ByVal var_price As Double, ByVal var_id_wh As String, ByVal var_max_qty As Integer, ByVal var_min_qty As Integer, ByVal var_notes As String, ByVal var_length As Double, ByVal var_width As Double, ByVal var_height As Double, ByVal var_weight As Double, ByVal var_id_account_cogs As String, ByVal var_account_cogs As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_item ('" & var_id_item & "','" & var_item_name & "','" & var_id_category & "','" & var_id_brand & "','" & var_id_account & "','" & var_main_unit & "','" & var_buy_unit & "','" & var_sell_unit & "','" & var_flag_buy & "','" & var_flag_sell & "','" & var_flag_inv & "','" & var_blob_image & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','DELETE','" & var_wh & "'," & var_price & ", '" & var_id_wh & "'," & var_max_qty & "," & var_min_qty & ",'" & var_notes & "'," & var_length & "," & var_width & "," & var_height & "," & var_weight & ",'" & var_id_account_cogs & "','" & var_account_cogs & "',0,'',0,'',0,0,'','pcs',0,0,0)"
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


    Public Sub delete_itemcat(ByVal var_itemjns_id As String, ByVal var_itemcat_id As String, ByVal var_itemcat_nm As String, ByVal description As String, ByVal transid As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_itemcat ('" & var_itemjns_id & "','" & var_itemcat_id & "','" & var_itemcat_nm & "','" & description & "','" & transid & "',0)"
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


    Public Sub delete_itemjenis(ByVal var_itemcat_id As String, ByVal var_itemcat_nm As String, ByVal description As String, ByVal transid As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_itemjenis ('" & var_itemcat_id & "','" & var_itemcat_nm & "','" & description & "','" & transid & "',0)"
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


    Public Sub delete_itembrand(ByVal var_itemcat_id As String, ByVal var_itemcat_nm As String, ByVal description As String, ByVal transid As String, ByVal disc As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_itembrand ('" & var_itemcat_id & "','" & var_itemcat_nm & "','" & description & "','" & transid & "'," & disc & ")"
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


    Public Sub delete_unit(ByVal var_itemcat_id As String, ByVal var_itemcat_nm As String, ByVal description As String, ByVal transid As String, ByVal flag As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_unit ('" & var_itemcat_id & "','" & var_itemcat_nm & "','" & description & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd") & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd") & "','" & transid & "'," & flag & ")"
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
