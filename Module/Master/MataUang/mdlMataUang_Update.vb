Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlMataUang_Update

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub update_currency(ByVal var_itemcat_id As String, ByVal var_itemcat_nm As String, ByVal var_nation As String, ByVal description As String, ByVal transid As String, ByVal flag As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_currency ('" & var_itemcat_id & "','" & var_itemcat_nm & "','" & var_nation & "','" & description & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd") & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd") & "','" & transid & "'," & flag & ")"
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


    Public Sub update_setcurrency(ByVal var_id_curr As String, ByVal var_qty As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_curr_konversi ('" & var_id_curr & "'," & var_qty & ")"
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
