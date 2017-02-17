Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPembayaranEkspedisi_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub insert_expedition(ByVal var_id_expedition As String, ByVal var_expedition_name As String, ByVal var_expedition_rate As Double, ByVal from_city As String, ByVal to_city As String, ByVal var_qty_perunit As Double, ByVal var_notes As String, ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal transid As String, ByVal var_provinsi As String, ByVal var_kecamatan As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_expedition ('" & var_id_expedition & "','" & var_expedition_name & "'," & var_expedition_rate & ",'" & from_city & "','" & to_city & "'," & var_qty_perunit & ",'" & var_notes & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','INSERT','" & var_provinsi & "','" & var_kecamatan & "')"
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


    Public Sub insert_payment_expedisi(ByVal var_no_ekspedisi As String, ByVal var_date_trn As Date, ByVal var_total As Double, ByVal var_id_currency As String, ByVal var_id_account As String, ByVal var_notes As String, ByVal var_kurs As Double, ByVal var_created_date As Date, ByVal var_created_user As String, ByVal var_modified_date As Date, ByVal var_modified_user As String, ByVal var_no_do As String, ByVal var_no_resi As String, ByVal var_freight_address As String, ByVal var_freight_city As String, ByVal var_freight_cost As Double, ByVal var_detail As Integer, ByVal var_loop As Double, ByVal TRANSID As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_biaya_ekspedisi('" & var_no_ekspedisi & "','" & Format(var_date_trn, "yyyy-MM-dd") & "'," & var_total & ",'" & var_id_currency & "','" & var_id_account & "','" & var_notes & "'," & var_kurs & ",'" & Format(var_created_date, "yyyy-MM-dd") & "','" & var_created_user & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_modified_user & "','" & var_no_do & "','" & var_no_resi & "','" & var_freight_address & "','" & var_freight_city & "'," & var_freight_cost & "," & var_detail & "," & var_loop & ",'INSERT')"
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
