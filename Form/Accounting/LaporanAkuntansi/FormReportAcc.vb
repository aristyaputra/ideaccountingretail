Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports MySql.Data.MySqlClient

Public Class FormReportAcc
    ' Public report_acc_source As Boolean

    Private Sub list_report()
        Dim DT As DataTable
        DT = select_report_list(username, "MN_ACCOUNTING_REPORT")
        ListReport.DisplayMember = "notes"
        ListReport.ValueMember = "childkey"
        ListReport.DataSource = DT
    End Sub

    Private Sub clear_checked()
        open_conn()

        rb_purch1.Checked = False
        rb_purch2.Checked = False
        rb_purch3.Checked = False
        rb_purch6.Checked = False
        rb_purch7.Checked = False

        chk_filterbl_purch.Checked = False
        bl_purch1.Enabled = False
        bl_purch2.Enabled = False

        chk_filtersupp_purch.Checked = False
        cbo_supp_purch1.Enabled = False
        cbo_supp_purch2.Enabled = False

        chk_filtertgl_purch.Checked = False
        tgl_purch1.Enabled = False
        tgl_purch2.Enabled = False

        ' gb_filterbl_purch.Visible = False
        gb_filtersupp_purch.Visible = False
        gb_filtertgl_purch.Visible = False
        'gb_filterth_purch.Visible = False
    End Sub

    Private Sub choose_report(ByVal value_choose As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False

            If value_choose = "MN_PIHAKKE3_REVENUE" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapPendapatanSIMRSGroupPihak3.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_layanan_grouppasien"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))


                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_account} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_account} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filtertgl_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.TGLPELAYANAN} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.TGLPELAYANAN} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        Else
                            filter2 = "{view_lap_datacustomer.TGLPELAYANAN} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.TGLPELAYANAN} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        End If
                    Else
                        filter2 = ""
                    End If

                    If filter1 <> "" Or filter2 <> "" Then
                        ReportFormula = filter1 + filter2
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    cryRpt.Refresh()

                    My.Application.ChangeCulture("en-US")
                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue("PERIOD", "Periode: " & Format(tgl_purch1.Value, "dd-MMM-yyyy") & " s/d " & Format(tgl_purch2.Value, "dd-MMM-yyyy"))
                    Else
                        cryRpt.SetParameterValue("PERIOD", "Per: " & Format(server_datetime(), "dd-MMM-yyyy"))
                    End If

                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Pendapatan Per Jenis Pasien"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If


            If value_choose = "MN_JOURNAL_REPORT" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapJurnal.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_lap_jurnal"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))

                    
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_account} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_account} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filtertgl_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        Else
                            filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        End If
                    Else
                        filter2 = ""
                    End If

                    If filter1 <> "" Or filter2 <> "" Then
                        ReportFormula = filter1 + filter2
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    cryRpt.Refresh()

                    My.Application.ChangeCulture("en-US")
                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue(2, "Periode: " & Format(tgl_purch1.Value, "dd-MMM-yyyy") & " s/d " & Format(tgl_purch2.Value, "dd-MMM-yyyy"))
                    Else
                        cryRpt.SetParameterValue(2, "Per: " & Format(server_datetime(), "dd-MMM-yyyy"))
                    End If

                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Daftar Jurnal"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_GENERAL_LEDGER_REPORT" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapBukuBesar.rpt"
                Try
                    
                    Dim DTA, DTB As DataTable

                    DTA = select_first_account()
                    DTB = select_last_account()
                    If chk_filtersupp_purch.Checked = False Then
                        cbo_supp_purch1.EditValue = DTA.Rows(0).Item(0)
                        cbo_supp_purch2.EditValue = DTB.Rows(0).Item(0)
                    End If

                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim filterDate As Integer
                    If chk_filtertgl_purch.Checked = True Then
                        filterDate = 1
                    Else
                        filterDate = 0
                    End If
                    Dim qryCompanies As String = "call sp_rpt_all_ledger('" & cbo_supp_purch1.EditValue & "','" & cbo_supp_purch2.EditValue & "','" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "','" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "'," & filterDate & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()


                    cryRpt.SetParameterValue(0, cbo_supp_purch1.EditValue)
                    cryRpt.SetParameterValue(1, cbo_supp_purch2.EditValue)
                    cryRpt.SetParameterValue(2, Format(tgl_purch1.Value, "yyyy-MM-dd"))
                    cryRpt.SetParameterValue(3, Format(tgl_purch2.Value, "yyyy-MM-dd"))
                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue(4, 1)
                    ElseIf chk_filtertgl_purch.Checked = False Then
                        cryRpt.SetParameterValue(4, 0)
                    End If

                    My.Application.ChangeCulture("id-ID")
                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue("periode", "Periode: " & Format(tgl_purch1.Value, "dd-MMM-yyyy") & " s/d " & Format(tgl_purch2.Value, "dd-MMM-yyyy"))
                    Else
                        cryRpt.SetParameterValue("periode", "Per: " & Format(server_datetime(), "dd-MMM-yyyy"))
                    End If

                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Buku Besar"
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized

                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With


                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_TRIAL_BALANCE" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapNeracaLajur.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim filterDate As Integer
                    If chk_filtertgl_purch.Checked = True Then
                        filterDate = 1
                    Else
                        filterDate = 0
                    End If
                    Dim qryCompanies As String = "call sp_view_neraca_lajur('" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "','" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "'," & filterDate & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Format(tgl_purch1.Value, "yyyy-MM-dd"))
                    cryRpt.SetParameterValue(1, Format(tgl_purch2.Value, "yyyy-MM-dd"))

                    My.Application.ChangeCulture("id-ID")
                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue(3, "Periode: " & Format(tgl_purch1.Value, "dd-MMM-yyyy") & " s/d " & Format(tgl_purch2.Value, "dd-MMM-yyyy"))
                    Else
                        cryRpt.SetParameterValue(3, "Per: " & Format(server_datetime(), "dd-MMM-yyyy"))
                    End If

                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"

                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue(2, 1)
                    ElseIf chk_filtertgl_purch.Checked = False Then
                        cryRpt.SetParameterValue(2, 0)
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Neraca Lajur"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_TRIAL_BALANCE_ADJUSTED" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapNeracaLajurAdjusted.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim filterDate As Integer
                    If chk_filtertgl_purch.Checked = True Then
                        filterDate = 1
                    Else
                        filterDate = 0
                    End If
                    Dim qryCompanies As String = "call sp_view_neraca_lajur2('" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "','" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "'," & filterDate & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Format(tgl_purch1.Value, "yyyy-MM-dd"))
                    cryRpt.SetParameterValue(1, Format(tgl_purch2.Value, "yyyy-MM-dd"))

                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue(2, 1)
                    ElseIf chk_filtertgl_purch.Checked = False Then
                        cryRpt.SetParameterValue(2, 0)
                    End If

                    My.Application.ChangeCulture("id-ID")
                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue(3, "Periode: " & Format(tgl_purch1.Value, "dd-MMM-yyyy") & " s/d " & Format(tgl_purch2.Value, "dd-MMM-yyyy"))
                    Else
                        cryRpt.SetParameterValue(3, "Per: " & Format(server_datetime(), "dd-MMM-yyyy"))
                    End If

                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"
                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Neraca Lajur Setelah Penyesuaian"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_BALANCE_SHEET_SCONTRO" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapNeraca.rpt"

                Try
                    If chk_filtertgl_purch.Checked = True Then
                        Call aktiva_rpt(Format(tgl_purch1.Value, "yyyy-MM-dd"), Format(tgl_purch2.Value, "yyyy-MM-dd"), 1)
                        Call pasiva_rpt(Format(tgl_purch1.Value, "yyyy-MM-dd"), Format(tgl_purch2.Value, "yyyy-MM-dd"), 1)
                    ElseIf chk_filtertgl_purch.Checked = False Then
                        Call aktiva_rpt(Format(tgl_purch1.Value, "yyyy-MM-dd"), Format(tgl_purch2.Value, "yyyy-MM-dd"), 0)
                        Call pasiva_rpt(Format(tgl_purch1.Value, "yyyy-MM-dd"), Format(tgl_purch2.Value, "yyyy-MM-dd"), 0)
                    End If

                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim DTAktiva As New DataTable
                    Dim DTPassiva As New DataTable

                    DTAktiva = select_view_aktiva()
                    DTPassiva = select_view_pasiva()

                    Dim filterDate As Integer
                    If chk_filtertgl_purch.Checked = True Then
                        filterDate = 1
                    Else
                        filterDate = 0
                    End If
                    Dim qryCompanies As String = "select * from view_report_header"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    
                    da.Fill(ds)
                    cryRpt.Load(pathfilereport)

                   
                    cryRpt.Subreports(0).SetDataSource(DTAktiva)
                    cryRpt.Subreports(1).SetDataSource(DTPassiva)
                    cryRpt.Subreports(2).SetDataSource(DTAktiva)
                    cryRpt.Subreports(3).SetDataSource(DTPassiva)


                    cryRpt.SetDataSource(ds.Tables(0))
                   
                    cryRpt.Refresh()

                    My.Application.ChangeCulture("id-ID")
                    'If chk_filtertgl_purch.Checked = True Then
                    '    cryRpt.SetParameterValue("periode", "Periode: " & Format(tgl_purch1.Value, "dd-MMM-yyyy") & " s/d " & Format(tgl_purch2.Value, "dd-MMM-yyyy"))
                    'Else
                    cryRpt.SetParameterValue("periode", "Per: " & Format(tgl_purch2.Value, "dd MMMM yyyy"))
                    'End If

                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Neraca"
                    '   LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_BALANCE_SHEET_STAFFEL" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapNeracaStafel.rpt"

                Try

                    Dim tgl_th_lalu1 As Date
                    Dim tgl_th_lalu2 As Date
                    If Format(tgl_purch1.Value, "MM") = "2" And Format(tgl_purch1.Value, "dd") = "28" Then
                        tgl_th_lalu1 = CDate(CStr(Year(tgl_purch1.Value) - 1) & "-" & Format(tgl_purch1.Value, "MM") & "-" & Format(tgl_purch1.Value, "dd"))
                    Else
                        tgl_th_lalu1 = CDate(CStr(Year(tgl_purch1.Value) - 1) & "-" & Format(tgl_purch1.Value, "MM") & "-28")
                    End If
                    If Format(tgl_purch2.Value, "MM") = "2" And Format(tgl_purch2.Value, "dd") = "28" Then
                        tgl_th_lalu2 = CDate(CStr(Year(tgl_purch2.Value) - 1) & "-" & Format(tgl_purch2.Value, "MM") & "-" & Format(tgl_purch2.Value, "dd"))
                    Else
                        tgl_th_lalu2 = CDate(CStr(Year(tgl_purch2.Value) - 1) & "-" & Format(tgl_purch2.Value, "MM") & "-28")
                    End If
                    If chk_filtertgl_purch.Checked = True Then
                        Call aktiva_tahunlalu_rpt(Format(tgl_th_lalu1, "yyyy-MM-dd"), Format(tgl_th_lalu2, "yyyy-MM-dd"), 1)
                        Call pasiva_tahunlalu_rpt(Format(tgl_th_lalu1, "yyyy-MM-dd"), Format(tgl_th_lalu2, "yyyy-MM-dd"), 1)
                        Call aktiva_rpt(Format(tgl_purch1.Value, "yyyy-MM-dd"), Format(tgl_purch2.Value, "yyyy-MM-dd"), 1)
                        Call pasiva_rpt(Format(tgl_purch1.Value, "yyyy-MM-dd"), Format(tgl_purch2.Value, "yyyy-MM-dd"), 1)
                    ElseIf chk_filtertgl_purch.Checked = False Then
                        Call aktiva_tahunlalu_rpt(Format(tgl_th_lalu1, "yyyy-MM-dd"), Format(tgl_th_lalu2, "yyyy-MM-dd"), 0)
                        Call pasiva_tahunlalu_rpt(Format(tgl_th_lalu1, "yyyy-MM-dd"), Format(tgl_th_lalu2, "yyyy-MM-dd"), 0)
                        Call aktiva_rpt(Format(tgl_purch1.Value, "yyyy-MM-dd"), Format(tgl_purch2.Value, "yyyy-MM-dd"), 0)
                        Call pasiva_rpt(Format(tgl_purch1.Value, "yyyy-MM-dd"), Format(tgl_purch2.Value, "yyyy-MM-dd"), 0)
                    End If

                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim filterDate As Integer
                    If chk_filtertgl_purch.Checked = True Then
                        filterDate = 1
                    Else
                        filterDate = 0
                    End If
                    Dim qryCompanies As String = "select * from view_aktiva_stafel"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()

                    My.Application.ChangeCulture("id-ID")
                    'If chk_filtertgl_purch.Checked = True Then
                    '    cryRpt.SetParameterValue("periode", "Periode: " & Format(tgl_purch1.Value, "dd-MMM-yyyy") & " s/d " & Format(tgl_purch2.Value, "dd-MMM-yyyy"))
                    'Else
                    cryRpt.SetParameterValue("periode", "Per: " & Format(tgl_purch2.Value, "dd MMMM yyyy"))
                    'End If
                    cryRpt.SetParameterValue("keterangan", "Dengan Angka Pembanding Tahun " & CStr(Year(tgl_purch2.Value) - 1))

                    cryRpt.SetParameterValue("bulan_ini", UCase(Format(tgl_purch2.Value, "MMMM")))
                    cryRpt.SetParameterValue("tahun_ini", Year(tgl_purch2.Value))
                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Neraca"
                    '   LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_COGS_REPORT" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapHPP.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim filterDate As Integer
                    If chk_filtertgl_purch.Checked = True Then
                        filterDate = 1
                    Else
                        filterDate = 0
                    End If
                    Dim qryCompanies As String = "call sp_rpt_cogs('" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "','" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "'," & filterDate & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Format(tgl_purch1.Value, "yyyy-MM-dd"))
                    cryRpt.SetParameterValue(1, Format(tgl_purch2.Value, "yyyy-MM-dd"))

                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue(2, 1)
                    ElseIf chk_filtertgl_purch.Checked = False Then
                        cryRpt.SetParameterValue(2, 0)
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan HPP"
                    '    LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_INCOME_STATEMENT" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapLabaRugi.rpt"

                Try
                    If chk_filtertgl_purch.Checked = True Then
                        Call income_rpt(Format(tgl_purch1.Value, "yyyy-MM-dd"), Format(tgl_purch2.Value, "yyyy-MM-dd"), 1)
                    ElseIf chk_filtertgl_purch.Checked = False Then
                        Call income_rpt(Format(tgl_purch1.Value, "yyyy-MM-dd"), Format(tgl_purch2.Value, "yyyy-MM-dd"), 0)
                    End If
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim filterDate As Integer
                    If chk_filtertgl_purch.Checked = True Then
                        filterDate = 1
                    Else
                        filterDate = 0
                    End If
                    Dim qryCompanies As String = "select * from view_laba_rugi"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()

                    My.Application.ChangeCulture("id-ID")
                    'If chk_filtertgl_purch.Checked = True Then
                    '    cryRpt.SetParameterValue("periode", "Periode: " & Format(tgl_purch1.Value, "dd-MMM-yyyy") & " s/d " & Format(tgl_purch2.Value, "dd-MMM-yyyy"))
                    'Else
                    cryRpt.SetParameterValue("periode", "Per: " & Format(tgl_purch2.Value, "dd MMMM yyyy"))
                    '  End If

                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"

                    cryRpt.SetParameterValue(0, 0)
                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "laporan Laba Rugi"
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_OPERASIONAL_REPORT_RSHAJI" Then
                
            End If
            If value_choose = "MN_LRA_REPORT_RSHAJI" Then
                
            End If
            If value_choose = "MN_EQUITY_REPORT" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapPerubahanModal.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim filterDate As Integer
                    If chk_filtertgl_purch.Checked = True Then
                        filterDate = 1
                    Else
                        filterDate = 0
                    End If
                    Dim qryCompanies As String = "call sp_rpt_perubahan_modal('" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "','" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "'," & filterDate & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Format(tgl_purch1.Value, "yyyy-MM-dd"))
                    cryRpt.SetParameterValue(1, Format(tgl_purch2.Value, "yyyy-MM-dd"))

                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue(2, 1)
                    ElseIf chk_filtertgl_purch.Checked = False Then
                        cryRpt.SetParameterValue(2, 0)
                    End If

                    My.Application.ChangeCulture("id-ID")
                    'If chk_filtertgl_purch.Checked = True Then
                    '    cryRpt.SetParameterValue("periode", "Periode: " & Format(tgl_purch1.Value, "dd-MMM-yyyy") & " s/d " & Format(tgl_purch2.Value, "dd-MMM-yyyy"))
                    'Else
                    cryRpt.SetParameterValue("periode", "Per: " & Format(tgl_purch2.Value, "dd MMMM yyyy"))
                    ' End If
                    cryRpt.SetParameterValue("keterangan", "Dengan Angka Pembanding Tahun " & CStr(Year(tgl_purch2.Value) - 1))

                    cryRpt.SetParameterValue("bulan_ini", UCase(Format(tgl_purch2.Value, "MMMM")))
                    cryRpt.SetParameterValue("tahun_ini", Year(tgl_purch2.Value))
                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Perubahan Ekuitas"
                    '    LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_CASHFLOW_REPORT" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapArusKas.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim filterDate As Integer
                    If chk_filtertgl_purch.Checked = True Then
                        filterDate = 1
                    Else
                        filterDate = 0
                    End If
                    Dim qryCompanies As String = "call sp_rpt_cash_flow('" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "','" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "'," & filterDate & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Format(tgl_purch1.Value, "yyyy-MM-dd"))
                    cryRpt.SetParameterValue(1, Format(tgl_purch2.Value, "yyyy-MM-dd"))

                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue(2, 1)
                    ElseIf chk_filtertgl_purch.Checked = False Then
                        cryRpt.SetParameterValue(2, 0)
                    End If

                    My.Application.ChangeCulture("id-ID")
                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue("periode", "Periode: " & Format(tgl_purch1.Value, "dd-MMM-yyyy") & " s/d " & Format(tgl_purch2.Value, "dd-MMM-yyyy"))
                    Else
                        cryRpt.SetParameterValue("periode", "Per: " & Format(tgl_purch2.Value, "dd MMMM yyyy"))
                    End If
                    '  cryRpt.SetParameterValue("keterangan", "Dengan Angka Pembanding Tahun " & CStr(Year(tgl_purch2.Value) - 1))

                    cryRpt.SetParameterValue("bulan_ini", UCase(Format(tgl_purch2.Value, "MMMM")))
                    cryRpt.SetParameterValue("tahun_ini", Year(tgl_purch2.Value))
                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Arus Kas"
                    '    LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_purch.Click
        open_conn()
        choose_report(ListReport.SelectedValue)
    End Sub

    Private Sub FormReportAcc_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FormReportMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        clear_checked()
        fillComboBox()
        list_report()
    End Sub

    Private Sub fillComboBox()
        Dim DTAkun As DataTable
        DTAkun = getComboAccount()
        cbo_supp_purch1.Properties.DataSource = DTAkun
        cbo_supp_purch1.Properties.DisplayMember = "account_name"
        cbo_supp_purch1.Properties.ValueMember = "id_account"
        cbo_supp_purch1.Properties.PopulateViewColumns()
        cbo_supp_purch1.Properties.View.Columns("id_account").Caption = "No Akun"
        cbo_supp_purch1.Properties.View.Columns("account_name").Caption = "Nama Akun"
        cbo_supp_purch1.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_supp_purch1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        cbo_supp_purch2.Properties.DataSource = DTAkun
        cbo_supp_purch2.Properties.DisplayMember = "account_name"
        cbo_supp_purch2.Properties.ValueMember = "id_account"
        cbo_supp_purch2.Properties.PopulateViewColumns()
        cbo_supp_purch2.Properties.View.Columns("id_account").Caption = "No Akun"
        cbo_supp_purch2.Properties.View.Columns("account_name").Caption = "Nama Akun"
        cbo_supp_purch2.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_supp_purch2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub chk_filterkota_cust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filtersupp_purch.CheckedChanged
        If chk_filtersupp_purch.Checked = True Then
            cbo_supp_purch1.Enabled = True
            cbo_supp_purch2.Enabled = True
        ElseIf chk_filtersupp_purch.Checked = False Then
            cbo_supp_purch1.Enabled = False
            cbo_supp_purch2.Enabled = False
        End If
    End Sub

    Private Sub chk_filterbl_cust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filtertgl_purch.CheckedChanged
        open_conn()
        If chk_filtertgl_purch.Checked = True Then
            tgl_purch1.Enabled = True
            tgl_purch2.Enabled = True
        ElseIf chk_filtertgl_purch.Checked = False Then
            tgl_purch1.Enabled = False
            tgl_purch2.Enabled = False
        End If
    End Sub

    Private Sub chk_filtertgl_cust_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_filterbl_purch.CheckedChanged
        open_conn()
        If chk_filterbl_purch.Checked = True Then
            bl_purch1.Enabled = True
            bl_purch2.Enabled = True
        ElseIf chk_filterbl_purch.Checked = False Then
            bl_purch1.Enabled = False
            bl_purch2.Enabled = False
        End If
    End Sub

    Private Sub rb_purch8_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_purch8.CheckedChanged
        open_conn()
        If rb_purch8.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
        End If
    End Sub

    Private Sub rb_purch9_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_purch9.CheckedChanged
        open_conn()
        If rb_purch9.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
        End If
    End Sub

    Private Sub btn_purch_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_purch.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_purch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_purch.BackColor = Color.FromArgb(var_red_btn, var_grey_btn, var_blue_btn)
        btn_purch.ForeColor = Color.White
        btn_purch.Cursor = Cursors.Default
    End Sub

    Private Sub btn_ap_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_purch.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pesan As String
        pesan = MessageBox.Show("Keluar Form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pesan = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ListReport_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListReport.SelectedValueChanged
        open_conn()
        If ListReport.SelectedValue = "MN_PIHAKKE3_REVENUE" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Filter Tanggal"
            tgl_purch1.Visible = True
            tgl_purch2.Visible = True
            tgl_purch2.Top = 109
            chk_filtertgl_purch.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = False
            tgl_purch2.Enabled = False
        End If
        If ListReport.SelectedValue = "MN_JOURNAL_REPORT" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Filter Tanggal"
            tgl_purch1.Visible = True
            tgl_purch2.Visible = True
            tgl_purch2.Top = 109
            chk_filtertgl_purch.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = False
            tgl_purch2.Enabled = False
        End If
        If ListReport.SelectedValue = "MN_GENERAL_LEDGER_REPORT" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Filter Tanggal"
            tgl_purch1.Visible = True
            tgl_purch2.Visible = True
            tgl_purch2.Top = 109
            chk_filtertgl_purch.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = False
            tgl_purch2.Enabled = False
        End If
        If ListReport.SelectedValue = "MN_TRIAL_BALANCE" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Filter Tanggal"
            tgl_purch1.Visible = True
            tgl_purch2.Visible = True
            tgl_purch2.Top = 109
            chk_filtertgl_purch.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = False
            tgl_purch2.Enabled = False
        End If
        If ListReport.SelectedValue = "MN_TRIAL_BALANCE_ADJUSTED" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Filter Tanggal"
            tgl_purch1.Visible = True
            tgl_purch2.Visible = True
            tgl_purch2.Top = 109
            chk_filtertgl_purch.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = False
            tgl_purch2.Enabled = False
        End If
        If ListReport.SelectedValue = "MN_BALANCE_SHEET_SCONTRO" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Per Tanggal"
            tgl_purch1.Visible = False
            tgl_purch2.Visible = True
            tgl_purch2.Top = 20
            chk_filtertgl_purch.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = True
            tgl_purch2.Enabled = True
        End If
        If ListReport.SelectedValue = "MN_BALANCE_SHEET_STAFFEL" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Per Tanggal"
            tgl_purch1.Visible = False
            tgl_purch2.Visible = True
            tgl_purch2.Top = 20
            chk_filtertgl_purch.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = True
            tgl_purch2.Enabled = True
        End If
        If ListReport.SelectedValue = "MN_COGS_REPORT" Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = False
        End If
        If ListReport.SelectedValue = "MN_INCOME_STATEMENT" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Per Tanggal"
            tgl_purch1.Visible = False
            tgl_purch2.Visible = True
            tgl_purch2.Top = 20
            chk_filtertgl_purch.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = True
            tgl_purch2.Enabled = True
        End If
        If ListReport.SelectedValue = "MN_OPERASIONAL_REPORT_RSHAJI" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Per Tanggal"
            tgl_purch1.Visible = False
            tgl_purch2.Visible = True
            tgl_purch2.Top = 20
            chk_filtertgl_purch.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = True
            tgl_purch2.Enabled = True
        End If
        If ListReport.SelectedValue = "MN_EQUITY_REPORT" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Per Tanggal"
            tgl_purch1.Visible = False
            tgl_purch2.Visible = True
            tgl_purch2.Top = 20
            chk_filtertgl_purch.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = True
            tgl_purch2.Enabled = True
        End If
        If ListReport.SelectedValue = "MN_CASHFLOW_REPORT" Then
            gb_filtertgl_purch.Visible = True
            gb_filtertgl_purch.Text = "Filter Tanggal"
            tgl_purch1.Visible = True
            tgl_purch2.Visible = True
            tgl_purch2.Top = 109
            chk_filtertgl_purch.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            chk_filtertgl_purch.Checked = False
        End If
    End Sub

    Private Sub ListReport_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListReport.SelectedIndexChanged

    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class