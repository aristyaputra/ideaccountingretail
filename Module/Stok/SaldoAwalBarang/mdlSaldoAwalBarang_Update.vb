Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSaldoAwalBarang_Update

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub update_begbalance(ByVal var_id_item As String, ByVal var_nm_item As String, ByVal var_balance As Double, ByVal var_notes As String, ByVal var_price As Double, ByVal var_loop As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_begbalance ('" & var_id_item & "','" & var_nm_item & "','" & var_balance & "','" & var_notes & "'," & var_price & "," & var_loop & ")"
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
