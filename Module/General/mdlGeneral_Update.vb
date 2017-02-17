Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlGeneral_Update
    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub set_cogs_avg(ByVal var_id_item As String, ByVal var_date_trn As Date)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_recalculate_cogs_avg('" & var_id_item & "','" & var_id_item & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & Format(var_date_trn, "yyyy-MM-dd") & "',0)"
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

    Public Sub update_no_trans(ByVal var_date_trn As Date, ByVal var_criteria As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "update control_no_trans set nourut = (select func_update_nobukti('" & var_criteria & "'," & Month(var_date_trn) & "," & Year(var_date_trn) & ")) where form = '" & var_criteria & "' and bulan = " & Month(var_date_trn) & " and tahun = " & Year(var_date_trn) & ""
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlupdate.ExecuteNonQuery()
            oTransaction.Commit()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            oTransaction.Rollback()
        End Try
    End Sub





End Module
