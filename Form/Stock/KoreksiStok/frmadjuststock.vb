Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmadjuststock
    Dim insert As Integer
    Dim edit As Integer
    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Dim pesan As String
    Public NoBuktiKoreksi As String
    Dim IndexRowDg As Integer

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub frmadjuststock_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmadjuststock_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmadjuststock_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            '   Dim NewDisplayAcc As New frm_display_item
            frm_display_item.formsource_adjustitem = True
            frm_display_item.Show()
            ' MainMenu.Enabled = False
            '  Me.Enabled = False
        End If
    End Sub

    Private Sub frmadjuststock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        insert = 1
        edit = 0
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Dim Rows As Integer
        open_conn()
        Rows = select_warehouse.Rows.Count - 1
        Dim i As Integer
        For i = 0 To Rows
            cbo_warehouse.Items.Add(select_warehouse.Rows(i).Item(0))
        Next
        Call insert_no_trans("ADJUSTSTOCK", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("ADJUSTSTOCK", "TRANS")
        txt_no.Text = no_master
        DataGridView1.Item(0, 0).Value = 1
        cbo_search.Text = "Adjustment No"
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        btn_cetak.Enabled = False
        btn_del2.Enabled = False
        IndexRowDg = 1
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        view_data()
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
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = True
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(3).ReadOnly = False
            .Columns(4).ReadOnly = False
            .Columns(5).ReadOnly = False
            .Columns(6).ReadOnly = True
            .Columns(6).DefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim rows As Integer
        Dim TDebet As Double
        Dim TCredit As Double
        Dim var_nominal As Double
        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
            DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = 0
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Data Kosong")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        rows = DataGridView1.Rows.Count - 1
        Dim i As Integer
        For i = 0 To rows
            TDebet = TDebet + Replace(DataGridView1.Item(4, i).Value, ",", "")
            TCredit = TCredit + Replace(DataGridView1.Item(5, i).Value, ",", "")
        Next
        txt_positif.Text = FormatNumber(TDebet, 0)
        txt_negatif.Text = FormatNumber(TCredit, 0)
        'DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
        'DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = 0

        var_nominal = Replace(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, ",", "")
        DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(var_nominal, 0)

        var_nominal = Replace(DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value, ",", "")
        DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(var_nominal, 0)
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
        DataGridView1.Item(0, mRow).Value = mRow + 1
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        On Error Resume Next
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        i = DataGridView1.CurrentCell.ColumnIndex
        If i = 6 Then
            Dim NewDisplayAcc As New frm_display_unit
            NewDisplayAcc.formsource_adjustitem = True
            NewDisplayAcc.Show()
            '  NewDisplayAcc.MdiParent = MainMenu
            ' MainMenu.Enabled = False
            Me.Enabled = False
        End If
    End Sub

    Private Sub insert_data()
        open_conn()
        Dim var_nominal As Double
        Dim i As Integer
        If insert = 1 Then
            Call insert_adjust_stock(Trim(txt_no.Text), txt_date.Value, Trim(cbo_warehouse.Text), (Replace(txt_positif.Text, ",", "") - Replace(txt_negatif.Text, ",", "")), username, Format(server_datetime(), "yyyy-MM-dd"), _
                               Format(server_datetime(), "yyyy-MM-dd"), username, "", "", 0, 0, 0, 0, txt_command.Text, "")
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Or DataGridView1.Item(1, i).Value <> Nothing Then
                    If CInt(DataGridView1.Item(4, i).Value) > 0 And CInt(DataGridView1.Item(5, i).Value) <= 0 Then
                        var_nominal = CInt(DataGridView1.Item(4, i).Value)
                    ElseIf CInt(DataGridView1.Item(5, i).Value) > 0 And CInt(DataGridView1.Item(4, i).Value) <= 0 Then
                        var_nominal = -1 * CInt(DataGridView1.Item(5, i).Value)
                    Else
                        var_nominal = 0
                    End If
                    Call insert_adjust_stock(Trim(txt_no.Text), txt_date.Value, Trim(cbo_warehouse.Text), (Replace(txt_positif.Text, ",", "") - Replace(txt_negatif.Text, ",", "")), username, Format(server_datetime(), "yyyy-MM-dd"), _
                               Format(server_datetime(), "yyyy-MM-dd"), username, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, i, 1, "", DataGridView1.Item(6, i).Value)
                End If
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "ADJUSTSTOCK")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_adjust_stock(Trim(txt_no.Text), txt_date.Value, Trim(cbo_warehouse.Text), (Replace(txt_positif.Text, ",", "") - Replace(txt_negatif.Text, ",", "")), username, Format(server_datetime(), "yyyy-MM-dd"), _
                               Format(server_datetime(), "yyyy-MM-dd"), username, "", DataGridView1.Item(3, i).Value, 0, 0, 0, 0, txt_command.Text, "")
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Or DataGridView1.Item(1, i).Value <> Nothing Then
                    If CInt(DataGridView1.Item(4, i).Value) > 0 And CInt(DataGridView1.Item(5, i).Value) <= 0 Then
                        var_nominal = CInt(DataGridView1.Item(4, i).Value)
                    ElseIf CInt(DataGridView1.Item(5, i).Value) > 0 And CInt(DataGridView1.Item(4, i).Value) <= 0 Then
                        var_nominal = -1 * CInt(DataGridView1.Item(5, i).Value)
                    Else
                        var_nominal = 0
                    End If
                    Call update_adjust_stock(Trim(txt_no.Text), txt_date.Value, Trim(cbo_warehouse.Text), (Replace(txt_positif.Text, ",", "") - Replace(txt_negatif.Text, ",", "")), username, Format(server_datetime(), "yyyy-MM-dd"), _
                               Format(server_datetime(), "yyyy-MM-dd"), username, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, i, 1, "", DataGridView1.Item(6, i).Value)
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
        Call select_control_no("ADJUSTSTOCK", "TRANS")
        txt_no.Text = no_master
        With Me
            .cbo_warehouse.Text = ""
            .txt_negatif.Text = 0
            .txt_positif.Text = 0
            .txt_command.Text = ""
            For i = 0 To DataGridView1.Rows.Count - 2
                DataGridView1.Item(0, i).Value = ""
                DataGridView1.Item(1, i).Value = ""
                DataGridView1.Item(2, i).Value = ""
                DataGridView1.Item(3, i).Value = ""
                DataGridView1.Item(4, i).Value = 0
                DataGridView1.Item(5, i).Value = 0
                'DataGridView1.Rows.RemoveAt(i)
            Next
        End With
        btn_cetak.Enabled = False
        btn_del2.Enabled = False
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_STOCK_CORRECTION_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_STOCK_CORRECTION_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
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

        If Trim(cbo_warehouse.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih Gudang")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        If trial = True Then
            If get_count_data("trn_adjust_stock_head", "no_adjust_stock") > row_trial Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Batas untuk input versi trial telah habis, silahkan membeli produk ini")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        insert_data()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_STOCK_CORRECTION_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_adjust_stock(Trim(txt_no.Text), txt_date.Value, Trim(cbo_warehouse.Text), (Replace(txt_positif.Text, ",", "") - Replace(txt_negatif.Text, ",", "")), username, Format(server_datetime(), "yyyy-MM-dd"), _
                               Format(server_datetime(), "yyyy-MM-dd"), username, "", "", 0, 0, 0, 0, txt_command.Text, "")
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

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        edit = 1
        insert = 0
        Dim a As Integer
        btn_del2.Enabled = True
        btn_cetak.Enabled = True

        a = DataGridView2.CurrentCell.RowIndex
        detail(DataGridView2.Item(0, a).Value)
        TabControl1.SelectedTabPage = TabInput
    End Sub

    Public Sub detail(ByVal criteria As String)
        open_conn()
        edit = 1
        insert = 0
        ' Dim current_row As Integer
        Dim TDebet, TCredit As Integer
        'current_row = cbo_acc_group.SelectedIndex
        Dim DT As DataTable
        Dim rows As Integer
        Dim date_filter As Integer
        If chk_date.Checked = True Then
            date_filter = 1
        ElseIf chk_date.Checked = False Then
            date_filter = 0
        End If
        DT = select_view_adjuststock("no_adjust_stock", criteria, 1, date_filter, tglawal.Value, tglakhir.Value)
        rows = DT.Rows.Count - 1
        If DT.Rows.Count > 0 Then
            txt_no.Text = DT.Rows(0).Item("no_adjust_stock")
            txt_date.Value = DT.Rows(0).Item("date_trn")
            txt_command.Text = DT.Rows(0).Item("notes")
            cbo_warehouse.Text = DT.Rows(0).Item("id_warehouse")
            DataGridView1.Rows.Clear()
            Dim i As Integer
            For i = 0 To rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("description")
                DataGridView1.Item(4, i).Value = DT.Rows(i).Item("positive")
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item("negative")
                DataGridView1.Item(6, i).Value = DT.Rows(i).Item("id_unit")
                TDebet = TDebet + CInt(DataGridView1.Item(4, i).Value)
                TCredit = TCredit + CInt(DataGridView1.Item(5, i).Value)
            Next
            'DataGridView1.Rows.Remove(DataGridView1.Rows(i))
            txt_positif.Text = FormatNumber(TDebet, 0)
            txt_negatif.Text = FormatNumber(TCredit, 0)
        End If
        btn_cetak.Enabled = True
        btn_del2.Enabled = True
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
            'If cbo_search.Text = "Adjust No" Then
            Dim date_filter As Integer
            If chk_date.Checked = True Then
                date_filter = 1
            ElseIf chk_date.Checked = False Then
                date_filter = 0
            End If
            DT = select_view_adjuststock(cbo_search.Text, txt_search.Text, 0, date_filter, tglawal.Value, tglakhir.Value)            'ElseIf cbo_search.Text = "Date" Then
            '    DT = select_view_adjuststock(Trim(cbo_search.Text), Format(tglawal.Value, "yyyy-MM-dd"), 0)
            'End If
            GridControl.DataSource = DT
            GridList_Customer.Columns("no_adjust_stock").Caption = "No Koreksi Stok"
            GridList_Customer.Columns("no_adjust_stock").Width = 170
            GridList_Customer.Columns("warehouse_name").Caption = "Gudang"
            GridList_Customer.Columns("warehouse_name").Width = 150
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 250
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 95
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("total_adjust").Caption = "Total"
            GridList_Customer.Columns("total_adjust").Width = 170
            GridList_Customer.Columns("total_adjust").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("total_adjust").DisplayFormat.FormatString = "N0"
            ' GridList_Customer.BestFitColumns()
            'Rows = DT.Rows.Count - 1
            'open_conn()
            'DataGridView2.Rows.Clear()
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            '        DataGridView2.Item(2, i).Value = Format(DT.Rows(i).Item(2), "dd-MMM-yyyy")
            '        DataGridView2.Item(3, i).Value = DT.Rows(i).Item(3)
            '        DataGridView2.Item(4, i).Value = DT.Rows(i).Item(4)
            '        DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
            '    Next
            'End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        view_data()
        'Dim Total_Width_Column, Total_Width_Column2 As Integer
        'Dim Width_Table, Width_Table2 As Integer
        'Dim selisih_col, selisih_col2 As Integer

        'With DataGridView1
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(3).Width = .Columns(3).Width + selisih_col
        'End With
        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(4).Width = .Columns(4).Width + selisih_col2
        'End With

    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        open_conn()
        view_data()
    End Sub

    Private Sub cbo_search_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_search.SelectedIndexChanged
        open_conn()
        If cbo_search.Text = "Adjust No" Then
            tglawal.Visible = False
            txt_search.Visible = True
            view_data()
        ElseIf cbo_search.Text = "Date" Then
            tglawal.Visible = True
            txt_search.Visible = False
            tglawal.Value = Now
            view_data()
        End If
    End Sub

    Private Sub txt_date_search_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        view_data()
    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("ADJUSTSTOCK", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("ADJUSTSTOCK", "TRANS")
            txt_no.Text = no_master
        End If
    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
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
        cbo_search.Text = "Adjustment No"
        txt_search.Text = ""
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        Dim DisplayNota As New FormCtkKoreksi
        NoBuktiKoreksi = Trim(txt_no.Text)
        With DisplayNota
            .Show()
            '  .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Private Sub frmadjuststock_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(3).Width = .Columns(3).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(4).Width = .Columns(4).Width + selisih_col2
    '    End With

    'End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        On Error Resume Next
        open_conn()
        IndexRowDg = DataGridView1.CurrentCell.RowIndex

        If e.KeyCode = Keys.Delete Then
            pesan = MessageBox.Show("Data ingin di hapus?", "Konfirmasi", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                DataGridView1.Rows.RemoveAt(IndexRowDg)
            End If
        End If
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_adjust_stock"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_adjust_stock"))
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

    Private Sub frmadjuststock_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged

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