Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports MySql.Data.MySqlClient

Public Class FormReportSales2

    Private Sub clear_checked()
        open_conn()
        'rb_ap1.Checked = False
        'rb_ap2.Checked = False
        'rb_ap3.Checked = False
        'rb_ap4.Checked = False
        'rb_ap5.Checked = False
        'rb_ap6.Checked = False
        'rb_ap7.Checked = False

 

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
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_preview.Click
        open_conn()
        choose_report(ListReport.SelectedValue)
    End Sub

    Private Sub FormReportSales2_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FormReportSales_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub FormReportMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        clear_checked()
        fillComboBox()
        list_report()
    End Sub

    Private Sub list_report()
        Dim DT As DataTable
        DT = select_report_list(username, "MN_MUTASI_CASHIER")
        ListReport.DisplayMember = "notes"
        ListReport.ValueMember = "childkey"
        ListReport.DataSource = DT
    End Sub

    Private Sub fillComboBox()
        Dim DTItem As DataTable
        DTItem = getComboItem()
        'cbo_filterbarang_purch1.Properties.DataSource = DTItem
        'cbo_filterbarang_purch1.Properties.DisplayMember = "item_name"
        'cbo_filterbarang_purch1.Properties.ValueMember = "id_item"
        'cbo_filterbarang_purch1.Properties.PopulateColumns()
        'cbo_filterbarang_purch1.Properties.Columns("id_item").Caption = "Kode"
        'cbo_filterbarang_purch1.Properties.Columns("item_name").Caption = "Barang"

        'cbo_filterbarang_purch2.Properties.DataSource = DTItem
        'cbo_filterbarang_purch2.Properties.DisplayMember = "item_name"
        'cbo_filterbarang_purch2.Properties.ValueMember = "id_item"
        'cbo_filterbarang_purch2.Properties.PopulateColumns()
        'cbo_filterbarang_purch2.Properties.Columns("id_item").Caption = "Kode"
        'cbo_filterbarang_purch2.Properties.Columns("item_name").Caption = "Barang"

        cbo_supp_purch1.Properties.DataSource = getComboCustomer()
        cbo_supp_purch1.Properties.DisplayMember = "Nama"
        cbo_supp_purch1.Properties.ValueMember = "id_customer"
        cbo_supp_purch1.Properties.PopulateViewColumns()
        cbo_supp_purch1.Properties.View.Columns("id_customer").Caption = "Kode"
        cbo_supp_purch1.Properties.View.Columns("Nama").Caption = "Pelanggan"
        cbo_supp_purch1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp_purch1.Properties.View.OptionsView.ShowAutoFilterRow = True

        cbo_supp_purch2.Properties.DataSource = getComboCustomer()
        cbo_supp_purch2.Properties.DisplayMember = "Nama"
        cbo_supp_purch2.Properties.ValueMember = "id_customer"
        cbo_supp_purch2.Properties.PopulateViewColumns()
        cbo_supp_purch2.Properties.View.Columns("id_customer").Caption = "Kode"
        cbo_supp_purch2.Properties.View.Columns("Nama").Caption = "Pelanggan"
        cbo_supp_purch2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_supp_purch2.Properties.View.OptionsView.ShowAutoFilterRow = True
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

    'Private Sub chk_filtersupp_ap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If chk_filtersupp_ap.Checked = True Then
    '        cbo_supp_ap1.Enabled = True
    '        cbo_supp_ap2.Enabled = True
    '    ElseIf chk_filtersupp_ap.Checked = False Then
    '        cbo_supp_ap1.Enabled = False
    '        cbo_supp_ap2.Enabled = False
    '    End If
    'End Sub

    'Private Sub chk_filtertgl_ap_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If chk_filtertgl_ap.Checked = True Then
    '        tgl_ap1.Enabled = True
    '        tgl_ap2.Enabled = True
    '    ElseIf chk_filtertgl_ap.Checked = False Then
    '        tgl_ap1.Enabled = False
    '        tgl_ap2.Enabled = False
    '    End If
    'End Sub

    'Private Sub rb_ap1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If rb_ap1.Checked = True Then
    '        gb_filtertgl_ap.Visible = True
    '        gb_filtersupp_ap.Visible = True
    '        gb_filterth_ap.Visible = False
    '    End If
    'End Sub

    'Private Sub btn_ap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If rb_ap1.Checked = False And rb_ap2.Checked = False And rb_ap3.Checked = False And rb_ap4.Checked = False And rb_ap5.Checked = False And rb_ap6.Checked = False And rb_ap7.Checked = False Then
    '        MsgBox("Laporan Belum Dipilih", MsgBoxStyle.Information, "Warning")
    '        Exit Sub
    '    End If
    '    If rb_ap1.Checked = True Then

    '        Dim cryRpt As New ReportDocument
    '        Dim pathfilereport As String
    '        Dim ReportFormula As String
    '        Dim filter1, filter2 As String

    '        pathfilereport = Application.StartupPath & "\Report\LapPiutangPerSupplier.rpt"
    '        Try
    '            cryRpt.Load(pathfilereport)
    '            cryRpt.Refresh()
    '            If chk_filtersupp_ap.Checked = True Then
    '                filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_ap2.EditValue) & "'"
    '            Else
    '                filter1 = ""
    '            End If

    '            If chk_filtertgl_ap.Checked = True Then
    '                If filter1 <> "" Then
    '                    filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
    '                Else
    '                    filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
    '                End If
    '            Else
    '                filter2 = ""
    '            End If

    '            If filter1 <> "" Or filter2 <> "" Then
    '                ReportFormula = filter1 + filter2
    '                cryRpt.RecordSelectionFormula = ReportFormula
    '            End If

    '            Dim LapDataCustomer_1 As New LapPembelian
    '            LapDataCustomer_1.Show()
    '            '  LapDataCustomer_1.MdiParent = MainMenu
    '            LapDataCustomer_1.WindowState = FormWindowState.Maximized
    '            With LapDataCustomer_1.CRviewer
    '                .ReportSource = cryRpt
    '                .ShowGroupTreeButton = False
    '                .ShowExportButton = True
    '                .DisplayGroupTree = False
    '            End With

    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '    ElseIf rb_ap2.Checked = True Then
    '        Dim cryRpt As New ReportDocument
    '        Dim pathfilereport As String
    '        Dim ReportFormula As String
    '        Dim filter1 As String

    '        pathfilereport = Application.StartupPath & "\Report\LapUmurPiutang.rpt"
    '        Try
    '            cryRpt.Load(pathfilereport)
    '            cryRpt.Refresh()
    '            If chk_filtersupp_ap.Checked = True Then
    '                filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_cu} <= 'id_customer" & Trim(cbo_supp_ap2.EditValue) & "'"
    '            Else
    '                filter1 = ""
    '            End If


    '            If filter1 <> "" Then
    '                ReportFormula = filter1
    '                cryRpt.RecordSelectionFormula = ReportFormula
    '            End If

    '            Dim LapDataCustomer_1 As New LapPembelian
    '            LapDataCustomer_1.Show()
    '            '   LapDataCustomer_1.MdiParent = MainMenu
    '            LapDataCustomer_1.WindowState = FormWindowState.Maximized
    '            With LapDataCustomer_1.CRviewer
    '                .ReportSource = cryRpt
    '                .ShowGroupTreeButton = False
    '                .ShowExportButton = True
    '                .DisplayGroupTree = False
    '            End With

    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '    ElseIf rb_ap3.Checked = True Then
    '        Dim cryRpt As New ReportDocument
    '        Dim pathfilereport As String
    '        Dim ReportFormula As String
    '        Dim filter1, filter2 As String

    '        pathfilereport = Application.StartupPath & "\Report\LapHistoryBayarPiutang.rpt"
    '        Try
    '            cryRpt.Load(pathfilereport)
    '            cryRpt.Refresh()
    '            If chk_filtersupp_ap.Checked = True Then
    '                filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_ap2.EditValue) & "'"
    '            Else
    '                filter1 = ""
    '            End If

    '            If chk_filtertgl_ap.Checked = True Then
    '                If filter1 <> "" Then
    '                    filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
    '                Else
    '                    filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
    '                End If
    '            Else
    '                filter2 = ""
    '            End If

    '            If filter1 <> "" Or filter2 <> "" Then
    '                ReportFormula = filter1 + filter2
    '                cryRpt.RecordSelectionFormula = ReportFormula
    '            End If

    '            Dim LapDataCustomer_1 As New LapPembelian
    '            LapDataCustomer_1.Show()
    '            ' LapDataCustomer_1.MdiParent = MainMenu
    '            LapDataCustomer_1.WindowState = FormWindowState.Maximized
    '            With LapDataCustomer_1.CRviewer
    '                .ReportSource = cryRpt
    '                .ShowGroupTreeButton = False
    '                .ShowExportButton = True
    '                .DisplayGroupTree = False
    '            End With

    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '    ElseIf rb_ap4.Checked = True Then
    '        Dim cryRpt As New ReportDocument
    '        Dim pathfilereport As String
    '        Dim ReportFormula As String
    '        Dim filter1, filter2 As String

    '        pathfilereport = Application.StartupPath & "\Report\LapPiutangLunas.rpt"
    '        Try
    '            cryRpt.Load(pathfilereport)
    '            cryRpt.Refresh()
    '            If chk_filtersupp_ap.Checked = True Then
    '                filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_ap1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_ap2.EditValue) & "'"
    '            Else
    '                filter1 = ""
    '            End If

    '            If chk_filtertgl_ap.Checked = True Then
    '                If filter1 <> "" Then
    '                    filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
    '                Else
    '                    filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
    '                End If
    '            Else
    '                filter2 = ""
    '            End If



    '            If filter1 <> "" Or filter2 <> "" Then
    '                ReportFormula = filter1 + filter2
    '                cryRpt.RecordSelectionFormula = ReportFormula
    '            End If

    '            Dim LapDataCustomer_1 As New LapPembelian
    '            LapDataCustomer_1.Show()
    '            '   LapDataCustomer_1.MdiParent = MainMenu
    '            LapDataCustomer_1.WindowState = FormWindowState.Maximized
    '            With LapDataCustomer_1.CRviewer
    '                .ReportSource = cryRpt
    '                .ShowGroupTreeButton = False
    '                .ShowExportButton = True
    '                .DisplayGroupTree = False
    '            End With

    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '    ElseIf rb_ap5.Checked = True Then
    '        Dim cryRpt As New ReportDocument
    '        Dim pathfilereport As String
    '        Dim ReportFormula As String
    '        Dim filter1 As String

    '        pathfilereport = Application.StartupPath & "\Report\LapRekapARPaymentTahun.rpt"
    '        Try
    '            cryRpt.Load(pathfilereport)
    '            cryRpt.Refresh()
    '            cryRpt.SetParameterValue(0, Year(th_ap.Value))
    '            If chk_filtersupp_purch.Checked = True Then
    '                filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
    '            Else
    '                filter1 = ""
    '            End If


    '            If filter1 <> "" Then
    '                ReportFormula = filter1
    '                cryRpt.RecordSelectionFormula = ReportFormula
    '            End If

    '            Dim LapDataCustomer_1 As New LapPembelian
    '            LapDataCustomer_1.Show()
    '            '  LapDataCustomer_1.MdiParent = MainMenu
    '            LapDataCustomer_1.WindowState = FormWindowState.Maximized
    '            With LapDataCustomer_1.CRviewer
    '                .ReportSource = cryRpt
    '                .ShowGroupTreeButton = False
    '                .ShowExportButton = True
    '                .DisplayGroupTree = False
    '            End With


    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '    ElseIf rb_ap6.Checked = True Then

    '        Dim cryRpt As New ReportDocument
    '        Dim pathfilereport As String
    '        Dim ReportFormula As String
    '        Dim filter1 As String

    '        pathfilereport = Application.StartupPath & "\Report\LapRekapARBalanceTahun.rpt"
    '        Try
    '            cryRpt.Load(pathfilereport)
    '            cryRpt.Refresh()
    '            cryRpt.SetParameterValue(0, Year(th_ap.Value))
    '            If chk_filtersupp_purch.Checked = True Then
    '                filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
    '            Else
    '                filter1 = ""
    '            End If


    '            If filter1 <> "" Then
    '                ReportFormula = filter1
    '                cryRpt.RecordSelectionFormula = ReportFormula
    '            End If

    '            Dim LapDataCustomer_1 As New LapPembelian
    '            LapDataCustomer_1.Show()
    '            ' LapDataCustomer_1.MdiParent = MainMenu
    '            LapDataCustomer_1.WindowState = FormWindowState.Maximized
    '            With LapDataCustomer_1.CRviewer
    '                .ReportSource = cryRpt
    '                .ShowGroupTreeButton = False
    '                .ShowExportButton = True
    '                .DisplayGroupTree = False
    '            End With


    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '    ElseIf rb_ap7.Checked = True Then

    '        Dim cryRpt As New ReportDocument
    '        Dim pathfilereport As String
    '        Dim ReportFormula As String
    '        Dim filter1, filter2 As String

    '        pathfilereport = Application.StartupPath & "\Report\LapPiutangJT.rpt"
    '        Try
    '            cryRpt.Load(pathfilereport)
    '            cryRpt.Refresh()
    '            If chk_filtersupp_purch.Checked = True Then
    '                filter1 = "{view_lap_datacustomer.id_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
    '            Else
    '                filter1 = ""
    '            End If

    '            If chk_filtertgl_ap.Checked = True Then
    '                If filter1 <> "" Then
    '                    filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
    '                Else
    '                    filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(tgl_ap1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(tgl_ap2.Value, "yyyy-MM-dd") & "#"
    '                End If
    '            Else
    '                filter2 = ""
    '            End If

    '            If filter1 <> "" Or filter2 <> "" Then
    '                ReportFormula = filter1 + filter2
    '                cryRpt.RecordSelectionFormula = ReportFormula
    '            End If

    '            Dim LapDataCustomer_1 As New LapPembelian
    '            LapDataCustomer_1.Show()
    '            '  LapDataCustomer_1.MdiParent = MainMenu
    '            LapDataCustomer_1.WindowState = FormWindowState.Maximized
    '            With LapDataCustomer_1.CRviewer
    '                .ReportSource = cryRpt
    '                .ShowGroupTreeButton = False
    '                .ShowExportButton = True
    '                .DisplayGroupTree = False
    '            End With
    '            'cryRpt.SetParameterValue(0, Year(th_ap.Value))

    '        Catch ex As Exception
    '            MsgBox(ex.ToString)
    '        End Try

    '    End If


    'End Sub

    'Private Sub rb_ap3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If rb_ap3.Checked = True Then
    '        gb_filtertgl_ap.Visible = True
    '        gb_filtersupp_ap.Visible = True
    '        gb_filterth_ap.Visible = False
    '    End If
    'End Sub

    'Private Sub rb_ap4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If rb_ap4.Checked = True Then
    '        gb_filtertgl_ap.Visible = True
    '        gb_filtersupp_ap.Visible = True
    '        gb_filterth_ap.Visible = False
    '    End If
    'End Sub

    'Private Sub rb_ap2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If rb_ap2.Checked = True Then
    '        gb_filtertgl_ap.Visible = False
    '        gb_filtersupp_ap.Visible = True
    '        gb_filterth_ap.Visible = False
    '    End If
    'End Sub

    'Private Sub rb_ap5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If rb_ap5.Checked = True Then
    '        gb_filtertgl_ap.Visible = False
    '        gb_filtersupp_ap.Visible = False
    '        gb_filterth_ap.Visible = True
    '    End If
    'End Sub

    'Private Sub rb_ap6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If rb_ap6.Checked = True Then
    '        gb_filtertgl_ap.Visible = False
    '        gb_filtersupp_ap.Visible = False
    '        gb_filterth_ap.Visible = True
    '    End If
    'End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        If TabControl1.SelectedTabPage Is TabPage1 Then
            '  rb_purch1.Checked = True
            'ElseIf TabControl1.SelectedTab Is TabPage2 Then
            '    rb_ap1.Checked = True
        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub choose_report(ByVal value_choose As String)
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False

            If value_choose = "MN_MUTASI_CASHIER_DETAIL" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapKasirDetail.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_lap_detail_transkasir"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.nama_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.nama_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
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
            If value_choose = "MN_MUTASI_CASHIER_RECAP" Then
                Dim cryRpt As New ReportDocument
                Dim pathfilereport As String
                Dim ReportFormula As String
                Dim filter1, filter2 As String

                pathfilereport = Application.StartupPath & "\Report\LapKasirRekap.rpt"
                Try
                    Dim da As New MySqlDataAdapter()
                    Dim ds As New DataSet()
                    Dim qryCompanies As String = "SELECT * FROM view_lap_rekap_transkasir"

                    da.SelectCommand = New MySqlCommand(qryCompanies, conn)

                    Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

                    da.Fill(ds)

                    cryRpt.Load(pathfilereport)
                    cryRpt.SetDataSource(ds.Tables(0))
                    cryRpt.Refresh()
                    If chk_filtersupp_purch.Checked = True Then
                        filter1 = "{view_lap_datacustomer.nama_customer} >= '" & Trim(cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.nama_customer} <= '" & Trim(cbo_supp_purch2.EditValue) & "'"
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

                    If filter1 <> "" Then
                        ReportFormula = filter1
                        cryRpt.RecordSelectionFormula = ReportFormula
                    End If

                    Dim LapDataCustomer_1 As New LapPembelian
                    LapDataCustomer_1.Show()
                    '   LapDataCustomer_1.MdiParent = MainMenu
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
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub
    Private Sub ListReport_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ListReport.SelectedValueChanged
        open_conn()
        If ListReport.SelectedValue = "MN_MUTASI_CASHIER_DETAIL" Then

        End If
        If ListReport.SelectedValue = "MN_MUTASI_CASHIER_RECAP" Then

        End If
    End Sub


    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class