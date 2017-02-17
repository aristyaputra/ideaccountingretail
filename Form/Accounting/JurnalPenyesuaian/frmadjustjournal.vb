Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraEditors

Public Class frmadjustjournal

    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Public NoJurnal As String
    Dim IndexRowDg As Integer
    Dim rowIndex As Integer
    Dim colIndex As Integer
    Dim pageIndex As Integer
    Dim pageLoad As Integer

    Private Sub frmadjustjournal_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
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

    Private Sub frmjournal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub frmjournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        Dim DT As New DataTable
        Dim Rows As Integer

        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("ADJUST_JOURNAL", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("ADJUST_JOURNAL", "TRANS")
        cbo_search.Text = "Journal No"
        txt_nojournal.Text = no_master
        'DataGridView1.Item(0, 0).Value = 1
        DataGridView1.Focus()
        btn_del2.Enabled = False
        btn_cetak2.Enabled = False
        insert = 1
        edit = 0
        txt_Tdebit.Text = 0
        txt_Tkredit.Text = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.RowCount = 200
        chk_date.Checked = False
        tglawal.Enabled = False
        tglakhir.Enabled = False
        datagrid_layout()
        cbo_curr.Items.Clear()
        DT = select_curr()
        Rows = DT.Rows.Count - 1
        For i = 0 To Rows
            cbo_curr.Items.Add(DT.Rows(i).Item(0))
        Next
        cbo_curr.Text = get_def_curr()
        txt_kurs.Text = 1
        DataGridView1.Rows.Add(250)
        fillComboBox()
        pageLoad = 25
        pageIndex = 1
        txtPage2.Text = 1
        txtPage2.Enabled = False
        view_data(pageIndex, pageLoad)
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
            .Columns(5).ReadOnly = False
        End With
    End Sub
    Private Sub view_data(ByVal pageIndex As Integer, ByVal pageLoad As Integer)
        open_conn()
        'If TabControl1.SelectedTabPage Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            Dim i As Integer
            Dim Rows As Integer
            Dim DT As DataTable
            Dim var_date_filter As Integer
            If chk_date.Checked = True Then
                var_date_filter = 1
            Else
                var_date_filter = 0
            End If
            DT = select_adj_journal(Trim(cbo_search.Text), Trim(txt_search.Text), 0, var_date_filter, tglawal.Value, tglakhir.Value, pageIndex, pageLoad)
            GridControl.DataSource = DT
            GridList_Customer.Columns("journal_no").Caption = "No Jurnal"
            GridList_Customer.Columns("journal_no").Width = 150
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 90
            GridList_Customer.Columns("description").Caption = "Keterangan"
            GridList_Customer.Columns("description").Width = 300
            GridList_Customer.Columns("amount").Caption = "Nominal"
            GridList_Customer.Columns("amount").Width = 180
            GridList_Customer.Columns("amount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("amount").DisplayFormat.FormatString = "N0"
            ' GridList_Customer.BestFitColumns()
            'Rows = DT.Rows.Count - 1
            'DataGridView2.Rows.Clear()
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            '        DataGridView2.Item(1, i).Value = Format(DT.Rows(i).Item(1), "dd-MMM-yyyy")
            '        DataGridView2.Item(2, i).Value = DT.Rows(i).Item(2)
            '        DataGridView2.Item(3, i).Value = FormatNumber(DT.Rows(i).Item(3), 0)
            '        'DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
            '        'DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
            '    Next
            'End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Private Sub insert_data()
        open_conn()
        Dim var_nominal As Double
        Dim i As Integer
        If insert = 1 Then
            Call insert_adj_journal(Trim(txt_nojournal.Text), txt_date.Value, Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                username, Format(server_datetime(), "yyyy-MM-dd"), "", "", 0, 0, (txt_Tdebit.Text), cbo_curr.Text, txt_kurs.Text)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then
                    If CInt(DataGridView1.Item(4, i).Value) > 0 And CInt(DataGridView1.Item(5, i).Value) <= 0 Then
                        var_nominal = CInt(DataGridView1.Item(4, i).Value)
                    ElseIf CInt(DataGridView1.Item(5, i).Value) > 0 And CInt(DataGridView1.Item(4, i).Value) <= 0 Then
                        var_nominal = -1 * CInt(DataGridView1.Item(5, i).Value)
                    Else
                        var_nominal = 0
                    End If
                    Call insert_adj_journal(Trim(txt_nojournal.Text), txt_date.Value, Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                username, Format(server_datetime(), "yyyy-MM-dd"), DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, var_nominal, 1, 0, cbo_curr.Text, txt_kurs.Text)
                End If
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "ADJUST_JOURNAL")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_adj_journal(Trim(txt_nojournal.Text), txt_date.Value, Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                username, Format(server_datetime(), "yyyy-MM-dd"), "", "", 0, 0, 1, txt_Tdebit.Text, cbo_curr.Text, txt_kurs.Text)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then
                    If CInt(DataGridView1.Item(4, i).Value) > 0 And CInt(DataGridView1.Item(5, i).Value) <= 0 Then
                        var_nominal = CInt(DataGridView1.Item(4, i).Value)
                    ElseIf CInt(DataGridView1.Item(5, i).Value) > 0 And CInt(DataGridView1.Item(4, i).Value) <= 0 Then
                        var_nominal = -1 * CInt(DataGridView1.Item(5, i).Value)
                    Else
                        var_nominal = 0
                    End If
                    Call update_adj_journal(Trim(txt_nojournal.Text), txt_date.Value, Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                username, Format(server_datetime(), "yyyy-MM-dd"), DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, var_nominal, 1, i, 0, cbo_curr.Text, txt_kurs.Text)
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
        Dim i As Integer
        insert = 1
        edit = 0
        Call select_control_no("ADJUST_JOURNAL", "TRANS")
        txt_nojournal.Text = no_master
        txt_date.Value = Now()
        txt_comment.Text = ""
        txt_Tdebit.Text = 0
        txt_Tkredit.Text = 0
        DataGridView1.Rows.Clear()
        DataGridView1.RowCount = 200
        btn_cetak2.Enabled = False
        btn_del2.Enabled = False
        cbo_curr.Text = get_def_curr()
        DataGridView1.Rows.Add(250)
    End Sub

    Private Sub btn_save2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        Dim validate As Integer
        validate = 0

        If insert = 1 Then
            If getTemplateAkses(username, "MN_ADJUSTJOURNAL_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_ADJUSTJOURNAL_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If trial = True Then
            If get_count_data("trn_adjustjournal_head", "journal_no") > row_trial Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Batas input telah habis untuk masa trial," & vbCrLf & " Silahkan membeli produk ini")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        If Val(txt_Tdebit.Text) = 0 And Val(txt_Tkredit.Text) = 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Detail Data Kosong!")
            alertControl_warning.Show(Me, info)
            validate = validate + 1
        End If
        If CDbl(txt_Tdebit.Text) <> CDbl(txt_Tkredit.Text) Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Debet dan kredit tidak sama")
            alertControl_warning.Show(Me, info)
            validate = validate + 1
        End If

        If validate > 0 Then
            Exit Sub
        End If

        'pesan = MsgBox("Simpan Data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
        msgbox_confirm = XtraMessageBox.Show(txt_confirm_simpan, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If msgbox_confirm = DialogResult.Yes Then
            insert_data()
        End If

    End Sub

    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()
        Dim var_nominal As Double
        If edit = 1 Then
            If getTemplateAkses(username, "MN_ADJUSTJOURNAL_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Hapus jurnal?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_adj_journal(Trim(txt_nojournal.Text), txt_date.Value, Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                username, Format(server_datetime(), "yyyy-MM-dd"), "", "", 0, 0, (txt_Tdebit.Text), cbo_curr.Text, txt_kurs.Text)
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

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        cbo_search.Text = "Journal No"
        txt_search.Text = ""
        chk_date.Checked = False
        pageIndex = (pageLoad * CInt(txtPage2.Text)) - pageLoad
        view_data(pageIndex, pageLoad)

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
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(2).Width = .Columns(2).Width + selisih_col2
        'End With
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        edit = 1
        insert = 0
        Dim a As Integer
        btn_cetak2.Enabled = True
        btn_del2.Enabled = True
        a = DataGridView2.CurrentCell.RowIndex
        detail(DataGridView2.Item(0, a).Value)
        TabControl1.SelectedTabPage = TabInput
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        insert = 0
        edit = 1
        Dim i As Integer
        Dim TDebet, TCredit As Integer
        'current_row = cbo_acc_group.SelectedIndex
        Dim DT As DataTable
        Dim rows As Integer
        Dim var_date_filter As Integer
        If chk_date.Checked = True Then
            var_date_filter = 1
        Else
            var_date_filter = 0
        End If
        DT = select_adj_journal("journal_no", criteria, 1, var_date_filter, tglawal.Value, tglakhir.Value, 0, pageLoad)
        rows = DT.Rows.Count - 1
        If DT.Rows.Count > 0 Then
            txt_nojournal.Text = DT.Rows(0).Item("journal_no")
            txt_date.Value = DT.Rows(0).Item("date_trn")
            txt_comment.Text = DT.Rows(0).Item("description")
            cbo_curr.Text = DT.Rows(0).Item("id_currency")
            txt_kurs.Text = DT.Rows(0).Item("kurs")
            DataGridView1.Rows.Clear()
            For i = 0 To rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_account")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("account_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("notes")
                DataGridView1.Item(4, i).Value = DT.Rows(i).Item("debet")
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item("credit")
                TDebet = TDebet + CInt(DataGridView1.Item(4, i).Value)
                TCredit = TCredit + CInt(DataGridView1.Item(5, i).Value)
            Next
            'DataGridView1.Rows.Remove(DataGridView1.Rows(i))
            txt_Tdebit.Text = FormatNumber(TDebet, 0)
            txt_Tkredit.Text = FormatNumber(TCredit, 0)
        End If
        btn_cetak2.Enabled = True
        btn_del2.Enabled = True
    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("ADJUST_JOURNAL", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("ADJUST_JOURNAL", "TRANS")
            txt_nojournal.Text = no_master
        End If
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

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        txtPage2.Text = 1
        view_data(0, pageLoad)
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        cbo_search.Text = "Journal No"
        txt_search.Text = ""
        chk_date.Checked = False
        tglawal.Enabled = False
        tglakhir.Enabled = False
        txtPage2.Text = 1
        view_data(0, pageLoad)
    End Sub

    Private Sub check_combo()
        open_conn()
        If cbo_search.Text = "Journal No" Then
            cbo_search.Text = "Journal No"
        ElseIf cbo_search.Text = "Notes" Then
            cbo_search.Text = "Notes"
        Else
            cbo_search.Text = "Journal No"
        End If
    End Sub

    Private Sub cbo_search_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_search.LostFocus
        open_conn()
        check_combo()
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub txt_nojournal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nojournal.TextChanged
        open_conn()
        edit = 1
        insert = 0

        btn_del2.Enabled = True
        detail(txt_nojournal.Text)
        TabControl1.SelectedTabPage = TabInput
    End Sub

    Private Sub btn_cetak2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak2.Click
        open_conn()
        Dim DisplayNota As New FormCtkJurnal
        NoJurnal = Trim(txt_nojournal.Text)
        With DisplayNota
            .Show()
            '  .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            edit = 1
            insert = 0
            Dim a As Integer
            btn_cetak2.Enabled = True
            btn_del2.Enabled = True
            a = DataGridView2.CurrentCell.RowIndex
            detail(DataGridView2.Item(0, a).Value)
            TabControl1.SelectedTabPage = TabInput
        End If
    End Sub

    'Private Sub comboTest_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    cbo_noakun.DroppedDown = False
    'End Sub

    'Private Sub cbo_noakun_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    '    open_conn()
    '    On Error Resume Next
    '    cbo_noakun.Text = cbo_nmakun.SelectedItem.Col2
    'End Sub

    Private Sub txt_debit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub txt_kredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub hitungDK()
        open_conn()
        Dim rows As Integer
        Dim TDebet As Double
        Dim TCredit As Double

        Dim i As Integer
        rows = DataGridView1.Rows.Count - 1
        For i = 0 To rows
            TDebet = TDebet + Replace(DataGridView1.Item(4, i).Value, ",", "")
            TCredit = TCredit + Replace(DataGridView1.Item(5, i).Value, ",", "")
        Next
        txt_Tdebit.Text = FormatNumber(TDebet, 0)
        txt_Tkredit.Text = FormatNumber(TCredit, 0)
    End Sub

    'Private Sub btn_plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    If Val(txt_debit.Text) = 0 And Val(txt_kredit.Text) = 0 Then
    '        Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan Nilai Debit/Credit")
    '        alertControl_warning.Show(Me, info)
    '        Exit Sub
    '    End If
    '    DataGridView1.Rows.Add(1)
    '    DataGridView1.Item(0, IndexRowDg).Value = IndexRowDg + 1
    '    DataGridView1.Item(1, IndexRowDg).Value = cbo_noakun.Text
    '    DataGridView1.Item(2, IndexRowDg).Value = cbo_nmakun.Text
    '    DataGridView1.Item(3, IndexRowDg).Value = txt_ket.Text
    '    DataGridView1.Item(4, IndexRowDg).Value = FormatNumber(Replace(txt_debit.Text, ",", ""), 0)
    '    DataGridView1.Item(5, IndexRowDg).Value = FormatNumber(Replace(txt_kredit.Text, ",", ""), 0)

    '    clearCollector()

    '    IndexRowDg = IndexRowDg + 1
    '    hitungDK()
    '    cbo_nmakun.Focus()
    'End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim validate As Integer
        validate = 0

        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item harus di isi!")
            alertControl_warning.Show(Me, info)
            validate = validate + 1
        End If

        Dim columnIndex As Integer
        Dim var_temp As Double
        Dim rowIndex As Integer

        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        rowIndex = DataGridView1.CurrentCell.RowIndex

        If columnIndex = 4 Then
            'DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, 0)
            If Not IsNumeric(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value) Then
                Dim info As AlertInfo = New AlertInfo("Informasi", "Format harus numerik")
                alertControl_warning.Show(Me, info)
                DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
                validate = validate + 1
            End If
        End If

        If columnIndex = 5 Then
            'DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, 0)
            If Not IsNumeric(DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value) Then
                Dim info As AlertInfo = New AlertInfo("Informasi", "Format harus numerik")
                alertControl_warning.Show(Me, info)
                DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = 0
                validate = validate + 1
            End If
        End If

        If validate > 0 Then
            Exit Sub
        End If
        If columnIndex = 4 Or columnIndex = 5 Then
            var_temp = DataGridView1.Item(columnIndex, rowIndex).Value
            DataGridView1.Item(columnIndex, rowIndex).Value = FormatNumber(var_temp, 0)
        End If
        hitungDK()

    End Sub


    'Private Sub clearCollector()
    '    open_conn()
    '    cbo_noakun.Text = ""
    '    cbo_nmakun.Text = ""
    '    txt_ket.Text = ""
    '    txt_debit.Text = ""
    '    txt_kredit.Text = ""
    'End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        DataGridView1.Item(0, mRow).Value = mRow + 1
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Delete Then
            hitungDK()
            IndexRowDg = IndexRowDg - 1
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
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

    'Private Sub txt_debit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    Dim number As Double
    '    If Trim(txt_debit.Text) = "" Then
    '        number = 0
    '    Else
    '        number = CDbl(txt_debit.Text)
    '    End If
    '    txt_debit.Text = FormatNumber(number, 0)
    'End Sub

    'Private Sub txt_kredit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    Dim number As Double
    '    If Trim(txt_kredit.Text) = "" Then
    '        number = 0
    '    Else
    '        number = CDbl(txt_kredit.Text)
    '    End If
    '    txt_kredit.Text = FormatNumber(number, 0)
    'End Sub

    Private Sub cbo_noakun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    'Private Sub cbo_noakun_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    cbo_noakun.DroppedDown = True
    'End Sub

    Private Sub DataGridView1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        open_conn()
        hitungDK()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    'Private Sub frmjournal_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
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


    Private Sub cbo_curr_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_curr.SelectedIndexChanged
        txt_kurs.Text = FormatNumber(get_def_convertcurr(Trim(cbo_curr.Text)), 0)
    End Sub

    Private Sub NavBarControl1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PanelEx1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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

    Private Sub cbo_acc_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_acc.EditValueChanged
        Dim row As DataRowView
        row = TryCast(cbo_acc.Properties.GetRowByKeyValue(cbo_acc.EditValue), DataRowView)
        DataGridView1.Item(colIndex, rowIndex).Value = cbo_acc.EditValue
        DataGridView1.Item(2, rowIndex).Value = row.Item("account_name")
        cbo_acc.Visible = False
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

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "journal_no"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "journal_no"))
        End If
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