Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmso
    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Public NoBuktiSO As String
    Dim pesan As String
    Dim IndexRowDg As Integer

    Private Sub frmso_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmso_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmso_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            'Dim NewDisplayAcc As New frm_display_item
            frm_display_item.formsource_so_item = True
            frm_display_item.Show()
            ' MainMenu.Enabled = False
            'Me.Enabled = False
        End If
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        Dim rows As Integer
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("SALES_ORDER", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("SALES_ORDER", "TRANS")
        cbo_search.Text = "SO No"
        txt_so_no.Text = no_master
        'DataGridView1.Item(0, 0).Value = 1
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.ReadOnly = True
        btn_del2.Enabled = False
        txt_curr.Items.Clear()
        rows = select_curr.Rows.Count - 1
        Dim i As Integer
        For i = 0 To rows
            txt_curr.Items.Add(select_curr.Rows(i).Item(0))
        Next
        Call init_number()
        txt_curr.Text = get_def_curr()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        LoadComboBox_MtgcComboBoxItem()
        LoadComboBox_MtgcComboBoxItemName()
        LoadComboBox_MtgcComboBoxMark()
        txt_kurs.Text = 1
        lbl_kurs.Text = get_def_curr()
        cbo_curr_um.Text = get_def_curr()
        txt_kurs_um.Text = 1
        DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)

        DataGridView3.Rows.Clear()
        DataGridView3.Rows.Add(250)

        DataGridView4.Rows.Clear()
        DataGridView4.Rows.Add(250)

        DataGridView5.Rows.Clear()
        DataGridView5.Rows.Add(250)

        DataGridView6.Rows.Clear()
        DataGridView6.Rows.Add(250)
        Panel2.Visible = False
        LoadComboBox_Currency()
        LoadComboBox_AccItem()
        LoadComboBox_Ekspedisi()
        txt_disc.Text = 0
        TextBox1.Text = 0
        view_data()
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxItem()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_item()

        cbo_idbarang.SelectedIndex = -1
        cbo_idbarang.Items.Clear()
        cbo_idbarang.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_idbarang.SourceDataString = New String(1) {"id_item", "item_name"}
        cbo_idbarang.SourceDataTable = dtLoading
        cbo_idbarang.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxItemName()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_item()

        cbo_nmbarang.SelectedIndex = -1
        cbo_nmbarang.Items.Clear()
        cbo_nmbarang.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_nmbarang.SourceDataString = New String(1) {"item_name", "id_item"}
        cbo_nmbarang.SourceDataTable = dtLoading
        cbo_idbarang.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxUnit()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_unit_item(cbo_idbarang.Text)

        cbo_unit.SelectedIndex = -1
        cbo_unit.Items.Clear()
        cbo_unit.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_unit.SourceDataString = New String(1) {"id_unit", "unit"}
        cbo_unit.SourceDataTable = dtLoading
        cbo_unit.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub


    Private Sub cbo_customer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_customer.Click
        open_conn()
        '  Dim NewDisplayAcc As New frm_display_cust
        frm_display_cust.formsource_so = True
        frm_display_cust.Show()
        ' MainMenu.Enabled = False
        ' Me.Enabled = False
        '  NewDisplayAcc.MdiParent = MainMenu
    End Sub

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        'DataGridView1.ReadOnly = True
        With DataGridView1
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = False
            .Columns(4).ReadOnly = False
            .Columns(6).ReadOnly = False
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(5).ReadOnly = True
            ' .Columns(5).DefaultCellStyle.BackColor = Color.Beige
            .Columns(7).ReadOnly = True
            .Columns(7).DefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
        With DataGridView3
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .ReadOnly = True
        End With
        With DataGridView4
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .ReadOnly = True
        End With
        With DataGridView5
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .ReadOnly = True
        End With
        With DataGridView6
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.BackColor = Color.WhiteSmoke
            .ReadOnly = True
        End With
    End Sub

    Private Sub init_number()
        open_conn()
        txt_tax.Text = FormatPercent(0, 0)
        txt_subtotal.Text = 0
        txt_total.Text = 0
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub cek_qty_stock(ByVal input_qty As Integer, ByVal item_id As String)
        Dim DT_stock As DataTable
        DT_stock = select_get_stock(item_id)
        If DT_stock.Rows(0).Item(0) < input_qty Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Stok Qty " & DT_stock.Rows(0).Item(0) & " Tidak Cukup Untuk Transaksi")
            alertControl_warning.Show(Me, info)
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = DT_stock.Rows(0).Item(0)
        End If
    End Sub

    Dim TSubTotal As Double
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Try
            Dim rows, rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
            Dim columnIndex, rowIndex As Integer
            TSubTotal = 0
            columnIndex = DataGridView1.CurrentCell.ColumnIndex
            rowIndex = DataGridView1.CurrentCell.RowIndex

            If columnIndex = 5 Then
                Dim a As Integer
                Dim DT As DataTable
                DT = select_unit3(DataGridView1.Item(columnIndex, rowIndex).Value)
                a = DT.Rows.Count
                If a = 0 Then
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "No Unit")
                    alertControl_warning.Show(Me, info)
                    DataGridView1.Item(5, rowIndex).Value = ""
                    Exit Sub
                ElseIf a > 0 Then
                    DataGridView1.Item(5, rowIndex).Value = DT.Rows(0).Item(0)
                End If
            End If

            If columnIndex = 4 Then
                If Not IsNumeric(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value) Then
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan format angka")
                    alertControl_warning.Show(Me, info)
                    DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
                    Exit Sub
                End If
                cek_qty_stock(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
                DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value * DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value, 0)
                If chk_brand.Checked = True Then
                    If get_disc_brand(DataGridView1.Item(10, DataGridView1.CurrentCell.RowIndex).Value) > 0 Then
                        DataGridView3.Item(3, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_disc_brand(DataGridView1.Item(10, DataGridView1.CurrentCell.RowIndex).Value) / 100 * DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, 0)
                    End If
                End If
                If chk_category.Checked = True Then
                    If get_disc_cat(DataGridView1.Item(9, DataGridView1.CurrentCell.RowIndex).Value) > 0 Then
                        DataGridView5.Item(3, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_disc_cat(DataGridView1.Item(9, DataGridView1.CurrentCell.RowIndex).Value) / 100 * DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, 0)
                    End If
                End If
                If chk_type.Checked = True Then
                    If get_disc_type(DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value) > 0 Then
                        DataGridView4.Item(3, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_disc_type(DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value) / 100 * DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, 0)
                    End If
                End If

                'generate disc other item
                Call generate_item_disc()

            End If

            If columnIndex = 5 Then
                Call generate_item_disc()
            End If

            If columnIndex = 6 Then
                If Not IsNumeric(DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value) Then
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan Format Angka")
                    alertControl_warning.Show(Me, info)
                    DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = 0
                    Exit Sub
                End If
                DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value, 0)
                DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value * DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value, 0)
                If chk_brand.Checked = True Then
                    If get_disc_brand(DataGridView1.Item(10, DataGridView1.CurrentCell.RowIndex).Value) > 0 Then
                        DataGridView3.Item(3, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_disc_brand(DataGridView1.Item(10, DataGridView1.CurrentCell.RowIndex).Value) / 100 * DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, 0)
                    End If
                End If
                If chk_category.Checked = True Then
                    If get_disc_cat(DataGridView1.Item(9, DataGridView1.CurrentCell.RowIndex).Value) > 0 Then
                        DataGridView5.Item(3, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_disc_cat(DataGridView1.Item(9, DataGridView1.CurrentCell.RowIndex).Value) / 100 * DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, 0)
                    End If
                End If
                If chk_type.Checked = True Then
                    If get_disc_type(DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value) > 0 Then
                        DataGridView4.Item(3, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(get_disc_type(DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value) / 100 * DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, 0)
                    End If
                End If

                'generate disc other item
                Call generate_item_disc()
            End If
            If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
                DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
                DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = 0
                DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = 0
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item Kosong")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If



            Dim tDisc_brand As Double
            Dim tDisc_type As Double
            Dim tDisc_cat As Double

            tDisc_brand = 0
            tDisc_type = 0
            tDisc_cat = 0

            If chk_brand.Checked = True Then
                rows_disc_brand = DataGridView3.Rows.Count - 1
                For i As Integer = 0 To rows_disc_brand
                    tDisc_brand = tDisc_brand + Replace(DataGridView3.Item(3, i).Value, ",", "")
                Next
            End If

            If chk_type.Checked = True Then
                rows_disc_type = DataGridView4.Rows.Count - 1
                For i As Integer = 0 To rows_disc_type
                    tDisc_type = tDisc_type + Replace(DataGridView4.Item(3, i).Value, ",", "")
                Next
            End If

            If chk_category.Checked = True Then
                rows_disc_cat = DataGridView5.Rows.Count - 1
                For i As Integer = 0 To rows_disc_cat
                    tDisc_cat = tDisc_cat + Replace(DataGridView5.Item(3, i).Value, ",", "")
                Next
            End If

            rows = DataGridView1.Rows.Count - 1
            For i = 0 To rows
                TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
            Next
            TSubTotal = TSubTotal - tDisc_brand - tDisc_type - tDisc_cat
            txt_subtotal.Text = FormatNumber(TSubTotal, 0)

            hitung_nominal()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(Me, info)
            Exit Sub
        End Try
    End Sub

    Private Sub generate_item_disc()
        Dim DTDisc As DataTable
        DataGridView6.Rows.Clear()
        DataGridView6.Rows.Add(250)

        If chk_item.Checked = True Then
            For y As Integer = 0 To DataGridView1.Rows.Count - 1
                If Trim(DataGridView1.Item(1, y).Value) <> "" Then
                    If DataGridView1.Item(4, y).Value >= get_qty_todisc(DataGridView1.Item(1, y).Value) And DataGridView1.Item(5, y).Value = get_unit_tobonus(DataGridView1.Item(1, y).Value) Then
                        DTDisc = get_disc_otheritem(DataGridView1.Item(1, y).Value)
                        If DTDisc.Rows.Count > 0 Then
                            For x As Integer = 0 To DTDisc.Rows.Count - 1
                                DataGridView6.Item(0, x).Value = x + 1
                                DataGridView6.Item(1, x).Value = DTDisc.Rows(x).Item("id_item_disc")
                                DataGridView6.Item(2, x).Value = DTDisc.Rows(x).Item("item_name_disc")
                                DataGridView6.Item(3, x).Value = DTDisc.Rows(x).Item("qty")
                                DataGridView6.Item(4, x).Value = DTDisc.Rows(x).Item("id_unit")
                            Next
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Sub hitung_nominal()
        open_conn()
        Dim TNett As Double
        Dim Ttotal As Double
        Dim Tchange As Double

        TNett = 0
        Ttotal = 0
        Tchange = 0

        'menghitung netto
        TNett = TSubTotal - (TSubTotal * CDbl(Replace(txt_disc.Text, "%", "")) / 100)
        txt_netto.Text = FormatNumber(TNett, 0)

        'menghitung ppn
        If chk_ppn.Checked = True Then
            Dim DT As DataTable
            DT = get_tax_rate("PPN")
            txt_tax.Text = DT.Rows(0).Item(0)
            txt_tax_nominal.Text = FormatNumber((DT.Rows(0).Item(0) / 100) * (CDbl(Replace(TNett, ",", ""))), 0)
        ElseIf chk_ppn.Checked = False Then
            txt_tax.Text = 0
            txt_tax_nominal.Text = 0
        End If

        'menghitung total
        Dim freight As Double
        freight = Replace(TextBox1.Text, ",", "")
        Ttotal = TNett + (TNett * (CDbl(Replace(txt_tax.Text, "%", "")) / 100)) + freight
        txt_total.Text = FormatNumber(Ttotal, 0)

        'menghitung change
        'Tchange = (CDbl(txt_paid.Text)) - Ttotal
        'txt_change.Text = FormatNumber(Tchange, 0)
    End Sub

    Private Sub txt_tax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        txt_tax.SelectionStart = 0
        txt_tax.SelectionLength = Len(txt_tax.Text)
    End Sub

    Private Sub txt_tax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        TSubTotal = 0
        Dim i As Integer
        If txt_tax.Text = "" Then
            txt_tax.Text = FormatPercent(0, 0)
        Else
            txt_tax.Text = FormatPercent(CDbl(Replace(txt_tax.Text, "%", "")) / 100, 0)
        End If
        For i = 0 To DataGridView1.Rows.Count - 1
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        hitung_nominal()
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        'open_conn()
        'mRow = DataGridView1.CurrentCell.RowIndex
        'mCol = DataGridView1.CurrentCell.ColumnIndex
        ''i = DataGridView1.CurrentCell.ColumnIndex
        ''If i = 1 Or i = 2 Then
        ''    Dim NewDisplayAcc As New frm_display_acc_detail
        ''    NewDisplayAcc.formsource_journal_noacc = True
        ''    NewDisplayAcc.Show()
        ''End If
        'DataGridView1.Item(0, mRow).Value = mRow + 1
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        i = DataGridView1.CurrentCell.ColumnIndex
        If i = 1 Or i = 2 Then
            'Dim NewDisplayAcc As New frm_display_item
            'NewDisplayAcc.formsource_ro_item = True
            'NewDisplayAcc.Show()
            '' MainMenu.Enabled = False
        End If
        DataGridView1.Item(0, mRow).Value = mRow + 1
    End Sub

    Private Sub clean()
        open_conn()
        With Me
            .txt_comment.Text = ""
            .txt_cust_address.Text = ""
            .txt_customer_nm.Text = ""
            .txt_date.Value = Now
            .txt_search.Text = ""
            .txt_subtotal.Text = 0
            .txt_tax.Text = 0
            .txt_total.Text = 0
            .cbo_customer.Text = ""
            .txt_curr.Text = ""
            .txt_tax_nominal.Text = ""
            .cbo_marketing.Text = ""
            .txt_um.Text = 0
            .cbo_acc.Text = ""
            .txt_disc.Text = 0
            .TextBox1.Text = 0
            .btn_del2.Enabled = False
            .btn_cetak.Enabled = False
        End With
        ' For i = 0 To DataGridView1.Rows.Count - 1
        'DataGridView1.Item(0, i).Value = ""
        'DataGridView1.Item(1, i).Value = ""
        'DataGridView1.Item(2, i).Value = ""
        'DataGridView1.Item(3, i).Value = ""
        'DataGridView1.Item(4, i).Value = 0
        'DataGridView1.Item(5, i).Value = ""
        'DataGridView1.Item(6, i).Value = 0
        'DataGridView1.Item(7, i).Value = 0
        'DataGridView1.Rows.RemoveAt(i)
        'Next
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        DataGridView3.Rows.Clear()
        DataGridView3.Rows.Add(250)
        DataGridView4.Rows.Clear()
        DataGridView4.Rows.Add(250)
        DataGridView5.Rows.Clear()
        DataGridView5.Rows.Add(250)
        DataGridView6.Rows.Clear()
        DataGridView6.Rows.Add(250)
        Call select_control_no("SALES_ORDER", "TRANS")
        txt_so_no.Text = no_master
        cbo_search.Text = "SO No"
        insert = 1
        edit = 0
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        txt_curr.Text = get_def_curr()
        chk_ppn.Checked = False
        txt_kurs.Text = 1
        TextBox1.Text = 0
        cbo_ekspedisi.Text = ""
        txt_total.Text = 0
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxMark()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_marketing()

        cbo_marketing.SelectedIndex = -1
        cbo_marketing.Items.Clear()
        cbo_marketing.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_marketing.SourceDataString = New String(1) {"id_employee", "nama"}
        cbo_marketing.SourceDataTable = dtLoading
        cbo_marketing.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub insert_data()
        open_conn()
        Dim i As Integer
        Dim var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem As Integer

        If chk_brand.Checked = True Then
            var_is_discbrand = 1
        Else
            var_is_discbrand = 0
        End If

        If chk_type.Checked = True Then
            var_is_disctype = 1
        Else
            var_is_disctype = 0
        End If

        If chk_category.Checked = True Then
            var_is_disccat = 1
        Else
            var_is_disccat = 0
        End If

        If chk_item.Checked = True Then
            var_is_discitem = 1
        Else
            var_is_discitem = 0
        End If

        If insert = 1 Then
            Call insert_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                0, "", "", 0, "", 0, 0, "", 0, 0, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), "", "", "", "", 0, 0, 0, Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, 0, DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
            For i = 0 To DataGridView1.Rows.Count - 1
                If Trim(DataGridView1.Item(1, i).Value) <> "" Then
                    Call insert_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, txt_curr.Text, 1, 0, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), DataGridView1.Item(2, i).Value, DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(4, i).Value, Replace(DataGridView3.Item(3, i).Value, ",", ""), Replace(DataGridView4.Item(3, i).Value, ",", ""), Replace(DataGridView5.Item(3, i).Value, ",", ""), Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, Replace(DataGridView6.Item(3, i).Value, ",", ""), DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
                End If
            Next

            For i = 0 To DataGridView3.Rows.Count - 1
                If Trim(DataGridView3.Item(1, i).Value) <> "" Then
                    Call insert_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, txt_curr.Text, 2, 0, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), DataGridView1.Item(2, i).Value, DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(4, i).Value, Replace(DataGridView3.Item(3, i).Value, ",", ""), Replace(DataGridView4.Item(3, i).Value, ",", ""), Replace(DataGridView5.Item(3, i).Value, ",", ""), Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, Replace(DataGridView6.Item(3, i).Value, ",", ""), DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
                End If
            Next

            For i = 0 To DataGridView5.Rows.Count - 1
                If Trim(DataGridView5.Item(1, i).Value) <> "" Then
                    Call insert_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, txt_curr.Text, 3, 0, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), DataGridView1.Item(2, i).Value, DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(4, i).Value, Replace(DataGridView3.Item(3, i).Value, ",", ""), Replace(DataGridView4.Item(3, i).Value, ",", ""), Replace(DataGridView5.Item(3, i).Value, ",", ""), Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, Replace(DataGridView6.Item(3, i).Value, ",", ""), DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
                End If
            Next

            For i = 0 To DataGridView4.Rows.Count - 1
                If Trim(DataGridView4.Item(1, i).Value) <> "" Then
                    Call insert_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, txt_curr.Text, 4, 0, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), DataGridView1.Item(2, i).Value, DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(4, i).Value, Replace(DataGridView3.Item(3, i).Value, ",", ""), Replace(DataGridView4.Item(3, i).Value, ",", ""), Replace(DataGridView5.Item(3, i).Value, ",", ""), Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, Replace(DataGridView6.Item(3, i).Value, ",", ""), DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
                End If
            Next

            For i = 0 To DataGridView6.Rows.Count - 1
                If Trim(DataGridView6.Item(1, i).Value) <> "" Then
                    Call insert_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, txt_curr.Text, 5, 0, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), DataGridView1.Item(2, i).Value, DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(4, i).Value, Replace(DataGridView3.Item(3, i).Value, ",", ""), Replace(DataGridView4.Item(3, i).Value, ",", ""), Replace(DataGridView5.Item(3, i).Value, ",", ""), Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, Replace(DataGridView6.Item(3, i).Value, ",", ""), DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
                End If
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "SALES_ORDER")
                pesan = MsgBox("Cetak SO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormNotaSO
                    NoBuktiSO = Trim(txt_so_no.Text)
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
            If select_validate("Sales Order", Trim(txt_so_no.Text)) > 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "SO Sudah diproses ke faktur")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
            Call update_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                0, "", "", 0, "", 0, 0, "", 0, 0, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), "", "", "", "", 0, 0, 0, Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, 0, DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
            For i = 0 To DataGridView1.Rows.Count - 1
                If Trim(DataGridView1.Item(1, i).Value) <> "" Then
                    Call update_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, txt_curr.Text, 1, i, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), DataGridView1.Item(2, i).Value, DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(4, i).Value, Replace(DataGridView3.Item(3, i).Value, ",", ""), Replace(DataGridView4.Item(3, i).Value, ",", ""), Replace(DataGridView5.Item(3, i).Value, ",", ""), Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, Replace(DataGridView6.Item(3, i).Value, ",", ""), DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
                End If
            Next

            For i = 0 To DataGridView3.Rows.Count - 1
                If Trim(DataGridView3.Item(1, i).Value) <> "" Then
                    Call update_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, txt_curr.Text, 2, i, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), DataGridView1.Item(2, i).Value, DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(4, i).Value, Replace(DataGridView3.Item(3, i).Value, ",", ""), Replace(DataGridView4.Item(3, i).Value, ",", ""), Replace(DataGridView5.Item(3, i).Value, ",", ""), Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, Replace(DataGridView6.Item(3, i).Value, ",", ""), DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
                End If
            Next

            For i = 0 To DataGridView5.Rows.Count - 1
                If Trim(DataGridView5.Item(1, i).Value) <> "" Then
                    Call update_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, txt_curr.Text, 3, i, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), DataGridView1.Item(2, i).Value, DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(4, i).Value, Replace(DataGridView3.Item(3, i).Value, ",", ""), Replace(DataGridView4.Item(3, i).Value, ",", ""), Replace(DataGridView5.Item(3, i).Value, ",", ""), Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, Replace(DataGridView6.Item(3, i).Value, ",", ""), DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
                End If
            Next

            For i = 0 To DataGridView4.Rows.Count - 1
                If Trim(DataGridView4.Item(1, i).Value) <> "" Then
                    Call update_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, txt_curr.Text, 4, i, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), DataGridView1.Item(2, i).Value, DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(4, i).Value, Replace(DataGridView3.Item(3, i).Value, ",", ""), Replace(DataGridView4.Item(3, i).Value, ",", ""), Replace(DataGridView5.Item(3, i).Value, ",", ""), Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, Replace(DataGridView6.Item(3, i).Value, ",", ""), DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
                End If
            Next

            For i = 0 To DataGridView6.Rows.Count - 1
                If Trim(DataGridView6.Item(1, i).Value) <> "" Then
                    Call update_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, txt_curr.Text, 5, i, Replace(txt_kurs.Text, ",", ""), Trim(cbo_marketing.Text), DataGridView1.Item(2, i).Value, DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(4, i).Value, Replace(DataGridView3.Item(3, i).Value, ",", ""), Replace(DataGridView4.Item(3, i).Value, ",", ""), Replace(DataGridView5.Item(3, i).Value, ",", ""), Replace(txt_disc.Text, ",", ""), Replace(txt_netto.Text, ",", ""), var_is_discbrand, var_is_disctype, var_is_disccat, var_is_discitem, Replace(DataGridView6.Item(3, i).Value, ",", ""), DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value, DataGridView1.Item(10, i).Value, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""), cbo_ekspedisi.Text, Replace(TextBox1.Text, ",", ""))
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

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_SO_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SO_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Item(2, i).Value = "" And DataGridView1.Item(1, i).Value <> "" Then
        '        MsgBox("Data Unit Belum Lengkap", MsgBoxStyle.Information, "Informasi")
        '        Exit Sub
        '    End If
        'Next
        If trial = True Then
            If get_count_data("trn_sales_order_head", "no_sales_order") > row_trial Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Batas untuk input versi trial telah habis, silahkan membeli produk ini")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        If Trim(txt_um.Text) = "" Then
            txt_um.Text = 0
        End If
        If txt_um.Text > 0 And Trim(cbo_acc.Text = "") Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Account UM Belum Di isi")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If txt_um.Text > 0 And Trim(cbo_curr_um.Text = "") Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Mata Uang Pembayaran UM Belum Di isi")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        insert_data()
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
            DT = select_sales_order(Trim(cbo_search.Text), Trim(txt_search.Text), 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))

            GridControl.DataSource = DT
            GridList_Customer.Columns("no_sales_order").Caption = "No SO"
            GridList_Customer.Columns("no_sales_order").Width = 165
            GridList_Customer.Columns("nama").Caption = "Pelanggan"
            GridList_Customer.Columns("nama").Width = 180
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 95
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("subtotal").Caption = "Sub Total"
            GridList_Customer.Columns("subtotal").Width = 160
            GridList_Customer.Columns("subtotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("subtotal").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("tax").Caption = "PPN"
            GridList_Customer.Columns("tax").Width = 140
            GridList_Customer.Columns("tax").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("tax").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("total").Caption = "Total"
            GridList_Customer.Columns("total").Width = 160
            GridList_Customer.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("total").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 250
            GridList_Customer.Columns("id_customer").Visible = False
            GridList_Customer.Columns("address").Visible = False
            ' GridList_Customer.BestFitColumns()
            'Rows = DT.Rows.Count - 1

            'DataGridView2.Rows.Clear()
            'Dim i As Integer
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            '        DataGridView2.Item(2, i).Value = Format(DT.Rows(i).Item(2), "yyyy-MM-dd")
            '        DataGridView2.Item(3, i).Value = FormatNumber(DT.Rows(i).Item(3), 0)
            '        DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item(4), 0)
            '        DataGridView2.Item(5, i).Value = FormatNumber(DT.Rows(i).Item(5), 0)
            '        DataGridView2.Item(6, i).Value = DT.Rows(i).Item(6)
            '    Next
            'End If

        Finally
            SplashScreenManager.CloseForm(False)
        End Try

        '   End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        view_data()

        'Dim Total_Width_Column, Total_Width_Column2 As Integer
        'Dim Width_Table, Width_Table2 As Integer
        'Dim selisih_col, selisih_col2 As Integer

        'With DataGridView1
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(3).Width = .Columns(3).Width + selisih_col
        'End With
        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(6).Width = .Columns(6).Width + selisih_col2
        'End With
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        TSubTotal = 0
        'current_row = cbo_acc_group.SelectedIndex
        insert = 0
        edit = 1
        Dim DT, DTBrand, DTType, DTCat, DTItem As DataTable
        Dim rows, rowsbrand, rowstype, rowscat, rowsitem As Integer
        Dim date_filter As Integer
        If chk_date.Checked = True Then
            date_filter = 1
        ElseIf chk_date.Checked = False Then
            date_filter = 0
        End If

        DT = select_sales_order("no_sales_order", criteria, 1, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rows = DT.Rows.Count - 1
        If DT.Rows.Count > 0 Then
            cbo_customer.Text = DT.Rows(0).Item("id_customer")
            txt_customer_nm.Text = DT.Rows(0).Item("nama")
            txt_cust_address.Text = DT.Rows(0).Item("address")
            txt_so_no.Text = DT.Rows(0).Item("no_sales_order")
            txt_date.Value = DT.Rows(0).Item("date_trn")
            txt_curr.Text = DT.Rows(0).Item("id_curr")
            txt_comment.Text = DT.Rows(0).Item("notes")
            txt_subtotal.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
            cbo_marketing.SelectedText = ""
            cbo_marketing.Text = DT.Rows(0).Item("id_employee")
            txt_um.Text = FormatNumber(DT.Rows(0).Item("uang_muka"), 0)
            cbo_acc.Text = DT.Rows(0).Item("id_account")
            cbo_curr_um.Text = ""
            cbo_curr_um.SelectedText = DT.Rows(0).Item("id_curr_um")
            If DT.Rows(0).Item("is_discbrand") = 0 Then
                chk_brand.Checked = False
            Else
                chk_brand.Checked = True
            End If
            If DT.Rows(0).Item("is_disctype") = 0 Then
                chk_type.Checked = False
            Else
                chk_type.Checked = True
            End If
            If DT.Rows(0).Item("is_disccat") = 0 Then
                chk_category.Checked = False
            Else
                chk_category.Checked = True
            End If
            If DT.Rows(0).Item("is_discitem") = 0 Then
                chk_item.Checked = False
            Else
                chk_item.Checked = True
            End If
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(200)
            Dim i As Integer
            For i = 0 To rows
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("description")
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("qty"), 0)
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
                'dgvcc.Value = DT.Rows(i).Item("id_unit")
                DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
                DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)
                DataGridView1.Item(8, i).Value = DT.Rows(i).Item("id_type_disc")
                DataGridView1.Item(9, i).Value = DT.Rows(i).Item("id_cat_disc")
                DataGridView1.Item(10, i).Value = DT.Rows(i).Item("id_brand_disc")

            Next

            For i = 0 To DataGridView1.Rows.Count - 1
                TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
            Next
            txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        End If

        'ambil discount brand
        DTBrand = select_sales_order("no_sales_order", criteria, 2, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rowsbrand = DTBrand.Rows.Count - 1
        If DTBrand.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To rowsbrand
                DataGridView3.Item(0, i).Value = i + 1
                DataGridView3.Item(1, i).Value = DTBrand.Rows(i).Item("id_item")
                DataGridView3.Item(2, i).Value = DTBrand.Rows(i).Item("item_name")
                DataGridView3.Item(3, i).Value = DTBrand.Rows(i).Item("nom_disc")
            Next
        End If

        'ambil discount type
        DTType = select_sales_order("no_sales_order", criteria, 3, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rowstype = DTType.Rows.Count - 1
        If DTType.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To rowstype
                DataGridView4.Item(0, i).Value = i + 1
                DataGridView4.Item(1, i).Value = DTType.Rows(i).Item("id_item")
                DataGridView4.Item(2, i).Value = DTType.Rows(i).Item("item_name")
                DataGridView4.Item(3, i).Value = DTType.Rows(i).Item("nom_disc")
            Next
        End If

        'ambil discount category
        DTCat = select_sales_order("no_sales_order", criteria, 4, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rowscat = DTCat.Rows.Count - 1
        If DTCat.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To rowscat
                DataGridView5.Item(0, i).Value = i + 1
                DataGridView5.Item(1, i).Value = DTCat.Rows(i).Item("id_item")
                DataGridView5.Item(2, i).Value = DTCat.Rows(i).Item("item_name")
                DataGridView5.Item(3, i).Value = DTCat.Rows(i).Item("nom_disc")
            Next
        End If

        'ambil discount item
        DTItem = select_sales_order("no_sales_order", criteria, 5, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rowsitem = DTItem.Rows.Count - 1
        If DTItem.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To rowsitem
                DataGridView6.Item(0, i).Value = i + 1
                DataGridView6.Item(1, i).Value = DTItem.Rows(i).Item("id_item")
                DataGridView6.Item(2, i).Value = DTItem.Rows(i).Item("item_name")
                DataGridView6.Item(3, i).Value = DTItem.Rows(i).Item("qty")
                DataGridView6.Item(4, i).Value = DTItem.Rows(i).Item("id_unit")
            Next
        End If

        txt_disc.Text = DT.Rows(0).Item("discount")
        txt_netto.Text = FormatNumber(DT.Rows(0).Item("nett_total"), 0)
        txt_tax.Text = FormatPercent(DT.Rows(0).Item("tax") / 100, 0)
        If DT.Rows(0).Item("tax") > 0 Then
            chk_ppn.Checked = True
        Else
            chk_ppn.Checked = False
        End If
        txt_tax_nominal.Text = FormatNumber(DT.Rows(0).Item("tax") / 100 * DT.Rows(0).Item("nett_total"), 0)
        cbo_ekspedisi.Text = ""
        cbo_ekspedisi.SelectedText = DT.Rows(0).Item("id_ekspedisi")
        TextBox1.Text = FormatNumber(DT.Rows(0).Item("freight_est"), 0)
        txt_total.Text = FormatNumber(DT.Rows(0).Item("total_head"), 0)
        btn_del2.Enabled = True
        btn_cetak.Enabled = True
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SO_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If select_validate("Sales Order", Trim(txt_so_no.Text)) > 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "SO sudah diproses di faktur")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                                0, "", "", 0, "", 0, 0, "", 0, 0, Replace(txt_um.Text, ",", ""), Trim(cbo_acc.Text), Trim(cbo_curr_um.Text), Replace(txt_kurs.Text, ",", ""))
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

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        open_conn()
        Dim colIndex As Integer
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        If colIndex = 7 Then
            Dim DisplayNota As New FormNotaSO
            NoBuktiSO = Trim(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
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

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("SALES_ORDER", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("SALES_ORDER", "TRANS")
            cbo_search.Text = "SO No"
            txt_so_no.Text = no_master
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
        cbo_search.Text = "SO No"
        txt_search.Text = ""
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        'Dim cryRpt3 As New ReportDocument
        'Dim pathfilereport As String
        'Dim pathfilepdf As String
        'Dim ReportFormula As String

        'pathfilereport = Application.StartupPath & "\Report\NotaSO.rpt"
        'pathfilepdf = Application.StartupPath & "\Report\NotaSO.pdf"

        'Try
        '    cryRpt3.Load(pathfilereport)

        '    ReportFormula = "{view_ctk_so1.no_sales_order} = '" & Trim(txt_so_no.Text) & "'"
        '    cryRpt3.RecordSelectionFormula = ReportFormula

        '    Dim CrExportOptions As ExportOptions
        '    Dim CrDiskFileDestinationOptions As New  _
        '    DiskFileDestinationOptions()
        '    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        '    CrDiskFileDestinationOptions.DiskFileName = pathfilepdf
        '    CrExportOptions = cryRpt3.ExportOptions
        '    With CrExportOptions
        '        .ExportDestinationType = ExportDestinationType.DiskFile
        '        .ExportFormatType = ExportFormatType.PortableDocFormat
        '        .DestinationOptions = CrDiskFileDestinationOptions
        '        .FormatOptions = CrFormatTypeOptions
        '    End With
        '    cryRpt3.Export()
        '    System.Diagnostics.Process.Start(pathfilepdf)
        'Catch ex As Exception
        '    MsgBox("Nota Sudah Di buka, tutup nota terlebih dahulu", vbInformation, "Information")
        'End Try

        Dim DisplayNota As New FormNotaSO
        NoBuktiSO = Trim(txt_so_no.Text)
        With DisplayNota
            .Show()
            ' .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub cbo_idbarang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_idbarang.Click
        open_conn()
        cbo_idbarang.DroppedDown = True
    End Sub

    Private Sub cbo_idbarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_idbarang.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_idbarang_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_idbarang.SelectedIndexChanged
        open_conn()
        On Error Resume Next
        cbo_nmbarang.Text = cbo_idbarang.SelectedItem.Col2
        LoadComboBox_MtgcComboBoxUnit()
        txt_price.Text = FormatNumber(get_sellprice(cbo_idbarang.Text), 0)
    End Sub

    Private Sub cbo_nmbarang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_nmbarang.Click
        open_conn()
        cbo_nmbarang.DroppedDown = True
    End Sub

    Private Sub cbo_nmbarang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_nmbarang.GotFocus
        open_conn()
        cbo_nmbarang.DroppedDown = True
    End Sub

    Private Sub cbo_nmbarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_nmbarang.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_nmbarang_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_nmbarang.LostFocus
        open_conn()
        cbo_nmbarang.DroppedDown = False
    End Sub

    Private Sub cbo_nmbarang_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_nmbarang.SelectedIndexChanged
        open_conn()
        On Error Resume Next
        cbo_idbarang.Text = cbo_nmbarang.SelectedItem.Col2
        txt_price.Text = FormatNumber(get_sellprice(cbo_idbarang.Text), 0)
    End Sub

    Private Sub cbo_unit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_unit.DroppedDown = True
    End Sub

    Private Sub txt_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub btn_plus_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim rows As Integer
        TSubTotal = 0
        If Val(txt_qty.Text) = 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan Qty")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        If Val(txt_price.Text) = 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan Harga")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Item(1, i).Value = Trim(cbo_idbarang.Text) Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item Sudah Ada Di Detail")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        Next

        DataGridView1.Rows.Add(1)
        DataGridView1.Item(0, IndexRowDg).Value = IndexRowDg + 1
        DataGridView1.Item(1, IndexRowDg).Value = cbo_idbarang.Text
        DataGridView1.Item(2, IndexRowDg).Value = cbo_nmbarang.Text
        DataGridView1.Item(3, IndexRowDg).Value = txt_ket.Text
        DataGridView1.Item(4, IndexRowDg).Value = FormatNumber(Replace(txt_qty.Text, ",", ""), 0)
        DataGridView1.Item(5, IndexRowDg).Value = cbo_unit.Text
        DataGridView1.Item(6, IndexRowDg).Value = txt_price.Text
        DataGridView1.Item(7, IndexRowDg).Value = FormatNumber(Replace(DataGridView1.Item(4, IndexRowDg).Value, ",", "") * Replace(DataGridView1.Item(6, IndexRowDg).Value, ",", ""), 0)
        clearCollector()

        IndexRowDg = IndexRowDg + 1
        rows = DataGridView1.Rows.Count - 1
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)

        hitung_nominal()

        cbo_nmbarang.Focus()

    End Sub

    Private Sub clearCollector()
        open_conn()
        cbo_idbarang.Text = ""
        cbo_nmbarang.Text = ""
        txt_ket.Text = ""
        txt_qty.Text = ""
        txt_price.Text = ""
        cbo_unit.Text = ""
    End Sub

    Private Sub txt_qty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim DT_stock As DataTable
        Dim Qty As Integer
        DT_stock = select_get_stock(cbo_idbarang.Text)
        Qty = Val(txt_qty.Text)
        If Qty > DT_stock.Rows(0).Item(0) Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Stock tidak mencukupi untuk transaksi")
            alertControl_warning.Show(Me, info)
            txt_qty.Text = 0
            Exit Sub
        End If
    End Sub

    Private Sub chk_ppn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ppn.CheckedChanged
        open_conn()
        TSubTotal = 0


        Dim i, rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
        Dim tDisc_brand As Double
        Dim tDisc_type As Double
        Dim tDisc_cat As Double

        tDisc_brand = 0
        tDisc_type = 0
        tDisc_cat = 0

        If chk_brand.Checked = True Then
            rows_disc_brand = DataGridView3.Rows.Count - 1
            For i = 0 To rows_disc_brand
                tDisc_brand = tDisc_brand + Replace(DataGridView3.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_type.Checked = True Then
            rows_disc_type = DataGridView4.Rows.Count - 1
            For i = 0 To rows_disc_type
                tDisc_type = tDisc_type + Replace(DataGridView4.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_category.Checked = True Then
            rows_disc_cat = DataGridView5.Rows.Count - 1
            For i = 0 To rows_disc_cat
                tDisc_cat = tDisc_cat + Replace(DataGridView5.Item(3, i).Value, ",", "")
            Next
        End If

        For i = 0 To DataGridView1.Rows.Count - 1
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        TSubTotal = TSubTotal - tDisc_brand - tDisc_type - tDisc_cat
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        hitung_nominal()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    'Private Sub frmso_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(3).Width = .Columns(3).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(6).Width = .Columns(6).Width + selisih_col2
    '    End With
    'End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub txt_curr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_curr.SelectedIndexChanged
        txt_kurs.Text = FormatNumber(get_def_convertcurr(Trim(txt_curr.Text)), 0)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
        If i = 5 Then
            Dim NewDisplayAcc As New frm_display_unit
            NewDisplayAcc.formsource_so_unit = True
            NewDisplayAcc.Show()
            ' MainMenu.Enabled = False
            Me.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        IndexRowDg = DataGridView1.CurrentCell.RowIndex
        Dim rows As Integer

        If e.KeyCode = Keys.Delete Then
            pesan = MessageBox.Show("Data ingin di hapus?", "Konfirmasi", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                DataGridView1.Rows.RemoveAt(IndexRowDg)
                DataGridView3.Rows.RemoveAt(IndexRowDg)
                DataGridView4.Rows.RemoveAt(IndexRowDg)
                DataGridView5.Rows.RemoveAt(IndexRowDg)
                TSubTotal = 0
                Dim i, rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
                Dim tDisc_brand As Double
                Dim tDisc_type As Double
                Dim tDisc_cat As Double

                tDisc_brand = 0
                tDisc_type = 0
                tDisc_cat = 0

                If chk_brand.Checked = True Then
                    rows_disc_brand = DataGridView3.Rows.Count - 1
                    For i = 0 To rows_disc_brand
                        tDisc_brand = tDisc_brand + Replace(DataGridView3.Item(3, i).Value, ",", "")
                    Next
                End If

                If chk_type.Checked = True Then
                    rows_disc_type = DataGridView4.Rows.Count - 1
                    For i = 0 To rows_disc_type
                        tDisc_type = tDisc_type + Replace(DataGridView4.Item(3, i).Value, ",", "")
                    Next
                End If

                If chk_category.Checked = True Then
                    rows_disc_cat = DataGridView5.Rows.Count - 1
                    For i = 0 To rows_disc_cat
                        tDisc_cat = tDisc_cat + Replace(DataGridView5.Item(3, i).Value, ",", "")
                    Next
                End If

                For i = 0 To DataGridView1.Rows.Count - 1
                    TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
                Next
                TSubTotal = TSubTotal - tDisc_brand - tDisc_type - tDisc_cat
                txt_subtotal.Text = FormatNumber(TSubTotal, 0)
                hitung_nominal()
            End If
        End If
    End Sub

    Private Sub cbo_marketing_GotFocus(sender As Object, e As System.EventArgs) Handles cbo_marketing.GotFocus
        open_conn()
        cbo_marketing.DroppedDown = True
    End Sub



    Private Sub chk_brand_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_brand.CheckedChanged
        Dim rows As Integer
        If chk_brand.Checked = False Then
            DataGridView3.Rows.Clear()
            DataGridView3.Rows.Add(250)
        Else
            DataGridView3.Rows.Clear()
            DataGridView3.Rows.Add(250)
            rows = DataGridView1.Rows.Count - 1
            For i As Integer = 0 To rows
                If Trim(DataGridView1.Item(1, i).Value) <> "" Then
                    If get_disc_brand(DataGridView1.Item(10, i).Value) > 0 Then
                        DataGridView3.Item(0, i).Value = DataGridView1.Item(0, i).Value
                        DataGridView3.Item(1, i).Value = DataGridView1.Item(1, i).Value
                        DataGridView3.Item(2, i).Value = DataGridView1.Item(2, i).Value
                        DataGridView3.Item(3, i).Value = FormatNumber((get_disc_brand(DataGridView1.Item(10, i).Value)) / 100 * Replace(DataGridView1.Item(7, i).Value, ",", ""), 0)
                    End If
                End If
            Next
        End If

        Dim rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
        Dim tDisc_brand As Double
        Dim tDisc_type As Double
        Dim tDisc_cat As Double

        TSubTotal = 0
        tDisc_brand = 0
        tDisc_type = 0
        tDisc_cat = 0

        If chk_brand.Checked = True Then
            rows_disc_brand = DataGridView3.Rows.Count - 1
            For i As Integer = 0 To rows_disc_brand
                tDisc_brand = tDisc_brand + Replace(DataGridView3.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_type.Checked = True Then
            rows_disc_type = DataGridView4.Rows.Count - 1
            For i As Integer = 0 To rows_disc_type
                tDisc_type = tDisc_type + Replace(DataGridView4.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_category.Checked = True Then
            rows_disc_cat = DataGridView5.Rows.Count - 1
            For i As Integer = 0 To rows_disc_cat
                tDisc_cat = tDisc_cat + Replace(DataGridView5.Item(3, i).Value, ",", "")
            Next
        End If

        rows = DataGridView1.Rows.Count - 1
        For i As Integer = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        TSubTotal = TSubTotal - tDisc_brand - tDisc_type - tDisc_cat
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)

        hitung_nominal()

    End Sub

    Private Sub chk_type_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_type.CheckedChanged
        Dim rows As Integer
        If chk_type.Checked = False Then
            DataGridView4.Rows.Clear()
            DataGridView4.Rows.Add(250)
        Else
            DataGridView4.Rows.Clear()
            DataGridView4.Rows.Add(250)
            rows = DataGridView1.Rows.Count - 1
            For i As Integer = 0 To rows
                If Trim(DataGridView1.Item(1, i).Value) <> "" Then
                    If get_disc_type(DataGridView1.Item(8, i).Value) > 0 Then
                        DataGridView4.Item(0, i).Value = DataGridView1.Item(0, i).Value
                        DataGridView4.Item(1, i).Value = DataGridView1.Item(1, i).Value
                        DataGridView4.Item(2, i).Value = DataGridView1.Item(2, i).Value
                        DataGridView4.Item(3, i).Value = FormatNumber((get_disc_type(DataGridView1.Item(8, i).Value)) / 100 * Replace(DataGridView1.Item(7, i).Value, ",", ""), 0)
                    End If
                End If
            Next


        End If

        Dim rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
        Dim tDisc_brand As Double
        Dim tDisc_type As Double
        Dim tDisc_cat As Double

        TSubTotal = 0
        tDisc_brand = 0
        tDisc_type = 0
        tDisc_cat = 0

        If chk_brand.Checked = True Then
            rows_disc_brand = DataGridView3.Rows.Count - 1
            For i As Integer = 0 To rows_disc_brand
                tDisc_brand = tDisc_brand + Replace(DataGridView3.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_type.Checked = True Then
            rows_disc_type = DataGridView4.Rows.Count - 1
            For i As Integer = 0 To rows_disc_type
                tDisc_type = tDisc_type + Replace(DataGridView4.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_category.Checked = True Then
            rows_disc_cat = DataGridView5.Rows.Count - 1
            For i As Integer = 0 To rows_disc_cat
                tDisc_cat = tDisc_cat + Replace(DataGridView5.Item(3, i).Value, ",", "")
            Next
        End If

        rows = DataGridView1.Rows.Count - 1
        For i As Integer = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        TSubTotal = TSubTotal - tDisc_brand - tDisc_type - tDisc_cat
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)

        hitung_nominal()
    End Sub

    Private Sub chk_category_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_category.CheckedChanged
        Dim rows, rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
        If chk_category.Checked = False Then
            DataGridView5.Rows.Clear()
            DataGridView5.Rows.Add(250)
        Else
            DataGridView5.Rows.Clear()
            DataGridView5.Rows.Add(250)
            rows = DataGridView1.Rows.Count - 1
            For i As Integer = 0 To rows
                If Trim(DataGridView1.Item(1, i).Value) <> "" Then
                    If get_disc_cat(DataGridView1.Item(9, i).Value) > 0 Then
                        DataGridView5.Item(0, i).Value = DataGridView1.Item(0, i).Value
                        DataGridView5.Item(1, i).Value = DataGridView1.Item(1, i).Value
                        DataGridView5.Item(2, i).Value = DataGridView1.Item(2, i).Value
                        DataGridView5.Item(3, i).Value = FormatNumber((get_disc_cat(DataGridView1.Item(9, i).Value)) / 100 * Replace(DataGridView1.Item(7, i).Value, ",", ""), 0)
                    End If
                End If
            Next
        End If
        Dim tDisc_brand As Double
        Dim tDisc_type As Double
        Dim tDisc_cat As Double

        TSubTotal = 0
        tDisc_brand = 0
        tDisc_type = 0
        tDisc_cat = 0

        If chk_brand.Checked = True Then
            rows_disc_brand = DataGridView3.Rows.Count - 1
            For i As Integer = 0 To rows_disc_brand
                tDisc_brand = tDisc_brand + Replace(DataGridView3.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_type.Checked = True Then
            rows_disc_type = DataGridView4.Rows.Count - 1
            For i As Integer = 0 To rows_disc_type
                tDisc_type = tDisc_type + Replace(DataGridView4.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_category.Checked = True Then
            rows_disc_cat = DataGridView5.Rows.Count - 1
            For i As Integer = 0 To rows_disc_cat
                tDisc_cat = tDisc_cat + Replace(DataGridView5.Item(3, i).Value, ",", "")
            Next
        End If

        rows = DataGridView1.Rows.Count - 1
        For i As Integer = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        TSubTotal = TSubTotal - tDisc_brand - tDisc_type - tDisc_cat
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)

        hitung_nominal()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_item.CheckedChanged
        Dim DT As DataTable
        If chk_item.Checked = False Then
            DataGridView6.Rows.Clear()
            DataGridView6.Rows.Add(250)
        Else
            Dim rows, rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
            DataGridView6.Rows.Clear()
            DataGridView6.Rows.Add(250)
            rows = DataGridView1.Rows.Count - 1
            For i As Integer = 0 To rows
                If Trim(DataGridView1.Item(1, i).Value) <> "" Then
                    If DataGridView1.Item(4, i).Value >= get_qty_todisc(DataGridView1.Item(1, i).Value) And DataGridView1.Item(5, i).Value = get_unit_tobonus(DataGridView1.Item(1, i).Value) Then
                        DT = get_disc_otheritem(DataGridView1.Item(1, i).Value)
                        If DT.Rows.Count > 0 Then
                            For x As Integer = 0 To DT.Rows.Count - 1
                                DataGridView6.Item(0, x).Value = x + 1
                                DataGridView6.Item(1, x).Value = DT.Rows(x).Item("id_item_disc")
                                DataGridView6.Item(2, x).Value = DT.Rows(x).Item("item_name_disc")
                                DataGridView6.Item(3, x).Value = DT.Rows(x).Item("qty")
                                DataGridView6.Item(4, x).Value = DT.Rows(x).Item("id_unit")
                            Next
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub txt_disc_LostFocus(sender As Object, e As System.EventArgs) Handles txt_disc.LostFocus
        open_conn()
        TSubTotal = 0

        Dim i, rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
        Dim tDisc_brand As Double
        Dim tDisc_type As Double
        Dim tDisc_cat As Double

        tDisc_brand = 0
        tDisc_type = 0
        tDisc_cat = 0

        If chk_brand.Checked = True Then
            rows_disc_brand = DataGridView3.Rows.Count - 1
            For i = 0 To rows_disc_brand
                tDisc_brand = tDisc_brand + Replace(DataGridView3.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_type.Checked = True Then
            rows_disc_type = DataGridView4.Rows.Count - 1
            For i = 0 To rows_disc_type
                tDisc_type = tDisc_type + Replace(DataGridView4.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_category.Checked = True Then
            rows_disc_cat = DataGridView5.Rows.Count - 1
            For i = 0 To rows_disc_cat
                tDisc_cat = tDisc_cat + Replace(DataGridView5.Item(3, i).Value, ",", "")
            Next
        End If

        For i = 0 To DataGridView1.Rows.Count - 1
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        TSubTotal = TSubTotal - tDisc_brand - tDisc_type - tDisc_cat
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        hitung_nominal()
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim columnIndex, rowIndex As Integer
        TSubTotal = 0
        Try
            columnIndex = DataGridView1.CurrentCell.ColumnIndex
            rowIndex = DataGridView1.CurrentCell.RowIndex
        Catch ex As Exception
            columnIndex = 0
            rowIndex = 0
        End Try
        
        If columnIndex = 5 Then
            generate_item_disc()
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Panel2.Visible = False

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Panel2.Visible = True
        txt_totalcsh.Text = txt_total.Text
        Dim DT As New DataTable
        Dim um As Double
        DT = get_um_so(Trim(txt_so_no.Text))
        If DT.Rows.Count > 0 Then
            um = DT.Rows(0).Item(0)
        End If
        txt_bayarum.Text = FormatNumber(um, 0)
        txt_sisa_tagihan.Text = FormatNumber(CDbl(Replace(txt_total.Text, ",", "")) - um, 0)

    End Sub

    Private Sub LoadComboBox_Currency()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_curr()

        cbo_curr_um.SelectedIndex = -1
        cbo_curr_um.Items.Clear()
        cbo_curr_um.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_curr_um.SourceDataString = New String(1) {"id_currency", "currency"}
        cbo_curr_um.SourceDataTable = dtLoading
        cbo_curr_um.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList

    End Sub

    Private Sub LoadComboBox_AccItem()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_cashbank_all()

        cbo_acc.SelectedIndex = -1
        cbo_acc.Items.Clear()
        cbo_acc.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_acc.SourceDataString = New String(1) {"id_account", "account_name"}
        cbo_acc.SourceDataTable = dtLoading
        cbo_acc.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList

    End Sub

    Private Sub LoadComboBox_Ekspedisi()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_ekspedisi()

        cbo_ekspedisi.SelectedIndex = -1
        cbo_ekspedisi.Items.Clear()
        cbo_ekspedisi.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_ekspedisi.SourceDataString = New String(1) {"id_expedition", "expedition_name"}
        cbo_ekspedisi.SourceDataTable = dtLoading
        cbo_ekspedisi.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList

    End Sub

    Private Sub txt_bayarum_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_bayarum.TextChanged
        Dim total, um, sisa As Double
        total = CDbl(Replace(txt_total.Text, ",", ""))
        um = CDbl(Replace(txt_bayarum.Text, ",", ""))
        sisa = total - um
        txt_sisa_tagihan.Text = FormatNumber(sisa, 0)
        txt_bayarum.Text = FormatNumber(um, 0)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Panel2.Visible = False
        txt_um.Text = FormatNumber(txt_bayarum.Text, 0)
    End Sub

    Private Sub Panel4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub cbo_curr_um_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        txt_kurs_um.Text = FormatNumber(get_kurs(cbo_curr_um.Text), 0)
    End Sub

    Private Sub MtgcComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_ekspedisi.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox1.LostFocus
        open_conn()
        TSubTotal = 0


        Dim i, rows_disc_brand, rows_disc_type, rows_disc_cat As Integer
        Dim tDisc_brand As Double
        Dim tDisc_type As Double
        Dim tDisc_cat As Double

        tDisc_brand = 0
        tDisc_type = 0
        tDisc_cat = 0

        If chk_brand.Checked = True Then
            rows_disc_brand = DataGridView3.Rows.Count - 1
            For i = 0 To rows_disc_brand
                tDisc_brand = tDisc_brand + Replace(DataGridView3.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_type.Checked = True Then
            rows_disc_type = DataGridView4.Rows.Count - 1
            For i = 0 To rows_disc_type
                tDisc_type = tDisc_type + Replace(DataGridView4.Item(3, i).Value, ",", "")
            Next
        End If

        If chk_category.Checked = True Then
            rows_disc_cat = DataGridView5.Rows.Count - 1
            For i = 0 To rows_disc_cat
                tDisc_cat = tDisc_cat + Replace(DataGridView5.Item(3, i).Value, ",", "")
            Next
        End If

        For i = 0 To DataGridView1.Rows.Count - 1
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        TSubTotal = TSubTotal - tDisc_brand - tDisc_type - tDisc_cat
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        hitung_nominal()
        TextBox1.Text = FormatNumber(TextBox1.Text, 0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_sales_order"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_sales_order"))
        End If
    End Sub

    Private Sub txt_kurs_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_kurs.TextChanged

    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        PanelControl3.Visible = False
        enableMain()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            view_data()
            Dim DT_SO_thisMonth As DataTable
            DT_SO_thisMonth = notifSOThisMonth()
            FrmCommandPanel.GridControl1.DataSource = DT_SO_thisMonth
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub GridControl_Click(sender As System.Object, e As System.EventArgs) Handles GridControl.Click

    End Sub

    Private Sub txt_cust_address_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_cust_address.TextChanged

    End Sub

    Private Sub GroupControl2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub PanelControl3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelControl3.Paint

    End Sub

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
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

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub cbo_customer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_customer.SelectedIndexChanged

    End Sub
End Class