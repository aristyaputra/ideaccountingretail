Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frm_display_item
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
    Public formsource_bom_item As Boolean
    Public formsource_direct_purchase As Boolean
    Dim qty As Double

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        With DataGridView2
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
        'If formsource_direct_purchase = True Then
        '    formsource_direct_purchase = False
        '    frmpurchase_direct.Enabled = True
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
        '    'formsource_rptstock_item = False
        '    'FormStockReport.Activate()
        '    'FormStockReport.Enabled = True
        '    'MainMenu.Enabled = True
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
        'If formsource_bom_item = True Then
        '    formsource_bom_item = False
        '    MainMenu.Enabled = True

        'End If
    End Sub

    Private Sub frm_display_acc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
       
            cbo_search.Text = "ID"
            rbitem.Checked = True
            DataGridView1.Visible = True
            'view_data()
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.ReadOnly = True
            datagrid_layout()
       
    End Sub

    Private Sub view_data()
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            'If TabControl1.SelectedTab Is TabList Then
            Dim Rows As Integer
            Dim DT As DataTable
            DT = select_item(Trim(cbo_search.Text), Trim(txt_search.Text))

            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = DT
            DataGridView1.Columns(0).DataPropertyName = "id_item"
            DataGridView1.Columns(1).DataPropertyName = "item_name"
            DataGridView1.Columns(2).DataPropertyName = "id_barcode"
            DataGridView1.Columns(3).DataPropertyName = "type"
            DataGridView1.Columns(4).DataPropertyName = "category"
            DataGridView1.Columns(5).DataPropertyName = "brand"
            DataGridView1.Columns(6).DataPropertyName = "id_jenis"
            DataGridView1.Columns(7).DataPropertyName = "id_category"
            DataGridView1.Columns(8).DataPropertyName = "id_brand"

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

    Private Sub view_data_service()
        open_conn()
        'If TabControl1.SelectedTab Is TabList Then
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_service_kasir(Trim(cbo_search.Text), Trim(txt_search.Text))

        DataGridView2.AutoGenerateColumns = False
        DataGridView2.DataSource = DT
        DataGridView2.Columns(0).DataPropertyName = "id_service"
        DataGridView2.Columns(1).DataPropertyName = "service_name"


        'Rows = DT.Rows.Count
        'DataGridView2.Rows.Clear()
        'Dim i As Integer
        'If Rows > 0 Then
        '    For i = 0 To DT.Rows.Count - 1
        '        DataGridView2.Rows.Add()
        '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
        '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
        '        'DataGridView1.Item(2, i).Value = DT.Rows(i).Item(2)
        '        'DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
        '        'DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
        '    Next
        'End If
    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        open_conn()
        If e.KeyCode = Keys.Down Then
            DataGridView1.Focus()
            SendKeys.Send(Keys.Down)
        End If
        If e.KeyCode = Keys.Enter Then
            If rbitem.Checked = True Then
                view_data()
            End If
            If rbservice.Checked = True Then
                view_data_service()
            End If
        End If
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        open_conn()
        If Len(txt_search.Text) = 10 And Trim(cbo_search.Text) = "ID" Then
            view_data()
            DataGridView1_DoubleClick(sender, e)
        End If
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
            Me.Close()
        End If
        If formsource_cust = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmcustomer
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account.Text = DataGridView1.Item(0, i).Value
            End With
            Me.Close()
        End If
        If formsource_marketing = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmmarketing
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_account_id.Text = DataGridView1.Item(0, i).Value
            End With
            Me.Close()
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
            Me.Close()
        End If
        If formsource_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmitem
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
            End With
            Me.Close()
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
            Me.Close()
        End If
        If formsource_adjustitem = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmadjuststock
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(6, .mRow).Value = DTUnit.Rows(0).Item(0)
            End With
            Me.Close()
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
        '    Me.Close()
        'End If
        If formsource_so_item = True Then

            Dim TSubtotal As Double
            Dim rows, rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
            TSubtotal = 0
            i = DataGridView1.CurrentCell.RowIndex

            If cek_qty_stock(DataGridView1.Item(0, i).Value) <= 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Stok barang tidak tersedia")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If

            With frmso
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang tersebut sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                ' MainMenu.Enabled = True
                '.Enabled = True
                ' .Activate()
                .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(4, .mRow).Value = 1
                .DataGridView1.Item(6, .DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_sellprice(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value), 0)
                .DataGridView1.Item(5, .DataGridView1.CurrentCell.RowIndex).Value = get_unit_sell(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value)
                .DataGridView1.Item(7, .DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_sellprice(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value), 0)
                .DataGridView1.Item(8, .DataGridView1.CurrentCell.RowIndex).Value = DataGridView1.Item(6, i).Value
                .DataGridView1.Item(9, .DataGridView1.CurrentCell.RowIndex).Value = DataGridView1.Item(7, i).Value
                .DataGridView1.Item(10, .DataGridView1.CurrentCell.RowIndex).Value = DataGridView1.Item(8, i).Value


                If .chk_brand.Checked = True And get_disc_brand(.DataGridView1.Item(10, .mRow).Value) > 0 Then
                    .DataGridView3.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView3.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView3.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView3.Item(3, .mRow).Value = FormatNumber((get_disc_brand(.DataGridView1.Item(10, .mRow).Value)) / 100 * Replace(.DataGridView1.Item(7, .mRow).Value, ",", ""), 0)
                End If

                If .chk_type.Checked = True And get_disc_type(.DataGridView1.Item(8, .mRow).Value) > 0 Then
                    .DataGridView4.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView4.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView4.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView4.Item(3, .mRow).Value = FormatNumber((get_disc_type(.DataGridView1.Item(8, .mRow).Value)) / 100 * Replace(.DataGridView1.Item(7, .mRow).Value, ",", ""), 0)
                End If

                If .chk_category.Checked = True And get_disc_cat(.DataGridView1.Item(9, .mRow).Value) > 0 Then
                    .DataGridView5.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView5.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView5.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView5.Item(3, .mRow).Value = FormatNumber((get_disc_cat(.DataGridView1.Item(9, .mRow).Value)) / 100 * Replace(.DataGridView1.Item(7, .mRow).Value, ",", ""), 0)
                End If

                Dim DTDisc As DataTable
                If .chk_item.Checked = True Then
                    If .DataGridView1.Item(4, .mRow).Value >= get_qty_todisc(DataGridView1.Item(0, i).Value) Then
                        DTDisc = get_disc_otheritem(DataGridView1.Item(0, i).Value)
                        If DTDisc.Rows.Count > 0 Then
                            For x As Integer = 0 To DTDisc.Rows.Count - 1
                                .DataGridView6.Item(0, x).Value = x + 1
                                .DataGridView6.Item(1, x).Value = DTDisc.Rows(x).Item("id_item_disc")
                                .DataGridView6.Item(2, x).Value = DTDisc.Rows(x).Item("item_name_disc")
                                .DataGridView6.Item(3, x).Value = DTDisc.Rows(x).Item("qty")
                                .DataGridView6.Item(4, x).Value = DTDisc.Rows(x).Item("id_unit")
                            Next
                        End If
                    End If
                End If


                .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                .DataGridView3.CurrentCell = .DataGridView3.Rows(.mRow + 1).Cells(1)
                .DataGridView4.CurrentCell = .DataGridView4.Rows(.mRow + 1).Cells(1)
                .DataGridView5.CurrentCell = .DataGridView5.Rows(.mRow + 1).Cells(1)
                .DataGridView6.CurrentCell = .DataGridView6.Rows(.mRow + 1).Cells(1)


                Dim tDisc_brand As Double
                Dim tDisc_type As Double
                Dim tDisc_cat As Double

                If .chk_brand.Checked = True Then
                    rows_disc_brand = .DataGridView3.Rows.Count - 1
                    For i As Integer = 0 To rows_disc_brand
                        tDisc_brand = tDisc_brand + Replace(.DataGridView3.Item(3, i).Value, ",", "")
                    Next
                End If

                If .chk_type.Checked = True Then
                    rows_disc_type = .DataGridView4.Rows.Count - 1
                    For i As Integer = 0 To rows_disc_type
                        tDisc_type = tDisc_type + Replace(.DataGridView4.Item(3, i).Value, ",", "")
                    Next
                End If

                If .chk_category.Checked = True Then
                    rows_disc_cat = .DataGridView5.Rows.Count - 1
                    For i As Integer = 0 To rows_disc_cat
                        tDisc_cat = tDisc_cat + Replace(.DataGridView5.Item(3, i).Value, ",", "")
                    Next
                End If

                rows = .DataGridView1.Rows.Count - 1
                For i As Integer = 0 To rows
                    TSubtotal = TSubtotal + Replace(.DataGridView1.Item(7, i).Value, ",", "")
                Next
                TSubtotal = TSubtotal - tDisc_brand - tDisc_type - tDisc_cat
                .txt_subtotal.Text = FormatNumber(TSubtotal, 0)

                Dim TNett As Double
                Dim Ttotal As Double
                Dim Tchange As Double

                TNett = 0
                Ttotal = 0
                Tchange = 0

                'menghitung(netto)
                TNett = TSubtotal - (TSubtotal * CDbl(Replace(.txt_disc.Text, "%", "")) / 100)
                .txt_netto.Text = FormatNumber(TNett, 0)

                'menghitung tax
                If .chk_ppn.Checked = True Then
                    Dim DTX As DataTable
                    DTX = get_tax_rate("PPN")
                    .txt_tax.Text = DTX.Rows(0).Item(0)
                    .txt_tax_nominal.Text = FormatNumber((DTX.Rows(0).Item(0) / 100) * (CDbl(Replace(TNett, ",", ""))), 0)
                ElseIf .chk_ppn.Checked = False Then
                    .txt_tax.Text = 0
                    .txt_tax_nominal.Text = 0
                End If

                'menghitung total
                Ttotal = TNett + (TNett * (CDbl(Replace(.txt_tax.Text, "%", "")) / 100))
                .txt_total.Text = FormatNumber(Ttotal, 0)

            End With


            'Me.Close()
        End If

        If formsource_direct_purchase = True Then

            Dim TSubtotal As Double
            Dim rows As Integer
            TSubtotal = 0
            i = DataGridView1.CurrentCell.RowIndex
            With frmpurchase_direct
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang tersebut sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                ' MainMenu.Enabled = True
                '.Enabled = True
                ' .Activate()
                .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(4, .mRow).Value = 1
                '.DataGridView1.Item(6, .DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_sellprice(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value), 0)
                '.DataGridView1.Item(5, .DataGridView1.CurrentCell.RowIndex).Value = get_unit_sell(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value)
                '.DataGridView1.Item(7, .DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_sellprice(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value), 0)
                '.DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                rows = .DataGridView1.Rows.Count - 1
                For i = 0 To rows
                    TSubtotal = TSubtotal + Replace(.DataGridView1.Item(7, i).Value, ",", "")
                Next
                .txt_subtotal.Text = FormatNumber(TSubtotal, 0)

                Dim TNett As Double
                Dim Ttotal As Double
                Dim Tchange As Double

                TNett = 0
                Ttotal = 0
                Tchange = 0

                'menghitung netto
                'TNett = TSubTotal - (TSubTotal * CDbl(Replace(txt_disc.Text, "%", "")) / 100)
                'txt_netto.Text = FormatNumber(TNett, 0)
                Ttotal = TSubtotal + (TSubtotal * (CDbl(Replace(.txt_tax.Text, "%", "")) / 100))

                'menghitung total
                .txt_amount.Text = FormatNumber(Ttotal, 0)

            End With


            'Me.Close()
        End If

        If formsource_sales_item = True Then
            Dim i As Integer
            Dim cRow As Integer
            i = DataGridView1.CurrentCell.RowIndex
            With frmcashier
                cRow = .mRow
                qty = 1
                If Not IsNumeric(qty) Then
                    qty = 0
                End If

                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang tersebut sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                ' MainMenu.Enabled = True
                ' .Enabled = True
                ' .Activate()
                .DataGridView1.Item(0, .mRow).Value = .DataGridView1.CurrentCell.RowIndex + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(4, .mRow).Value = qty
                .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                .DataGridView1.Item(5, .mRow).Value = DTUnit.Rows(0).Item(0)
                .DataGridView1.Item(8, .mRow).Value = 0
                .DataGridView1.Item(7, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                .DataGridView1.Item(9, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                .DataGridView1.Item(10, .mRow).Value = qty
                .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                Dim TSubTotal As Double
                TSubTotal = 0
                Dim DT_stock As DataTable
                DT_stock = select_get_stock(.DataGridView1.Item(1, .mRow).Value)
                If DT_stock.Rows(0).Item(0) < .DataGridView1.Item(4, .mRow).Value And .DataGridView1.Item(10, .mRow).Value = 1 Then
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Qty " & DT_stock.Rows(0).Item(0) & " lebih besar dari SO")
                    alertControl_warning.Show(Me, info)
                    .DataGridView1.Item(4, .mRow).Value = 0
                End If
                .DataGridView1.Item(7, cRow).Value = FormatNumber(.DataGridView1.Item(4, cRow).Value * .DataGridView1.Item(6, cRow).Value, 0)
                .DataGridView1.Item(9, cRow).Value = FormatNumber(.DataGridView1.Item(4, cRow).Value * .DataGridView1.Item(6, cRow).Value, 0)
                For a = 0 To .DataGridView1.Rows.Count - 1
                    TSubTotal = TSubTotal + Replace(.DataGridView1.Item(9, a).Value, ",", "")
                Next
                .txt_subtotal.Text = FormatNumber(TSubTotal, 0)

                .hitung_nominal()
                Dim info2 As AlertInfo = New AlertInfo("Berhasil ditambahkan", "Barang " & DataGridView1.Item(0, i).Value & "ditambahkan di detail")
                alertControl_success.Show(Me, info2)
            End With
            ' Me.Close()
        End If
        If formsource_po_item = True Then
            Dim a As Integer

            i = DataGridView1.CurrentCell.RowIndex
            With frmpo
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang tersebut sudah ada di detail")
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
            Me.Close()
        End If
        If formsource_ro_item = True Then
            Dim a As Integer

            i = DataGridView1.CurrentCell.RowIndex
            With frmRO
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang tersebut sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                '.Activate()
                '.Enabled = True
                ' .DataGridView1.Rows.Add()
                .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(4, .mRow).Value = 1
                .DataGridView1.Item(5, .mRow).Value = get_unit_buy(DataGridView1.Item(0, i).Value)
                .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
            End With
            'Me.Close()
        End If
        If formsource_purchase_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmpurchase_langsung
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang tersebut sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                .DataGridView1.Item(6, .mRow).Value = get_unit_buy(DataGridView1.Item(0, i).Value)
            End With
            Me.Close()
        End If
        If formsource_rptstock_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            'With FormStockReport
            '    MainMenu.Enabled = True
            '    .Enabled = True
            '    .Activate()
            '    Rpt_Stock_Item = DataGridView1.Item(0, i).Value
            'End With
            Me.Close()
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
            Me.Close()
        End If
        If formsource_bom_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmbom
                For a = 0 To .DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang tersebut sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .txt_item_nm.Text = DataGridView1.Item(1, i).Value
                '.txt_customer_nm.Text = DataGridView1.Item(2, i).Value
                .txt_qty.Text = 1
            End With
            Me.Close()
        End If

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
                Me.Close()
            End If
            If formsource_cust = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmcustomer
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account.Text = DataGridView1.Item(0, i).Value
                End With
                Me.Close()
            End If
            If formsource_marketing = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmmarketing
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account_id.Text = DataGridView1.Item(0, i).Value
                End With
                Me.Close()
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
                Me.Close()
            End If
            If formsource_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmitem
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                End With
                Me.Close()
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
                Me.Close()
            End If
            If formsource_adjustitem = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmadjuststock
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.Item(6, .mRow).Value = DTUnit.Rows(0).Item(0)
                End With
                Me.Close()
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
            '    Me.Close()
            'End If
            If formsource_so_item = True Then
                Dim TSubtotal As Double
                Dim rows, rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
                TSubtotal = 0
                i = DataGridView1.CurrentCell.RowIndex
                If cek_qty_stock(DataGridView1.Item(0, i).Value) <= 0 Then
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Stok item tidak tersedia")
                    alertControl_warning.Show(Me, info)
                    Exit Sub
                End If
                With frmso
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang tersebut sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    ' MainMenu.Enabled = True
                    '.Enabled = True
                    ' .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.Item(4, .mRow).Value = 1
                    .DataGridView1.Item(6, .DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_sellprice(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value), 0)
                    .DataGridView1.Item(5, .DataGridView1.CurrentCell.RowIndex).Value = get_unit_sell(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value)
                    .DataGridView1.Item(7, .DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_sellprice(.DataGridView1.Item(1, .DataGridView1.CurrentCell.RowIndex).Value), 0)
                    .DataGridView1.Item(8, .DataGridView1.CurrentCell.RowIndex).Value = DataGridView1.Item(6, i).Value
                    .DataGridView1.Item(9, .DataGridView1.CurrentCell.RowIndex).Value = DataGridView1.Item(7, i).Value
                    .DataGridView1.Item(10, .DataGridView1.CurrentCell.RowIndex).Value = DataGridView1.Item(8, i).Value


                    If .chk_brand.Checked = True And get_disc_brand(.DataGridView1.Item(10, .mRow).Value) > 0 Then
                        .DataGridView3.Item(0, .mRow).Value = .mRow + 1
                        .DataGridView3.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                        .DataGridView3.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                        .DataGridView3.Item(3, .mRow).Value = FormatNumber((get_disc_brand(.DataGridView1.Item(10, .mRow).Value)) / 100 * Replace(.DataGridView1.Item(7, .mRow).Value, ",", ""), 0)
                    End If

                    If .chk_type.Checked = True And get_disc_type(.DataGridView1.Item(8, .mRow).Value) > 0 Then
                        .DataGridView4.Item(0, .mRow).Value = .mRow + 1
                        .DataGridView4.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                        .DataGridView4.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                        .DataGridView4.Item(3, .mRow).Value = FormatNumber((get_disc_type(.DataGridView1.Item(8, .mRow).Value)) / 100 * Replace(.DataGridView1.Item(7, .mRow).Value, ",", ""), 0)
                    End If

                    If .chk_category.Checked = True And get_disc_cat(.DataGridView1.Item(9, .mRow).Value) > 0 Then
                        .DataGridView5.Item(0, .mRow).Value = .mRow + 1
                        .DataGridView5.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                        .DataGridView5.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                        .DataGridView5.Item(3, .mRow).Value = FormatNumber((get_disc_cat(.DataGridView1.Item(9, .mRow).Value)) / 100 * Replace(.DataGridView1.Item(7, .mRow).Value, ",", ""), 0)
                    End If

                    Dim DTDisc As DataTable
                    If .chk_item.Checked = True Then
                        If .DataGridView1.Item(4, .mRow).Value >= get_qty_todisc(DataGridView1.Item(0, i).Value) Then
                            DTDisc = get_disc_otheritem(DataGridView1.Item(0, i).Value)
                            If DTDisc.Rows.Count > 0 Then
                                For x As Integer = 0 To DTDisc.Rows.Count - 1
                                    .DataGridView6.Item(0, x).Value = x + 1
                                    .DataGridView6.Item(1, x).Value = DTDisc.Rows(x).Item("id_item_disc")
                                    .DataGridView6.Item(2, x).Value = DTDisc.Rows(x).Item("item_name_disc")
                                    .DataGridView6.Item(3, x).Value = DTDisc.Rows(x).Item("qty")
                                    .DataGridView6.Item(4, x).Value = DTDisc.Rows(x).Item("id_unit")
                                Next
                            End If
                        End If
                    End If


                    .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                    .DataGridView3.CurrentCell = .DataGridView3.Rows(.mRow + 1).Cells(1)
                    .DataGridView4.CurrentCell = .DataGridView4.Rows(.mRow + 1).Cells(1)
                    .DataGridView5.CurrentCell = .DataGridView5.Rows(.mRow + 1).Cells(1)
                    .DataGridView6.CurrentCell = .DataGridView6.Rows(.mRow + 1).Cells(1)


                    Dim tDisc_brand As Double
                    Dim tDisc_type As Double
                    Dim tDisc_cat As Double
                    tDisc_brand = 0
                    tDisc_type = 0
                    tDisc_cat = 0

                    If .chk_brand.Checked = True Then
                        rows_disc_brand = .DataGridView3.Rows.Count - 1
                        For a As Integer = 0 To rows_disc_brand
                            tDisc_brand = tDisc_brand + Replace(.DataGridView3.Item(3, a).Value, ",", "")
                        Next
                    End If

                    If .chk_type.Checked = True Then
                        rows_disc_type = .DataGridView4.Rows.Count - 1
                        For b As Integer = 0 To rows_disc_type
                            tDisc_type = tDisc_type + Replace(.DataGridView4.Item(3, b).Value, ",", "")
                        Next
                    End If

                    If .chk_category.Checked = True Then
                        rows_disc_cat = .DataGridView5.Rows.Count - 1
                        For c As Integer = 0 To rows_disc_cat
                            tDisc_cat = tDisc_cat + Replace(.DataGridView5.Item(3, c).Value, ",", "")
                        Next
                    End If

                    rows = .DataGridView1.Rows.Count - 1
                    For d As Integer = 0 To rows
                        TSubtotal = TSubtotal + Replace(.DataGridView1.Item(7, d).Value, ",", "")
                    Next
                    TSubtotal = TSubtotal - tDisc_brand - tDisc_type - tDisc_cat
                    .txt_subtotal.Text = FormatNumber(TSubtotal, 0)

                    Dim TNett As Double
                    Dim Ttotal As Double
                    Dim Tchange As Double

                    TNett = 0
                    Ttotal = 0
                    Tchange = 0

                    'menghitung(netto)
                    TNett = TSubtotal - (TSubtotal * CDbl(Replace(.txt_disc.Text, "%", "")) / 100)
                    .txt_netto.Text = FormatNumber(TNett, 0)

                    'menghitung tax
                    If .chk_ppn.Checked = True Then
                        Dim DTX As DataTable
                        DTX = get_tax_rate("PPN")
                        .txt_tax.Text = DTX.Rows(0).Item(0)
                        .txt_tax_nominal.Text = FormatNumber((DTX.Rows(0).Item(0) / 100) * (CDbl(Replace(TNett, ",", ""))), 0)
                    ElseIf .chk_ppn.Checked = False Then
                        .txt_tax.Text = 0
                        .txt_tax_nominal.Text = 0
                    End If

                    'menghitung total
                    Ttotal = TNett + (TNett * (CDbl(Replace(.txt_tax.Text, "%", "")) / 100))
                    .txt_total.Text = FormatNumber(Ttotal, 0)

                End With


                'Me.Close()
            End If

            If formsource_sales_item = True Then
                Dim cRow As Integer
                i = DataGridView1.CurrentCell.RowIndex
                With frmcashier
                    cRow = .mRow
                    qty = InputBox("Fill Qty", "Item Qty")
                    If Not IsNumeric(qty) Then
                        qty = 0
                    End If
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    ' MainMenu.Enabled = True
                    ' .Enabled = True
                    ' .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .DataGridView1.CurrentCell.RowIndex + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.Item(4, .mRow).Value = qty
                    .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                    .DataGridView1.Item(5, .mRow).Value = DTUnit.Rows(0).Item(0)
                    .DataGridView1.Item(8, .mRow).Value = 0
                    .DataGridView1.Item(7, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                    .DataGridView1.Item(9, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                    .DataGridView1.Item(10, .mRow).Value = qty
                    .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                    Dim TSubTotal As Double
                    TSubTotal = 0
                    Dim DT_stock As DataTable
                    DT_stock = select_get_stock(.DataGridView1.Item(1, .mRow).Value)
                    If DT_stock.Rows(0).Item(0) < .DataGridView1.Item(4, .mRow).Value And .DataGridView1.Item(10, .mRow).Value = 1 Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Stock Qty " & DT_stock.Rows(0).Item(0) & " less than requirement")
                        alertControl_warning.Show(Me, info)
                        .DataGridView1.Item(4, .mRow).Value = 0
                    End If
                    .DataGridView1.Item(7, cRow).Value = FormatNumber(.DataGridView1.Item(4, cRow).Value * .DataGridView1.Item(6, cRow).Value, 0)
                    .DataGridView1.Item(9, cRow).Value = FormatNumber(.DataGridView1.Item(4, cRow).Value * .DataGridView1.Item(6, cRow).Value, 0)
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        TSubTotal = TSubTotal + Replace(.DataGridView1.Item(9, a).Value, ",", "")
                    Next
                    .txt_subtotal.Text = FormatNumber(TSubTotal, 0)

                    .hitung_nominal()
                End With
                ' Me.Close()
            End If
            If formsource_po_item = True Then
                Dim a As Integer

                i = DataGridView1.CurrentCell.RowIndex
                With frmpo
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang sudah ada di detail")
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
                Me.Close()
            End If
            If formsource_ro_item = True Then
                Dim a As Integer

                i = DataGridView1.CurrentCell.RowIndex
                With frmRO
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    '.Enabled = True
                    '.Activate()
                    '.DataGridView1.Rows.Add()
                    .DataGridView1.Item(0, .mRow).Value = .mRow + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
                    .DataGridView1.Item(4, .mRow).Value = 1
                    .DataGridView1.Item(5, .mRow).Value = get_unit_buy(DataGridView1.Item(0, i).Value)
                    .DataGridView1.CurrentCell = .DataGridView1.Rows(.mRow + 1).Cells(1)
                End With
                'Me.Close()
            End If
            If formsource_purchase_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmpurchase_langsung
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang sudah ada di detail")
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
                Me.Close()
            End If
            If formsource_rptstock_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                'With FormStockReport
                '    MainMenu.Enabled = True
                '    .Enabled = True
                '    .Activate()
                '    Rpt_Stock_Item = DataGridView1.Item(0, i).Value
                'End With
                Me.Close()
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
                Me.Close()
            End If
            If formsource_bom_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmbom
                    For a = 0 To .DataGridView1.Rows.Count - 1
                        If DataGridView1.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()

                    .txt_item_nm.Text = DataGridView1.Item(1, i).Value
                    .txt_qty.Text = 1
                    '.txt_customer_nm.Text = DataGridView1.Item(2, i).Value
                End With
                Me.Close()
            End If

        End If
    End Sub

    Private Sub DataGridView1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SizeChanged
        open_conn()
        If rbitem.Checked = True Then
            Dim Total_Width_Column As Integer
            Dim Width_Table As Integer
            Dim selisih_col As Integer

            With DataGridView1
                Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width
                Width_Table = .Width
                selisih_col = Width_Table - Total_Width_Column - 50
                .Columns(1).Width = .Columns(1).Width + selisih_col
            End With
        End If

        If rbservice.Checked = True Then
            Dim Total_Width_Column2 As Integer
            Dim Width_Table2 As Integer
            Dim selisih_col2 As Integer

            With DataGridView2
                Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width
                Width_Table2 = .Width
                selisih_col2 = Width_Table2 - Total_Width_Column2 - 50
                .Columns(1).Width = .Columns(1).Width + selisih_col2
            End With
        End If
    End Sub

    Private Sub rbitem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbitem.CheckedChanged
        If rbitem.Checked = True Then
            DataGridView1.Visible = True
            DataGridView2.Visible = False
            cbo_search.Text = "ID"
            view_data()
        End If
    End Sub

    Private Sub rbservice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbservice.CheckedChanged
        If rbservice.Checked = True Then
            DataGridView2.Visible = True
            DataGridView1.Visible = False
            cbo_search.Text = "Name"
            view_data_service()
        End If
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        Dim DT, DTUnit As New DataTable
        DT = select_get_price_service(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
        If formsource_sales_item = True Then
            Dim i As Integer
            i = DataGridView2.CurrentCell.RowIndex
            With frmcashier
                For a = 0 To .DataGridView2.Rows.Count - 1
                    If DataGridView2.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item sudah ada di detail")
                        alertControl_warning.Show(Me, info)
                        Exit Sub
                    End If
                Next
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(0, .mRow).Value = .DataGridView1.CurrentCell.RowIndex + 1
                .DataGridView1.Item(1, .mRow).Value = DataGridView2.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView2.Item(1, i).Value
                .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                .DataGridView1.Item(5, .mRow).Value = "Unit"
                .DataGridView1.Item(8, .mRow).Value = 0
                .DataGridView1.Item(4, .mRow).Value = 0
                .DataGridView1.Item(7, .mRow).Value = 0
                .DataGridView1.Item(9, .mRow).Value = 0
                .DataGridView1.Item(10, .mRow).Value = 2
                Dim TSubTotal As Double

                For i = 0 To .DataGridView1.Rows.Count - 1
                    TSubTotal = TSubTotal + Replace(.DataGridView1.Item(9, i).Value, ",", "")
                Next
                .txt_subtotal.Text = FormatNumber(TSubTotal, 0)

                .hitung_nominal()
            End With
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
        open_conn()
        Dim DT, DTUnit As New DataTable
        If e.KeyCode = Keys.Enter Then
            DT = select_get_price_service(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
            If formsource_sales_item = True Then
                Dim i As Integer
                i = DataGridView2.CurrentCell.RowIndex
                With frmcashier
                    For a = 0 To .DataGridView2.Rows.Count - 1
                        If DataGridView2.Item(0, i).Value = .DataGridView1.Item(1, a).Value Then
                            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Barang sudah ada di detail")
                            alertControl_warning.Show(Me, info)
                            Exit Sub
                        End If
                    Next
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .DataGridView1.Item(0, .mRow).Value = .DataGridView1.CurrentCell.RowIndex + 1
                    .DataGridView1.Item(1, .mRow).Value = DataGridView2.Item(0, i).Value
                    .DataGridView1.Item(2, .mRow).Value = DataGridView2.Item(1, i).Value
                    .DataGridView1.Item(6, .mRow).Value = FormatNumber(DT.Rows(0).Item(0), 0)
                    .DataGridView1.Item(5, .mRow).Value = get_DefUnit_General()
                    .DataGridView1.Item(8, .mRow).Value = 0
                    .DataGridView1.Item(4, .mRow).Value = 0
                    .DataGridView1.Item(7, .mRow).Value = 0
                    .DataGridView1.Item(9, .mRow).Value = 0
                    .DataGridView1.Item(10, .mRow).Value = 2
                    Dim TSubTotal As Double

                    For i = 0 To .DataGridView1.Rows.Count - 1
                        TSubTotal = TSubTotal + Replace(.DataGridView1.Item(9, i).Value, ",", "")
                    Next
                    .txt_subtotal.Text = FormatNumber(TSubTotal, 0)

                    .hitung_nominal()
                End With
            End If
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frm_display_item_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

    End Sub

    Private Function cek_qty_stock(ByVal item_id As String) As Double
        Dim DT_stock As DataTable
        DT_stock = select_get_stock(item_id)
        Return DT_stock.Rows(0).Item(0)
    End Function

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class