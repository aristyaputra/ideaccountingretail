Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlKaryawan_Insert

    Dim SqlInsert As String
    Dim cmd_sqlinsert As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String



    Public Sub import_employee(ByVal selectedField As String, ByVal selectedValue As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "INSERT INTO mst_employee (" & selectedField & ") values (" & UCase(selectedValue) & ")"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlinsert.ExecuteNonQuery()
            oTransaction.Commit()
            param_sukses = True
            If param_sukses = True Then
                With cmd_sqlinsert
                    .Connection = conn
                    .CommandText = "update control_no_master set nourut = (select func_update_nomor('MASTER MARKETING')) where form = 'MASTER MARKETING'"
                    .CommandType = CommandType.Text
                End With
                cmd_sqlinsert.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            oTransaction.Rollback()
            param_sukses = False
        End Try
    End Sub


    Public Sub load_csv_emp(ByVal path As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "LOAD DATA INFILE '" & path & "' INTO TABLE mst_employee FIELDS TERMINATED BY ';' ENCLOSED BY '""' LINES TERMINATED BY '\r\n' IGNORE 1 LINES (first_name,last_name,address,city,state,postal_code,country,phone1,phone2,phone3,fax,email,website,notes);"
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


    Public Sub insert_marketing(ByVal var_id_marketing As String, ByVal var_first_name As String, ByVal var_last_name As String, _
                                ByVal var_address As String, ByVal var_city As String, _
                                ByVal var_state As String, ByVal var_postal_code As String, ByVal var_country As String, ByVal var_phone1 As String, _
                                ByVal var_phone2 As String, ByVal var_phone3 As String, ByVal var_fax As String, ByVal var_email As String, ByVal var_website As String, _
                                ByVal var_photo As String, ByVal target As Double, ByVal var_id_account As String, ByVal var_modified_user As String, ByVal var_created_date As Date, _
                                ByVal var_modified_date As Date, ByVal var_created_user As String, ByVal var_status As Integer, ByVal var_notes As String, ByVal var_grade As String, ByVal var_position As Integer, ByVal var_department As Integer)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        var_photo_replace = Replace(var_photo, "\", "/")
        With cmd_sqlinsert
            .Connection = conn
            .CommandText = "call sp_marketing ('" & var_id_marketing & "','" & var_first_name & "','" & var_last_name & "','" & _
                                                var_address & "','" & var_city & "','" & _
                                                var_state & "','" & var_postal_code & "','" & var_country & "','" & var_phone1 & "','" & _
                                                var_phone2 & "','" & var_phone3 & "','" & var_fax & "','" & var_email & "','" & var_website & "','" & _
                                                var_photo_replace & "'," & target & ",'" & var_id_account & "','" & var_modified_user & "','" & Format(var_created_date, "yyyy-MM-dd") & "','" & _
                                                Format(var_modified_date, "yyyy-MM-dd") & "','" & var_created_user & "','INSERT'," & var_status & ",'" & var_notes & "','" & var_grade & "'," & var_position & "," & var_department & ")"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlinsert.ExecuteNonQuery()
            oTransaction.Commit()
            param_sukses = True
            If param_sukses = True Then
                With cmd_sqlinsert
                    .Connection = conn
                    .CommandText = "update control_no_master set nourut = (select func_update_nomor('MASTER MARKETING')) where form = 'MASTER MARKETING'"
                    .CommandType = CommandType.Text
                End With
                cmd_sqlinsert.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            oTransaction.Rollback()
            param_sukses = False
        End Try
    End Sub



End Module
