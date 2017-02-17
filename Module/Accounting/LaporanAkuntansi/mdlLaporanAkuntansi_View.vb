Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlLaporanAkuntansi_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader

    Dim oTransaction As MySqlTransaction
    Dim oTransaction2 As MySqlTransaction


    Public Function select_view_aktiva() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_aktiva"
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


    Public Function select_view_pasiva() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_pasiva"
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

    Public Function select_first_account() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select id_account from mst_account where flag_header = 0 order by id_account asc limit 1"
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

    Public Function select_last_account() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select id_account from mst_account where flag_header = 0 order by id_account desc limit 1"
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

    Public Function journal_report() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_lap_jurnal"
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


    Public Sub neraca_rpt(ByVal var_start_date As Date, ByVal var_end_date As Date)
        Dim DT As New DataTable
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlselect
            .Connection = conn
            .CommandText = "call sp_view_neraca('" & Format(var_start_date, "yyyy-MM-dd") & "','" & Format(var_end_date, "yyyy-MM-dd") & "')"
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



    Public Sub aktiva_rpt(ByVal var_start_date As Date, ByVal var_end_date As Date, ByVal date_filter As Integer)
        Dim DT As New DataTable
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlselect
            .Connection = conn
            .CommandText = "call sp_view_aktiva('" & Format(var_start_date, "yyyy-MM-dd") & "','" & Format(var_end_date, "yyyy-MM-dd") & "'," & date_filter & ")"
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


    Public Sub aktiva_tahunlalu_rpt(ByVal var_start_date As Date, ByVal var_end_date As Date, ByVal date_filter As Integer)
        Dim DT As New DataTable
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlselect
            .Connection = conn
            .CommandText = "call sp_view_aktiva_tahunlalu('" & Format(var_start_date, "yyyy-MM-dd") & "','" & Format(var_end_date, "yyyy-MM-dd") & "'," & date_filter & ")"
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


    Public Sub pasiva_tahunlalu_rpt(ByVal var_start_date As Date, ByVal var_end_date As Date, ByVal date_filter As Integer)
        Dim DT As New DataTable
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlselect
            .Connection = conn
            .CommandText = "call sp_view_pasiva_tahunlalu('" & Format(var_start_date, "yyyy-MM-dd") & "','" & Format(var_end_date, "yyyy-MM-dd") & "'," & date_filter & ")"
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


    Public Sub pasiva_rpt(ByVal var_start_date As Date, ByVal var_end_date As Date, ByVal date_filter As Integer)
        Dim DT As New DataTable
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlselect
            .Connection = conn
            .CommandText = "call sp_view_pasiva('" & Format(var_start_date, "yyyy-MM-dd") & "','" & Format(var_end_date, "yyyy-MM-dd") & "'," & date_filter & ")"
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


    Public Sub income_rpt(ByVal var_start_date As Date, ByVal var_end_date As Date, ByVal date_filter As Integer)
        Dim DT As New DataTable
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlselect
            .Connection = conn
            .CommandText = "call sp_view_income('" & Format(var_start_date, "yyyy-MM-dd") & "','" & Format(var_end_date, "yyyy-MM-dd") & "'," & date_filter & ")"
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

    Public Sub income_rpt_tahunlalu(ByVal var_start_date As Date, ByVal var_end_date As Date, ByVal date_filter As Integer)
        Dim DT As New DataTable
        oTransaction = conn.BeginTransaction(IsolationLevel.ReadCommitted)

        With cmd_sqlselect
            .Connection = conn
            .CommandText = "call sp_view_income_tahunlalu('" & Format(var_start_date, "yyyy-MM-dd") & "','" & Format(var_end_date, "yyyy-MM-dd") & "'," & date_filter & ")"
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
