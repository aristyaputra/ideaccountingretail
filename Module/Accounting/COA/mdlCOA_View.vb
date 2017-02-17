Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlCOA_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_golongan_acc_bumn() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from i_golongan_account_bumn"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT
        End Try

    End Function

    Public Function select_golongan_acc_umum() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from i_golongan_account_umum"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT
        End Try

    End Function

    Public Function select_master_acc(ByVal sp_name As String, ByVal field As String, ByVal criteria As String, ByVal detail As Integer, ByVal var_date_filter As Integer, ByVal startdate As Date, ByVal enddate As Date, ByVal pageIndex As Integer, ByVal pageLoad As Integer) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call " & sp_name & "('" & field & "','" & criteria & "'," & detail & "," & var_date_filter & ",'" & Format(startdate, "yyyy-MM-dd") & "','" & Format(enddate, "yyyy-MM-dd") & "')"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT
        End Try

    End Function

    Public Sub select_control_acc(ByVal parent As String, ByVal header As Integer)
        With cmd_sqlselect
            .Connection = conn
            .CommandText = "select func_get_account_no('" & parent & "'," & header & ")"
            .CommandType = CommandType.Text
        End With
        mysql_select = cmd_sqlselect.ExecuteReader

        If mysql_select.HasRows Then
            mysql_select.Read()
            no_account = mysql_select.Item(0)
            mysql_select.Close()
        End If
    End Sub

    Public Function getComboPositionAcc() As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select 'Debet' as position union select 'Kredit'"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT
        End Try

    End Function


End Module
