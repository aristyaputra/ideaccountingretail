Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPerakitanBarang_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub delete_assembly(ByVal var_no_bom As String, _
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

        With cmd_sqldelete
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


    Public Sub delete_aset(ByVal var_id_aset As String, ByVal var_id_golongan As String, ByVal var_nama As String, ByVal var_notes As String, ByVal var_tanggal_perolehan As Date, ByVal var_nilai_perolehan As Double, ByVal var_sawal_nilai_buku As Double, ByVal var_created_date As DateTime, ByVal var_modified_date As DateTime, ByVal var_created_user As String, ByVal var_modified_user As String, ByVal transid As String, ByVal depart As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_asset ('" & var_id_aset & "','" & var_id_golongan & "','" & var_nama & "','" & var_notes & "','" & Format(var_tanggal_perolehan, "yyyy-MM-dd") & "'," & var_nilai_perolehan & "," & var_sawal_nilai_buku & ",'" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','" & var_modified_user & "','DELETE'," & depart & ")"
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
