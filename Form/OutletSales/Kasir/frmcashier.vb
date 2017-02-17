Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmcashier
    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Public NoFakturJual As String
    Dim FrmWidthBefore As Integer
    Dim IndexRowDg As Integer

    Private Sub frmcashier_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmcashier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmcashier_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            'Dim NewDisplayAcc As New frm_display_item
            frm_display_item.formsource_sales_item = True
            frm_display_item.Show()
            ' MainMenu.Enabled = False
            'Me.Enabled = False
        End If
        If e.KeyCode = Keys.ShiftKey Then
            pesan = InputBox("Masukkan Nominal Pembayaran", "Konfirmasi")
            If Not IsNumeric(pesan) Then
                pesan = 0
            End If
            TextBox1.Text = FormatNumber(CDbl(pesan), 0)
            Dim var_bayar As Double
            Dim var_total As Double

            var_bayar = CDbl(Replace(TextBox1.Text, ",", ""))
            var_total = CDbl(Replace(txt_total.Text, ",", ""))
            If var_bayar < var_total Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Nominal Pembayaran Kurang")
                alertControl_success.Show(Me, info)
                TextBox1.Text = 0
                TextBox2.Text = 0
                Exit Sub
            End If
            TextBox1.Text = FormatNumber(TextBox1.Text, 0)
            TextBox2.Text = FormatNumber((var_bayar - var_total), 0)

        End If
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        Dim DT As New DataTable
        Dim Rows As Integer
        Dim i As Integer
        If get_count_outlet() = 0 Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Belum ada outlet yang di setting")
            alertControl_warning.Show(Me, info)
            Me.Close()
            Exit Sub
        End If
        If get_count_outlet() > 1 Then
            MsgBox("Setting Outlet tidak sesuai, silahkan cek outlet", MsgBoxStyle.Information, "Informasi")
            Me.Close()
            Exit Sub
        End If
        insert = 1
        edit = 0
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        If insert = 1 Then
            Call insert_no_trans("CASHIER", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("CASHIER", "TRANS")
            cbo_search.Text = "Transaction No"
            txt_inv_no.Text = no_master
        End If
        cbo_search.Text = "Transaction No"
        'DataGridView1.Item(0, 0).Value = 1
        'DataGridView1.Focus()
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        txt_paid.Text = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
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
        txt_curr.Text = "IDR"
        txt_paymethod.Text = "Cash"
        Call init_number()
        chk_date.Checked = False
        tglawal.Enabled = False
        tglakhir.Enabled = False
        datagrid_layout()
        chk_so.Checked = True
        LoadComboBox_MtgcComboBoxAkun()
        txt_tax_nominal.Text = 0
        txt_totalcsh.Text = 0
        FrmWidthBefore = Me.Width
        ' Me.WindowState = FormWindowState.Normal
        cbo_customer.Enabled = False
        txt_customer_nm.Enabled = True
        txt_cust_address.Enabled = True
        txt_customer_phone.Enabled = True
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(200)
        'frm_display_item.formsource_sales_item = True
        'frm_display_item.Show()
        txtbarcode.Focus()
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

    Dim TSubTotal As Double

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim i As Integer
        Dim rows As Integer
        Dim columnIndex As Integer
        TSubTotal = 0
        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        If columnIndex = 4 Or columnIndex = 6 Or columnIndex = 8 Then
            Dim DT_stock As DataTable
            DT_stock = select_get_stock(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
            If DT_stock.Rows(0).Item(0) < DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value And DataGridView1.Item(10, DataGridView1.CurrentCell.RowIndex).Value = 1 Then
                pesan = MsgBox("Stok " & DT_stock.Rows(0).Item(0) & " tidak mencukupi untuk transaksi" & vbCrLf & "Anda yakin akan lanjut?")

                If pesan = vbNo Then
                    DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
                End If
            End If
            DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value * DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value, 0)
            DataGridView1.Item(9, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value - (DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value / 100 * DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value), 0)
            DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value, 0)
        End If
        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
            DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = 0
            DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = 0
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Silahkan tambah item transaksi")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        rows = DataGridView1.Rows.Count - 1
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(9, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)

        hitung_nominal()
    End Sub

    Public Sub hitung_nominal()
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
        txt_total.Text = FormatNumber(Ttotal, 0)

        'menghitung change
        If Trim(txt_paid.Text) = "" Then
            txt_paid.Text = 0
        End If

        Tchange = (CDbl(txt_paid.Text)) - Ttotal
        txt_change.Text = FormatNumber(Tchange, 0)
        txt_totalcsh.Text = txt_total.Text

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
            .txt_curr.Text = "IDR"
            .txt_paymethod.Text = "Cash"
            .cbo_akun.Text = ""
            .txt_tax_nominal.Text = 0
            .chk_ppn.Checked = False
            .txt_totalcsh.Text = 0
            .txt_customer_phone.Text = ""
            .TextBox1.Text = 0
        End With
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(200)
        Call select_control_no("CASHIER", "TRANS")
        txt_inv_no.Text = no_master
        cbo_search.Text = "Transaction No"
        insert = 1
        edit = 0
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        init_number()
        lbl_nm_akun.Visible = False
        CheckBox1.Checked = False
        btn_save.Enabled = True
        lbl_item_nm.Text = ""
    End Sub

    Private Sub insert_data()
        open_conn()
        Dim i As Integer
        Dim var_paymethod As Integer
        Dim var_chk_so As Integer
        Dim member As Integer

        var_paymethod = 1

        If chk_so.Checked = True Then
            var_chk_so = 1
        ElseIf chk_so.Checked = False Then
            var_chk_so = 0
        End If

        If CheckBox1.Checked = True Then
            member = 1
        ElseIf CheckBox1.Checked = False Then
            member = 0
        End If

        Dim nobukti As String
        nobukti = Trim(txt_inv_no.Text)
        If insert = 1 Then
            Call insert_cashier(Trim(txt_inv_no.Text), txt_date.Value, txt_customer_nm.Text, txt_cust_address.Text, txt_customer_phone.Text, _
                                    var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
                                    server_datetime(), username, server_datetime(), 0, "", "", 0, "", 0, 0, 0, 0, "", 0, 0, 0, txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), var_chk_so, member, cbo_customer.Text, Replace(TextBox1.Text, ",", ""))

            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then


                    Call insert_cashier(Trim(txt_inv_no.Text), txt_date.Value, txt_customer_nm.Text, txt_cust_address.Text, txt_customer_phone.Text, _
                                    var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
                                    server_datetime(), username, server_datetime(), DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, Replace(DataGridView1.Item(4, i).Value, ",", ""), DataGridView1.Item(5, i).Value, Replace(DataGridView1.Item(6, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), Replace(DataGridView1.Item(8, i).Value, ",", ""), Replace(DataGridView1.Item(9, i).Value, ",", ""), txt_curr.Text, DataGridView1.Item(10, i).Value, i, 0, txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), var_chk_so, member, cbo_customer.Text, Replace(TextBox1.Text, ",", ""))
                End If
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "CASHIER")
                pesan = MsgBox("Print Nota?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormFakturCashier
                    NoFakturJual = Trim(txt_inv_no.Text)
                    With DisplayNota
                        .Show()
                        '  .MdiParent = MainMenu
                        .WindowState = FormWindowState.Maximized
                    End With
                End If
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            'If select_validate("Sales", Trim(txt_inv_no.Text)) > 0 Then
            '    MsgBox("Sales Sudah Ada Pelunasan", MsgBoxStyle.Information, "Validate")
            '    Exit Sub
            'End If
            'Call update_sales(Trim(txt_inv_no.Text), txt_date.Value, cbo_customer.Text, txt_cust_id.Text, _
            '                    var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
            '                    server_datetime(), username, server_datetime(), 0, "", "", 0, "", 0, 0, "", 0, 0, 0, "", txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), var_chk_so, cbo_akun.Text)

            'For i = 0 To DataGridView1.Rows.Count - 1
            '    If DataGridView1.Item(1, i).Value <> "" Then


            '        Call update_sales(Trim(txt_inv_no.Text), txt_date.Value, cbo_customer.Text, txt_cust_id.Text, _
            '                    var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
            '                    server_datetime(), username, server_datetime(), DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, Replace(DataGridView1.Item(4, i).Value, ",", ""), DataGridView1.Item(5, i).Value, Replace(DataGridView1.Item(6, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), txt_curr.Text, 1, i, 0, DataGridView1.Item(8, i).Value, txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), var_chk_so, cbo_akun.Text)
            '    End If
            'Next

            'If param_sukses = True Then
            '    MsgBox("Data Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
            '    clean()
            '    'Dim R As New ReportDocument
            '    'R.Load(Application.StartupPath & "\report\StrukPenjualan.rpt")
            '    'R.RecordSelectionFormula = "{trn_sales_head.no_sales} ='" & nobukti & "'"
            '    'R.PrintToPrinter(1, False, 1, 1)
            'End If
        End If
        Dim NewDisplayAcc As New frm_display_item
        NewDisplayAcc.formsource_sales_item = True
        NewDisplayAcc.Show()
        ' MainMenu.Enabled = False
        Me.Enabled = False
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        open_conn()
        If txt_curr.Text = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih Mata Uang")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If TextBox1.Text = 0 Or IsNumeric(Replace(TextBox1.Text, ",", "")) = False Then
            MsgBox("Anda belum memasukkan pembayaran", MsgBoxStyle.Information, "Informasi")
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda belum memasukkan pembayaran")
            alertControl_warning.Show(Me, info)
            Exit Sub
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
            ' .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(7).ReadOnly = True
            .Columns(9).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(5).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(7).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(9).DefaultCellStyle.BackColor = Color.WhiteSmoke
        End With

    End Sub

    Private Sub cbo_customer_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        If chk_so.Checked = False Then
            Dim NewDisplayAcc As New frm_display_cust
            NewDisplayAcc.formsource_sales = True
            NewDisplayAcc.Show()
            ' NewDisplayAcc.MdiParent = MainMenu
            Me.Enabled = False
        Else
            Dim NewDisplayAcc As New frm_display_so
            NewDisplayAcc.formsource_so_sales = True
            NewDisplayAcc.Show()
            ' NewDisplayAcc.MdiParent = MainMenu
            Me.Enabled = False
        End If
    End Sub

    Private Sub txt_disc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_disc.GotFocus
        open_conn()
        txt_disc.SelectionLength = Len(txt_disc.Text)
    End Sub

    Private Sub txt_disc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_disc.LostFocus
        open_conn()
        Dim disc As Double
        disc = Replace(txt_disc.Text, "%", "")
        If txt_disc.Text = "" Then
            txt_disc.Text = FormatPercent(0, 0)
        Else
            txt_disc.Text = FormatPercent(CDbl(Replace(disc, "%", "")) / 100, 0)
        End If
        hitung_nominal()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        open_conn()
        view_data()

        Dim Total_Width_Column, Total_Width_Column2 As Integer
        Dim Width_Table, Width_Table2 As Integer
        Dim selisih_col, selisih_col2 As Integer

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(9).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 25
            .Columns(2).Width = .Columns(2).Width + selisih_col
        End With

        With DataGridView2
            Total_Width_Column2 = .Columns(0).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
            Width_Table2 = .Width
            selisih_col2 = Width_Table2 - Total_Width_Column2 - 25
            .Columns(1).Width = .Columns(1).Width + selisih_col2
        End With

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
        btn_save.Enabled = False
    End Sub

    Private Sub view_data()
        open_conn()
        Dim i As Integer
        If TabControl1.SelectedTabPage Is TabList Then
            Try
                SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
                SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
                SplashScreenManager.ActivateParentOnSplashFormClosing = True
                Dim Rows As Integer
                Dim DT As DataTable
                Dim var_date_filter As Integer
                If chk_date.Checked = True Then
                    var_date_filter = 1
                Else
                    var_date_filter = 0
                End If
                DT = select_cashier(Trim(cbo_search.Text), Trim(txt_search.Text), 0, var_date_filter, tglawal.Value, tglakhir.Value)
                Rows = DT.Rows.Count - 1
                DataGridView2.Rows.Clear()
                If DT.Rows().Count > 0 Then
                    For i = 0 To Rows
                        DataGridView2.Rows.Add()
                        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
                        DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
                        DataGridView2.Item(2, i).Value = Format(DT.Rows(i).Item(2), "yyyy-MM-dd")
                        DataGridView2.Item(3, i).Value = FormatNumber(DT.Rows(i).Item(3), 0)
                        DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item(4), 0)
                        DataGridView2.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("tax"), 0)
                        DataGridView2.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)
                    Next
                End If
            Finally
                SplashScreenManager.CloseForm(False)
            End Try

        End If
    End Sub


    Private Sub chk_so_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        clean()
    End Sub

    Private Sub txt_paymethod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        If txt_paymethod.Text = "Cash" Then
            txt_paid.Text = FormatNumber(Replace(txt_total.Text, ",", ""))
            txt_disc_pay.Enabled = False
            txt_discterm.Enabled = False
            txt_payterm.Enabled = False
            cbo_akun.Enabled = True
        Else
            txt_paid.Text = FormatNumber(0, 0)
            txt_disc_pay.Enabled = True
            txt_discterm.Enabled = True
            txt_payterm.Enabled = True
            cbo_akun.Enabled = False
            lbl_nm_akun.Visible = False
        End If
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        Dim i As Integer
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
        DT = select_cashier(cbo_search.Text, criteria, 1, var_date_filter, tglawal.Value, tglakhir.Value)
        rows = DT.Rows.Count - 1
        If DT.Rows.Count > 0 Then
            txt_inv_no.Text = DT.Rows(0).Item("no_sales")
            txt_date.Value = DT.Rows(0).Item("date_trn")
            txt_curr.Text = DT.Rows(0).Item("id_curr")
            txt_comment.Text = DT.Rows(0).Item("notes")
            If DT.Rows(0).Item("payment_method") = 1 Then
                txt_paymethod.Text = "Cash"
            ElseIf DT.Rows(0).Item("payment_method") = 2 Then
                txt_paymethod.Text = "Credit"
            End If
            If DT.Rows(0).Item("flag_member") = 1 Then
                CheckBox1.Checked = True
            ElseIf DT.Rows(0).Item("flag_member") = 0 Then
                CheckBox1.Checked = False
            End If
            txt_disc_pay.Text = FormatPercent(DT.Rows(0).Item("discpay") / 100, 0)
            txt_discterm.Text = DT.Rows(0).Item("termpaydisc")
            txt_payterm.Text = DT.Rows(0).Item("term")
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(200)
            For i = 0 To rows
                DataGridView1.Item(0, i).Value = i + 1
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("description")
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("qty"), 0)
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
                DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
                DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)
                DataGridView1.Item(8, i).Value = FormatNumber(DT.Rows(i).Item("disc_nom"), 0)
                DataGridView1.Item(9, i).Value = FormatNumber(DT.Rows(i).Item("nominal_net"), 0)
            Next

            txt_subtotal.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
            txt_disc.Text = FormatPercent(DT.Rows(0).Item("discount") / 100, 0)
            txt_netto.Text = FormatNumber(DT.Rows(0).Item("subtotal") - (DT.Rows(0).Item("subtotal") * DT.Rows(0).Item("discount") / 100), 0)
            txt_tax.Text = FormatPercent(DT.Rows(0).Item("tax") / 100, 0)

            If DT.Rows(0).Item("tax") > 0 Then
                chk_ppn.Checked = True
            Else
                chk_ppn.Checked = False
            End If
            txt_total.Text = FormatNumber(DT.Rows(0).Item("total_head"), 0)
            cbo_customer.Text = DT.Rows(0).Item("id_customer")
            txt_customer_nm.Text = DT.Rows(0).Item("customer")
            txt_cust_address.Text = DT.Rows(0).Item("address")
            txt_customer_phone.Text = DT.Rows(0).Item("cust_phone")
            txt_totalcsh.Text = FormatNumber(DT.Rows(0).Item("total_head"), 0)
        End If

    End Sub


    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()
        Dim var_paymethod As Integer
        Dim var_chk_so As Integer
        Dim member As Integer

        var_paymethod = 1

        If chk_so.Checked = True Then
            var_chk_so = 1
        ElseIf chk_so.Checked = False Then
            var_chk_so = 0
        End If

        If CheckBox1.Checked = True Then
            member = 1
        ElseIf CheckBox1.Checked = False Then
            member = 0
        End If

        If edit = 1 Then
            If select_validate("Sales", Trim(txt_inv_no.Text)) > 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Sales Sudah Ada Pelunasan")
                alertControl_success.Show(Me, info)
                Exit Sub
            End If
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                delete_cashier(Trim(txt_inv_no.Text), txt_date.Value, txt_customer_nm.Text, txt_cust_address.Text, txt_customer_phone.Text, _
                                    var_paymethod, Replace(txt_subtotal.Text, ",", ""), Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), txt_comment.Text, username, _
                                    server_datetime(), username, server_datetime(), 0, "", "", 0, "", 0, 0, 0, 0, "", 0, 0, 0, txt_payterm.Text, txt_discterm.Text, Replace(txt_disc_pay.Text, "%", ""), var_chk_so, member, cbo_customer.Text)
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

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'If insert = 1 Then
        '    var_bulan = Month(txt_date.Value)
        '    var_tahun = Year(txt_date.Value)
        '    Call insert_no_trans("CASHIER", Month(txt_date.Value), Year(txt_date.Value))
        '    Call select_control_no("CASHIER", "TRANS")
        '    cbo_search.Text = "No Penjualan"
        '    txt_inv_no.Text = no_master
        'End If
    End Sub

    'Private Sub txt_inv_no_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_inv_no.TextChanged
    '    'open_conn()
    '    'edit = 1
    '    'insert = 0
    '    'btn_del2.Enabled = True
    '    ''a = DataGridView2.CurrentCell.RowIndex
    '    'detail(txt_inv_no.Text)
    '    'TabControl1.SelectedTab = TabInput
    'End Sub

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
        cbo_search.Text = "Transaction No"
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

        'Dim DisplayNota As New FormFakturCashier
        'NoFakturJual = Trim(txt_inv_no.Text)
        'With DisplayNota
        '    .Show()
        '    ' .CRviewer.Refresh()
        '    '  .MdiParent = MainMenu
        '    .WindowState = FormWindowState.Maximized
        'End With

    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub cbo_akun_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_akun.DroppedDown = True
    End Sub

    Private Sub cbo_akun_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        cbo_akun.DroppedDown = False
    End Sub

    Private Sub cbo_akun_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        On Error Resume Next
        lbl_nm_akun.Text = cbo_akun.SelectedItem.Col2
        lbl_nm_akun.Visible = True
    End Sub

    Private Sub chk_ppn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ppn.CheckedChanged
        open_conn()
        Dim i As Integer
        TSubTotal = 0
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
        Dim rows As Integer
        rows = DataGridView1.Rows.Count - 1
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(9, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        hitung_nominal()
    End Sub

    Private Sub txt_disc_pay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim disc_pay As Double
        disc_pay = txt_disc_pay.Text
        txt_disc_pay.Text = FormatPercent(disc_pay / 100, 0)
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        open_conn()
        Dim colIndex As Integer
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        If colIndex = 8 Then
            Dim DisplayNota As New FormFakturCashier
            NoFakturJual = Trim(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        IndexRowDg = DataGridView1.CurrentCell.RowIndex
        If e.KeyCode = Keys.Delete Then
            pesan = MessageBox.Show("Data ingin di hapus?", "Konfirmasi", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                DataGridView1.Rows.RemoveAt(IndexRowDg)
            End If
        End If
    End Sub

    Private Sub frmcashier_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        open_conn()
        Dim Total_Width_Column, Total_Width_Column2 As Integer
        Dim Width_Table, Width_Table2 As Integer
        Dim selisih_col, selisih_col2 As Integer

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(9).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 245
            .Columns(2).Width = .Columns(2).Width + selisih_col
        End With

        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 25
        '    .Columns(7).Width = .Columns(7).Width + selisih_col2
        'End With

        Panel2.Left = (Me.Width - Panel2.Width) / 2
        Panel2.Top = (Me.Height - Panel2.Height) / 2

    End Sub


    Private Sub DataGridView1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        open_conn()
        Dim rows As Integer
        Dim i As Integer
        TSubTotal = 0
        rows = DataGridView1.Rows.Count - 1
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(9, i).Value, ",", "")
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)

        hitung_nominal()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            cbo_customer.Enabled = True
            cbo_customer.Text = ""
            txt_customer_nm.Enabled = False
            txt_customer_nm.Text = ""
            txt_cust_address.Enabled = False
            txt_cust_address.Text = ""
            txt_customer_phone.Enabled = False
            txt_customer_phone.Text = ""
            btn_plus.Enabled = True
            cbo_customer.Focus()
        ElseIf CheckBox1.Checked = False Then
            cbo_customer.Enabled = False
            cbo_customer.Text = ""
            txt_customer_nm.Enabled = True
            txt_customer_nm.Text = ""
            txt_cust_address.Enabled = True
            txt_cust_address.Text = ""
            txt_customer_phone.Enabled = True
            txt_customer_phone.Text = ""
            btn_plus.Enabled = False
        End If
    End Sub

    Private Sub btn_plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plus.Click
        Dim form1 As New frmcustomer2
        frmcustomer2.Show()
    End Sub

    Private Sub cbo_customer_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_customer.Click
        open_conn()
        ' Dim NewDisplayAcc As New frm_display_cust

        
        'NewDisplayAcc.MdiParent = MainMenu
        'NewDisplayAcc.WindowState = FormWindowState.Maximized
        ' MainMenu.Enabled = False
        'Me.Enabled = False

        'view barcode member
        


    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        
    End Sub


    Private Sub cbo_customer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_customer.SelectedIndexChanged

    End Sub

    Private Sub NavBarGroupControlContainer2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub chk_date_2_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cbo_sales_no_LostFocus(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button11_MouseHover(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button11_MouseLeave(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_MouseHover(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub NavBarControl6_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub NavBarGroupControlContainer3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_DockChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.DockChanged

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        Dim i As Integer
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        Dim Rows As Integer
        i = DataGridView1.CurrentCell.ColumnIndex

        If i = 5 Then
            Dim NewDisplayAcc As New frm_display_unit
            NewDisplayAcc.formsource_sales_unit = True
            NewDisplayAcc.Show()
            '    NewDisplayAcc.MdiParent = MainMenu
            Me.Enabled = False
            Dim dgvcc As DataGridViewComboBoxCell
            dgvcc = DataGridView1.Rows(mRow).Cells(5)
            dgvcc.Items.Clear()
            Rows = select_unit.Rows.Count - 1
            For i = 0 To Rows
                dgvcc.Items.Add(select_unit.Rows(i).Item(0))
            Next
        End If
        'If mRow = 0 Then
        '    DataGridView1.Rows.Add(1)
        'End If
        If DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value = "" Then
            DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = 0
        End If
    End Sub

    Private Sub txtbarcode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbarcode.TextChanged
        If Len(txtbarcode.Text) = 10 Then
            Dim DT As New DataTable
            Dim DTPrice, DTUnit As New DataTable
            Dim a As Integer

            DT = select_item("id_item", Trim(txtbarcode.Text))

            If DT.Rows.Count > 0 And Trim(txtbarcode.Text <> "") Then
                For a = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(1, a).Value = DT.Rows(0).Item(0) Then
                        MsgBox("Item tersebut sudah ada di detail transaksi", MsgBoxStyle.Information, "Perhatian")
                        Exit Sub
                    End If
                Next
            End If

            If DT.Rows.Count > 0 And Trim(txtbarcode.Text <> "") Then
                lbl_item_nm.Text = DT.Rows(0).Item(1)
                DataGridView1.Item(0, mRow).Value = DataGridView1.CurrentCell.RowIndex + 1
                DataGridView1.Item(1, mRow).Value = DT.Rows(0).Item(0)
                DataGridView1.Item(2, mRow).Value = DT.Rows(0).Item(1)
                DataGridView1.Item(4, mRow).Value = 1
                DTPrice = select_get_price(DT.Rows(0).Item(0))
                DataGridView1.Item(6, mRow).Value = FormatNumber(DTPrice.Rows(0).Item(0), 0)
                DTUnit = select_get_defunit(DT.Rows(0).Item(0))
                DataGridView1.Item(5, mRow).Value = DTUnit.Rows(0).Item(0)
                DataGridView1.Item(8, mRow).Value = 0
                DataGridView1.Item(7, mRow).Value = FormatNumber(DTPrice.Rows(0).Item(0), 0)
                DataGridView1.Item(9, mRow).Value = FormatNumber(DTPrice.Rows(0).Item(0), 0)
                DataGridView1.Item(10, mRow).Value = 1
                DataGridView1.CurrentCell = DataGridView1.Rows(mRow + 1).Cells(1)
                Dim TSubTotal As Double
                TSubTotal = 0
                Dim DT_stock As DataTable
                DT_stock = select_get_stock(DataGridView1.Item(1, mRow).Value)
                If DT_stock.Rows(0).Item(0) < DataGridView1.Item(4, mRow).Value And DataGridView1.Item(10, mRow).Value = 1 Then
                    pesan = MsgBox("Pencatatan Stok " & DT_stock.Rows(0).Item(0) & " tidak tersedia, " & vbCrLf & "Apakah Anda ingin lanjut?")
                    If pesan = vbNo Then
                        DataGridView1.Item(4, mRow).Value = 0
                    End If
                End If
                DataGridView1.Item(7, mRow).Value = FormatNumber((DataGridView1.Item(6, mRow).Value * DataGridView1.Item(4, mRow).Value), 0)
                DataGridView1.Item(9, mRow).Value = FormatNumber((DataGridView1.Item(6, mRow).Value * DataGridView1.Item(4, mRow).Value), 0)
                For a = 0 To DataGridView1.Rows.Count - 1
                    TSubTotal = TSubTotal + Replace(DataGridView1.Item(9, a).Value, ",", "")
                Next
                txt_subtotal.Text = FormatNumber(TSubTotal, 0)

                hitung_nominal()
                txtbarcode.Text = ""
                txtbarcode.Focus()
            End If
        End If
    End Sub

    Private Sub btn_save2_Click(sender As System.Object, e As System.EventArgs) Handles btn_save2.Click
        'Panel1.Enabled = False
        Panel2.Visible = True
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Panel2.Visible = False
        'Panel1.Enabled = True
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub XtraTabControl1_Click(sender As System.Object, e As System.EventArgs) Handles TabControl1.Click, TabControl1.Click

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim form1 As New frm_display_cust
        frm_display_cust.Show()
        frm_display_cust.formsource_cashier = True
    End Sub

    Private Sub cbo_customer_TextChanged(sender As Object, e As System.EventArgs) Handles cbo_customer.TextChanged
        If Len(cbo_customer.Text) = 12 Then
            Dim DT As DataTable
            DT = select_master("select_customer", "id_customer", Trim(cbo_customer.Text), 3, 0, server_datetime(), server_datetime())
            If DT.Rows.Count > 0 Then
                txt_customer_nm.Text = DT.Rows(0).Item("name")
                txt_cust_address.Text = DT.Rows(0).Item("address")
            Else
                cbo_customer.Text = ""
                Dim info As AlertInfo = New AlertInfo("Informasi", "Member belum terdaftar")
                alertControl_warning.Show(Me, info)
                txt_customer_nm.Focus()
            End If
        End If
    End Sub
End Class