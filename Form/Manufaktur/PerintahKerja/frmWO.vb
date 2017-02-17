Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmWO

    Dim i As Integer
    Dim a As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String

    Dim IndexRowDg As Integer

    Private Sub frmRO_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmRO_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmRO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Dim NewDisplayAcc As New frm_display_item
            NewDisplayAcc.formsource_ro_item = True
            NewDisplayAcc.Show()
            '  ' MainMenu.Enabled = False
            '  Me.Enabled = False
        End If
    End Sub

    Private Sub fillComboBox()
        Dim DTDepartemen As DataTable
        DTDepartemen = getComboDepartmentProduksi()
        cbo_department.Properties.DataSource = DTDepartemen
        cbo_department.Properties.DisplayMember = "department_name"
        cbo_department.Properties.ValueMember = "department_id"
        cbo_department.Properties.PopulateViewColumns()
        cbo_department.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_department.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_department.Properties.View.Columns("department_id").Caption = "ID"
        cbo_department.Properties.View.Columns("department_name").Caption = "Departemen"

        Dim DTPIC As DataTable
        DTPIC = getComboPIC()
        cbo_pic.Properties.DataSource = DTPIC
        cbo_pic.Properties.DisplayMember = "nama"
        cbo_pic.Properties.ValueMember = "id_employee"
        cbo_pic.Properties.PopulateViewColumns()
        cbo_pic.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_pic.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_pic.Properties.View.Columns("id_employee").Caption = "ID"
        cbo_pic.Properties.View.Columns("nama").Caption = "Nama"
        cbo_pic.Properties.View.Columns("position_name").Caption = "Posisi"
        cbo_pic.Properties.View.Columns("department_name").Caption = "Departemen"

        Dim DTBillOfMaterial As DataTable
        DTBillOfMaterial = getComboBillOfMaterial()
        cbo_bom.Properties.DataSource = DTBillOfMaterial
        cbo_bom.Properties.DisplayMember = "item_desc"
        cbo_bom.Properties.ValueMember = "no_bom"
        cbo_bom.Properties.PopulateViewColumns()
        cbo_bom.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_bom.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_bom.Properties.View.Columns("no_bom").Caption = "No BOM"
        cbo_bom.Properties.View.Columns("item_desc").Caption = "Item Diproduksi"
        cbo_bom.Properties.View.Columns("date_trn").Caption = "Tanggal"
        cbo_bom.Properties.View.Columns("qty_item_production").Caption = "Qty Produksi"
        cbo_bom.Properties.View.Columns("id_unit").Caption = "Unit"
        cbo_bom.Properties.View.Columns("total_cost").Caption = "Total Biaya Produksi"
        cbo_bom.Properties.View.Columns("finished").Caption = "Terselesaikan (%)"
        cbo_bom.Properties.View.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        cbo_bom.Properties.View.Columns("date_trn").DisplayFormat.FormatString = "dd-MM-yyyy"
        cbo_bom.Properties.View.Columns("qty_item_production").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        cbo_bom.Properties.View.Columns("qty_item_production").DisplayFormat.FormatString = "N0"
        cbo_bom.Properties.View.Columns("total_cost").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        cbo_bom.Properties.View.Columns("total_cost").DisplayFormat.FormatString = "N0"
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DataGudang.DataTableWH' table. You can move, or remove it, as needed.

        open_conn()
        Dim DT As New DataTable
        insert = 1
        edit = 0
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("WORKING_ORDER", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("WORKING_ORDER", "TRANS")
        cbo_search.Text = "WO No"
        txt_po_no.Text = no_master
        DataGridView1.Focus()
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        'LoadComboBox_MtgcComboBoxGudang()
        txt_real_date.Value = Now
        txt_real_date.Enabled = False
        fillComboBox()
        'GridList_Customer.OptionsView.ColumnAutoWidth = False
        view_data()
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxItem()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_car_brand()

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

    Private Sub LoadComboBox_MtgcComboBoxGudang()

    End Sub

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            ' .RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
            ' .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            ' .RowCount = 20
            ' .AlternatingRowsDefaultCellStyle.BackColor = Color.LavenderBlush
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = True
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(3).ReadOnly = False
            .Columns(4).ReadOnly = False
            .Columns(5).ReadOnly = False
            '.Columns(5).DefaultCellStyle.BackColor = Color.LightGray
        End With
    End Sub

    Private Sub cbo_supplier_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim NewDisplayAcc As New frm_display_supp
        '  ' MainMenu.Enabled = False
        NewDisplayAcc.formsource_ro = True
        NewDisplayAcc.Show()
        NewDisplayAcc.txt_search.Focus()
        '   NewDisplayAcc.MdiParent = MainMenu
        'Me.Enabled = False
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
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Data sudah ada")
                    alertControl_warning.Show(Me, info)
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
            Dim date_server As Date
            date_server = server_datetime()
            Call insert_wo(Trim(txt_po_no.Text), _
                         Format(txt_req_date.Value, "yyyy-MM-dd"), _
                         Format(txt_real_date.Value, "yyyy-MM-dd"), _
                         Format(txt_start_date.Value, "yyyy-MM-dd"), _
                         Format(txt_date.Value, "yyyy-MM-dd"), _
                         cbo_pic.EditValue, _
                         cbo_department.EditValue, _
                         Replace(txt_total_cost.Text, ",", ""), _
                         txt_comment.Text,
                         username, _
                         date_server, _
                         date_server, _
                         username, _
                         "", _
                         "", _
                         0, _
                         "", _
                         0, _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         0, _
                         "", _
                         0, 0, 0, "INSERT")
            For i = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.CurrentCell = DataGridView1(0, i)
                If DataGridView1.Item(1, i).Value <> Nothing Or DataGridView1.Item(1, i).Value <> "" Then
                    Call insert_wo(Trim(txt_po_no.Text), _
                         Format(txt_req_date.Value, "yyyy-MM-dd"), _
                         Format(txt_real_date.Value, "yyyy-MM-dd"), _
                         Format(txt_start_date.Value, "yyyy-MM-dd"), _
                         Format(txt_date.Value, "yyyy-MM-dd"), _
                         cbo_pic.EditValue, _
                         cbo_department.EditValue, _
                         Replace(txt_total_cost.Text, ",", ""), _
                         txt_comment.Text,
                         username, _
                         date_server, _
                         date_server, _
                         username, _
                         DataGridView1.Item(1, i).Value, _
                         DataGridView1.Item(2, i).Value, _
                         Replace(DataGridView1.Item(3, i).Value, ",", ""), _
                         DataGridView1.Item(4, i).Value, _
                         Replace(DataGridView1.Item(5, i).Value, ",", ""), _
                         Replace(DataGridView1.Item(6, i).Value, ",", ""), _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         0, _
                         "", _
                         0, 1, i, "INSERT")
                End If

                For x As Integer = 0 To DataGridView3.Rows.Count - 1
                    If DataGridView3.Item(1, x).Value <> Nothing Or DataGridView3.Item(1, x).Value <> "" Then
                        Call insert_wo(Trim(txt_po_no.Text), _
                             Format(txt_req_date.Value, "yyyy-MM-dd"), _
                             Format(txt_real_date.Value, "yyyy-MM-dd"), _
                             Format(txt_start_date.Value, "yyyy-MM-dd"), _
                             Format(txt_date.Value, "yyyy-MM-dd"), _
                             cbo_pic.EditValue, _
                             cbo_department.EditValue, _
                             Replace(txt_total_cost.Text, ",", ""), _
                             txt_comment.Text,
                             username, _
                             date_server, _
                             date_server, _
                             username, _
                             DataGridView1.Item(1, i).Value, _
                             DataGridView1.Item(2, i).Value, _
                             Replace(DataGridView1.Item(3, i).Value, ",", ""), _
                             DataGridView1.Item(4, i).Value, _
                             Replace(DataGridView1.Item(5, i).Value, ",", ""), _
                             Replace(DataGridView1.Item(6, i).Value, ",", ""), _
                             DataGridView3.Item(1, x).Value, _
                             Replace(DataGridView3.Item(4, x).Value, ",", ""), _
                             DataGridView3.Item(5, x).Value, _
                             Replace(DataGridView3.Item(6, x).Value, ",", ""), _
                             DataGridView3.Item(3, x).Value, _
                             Replace(DataGridView3.Item(7, x).Value, ",", ""), _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             0, _
                             "", _
                             0, 2, x, "INSERT")
                    End If
                Next
                For y As Integer = 0 To DataGridView4.Rows.Count - 1
                    If DataGridView4.Item(1, y).Value <> Nothing Or DataGridView4.Item(1, y).Value <> "" Then
                        Call insert_wo(Trim(txt_po_no.Text), _
                             Format(txt_req_date.Value, "yyyy-MM-dd"), _
                             Format(txt_real_date.Value, "yyyy-MM-dd"), _
                             Format(txt_start_date.Value, "yyyy-MM-dd"), _
                             Format(txt_date.Value, "yyyy-MM-dd"), _
                             cbo_pic.EditValue, _
                             cbo_department.EditValue, _
                             Replace(txt_total_cost.Text, ",", ""), _
                             txt_comment.Text,
                             username, _
                             date_server, _
                             date_server, _
                             username, _
                             DataGridView1.Item(1, i).Value, _
                             DataGridView1.Item(2, i).Value, _
                             Replace(DataGridView1.Item(3, i).Value, ",", ""), _
                             DataGridView1.Item(4, i).Value, _
                             Replace(DataGridView1.Item(5, i).Value, ",", ""), _
                             Replace(DataGridView1.Item(6, i).Value, ",", ""), _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             DataGridView4.Item(1, y).Value, _
                             Replace(DataGridView4.Item(4, y).Value, ",", ""), _
                             DataGridView4.Item(5, y).Value, _
                             Replace(DataGridView4.Item(6, y).Value, ",", ""), _
                             DataGridView4.Item(3, y).Value, _
                             Replace(DataGridView4.Item(7, y).Value, ",", ""), _
                             "", _
                             0, _
                             0, _
                             "", _
                             0, 3, y, "INSERT")
                    End If
                Next
                For z As Integer = 0 To DataGridView5.Rows.Count - 1
                    If DataGridView5.Item(1, z).Value <> Nothing Or DataGridView5.Item(1, z).Value <> "" Then
                        Call insert_wo(Trim(txt_po_no.Text), _
                             Format(txt_req_date.Value, "yyyy-MM-dd"), _
                             Format(txt_real_date.Value, "yyyy-MM-dd"), _
                             Format(txt_start_date.Value, "yyyy-MM-dd"), _
                             Format(txt_date.Value, "yyyy-MM-dd"), _
                             cbo_pic.EditValue, _
                             cbo_department.EditValue, _
                             Replace(txt_total_cost.Text, ",", ""), _
                             txt_comment.Text,
                             username, _
                             date_server, _
                             date_server, _
                             username, _
                             DataGridView1.Item(1, i).Value, _
                             DataGridView1.Item(2, i).Value, _
                             Replace(DataGridView1.Item(3, i).Value, ",", ""), _
                             DataGridView1.Item(4, i).Value, _
                             Replace(DataGridView1.Item(5, i).Value, ",", ""), _
                             Replace(DataGridView1.Item(6, i).Value, ",", ""), _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             DataGridView5.Item(1, z).Value, _
                             Replace(DataGridView5.Item(4, z).Value, ",", ""), _
                             Replace(DataGridView5.Item(5, z).Value, ",", ""), _
                             DataGridView5.Item(3, z).Value, _
                             Replace(DataGridView5.Item(6, z).Value, ",", ""), 4, z, "INSERT")
                    End If
                Next
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "WORKING_ORDER")
                'pesan = MsgBox("Cetak Permintaan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                'If pesan = vbYes Then
                '    Dim DisplayNota As New FormNotaRO
                '    NoBuktiRO = Trim(txt_po_no.Text)
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
            'If select_validate("Request Order", Trim(txt_po_no.Text)) > 0 Then
            '    Dim info As AlertInfo = New AlertInfo("Informasi", "Permintaan sudah disetujui" & vbCrLf & "tidak bisa ubah data")
            '    alertControl_warning.Show(Me, info)
            '    Exit Sub
            'End If
            Dim date_server As Date
            date_server = server_datetime()
            Call update_wo(Trim(txt_po_no.Text), _
                         Format(txt_req_date.Value, "yyyy-MM-dd"), _
                         Format(txt_real_date.Value, "yyyy-MM-dd"), _
                         Format(txt_start_date.Value, "yyyy-MM-dd"), _
                         Format(txt_date.Value, "yyyy-MM-dd"), _
                         cbo_pic.EditValue, _
                         cbo_department.EditValue, _
                         Replace(txt_total_cost.Text, ",", ""), _
                         txt_comment.Text,
                         username, _
                         date_server, _
                         date_server, _
                         username, _
                         "", _
                         "", _
                         0, _
                         "", _
                         0, _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         0, _
                         "", _
                         0, 0, 0, "UPDATE")
            For i = 0 To DataGridView1.Rows.Count - 1
                DataGridView1.CurrentCell = DataGridView1(0, i)
                If DataGridView1.Item(1, i).Value <> Nothing Or DataGridView1.Item(1, i).Value <> "" Then
                    Call update_wo(Trim(txt_po_no.Text), _
                         Format(txt_req_date.Value, "yyyy-MM-dd"), _
                         Format(txt_real_date.Value, "yyyy-MM-dd"), _
                         Format(txt_start_date.Value, "yyyy-MM-dd"), _
                         Format(txt_date.Value, "yyyy-MM-dd"), _
                         cbo_pic.EditValue, _
                         cbo_department.EditValue, _
                         Replace(txt_total_cost.Text, ",", ""), _
                         txt_comment.Text,
                         username, _
                         date_server, _
                         date_server, _
                         username, _
                         DataGridView1.Item(1, i).Value, _
                         DataGridView1.Item(2, i).Value, _
                         Replace(DataGridView1.Item(3, i).Value, ",", ""), _
                         DataGridView1.Item(4, i).Value, _
                         Replace(DataGridView1.Item(5, i).Value, ",", ""), _
                         Replace(DataGridView1.Item(6, i).Value, ",", ""), _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         0, _
                         "", _
                         0, 1, i, "UPDATE")
                End If

                For x As Integer = 0 To DataGridView3.Rows.Count - 1
                    If DataGridView3.Item(1, x).Value <> Nothing Or DataGridView3.Item(1, x).Value <> "" Then
                        Call update_wo(Trim(txt_po_no.Text), _
                             Format(txt_req_date.Value, "yyyy-MM-dd"), _
                             Format(txt_real_date.Value, "yyyy-MM-dd"), _
                             Format(txt_start_date.Value, "yyyy-MM-dd"), _
                             Format(txt_date.Value, "yyyy-MM-dd"), _
                             cbo_pic.EditValue, _
                             cbo_department.EditValue, _
                             Replace(txt_total_cost.Text, ",", ""), _
                             txt_comment.Text,
                             username, _
                             date_server, _
                             date_server, _
                             username, _
                             DataGridView1.Item(1, i).Value, _
                             DataGridView1.Item(2, i).Value, _
                             Replace(DataGridView1.Item(3, i).Value, ",", ""), _
                             DataGridView1.Item(4, i).Value, _
                             Replace(DataGridView1.Item(5, i).Value, ",", ""), _
                             Replace(DataGridView1.Item(6, i).Value, ",", ""), _
                             DataGridView3.Item(1, x).Value, _
                             Replace(DataGridView3.Item(4, x).Value, ",", ""), _
                             DataGridView3.Item(5, x).Value, _
                             Replace(DataGridView3.Item(6, x).Value, ",", ""), _
                             DataGridView3.Item(3, x).Value, _
                             Replace(DataGridView3.Item(7, x).Value, ",", ""), _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             0, _
                             "", _
                             0, 2, x, "UPDATE")
                    End If
                Next
                For y As Integer = 0 To DataGridView4.Rows.Count - 1
                    If DataGridView4.Item(1, y).Value <> Nothing Or DataGridView4.Item(1, y).Value <> "" Then
                        Call update_wo(Trim(txt_po_no.Text), _
                             Format(txt_req_date.Value, "yyyy-MM-dd"), _
                             Format(txt_real_date.Value, "yyyy-MM-dd"), _
                             Format(txt_start_date.Value, "yyyy-MM-dd"), _
                             Format(txt_date.Value, "yyyy-MM-dd"), _
                             cbo_pic.EditValue, _
                             cbo_department.EditValue, _
                             Replace(txt_total_cost.Text, ",", ""), _
                             txt_comment.Text,
                             username, _
                             date_server, _
                             date_server, _
                             username, _
                             DataGridView1.Item(1, i).Value, _
                             DataGridView1.Item(2, i).Value, _
                             Replace(DataGridView1.Item(3, i).Value, ",", ""), _
                             DataGridView1.Item(4, i).Value, _
                             Replace(DataGridView1.Item(5, i).Value, ",", ""), _
                             Replace(DataGridView1.Item(6, i).Value, ",", ""), _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             DataGridView4.Item(1, y).Value, _
                             Replace(DataGridView4.Item(4, y).Value, ",", ""), _
                             DataGridView4.Item(5, y).Value, _
                             Replace(DataGridView4.Item(6, y).Value, ",", ""), _
                             DataGridView4.Item(3, y).Value, _
                             Replace(DataGridView4.Item(7, y).Value, ",", ""), _
                             "", _
                             0, _
                             0, _
                             "", _
                             0, 3, y, "UPDATE")
                    End If
                Next
                For z As Integer = 0 To DataGridView5.Rows.Count - 1
                    If DataGridView5.Item(1, z).Value <> Nothing Or DataGridView5.Item(1, z).Value <> "" Then
                        Call update_wo(Trim(txt_po_no.Text), _
                             Format(txt_req_date.Value, "yyyy-MM-dd"), _
                             Format(txt_real_date.Value, "yyyy-MM-dd"), _
                             Format(txt_start_date.Value, "yyyy-MM-dd"), _
                             Format(txt_date.Value, "yyyy-MM-dd"), _
                             cbo_pic.EditValue, _
                             cbo_department.EditValue, _
                             Replace(txt_total_cost.Text, ",", ""), _
                             txt_comment.Text,
                             username, _
                             date_server, _
                             date_server, _
                             username, _
                             DataGridView1.Item(1, i).Value, _
                             DataGridView1.Item(2, i).Value, _
                             Replace(DataGridView1.Item(3, i).Value, ",", ""), _
                             DataGridView1.Item(4, i).Value, _
                             Replace(DataGridView1.Item(5, i).Value, ",", ""), _
                             Replace(DataGridView1.Item(6, i).Value, ",", ""), _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             "", _
                             0, _
                             DataGridView5.Item(1, z).Value, _
                             Replace(DataGridView5.Item(4, z).Value, ",", ""), _
                             Replace(DataGridView5.Item(5, z).Value, ",", ""), _
                             DataGridView5.Item(3, z).Value, _
                             Replace(DataGridView5.Item(6, z).Value, ",", ""), 4, z, "UPDATE")
                    End If
                Next
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                'pesan = MsgBox("Cetak Permintaan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                'If pesan = vbYes Then
                '    Dim DisplayNota As New FormNotaRO
                '    NoBuktiRO = Trim(txt_po_no.Text)
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

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        With Me
            .txt_supp_nm.Text = ""
            .txt_supp_address.Text = ""
            .txt_comment.Text = ""
            .txt_date.Value = Now
            .cbo_supplier.Text = ""
            .DataGridView1.Rows.Clear()
            .cbo_gudang.Text = ""
            .cbo_unit.Text = ""
            .txt_real_date.Enabled = False
            .cbo_department.EditValue = Nothing
            .cbo_pic.EditValue = Nothing
        End With
        Call select_control_no("WORKING_ORDER", "TRANS")
        txt_po_no.Text = no_master
        txt_date.Value = Now
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        txt_ket.Text = ""
        txt_qty.Text = 0
        cbo_idbarang.Text = ""
        cbo_nmbarang.Text = ""
        IndexRowDg = 0
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(200)
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

    Dim TSubTotal As Double
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim rows As Integer
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
                Dim info As AlertInfo = New AlertInfo("Informasi", "No Unit")
                alertControl_warning.Show(Me, info)
                DataGridView1.Item(5, rowIndex).Value = ""
                Exit Sub
            ElseIf a > 0 Then
                DataGridView1.Item(5, rowIndex).Value = DT.Rows(0).Item(0)
            End If
        End If
        If columnIndex = 4 Or columnIndex = 6 Then
            'DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, 0)
            If Not IsNumeric(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value) Then
                Dim info As AlertInfo = New AlertInfo("Informasi", "Masukkan Format Numeric")
                alertControl_warning.Show(Me, info)
                DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
                Exit Sub
            End If
        End If
        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
            Dim info As AlertInfo = New AlertInfo("Informasi", "Item masih kosong")
            alertControl_warning.Show(Me, info)
            Exit Sub
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

    Private Sub fillComboBox_Unit()
        cbo_bom.Properties.DataSource = select_combo_unit_item(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
        cbo_bom.Properties.DisplayMember = "unit"
        cbo_bom.Properties.ValueMember = "id_unit"
        cbo_bom.Properties.PopulateViewColumns()
        cbo_bom.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_bom.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_bom.Properties.View.Columns("id_unit").Caption = "ID Unit"
        cbo_bom.Properties.View.Columns("unit").Caption = "Unit"
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        'i = DataGridView1.CurrentCell.ColumnIndex
        'If i = 1 Or i = 2 Then
        '    'Dim NewDisplayAcc As New frm_display_item
        '    'NewDisplayAcc.formsource_ro_item = True
        '    'NewDisplayAcc.Show()
        '    '' MainMenu.Enabled = False
        'End If
        DataGridView1.Item(0, mRow).Value = mRow + 1

        'If insert = 1 Then
        If mCol = 1 Then
            cbo_bom.Visible = True
            cbo_bom.Left = DataGridView1.GetCellDisplayRectangle(mCol, mRow, True).Left + 1
            cbo_bom.Top = DataGridView1.GetCellDisplayRectangle(mCol, mRow, True).Bottom - 1

        Else
            cbo_bom.Visible = False
        End If


        DataGridView3.Rows.Clear()
        DataGridView4.Rows.Clear()
        DataGridView5.Rows.Clear()
        If DataGridView1.Item(1, mRow).Value <> Nothing Then
            Dim DTMaterial As DataTable
            Dim totalmaterial As Double
            DTMaterial = getBomMaterialDet(DataGridView1.Item(1, mRow).Value)
            For i As Integer = 0 To DTMaterial.Rows.Count - 1
                DataGridView3.Rows.Add(1)
                DataGridView3.Item(0, i).Value = i + 1
                DataGridView3.Item(1, i).Value = DTMaterial.Rows(i).Item("id_item_material")
                DataGridView3.Item(2, i).Value = DTMaterial.Rows(i).Item("item_name")
                DataGridView3.Item(3, i).Value = DTMaterial.Rows(i).Item("notes_material")
                DataGridView3.Item(4, i).Value = FormatNumber(DTMaterial.Rows(i).Item("qty_material"), 0)
                DataGridView3.Item(5, i).Value = DTMaterial.Rows(i).Item("id_unit_material")
                DataGridView3.Item(6, i).Value = FormatNumber(DTMaterial.Rows(i).Item("material_cost"), 0)
                DataGridView3.Item(7, i).Value = FormatNumber(DTMaterial.Rows(i).Item("total_cost_material"), 0)
                totalmaterial = totalmaterial + Replace(DataGridView3.Item(7, i).Value, ",", "")
            Next
            txt_total.Text = FormatNumber(totalmaterial, 0)
        End If
        If DataGridView1.Item(1, mRow).Value <> Nothing Then
            Dim DTWIP As DataTable
            Dim totalwip As Double
            DTWIP = getBomWIPDet(DataGridView1.Item(1, mRow).Value)
            For i As Integer = 0 To DTWIP.Rows.Count - 1
                DataGridView4.Rows.Add(1)
                DataGridView4.Item(0, i).Value = i + 1
                DataGridView4.Item(1, i).Value = DTWIP.Rows(i).Item("id_item_wip")
                DataGridView4.Item(2, i).Value = DTWIP.Rows(i).Item("item_name")
                DataGridView4.Item(3, i).Value = DTWIP.Rows(i).Item("notes_wip")
                DataGridView4.Item(4, i).Value = FormatNumber(DTWIP.Rows(i).Item("qty_wip"), 0)
                DataGridView4.Item(5, i).Value = DTWIP.Rows(i).Item("id_unit")
                DataGridView4.Item(6, i).Value = FormatNumber(DTWIP.Rows(i).Item("wip_cost"), 0)
                DataGridView4.Item(7, i).Value = FormatNumber(DTWIP.Rows(i).Item("total_cost_wip"), 0)
                totalwip = totalwip + Replace(DataGridView4.Item(7, i).Value, ",", "")
            Next
            txt_total_wip.Text = FormatNumber(totalwip, 0)
        End If
        If DataGridView1.Item(1, mRow).Value <> Nothing Then
            Dim DTConversion As DataTable
            Dim totalkonversi As Double
            DTConversion = getBomConversionDet(DataGridView1.Item(1, mRow).Value)
            For i As Integer = 0 To DTConversion.Rows.Count - 1
                DataGridView5.Rows.Add(1)
                DataGridView5.Item(0, i).Value = i + 1
                DataGridView5.Item(1, i).Value = DTConversion.Rows(i).Item("id_cost_konversi")
                DataGridView5.Item(2, i).Value = DTConversion.Rows(i).Item("cost_name")
                DataGridView5.Item(3, i).Value = DTConversion.Rows(i).Item("notes_konversi")
                DataGridView5.Item(4, i).Value = FormatNumber(DTConversion.Rows(i).Item("qty_hour"), 0)
                DataGridView5.Item(5, i).Value = FormatNumber(DTConversion.Rows(i).Item("cost_konversi"), 0)
                DataGridView5.Item(6, i).Value = FormatNumber(DTConversion.Rows(i).Item("total_cost_konversi"), 0)
                totalkonversi = totalkonversi + Replace(DataGridView5.Item(6, i).Value, ",", "")
            Next
            txt_total_konversi.Text = FormatNumber(totalkonversi, 0)
        End If
        'End If
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
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(3).Width = .Columns(3).Width + selisih_col
        'End With
        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(4).Width + .Columns(5).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(2).Width = .Columns(2).Width + selisih_col2
        'End With
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "wo_no"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "wo_no"))
        End If
    End Sub

    Private Sub view_data()
        open_conn()
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
            DT = select_working_order(Trim(txt_search.Text), 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
            GridControl.DataSource = DT
            GridList_Customer.Columns("wo_no").Caption = "No Perintah Kerja"
            GridList_Customer.Columns("wo_no").Width = 170
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 90
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("expected_date").Caption = "Tgl Ekspektasi"
            GridList_Customer.Columns("expected_date").Width = 90
            GridList_Customer.Columns("expected_date").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("expected_date").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("realized_date").Caption = "Tgl Selesai"
            GridList_Customer.Columns("realized_date").Width = 90
            GridList_Customer.Columns("realized_date").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("realized_date").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("start_date").Caption = "Tgl Mulai"
            GridList_Customer.Columns("start_date").Width = 90
            GridList_Customer.Columns("start_date").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("start_date").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("pic").Caption = "PIC"
            GridList_Customer.Columns("pic").Width = 150
            GridList_Customer.Columns("department_name").Caption = "Departemen"
            GridList_Customer.Columns("department_name").Width = 120
            GridList_Customer.Columns("cost_total").Caption = "Biaya Produksi"
            GridList_Customer.Columns("cost_total").Width = 160
            GridList_Customer.Columns("cost_total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("cost_total").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 300
            GridList_Customer.Columns("cost_total").Visible = False
            GridList_Customer.Columns("date_trn").Visible = False
            GridList_Customer.Columns("department_id").Visible = False
            '  GridList_Customer.BestFitColumns()


            'Rows = DT.Rows.Count - 1
            'DataGridView2.Rows.Clear()
            'Dim i As Integer
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item("no_request_order")
            '        DataGridView2.Item(1, i).Value = Format(DT.Rows(i).Item("date_trn"), "yyyy-MM-dd")
            '        DataGridView2.Item(2, i).Value = DT.Rows(i).Item("notes")
            '        DataGridView2.Item(4, i).Value = DT.Rows(i).Item("notes_approve")
            '    Next
            'End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try

    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        Try
            'current_row = cbo_acc_group.SelectedIndex
            Dim DT As DataTable
            Dim rows As Integer
            Dim date_filter As Integer
            insert = 0
            edit = 1
            'If chk_date.Checked = True Then
            'date_filter = 1
            'ElseIf chk_date.Checked = False Then
            date_filter = 0
            'End If
            btn_del2.Enabled = True
            btn_cetak.Enabled = True
            DT = select_working_order(criteria, 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
            rows = DT.Rows.Count
            If DT.Rows.Count > 0 Then
                'cbo_supplier.Text = DT.Rows(0).Item("id_supplier")
                'txt_supp_nm.Text = DT.Rows(0).Item("nama")
                'txt_supp_address.Text = DT.Rows(0).Item("address")
                txt_po_no.Text = DT.Rows(0).Item("wo_no")
                txt_date.Value = DT.Rows(0).Item("date_trn")
                txt_real_date.Value = DT.Rows(0).Item("realized_date")
                txt_req_date.Value = DT.Rows(0).Item("expected_date")
                txt_comment.Text = DT.Rows(0).Item("notes")
                cbo_pic.EditValue = DT.Rows(0).Item("pic")
                cbo_department.EditValue = DT.Rows(0).Item("department_id")
                'cbo_gudang.EditValue = DT.Rows(0).Item("id_warehouse")
                txt_real_date.Enabled = True
                DataGridView1.Rows.Clear()
                DataGridView1.Rows.Add(200)

                Dim DTDetail As DataTable
                Dim totalItemProduksi As Double
                DTDetail = select_working_order(criteria, 1, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
                rows = DTDetail.Rows.Count

                For i As Integer = 0 To rows - 1
                    DataGridView1.Item(0, i).Value = i + 1
                    DataGridView1.Item(1, i).Value = DTDetail.Rows(i).Item("no_bom")
                    DataGridView1.Item(2, i).Value = DTDetail.Rows(i).Item("item_notes")
                    DataGridView1.Item(4, i).Value = DTDetail.Rows(i).Item("id_unit")
                    DataGridView1.Item(3, i).Value = FormatNumber(DTDetail.Rows(i).Item("qty_item_production"), 0)
                    DataGridView1.Item(5, i).Value = FormatNumber(DTDetail.Rows(i).Item("cost_total_wo"), 0)
                    DataGridView1.Item(6, i).Value = FormatNumber(DTDetail.Rows(i).Item("persentage_finished"), 0)
                    totalItemProduksi = totalItemProduksi + Replace(DTDetail.Rows(i).Item("cost_total_wo"), ",", "")
                    DataGridView1.CurrentCell = DataGridView1(0, i)
                Next
                txt_total_cost.Text = FormatNumber(totalItemProduksi, 0)



            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Peringatan", ex.Message)
            alertControl_error.Show(Me, info)
        End Try
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()

        edit = 1
        insert = 0
        btn_del2.Enabled = True
        btn_cetak.Enabled = True

        detail(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
        TabControl1.SelectedTabPage = TabInput
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_WORKING_ORDER_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim jml_wo As Integer
        jml_wo = select_validate("WO Material Usage", Trim(txt_po_no.Text))
        If jml_wo > 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "WO Sudah di Proses" & vbCrLf & "tidak dapat merubah data")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        Dim jml_wo_real As Integer
        jml_wo_real = select_validate("WO Realized", Trim(txt_po_no.Text))
        If jml_wo_real > 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "WO Sudah di Proses" & vbCrLf & "tidak dapat merubah data")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        If edit = 1 Then
            'If select_validate("Request Order", Trim(txt_po_no.Text)) > 0 Then
            '    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Permintaan sudah disetujui" & vbCrLf & "tidak bisa ubah data")
            '    alertControl_warning.Show(Me, info)
            '    Exit Sub
            'End If
            Dim date_server As Date
            date_server = server_datetime()
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_wo(Trim(txt_po_no.Text), _
                         Format(txt_req_date.Value, "yyyy-MM-dd"), _
                         Format(txt_real_date.Value, "yyyy-MM-dd"), _
                         Format(txt_start_date.Value, "yyyy-MM-dd"), _
                         Format(txt_date.Value, "yyyy-MM-dd"), _
                         cbo_pic.EditValue, _
                         cbo_department.EditValue, _
                         Replace(txt_total_cost.Text, ",", ""), _
                         txt_comment.Text,
                         username, _
                         date_server, _
                         date_server, _
                         username, _
                         "", _
                         "", _
                         0, _
                         "", _
                         0, _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         "", _
                         0, _
                         0, _
                         "", _
                         0, 0, 0, "DELETE")
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

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged, txt_req_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("WORKING_ORDER", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("WORKING_ORDER", "TRANS")
            txt_po_no.Text = no_master
        End If
        txt_real_date.Value = txt_req_date.Value
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
        cbo_search.Text = "Requisition No"
        txt_search.Text = ""
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_save2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        If insert = 1 Then
            If getTemplateAkses(username, "MN_WORKING_ORDER_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_WORKING_ORDER_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim jml_wo As Integer
        jml_wo = select_validate("WO Material Usage", Trim(txt_po_no.Text))
        If jml_wo > 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "WO Sudah di Proses" & vbCrLf & "tidak dapat merubah data")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        Dim jml_wo_real As Integer
        jml_wo_real = select_validate("WO Realized", Trim(txt_po_no.Text))
        If jml_wo_real > 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "WO Sudah di Proses" & vbCrLf & "tidak dapat merubah data")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

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

        open_conn()
        'If Trim(cbo_supplier.Text) = "" Then
        '    MsgBox("Supplier belum di pilih", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validate")
        '    Exit Sub
        'End If
        If cbo_department.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan pilih departemen")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If cbo_pic.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan pilih PIC")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        'If trial = True Then
        '    If get_count_data("trn_wo_head", "wo_no") > row_trial Then
        '        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Batas untuk input versi trial telah habis, silahkan membeli produk ini")
        '        alertControl_warning.Show(Me, info)
        '        Exit Sub
        '    End If
        'End If
        insert_data()

    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        Dim DisplayNota As New FormNotaRO
        NoBuktiRO = Trim(txt_po_no.Text)
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
        If colIndex = 5 Then
            Dim DisplayNota As New FormNotaRO
            NoBuktiRO = Trim(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
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

    Private Sub btn_plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        If Val(txt_qty.Text) = 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan Qty")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Item(1, i).Value = Trim(cbo_idbarang.Text) Then
                MsgBox("Data Barang Sudah Ada", MsgBoxStyle.Critical, "Warning!")
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
        clearCollector()

        IndexRowDg = IndexRowDg + 1
        cbo_nmbarang.Focus()

    End Sub

    Private Sub clearCollector()
        open_conn()
        cbo_idbarang.Text = ""
        cbo_nmbarang.Text = ""
        txt_ket.Text = ""
        txt_qty.Text = ""
    End Sub

    Private Sub cbo_idbarang_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_idbarang.DroppedDown = True
    End Sub

    Private Sub cbo_idbarang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_idbarang.DroppedDown = True
    End Sub

    Private Sub cbo_idbarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_idbarang_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error Resume Next
        open_conn()
        cbo_nmbarang.Text = cbo_idbarang.SelectedItem.Col2
        LoadComboBox_MtgcComboBoxUnit()
    End Sub

    Private Sub cbo_nmbarang_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_nmbarang.DroppedDown = True
    End Sub

    Private Sub cbo_nmbarang_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_nmbarang.DroppedDown = True
    End Sub

    Private Sub cbo_nmbarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_nmbarang_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_nmbarang.DroppedDown = False
    End Sub

    Private Sub cbo_nmbarang_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error Resume Next
        open_conn()
        cbo_idbarang.Text = cbo_nmbarang.SelectedItem.Col2
    End Sub

    Private Sub txt_qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_ket_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_unit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_unit.DroppedDown = True
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        IndexRowDg = DataGridView1.CurrentCell.RowIndex
        If e.KeyCode = Keys.Delete Then
            pesan = MessageBox.Show("Data ingin di hapus?", "Konfirmasi", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                DataGridView1.Rows.RemoveAt(IndexRowDg)
            End If
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



    'Private Sub frmRO_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(3).Width = .Columns(3).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(4).Width + .Columns(5).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(2).Width = .Columns(2).Width + selisih_col2
    '    End With
    'End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''PanelInfo.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PanelInfo.Visible = False
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        Dim Rows As Integer
        If i = 5 Then
            Dim NewDisplayAcc As New frm_display_unit
            NewDisplayAcc.formsource_ro_unit = True
            NewDisplayAcc.Show()
            '  ' MainMenu.Enabled = False
            '   Me.Enabled = False
        End If
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupControl4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl4.Paint

    End Sub

    Private Sub Panel4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub GroupControl3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl3.Paint

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

    Private Sub DataGridView1_LostFocus(sender As Object, e As System.EventArgs) Handles DataGridView1.LostFocus
        cbo_bom.Visible = False
    End Sub

    Private Sub Lookup_Unit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbo_bom.EditValueChanged
        If cbo_bom.EditValue <> Nothing Then
            Dim row As DataRowView
            Dim total_cost As Double
            row = TryCast(cbo_bom.Properties.GetRowByKeyValue(cbo_bom.EditValue), DataRowView)

            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If row.Item("no_bom") = DataGridView1.Item(1, i).Value Then
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Data sudah ada")
                    alertControl_warning.Show(Me, info)
                    Exit Sub
                End If
            Next

            DataGridView1.Item(0, mRow).Value = mRow + 1
            DataGridView1.Item(1, mRow).Value = row.Item("no_bom")
            DataGridView1.Item(2, mRow).Value = row.Item("item_desc")
            DataGridView1.Item(3, mRow).Value = FormatNumber(row.Item("qty_item_production"), 0)
            DataGridView1.Item(4, mRow).Value = row.Item("id_unit")
            DataGridView1.Item(5, mRow).Value = FormatNumber(row.Item("total_cost"), 0)
            DataGridView1.Item(6, mRow).Value = FormatNumber(row.Item("finished"), 0)
            total_cost = total_cost + Replace(DataGridView1.Item(5, mRow).Value, ",", "")
            txt_total_cost.Text = FormatNumber(total_cost, 0)
        End If
    End Sub
End Class