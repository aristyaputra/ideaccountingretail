Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports MySql.Data.MySqlClient

Public Class FormReportPurch

    Private Sub list_report_purchase()
        Dim DT As DataTable
        DT = select_report_list(username, "MN_PURCHASE_REPORT")
        ListReportPurch.DisplayMember = "notes"
        ListReportPurch.ValueMember = "childkey"
        ListReportPurch.DataSource = DT
    End Sub

    Private Sub list_report_ap()
        Dim DT As DataTable
        DT = select_report_list(username, "MN_AP_REPORT")
        listreportap.DisplayMember = "notes"
        listreportap.ValueMember = "childkey"
        listreportap.DataSource = DT
    End Sub

    Private Sub clear_checked()
        open_conn()
        rb_ap1.Checked = False
        rb_ap2.Checked = False
        rb_ap3.Checked = False
        rb_ap4.Checked = False
        rb_ap5.Checked = False
        rb_ap6.Checked = False
        rb_ap7.Checked = False

        rb_purch1.Checked = False
        rb_purch2.Checked = False
        rb_purch3.Checked = False
        rb_purch5.Checked = False
        rb_purch6.Checked = False
        rb_purch7.Checked = False

        chk_filterbarang_purch.Checked = False
        cbo_filterbarang1.Enabled = False
        cbo_filterbarang2.Enabled = False

        chk_filterbl_purch.Checked = False
        bl_purch1.Enabled = False
        bl_purch2.Enabled = False

        chk_filtersupp_ap.Checked = False
        cbo_supp3.Enabled = False
        cbo_supp3.Enabled = False

        chk_filtersupp_purch.Checked = False
        cbo_supp1.Enabled = False
        cbo_supp2.Enabled = False

        chk_filtertgl_ap.Checked = False
        tgl_ap1.Enabled = False
        tgl_ap2.Enabled = False

        chk_filtertgl_purch.Checked = False
        tgl_purch1.Enabled = False
        tgl_purch2.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_purch2.Click
        open_conn()
        choose_report_purch(ListReportPurch.SelectedValue)
    End Sub

    Private Sub common_disable()
        open_conn()
        chk_filterbarang_purch.Checked = False
        chk_filterbl_purch.Checked = False
        chk_filtersupp_ap.Checked = False
        chk_filtersupp_purch.Checked = False
        chk_filtertgl_ap.Checked = False
        chk_filtertgl_purch.Checked = False
    End Sub


    Private Sub rb_cust1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch1.CheckedChanged
        open_conn()
        If rb_purch1.Checked = True Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False

        End If
        common_disable()
    End Sub

    Private Sub fillComboBox()
        Dim DTsupp As DataTable
        DTsupp = getComboSupplier()
        cbo_supp1.Properties.DataSource = DTsupp
        cbo_supp1.Properties.DisplayMember = "nama"
        cbo_supp1.Properties.ValueMember = "id_supplier"
        cbo_supp1.Properties.PopulateViewColumns()
        cbo_supp1.Properties.View.Columns("id_supplier").Caption = "Kode"
        cbo_supp1.Properties.View.Columns("nama").Caption = "Nama Pemasok"
        cbo_supp1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp2.Properties.DataSource = DTsupp
        cbo_supp2.Properties.DisplayMember = "nama"
        cbo_supp2.Properties.ValueMember = "id_supplier"
        cbo_supp2.Properties.PopulateViewColumns()
        cbo_supp2.Properties.View.Columns("id_supplier").Caption = "Kode"
        cbo_supp2.Properties.View.Columns("nama").Caption = "Nama Pemasok"
        cbo_supp2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp2.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp3.Properties.DataSource = DTsupp
        cbo_supp3.Properties.DisplayMember = "nama"
        cbo_supp3.Properties.ValueMember = "id_supplier"
        cbo_supp3.Properties.PopulateViewColumns()
        cbo_supp3.Properties.View.Columns("id_supplier").Caption = "Kode"
        cbo_supp3.Properties.View.Columns("nama").Caption = "Nama Pemasok"
        cbo_supp3.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp3.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp4.Properties.DataSource = DTsupp
        cbo_supp4.Properties.DisplayMember = "nama"
        cbo_supp4.Properties.ValueMember = "id_supplier"
        cbo_supp4.Properties.PopulateViewColumns()
        cbo_supp4.Properties.View.Columns("id_supplier").Caption = "Kode"
        cbo_supp4.Properties.View.Columns("nama").Caption = "Nama Pemasok"
        cbo_supp4.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp4.Properties.View.OptionsView.ShowAutoFilterRow = True

        Dim DTItem As DataTable
        DTItem = select_combo_item()

        cbo_filterbarang1.Properties.DataSource = DTItem
        cbo_filterbarang1.Properties.DisplayMember = "item_name"
        cbo_filterbarang1.Properties.ValueMember = "id_item"
        cbo_filterbarang1.Properties.PopulateViewColumns()
        cbo_filterbarang1.Properties.View.Columns("id_item").Caption = "Kode"
        cbo_filterbarang1.Properties.View.Columns("item_name").Caption = "Nama Item"
        cbo_filterbarang1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_filterbarang1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_filterbarang2.Properties.DataSource = DTItem
        cbo_filterbarang2.Properties.DisplayMember = "item_name"
        cbo_filterbarang2.Properties.ValueMember = "id_item"
        cbo_filterbarang2.Properties.PopulateViewColumns()
        cbo_filterbarang2.Properties.View.Columns("id_item").Caption = "Kode"
        cbo_filterbarang2.Properties.View.Columns("item_name").Caption = "Nama Item"
        cbo_filterbarang2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_filterbarang2.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub FormReportPurch_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FormReportPurch_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub FormReportMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.MdiParent = MainMenu
        Me.WindowState = FormWindowState.Maximized
        TabControl1.SelectedTabPage = TabPage2
        TabControl1.SelectedTabPage = TabPage1
        clear_checked()
        'LoadComboBox_MtgcComboBoxSupp()
        '   LoadComboBox_MtgcComboBoxItem()
        list_report_purchase()
        list_report_ap()
        fillComboBox()
    End Sub

    Private Sub choose_report_purch(ByVal value_choose As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False

            If value_choose = "MN_LAP_RO" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2, filter3 As String

                pathfilereport = Application.StartupPath & "\Report\LapPermintaanBarang.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_ro_report"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp1.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filterbarang_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.id_item} >= '" & cbo_filterbarang1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang2.EditValue & "'"
                        Else
                            filter2 = "{view_lap_datacustomer.id_item} >= '" & cbo_filterbarang1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang2.EditValue & "'"
                        End If
                    Else
                        filter2 = ""
                    End If

                    If chk_filtertgl_purch.Checked = True Then
                        If filter2 <> "" Or filter1 <> "" Then
                            filter3 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        Else
                            filter3 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        End If
                    Else
                        filter3 = ""
                    End If

                    If filter1 <> "" Or filter2 <> "" Or filter3 <> "" Then
                        ReportFormula = filter1 + filter2 + filter3
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Daftar Permintaan Pembelian"
                    ' LapDataCustomer_1.CRviewer.Refresh()
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try

            ElseIf value_choose = "MN_LAP_PO" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2, filter3 As String

                pathfilereport = Application.StartupPath & "\Report\LapPurchaseOrder.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_po_report"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp1.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filterbarang_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.id_item} >= '" & cbo_filterbarang1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang2.EditValue & "'"
                        Else
                            filter2 = "{view_lap_datacustomer.id_item} >= '" & cbo_filterbarang1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang2.EditValue & "'"
                        End If
                    Else
                        filter2 = ""
                    End If

                    If chk_filtertgl_purch.Checked = True Then
                        If filter2 <> "" Or filter1 <> "" Then
                            filter3 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        Else
                            filter3 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        End If
                    Else
                        filter3 = ""
                    End If

                    If filter1 <> "" Or filter2 <> "" Or filter3 <> "" Then
                        ReportFormula = filter1 + filter2 + filter3
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Daftar PO"
                    ' LapDataCustomer_1.CRviewer.Refresh()
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try


            ElseIf value_choose = "MN_LAP_REC_ITEM" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2, filter3 As String

                pathfilereport = Application.StartupPath & "\Report\LapPenerimaanBarang.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_recitem_report"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp1.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filterbarang_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.id_item} >= '" & cbo_filterbarang1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang2.EditValue & "'"
                        Else
                            filter2 = "{view_lap_datacustomer.id_item} >= '" & cbo_filterbarang1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang2.EditValue & "'"
                        End If
                    Else
                        filter2 = ""
                    End If

                    If chk_filtertgl_purch.Checked = True Then
                        If filter2 <> "" Or filter1 <> "" Then
                            filter3 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        Else
                            filter3 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                        End If
                    Else
                        filter3 = ""
                    End If

                    If filter1 <> "" Or filter2 <> "" Or filter3 <> "" Then
                        ReportFormula = filter1 + filter2 + filter3
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Daftar Penerimaan Barang"
                    ' LapDataCustomer_1.CRviewer.Refresh()
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try

            ElseIf value_choose = "MN_LAP_PURCH" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapPembelianStandar.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_lap_pembelian_std"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp1.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp2.EditValue) & "'"
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
                    LapDataCustomer_1.Text = "Laporan Pembelian Standar"
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With
                    'LapDataCustomer_1.CRviewer.Refresh()
                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try

            ElseIf value_choose = "MN_LAP_PURCH_GROUP_SUPP" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapPembelianGrupSupplier.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_lap_pembelian_std"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp1.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp2.EditValue) & "'"
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
                    LapDataCustomer_1.Text = "Laporan Pembelian Grup Pemasok"
                    ' LapDataCustomer_1.CRviewer.Refresh()
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try

            ElseIf value_choose = "MN_LAP_PURCH_GROUP_PERIOD" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1 As String

                pathfilereport = Application.StartupPath & "\Report\LapRekapPembelianTahun.rpt"
                Try
                    Dim LapDataCustomer_1 As New LapPembelian

                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_rekappemb_bln_supp(" & Year(th_purch.Value) & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Year(th_purch.Value))
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp1.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If filter1 <> "" Then
                        ReportFormula = filter1
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Rekapitulasi Pembelian"
                    'LapDataCustomer_1.CRviewer.Refresh()

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try

            ElseIf value_choose = "MN_LAP_BUYPRICE_HISTORY" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapPerubahanHargaBeli.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_perubahan_hargabeli(0)"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Year(th_purch.Value))
                    If chk_filtertgl_purch.Checked = True Then
                        filter1 = "{sp_rpt_perubahan_hargabeli1.tanggal} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {sp_rpt_perubahan_hargabeli1.tanggal} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                    Else
                        filter1 = ""
                    End If

                    If chk_filterbarang_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {sp_rpt_perubahan_hargabeli1.id_item} >= '" & cbo_filterbarang1.EditValue & "' and {sp_rpt_perubahan_hargabeli1.id_item} <= '" & cbo_filterbarang2.EditValue & "'"
                        Else
                            filter2 = "{sp_rpt_perubahan_hargabeli1.id_item} >= '" & cbo_filterbarang1.EditValue & "' and {sp_rpt_perubahan_hargabeli1.id_item} <= '" & cbo_filterbarang2.EditValue & "'"
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
                    LapDataCustomer_1.Text = "Laporan Histori Harga"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With


                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try

            ElseIf value_choose = "MN_LAP_PURCH_RANKING" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapRankingPembPerBarang.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "select * from view_lap_ranking_pembperbarang"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtertgl_purch.Checked = True Then
                        filter1 = "{view_lap_ranking_pembperbarang1.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_ranking_pembperbarang1.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                    Else
                        filter1 = ""
                    End If

                    If chk_filterbarang_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_ranking_pembperbarang1.id_item} >= '" & cbo_filterbarang1.EditValue & "' and {view_lap_ranking_pembperbarang1.id_item} <= '" & cbo_filterbarang2.EditValue & "'"
                        Else
                            filter2 = "{view_lap_ranking_pembperbarang1.id_item} >= '" & cbo_filterbarang1.EditValue & "' and {view_lap_ranking_pembperbarang1.id_item} <= '" & cbo_filterbarang2.EditValue & "'"
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
                    LapDataCustomer_1.Text = "Laporan Ranking Pembelian"
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With
                    'cryRpt.SetParameterValue(0, Year(th_purch.Value))

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try

            ElseIf value_choose = "MN_LAP_PURCH_GRAPHIC" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapRekapPembelianTahunGrafik.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_rekappemb_bln_supp(" & Year(th_purch.Value) & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Year(th_purch.Value))
                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    'LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Grafik Pembelian"
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With


                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try

            End If

        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub choose_report_ap(ByVal value_choose As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False

            If value_choose = "MN_LAP_AP_CARD" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapHutangPerSupplier.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "select * from view_laphutang_per_supplier"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_ap.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp3.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp4.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filtertgl_ap.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
                        Else
                            filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
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
                    LapDataCustomer_1.Text = "Laporan Hutang grup Supplier"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            ElseIf value_choose = "MN_LAP_AP_AGING" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1 As String

                pathfilereport = Application.StartupPath & "\Report\LapUmurHutang.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_lapumurhutang(0)"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, 0)
                    If chk_filtersupp_ap.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp3.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp4.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If


                    If filter1 <> "" Then
                        ReportFormula = filter1
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Umur Hutang"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With


                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try

            ElseIf value_choose = "MN_LAP_APPAYMENT_HISTORY" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapHistoryBayarHutang.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "select * from view_lap_pemby_hutang"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_ap.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp3.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp4.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filtertgl_ap.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
                        Else
                            filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
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
                    LapDataCustomer_1.Text = "Laporan Histori Pembayaran Hutang"
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try

            ElseIf value_choose = "MN_LAP_APPAYMENT_PAIDOFF" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapHutangLunas.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "select * from view_lap_hutang_lunas"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_ap.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp3.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp4.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filtertgl_ap.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
                        Else
                            filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
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
                    LapDataCustomer_1.Text = "Laporan Pelunasan Hutang"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try


            ElseIf value_choose = "MN_LAP_APPAYMENT_RECAP" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1 As String

                pathfilereport = Application.StartupPath & "\Report\LapRekapAPPaymentTahun.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_appayment_bln_supp(" & Year(th_ap.Value) & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Year(th_ap.Value))
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp1.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If


                    If filter1 <> "" Then
                        ReportFormula = filter1
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Rekapitulasi"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With


                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try


            ElseIf value_choose = "MN_LAP_APBALANCE_RECAP" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1 As String

                pathfilereport = Application.StartupPath & "\Report\LapRekapAPBalanceTahun.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_apbalance_bln_supp(" & Year(th_ap.Value) & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Year(th_ap.Value))
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp1.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If


                    If filter1 <> "" Then
                        ReportFormula = filter1
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Rekapitulasi"
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With


                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try


            ElseIf value_choose = "MN_LAP_EST_APDUEDATE" Then

                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapHutangJT.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "select * from view_hutang_jt"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_ap.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_supplier} >= '" & Trim(cbo_supp3.EditValue) & "' and {view_lap_datacustomer.id_supplier} <= '" & Trim(cbo_supp4.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filtertgl_ap.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
                        Else
                            filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
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
                    LapDataCustomer_1.Text = "Laporan Estimasi Hutang Jatuh Tempo"
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With
                    'cryRpt.SetParameterValue(0, Year(th_ap.Value))

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try


            End If

        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub


    'Private Sub LoadComboBox_MtgcComboBoxSupp()
    '    open_conn()
    '    Dim dtLoading As New DataTable("UsStates")
    '    dtLoading = select_combo_supplier()

    '    cbo_supp_purch1.SelectedIndex = -1
    '    cbo_supp_purch1.Items.Clear()
    '    cbo_supp_purch1.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
    '    cbo_supp_purch1.SourceDataString = New String(1) {"id_supplier", "name"}
    '    cbo_supp_purch1.SourceDataTable = dtLoading
    '    cbo_supp_purch1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList

    '    cbo_supp_purch2.SelectedIndex = -1
    '    cbo_supp_purch2.Items.Clear()
    '    cbo_supp_purch2.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
    '    cbo_supp_purch2.SourceDataString = New String(1) {"id_supplier", "name"}
    '    cbo_supp_purch2.SourceDataTable = dtLoading
    '    cbo_supp_purch2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList

    '    cbo_supp_ap1.SelectedIndex = -1
    '    cbo_supp_ap1.Items.Clear()
    '    cbo_supp_ap1.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
    '    cbo_supp_ap1.SourceDataString = New String(1) {"id_supplier", "name"}
    '    cbo_supp_ap1.SourceDataTable = dtLoading
    '    cbo_supp_ap1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList

    '    cbo_supp_ap2.SelectedIndex = -1
    '    cbo_supp_ap2.Items.Clear()
    '    cbo_supp_ap2.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
    '    cbo_supp_ap2.SourceDataString = New String(1) {"id_supplier", "name"}
    '    cbo_supp_ap2.SourceDataTable = dtLoading
    '    cbo_supp_ap2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList

    'End Sub


    'Private Sub LoadComboBox_MtgcComboBoxItem()
    '    open_conn()
    '    Dim dtLoading As New DataTable("UsStates")
    '    dtLoading = select_combo_item()

    '    cbo_filterbarang1.SelectedIndex = -1
    '    cbo_filterbarang1.Items.Clear()
    '    cbo_filterbarang1.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
    '    cbo_filterbarang1.SourceDataString = New String(1) {"id_item", "item_name"}
    '    cbo_filterbarang1.SourceDataTable = dtLoading
    '    cbo_filterbarang1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList

    '    cbo_filterbarang2.SelectedIndex = -1
    '    cbo_filterbarang2.Items.Clear()
    '    cbo_filterbarang2.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
    '    cbo_filterbarang2.SourceDataString = New String(1) {"id_item", "item_name"}
    '    cbo_filterbarang2.SourceDataTable = dtLoading
    '    cbo_filterbarang2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    'End Sub

    Private Sub chk_filterkota_cust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filtersupp_purch.CheckedChanged
        open_conn()
        If chk_filtersupp_purch.Checked = True Then
            cbo_supp1.Enabled = True
            cbo_supp2.Enabled = True
        ElseIf chk_filtersupp_purch.Checked = False Then
            cbo_supp1.Enabled = False
            cbo_supp2.Enabled = False
        End If
    End Sub

    Private Sub rb_cust2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch2.CheckedChanged
        open_conn()
        If rb_purch2.Checked = True Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub rb_cust3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch3.CheckedChanged
        open_conn()
        If rb_purch3.Checked = True Then
            gb_filtersupp_purch.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = True
            gb_filterbarang_purch.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub rb_cust4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        If rb_purch5.Checked = True Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
        End If
        common_disable()
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
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
        End If
        common_disable()
    End Sub

    Private Sub rb_purch7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch7.CheckedChanged
        open_conn()
        If rb_purch7.Checked = True Then
            gb_filtersupp_purch.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = True
            gb_filterbarang_purch.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub chk_filterbarang_purch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chk_filtersupp_ap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_filtersupp_ap.CheckedChanged
        open_conn()
        If chk_filtersupp_ap.Checked = True Then
            cbo_supp3.Enabled = True
            cbo_supp4.Enabled = True
        ElseIf chk_filtersupp_ap.Checked = False Then
            cbo_supp3.Enabled = False
            cbo_supp4.Enabled = False
        End If
    End Sub

    Private Sub chk_filtertgl_ap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_filtertgl_ap.CheckedChanged
        open_conn()
        If chk_filtertgl_ap.Checked = True Then
            tgl_ap1.Enabled = True
            tgl_ap2.Enabled = True
        ElseIf chk_filtertgl_ap.Checked = False Then
            tgl_ap1.Enabled = False
            tgl_ap2.Enabled = False
        End If
    End Sub

    Private Sub rb_ap1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_ap1.CheckedChanged
        open_conn()
        If rb_ap1.Checked = True Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub btn_ap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ap.Click
        open_conn()
        choose_report_ap(listreportap.SelectedValue)
    End Sub

    Private Sub rb_ap3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap3.CheckedChanged
        open_conn()
        If rb_ap3.Checked = True Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub rb_ap4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap4.CheckedChanged
        open_conn()
        If rb_ap4.Checked = True Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub rb_ap2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap2.CheckedChanged
        open_conn()
        If rb_ap2.Checked = True Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub rb_ap5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap5.CheckedChanged
        open_conn()
        If rb_ap5.Checked = True Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = False
            gb_filterth_ap.Visible = True
        End If
        common_disable()
    End Sub

    Private Sub rb_ap6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap6.CheckedChanged
        open_conn()
        If rb_ap6.Checked = True Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = False
            gb_filterth_ap.Visible = True
        End If
        common_disable()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        If TabControl1.SelectedTabPage Is TabPage1 Then
            rb_purch1.Checked = True
        ElseIf TabControl1.SelectedTabPage Is TabPage2 Then
            rb_ap1.Checked = True
        End If
    End Sub

    Private Sub cbo_supp_purch1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_supp_purch1.Click
        open_conn()
        cbo_supp_purch1.DroppedDown = True
    End Sub

    Private Sub cbo_supp_purch2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_supp_purch2.Click
        open_conn()
        cbo_supp_purch2.DroppedDown = True
    End Sub

    'Private Sub cbo_supp_ap1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    cbo_supp_ap1.DroppedDown = True
    'End Sub

    'Private Sub cbo_supp_ap2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    cbo_supp_ap2.DroppedDown = True
    'End Sub

    Private Sub cbo_filterbarang1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbo_filterbarang2_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rb_purch8_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_purch8.CheckedChanged
        open_conn()
        If rb_purch8.Checked = True Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True

        End If
        common_disable()
    End Sub

    Private Sub rb_purch9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch9.CheckedChanged
        open_conn()
        If rb_purch9.Checked = True Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True

        End If
        common_disable()
    End Sub

    Private Sub rb_purch10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch10.CheckedChanged
        open_conn()
        If rb_purch10.Checked = True Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True

        End If
        common_disable()
    End Sub

    Private Sub rb_ap7_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap7.CheckedChanged
        open_conn()
        If rb_ap6.Checked = True Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles gb_filtertgl_purch.Enter

    End Sub

    Private Sub rb_purch1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub chk_filtersupp_purch_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub NavBarGroupControlContainer2_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub ListReportPurch_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListReportPurch.SelectedValueChanged
        open_conn()
        If ListReportPurch.SelectedValue = "MN_LAP_RO" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
        ElseIf ListReportPurch.SelectedValue = "MN_LAP_PO" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
        ElseIf ListReportPurch.SelectedValue = "MN_LAP_REC_ITEM" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
        ElseIf ListReportPurch.SelectedValue = "MN_LAP_PURCH" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
        ElseIf ListReportPurch.SelectedValue = "MN_LAP_PURCH_GROUP_SUPP" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
        ElseIf ListReportPurch.SelectedValue = "MN_LAP_PURCH_GROUP_PERIOD" Then
            gb_filtersupp_purch.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = False
            gb_filterth_purch.Visible = True
            gb_filterbarang_purch.Visible = False
        ElseIf ListReportPurch.SelectedValue = "MN_LAP_BUYPRICE_HISTORY" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
        ElseIf ListReportPurch.SelectedValue = "MN_LAP_PURCH_RANKING" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
        ElseIf ListReportPurch.SelectedValue = "MN_LAP_PURCH_GRAPHIC" Then
            gb_filtersupp_purch.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = False
            gb_filterth_purch.Visible = True
            gb_filterbarang_purch.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub listreportap_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles listreportap.SelectedValueChanged
        open_conn()
        If listreportap.SelectedValue = "MN_LAP_AP_CARD" Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        ElseIf listreportap.SelectedValue = "MN_LAP_AP_AGING" Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        ElseIf listreportap.SelectedValue = "MN_LAP_APPAYMENT_HISTORY" Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        ElseIf listreportap.SelectedValue = "MN_LAP_APPAYMENT_PAIDOFF" Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        ElseIf listreportap.SelectedValue = "MN_LAP_APPAYMENT_RECAP" Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = False
            gb_filterth_ap.Visible = True
        ElseIf listreportap.SelectedValue = "MN_LAP_APBALANCE_RECAP" Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = False
            gb_filterth_ap.Visible = True
        ElseIf listreportap.SelectedValue = "MN_LAP_EST_APDUEDATE" Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub chk_filterbarang_purch_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles chk_filterbarang_purch.CheckedChanged
        If chk_filterbarang_purch.Checked = True Then
            cbo_filterbarang1.Enabled = True
            cbo_filterbarang2.Enabled = True
        Else
            cbo_filterbarang1.Enabled = False
            cbo_filterbarang2.Enabled = False
        End If
    End Sub

    Private Sub gb_filterth_ap_Enter(sender As System.Object, e As System.EventArgs) Handles gb_filterth_ap.Enter

    End Sub
End Class