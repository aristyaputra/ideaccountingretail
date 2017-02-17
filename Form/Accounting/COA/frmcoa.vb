Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmcoa
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Dim pageIndex As Integer
    Dim pageLoad As Integer

    Private Sub insert_data()
        open_conn()
        Dim var_status_aktif As Integer
        Dim var_header As Integer
        Dim var_income As Integer
        Dim var_neraca As Integer
        Dim var_def As String
        Dim id_golongan As Integer
        Dim var_lra As Integer
        Dim var_lo As Integer

        If Trim(cbo_def_balance.Text) = "Debet" Then
            var_def = "D"
        Else
            var_def = "K"
        End If

        If CheckBox1.Checked = True Then
            var_status_aktif = 0
        Else
            var_status_aktif = 1
        End If

        If cbo_acc_type.Text = "Header" Then
            var_header = 1
        Else
            var_header = 0
        End If

        If rb_income.Checked = True Then
            var_income = 1
        Else
            var_income = 0
        End If

        If rb_neraca.Checked = True Then
            var_neraca = 1
        Else
            var_neraca = 0
        End If


        If cbo_gol.Text = "ASET" Then
            id_golongan = 1
        ElseIf cbo_gol.Text = "KEWAJIBAN" Then
            id_golongan = 2
        ElseIf cbo_gol.Text = "EKUITAS" Then
            id_golongan = 3
        ElseIf cbo_gol.Text = "PENDAPATAN" Then
            id_golongan = 4
        ElseIf cbo_gol.Text = "PENDAPATAN LRA" Then
            id_golongan = 4
        ElseIf cbo_gol.Text = "HPP" Then
            id_golongan = 5
        ElseIf cbo_gol.Text = "BIAYA LRA" Then
            id_golongan = 5
        ElseIf cbo_gol.Text = "BIAYA" Then
            id_golongan = 6
        ElseIf cbo_gol.Text = "PENDAPATAN LO" Then
            id_golongan = 6
        ElseIf cbo_gol.Text = "BIAYA LO" Then
            id_golongan = 7
        End If

        If insert = 1 Then
            Call insert_account(Trim(txt_acc_no.Text), Trim(txt_acc_name.Text), Trim(cbo_acc_group.Text), var_status_aktif, _
                 var_header, var_income, var_neraca, Trim(txt_notes.Text), username, server_datetime(), server_datetime(), _
                 username, var_def, Replace(txtsawal.Text, ",", ""), id_golongan)

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_account(Trim(txt_acc_no.Text), Trim(txt_acc_name.Text), Trim(cbo_acc_group.Text), var_status_aktif, _
                 var_header, var_income, var_neraca, Trim(txt_notes.Text), username, server_datetime(), server_datetime(), _
                 username, var_def, Replace(txtsawal.Text, ",", ""), id_golongan)

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

    Private Sub check_combo()
        open_conn()
        If cbo_search.Text = "Account No" Then
            cbo_search.Text = "Account No"
        ElseIf cbo_search.Text = "Account Name" Then
            cbo_search.Text = "Account Name"
        Else
            cbo_search.Text = "Account No"
        End If
    End Sub

    Private Sub frmcoa_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmcoa_ForeColorChanged(sender As Object, e As System.EventArgs) Handles Me.ForeColorChanged

    End Sub

    Private Sub frmcoa_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmcoa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        cbo_search.Text = "Account No"
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        insert = 1
        edit = 0
        'Rows = select_grup_acc.Rows.Count - 1
        'For i = 0 To Rows
        '    cbo_acc_group.Items.Add(select_grup_acc.Rows(i).Item(0) & " " & select_grup_acc.Rows(i).Item(1))
        'Next
        btn_delete.Enabled = False
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        txtsawal.Text = 0
        cbo_acc_type.Text = "Detail"
        txtsawal.Enabled = True
        rb_neraca.Checked = True
        cbo_gol.Items.Clear()
        Dim DTGolAcc As DataTable
        If cek_is_bumn() > 0 Then
            DTGolAcc = select_golongan_acc_bumn()
        Else
            DTGolAcc = select_golongan_acc_umum()
        End If
        For i As Integer = 0 To DTGolAcc.Rows.Count - 1
            cbo_gol.Items.Add(DTGolAcc.Rows(i).Item("Keterangan"))
        Next
        pageLoad = 25
        pageIndex = 1
        txtPage2.Text = 1
        txtPage2.Enabled = False
        view_data(0, pageLoad)
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        edit = 1
        insert = 0
        Dim current_row As Integer
        current_row = cbo_acc_group.SelectedIndex
        Dim DT As DataTable
        Dim var_date_filter As Integer
        If chk_date.Checked = True Then
            var_date_filter = 1
        ElseIf chk_date.Checked = False Then
            var_date_filter = 0
        End If
        DT = select_master_acc("select_account", "id_account", criteria, 1, var_date_filter, tglawal.Value, tglakhir.Value, 0, pageLoad)
        If DT.Rows.Count > 0 Then
            txt_acc_no.Text = DT.Rows(0).Item("id_account").ToString
            txt_acc_name.Text = DT.Rows(0).Item("account_name").ToString
            If DT.Rows(0).Item("Flag_Header").ToString = "1" Then
                cbo_acc_type.Text = "Header"
                txtsawal.Enabled = False
            Else
                cbo_acc_type.Text = "Detail"
                txtsawal.Enabled = True
            End If
            txt_notes.Text = DT.Rows(0).Item("notes").ToString
            If DT.Rows(0).Item("flag_active") = 1 Then
                CheckBox1.Checked = False
            Else
                CheckBox1.Checked = True
            End If
            cbo_acc_group.Text = DT.Rows(0).Item("parent").ToString
            If DT.Rows(0).Item("def_position").ToString = "D" Then
                cbo_def_balance.Text = "Debet"
            Else
                cbo_def_balance.Text = "Credit"
            End If
            If DT.Rows(0).Item("is_income") = 1 Then
                rb_income.Checked = True
            Else
                rb_income.Checked = False
            End If
            If DT.Rows(0).Item("is_balance_sheet") = 1 Then
                rb_neraca.Checked = True
            Else
                rb_neraca.Checked = False
            End If

            txtsawal.Text = FormatNumber(DT.Rows(0).Item("beg_balance"), 0)
            If DT.Rows(0).Item("golongan") = 1 Then
                cbo_gol.Text = "ASET"
            ElseIf DT.Rows(0).Item("golongan") = 2 Then
                cbo_gol.Text = "KEWAJIBAN"
            ElseIf DT.Rows(0).Item("golongan") = 3 Then
                cbo_gol.Text = "EKUITAS"
            ElseIf DT.Rows(0).Item("golongan") = 4 Then
                If cek_is_bumn() > 0 Then
                    cbo_gol.Text = "PENDAPATAN LRA"
                Else
                    cbo_gol.Text = "PENDAPATAN"
                End If
            ElseIf DT.Rows(0).Item("golongan") = 5 Then
                If cek_is_bumn() > 0 Then
                    cbo_gol.Text = "BIAYA LRA"
                Else
                    cbo_gol.Text = "HPP"
                End If
            ElseIf DT.Rows(0).Item("golongan") = 6 Then
                If cek_is_bumn() > 0 Then
                    cbo_gol.Text = "PENDAPATAN LO"
                Else
                    cbo_gol.Text = "BIAYA"
                End If
            ElseIf DT.Rows(0).Item("golongan") = 7 Then
                cbo_gol.Text = "BIAYA LO"
            End If
        End If
        btn_delete.Enabled = True
        btn_cetak2.Enabled = True
    End Sub

    Private Sub view_data(ByVal pageIndex As Integer, ByVal pageLoad As Integer)
        open_conn()
        ' If TabControl1.SelectedTabPage Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim Rows As Integer
            Dim DT As DataTable
            Dim var_date_filter As Integer
            If chk_date.Checked = True Then
                var_date_filter = 1
            ElseIf chk_date.Checked = False Then
                var_date_filter = 0
            End If
            DT = select_master_acc("select_account_withoutlimit", Trim(cbo_search.Text), Trim(txt_search.Text), 0, var_date_filter, tglawal.Value, tglakhir.Value, pageIndex, pageLoad)
            'DataGridView1.Columns.Clear()

            GridControl.DataSource = DT
            GridList_Customer.Columns("id_account").Caption = "No AKun"
            GridList_Customer.Columns("id_account").Width = 120
            GridList_Customer.Columns("account_name").Caption = "Nama Akun"
            GridList_Customer.Columns("account_name").Width = 280
            GridList_Customer.Columns("Type").Caption = "Jenis"
            GridList_Customer.Columns("Type").Width = 100
            GridList_Customer.Columns("Def").Caption = "Def Posisi"
            GridList_Customer.Columns("Def").Width = 100
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 300
            GridList_Customer.Columns("parent_name").Caption = "Group Akun"
            GridList_Customer.Columns("parent_name").Group()
            GridList_Customer.Columns("parent").Visible = False
            ' GridList_Customer.BestFitColumns()
            GridList_Customer.OptionsBehavior.AutoExpandAllGroups = True
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(Me, info)
            Exit Sub
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        '   End If
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        txt_acc_name.Text = ""
        txt_acc_no.Text = ""
        txt_notes.Text = ""
        txt_search.Text = ""
        'cbo_acc_group.Text = ""
        cbo_acc_type.Text = ""
        cbo_def_balance.Text = ""
        btn_delete.Enabled = False
        cbo_acc_group.Enabled = True
        txt_acc_no.Enabled = True
        txtsawal.Text = 0
        cbo_gol.Text = ""
        cbo_gol.Items.Clear()
        Dim DTGolAcc As DataTable
        If cek_is_bumn() > 0 Then
            DTGolAcc = select_golongan_acc_bumn()
        Else
            DTGolAcc = select_golongan_acc_umum()
        End If
        For i As Integer = 0 To DTGolAcc.Rows.Count - 1
            cbo_gol.Items.Add(DTGolAcc.Rows(i).Item("Keterangan"))
        Next
        btn_cetak2.Enabled = False
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        pageIndex = (pageLoad * CInt(txtPage2.Text)) - pageLoad
        view_data(pageIndex, pageLoad)
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        Dim i As Integer
        edit = 1
        insert = 0
        btn_delete.Enabled = True
        i = DataGridView1.CurrentCell.RowIndex
        detail(DataGridView1.Item(0, i).Value)
        TabControl1.SelectedTabPage = TabInput
        cbo_acc_group.Enabled = False
        txt_acc_no.Enabled = False
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        open_conn()
        txtPage2.Text = 1
        view_data(0, pageLoad)
    End Sub

    Private Sub txt_acc_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_acc_name.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_acc_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_acc_no.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_notes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_notes.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_acc_group_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_acc_group.Click
        open_conn()
        If cbo_acc_type.Text = "Detail" Or cbo_acc_type.Text = "Header" Then
            '  ' MainMenu.Enabled = False
            '  Me.Enabled = False
            'Dim NewDisplay As New frm_display_grupacc
            frm_display_grupacc.Show()
            '   NewDisplay.MdiParent = MainMenu
            formsource = "MASTER ACCOUNT"
        Else
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih tipe akun" & vbCrLf & "terlebih dahulu")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

    End Sub

    Private Sub cbo_acc_group_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_acc_group.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_acc_type_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_acc_type.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_def_balance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_def_balance.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        insert_data()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        open_conn()
        Dim var_status_aktif As Integer
        Dim var_header As Integer
        Dim var_income As Integer
        Dim var_neraca As Integer
        Dim var_def As String


        If edit = 1 Then
            If getTemplateAkses(username, "MN_COA_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If Trim(cbo_def_balance.Text) = "Debet" Then
            var_def = "D"
        Else
            var_def = "K"
        End If

        If CheckBox1.Checked = True Then
            var_status_aktif = 0
        Else
            var_status_aktif = 1
        End If

        If cbo_acc_group.Text = "Header" Then
            var_header = 1
        Else
            var_header = 0
        End If

        If rb_income.Checked = True Then
            var_income = 1
        Else
            var_income = 0
        End If

        If rb_neraca.Checked = True Then
            var_neraca = 1
        Else
            var_neraca = 0
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Delete Confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_account(Trim(txt_acc_no.Text), Trim(txt_acc_name.Text), Trim(cbo_acc_group.Text), var_status_aktif, _
                var_header, var_income, var_neraca, Trim(txt_notes.Text), username, server_datetime(), server_datetime(), _
                username, var_def, Replace(txtsawal.Text, ",", ""))

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

    Private Sub cbo_acc_group_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_acc_group.LostFocus
        open_conn()
        Dim header As Integer
        If cbo_acc_type.Text = "Header" Then
            header = 1
        ElseIf cbo_acc_type.Text = "Detail" Then
            header = 0
        End If
        If insert = 1 Then
            If cbo_acc_group.Text <> "" Then
                Call select_control_acc(Trim(cbo_acc_group.Text), header)
                txt_acc_no.Text = no_account
            End If
        End If
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

    Private Sub chk_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_date.CheckedChanged
        open_conn()
        date_filter()
    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        txtPage2.Text = 1
        view_data(0, pageLoad)
    End Sub

    Private Sub cbo_search_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_search.LostFocus
        open_conn()
        check_combo()
    End Sub

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub reset_list()
        open_conn()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        tglakhir.Value = Now
        tglawal.Value = Now
        cbo_search.Text = "Account No"
        txt_search.Text = ""
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
        txtPage2.Text = 1
        view_data(0, pageLoad)
    End Sub

    Private Sub btn_save2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_COA_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_COA_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If Trim(cbo_acc_group.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih jenis akun!")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(txt_acc_no.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Error generate no akun!")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(txt_acc_name.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan nama akun!")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(cbo_def_balance.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih posisi default" & vbCrLf & "debet / kredit!")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(cbo_acc_type.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih jenis akun!")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        insert_data()
    End Sub

    Private Sub txtsawal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsawal.LostFocus
        open_conn()
        Dim var_temp As Double
        var_temp = Replace(txtsawal.Text, ",", "")
        txtsawal.Text = FormatNumber(var_temp, 0)
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            Dim i As Integer
            edit = 1
            insert = 0
            btn_delete.Enabled = True
            i = DataGridView1.CurrentCell.RowIndex
            detail(DataGridView1.Item(0, i).Value)
            TabControl1.SelectedTabPage = TabInput
            cbo_acc_group.Enabled = False
            txt_acc_no.Enabled = False
        End If
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    'Private Sub frmcoa_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column As Integer
    '    Dim Width_Table As Integer
    '    Dim selisih_col As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column
    '        .Columns(4).Width = .Columns(4).Width + selisih_col
    '    End With
    'End Sub

    Private Sub btn_delete_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_delete.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_delete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_delete.Cursor = Cursors.Default
    End Sub

    Private Sub btn_reset2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_reset2.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_reset2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_reset2.Cursor = Cursors.Default
    End Sub

    Private Sub btn_save2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_save2.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_save2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_save2.Cursor = Cursors.Default
    End Sub

    Private Sub btn_reset_cust_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reset_cust.MouseHover
        btn_reset_cust.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_reset_cust_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reset_cust.MouseLeave
        btn_reset_cust.Cursor = Cursors.Default
    End Sub

    Private Sub btn_cari_cust_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cari_cust.MouseHover
        btn_cari_cust.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_cari_cust_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cari_cust.MouseLeave
        btn_cari_cust.Cursor = Cursors.Default
    End Sub


    Private Sub cbo_purchase_no_LostFocus(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub btn_cetak23_MouseHover(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub btn_cetak23_MouseLeave(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub btn_cetak23_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub btn_reset_cust_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cbo_acc_group_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_acc_group.SelectedIndexChanged

    End Sub

    Private Sub cbo_acc_type_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbo_acc_type.SelectedIndexChanged
        If Trim(cbo_acc_type.Text) = "Header" Then
            txtsawal.Enabled = False
        ElseIf Trim(cbo_acc_type.Text) = "Detail" Then
            txtsawal.Enabled = True
        End If
    End Sub

    Private Sub btn_cetak2_Click(sender As System.Object, e As System.EventArgs) Handles btn_cetak2.Click
        Dim DisplayNota As New LapCOA
        With DisplayNota
            .Show()
            '  .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub rb_income_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_income.CheckedChanged
        cbo_gol.Items.Clear()
        If rb_income.Checked = True Then
            cbo_gol.Items.Add("Pendapatan")
            cbo_gol.Items.Add("HPP")
            cbo_gol.Items.Add("Biaya")
        End If
    End Sub

    Private Sub rb_neraca_CheckedChanged(sender As Object, e As System.EventArgs) Handles rb_neraca.CheckedChanged
        cbo_gol.Items.Clear()
        If rb_neraca.Checked = True Then
            cbo_gol.Items.Add("Aktiva")
            cbo_gol.Items.Add("Pasiva")
            cbo_gol.Items.Add("Modal")
        End If
    End Sub

    Private Sub cbo_gol_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_gol.SelectedIndexChanged
        If cbo_gol.Text = "ASET" Or cbo_gol.Text = "BIAYA LRA" Or cbo_gol.Text = "BIAYA LO" Or cbo_gol.Text = "BIAYA" Or cbo_gol.Text = "HPP" Then
            cbo_def_balance.Text = "Debet"
        Else
            cbo_def_balance.Text = "Kredit"
        End If
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_account"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_account"))
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
            view_data(pageIndex, pageLoad)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub GridControl_Click(sender As System.Object, e As System.EventArgs) Handles GridControl.Click

    End Sub
End Class