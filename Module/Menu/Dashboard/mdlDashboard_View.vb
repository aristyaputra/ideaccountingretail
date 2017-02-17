Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module mdlDashboard_View
    Dim SqlSelect As String
    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Dim mysql_reader As MySqlDataReader



    Public Function get_count_pjt() As Double
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select count(no_sales) from view_piutang_jt"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT.Rows(0).Item(0)
        End Try

    End Function

    Public Function get_count_hjt() As Double
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select count(no_purchase) from view_hutang_jt"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT.Rows(0).Item(0)
        End Try

    End Function

    Public Function get_logo() As String
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select logo from i_product_id where is_active = 1"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT.Rows(0).Item(0)
        End Try

    End Function

    Public Function get_panel() As String
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select panel from i_product_id where is_active = 1"
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT.Rows(0).Item(0)
        End Try

    End Function

    Public Function current_grafik_assetreturn() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "SELECT * FROM view_grafik_currentaset"
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

    Public Function piutangJtTempo() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_piutang_jt"
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


    Public Function hutangJtTempo() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_hutang_jt"
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

    Public Function grafikBiayaTahunan() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_grafikbiaya_th"
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


    Public Function notifSOThisMonth() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from so_thismonth_view"
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


    Public Function grafikRekapPembelian() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select bulan, total from rekap_pembelian_view"
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

    Public Function grafikRekapPenjualanPerCategory() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_lap_rekap_penjper_category"
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

    Public Function OneHundredCurrentSales() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_current_100sales"
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

    Public Function grafikRekapPenjualan() As DataTable
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from rekap_penjualan_view"
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

    Public Function select_so_nowadays() As DataTable
        Dim DT As New DataTable
        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select * from view_so_nowadays where month(date_trn) = " & Month(server_datetime()) & " "
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
