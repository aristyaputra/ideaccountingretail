Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlSimpanPinjam_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


   
    Public Sub set_kode_bayar(var_kode As String, var_angka As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_setup_kodebayar('" & var_kode & "'," & var_angka & ")"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlinsert.ExecuteNonQuery()
            oTransaction.Commit()
            param_sukses = True
        Catch ex As Exception
            MsgBox(ex.Message)
            oTransaction.Rollback()
            param_sukses = False
        End Try
    End Sub

    Public Sub insert_pinjam(ByVal var_no_pinjam As String, ByVal var_no_jual As String, ByVal var_id_item As String, ByVal var_item_name As String, ByVal var_nominal As Double, ByVal var_date_trn As Date, ByVal var_flag_surat As Integer, ByVal berat As Double, ByVal trnid As String, ByVal var_created_user As String, ByVal var_created_date As Date, ByVal var_modified_user As String, ByVal var_modified_date As Date)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_pinjaman ('" & var_no_pinjam & "','" & var_no_jual & "','" & var_id_item & "','" & var_item_name & "'," & var_nominal & ",'" & Format(var_date_trn, "yyyy-MM-dd") & "'," & var_flag_surat & "," & berat & ",'INSERT','" & Format(var_created_date, "yyyy-MM-dd hh:mm:ss") & "','" & var_created_user & "','" & Format(var_modified_date, "yyyy-MM-dd hh:mm:ss") & "','" & var_modified_user & "')"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlinsert.ExecuteNonQuery()
            oTransaction.Commit()
            param_sukses = True
        Catch ex As Exception
            MsgBox(ex.Message)
            oTransaction.Rollback()
            param_sukses = False
        End Try
    End Sub

    Public Sub insert_bayarpinjam(ByVal var_no_bayar As String, ByVal var_no_pinjam As String, ByVal var_saldo_pinjaman As Double, ByVal var_date_trn As Date, ByVal var_nominal_bayar As Double, ByVal TRANSID As String, ByVal bunga As Double, ByVal duedate As Date)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_bayar_pinjaman ('" & var_no_bayar & "','" & var_no_pinjam & "'," & var_saldo_pinjaman & ",'" & Format(var_date_trn, "yyyy-MM-dd") & "'," & var_nominal_bayar & ",'INSERT'," & bunga & ",'" & Format(duedate, "yyyy-MM-dd") & "')"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlinsert.ExecuteNonQuery()
            oTransaction.Commit()
            param_sukses = True
        Catch ex As Exception
            MsgBox(ex.Message)
            oTransaction.Rollback()
            param_sukses = False
        End Try
    End Sub



End Module
