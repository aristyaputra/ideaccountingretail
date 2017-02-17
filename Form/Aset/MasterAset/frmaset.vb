Imports System.IO
Imports System.Text
Imports System.Drawing
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmaset
    Dim insert As Integer
    Dim edit As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan As String
    Dim Def_Kode As String
    Dim Kode1, Kode2, Kode3 As String
    Private Sub default_code(ByVal criteria As String)
        Def_Kode = Nothing
        If criteria.Length = 1 Then
            Kode1 = (Mid(criteria, 1, 1)).ToUpper
        ElseIf criteria.Length = 2 Then
            Kode2 = EnkripsiID(Mid(criteria, 2, 1))
        ElseIf criteria.Length = 3 Then
            Kode3 = EnkripsiID(Mid(criteria, 3, 1))
        End If
        If criteria.Length = 0 Then
            Def_Kode = ""
        Else
            Def_Kode = Trim(Kode1 + Kode2 + Kode3 + EnkripsiID(CStr(CInt(Format(Now, "dd")))) + (Format(Now, "mm")) + (Format(Now, "ss")))
        End If
    End Sub

    Private Sub LoadComboBox2_MtgcComboBoxGol()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_golaset()

        cbo_gol_aset.SelectedIndex = -1
        cbo_gol_aset.Items.Clear()
        cbo_gol_aset.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_gol_aset.SourceDataString = New String(1) {"id_golongan", "type"}
        cbo_gol_aset.SourceDataTable = dtLoading
        cbo_gol_aset.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        cbo_gol_aset.GridLineVertical = True
        cbo_gol_aset.GridLineHorizontal = True
    End Sub

    Private Sub LoadComboBox2_MtgcComboBoxDep()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_list_depart()

        cbo_depart.SelectedIndex = -1
        cbo_depart.Items.Clear()
        cbo_depart.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_depart.SourceDataString = New String(1) {"department_id", "department_name"}
        cbo_depart.SourceDataTable = dtLoading
        cbo_depart.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        cbo_depart.GridLineVertical = True
        cbo_depart.GridLineHorizontal = True
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        edit = 1
        insert = 0
        Dim current_row As Integer
        current_row = DataGridView2.CurrentCell.RowIndex
        Dim DT As DataTable
        Dim var_chk As Integer
        If chk_date.Checked = True Then
            var_chk = 1
        Else
            var_chk = 0
        End If
        DT = select_aset("id_aset", criteria, 1, 0, tglawal.Value, tglakhir.Value)
        If DT.Rows.Count > 0 Then
            txt_kode_aset.Text = DT.Rows(0).Item("id_aset")
            txt_nm_aset.Text = DT.Rows(0).Item("nama")
            ' cbo_gol_aset.Text = DT.Rows(0).Item("id_golongan")
            cbo_gol_aset.SelectedText = DT.Rows(0).Item("id_golongan")
            lbl_nm_gol.Text = DT.Rows(0).Item("type")
            txt_price.Text = FormatNumber(DT.Rows(0).Item("nilai_perolehan"), 0)
            txt_date.Value = Format(DT.Rows(0).Item("tanggal_perolehan"), "dd-MMM-yyyy")
            txt_notes.Text = DT.Rows(0).Item("notes")
            txt_nilai_buku.Text = FormatNumber(DT.Rows(0).Item("sawal_nilai_buku"), 0)
            lbl_nm_depart.Text = DT.Rows(0).Item("department_name")
            cbo_depart.SelectedText = DT.Rows(0).Item("id_department")
        End If
        btn_del2.Enabled = True
    End Sub
    Private Sub datagrid_layout()

        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub frmaset_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmservice_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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

    Private Sub frmitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        insert = 1
        edit = 0
        btn_del2.Enabled = False
        cbo_search.Text = "ID Aset"
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'txt_junior_comm.Text = 0
        'txt_senior_comm.Text = 0
        txt_price.Text = 0
        txt_nilai_buku.Text = 0
        cbo_gol_aset.Text = ""
        lbl_nm_gol.Text = ""
        txt_nm_aset.Text = ""
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False

        LoadComboBox2_MtgcComboBoxGol()
        LoadComboBox2_MtgcComboBoxDep()
        chk_code.Checked = False
        datagrid_layout()
        view_data()
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_NAMA_ASET_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses tambah aset!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_NAMA_ASET_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses edit aset!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If Replace(txt_nilai_buku.Text, ",", "") <> cek_nilaibuku_aset(Trim(cbo_gol_aset.Text), Replace(txt_price.Text, ",", ""), Format(txt_date.Value, "yyyy-MM-dd")) Then
            MsgBox("Nilai Buku yang di input tidak sama dengan simulasi perhitungan aset " & vbCrLf & "Lihat simulasi", MsgBoxStyle.Information, "Informasi")
            Dim frm As New frmsimulasiaset
            frm.lbl_golongan.Text = Trim(lbl_nm_gol.Text)
            frm.lbl_nm_aset.Text = Trim(txt_nm_aset.Text)
            frm.gol_aset = Trim(cbo_gol_aset.Text)
            frm.nilai_perolehan = Replace(txt_price.Text, ",", "")
            frm.tgl_perolehan = Format(txt_date.Value, "yyyy-MM-dd")
            frm.nilai_buku = Replace(txt_nilai_buku.Text, ",", "")
            frm.Show()
            Me.Enabled = False
            Exit Sub
        End If

        'If trial = True Then
        '    If get_count_data("mst_service", "id_service") > row_trial Then
        '        MsgBox("You have reached the limit of data usage, Please Buy This Product", MsgBoxStyle.Information, "Validation")
        '        Exit Sub
        '    End If
        'End If
        insert_data()
    End Sub

    Public Sub insert_data()
        open_conn()
        If insert = 1 Then
            Call insert_aset(Trim(txt_kode_aset.Text), Trim(cbo_gol_aset.Text), Replace(txt_nm_aset.Text, ",", ""), Trim(txt_notes.Text), txt_date.Value, Replace(txt_price.Text, ",", ""), _
                 Replace(txt_nilai_buku.Text, ",", ""), Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, username, "INSERT", cbo_depart.Text)
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(server_datetime(), "MASTER_ASET")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_aset(Trim(txt_kode_aset.Text), Trim(cbo_gol_aset.Text), Replace(txt_nm_aset.Text, ",", ""), Trim(txt_notes.Text), txt_date.Value, Replace(txt_price.Text, ",", ""), _
                 Replace(txt_nilai_buku.Text, ",", ""), Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, username, "UPDATE", cbo_depart.Text)
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_success.Show(Me, info)
            End If
        End If
    End Sub

    Private Sub clean()
        open_conn()
        With Me
            insert = 1
            edit = 0
            .txt_kode_aset.Text = ""
            .txt_nm_aset.Text = ""
            .txt_price.Text = 0
            .txt_nilai_buku.Text = 0
            .txt_notes.Text = ""
            .cbo_gol_aset.SelectedText = ""
            .cbo_gol_aset.Text = ""
            .cbo_depart.SelectedText = ""
            .cbo_depart.Text = ""
            .lbl_nm_gol.Text = ""
            .lbl_nm_depart.Text = ""
            .btn_del2.Enabled = False
        End With
        If insert = 1 And chk_code.Checked = False Then
            var_bulan = Month(server_datetime())
            var_tahun = Year(server_datetime())
            Call insert_no_trans("MASTER_ASET", Month(server_datetime()), Year(server_datetime()))
            Call select_control_no("MASTER_ASET", "TRANS")
            txt_kode_aset.Text = no_master
        End If
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        edit = 1
        insert = 0
        i = DataGridView2.CurrentCell.RowIndex
        detail(DataGridView2.Item(0, i).Value)
        TabControl1.SelectedTabpage = TabInput
        btn_del2.Enabled = True
    End Sub

    Private Sub txt_itemid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kode_aset.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_itemname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nm_aset.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_acc_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim FrmAccount As New frm_display_acc_detail
        open_conn()
        FrmAccount.formsource_service = True
        FrmAccount.Show()
        'FrmAccount.MdiParent = MainMenu
        'FrmAccount.WindowState = FormWindowState.Maximized
        '  ' MainMenu.Enabled = False
        '  Me.Enabled = False
    End Sub

    'Private Sub cbo_acc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_acc.GotFocus
    '    open_conn()
    '    If param_focus = 0 Then
    '        Dim FrmAccount As New frm_display_acc_detail
    '        FrmAccount.Show()
    '        FrmAccount.formsource_service = True
    '        ' MainMenu.Enabled = False
    '        param_focus = 1
    '    Else
    '        param_focus = 0
    '    End If
    'End Sub

    Private Sub cbo_acc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        If TabControl1.SelectedTabPage Is TabList Then
            view_data()
        End If
        open_conn()
        Dim Total_Width_Column As Integer
        Dim Width_Table As Integer
        Dim selisih_col As Integer

        With DataGridView2
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(1).Width = .Columns(1).Width + selisih_col
        End With
    End Sub

    Private Sub view_data()
        open_conn()
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        Dim var_chk As Integer
        If chk_date.Checked = True Then
            var_chk = 1
        Else
            var_chk = 0
        End If

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            DT = select_aset(Trim(cbo_search.Text), Trim(txt_search.Text), 0, var_chk, tglawal.Value, tglakhir.Value)
            GridControl.DataSource = DT
            GridList_Customer.Columns("id_golongan").Caption = "ID Golongan"
            GridList_Customer.Columns("id_aset").Caption = "ID Aset"
            GridList_Customer.Columns("type").Caption = "Golongan"
            GridList_Customer.Columns("nama").Caption = "Nama"
            GridList_Customer.Columns("notes").Visible = False
            GridList_Customer.Columns("tanggal_perolehan").Caption = "Tgl Perolehan"
            GridList_Customer.Columns("nilai_perolehan").Caption = "Nilai Perolehan"
            GridList_Customer.Columns("nilai_perolehan").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("nilai_perolehan").DisplayFormat.FormatString = "N2"
            GridList_Customer.Columns("sawal_nilai_buku").Visible = False
            GridList_Customer.Columns("created_date").Visible = False
            GridList_Customer.Columns("created_user").Visible = False
            GridList_Customer.Columns("modified_date").Visible = False
            GridList_Customer.Columns("modified_user").Visible = False
            GridList_Customer.BestFitColumns()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_NAMA_ASET_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses hapus aset!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If


        If edit = 1 Then
            pesan = MessageBox.Show("Hapus Data?", "Cek Kevaliditasan Data", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_aset(Trim(txt_kode_aset.Text), Trim(cbo_gol_aset.Text), Replace(txt_nm_aset.Text, ",", ""), Trim(txt_notes.Text), txt_date.Value, Replace(txt_price.Text, ",", ""), _
                Replace(txt_nilai_buku.Text, ",", ""), Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, username, "DELETE", cbo_depart.Text)
                If param_sukses = True Then
                    Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                    alertControl_success.Show(Me, info)
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
        cbo_search.Text = "ID Aset"
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

    Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            edit = 1
            insert = 0
            i = DataGridView2.CurrentCell.RowIndex
            detail(DataGridView2.Item(0, i).Value)
            TabControl1.SelectedTabPage = TabInput
            btn_del2.Enabled = True
        End If
    End Sub

    Private Sub txt_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_senior_comm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_junior_comm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub TabInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub frmservice_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        open_conn()
        Dim Total_Width_Column As Integer
        Dim Width_Table As Integer
        Dim selisih_col As Integer

        With DataGridView2
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(1).Width = .Columns(1).Width + selisih_col
        End With

    End Sub

    Private Sub txt_servicenm_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nm_aset.TextChanged

    End Sub

    Private Sub cbo_acc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabList_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_code.CheckedChanged
        If chk_code.Checked = True Then
            If insert = 1 Then
                txt_kode_aset.Enabled = True
                txt_kode_aset.ReadOnly = False
                txt_kode_aset.BackColor = Color.White
            End If
        ElseIf chk_code.Checked = False Then
            txt_kode_aset.Enabled = False
            txt_kode_aset.ReadOnly = True
            txt_kode_aset.BackColor = Color.Lavender
        End If
        If insert = 1 And chk_code.Checked = False Then
            var_bulan = Month(server_datetime())
            var_tahun = Year(server_datetime())
            Call insert_no_trans("MASTER_ASET", Month(server_datetime()), Year(server_datetime()))
            Call select_control_no("MASTER_ASET", "TRANS")
            txt_kode_aset.Text = no_master
        End If
    End Sub

    Private Sub cbo_noakun_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_gol_aset.SelectedIndexChanged
        On Error Resume Next
        open_conn()
        lbl_nm_gol.Text = cbo_gol_aset.SelectedItem.Col2
    End Sub

    Private Sub MtgcComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_akun.SelectedIndexChanged

    End Sub

    Private Sub NavBarControl9_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cbo_depart_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbo_depart.SelectedIndexChanged
        On Error Resume Next
        open_conn()
        lbl_nm_depart.Text = cbo_depart.SelectedItem.Col2
    End Sub

    Private Sub txt_price_LostFocus(sender As Object, e As System.EventArgs) Handles txt_price.LostFocus
        If IsNumeric(txt_price.Text) = False Then
            txt_price.Text = 0
        Else
            txt_price.Text = FormatNumber(txt_price.Text, 0)
        End If
    End Sub

    Private Sub txt_price_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_price.TextChanged

    End Sub

    Private Sub txt_nilai_buku_LostFocus(sender As Object, e As System.EventArgs) Handles txt_nilai_buku.LostFocus
        If IsNumeric(txt_nilai_buku.Text) = False Then
            txt_nilai_buku.Text = 0
        Else
            txt_nilai_buku.Text = FormatNumber(txt_nilai_buku.Text, 0)
            
        End If
    End Sub

    Private Sub txt_nilai_buku_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_nilai_buku.TextChanged

    End Sub

    Private Sub txt_kode_aset_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_kode_aset.TextChanged

    End Sub

    Private Sub txt_date_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_date.ValueChanged

    End Sub

    Private Sub txt_notes_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_notes.TextChanged

    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_aset"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_aset"))
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
End Class