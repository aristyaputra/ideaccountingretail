Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlBOM_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub insert_billofmaterial(ByVal var_no_bom As String, _
                                     ByVal var_id_item As String, _
                                     ByVal var_notes As String, ByVal var_qty_item_production As Double, _
                                     ByVal var_id_unit As String, ByVal var_date_trn As Date, _
                                     ByVal var_modified_user As String, ByVal var_created_date As Date, _
                                     ByVal var_modified_date As Date, _
                                     ByVal var_created_user As String, _
                                     ByVal var_id_item_material As String, _
                                     ByVal var_qty_material As Double, _
                                     ByVal var_id_unit_material As String, _
                                     ByVal var_cost_material As Double, _
                                     ByVal var_notes_material As String, _
                                     ByVal var_total_cost_material As Double,
                                     ByVal var_id_item_wip As String,
                                     ByVal var_qty_material_wip As Double,
                                     ByVal var_id_unit_wip As String, ByVal var_cost_wip As Double,
                                     ByVal var_notes_wip As String, ByVal var_total_cost_wip As Double,
                                     ByVal var_id_cost_conversion As String, ByVal var_qty_hour_conversion As Double, _
                                     ByVal var_cost_conversion As Double, _
                                     ByVal var_notes_conversion As String, ByVal var_total_cost_conversion As Double, _
                                     ByVal var_detail As Integer, ByVal varloop As Integer, _
                                     ByVal transid As String, ByVal var_total_cost_bom As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_billofmaterial ('" & var_no_bom & "','" & _
                                                    var_id_item & "','" & _
                                                    var_notes & "'," & Replace(var_qty_item_production, ",", "") & ",'" & _
                                                    var_id_unit & "','" & Format(var_date_trn, "yyyy-MM-dd") & "','" & _
                                                    var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd hh:mm:ss") & "','" & _
                                                    Format(var_modified_date, "yyyy-MM-dd hh:mm:ss") & "','" & _
                                                    var_created_user & "','" & _
                                                    var_id_item_material & "'," & _
                                                    Replace(var_qty_material, ",", "") & ",'" & _
                                                    var_id_unit_material & "'," & _
                                                    Replace(var_cost_material, ",", "") & ",'" & _
                                                    var_notes_material & "'," & _
                                                    Replace(var_total_cost_material, ",", "") & ",'" & _
                                                    var_id_item_wip & "'," & _
                                                    Replace(var_qty_material_wip, ",", "") & ",'" & _
                                                    var_id_unit_wip & "'," & Replace(var_cost_wip, ",", "") & ",'" & _
                                                    var_notes_wip & "'," & Replace(var_total_cost_wip, ",", "") & ",'" & _
                                                    var_id_cost_conversion & "'," & Replace(var_qty_hour_conversion, ",", "") & "," & _
                                                    Replace(var_cost_conversion, ",", "") & ",'" & _
                                                    var_notes_conversion & "'," & Replace(var_total_cost_conversion, ",", "") & "," & _
                                                    var_detail & "," & varloop & ",'" & _
                                                    transid & "'," & var_total_cost_bom & ")"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlinsert.ExecuteNonQuery()
            oTransaction.Commit()
            param_sukses = True
            If param_sukses = True And var_detail = 0 Then
                With cmd_sqlinsert
                    .Connection = conn
                    .CommandText = "update control_no_master set nourut = (select func_update_nomor('FORMULA PRODUCT')) where form = 'FORMULA PRODUCT'"
                    .CommandType = CommandType.Text
                End With
                cmd_sqlinsert.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            oTransaction.Rollback()
            param_sukses = False
        End Try
    End Sub




End Module
