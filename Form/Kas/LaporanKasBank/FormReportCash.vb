Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports MySql.Data.MySqlClient

Public Class FormReportCash
    '   Public report_cashbank_source As Boolean
    Private Sub clear_checked()
        rb_ap1.Checked = False


        rb_purch1.Checked = False
        rb_purch2.Checked = False

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_purch.Click
        open_conn()
        choose_report(ListReportDetail.SelectedValue)
    End Sub

    Private Sub rb_cust1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch1.CheckedChanged
        If rb_purch1.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False

        End If
    End Sub

    Private Sub list_report_detail()
        Dim DT As DataTable
        DT = select_report_list(username, "MN_CASHBANK_TRANS_REPORT")
        ListReportDetail.DisplayMember = "notes"
        ListReportDetail.ValueMember = "childkey"
        ListReportDetail.DataSource = DT
    End Sub


    Private Sub list_report_recap()
        Dim DT As DataTable
        DT = select_report_list(username, "MN_CASHBANK_RECAP_REPORT")
        ListReportRekap.DisplayMember = "notes"
        ListReportRekap.ValueMember = "childkey"
        ListReportRekap.DataSource = DT
    End Sub

    Private Sub FormReportCash_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FormReportMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        clear_checked()
        fillComboBox()
        list_report_detail()
        list_report_recap()
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
        cbo_supp_purch1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp_purch1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp_ap1.Properties.DataSource = DTAkun
        cbo_supp_ap1.Properties.DisplayMember = "account_name"
        cbo_supp_ap1.Properties.ValueMember = "id_account"
        cbo_supp_ap1.Properties.PopulateViewColumns()
        cbo_supp_ap1.Properties.View.Columns("id_account").Caption = "No Akun"
        cbo_supp_ap1.Properties.View.Columns("account_name").Caption = "Nama Akun"
        cbo_supp_ap1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp_ap1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp_purch2.Properties.DataSource = DTAkun
        cbo_supp_purch2.Properties.DisplayMember = "account_name"
        cbo_supp_purch2.Properties.ValueMember = "id_account"
        cbo_supp_purch2.Properties.PopulateViewColumns()
        cbo_supp_purch2.Properties.View.Columns("id_account").Caption = "No Akun"
        cbo_supp_purch2.Properties.View.Columns("account_name").Caption = "Nama Akun"
        cbo_supp_purch2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp_purch2.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp_ap2.Properties.DataSource = DTAkun
        cbo_supp_ap2.Properties.DisplayMember = "account_name"
        cbo_supp_ap2.Properties.ValueMember = "id_account"
        cbo_supp_ap2.Properties.PopulateViewColumns()
        cbo_supp_ap2.Properties.View.Columns("id_account").Caption = "No Akun"
        cbo_supp_ap2.Properties.View.Columns("account_name").Caption = "Nama Akun"
        cbo_supp_ap2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp_ap2.Properties.View.OptionsView.ShowAutoFilterRow = True
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

    Private Sub rb_cust2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_purch2.CheckedChanged
        If rb_purch2.Checked = True Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            chk_filtersupp_purch.Checked = False
            chk_filtertgl_purch.Checked = False
        End If
    End Sub

    Private Sub chk_filterbl_cust_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_filtertgl_purch.CheckedChanged
        If chk_filtertgl_purch.Checked = True Then
            tgl_purch1.Enabled = True
            tgl_purch2.Enabled = True
        ElseIf chk_filtertgl_purch.Checked = False Then
            tgl_purch1.Enabled = False
            tgl_purch2.Enabled = False
        End If
    End Sub

    Private Sub chk_filtertgl_cust_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_filterbl_purch.CheckedChanged
        If chk_filterbl_purch.Checked = True Then
            bl_purch1.Enabled = True
            bl_purch2.Enabled = True
        ElseIf chk_filterbl_purch.Checked = False Then
            bl_purch1.Enabled = False
            bl_purch2.Enabled = False
        End If
    End Sub

   

    Private Sub chk_filtersupp_ap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_filtersupp_ap.CheckedChanged
        If chk_filtersupp_ap.Checked = True Then
            cbo_supp_ap1.Enabled = True
            cbo_supp_ap2.Enabled = True
        ElseIf chk_filtersupp_ap.Checked = False Then
            cbo_supp_ap1.Enabled = False
            cbo_supp_ap2.Enabled = False
        End If
    End Sub

    Private Sub chk_filtertgl_ap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_filtertgl_ap.CheckedChanged
        If chk_filtertgl_ap.Checked = True Then
            tgl_ap1.Enabled = True
            tgl_ap2.Enabled = True
        ElseIf chk_filtertgl_ap.Checked = False Then
            tgl_ap1.Enabled = False
            tgl_ap2.Enabled = False
        End If
    End Sub

    Private Sub choose_rekap_report(ByVal value_choose As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False

            If value_choose = "MN_CASHBANK_TRANS_RECAP" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String
                Dim DTA, DTB As DataTable

                DTA = select_first_account()
                DTB = select_last_account()
                If chk_filtersupp_ap.Checked = False Then
                    cbo_supp_ap1.EditValue = DTA.Rows(0).Item(0)
                    cbo_supp_ap2.EditValue = DTB.Rows(0).Item(0)
                End If

                pathfilereport = Application.StartupPath & "\Report\LapKasBankRekap.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_lap_rekap_kasbank"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))

                    If chk_filtersupp_ap.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_account} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_account} <= '" & Trim(cbo_supp_ap2.EditValue) & "'"
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

                    cryRpt.Refresh()
                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
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

    Private Sub choose_report(ByVal value_choose As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False

            If value_choose = "MN_CASHBANK_TRANS_DETAIL" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String
                Dim DTA, DTB As DataTable

                DTA = select_first_account()
                DTB = select_last_account()
                If chk_filtersupp_purch.Checked = False Then
                    cbo_supp_purch1.EditValue = DTA.Rows(0).Item(0)
                    cbo_supp_purch2.EditValue = DTB.Rows(0).Item(0)
                End If

                pathfilereport = Application.StartupPath & "\Report\LapKasBankDetail.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_cashbank_report"

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
                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Detail Transaksi Kas/Bank"
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
            If value_choose = "MN_CASHBANK_REKON_DETAIL" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String
                Dim DTA, DTB As DataTable

                DTA = select_first_account()
                DTB = select_last_account()
                If chk_filtersupp_purch.Checked = False Then
                    cbo_supp_purch1.EditValue = DTA.Rows(0).Item(0)
                    cbo_supp_purch2.EditValue = DTB.Rows(0).Item(0)
                End If

                pathfilereport = Application.StartupPath & "\Report\LapRekonsiliasiBank.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_rekonsiliasi_report"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.id_account_bank} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_account_bank} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
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

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.WindowState = FormWindowState.Maximized
                    With LapDataCustomer_1.CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = True
                        .DisplayGroupTree = False
                    End With


                    LapDataCustomer_1.Show()
                    LapDataCustomer_1.Text = "Laporan Rekonsiliasi Bank"

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub rb_ap1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_ap1.CheckedChanged
        If rb_ap1.Checked = True Then
            gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If
    End Sub

    Private Sub btn_ap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ap.Click
        open_conn()
        choose_rekap_report(ListReportRekap.SelectedValue)

      
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        If TabControl1.SelectedTabPage Is TabPage1 Then
            rb_purch1.Checked = True
        ElseIf TabControl1.SelectedTabPage Is TabPage2 Then
            rb_ap1.Checked = True
        End If
    End Sub



    Private Sub cbo_supp_purch1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_supp_purch1.EditValueChanged

    End Sub

    Private Sub btn_ap_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_ap.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_ap_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_ap.Cursor = Cursors.Default
    End Sub

    Private Sub btn_purch_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_purch.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_purch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_purch.Cursor = Cursors.Default
    End Sub

    Private Sub rb_purch1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub chk_filtersupp_purch_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ListReportDetail_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListReportDetail.SelectedValueChanged
        open_conn()
        If ListReportDetail.SelectedValue = "MN_CASHBANK_TRANS_DETAIL" Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
        End If
        If ListReportDetail.SelectedValue = "MN_CASHBANK_REKON_DETAIL" Then
            gb_filtertgl_purch.Visible = True
            gb_filterbl_purch.Visible = False
            gb_filtersupp_purch.Visible = True
            gb_filterth_purch.Visible = False
            chk_filtersupp_purch.Checked = False
            chk_filtertgl_purch.Checked = False
        End If
    End Sub

    Private Sub ListReportRekap_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListReportRekap.SelectedValueChanged
        open_conn()
        If ListReportDetail.SelectedValue = "MN_CASHBANK_TRANS_RECAP" Then
          gb_filtertgl_ap.Visible = True
            gb_filtersupp_ap.Visible = True
            gb_filterth_ap.Visible = False
        End If

    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class