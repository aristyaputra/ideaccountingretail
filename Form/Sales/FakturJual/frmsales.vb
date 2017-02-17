Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmsales
    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Public NoFakturJual As String

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub frmsales_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmsales_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        Dim DT As New DataTable
        Dim Rows As Integer
        insert = 1
        edit = 0
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        If insert = 1 Then
            Call insert_no_trans("SALES", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("SALES", "TRANS")
            cbo_search.Text = "Invoice No"
            txt_inv_no.Text = no_master
        End If
        cbo_search.Text = "Invoice No"
        'DataGridView1.Item(0, 0).Value = 1
        'DataGridView1.Focus()
        btn_del2.Enabled = False
        btn_cetak.Enabled = False

        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dim i As Integer
        DataGridView2.ReadOnly = True
        btn_del2.Enabled = False
        txt_curr.Items.Clear()
        Rows = select_curr.Rows.Count - 1
        For i = 0 To Rows
            txt_curr.Items.Add(select_curr.Rows(i).Item(0))
        Next
        txt_paymethod.Items.Clear()
        DT = select_ref_paymethod()
        Rows = DT.Rows.Count - 1
        For i = 0 To Rows
            txt_paymethod.Items.Add(DT.Rows(i).Item(1))
        Next
        txt_curr.Text = get_def_curr()
        txt_paymethod.Text = "Credit"
        'If insert = 1 Then
        Call init_number()
        'End If
        'DataGridView1.Rows.Add(10)
        chk_date.Checked = False
        tglawal.Enabled = False
        tglakhir.Enabled = False
        datagrid_layout()
        chk_so.Checked = True
        LoadComboBox_MtgcComboBoxAkun()
        txt_tax_nominal.Text = 0
        lbl_kurs.Text = get_def_curr()
        txt_kurs.Text = 1
        view_data()
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxAkun()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_cashbank_all()

        cbo_akun.SelectedIndex = -1
        cbo_akun.Items.Clear()
        cbo_akun.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_akun.SourceDataString = New String(1) {"id_account", "account_name"}
        cbo_akun.SourceDataTable = dtLoading
        cbo_akun.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub init_number()
        open_conn()
        txt_tax.Text = FormatPercent(0, 0)
        txt_subtotal.Text = 0
        txt_total.Text = 0
        txt_disc_pay.Text = FormatPercent(0, 0)
        txt_netto.Text = 0
        txt_paid.Text = 0
        txt_change.Text = 0
        txt_discterm.Text = 0
        txt_payterm.Text = 0
        txt_disc.Text = FormatPercent(0, 0)
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        i = DataGridView1.CurrentCell.ColumnIndex
        If i = 8 Then
            'Dim NewDisplayAcc As New frm_display_teraphyst
            'NewDisplayAcc.formsource_sales = True
            'NewDisplayAcc.Show()
            ''   NewDisplayAcc.MdiParent = MainMenu
            'Me.Enabled = False
        End If
        'If i = 1 Or i = 2 Then
        '    Dim NewDisplayAcc As New frm_display_item
        '    NewDisplayAcc.formsource_sales_item = True
        '    NewDisplayAcc.Show()
        '    '    NewDisplayAcc.MdiParent = MainMenu
        '    Me.Enabled = False
        'End If
        If i = 5 Then
            'Dim NewDisplayAcc As New frm_display_unit
            'NewDisplayAcc.formsource_sales_unit = True
            'NewDisplayAcc.Show()
            ''    NewDisplayAcc.MdiParent = MainMenu
            'Me.Enabled = False
            'Dim dgvcc As DataGridViewComboBoxCell
            'dgvcc = DataGridView1.Rows(mRow).Cells(5)
            'dgvcc.Items.Clear()
            'Rows = select_unit.Rows.Count - 1
            'For i = 0 To Rows
            '    dgvcc.Items.Add(select_unit.Rows(i).Item(0))
            'Next
        End If
        'If mRow = 0 Then
        '    DataGridView1.Rows.Add(1)
        'End If
        'If DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value = "" Then
        '    DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = 0
        'End If
    End Sub

    Dim TSubTotal As Double
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim rows As Integer
        Dim columnIndex As Integer
        TSubTotal = 0
        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        If columnIndex = 4 Or columnIndex = 6 Then
            Dim DT_stock As DataTable
            DT_stock = select_get_stock(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
            If DT_stock.Rows(0).Item(0) < DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value Then
                Dim info As AlertInfo = New AlertInfo("Validate", "Stok Qty " & DT_stock.Rows(0).Item(0) & " tidak mencukupi")
                alertControl_warning.Show(Me, info)
                DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
            End If
            DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value * DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value, 0)
        End If
        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
            DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = 0
            DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = 0
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item belum di isi")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        Dim i As Integer
        rows = DataGridView1.Rows.Count - 1
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)

        hitung_nominal()
    End Sub

    Private Sub hitung_nominal()
        open_conn()
        Dim TNett As Double
        Dim Ttotal As Double
        Dim Tchange As Double

        TNett = 0
        Ttotal = 0
        Tchange = 0

        'menghitung(netto)
        TNett = CDbl(txt_subtotal.Text) - (CDbl(txt_subtotal.Text) * CDbl(Replace(txt_disc.Text, "%", "")) / 100)
        txt_netto.Text = FormatNumber(TNett, 0)
        Ttotal = TNett + (TNett * (CDbl(Replace(txt_tax.Text, "%", "")) / 100))

        'menghitung total
        txt_total.Text = FormatNumber(Ttotal - CDbl(Replace(txt_um.Text, ",", "")) + CDbl(Replace(txt_freight.Text, ",", "")), 0)

        'menghitung change
        Tchange = (CDbl(txt_paid.Text)) - Ttotal
        txt_change.Text = FormatNumber(Tchange, 0)
    End Sub

    Private Sub txt_paid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        If txt_paid.Text = "" Then
            txt_paid.Text = FormatNumber(0, 0)
        Else
            txt_paid.Text = FormatNumber(txt_paid.Text, 0)
        End If
        hitung_nominal()
    End Sub

    Private Sub txt_tax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        txt_tax.SelectionStart = 0
        txt_tax.SelectionLength = Len(txt_tax.Text)
    End Sub

    Private Sub txt_tax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        If txt_tax.Text = "" Then
            txt_tax.Text = FormatPercent(0, 0)
        Else
            txt_tax.Text = FormatPercent(CDbl(Replace(txt_tax.Text, "%", "")) / 100, 0)
        End If
        hitung_nominal()
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

    Private Sub clean()
        open_conn()
        With Me
            .txt_comment.Text = ""
            .txt_cust_address.Text = ""
            .txt_customer_nm.Text = ""
            .txt_date.Value = Now
            .txt_search.Text = ""
            .txt_subtotal.Text = 0
            .txt_tax.Text = 0
            .txt_total.Text = 0
            .cbo_customer.Text = ""
            .txt_curr.Text = get_def_curr()
            .txt_paymethod.Text = "Cash"
            .cbo_akun.Text = ""
            .txt_tax_nominal.Text = 0
            .chk_ppn.Checked = False
        End With
        'For i = 0 To DataGridView1.Rows.Count - 1
        '    DataGridView1.Item(0, i).Value = ""
        '    DataGridView1.Item(1, i).Value = ""
        '    DataGridView1.Item(2, i).Value = ""
        '    DataGridView1.Item(3, i).Value = ""
        '    DataGridView1.Item(4, i).Value = 0
        '    DataGridView1.Item(5, i).Value = ""
        '    DataGridView1.Item(6, i).Value = 0
        '    DataGridView1.Item(7, i).Value = 0
        '    'DataGridView1.Rows.RemoveAt(i)
        'Next
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        DataGridView6.Rows.Clear()
        DataGridView6.Rows.Add(250)

        'DataGridView1.Rows.Add(10)
        Call select_control_no("SALES", "TRANS")
        txt_inv_no.Text = no_master
        cbo_search.Text = "Invoice No"
        insert = 1
        edit = 0
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        init_number()
        lbl_nm_akun.Visible = False
    End Sub

    Private Sub insert_data()
        open_conn()
        Dim var_paymethod As Integer
        Dim var_chk_so As Integer

        If txt_paymethod.Text = "Cash" Then
            var_paymethod = 1
        Else
            var_paymethod = 2
        End If

        If chk_so.Checked = True Then
            var_chk_so = 1
        ElseIf chk_so.Checked = False Then
            var_chk_so = 0
        End If

        Dim nobukti As String
        nobukti = Trim(txt_inv_no.Text)
        If insert = 1 Then
            Call insert_sales(Trim(txt_inv_no.Text), txt_date.Value, cbo_customer.Text, txt_cust_id.Text, _
                                var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
                                server_datetime(), username, server_datetime(), 0, "", "", 0, "", 0, 0, "", 0, 0, 0, "", CInt(txt_payterm.Text), CInt(txt_discterm.Text), Replace(txt_disc_pay.Text, "%", ""), var_chk_so, cbo_akun.Text, Replace(txt_kurs.Text, ",", ""), "", "", 0, "", Replace(txt_um.Text, ",", ""), Replace(txt_freight.Text, ",", ""))
            Dim i As Integer
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then
                    Call insert_sales(Trim(txt_inv_no.Text), txt_date.Value, cbo_customer.Text, txt_cust_id.Text, _
                                var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
                                server_datetime(), username, server_datetime(), DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, Replace(DataGridView1.Item(4, i).Value, ",", ""), DataGridView1.Item(5, i).Value, Replace(DataGridView1.Item(6, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), txt_curr.Text, 1, i, 0, DataGridView1.Item(8, i).Value, CInt(txt_payterm.Text), CInt(txt_discterm.Text), Replace(txt_disc_pay.Text, "%", ""), var_chk_so, cbo_akun.Text, Replace(txt_kurs.Text, ",", ""), DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(3, i).Value, DataGridView6.Item(4, i).Value, Replace(txt_um.Text, ",", ""), Replace(txt_freight.Text, ",", ""))
                End If
            Next
            For i = 0 To DataGridView6.Rows.Count - 1
                If DataGridView6.Item(1, i).Value <> "" Then
                    Call insert_sales(Trim(txt_inv_no.Text), txt_date.Value, cbo_customer.Text, txt_cust_id.Text, _
                                var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
                                server_datetime(), username, server_datetime(), DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, Replace(DataGridView1.Item(4, i).Value, ",", ""), DataGridView1.Item(5, i).Value, Replace(DataGridView1.Item(6, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), txt_curr.Text, 2, i, 0, DataGridView1.Item(8, i).Value, CInt(txt_payterm.Text), CInt(txt_discterm.Text), Replace(txt_disc_pay.Text, "%", ""), var_chk_so, cbo_akun.Text, Replace(txt_kurs.Text, ",", ""), DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(3, i).Value, DataGridView6.Item(4, i).Value, Replace(txt_um.Text, ",", ""), Replace(txt_freight.Text, ",", ""))
                End If
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "SALES")
                pesan = MsgBox("Cetak Faktur?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormFakturJual
                    NoFakturJual = Trim(txt_inv_no.Text)
                    With DisplayNota
                        .Show()
                        '  .MdiParent = MainMenu
                        .WindowState = FormWindowState.Maximized
                    End With
                End If
                clean()
                'Dim R As New ReportDocument
                'R.Load("C:\report\StrukPenjualan.rpt")
                'R.RecordSelectionFormula = "{trn_sales_head.no_sales} ='" & nobukti & "'"
                'R.PrintToPrinter(1, False, 1, 1)
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            If select_validate("Sales", Trim(txt_inv_no.Text)) > 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Faktr telah lunas")
                alertControl_error.Show(Me, info)
                Exit Sub
            End If
            Call update_sales(Trim(txt_inv_no.Text), txt_date.Value, cbo_customer.Text, txt_cust_id.Text, _
                                var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
                                server_datetime(), username, server_datetime(), 0, "", "", 0, "", 0, 0, "", 0, 0, 0, "", txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), var_chk_so, cbo_akun.Text, Replace(txt_kurs.Text, ",", ""), "", "", 0, "", Replace(txt_um.Text, ",", ""), Replace(txt_freight.Text, ",", ""))
            Dim i As Integer
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then


                    Call update_sales(Trim(txt_inv_no.Text), txt_date.Value, cbo_customer.Text, txt_cust_id.Text, _
                                var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
                                server_datetime(), username, server_datetime(), DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, Replace(DataGridView1.Item(4, i).Value, ",", ""), DataGridView1.Item(5, i).Value, Replace(DataGridView1.Item(6, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), txt_curr.Text, 1, i, 0, DataGridView1.Item(8, i).Value, txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), var_chk_so, cbo_akun.Text, Replace(txt_kurs.Text, ",", ""), DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(3, i).Value, DataGridView6.Item(4, i).Value, Replace(txt_um.Text, ",", ""), Replace(txt_freight.Text, ",", ""))
                End If
            Next

            For i = 0 To DataGridView6.Rows.Count - 1
                If DataGridView6.Item(1, i).Value <> "" Then


                    Call update_sales(Trim(txt_inv_no.Text), txt_date.Value, cbo_customer.Text, txt_cust_id.Text, _
                                var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
                                server_datetime(), username, server_datetime(), DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, Replace(DataGridView1.Item(4, i).Value, ",", ""), DataGridView1.Item(5, i).Value, Replace(DataGridView1.Item(6, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), txt_curr.Text, 2, i, 0, DataGridView1.Item(8, i).Value, txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), var_chk_so, cbo_akun.Text, Replace(txt_kurs.Text, ",", ""), DataGridView6.Item(1, i).Value, DataGridView6.Item(2, i).Value, DataGridView6.Item(3, i).Value, DataGridView6.Item(4, i).Value, Replace(txt_um.Text, ",", ""), Replace(txt_freight.Text, ",", ""))
                End If
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                clean()
                'Dim R As New ReportDocument
                'R.Load(Application.StartupPath & "\report\StrukPenjualan.rpt")
                'R.RecordSelectionFormula = "{trn_sales_head.no_sales} ='" & nobukti & "'"
                'R.PrintToPrinter(1, False, 1, 1)
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
    End Sub

    Private Sub btn_saev2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_SALES_INV_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SALES_INV_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If txt_paymethod.Text = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih metode pembayaran")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If txt_curr.Text = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih Mata Uang")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If txt_paymethod.Text = "Cash" And cbo_akun.Text = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "P")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If trial = True Then
            If get_count_data("trn_sales_head", "no_sales") > row_trial Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Batas untuk input versi trial telah habis, silahkan membeli produk ini")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        insert_data()
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
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)

        End With
    End Sub

    Private Sub cbo_customer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_customer.Click
        open_conn()
        insert = 1
        If chk_so.Checked = False Then
            'Dim NewDisplayAcc As New frm_display_cust
            frm_display_cust.formsource_sales = True
            frm_display_cust.Show()
            ' NewDisplayAcc.MdiParent = MainMenu
            'Me.Enabled = False
        Else
            'Dim NewDisplayAcc As New frm_display_so
            frm_display_so.formsource_so_sales = True
            frm_display_so.Show()
            ' NewDisplayAcc.MdiParent = MainMenu
            ' MainMenu.Enabled = False
            ' Me.Enabled = False
        End If

    End Sub

    Private Sub txt_disc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_disc.GotFocus
        open_conn()
        txt_disc.SelectionLength = Len(txt_disc.Text)
    End Sub

    Private Sub txt_disc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_disc.LostFocus
        open_conn()
        If txt_disc.Text = "" Then
            txt_disc.Text = FormatPercent(0, 0)
        Else
            txt_disc.Text = FormatPercent(CDbl(Replace(txt_disc.Text, "%", "")) / 100, 0)
        End If
        hitung_nominal()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        view_data()

        'Dim Total_Width_Column, Total_Width_Column2 As Integer
        'Dim Width_Table, Width_Table2 As Integer
        'Dim selisih_col, selisih_col2 As Integer

        'With DataGridView1
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(3).Width = .Columns(3).Width + selisih_col
        'End With
        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(7).Width = .Columns(7).Width + selisih_col2
        'End With
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

    Private Sub view_data()
        open_conn()
        '  If TabControl1.SelectedTabPage Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim Rows As Integer
            Dim DT As DataTable
            Dim var_date_filter As Integer
            If chk_date.Checked = True Then
                var_date_filter = 1
            Else
                var_date_filter = 0
            End If
            DT = select_sales(Trim(cbo_search.Text), Trim(txt_search.Text), 0, var_date_filter, tglawal.Value, tglakhir.Value)
            GridControl.DataSource = DT
            GridList_Customer.Columns("no_sales").Caption = "No Faktur"
            GridList_Customer.Columns("no_sales").Width = 165
            GridList_Customer.Columns("nama").Caption = "Pelanggan"
            GridList_Customer.Columns("nama").Width = 200
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 100
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("total").Caption = "Total"
            GridList_Customer.Columns("total").Width = 160
            GridList_Customer.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("total").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("subtotal").Caption = "Sub Total"
            GridList_Customer.Columns("subtotal").Width = 160
            GridList_Customer.Columns("subtotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("subtotal").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("tax").Caption = "PPN"
            GridList_Customer.Columns("tax").Width = 140
            GridList_Customer.Columns("tax").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("tax").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("discount").Caption = "Diskon"
            GridList_Customer.Columns("discount").Width = 140
            GridList_Customer.Columns("discount").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("discount").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 200
            GridList_Customer.Columns("id_customer").Visible = False
            GridList_Customer.Columns("address").Visible = False
            GridList_Customer.Columns("payment_method").Visible = False
            'GridList_Customer.BestFitColumns()
            'Rows = DT.Rows.Count - 1
            'Dim i As Integer
            'DataGridView2.Rows.Clear()
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            '        DataGridView2.Item(2, i).Value = Format(DT.Rows(i).Item(2), "yyyy-MM-dd")
            '        DataGridView2.Item(3, i).Value = FormatNumber(DT.Rows(i).Item(3), 0)
            '        DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("discount"), 0)
            '        DataGridView2.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("tax"), 0)
            '        DataGridView2.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)
            '    Next
            'End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub


    Private Sub chk_so_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        If chk_so.Checked = True Then
            DataGridView1.Enabled = False
        Else
            DataGridView1.Enabled = True
        End If
        clean()
    End Sub

    Private Sub txt_paymethod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_paymethod.SelectedIndexChanged
        open_conn()
        If txt_paymethod.Text = "Cash" Then
            txt_paid.Text = FormatNumber(Replace(txt_total.Text, ",", ""))
            txt_disc_pay.Enabled = False
            txt_discterm.Enabled = False
            txt_payterm.Enabled = False
            cbo_akun.Enabled = True
            cbo_akun.Text = ""
        Else
            txt_paid.Text = FormatNumber(0, 0)
            txt_disc_pay.Enabled = True
            txt_discterm.Enabled = True
            txt_payterm.Enabled = True
            cbo_akun.Enabled = False
            lbl_nm_akun.Visible = False
            cbo_akun.Text = ""
            If Trim(txt_cust_id.Text) <> "" Then
                cbo_akun.SelectedText = get_acc_piutang_cust(Trim(txt_cust_id.Text))
            End If
        End If
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        'current_row = cbo_acc_group.SelectedIndex
        edit = 1
        insert = 0
        chk_ppn.Checked = False
        TSubTotal = 0
        Dim DT As DataTable
        Dim rows As Integer
        Dim var_date_filter As Integer
        If chk_date.Checked = True Then
            var_date_filter = 1
        Else
            var_date_filter = 0
        End If
        DT = select_sales(cbo_search.Text, criteria, 1, var_date_filter, tglawal.Value, tglakhir.Value)
        rows = DT.Rows.Count - 1
        If DT.Rows.Count > 0 Then
            cbo_akun.Text = ""
            cbo_akun.SelectedText = DT.Rows(0).Item("id_account")
            cbo_customer.Text = DT.Rows(0).Item("no_sales_order")
            txt_cust_id.Text = DT.Rows(0).Item("id_customer")
            txt_customer_nm.Text = DT.Rows(0).Item("nama")
            txt_cust_address.Text = DT.Rows(0).Item("address")
            txt_inv_no.Text = DT.Rows(0).Item("no_sales")
            txt_date.Value = DT.Rows(0).Item("date_trn")
            txt_curr.Text = DT.Rows(0).Item("id_curr")
            txt_comment.Text = DT.Rows(0).Item("notes")
            txt_subtotal.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
            txt_disc.Text = FormatPercent(DT.Rows(0).Item("discount") / 100, 0)
            txt_netto.Text = FormatNumber(DT.Rows(0).Item("subtotal") - (DT.Rows(0).Item("subtotal") * DT.Rows(0).Item("discount") / 100), 0)
            txt_tax.Text = FormatPercent(DT.Rows(0).Item("tax") / 100, 0)
            txt_um.Text = FormatNumber(DT.Rows(0).Item("uang_muka"), 0)
            txt_freight.Text = FormatNumber(DT.Rows(0).Item("freight"), 0)
            'txt_total.Text = FormatNumber(DT.Rows(0).Item("total_head") - DT.Rows(0).Item("uang_muka"), 0)
            If DT.Rows(0).Item("payment_method") = 1 Then
                txt_paymethod.Text = "Cash"
                cbo_akun.Text = ""
                cbo_akun.Enabled = True
            ElseIf DT.Rows(0).Item("payment_method") = 2 Then
                txt_paymethod.Text = "Credit"
                cbo_akun.Text = ""
                cbo_akun.SelectedText = get_acc_piutang_cust(DT.Rows(0).Item("id_customer"))
            End If
            txt_disc_pay.Text = FormatPercent(DT.Rows(0).Item("discpay") / 100, 0)
            txt_discterm.Text = DT.Rows(0).Item("termpaydisc")
            txt_payterm.Text = DT.Rows(0).Item("term")
            txt_kurs.Text = DT.Rows(0).Item("kurs")
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(250)
            Dim i As Integer
            For i = 0 To rows
                If i >= 250 Then
                    DataGridView1.Rows.Add(1)
                End If
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("description")
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("qty"), 0)
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
                'dgvcc.Value = DT.Rows(i).Item("id_unit")
                DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
                DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)
            Next

            If DT.Rows(0).Item("tax") > 0 Then
                chk_ppn.Checked = True
            Else
                chk_ppn.Checked = False
            End If

            If txt_paymethod.Text = "Cash" Then
                cbo_akun.Text = ""
                cbo_akun.SelectedText = DT.Rows(0).Item("id_account")
                cbo_akun.Enabled = True
                lbl_nm_akun.Visible = True
                lbl_nm_akun.Text = DT.Rows(0).Item("account_name")
            ElseIf txt_paymethod.Text = "Credit" Then
                cbo_akun.Text = ""
                cbo_akun.SelectedText = get_acc_piutang_cust(DT.Rows(0).Item("id_customer"))
                cbo_akun.Enabled = False
                lbl_nm_akun.Visible = False
            End If

        End If

        DataGridView6.Rows.Clear()
        DataGridView6.Rows.Add(250)
        Dim DTX As DataTable
        DTX = select_item_bonus_sales(txt_inv_no.Text)
        If DTX.Rows.Count > 0 Then
            For i = 0 To DTX.Rows.Count - 1
                If i >= 250 Then
                    DataGridView6.Rows.Add(1)
                End If
                DataGridView6.Item(0, i).Value = i + 1
                DataGridView6.Item(1, i).Value = DTX.Rows(i).Item(1)
                DataGridView6.Item(2, i).Value = DTX.Rows(i).Item(2)
                DataGridView6.Item(3, i).Value = DTX.Rows(i).Item(3)
                DataGridView6.Item(4, i).Value = DTX.Rows(i).Item(4)
            Next

        End If
        txt_total.Text = FormatNumber(DT.Rows(0).Item("total_head"), 0)
        btn_del2.Enabled = True
        btn_cetak.Enabled = True
    End Sub


    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SALES_INV_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim var_paymethod As Integer
        Dim var_chk_so As Integer

        If txt_paymethod.Text = "Cash" Then
            var_paymethod = 1
        Else
            var_paymethod = 2
        End If

        If chk_so.Checked = True Then
            var_chk_so = 1
        ElseIf chk_so.Checked = False Then
            var_chk_so = 0
        End If

        If edit = 1 Then
            If select_validate("Sales", Trim(txt_inv_no.Text)) > 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Faktur Sudah Lunas" & vbCrLf & "Tidak dapat merubah data")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_sales(Trim(txt_inv_no.Text), txt_date.Value, cbo_customer.Text, txt_cust_id.Text, _
                                var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
                                server_datetime(), username, server_datetime(), 0, "", "", 0, "", 0, 0, "", 0, 0, 0, "", txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), var_chk_so, cbo_akun.Text)
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

    Private Sub view_item_disc(ByVal Criteria As String)
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable
        Dim i As Integer

        DT = select_item_bonus(Criteria)
        Rows = DT.Rows.Count - 1
        DataGridView6.Rows.Clear()
        DataGridView6.Rows.Add(250)
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                If i >= 250 Then
                    DataGridView6.Rows.Add(1)
                End If
                DataGridView6.Item(0, i).Value = i + 1
                DataGridView6.Item(1, i).Value = DT.Rows(i).Item(1)
                DataGridView6.Item(2, i).Value = DT.Rows(i).Item(2)
                DataGridView6.Item(3, i).Value = DT.Rows(i).Item(3)
                DataGridView6.Item(4, i).Value = DT.Rows(i).Item(4)
            Next
        End If
    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("SALES", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("SALES", "TRANS")
            cbo_search.Text = "Invoice No"
            txt_inv_no.Text = no_master
        End If
    End Sub

    Private Sub txt_inv_no_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_inv_no.TextChanged

    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub

    Private Sub chk_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_date.CheckedChanged
        open_conn()
        If chk_date.Checked = True Then
            tglawal.Enabled = True
            tglakhir.Enabled = True
        Else
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

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        'Dim cryRpt3 As New ReportDocument
        'Dim pathfilereport As String
        'Dim pathfilepdf As String
        'Dim ReportFormula As String

        'pathfilereport = Application.StartupPath & "\Report\FakturJual.rpt"
        'pathfilepdf = Application.StartupPath & "\Report\FakturJual.pdf"

        'Try
        '    cryRpt3.Load(pathfilereport)

        '    ReportFormula = "{view_ctk_so1.no_sales} = '" & Trim(txt_inv_no.Text) & "'"
        '    cryRpt3.RecordSelectionFormula = ReportFormula

        '    Dim CrExportOptions As ExportOptions
        '    Dim CrDiskFileDestinationOptions As New  _
        '    DiskFileDestinationOptions()
        '    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        '    CrDiskFileDestinationOptions.DiskFileName = pathfilepdf
        '    CrExportOptions = cryRpt3.ExportOptions
        '    With CrExportOptions
        '        .ExportDestinationType = ExportDestinationType.DiskFile
        '        .ExportFormatType = ExportFormatType.PortableDocFormat
        '        .DestinationOptions = CrDiskFileDestinationOptions
        '        .FormatOptions = CrFormatTypeOptions
        '    End With
        '    cryRpt3.Export()
        '    System.Diagnostics.Process.Start(pathfilepdf)

        'Catch ex As Exception
        '    MsgBox("Faktur Sudah Di buka, tutup faktur terlebih dahulu", vbInformation, "Information")
        'End Try
        open_conn()
        Dim DisplayNota As New FormFakturJual
        NoFakturJual = Trim(txt_inv_no.Text)
        With DisplayNota
            .Show()
            '  .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub cbo_akun_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_akun.GotFocus
        open_conn()
        cbo_akun.DroppedDown = True
    End Sub

    Private Sub cbo_akun_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_akun.LostFocus
        open_conn()
        cbo_akun.DroppedDown = False
    End Sub

    Private Sub cbo_akun_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_akun.SelectedIndexChanged
        On Error Resume Next
        open_conn()
        lbl_nm_akun.Text = cbo_akun.SelectedItem.Col2
        lbl_nm_akun.Visible = True
    End Sub

    Private Sub chk_ppn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ppn.CheckedChanged
        open_conn()
        'TSubTotal = 0
        Dim diskon As Double
        diskon = CDbl(Replace(txt_disc.Text, "%", "")) / 100 * (CDbl(Replace(txt_subtotal.Text, ",", "")))
        If chk_ppn.Checked = True Then
            Dim DT As DataTable
            DT = get_tax_rate("PPN")
            txt_tax.Text = DT.Rows(0).Item(0)
            txt_tax_nominal.Text = FormatNumber((DT.Rows(0).Item(0) / 100) * (CDbl(Replace(txt_subtotal.Text, ",", "")) - diskon), 0)
        ElseIf chk_ppn.Checked = False Then
            txt_tax.Text = 0
            txt_tax_nominal.Text = 0
        End If
        'Dim rows As Integer
        'Dim i As Integer
        'rows = DataGridView1.Rows.Count - 1
        'For i = 0 To rows
        '    TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        'Next
        'txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        'hitung_nominal()
    End Sub

    Private Sub txt_disc_pay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_disc_pay.LostFocus
        open_conn()
        Dim disc_pay As Double
        disc_pay = Replace(txt_disc_pay.Text, "%", "")
        txt_disc_pay.Text = FormatPercent(disc_pay / 100, 0)
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        open_conn()
        Dim colIndex As Integer
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        If colIndex = 8 Then
            Dim DisplayNota As New FormFakturJual
            NoFakturJual = Trim(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    'Private Sub frmsales_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(3).Width = .Columns(3).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(7).Width = .Columns(7).Width + selisih_col2
    '    End With
    'End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbo_customer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_customer.SelectedIndexChanged

    End Sub

    Private Sub cbo_customer_TextChanged(sender As Object, e As System.EventArgs) Handles cbo_customer.TextChanged
        txt_date.Value = Now
        view_item_disc(Trim(cbo_customer.Text))
    End Sub

    Private Sub txt_freight_LostFocus(sender As Object, e As System.EventArgs) Handles txt_freight.LostFocus
        'open_conn()
        'TSubTotal = 0
        'Dim diskon As Double
        'diskon = CDbl(Replace(txt_disc.Text, "%", "")) / 100 * (CDbl(Replace(txt_subtotal.Text, ",", "")))
        'If chk_ppn.Checked = True Then
        '    Dim DT As DataTable
        '    DT = get_tax_rate("PPN")
        '    txt_tax.Text = DT.Rows(0).Item(0)
        '    txt_tax_nominal.Text = FormatNumber((DT.Rows(0).Item(0) / 100) * (CDbl(Replace(txt_subtotal.Text, ",", "")) - diskon), 0)
        'ElseIf chk_ppn.Checked = False Then
        '    txt_tax.Text = 0
        '    txt_tax_nominal.Text = 0
        'End If
        'Dim rows As Integer
        'Dim i As Integer
        'rows = DataGridView1.Rows.Count - 1
        'For i = 0 To rows
        '    TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        'Next
        'txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        'hitung_nominal()
        'txt_freight.Text = FormatNumber(txt_freight.Text, 0)
    End Sub

    Private Sub txt_freight_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_freight.TextChanged

    End Sub

    Private Sub txt_curr_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txt_curr.SelectedIndexChanged

    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_sales"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_sales"))
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