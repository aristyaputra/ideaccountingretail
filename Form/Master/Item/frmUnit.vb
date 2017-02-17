Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Public Class frmUnit

    Dim insert As Integer
    Dim edit As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan As String

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = False
            .Columns(2).DefaultCellStyle.BackColor = Color.White
            .Columns(3).ReadOnly = True
            .Columns(3).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(4).ReadOnly = True
            .Columns(4).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(5).ReadOnly = False
            .Columns(5).DefaultCellStyle.BackColor = Color.White
        End With
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black

        End With
    End Sub


    Private Sub LoadComboBox_MtgcComboBoxItem()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_item()

        cbo_noakun.SelectedIndex = -1
        cbo_noakun.Items.Clear()
        cbo_noakun.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_noakun.SourceDataString = New String(1) {"id_item", "item_name"}
        cbo_noakun.SourceDataTable = dtLoading
        cbo_noakun.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub frmUnit_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmUnit_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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

    Private Sub frmkatbarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        PanelControl1.Visible = False
        Me.MdiParent = MainMenu
        datagrid_layout()
        insert = 1
        edit = 0
        btn_del2.Enabled = False
        LoadComboBox_MtgcComboBoxItem()
        'GridList_Customer.OptionsView.ColumnAutoWidth = False
        view_data()
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        txtket.Text = ""
        txtnama.Text = ""
        txtkode.Text = ""
        btn_del2.Enabled = False
        chk_def.Checked = False
        txtkode.Enabled = True
    End Sub

    Public Sub insert_data()
        open_conn()
        Dim flag As Integer
        If chk_def.Checked = True Then
            flag = 1
        ElseIf chk_def.Checked = False Then
            flag = 0
        End If
        If insert = 1 Then
            Call insert_unit(Trim(txtkode.Text), Trim(txtnama.Text), Trim(txtket.Text), "INSERT", flag)
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_unit(Trim(txtkode.Text), Trim(txtnama.Text), Trim(txtket.Text), "UPDATE", flag)
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
        If insert = 1 Then
            If getTemplateAkses(username, "MN_UNIT_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_UNIT_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        insert_data()
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_UNIT_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim flag As Integer
        If chk_def.Checked = True Then
            flag = 1
        ElseIf chk_def.Checked = False Then
            flag = 0
        End If
        If edit = 1 Then
            pesan = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_unit(Trim(txtkode.Text), Trim(txtnama.Text), Trim(txtket.Text), "DELETE", flag)
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

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_unit"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_unit"))
        End If
    End Sub

    Private Sub view_data_barang()
        open_conn()

        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        Dim var_chk As Integer

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Item . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True

            DT = select_master("select_item", "Item ID", "", 0, 0, server_datetime(), server_datetime())

            GridControl1.DataSource = DT
            GridView1.Columns("id_item").Caption = "Kode Barang"
            GridView1.Columns("item_name").Caption = "Nama Barang"
            GridView1.Columns("main_unit").Caption = "Unit Utama"
            GridView1.Columns("main_unit").Visible = False
            GridView1.Columns("mst_itemcat_nm").Caption = "Kategori Barang"
            GridView1.Columns("mst_itemcat_nm").Visible = False
            GridView1.Columns("mst_itemjenis_nm").Caption = "Jenis Barang"
            GridView1.Columns("mst_itemjenis_nm").Visible = False
            GridView1.Columns("id_barcode").Caption = "Barcode"
            GridView1.Columns("mst_itembrand_nm").Caption = "Merek"
            GridView1.Columns("mst_itembrand_nm").Visible = False
            GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto


            'Rows = DT.Rows.Count - 1
            'DataGridView2.Rows.Clear()
            'For i = 0 To Rows
            '    DataGridView2.Rows.Add()
            '    DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            '    DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            '    DataGridView2.Item(2, i).Value = DT.Rows(i).Item(2)
            '    DataGridView2.Item(3, i).Value = DT.Rows(i).Item(3)
            '    DataGridView2.Item(4, i).Value = DT.Rows(i).Item(4)
            '    DataGridView2.Item(6, i).Value = DT.Rows(i).Item(6)

            'Next
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub view_data()
        open_conn()
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_unit2("", 0)
        GridControl.DataSource = DT
        GridList_Customer.Columns("id_unit").Caption = "ID Unit"
        GridList_Customer.Columns("id_unit").Width = 120
        GridList_Customer.Columns("unit").Caption = "Unit"
        GridList_Customer.Columns("unit").Width = 180
        GridList_Customer.Columns("notes").Caption = "Keterangan"
        GridList_Customer.Columns("notes").Width = 300
        ' GridList_Customer.BestFitColumns()
        'Rows = DT.Rows.Count - 1
        'DataGridView1.Rows.Clear()
        'For i = 0 To Rows
        '    DataGridView1.Rows.Add()
        '    DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
        '    DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
        '    DataGridView1.Item(2, i).Value = DT.Rows(i).Item(2)
        'Next
    End Sub

    Private Sub view_konversi_data()
        open_conn()
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_unit2(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_item"), 2)
        Rows = DT.Rows.Count - 1
        DataGridView2.Rows.Clear()
        For i = 0 To Rows
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            DataGridView2.Item(2, i).Value = DT.Rows(i).Item(2)
            DataGridView2.Item(3, i).Value = DT.Rows(i).Item(3)
            DataGridView2.Item(4, i).Value = DT.Rows(i).Item(4)
            If DT.Rows(i).Item(5) = "true" Then
                DataGridView2.Item(5, i).Value = True
            ElseIf DT.Rows(i).Item(5) = "false" Then
                DataGridView2.Item(5, i).Value = False
            End If
        Next
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        Dim DT As DataTable
        btn_del2.Enabled = True
        insert = 0
        edit = 1
        DT = select_unit2(criteria, 1)
        txtkode.Enabled = False
        txtkode.Text = DT.Rows(0).Item(0)
        txtnama.Text = DT.Rows(0).Item(1)
        txtket.Text = DT.Rows(0).Item(2)
        If DT.Rows(0).Item(3) = 1 Then
            chk_def.Checked = True
        ElseIf DT.Rows(0).Item(3) = 0 Then
            chk_def.Checked = False
        End If
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
        edit = 1
        i = DataGridView1.CurrentCell.RowIndex
        detail(DataGridView1.Item(0, i).Value)
        TabControl1.SelectedTabPage = TabInput
        btn_del2.Enabled = True
        txtkode.Enabled = False
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        If TabControl1.SelectedTabPage Is TabList Then
            view_data()
        End If
        If TabControl1.SelectedTabPage Is TabKonversi Then

        End If
        open_conn()
        Dim Total_Width_Column, Total_Width_Column2 As Integer
        Dim Width_Table, Width_Table2 As Integer
        Dim selisih_col, selisih_col2 As Integer

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(2).Width = .Columns(2).Width + selisih_col
        End With

        With DataGridView2
            Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
            Width_Table2 = .Width
            selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
            .Columns(4).Width = .Columns(4).Width + selisih_col2
        End With
    End Sub


    Private Sub btn_save2_konversi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        open_conn()
        Dim rows As Integer
        Dim i As Integer
        Dim a As Integer
        Dim varall_unit As String

        a = 0
        rows = DataGridView2.Rows.Count - 1

        For i = 0 To rows
            If DataGridView2.Item(5, i).Value = True And DataGridView2.Item(2, i).Value > 0 Then
                Call update_setunit(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_item"), DataGridView2.Item(0, i).Value, DataGridView2.Item(4, i).Value, DataGridView2.Item(2, i).Value, server_datetime(), username, a)
                a = a + 1
                varall_unit = DataGridView2.Item(0, i).Value
            End If
        Next

        If a = 1 Then
            Call update_setallunititem(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_item"), varall_unit)
        End If

        If a = 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih Unit")
            alertControl_error.Show(Me, info)
            Exit Sub
        End If

        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
            alertControl_success.Show(Me, info)
        Else
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
            alertControl_error.Show(Me, info)
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

    Private Sub btn_plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plus.Click
        open_conn()
        view_konversi_data()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmUnit_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        open_conn()
        Dim Total_Width_Column, Total_Width_Column2 As Integer
        Dim Width_Table, Width_Table2 As Integer
        Dim selisih_col, selisih_col2 As Integer

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(2).Width = .Columns(2).Width + selisih_col
        End With

        With DataGridView2
            Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
            Width_Table2 = .Width
            selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
            .Columns(4).Width = .Columns(4).Width + selisih_col2
        End With

    End Sub

    Private Sub TabKonversi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub btn_save22_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_del2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_reset22_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_keluar_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
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

    Private Sub XtraTabPage3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles TabKonversi.Paint

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

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        PanelControl1.Visible = True
        disableMain()
        clean()
        view_data_barang()
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        PanelControl1.Visible = False
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

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        view_konversi_data()
    End Sub

    Private Sub SimpleButton9_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton9.Click

    End Sub

    Private Sub DataGridView2_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        If DataGridView2.CurrentCell.ColumnIndex = 2 And DataGridView2.Item(2, DataGridView2.CurrentCell.RowIndex).Value = 1 Then
            For i As Integer = 0 To DataGridView2.Rows.Count - 1
                If DataGridView2.Item(2, i).Value = 1 And i <> DataGridView2.CurrentCell.RowIndex Then
                    DataGridView2.Item(2, i).Value = 0
                End If
            Next
        End If
    End Sub
End Class