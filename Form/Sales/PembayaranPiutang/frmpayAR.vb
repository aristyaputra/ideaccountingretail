Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmpayAR
    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Public var_t_payment As Double
    Dim pesan As String
    Public NoBuktiBayarAR As String

    Private Sub frmpayAR_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmpayAR_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("PAYAR", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("PAYAR", "TRANS")
        cbo_search.Text = "Payment No"
        txt_billno.Text = no_master
        'DataGridView1.Item(0, 0).Value = 1
        'DataGridView1.Focus()
        btn_del2.Enabled = False
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'btn_cetak.Visible = False
        txt_total.Enabled = False
        Call init_number()
        'isi combo payment method
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_pay_method()
        Dim i As Integer
        Rows = DT.Rows.Count - 1
        For i = 0 To Rows
            cbo_acc.Items.Add(DT.Rows(i).Item(0))
        Next
        txt_curr.Items.Clear()
        Rows = select_curr.Rows.Count - 1
        For i = 0 To Rows
            txt_curr.Items.Add(select_curr.Rows(i).Item(0))
        Next
        datagrid_layout()
        clean()
        'list_data()
        'isi combo search
        'cbo_search.Items.Add("Invoice No")
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        LoadComboBox_MtgcComboBoxAkun()
        txt_curr.Text = get_def_curr()
        CheckKurs.Checked = True
        list_data()
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxAkun()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_acc()

        cbo_acc.SelectedIndex = -1
        cbo_acc.Items.Clear()
        cbo_acc.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_acc.SourceDataString = New String(1) {"id_account", "account_name"}
        cbo_acc.SourceDataTable = dtLoading
        cbo_acc.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub get_nominal_bayar()
        Dim rows As Integer
        rows = DataGridView1.Rows.Count
        If rows > 0 Then
            For i = 0 To rows - 1
                If txt_curr.Text <> get_def_curr() Then
                    If CheckKurs.Checked = True Then
                        DataGridView1.Item(10, i).Value = FormatNumber(get_def_convertcurr(txt_curr.Text), 0)
                    ElseIf CheckKurs.Checked = False Then
                        If DataGridView1.Item(12, i).Value = txt_curr.Text Then
                            DataGridView1.Item(10, i).Value = FormatNumber(get_kurs_sales(DataGridView1.Item(1, i).Value), 0)
                        Else
                            DataGridView1.Item(10, i).Value = FormatNumber(get_def_convertcurr(txt_curr.Text), 0)
                        End If
                    End If
                Else
                    DataGridView1.Item(10, i).Value = 1
                End If
                If DataGridView1.Item(8, i).Value <> "" Then
                    DataGridView1.Item(11, i).Value = FormatNumber((DataGridView1.Item(10, i).Value * DataGridView1.Item(8, i).Value), 0)
                End If
            Next
        End If
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        With Me
            .lb_idAccpayment.Text = ""
            .txt_idsupplier.Text = ""
            .cbo_supplier.Text = ""
            .txt_supplier_nm.Text = ""
            .txt_supplier_address.Text = ""
            .txt_billno.Text = ""
            .DataGridView1.Rows.Clear()
            .txt_comment.Text = ""
            .txt_date.Value = Now
            .txt_total.Text = ""
            .cbo_acc.Text = ""
        End With
        init_number()
        Call select_control_no("PAYAR", "TRANS")
        txt_billno.Text = no_master
        txt_date.Value = Now
        btn_del2.Enabled = False
        txt_curr.Text = get_def_curr()
    End Sub

    Private Sub init_number()
        open_conn()
        txt_total.Text = 0
        txt_total_ap.Text = 0
        txt_total_disc.Text = 0
        txt_total_return.Text = 0
        txt_total_net.Text = 0
        txt_payment.Text = 0
    End Sub

    Private Sub list_data()
        open_conn()
        'If TabControl1.SelectedTabPage Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim Rows As Integer
            Dim DT As DataTable
            Dim date_filter As Integer
            If chk_date.Checked = True Then
                date_filter = 1
            ElseIf chk_date.Checked = False Then
                date_filter = 0
            End If

            DT = select_ARpayment(cbo_search.Text, txt_search.Text, 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
            GridControl.DataSource = DT
            GridList_Customer.Columns("no_payment_ar").Caption = "No Pembayaran"
            GridList_Customer.Columns("no_payment_ar").Width = 160
            GridList_Customer.Columns("customer_name").Caption = "Pelanggan"
            GridList_Customer.Columns("customer_name").Width = 180
            GridList_Customer.Columns("account_name").Caption = "Melalui"
            GridList_Customer.Columns("account_name").Width = 180
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 100
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("total").Caption = "Total"
            GridList_Customer.Columns("total").Width = 160
            GridList_Customer.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("total").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("id_customer").Visible = False
            GridList_Customer.Columns("id_account").Visible = False
            'GridList_Customer.Columns("account_name").Visible = False
            GridList_Customer.Columns("number_asc").Visible = False
            GridList_Customer.Columns("no_invoice").Visible = False
            GridList_Customer.Columns("invoice_date").Visible = False
            GridList_Customer.Columns("ap_amount").Visible = False
            GridList_Customer.Columns("discount").Visible = False
            GridList_Customer.Columns("ap_amount_net").Visible = False
            GridList_Customer.Columns("paid_amount").Visible = False
            GridList_Customer.Columns("customer_addr").Visible = False
            GridList_Customer.Columns("ap_return").Visible = False
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 250
            'GridList_Customer.BestFitColumns()
            'Rows = DT.Rows.Count - 1
            'DataGridView2.Rows.Clear()
            'Dim i As Integer
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            '        DataGridView2.Item(2, i).Value = Format(DT.Rows(i).Item(2), "dd-MMM-yyyy")
            '        DataGridView2.Item(3, i).Value = FormatNumber(DT.Rows(i).Item("ap_amount_net"), 0)
            '        DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item(14), 0)
            '        DataGridView2.Item(5, i).Value = DT.Rows(i).Item(3)
            '        DataGridView2.Item(6, i).Value = DT.Rows(i).Item(3)
            '        'DataGridView2.Item(7, i).Value = DT.Rows(i).Item(8)
            '        'DataGridView2.Item(8, i).Value = DT.Rows(i).Item(9)
            '    Next
            'End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub insert_data()
        open_conn()
        Dim i As Integer
        Dim var_flag_kurs As Integer

        If CheckKurs.Checked = True Then
            var_flag_kurs = 1
        ElseIf CheckKurs.Checked = False Then
            var_flag_kurs = 0
        End If

        If insert = 1 Then

            'MsgBox(Trim(txt_idsupplier.Text) + "-" + Trim(lb_idAccpayment.Text))
            Call insert_paymentAR(Trim(txt_billno.Text), Trim(txt_idsupplier.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                Trim(txt_comment.Text), Replace(txt_payment.Text, ",", ""), Trim(cbo_acc.Text), username, _
                                Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                0, "", Format(txt_date.Value, "yyyy-MM-dd"), 0, 0, 0, 0, 0, 0, 0, "INSERT", txt_curr.Text, 1, var_flag_kurs, 0, Replace(txt_total_disc.Text, ",", ""))
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(9, i).Value = True Then
                    Call insert_paymentAR(Trim(txt_billno.Text), Trim(txt_idsupplier.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                Trim(txt_comment.Text), txt_total.Text, Trim(cbo_acc.Text), username, _
                                Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                i, DataGridView1.Item(1, i).Value, Format(CDate(DataGridView1.Item(2, i).Value), "yyyy-MM-dd"), _
                                Replace(DataGridView1.Item(3, i).Value, ",", ""), Replace(DataGridView1.Item(4, i).Value, ",", ""), _
                                Replace(DataGridView1.Item(5, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), Replace(DataGridView1.Item(11, i).Value, ",", ""), _
                                1, i, "INSERT", txt_curr.Text, Replace(DataGridView1.Item(10, i).Value, ",", ""), var_flag_kurs, Replace(DataGridView1.Item(8, i).Value, ",", ""), Replace(txt_total_disc.Text, ",", ""))
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_paymentAR(Trim(txt_billno.Text), Trim(txt_idsupplier.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                Trim(txt_comment.Text), Replace(txt_payment.Text, ",", ""), Trim(cbo_acc.Text), username, _
                                Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                0, "", Format(txt_date.Value, "yyyy-MM-dd"), 0, 0, 0, 0, 0, 0, 0, "UPDATE", txt_curr.Text, 1, var_flag_kurs, 0, Replace(txt_total_disc.Text, ",", ""))
            For i = 0 To DataGridView1.Rows.Count - 1
                'If CheckKurs.Checked = True Then
                '    var_kurs = get_def_convertcurr(txt_curr.Text)
                'ElseIf CheckKurs.Checked = False Then
                '    var_kurs = get_kurs_pu(DataGridView1.Item(1, i).Value)
                'End If

                If DataGridView1.Item(9, i).Value = True Then
                    Call update_paymentAR(Trim(txt_billno.Text), Trim(txt_idsupplier.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                Trim(txt_comment.Text), txt_total.Text, Trim(cbo_acc.Text), username, _
                                Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                i, DataGridView1.Item(1, i).Value, Format(CDate(DataGridView1.Item(2, i).Value), "yyyy-MM-dd"), _
                                Replace(DataGridView1.Item(3, i).Value, ",", ""), Replace(DataGridView1.Item(4, i).Value, ",", ""), _
                                Replace(DataGridView1.Item(5, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), Replace(DataGridView1.Item(11, i).Value, ",", ""), _
                                1, i, "UPDATE", txt_curr.Text, Replace(DataGridView1.Item(10, i).Value, ",", ""), var_flag_kurs, Replace(DataGridView1.Item(8, i).Value, ",", ""), Replace(txt_total_disc.Text, ",", ""))
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

    Private Sub btn_save2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_PAYMENT_AR_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_PAYMENT_AR_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim a, b As Integer
        Dim row As Integer
        row = DataGridView1.Rows.Count - 1

        If Trim(cbo_supplier.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih pelanggan")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        If Trim(cbo_acc.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih metode pembayaran")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        For a = 0 To row
            If DataGridView1.Item(9, a).Value = True Then
                b = b + 1
            End If
        Next
        If b = 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Tidak ada data yang dipilih")
            alertControl_warning.Show(Me, info)
            Exit Sub
        ElseIf a > 0 Then
            insert_data()
        End If
    End Sub

    Dim TSubTotal As Double
    Dim TDiskon As Double
    Dim THrsBayar As Double
    Dim TTerbayar As Double
    Dim TPayAp As Double
    Dim TReturn As Double
    Dim var_temp_disc As Double
    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        Dim columnIndex As Integer
        columnIndex = DataGridView1.CurrentCell.ColumnIndex

        If columnIndex = 5 Or columnIndex = 8 Then
            var_temp_disc = 0
            If Replace(DataGridView1.Item(11, DataGridView1.CurrentCell.RowIndex).Value, ",", "") <= 0 Then
                var_temp_disc = get_disc_pay_ar(txt_idsupplier.Text, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim rows As Integer
        Dim columnIndex As Integer
        Dim i As Integer
        TSubTotal = 0
        columnIndex = DataGridView1.CurrentCell.ColumnIndex

        If columnIndex = 8 Or columnIndex = 5 Then
            get_nominal_bayar()
            If Replace(DataGridView1.Item(11, DataGridView1.CurrentCell.RowIndex).Value, ",", "") < Replace(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, ",", "") Then
                'MsgBox("Jika Pembayaran Masih Sebagian," & vbCrLf & "Tidak ada diskon termin bayar", MsgBoxStyle.Information, "Konfirmasi")
                'DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value - DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value, 0)
                'DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = 0
            ElseIf Replace(DataGridView1.Item(11, DataGridView1.CurrentCell.RowIndex).Value, ",", "") <= 0 Then
                ' var_temp_disc = DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value
                DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = 0
            ElseIf Replace(DataGridView1.Item(11, DataGridView1.CurrentCell.RowIndex).Value, ",", "") >= Replace(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, ",", "") Then
                'DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(Math.Round(get_disc_pay_ap(txt_idsupplier.Text, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value), 0), 0)
                'ElseIf Replace(DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value, ",", "") > Replace(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, ",", "") Then
                '    MsgBox("Pembayaran melebihi total hutang!", MsgBoxStyle.Information, "Konfirmasi")
                '    Dim total_hutang As Double
                '    total_hutang = Replace(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value, ",", "")
                '    DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(total_hutang, 0)
                '    DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(Math.Round(get_disc_pay_ap(txt_idsupplier.Text, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value), 0), 0)
            End If
            'If DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value <= 0 Then
            ' DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value - DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value - var_temp_disc - DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value, 0)
            'Else
            DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value - DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value - DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value - DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value, 0)
            ' End If

            DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value, 0)
            get_nominal_bayar()

        End If
        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
            DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value = 0
            'MsgBox("Item is Empty!", MsgBoxStyle.Critical, "Masukkan Item PO")
            Exit Sub
        End If
        hitung_total()
    End Sub

    Private Sub hitung_total()
        TSubTotal = 0
        TDiskon = 0
        THrsBayar = 0
        TTerbayar = 0
        TPayAp = 0
        TReturn = 0
        Dim arows As Integer
        arows = DataGridView1.Rows.Count - 1
        For i = 0 To arows
            Dim checkbox_cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(i).Cells(9), DataGridViewCheckBoxCell)
            If checkbox_cell.EditedFormattedValue = True Then
                TPayAp = TPayAp + Replace(DataGridView1.Item(3, i).Value, ",", "")
                TReturn = TReturn + +Replace(DataGridView1.Item(4, i).Value, ",", "")
                TDiskon = TDiskon + Replace(DataGridView1.Item(5, i).Value, ",", "")
                THrsBayar = THrsBayar + Replace(DataGridView1.Item(7, i).Value, ",", "")
                TSubTotal = TSubTotal + Replace(DataGridView1.Item(11, i).Value, ",", "")
                TTerbayar = TTerbayar + Replace(DataGridView1.Item(6, i).Value, ",", "")
            End If
        Next
        txt_total_ap.Text = FormatNumber(TPayAp, 0)
        txt_total_return.Text = FormatNumber(TReturn, 0)
        txt_payment.Text = FormatNumber(TSubTotal, 0)
        txt_total_disc.Text = FormatNumber(TDiskon, 0)
        txt_total.Text = FormatNumber(THrsBayar, 0)
        txt_total_net.Text = FormatNumber(TTerbayar, 0)
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex
        DataGridView1.Item(0, mRow).Value = mRow + 1
    End Sub

    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_PAYMENT_AR_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim i As Integer
        Dim var_flag_kurs As Integer

        If CheckKurs.Checked = True Then
            var_flag_kurs = 1
        ElseIf CheckKurs.Checked = False Then
            var_flag_kurs = 0
        End If
        If edit = 1 Then
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_paymentAR(Trim(txt_billno.Text), Trim(txt_idsupplier.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                Trim(txt_comment.Text), Replace(txt_payment.Text, ",", ""), Trim(cbo_acc.Text), username, _
                                Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                0, "", Format(txt_date.Value, "yyyy-MM-dd"), 0, 0, 0, 0, 0, 0, 0, "DELETE", txt_curr.Text, 1, var_flag_kurs)

                For i = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(1, i).Value <> "" Then
                        Call delete_paymentAR(Trim(txt_billno.Text), Trim(txt_idsupplier.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
                                Trim(txt_comment.Text), txt_total.Text, Trim(cbo_acc.Text), username, _
                                Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), _
                                i, DataGridView1.Item(1, i).Value, Format(CDate(DataGridView1.Item(2, i).Value), "yyyy-MM-dd"), _
                                Replace(DataGridView1.Item(3, i).Value, ",", ""), Replace(DataGridView1.Item(4, i).Value, ",", ""), _
                                Replace(DataGridView1.Item(5, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), Replace(DataGridView1.Item(11, i).Value, ",", ""), _
                                1, i, "DELETE", txt_curr.Text, Replace(DataGridView1.Item(10, i).Value, ",", ""), var_flag_kurs)
                    End If
                Next
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

    Private Sub generate()
        open_conn()
        Dim mRow As Integer
        Dim noBill As String
        Dim Rows As Integer
        Dim DT As DataTable

        Dim var_t_purchase As Double
        Dim var_t_return As Double
        Dim var_t_disc As Double
        Dim var_t_total As Double
        Dim var_t_pay As Double
        Dim var_t_paid As Double
        insert = 0
        edit = 1
        TabControl1.SelectedTabPage = TabInput
        'mRow = DataGridView2.CurrentCell.RowIndex
        noBill = GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_payment_ar")
        'edit data
        Dim date_filter As Integer
        If chk_date.Checked = True Then
            date_filter = 1
        ElseIf chk_date.Checked = False Then
            date_filter = 0
        End If
        DT = select_ARpayment("Detail", noBill, 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd")) 'ganti SP
        Rows = DT.Rows.Count - 1
        cbo_supplier.Text = DT.Rows(0).Item("id_customer")
        txt_idsupplier.Text = DT.Rows(0).Item("id_customer")
        txt_supplier_nm.Text = DT.Rows(0).Item("customer_name")
        txt_supplier_address.Text = DT.Rows(0).Item("customer_addr")
        txt_date.Value = DT.Rows(0).Item("date_trn")
        txt_billno.Text = DT.Rows(0).Item("no_payment_ar")
        txt_comment.Text = DT.Rows(0).Item("notes")
        'txt_total.Text = FormatNumber(DT.Rows(0).Item("total"), 0)
        txt_idsupplier.Text = cbo_supplier.Text
        cbo_acc.Text = ""
        cbo_acc.SelectedText = DT.Rows(0).Item("id_account")
        lb_idAccpayment.Text = DT.Rows(0).Item("account_name")

        DataGridView1.Rows.Clear()
        Dim i As Integer
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = (i + 1).ToString
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item("no_invoice")
            DataGridView1.Item(2, i).Value = Format(DT.Rows(i).Item("invoice_date"), "yyyy-MM-dd")
            DataGridView1.Item(3, i).Value = FormatNumber(DT.Rows(i).Item("ap_amount"), 0)
            var_t_purchase = var_t_purchase + DataGridView1.Item(3, i).Value
            DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("ap_return"), 0)
            var_t_return = var_t_return + DataGridView1.Item(4, i).Value
            DataGridView1.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("discount"), 0)
            var_t_disc = var_t_disc + DataGridView1.Item(5, i).Value
            DataGridView1.Item(6, i).Value = FormatNumber(0, 0)
            var_t_total = var_t_total + DataGridView1.Item(6, i).Value
            DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("ap_amount_net"), 0)
            var_t_pay = var_t_pay + DataGridView1.Item(7, i).Value
            DataGridView1.Item(8, i).Value = FormatNumber(DT.Rows(i).Item("paid_amount") / DT.Rows(i).Item("kurs"), 0)
            DataGridView1.Item(9, i).Value = True
            DataGridView1.Item(10, i).Value = FormatNumber(DT.Rows(i).Item("kurs"), 0)
            DataGridView1.Item(11, i).Value = FormatNumber(DT.Rows(i).Item("paid_amount"), 0)
            var_t_paid = var_t_paid + DataGridView1.Item(11, i).Value
        Next
        txt_total_ap.Text = FormatNumber(var_t_purchase, 0)
        txt_total_return.Text = FormatNumber(var_t_return, 0)
        txt_total_disc.Text = FormatNumber(var_t_disc, 0)
        txt_total_net.Text = FormatNumber(var_t_total, 0)
        txt_total.Text = FormatNumber(var_t_pay, 0)
        txt_payment.Text = FormatNumber(var_t_paid, 0)
        insert = 0
        edit = 1
        btn_del2.Enabled = True
    End Sub

    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
       
    End Sub
    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(3).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(4).DefaultCellStyle.BackColor = Color.WhiteSmoke
        'DataGridView1.Columns(5).DefaultCellStyle.BackColor = Color.Wheat
        DataGridView1.Columns(6).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(7).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(10).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(11).DefaultCellStyle.BackColor = Color.WhiteSmoke

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
        'DataGridView1.Columns(5).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = True
        DataGridView1.Columns(7).ReadOnly = True
        DataGridView1.Columns(10).ReadOnly = True
        DataGridView1.Columns(11).ReadOnly = True


        With DataGridView1
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub cbo_supplier_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_supplier.Click
        open_conn()
        Dim NewDisplayAcc As New frm_display_cust
        NewDisplayAcc.formsource_frmpayAR = True
        NewDisplayAcc.Show()
        ' NewDisplayAcc.MdiParent = MainMenu
        clean()
        ' MainMenu.Enabled = False
        Me.Enabled = False
    End Sub

    Private Sub txt_idsupplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_idsupplier.TextChanged
        open_conn()

        Dim var_t_purchase As Double
        Dim var_t_return As Double
        Dim var_t_disc As Double
        Dim var_t_total As Double
        Dim i As Integer
        var_t_payment = 0
        If edit = 0 Then
            Dim Rows As Integer
            Dim DT As DataTable
            DT = select_sales2("A/R Payment", txt_idsupplier.Text, 0)
            Rows = DT.Rows.Count - 1
            DataGridView1.Rows.Clear()
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = (i + 1)
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("no_sales")
                DataGridView1.Item(2, i).Value = Format(DT.Rows(i).Item("date_trn"), "yyyy-MM-dd")
                DataGridView1.Item(3, i).Value = FormatNumber(DT.Rows(i).Item("sales_amount"), 0)
                var_t_purchase = var_t_purchase + DataGridView1.Item(3, i).Value
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("return_amount"), 0)
                var_t_return = var_t_return + DataGridView1.Item(4, i).Value
                DataGridView1.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("disc"), 0)
                var_t_disc = var_t_disc + DataGridView1.Item(5, i).Value
                DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("paid_amount") + DT.Rows(i).Item("diskon_bayar"), 0)
                var_t_total = var_t_total + DataGridView1.Item(6, i).Value
                DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("total") - var_t_disc, 0)
                var_t_payment = var_t_payment + DataGridView1.Item(7, i).Value
                If DataGridView1.Item(7, i).Value <= 0 Then
                    DataGridView1.Item(5, i).Value = 0
                End If
                DataGridView1.Item(10, i).Value = 1
                DataGridView1.Item(11, i).Value = FormatNumber((DataGridView1.Item(10, i).Value * DataGridView1.Item(8, i).Value), 0)
                DataGridView1.Item(12, i).Value = get_curr_sales(DataGridView1.Item(1, i).Value)
            Next
            'txt_total_ap.Text = FormatNumber(var_t_purchase, 0)
            'txt_total_return.Text = FormatNumber(var_t_return, 0)
            'txt_total_disc.Text = FormatNumber(var_t_disc, 0)
            'txt_total_net.Text = FormatNumber(var_t_total, 0)
            'txt_total.Text = FormatNumber(var_t_payment, 0)

        End If
    End Sub

    Private Sub cbo_acc_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim NewDisplayAcc As New frm_display_acc_detail
        NewDisplayAcc.formsource_frmpayAR = True
        NewDisplayAcc.Show()
        ' NewDisplayAcc.MdiParent = MainMenu
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        list_data()
        'Dim Total_Width_Column, Total_Width_Column2 As Integer
        'Dim Width_Table, Width_Table2 As Integer
        'Dim selisih_col, selisih_col2 As Integer

        'With DataGridView1
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(9).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column - 65
        '    .Columns(1).Width = .Columns(1).Width + selisih_col
        'End With
        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(5).Width = .Columns(5).Width + selisih_col2
        'End With
    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("PAYAR", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("PAYAR", "TRANS")
            txt_billno.Text = no_master
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
        cbo_search.Text = "Payment No"
        txt_search.Text = ""
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        list_data()
    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        Dim DisplayNota As New FormCtkPayAr
        NoBuktiBayarAR = Trim(txt_billno.Text)
        With DisplayNota
            .Show()
            ' .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        open_conn()
        Dim colIndex As Integer
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        If colIndex = 6 Then
            Dim DisplayNota As New FormCtkPay
            NoBuktiBayarAR = Trim(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        open_conn()
        hitung_total()
    End Sub

    'Private Sub frmpayAR_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(9).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(1).Width = .Columns(1).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(5).Width = .Columns(5).Width + selisih_col2
    '    End With
    'End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub CheckKurs_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckKurs.CheckedChanged
        get_nominal_bayar()
        hitung_total()
    End Sub

    Private Sub txt_curr_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_curr.SelectedIndexChanged
        get_nominal_bayar()
        hitung_total()
    End Sub

    Private Sub NavBarGroupControlContainer7_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        PanelControl3.Visible = False
        enableMain()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            list_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
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

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        generate()
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            generate()
        End If
    End Sub

    Private Sub SimpleButton8_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton8.Click
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            list_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class