Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlPengirimanBarang_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Public Function select_received_order(ByVal field As String, ByVal criteria As String, ByVal detail As Integer, ByVal date_filter As Integer, ByVal startdate As Date, ByVal enddate As Date) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call select_received_order('" & field & "','" & criteria & "'," & detail & "," & date_filter & ",'" & Format(startdate, "yyyy-MM-dd") & "','" & Format(enddate, "yyyy-MM-dd") & "')"
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


    Public Function select_delivered_item(ByVal field As String, ByVal criteria As String, ByVal detail As Integer, ByVal date_filter As Integer, ByVal startdate As Date, ByVal enddate As Date) As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "call select_delivered_item('" & field & "','" & criteria & "'," & detail & "," & date_filter & ",'" & Format(startdate, "yyyy-MM-dd") & "','" & Format(enddate, "yyyy-MM-dd") & "')"
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
