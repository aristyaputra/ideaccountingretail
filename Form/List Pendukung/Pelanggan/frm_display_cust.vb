Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Public Class frm_display_cust
    Dim i As Integer
    Public formsource_supplier As Boolean
    Public formsource_cust As Boolean
    Public formsource_marketing As Boolean
    Public formsource_journal_noacc As Boolean
    Public formsource_item As Boolean
    Public formsource_ledger As Boolean
    Public formsource_adjustitem As Boolean
    Public formsource_salesservice As Boolean
    Public formsource_cashier As Boolean
    Public formsource_so As Boolean
    Public formsource_sales As Boolean
    Public formsource_frmpayAR As Boolean
    Public formsource_arinit As Boolean

    Dim ex As System.Windows.Forms.KeyEventArgs

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
        'generate()
    End Sub

    Private Sub generate()
        open_conn()
        If formsource_supplier = True Then
            formsource_supplier = False
            frmsupplier.Enabled = True
            MainMenu.Enabled = True
        End If
        If formsource_cust = True Then
            formsource_cust = False
            frmcustomer.Enabled = True
            MainMenu.Enabled = True
        End If
        If formsource_arinit = True Then
            formsource_arinit = False
            frmar_initbalance.Enabled = True
            MainMenu.Enabled = True
        End If
        If formsource_marketing = True Then
            formsource_marketing = False
            frmmarketing.Enabled = True
            MainMenu.Enabled = True
        End If
        If formsource_journal_noacc = True Then
            formsource_journal_noacc = False
            frmjournal.Enabled = True
            MainMenu.Enabled = True
        End If
        If formsource_item = True Then
            formsource_item = False
            frmitem.Enabled = True
            MainMenu.Enabled = True
        End If
        If formsource_ledger = True Then
            formsource_ledger = False
            frmledger.Enabled = True
            MainMenu.Enabled = True
        End If
        If formsource_adjustitem = True Then
            formsource_adjustitem = False
            frmadjuststock.Enabled = True
            MainMenu.Enabled = True
        End If
        'If formsource_salesservice = True Then
        '    formsource_salesservice = False
        '    MainMenu.Enabled = True
        '    frmsalonservice.Enabled = True
        'End If
        If formsource_so = True Then
            formsource_so = False
            frmso.Enabled = True
            MainMenu.Enabled = True
        End If
        If formsource_sales = True Then
            formsource_sales = False
            frmcashier.Enabled = True
            MainMenu.Enabled = True
        End If
        If formsource_frmpayAR = True Then
            formsource_frmpayAR = False
            frmpayAR.Enabled = True
            MainMenu.Enabled = True
        End If
        If formsource_cashier = True Then
            formsource_cashier = False
            MainMenu.Enabled = True
            frmcashier.Enabled = True
        End If

    End Sub

    Private Sub frm_display_cust_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub frm_display_acc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        
            cbo_search.Text = "Barcode Member"
            view_data()
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.ReadOnly = True
            datagrid_layout()
            txt_search.Focus()
        
    End Sub

    Private Sub view_data()
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            Dim i As Integer
            'If TabControl1.SelectedTab Is TabList Then
            Dim Rows As Integer
            Dim DT As DataTable
            DT = select_master("select_customer", cbo_search.Text, txt_search.Text, 2, 0, "1900-01-01", "1900-01-01")
            Rows = DT.Rows.Count - 1
            DataGridView1.Rows.Clear()
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item(3)
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item(2)
                DataGridView1.Item(4, i).Value = DT.Rows(i).Item("id_barcode")
                'DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
                'DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
            Next
            ' End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Down Then
            DataGridView1.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            open_conn()
            view_data()
        End If
    End Sub

    'Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
    '    open_conn()
    '    view_data()
    '    If Trim(cbo_search.Text) = "ID Barcode" Then
    '        If formsource_salesservice = True And DataGridView1.Rows.Count = 1 Then
    '            i = DataGridView1.CurrentCell.RowIndex
    '            With frmsalonservice
    '                MainMenu.Enabled = True
    '                .Activate()
    '                .cbo_customer.Text = DataGridView1.Item(0, i).Value
    '                .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
    '                .txt_cust_address.Text = DataGridView1.Item(2, i).Value
    '                .txt_customer_phone.Text = DataGridView1.Item(3, i).Value
    '                .DataGridView1.Focus()
    '            End With
    '            Me.Close()
    '        End If
    '    End If
    'End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
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
        If formsource_arinit = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmar_initbalance
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
                .lbl_acc_name.Text = DataGridView1.Item(1, i).Value
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
        'If formsource_salesservice = True Then
        '    i = DataGridView1.CurrentCell.RowIndex
        '    With frmsalonservice
        '        MainMenu.Enabled = True
        '        .Enabled = True
        '        .Activate()
        '        .cbo_customer.Text = DataGridView1.Item(0, i).Value
        '        .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
        '        .txt_cust_address.Text = DataGridView1.Item(2, i).Value
        '        .txt_customer_phone.Text = DataGridView1.Item(3, i).Value
        '    End With
        'End If
        If formsource_cashier = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmcashier
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_customer.Text = DataGridView1.Item(0, i).Value
                .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
                .txt_cust_address.Text = DataGridView1.Item(2, i).Value
                .txt_customer_phone.Text = DataGridView1.Item(3, i).Value
            End With
        End If
        If formsource_so = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmso
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_customer.Text = DataGridView1.Item(0, i).Value
                .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
                .txt_cust_address.Text = DataGridView1.Item(2, i).Value
            End With
        End If
        If formsource_sales = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmcashier
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .txt_cust_id.Text = DataGridView1.Item(0, i).Value
                .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
                .txt_cust_address.Text = DataGridView1.Item(2, i).Value
            End With
        End If
        If formsource_frmpayAR = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmpayAR
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .cbo_supplier.Text = DataGridView1.Item(0, i).Value
                .txt_idsupplier.Text = DataGridView1.Item(0, i).Value
                .txt_supplier_nm.Text = DataGridView1.Item(1, i).Value
                .txt_supplier_address.Text = DataGridView1.Item(2, i).Value
            End With
        End If
        Me.Close()
    End Sub


    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            If formsource_supplier = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmsupplier
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_account.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            If formsource_arinit = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmar_initbalance
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_acc.Text = DataGridView1.Item(0, i).Value
                    .lbl_acc_name.Text = DataGridView1.Item(1, i).Value
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
            'If formsource_salesservice = True Then
            '    i = DataGridView1.CurrentCell.RowIndex
            '    With frmsalonservice
            '        MainMenu.Enabled = True
            '        .Enabled = True
            '        .Activate()
            '        .cbo_customer.Text = DataGridView1.Item(0, i).Value
            '        .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
            '        .txt_cust_address.Text = DataGridView1.Item(2, i).Value
            '        .txt_customer_phone.Text = DataGridView1.Item(3, i).Value
            '    End With
            'End If
            If formsource_cashier = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmcashier
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_customer.Text = DataGridView1.Item(0, i).Value
                    .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
                    .txt_cust_address.Text = DataGridView1.Item(2, i).Value
                    .txt_customer_phone.Text = DataGridView1.Item(3, i).Value
                End With
            End If
            If formsource_so = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmso
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_customer.Text = DataGridView1.Item(0, i).Value
                    .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
                    .txt_cust_address.Text = DataGridView1.Item(2, i).Value
                End With
            End If
            If formsource_sales = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmcashier
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .txt_cust_id.Text = DataGridView1.Item(0, i).Value
                    .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
                    .txt_cust_address.Text = DataGridView1.Item(2, i).Value
                End With
            End If
            If formsource_frmpayAR = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmpayAR
                    MainMenu.Enabled = True
                    .Enabled = True
                    .Activate()
                    .cbo_supplier.Text = DataGridView1.Item(0, i).Value
                    .txt_idsupplier.Text = DataGridView1.Item(0, i).Value
                    .txt_supplier_nm.Text = DataGridView1.Item(1, i).Value
                    .txt_supplier_address.Text = DataGridView1.Item(2, i).Value
                End With
            End If

            Me.Close()
        End If
    End Sub

    Private Sub frm_display_cust_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        open_conn()
        Dim Total_Width_Column As Integer
        Dim Width_Table As Integer
        Dim selisih_col As Integer

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(1).Width = .Columns(1).Width + selisih_col
        End With
    End Sub
End Class