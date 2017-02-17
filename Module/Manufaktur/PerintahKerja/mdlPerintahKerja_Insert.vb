Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPerintahKerja_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_wo(ByVal var_wo_no As String, _
                         ByVal var_expected_date As Date, _
                         ByVal var_realized_date As Date, _
                         ByVal var_start_date As Date, _
                         ByVal var_date_trn As Date, _
                         ByVal var_pic As String, _
                         ByVal var_department_id As Integer, _
                         ByVal var_cost_total As Double, _
                         ByVal var_notes As String,
                         ByVal var_modified_user As String, _
                         ByVal var_created_date As Date, _
                         ByVal var_modified_date As Date, _
                         ByVal var_created_user As String, _
                         ByVal var_no_bom As String, _
                         ByVal var_item_notes As String, _
                         ByVal var_qty_item_production As Double, _
                         ByVal var_unit As String, _
                         ByVal var_cost_total_wo As Double, _
                         ByVal var_persentage As Double, _
                         ByVal var_id_material As String, _
                         ByVal var_qty_material As Double, _
                         ByVal var_id_unit_material As String, _
                         ByVal var_cost_material As Double, _
                         ByVal var_notes_material As String, _
                         ByVal var_total_cost_material As Double, _
                         ByVal var_id_wip As String, _
                         ByVal var_qty_wip As Double, _
                         ByVal var_id_unit_wip As String, _
                         ByVal var_cost_wip As Double, _
                         ByVal var_notes_wip As String, _
                         ByVal var_total_cost_wip As Double, _
                         ByVal var_id_cost_conversion As String, _
                         ByVal var_qty_hour_conversion As Double, _
                         ByVal var_cost_conversion As Double, _
                         ByVal var_notes_conversion As String, _
                         ByVal var_total_cost_conversion As Double, ByVal var_detail As Integer, ByVal varloop As Integer, ByVal transid As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_wo ('" & var_wo_no & "','" & _
                                         Format(var_expected_date, "yyyy-MM-dd") & "','" & _
                                         Format(var_realized_date, "yyyy-MM-dd") & "','" & _
                                         Format(var_start_date, "yyyy-MM-dd") & "','" & _
                                         Format(var_date_trn, "yyyy-MM-dd") & "','" & _
                                         var_pic & "'," & _
                                         var_department_id & "," & _
                                         Replace(var_cost_total, ",", "") & ",'" & _
                                         var_notes & "','" & _
                                         var_modified_user & "','" & _
                                         Format(var_created_date, "yyyy-MM-dd hh:mm:ss") & "','" & _
                                         Format(var_modified_date, "yyyy-MM-dd hh:mm:ss") & "','" & _
                                         var_created_user & "','" & _
                                         var_no_bom & "','" & _
                                         var_item_notes & "'," & _
                                         Replace(var_qty_item_production, ",", "") & ",'" & _
                                         var_unit & "'," & _
                                         Replace(var_cost_total_wo, ",", "") & "," & _
                                         Replace(var_persentage, ",", "") & ",'" & _
                                         var_id_material & "'," & _
                                         Replace(var_qty_material, ",", "") & ",'" & _
                                         var_id_unit_material & "'," & _
                                         Replace(var_cost_material, ",", "") & ",'" & _
                                         var_notes_material & "'," & _
                                         Replace(var_total_cost_material, ",", "") & ",'" & _
                                         var_id_wip & "'," & _
                                         Replace(var_qty_wip, ",", "") & ",'" & _
                                         var_id_unit_wip & "'," & _
                                         Replace(var_cost_wip, ",", "") & ",'" & _
                                         var_notes_wip & "'," & _
                                         Replace(var_total_cost_wip, ",", "") & ",'" & _
                                         var_id_cost_conversion & "'," & _
                                         Replace(var_qty_hour_conversion, ",", "") & "," & _
                                         Replace(var_cost_conversion, ",", "") & ",'" & _
                                         var_notes_conversion & "'," & _
                                         Replace(var_total_cost_conversion, ",", "") & "," & var_detail & "," & varloop & ",'" & transid & "')"
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
