Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlRekonsiliasiBank_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_reconcile(ByVal field As String, ByVal criteria As String, ByVal detail As Integer, ByVal var_date_filter As Integer, ByVal startdate As Date, ByVal enddate As Date) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call select_reconcile('" & field & "','" & criteria & "'," & detail & "," & var_date_filter & ",'" & Format(startdate, "yyyy-MM-dd") & "','" & Format(enddate, "yyyy-MM-dd") & "')"
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

    Public Function end_balance_acc(ByVal criteria As String) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call sp_end_balance_acc('" & criteria & "')"
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
