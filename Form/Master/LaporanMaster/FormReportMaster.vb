Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports MySql.Data.MySqlClient

Public Class FormReportMaster

    Private Sub choose_report(ByVal type As Integer, ByVal value_choose As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False

            Dim da As New MySqlDataAdapter()
            Dim ds As New DataSet()

            If type = 1 Then
                If value_choose = "MN_CUST_REPORT_DAFTARPELANGGAN" Then
                    Dim cryRpt As New ReportDocument
                    Dim pathfilereport As String
                    Dim pathfilepdf As String
                    Dim ReportFormula As String

                    Try
                        pathfilereport = Application.StartupPath & "\Report\LapDataCustomer.rpt"
                        pathfilepdf = Application.StartupPath & "\Report\LapDataCustomer.pdf"

                        Dim qryCompanies As String = "SELECT * FROM view_lap_datacustomer_2"

                        da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                        Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                        da.Fill(ds, "view_lap_datacustomer_2")

                        cryRpt.Load(pathfilereport)
                        cryRpt.SetDataSource(ds.Tables(0))



                        If chk_filtercust_cust.Checked = True Then
                            ReportFormula = "{view_lap_datacustomer.ID} >= '" & Trim(cbo_cust1.Text) & "' and {view_lap_datacustomer.ID} <= '" & Trim(cbo_cust2.Text) & "'"
                            cryRpt.RecordSelectionFormula = ReportFormula
                        End If

                        cryRpt.Refresh()
                        Dim LapDataCustomer_1 As New LapMaster
                        LapDataCustomer_1.Show()
                        LapDataCustomer_1.WindowState = FormWindowState.Maximized
                        LapDataCustomer_1.Text = "Customer File Report"
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
                ElseIf value_choose = "MN_CUST_REPORT_DAFTARPELANGGAN_CITY" Then
                    Dim cryRpt As New ReportDocument
                    Dim pathfilereport As String
                    Dim pathfilepdf As String
                    Dim ReportFormula As String

                    Try
                        pathfilereport = Application.StartupPath & "\Report\LapDataCustomerGroupByKota.rpt"
                        pathfilepdf = Application.StartupPath & "\Report\LapDataCustomerGroupByKota.pdf"


                        Dim qryCompanies As String = "SELECT * FROM view_lap_datacustomer_2"

                        da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                        Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                        da.Fill(ds, "view_lap_datacustomer_2")

                        cryRpt.Load(pathfilereport)
                        cryRpt.SetDataSource(ds.Tables(0))

                        If chk_filterkota_cust.Checked = True Then
                            ReportFormula = "{view_lap_datacustomer.Kota} >= '" & Trim(cbo_kota1.Text) & "' and {view_lap_datacustomer.Kota} <= '" & Trim(cbo_kota2.Text) & "'"
                            cryRpt.RecordSelectionFormula = ReportFormula
                        End If
                       
                        cryRpt.Refresh()
                        Dim LapDataCustomer_1 As New LapMaster
                        LapDataCustomer_1.Show()
                        LapDataCustomer_1.Text = "Customer File Report"
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
                ElseIf value_choose = "MN_CUST_REPORT_RANKING_PENJUALAN" Then
                    Dim cryRpt As New ReportDocument
                    Dim pathfilereport As String
                    Dim pathfilepdf As String
                    Dim ReportFormula As String
                    Try
                        pathfilereport = Application.StartupPath & "\Report\LapRangkingCustomerBySales.rpt"
                        pathfilepdf = Application.StartupPath & "\Report\LapRangkingCustomerBySales.pdf"

                        Dim filter As Integer
                        If chk_filtertgl_cust.Checked = True Then
                            filter = 1
                        ElseIf chk_filtertgl_cust.Checked = False Then
                            filter = 0
                        End If

                        Dim qryCompanies As String = "call sp_rpt_rangking_pelanggan(" & filter & ",'" & Format(tgl_cust1.Value, "yyyy-MM-dd") & "','" & Format(tgl_cust2.Value, "yyyy-MM-dd") & "')"

                        da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                        Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                        da.Fill(ds)

                        cryRpt.Load(pathfilereport)
                        cryRpt.SetDataSource(ds.Tables(0))

                        'Call ranking_pelanggan_rpt(filter, tgl_cust1.Value, tgl_cust2.Value)


                        cryRpt.Refresh()
                        cryRpt.SetParameterValue(0, filter)
                        cryRpt.SetParameterValue(1, tgl_cust1.Value)
                        cryRpt.SetParameterValue(2, tgl_cust2.Value)

                        If chk_filtercust_cust.Checked = True Then
                            ReportFormula = "{view_lap_ranking_cust.ID} >= '" & Trim(cbo_cust1.Text) & "' and {view_lap_ranking_cust.ID} <= '" & Trim(cbo_cust2.Text) & "'"
                            cryRpt.RecordSelectionFormula = ReportFormula
                        End If

                        Dim LapDataCustomer_1 As New LapMaster
                        LapDataCustomer_1.Show()
                        ' LapDataCustomer_1.MdiParent = MainMenu
                        LapDataCustomer_1.WindowState = FormWindowState.Maximized
                        LapDataCustomer_1.Text = "Customer File Report"
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
            ElseIf type = 2 Then
                If value_choose = "MN_SUPP_REPORT_DAFTARSUPPLIER" Then
                    Dim cryRpt As New ReportDocument
                    Dim pathfilereport As String
                    Dim ReportFormula As String

                    pathfilereport = Application.StartupPath & "\Report\LapDataSupplier.rpt"

                    Try
                        Dim qryCompanies As String = "SELECT * FROM view_lap_datasupplier"

                        da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                        Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                        da.Fill(ds)

                        cryRpt.Load(pathfilereport)
                        cryRpt.SetDataSource(ds.Tables(0))
                        If chk_filter_supp.Checked = True Then
                            ReportFormula = "{view_lap_datacustomer.ID} >= '" & Trim(cbo_supp1.Text) & "' and {view_lap_datacustomer.ID} <= '" & Trim(cbo_supp2.Text) & "'"
                            cryRpt.RecordSelectionFormula = ReportFormula
                        End If
                        cryRpt.Refresh()
                        Dim LapDataCustomer_1 As New LapMaster
                        LapDataCustomer_1.Show()
                        ' LapDataCustomer_1.MdiParent = MainMenu
                        LapDataCustomer_1.WindowState = FormWindowState.Maximized
                        LapDataCustomer_1.Text = "Supplier File Report"
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
                ElseIf value_choose = "MN_SUPP_REPORT_RANKING_PEMBELIAN" Then
                    Dim cryRpt3 As New ReportDocument
                    Dim pathfilereport As String
                    Dim ReportFormula As String

                    pathfilereport = Application.StartupPath & "\Report\LapRangkingSupplierByPurchase.rpt"

                    Dim filter As Integer
                    If chk_tgl_supp.Checked = True Then
                        filter = 1
                    ElseIf chk_tgl_supp.Checked = False Then
                        filter = 0
                    End If

                    Try
                        Dim qryCompanies As String = "call sp_rpt_rangking_supplier(" & filter & ",'" & Format(tgl_cust1.Value, "yyyy-MM-dd") & "','" & Format(tgl_cust2.Value, "yyyy-MM-dd") & "')"

                        da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                        Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                        da.Fill(ds)

                        cryRpt3.Load(pathfilereport)
                        cryRpt3.SetDataSource(ds.Tables(0))
                        cryRpt3.Refresh()
                        cryRpt3.SetParameterValue(0, filter)
                        cryRpt3.SetParameterValue(1, tgl_supplier_1.Value)
                        cryRpt3.SetParameterValue(2, tgl_supplier2.Value)

                        If chk_filter_supp.Checked = True Then
                            ReportFormula = "{view_lap_ranking_cust.ID} >= '" & Trim(cbo_supp1.Text) & "' and {view_lap_ranking_cust.ID} <= '" & Trim(cbo_supp2.Text) & "'"
                            cryRpt3.RecordSelectionFormula = ReportFormula
                        End If

                        Dim LapDataCustomer_1 As New LapMaster
                        LapDataCustomer_1.Show()
                        ' LapDataCustomer_1.MdiParent = MainMenu
                        LapDataCustomer_1.WindowState = FormWindowState.Maximized
                        LapDataCustomer_1.Text = "Supplier File Report"
                        With LapDataCustomer_1.CRviewer
                            .ReportSource = cryRpt3
                            .ShowGroupTreeButton = False
                            .ShowExportButton = True
                            .DisplayGroupTree = False
                        End With
                    Catch ex As Exception
                        Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                        alertControl_error.Show(Me, info)
                    End Try
                End If
            ElseIf type = 3 Then
                If value_choose = "MN_EMPP_REPORT_DAFTARKARYAWAN" Then
                    Dim cryRpt As New ReportDocument
                    Dim pathfilereport As String
                    Dim ReportFormula As String

                    pathfilereport = Application.StartupPath & "\Report\LapDataKaryawan.rpt"

                    Try
                        Dim qryCompanies As String = "SELECT * FROM view_lap_dataemployee"

                        da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                        Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                        da.Fill(ds)

                        cryRpt.Load(pathfilereport)
                        cryRpt.SetDataSource(ds.Tables(0))
                        If chk_pegawai.Checked = True Then
                            ReportFormula = "{view_lap_datacustomer.ID} >= '" & Trim(cbo_mrkt1.Text) & "' and {view_lap_datacustomer.ID} <= '" & Trim(cbo_mrkt2.Text) & "'"
                            cryRpt.RecordSelectionFormula = ReportFormula
                        End If
                        cryRpt.Refresh()
                        Dim LapDataCustomer_1 As New LapMaster
                        LapDataCustomer_1.Show()
                        ' LapDataCustomer_1.MdiParent = MainMenu
                        LapDataCustomer_1.WindowState = FormWindowState.Maximized
                        LapDataCustomer_1.Text = "Employee File Report"
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
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub btn_save_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save_cust.Click
        open_conn()
        choose_report(1, ListReportCust.SelectedValue)
    End Sub

    Private Sub rb_cust1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_cust1.CheckedChanged
        open_conn()
        If rb_cust1.Checked = True Then
            gb_filtercust_cust.Visible = True
            gb_filterbl_cust.Visible = False
            gb_filtertgl_cust.Visible = False
            gb_filterkota_cust.Visible = False
        End If
    End Sub

    Private Sub FormReportMaster_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FormReportMaster_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub fillComboBox()
        open_conn()

        Dim DTItem As DataTable
        DTItem = getComboSupplier()
        cbo_supp1.Properties.DataSource = DTItem
        cbo_supp1.Properties.DisplayMember = "nama"
        cbo_supp1.Properties.ValueMember = "id_supplier"
        cbo_supp1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp2.Properties.DataSource = DTItem
        cbo_supp2.Properties.DisplayMember = "nama"
        cbo_supp2.Properties.ValueMember = "id_supplier"
        cbo_supp2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp2.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_mrkt1.Properties.DataSource = getComboEmployee()
        cbo_mrkt1.Properties.DisplayMember = "nama"
        cbo_mrkt1.Properties.ValueMember = "id_employee"
        cbo_mrkt1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_mrkt1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_mrkt2.Properties.DataSource = getComboEmployee()
        cbo_mrkt2.Properties.DisplayMember = "nama"
        cbo_mrkt2.Properties.ValueMember = "id_employee"
        cbo_mrkt2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_mrkt2.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_kota1.Properties.DataSource = getComboKotaCust()
        cbo_kota1.Properties.DisplayMember = "Kota"
        cbo_kota1.Properties.ValueMember = "Kota"
        cbo_kota1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_kota1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_kota2.Properties.DataSource = getComboKotaCust()
        cbo_kota2.Properties.DisplayMember = "Kota"
        cbo_kota2.Properties.ValueMember = "Kota"
        cbo_kota2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_kota2.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_cust1.Properties.DataSource = getComboCustomer()
        cbo_cust1.Properties.DisplayMember = "Nama"
        cbo_cust1.Properties.ValueMember = "id_customer"
        cbo_cust1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_cust1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_cust2.Properties.DataSource = getComboCustomer()
        cbo_cust2.Properties.DisplayMember = "Nama"
        cbo_cust2.Properties.ValueMember = "id_customer"
        cbo_cust2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_cust2.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub


    Private Sub list_report()
        Dim DTCust As DataTable
        DTCust = select_reportmaster_list(username, "MN_CUST_REPORT")

        Dim DTSupp As DataTable
        DTSupp = select_reportmaster_list(username, "MN_SUPP_REPORT")

        Dim DTEmpl As DataTable
        DTEmpl = select_reportmaster_list(username, "MN_EMPP_REPORT")

        ListReportCust.DisplayMember = "notes"
        ListReportCust.ValueMember = "childkey"
        ListReportCust.DataSource = DTCust
        ListReportCust.AutoSizeInLayoutControl = True

        ListReportSupp.DisplayMember = "notes"
        ListReportSupp.ValueMember = "childkey"
        ListReportSupp.DataSource = DTSupp
        ListReportSupp.AutoSizeInLayoutControl = True

        ListReportKaryawan.DisplayMember = "notes"
        ListReportKaryawan.ValueMember = "childkey"
        ListReportKaryawan.DataSource = DTEmpl
        ListReportKaryawan.AutoSizeInLayoutControl = True
    End Sub

    Private Sub FormReportMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        fillComboBox()
        Me.TabControl1.SelectedTabPage = TabEmp
        Me.TabControl1.SelectedTabPage = TabSupp
        Me.TabControl1.SelectedTabPage = TabCust

        gb_filtercust_cust.Visible = True
        gb_filterbl_cust.Visible = False
        gb_filtertgl_cust.Visible = False
        gb_filterkota_cust.Visible = False

        gb_supp_supp.Visible = True
        gb_supp_tgl.Visible = False

        gb_pegawai1.Visible = True
        gb_pegawai2.Visible = False

        chk_filtercust_cust.Checked = False
        cbo_cust1.Enabled = False
        cbo_cust2.Enabled = False

        chk_filter_supp.Checked = False
        cbo_supp1.Enabled = False
        cbo_supp2.Enabled = False

        chk_tgl_supp.Checked = False
        tgl_supplier_1.Enabled = False
        tgl_supplier2.Enabled = False

        chk_filterkota_cust.Checked = False
        cbo_kota1.Enabled = False
        cbo_kota2.Enabled = False

        chk_filterbl_cust.Checked = False
        bln_cust1.Enabled = False
        bln_cust2.Enabled = False

        chk_filtertgl_cust.Checked = False
        tgl_cust1.Enabled = False
        tgl_cust2.Enabled = False
        tgl_cust1.Value = Now
        tgl_cust2.Value = Now

        chk_pegawai.Checked = False
        cbo_mrkt1.Enabled = False
        cbo_mrkt2.Enabled = False

        chk_tgl_employee.Checked = False
        tgl_empl1.Enabled = False
        tgl_empl1.Enabled = False

        rb_cust1.Checked = True
        rb_supp1.Checked = True
        rb_mrkt1.Checked = True

        list_report()

    End Sub

    Private Sub chk_filtercust_cust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filtercust_cust.CheckedChanged
        open_conn()
        If chk_filtercust_cust.Checked = True Then
            cbo_cust1.Enabled = True
            cbo_cust2.Enabled = True
        ElseIf chk_filtercust_cust.Checked = False Then
            cbo_cust1.Enabled = False
            cbo_cust2.Enabled = False
        End If
    End Sub

    Private Sub chk_filterkota_cust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filterkota_cust.CheckedChanged
        open_conn()
        If chk_filterkota_cust.Checked = True Then
            cbo_kota1.Enabled = True
            cbo_kota2.Enabled = True
        ElseIf chk_filterkota_cust.Checked = False Then
            cbo_kota1.Enabled = False
            cbo_kota2.Enabled = False
        End If
    End Sub

    Private Sub rb_cust2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_cust2.CheckedChanged
        open_conn()
        If rb_cust2.Checked = True Then
            gb_filtercust_cust.Visible = False
            gb_filterbl_cust.Visible = False
            gb_filtertgl_cust.Visible = False
            gb_filterkota_cust.Visible = True
        End If
    End Sub

    Private Sub rb_cust3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_cust3.CheckedChanged
        open_conn()
        If rb_cust3.Checked = True Then
            gb_filtercust_cust.Visible = True
            gb_filterbl_cust.Visible = False
            gb_filtertgl_cust.Visible = True
            gb_filterkota_cust.Visible = False
        End If
    End Sub

    Private Sub rb_cust4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_cust4.CheckedChanged
        open_conn()
        If rb_cust4.Checked = True Then
            gb_filtercust_cust.Visible = True
            gb_filterbl_cust.Visible = False
            gb_filtertgl_cust.Visible = True
            gb_filterkota_cust.Visible = False
        End If
    End Sub

    Private Sub rb_cust5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_cust5.CheckedChanged
        open_conn()
        If rb_cust5.Checked = True Then
            gb_filtercust_cust.Visible = True
            gb_filterbl_cust.Visible = False
            gb_filtertgl_cust.Visible = True
            gb_filterkota_cust.Visible = False
        End If
    End Sub

    Private Sub chk_filterbl_cust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filterbl_cust.CheckedChanged
        open_conn()
        If chk_filterbl_cust.Checked = True Then
            bln_cust1.Enabled = True
            bln_cust2.Enabled = True
        ElseIf chk_filterbl_cust.Checked = False Then
            bln_cust1.Enabled = False
            bln_cust2.Enabled = False
        End If
    End Sub

    Private Sub chk_filtertgl_cust_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_filtertgl_cust.CheckedChanged
        open_conn()
        If chk_filtertgl_cust.Checked = True Then
            tgl_cust1.Enabled = True
            tgl_cust2.Enabled = True
        ElseIf chk_filtertgl_cust.Checked = False Then
            tgl_cust1.Enabled = False
            tgl_cust2.Enabled = False
        End If
    End Sub

    Private Sub btn_save_supp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save_supp.Click
        open_conn()
        choose_report(2, ListReportSupp.SelectedValue)
    End Sub

    Private Sub btn_save_emp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save_emp.Click
        open_conn()
        choose_report(3, ListReportKaryawan.SelectedValue)
    End Sub

    Private Sub chk_filter_supp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filter_supp.CheckedChanged
        open_conn()
        If chk_filter_supp.Checked = True Then
            cbo_supp1.Enabled = True
            cbo_supp2.Enabled = True
        ElseIf chk_filterkota_cust.Checked = False Then
            cbo_supp1.Enabled = False
            cbo_supp2.Enabled = False
        End If
    End Sub

    Private Sub chk_tgl_supp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_tgl_supp.CheckedChanged
        open_conn()
        If chk_tgl_supp.Checked = True Then
            tgl_supplier_1.Enabled = True
            tgl_supplier2.Enabled = True
        ElseIf chk_filterkota_cust.Checked = False Then
            tgl_supplier_1.Enabled = False
            tgl_supplier2.Enabled = False
        End If
    End Sub

    Private Sub chk_pegawai_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_pegawai.CheckedChanged
        open_conn()
        If chk_pegawai.Checked = True Then
            cbo_mrkt1.Enabled = True
            cbo_mrkt2.Enabled = True
        ElseIf chk_pegawai.Checked = False Then
            cbo_mrkt1.Enabled = False
            cbo_mrkt2.Enabled = False
        End If
    End Sub

    Private Sub chk_tgl_employee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_tgl_employee.CheckedChanged
        open_conn()
        If chk_tgl_employee.Checked = True Then
            tgl_empl1.Enabled = True
            tgl_empl2.Enabled = True
        ElseIf chk_pegawai.Checked = False Then
            tgl_empl1.Enabled = False
            tgl_empl2.Enabled = False
        End If
    End Sub

    Private Sub rb_supp1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rb_supp1.CheckedChanged
        open_conn()
        If rb_supp1.Checked = True Then
            gb_supp_supp.Visible = True
            gb_supp_tgl.Visible = True
        End If
    End Sub


    Private Sub rb_supp2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_supp2.CheckedChanged
        open_conn()
        If rb_supp2.Checked = True Then
            gb_supp_supp.Visible = True
            gb_supp_tgl.Visible = True
        End If
    End Sub

    Private Sub rb_mrkt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_mrkt1.CheckedChanged
        open_conn()
        If rb_mrkt1.Checked = True Then
            gb_pegawai1.Visible = True
            gb_pegawai2.Visible = True
        End If
    End Sub

    Private Sub rb_purch6_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub rb_purch7_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub rb_purch8_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub rb_purch9_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub rb_purch1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub chk_filtersupp_purch_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub bln_cust1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles bln_cust1.ValueChanged

    End Sub

    Private Sub tgl_supplier_1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles tgl_supplier_1.ValueChanged

    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub ListReportCust_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListReportCust.SelectedValueChanged
        open_conn()
        If ListReportCust.SelectedValue = "MN_CUST_REPORT_DAFTARPELANGGAN" Then
            gb_filtercust_cust.Visible = True
            gb_filterbl_cust.Visible = False
            gb_filtertgl_cust.Visible = False
            gb_filterkota_cust.Visible = False
        ElseIf ListReportCust.SelectedValue = "MN_CUST_REPORT_DAFTARPELANGGAN_CITY" Then
            gb_filtercust_cust.Visible = False
            gb_filterbl_cust.Visible = False
            gb_filtertgl_cust.Visible = False
            gb_filterkota_cust.Visible = True
        ElseIf ListReportCust.SelectedValue = "MN_CUST_REPORT_RANKING_PENJUALAN" Then
            gb_filtercust_cust.Visible = True
            gb_filterbl_cust.Visible = False
            gb_filtertgl_cust.Visible = True
            gb_filterkota_cust.Visible = False
        End If
    End Sub

    Private Sub ListReportKaryawan_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListReportKaryawan.SelectedValueChanged
        open_conn()
        If ListReportKaryawan.SelectedValue = "MN_EMPP_REPORT_DAFTARKARYAWAN" Then
            gb_pegawai1.Visible = True
            gb_pegawai2.Visible = True
        End If
    End Sub

    Private Sub ListReportSupp_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListReportSupp.SelectedValueChanged
        open_conn()
        If ListReportSupp.SelectedValue = "MN_SUPP_REPORT_DAFTARSUPPLIER" Then
            gb_supp_supp.Visible = True
            gb_supp_tgl.Visible = True
        ElseIf ListReportSupp.SelectedValue = "MN_SUPP_REPORT_RANKING_PEMBELIAN" Then
            gb_supp_supp.Visible = True
            gb_supp_tgl.Visible = True
        End If
    End Sub
End Class