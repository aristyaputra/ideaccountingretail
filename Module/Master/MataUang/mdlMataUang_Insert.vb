Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlMataUang_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_currency(ByVal var_itemcat_id As String, ByVal var_itemcat_nm As String, ByVal var_nation As String, ByVal description As String, ByVal transid As String, ByVal flag As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_currency ('" & var_itemcat_id & "','" & var_itemcat_nm & "','" & var_nation & "','" & description & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd") & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd") & "','" & transid & "'," & flag & ")"
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
