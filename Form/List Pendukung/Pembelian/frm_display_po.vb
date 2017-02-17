Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frm_display_po
    Dim i As Integer
    Public formsource_supplier As Boolean
    Public formsource_cust As Boolean
    Public formsource_marketing As Boolean
    Public formsource_journal_noacc As Boolean
    Public formsource_item As Boolean
    Public formsource_ledger As Boolean
    Public formsource_adjustitem As Boolean
    Public formsource_salesservice As Boolean
    Public formsource_so As Boolean
    Public formsource_sales As Boolean
    Public formsource_so_sales As Boolean
    Public formsource_po_unit As Boolean
    Public formsource_purchase_po As Boolean

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Down Then
            DataGridView1.Focus()
            SendKeys.Send(Keys.Down)
        End If
    End Sub

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
        'End If
        'If formsource_cust = True Then
        '    formsource_cust = False
        '    frmcustomer.Enabled = True
        'End If
        'If formsource_marketing = True Then
        '    formsource_marketing = False
        '    frmmarketing.Enabled = True
        'End If
        'If formsource_journal_noacc = True Then
        '    formsource_journal_noacc = False
        '    frmjournal.Enabled = True
        'End If
        'If formsource_item = True Then
        '    formsource_item = False
        '    frmitem.Enabled = True
        'End If
        'If formsource_ledger = True Then
        '    formsource_ledger = False
        '    frmledger.Enabled = True
        'End If
        'If formsource_adjustitem = True Then
        '    formsource_adjustitem = False
        '    frmadjuststock.Enabled = True
        'End If
        ''If formsource_salesservice = True Then
        ''    formsource_salesservice = False
        ''    frmsalonservice.Enabled = True
        ''End If
        'If formsource_so = True Then
        '    formsource_so = False
        '    frmso.Enabled = True
        'End If
        'If formsource_sales = True Then
        '    formsource_sales = False
        '    frmcashier.Enabled = True
        'End If
        'If formsource_so_sales = True Then
        '    formsource_sales = False
        '    frmcashier.Enabled = True
        'End If
        'If formsource_po_unit = True Then
        '    formsource_po_unit = False
        '    frmpurchase.Enabled = True
        'End If
        'If formsource_purchase_po = True Then
        '    formsource_purchase_po = False
        '    frmpurchase.Enabled = True
        'End If

    End Sub

    Private Sub frm_display_acc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            cbo_search.Text = "PO No"
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
        'If TabControl1.SelectedTab Is TabList Then
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_purchase_order2(cbo_search.Text, txt_search.Text, 0)
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
            DataGridView1.Item(2, i).Value = Format(DT.Rows(i).Item(2), "dd-MMM-yyyy")
            DataGridView1.Item(3, i).Value = FormatNumber(DT.Rows(i).Item(5), 0)
            DataGridView1.Item(4, i).Value = DT.Rows(i).Item(8)
            DataGridView1.Item(5, i).Value = DT.Rows(i).Item("kurs")
        Next
        ' End If
    End Sub

    Private Sub detail_data()
        open_conn()
        'If TabControl1.SelectedTab Is TabList Then
        Dim Rows As Integer
        Dim DT As DataTable
        Dim RowIndex As Integer
        Dim PlusFreight As Double
        RowIndex = DataGridView1.CurrentCell.RowIndex

        DT = select_po_detail(DataGridView1.Item(0, RowIndex).Value)
        Rows = DT.Rows.Count - 1

        Dim i As Integer
        With frmpurchase
            .DataGridView1.Rows.Add(Rows + 1)
            .cbo_po_no.Text = DT.Rows(0).Item("no_purchase_order")
            .txt_idsupplier.Text = DT.Rows(0).Item("id_supplier")
            .txt_supp_nm.Text = DT.Rows(0).Item("nama")
            .txt_supp_address.Text = DT.Rows(0).Item("address")
            .txt_comment.Text = DT.Rows(0).Item("notes")
            For i = 0 To DT.Rows.Count - 1
                .DataGridView1.Item(0, i).Value = DT.Rows(i).Item("number_asc")
                .DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                .DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                .DataGridView1.Item(3, i).Value = DT.Rows(i).Item("description")
                .DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("qty"), 0)
                .DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
                .DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
                .DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)

            Next
            .txt_amount.Text = FormatNumber(DT.Rows(0).Item("total_head"), 0)
            .txt_subtotal.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
            PlusFreight = DT.Rows(0).Item("subtotal") + DT.Rows(0).Item("freight")
            .txt_netto.Text = FormatNumber(PlusFreight, 0)
            .txt_tax.Text = FormatPercent(DT.Rows(0).Item("Tax") / 100, 0)
            .txt_disc_pay.Text = FormatPercent(0, 0)
            .txt_freight.Text = FormatNumber(DT.Rows(0).Item("freight"), 0)
            .txt_curr.Text = "IDR"
        End With

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
                .Enabled = True
                .Activate()
                .cbo_account.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_cust = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmcustomer
                .Enabled = True
                .Activate()
                .cbo_account.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_marketing = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmmarketing
                .Enabled = True
                .Activate()
                .cbo_account_id.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_journal_noacc = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmjournal
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmitem
                .Enabled = True
                .Activate()
                .cbo_acc.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        If formsource_ledger = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmledger
                .Enabled = True
                .Activate()
                .cbo_search.Text = DataGridView1.Item(0, i).Value
                .lbl_acc_nm.Text = DataGridView1.Item(1, i).Value
            End With
        End If
        If formsource_adjustitem = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmadjuststock
                .Enabled = True
                .Activate()
                .DataGridView1.Item(1, .mRow).Value = DataGridView1.Item(0, i).Value
                .DataGridView1.Item(2, .mRow).Value = DataGridView1.Item(1, i).Value
            End With
        End If
        'If formsource_salesservice = True Then
        '    i = DataGridView1.CurrentCell.RowIndex
        '    With frmsalonservice
        '        .Enabled = True
        '        .Activate()
        '        .cbo_customer.Text = DataGridView1.Item(0, i).Value
        '        .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
        '        .txt_cust_address.Text = DataGridView1.Item(2, i).Value
        '    End With
        'End If
        If formsource_so = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmso
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
                .Enabled = True
                .Activate()
                .txt_cust_id.Text = DataGridView1.Item(0, i).Value
                .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
                .txt_cust_address.Text = DataGridView1.Item(2, i).Value
            End With
        End If
        If formsource_so_sales = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmcashier
                .Enabled = True
                .Activate()
                detail_data()
            End With

        End If
        If formsource_po_unit = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmpurchase
                .Enabled = True
                .Activate()
                .cbo_po_no.Text = DataGridView1.Item(4, i).Value
                detail_data()
            End With

        End If
        If formsource_purchase_po = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmpurchase
                .Enabled = True
                .Activate()
                .cbo_po_no.Text = DataGridView1.Item(0, i).Value
                .txt_idsupplier.Text = DataGridView1.Item(4, i).Value
                .txt_kurs.Text = FormatNumber(DataGridView1.Item(5, i).Value)
                detail_data()
            End With

        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        generate()
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            generate()
        End If
    End Sub
End Class