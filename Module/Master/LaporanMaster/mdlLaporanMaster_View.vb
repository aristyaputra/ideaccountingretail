Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlLaporanMaster_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader
    Dim oTransaction As MySqlTransaction
    Dim oTransaction2 As MySqlTransaction


    Public Sub ranking_pelanggan_rpt(ByVal date_filter As Integer, ByVal var_start_date As Date, ByVal var_end_date As Date)
        Dim DT As New DataTable
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlselect
            .Connection = conn
            .CommandText = "call sp_rpt_rangking_pelanggan(" & date_filter & ",'" & Format(var_start_date, "yyyy-MM-dd") & "','" & Format(var_end_date, "yyyy-MM-dd") & "')"
            .CommandType = CommandType.Text
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlselect.ExecuteNonQuery()
            oTransaction.Commit()
        Catch ex As Exception
            oTransaction.Rollback()
        End Try

    End Sub


End Module
