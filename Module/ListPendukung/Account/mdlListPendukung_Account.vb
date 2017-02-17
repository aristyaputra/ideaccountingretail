Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlListPendukung_Account
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_acc_detail(ByVal field As String, ByVal criteria As String) As DataTable
        Dim DT As New DataTable
        If field = "Account No" Then
            field = "id_account"
        ElseIf field = "Account Name" Then
            field = "account_name"
        End If
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from mst_account where " & field & " like '%" & criteria & "%' and flag_header = 0"
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
