Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Public Class frmWH

    Dim insert As Integer
    Dim edit As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan As String
    Dim is_outlet As Integer

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub frmWH_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        open_conn()
        Dim Rows As Integer
        Dim i As Integer
        Me.WindowState = FormWindowState.Maximized
        cbounit.Items.Clear()
        Rows = select_unit.Rows.Count - 1
        For i = 0 To Rows
            cbounit.Items.Add(select_unit.Rows(i).Item(0))
        Next
    End Sub

    Private Sub frmWH_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
        Dim i As Integer
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        datagrid_layout()
        insert = 1
        edit = 0
        btn_del2.Enabled = False
        Dim Rows As Integer
        Rows = select_unit.Rows.Count - 1
        For i = 0 To Rows
            cbounit.Items.Add(select_unit.Rows(i).Item(0))
        Next
        'GridList_Customer.OptionsView.ColumnAutoWidth = False
        view_data()
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        txtalamat.Text = ""
        txtkota.Text = ""
        cboqty.Text = ""
        txttelp.Text = ""
        cbounit.Text = ""
        chkdef.Checked = False
        txtket.Text = ""
        txtnama.Text = ""
        txtkode.Text = ""
        btn_del2.Enabled = False
        txtkode.Enabled = True
    End Sub

    Public Sub insert_data()
        open_conn()
        Dim flag As Integer
        If chkdef.Checked = True Then
            flag = 1
        ElseIf chkdef.Checked = False Then
            flag = 0
        End If
        If insert = 1 Then
            Call insert_warehouse(Trim(txtkode.Text), Trim(txtnama.Text), cboqty.Text, cbounit.Text, Trim(txtalamat.Text), Trim(txttelp.Text), Trim(txtkota.Text), Trim(txtket.Text), flag, "INSERT", is_outlet)
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_warehouse(Trim(txtkode.Text), Trim(txtnama.Text), cboqty.Text, cbounit.Text, Trim(txtalamat.Text), Trim(txttelp.Text), Trim(txtkota.Text), Trim(txtket.Text), flag, "UPDATE", is_outlet)
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
            If getTemplateAkses(username, "MN_WAREHOUSE_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_WAREHOUSE_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If Trim(cboqty.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan kapasitas gudang")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If chk_outlet.Checked = True Then
            If get_count_outlet() > 1 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Sudah ada outlet pada aplikasi," & vbCrLf & "Silahkan ubah outlet")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If chk_outlet.Checked = True Then
            is_outlet = 1
        Else
            is_outlet = 0
        End If
        insert_data()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_WAREHOUSE_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If


        If edit = 1 Then
            pesan = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_warehouse(Trim(txtkode.Text), Trim(txtnama.Text), cboqty.Text, cbounit.Text, Trim(txtalamat.Text), Trim(txttelp.Text), Trim(txtkota.Text), Trim(txtket.Text), 1, "DELETE")
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
        DT = select_warehouse_list("", 0)
        GridControl.DataSource = DT
        GridList_Customer.Columns("id_warehouse").Caption = "ID Gudang"
        GridList_Customer.Columns("id_warehouse").Width = 120
        GridList_Customer.Columns("warehouse_name").Caption = "Nama Gudang"
        GridList_Customer.Columns("warehouse_name").Width = 200
        GridList_Customer.Columns("qty_max").Caption = "Kapasitas"
        GridList_Customer.Columns("qty_max").Width = 150
        GridList_Customer.Columns("city").Caption = "Kota"
        GridList_Customer.Columns("city").Width = 200
        GridList_Customer.Columns("phone").Caption = "Telepon"
        GridList_Customer.Columns("phone").Width = 200
        'GridList_Customer.BestFitColumns()
        'Rows = DT.Rows.Count - 1
        'DataGridView1.Rows.Clear()
        'For i = 0 To Rows
        '    DataGridView1.Rows.Add()
        '    DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
        '    DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
        '    DataGridView1.Item(2, i).Value = DT.Rows(i).Item(2)
        '    DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
        '    DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
        'Next
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        Dim DT As DataTable
        insert = 0
        edit = 1
        btn_del2.Enabled = True
        DT = select_warehouse_list(criteria, 1)
        txtkode.Enabled = False
        txtkode.Text = DT.Rows(0).Item(0)
        txtnama.Text = DT.Rows(0).Item(1)
        cboqty.Text = DT.Rows(0).Item(2)
        cbounit.Text = DT.Rows(0).Item(3)
        txtalamat.Text = DT.Rows(0).Item(4)
        txttelp.Text = DT.Rows(0).Item(5)
        txtkota.Text = DT.Rows(0).Item(6)
        txtket.Text = DT.Rows(0).Item(7)
        If DT.Rows(0).Item("is_outlet") = 1 Then
            chk_outlet.Checked = True
        Else
            chk_outlet.Checked = False
        End If
        If DT.Rows(0).Item(8) = 1 Then
            chkdef.Checked = True
        ElseIf DT.Rows(0).Item(8) = 0 Then
            chkdef.Checked = False
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

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(3).Width = .Columns(3).Width + selisih_col
        End With
    End Sub

    Private Sub cboqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboqty.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub txtalamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtalamat.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtkota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkota.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txttelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelp.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
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
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmWH_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        open_conn()
        Dim Total_Width_Column As Integer
        Dim Width_Table As Integer
        Dim selisih_col As Integer

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(3).Width = .Columns(3).Width + selisih_col
        End With

    End Sub

    Private Sub TabInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabInput.Click

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

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_warehouse"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_warehouse"))
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl3.Visible = True
        disableMain()
        clean()
    End Sub


End Class