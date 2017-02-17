Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlStokOpname_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub delete_stockopname(ByVal var_no_opname As String, ByVal var_date_trn As Date, ByVal var_id_warehouse As String, ByVal var_id_item As String, ByVal var_id_unit As String, ByVal var_qty_onhand As Integer, ByVal var_qty_opname As Integer, ByVal var_notes As String)

        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_stock_opname ('" & var_no_opname & "','" & var_date_trn & "','" & var_id_warehouse & "','" & var_id_item & "','" & var_id_unit & "'," & var_qty_onhand & "," & var_qty_opname & ",'" & var_notes & "','DELETE')"
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
