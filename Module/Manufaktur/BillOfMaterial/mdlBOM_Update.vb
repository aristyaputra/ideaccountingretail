Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlBOM_Update

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub update_billofmaterial(ByVal var_no_bom As String, _
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
                                 ByVal transid As String, ByVal var_total_cost As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
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
                                                    transid & "'," & var_total_cost & ")"
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
