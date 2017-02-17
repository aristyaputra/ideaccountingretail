Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Public Class frmCurrency

    Dim insert As Integer
    Dim edit As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan As String

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
        End With
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.WhiteSmoke
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub frmCurrency_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmCurrency_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmkatbarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        datagrid_layout()
        insert = 1
        edit = 0
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        PanelControl1.Visible = False
        Me.MdiParent = MainMenu
        btn_del2.Enabled = False
        view_data()
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        txtket.Text = ""
        txtnama.Text = ""
        txtkode.Text = ""
        txtnegara.Text = ""
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
            Call insert_currency(Trim(txtkode.Text), Trim(txtnama.Text), Trim(txtnegara.Text), Trim(txtket.Text), "INSERT", flag)
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_currency(Trim(txtkode.Text), Trim(txtnama.Text), Trim(txtnegara.Text), Trim(txtket.Text), "UPDATE", flag)
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
            If getTemplateAkses(username, "MN_CURRENCY_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_CURRENCY_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        insert_data()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_CURRENCY_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
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
            pesan = MessageBox.Show("Do you want to delete data?", "Delete", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_currency(Trim(txtkode.Text), Trim(txtnama.Text), Trim(txtnegara.Text), Trim(txtket.Text), "DELETE", flag)
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
        '   GridList_Customer.OptionsView.ColumnAutoWidth = False
        DT = select_currency("", 0)
        GridControl.DataSource = DT
        GridList_Customer.Columns("id_currency").Caption = "ID Mata Uang"
        GridList_Customer.Columns("id_currency").Width = 120
        GridList_Customer.Columns("currency").Caption = "Mata Uang"
        GridList_Customer.Columns("currency").Width = 200
        GridList_Customer.Columns("notes").Caption = "Keterangan"
        GridList_Customer.Columns("notes").Width = 300
        'GridList_Customer.BestFitColumns()
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
        DT = select_currency("", 2)
        Rows = DT.Rows.Count - 1
        DataGridView2.Rows.Clear()
        For i = 0 To Rows
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            DataGridView2.Item(2, i).Value = DT.Rows(i).Item(2)
            DataGridView2.Item(3, i).Value = DT.Rows(i).Item(3)
            DataGridView2.Item(4, i).Value = DT.Rows(i).Item(4)
        Next
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        Dim DT As DataTable
        btn_del2.Enabled = True
        insert = 0
        edit = 1
        DT = select_currency(criteria, 1)
        txtkode.Enabled = False
        txtkode.Text = DT.Rows(0).Item(0)
        txtnama.Text = DT.Rows(0).Item(1)
        txtket.Text = DT.Rows(0).Item(2)
        txtnegara.Text = DT.Rows(0).Item(4)
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
        If TabControl1.SelectedTabPage Is TabConvert Then
            view_konversi_data()
        End If
        Dim Total_Width_Column, Total_Width_Column2 As Integer
        Dim Width_Table, Width_Table2 As Integer
        Dim selisih_col, selisih_col2 As Integer

        With DataGridView2
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(4).Width = .Columns(4).Width + selisih_col
        End With

        With DataGridView1
            Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width
            Width_Table2 = .Width
            selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
            .Columns(2).Width = .Columns(2).Width + selisih_col2
        End With
    End Sub

    Private Sub btn_save_konversi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save_konversi2.Click
        open_conn()
        Dim rows As Integer
        Dim i As Integer
        rows = DataGridView2.Rows.Count - 1
        For i = 0 To rows
            If DataGridView2.Item(0, i).Value.ToString <> "" Then
                If DataGridView2.Item(0, i).Value <> DataGridView2.Item(3, i).Value Then
                    Call update_setcurrency(DataGridView2.Item(0, i).Value, DataGridView2.Item(2, i).Value)
                End If
            End If
        Next
        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
            alertControl_success.Show(Me, info)
        Else
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
            alertControl_error.Show(Me, info)
        End If
    End Sub

    Private Sub txtnegara_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnegara.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtnama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnama.TextChanged

    End Sub

    Private Sub frmCurrency_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

    End Sub

    Private Sub TabConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NavBarControl9_Click(sender As System.Object, e As System.EventArgs)

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

    Private Sub TabControl1_Click(sender As System.Object, e As System.EventArgs) Handles TabControl1.Click

    End Sub


    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl3.Visible = True
        disableMain()
        clean()
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        PanelControl1.Visible = True
        disableMain()
        clean()
        view_konversi_data()
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
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_currency"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_currency"))
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class