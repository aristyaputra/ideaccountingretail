Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPelanggan_Update

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub update_customer(ByVal var_id_customer As String, ByVal var_first_name As String, ByVal var_last_name As String, _
                               ByVal var_address As String, _
                               ByVal var_city As String, ByVal var_state As String, ByVal var_postal_code As String, ByVal var_country As String, _
                               ByVal var_phone1 As String, ByVal var_phone2 As String, ByVal var_phone3 As String, ByVal var_fax As String, _
                               ByVal var_email As String, ByVal var_website As String, ByVal var_photo As String, ByVal var_credit_limit As Double, _
                               ByVal var_id_account As String, ByVal var_def_due_date As Date, ByVal var_def_payment_method As Integer, _
                               ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, _
                               ByVal var_created_user As String, ByVal var_status As Integer, ByVal var_notes As String, ByVal var_ar_balance As Double, ByVal id_barcode As String, ByVal flag_credit_limit As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        var_photo_replace = Replace(var_photo, "\", "/")
        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_customer ('" & var_id_customer & "','" & var_first_name & "','" & _
                                              var_last_name & "','" & var_address & "','" & _
                                              var_city & "','" & var_state & "','" & var_postal_code & "','" & var_country & "','" & _
                                              var_phone1 & "','" & var_phone2 & "','" & var_phone3 & "','" & var_fax & "','" & _
                                              var_email & "','" & var_website & "','" & var_photo_replace & "'," & var_credit_limit & ",'" & var_id_account & "','" & Format(var_def_due_date, "yyyy-MM-dd") & "'," & _
                                              var_def_payment_method & ",'" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','UPDATE'," & var_status & ",'" & var_notes & "'," & var_ar_balance & ",'" & id_barcode & "'," & flag_credit_limit & ")"
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
