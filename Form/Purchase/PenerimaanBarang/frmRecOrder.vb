Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmRecOrder

    Dim i As Integer
    Dim a As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Public NoBuktiRec As String
    Dim var_id_supplier As String
    Dim var_nm_supplier As String
    Dim var_add_supplier As String
    Dim var_no_po As String
    Dim Qty_Before As Integer
    Dim nobukti_update As String
    Dim valueBefore As Integer

    Private Sub frmRecOrder_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmRecOrder_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        'TODO: This line of code loads data into the 'DataNotif.List_PO' table. You can move, or remove it, as needed.
        'Me.List_PO.Fill(Me.DataNotif.List_PO)
        Dim DT As New DataTable
        ' Dim Rows As Integer
        insert = 1
        edit = 0
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu

        'Dim Rows As Integer
        'Dim Rows_item As Integer

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

        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("RECEIVED_ORDER", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("RECEIVED_ORDER", "TRANS")
        cbo_search.Text = "Received No"
        txt_po_no.Text = no_master
        DataGridView1.Focus()
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        '   LoadComboBox_MtgcComboBoxPO()
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        'GridList_Customer.OptionsView.ColumnAutoWidth = False
        view_data()
        fillComboBox()
    End Sub

    Private Sub Lookup_Pelanggan_EditValueChanged(sender As Object, e As System.EventArgs) Handles Lookup_Pelanggan.EditValueChanged
        If Lookup_Pelanggan.EditValue <> Nothing Then
            Dim rowSupplier As DataRowView
            rowSupplier = TryCast(Lookup_Pelanggan.Properties.GetRowByKeyValue(Lookup_Pelanggan.EditValue), DataRowView)
            txt_supp_nm.Text = rowSupplier.Item("supplier_name").ToString
            txt_supp_address.Text = rowSupplier.Item("address").ToString
            var_no_po = rowSupplier.Item("no_purchase_order").ToString
            var_id_supplier = rowSupplier.Item("id_supplier").ToString
            var_nm_supplier = rowSupplier.Item("supplier_name").ToString
            var_add_supplier = rowSupplier.Item("address").ToString
            view_data_po(rowSupplier.Item("no_purchase_order").ToString)
            DataGridView1.Rows.Add(250)
        End If
    End Sub

    Private Sub fillComboBox()
        Dim DT As DataTable
        DT = select_list_po_rec()
        Lookup_Pelanggan.Properties.DataSource = DT
        Lookup_Pelanggan.Properties.DisplayMember = "id_supplier"
        Lookup_Pelanggan.Properties.ValueMember = "no_purchase_order"
        Lookup_Pelanggan.Properties.PopulateViewColumns()
        Lookup_Pelanggan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Lookup_Pelanggan.Properties.View.OptionsView.ShowAutoFilterRow = True
        Lookup_Pelanggan.Properties.View.Columns("id_supplier").Caption = "ID Supplier"
        Lookup_Pelanggan.Properties.View.Columns("supplier_name").Caption = "Nama"
        Lookup_Pelanggan.Properties.View.Columns("address").Caption = "Alamat"
        Lookup_Pelanggan.Properties.View.Columns("date_trn").Caption = "Tanggal"
        Lookup_Pelanggan.Properties.View.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Lookup_Pelanggan.Properties.View.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
        Lookup_Pelanggan.Properties.View.Columns("no_purchase_order").Caption = "No PO"

        Dim DTGudang As DataTable
        DTGudang = select_combo_gudang()
        cbo_gudang.Properties.DataSource = DTGudang
        cbo_gudang.Properties.DisplayMember = "warehouse_name"
        cbo_gudang.Properties.ValueMember = "id_warehouse"
        cbo_gudang.Properties.PopulateViewColumns()
        cbo_gudang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_gudang.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_gudang.Properties.View.Columns("id_warehouse").Caption = "Kode"
        cbo_gudang.Properties.View.Columns("warehouse_name").Caption = "Gudang"
    End Sub

    Private Sub fillComboBoxAll()
        Dim DT As DataTable
        DT = select_list_po_rec_all()
        Lookup_Pelanggan.Properties.DataSource = DT
        Lookup_Pelanggan.Properties.DisplayMember = "id_supplier"
        Lookup_Pelanggan.Properties.ValueMember = "no_purchase_order"
        Lookup_Pelanggan.Properties.PopulateViewColumns()
        Lookup_Pelanggan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Lookup_Pelanggan.Properties.View.OptionsView.ShowAutoFilterRow = True
        Lookup_Pelanggan.Properties.View.Columns("id_supplier").Caption = "ID Supplier"
        Lookup_Pelanggan.Properties.View.Columns("supplier_name").Caption = "Nama"
        Lookup_Pelanggan.Properties.View.Columns("address").Caption = "Alamat"
        Lookup_Pelanggan.Properties.View.Columns("date_trn").Caption = "Tanggal"
        Lookup_Pelanggan.Properties.View.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Lookup_Pelanggan.Properties.View.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
        Lookup_Pelanggan.Properties.View.Columns("no_purchase_order").Caption = "No PO"
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxPO()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_list_po_rec()
        cbo_po.SelectedIndex = -1
        cbo_po.Items.Clear()
        cbo_po.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_po.SourceDataString = New String(3) {"no_purchase_order", "id_supplier", "supplier_name", "address"}
        cbo_po.SourceDataTable = dtLoading
        cbo_po.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        With DataGridView1
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = False
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(7).ReadOnly = False
            .Columns(8).ReadOnly = True
            .Columns(10).ReadOnly = False
            ' .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(4).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(5).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(6).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(8).DefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub cbo_supplier_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim NewDisplayAcc As New frm_display_supp
        NewDisplayAcc.formsource_ro = True
        NewDisplayAcc.Show()
        ' NewDisplayAcc.MdiParent = MainMenu
        Me.Enabled = False
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
        Dim var_id_item As String
        Dim z, y, x As Integer
        For z = 0 To DataGridView1.Rows.Count - 1
            y = y + 1
            var_id_item = DataGridView1.Item(1, z).Value
            For x = y To DataGridView1.Rows.Count - 1
                If var_id_item = DataGridView1.Item(1, x).Value Then
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Data already exists")
                    alertControl_success.Show(Me, info)
                    Exit Sub
                Else
                    insert_data()
                End If
            Next
        Next
    End Sub

    'fungsi simpan
    Private Sub insert_data()
        open_conn()
        Dim i As Integer
        If insert = 1 Then
            Call insert_rec(Trim(txt_po_no.Text), var_no_po, var_id_supplier, Format(txt_date.Value, "yyyy-MM-dd"), _
                           Trim(txt_comment.Text), username, server_datetime(), server_datetime(), username, 0, "", "", 0, "", 0, 0, "INSERT", 0, Qty_Before, "", "")
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(10, i).Value = True Then
                    Call insert_rec(Trim(txt_po_no.Text), var_no_po, var_id_supplier, Format(txt_date.Value, "yyyy-MM-dd"), _
                           Trim(txt_comment.Text), username, server_datetime(), server_datetime(), username, i, DataGridView1.Item(1, i).Value, _
                           DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, 1, i, "INSERT", DataGridView1.Item(7, i).Value, Qty_Before, DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value)
                End If

            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "RECEIVED_ORDER")
                pesan = MsgBox("Cetak Penerimaan Barang?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormNotaReceivedOrder
                    NoBuktiRec = Trim(txt_po_no.Text)
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
            Call update_rec(Trim(txt_po_no.Text), var_no_po, var_id_supplier, Format(txt_date.Value, "yyyy-MM-dd"), _
                           Trim(txt_comment.Text), username, server_datetime(), server_datetime(), username, 0, "", "", 0, "", 0, 0, "UPDATE", 0, Qty_Before, "", "")

            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(10, i).Value = True Then
                    Dim DT_QtyRec As DataTable
                    DT_QtyRec = get_QtyRec(var_no_po, DataGridView1.Item(1, i).Value)
                    Qty_Before = CInt(DT_QtyRec.Rows(0).Item(0))
                    Call update_rec(Trim(txt_po_no.Text), var_no_po, var_id_supplier, Format(txt_date.Value, "yyyy-MM-dd"), _
                           Trim(txt_comment.Text), username, server_datetime(), server_datetime(), username, i, DataGridView1.Item(1, i).Value, _
                           DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, 1, i, "UPDATE", DataGridView1.Item(7, i).Value, Qty_Before, DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value)
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                pesan = MsgBox("Cetak Penerimaan Barang?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormNotaReceivedOrder
                    NoBuktiRec = Trim(txt_po_no.Text)
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
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        cbo_po.Enabled = True
        With Me
            .txt_supp_nm.Text = ""
            .txt_supp_address.Text = ""
            .txt_comment.Text = ""
            .txt_date.Value = Now
            .cbo_supplier.Text = ""
            .cbo_po.Text = ""
            .DataGridView1.Rows.Clear()
            .DataGridView1.Columns(10).Visible = True
        End With
        Call select_control_no("RECEIVED_ORDER", "TRANS")
        txt_po_no.Text = no_master
        txt_date.Value = Now
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        'LoadComboBox_MtgcComboBoxPO()
        cbo_po.SelectedText = ""
        cbo_po.Text = ""
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        Lookup_Pelanggan.Enabled = True
        fillComboBox()
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub txt_search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'ganti ke text changed
        open_conn()
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

        If columnIndex = 7 Then
            'DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, 0)
            If Not IsNumeric(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value) = True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Please fill with Qty > 0")
                alertControl_warning.Show(Me, info)
                DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = 0
                Exit Sub
            Else
                DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, 0)
            End If
        End If

        If columnIndex = 4 Or columnIndex = 6 Then
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, 0)
        End If
        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item Masih Kosong")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        'If columnIndex = 7 Then
        '    If CInt(DataGridView1.Item(columnIndex, rowIndex).Value) > CInt(DataGridView1.Item(6, rowIndex).Value) Then
        '        MsgBox("Qty Diterima Melebihi Sisa PO, Cek Kembali", MsgBoxStyle.Critical, "Qty Diterima")
        '        If insert = 1 Then
        '            DataGridView1.Item(columnIndex, rowIndex).Value = DataGridView1.Item(6, rowIndex).Value
        '        ElseIf edit = 1 Then
        '            Dim DT_QtyRec As DataTable
        '            DT_QtyRec = get_QtyRec(cbo_po.Text, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
        '            DataGridView1.Item(columnIndex, rowIndex).Value = DT_QtyRec.Rows(0).Item(0)
        '        End If
        '        Exit Sub
        '    End If
        'End If
        If columnIndex = 7 Then
            'If insert = 1 Then
            If CInt(DataGridView1.Item(columnIndex, rowIndex).Value) > CInt(DataGridView1.Item(6, rowIndex).Value) Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Qty diterima lebih besar dari qty sisa PO")
                alertControl_warning.Show(Me, info)
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
        Try
            If mCol = 8 And DataGridView1.Item(1, mRow).Value <> "" And IsDBNull(DataGridView1.Item(8, mRow).Value) = True Then

                cbo_gudang.Visible = True
                cbo_gudang.Left = DataGridView1.GetCellDisplayRectangle(mCol, mRow, True).Left + 1
                cbo_gudang.Top = DataGridView1.GetCellDisplayRectangle(mCol, mRow, True).Bottom - 1

            Else
                cbo_gudang.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

        DataGridView1.Item(0, mRow).Value = mRow + 1
    End Sub

    Private Sub txt_tax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        'txt_tax.SelectionStart = 0
        'txt_tax.SelectionLength = Len(txt_tax.Text)
    End Sub

    Private Sub txt_tax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        'If txt_tax.Text = "" Then
        '    txt_tax.Text = FormatPercent(0, 0)
        'Else
        '    txt_tax.Text = FormatPercent(CDbl(Replace(txt_tax.Text, "%", "")) / 100, 0)
        'End If
        'hitung_nominal()
    End Sub

    Private Sub txt_freight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
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
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(10).Width
        '    Width_Table = .Width
        '    selisih_col = (Width_Table - Total_Width_Column - 65) / 2
        '    .Columns(3).Width = .Columns(3).Width + selisih_col
        '    .Columns(2).Width = .Columns(2).Width + selisih_col
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
        Dim i As Integer
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
            DT = select_received_order(Trim(cbo_search.Text), Trim(txt_search.Text), 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
            GridControl.DataSource = DT
            GridList_Customer.Columns("no_received_order").Caption = "No Penerimaan"
            GridList_Customer.Columns("no_received_order").Width = 170
            GridList_Customer.Columns("nama").Caption = "Pemasok"
            GridList_Customer.Columns("nama").Width = 200
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 90
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 300
            GridList_Customer.Columns("id_supplier").Visible = False
            GridList_Customer.Columns("no_purchase_order").Caption = "No PO"
            GridList_Customer.Columns("no_purchase_order").Width = 170
            'GridList_Customer.BestFitColumns()
            'Rows = DT.Rows.Count - 1
            'DataGridView2.Rows.Clear()
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            '        DataGridView2.Item(2, i).Value = Format(DT.Rows(i).Item(2), "yyyy-MM-dd")
            '        DataGridView2.Item(3, i).Value = DT.Rows(i).Item(3)
            '        DataGridView2.Item(4, i).Value = DT.Rows(i).Item(5)
            '    Next
            'End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        Dim i As Integer
        Dim Qty_Sisa As Integer
        Dim DT As DataTable
        Dim rows As Integer
        Dim date_filter As Integer
        Dim DT_QtyRec As DataTable
        insert = 0
        edit = 1
        btn_del2.Enabled = True
        btn_cetak.Enabled = True
        If chk_date.Checked = True Then
            date_filter = 1
        ElseIf chk_date.Checked = False Then
            date_filter = 0
        End If
        cbo_po.Enabled = False
        DT = select_received_order("Received No", criteria, 1, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rows = DT.Rows.Count - 1
        cbo_po.Text = ""
        If DT.Rows.Count > 0 Then
            fillComboBoxAll()
            nobukti_update = DT.Rows(0).Item("no_received_order")
            Lookup_Pelanggan.EditValue = DT.Rows(0).Item("no_purchase_order")
            Lookup_Pelanggan.Enabled = False
            'cbo_supplier.SelectedText = DT.Rows(0).Item("id_supplier")
            ' cbo_po.SelectedText = DT.Rows(0).Item("no_purchase_order")
            var_no_po = DT.Rows(0).Item("no_purchase_order")
            txt_supp_nm.Text = DT.Rows(0).Item("nama")
            var_nm_supplier = DT.Rows(0).Item("nama")
            txt_supp_address.Text = DT.Rows(0).Item("address")
            var_add_supplier = DT.Rows(0).Item("address")
            txt_po_no.Text = DT.Rows(0).Item("no_received_order")
            txt_date.Value = DT.Rows(0).Item("date_trn")
            txt_comment.Text = DT.Rows(0).Item("notes")
            DataGridView1.Rows.Clear()
            For i = 0 To rows
                DT_QtyRec = get_QtyRec(var_no_po, DT.Rows(i).Item("id_item"))
                Qty_Sisa = DT_QtyRec.Rows(0).Item(0)
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("description")
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("qty_po"), 0)
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
                DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("qty_po") + DT.Rows(i).Item("received_qty") - Qty_Sisa, 0)
                DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("received_qty"), 0)
                DataGridView1.Item(8, i).Value = DT.Rows(i).Item("warehouse_name")
                DataGridView1.Item(9, i).Value = DT.Rows(i).Item("id_warehouse")
                DataGridView1.Columns(10).Visible = False
                valueBefore = DT.Rows(i).Item("received_qty")
                DataGridView1.Item(10, i).Value = True
            Next
        End If
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        Dim jml_po As Integer
        Dim a As Integer
        a = DataGridView2.CurrentCell.RowIndex
        'jml_po = select_validate("PURCH REC", DataGridView2.Item(4, a).Value)
        'If jml_po > 0 Then
        '    MsgBox("Received Item already exists in invoice" & vbCrLf & "Can't change received item", MsgBoxStyle.Information, "Information")
        '    Exit Sub
        'End If
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
            If getTemplateAkses(username, "MN_RECEIVED_ORDER_DELETE") <> True Then
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
            pesan = MessageBox.Show("Delete Confirmation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_rec(Trim(txt_po_no.Text), var_no_po, var_id_supplier, Format(txt_date.Value, "yyyy-MM-dd"), _
                           Trim(txt_comment.Text), username, server_datetime(), server_datetime(), username, 0, "", "", 0, "", 0, 0, "DELETE", 0, Qty_Before, "", "")
                For i = 0 To DataGridView1.Rows.Count - 1
                    Dim DT_QtyRec As DataTable
                    DT_QtyRec = get_QtyRec(var_no_po, DataGridView1.Item(1, i).Value)
                    Qty_Before = CInt(DT_QtyRec.Rows(0).Item(0))
                    If DataGridView1.Item(10, i).Value = True Then
                        Call delete_rec(Trim(txt_po_no.Text), var_no_po, var_id_supplier, Format(txt_date.Value, "yyyy-MM-dd"), _
                               Trim(txt_comment.Text), username, server_datetime(), server_datetime(), username, i, DataGridView1.Item(1, i).Value, _
                               DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, 1, i, "DELETE", DataGridView1.Item(7, i).Value, Qty_Before, DataGridView1.Item(8, i).Value, DataGridView1.Item(9, i).Value)
                    End If

                Next

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
            Call insert_no_trans("RECEIVED_ORDER", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("RECEIVED_ORDER", "TRANS")
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
        cbo_search.Text = "Received No"
        txt_search.Text = ""
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_save2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        Dim jml_po As Integer
        Dim z As Integer
        If edit = 1 Then
            ' z = DataGridView2.CurrentCell.RowIndex
            jml_po = select_validate("PURCH REC", var_no_po)
            If jml_po > 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Penerimaan barang telah di proses faktur" & vbCrLf & "tidak dapat merubah data")
                alertControl_error.Show(Me, info)
                Exit Sub
            End If
        End If
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_RECEIVED_ORDER_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_RECEIVED_ORDER_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim a, b As Integer
        Dim row As Integer
        row = DataGridView1.Rows.Count - 1

        For a = 0 To row
            If DataGridView1.Item(7, a).Value > 0 Then
                b = b + 1
            End If
        Next
        If b = 0 Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Masukkan qty penerimaan barang")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        b = 0
        For a = 0 To row
            If DataGridView1.Item(10, a).Value = True Then
                b = b + 1
            End If
        Next
        If b = 0 Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Tidak Ada Data yang Di pilih")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        For a = 0 To row
            If DataGridView1.Item(10, a).Value = True Then
                b = b + 1
            End If
        Next
        If b = 0 Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Item belum di pilih")
            alertControl_warning.Show(Me, info)
            Exit Sub
        ElseIf a > 0 Then
            insert_data()
        End If
    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        Dim DisplayNota As New FormNotaReceivedOrder
        NoBuktiRec = Trim(txt_po_no.Text)
        With DisplayNota
            .Show()
            ' .MdiParent = MainMenu
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

    Private Sub view_data_po(ByVal Criteria As String)
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable
        Dim DT_QtyRec As DataTable
        Dim i As Integer

        Dim date_filter As Integer
        date_filter = 0
        DT = select_po_rec("No PO", Criteria, date_filter, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"))
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                DT_QtyRec = get_QtyRec(var_no_po, DT.Rows(i).Item(0))
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item(0)
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item(1)
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item(2)
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item(3), 0)
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item(4)
                DataGridView1.Item(6, i).Value = DT.Rows(i).Item(3) - DT_QtyRec.Rows(0).Item(0)
                DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item(6), 0)
                DataGridView1.Item(8, i).Value = DT.Rows(i).Item(7)
                DataGridView1.Item(9, i).Value = DT.Rows(i).Item(8)
            Next
        End If
    End Sub

    Private Sub cbo_po_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_po.SelectedIndexChanged
        open_conn()
        If cbo_po.Text <> "" Then
            var_id_supplier = cbo_po.SelectedItem.Col2
            var_nm_supplier = cbo_po.SelectedItem.Col3
            var_add_supplier = cbo_po.SelectedItem.Col4
            txt_supp_nm.Text = var_nm_supplier
            txt_supp_address.Text = var_add_supplier
            view_data_po(cbo_po.Text)
            DataGridView1.Rows.Add(250)
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        open_conn()
        Dim colIndex As Integer
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        If colIndex = 5 Then
            Dim DisplayNota As New FormNotaReceivedOrder
            NoBuktiRec = Trim(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Private Sub frmRecOrder_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(10).Width
    '        Width_Table = .Width
    '        selisih_col = (Width_Table - Total_Width_Column - 65) / 2
    '        .Columns(3).Width = .Columns(3).Width + selisih_col
    '        .Columns(2).Width = .Columns(2).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(3).Width = .Columns(3).Width + selisih_col2
    '    End With
    'End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_received_order"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_received_order"))
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

    Private Sub GroupControl4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl4.Paint

    End Sub

    Private Sub GroupControl2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub GroupControl3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl3.Paint

    End Sub

    Private Sub GroupControl1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl3.Visible = True
        disableMain()
        clean()
        Lookup_Pelanggan.EditValue = Nothing
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

    Private Sub cbo_gudang_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_gudang.EditValueChanged
        If cbo_gudang.EditValue <> Nothing Then
            DataGridView1.Item(9, DataGridView1.CurrentCell.RowIndex).Value = cbo_gudang.EditValue
            Dim row As DataRowView = TryCast(cbo_gudang.Properties.GetRowByKeyValue(cbo_gudang.EditValue), DataRowView)
            DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value = row.Item("warehouse_name").ToString
            cbo_gudang.Visible = False
        End If
    End Sub
End Class