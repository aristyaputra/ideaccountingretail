﻿Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmreconcile
    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Dim TSubTotal_In As Double
    Dim TSubTotal_Out As Double
    Public NoBuktiReconcile As String
    Dim rowIndex As Integer
    Dim colIndex As Integer


    Private Sub fillComboBox()
        Dim DTAccount As DataTable
        DTAccount = getComboAccount()
        lookup_acc.Properties.DataSource = DTAccount
        lookup_acc.Properties.DisplayMember = "account_name"
        lookup_acc.Properties.ValueMember = "id_account"
        lookup_acc.Properties.PopulateViewColumns()
        lookup_acc.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lookup_acc.Properties.View.OptionsView.ShowAutoFilterRow = True
        lookup_acc.Properties.View.Columns("id_account").Caption = "No Akun"
        lookup_acc.Properties.View.Columns("account_name").Caption = "Nama Akun"
    End Sub

    Private Sub frmreconcile_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub frmreconcile_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmreconcile_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Dim NewDisplayAcc As New frm_display_acc_detail
            NewDisplayAcc.formsource_reconcile_detail = True
            NewDisplayAcc.Show()
            '  NewDisplayAcc.MdiParent = MainMenu
            ' ' MainMenu.Enabled = False
            ' Me.Enabled = False
        End If
    End Sub

    Private Sub frmreconcile_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu

        Dim DT As New DataTable
        Dim Rows As Integer
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("RECONCILE", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("RECONCILE", "TRANS")
        cbo_search.Text = "Reconcile No"
        txt_no_reconcile.Text = no_master
        DataGridView1.Item(0, 0).Value = 1
        DataGridView1.Focus()
        btn_del2.Enabled = False
        btn_cetak2.Enabled = False
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.ReadOnly = True
        ' btn_cetak2.Visible = False
        txt_balance.Text = 0
        txt_reconcile.Text = 0
        txt_adjustment.Text = 0
        Call init_number()
        datagrid_layout()
        'isi combo search
        'cbo_search.Items.Add("Reconcile No.")
        txt_search.Text = ""
        'list_data()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        LoadComboBox_cashbank()
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
        view_data()
    End Sub

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub LoadComboBox_cashbank()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_cashbank(2)
        cbo_acc.SelectedIndex = -1
        cbo_acc.Items.Clear()
        cbo_acc.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_acc.SourceDataString = New String(1) {"id_account", "account_name"}
        cbo_acc.SourceDataTable = dtLoading
        cbo_acc.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub init_number()
        open_conn()
        txt_balance.Text = 0
    End Sub

    Dim fld As String
    Dim crt As String
    Private Sub list_data()
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable
        Dim i As Integer

        If txt_search.Text = "" Then
            fld = "1"
            crt = "1"
        Else
            If cbo_search.Text = "Reconcile No." Then
                fld = "no_reconcile"
            End If
            crt = Trim(txt_search.Text)
        End If
        DT = select_view_ReceiptMoney(fld, crt)
        Rows = DT.Rows.Count - 1
        DataGridView2.Rows.Clear()
        For i = 0 To Rows
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = DT.Rows(i).Item("no_reconcile")
            DataGridView2.Item(1, i).Value = Format(DT.Rows(i).Item("date_trn"), "yyyy-mm-dd")
            DataGridView2.Item(2, i).Value = DT.Rows(i).Item("notes")
            DataGridView2.Item(3, i).Value = DT.Rows(i).Item("total")
        Next
    End Sub

    Private Sub cbo_cashbank_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        clean()
        ' ' MainMenu.Enabled = False
        Dim NewDisplayAccBank As New frm_display_acc_detail
        NewDisplayAccBank.formsource_reconcile = True
        NewDisplayAccBank.Show()
        ' NewDisplayAccBank.MdiParent = MainMenu
        'NewDisplayAccBank.cbo_search.Text = "Account Name"
        'NewDisplayAccBank.txt_search.Text = "Bank"

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        open_conn()
        rowIndex = DataGridView1.CurrentCell.RowIndex
        colIndex = DataGridView1.CurrentCell.ColumnIndex
        If colIndex = 1 Then
            lookup_acc.Visible = True
            lookup_acc.Left = DataGridView1.GetCellDisplayRectangle(colIndex, rowIndex, False).Left
            lookup_acc.Top = DataGridView1.GetCellDisplayRectangle(colIndex, rowIndex, False).Bottom - 1
        Else
            lookup_acc.Visible = False
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim rows As Integer
        Dim columnIndex As Integer
        Dim var_temp As Double
        Dim rowIndex As Integer
        Dim i As Integer

        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        rowIndex = DataGridView1.CurrentCell.RowIndex
        If columnIndex = 4 Or columnIndex = 5 Then
            var_temp = DataGridView1.Item(columnIndex, rowIndex).Value
            DataGridView1.Item(columnIndex, rowIndex).Value = FormatNumber(var_temp, 0)
        End If

        TSubTotal_In = 0
        TSubTotal_Out = 0
        Dim total_adjust As Double

        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" And (DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0 And DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value) = 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item masih kosong!")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        rows = DataGridView1.Rows.Count - 1
        For i = 0 To rows
            TSubTotal_In = TSubTotal_In + Replace(DataGridView1.Item(4, i).Value, ",", "")
            TSubTotal_Out = TSubTotal_Out + Replace(DataGridView1.Item(5, i).Value, ",", "")
        Next
        txt_reconcile.Text = FormatNumber(TSubTotal_In - TSubTotal_Out, 0)
        total_adjust = saldo_akhir + (TSubTotal_In - TSubTotal_Out)
        txt_adjustment.Text = FormatNumber(total_adjust, 0)
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex

        DataGridView1.Item(0, mRow).Value = mRow + 1
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

    'fungsi simpan
    Private Sub insert_data()
        open_conn()
        Dim i As Integer

        If insert = 1 Then
            Call insert_Reconcile(txt_no_reconcile.Text, txt_date.Value, cbo_acc.Text, txt_balance.Text, txt_reconcile.Text, txt_adjustment.Text, username, server_datetime(), username, server_datetime(), "", "", 0, 0, 0, 0, txt_comment.Text, cbo_curr.Text, Replace(txt_kurs.Text, ",", ""))
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then
                    Call insert_Reconcile(txt_no_reconcile.Text, txt_date.Value, cbo_acc.Text, txt_balance.Text, txt_reconcile.Text, txt_adjustment.Text, username, server_datetime(), username, server_datetime(), DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, 1, i, "", cbo_curr.Text, Replace(txt_kurs.Text, ",", ""))
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "RECONCILE")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_Reconcile(txt_no_reconcile.Text, txt_date.Value, cbo_acc.Text, txt_balance.Text, txt_reconcile.Text, txt_adjustment.Text, username, server_datetime(), username, server_datetime(), "", "", 0, 0, 0, 0, txt_comment.Text, cbo_curr.Text, Replace(txt_kurs.Text, ",", ""))
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then
                    Call update_Reconcile(txt_no_reconcile.Text, txt_date.Value, cbo_acc.Text, txt_balance.Text, txt_reconcile.Text, txt_adjustment.Text, username, server_datetime(), username, server_datetime(), DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, 1, i, "", cbo_curr.Text, Replace(txt_kurs.Text, ",", ""))
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                'update_no_trans(txt_date.Value, "RECONCILE")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
    End Sub
    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        Dim i As Integer
        With Me
            .cbo_acc.Text = ""
            .txt_balance.Text = 0
            .txt_reconcile.Text = 0
            .txt_adjustment.Text = 0
            .txt_comment.Text = ""
        End With
        Call select_control_no("RECONCILE", "TRANS")
        txt_no_reconcile.Text = no_master
        txt_date.Value = Now
        init_number()
        btn_del2.Enabled = False
        btn_cetak2.Enabled = False
        txt_balance.Text = 0
        txt_reconcile.Text = 0
        txt_adjustment.Text = 0
        For i = 0 To DataGridView1.Rows.Count - 2
            DataGridView1.Item(0, i).Value = ""
            DataGridView1.Item(1, i).Value = ""
            DataGridView1.Item(2, i).Value = ""
            DataGridView1.Item(3, i).Value = ""
            DataGridView1.Item(4, i).Value = 0
            DataGridView1.Item(5, i).Value = 0
            'DataGridView1.Rows.RemoveAt(i)
        Next
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
        btn_cetak2.Enabled = True
        a = DataGridView2.CurrentCell.RowIndex
        detail(DataGridView2.Item(0, a).Value)
        TabControl1.SelectedTabpage = TabInput
    End Sub

    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_BANK_RECONCILE_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim i As Integer
        If edit = 1 Then
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_Reconcile(txt_no_reconcile.Text, txt_date.Value, cbo_acc.Text, txt_balance.Text, txt_reconcile.Text, txt_adjustment.Text, username, server_datetime(), username, server_datetime(), "", "", 0, 0, 0, 0, txt_comment.Text)
                For i = 0 To DataGridView1.Rows.Count - 2
                    If DataGridView1.Item(1, i).Value.ToString <> "" Then
                        Call delete_Reconcile(txt_no_reconcile.Text, txt_date.Value, cbo_acc.Text, txt_balance.Text, txt_reconcile.Text, txt_adjustment.Text, username, server_datetime(), username, server_datetime(), DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, 1, i, txt_comment.Text)
                    End If
                Next
                If param_sukses = True Then
                    Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                    alertControl_success.Show(Me, info)
                    'update_no_trans(txt_date.Value, "RECONCILE")
                    clean()
                Else
                    Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
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

    Private Sub view_data()
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
            Else
                var_date_filter = 0
            End If
            DT = select_reconcile(Trim(cbo_search.Text), Trim(txt_search.Text), 0, var_date_filter, tglawal.Value, tglakhir.Value)
            GridControl.DataSource = DT
            GridList_Customer.Columns("no_reconcile").Caption = "No Rekonsiliasi"
            GridList_Customer.Columns("no_reconcile").Width = 150
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 90
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("notes_head").Caption = "Keterangan"
            GridList_Customer.Columns("notes_head").Width = 300
            GridList_Customer.Columns("reconcile").Caption = "Harga"
            GridList_Customer.Columns("reconcile").Width = 180
            GridList_Customer.Columns("reconcile").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("reconcile").DisplayFormat.FormatString = "N0"
            ' GridList_Customer.BestFitColumns()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        ' End If
    End Sub

    Public Sub detail(ByVal criteria As String)
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
        DT = select_reconcile("reconcile_no", criteria, 1, var_date_filter, tglawal.Value, tglakhir.Value)
        rows = DT.Rows.Count - 1
        If DT.Rows.Count > 0 Then
            txt_date.Value = DT.Rows(0).Item("date_trn")
            txt_no_reconcile.Text = DT.Rows(0).Item("no_reconcile")
            cbo_acc.Text = DT.Rows(0).Item("id_account_bank")
            txt_comment.Text = DT.Rows(0).Item("notes_head")
            'txt_balance.Text=0
            'lb_cashbank_acc.Text = DT.Rows(0).Item("id_account")
            'lb_cashbank_name.Text = DT.Rows(0).Item("account_name")
            cbo_curr.Text = DT.Rows(0).Item("id_currency")
            txt_kurs.Text = DT.Rows(0).Item("kurs")
            DataGridView1.Rows.Clear()
            For i = 0 To rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_account")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("account_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("notes")
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("amount_in"), 0)
                DataGridView1.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("amount_out"), 0)
                TDebet = TDebet + CInt(DataGridView1.Item(4, i).Value)
                TCredit = TCredit + CInt(DataGridView1.Item(5, i).Value)
            Next
            'DataGridView1.Rows.Remove(DataGridView1.Rows(i))
            txt_balance.Text = FormatNumber(DT.Rows(0).Item("balance_before"), 0)
            txt_reconcile.Text = FormatNumber(DT.Rows(0).Item("reconcile"), 0)
            txt_adjustment.Text = FormatNumber(DT.Rows(0).Item("balance_after"), 0)
            btn_cetak2.Enabled = True
            btn_del2.Enabled = True
        End If
    End Sub

    Private Sub btn_save2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_BANK_RECONCILE_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_BANK_RECONCILE_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        insert_data()
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
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(2).Width = .Columns(2).Width + selisih_col2
        'End With
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        view_data()
    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("RECONCILE", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("RECONCILE", "TRANS")
            'cbo_search.Text = "Reconcile No"
            txt_no_reconcile.Text = no_master
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
        cbo_search.Text = "Reconcile No"
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

    Dim saldo_akhir As Double
    Private Sub cbo_acc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_acc.SelectedIndexChanged
        open_conn()
        Try
            Dim DT As DataTable
            DT = end_balance_acc(Trim(cbo_acc.Text))
            saldo_akhir = DT.Rows(0).Item("var_saldo")
            txt_balance.Text = FormatNumber(saldo_akhir, 0)
            If Trim(cbo_acc.Text) <> "" Then
                lb_cashbank_name.Text = cbo_acc.SelectedItem.Col2
                lb_cashbank_name.Visible = True
            Else
                lb_cashbank_name.Text = ""
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Informasi", ex.Message)
            alertControl_error.Show(Me, info)
        End Try
    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak2.Click
        open_conn()
        Dim DisplayNota As New FormCtkReconcile
        NoBuktiReconcile = Trim(txt_no_reconcile.Text)
        With DisplayNota
            .Show()
            '   .MdiParent = MainMenu
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
            btn_cetak2.Enabled = True
            a = DataGridView2.CurrentCell.RowIndex
            detail(DataGridView2.Item(0, a).Value)
            TabControl1.SelectedTabPage = TabInput
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Private Sub frmreconcile_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
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

    Private Sub cbo_acc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_acc.SelectedIndexChanged

    End Sub

    Private Sub cbo_curr_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_curr.SelectedIndexChanged
        txt_kurs.Text = FormatNumber(get_def_convertcurr(Trim(cbo_curr.Text)), 0)
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        Dim rows As Integer
        If e.KeyCode = Keys.Delete Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)

            TSubTotal_In = 0
            TSubTotal_Out = 0
            Dim total_adjust As Double

            rows = DataGridView1.Rows.Count - 1
            For i = 0 To rows
                TSubTotal_In = TSubTotal_In + Replace(DataGridView1.Item(4, i).Value, ",", "")
                TSubTotal_Out = TSubTotal_Out + Replace(DataGridView1.Item(5, i).Value, ",", "")
            Next
            txt_reconcile.Text = FormatNumber(TSubTotal_In - TSubTotal_Out, 0)
            total_adjust = saldo_akhir + (TSubTotal_In - TSubTotal_Out)
            txt_adjustment.Text = FormatNumber(total_adjust, 0)

        End If
    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click

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

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub lookup_acc_EditValueChanged(sender As Object, e As System.EventArgs) Handles lookup_acc.EditValueChanged
        Dim row As DataRowView
        row = TryCast(lookup_acc.Properties.GetRowByKeyValue(lookup_acc.EditValue), DataRowView)
        DataGridView1.Item(colIndex, rowIndex).Value = lookup_acc.EditValue
        DataGridView1.Item(2, rowIndex).Value = row.Item("account_name")
        cbo_acc.Visible = False
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

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_reconcile"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_reconcile"))
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class