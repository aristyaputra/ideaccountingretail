Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSetCOADepProduksi_Update

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub set_coa_depproduksi(ByVal var_department_id As Integer, ByVal var_id_account_bdp As String, ByVal var_id_account_material_cost As String, ByVal var_id_account_wip_cost As String, ByVal var_id_account_bop_std As String, ByVal var_id_account_bop_real As String, ByVal var_id_account_directlabor As String, ByVal var_id_account_wages_payable As String, ByVal var_modified_user As String, ByVal var_modified_date As Date, ByVal TRANSID As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_setcoa_depproduksi(" & var_department_id & ",'" & var_id_account_bdp & "','" & var_id_account_material_cost & "','" & var_id_account_wip_cost & "','" & var_id_account_bop_std & "','" & var_id_account_bop_real & "','" & var_id_account_directlabor & "','" & var_id_account_wages_payable & "','" & var_modified_user & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','UPDATE')"
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
