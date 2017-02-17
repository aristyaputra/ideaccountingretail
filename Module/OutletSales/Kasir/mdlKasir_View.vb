Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlKasir_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_cashier2(ByVal fields As String, ByVal criteria As String, ByVal detail As Integer) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call select_cashier_2('" & fields & "', '" & criteria & "', " & detail & " )"
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
