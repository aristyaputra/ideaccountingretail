Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmreceiptmoney
    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Dim TSubTotal As Double
    Public nobukti As String
    Public tipe As String
    Dim IndexRowDg As Integer
    Dim transaction_type As Integer
    Dim rowIndex As Integer
    Dim colIndex As Integer
    Dim pageIndex As Integer
    Dim pageLoad As Integer

    Private Sub frmreceiptmoney_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub frmreceiptmoney_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmreceiptmoney_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            'Dim NewDisplayAcc As New frm_display_acc_detail
            frm_display_acc_detail.formsource_receivemoney_detail = True
            frm_display_acc_detail.Show()
            '  NewDisplayAcc.MdiParent = MainMenu
            '  ' MainMenu.Enabled = False
            '   Me.Enabled = False
        End If
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        Dim DT As New DataTable
        Dim Rows As Integer
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("RECEIVEMONEY", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("RECEIVEMONEY", "TRANS")
        cbo_search.Text = "Receipt No"
        txt_no_receive.Text = no_master
        ' DataGridView1.Item(0, 0).Value = 1
        DataGridView1.Focus()
        btn_del2.Enabled = False
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.ReadOnly = True
        '  Button1.Visible = False
        Call init_number()
        lb_cashbank_acc.Visible = False
        lb_cashbank_name.Visible = False
        'isi combo search
        'cbo_search.Items.Add("Receive No.")
        txt_search.Text = ""
        'list_data()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        'LoadComboBox_MtgcComboBoxItem()
        'LoadComboBox2_MtgcComboBoxItem()
        'LoadComboBox_cashbank()
        cbo_curr.Items.Clear()
        DT = select_curr()
        Rows = DT.Rows.Count - 1
        For i = 0 To Rows
            cbo_curr.Items.Add(DT.Rows(i).Item(0))
        Next
        cbo_curr.Text = get_def_curr()
        txt_kurs.Text = 1
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        fillComboBox()
        pageLoad = 25
        pageIndex = 1
        txtPage2.Text = 1
        txtPage2.Enabled = False
        view_data(pageIndex, pageLoad)
    End Sub

    Private Sub fillComboBox()
        Dim DTAccount As DataTable
        DTAccount = getComboAccount()
        cbo_acc.Properties.DataSource = DTAccount
        cbo_acc.Properties.DisplayMember = "account_name"
        cbo_acc.Properties.ValueMember = "id_account"
        cbo_acc.Properties.PopulateViewColumns()
        cbo_acc.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_acc.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_acc.Properties.View.Columns("id_account").Caption = "No Akun"
        cbo_acc.Properties.View.Columns("account_name").Caption = "Nama Akun"
    End Sub

    'Private Sub LoadComboBox_MtgcComboBoxItem()
    '    open_conn()
    '    Dim dtLoading As New DataTable("UsStates")
    '    dtLoading = select_combo_acc()
    '    cbo_noakun.SelectedIndex = -1
    '    cbo_noakun.Items.Clear()
    '    cbo_noakun.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
    '    cbo_noakun.SourceDataString = New String(1) {"id_account", "account_name"}
    '    cbo_noakun.SourceDataTable = dtLoading
    '    cbo_noakun.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    'End Sub

    Private Sub LoadComboBox_cashbank()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_cashbank(transaction_type)
        cbo_cashbank.SelectedIndex = -1
        cbo_cashbank.Items.Clear()
        cbo_cashbank.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_cashbank.SourceDataString = New String(1) {"id_account", "account_name"}
        cbo_cashbank.SourceDataTable = dtLoading
        cbo_cashbank.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    'Private Sub LoadComboBox2_MtgcComboBoxItem()
    '    open_conn()
    '    Dim dtLoading As New DataTable("UsStates")
    '    dtLoading = select_combo_acc()
    '    cbo_nmakun.SelectedIndex = -1
    '    cbo_nmakun.Items.Clear()
    '    cbo_nmakun.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
    '    cbo_nmakun.SourceDataString = New String(1) {"account_name", "id_account"}
    '    cbo_nmakun.SourceDataTable = dtLoading
    '    cbo_nmakun.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    'End Sub

    Private Sub init_number()
        open_conn()
        txt_total.Text = 0
    End Sub

    Dim fld As String
    Dim crt As String
    Private Sub list_data()
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable

        If txt_search.Text = "" Then
            fld = "1"
            crt = "1"
        Else
            If cbo_cashbank.Text = "Receive No." Then
                fld = "cashbank_no"
            End If
            crt = Trim(txt_search.Text)
        End If
        DT = select_view_ReceiptMoney(fld, crt)
        Rows = DT.Rows.Count - 1
        DataGridView2.Rows.Clear()
        Dim i As Integer
        For i = 0 To Rows
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = DT.Rows(i).Item("cashbank_no")
            DataGridView2.Item(1, i).Value = Format(DT.Rows(i).Item("date_trn"), "yyyy-mm-dd")
            DataGridView2.Item(2, i).Value = DT.Rows(i).Item("notes")
            DataGridView2.Item(3, i).Value = DT.Rows(i).Item("total")
        Next
    End Sub

    Private Sub cbo_cashbank_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim NewDisplayAccBank As New frm_display_acc_detail
        NewDisplayAccBank.formsource_receivemoney_accbank = True
        NewDisplayAccBank.Show()
        ' NewDisplayAccBank.MdiParent = MainMenu
        'NewDisplayAccBank.cbo_search.Text = "Account Name"
        'NewDisplayAccBank.txt_search.Text = "Bank"
        Me.Enabled = False
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim rows As Integer
        Dim columnIndex As Integer
        Dim var_temp As Double
        Dim rowIndex As Integer

        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        rowIndex = DataGridView1.CurrentCell.RowIndex
        If columnIndex = 4 Then
            var_temp = DataGridView1.Item(columnIndex, rowIndex).Value
            DataGridView1.Item(columnIndex, rowIndex).Value = FormatNumber(var_temp, 0)
        End If

        TSubTotal = 0

        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Akun penerimaan harus di isi!")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        rows = DataGridView1.Rows.Count - 1
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(4, i).Value, ",", "")
        Next
        txt_total.Text = FormatNumber(TSubTotal, 0)
    End Sub

    Private Sub hitungDK()
        open_conn()
        Dim rows As Integer
        Dim i As Integer
        TSubTotal = 0
        rows = DataGridView1.Rows.Count - 1
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(4, i).Value, ",", "")
        Next
        txt_total.Text = FormatNumber(TSubTotal, 0)
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        DataGridView1.Item(0, mRow).Value = mRow + 1
    End Sub

    Dim var_type As String
    Private Sub insert_data()
        open_conn()
        Dim i As Integer
        If Trim(cbo_type.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan pilih jenis transaksi")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If cbo_type.Text = "Cash" Then
            var_type = "KM"
        ElseIf cbo_type.Text = "Bank" Then
            var_type = "BM"
        End If

        If insert = 1 Then
            Call insert_ReceiptMoney(Trim(txt_no_receive.Text), Trim(cbo_cashbank.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                   Replace(txt_total.Text, ",", ""), Trim(txt_comment.Text), var_type, (username), server_datetime(), _
                                    (username), server_datetime(), "", "", 0, 0, 0, Trim(TextBox1.Text), cbo_curr.Text, Replace(txt_kurs.Text, ",", ""))
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then
                    Call insert_ReceiptMoney(Trim(txt_no_receive.Text), Trim(cbo_cashbank.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                0, "", var_type, (username), server_datetime(), _
                              (username), server_datetime(), DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, _
                             Replace(DataGridView1(4, i).Value, ",", ""), 1, 0, Trim(TextBox1.Text), cbo_curr.Text, Replace(txt_kurs.Text, ",", ""))
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "RECEIVEMONEY")
                pesan = MsgBox("Cetak bukti penerimaan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormCtkBBM
                    nobukti = Trim(txt_no_receive.Text)
                    tipe = Trim(cbo_type.Text)
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
            Call update_ReceiptMoney(Trim(txt_no_receive.Text), Trim(cbo_cashbank.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                   Replace(txt_total.Text, ",", ""), Trim(txt_comment.Text), var_type, (username), server_datetime(), _
                                    (username), server_datetime(), "", "", 0, 0, 0, Trim(TextBox1.Text), cbo_curr.Text, Replace(txt_kurs.Text, ",", ""))
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then
                    Call update_ReceiptMoney(Trim(txt_no_receive.Text), Trim(cbo_cashbank.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                0, "", var_type, (username), server_datetime(), _
                              (username), server_datetime(), DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, _
                             Replace(DataGridView1(4, i).Value, ",", ""), 1, 0, Trim(TextBox1.Text), cbo_curr.Text, Replace(txt_kurs.Text, ",", ""))
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                'update_no_trans(txt_date.Value, "RECEIVEMONEY")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_error.Show(Me, info)
            End If

        End If
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
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = True
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(3).ReadOnly = False
            .Columns(4).ReadOnly = False
        End With
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        With Me
            .txt_comment.Text = ""
            .lb_cashbank_acc.Text = ""
            .lb_cashbank_name.Text = ""
            .DataGridView1.Rows.Clear()
            .cbo_cashbank.Text = ""
            .TextBox1.Text = ""
            .cbo_type.Text = ""
        End With
        Call select_control_no("RECEIVEMONEY", "TRANS")
        txt_no_receive.Text = no_master
        txt_date.Value = Now
        init_number()
        btn_del2.Enabled = False
        btn_cetak2.Enabled = False
        lb_cashbank_acc.Visible = False
        lb_cashbank_name.Visible = False
        cbo_curr.Text = get_def_curr()
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        edit = 1
        insert = 0
        Dim a As Integer
        btn_del2.Enabled = True
        a = DataGridView2.CurrentCell.RowIndex
        detail(DataGridView2.Item(0, a).Value)
        TabControl1.SelectedTabPage = TabInput
    End Sub

    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()


        If edit = 1 Then
            If getTemplateAkses(username, "MN_RECEIPT_MONEY_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_ReceiptMoney(Trim(txt_no_receive.Text), Trim(lb_cashbank_name.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                   txt_total.Text, Trim(txt_comment.Text), "BM", (username), server_datetime(), _
                                    (username), server_datetime(), "", "", 0, 0, 0, Trim(TextBox1.Text))
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

    Private Sub txt_search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If Keys.Enter Then
            list_data()
        End If
    End Sub

    Private Sub view_data(ByVal pageIndex As Integer, ByVal pageLoad As Integer)
        open_conn()
        Dim i As Integer

        'If TabControl1.SelectedTabPage Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            Dim Rows As Integer
            Dim DT As DataTable
            Dim var_date_filter As Integer
            If chk_date.Checked = True Then
                var_date_filter = 1
            ElseIf chk_date.Checked = False Then
                var_date_filter = 0
            End If
            DT = select_cashbank(Trim(cbo_search.Text), Trim(txt_search.Text), 0, "IN", var_date_filter, tglawal.Value, tglakhir.Value, pageIndex, pageLoad)
            GridControl.DataSource = DT
            GridList_Customer.Columns("cashbank_no").Caption = "No Transaksi"
            GridList_Customer.Columns("cashbank_no").Width = 150
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 90
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 300
            GridList_Customer.Columns("total").Caption = "Nominal"
            GridList_Customer.Columns("total").Width = 180
            GridList_Customer.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("total").DisplayFormat.FormatString = "N0"
            'GridList_Customer.BestFitColumns()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Public Sub detail(ByVal criteria As String)
        open_conn()
        insert = 0
        edit = 1
        Dim TDebet As Integer
        Dim i As Integer
        Dim DT As DataTable
        Dim rows As Integer
        Dim var_date_filter As Integer
        If chk_date.Checked = True Then
            var_date_filter = 1
        ElseIf chk_date.Checked = False Then
            var_date_filter = 0
        End If
        DT = select_cashbank("cashbank_no", criteria, 1, "IN", 0, tglawal.Value, tglakhir.Value, 0, pageLoad)
        rows = DT.Rows.Count - 1
        If DT.Rows.Count > 0 Then
            txt_date.Value = DT.Rows(0).Item("date_trn")
            txt_no_receive.Text = DT.Rows(0).Item("cashbank_no")
            txt_comment.Text = DT.Rows(0).Item("notes")
            cbo_type.Text = DT.Rows(0).Item("type")
            cbo_cashbank.SelectedText = ""
            cbo_cashbank.Text = DT.Rows(0).Item("id_account")
            lb_cashbank_acc.Text = DT.Rows(0).Item("id_account")
            lb_cashbank_name.Text = DT.Rows(0).Item("account_name")
            TextBox1.Text = DT.Rows(0).Item("evidence_no")
            txt_kurs.Text = DT.Rows(0).Item("kurs")
            cbo_curr.Text = DT.Rows(0).Item("id_currency")
            lb_cashbank_acc.Visible = False
            lb_cashbank_name.Visible = True
            DataGridView1.Rows.Clear()
            For i = 0 To rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("acc_det")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("acc_nm_det")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("notes_det")
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("amount"), 0)
                TDebet = TDebet + CInt(DataGridView1.Item(4, i).Value)
            Next
            'DataGridView1.Rows.Remove(DataGridView1.Rows(i))
            txt_total.Text = FormatNumber(TDebet, 0)
        End If
        btn_cetak2.Enabled = True
        btn_save2.Enabled = True
    End Sub

    Private Sub btn_save2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        insert_data()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        pageIndex = (pageLoad * CInt(txtPage2.Text)) - pageLoad
        view_data(pageIndex, pageLoad)

        'Dim Total_Width_Column, Total_Width_Column2 As Integer
        'Dim Width_Table, Width_Table2 As Integer
        'Dim selisih_col, selisih_col2 As Integer

        'With DataGridView1
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(3).Width = .Columns(3).Width + selisih_col
        'End With
        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(2).Width = .Columns(2).Width + selisih_col2
        'End With
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        txtPage2.Text = 1
        view_data(0, pageLoad)
    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("RECEIVEMONEY", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("RECEIVEMONEY", "TRANS")
            'cbo_search.Text = "Receive No"
            txt_no_receive.Text = no_master
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
        cbo_search.Text = "Receipt No"
        txt_search.Text = ""
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
        txtPage2.Text = 1
        view_data(0, pageLoad)
    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        txtPage2.Text = 1
        view_data(0, pageLoad)
    End Sub

    Private Sub btn_save2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()

        If insert = 1 Then
            If getTemplateAkses(username, "MN_RECEIPT_MONEY_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_RECEIPT_MONEY_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If Val(txt_total.Text) = 0 Then
            Dim info As AlertInfo = New AlertInfo("Konfirmasi", "Data kosong")
            alertControl_warning.Show(Me, info)
            Exit Sub
        Else
            'pesan = MsgBox("Data akan disimpan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
            'If pesan = vbYes Then
            insert_data()
            'End If
        End If
    End Sub

    Private Sub btn_cetak2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak2.Click
        open_conn()
        If cbo_type.Text = "Cash" Then
            Dim DisplayNota As New FormCtkBKM
            tipe = Trim(cbo_type.Text)
            nobukti = Trim(txt_no_receive.Text)
            With DisplayNota
                .Show()
                ' .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
            'End If
        ElseIf cbo_type.Text = "Bank" Then
            Dim DisplayNota As New FormCtkBBM
            tipe = Trim(cbo_type.Text)
            nobukti = Trim(txt_no_receive.Text)
            With DisplayNota
                .Show()
                ' .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
            'End If
        End If

    End Sub

    Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            edit = 1
            insert = 0
            Dim a As Integer
            btn_del2.Enabled = True
            a = DataGridView2.CurrentCell.RowIndex
            detail(DataGridView2.Item(0, a).Value)
            TabControl1.SelectedTabPage = TabInput
        End If
    End Sub

    'Private Sub cbo_noakun_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    cbo_noakun.DroppedDown = True
    'End Sub

    Private Sub cbo_cashbank_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_cashbank.GotFocus
        open_conn()
        If Trim(cbo_type.Text) = "" Then
            cbo_type.Focus()
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan pilih jenis transaksi terlebih dahulu")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
    End Sub

    Private Sub cbo_noakun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_cashbank.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    'Private Sub cbo_noakun_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    cbo_noakun.DroppedDown = False
    'End Sub

    'Private Sub cbo_noakun_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    On Error Resume Next
    '    open_conn()
    '    cbo_nmakun.Text = cbo_noakun.SelectedItem.Col2
    'End Sub

    'Private Sub cbo_nmakun_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    cbo_nmakun.DroppedDown = True
    'End Sub

    Private Sub cbo_nmakun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    'Private Sub cbo_nmakun_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    cbo_nmakun.DroppedDown = False
    'End Sub

    'Private Sub cbo_nmakun_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    On Error Resume Next
    '    open_conn()
    '    cbo_noakun.Text = cbo_nmakun.SelectedItem.Col2
    'End Sub

    'Private Sub clearCollector()
    '    open_conn()
    '    cbo_noakun.Text = ""
    '    cbo_nmakun.Text = ""
    '    txt_ket.Text = ""
    '    txt_nominal.Text = ""
    'End Sub

    'Private Sub btn_plus_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If Val(txt_nominal.Text) = 0 Then
    '        MsgBox("Please fill debit/credit nominal", MsgBoxStyle.Critical, "Warning!")
    '        Exit Sub
    '    End If
    '    DataGridView1.Rows.Add(1)
    '    DataGridView1.Item(0, IndexRowDg).Value = IndexRowDg + 1
    '    DataGridView1.Item(1, IndexRowDg).Value = cbo_noakun.Text
    '    DataGridView1.Item(2, IndexRowDg).Value = cbo_nmakun.Text
    '    DataGridView1.Item(3, IndexRowDg).Value = txt_ket.Text
    '    DataGridView1.Item(4, IndexRowDg).Value = FormatNumber(Replace(txt_nominal.Text, ",", ""), 0)

    '    clearCollector()

    '    IndexRowDg = IndexRowDg + 1
    '    hitungDK()
    '    cbo_nmakun.Focus()
    'End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Delete Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            hitungDK()
            IndexRowDg = IndexRowDg - 1
        End If
    End Sub

    Private Sub DataGridView1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        open_conn()
        hitungDK()
    End Sub

    Private Sub cbo_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_type.SelectedIndexChanged
        open_conn()
        If cbo_type.Text = "Cash" Then
            transaction_type = 1
            LoadComboBox_cashbank()
        ElseIf cbo_type.Text = "Bank" Then
            transaction_type = 2
            LoadComboBox_cashbank()
        End If
    End Sub

    Private Sub cbo_cashbank_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_cashbank.SelectedIndexChanged
        On Error Resume Next
        open_conn()
        'cbo_nmakun.Focus()
        If Trim(cbo_cashbank.Text) <> "" Then
            lb_cashbank_name.Text = cbo_cashbank.SelectedItem.Col2
            lb_cashbank_name.Visible = True
        Else
            lb_cashbank_name.Text = ""
        End If
    End Sub

    Private Sub txt_nominal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    'Private Sub frmreceiptmoney_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column
    '        .Columns(3).Width = .Columns(3).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2
    '        .Columns(2).Width = .Columns(2).Width + selisih_col2
    '    End With
    'End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        open_conn()
        rowIndex = DataGridView1.CurrentCell.RowIndex
        colIndex = DataGridView1.CurrentCell.ColumnIndex
        If colIndex = 1 Then
            cbo_acc.Visible = True
            cbo_acc.Left = DataGridView1.GetCellDisplayRectangle(colIndex, rowIndex, False).Left
            cbo_acc.Top = DataGridView1.GetCellDisplayRectangle(colIndex, rowIndex, False).Bottom - 1
        Else
            cbo_acc.Visible = False
        End If
    End Sub

    Private Sub cbo_acc_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_acc.EditValueChanged
        Dim row As DataRowView
        row = TryCast(cbo_acc.Properties.GetRowByKeyValue(cbo_acc.EditValue), DataRowView)
        DataGridView1.Item(colIndex, rowIndex).Value = cbo_acc.EditValue
        DataGridView1.Item(2, rowIndex).Value = row.Item("account_name")
        cbo_acc.Visible = False
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub cbo_curr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_curr.SelectedIndexChanged
        txt_kurs.Text = FormatNumber(get_def_convertcurr(Trim(cbo_curr.Text)), 0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel15_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub txt_kurs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_kurs.TextChanged

    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "cashbank_no"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "cashbank_no"))
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        PanelControl3.Visible = False
        enableMain()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            view_data(pageIndex, pageLoad)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton11_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton11.Click
        If DataGridView1.Rows.Count > 0 Then
            txtPage2.Text = txtPage2.Text + 1
        End If
        pageIndex = (pageLoad * CInt(txtPage2.Text)) - pageLoad
        view_data(pageIndex, pageLoad)
    End Sub

    Private Sub SimpleButton10_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton10.Click
        If CInt(txtPage2.Text) > 1 Then
            txtPage2.Text = txtPage2.Text - 1
        End If
        pageIndex = (pageLoad * CInt(txtPage2.Text)) - pageLoad
        view_data(pageIndex, pageLoad)
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
            view_data(pageIndex, pageLoad)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class