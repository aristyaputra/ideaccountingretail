Imports System.IO
Imports System.Text
Imports System.Drawing
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmar_initbalance
    Dim insert As Integer
    Dim edit As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan As String
    Dim amount_before As Double
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

    Private Sub detail(ByVal criteria As String, ByVal customer As String)
        open_conn()
        insert = 0
        edit = 1

        Dim DT As DataTable
        Dim var_chk As Integer
        If chk_date.Checked = True Then
            var_chk = 1
        Else
            var_chk = 0
        End If
        DT = select_master2("select_ar_initbalance", "invoice_no", criteria, customer, 1, var_chk, tglawal.Value, tglakhir.Value)
        If DT.Rows.Count > 0 Then
            txt_date.Value = DT.Rows(0).Item("cutoff_date").ToString
            txt_servicenm.Text = DT.Rows(0).Item("invoice_no").ToString
            cbo_acc.Text = DT.Rows(0).Item("id_customer").ToString
            lbl_acc_name.Text = DT.Rows(0).Item("customer_name").ToString
            txt_price.Text = DT.Rows(0).Item("amount_of").ToString
            amount_before = DT.Rows(0).Item("amount_of").ToString
            txt_senior_comm.Text = DT.Rows(0).Item("notes").ToString
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

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub frmar_initbalance_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmservice_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub
    Private Sub frmitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        lbl_acc_name.Text = ""
        insert = 1
        edit = 0
        btn_del2.Enabled = False
        cbo_search.Text = "Invoice No"
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        txt_junior_comm.Text = 0
        txt_senior_comm.Text = 0
        txt_price.Text = 0
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        amount_before = 0
        view_data()
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "invoice_no"), GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_customer"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "invoice_no"), GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_customer"))
        End If
    End Sub


    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_AR_INITBALANCE_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_AR_INITBALANCE_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        insert_data()
    End Sub

    Public Sub insert_data()
        open_conn()
        If insert = 1 Then
            Call insert_ar_init(Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_servicenm.Text), Trim(cbo_acc.Text), Trim(txt_price.Text), _
                 TextBox1.Text, username, server_datetime(), server_datetime(), username, "INSERT", amount_before)
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_ar_init(Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_servicenm.Text), Trim(cbo_acc.Text), Trim(txt_price.Text), _
                  TextBox1.Text, username, server_datetime(), server_datetime(), username, "UPDATE", amount_before)
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
            .txt_servicenm.Text = ""
            .cbo_acc.Text = ""
            .txt_junior_comm.Text = ""
            .txt_senior_comm.Text = 0
            .txt_price.Text = 0
            .lbl_acc_name.Text = ""
        End With
        amount_before = 0
    End Sub

    'Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
    '    open_conn()
    '    edit = 1
    '    insert = 0
    '    i = DataGridView2.CurrentCell.RowIndex
    '    detail(DataGridView2.Item(1, i).Value)
    '    TabControl1.SelectedTabPage = TabInput
    '    btn_del2.Enabled = True
    'End Sub

    Private Sub txt_itemid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub cbo_acc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_acc.Click
        Dim FrmAccount As New frm_display_cust
        open_conn()
        FrmAccount.formsource_arinit = True
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

    Private Sub cbo_acc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_acc.KeyPress
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

        'Dim Total_Width_Column As Integer
        'Dim Width_Table As Integer
        'Dim selisih_col As Integer

        'With DataGridView2
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(1).Width = .Columns(1).Width + selisih_col
        'End With
    End Sub

    Private Sub view_data()
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            Dim i As Integer
            Dim Rows As Integer
            Dim DT As DataTable
            Dim var_chk As Integer
            If chk_date.Checked = True Then
                var_chk = 1
            Else
                var_chk = 0
            End If
            DT = select_master2("select_ar_initbalance", Trim(cbo_search.Text), Trim(txt_search.Text), "", 0, var_chk, tglawal.Value, tglakhir.Value)
            GridControl.DataSource = DT
            GridList_Customer.Columns("cutoff_date").Caption = "Tanggal Cut Off"
            GridList_Customer.Columns("cutoff_date").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("cutoff_date").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("invoice_no").Caption = "No Faktur"
            GridList_Customer.Columns("id_customer").Caption = "ID Pelanggan"
            GridList_Customer.Columns("customer_name").Caption = "Nama Pelanggan"
            GridList_Customer.Columns("amount_of").Caption = "Nominal"
            GridList_Customer.Columns("amount_of").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("amount_of").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.BestFitColumns()

            'Rows = DT.Rows.Count - 1
            'DataGridView2.Rows.Clear()
            'For i = 0 To Rows
            '    DataGridView2.Rows.Add()
            '    DataGridView2.Item(0, i).Value = DT.Rows(i).Item("supplier_name")
            '    DataGridView2.Item(1, i).Value = DT.Rows(i).Item("invoice_no")
            '    DataGridView2.Item(2, i).Value = FormatNumber(DT.Rows(i).Item("amount_of"), 0)
            'Next
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
            If getTemplateAkses(username, "MN_AR_INITBALANCE_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_ar_init(Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_servicenm.Text), Trim(cbo_acc.Text), Trim(txt_price.Text), _
                 txt_senior_comm.Text, username, server_datetime(), server_datetime(), username, "DELETE", amount_before)
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
        cbo_search.Text = "Invoice No"
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

    'Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
    '    open_conn()
    '    If e.KeyCode = Keys.Enter Then
    '        edit = 1
    '        insert = 0
    '        i = DataGridView2.CurrentCell.RowIndex
    '        detail(DataGridView2.Item(0, i).Value)
    '        TabControl1.SelectedTabPage = TabInput
    '        btn_del2.Enabled = True
    '    End If
    'End Sub

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
        'open_conn()
        'Dim Total_Width_Column As Integer
        'Dim Width_Table As Integer
        'Dim selisih_col As Integer

        'With DataGridView2
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(1).Width = .Columns(1).Width + selisih_col
        'End With

    End Sub


    Private Sub cbo_acc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_acc.SelectedIndexChanged

    End Sub

    Private Sub TabList_Click(sender As System.Object, e As System.EventArgs)

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