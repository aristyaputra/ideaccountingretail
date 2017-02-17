Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports MySql.Data.MySqlClient

Public Class FormReportStock

    Private Sub clear_checked()
        open_conn()
        'rb_ap1.Checked = False
        'rb_ap2.Checked = False
        'rb_ap3.Checked = False
        'rb_ap4.Checked = False
        'rb_ap5.Checked = False
        'rb_ap6.Checked = False
        'rb_ap7.Checked = False

        rb_purch1.Checked = False
        rb_purch2.Checked = False
        rb_purch3.Checked = False
        rb_purch5.Checked = False
        rb_purch6.Checked = False
        rb_purch7.Checked = False

        chk_filterbarang_purch.Checked = False
        cbo_filterbarang_purch1.Enabled = False
        cbo_filterbarang_purch2.Enabled = False

        chk_filterbl_purch.Checked = False
        bl_purch1.Enabled = False
        bl_purch2.Enabled = False

        'chk_filtersupp_ap.Checked = False
        'cbo_supp_ap1.Enabled = False
        'cbo_supp_ap2.Enabled = False

        chk_filtersupp_purch.Checked = False
        cbo_supp_purch1.Enabled = False
        cbo_supp_purch2.Enabled = False

        'chk_filtertgl_ap.Checked = False
        'tgl_ap1.Enabled = False
        'tgl_ap2.Enabled = False

        chk_filtertgl_purch.Checked = False
        tgl_purch1.Enabled = False
        tgl_purch2.Enabled = False

        cbo_filterwh_purch1.Enabled = True

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_preview.Click
        open_conn()
        choose_report(ListReport.SelectedValue)
    End Sub

    Private Sub rb_cust1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch1.CheckedChanged
        open_conn()
        If rb_purch1.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
            gb_filterwh_purch.Visible = False
        End If
    End Sub

    Private Sub FormReportStock_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FormReportStock_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub list_report()
        Dim DT As DataTable
        DT = select_report_list(username, "MN_STOCK_REPORT")
        ListReport.DisplayMember = "notes"
        ListReport.ValueMember = "childkey"
        ListReport.DataSource = DT
    End Sub

    Private Sub choose_report(ByVal value_choose As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False

            If value_choose = "MN_STOCK_ADJUSTMENT_REPORT" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapKoreksiStock.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_lap_koreksi_stock"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_item} >= '" & Trim(cbo_filterbarang_purch1.EditValue) & "' and {view_lap_datacustomer.id_item} <= '" & Trim(cbo_filterbarang_purch2.EditValue) & "'"
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

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_STOCK_MUTATION_REPORT" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                If cbo_filterwh_purch1.EditValue Is Nothing Then
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan pilih gudang")
                    alertControl_warning.Show(Me, info)
                    Exit Sub
                End If

                pathfilereport = Application.StartupPath & "\Report\LapMutasiStock.rpt"
                Try
                    Dim DTA, DTB As DataTable
                    Dim datefilter As Integer
                    DTA = select_first_item()
                    DTB = select_end_item()
                    If chk_filterbarang_purch.Checked = False Then
                        cbo_filterbarang_purch1.EditValue = DTA.Rows(0).Item(0)
                        cbo_filterbarang_purch2.EditValue = DTB.Rows(0).Item(0)
                    End If
                    If chk_filtertgl_purch.Checked = True Then
                        datefilter = 1
                    Else
                        datefilter = 0
                    End If
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_all_mutasi_stock('" & cbo_filterbarang_purch1.EditValue & "','" & cbo_filterbarang_purch2.EditValue & "','" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "','" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "'," & datefilter & ",'" & cbo_filterwh_purch1.EditValue & "')"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                   
                    cryRpt.SetParameterValue(0, cbo_filterbarang_purch1.EditValue)
                    cryRpt.SetParameterValue(1, cbo_filterbarang_purch2.EditValue)
                    cryRpt.SetParameterValue(2, Format(tgl_purch1.Value, "yyyy-MM-dd"))
                    cryRpt.SetParameterValue(3, Format(tgl_purch2.Value, "yyyy-MM-dd"))

                    If chk_filtertgl_purch.Checked = True Then
                        cryRpt.SetParameterValue(4, 1)
                    ElseIf chk_filtertgl_purch.Checked = False Then
                        cryRpt.SetParameterValue(4, 0)
                    End If
                    cryRpt.SetParameterValue(5, cbo_filterwh_purch1.EditValue)
                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Refresh()
                    '   LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
            If value_choose = "MN_STOCK_CARD_COGS" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String
                Dim DTA, DTB As DataTable

                DTA = select_first_item()
                DTB = select_end_item()
                If chk_filterbarang_purch.Checked = False Then
                    cbo_filterbarang_purch1.EditValue = DTA.Rows(0).Item(0)
                    cbo_filterbarang_purch2.EditValue = DTB.Rows(0).Item(0)
                End If

                If chk_filtertgl_purch.Checked = True Then
                    Recalculate_COGS(cbo_filterbarang_purch1.EditValue, cbo_filterbarang_purch2.EditValue, tgl_purch1.Value, tgl_purch2.Value, 1)
                Else
                    Recalculate_COGS(cbo_filterbarang_purch1.EditValue, cbo_filterbarang_purch2.EditValue, tgl_purch1.Value, tgl_purch2.Value, 0)
                End If
                Rekapitulasi_HPP_Akhir(cbo_filterbarang_purch1.EditValue, cbo_filterbarang_purch2.EditValue)
                pathfilereport = Application.StartupPath & "\Report\LapHPPCalculated.rpt"
                Try
                    Dim da, da2 As New MySqlDataAdapter()
                    Dim ds, ds2 As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_hpp_calculated"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    Dim qryCompanies2 As String = "select * from lap_rekap_hpp_akhir_view"

                    da2.SelectCommand = New MySqlCommand(qryCompanies2, conn)
                    da2.Fill(ds2)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Subreports(0).SetDataSource(ds2.Tables(0))
                    cryRpt.Refresh()

                    ' cryRpt.Subreports(0).Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{general_ledger1.id_item} >= '" & Trim(cbo_filterbarang_purch1.EditValue) & "' and {general_ledger1.id_item} <= '" & Trim(cbo_filterbarang_purch2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filtertgl_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {general_ledger1.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {general_ledger1.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        Else
                            filter2 = "{general_ledger1.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {general_ledger1.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        End If
                    Else
                        filter2 = ""
                    End If

                    If filter1 <> "" Or filter2 <> "" Then
                        ReportFormula = filter1 + filter2
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub FormReportMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataGudang.DataTableWH' table. You can move, or remove it, as needed.
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        open_conn()
        clear_checked()
        fillComboBox()
        list_report()
    End Sub

    Private Sub fillComboBox()
        'Dim DTAkun As DataTable
        'DTAkun = getComboAccount()
        'cbo_supp_purch1.Properties.DataSource = DTAkun
        'cbo_supp_purch1.Properties.DisplayMember = "account_name"
        'cbo_supp_purch1.Properties.ValueMember = "id_account"
        'cbo_supp_purch1.Properties.PopulateColumns()
        'cbo_supp_purch1.Properties.View.Columns("id_account").Caption = "No Akun"
        'cbo_supp_purch1.Properties.View.Columns("account_name").Caption = "Nama Akun"
        'cbo_supp_purch1.Properties.View.OptionsView.ShowAutoFilterRow = True
        'cbo_supp_purch1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        'cbo_supp_purch2.Properties.DataSource = DTAkun
        'cbo_supp_purch2.Properties.DisplayMember = "account_name"
        'cbo_supp_purch2.Properties.ValueMember = "id_account"
        'cbo_supp_purch2.Properties.PopulateColumns()

        Dim DT As DataTable
        DT = getComboGudang()
        cbo_filterwh_purch1.Properties.DataSource = DT
        cbo_filterwh_purch1.Properties.DisplayMember = "warehouse_name"
        cbo_filterwh_purch1.Properties.ValueMember = "id_warehouse"
        cbo_filterwh_purch1.Properties.PopulateViewColumns()
        cbo_filterwh_purch1.Properties.View.Columns("id_warehouse").Caption = "Kode"
        cbo_filterwh_purch1.Properties.View.Columns("warehouse_name").Caption = "Gudang"
        cbo_filterwh_purch1.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_filterwh_purch1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        Dim DTItem As DataTable
        DTItem = getComboItem()
        cbo_filterbarang_purch1.Properties.DataSource = DTItem
        cbo_filterbarang_purch1.Properties.DisplayMember = "item_name"
        cbo_filterbarang_purch1.Properties.ValueMember = "id_item"
        cbo_filterbarang_purch1.Properties.PopulateViewColumns()
        cbo_filterbarang_purch1.Properties.View.Columns("id_item").Caption = "Kode Barang"
        cbo_filterbarang_purch1.Properties.View.Columns("item_name").Caption = "Nama Barang"
        cbo_filterbarang_purch1.Properties.View.Columns("id_barcode").Caption = "Barcode"
        cbo_filterbarang_purch1.Properties.View.Columns("mst_itemcat_nm").Caption = "Kategori"
        cbo_filterbarang_purch1.Properties.View.Columns("flag_buy").Visible = False
        cbo_filterbarang_purch1.Properties.View.Columns("flag_inv").Visible = False
        cbo_filterbarang_purch1.Properties.View.Columns("flag_sell").Visible = False
        cbo_filterbarang_purch1.Properties.View.Columns("sell_unit").Visible = False
        cbo_filterbarang_purch1.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_filterbarang_purch1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        cbo_filterbarang_purch2.Properties.DataSource = DTItem
        cbo_filterbarang_purch2.Properties.DisplayMember = "item_name"
        cbo_filterbarang_purch2.Properties.ValueMember = "id_item"
        cbo_filterbarang_purch2.Properties.PopulateViewColumns()
        cbo_filterbarang_purch2.Properties.View.Columns("id_item").Caption = "Kode Barang"
        cbo_filterbarang_purch2.Properties.View.Columns("item_name").Caption = "Nama Barang"
        cbo_filterbarang_purch2.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_filterbarang_purch2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub chk_filterkota_cust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filtersupp_purch.CheckedChanged
        open_conn()
        If chk_filtersupp_purch.Checked = True Then
            cbo_supp_purch1.Enabled = True
            cbo_supp_purch2.Enabled = True
        ElseIf chk_filtersupp_purch.Checked = False Then
            cbo_supp_purch1.Enabled = False
            cbo_supp_purch2.Enabled = False
        End If
    End Sub

    Private Sub rb_cust2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch2.CheckedChanged
        open_conn()
        If rb_purch2.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
            gb_filterwh_purch.Visible = True
        End If
    End Sub

    Private Sub rb_cust3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch3.CheckedChanged
        open_conn()
        If rb_purch3.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
            gb_filterwh_purch.Visible = False
        End If
    End Sub

    Private Sub rb_cust4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        'If rb_purch4.Checked = True Then
        '    gb_filtertgl_purch.Visible = False
        '    gb_filterbl_purch.Visible = False
        '    gb_filtersupp_purch.Visible = True
        '    gb_filterth_purch.Visible = True
        '    gb_filterbarang_purch.Visible = False
        'End If
    End Sub

    Private Sub rb_cust5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch5.CheckedChanged
        open_conn()
        If rb_purch3.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
            gb_filterwh_purch.Visible = False
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

    Private Sub rb_purch6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch6.CheckedChanged
        open_conn()
        If rb_purch6.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
            gb_filterwh_purch.Visible = False
        End If
    End Sub

    Private Sub rb_purch7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch7.CheckedChanged
        open_conn()
        If rb_purch7.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
            gb_filterwh_purch.Visible = False
        End If
    End Sub

    Private Sub chk_filterbarang_purch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filterbarang_purch.CheckedChanged
        open_conn()
        If chk_filterbarang_purch.Checked = True Then
            cbo_filterbarang_purch1.Enabled = True
            cbo_filterbarang_purch2.Enabled = True
        ElseIf chk_filterbarang_purch.Checked = False Then
            cbo_filterbarang_purch1.Enabled = False
            cbo_filterbarang_purch2.Enabled = False
        End If
    End Sub

    Private Sub chk_filtersupp_ap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        'If chk_filtersupp_ap.Checked = True Then
        '    cbo_supp_ap1.Enabled = True
        '    cbo_supp_ap2.Enabled = True
        'ElseIf chk_filtersupp_ap.Checked = False Then
        '    cbo_supp_ap1.Enabled = False
        '    cbo_supp_ap2.Enabled = False
        'End If
    End Sub

    Private Sub chk_filtertgl_ap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        'If chk_filtertgl_ap.Checked = True Then
        '    tgl_ap1.Enabled = True
        '    tgl_ap2.Enabled = True
        'ElseIf chk_filtertgl_ap.Checked = False Then
        '    tgl_ap1.Enabled = False
        '    tgl_ap2.Enabled = False
        'End If
    End Sub

    Private Sub rb_ap1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        'If rb_ap1.Checked = True Then
        '    gb_filtertgl_ap.Visible = True
        '    gb_filtersupp_ap.Visible = True
        '    gb_filterth_ap.Visible = False
        'End If
    End Sub

    Private Sub btn_ap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        'If rb_ap1.Checked = False And rb_ap2.Checked = False And rb_ap3.Checked = False And rb_ap4.Checked = False And rb_ap5.Checked = False And rb_ap6.Checked = False And rb_ap7.Checked = False Then
        '    MsgBox("Laporan Belum Dipilih", MsgBoxStyle.Information, "Warning")
        '    Exit Sub
        'End If
        'If rb_ap1.Checked = True Then

        '    Dim cryRpt As New ReportDocument
        '    Dim pathfilereport As String
        '    Dim ReportFormula As String
        '    Dim filter1, filter2 As String

        '    pathfilereport = Application.StartupPath & "\Report\LapPiutangPerSupplier.rpt"
        '    Try
        '        cryRpt.Load(pathfilereport)
        '        If chk_filtersupp_ap.Checked = True Then
        '            filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_ap2.EditValue) & "'"
        '        Else
        '            filter1 = ""
        '        End If

        '        If chk_filtertgl_ap.Checked = True Then
        '            If filter1 <> "" Then
        '                filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
        '            Else
        '                filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
        '            End If
        '        Else
        '            filter2 = ""
        '        End If

        '        If filter1 <> "" Or filter2 <> "" Then
        '            ReportFormula = filter1 + filter2
        '            cryRpt.RecordSelectionFormula = ReportFormula
        '        End If

        '        Dim LapDataCustomer_1 As New LapPembelian
        '        LapDataCustomer_1.Show()
        '        LapDataCustomer_1.MdiParent = MainMenu
        '        LapDataCustomer_1.WindowState = FormWindowState.Maximized
        '        With LapDataCustomer_1.CRviewer
        '            .ReportSource = cryRpt
        '            .ShowGroupTreeButton = False
        '            .ShowExportButton = True
        '            .DisplayGroupTree = False
        '        End With

        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try

        'ElseIf rb_ap2.Checked = True Then
        '    Dim cryRpt As New ReportDocument
        '    Dim pathfilereport As String
        '    Dim ReportFormula As String
        '    Dim filter1 As String

        '    pathfilereport = Application.StartupPath & "\Report\LapUmurPiutang.rpt"
        '    Try
        '        cryRpt.Load(pathfilereport)
        '        If chk_filtersupp_ap.Checked = True Then
        '            filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_cu} <= 'id_customer" & Trim(cbo_supp_ap2.EditValue) & "'"
        '        Else
        '            filter1 = ""
        '        End If


        '        If filter1 <> "" Then
        '            ReportFormula = filter1
        '            cryRpt.RecordSelectionFormula = ReportFormula
        '        End If

        '        Dim LapDataCustomer_1 As New LapPembelian
        '        LapDataCustomer_1.Show()
        '        LapDataCustomer_1.MdiParent = MainMenu
        '        LapDataCustomer_1.WindowState = FormWindowState.Maximized
        '        With LapDataCustomer_1.CRviewer
        '            .ReportSource = cryRpt
        '            .ShowGroupTreeButton = False
        '            .ShowExportButton = True
        '            .DisplayGroupTree = False
        '        End With

        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try

        'ElseIf rb_ap3.Checked = True Then
        '    Dim cryRpt As New ReportDocument
        '    Dim pathfilereport As String
        '    Dim ReportFormula As String
        '    Dim filter1, filter2 As String

        '    pathfilereport = Application.StartupPath & "\Report\LapHistoryBayarPiutang.rpt"
        '    Try
        '        cryRpt.Load(pathfilereport)
        '        If chk_filtersupp_ap.Checked = True Then
        '            filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_ap2.EditValue) & "'"
        '        Else
        '            filter1 = ""
        '        End If

        '        If chk_filtertgl_ap.Checked = True Then
        '            If filter1 <> "" Then
        '                filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
        '            Else
        '                filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
        '            End If
        '        Else
        '            filter2 = ""
        '        End If

        '        If filter1 <> "" Or filter2 <> "" Then
        '            ReportFormula = filter1 + filter2
        '            cryRpt.RecordSelectionFormula = ReportFormula
        '        End If

        '        Dim LapDataCustomer_1 As New LapPembelian
        '        LapDataCustomer_1.Show()
        '        LapDataCustomer_1.MdiParent = MainMenu
        '        LapDataCustomer_1.WindowState = FormWindowState.Maximized
        '        With LapDataCustomer_1.CRviewer
        '            .ReportSource = cryRpt
        '            .ShowGroupTreeButton = False
        '            .ShowExportButton = True
        '            .DisplayGroupTree = False
        '        End With

        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try

        'ElseIf rb_ap4.Checked = True Then
        '    Dim cryRpt As New ReportDocument
        '    Dim pathfilereport As String
        '    Dim ReportFormula As String
        '    Dim filter1, filter2 As String

        '    pathfilereport = Application.StartupPath & "\Report\LapPiutangLunas.rpt"
        '    Try
        '        cryRpt.Load(pathfilereport)
        '        If chk_filtersupp_ap.Checked = True Then
        '            filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_ap2.EditValue) & "'"
        '        Else
        '            filter1 = ""
        '        End If

        '        If chk_filtertgl_ap.Checked = True Then
        '            If filter1 <> "" Then
        '                filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
        '            Else
        '                filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
        '            End If
        '        Else
        '            filter2 = ""
        '        End If



        '        If filter1 <> "" Or filter2 <> "" Then
        '            ReportFormula = filter1 + filter2
        '            cryRpt.RecordSelectionFormula = ReportFormula
        '        End If

        '        Dim LapDataCustomer_1 As New LapPembelian
        '        LapDataCustomer_1.Show()
        '        LapDataCustomer_1.MdiParent = MainMenu
        '        LapDataCustomer_1.WindowState = FormWindowState.Maximized
        '        With LapDataCustomer_1.CRviewer
        '            .ReportSource = cryRpt
        '            .ShowGroupTreeButton = False
        '            .ShowExportButton = True
        '            .DisplayGroupTree = False
        '        End With

        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try

        'ElseIf rb_ap5.Checked = True Then
        '    Dim cryRpt As New ReportDocument
        '    Dim pathfilereport As String
        '    Dim ReportFormula As String
        '    Dim filter1 As String

        '    pathfilereport = Application.StartupPath & "\Report\LapRekapARPaymentTahun.rpt"
        '    Try
        '        cryRpt.Load(pathfilereport)
        '        If chk_filtersupp_purch.Checked = True Then
        '            filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
        '        Else
        '            filter1 = ""
        '        End If


        '        If filter1 <> "" Then
        '            ReportFormula = filter1
        '            cryRpt.RecordSelectionFormula = ReportFormula
        '        End If

        '        Dim LapDataCustomer_1 As New LapPembelian
        '        LapDataCustomer_1.Show()
        '        LapDataCustomer_1.MdiParent = MainMenu
        '        LapDataCustomer_1.WindowState = FormWindowState.Maximized
        '        With LapDataCustomer_1.CRviewer
        '            .ReportSource = cryRpt
        '            .ShowGroupTreeButton = False
        '            .ShowExportButton = True
        '            .DisplayGroupTree = False
        '        End With
        '        cryRpt.SetParameterValue(0, Year(th_ap.Value))

        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try

        'ElseIf rb_ap6.Checked = True Then

        '    Dim cryRpt As New ReportDocument
        '    Dim pathfilereport As String
        '    Dim ReportFormula As String
        '    Dim filter1 As String

        '    pathfilereport = Application.StartupPath & "\Report\LapRekapARBalanceTahun.rpt"
        '    Try
        '        cryRpt.Load(pathfilereport)
        '        If chk_filtersupp_purch.Checked = True Then
        '            filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
        '        Else
        '            filter1 = ""
        '        End If


        '        If filter1 <> "" Then
        '            ReportFormula = filter1
        '            cryRpt.RecordSelectionFormula = ReportFormula
        '        End If

        '        Dim LapDataCustomer_1 As New LapPembelian
        '        LapDataCustomer_1.Show()
        '        LapDataCustomer_1.MdiParent = MainMenu
        '        LapDataCustomer_1.WindowState = FormWindowState.Maximized
        '        With LapDataCustomer_1.CRviewer
        '            .ReportSource = cryRpt
        '            .ShowGroupTreeButton = False
        '            .ShowExportButton = True
        '            .DisplayGroupTree = False
        '        End With
        '        cryRpt.SetParameterValue(0, Year(th_ap.Value))

        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try

        'ElseIf rb_ap7.Checked = True Then

        '    Dim cryRpt As New ReportDocument
        '    Dim pathfilereport As String
        '    Dim ReportFormula As String
        '    Dim filter1, filter2 As String

        '    pathfilereport = Application.StartupPath & "\Report\LapPiutangJT.rpt"
        '    Try
        '        cryRpt.Load(pathfilereport)
        '        If chk_filtersupp_purch.Checked = True Then
        '            filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
        '        Else
        '            filter1 = ""
        '        End If

        '        If chk_filtertgl_ap.Checked = True Then
        '            If filter1 <> "" Then
        '                filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
        '            Else
        '                filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
        '            End If
        '        Else
        '            filter2 = ""
        '        End If

        '        If filter1 <> "" Or filter2 <> "" Then
        '            ReportFormula = filter1 + filter2
        '            cryRpt.RecordSelectionFormula = ReportFormula
        '        End If

        '        Dim LapDataCustomer_1 As New LapPembelian
        '        LapDataCustomer_1.Show()
        '        LapDataCustomer_1.MdiParent = MainMenu
        '        LapDataCustomer_1.WindowState = FormWindowState.Maximized
        '        With LapDataCustomer_1.CRviewer
        '            .ReportSource = cryRpt
        '            .ShowGroupTreeButton = False
        '            .ShowExportButton = True
        '            .DisplayGroupTree = False
        '        End With
        '        'cryRpt.SetParameterValue(0, Year(th_ap.Value))

        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try

        'End If


    End Sub

    Private Sub rb_ap3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        'If rb_ap3.Checked = True Then
        '    gb_filtertgl_ap.Visible = True
        '    gb_filtersupp_ap.Visible = True
        '    gb_filterth_ap.Visible = False
        'End If
    End Sub

    Private Sub rb_ap4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        '    If rb_ap4.Checked = True Then
        '        gb_filtertgl_ap.Visible = True
        '        gb_filtersupp_ap.Visible = True
        '        gb_filterth_ap.Visible = False
        '    End If
    End Sub

    Private Sub rb_ap2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        'If rb_ap2.Checked = True Then
        '    gb_filtertgl_ap.Visible = False
        '    gb_filtersupp_ap.Visible = True
        '    gb_filterth_ap.Visible = False
        'End If
    End Sub

    Private Sub rb_ap5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        'If rb_ap5.Checked = True Then
        '    gb_filtertgl_ap.Visible = False
        '    gb_filtersupp_ap.Visible = False
        '    gb_filterth_ap.Visible = True
        'End If
    End Sub

    Private Sub rb_ap6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        'If rb_ap6.Checked = True Then
        '    gb_filtertgl_ap.Visible = False
        '    gb_filtersupp_ap.Visible = False
        '    gb_filterth_ap.Visible = True
        'End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        If TabControl1.SelectedTabPage Is TabPage1 Then
            rb_purch1.Checked = True
            'ElseIf TabControl1.SelectedTab Is TabPage2 Then
            '    rb_ap1.Checked = True
        End If
    End Sub

    Private Sub rb_purch8_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_purch8.CheckedChanged
        open_conn()
        If rb_purch8.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
            gb_filterwh_purch.Visible = False
        End If
    End Sub

    Private Sub rb_purch9_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_purch9.CheckedChanged
        open_conn()
        If rb_purch9.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
            gb_filterwh_purch.Visible = False
        End If
    End Sub

    Private Sub chk_filtercust_cust_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub bln_cust1_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ListReport_SelectedValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ListReport_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ListReport_SelectedValueChanged1(sender As Object, e As System.EventArgs) Handles ListReport.SelectedValueChanged
        open_conn()
        If ListReport.SelectedValue = "MN_STOCK_ADJUSTMENT_REPORT" Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
            gb_filterwh_purch.Visible = False
        End If
        If ListReport.SelectedValue = "MN_STOCK_MUTATION_REPORT" Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
            gb_filterwh_purch.Visible = True
        End If
        If ListReport.SelectedValue = "MN_STOCK_CARD_COGS" Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
            gb_filterwh_purch.Visible = False
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class