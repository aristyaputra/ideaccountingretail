Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlCOA_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub insert_account(ByVal id_account As String, ByVal account_name As String, ByVal parent As String, ByVal flag_active As Integer, _
                            ByVal flag_header As Integer, ByVal is_income As Integer, ByVal is_balance_sheet As Integer, ByVal notes As String, _
                      ByVal modified_user As String, ByVal created_date As Date, ByVal modified_date As Date, ByVal created_user As String, ByVal def_position As String, ByVal beg_balance As Double, ByVal var_id_golongan As Integer)

        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_account ('" & id_account & "','" & account_name & "','" & parent & "'," & _
                                                flag_active & "," & flag_header & "," & is_income & "," & is_balance_sheet & ",'" & notes & "','" & modified_user & "','" & _
                                                Format(created_date, "yyyy-MM-dd") & "','" & Format(modified_date, "yyyy-MM-dd") & "','" & created_user & "','INSERT','" & def_position & "'," & beg_balance & "," & var_id_golongan & ")"
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
