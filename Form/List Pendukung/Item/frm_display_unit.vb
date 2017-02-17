Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Public Class frm_display_unit
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
    Public formsource_so_unit As Boolean
    Public formsource_po_unit As Boolean
    Public formsource_sales_unit As Boolean
    Public formsource_purchase_unit As Boolean
    Public formsource_trf_wh As Boolean
    Public formsource_ro_unit As Boolean
    Public formsource_BOM As Boolean
    Public formsource_itemdisc_unit As Boolean

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
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
        'If formsource_so_unit = True Then
        '    formsource_so_unit = False
        '    frmso.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_sales_unit = True Then
        '    formsource_sales_unit = False
        '    frmcashier.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_po_unit = True Then
        '    formsource_po_unit = False
        '    frmpo.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_purchase_unit = True Then
        '    formsource_purchase_unit = False
        '    frmpurchase.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_trf_wh = True Then
        '    formsource_trf_wh = False
        '    frmitemtransfer.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_ro_unit = True Then
        '    formsource_ro_unit = False
        '    MainMenu.Enabled = True
        'End If
        'If formsource_BOM = True Then
        '    formsource_BOM = False
        '    MainMenu.Enabled = True
        'End If

    End Sub

    Private Sub frm_display_acc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            cbo_search.Text = "Unit ID"
            view_data()
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.ReadOnly = True
            datagrid_layout()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub view_data()
        open_conn()
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_unit_sales(Trim(cbo_search.Text), Trim(txt_search.Text))
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
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        open_conn()
        view_data()
    End Sub

    Private Sub generate()
        open_conn()
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
                .DataGridView1.Item(6, .mRow).Value = DataGridView1.Item(0, i).Value
            End With
        End If
        'If formsource_useitem = True Then
        '    i = DataGridView1.CurrentCell.RowIndex
        '    With frmsalonservice
        '        MainMenu.Enabled = True
        '        .Enabled = True
        '        .Activate()
        '        '.DataGridView2.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
        '        '.DataGridView2.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
        '    End With
        'End If
        If formsource_so_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmso
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_so_unit = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmso
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(5, .mRow).Value = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_sales_unit = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmcashier
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(5, .mRow).Value = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_po_unit = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmpo
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(5, .mRow).Value = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_ro_unit = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmRO
                MainMenu.Enabled = True
                .Activate()
                .Enabled = True
                .DataGridView1.Item(5, .mRow).Value = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_itemdisc_unit = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmitem
                MainMenu.Enabled = True
                .Activate()
                .Enabled = True
                .DataGridView3.Item(3, .zRow).Value = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_purchase_unit = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmpurchase
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(5, .mRow).Value = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_trf_wh = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmitemtransfer
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .DataGridView1.Item(5, .mRow).Value = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_BOM = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmbom
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
            End With
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        generate()
    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Down Then
            DataGridView1.Focus()
            SendKeys.Send(Keys.Down)
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            generate()
        End If
    End Sub
End Class