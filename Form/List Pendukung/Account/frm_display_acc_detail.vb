Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Public Class frm_display_acc_detail
    Dim i As Integer
    Public formsource_supplier As Boolean
    Public formsource_cust As Boolean
    Public formsource_marketing As Boolean
    Public formsource_journal_noacc As Boolean
    Public formsource_adjjournal_noacc As Boolean
    Public formsource_item As Boolean
    Public formsource_service As Boolean
    Public formsource_ledger As Boolean
    Public formsource_spendmoney_accbank As Boolean
    Public formsource_spendmoney_detail As Boolean
    Public formsource_receivemoney_accbank As Boolean
    Public formsource_reconcile As Boolean
    Public formsource_reconcile_detail As Boolean
    Public formsource_receivemoney_detail As Boolean
    Public formsource_frmpayAP As Boolean
    Public formsource_frmpayAR As Boolean
    Public formsource_cost As Boolean
    Public formsource_hpp As Boolean
    Public formsource_setcoa As Boolean
    Public formsource_setcoa_aset As Boolean

    Public formsource_setcoa_depprod1 As Boolean
    Public formsource_setcoa_depprod2 As Boolean
    Public formsource_setcoa_depprod3 As Boolean
    Public formsource_setcoa_depprod4 As Boolean
    Public formsource_setcoa_depprod5 As Boolean
    Public formsource_setcoa_depprod6 As Boolean
    Public formsource_setcoa_depprod7 As Boolean

    Public formsource_setcoa_penyusutan As Boolean
    Public formsource_setcoa_akum As Boolean



    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Down Then
            DataGridView1.Focus()
            SendKeys.Send(Keys.Down)
        End If
    End Sub

    Private Sub frm_display_acc_detail_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If formsource_supplier = True Then
        '    formsource_supplier = False
        '    MainMenu.Enabled = True
        '    frmsupplier.Enabled = True
        'End If
        'If formsource_adjjournal_noacc = True Then
        '    formsource_adjjournal_noacc = False
        '    frmadjustjournal.Enabled = True
        '    frmadjustjournal.Enabled = True
        'End If
        'If formsource_cust = True Then
        '    formsource_cust = False
        '    MainMenu.Enabled = True
        '    frmcustomer.Enabled = True
        'End If
        'If formsource_setcoa = True Then
        '    formsource_setcoa = False
        '    MainMenu.Enabled = True
        '    frmsetcoa.Enabled = True
        'End If
        'If formsource_setcoa_depprod1 = True Then
        '    formsource_setcoa_depprod1 = False
        '    MainMenu.Enabled = True
        '    frmsetcoa_depProduksi.Enabled = True
        'End If
        'If formsource_setcoa_depprod2 = True Then
        '    formsource_setcoa_depprod2 = False
        '    MainMenu.Enabled = True
        '    frmsetcoa_depProduksi.Enabled = True
        'End If
        'If formsource_setcoa_depprod3 = True Then
        '    formsource_setcoa_depprod3 = False
        '    MainMenu.Enabled = True
        '    frmsetcoa_depProduksi.Enabled = True
        'End If
        'If formsource_setcoa_depprod4 = True Then
        '    formsource_setcoa_depprod4 = False
        '    MainMenu.Enabled = True
        '    frmsetcoa_depProduksi.Enabled = True
        'End If
        'If formsource_setcoa_depprod5 = True Then
        '    formsource_setcoa_depprod5 = False
        '    MainMenu.Enabled = True
        '    frmsetcoa_depProduksi.Enabled = True
        'End If
        'If formsource_setcoa_depprod6 = True Then
        '    formsource_setcoa_depprod6 = False
        '    MainMenu.Enabled = True
        '    frmsetcoa_depProduksi.Enabled = True
        'End If
        'If formsource_setcoa_depprod7 = True Then
        '    formsource_setcoa_depprod7 = False
        '    MainMenu.Enabled = True
        '    frmsetcoa_depProduksi.Enabled = True
        'End If
        'If formsource_marketing = True Then
        '    formsource_marketing = False
        '    MainMenu.Enabled = True
        '    frmmarketing.Enabled = True
        'End If
        'If formsource_journal_noacc = True Then
        '    formsource_journal_noacc = False
        '    frmjournal.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_item = True Then
        '    formsource_item = False
        '    frmitem.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_ledger = True Then
        '    formsource_ledger = False
        '    MainMenu.Enabled = True
        '    frmcashregister.Enabled = True
        '    frmledger.Enabled = True
        'End If
        'If formsource_service = True Then
        '    formsource_service = False
        '    frmservice.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_spendmoney_accbank = True Then
        '    formsource_spendmoney_accbank = False
        '    MainMenu.Enabled = True
        '    frmspendmoney.Enabled = True
        'End If
        'If formsource_spendmoney_detail = True Then
        '    formsource_spendmoney_detail = False
        '    MainMenu.Enabled = True
        '    frmspendmoney.Enabled = True
        'End If
        'If formsource_receivemoney_accbank = True Then
        '    formsource_receivemoney_accbank = False
        '    frmreceiptmoney.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_receivemoney_detail = True Then
        '    formsource_receivemoney_detail = False
        '    frmreceiptmoney.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_frmpayAP = True Then
        '    formsource_frmpayAP = False
        '    frmpayAP.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_reconcile = True Then
        '    formsource_reconcile = False
        '    MainMenu.Enabled = True
        '    frmreconcile.Enabled = True
        'End If
        'If formsource_reconcile_detail = True Then
        '    formsource_reconcile_detail = False
        '    MainMenu.Enabled = True
        '    frmreconcile.Enabled = True
        'End If
        'If formsource_cost = True Then
        '    formsource_cost = False
        '    MainMenu.Enabled = True
        '    frmstdcost.Enabled = True
        'End If
        'If formsource_hpp = True Then
        '    formsource_hpp = False
        '    MainMenu.Enabled = True
        '    frmstdcost.Enabled = True
        'End If
        'If formsource_setcoa_akum = True Then
        '    formsource_setcoa_akum = False
        '    MainMenu.Enabled = True
        '    frmsetcoa_depProduksi.Enabled = True
        'End If
        'If formsource_setcoa_aset = True Then
        '    formsource_setcoa_aset = False
        '    MainMenu.Enabled = True
        '    frmsetcoa_depProduksi.Enabled = True
        'End If
        'If formsource_setcoa_penyusutan = True Then
        '    formsource_setcoa_penyusutan = False
        '    MainMenu.Enabled = True
        '    frmsetcoa_depProduksi.Enabled = True
        'End If
    End Sub

    Private Sub frm_display_acc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()

        cbo_search.Text = "Account Name"
        view_data()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.ReadOnly = True
        datagrid_layout()

    End Sub

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub view_data()
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            Dim i As Integer
            Dim Rows As Integer
            Dim DT As DataTable
            DT = select_acc_detail(Trim(cbo_search.Text), Trim(txt_search.Text))
            Rows = DT.Rows.Count - 1
            DataGridView1.Rows.Clear()
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
                'DataGridView1.Item(2, i).Value = DT.Rows(i).Item(2)
                'DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
                'DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
            Next
            ' End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        open_conn()
        view_data()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        i = DataGridView1.CurrentCell.RowIndex
        MainMenu.Enabled = True
        If formsource_supplier = True Then

            With frmsupplier
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_cust = True Then
            With frmcustomer
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_setcoa = True Then
            With frmsetcoa
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(.columnIndex, .rowIndex).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(.columnIndex + 1, .rowIndex).Value = DataGridView1.Item(1, i).Value

            End With
        End If
        If formsource_setcoa_depprod1 = True Or formsource_setcoa_depprod2 = True Or formsource_setcoa_depprod3 = True Or formsource_setcoa_depprod4 = True Or formsource_setcoa_depprod5 = True Or formsource_setcoa_depprod6 = True Or formsource_setcoa_depprod7 = True Then
            With frmsetcoa_depProduksi
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(.columnIndex, .rowIndex).Value = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_setcoa_akum = True Or formsource_setcoa_aset = True Or formsource_setcoa_penyusutan = True Then
            With frmsetcoa_depProduksi
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(.columnIndex, .rowIndex).Value = DataGridView1.Item(0, i).Value
                '.DataGridView1.Item(.columnIndex + 1, .rowIndex).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_marketing = True Then
            With frmmarketing
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account_id.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_journal_noacc = True Then
            With frmjournal
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
            End With
        End If
        If formsource_adjjournal_noacc = True Then
            With frmadjustjournal
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
            End With
        End If
        If formsource_item = True Then
            With frmitem
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_ledger = True Then
            With frmledger
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_search.Text = DataGridView1.Item(0, i).Value
                .lbl_acc_nm.Text = DataGridView1.Item(1, i).Value
            End With
            With frmcashregister
                .cbo_search.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_service = True Then
            With frmservice
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
                .lbl_acc_name.Text = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_cost = True Then
            With frmstdcost
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
                .lbl_acc_name.Text = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_hpp = True Then
            With frmstdcost
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc_hpp.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_spendmoney_accbank = True Then
            With frmspendmoney
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_cashbank.Text = DataGridView1.Item(0, i).Value
                .lb_cashbank_acc.Text = DataGridView1.Item(0, i).Value
                .lb_cashbank_name.Text = DataGridView1.Item(1, i).Value
                .lb_cashbank_acc.Visible = True
                .lb_cashbank_name.Visible = True
            End With
        End If
        If formsource_spendmoney_detail = True Then
            With frmspendmoney
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
            End With
        End If
        If formsource_receivemoney_accbank = True Then
            With frmreceiptmoney
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_cashbank.Text = DataGridView1.Item(0, i).Value
                .lb_cashbank_acc.Text = DataGridView1.Item(0, i).Value
                .lb_cashbank_name.Text = DataGridView1.Item(1, i).Value
                .lb_cashbank_acc.Visible = True
                .lb_cashbank_name.Visible = True
            End With
        End If
        If formsource_receivemoney_detail = True Then
            With frmreceiptmoney
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
            End With
        End If
        If formsource_frmpayAP = True Then
            With frmpayAP
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_frmpayAP = True Then 'add by ani
            With frmpayAP
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_frmpayAR = True Then 'add by ani
            With frmpayAR
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_reconcile = True Then 'add by ani
            'Dim DT As DataTable
            'DT = end_balance_acc(DataGridView1.Item(0, i).Value)
            With frmreconcile
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
                '.txt_balance.Text = FormatNumber(DT.Rows(0).Item("var_saldo"), 0)
            End With
        End If
        If formsource_reconcile_detail = True Then 'add by ani
            'i = DataGridView1.CurrentCell.RowIndex
            With frmreconcile
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
            End With
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            MainMenu.Enabled = True
            i = DataGridView1.CurrentCell.RowIndex
            If formsource_supplier = True Then
                With frmsupplier
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_cost = True Then
                With frmstdcost
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                    .lbl_acc_name.Text = DataGridView1.Item(1, i).Value
                End With
            End If
            If formsource_hpp = True Then
                With frmstdcost
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc_hpp.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_cust = True Then
                With frmcustomer
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_setcoa = True Then
                With frmsetcoa
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(.columnIndex, .rowIndex).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(.columnIndex + 1, .rowIndex).Value = DataGridView1.Item(1, i).Value

                End With
            End If
            If formsource_setcoa_akum = True Or formsource_setcoa_aset = True Or formsource_setcoa_penyusutan = True Then
                With frmsetcoa_depProduksi
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(.columnIndex, .rowIndex).Value = DataGridView1.Item(0, i).Value
                    '.DataGridView1.Item(.columnIndex + 1, .rowIndex).Value = DataGridView1.Item(1, i).Value
                End With
            End If
            If formsource_marketing = True Then
                With frmmarketing
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account_id.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_journal_noacc = True Then
                With frmjournal
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                End With
            End If
            If formsource_adjjournal_noacc = True Then
                With frmadjustjournal
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                End With
            End If
            If formsource_item = True Then
                With frmitem
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_ledger = True Then
                With frmledger
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_search.Text = DataGridView1.Item(0, i).Value
                    .lbl_acc_nm.Text = DataGridView1.Item(1, i).Value
                End With
                With frmcashregister
                    .cbo_search.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_service = True Then
                With frmservice
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                    .lbl_acc_name.Text = DataGridView1.Item(1, i).Value
                End With
            End If
            If formsource_spendmoney_accbank = True Then
                With frmspendmoney
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_cashbank.Text = DataGridView1.Item(0, i).Value
                    .lb_cashbank_acc.Text = DataGridView1.Item(0, i).Value
                    .lb_cashbank_name.Text = DataGridView1.Item(1, i).Value
                    .lb_cashbank_acc.Visible = True
                    .lb_cashbank_name.Visible = True
                End With
            End If
            If formsource_spendmoney_detail = True Then
                With frmspendmoney
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                End With
            End If
            If formsource_receivemoney_accbank = True Then
                With frmreceiptmoney
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_cashbank.Text = DataGridView1.Item(0, i).Value
                    .lb_cashbank_acc.Text = DataGridView1.Item(0, i).Value
                    .lb_cashbank_name.Text = DataGridView1.Item(1, i).Value
                    .lb_cashbank_acc.Visible = True
                    .lb_cashbank_name.Visible = True
                End With
            End If
            If formsource_receivemoney_detail = True Then
                With frmreceiptmoney
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                End With
            End If
            If formsource_frmpayAP = True Then
                With frmpayAP
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_frmpayAP = True Then
                With frmpayAP
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_frmpayAR = True Then
                With frmpayAR
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_reconcile = True Then
                'Dim DT As DataTable
                'DT = end_balance_acc(DataGridView1.Item(0, i).Value)
                With frmreconcile
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                    '.txt_balance.Text = FormatNumber(DT.Rows(0).Item("var_saldo"), 0)
                End With
            End If
            If formsource_reconcile_detail = True Then
                'i = DataGridView1.CurrentCell.RowIndex
                With frmreconcile
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                End With
            End If
            Me.Close()
        End If
    End Sub
End Class