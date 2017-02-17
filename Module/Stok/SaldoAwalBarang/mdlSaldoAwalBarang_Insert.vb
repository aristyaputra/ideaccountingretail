Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSaldoAwalBarang_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub import_item_begbalance(ByVal id_item As String, ByVal id_unit As String, ByVal id_warehouse As String, ByVal balance As Double, ByVal notes As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "INSERT INTO i_item_beg_balance(id_item,id_unit,id_warehouse,balance,notes) values ('" & id_item & "','" & id_unit & "','" & id_warehouse & "'," & balance & ",'" & notes & "')"
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
