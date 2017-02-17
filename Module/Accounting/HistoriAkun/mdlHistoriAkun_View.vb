Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlHistoriAkun_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_general_ledger(ByVal var_criteria As String, ByVal tgl_awal As Date, ByVal tgl_akhir As Date, ByVal date_filter As Integer, ByVal pageIndex As Integer, ByVal pageLoad As Integer) As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call general_ledger ('" & var_criteria & "','" & Format(tgl_awal, "yyyy-MM-dd") & "','" & Format(tgl_akhir, "yyyy-MM-dd") & "'," & date_filter & "," & pageIndex & "," & pageLoad & ")"
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

    Public Function select_def_accpos(ByVal var_criteria As String) As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select def_position from mst_account where id_account = '" & var_criteria & "'"
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
