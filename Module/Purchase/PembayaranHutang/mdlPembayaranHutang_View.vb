Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPembayaranHutang_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_APpayment(ByVal fields As String, ByVal criteria As String, ByVal detail As Integer, ByVal date_filter As Integer, ByVal startdate As Date, ByVal enddate As Date) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call select_APpayment('" & fields & "', '" & criteria & "', " & detail & "," & date_filter & ",'" & Format(startdate, "yyyy-MM-dd") & "','" & Format(enddate, "yyyy-MM-dd") & "')"
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

    Public Function view_ap_status(ByVal filter_date As Integer, ByVal field As String, ByVal criteria As String, ByVal start_date As Date, ByVal end_date As Date) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                If filter_date = 0 Then
                    .CommandText = "select * from view_ap_status where " & field & " like '%" & criteria & "%'"
                ElseIf filter_date = 1 Then
                    .CommandText = "select * from view_ap_status where " & field & " like '%" & criteria & "%' and date_trn between '" & Format(start_date, "yyyy-MM-dd") & "' and '" & Format(end_date, "yyyy-MM-dd") & "'"
                End If
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
