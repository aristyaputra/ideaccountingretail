Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Public Class frmgolaset

    Dim insert As Integer
    Dim edit As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan As String

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub frmgolaset_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmjenisbarang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmkatbarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        datagrid_layout()
        insert = 1
        edit = 0
        btn_del2.Enabled = False
        txt_penyusutan.Text = 0
        txt_manfaat.Text = 0
        CheckBox1.Checked = False
        view_data()
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        txtnama.Text = ""
        txtkode.Text = ""
        btn_del2.Enabled = False
        txt_penyusutan.Text = 0
        txt_manfaat.Text = 0
        CheckBox1.Checked = False
        txtkode.Enabled = False
        txtkode.BackColor = Color.Lavender
        txtkode.ReadOnly = False
        txt_penyusutan.Text = 0
        If insert = 1 And CheckBox1.Checked = False Then
            var_bulan = Month(server_datetime())
            var_tahun = Year(server_datetime())
            Call insert_no_trans("MASTER_GOLASET", Month(server_datetime()), Year(server_datetime()))
            Call select_control_no("MASTER_GOLASET", "TRANS")
            txtkode.Text = no_master
        End If
    End Sub

    Public Sub insert_data()
        open_conn()
        If insert = 1 Then
            Call insert_golaset(Trim(txtkode.Text), txt_manfaat.Text, txt_penyusutan.Text, Trim(txtnama.Text), username, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, "INSERT")
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(server_datetime(), "MASTER_GOLASET")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_golaset(Trim(txtkode.Text), txt_manfaat.Text, txt_penyusutan.Text, Trim(txtnama.Text), username, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, "UPDATE")
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
        If Trim(txt_penyusutan.Text) = "" Then
            txt_penyusutan.Text = 0
        End If
        If Trim(txt_manfaat.Text) = "" Then
            txt_manfaat.Text = 0
        End If
        If insert = 1 Then
            If getTemplateAkses(username, "MN_GOLONGAN_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_GOLONGAN_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        insert_data()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_GOLONGAN_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_golaset(Trim(txtkode.Text), txt_manfaat.Text, txt_penyusutan.Text, Trim(txtnama.Text), username, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, "DELETE")
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
        DT = select_golaset("", 0)
        GridControl.DataSource = DT
        GridList_Customer.Columns("id_golongan").Caption = "ID Golongan"
        GridList_Customer.Columns("masa_manfaat").Caption = "Masa Manfaat"
        GridList_Customer.Columns("type").Caption = "Golongan"
        GridList_Customer.Columns("rate_penyusutan").Caption = "Rate Penyusutan (%)/Th"
        GridList_Customer.Columns("rate_penyusutan").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridList_Customer.Columns("rate_penyusutan").DisplayFormat.FormatString = "N2"
        GridList_Customer.BestFitColumns()
        'Rows = DT.Rows.Count - 1
        'DataGridView1.Rows.Clear()
        'For i = 0 To Rows
        '    DataGridView1.Rows.Add()
        '    DataGridView1.Item(0, i).Value = DT.Rows(i).Item("id_golongan")
        '    DataGridView1.Item(1, i).Value = DT.Rows(i).Item("type")
        '    DataGridView1.Item(2, i).Value = DT.Rows(i).Item("masa_manfaat")
        '    DataGridView1.Item(3, i).Value = FormatPercent(DT.Rows(i).Item("rate_penyusutan") / 100, 2)
        'Next
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        insert = 0
        edit = 1
        Dim DT As DataTable
        DT = select_golaset(criteria, 1)
        txtkode.Text = DT.Rows(0).Item("id_golongan")
        txtnama.Text = DT.Rows(0).Item("type")
        ' txtket.Text = DT.Rows(0).Item(2)
        txt_penyusutan.Text = FormatNumber(DT.Rows(0).Item("rate_penyusutan"), 2)
        txt_manfaat.Text = DT.Rows(0).Item("masa_manfaat")
        btn_del2.Enabled = True

    End Sub

    Private Sub txtket_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
        open_conn()
        Dim Total_Width_Column As Integer
        Dim Width_Table As Integer
        Dim selisih_col As Integer

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(2).Width = .Columns(2).Width + selisih_col
        End With

    End Sub

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

    Private Sub txtnama_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnama.TextChanged
        ''open_conn()
        ''If insert = 1 Then

        ''    (txtnama.Text)
        ''    txtkode.Text = Def_Kode
        ''End If
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

    Private Sub frmjenisbarang_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        open_conn()
        Dim Total_Width_Column As Integer
        Dim Width_Table As Integer
        Dim selisih_col As Integer

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(2).Width = .Columns(2).Width + selisih_col
        End With

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If insert = 1 Then
                txtkode.Enabled = True
                txtkode.ReadOnly = False
                txtkode.BackColor = Color.White
            End If
        ElseIf CheckBox1.Checked = False Then
            txtkode.Enabled = False
            txtkode.ReadOnly = True
            txtkode.BackColor = Color.Lavender
        End If
        If insert = 1 And CheckBox1.Checked = False Then
            var_bulan = Month(server_datetime())
            var_tahun = Year(server_datetime())
            Call insert_no_trans("MASTER_GOLASET", Month(server_datetime()), Year(server_datetime()))
            Call select_control_no("MASTER_GOLASET", "TRANS")
            txtkode.Text = no_master
        End If
    End Sub

    Private Sub Panel4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub txt_manfaat_LostFocus(sender As Object, e As System.EventArgs) Handles txt_manfaat.LostFocus
        Dim rate As Double
        rate = 1 / CInt(txt_manfaat.Text) * 100
        txt_penyusutan.Text = FormatNumber(rate, 2)
    End Sub

    Private Sub txt_manfaat_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_manfaat.TextChanged

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_golongan"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_golongan"))
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

    Private Sub Panel3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

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
            view_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class