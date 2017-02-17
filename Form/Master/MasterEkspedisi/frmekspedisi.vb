Imports System.IO
Imports System.Text
Imports System.Drawing
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Public Class frmekspedisi
    Dim insert As Integer
    Dim edit As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan As String

    Dim Def_Kode As String
    Dim Kode1, Kode2, Kode3 As String

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

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

    Private Sub detail(ByVal criteria As String)
        open_conn()

        Dim DT As DataTable
        Dim var_chk As Integer
        If chk_date.Checked = True Then
            var_chk = 1
        Else
            var_chk = 0
        End If
        btn_del2.Enabled = True
        insert = 0
        edit = 1
        DT = select_expedition("id_expedition", criteria, 1, 0, tglawal.Value, tglakhir.Value)
        If DT.Rows.Count > 0 Then
            txt_serviceid.Text = DT.Rows(0).Item("id_expedition")
            txt_servicenm.Text = DT.Rows(0).Item("expedition_name")
            txt_price.Text = FormatNumber(DT.Rows(0).Item("expedition_rate"), 0)
            txt_qty.Text = FormatNumber(DT.Rows(0).Item("qty_perunit"), 0)
            txt_notes.Text = DT.Rows(0).Item("notes")
            txt_from_kota.Text = DT.Rows(0).Item("from_city")
            txt_to_kota.Text = DT.Rows(0).Item("to_city")
            txt_state.Text = DT.Rows(0).Item("to_provinsi")
            txt_kecamatan.Text = DT.Rows(0).Item("to_kecamatan")
        End If
    End Sub
    Private Sub datagrid_layout()

        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        End With
    End Sub

    Private Sub frmekspedisi_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmservice_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        insert = 1
        edit = 0
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        btn_del2.Enabled = False
        cbo_search.Text = "ID Ekspedisi"
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        txt_junior_comm.Text = 0
        txt_senior_comm.Text = 0
        txt_price.Text = 0
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False

        chk_code.Checked = False
        datagrid_layout()
        fillComboBox()
        '  GridList_Customer.OptionsView.ColumnAutoWidth = False
        view_data()
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_EXPEDITION_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_EXPEDITION_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
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
            Call insert_expedition(Trim(txt_serviceid.Text), Trim(txt_servicenm.Text), Replace(txt_price.Text, ",", ""), Trim(txt_from_kota.Text), Trim(txt_to_kota.Text), Replace(txt_qty.Text, ",", ""), _
                 txt_notes.Text, username, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, "INSERT", txt_state.Text, txt_kecamatan.Text)
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(server_datetime(), "MASTER_EXPEDITION")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_expedition(Trim(txt_serviceid.Text), Trim(txt_servicenm.Text), Replace(txt_price.Text, ",", ""), Trim(txt_from_kota.Text), Trim(txt_to_kota.Text), Replace(txt_qty.Text, ",", ""), _
                 txt_notes.Text, username, server_datetime(), server_datetime(), username, "UPDATE", txt_state.Text, txt_kecamatan.Text)
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
        With Me
            insert = 1
            edit = 0
            .txt_serviceid.Text = ""
            .txt_servicenm.Text = ""
            .txt_qty.Text = 0
            .txt_price.Text = 0
            .txt_notes.Text = ""
            .txt_from_kota.Text = ""
            .txt_to_kota.Text = ""
            .txt_state.Text = ""
            .txt_kecamatan.Text = ""
            .btn_del2.Enabled = False
        End With
        If insert = 1 And chk_code.Checked = False Then
            var_bulan = Month(server_datetime())
            var_tahun = Year(server_datetime())
            Call insert_no_trans("MASTER_EXPEDITION", Month(server_datetime()), Year(server_datetime()))
            Call select_control_no("MASTER_EXPEDITION", "TRANS")
            txt_serviceid.Text = no_master
        End If
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        edit = 1
        insert = 0
        i = DataGridView2.CurrentCell.RowIndex
        detail(DataGridView2.Item(0, i).Value)
        TabControl1.SelectedTabPage = TabInput
        btn_del2.Enabled = True
    End Sub

    Private Sub txt_itemid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_serviceid.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_itemname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_servicenm.KeyPress
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
        ' MainMenu.Enabled = False
        Me.Enabled = False
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
        DT = select_expedition(Trim(cbo_search.Text), Trim(txt_search.Text), 0, var_chk, tglawal.Value, tglakhir.Value)
        GridControl.DataSource = DT
        GridList_Customer.Columns("id_expedition").Caption = "ID Ekspedisi"
        GridList_Customer.Columns("id_expedition").Width = 150
        GridList_Customer.Columns("expedition_name").Caption = "Ekspedisi"
        GridList_Customer.Columns("expedition_name").Width = 200
        GridList_Customer.Columns("from_city").Caption = "Kota Pengiriman"
        GridList_Customer.Columns("from_city").Width = 180
        GridList_Customer.Columns("to_city").Caption = "Kota Tujuan"
        GridList_Customer.Columns("to_city").Width = 180
        GridList_Customer.Columns("expedition_rate").Caption = "Rate"
        GridList_Customer.Columns("expedition_rate").Width = 100
        GridList_Customer.Columns("expedition_rate").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridList_Customer.Columns("expedition_rate").DisplayFormat.FormatString = "N0"
        GridList_Customer.Columns("qty_perunit").Caption = "Qty/Unit"
        GridList_Customer.Columns("qty_perunit").Width = 100

        'Rows = DT.Rows.Count - 1
        'DataGridView2.Rows.Clear()
        'For i = 0 To Rows
        '    DataGridView2.Rows.Add()
        '    DataGridView2.Item(0, i).Value = DT.Rows(i).Item("id_expedition")
        '    DataGridView2.Item(1, i).Value = DT.Rows(i).Item("expedition_name")
        '    DataGridView2.Item(2, i).Value = DT.Rows(i).Item("from_city")
        '    DataGridView2.Item(3, i).Value = DT.Rows(i).Item("to_city")
        '    DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("expedition_rate"), 0)
        '    DataGridView2.Item(5, i).Value = DT.Rows(i).Item("qty_perunit")
        'Next
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub


    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_expedition"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_expedition"))
        End If
    End Sub

    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_EXPEDITION") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If


        If edit = 1 Then
            pesan = MessageBox.Show("Hapus Data?", "Cek Kevaliditasan Data", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_expedition(Trim(txt_serviceid.Text), Trim(txt_servicenm.Text), Replace(txt_price.Text, ",", ""), Trim(txt_from_kota.Text), Trim(txt_to_kota.Text), Replace(txt_qty.Text, ",", ""), _
                 txt_notes.Text, username, server_datetime(), server_datetime(), username, "DELETE", txt_state.Text, txt_kecamatan.Text)
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
        cbo_search.Text = "ID Ekspedisi"
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

    Private Sub txt_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_price.KeyPress
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

    Private Sub txt_servicenm_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_servicenm.TextChanged

    End Sub

    Private Sub cbo_acc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabList_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_code.CheckedChanged
        If chk_code.Checked = True Then
            If insert = 1 Then
                txt_serviceid.Enabled = True
                txt_serviceid.ReadOnly = False
                txt_serviceid.BackColor = Color.White
            End If
        ElseIf chk_code.Checked = False Then
            txt_serviceid.Enabled = False
            txt_serviceid.ReadOnly = True
            txt_serviceid.BackColor = Color.Lavender
        End If
        If insert = 1 And chk_code.Checked = False Then
            var_bulan = Month(server_datetime())
            var_tahun = Year(server_datetime())
            Call insert_no_trans("MASTER_EXPEDITION", Month(server_datetime()), Year(server_datetime()))
            Call select_control_no("MASTER_EXPEDITION", "TRANS")
            txt_serviceid.Text = no_master
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

    Private Sub lookup_kota1_EditValueChanged(sender As Object, e As System.EventArgs) Handles lookup_kota1.EditValueChanged
        Dim row As DataRowView
        row = TryCast(lookup_kota1.Properties.GetRowByKeyValue(lookup_kota1.EditValue), DataRowView)
        txt_from_kota.Text = row.Item("city_name")
        lookup_kota1.Visible = False
    End Sub

    Private Sub Lookup_Kota2_EditValueChanged(sender As Object, e As System.EventArgs) Handles Lookup_Kota2.EditValueChanged
        Dim row As DataRowView
        row = TryCast(Lookup_Kota2.Properties.GetRowByKeyValue(Lookup_Kota2.EditValue), DataRowView)
        txt_to_kota.Text = row.Item("city_name")
        Lookup_Kota2.Visible = False
        lookup_state.Properties.DataSource = getComboState(row.Item("city_code"))
        lookup_state.Properties.DisplayMember = "state_name"
        lookup_state.Properties.ValueMember = "state_code"
        lookup_state.Properties.PopulateViewColumns()
        lookup_state.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lookup_state.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub txt_to_kota_GotFocus(sender As Object, e As System.EventArgs) Handles txt_to_kota.GotFocus
        Lookup_Kota2.Width = txt_to_kota.Width
        Lookup_Kota2.Top = txt_to_kota.Top
        Lookup_Kota2.Left = txt_to_kota.Left
        'fillComboBox2()
        Lookup_Kota2.Visible = True
    End Sub

    Private Sub txt_from_kota_GotFocus(sender As Object, e As System.EventArgs) Handles txt_from_kota.GotFocus
        lookup_kota1.Width = txt_from_kota.Width
        lookup_kota1.Top = txt_from_kota.Top
        lookup_kota1.Left = txt_from_kota.Left
        'fillComboBox2()
        lookup_kota1.Visible = True
    End Sub

    Private Sub fillcombobox2()
        Dim DT As DataTable
        DT = getComboCityAll()
        Lookup_Kota2.Properties.DataSource = DT
        Lookup_Kota2.Properties.DisplayMember = "city_name"
        Lookup_Kota2.Properties.ValueMember = "city_code"
        Lookup_Kota2.Properties.PopulateViewColumns()
        Lookup_Kota2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Lookup_Kota2.Properties.View.OptionsView.ShowAutoFilterRow = True
        Lookup_Kota2.Properties.View.Columns("city_code").Caption = "Kode"
        Lookup_Kota2.Properties.View.Columns("city_name").Caption = "Kota"
    End Sub

    Private Sub fillComboBox()
        Dim DT As DataTable
        DT = getComboCityAll()
        lookup_kota1.Properties.DataSource = DT
        lookup_kota1.Properties.DisplayMember = "city_name"
        lookup_kota1.Properties.ValueMember = "city_code"
        lookup_kota1.Properties.PopulateViewColumns()
        lookup_kota1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lookup_kota1.Properties.View.OptionsView.ShowAutoFilterRow = True
        lookup_kota1.Properties.View.Columns("city_code").Caption = "Kode"
        lookup_kota1.Properties.View.Columns("city_name").Caption = "Kota"

        
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
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

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl3.Visible = True
        disableMain()
        clean()
    End Sub

    Private Sub txt_price_LostFocus(sender As Object, e As System.EventArgs) Handles txt_price.LostFocus
        txt_price.Text = FormatNumber(txt_price.Text, 0)
    End Sub

    Private Sub lookup_state_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lookup_state.EditValueChanged
        Dim row As DataRowView
        row = TryCast(lookup_state.Properties.GetRowByKeyValue(lookup_state.EditValue), DataRowView)
        txt_state.Text = row.Item("state_name")
        Lookup_Kota2.Properties.DataSource = getComboCity(row.Item("state_code"))
        Lookup_Kota2.Properties.DisplayMember = "city_name"
        Lookup_Kota2.Properties.ValueMember = "city_code"
        Lookup_Kota2.Properties.PopulateViewColumns()
        Lookup_Kota2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Lookup_Kota2.Properties.View.OptionsView.ShowAutoFilterRow = True
        lookup_state.Visible = False
    End Sub

    Private Sub txt_state_GotFocus(sender As Object, e As System.EventArgs) Handles txt_state.GotFocus
        lookup_state.Width = txt_state.Width
        lookup_state.Top = txt_state.Top
        lookup_state.Left = txt_state.Left
        'fillComboBox1()
        lookup_state.Visible = True
        lookup_state.BringToFront()
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        fillcombobox2()
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        lookup_state.Properties.DataSource = getComboStateAll()
        lookup_state.Properties.DisplayMember = "state_name"
        lookup_state.Properties.ValueMember = "state_code"
        lookup_state.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lookup_state.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub
End Class