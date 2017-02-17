Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmpurchase_langsung

    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Dim TSubTotal As Double
    Dim clean_cek_po As Integer
    Public NoBuktiFaktur As String
    Dim var_id_supplier As String
    Dim var_no_po As String
    Dim var_nm_supplier As String
    Dim var_add_supplier As String

    Private Sub datagrid_layout()
        open_conn()
        Dim i As Integer
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        For i = 0 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(i).DefaultCellStyle.BackColor = Color.WhiteSmoke
        Next
        With DataGridView1
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .Rows.Clear()
            .Rows.Add(250)
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = True
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(3).ReadOnly = False
            .Columns(3).DefaultCellStyle.BackColor = Color.White
            .Columns(4).ReadOnly = False
            .Columns(4).DefaultCellStyle.BackColor = Color.White
            .Columns(5).ReadOnly = True
            .Columns(5).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(6).ReadOnly = True
            .Columns(6).DefaultCellStyle.BackColor = Color.White
            .Columns(7).ReadOnly = False
            .Columns(7).DefaultCellStyle.BackColor = Color.White
            .Columns(8).ReadOnly = True
            .Columns(8).DefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
    End Sub

    Private Sub frmpurchase_langsung_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmpurchase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub fillComboBox()
        Dim DTItem As DataTable
        DTItem = getComboSupplierCompleteField()
        cbo_po.Properties.DataSource = DTItem
        cbo_po.Properties.DisplayMember = "Kode"
        cbo_po.Properties.ValueMember = "Kode"
        cbo_po.Properties.PopulateViewColumns()
        cbo_po.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_po.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Dim i As Integer
        'TODO: This line of code loads data into the 'DataNotif.List_PO_Purch' table. You can move, or remove it, as needed.
        'Me.List_PO_Purch.Fill(Me.DataNotif.List_PO_Purch)
        'TODO: This line of code loads data into the 'DataNotif.List_PO' table. You can move, or remove it, as needed.
        'Me.List_PO.Fill(Me.DataNotif.List_PO)
        Me.MdiParent = MainMenu
        Me.WindowState = FormWindowState.Maximized
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("PURCHASE_DIRECT", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("PURCHASE_DIRECT", "TRANS")
        cbo_search.Text = "Invoice No"
        txt_inv_no.Text = no_master
        txt_curr.Text = get_def_curr()
        'DataGridView1.Item(0, 0).Value = 1
        DataGridView1.Focus()
        btn_del2.Enabled = False
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Button1.Visible = False
        txt_subtotal.Enabled = False
        txt_amount.Enabled = False
        Call init_number()
        'isi combo payment method
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_pay_method()
        Rows = DT.Rows.Count - 1
        For i = 0 To Rows
            cbo_paymethod.Items.Add(DT.Rows(i).Item(1))
        Next
        txt_curr.Items.Clear()
        Rows = select_curr.Rows.Count - 1
        For i = 0 To Rows
            txt_curr.Items.Add(select_curr.Rows(i).Item(0))
        Next
        txt_curr.Text = get_def_curr()

        view_data()
        'isi combo search
        '  cbo_search.Items.Add("Invoice No")

        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        btn_cetak.Enabled = False
        chk_po.Checked = True
        txt_payterm.Enabled = True
        txt_disc_pay.Enabled = True
        txt_discterm.Enabled = True
        ' LoadComboBox_MtgcComboBoxPO()
        fillComboBox()
        LoadComboBox_MtgcComboBoxAkun()
        '  lbl_nm_akun.Visible = False
        cbo_paymethod.Text = "Credit"
        cbo_akun.Enabled = False
        txt_tax_nominal.Text = 0
        cbo_akun.BackColor = Color.Wheat
        lbl_kurs.Text = get_def_curr()
        txt_kurs.Text = 1
        DataGridView1.Rows.Add(250)
    End Sub

    'Private Sub LoadComboBox_MtgcComboBoxPO()
    '    open_conn()
    '    Dim dtLoading As New DataTable("UsStates")
    '    dtLoading = getComboSupplierCompleteField()

    '    cbo_po.SelectedIndex = -1
    '    cbo_po.Items.Clear()
    '    cbo_po.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
    '    cbo_po.SourceDataString = New String(2) {"id_supplier", "nama", "address"}
    '    cbo_po.DataSource = dtLoading
    '    cbo_po.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    'End Sub

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

    Private Sub init_number()
        open_conn()
        txt_payterm.Text = 0
        txt_discterm.Text = 0
        txt_disc_pay.Text = FormatPercent(0, 0)
        txt_disc.Text = FormatPercent(0, 0)
        txt_subtotal.Text = 0
        txt_freight.Text = 0
        txt_tax.Text = 0
        txt_amount.Text = FormatPercent(0, 0)
        lbl_kurs.Text = get_def_curr()
        txt_kurs.Text = 1
    End Sub
    Private Sub clean()
        open_conn()
        With Me
            .cbo_po_no.Text = ""
            .cbo_po.EditValue = Nothing
            .txt_supp_nm.Text = ""
            .txt_supp_address.Text = ""
            .txt_inv_no.Text = ""
            .DataGridView1.Rows.Clear()
            .txt_comment.Text = ""
            .txt_netto.Text = ""
            .txt_date.Value = Now
            .cbo_paymethod.Text = ""
            '.chk_po.Checked = False
            ' .lbl_nm_akun.Visible = False
            .txt_tax_nominal.Text = 0
            '.cbo_akun.Text = ""
            .cbo_paymethod.Text = "Credit"
            .cbo_akun.Enabled = False
            .cbo_po.Enabled = True
        End With
        init_number()
        Call select_control_no("PURCHASE_DIRECT", "TRANS")
        txt_inv_no.Text = no_master
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        txt_curr.Text = get_def_curr()
        insert = 1
        edit = 0
        chk_ppn.Checked = False
        LoadComboBox_MtgcComboBoxAkun()
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        open_conn()
        clean()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        i = DataGridView1.CurrentCell.ColumnIndex
        'If i = 1 Or i = 2 Then
        '    Dim NewDisplayAcc As New frm_display_item
        '    NewDisplayAcc.formsource_purchase_item = True
        '    NewDisplayAcc.Show()
        '    NewDisplayAcc.MdiParent = MainMenu
        '    Me.Enabled = False
        'End If
        'If i = 5 Then
        '    Dim NewDisplayAcc As New frm_display_unit
        '    NewDisplayAcc.formsource_purchase_unit = True
        '    NewDisplayAcc.Show()
        '    NewDisplayAcc.MdiParent = MainMenu
        '    Me.Enabled = False
        'End If

    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim rows As Integer
        Dim columnIndex As Integer
        TSubTotal = 0
        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        If columnIndex = 7 Then
            DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, 0)
        End If
        If columnIndex = 4 Or columnIndex = 7 Then
            If IsNumeric(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value) = False Then
                DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = 0
            End If
            If IsNumeric(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value) = False Then
                DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
            End If
            DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value * DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, 0)
        End If
        If columnIndex = 4 Then
            DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, 0)
        End If
        'If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
        '    DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = ""
        '    DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
        '    DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = 0
        '    DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = ""
        '    DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = 0
        '    DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value = 0
        '    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item Masih Kosong")
        '    alertControl_warning.Show(Me, info)
        '    Exit Sub
        'End If
        rows = DataGridView1.Rows.Count - 1
        Dim i As Integer
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(8, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        hitung_nominal()
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
        TNett = CDbl(Replace(txt_subtotal.Text, ",", "")) - ((CDbl(Replace(txt_subtotal.Text, ",", ""))) * CDbl(Replace(txt_disc.Text, "%", "")) / 100)
        txt_netto.Text = FormatNumber(TNett, 0)
        Ttotal = TNett + (TNett * (CDbl(Replace(txt_tax.Text, "%", "")) / 100)) + CDbl(Replace(txt_freight.Text, ",", ""))

        'menghitung total
        txt_amount.Text = FormatNumber(Ttotal, 0)

    End Sub

    Private Sub txt_freight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_freight.LostFocus
        open_conn()

        TSubTotal = 0
        If txt_disc.Text = "" Then
            txt_disc.Text = FormatPercent(0, 0)
        Else
            txt_disc.Text = FormatPercent(CDbl(Replace(txt_disc.Text, "%", "")) / 100, 0)
        End If

        Dim diskon As Double
        Dim rows As Integer
        diskon = CDbl(Replace(txt_disc.Text, "%", "")) / 100 * (CDbl(Replace(txt_subtotal.Text, ",", "")))
        If chk_ppn.Checked = True Then
            Dim DT As DataTable
            DT = get_tax_rate("PPN")
            txt_tax.Text = DT.Rows(0).Item(0)
            txt_tax_nominal.Text = FormatNumber((DT.Rows(0).Item(0) / 100) * (CDbl(Replace(txt_subtotal.Text, ",", "")) - diskon), 0)
        ElseIf chk_ppn.Checked = False Then
            txt_tax.Text = 0
            txt_tax_nominal.Text = 0
        End If

        rows = DataGridView1.Rows.Count - 1
        Dim i As Integer
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(8, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)

        If txt_freight.Text = "" Then
            txt_freight.Text = FormatNumber(0, 0)
        Else
            txt_freight.Text = FormatNumber(CDbl(Replace(txt_freight.Text, ",", "")), 0)
        End If
        hitung_nominal()
    End Sub

    Private Sub txt_disc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_disc.GotFocus
        open_conn()
        txt_disc.SelectionLength = Len(txt_disc.Text)
    End Sub

    Private Sub txt_disc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_disc.LostFocus
        open_conn()
        TSubTotal = 0
        If txt_disc.Text = "" Then
            txt_disc.Text = FormatPercent(0, 0)
        Else
            txt_disc.Text = FormatPercent(CDbl(Replace(txt_disc.Text, "%", "")) / 100, 0)
        End If

        Dim diskon As Double
        Dim rows As Integer
        diskon = CDbl(Replace(txt_disc.Text, "%", "")) / 100 * (CDbl(Replace(txt_subtotal.Text, ",", "")))
        If chk_ppn.Checked = True Then
            Dim DT As DataTable
            DT = get_tax_rate("PPN")
            txt_tax.Text = DT.Rows(0).Item(0)
            txt_tax_nominal.Text = FormatNumber((DT.Rows(0).Item(0) / 100) * (CDbl(Replace(txt_subtotal.Text, ",", "")) - diskon), 0)
        ElseIf chk_ppn.Checked = False Then
            txt_tax.Text = 0
            txt_tax_nominal.Text = 0
        End If

        rows = DataGridView1.Rows.Count - 1
        Dim i As Integer
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(8, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)

        hitung_nominal()
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

    Private Sub btn_save2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_PURCHASE_DIRECT_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_PURCHASE_DIRECT_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If cbo_paymethod.Text = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan pilih metode pembayaran")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If txt_curr.Text = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan pilih mata uang")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If cbo_paymethod.Text = "Cash" And cbo_akun.Text = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan pilih akun kas/bank")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        Dim rows As Integer
        Dim a, b As Integer
        rows = DataGridView1.Rows.Count - 1
        For a = 0 To rows
            If DataGridView1.Item(4, a).Value <> DataGridView1.Item(5, a).Value Then
                b = b + 1
            End If
        Next
        If b > 0 Then
            pesan = MsgBox("Belum ada penerimaan barang untuk item dari order tsb" & vbCrLf & "Ingin Lanjut?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If pesan = vbYes Then
                insert_data()
            Else
                Exit Sub
            End If
            Exit Sub
        Else
            insert_data()
        End If

    End Sub

    'fungsi simpan
    Private Sub insert_data()
        open_conn()
        Dim i As Integer
        Dim var_po As Integer
        Dim var_pay_method As Integer

        If chk_po.Checked = True Then
            var_po = 1
        Else
            var_po = 0
        End If

        If cbo_paymethod.Text = "Cash" Then
            var_pay_method = 1
        Else
            var_pay_method = 2
        End If

        If insert = 1 Then
            'Call delete_i_cogs()
            Call insert_purchase_langsung(Trim(txt_inv_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), "", _
                            var_id_supplier, var_pay_method, txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), _
                            txt_subtotal.Text, txt_freight.Text, Replace(txt_tax.Text, "%", ""), txt_amount.Text, Trim(txt_comment.Text), _
                            username, Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), _
                            0, "", "", 0, "", 0, 0, Trim(txt_curr.Text), 0, 0, "INSERT", 0, var_po, Replace(txt_disc.Text, "%", ""), cbo_akun.Text, "", Replace(txt_kurs.Text, ",", ""))
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> Nothing And Trim(DataGridView1.Item(1, i).Value) <> "" Then
                    Call insert_purchase_langsung(Trim(txt_inv_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), "", "", 0, 0, 0, 0, 0, _
                                                        0, 0, 0, "", "", Format(server_datetime(), "yyyy-MM-dd"), "", Format(server_datetime(), "yyyy-MM-dd"), _
                                                        DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, _
                                                        DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, DataGridView1.Item(8, i).Value, _
                                                        txt_curr.Text, 1, i, "INSERT", 0, var_po, Replace(txt_disc.Text, "%", ""), cbo_akun.Text, DataGridView1.Item(2, i).Value, Replace(txt_kurs.Text, ",", ""))
                End If
                'Call calculate_cogs(txt_date.Value, DataGridView1.Item(1, i).Value)
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "Purchase")
                'pesan = MsgBox("Cetak Faktur?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                'If pesan = vbYes Then
                '    Dim DisplayNota As New FormFakturBeli
                '    NoBuktiFaktur = Trim(txt_inv_no.Text)
                '    With DisplayNota
                '        .Show()
                '        '  .MdiParent = MainMenu
                '        .WindowState = FormWindowState.Maximized
                '    End With
                'End If
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            If select_validate("Purchase", Trim(txt_inv_no.Text)) > 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Faktur sudah lunas")
                alertControl_error.Show(Me, info)
                Exit Sub
            End If
            ' Call delete_i_cogs()

            Call update_purchase_langsung(Trim(txt_inv_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), "", _
                            var_id_supplier, var_pay_method, txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), _
                            txt_subtotal.Text, txt_freight.Text, Replace(txt_tax.Text, "%", ""), txt_amount.Text, Trim(txt_comment.Text), _
                            username, Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), _
                            0, "", "", 0, "", 0, 0, Trim(txt_curr.Text), 0, 0, "UPDATE", 0, var_po, Replace(txt_disc.Text, "%", ""), cbo_akun.Text, "", Replace(txt_kurs.Text, ",", ""))
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> Nothing And Trim(DataGridView1.Item(1, i).Value) <> "" Then
                    Call update_purchase_langsung(Trim(txt_inv_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), "", "", 0, 0, 0, 0, 0, _
                                                        0, 0, 0, "", "", Format(server_datetime(), "yyyy-MM-dd"), "", Format(server_datetime(), "yyyy-MM-dd"), _
                                                        DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, _
                                                        DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, DataGridView1.Item(8, i).Value, _
                                                        txt_curr.Text, 1, i, "UPDATE", 0, var_po, Replace(txt_disc.Text, "%", ""), cbo_akun.Text, DataGridView1.Item(2, i).Value, Replace(txt_kurs.Text, ",", ""))
                End If
                'Call calculate_cogs(txt_date.Value, DataGridView1.Item(1, i).Value)
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                'update_no_trans(txt_date.Value, "PO")
                'pesan = MsgBox("Cetak Faktur?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                'If pesan = vbYes Then
                '    Dim DisplayNota As New FormFakturBeli
                '    NoBuktiFaktur = Trim(txt_inv_no.Text)
                '    With DisplayNota
                '        .Show()
                '        '  .MdiParent = MainMenu
                '        .WindowState = FormWindowState.Maximized
                '    End With
                'End If
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex

        DataGridView1.Item(0, mRow).Value = mRow + 1
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        generate(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_purchase"))
    End Sub

    Private Sub list_data()
        open_conn()
        Dim i As Integer
        On Error Resume Next
        'If TabControl1.SelectedTab Is TabList Then
        Dim var_date_filter As Integer
        If chk_date.Checked = True Then
            var_date_filter = 1
        Else
            var_date_filter = 0
        End If
        Dim Rows As Integer
        Dim DT As DataTable
        If txt_search.Text = "" Then
            DT = select_purchase_direct("", "", 1, var_date_filter, tglawal.Value, tglakhir.Value)
        Else
            DT = select_purchase_direct(cbo_search.Text, txt_search.Text, 0, var_date_filter, tglawal.Value, tglakhir.Value)
        End If
        Rows = DT.Rows.Count - 1

        DataGridView2.Rows.Clear()
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                DataGridView2.Rows.Add()
                DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
                DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
                DataGridView2.Item(2, i).Value = DT.Rows(i).Item(3)
                DataGridView2.Item(3, i).Value = DT.Rows(i).Item(4)
                DataGridView2.Item(4, i).Value = DT.Rows(i).Item(5)
                DataGridView2.Item(5, i).Value = DT.Rows(i).Item(6)
                DataGridView2.Item(6, i).Value = DT.Rows(i).Item(7)
                DataGridView2.Item(7, i).Value = DT.Rows(i).Item(8)
                DataGridView2.Item(8, i).Value = DT.Rows(i).Item(9)
            Next
        End If
        'End If
    End Sub

    Private Sub generate(ByVal criteria As String)
        open_conn()
        chk_ppn.Checked = False
        TSubTotal = 0
        Dim mRow As Integer
        Dim noPurchase As String
        Dim Rows As Integer
        Dim DT As DataTable
        Dim var_date As Integer
        If chk_date.Checked = True Then
            var_date = 1
        Else
            var_date = 0
        End If
        '  TabControl1.SelectedTabPage = TabInput
        ' mRow = DataGridView2.CurrentCell.RowIndex
        'noPurchase = DataGridView2.Item(0, mRow).Value
        'edit data
        edit = 1
        insert = 0
        DT = select_purchase_direct("", criteria, 1, var_date, tglawal.Value, tglakhir.Value)
        Rows = DT.Rows.Count - 1

        DataGridView1.Rows.Clear()
        'If DT.Rows(0).Item("flag_po") = 1 Then
        '    chk_po.Checked = True
        'Else
        '    chk_po.Checked = False
        'End If
        cbo_po.EditValue = DT.Rows(0).Item("id_supplier")
        txt_idsupplier.Text = DT.Rows(0).Item("id_supplier")
        var_id_supplier = DT.Rows(0).Item("id_supplier")
        txt_inv_no.Text = DT.Rows(0).Item("no_purchase")
        txt_date.Value = DT.Rows(0).Item("date_trn")
        txt_curr.Text = DT.Rows(0).Item("id_curr")
        If DT.Rows(0).Item("payment_method") = 1 Then
            cbo_paymethod.Text = "Cash"
        Else
            cbo_paymethod.Text = "Credit"
        End If
        txt_subtotal.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
        txt_freight.Text = FormatNumber(DT.Rows(0).Item("freight"), 0)
        txt_tax.Text = FormatPercent(DT.Rows(0).Item("tax") / 100, 0)
        txt_amount.Text = FormatNumber(DT.Rows(0).Item("total"), 0)
        txt_payterm.Text = FormatNumber(DT.Rows(0).Item("payment_term_days"), 0)
        txt_discterm.Text = FormatNumber(DT.Rows(0).Item("disc_term_days"), 0)
        txt_disc_pay.Text = FormatPercent(DT.Rows(0).Item("disc_term_nominal") / 100, 0)
        txt_comment.Text = DT.Rows(0).Item("notes")
        txt_supp_nm.Text = DT.Rows(0).Item("nm_supplier")
        txt_supp_address.Text = DT.Rows(0).Item("addr_supplier")
        txt_disc.Text = FormatPercent(DT.Rows(0).Item("disc") / 100, 0)
        txt_netto.Text = FormatNumber(DT.Rows(0).Item("netto"), 0)
        Dim diskon As Double
        diskon = CDbl(Replace(txt_disc.Text, "%", "")) / 100 * (CDbl(Replace(txt_subtotal.Text, ",", "")) + CDbl(Replace(txt_freight.Text, ",", "")))
        'txt_tax_nominal.Text = FormatNumber((DT.Rows(0).Item("tax") / 100) * (CDbl(Replace(txt_subtotal.Text, ",", "")) + CDbl(Replace(txt_freight.Text, ",", "")) - diskon), 0)

        If cbo_paymethod.Text = "Cash" Then
            cbo_akun.Text = ""
            cbo_akun.SelectedText = DT.Rows(0).Item("id_account")
            ' lbl_nm_akun.Text = DT.Rows(0).Item("account_name")
            ' lbl_nm_akun.Visible = True
            cbo_akun.Enabled = True
        Else
            cbo_akun.Text = ""
            cbo_akun.SelectedText = DT.Rows(0).Item("id_account")
            ' lbl_nm_akun.Text = DT.Rows(0).Item("account_name")
            ' lbl_nm_akun.Visible = False
            cbo_akun.Enabled = False
        End If
        Dim i As Integer
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = DT.Rows(i).Item("number_asc")
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
            DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
            DataGridView1.Item(3, i).Value = DT.Rows(i).Item("notes_detail")
            DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("qtypo"), 0)
            DataGridView1.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("qty_received"), 0)
            DataGridView1.Item(6, i).Value = DT.Rows(i).Item("id_unit")
            DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
            DataGridView1.Item(8, i).Value = FormatNumber(DT.Rows(i).Item("nominal"), 0)
        Next
        txt_kurs.Text = FormatNumber(DT.Rows(0).Item("kurs"), 0)
        For i = 0 To Rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(8, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        If DT.Rows(0).Item("tax") > 0 Then
            chk_ppn.Checked = True
        Else
            chk_ppn.Checked = False
        End If
        hitung_nominal()

        insert = 0
        edit = 1
        btn_del2.Enabled = True
        btn_cetak.Enabled = True
        cbo_po.Enabled = False
        DataGridView1.Rows.Add(250)
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick

        open_conn()
        Dim jml_po As Integer
        Dim a As Integer
        a = DataGridView2.CurrentCell.RowIndex
        jml_po = select_validate("PURCH_PURCHRETUR", DataGridView2.Item(0, a).Value)
        If jml_po > 0 Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Terdapat transaksi retur")
            alertControl_error.Show(Me, info)
            Exit Sub
        End If

        'generate()
    End Sub

    'Private Sub txt_search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_search.KeyPress
    '    list_data()
    'End Sub

    Private Sub cbo_paymethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_paymethod.SelectedIndexChanged
        open_conn()
        If cbo_paymethod.Text = "Credit" Then
            txt_payterm.Enabled = True
            txt_payterm.BackColor = Color.White
            txt_disc_pay.Enabled = True
            txt_disc_pay.BackColor = Color.White
            txt_discterm.Enabled = True
            txt_discterm.BackColor = Color.White
            cbo_akun.Enabled = False
            cbo_akun.BackColor = Color.Wheat
            '  lbl_nm_akun.Visible = False
            cbo_akun.Text = ""
            If var_id_supplier <> Nothing Then
                cbo_akun.SelectedText = get_acc_hutang_supplier(var_id_supplier)
            End If
        Else
            txt_payterm.Enabled = False
            txt_payterm.BackColor = Color.Wheat
            txt_disc_pay.Enabled = False
            txt_disc_pay.BackColor = Color.Wheat
            txt_discterm.Enabled = False
            txt_discterm.BackColor = Color.Wheat
            cbo_akun.Enabled = True
            cbo_akun.BackColor = Color.White
            cbo_akun.Text = ""
            'cbo_akun.SelectedText = get_acc_hutang_supplier(var_id_supplier)
        End If
    End Sub

    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_PURCHASE_DIRECT_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim var_po As Integer
        Dim var_pay_method As Integer

        If chk_po.Checked = True Then
            var_po = 1
        Else
            var_po = 0
        End If

        If cbo_paymethod.Text = "Cash" Then
            var_pay_method = 1
        Else
            var_pay_method = 2
        End If

        If edit = 1 Then
            If select_validate("Purchase", Trim(txt_inv_no.Text)) > 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Faktur ini telah lunas")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_purchase_langsung(Trim(txt_inv_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Trim(cbo_po.EditValue), _
                            var_id_supplier, var_pay_method, txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), _
                            txt_subtotal.Text, txt_freight.Text, Replace(txt_tax.Text, "%", ""), txt_amount.Text, Trim(txt_comment.Text), _
                            username, Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), _
                            0, "", "", 0, "", 0, 0, Trim(txt_curr.Text), 0, 0, "DELETE", 0, var_po, Replace(txt_disc.Text, "%", ""), cbo_akun.Text, "")
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

    Private Sub cbo_po_no_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        clean()
        If chk_po.Checked = False Then
            Dim NewDisplayAcc As New frm_display_supp
            NewDisplayAcc.formsource_purchase_supplier = True
            NewDisplayAcc.Show()
            'NewDisplayAcc.MdiParent = MainMenu
            Me.Enabled = False
        Else
            Dim NewDisplayAcc As New frm_display_po
            NewDisplayAcc.formsource_purchase_po = True
            NewDisplayAcc.Show()
            '  NewDisplayAcc.MdiParent = MainMenu
            Me.Enabled = False
        End If
    End Sub

    Private Sub chk_po_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        If chk_po.Checked = True Then

            DataGridView1.Enabled = False
        Else

            DataGridView1.Enabled = True
        End If
        clean_cek_po = 1
        clean()
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
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(7).Width = .Columns(7).Width + selisih_col2
        'End With
    End Sub

    Private Sub view_data()
        open_conn()
        'On Error Resume Next
        'If TabControl1.SelectedTabPage Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim Rows As Integer
            Dim DT As DataTable
            Dim var_date As Integer
            If chk_date.Checked = True Then
                var_date = 1
            Else
                var_date = 0
            End If

            Dim dtcust As DataTable
            dtcust = select_purchase_direct("Invoice No", "", 0, 0, tglawal.Value, tglakhir.Value)
            GridControl.DataSource = dtcust
            GridList_Customer.Columns("no_purchase").Caption = "No Transaksi"
            GridList_Customer.Columns("no_purchase").Width = 150
            GridList_Customer.Columns("nm_supplier").Caption = "Supplier"
            GridList_Customer.Columns("nm_supplier").Width = 250
            GridList_Customer.Columns("total").Caption = "Total"
            GridList_Customer.Columns("total").Width = 160
            GridList_Customer.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("total").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("nm_payment").Caption = "Cara Bayar"
            GridList_Customer.Columns("nm_payment").Width = 100
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 120
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MM-yyyy"
            GridList_Customer.Columns("addr_supplier").Visible = False
            GridList_Customer.Columns("no_purchase_order").Visible = False
            GridList_Customer.Columns("subtotal").Visible = False
            GridList_Customer.Columns("freight").Visible = False
            GridList_Customer.Columns("tax").Visible = False
            GridList_Customer.Columns("payment_method").Visible = False
            GridList_Customer.Columns("payment_term_days").Visible = False
            GridList_Customer.Columns("disc_term_days").Visible = False
            GridList_Customer.Columns("disc_term_nominal").Visible = False
            GridList_Customer.Columns("addr_supplier1").Visible = False
            GridList_Customer.Columns("id_supplier").Visible = False
            GridList_Customer.Columns("notes").Visible = False
            GridList_Customer.Columns("kurs").Visible = False
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    'Private Sub txt_date_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.LostFocus
    '    var_bulan = Month(txt_date.Value)
    '    var_tahun = Year(txt_date.Value)

    '    Call insert_no_trans("PURCHASE", Month(txt_date.Value), Year(txt_date.Value))
    '    Call select_control_no("PURCHASE", "TRANS")
    '    cbo_search.Text = "Purchase No"
    '    txt_inv_no.Text = no_master
    'End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("PURCHASE_DIRECT", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("PURCHASE_DIRECT", "TRANS")
            cbo_search.Text = "Invoice No"
            txt_inv_no.Text = no_master
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        open_conn()
        Dim colIndex As Integer
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        If colIndex = 8 Then
            Dim DisplayNota As New FormFakturBeli
            NoBuktiFaktur = Trim(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
        End If
    End Sub

    Private Sub txt_inv_no_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_inv_no.TextChanged

        'Dim mRow As Integer
        'Dim noPurchase As String
        'Dim Rows As Integer
        'Dim DT As DataTable
        'Dim var_date As Integer
        'If chk_date.Checked = True Then
        '    var_date = 1
        'Else
        '    var_date = 0
        'End If
        'TabControl1.SelectedTab = TabInput
        ''mRow = DataGridView2.CurrentCell.RowIndex
        ''noPurchase = DataGridView2.Item(0, mRow).Value
        ''edit data
        'edit = 1
        'insert = 0
        'DT = select_purchase(cbo_search.Text, txt_inv_no.Text, 1, var_date, tglawal.Value, tglakhir.Value)
        'Rows = DT.Rows.Count
        'open_conn()
        'DataGridView1.Rows.Clear()
        'If Rows <= 0 Then
        '    'MsgBox("Tidak ada pembelian!," & vbCrLf & "Harap Cek Data Pembelian", MsgBoxStyle.Critical, "Error Data")
        '    Exit Sub
        'End If
        'If DT.Rows(0).Item("flag_po") = 1 Then
        '    chk_po.Checked = True
        'Else
        '    chk_po.Checked = False
        'End If
        'cbo_po_no.Text = DT.Rows(0).Item("no_purchase_order").ToString
        'txt_idsupplier.Text = DT.Rows(0).Item("id_supplier").ToString
        'txt_inv_no.Text = DT.Rows(0).Item("no_purchase")
        'txt_date.Value = DT.Rows(0).Item("date_trn")
        'If DT.Rows(0).Item("payment_method") = 1 Then
        '    cbo_paymethod.Text = "Cash"
        'Else
        '    cbo_paymethod.Text = "Credit"
        'End If
        'txt_subtotal.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
        'txt_freight.Text = FormatNumber(DT.Rows(0).Item("freight"), 0)
        'txt_tax.Text = FormatPercent(DT.Rows(0).Item("tax") / 100, 0)
        'txt_amount.Text = FormatNumber(DT.Rows(0).Item("total"), 0)
        'txt_payterm.Text = FormatNumber(DT.Rows(0).Item("payment_term_days"), 0)
        'txt_discterm.Text = FormatNumber(DT.Rows(0).Item("disc_term_days"), 0)
        'txt_disc_pay.Text = FormatPercent(DT.Rows(0).Item("disc_term_nominal") / 100, 0)
        'txt_comment.Text = DT.Rows(0).Item("notes")
        'txt_supp_nm.Text = DT.Rows(0).Item("nm_supplier")
        'txt_supp_address.Text = DT.Rows(0).Item("addr_supplier")
        'txt_disc.Text = FormatPercent(DT.Rows(0).Item("disc") / 100, 0)
        'txt_netto.Text = FormatNumber(DT.Rows(0).Item("netto"), 0)
        'For i = 0 To Rows - 1
        '    DataGridView1.Rows.Add()
        '    DataGridView1.Item(0, i).Value = DT.Rows(i).Item("number_asc")
        '    DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
        '    DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
        '    DataGridView1.Item(3, i).Value = DT.Rows(i).Item("notes_detail")
        '    DataGridView1.Item(4, i).Value = DT.Rows(i).Item("qty")
        '    DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
        '    DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
        '    DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("nominal"), 0)
        'Next
        'insert = 0
        'edit = 1
        'btn_del2.Enabled = True

    End Sub



    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub
    Private Sub reset_list()
        open_conn()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        tglakhir.Value = Now
        tglawal.Value = Now
        cbo_search.Text = "Invoice No"
        txt_search.Text = ""
    End Sub
    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub chk_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_date.CheckedChanged
        open_conn()
        If chk_date.Checked = True Then
            tglawal.Enabled = True
            tglakhir.Enabled = True
        ElseIf chk_date.Checked = False Then
            tglawal.Enabled = False
            tglakhir.Enabled = False
        End If
    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        Dim DisplayNota As New FormFakturBeli
        NoBuktiFaktur = Trim(txt_inv_no.Text)
        With DisplayNota
            .Show()
            '  .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub txt_idsupplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        If get_payment_method(txt_idsupplier.Text, "purchase") = 1 Then
            cbo_paymethod.Text = "Cash"
        ElseIf get_payment_method(txt_idsupplier.Text, "purchase") = 2 Then
            cbo_paymethod.Text = "Credit"
        End If

    End Sub

    Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then

            '  generate()
        End If
    End Sub

    Private Sub view_data_po(ByVal Criteria As String)
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable
        Dim date_filter As Integer
        date_filter = 0
        DT = select_po_purch("No PO", Criteria, date_filter, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"))
        Rows = DT.Rows.Count - 1
        txt_freight.Text = FormatNumber(DT.Rows(0).Item("freight"), 0)
        txt_curr.Text = DT.Rows(0).Item("id_curr")
        txt_kurs.Text = FormatNumber(DT.Rows(0).Item("kurs"), 0)
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
                DataGridView1.Item(5, i).Value = FormatNumber(DT.Rows(i).Item(4), 0)
                DataGridView1.Item(6, i).Value = DT.Rows(i).Item(5)
                DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item(6), 0)
                DataGridView1.Item(8, i).Value = FormatNumber(DT.Rows(i).Item(7), 0)
            Next
        End If
        For i = 0 To Rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(8, i).Value, ",", "")
        Next

        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        If DT.Rows(0).Item("tax") > 0 Then
            chk_ppn.Checked = True
        Else
            chk_ppn.Checked = False
        End If
        hitung_nominal()
    End Sub

    Private Sub chk_ppn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ppn.CheckedChanged
        open_conn()
        TSubTotal = 0
        Dim diskon As Double
        diskon = CDbl(Replace(txt_disc.Text, "%", "")) / 100 * (CDbl(Replace(txt_subtotal.Text, ",", "")))
        If chk_ppn.Checked = True Then
            Dim DT As DataTable
            DT = get_tax_rate("PPN")
            txt_tax.Text = DT.Rows(0).Item(0)
            txt_tax_nominal.Text = FormatNumber((DT.Rows(0).Item(0) / 100) * (CDbl(Replace(txt_subtotal.Text, ",", "")) - diskon), 0)
        ElseIf chk_ppn.Checked = False Then
            txt_tax.Text = 0
            txt_tax_nominal.Text = 0
        End If
        Dim rows As Integer
        rows = DataGridView1.Rows.Count - 1
        Dim i As Integer
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(8, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        hitung_nominal()

    End Sub

    Private Sub cbo_akun_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_akun.GotFocus
        open_conn()
        cbo_akun.DroppedDown = True
    End Sub

    Private Sub cbo_akun_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_akun.LostFocus
        open_conn()
        cbo_akun.DroppedDown = False
    End Sub


    Private Sub cbo_akun_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_akun.SelectedIndexChanged
        open_conn()
        'lbl_nm_akun.Text = cbo_akun.SelectedItem.Col2
        'lbl_nm_akun.Visible = True

    End Sub

    Private Sub txt_disc_pay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub txt_disc_pay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim disc_pay As Integer
        disc_pay = Replace(txt_disc_pay.Text, "%", "")
        txt_disc_pay.Text = FormatPercent(disc_pay / 100, 0)
    End Sub

    Private Sub txt_discterm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub frmpo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Dim NewDisplayAcc As New frm_display_item
            NewDisplayAcc.formsource_purchase_item = True
            NewDisplayAcc.Show()
            '  ' MainMenu.Enabled = False
            '  Me.Enabled = False
        End If
    End Sub

    Private Sub txt_payterm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Private Sub frmpurchase_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
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
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(7).Width = .Columns(7).Width + selisih_col2
    '    End With
    'End Sub

    Private Sub Panel10_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub txt_curr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_curr.SelectedIndexChanged

    End Sub

    Private Sub txt_freight_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_freight.TextChanged

    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub cbo_po_EditValueChanged_1(sender As System.Object, e As System.EventArgs) Handles cbo_po.EditValueChanged
        If cbo_po.EditValue <> Nothing Then
            insert = 1
            txt_date.Value = Now
            Dim row As DataRowView
            row = TryCast(cbo_po.Properties.GetRowByKeyValue(cbo_po.EditValue), DataRowView)
            var_id_supplier = row.Item("Kode")
            var_nm_supplier = row.Item("Nama").ToString
            var_add_supplier = row.Item("Alamat").ToString
            txt_supp_nm.Text = var_nm_supplier
            txt_supp_address.Text = var_add_supplier
            'view_data_po(cbo_po.EditValue)
            cbo_akun.Text = ""
            cbo_akun.SelectedText = get_acc_hutang_supplier(var_id_supplier)
            'txt_kurs.Text = get_kurs_po(var_no_po)
        End If
    End Sub

    Private Sub GroupControl2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub GroupControl5_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl5.Paint

    End Sub

    Private Sub PanelControl3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelControl3.Paint

    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl3.Visible = True
        disableMain()
        clean()
    End Sub

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        PanelControl3.Visible = False
        enableMain()
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub SimpleButton8_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton8.Click
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            Dim dtcust As DataTable
            dtcust = select_purchase_direct("Invoice No", "", 0, 0, tglawal.Value, tglakhir.Value)
            GridControl.DataSource = dtcust
            GridList_Customer.RefreshData()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub
End Class