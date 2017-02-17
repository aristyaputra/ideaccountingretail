Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPenerimaanKas_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader


    Public Function select_view_ReceiptMoney(ByVal fields As String, ByVal criteria As String) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_receiptmoney where " & fields & "='" & criteria & "' AND flag_trans='BM' order by date_trn desc"
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
