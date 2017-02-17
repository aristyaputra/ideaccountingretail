Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSettingCadHutang_Update

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub update_set_cadangan_ap(ByVal var_prosentase_not As Double, ByVal var_prosentase_1 As Double, ByVal var_prosentase_2 As Double, ByVal var_prosentase_3 As Double, ByVal var_prosentase_4 As Double, ByVal var_prosentase_5 As Double, ByVal var_modified_date As Date, ByVal var_modified_user As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_set_ap_prosent (" & var_prosentase_not & "," & var_prosentase_1 & "," & var_prosentase_2 & "," & var_prosentase_3 & "," & var_prosentase_4 & "," & var_prosentase_5 & ",'" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_modified_user & "')"
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
