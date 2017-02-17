Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlItem_Update

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub update_item(ByVal var_id_item As String, ByVal var_item_name As String, ByVal var_id_category As String, ByVal var_id_brand As String, ByVal var_id_account As String, ByVal var_main_unit As String, ByVal var_buy_unit As String, ByVal var_sell_unit As String, ByVal var_flag_buy As Integer, ByVal var_flag_sell As Integer, ByVal var_flag_inv As Integer, ByVal var_blob_image As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_wh As String, ByVal var_price As Double, ByVal var_id_wh As String, ByVal var_max_qty As Integer, ByVal var_min_qty As Integer, ByVal var_notes As String, ByVal var_length As Double, ByVal var_width As Double, ByVal var_height As Double, ByVal var_weight As Double, ByVal var_id_account_cogs As String, ByVal var_account_cogs As String, ByVal min_qty_unit As String, ByVal item_brand As String, ByVal qty_to_disc As Double, ByVal id_item_disc As String, ByVal qty_disc As Double, ByVal detail As Integer, ByVal unitdisc As String, ByVal unit_item_disc As String, ByVal active_status As Integer, ByVal kadar As Double, ByVal use_notifminqty As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        var_photo_replace = Replace(var_blob_image, "\", "/")
        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_item ('" & var_id_item & "','" & var_item_name & "','" & var_id_category & "','" & var_id_brand & "','" & var_id_account & "','" & var_main_unit & "','" & var_buy_unit & "','" & var_sell_unit & "','" & var_flag_buy & "','" & var_flag_sell & "','" & var_flag_inv & "','" & var_photo_replace & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','UPDATE','" & var_wh & "'," & var_price & ",'" & var_id_wh & "'," & var_max_qty & "," & var_min_qty & ",'" & var_notes & "'," & var_length & "," & var_width & "," & var_height & "," & var_weight & ",'" & var_id_account_cogs & "','" & var_account_cogs & "','" & min_qty_unit & "','" & item_brand & "'," & qty_to_disc & ",'" & id_item_disc & "'," & qty_disc & "," & detail & ",'" & unitdisc & "','" & unit_item_disc & "'," & active_status & "," & kadar & ", " & use_notifminqty & ")"
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


    Public Sub update_itemcat(ByVal var_itemjns_id As String, ByVal var_itemcat_id As String, ByVal var_itemcat_nm As String, ByVal description As String, ByVal transid As String, ByVal discount As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_itemcat ('" & var_itemjns_id & "','" & var_itemcat_id & "','" & var_itemcat_nm & "','" & description & "','" & transid & "'," & discount & ")"
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


    Public Sub update_itemjenis(ByVal var_itemcat_id As String, ByVal var_itemcat_nm As String, ByVal description As String, ByVal transid As String, ByVal var_disc As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_itemjenis ('" & var_itemcat_id & "','" & var_itemcat_nm & "','" & description & "','" & transid & "'," & var_disc & ")"
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


    Public Sub update_itembrand(ByVal var_itemcat_id As String, ByVal var_itemcat_nm As String, ByVal description As String, ByVal transid As String, ByVal disc As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_itembrand ('" & var_itemcat_id & "','" & var_itemcat_nm & "','" & description & "','" & transid & "'," & disc & ")"
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


    Public Sub update_unit(ByVal var_itemcat_id As String, ByVal var_itemcat_nm As String, ByVal description As String, ByVal transid As String, ByVal flag As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_unit ('" & var_itemcat_id & "','" & var_itemcat_nm & "','" & description & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd") & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd") & "','" & transid & "'," & flag & ")"
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


    Public Sub update_setunit(ByVal var_id_item As String, ByVal var_id_unit As String, ByVal var_notes As String, ByVal var_qty As Double, ByVal var_date As Date, ByVal var_user As String, ByVal i As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_unit_konversi ('" & var_id_item & "','" & var_id_unit & "','" & var_notes & "'," & var_qty & ",'" & Format(var_date, "yyyy-MM-dd") & "','" & var_user & "'," & i & ")"
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

    Public Sub update_setallunititem(ByVal var_id_item As String, ByVal var_unit As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "update mst_item set main_unit = '" & var_unit & "', buy_unit = '" & var_unit & "', sell_unit = '" & var_unit & "' where id_item = '" & var_id_item & "'"
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
