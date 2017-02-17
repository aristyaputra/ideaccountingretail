Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlMasterAset_Update

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub update_aset(ByVal var_id_aset As String, ByVal var_id_golongan As String, ByVal var_nama As String, ByVal var_notes As String, ByVal var_tanggal_perolehan As Date, ByVal var_nilai_perolehan As Double, ByVal var_sawal_nilai_buku As Double, ByVal var_created_date As DateTime, ByVal var_modified_date As DateTime, ByVal var_created_user As String, ByVal var_modified_user As String, ByVal transid As String, ByVal depart As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_asset ('" & var_id_aset & "','" & var_id_golongan & "','" & var_nama & "','" & var_notes & "','" & Format(var_tanggal_perolehan, "yyyy-MM-dd") & "'," & var_nilai_perolehan & "," & var_sawal_nilai_buku & ",'" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','" & var_modified_user & "','UPDATE'," & depart & ")"
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
