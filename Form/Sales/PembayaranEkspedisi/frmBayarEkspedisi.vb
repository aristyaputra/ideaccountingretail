Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmBayarEkspedisi

    Dim i As Integer
    Dim a As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Public NoBuktiDO As String
    Dim var_id_supplier As String
    Dim var_nm_supplier As String
    Dim var_add_supplier As String
    Dim Qty_Before As Integer
    Dim nobukti_update As String
    Dim valueBefore As Integer

    Private Sub frmBayarEkspedisi_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmDeliveredItem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxAkun()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_cashbank_all()

        cbo_akun.SelectedIndex = -1
        cbo_akun.Items.Clear()
        cbo_akun.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_akun.SourceDataString = New String(1) {"id_account", "account_name"}
        cbo_akun.SourceDataTable = dtLoading
        cbo_akun.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxCurrency()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_curr()

        cbo_currency.SelectedIndex = -1
        cbo_currency.Items.Clear()
        cbo_currency.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_currency.SourceDataString = New String(1) {"id_currency", "currency"}
        cbo_currency.SourceDataTable = dtLoading
        cbo_currency.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub view_do_list()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim DT As New DataTable
            DataGridView3.Rows.Clear()
            DT = select_view_do_list()
            If DT.Rows.Count > 0 Then
                For i As Integer = 0 To DT.Rows.Count - 1
                    DataGridView3.Rows.Add(1)
                    DataGridView3.Item(0, i).Value = DT.Rows(i).Item("no_delivery_order")
                    DataGridView3.Item(1, i).Value = Format(DT.Rows(i).Item("date_trn"), "dd-MM-yyyy")
                    DataGridView3.Item(2, i).Value = DT.Rows(i).Item("pelanggan")
                    DataGridView3.Item(3, i).Value = DT.Rows(i).Item("address")
                    DataGridView3.Item(4, i).Value = DT.Rows(i).Item("city")
                    DataGridView3.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("freight_est"), 0)
                Next
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try

    End Sub

    Private Sub frmBayarEkspedisi_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Panel2.Visible = True
            view_do_list()
        End If
    End Sub


    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        Dim DT As New DataTable
        insert = 1
        edit = 0
        'Dim Rows As Integer
        'Dim Rows_item As Integer
        open_conn()
        'Rows = select_supplier().Rows.Count - 1
        'For i = 0 To Rows
        '    cbo_supplier.Items.Add(select_supplier.Rows(i).Item(0))
        'Next
        'fill datagridview
        'Rows_item = select_item("1", "").Rows.Count - 1
        'For a = 0 To Rows_item
        '    ComboBox1.Items.Add(select_item("1", "").Rows(a).Item(0))
        'Next
        'DataGridView1.Item(1, Collection.Equals(ComboBox1, "")).ValueType()
        Panel2.Visible = False
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("EXPEDITION_JOURNAL", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("EXPEDITION_JOURNAL", "TRANS")
        cbo_search.Text = "Ekspedisi No"
        txt_po_no.Text = no_master
        DataGridView1.Focus()
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Call init_number()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        ' LoadComboBox_MtgcComboBoxSO()
        LoadComboBox_MtgcComboBoxAkun()
        LoadComboBox_MtgcComboBoxCurrency()
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        cbo_currency.Text = get_def_curr()
        txt_kurs.Text = 1
        'DataGridView6.Rows.Clear()
        'DataGridView6.Rows.Add(250)
        view_data()
    End Sub

    Private Sub init_number()

    End Sub
    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
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
        With DataGridView1
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = False
            .Columns(3).ReadOnly = True
            .Columns(3).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(4).ReadOnly = True
            .Columns(4).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(5).ReadOnly = False
            .Columns(5).DefaultCellStyle.BackColor = Color.White
            ' .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        'With DataGridView6
        '    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        '    .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        '    .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
        '    .DefaultCellStyle.SelectionForeColor = Color.Black
        '    .DefaultCellStyle.BackColor = Color.WhiteSmoke
        '    .ReadOnly = True
        'End With
    End Sub
    Private Sub cbo_supplier_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim NewDisplayAcc As New frm_display_supp
        NewDisplayAcc.formsource_ro = True
        NewDisplayAcc.Show()
        ' NewDisplayAcc.MdiParent = MainMenu
        Me.Enabled = False
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxSO()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_list_so_new()

        cbo_po.SelectedIndex = -1
        cbo_po.Items.Clear()
        cbo_po.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_po.SourceDataString = New String(3) {"no_sales_order", "id_customer", "customer_name", "address"}
        cbo_po.SourceDataTable = dtLoading
        cbo_po.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    'Private Sub cbo_supplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_supplier.SelectedIndexChanged
    '    Dim Rows As Integer
    '    Dim DT As DataTable
    '    DT = select_master("select_supplier", "ID Supplier", cbo_supplier.SelectedItem, 0)
    '    Rows = DT.Rows.Count - 1
    '    open_conn()
    '    For i = 0 To Rows
    '        txt_supp_nm.Text = DT.Rows(i).Item("NAME")
    '        txt_supp_address.Text = DT.Rows(i).Item("address")
    '    Next
    '    'txt_supp_nm.Text = cbo_supplier.SelectedItem
    '    'DataGridView1.Rows.Clear()
    '    'For i = 0 To Rows
    '    '    DataGridView1.
    '    'Next

    'End Sub
    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        'Dim var_id_item As String
        'Dim z, y, x As Integer
        'For z = 0 To DataGridView1.Rows.Count - 1
        '    y = y + 1
        '    var_id_item = DataGridView1.Item(1, z).Value
        '    For x = y To DataGridView1.Rows.Count - 1
        '        If var_id_item = DataGridView1.Item(1, x).Value Then
        '            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Data sudah ada")
        '            alertControl_warning.Show(Me, info)
        '            Exit Sub
        '        Else
        '            insert_data()
        '        End If
        '    Next
        'Next
        Dim a As Integer
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Item(1, i).Value <> "" Or DataGridView1.Item(1, i).Value <> Nothing Then
                a = a + 1
            End If
        Next

        If a = 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Data Kosong")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        Try
            insert_data()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", ex.Message)
            alertControl_warning.Show(Me, info)
        End Try

    End Sub
    'fungsi simpan
    Private Sub insert_data()
        open_conn()
        Dim i As Integer
        If insert = 1 Then
            Call insert_payment_expedisi(Trim(txt_po_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Replace(txt_total.Text, ",", ""), Trim(cbo_currency.Text), Trim(cbo_akun.Text), Trim(txt_comment.Text), Replace(txt_kurs.Text, ",", ""), Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), username, "", "", "", "", 0, 0, 0, "INSERT")
            For i = 0 To DataGridView1.Rows.Count - 1
                If Trim(DataGridView1.Item(1, i).Value) <> "" Or Trim(DataGridView1.Item(1, i).Value) <> Nothing Then
                    insert_payment_expedisi(Trim(txt_po_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Replace(txt_total.Text, ",", ""), Trim(cbo_currency.Text), Trim(cbo_akun.Text), Trim(txt_comment.Text), Replace(txt_kurs.Text, ",", ""), Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), username, DataGridView1.Item(1, i).Value, DataGridView1.Item(2, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, 1, i, "INSERT")
                End If

            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "EXPEDITION_JOURNAL")
                pesan = MsgBox("Cetak Bukti Pembayaran Ekspedisi?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormNotaEkspedisi
                    NoBuktiDO = Trim(txt_po_no.Text)
                    With DisplayNota
                        .Show()
                        ' .MdiParent = MainMenu
                        .WindowState = FormWindowState.Maximized
                    End With
                End If
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_payment_expedisi(Trim(txt_po_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Replace(txt_total.Text, ",", ""), Trim(cbo_currency.Text), Trim(cbo_akun.Text), Trim(txt_comment.Text), Replace(txt_kurs.Text, ",", ""), Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), username, "", "", "", "", 0, 0, 0, "UPDATE")
            For i = 0 To DataGridView1.Rows.Count - 1
                If Trim(DataGridView1.Item(1, i).Value) <> "" Or Trim(DataGridView1.Item(1, i).Value) <> Nothing Then
                    update_payment_expedisi(Trim(txt_po_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Replace(txt_total.Text, ",", ""), Trim(cbo_currency.Text), Trim(cbo_akun.Text), Trim(txt_comment.Text), Replace(txt_kurs.Text, ",", ""), Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), username, DataGridView1.Item(1, i).Value, DataGridView1.Item(2, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, 1, i, "UPDATE")
                End If

            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        Panel2.Visible = False
        With Me
            .txt_supp_nm.Text = ""
            .txt_supp_address.Text = ""
            .txt_comment.Text = ""
            .txt_date.Value = Now
            .cbo_supplier.Text = ""
            .cbo_po.SelectedText = ""
            .cbo_po.Text = ""
            .DataGridView1.Rows.Clear()

        End With
        Call select_control_no("EXPEDITION_JOURNAL", "TRANS")
        txt_po_no.Text = no_master
        txt_date.Value = Now
        init_number()
        btn_cetak.Enabled = False
        btn_del2.Enabled = False
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        '.Rows.Clear()
        'DataGridView6.Rows.Add(250)
        datagrid_layout()
        cbo_akun.Text = ""
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub txt_search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        'ganti ke text changed

        'Dim Rows As Integer
        'Dim DT As DataTable
        'DT = select_view_po()
        'Rows = DT.Rows.Count - 1
        'open_conn()
        'DataGridView2.Rows.Clear()
        'For i = 0 To Rows
        '    DataGridView2.Rows.Add()
        '    DataGridView2.Item(0, i).Value = DT.Rows(i).Item("no_purchase_order")
        '    DataGridView2.Item(1, i).Value = DT.Rows(i).Item("nm_supplier")
        '    DataGridView2.Item(2, i).Value = DT.Rows(i).Item("date_trn")
        'Next
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        view_data()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        open_conn()
        'mRow = DataGridView1.CurrentCell.RowIndex
        'mCol = DataGridView1.CurrentCell.ColumnIndex
        'Dim Rows As Integer
        'i = DataGridView1.CurrentCell.ColumnIndex
        'If i = 1 Or i = 2 Then
        '    Dim NewDisplayAcc As New frm_display_item
        '    NewDisplayAcc.formsource_ro_item = True
        '    NewDisplayAcc.Show()
        '    NewDisplayAcc.MdiParent = MainMenu
        'End If
        'If i = 5 Then
        '    Dim NewDisplayAcc As New frm_display_unit
        '    NewDisplayAcc.formsource_ro_unit = True
        '    NewDisplayAcc.Show()
        '    NewDisplayAcc.MdiParent = MainMenu
        'Dim dgvcc As DataGridViewComboBoxCell
        'dgvcc = DataGridView1.Rows(mRow).Cells(5)
        'dgvcc.Items.Clear()
        'Rows = select_unit.Rows.Count - 1
        'For i = 0 To Rows
        '    dgvcc.Items.Add(select_unit.Rows(i).Item(0))
        'Next
        'End If
    End Sub

    Dim TSubTotal As Double
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim rows As Integer
        Dim columnIndex As Integer
        Dim rowIndex As Integer

        TSubTotal = 0
        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        rowIndex = DataGridView1.CurrentCell.RowIndex
        If columnIndex = 4 Or columnIndex = 6 Then
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, 0)
        End If
        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Detail item masih kosong!")
            alertControl_error.Show(Me, info)
            Exit Sub
        End If
        If columnIndex = 7 Then
            'If insert = 1 Then
            If DataGridView1.Item(columnIndex, rowIndex).Value > DataGridView1.Item(6, rowIndex).Value Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Qty melebihi qty pemesanan" & vbCrLf & "Silahkan cek kembali")
                alertControl_error.Show(Me, info)
                DataGridView1.Item(columnIndex, rowIndex).Value = DataGridView1.Item(6, rowIndex).Value
                Exit Sub
            End If
            'ElseIf edit = 1 Then
            'Dim DT_QtyRec As DataTable
            'DT_QtyRec = get_QtyDO(cbo_po.Text, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
            'If DataGridView1.Item(columnIndex, rowIndex).Value > (DataGridView1.Item(4, rowIndex).Value - DT_QtyRec.Rows(0).Item(0)) Then
            '    DataGridView1.Item(columnIndex, rowIndex).Value = DT_QtyRec.Rows(0).Item(0)
            'End If
            'End If
        End If
        rows = DataGridView1.Rows.Count - 1

    End Sub

    Private Sub hitung_nominal()
        open_conn()
        Dim TNett As Double
        Dim Ttotal As Double
        Dim Tchange As Double

        TNett = 0
        Ttotal = 0
        Tchange = 0

        'menghitung netto
        'TNett = TSubTotal - (TSubTotal * CDbl(Replace(txt_disc.Text, "%", "")) / 100)
        'txt_netto.Text = FormatNumber(TNett, 0)
        'Ttotal = (TSubTotal + Replace(txt_freight.Text, ",", "")) + ((TSubTotal + Replace(txt_freight.Text, ",", "")) * (CDbl(Replace(txt_tax.Text, "%", "")) / 100))

        'menghitung total
        'txt_amount.Text = FormatNumber(Ttotal, 0)

        'menghitung change
        'Tchange = (CDbl(txt_paid.Text)) - Ttotal
        'txt_change.Text = FormatNumber(Tchange, 0)
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        'i = DataGridView1.CurrentCell.ColumnIndex
        'If i = 1 Or i = 2 Then
        '    Dim NewDisplayAcc As New frm_display_acc_detail
        '    NewDisplayAcc.formsource_journal_noacc = True
        '    NewDisplayAcc.Show()
        'End If
        DataGridView1.Item(0, mRow).Value = mRow + 1
    End Sub


    Private Sub txt_tax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'txt_tax.SelectionStart = 0
        'txt_tax.SelectionLength = Len(txt_tax.Text)
    End Sub

    Private Sub txt_tax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If txt_tax.Text = "" Then
        '    txt_tax.Text = FormatPercent(0, 0)
        'Else
        '    txt_tax.Text = FormatPercent(CDbl(Replace(txt_tax.Text, "%", "")) / 100, 0)
        'End If
        'hitung_nominal()
    End Sub

    Private Sub txt_freight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If txt_freight.Text = "" Then
        '    txt_freight.Text = FormatNumber(0, 0)
        'Else
        '    txt_freight.Text = FormatNumber(CDbl(Replace(txt_freight.Text, ",", "")), 0)
        'End If
        'hitung_nominal()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        view_data()
        'Dim Total_Width_Column, Total_Width_Column2 As Integer
        'Dim Width_Table, Width_Table2 As Integer
        'Dim selisih_col, selisih_col2 As Integer

        'With DataGridView1
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(3).Width = .Columns(3).Width + selisih_col
        'End With
        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(3).Width = .Columns(3).Width + selisih_col2
        'End With
    End Sub

    Private Sub view_data()
        open_conn()
        'If TabControl1.SelectedTabPage Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim Rows As Integer
            Dim DT As DataTable
            Dim date_filter As Integer
            If chk_date.Checked = True Then
                date_filter = 1
            ElseIf chk_date.Checked = False Then
                date_filter = 0
            End If
            DT = select_expedition_payment(Trim(cbo_search.Text), Trim(txt_search.Text), 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))

            GridControl.DataSource = DT
            GridList_Customer.Columns("no_ekspedisi").Caption = "No Pembayaran"
            GridList_Customer.Columns("no_ekspedisi").Width = 170
            GridList_Customer.Columns("id_currency").Caption = "Mata Uang"
            GridList_Customer.Columns("id_currency").Width = 100
            GridList_Customer.Columns("account_name").Caption = "Melalui"
            GridList_Customer.Columns("account_name").Width = 130
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 100
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("total").Caption = "Nominal"
            GridList_Customer.Columns("total").Width = 170
            GridList_Customer.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("total").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 250
            GridList_Customer.Columns("id_account").Visible = False

            '            GridList_Customer.BestFitColumns()

            'Rows = DT.Rows.Count - 1
            'open_conn()
            'DataGridView2.Rows.Clear()
            'Dim i As Integer
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item("no_ekspedisi")
            '        DataGridView2.Item(1, i).Value = Format(DT.Rows(i).Item("date_trn"), "dd-MM-yyyy")
            '        DataGridView2.Item(2, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)
            '        DataGridView2.Item(3, i).Value = DT.Rows(i).Item("notes")
            '        DataGridView2.Item(4, i).Value = DT.Rows(i).Item("account_name")
            '    Next
            'End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        'current_row = cbo_acc_group.SelectedIndex
        edit = 1
        insert = 0
        Dim Qty_Sisa As Integer
        Dim DT As DataTable
        Dim rows As Integer
        Dim date_filter As Integer
        Dim DT_QtyRec As DataTable
        If chk_date.Checked = True Then
            date_filter = 1
        ElseIf chk_date.Checked = False Then
            date_filter = 0
        End If
        '.ReadOnly = True
        DT = select_expedition_payment("Ekspedisi No", criteria, 1, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rows = DT.Rows.Count - 1
        If DT.Rows.Count > 0 Then
            cbo_po.Text = ""
            nobukti_update = DT.Rows(0).Item("no_ekspedisi")
            txt_po_no.Text = nobukti_update
            txt_date.Value = DT.Rows(0).Item("date_trn")
            txt_comment.Text = DT.Rows(0).Item("notes")
            txt_total.Text = FormatNumber(DT.Rows(0).Item("total"), 0)
            cbo_akun.SelectedText = ""
            cbo_akun.Text = DT.Rows(0).Item("id_account")
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(250)
            Dim i As Integer
            For i = 0 To rows
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("no_do")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("no_resi")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("freight_address")
                DataGridView1.Item(4, i).Value = DT.Rows(i).Item("freight_city")
                DataGridView1.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("freight_cost"), 0)
                If select_validate("Sales Order", get_so_no_from_do(DT.Rows(i).Item("no_do"))) > 0 Then
                    Dim info As AlertInfo = New AlertInfo("Informasi", "Beberapa DO sudah dikirim faktur" & vbCrLf & "Biaya Ekspedisi tidak dapat di ubah")
                    alertControl_warning.Show(Me, info)
                    DataGridView1.Rows(i).Cells(5).ReadOnly = True
                    DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.WhiteSmoke
                Else
                    DataGridView1.Rows(i).Cells(5).ReadOnly = False
                    DataGridView1.Rows(i).Cells(5).Style.BackColor = Color.White
                End If
            Next
            btn_del2.Enabled = True
            btn_cetak.Enabled = True
        End If
    End Sub

    Private Sub view_detail_itemdisc(Criteria)
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable
        Dim i As Integer

        DT = select_item_bonus_det(Criteria)
        Rows = DT.Rows.Count - 1
        'DataGridView6.Rows.Clear()
        'DataGridView6.Rows.Add(250)
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                'DataGridView6.Rows.Add(1)
                'DataGridView6.Item(0, i).Value = i + 1
                'DataGridView6.Item(1, i).Value = DT.Rows(i).Item(1)
                'DataGridView6.Item(2, i).Value = DT.Rows(i).Item(2)
                'DataGridView6.Item(3, i).Value = DT.Rows(i).Item(3)
                'DataGridView6.Item(4, i).Value = DT.Rows(i).Item(4)
            Next
        End If
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        edit = 1
        insert = 0
        Dim a As Integer
        btn_del2.Enabled = True
        btn_cetak.Enabled = True
        a = DataGridView2.CurrentCell.RowIndex
        detail(DataGridView2.Item(0, a).Value)
        TabControl1.SelectedTabPage = TabInput
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_EXPEDITION_PAYMENT_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            'If select_validate("Request Order", Trim(txt_po_no.Text)) > 0 Then
            '    MsgBox("RO Sudah Di Approve", MsgBoxStyle.Information, "Validate")
            '    Exit Sub
            'End If
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_payment_expedisi(Trim(txt_po_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Replace(txt_total.Text, ",", ""), Trim(cbo_currency.Text), Trim(cbo_akun.Text), Trim(txt_comment.Text), Replace(txt_kurs.Text, ",", ""), Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), username, "", "", "", "", 0, 0, 0, "DELETE")

                If param_sukses = True Then
                    Dim info As AlertInfo = New AlertInfo(msgtitle_delete_success, msgbox_delete_success)
                    alertControl_success.Show(Me, info)
                    clean()
                Else
                    Dim info As AlertInfo = New AlertInfo(msgtitle_delete_failed, msgbox_delete_failed)
                    alertControl_error.Show(Me, info)
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("EXPEDITION_JOURNAL", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("EXPEDITION_JOURNAL", "TRANS")
            txt_po_no.Text = no_master
        End If
    End Sub

    Private Sub chk_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_date.CheckedChanged
        open_conn()
        date_filter()
    End Sub

    Private Sub date_filter()
        open_conn()
        If chk_date.Checked = True Then
            tglawal.Enabled = True
            tglakhir.Enabled = True
        ElseIf chk_date.Checked = False Then
            tglawal.Enabled = False
            tglakhir.Enabled = False
        End If
    End Sub

    Private Sub reset_list()
        open_conn()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        tglakhir.Value = Now
        tglawal.Value = Now
        cbo_search.Text = "Delivery No"
        txt_search.Text = ""
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_save2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_EXPEDITION_PAYMENT_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_EXPEDITION_PAYMENT_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim a, b As Integer
        Dim row As Integer
        row = DataGridView1.Rows.Count - 1
        'If trial = True Then
        'If get_count_data("trn_delivery_order_head", "no_delivery_order") > row_trial Then
        '    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda telah mencapai batas jumlah pengisian trial, Silahkan membeli produk ini")
        '    alertControl_warning.Show(Me, info)
        '    Exit Sub
        'End If
        ' End If
        'If cbo_filterwh_purch1.EditValue Is Nothing Then
        '    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih gudang")
        '    alertControl_warning.Show(Me, info)
        '    Exit Sub
        'End If

        'For a = 0 To row
        '    If DataGridView1.Item(8, a).Value = True Then
        '        b = b + 1
        '    End If
        'Next
        'If b = 0 Then
        '    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih data detail")
        '    alertControl_warning.Show(Me, info)
        '    Exit Sub
        'ElseIf a > 0 Then
        insert_data()
        ' End If
    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        Dim DisplayNota As New FormNotaEkspedisi
        NoBuktiDO = Trim(txt_po_no.Text)
        With DisplayNota
            .Show()
            ' .MdiParent = MainMenu
            .Text = "Nota Pembayaran Ekspedisi"
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            edit = 1
            insert = 0
            Dim a As Integer
            btn_del2.Enabled = True
            btn_cetak.Enabled = True
            a = DataGridView2.CurrentCell.RowIndex
            detail(DataGridView2.Item(0, a).Value)
            TabControl1.SelectedTabPage = TabInput
        End If
    End Sub

    Private Sub cbo_po_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_po.DroppedDown = True
    End Sub

    Private Sub cbo_po_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_po.DroppedDown = False
    End Sub

    Private Sub cbo_po_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        var_id_supplier = cbo_po.SelectedItem.Col2
        var_nm_supplier = cbo_po.SelectedItem.Col3
        var_add_supplier = cbo_po.SelectedItem.Col4
        txt_supp_nm.Text = var_nm_supplier
        txt_supp_address.Text = var_add_supplier
        view_data_po(cbo_po.Text)
        view_item_disc(cbo_po.Text)
    End Sub

    Private Sub view_data_po(ByVal Criteria As String)
        open_conn()
        Dim Rows, a As Integer
        Dim DT As DataTable
        Dim DT_QtyRec As DataTable

        Dim date_filter As Integer
        date_filter = 0
        DT = select_so_do("No SO", Criteria, date_filter, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"))
        Rows = DT.Rows.Count - 1
        open_conn()
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        Dim i As Integer
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                DT_QtyRec = get_QtyDO(cbo_po.Text, DT.Rows(i).Item(0))
                If (DT.Rows(i).Item(3) - DT_QtyRec.Rows(0).Item(0)) > 0 Then
                    'DataGridView1.Rows.Add()
                    DataGridView1.Item(0, a).Value = a + 1
                    DataGridView1.Item(1, a).Value = DT.Rows(i).Item(0)
                    DataGridView1.Item(2, a).Value = DT.Rows(i).Item(1)
                    DataGridView1.Item(3, a).Value = DT.Rows(i).Item(2)
                    DataGridView1.Item(4, a).Value = FormatNumber(DT.Rows(i).Item(3), 0)
                    DataGridView1.Item(5, a).Value = DT.Rows(i).Item(4)
                    DataGridView1.Item(6, a).Value = DT.Rows(i).Item(3) - DT_QtyRec.Rows(0).Item(0)
                    DataGridView1.Item(7, a).Value = FormatNumber(DT.Rows(i).Item(6), 0)
                    a = a + 1
                End If
            Next
        End If
    End Sub

    Private Sub view_item_disc(ByVal Criteria As String)
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable
        Dim i As Integer

        DT = select_item_bonus(Criteria)
        Rows = DT.Rows.Count - 1
        ' DataGridView6.Rows.Clear()
        ' DataGridView6.Rows.Add(250)
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                'DataGridView6.Rows.Add(1)
                'DataGridView6.Item(0, i).Value = i + 1
                'DataGridView6.Item(1, i).Value = DT.Rows(i).Item(1)
                'DataGridView6.Item(2, i).Value = DT.Rows(i).Item(2)
                'DataGridView6.Item(3, i).Value = DT.Rows(i).Item(3)
                'DataGridView6.Item(4, i).Value = DT.Rows(i).Item(4)
            Next
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        open_conn()
        Dim colIndex As Integer
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        If colIndex = 5 Then
            Dim DisplayNota As New FormNotaEkspedisi
            NoBuktiDO = Trim(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .Text = "Nota Pembayaran Ekspedisi"
                .WindowState = FormWindowState.Maximized
            End With
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Private Sub frmDeliveredItem_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(3).Width = .Columns(3).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(3).Width = .Columns(3).Width + selisih_col2
    '    End With
    'End Sub

    Private Sub NavBarGroupControlContainer10_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cbo_currency_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_currency.SelectedIndexChanged
        open_conn()
        Dim var_id_currency As String
        var_id_currency = cbo_currency.SelectedItem.Col1
        txt_kurs.Text = FormatNumber(get_kurs(var_id_currency), 0)
    End Sub

    Private Sub NavBarGroupControlContainer2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Panel2.Visible = False
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        DataGridView1.Rows.Clear()
        Dim a As Integer
        For i As Integer = 0 To DataGridView3.Rows.Count - 1
            If DataGridView3.Item(6, i).Value = True Then
                DataGridView1.Rows.Add(1)
                DataGridView1.Item(0, a).Value = i + 1
                DataGridView1.Item(1, a).Value = DataGridView3.Item(0, i).Value
                DataGridView1.Item(2, a).Value = ""
                DataGridView1.Item(3, a).Value = DataGridView3.Item(3, i).Value
                DataGridView1.Item(4, a).Value = DataGridView3.Item(4, i).Value
                DataGridView1.Item(5, a).Value = DataGridView3.Item(5, i).Value
                a = a + 1
            End If
        Next
        hitung_total()
        DataGridView1.Rows.Add(250)
        Panel2.Visible = False
    End Sub

    Private Sub hitung_total()
        Dim value As Double
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If IsNumeric(DataGridView1.Item(5, i).Value) = True Then
                value = value + DataGridView1.Item(5, i).Value
            End If
        Next
        txt_total.Text = FormatNumber(value, 0)
    End Sub

    Private Sub btn_chk_all_Click(sender As System.Object, e As System.EventArgs) Handles btn_chk_all.Click
        open_conn()
        Dim i As Integer
        For i = 0 To DataGridView3.Rows.Count - 1
            DataGridView3.Item(6, i).Value = True
        Next
    End Sub

    Private Sub btn_clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_clear.Click
        open_conn()
        Dim i As Integer
        For i = 0 To DataGridView3.Rows.Count - 1
            DataGridView3.Item(6, i).Value = False
        Next
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_ekspedisi"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_ekspedisi"))
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        PanelControl3.Visible = False
        enableMain()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            view_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        Panel2.Visible = False
    End Sub

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl3.Visible = True
        disableMain()
        clean()
    End Sub

    Private Sub SimpleButton8_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton8.Click
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            view_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub
End Class