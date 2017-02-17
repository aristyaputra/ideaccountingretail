Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlListPendukung_Pembelian
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_po_detail(ByVal criteria As String) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_po_detail where no_purchase_order = '" & criteria & "'"
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
