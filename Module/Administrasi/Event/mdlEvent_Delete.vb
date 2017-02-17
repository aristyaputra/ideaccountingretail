Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlEvent_Delete
    Dim SqlDelete As String
    Dim cmd_sqldelete As New MySqlCommand
    Dim oTransaction As MySqlTransaction
    Dim var_photo_replace As String


    Public Sub delete_event(ByVal var_id_event As String, ByVal var_event_name As String, ByVal var_start_date As DateTime, ByVal var_end_date As DateTime, ByVal var_pic As String, ByVal var_created_date As DateTime, ByVal var_modified_date As DateTime, ByVal var_created_user As String, ByVal var_modified_user As String, ByVal TRANSID As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_event ('" & var_id_event & "','" & var_event_name & "','" & Format(var_start_date, "yyyy-MM-dd hh:mm:ss") & "','" & Format(var_end_date, "yyyy-MM-dd hh:mm:ss") & "','" & var_pic & "','" & Format(var_created_date, "yyyy-MM-dd hh:mm:ss") & "','" & Format(var_modified_date, "yyyy-MM-dd hh:mm:ss") & "','" & var_created_user & "','" & var_modified_user & "','DELETE')"
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

    Public Sub delete_event_member(ByVal var_id_member As String, ByVal var_id_event As String, ByVal var_nip_member As String, ByVal var_member_name As String, ByVal var_position As String, ByVal var_area As String, ByVal var_region As String, ByVal var_created_date As DateTime, ByVal var_modified_date As DateTime, ByVal var_created_user As String, ByVal var_modified_user As String, ByVal TRANSID As String, ByVal photo_path As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_event_member ('" & var_id_member & "','" & var_id_event & "','" & var_nip_member & "','" & var_member_name & "','" & var_position & "','" & var_area & "','" & var_region & "','" & Format(var_created_date, "yyyy-MM-dd hh:mm:ss") & "','" & Format(var_modified_date, "yyyy-MM-dd hh:mm:ss") & "','" & var_created_user & "','" & var_modified_user & "','DELETE','" & Replace(photo_path, "\", "/") & "')"
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

    Public Sub delete_evt_attendance(ByVal var_id_event As String, ByVal var_id_attendance As String, ByVal var_attendance_date As DateTime, ByVal var_id_member As String, ByVal var_created_date As DateTime, ByVal var_modified_date As DateTime, ByVal var_created_user As String, ByVal var_modified_user As String, ByVal TRANSID As String)
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)
        With cmd_sqldelete
            .Connection = conn
            .CommandText = "call sp_event_attendance ('" & var_id_event & "','" & var_id_attendance & "','" & Format(var_attendance_date, "yyyy-MM-dd hh:mm:ss") & "','" & var_id_member & "','" & Format(var_created_date, "yyyy-MM-dd hh:mm:ss") & "','" & Format(var_modified_date, "yyyy-MM-dd hh:mm:ss") & "','" & var_created_user & "','" & var_modified_user & "','DELETE')"
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
