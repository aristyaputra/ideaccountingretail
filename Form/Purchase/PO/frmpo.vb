Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmpo

    Dim i As Integer
    Dim a As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Public NoBuktiPO As String
    Dim IndexRowDg As Integer

    Private Sub frmpo_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmpo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmpo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            'Dim NewDisplayAcc As New frm_display_ro
            frm_display_ro.formsource_po_item = True
            frm_display_ro.Show()
            ' MainMenu.Enabled = False
            'Me.Enabled = False
        End If
    End Sub

    Private Sub fillComboBox()
        Dim DT As DataTable
        DT = select_combo_supplier()
        Lookup_Pelanggan.Properties.DataSource = DT
        Lookup_Pelanggan.Properties.DisplayMember = "id_supplier"
        Lookup_Pelanggan.Properties.ValueMember = "id_supplier"
        Lookup_Pelanggan.Properties.PopulateViewColumns()
        Lookup_Pelanggan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Lookup_Pelanggan.Properties.View.OptionsView.ShowAutoFilterRow = True
        Lookup_Pelanggan.Properties.View.Columns("id_supplier").Caption = "ID Supplier"
        Lookup_Pelanggan.Properties.View.Columns("name").Caption = "Nama"
        Lookup_Pelanggan.Properties.View.Columns("address").Caption = "Alamat"

        Dim DTAccount As DataTable
        DTAccount = select_combo_cashbank()
        txt_account_um.Properties.DataSource = DTAccount
        txt_account_um.Properties.DisplayMember = "account_name"
        txt_account_um.Properties.ValueMember = "id_account"
        txt_account_um.Properties.PopulateViewColumns()
        txt_account_um.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        txt_account_um.Properties.View.OptionsView.ShowAutoFilterRow = True
        txt_account_um.Properties.View.Columns("id_account").Caption = "No Akun"
        txt_account_um.Properties.View.Columns("account_name").Caption = "Nama Akun"
    End Sub


    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Dim DT As New DataTable
        Dim Rows As Integer
        Dim i As Integer
        insert = 1
        edit = 0
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("PO", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("PO", "TRANS")
        cbo_search.Text = "PO No"
        txt_po_no.Text = no_master
        cbo_curr.Text = get_def_curr()
        cbo_curr.Items.Clear()
        DT = select_curr()
        Panel1.Visible = False
        Rows = DT.Rows.Count - 1
        For i = 0 To Rows
            cbo_curr.Items.Add(DT.Rows(i).Item(0))
        Next
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
        txt_tax_nominal.Text = 0
        ' LoadComboBox_MtgcComboBoxPOApproved()
        lbl_kurs.Text = get_def_curr()
        txt_kurs.Text = 1
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        fillComboBox()
        'GridList_Customer.OptionsView.ColumnAutoWidth = False
        cbo_unit2.Visible = False
        SimpleButton1.Visible = False
        view_data()

    End Sub

    Private Sub LoadComboBox_MtgcComboBoxPOApproved()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_supplier()

        cbo_supplier2.SelectedIndex = -1
        cbo_supplier2.Items.Clear()
        cbo_supplier2.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_supplier2.SourceDataString = New String(2) {"id_supplier", "name", "address"}
        cbo_supplier2.SourceDataTable = dtLoading
        cbo_supplier2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub


    Private Sub init_number()
        open_conn()
        txt_tax.Text = FormatPercent(0, 0)
        txt_subtotal.Text = 0
        txt_amount.Text = 0
        txt_freight.Text = 0
    End Sub
    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = False
        DataGridView1.Columns(4).ReadOnly = True
        DataGridView1.Columns(5).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = False
        DataGridView1.Columns(7).ReadOnly = True
        DataGridView1.Columns(8).ReadOnly = True
        DataGridView1.Columns(9).ReadOnly = False

        DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(4).DefaultCellStyle.BackColor = Color.White
        DataGridView1.Columns(5).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(7).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(8).DefaultCellStyle.BackColor = Color.WhiteSmoke

        With DataGridView1
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub
    Private Sub cbo_supplier_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim NewDisplayAcc As New frm_display_supp
        NewDisplayAcc.formsource_ro_po = True
        NewDisplayAcc.Show()
        '  NewDisplayAcc.MdiParent = MainMenu
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

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        insert_data()
    End Sub

    'fungsi simpan
    Private Sub insert_data()

        open_conn()
        Dim i As Integer
        Dim a As Integer
        Dim b As Integer
        'For a = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Item(9, a).Value = True Then
        '        b = b + 1
        '    End If
        'Next
        'If b > 0 Then
        If insert = 1 Then
            Call insert_po(Trim(txt_po_no.Text), Lookup_Pelanggan.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                           Trim(txt_comment.Text), txt_subtotal.Text, txt_freight.Text, Replace(txt_tax.Text, "%", ""), txt_amount.Text, _
                           "", server_datetime(), server_datetime(), (username), 0, "", "", 0, "", 0, 0, "", 0, 0, "", Replace(txt_kurs.Text, ",", ""), Replace(txtum.Text, ",", ""), txt_account_um.EditValue)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Or DataGridView1.Item(1, i).Value <> Nothing Then
                    Call insert_po(Trim(txt_po_no.Text), "", Format(txt_date.Value, "yyyy-MM-dd"), _
                          "", 0, 0, 0, 0, _
                           "", Format(server_datetime, "yyyy-MM-dd"), Format(server_datetime, "yyyy-MM-dd"), username, DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, _
                           DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, cbo_curr.Text, 1, 0, DataGridView1.Item(8, i).Value, Replace(txt_kurs.Text, ",", ""), Replace(txtum.Text, ",", ""), txt_account_um.EditValue)
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "PO")
                pesan = MsgBox("Cetak PO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormNotaPO
                    NoBuktiPO = Trim(txt_po_no.Text)
                    With DisplayNota
                        .Show()
                        '  .MdiParent = MainMenu
                        .WindowState = FormWindowState.Maximized
                    End With
                End If

                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            If select_validate("Purchase Order", Trim(txt_po_no.Text)) > 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "PO telah di proses pada faktur beli")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
            Call update_po(Trim(txt_po_no.Text), Lookup_Pelanggan.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                           Trim(txt_comment.Text), txt_subtotal.Text, txt_freight.Text, Replace(txt_tax.Text, "%", ""), txt_amount.Text, _
                           "", server_datetime(), server_datetime(), (username), 0, "", "", 0, "", 0, 0, "", 0, 0, "", Replace(txt_kurs.Text, ",", ""), Replace(txtum.Text, ",", ""), txt_account_um.EditValue)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Or DataGridView1.Item(1, i).Value <> Nothing Then
                    Call update_po(Trim(txt_po_no.Text), "", Format(txt_date.Value, "yyyy-MM-dd"), _
                          "", 0, 0, 0, 0, _
                           "", Format(server_datetime, "yyyy-MM-dd"), Format(server_datetime, "yyyy-MM-dd"), username, DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, _
                           DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, cbo_curr.Text, 1, 0, DataGridView1.Item(8, i).Value, Replace(txt_kurs.Text, ",", ""), Replace(txtum.Text, ",", ""), txt_account_um.EditValue)
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                pesan = MsgBox("Cetak PO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormNotaPO
                    NoBuktiPO = Trim(txt_po_no.Text)
                    With DisplayNota
                        .Show()
                        '  .MdiParent = MainMenu
                        .WindowState = FormWindowState.Maximized
                    End With
                End If
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
        'Else
        'MsgBox("Tidak ada data RO yang dipilih", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        'Exit Sub
        'End If

    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        With Me
            .txt_supp_nm.Text = ""
            .txt_supp_address.Text = ""
            .txt_subtotal.Text = ""
            .txt_freight.Text = 0
            .txt_comment.Text = ""
            .txt_amount.Text = 0
            .txt_tax.Text = 0
            .txt_date.Value = Now
            '  .cbo_supplier.Text = ""
        End With
        Call select_control_no("PO", "TRANS")
        txt_po_no.Text = no_master
        txt_date.Value = Now
        init_number()
        cbo_curr.Text = get_def_curr()
        btn_del2.Enabled = True
        btn_cetak.Enabled = True
        ' view_data_ro(cbo_supplier2.Text)
        cbo_supplier2.Text = ""
        chk_ppn.Checked = False
        txt_kurs.Text = 1
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(200)
        Lookup_Pelanggan.EditValue = Nothing
        btn_cetak.Enabled = False
        btn_del2.Enabled = False
        txtum.Text = 0
        txt_amount.Text = 0
        txt_subtotal.Text = 0
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
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        i = DataGridView1.CurrentCell.ColumnIndex
        If i = 1 Or i = 2 Then
            'Dim NewDisplayAcc As New frm_display_item
            'NewDisplayAcc.formsource_po_item = True
            'NewDisplayAcc.Show()
            'NewDisplayAcc.MdiParent = MainMenu
        End If
        If i = 5 Then
            'Dim NewDisplayAcc As New frm_display_unit
            'NewDisplayAcc.formsource_po_unit = True
            'NewDisplayAcc.Show()
            'NewDisplayAcc.MdiParent = MainMenu
            'Dim dgvcc As DataGridViewComboBoxCell
            'dgvcc = DataGridView1.Rows(mRow).Cells(5)
            'dgvcc.Items.Clear()
            'Rows = select_unit.Rows.Count - 1
            'For i = 0 To Rows
            '    dgvcc.Items.Add(select_unit.Rows(i).Item(0))
            'Next


        End If
    End Sub

    Dim TSubTotal As Double
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim columnIndex As Integer
        TSubTotal = 0
        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        If columnIndex = 6 Or columnIndex = 4 Then
            If Not IsNumeric(DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value) Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan Nominal Angka")
                alertControl_warning.Show(Me, info)
                DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = 0
                Exit Sub
            End If
            DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value * DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value
            DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value, 0)

            Dim i As Integer
            For i = 0 To DataGridView1.Rows.Count - 1
                'If columnIndex = 6 Then
                TSubTotal = TSubTotal + DataGridView1.Item(7, i).Value
                'End If
            Next
            txt_subtotal.Text = FormatNumber(TSubTotal, 0)


            If chk_ppn.Checked = True Then
                Dim DT As DataTable
                DT = get_tax_rate("PPN")
                txt_tax.Text = DT.Rows(0).Item(0)
                txt_tax_nominal.Text = FormatNumber((DT.Rows(0).Item(0) / 100) * (CDbl(Replace(txt_subtotal.Text, ",", ""))), 0)
            ElseIf chk_ppn.Checked = False Then
                txt_tax.Text = 0
                txt_tax_nominal.Text = 0
            End If

            hitung_nominal()
        End If

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
        Ttotal = (TSubTotal) + ((TSubTotal) * (CDbl(Replace(txt_tax.Text, "%", "")) / 100)) + CDbl(Replace(txt_freight.Text, ",", ""))

        'menghitung total
        txt_amount.Text = FormatNumber(Ttotal, 0)

        'menghitung change
        'Tchange = (CDbl(txt_paid.Text)) - Ttotal
        'txt_change.Text = FormatNumber(Tchange, 0)
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex


        If DataGridView1.Item(8, mRow).Value = "" Then
            DataGridView1.Rows(mRow).Cells(4).ReadOnly = False
        Else
            DataGridView1.Rows(mRow).Cells(4).ReadOnly = True
        End If

        If mCol = 5 And DataGridView1.Item(1, mRow).Value <> "" And DataGridView1.Item(8, mRow).Value = "" Then

            Dim DT As DataTable
            DT = select_combo_unit_item(DataGridView1.Item(1, mRow).Value)
            cbo_unit2.Properties.DataSource = DT
            cbo_unit2.Properties.DisplayMember = "unit"
            cbo_unit2.Properties.ValueMember = "id_unit"
            cbo_unit2.Properties.PopulateViewColumns()
            cbo_unit2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            cbo_unit2.Properties.View.OptionsView.ShowAutoFilterRow = True
            cbo_unit2.Properties.View.Columns("id_unit").Caption = "Kode"
            cbo_unit2.Properties.View.Columns("unit").Caption = "Unit"

            cbo_unit2.Visible = True
            cbo_unit2.Left = DataGridView1.GetCellDisplayRectangle(mCol, mRow, True).Left + 1
            cbo_unit2.Top = DataGridView1.GetCellDisplayRectangle(mCol, mRow, True).Bottom - 1

        Else
            cbo_unit2.Visible = False
        End If

        'i = DataGridView1.CurrentCell.ColumnIndex
        'If i = 1 Or i = 2 Then
        '    Dim NewDisplayAcc As New frm_display_acc_detail
        '    NewDisplayAcc.formsource_journal_noacc = True
        '    NewDisplayAcc.Show()
        'End If
        'DataGridView1.Item(0, mRow).Value = mRow + 1
    End Sub


    Private Sub txt_tax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        txt_tax.SelectionStart = 0
        txt_tax.SelectionLength = Len(txt_tax.Text)
    End Sub

    Private Sub txt_tax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        If txt_tax.Text = "" Then
            txt_tax.Text = FormatPercent(0, 0)
        Else
            txt_tax.Text = FormatPercent(CDbl(Replace(txt_tax.Text, "%", "")) / 100, 0)
        End If
        hitung_nominal()
    End Sub

    Private Sub txt_freight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_freight.LostFocus
        open_conn()
        TSubTotal = 0
        If txt_freight.Text = "" Then
            txt_freight.Text = FormatNumber(0, 0)
        Else
            txt_freight.Text = FormatNumber(CDbl(Replace(txt_freight.Text, ",", "")), 0)
        End If
        Dim rows As Integer
        rows = DataGridView1.Rows.Count - 1
        Dim i As Integer
        For i = 0 To rows
            'Dim checkbox_cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(i).Cells(9), DataGridViewCheckBoxCell)
            'If checkbox_cell.EditedFormattedValue = True Then
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
            ' End If
        Next
        hitung_nominal()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        view_data()
        'Dim Total_Width_Column, Total_Width_Column2 As Integer
        'Dim Width_Table, Width_Table2 As Integer
        'Dim selisih_col, selisih_col2 As Integer

        'With DataGridView1
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(9).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(3).Width = .Columns(3).Width + selisih_col
        'End With
        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(7).Width = .Columns(7).Width + selisih_col2
        'End With
    End Sub

    Private Sub view_data()
        open_conn()
        '   If TabControl1.SelectedTabPage Is TabList Then
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
            DT = select_purchase_order(Trim(cbo_search.Text), Trim(txt_search.Text), 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
            GridControl.DataSource = DT
            GridList_Customer.Columns("no_purchase_order").Caption = "No PO"
            GridList_Customer.Columns("no_purchase_order").Width = 170
            GridList_Customer.Columns("nama").Caption = "Supplier"
            GridList_Customer.Columns("nama").Width = 200
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 110
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("subtotal").Caption = "Sub Total"
            GridList_Customer.Columns("subtotal").Width = 170
            GridList_Customer.Columns("subtotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("subtotal").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("freight").Caption = "B.Angkut"
            GridList_Customer.Columns("freight").Width = 160
            GridList_Customer.Columns("freight").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("freight").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("tax").Caption = "PPN"
            GridList_Customer.Columns("tax").Width = 160
            GridList_Customer.Columns("tax").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("tax").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("total").Caption = "Total"
            GridList_Customer.Columns("total").Width = 170
            GridList_Customer.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("total").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("id_supplier").Visible = False
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 300
            '    GridList_Customer.BestFitColumns()


            'Rows = DT.Rows.Count - 1
            'DataGridView2.Rows.Clear()
            'Dim i As Integer
            'If DT.Rows.Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            '        DataGridView2.Item(2, i).Value = Format(DT.Rows(i).Item(2), "yyyy-MM-dd")
            '        DataGridView2.Item(3, i).Value = FormatNumber(DT.Rows(i).Item(3), 0)
            '        DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item(4), 0)
            '        DataGridView2.Item(5, i).Value = FormatNumber(DT.Rows(i).Item(5), 0)
            '        DataGridView2.Item(6, i).Value = FormatNumber(DT.Rows(i).Item(6), 0)
            '        DataGridView2.Item(7, i).Value = DT.Rows(i).Item(7)

            '    Next
            'End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Private Sub view_data_ro(ByVal Criteria As String)
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable
        Dim date_filter As Integer
        date_filter = 0
        DT = select_ro_po("No Permintaan", Criteria, 0, date_filter, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"))
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        Dim i As Integer
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item(0)
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item(1)
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item(2)
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item(3), 0)
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item(4)
                DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item(5), 0)
                DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item(6), 0)
                DataGridView1.Item(8, i).Value = DT.Rows(i).Item(7)
            Next
        End If
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        'current_row = cbo_acc_group.SelectedIndex
        Dim DT As DataTable
        Dim rows As Integer
        Dim date_filter As Integer
        insert = 0
        edit = 1

        If getTemplateAkses(username, "MN_PO_EDIT_UM") = True Then
            SimpleButton1.Visible = True
        Else
            SimpleButton1.Visible = False
        End If


        If chk_date.Checked = True Then
            date_filter = 1
        ElseIf chk_date.Checked = False Then
            date_filter = 0
        End If
        DT = select_purchase_order("no_purchase_order", criteria, 1, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))

        rows = DT.Rows.Count - 1
        If DT.Rows.Count > 0 Then
            ' cbo_supplier.Text = DT.Rows(0).Item("id_supplier")
            ' cbo_supplier2.Text = ""
            ' cbo_supplier2.SelectedText = DT.Rows(0).Item("id_supplier")
            Lookup_Pelanggan.EditValue = DT.Rows(0).Item("id_supplier")
            txt_supp_nm.Text = DT.Rows(0).Item("nama")
            txt_supp_address.Text = DT.Rows(0).Item("address")
            txt_po_no.Text = DT.Rows(0).Item("no_purchase_order")
            txt_date.Value = DT.Rows(0).Item("date_trn")
            cbo_curr.Text = DT.Rows(0).Item("id_curr")
            txt_comment.Text = DT.Rows(0).Item("notes")
            txt_subtotal.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
            txt_tax_nominal.Text = (DT.Rows(0).Item("tax") / 100 * (DT.Rows(0).Item("subtotal") + DT.Rows(0).Item("freight")))
            btn_del2.Enabled = True
            btn_cetak.Enabled = True
            DataGridView1.Rows.Clear()
            Dim i As Integer
            For i = 0 To rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("description")
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("qty"), 0)
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
                'dgvcc.Value = DT.Rows(i).Item("id_unit")
                DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
                DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)
                DataGridView1.Item(8, i).Value = DT.Rows(i).Item("no_request_order")
                DataGridView1.Item(9, i).Value = True
            Next
            txt_freight.Text = FormatNumber(DT.Rows(0).Item("freight"), 0)
            If DT.Rows(0).Item("tax") > 0 Then
                chk_ppn.Checked = True
            Else
                chk_ppn.Checked = False
            End If
            txt_amount.Text = FormatNumber(DT.Rows(0).Item("total_head"), 0)
            txtum.Text = FormatNumber(DT.Rows(0).Item("um"), 0)
        End If
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        Dim jml_po As Integer
        Dim a As Integer
        a = DataGridView2.CurrentCell.RowIndex
        jml_po = select_validate("PO REC", DataGridView2.Item(0, a).Value)
        If jml_po > 0 Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Barang di PO Sudah diterima")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        edit = 1
        insert = 0
        btn_del2.Enabled = True
        btn_cetak.Enabled = True
        a = DataGridView2.CurrentCell.RowIndex
        detail(DataGridView2.Item(0, a).Value)
        TabControl1.SelectedTabPage = TabInput
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_PO_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If select_validate("Purchase Order", Trim(txt_po_no.Text)) > 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "PO telah di proses di faktur pembelian")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_po(Trim(txt_po_no.Text), Lookup_Pelanggan.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                               Trim(txt_comment.Text), txt_subtotal.Text, txt_freight.Text, Replace(txt_tax.Text, "%", ""), txt_amount.Text, _
                               "", server_datetime(), server_datetime(), (username), 0, "", "", 0, "", 0, 0, "", 0, 0, "", txt_account_um.EditValue)
                If param_sukses = True Then
                    Dim info As AlertInfo = New AlertInfo(msgtitle_delete_success, msgbox_delete_success)
                    alertControl_success.Show(Me, info)
                    clean()
                End If
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_delete_failed, msgbox_delete_failed)
                alertControl_error.Show(Me, info)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("PO", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("PO", "TRANS")
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
        cbo_search.Text = "PO No"
        txt_search.Text = ""
    End Sub
    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        open_conn()
        Dim rows As Integer
        Dim columnIndex, rowIndex As Integer
        Dim i As Integer
        rows = DataGridView1.Rows.Count - 1

        TSubTotal = 0

        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        rowIndex = DataGridView1.CurrentCell.RowIndex
        If columnIndex = 9 Then

            For i = 0 To rows
                Dim checkbox_cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(i).Cells(9), DataGridViewCheckBoxCell)
                If checkbox_cell.EditedFormattedValue = True Then
                    TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
                End If
            Next
            txt_subtotal.Text = FormatNumber(TSubTotal, 0)

            hitung_nominal()
        End If
    End Sub

    Private Sub btn_save2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_PO_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If Trim(txtum.Text) = "" Or IsNumeric(txtum.Text) = False Then
            txtum.Text = 0
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_PO_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        If trial = True Then
            If get_count_data("trn_purchase_order_head", "no_purchase_order") > row_trial Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Batas untuk input versi trial telah habis, silahkan membeli produk ini")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        insert_data()

    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        Dim DisplayNota As New FormNotaPO
        NoBuktiPO = Trim(txt_po_no.Text)
        With DisplayNota
            .Show()
            '  .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        open_conn()
        Dim colIndex As Integer
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        If colIndex = 8 Then
            Dim DisplayNota As New FormNotaPO
            NoBuktiPO = Trim(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
        End If
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


    Private Sub chk_ppn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ppn.CheckedChanged
        open_conn()
        Dim i As Integer
        TSubTotal = 0
        If chk_ppn.Checked = True Then
            Dim DT As DataTable
            DT = get_tax_rate("PPN")
            txt_tax.Text = DT.Rows(0).Item(0)
            txt_tax_nominal.Text = FormatNumber((DT.Rows(0).Item(0) / 100) * (CDbl(Replace(txt_subtotal.Text, ",", ""))), 0)
        ElseIf chk_ppn.Checked = False Then
            txt_tax.Text = 0
            txt_tax_nominal.Text = 0
        End If

        For i = 0 To DataGridView1.Rows.Count - 1
            ' Dim checkbox_cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(i).Cells(9), DataGridViewCheckBoxCell)
            'If checkbox_cell.EditedFormattedValue = True Then
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
            'End If
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        hitung_nominal()

    End Sub

    Private Sub cbo_supplier2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_supplier2.Click
        open_conn()
        cbo_supplier2.DroppedDown = True
    End Sub

    Private Sub cbo_supplier2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_supplier2.LostFocus
        open_conn()
        cbo_supplier2.DroppedDown = False
    End Sub

    Private Sub cbo_supplier2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_supplier2.SelectedIndexChanged
        open_conn()
        txt_supp_address.Text = cbo_supplier2.SelectedItem.Col3
        txt_supp_nm.Text = cbo_supplier2.SelectedItem.Col2
        'If insert = 1 Then
        '    view_data_ro(cbo_supplier2.Text)
        'End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    'Private Sub frmpo_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(9).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(3).Width = .Columns(3).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(7).Width = .Columns(7).Width + selisih_col2
    '    End With
    'End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txt_subtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_subtotal.TextChanged

    End Sub

    Private Sub txt_tax_nominal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_tax_nominal.TextChanged

    End Sub

    Private Sub txt_freight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_freight.TextChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub txt_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amount.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub btn_chk_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Item(9, i).Value = True
        Next
        hitung_check()
    End Sub

    Private Sub hitung_check()
        open_conn()
        Dim rows As Integer
        Dim columnIndex, rowIndex As Integer
        Dim i As Integer
        rows = DataGridView1.Rows.Count - 1

        TSubTotal = 0

        For i = 0 To rows
            Dim checkbox_cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(i).Cells(9), DataGridViewCheckBoxCell)
            If checkbox_cell.EditedFormattedValue = True Then
                TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
            End If
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)

        hitung_nominal()

    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Item(9, i).Value = False
        Next
        hitung_check()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        'open_conn()
        'mRow = DataGridView1.CurrentCell.RowIndex
        'mCol = DataGridView1.CurrentCell.ColumnIndex
        'Dim Rows As Integer
        'i = DataGridView1.CurrentCell.ColumnIndex
        'If i = 1 Or i = 2 Then

        'End If
    End Sub

    Private Sub cbo_curr_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_curr.SelectedIndexChanged
        txt_kurs.Text = FormatNumber(get_def_convertcurr(Trim(cbo_curr.Text)), 0)
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        IndexRowDg = DataGridView1.CurrentCell.RowIndex
        If e.KeyCode = Keys.Delete Then
            pesan = MessageBox.Show("Data ingin di hapus?", "Konfirmasi", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                DataGridView1.Rows.RemoveAt(IndexRowDg)
                Dim i As Integer
                For i = 0 To DataGridView1.Rows.Count - 1
                    'If columnIndex = 6 Then
                    TSubTotal = TSubTotal + DataGridView1.Item(7, i).Value
                    'End If
                Next
                txt_subtotal.Text = FormatNumber(TSubTotal, 0)


                If chk_ppn.Checked = True Then
                    Dim DT As DataTable
                    DT = get_tax_rate("PPN")
                    txt_tax.Text = DT.Rows(0).Item(0)
                    txt_tax_nominal.Text = FormatNumber((DT.Rows(0).Item(0) / 100) * (CDbl(Replace(txt_subtotal.Text, ",", ""))), 0)
                ElseIf chk_ppn.Checked = False Then
                    txt_tax.Text = 0
                    txt_tax_nominal.Text = 0
                End If

                hitung_nominal()
            End If

        End If
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_purchase_order"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_purchase_order"))
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
    End Sub

    Private Sub Lookup_Pelanggan_EditValueChanged(sender As Object, e As System.EventArgs) Handles Lookup_Pelanggan.EditValueChanged
        If Lookup_Pelanggan.EditValue <> Nothing Then
            Dim rowSupplier As DataRowView
            rowSupplier = TryCast(Lookup_Pelanggan.Properties.GetRowByKeyValue(Lookup_Pelanggan.EditValue), DataRowView)
            txt_supp_nm.Text = rowSupplier.Item("name").ToString
            txt_supp_address.Text = rowSupplier.Item("address").ToString
        End If
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

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Panel1.Visible = True
        txt_totalcsh.Text = FormatNumber(txt_amount.Text, 0)
        txt_bayarum.Text = FormatNumber(txtum.Text, 0)
        txt_sisa_tagihan.Text = FormatNumber(CDbl(txt_totalcsh.Text) - CDbl(txt_bayarum.Text), 0)
        SimpleButton1.Visible = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Panel1.Visible = False
        SimpleButton1.Visible = True
    End Sub

    Private Sub txt_bayarum_LostFocus(sender As Object, e As System.EventArgs) Handles txt_bayarum.LostFocus
        txt_sisa_tagihan.Text = FormatNumber(CDbl(txt_totalcsh.Text) - CDbl(txt_bayarum.Text))
    End Sub

    Private Sub txt_bayarum_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_bayarum.TextChanged

    End Sub

    Private Sub Panel1_Paint_1(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub




    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = False
        SimpleButton1.Visible = True
    End Sub

    Private Sub PanelControl3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelControl3.Paint

    End Sub

    Private Sub cbo_unit2_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_unit2.EditValueChanged
        If cbo_unit2.EditValue <> Nothing Then
            DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = cbo_unit2.EditValue
            cbo_unit2.Visible = False
        End If
    End Sub

    Private Sub cbo_unit2_LostFocus(sender As Object, e As System.EventArgs) Handles cbo_unit2.LostFocus

    End Sub
End Class