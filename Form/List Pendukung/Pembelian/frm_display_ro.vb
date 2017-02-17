Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frm_display_ro
    Dim i As Integer
    Public formsource_supplier As Boolean
    Public formsource_cust As Boolean
    Public formsource_marketing As Boolean
    Public formsource_journal_noacc As Boolean
    Public formsource_item As Boolean
    Public formsource_ledger As Boolean
    Public formsource_adjustitem As Boolean
    Public formsource_useitem As Boolean
    Public formsource_so_item As Boolean
    Public formsource_sales_item As Boolean
    Public formsource_po_item As Boolean
    Public formsource_ro_item As Boolean
    Public formsource_purchase_item As Boolean
    Public formsource_rptstock_item As Boolean
    Public formsource_trf_wh As Boolean

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        With DataGridView3
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub frm_display_acc_detail_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'open_conn()
        'If formsource_supplier = True Then
        '    formsource_supplier = False
        '    frmsupplier.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_cust = True Then
        '    formsource_cust = False
        '    frmcustomer.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_marketing = True Then
        '    formsource_marketing = False
        '    frmmarketing.Enabled = True
        '    MainMenu.Enabled = True
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
        '    frmledger.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_adjustitem = True Then
        '    formsource_adjustitem = False
        '    frmadjuststock.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        ''If formsource_useitem = True Then
        ''    formsource_useitem = False
        ''    frmsalonservice.Enabled = True
        ''    MainMenu.Enabled = True
        ''End If
        'If formsource_so_item = True Then
        '    formsource_so_item = False
        '    frmso.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_sales_item = True Then
        '    formsource_sales_item = False
        '    frmsales.Enabled = True
        '    frmcashier.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_po_item = True Then
        '    formsource_po_item = False
        '    frmpo.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_purchase_item = True Then
        '    formsource_purchase_item = False
        '    frmpurchase.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_rptstock_item = True Then
        '    formsource_rptstock_item = False
        '    '  FormStockReport.Activate()
        '    '  FormStockReport.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_trf_wh = True Then
        '    formsource_trf_wh = False
        '    frmitemtransfer.Activate()
        '    frmitemtransfer.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_ro_item = True Then
        '    formsource_ro_item = False
        '    MainMenu.Enabled = True
        '    frmRO.Enabled = True
        'End If
    End Sub

    Private Sub frm_display_acc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        cbo_search_item.Text = "ID"
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            cbo_search.Text = "Requisition No"
            rbitem.Checked = True
            DataGridView1.Visible = True
            view_data()
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.ReadOnly = True
            datagrid_layout()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub


    Private Sub view_data_item()
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            'If TabControl1.SelectedTab Is TabList Then
            Dim Rows As Integer
            Dim DT As DataTable

            DT = select_item(Trim(cbo_search_item.Text), Trim(txt_search_item.Text))

            DataGridView3.AutoGenerateColumns = False
            DataGridView3.DataSource = DT
            DataGridView3.Columns(0).DataPropertyName = "id_item"
            DataGridView3.Columns(1).DataPropertyName = "item_name"
            DataGridView3.Columns(2).DataPropertyName = "id_barcode"
            DataGridView3.Columns(3).DataPropertyName = "type"
            DataGridView3.Columns(4).DataPropertyName = "category"
            DataGridView3.Columns(5).DataPropertyName = "brand"
            DataGridView3.Columns(6).DataPropertyName = "id_jenis"
            DataGridView3.Columns(7).DataPropertyName = "id_category"
            DataGridView3.Columns(8).DataPropertyName = "id_brand"

            'Rows = DT.Rows.Count
            'DataGridView1.Rows.Clear()
            'Dim i As Integer
            'If Rows > 0 Then
            '    For i = 0 To DT.Rows.Count - 1
            '        DataGridView1.Rows.Add()
            '        DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
            '        DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
            '        DataGridView1.Item(2, i).Value = DT.Rows(i).Item("id_barcode")
            '        DataGridView1.Item(3, i).Value = DT.Rows(i).Item("type")
            '        DataGridView1.Item(4, i).Value = DT.Rows(i).Item("category")
            '        DataGridView1.Item(5, i).Value = DT.Rows(i).Item("brand")
            '        DataGridView1.Item(6, i).Value = DT.Rows(i).Item("id_jenis")
            '        DataGridView1.Item(7, i).Value = DT.Rows(i).Item("id_category")
            '        DataGridView1.Item(8, i).Value = DT.Rows(i).Item("id_brand")
            '    Next
            'End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub


    Private Sub view_data()
        open_conn()
        'If TabControl1.SelectedTab Is TabList Then
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_ro(Trim(cbo_search.Text), Trim(txt_search.Text))
        Rows = DT.Rows.Count
        DataGridView1.Rows.Clear()
        Dim i As Integer
        If Rows > 0 Then

            For i = 0 To DT.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item(2)
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
                DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item(5)
            Next
        End If
    End Sub


    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Down Then
            DataGridView1.Focus()
            SendKeys.Send(Keys.Down)
        End If
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        open_conn()
        view_data()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        Dim DT, DTUnit As New DataTable
        DT = select_get_price(DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value)
        DTUnit = select_get_defunit(DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value)
        MainMenu.Enabled = True
        If formsource_supplier = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmsupplier
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_cust = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmcustomer
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_marketing = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmmarketing
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account_id.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_journal_noacc = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmjournal
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmitem
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_ledger = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmledger
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_search.Text = DataGridView1.Item(0, i).Value
                .lbl_acc_nm.Text = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_adjustitem = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmadjuststock
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        'If formsource_useitem = True Then
        '    i = DataGridView1.CurrentCell.RowIndex
        '    With frmsalonservice
        '        MainMenu.Enabled = True
        '        .Enabled = True
        '        .Activate()
        '        ' .DataGridView2.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
        '        '.DataGridView2.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
        '    End With
        'End If
        If formsource_so_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmso
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                .DataGridView1.Item(6, .DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_sellprice(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value), 0)
                .DataGridView1.Item(5, .DataGridView1.CurrentCell.RowIndex).Value = get_unit_sell(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value)
            End With
        End If

        If formsource_sales_item = True Then
            Dim i As Integer
            i = DataGridView1.CurrentCell.RowIndex
            With frmcashier
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(0, .mRow).Value = .DataGridView1.CurrentCell.RowIndex + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                .DataGridView1.Item(5, .mRow).Value = DTUnit.Rows(0).Item(0)
                .DataGridView1.Item(8, .mRow).Value = 0
                .DataGridView1.Item(4, .mRow).Value = 0
                .DataGridView1.Item(7, .mRow).Value = 0
                .DataGridView1.Item(9, .mRow).Value = 0
                .DataGridView1.Item(10, .mRow).Value = 1
                Dim TSubTotal As Double

                For i = 0 To .DataGridView1.Rows.Count - 1
                    TSubTotal = TSubTotal + Replace(.DataGridView1.Item(9, i).Value, ",", "")
                Next
                .txt_subtotal.Text = FormatNumber(TSubTotal, 0)

                .hitung_nominal()
            End With
        End If
        If formsource_po_item = True Then
            Dim a As Integer

            i = DataGridView1.CurrentCell.RowIndex
            With frmpo
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(4, .mRow).Value = DataGridView1.Item(3, i).Value
                .DataGridView1.Item(5, .mRow).Value = DataGridView1.Item(4, i).Value
                .DataGridView1.Item(8, .mRow).Value = DataGridView1.Item(2, i).Value
                .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
            End With
        End If
        If formsource_ro_item = True Then
            Dim a As Integer

            i = DataGridView1.CurrentCell.RowIndex
            With frmpo
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Activate()
                .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(4, .mRow).Value = DataGridView1.Item(3, i).Value
                .DataGridView1.Item(5, .mRow).Value = DataGridView1.Item(4, i).Value
                .DataGridView1.Item(8, .mRow).Value = DataGridView1.Item(2, i).Value
            End With
        End If
        If formsource_purchase_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmpurchase
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_rptstock_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            'With FormStockReport
            '    MainMenu.Enabled = True
            '    .Enabled = True
            '    .Activate()
            '    Rpt_Stock_Item = DataGridView1.Item(0, i).Value
            'End With
        End If
        If formsource_trf_wh = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmitemtransfer
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        Dim i As Integer
        If e.KeyCode = Keys.Enter Then
            MainMenu.Enabled = True
            Dim DT, DTUnit As New DataTable
            DT = select_get_price(DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value)
            DTUnit = select_get_defunit(DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value)

            If formsource_supplier = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmsupplier
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_cust = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmcustomer
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_marketing = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmmarketing
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account_id.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_journal_noacc = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmjournal
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                End With
            End If
            If formsource_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmitem
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_ledger = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmledger
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_search.Text = DataGridView1.Item(0, i).Value
                    .lbl_acc_nm.Text = DataGridView1.Item(1, i).Value
                End With
            End If
            If formsource_adjustitem = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmadjuststock
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                End With
            End If
            'If formsource_useitem = True Then
            '    i = DataGridView1.CurrentCell.RowIndex
            '    With frmsalonservice
            '        MainMenu.Enabled = True
            '        .Enabled = True
            '        .Activate()
            '        ' .DataGridView2.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
            '        '.DataGridView2.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            '    End With
            'End If
            If formsource_so_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmso
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                    .DataGridView1.Item(5, .DataGridView1.CurrentCell.RowIndex).Value = get_unit_sell(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value)
                End With
            End If

            If formsource_sales_item = True Then

                i = DataGridView1.CurrentCell.RowIndex
                With frmcashier
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .DataGridView1.CurrentCell.RowIndex + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                    .DataGridView1.Item(8, .mRow).Value = 0
                    .DataGridView1.Item(4, .mRow).Value = 0
                    .DataGridView1.Item(7, .mRow).Value = 0
                    .DataGridView1.Item(9, .mRow).Value = 0
                    .DataGridView1.Item(5, .mRow).Value = DTUnit.Rows(0).Item(0)
                    .DataGridView1.Item(10, .mRow).Value = 1
                    .Enabled = True
                    Dim TSubTotal As Double

                    For i = 0 To .DataGridView1.Rows.Count - 1
                        TSubTotal = TSubTotal + Replace(.DataGridView1.Item(9, i).Value, ",", "")
                    Next
                    .txt_subtotal.Text = FormatNumber(TSubTotal, 0)

                    .hitung_nominal()
                End With
            End If
            If formsource_po_item = True Then
                Dim a As Integer

                i = DataGridView1.CurrentCell.RowIndex
                With frmpo
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.Item(4, .mRow).Value = DataGridView1.Item(3, i).Value
                    .DataGridView1.Item(5, .mRow).Value = DataGridView1.Item(4, i).Value
                    .DataGridView1.Item(8, .mRow).Value = DataGridView1.Item(2, i).Value
                    .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                End With
            End If
            If formsource_ro_item = True Then
                Dim a As Integer

                i = DataGridView1.CurrentCell.RowIndex
                With frmpo
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.Item(4, .mRow).Value = DataGridView1.Item(3, i).Value
                    .DataGridView1.Item(5, .mRow).Value = DataGridView1.Item(4, i).Value
                    .DataGridView1.Item(8, .mRow).Value = DataGridView1.Item(2, i).Value

                End With
            End If
            If formsource_purchase_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmpurchase
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                End With
            End If
            If formsource_rptstock_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                'With FormStockReport
                '    MainMenu.Enabled = True
                '    .Enabled = True
                '    .Activate()
                '    Rpt_Stock_Item = DataGridView1.Item(0, i).Value
                'End With
            End If
            If formsource_trf_wh = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmitemtransfer
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                End With
            End If
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SizeChanged
        open_conn()
        'If rbitem.Checked = True Then
        Dim Total_Width_Column As Integer
        Dim Width_Table As Integer
        Dim selisih_col As Integer

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 50
            .Columns(1).Width = .Columns(1).Width + selisih_col
        End With
        'End If

    End Sub

    'Private Sub rbitem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbitem.CheckedChanged
    '    If rbitem.Checked = True Then
    '        DataGridView1.Visible = True
    '        cbo_search.Text = "ID Barcode"
    '        view_data()
    '    End If
    'End Sub

    Private Sub rbservice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbservice.CheckedChanged
        If rbservice.Checked = True Then
            'DataGridView2.Visible = True
            DataGridView1.Visible = False
            cbo_search.Text = "Nama Barang / Service"
            'view_data_service()
        End If
    End Sub

    'Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    Dim DT, DTUnit As New DataTable
    '    DT = select_get_price_service(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
    '    If formsource_sales_item = True Then
    '        Dim i As Integer
    '        i = DataGridView2.CurrentCell.RowIndex
    '        With frmcashier
    '            For a = 0 To .DataGridView2.Rows.Count - 1
    '                If DataGridView2.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
    '                    MsgBox("ID Service sudah ada", MsgBoxStyle.Information, "Warning")
    '                    Exit Sub
    '                End If
    '            Next
    '            MainMenu.Enabled = True
    '            .Enabled = True
    '            .Activate()
    '            .DataGridView1.Item(0, .mRow).Value = .DataGridView1.CurrentCell.RowIndex + 1
    '            .DataGridView1.Item(1, .mRow).Value = DataGridView2.Item(0, i).Value
    '            .DataGridView1.Item(2, .mRow).Value = DataGridView2.Item(1, i).Value
    '            .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
    '            .DataGridView1.Item(5, .mRow).Value = "Unit"
    '            .DataGridView1.Item(8, .mRow).Value = 0
    '            .DataGridView1.Item(4, .mRow).Value = 0
    '            .DataGridView1.Item(7, .mRow).Value = 0
    '            .DataGridView1.Item(9, .mRow).Value = 0
    '            .DataGridView1.Item(10, .mRow).Value = 2
    '            Dim TSubTotal As Double

    '            For i = 0 To .DataGridView1.Rows.Count - 1
    '                TSubTotal = TSubTotal + Replace(.DataGridView1.Item(9, i).Value, ",", "")
    '            Next
    '            .txt_subtotal.Text = FormatNumber(TSubTotal, 0)

    '            .hitung_nominal()
    '        End With
    '    End If
    '    Me.Close()
    'End Sub

    'Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    open_conn()
    '    Dim DT, DTUnit As New DataTable
    '    If e.KeyCode = Keys.Enter Then
    '        DT = select_get_price_service(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
    '        If formsource_sales_item = True Then
    '            Dim i As Integer
    '            i = DataGridView2.CurrentCell.RowIndex
    '            With frmcashier
    '                For a = 0 To .DataGridView2.Rows.Count - 1
    '                    If DataGridView2.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
    '                        MsgBox("ID Service sudah ada", MsgBoxStyle.Information, "Warning")
    '                        Exit Sub
    '                    End If
    '                Next
    '                MainMenu.Enabled = True
    '                .Enabled = True
    '                .Activate()
    '                .DataGridView1.Item(0, .mRow).Value = .DataGridView1.CurrentCell.RowIndex + 1
    '                .DataGridView1.Item(1, .mRow).Value = DataGridView2.Item(0, i).Value
    '                .DataGridView1.Item(2, .mRow).Value = DataGridView2.Item(1, i).Value
    '                .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
    '                .DataGridView1.Item(5, .mRow).Value = get_DefUnit_General()
    '                .DataGridView1.Item(8, .mRow).Value = 0
    '                .DataGridView1.Item(4, .mRow).Value = 0
    '                .DataGridView1.Item(7, .mRow).Value = 0
    '                .DataGridView1.Item(9, .mRow).Value = 0
    '                .DataGridView1.Item(10, .mRow).Value = 2
    '                Dim TSubTotal As Double

    '                For i = 0 To .DataGridView1.Rows.Count - 1
    '                    TSubTotal = TSubTotal + Replace(.DataGridView1.Item(9, i).Value, ",", "")
    '                Next
    '                .txt_subtotal.Text = FormatNumber(TSubTotal, 0)

    '                .hitung_nominal()
    '            End With
    '        End If
    '    End If
    '    Me.Close()
    'End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub XtraTabPage1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles XtraTabPage1.Paint

    End Sub

    Private Sub TabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabControl1.SelectedPageChanged
        If TabControl1.SelectedTabPage Is XtraTabPage2 Then
            view_data_item()
        End If
    End Sub

    Private Sub txt_search_item_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_search_item.KeyDown
        open_conn()
        If e.KeyCode = Keys.Down Then
            DataGridView3.Focus()
            SendKeys.Send(Keys.Down)
        End If
        If e.KeyCode = Keys.Enter Then
            If rbitem.Checked = True Then
                view_data_item()
            End If
            If rbservice.Checked = True Then

            End If
        End If
    End Sub

    Private Sub DataGridView3_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView3.DoubleClick
        open_conn()
        Dim DT, DTUnit As New DataTable
        ' DT = select_get_price(DataGridView3.Item(0, DataGridView1.CurrentCell.RowIndex).Value)
        ' DTUnit = select_get_defunit(DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value)
        MainMenu.Enabled = True
        If formsource_supplier = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmsupplier
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_cust = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmcustomer
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_marketing = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmmarketing
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account_id.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_journal_noacc = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmjournal
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmitem
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_ledger = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmledger
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_search.Text = DataGridView1.Item(0, i).Value
                .lbl_acc_nm.Text = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_adjustitem = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmadjuststock
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        'If formsource_useitem = True Then
        '    i = DataGridView1.CurrentCell.RowIndex
        '    With frmsalonservice
        '        MainMenu.Enabled = True
        '        .Enabled = True
        '        .Activate()
        '        ' .DataGridView2.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
        '        '.DataGridView2.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
        '    End With
        'End If
        If formsource_so_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmso
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                .DataGridView1.Item(6, .DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_sellprice(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value), 0)
                .DataGridView1.Item(5, .DataGridView1.CurrentCell.RowIndex).Value = get_unit_sell(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value)
            End With
        End If

        If formsource_sales_item = True Then
            Dim i As Integer
            i = DataGridView1.CurrentCell.RowIndex
            With frmcashier
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(0, .mRow).Value = .DataGridView1.CurrentCell.RowIndex + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                .DataGridView1.Item(5, .mRow).Value = DTUnit.Rows(0).Item(0)
                .DataGridView1.Item(8, .mRow).Value = 0
                .DataGridView1.Item(4, .mRow).Value = 0
                .DataGridView1.Item(7, .mRow).Value = 0
                .DataGridView1.Item(9, .mRow).Value = 0
                .DataGridView1.Item(10, .mRow).Value = 1
                Dim TSubTotal As Double

                For i = 0 To .DataGridView1.Rows.Count - 1
                    TSubTotal = TSubTotal + Replace(.DataGridView1.Item(9, i).Value, ",", "")
                Next
                .txt_subtotal.Text = FormatNumber(TSubTotal, 0)

                .hitung_nominal()
            End With
        End If
        If formsource_po_item = True Then
            Dim a As Integer

            i = DataGridView3.CurrentCell.RowIndex
            With frmpo
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView3.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Activate()
                .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView3.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView3.Item(1, i).Value
                .DataGridView1.Item(4, .mRow).Value = 0
                .DataGridView1.Item(5, .mRow).Value = get_unit_buy(DataGridView3.Item(0, i).Value)
                .DataGridView1.Item(8, .mRow).Value = ""
                .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
            End With
        End If
        If formsource_ro_item = True Then
            Dim a As Integer

            i = DataGridView3.CurrentCell.RowIndex
            With frmpo
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView3.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Activate()
                .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView3.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView3.Item(1, i).Value
                .DataGridView1.Item(4, .mRow).Value = 0
                .DataGridView1.Item(5, .mRow).Value = get_unit_buy(DataGridView3.Item(0, i).Value)
                .DataGridView1.Item(8, .mRow).Value = ""
            End With
        End If
        If formsource_purchase_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmpurchase
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_rptstock_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            'With FormStockReport
            '    MainMenu.Enabled = True
            '    .Enabled = True
            '    .Activate()
            '    Rpt_Stock_Item = DataGridView1.Item(0, i).Value
            'End With
        End If
        If formsource_trf_wh = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmitemtransfer
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView3_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView3.KeyDown
        open_conn()
        Dim i As Integer
        If e.KeyCode = Keys.Enter Then
            MainMenu.Enabled = True
            Dim DT, DTUnit As New DataTable
            DT = select_get_price(DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value)
            DTUnit = select_get_defunit(DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value)

            If formsource_supplier = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmsupplier
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_cust = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmcustomer
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_marketing = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmmarketing
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account_id.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_journal_noacc = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmjournal
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                End With
            End If
            If formsource_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmitem
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_ledger = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmledger
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_search.Text = DataGridView1.Item(0, i).Value
                    .lbl_acc_nm.Text = DataGridView1.Item(1, i).Value
                End With
            End If
            If formsource_adjustitem = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmadjuststock
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                End With
            End If
            'If formsource_useitem = True Then
            '    i = DataGridView1.CurrentCell.RowIndex
            '    With frmsalonservice
            '        MainMenu.Enabled = True
            '        .Enabled = True
            '        .Activate()
            '        ' .DataGridView2.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
            '        '.DataGridView2.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            '    End With
            'End If
            If formsource_so_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmso
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                    .DataGridView1.Item(5, .DataGridView1.CurrentCell.RowIndex).Value = get_unit_sell(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value)
                End With
            End If

            If formsource_sales_item = True Then

                i = DataGridView1.CurrentCell.RowIndex
                With frmcashier
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .DataGridView1.CurrentCell.RowIndex + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                    .DataGridView1.Item(8, .mRow).Value = 0
                    .DataGridView1.Item(4, .mRow).Value = 0
                    .DataGridView1.Item(7, .mRow).Value = 0
                    .DataGridView1.Item(9, .mRow).Value = 0
                    .DataGridView1.Item(5, .mRow).Value = DTUnit.Rows(0).Item(0)
                    .DataGridView1.Item(10, .mRow).Value = 1
                    .Enabled = True
                    Dim TSubTotal As Double

                    For i = 0 To .DataGridView1.Rows.Count - 1
                        TSubTotal = TSubTotal + Replace(.DataGridView1.Item(9, i).Value, ",", "")
                    Next
                    .txt_subtotal.Text = FormatNumber(TSubTotal, 0)

                    .hitung_nominal()
                End With
            End If
            If formsource_po_item = True Then
                Dim a As Integer

                i = DataGridView3.CurrentCell.RowIndex
                With frmpo
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView3.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView3.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView3.Item(1, i).Value
                    .DataGridView1.Item(4, .mRow).Value = 0
                    .DataGridView1.Item(5, .mRow).Value = get_unit_buy(DataGridView3.Item(0, i).Value)
                    .DataGridView1.Item(8, .mRow).Value = ""
                    .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                End With
            End If
            If formsource_ro_item = True Then
                Dim a As Integer

                i = DataGridView3.CurrentCell.RowIndex
                With frmpo
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView3.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView3.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView3.Item(1, i).Value
                    .DataGridView1.Item(4, .mRow).Value = 0
                    .DataGridView1.Item(5, .mRow).Value = get_unit_buy(DataGridView3.Item(0, i).Value)
                    .DataGridView1.Item(8, .mRow).Value = ""
                End With
            End If
            If formsource_purchase_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmpurchase
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                End With
            End If
            If formsource_rptstock_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                'With FormStockReport
                '    MainMenu.Enabled = True
                '    .Enabled = True
                '    .Activate()
                '    Rpt_Stock_Item = DataGridView1.Item(0, i).Value
                'End With
            End If
            If formsource_trf_wh = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmitemtransfer
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                End With
            End If
            Me.Close()
        End If
    End Sub
End Class