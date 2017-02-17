Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports MySql.Data.MySqlClient

Public Class FormReportSales

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
        cbo_filterbarang_purch1.Enabled = False
        cbo_filterbarang_purch2.Enabled = False
        '  chk_kota.Enabled = False
        cbo_kota1.Enabled = False
        cbo_kota2.Enabled = False

        chk_filterbl_purch.Checked = False
        bl_purch1.Enabled = False
        bl_purch2.Enabled = False

        chk_filtersupp_ap.Checked = False
        cbo_supp_ap1.Enabled = False
        cbo_supp_ap2.Enabled = False

        chk_filtersupp_purch.Checked = False
        cbo_supp_purch1.Enabled = False
        cbo_supp_purch2.Enabled = False

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

    Private Sub rb_cust1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch1.CheckedChanged
        open_conn()
        If rb_purch1.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
        End If
    End Sub

    Private Sub FormReportSales_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FormReportSales_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub fillComboBox()
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
        cbo_filterbarang_purch1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_filterbarang_purch1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_filterbarang_purch2.Properties.DataSource = DTItem
        cbo_filterbarang_purch2.Properties.DisplayMember = "item_name"
        cbo_filterbarang_purch2.Properties.ValueMember = "id_item"
        cbo_filterbarang_purch2.Properties.PopulateViewColumns()
        cbo_filterbarang_purch2.Properties.View.Columns("id_item").Caption = "Kode Barang"
        cbo_filterbarang_purch2.Properties.View.Columns("item_name").Caption = "Nama Barang"
        cbo_filterbarang_purch2.Properties.View.Columns("id_barcode").Caption = "Barcode"
        cbo_filterbarang_purch2.Properties.View.Columns("mst_itemcat_nm").Caption = "Kategori"
        cbo_filterbarang_purch2.Properties.View.Columns("flag_buy").Visible = False
        cbo_filterbarang_purch2.Properties.View.Columns("flag_inv").Visible = False
        cbo_filterbarang_purch2.Properties.View.Columns("flag_sell").Visible = False
        cbo_filterbarang_purch2.Properties.View.Columns("sell_unit").Visible = False
        cbo_filterbarang_purch2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_filterbarang_purch2.Properties.View.OptionsView.ShowAutoFilterRow = True

        Dim DTKota As DataTable
        DTKota = getComboCityAll()
        cbo_kota1.Properties.DataSource = DTKota
        cbo_kota1.Properties.DisplayMember = "city_name"
        cbo_kota1.Properties.ValueMember = "city_code"
        cbo_kota1.Properties.PopulateViewColumns()
        cbo_kota1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_kota1.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_kota1.Properties.View.Columns("city_code").Caption = "Kode"
        cbo_kota1.Properties.View.Columns("city_name").Caption = "Kota"

        cbo_kota2.Properties.DataSource = DTKota
        cbo_kota2.Properties.DisplayMember = "city_name"
        cbo_kota2.Properties.ValueMember = "city_code"
        cbo_kota2.Properties.PopulateViewColumns()
        cbo_kota2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_kota2.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_kota2.Properties.View.Columns("city_code").Caption = "Kode"
        cbo_kota2.Properties.View.Columns("city_name").Caption = "Kota"

        Dim DTCustomer As DataTable
        DTCustomer = getComboCustomer()
        cbo_supp_purch1.Properties.DataSource = DTCustomer
        cbo_supp_purch1.Properties.DisplayMember = "Nama"
        cbo_supp_purch1.Properties.ValueMember = "id_customer"
        cbo_supp_purch1.Properties.PopulateViewColumns()
        cbo_supp_purch1.Properties.View.Columns("id_customer").Caption = "Kode"
        cbo_supp_purch1.Properties.View.Columns("Nama").Caption = "Pelanggan"
        cbo_supp_purch1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp_purch1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp_purch2.Properties.DataSource = DTCustomer
        cbo_supp_purch2.Properties.DisplayMember = "Nama"
        cbo_supp_purch2.Properties.ValueMember = "id_customer"
        cbo_supp_purch2.Properties.PopulateViewColumns()
        cbo_supp_purch2.Properties.View.Columns("id_customer").Caption = "Kode"
        cbo_supp_purch2.Properties.View.Columns("Nama").Caption = "Pelanggan"
        cbo_supp_purch2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp_purch2.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp_ap1.Properties.DataSource = DTCustomer
        cbo_supp_ap1.Properties.DisplayMember = "Nama"
        cbo_supp_ap1.Properties.ValueMember = "id_customer"
        cbo_supp_ap1.Properties.PopulateViewColumns()
        cbo_supp_ap1.Properties.View.Columns("id_customer").Caption = "Kode"
        cbo_supp_ap1.Properties.View.Columns("Nama").Caption = "Pelanggan"
        cbo_supp_ap1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp_ap1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp_ap2.Properties.DataSource = DTCustomer
        cbo_supp_ap2.Properties.DisplayMember = "Nama"
        cbo_supp_ap2.Properties.ValueMember = "id_customer"
        cbo_supp_ap2.Properties.PopulateViewColumns()
        cbo_supp_ap2.Properties.View.Columns("id_customer").Caption = "Kode"
        cbo_supp_ap2.Properties.View.Columns("Nama").Caption = "Pelanggan"
        cbo_supp_ap2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp_ap2.Properties.View.OptionsView.ShowAutoFilterRow = True

    End Sub

    Private Sub FormReportMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        TabControl1.SelectedTabPage = TabPage2
        TabControl1.SelectedTabPage = TabPage1
        clear_checked()
        list_report_purchase()
        list_report_ap()
        fillComboBox()

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
            gb_filtertgl_purch.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
        End If
    End Sub

    Private Sub rb_cust3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch3.CheckedChanged
        open_conn()
        If rb_purch3.Checked = True Then
            gb_filtertgl_purch.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = True
            gb_filterbarang_purch.Visible = False
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
        If rb_purch5.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
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
            gb_filterbarang_purch.Visible = True
        End If
    End Sub

    Private Sub rb_purch7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch7.CheckedChanged
        open_conn()
        If rb_purch7.Checked = True Then
            gb_filtertgl_purch.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = False
            gb_filterth_purch.Visible = True
            gb_filterbarang_purch.Visible = False
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

    Private Sub chk_filtersupp_ap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_filtersupp_ap.CheckedChanged
        open_conn()
        If chk_filtersupp_ap.Checked = True Then
            cbo_supp_ap1.Enabled = True
            cbo_supp_ap2.Enabled = True
        ElseIf chk_filtersupp_ap.Checked = False Then
            cbo_supp_ap1.Enabled = False
            cbo_supp_ap2.Enabled = False
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
    End Sub

    Private Sub btn_ap2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ap2.Click
        open_conn()
        choose_report_ar(listreportap.SelectedValue)

    End Sub

    Private Sub rb_ap3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap3.CheckedChanged
        open_conn()
        If rb_ap3.Checked = True Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
    End Sub

    Private Sub rb_ap4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap4.CheckedChanged
        open_conn()
        If rb_ap4.Checked = True Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
    End Sub

    Private Sub rb_ap2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap2.CheckedChanged
        open_conn()
        If rb_ap2.Checked = True Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
    End Sub

    Private Sub rb_ap5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap5.CheckedChanged
        open_conn()
        If rb_ap5.Checked = True Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = False
            gb_filterth_ap.Visible = True
        End If
    End Sub

    Private Sub rb_ap6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_ap6.CheckedChanged
        open_conn()
        If rb_ap6.Checked = True Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = False
            gb_filterth_ap.Visible = True
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        If TabControl1.SelectedTabPage Is TabPage1 Then
            rb_purch1.Checked = True
        ElseIf TabControl1.SelectedTabPage Is TabPage2 Then
            rb_ap1.Checked = True
        End If
    End Sub

    Private Sub rb_purch9_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_purch9.CheckedChanged
        open_conn()
        If rb_purch9.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
        End If
    End Sub

    Private Sub rb_purch10_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_purch10.CheckedChanged
        open_conn()
        If rb_purch10.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
        End If
    End Sub

    Private Sub rb_purch8_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub rb_purch1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub chk_filtersupp_purch_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cbo_supp_purch1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cbo_supp_purch2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub list_report_purchase()
        Dim DT As DataTable
        DT = select_report_list(username, "MN_LAPORAN_JUAL")
        ListReportPurch.DisplayMember = "notes"
        ListReportPurch.ValueMember = "childkey"
        ListReportPurch.DataSource = DT
    End Sub

    Private Sub list_report_ap()
        Dim DT As DataTable
        DT = select_report_list(username, "MN_LAPORAN_PIUTANG")
        listreportap.DisplayMember = "notes"
        listreportap.ValueMember = "childkey"
        listreportap.DataSource = DT
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub ListReportPurch_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListReportPurch.SelectedValueChanged
        open_conn()
        If ListReportPurch.SelectedValue = "MN_LAPORAN_SO" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
            gb_filterkota_purch.Visible = False
        ElseIf ListReportPurch.SelectedValue = "MN_LAPORAN_DO" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
            gb_filterkota_purch.Visible = False
        ElseIf ListReportPurch.SelectedValue = "MN_LAPORAN_SALES_STD" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
            gb_filterkota_purch.Visible = False
        ElseIf ListReportPurch.SelectedValue = "MN_LAPORAN_SALES_GROUP" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
            gb_filterkota_purch.Visible = False
        ElseIf ListReportPurch.SelectedValue = "MN_LAPORAN_SALES_RECAP" Then
            gb_filtersupp_purch.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = False
            gb_filterth_purch.Visible = True
            gb_filterbarang_purch.Visible = False
            gb_filterkota_purch.Visible = False
        ElseIf ListReportPurch.SelectedValue = "MN_LAPORAN_SALES_RANK" Then
            gb_filtersupp_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = False
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = True
            gb_filterkota_purch.Visible = False
        ElseIf ListReportPurch.SelectedValue = "MN_LAPORAN_SALES_GRAFIK" Then
            gb_filtersupp_purch.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = False
            gb_filterth_purch.Visible = True
            gb_filterbarang_purch.Visible = False
            gb_filterkota_purch.Visible = False
        ElseIf ListReportPurch.SelectedValue = "MN_LAPORAN_KOMISI_SALESMAN" Then
            gb_filtersupp_purch.Visible = False
            gb_filterbl_purch.Visible = False
            gb_filtertgl_purch.Visible = True
            gb_filterth_purch.Visible = False
            gb_filterbarang_purch.Visible = False
            gb_filterkota_purch.Visible = True
        End If
        common_disable()

    End Sub

    Private Sub choose_report_ar(ByVal value_choose As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False

            If value_choose = "MN_LAPORAN_PIUTANG_SUPPLIER" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapPiutangPerSupplier.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_lappiutang_per_cust"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_ap.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_ap2.EditValue) & "'"
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
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Piutang"
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
            ElseIf value_choose = "MN_LAPORAN_UMUR_PIUTANG" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1 As String

                pathfilereport = Application.StartupPath & "\Report\LapUmurPiutang.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_lapumurpiutang(0)"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, 0)
                    If chk_filtersupp_ap.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= 'id_customer" & Trim(cbo_supp_ap2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If


                    If filter1 <> "" Then
                        ReportFormula = filter1
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    '   LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Umur Piutang"
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
            ElseIf value_choose = "MN_LAPORAN_PEMBAYARAN_PIUTANG" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapHistoryBayarPiutang.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "select * from view_lap_pemby_piutang"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_ap.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_ap2.EditValue) & "'"
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
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Pembayaran Piutang"
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

            ElseIf value_choose = "MN_LAPORAN_PELUNASAN_PIUTANG" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapPiutangLunas.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "select * from view_lap_piutang_lunas"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_ap.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_ap2.EditValue) & "'"
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
                    '   LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Pelunasan Piutang"
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

            ElseIf value_choose = "MN_LAPORAN_PEMBAYARAN_PER_PERIOD" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1 As String

                pathfilereport = Application.StartupPath & "\Report\LapRekapARPaymentTahun.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_arpayment_bln_supp(" & Year(th_ap.Value) & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Year(th_ap.Value))
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If


                    If filter1 <> "" Then
                        ReportFormula = filter1
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Rekapitulasi Piutang"
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
            ElseIf value_choose = "MN_LAPORAN_SALDO_PER_PERIOD" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1 As String

                pathfilereport = Application.StartupPath & "\Report\LapRekapARBalanceTahun.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_arbalance_bln_supp(" & Year(th_ap.Value) & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Year(th_ap.Value))
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If


                    If filter1 <> "" Then
                        ReportFormula = filter1
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Rekapitulasi Saldo Piutang"
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
            ElseIf value_choose = "MN_LAPORAN_ESTIMASI_JATUH_TEMPO" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapPiutangJT.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "select * from view_piutang_jt"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
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
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Piutang Jatuh Tempo"
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
    Private Sub choose_report_purch(ByVal value_choose As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False

            If value_choose = "MN_LAPORAN_SO" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2, filter3 As String

                pathfilereport = Application.StartupPath & "\Report\LapSalesOrder.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_so_report"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filterbarang_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.id_item} >= '" & cbo_filterbarang_purch1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang_purch2.EditValue & "'"
                        Else
                            filter2 = "{view_lap_datacustomer.id_item} >= '" & cbo_filterbarang_purch1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang_purch2.EditValue & "'"
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
                    LapDataCustomer_1.Text = "Laporan Sales Order"
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
            ElseIf value_choose = "MN_LAPORAN_DO" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2, filter3 As String

                pathfilereport = Application.StartupPath & "\Report\LapPengirimanBarang.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_sentitem_report"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filterbarang_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.id_item} >= '" & cbo_filterbarang_purch1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang_purch2.EditValue & "'"
                        Else
                            filter2 = "{view_lap_datacustomer.id_item} >= '" & cbo_filterbarang_purch1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang_purch2.EditValue & "'"
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
                    LapDataCustomer_1.Text = "Laporan Pengiriman Barang"
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
            ElseIf value_choose = "MN_LAPORAN_SALES_STD" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapPenjualanStandar.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_lap_penjualan_std"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
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
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Penjualan"
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
            ElseIf value_choose = "MN_LAPORAN_SALES_GROUP" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapPenjualanGrupCustomer.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_lap_penjualan_std"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If

                    If chk_filterbarang_purch.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.id_item} >= '" & cbo_filterbarang_purch1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang_purch2.EditValue & "'"
                        Else
                            filter2 = "{view_lap_datacustomer.id_item} >= '" & cbo_filterbarang_purch1.EditValue & "' and {view_lap_datacustomer.id_item} <= '" & cbo_filterbarang_purch2.EditValue & "'"
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
                    '   LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Penjualan"
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
            ElseIf value_choose = "MN_LAPORAN_SALES_RECAP" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1 As String

                pathfilereport = Application.StartupPath & "\Report\LapRekapPenjualanTahun.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_rekappenj_bln_cust(" & Year(th_purch.Value) & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Year(th_purch.Value))
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
                    Else
                        filter1 = ""
                    End If


                    If filter1 <> "" Then
                        ReportFormula = filter1
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    '  LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Rekap Penjualan"
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
            ElseIf value_choose = "MN_LAPORAN_SALES_RANK" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapRankingPenjPerBarang.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "select * from view_lap_ranking_penjperbarang"

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
                            filter2 = " and {view_lap_ranking_pembperbarang1.id_item} >= '" & cbo_filterbarang_purch1.EditValue & "' and {view_lap_ranking_pembperbarang1.id_item} <= '" & cbo_filterbarang_purch2.EditValue & "'"
                        Else
                            filter2 = "{view_lap_ranking_pembperbarang1.id_item} >= '" & cbo_filterbarang_purch1.EditValue & "' and {view_lap_ranking_pembperbarang1.id_item} <= '" & cbo_filterbarang_purch2.EditValue & "'"
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
                    LapDataCustomer_1.Text = "Laporan Ranking Penjualan"
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
            ElseIf value_choose = "MN_LAPORAN_SALES_GRAFIK" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String

                pathfilereport = Application.StartupPath & "\Report\LapRekapPenjualanTahunGrafik.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "call sp_rpt_rekappenj_bln_cust_grafik(" & Year(th_purch.Value) & ")"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue(0, Year(th_purch.Value))
                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    LapDataCustomer_1.Text = "Laporan Grafik Penjualan"
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

            ElseIf value_choose = "MN_LAPORAN_KOMISI_SALESMAN" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapKomisiPerSupplierPerKota.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "select * from marketing_commision_view"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()


                    If chk_filtertgl_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_purch2.Value, "yyyy-MM-dd") & "#"
                    Else
                        filter1 = ""
                    End If

                    If chk_kota.Checked = True Then
                        If filter1 <> "" Then
                            filter2 = " and {view_lap_datacustomer.city_code} >= '" & cbo_kota1.EditValue & "' and {view_lap_datacustomer.city_code} <= '" & cbo_kota2.EditValue & "'"
                        Else
                            filter2 = "{view_lap_datacustomer.city_code} >= '" & cbo_kota1.EditValue & "' and {view_lap_datacustomer.city_code} <= '" & cbo_kota2.EditValue & "'"
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
                    LapDataCustomer_1.Text = "Laporan Grafik Penjualan"
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

    Private Sub listreportap_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles listreportap.SelectedValueChanged
        open_conn()
        If listreportap.SelectedValue = "MN_LAPORAN_PIUTANG_SUPPLIER" Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        ElseIf listreportap.SelectedValue = "MN_LAPORAN_UMUR_PIUTANG" Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        ElseIf listreportap.SelectedValue = "MN_LAPORAN_PEMBAYARAN_PIUTANG" Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        ElseIf listreportap.SelectedValue = "MN_LAPORAN_PEMBAYARAN_PER_PERIOD" Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = False
            gb_filterth_ap.Visible = True
        ElseIf listreportap.SelectedValue = "MN_LAPORAN_SALDO_PER_PERIOD" Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = False
            gb_filterth_ap.Visible = True
        ElseIf listreportap.SelectedValue = "MN_LAPORAN_ESTIMASI_JATUH_TEMPO" Then
            gb_filtertgl_ap.Visible = False
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
        common_disable()
    End Sub

    Private Sub common_disable()
        open_conn()
        chk_filterbarang_purch.Checked = False
        chk_filterbl_purch.Checked = False
        chk_filtersupp_ap.Checked = False
        chk_filtersupp_purch.Checked = False
        chk_filtertgl_ap.Checked = False
        chk_filtertgl_purch.Checked = False
        chk_kota.Checked = False
    End Sub

    Private Sub chk_kota_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_kota.CheckedChanged
        open_conn()
        If chk_kota.Checked = True Then
            cbo_kota1.Enabled = True
            cbo_kota2.Enabled = True
        ElseIf chk_kota.Checked = False Then
            cbo_kota1.Enabled = False
            cbo_kota2.Enabled = False
        End If
    End Sub
End Class