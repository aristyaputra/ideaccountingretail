Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlBiayaKonversiStd_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_jenis_biaya(ByVal var_id_cost As String, ByVal var_cost_name As String, ByVal var_cost_def As Double, ByVal var_flag_active As Integer, ByVal var_notes As String, ByVal var_id_account As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal transid As String, ByVal var_id_account_hpp As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_standard_cost ('" & var_id_cost & "','" & var_cost_name & "'," & _
                                              var_cost_def & "," & var_flag_active & ",'" & _
                                              var_notes & "','" & var_id_account & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','INSERT','" & var_id_account_hpp & "')"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlinsert.ExecuteNonQuery()
            oTransaction.Commit()
            param_sukses = True
            If param_sukses = True Then
                With cmd_sqlinsert
                    .Connection = conn
                    .CommandText = "update control_no_master set nourut = (select func_update_nomor('MASTER BIAYA')) where form = 'MASTER BIAYA'"
                    .CommandType = CommandType.Text
                End With
                cmd_sqlinsert.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            oTransaction.Rollback()
            param_sukses = False
        End Try
    End Sub




End Module
