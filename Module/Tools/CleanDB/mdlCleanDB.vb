Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlCleanDB
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Dim SqlUpdate As String
    Dim cmd_sqlupdate As New MySqlCommand
    Dim oTransaction As MySqlTransaction

    Public Sub cleansing_db()
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlupdate
            .Connection = conn
            .CommandText = "call sp_clean_db()"
            .CommandType = CommandType.Text
            .CommandTimeout = 30000
            .Transaction = oTransaction
        End With
        Try
            cmd_sqlupdate.ExecuteNonQuery()
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
