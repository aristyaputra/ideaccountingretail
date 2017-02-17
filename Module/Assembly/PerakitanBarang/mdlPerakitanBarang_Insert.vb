Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPerakitanBarang_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_assembly(ByVal var_no_bom As String, _
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
                                    ByVal var_id_cost_conversion As String, ByVal var_qty_hour_conversion As Double, _
                                    ByVal var_cost_conversion As Double, _
                                    ByVal var_notes_conversion As String, ByVal var_total_cost_conversion As Double, _
                                    ByVal var_detail As Integer, ByVal varloop As Integer, _
                                    ByVal transid As String, ByVal total_cost_conversion As Double, ByVal total_cost_sparepart As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_assembly ('" & var_no_bom & "','" & _
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
                                                    var_id_cost_conversion & "'," & Replace(var_qty_hour_conversion, ",", "") & "," & _
                                                    Replace(var_cost_conversion, ",", "") & ",'" & _
                                                    var_notes_conversion & "'," & Replace(var_total_cost_conversion, ",", "") & "," & _
                                                    var_detail & "," & varloop & ",'" & _
                                                    transid & "'," & Replace(total_cost_conversion, ",", "") & "," & Replace(total_cost_sparepart, ",", "") & ")"
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
                    .CommandText = "update control_no_master set nourut = (select func_update_nomor('ASSEMBLY PRODUCT')) where form = 'ASSEMBLY PRODUCT'"
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
