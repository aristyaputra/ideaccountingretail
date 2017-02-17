Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlMasterEkspedisi_Update

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub update_expedition(ByVal var_id_expedition As String, ByVal var_expedition_name As String, ByVal var_expedition_rate As Double, ByVal from_city As String, ByVal to_city As String, ByVal var_qty_perunit As Double, ByVal var_notes As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal transid As String, ByVal var_provinsi As String, ByVal var_kecamatan As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_expedition ('" & var_id_expedition & "','" & var_expedition_name & "'," & var_expedition_rate & ",'" & from_city & "','" & to_city & "'," & var_qty_perunit & ",'" & var_notes & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','UPDATE','" & var_provinsi & "','" & var_kecamatan & "')"
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
