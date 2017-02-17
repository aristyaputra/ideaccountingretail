Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlJurnalPenyesuaian_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub delete_adj_journal(ByVal var_no_journal As String, ByVal var_date_trn As Date, ByVal var_comment As String, ByVal created_user As String, _
                              ByVal created_date As Date, ByVal var_modified_user As String, ByVal var_modified_date As Date, ByVal var_id_account As String, _
                              ByVal var_notes As String, ByVal var_amount As Double, ByVal var_detail As Integer, ByVal var_total As Double, ByVal var_curr As String, ByVal var_kurs As Double)

        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_journal_adjust ('" & var_no_journal & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & var_comment & "','" & _
                                                created_user & "','" & Format(created_date, "yyyy-MM-dd") & "','" & var_modified_user & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_id_account & "','" & var_notes & "'," & _
                                                var_amount & "," & var_detail & ",'DELETE',1," & Replace(var_total, ",", "") & ",'" & var_curr & "'," & var_kurs & ")"
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
