﻿Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Public Class frmkatbarang
    Dim insert As Integer
    Dim edit As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan As String
    Dim KodeKategori As String

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub frmkatbarang_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ' open_conn()
        '  Dim Rows As Integer
        ' Dim DT As DataTable
        'DT = jenis_barang("", 0)
        ' cbo_noakun.Items.Clear()
        'Rows = DT.Rows.Count - 1
        'For i = 0 To Rows
        ' cbo_noakun.Items.Add(DT.Rows(i).Item(0))
        ' Next
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LoadComboBox2_MtgcComboBoxItem()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_jenis()

        cbo_noakun.SelectedIndex = -1
        cbo_noakun.Items.Clear()
        cbo_noakun.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_noakun.SourceDataString = New String(1) {"mst_itemjenis_id", "mst_itemjenis_nm"}
        cbo_noakun.SourceDataTable = dtLoading
        cbo_noakun.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        cbo_noakun.GridLineVertical = True
        cbo_noakun.GridLineHorizontal = True
    End Sub

    Private Sub frmkatbarang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        'frmitem.Enabled = True
        'MainMenu.Enabled = True
        'If Application.OpenForms().OfType(Of frmitem).Any Then
        '    frmitem.Activate()
        '    '  frmitem.SimpleButton6_Click(sender, e)
        'Else
        MainMenu.Activate()
        ' End If
    End Sub


    Private Sub frmkatbarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        datagrid_layout()
        insert = 1
        edit = 0
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        btn_del2.Enabled = False
        Label5.Visible = True
        LoadComboBox2_MtgcComboBoxItem()
        var_bulan = Month(server_datetime())
        var_tahun = Year(server_datetime())
        Call insert_no_trans("MASTER_ITEM_KATEGORI", Month(server_datetime()), Year(server_datetime()))
        Call select_control_no("MASTER_ITEM_KATEGORI", "TRANS")
        txtkode.Text = no_master
        KodeKategori = no_master
        'GridList_Customer.OptionsView.ColumnAutoWidth = False
        view_data()
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        txt_disc.Text = 0
        txtket.Text = ""
        txtnama.Text = ""
        txtkode.Text = ""
        btn_del2.Enabled = False
        'cbo_noakun.Text = ""
        label5.Visible = False
        CheckBox1.Checked = False
        txtkode.Enabled = False
        txtkode.BackColor = Color.Lavender
        txtkode.ReadOnly = True
        CheckBox1.Enabled = True
        Call select_control_no("MASTER_ITEM_KATEGORI", "TRANS")
        txtkode.Text = no_master
        KodeKategori = no_master
    End Sub

    Public Sub insert_data()
        open_conn()
        If insert = 1 Then
            Call insert_itemcat(Trim(cbo_noakun.Text), Trim(txtkode.Text), Trim(txtnama.Text), Trim(txtket.Text), "INSERT", Replace(txt_disc.Text, ",", ""))
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(server_datetime(), "MASTER_ITEM_KATEGORI")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_itemcat(Trim(cbo_noakun.Text), Trim(txtkode.Text), Trim(txtnama.Text), Trim(txtket.Text), "UPDATE", Replace(txt_disc.Text, ",", ""))
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
        If Trim(txt_disc.Text) = "" Then
            txt_disc.Text = 0
        End If
        If insert = 1 Then
            If getTemplateAkses(username, "MN_ITEM_CAT_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_ITEM_CAT_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If Trim(txtnama.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan nama kategori")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        insert_data()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_ITEM_CAT_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Do you want to delete data?", "Delete", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_itemcat(Trim(cbo_noakun.Text), Trim(txtkode.Text), Trim(txtnama.Text), Trim(txtket.Text), "DELETE")
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

    Private Sub view_data()
        open_conn()
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_itemcat("", 0)
        GridControl.DataSource = DT
        GridList_Customer.Columns("mst_itemjenis_nm").Caption = "Jenis Barang"
        GridList_Customer.Columns("mst_itemjenis_nm").Width = 180
        GridList_Customer.Columns("mst_itemcat_id").Caption = "ID Kategori"
        GridList_Customer.Columns("mst_itemcat_id").Width = 120
        GridList_Customer.Columns("mst_itemcat_nm").Caption = "Kategori"
        GridList_Customer.Columns("mst_itemcat_nm").Width = 180
        GridList_Customer.Columns("description").Caption = "Keterangan"
        GridList_Customer.Columns("description").Width = 300
        GridList_Customer.Columns("discount").Caption = "Diskon Kategori Item"
        GridList_Customer.Columns("discount").Width = 120
        'GridList_Customer.BestFitColumns()

        'Rows = DT.Rows.Count - 1
        'DataGridView1.Rows.Clear()
        'For i = 0 To Rows
        '    DataGridView1.Rows.Add()
        '    DataGridView1.Item(0, i).Value = DT.Rows(i).Item(1)
        '    DataGridView1.Item(1, i).Value = DT.Rows(i).Item(2)
        '    DataGridView1.Item(2, i).Value = DT.Rows(i).Item(0)
        '    DataGridView1.Item(3, i).Value = DT.Rows(i).Item(4)
        '    DataGridView1.Item(4, i).Value = DT.Rows(i).Item(3)

        'Next
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        On Error Resume Next
        Dim DT As DataTable
        DT = select_itemcat(criteria, 1)
        insert = 0
        edit = 1
        txtkode.Text = DT.Rows(0).Item(2)
        txtnama.Text = DT.Rows(0).Item(3)
        txtket.Text = DT.Rows(0).Item(4)
        txt_disc.Text = DT.Rows(0).Item(5)
        label5.Text = DT.Rows(0).Item(1)
        cbo_noakun.Text = ""
        cbo_noakun.SelectedText = Trim(DT.Rows(0).Item(0).ToString)
        Label5.Visible = True
        label5.Text = DT.Rows(0).Item(1)
        CheckBox1.Enabled = False
        btn_del2.Enabled = True
    End Sub

    Private Sub txtket_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtket.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtkode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkode.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnama.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        insert = 0
        i = DataGridView1.CurrentCell.RowIndex
        detail(DataGridView1.Item(0, i).Value)
        TabControl1.SelectedTabPage = TabInput
        btn_del2.Enabled = True
        txtkode.Enabled = False
        edit = 1
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        If TabControl1.SelectedTabPage Is TabList Then
            view_data()
        End If
        'open_conn()
        'Dim Total_Width_Column As Integer
        'Dim Width_Table As Integer
        'Dim selisih_col As Integer

        'With DataGridView1
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(3).Width = .Columns(3).Width + selisih_col
        'End With
    End Sub

    Dim Def_Kode As String
    Dim Kode1, Kode2, Kode3 As String
    Private Sub default_code(ByVal criteria As String)
        open_conn()
        Def_Kode = Nothing
        If criteria.Length = 1 And Mid(criteria, 1, 1) <> " " Then
            Kode1 = (Mid(criteria, 1, 1)).ToUpper
        ElseIf criteria.Length = 2 And Mid(criteria, 2, 1) <> " " Then
            Kode2 = (Mid(criteria, 2, 1)).ToUpper
        ElseIf criteria.Length = 3 And Mid(criteria, 3, 1) <> " " Then
            Kode3 = (Mid(criteria, 3, 1)).ToUpper
        End If
        If criteria.Length = 0 Then
            Def_Kode = KodeKategori
        Else
            Def_Kode = Trim(Kode1 + Kode2 + Kode3 + "-" + KodeKategori)
        End If
    End Sub

    Private Sub txtnama_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnama.TextChanged
        open_conn()
        If insert = 1 And CheckBox1.Checked = False Then
            default_code(txtnama.Text)
            txtkode.Text = Def_Kode
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            insert = 0
            edit = 1
            i = DataGridView1.CurrentCell.RowIndex
            detail(DataGridView1.Item(0, i).Value)
            TabControl1.SelectedTabPage = TabInput
            btn_del2.Enabled = True
            txtkode.Enabled = False
        End If
    End Sub

    Private Sub cbo_noakun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_noakun.Click
        open_conn()
        cbo_noakun.DroppedDown = True
    End Sub

    Private Sub cbo_noakun_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_noakun.GotFocus
        
    End Sub

    Private Sub cbo_noakun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_noakun.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_noakun_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_noakun.LostFocus
        open_conn()
        cbo_noakun.DroppedDown = False
    End Sub

    Private Sub cbo_jenis_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_noakun.SelectedIndexChanged
        On Error Resume Next
        open_conn()
        Label5.Visible = True
        Label5.Text = cbo_noakun.SelectedItem.Col2
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmkatbarang_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        'open_conn()
        'Dim Total_Width_Column As Integer
        'Dim Width_Table As Integer
        'Dim selisih_col As Integer

        'With DataGridView1
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(4).Width = .Columns(4).Width + selisih_col
        'End With

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtkode.Enabled = True
            txtkode.ReadOnly = False
            txtkode.BackColor = Color.White
        ElseIf CheckBox1.Checked = False Then
            txtkode.Enabled = False
            txtkode.ReadOnly = True
            txtkode.BackColor = Color.Lavender
            Call select_control_no("MASTER_ITEM_KATEGORI", "TRANS")
            txtkode.Text = no_master
            KodeKategori = no_master
            default_code(Trim(txtnama.Text))
            txtkode.Text = Def_Kode
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

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
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
            view_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "mst_itemcat_id"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "mst_itemcat_id"))
        End If
    End Sub
End Class