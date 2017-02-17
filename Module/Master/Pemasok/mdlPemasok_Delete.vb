Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPemasok_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub delete_supplier(ByVal var_id_supplier As String, ByVal var_first_name As String, ByVal var_last_name As String, _
                               ByVal var_address As String, ByVal var_city As String, _
                               ByVal var_state As String, ByVal var_postal_code As String, ByVal var_country As String, ByVal var_phone1 As String, _
                               ByVal var_phone2 As String, ByVal var_phone3 As String, ByVal var_fax As String, ByVal var_email As String, _
                               ByVal var_website As String, ByVal var_photo As String, ByVal var_ar_id_account As String, _
                               ByVal var_contact_person As String, ByVal var_credit_limit As Double, ByVal var_def_due_date As Date, ByVal var_def_payment_method As Integer, _
                               ByVal var_modified_user As String, ByVal var_created_date As Date, ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_status As Integer, ByVal var_notes As String, ByVal var_ap_balance As Double)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_supplier ('" & var_id_supplier & "','" & var_first_name & "','" & _
                                              var_last_name & "','" & var_address & "','" & _
                                              var_city & "','" & var_state & "','" & var_postal_code & "','" & var_country & "','" & _
                                              var_phone1 & "','" & var_phone2 & "','" & var_phone3 & "','" & var_fax & "','" & _
                                              var_email & "','" & var_website & "','" & var_photo & "','" & var_ar_id_account & "','" & var_contact_person & "'," & var_credit_limit & ",'" & Format(var_def_due_date, "yyyy-MM-dd") & "'," & _
                                              var_def_payment_method & ",'" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','DELETE'," & var_status & ", '" & var_notes & "'," & var_ap_balance & ",0)"
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
