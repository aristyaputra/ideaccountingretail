Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlBiayaKonversiStd_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub delete_jenis_biaya(ByVal var_id_cost As String, ByVal var_cost_name As String, ByVal var_cost_def As Double, ByVal var_flag_active As Integer, ByVal var_notes As String, ByVal var_id_account As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal transid As String, ByVal var_id_account_hpp As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_standard_cost ('" & var_id_cost & "','" & var_cost_name & "'," & _
                                              var_cost_def & "," & var_flag_active & ",'" & _
                                              var_notes & "','" & var_id_account & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','DELETE','" & var_id_account_hpp & "')"
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
