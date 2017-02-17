Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlItemService_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub insert_service(ByVal var_id_service As String, ByVal var_service_name As String, ByVal var_id_account As String, ByVal var_price As Double, ByVal var_senior_commission As Double, ByVal var_junior_commission As Double, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_active_status As Integer, ByVal var_notes As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_service ('" & var_id_service & "','" & var_service_name & "','" & var_id_account & "'," & var_price & ",'" & var_senior_commission & "','" & var_junior_commission & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','INSERT'," & var_active_status & ",'" & var_notes & "')"
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
