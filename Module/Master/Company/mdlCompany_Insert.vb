Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlCompany_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String

    Public Sub insert_company(var_company_code As String, var_company_name As String, var_address As String, var_city As String, var_phone As String, var_email As String, var_website As String, flag_status As Integer, flag_type As Integer, serial1 As String, serial2 As String, serial3 As String, serial4 As String, ipaddress As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_company ('" & var_company_code & "','" & var_company_name & "','" & _
                                              var_address & "','" & var_city & "','" & _
                                              var_phone & "','" & var_email & "','" & var_website & "','INSERT'," & flag_status & "," & flag_type & ",'" & serial1 & "','" & serial2 & "','" & serial3 & "','" & serial4 & "','" & ipaddress & "')"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlinsert.ExecuteNonQuery()
            oTransaction.Commit()
            MsgBox("Successful Activated", MsgBoxStyle.Information, "Program Activated")
            DialogActivated.Hide()
            MainMenu.Show()
            If get_period() = 0 Then
                frm_set_init.Show()
                ' MainMenu.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Activation Failed - " & vbCrLf & _
                    ex.Message, MsgBoxStyle.Critical, "Error")
            oTransaction.Rollback()
        End Try
    End Sub


    Public Sub insert_company2(var_company_code As String, var_company_name As String, var_address As String, var_city As String, var_phone As String, var_email As String, var_website As String, flag_status As Integer, flag_type As Integer, serial1 As String, serial2 As String, serial3 As String, serial4 As String, ipaddress As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_company ('" & var_company_code & "','" & var_company_name & "','" & _
                                              var_address & "','" & var_city & "','" & _
                                              var_phone & "','" & var_email & "','" & var_website & "','INSERT'," & flag_status & "," & flag_type & ",'" & serial1 & "','" & serial2 & "','" & serial3 & "','" & serial4 & "','" & ipaddress & "')"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlinsert.ExecuteNonQuery()
            oTransaction.Commit()
            MsgBox("Successful Activated, Sistem akan logout", MsgBoxStyle.Information, "Program Activated")

            With LoginFormSambung
                MainMenu.Close()
                .Show()
                .txt_user.Text = ""
                .txt_password.Text = ""
                .txt_user.Focus()
            End With

        Catch ex As Exception
            MsgBox("Activation Failed - " & vbCrLf & _
                    ex.Message, MsgBoxStyle.Critical, "Error")
            oTransaction.Rollback()
        End Try
    End Sub


End Module
