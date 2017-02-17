Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmstockopname

    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Public NoOpname As String

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_warehouse.SelectedIndexChanged
        open_conn()
        If edit <> 1 Then
            Dim DTA As DataTable
            Dim var_code As String
            var_code = cbo_warehouse.SelectedItem
            DTA = select_warehouse_list(var_code, 1)
            Label7.Visible = True
            Label7.Text = DTA.Rows(0).Item(1).ToString

            Dim Rows As Integer
            Dim DT As DataTable
            DT = select_stock_opname(Trim(cbo_warehouse.Text))
            Rows = DT.Rows.Count - 1
            DataGridView1.Rows.Clear()

            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = DT.Rows(i).Item("id_item")
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("item_name")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("main_unit")
                DataGridView1.Item(3, i).Value = FormatNumber(0, 0)
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("balance"), 0)
            Next
        End If
    End Sub

    Private Sub frmstockopname_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_warehouse_list("", 0)
        cbo_warehouse.Items.Clear()
        Rows = DT.Rows.Count - 1
        For i = 0 To Rows
            cbo_warehouse.Items.Add(DT.Rows(i).Item(0))
        Next
    End Sub

    Private Sub frmstockopname_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmstockopname_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu

        insert = 1
        edit = 0
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Dim Rows As Integer
        Rows = select_warehouse.Rows.Count - 1
        cbo_warehouse.Items.Clear()
        For i = 0 To Rows
            cbo_warehouse.Items.Add(select_warehouse.Rows(i).Item(0))
        Next
        Call insert_no_trans("OPNAME", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("OPNAME", "TRANS")
        txt_no.Text = no_master
        DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        cbo_search.Text = "Stock Opname No"
        datagrid_layout()
        Label7.Visible = False
        btn_cetak.Enabled = False
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

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            '.RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(3).DefaultCellStyle.BackColor = Color.White
            .Columns(4).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(5).DefaultCellStyle.BackColor = Color.White
        End With
        With DataGridView3
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        End With
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_STOCK_OPNAME_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_STOCK_OPNAME_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim a As Integer
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Item(0, i).Value <> "" Or DataGridView1.Item(0, i).Value <> Nothing Then
                a = a + 1
            End If
        Next

        If a = 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Data Kosong")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If


        insert_data()
    End Sub

    Private Sub insert_data()
        open_conn()
        If insert = 1 Then
            Call insert_stockopname(Trim(txt_no.Text), txt_date.Value, Trim(cbo_warehouse.Text), "", "", _
                                0, 0, "", 0)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(0, i).Value <> "" Or DataGridView1.Item(0, i).Value <> Nothing Then
                    Call insert_stockopname(Trim(txt_no.Text), txt_date.Value, Trim(cbo_warehouse.Text), DataGridView1.Item(0, i).Value, DataGridView1.Item(2, i).Value, _
                                DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, 1)
                End If
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "OPNAME")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_stockopname(Trim(txt_no.Text), txt_date.Value, Trim(cbo_warehouse.Text), "", "", _
                                0, 0, "", 0)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(0, i).Value <> "" Or DataGridView1.Item(0, i).Value <> Nothing Then
                    Call update_stockopname(Trim(txt_no.Text), txt_date.Value, Trim(cbo_warehouse.Text), DataGridView1.Item(0, i).Value, DataGridView1.Item(2, i).Value, _
                                DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, 1)
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
        insert = 1
        edit = 0

        With Me
            .txt_date.Value = Now
            .cbo_warehouse.Text = ""
            .DataGridView1.Rows.Clear()
        End With
        Call select_control_no("OPNAME", "TRANS")
        txt_no.Text = no_master
        txt_date.Value = Now
        Label7.Visible = False
        cbo_warehouse.Enabled = True
        btn_cetak.Enabled = False
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim balance As Double
        Dim mRow As Integer
        mRow = DataGridView1.CurrentCell.RowIndex
        balance = DataGridView1.Item(4, mRow).Value
        DataGridView1.Item(4, mRow).Value = FormatNumber(balance, 0)

    End Sub

    Private Sub view_data()
        open_conn()
        ' If TabControl1.SelectedTabPage Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim Rows As Integer
            Dim DT As DataTable
            Dim var_chk As Integer
            If chk_date.Checked = True Then
                var_chk = 1
            ElseIf chk_date.Checked = False Then
                var_chk = 0
            End If
            DT = select_list_opname(Trim(cbo_search.Text), Trim(txt_search.Text), 0, var_chk, tglawal.Value, tglakhir.Value)
            GridControl.DataSource = DT
            GridList_Customer.Columns("no_opname").Caption = "No Stock Opname"
            GridList_Customer.Columns("no_opname").Width = 170
            GridList_Customer.Columns("id_warehouse").Caption = "Gudang"
            GridList_Customer.Columns("id_warehouse").Width = 150
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 95
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("balance").Caption = "Qty On Hand"
            GridList_Customer.Columns("balance").Width = 150
            GridList_Customer.Columns("balance").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("balance").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("opname").Caption = "Qty Opname"
            GridList_Customer.Columns("opname").Width = 150
            GridList_Customer.Columns("opname").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("opname").DisplayFormat.FormatString = "N0"
            'GridList_Customer.BestFitColumns()
            'Rows = DT.Rows.Count - 1

            'DataGridView3.Rows.Clear()
            'If DT.Rows.Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView3.Rows.Add()
            '        DataGridView3.Item(0, i).Value = DT.Rows(i).Item("no_opname")
            '        If DT.Rows(i).Item("date_trn").ToString <> "" Then DataGridView3.Item(1, i).Value = Format(DT.Rows(i).Item("date_trn"), "dd-MMM-yyyy")
            '        DataGridView3.Item(2, i).Value = DT.Rows(i).Item("id_warehouse")
            '        DataGridView3.Item(3, i).Value = DT.Rows(i).Item("balance")
            '        DataGridView3.Item(4, i).Value = DT.Rows(i).Item("opname")
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
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(5).Width = .Columns(5).Width + selisih_col
        'End With
        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(0).Width = .Columns(0).Width + selisih_col2
        'End With
    End Sub

    Private Sub DataGridView3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.DoubleClick
        open_conn()
        edit = 1
        insert = 0
        Dim nobukti As String
        Dim mRow As Integer
        TabControl1.SelectedTabPage = TabInput
        mRow = DataGridView3.CurrentCell.RowIndex
        nobukti = DataGridView3.Item(0, mRow).Value
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_view_opname(DataGridView3.Item(0, mRow).Value)
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = DT.Rows(i).Item("id_item")
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item("item_name")
            DataGridView1.Item(2, i).Value = DT.Rows(i).Item("id_unit")
            DataGridView1.Item(3, i).Value = DT.Rows(i).Item("qty_onhand")
            DataGridView1.Item(4, i).Value = DT.Rows(i).Item("qty_opname")
            DataGridView1.Item(5, i).Value = DT.Rows(i).Item("notes")
        Next
        txt_date.Value = DT.Rows(0).Item("date_trn")
        txt_no.Text = DT.Rows(0).Item("no_opname")
        cbo_warehouse.Text = DT.Rows(0).Item("id_warehouse")
        cbo_warehouse.Enabled = False
        btn_cetak.Enabled = True

    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("OPNAME", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("OPNAME", "TRANS")
            txt_no.Text = no_master
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
        cbo_search.Text = "Stock Opname No"
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

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        Dim DisplayNota As New FormCtkOpname
        NoOpname = Trim(txt_no.Text)
        With DisplayNota
            .Show()
            '   .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Private Sub frmstockopname_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(5).Width = .Columns(5).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(0).Width = .Columns(0).Width + selisih_col2
    '    End With
    'End Sub

    'Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
    '    disableMain()
    '    PanelControl3.Visible = True
    '    detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "cashbank_no"))
    'End Sub

    'Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        disableMain()
    '        PanelControl3.Visible = True
    '        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "cashbank_no"))
    '    End If
    'End Sub
 
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