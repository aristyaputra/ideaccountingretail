Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlClosePeriod_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_close_table(ByVal var_created_date As Date, ByVal var_id_acc_income As String, ByVal var_start_date As Date, ByVal var_end_date As Date, ByVal var_periode As Integer, ByVal var_year As Integer, ByVal lock_state As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_insert_closed_tbl ('" & Format(var_created_date, "yyyy-MM-dd") & "','" & var_id_acc_income & "','" & Format(var_start_date, "yyyy-MM-dd") & "','" & Format(var_end_date, "yyyy-MM-dd") & "'," & var_periode & "," & var_year & "," & lock_state & ")"
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

    Public Sub closed_journal(ByVal var_created_date As Date, ByVal var_id_acc_income As String, ByVal var_start_date As Date, ByVal var_end_date As Date, ByVal var_periode As Integer, ByVal var_year As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_closed_journal ('" & Format(var_created_date, "yyyy-MM-dd") & "','" & var_id_acc_income & "','" & Format(var_start_date, "yyyy-MM-dd") & "','" & Format(var_end_date, "yyyy-MM-dd") & "'," & var_periode & "," & var_year & ")"
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
