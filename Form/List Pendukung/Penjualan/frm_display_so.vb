Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frm_display_so
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

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Down Then
            DataGridView1.Focus()
            SendKeys.Send(Keys.Down)
        End If
        If e.KeyCode = Keys.Enter Then
            open_conn()
            view_data()
        End If
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
        ''If formsource_salesservice = True Then
        ''    formsource_salesservice = False
        ''    frmsalonservice.Enabled = True
        ''    MainMenu.Enabled = True
        ''End If
        'If formsource_so = True Then
        '    formsource_so = False
        '    frmso.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_sales = True Then
        '    formsource_sales = False
        '    frmsales.Enabled = True
        '    MainMenu.Enabled = True
        'End If
        'If formsource_so_sales = True Then
        '    formsource_sales = False
        '    frmsales.Enabled = True
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
            cbo_search.Text = "SO No"
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
        DT = select_sales_order(cbo_search.Text, txt_search.Text, 8, 0, "1900-01-01", Format(server_datetime(), "yyyy-MM-dd"))
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
            DataGridView1.Item(2, i).Value = Format(DT.Rows(i).Item(2), "dd-MMM-yyyy")
            DataGridView1.Item(3, i).Value = FormatNumber(DT.Rows(i).Item(5), 0)
            DataGridView1.Item(4, i).Value = DT.Rows(i).Item(7)
        Next
        ' End If
    End Sub

    Private Sub detail_data()
        open_conn()
        Try
            Dim i As Integer
            'If TabControl1.SelectedTab Is TabList Then
            Dim Rows, RowsX As Integer
            Dim DT, DTX As DataTable
            Dim RowIndex As Integer
            RowIndex = DataGridView1.CurrentCell.RowIndex

            DT = select_so_detail(DataGridView1.Item(0, RowIndex).Value)
            Rows = DT.Rows.Count - 1
            'DTX = select_item_bonus(DataGridView1.Item(0, RowIndex).Value)
            'RowsX = DTX.Rows.Count - 1

            With frmsales
                .txt_cust_id.Text = DT.Rows(0).Item("id_customer")
                .txt_customer_nm.Text = DT.Rows(0).Item("nama")
                .txt_cust_address.Text = DT.Rows(0).Item("address")
                .txt_comment.Text = DT.Rows(0).Item("notes")
                .DataGridView1.Rows.Clear()
                .DataGridView1.Rows.Add(250)
                .DataGridView6.Rows.Clear()
                .DataGridView6.Rows.Add(250)
                For i = 0 To DT.Rows.Count - 1
                    '.DataGridView1.Rows.Add(1)
                    .DataGridView1.Item(0, i).Value = i + 1
                    .DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                    .DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                    .DataGridView1.Item(3, i).Value = DT.Rows(i).Item("description")
                    .DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("sent_qty"), 0)
                    .DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
                    .DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
                    .DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)
                Next
                'For i = 0 To DTX.Rows.Count - 1
                '    '.DataGridView1.Rows.Add(1)
                '    .DataGridView6.Item(0, i).Value = i + 1
                '    .DataGridView6.Item(1, i).Value = DTX.Rows(i).Item("id_item")
                '    .DataGridView6.Item(2, i).Value = DTX.Rows(i).Item("item_name")
                '    .DataGridView6.Item(3, i).Value = DTX.Rows(i).Item("Qty")
                '    .DataGridView6.Item(4, i).Value = DTX.Rows(i).Item("id_unit")
                'Next
                .txt_um.Text = FormatNumber(DT.Rows(0).Item("uang_muka"), 0)
                .txt_subtotal.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
                .txt_netto.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
                If DT.Rows(0).Item("Tax") > 0 Then
                    .chk_ppn.Checked = True
                Else
                    .chk_ppn.Checked = False
                End If
                .txt_tax.Text = FormatPercent(DT.Rows(0).Item("Tax") / 100, 0)
                .txt_disc.Text = FormatPercent(DT.Rows(0).Item("Discount") / 100, 0)
                .txt_netto.Text = FormatNumber(DT.Rows(0).Item("nett_total"), 0)
                .txt_tax_nominal.Text = FormatNumber(DT.Rows(0).Item("nett_total") * DT.Rows(0).Item("Tax") / 100, 0)
                .txt_total.Text = FormatNumber(DT.Rows(0).Item("total_head"), 0)
                .txt_curr.Text = DT.Rows(0).Item("id_curr")
                .txt_paymethod.Text = "Credit"
                .txt_change.Text = .txt_total.Text
                .txt_paid.Text = FormatNumber(0, 0)
                .cbo_customer.Text = DT.Rows(0).Item("no_sales_order")
                .txt_kurs.Text = FormatNumber(DT.Rows(0).Item("kurs"), 0)
                .cbo_akun.Text = ""
                .cbo_akun.SelectedText = get_acc_piutang_cust(DT.Rows(0).Item("id_customer"))
                .txt_freight.Text = FormatNumber(get_freight_sales(DT.Rows(0).Item("no_sales_order")), 0)
                .txt_total.Text = FormatNumber(DT.Rows(0).Item("total_head") - DT.Rows(0).Item("uang_muka") + get_freight_sales(DT.Rows(0).Item("no_sales_order")), 0)

            End With
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
        End Try
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        'open_conn()
        'view_data()
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
        '    End With
        'End If
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
            With frmsales
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
                .txt_cust_id.Text = DataGridView1.Item(0, i).Value
                .txt_customer_nm.Text = DataGridView1.Item(1, i).Value
                .txt_cust_address.Text = DataGridView1.Item(2, i).Value
            End With
        End If
        If formsource_so_sales = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmsales
                MainMenu.Enabled = True
                .Enabled = True
                .Activate()
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class