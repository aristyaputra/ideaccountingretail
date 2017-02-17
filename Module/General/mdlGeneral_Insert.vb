Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlGeneral_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub update_no_master_carabayar()
        Try
            oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
            With cmd_sqlinsert
                .Connection = conn
                .CommandText = "update control_no_master set nourut = (select func_update_nomor('MASTER CARA BAYAR SIMRS')) where form = 'MASTER CARA BAYAR SIMRS'"
                .CommandType = CommandType.Text
            End With
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

    Public Sub insert_path_setup(ByVal key As String, ByVal path As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim var_path As String
        var_path = Replace(path, "\", "/")
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "update i_upload_path set path = '" & var_path & "' where form = '" & key & "'"
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

    Public Sub insert_no_trans(ByVal var_form As String, ByVal var_bulan As Integer, ByVal var_tahun As Integer)

        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_input_nobukti ('" & var_form & "'," & var_bulan & "," & var_tahun & ")"
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


    Public Sub calculate_cogs(ByVal var_date_trn As Date, ByVal var_id_item As String)

        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_calculate_cogs ('" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_id_item & "')"
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

    Public Sub Recalculate_COGS(ByVal var_item1 As String, ByVal var_item2 As String, ByVal var_tgl_awal As Date, ByVal var_tgl_akhir As Date, ByVal date_filter As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_recalculate_cogs_avg ('" & var_item1 & "','" & var_item2 & "','" & Format(var_tgl_awal, "yyyy-MM-dd") & "','" & Format(var_tgl_akhir, "yyyy-MM-dd") & "'," & date_filter & ")"
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

    Public Sub Rekapitulasi_HPP_Akhir(ByVal var_id_item1 As String, ByVal var_id_item2 As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_rekapitulasi_hpp_akhir('" & var_id_item1 & "','" & var_id_item2 & "')"
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
