Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlGudang_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub delete_warehouse(ByVal var_id_warehouse As String, ByVal var_warehouse_name As String, ByVal var_qty_max As Double, ByVal var_unit_max As String, ByVal var_address As String, ByVal var_phone As String, ByVal var_city As String, ByVal var_notes As String, ByVal var_flag_default As Integer, ByVal transid As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_warehouse ('" & var_id_warehouse & "','" & var_warehouse_name & "'," & var_qty_max & ",'" & var_unit_max & "','" & var_address & "','" & var_phone & "','" & var_city & "','" & var_notes & "'," & var_flag_default & ",'" & username & "','" & Format(server_datetime(), "yyyy-MM-dd") & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd") & "','" & transid & "',0)"
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
