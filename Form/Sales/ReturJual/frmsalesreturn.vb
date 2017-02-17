Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmsalesreturn

    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Dim return_value_bef As Double
    Dim TSubTotal As Double
    Public NoBuktiReturJual As String

    Public Sub hitung_nominal()
        open_conn()
        Dim TNett As Double
        Dim Ttotal As Double
        Dim Tchange As Double

        TNett = 0
        Ttotal = 0
        Tchange = 0

        'menghitung netto
        TNett = CDbl(Replace(txt_subtotal.Text, ",", "")) - (CDbl(Replace(txt_subtotal.Text, ",", "")) * CDbl(Replace(txt_disc.Text, "%", "")) / 100)
        txt_disc_nom.Text = FormatNumber(CDbl(Replace(txt_subtotal.Text, ",", "")) * CDbl(Replace(txt_disc.Text, "%", "")) / 100, 0)
        txt_nett.Text = FormatNumber(TNett, 0)
        Ttotal = TNett + (TNett * (CDbl(Replace(txt_tax.Text, "%", "")) / 100))
        txt_tax_nom.Text = FormatNumber(TNett * (CDbl(Replace(txt_tax.Text, "%", "")) / 100), 0)
        'menghitung total
        txt_total.Text = FormatNumber(Ttotal, 0)

    End Sub

    Private Sub frmsalesreturn_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmsalesreturn_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub fillComboBox()
        Dim DT As DataTable
        DT = getComboGudang()
        cbo_filterwh_purch1.Properties.DataSource = DT
        cbo_filterwh_purch1.Properties.DisplayMember = "warehouse_name"
        cbo_filterwh_purch1.Properties.ValueMember = "id_warehouse"
        cbo_filterwh_purch1.Properties.PopulateViewColumns()
        cbo_filterwh_purch1.Properties.View.Columns("id_warehouse").Caption = "Kode"
        cbo_filterwh_purch1.Properties.View.Columns("warehouse_name").Caption = "Gudang"
        cbo_filterwh_purch1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_filterwh_purch1.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("SALES_RETURN", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("SALES_RETURN", "TRANS")
        cbo_search.Text = "Return No"
        txt_return_no.Text = no_master
        DataGridView1.ReadOnly = False
        btn_del2.Enabled = False
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Button1.Visible = False
        txt_tax.Enabled = False
        list_data()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        lbl_kurs.Text = get_def_curr()
        txt_kurs.Text = 1
        btn_cetak.Visible = False
        fillComboBox()
        list_data()
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        With Me
            .txt_idsupplier.Text = ""
            '.txt_idpayment_method.Text = ""
            .txt_comment.Text = ""
            .txt_cust_nm.Text = ""
            .txt_cust_address.Text = ""
            .DataGridView1.Rows.Clear()
            .txt_subtotal.Text = ""
            .cbo_sales_no.Text = ""
            .txt_nett.Text = ""
            .txt_tax.Text = ""
            .txt_return_no.Text = ""
            .cbo_paymethod.Text = ""
            .txt_disc_nom.Text = ""
            .txt_tax_nom.Text = ""
        End With
        Call select_control_no("SALES_RETURN", "TRANS")
        txt_return_no.Text = no_master
        txt_date.Value = Now
        init_number()
        btn_del2.Enabled = False
        lbl_kurs.Text = get_def_curr()
        txt_kurs.Text = 1
        btn_cetak.Visible = False
    End Sub

    Private Sub init_number()
        open_conn()
        txt_total.Text = 0
    End Sub

    Public Sub insert_data()
        open_conn()
        Dim var_paymethod As Integer
        If cbo_paymethod.Text = "Cash" Then
            var_paymethod = 1
        ElseIf cbo_paymethod.Text = "Credit" Then
            var_paymethod = 2
        End If

        Dim i As Integer
        If insert = 1 Then
            Call insert_sales_return(Trim(txt_return_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_idsupplier.Text), _
                                     var_paymethod, Replace(txt_subtotal.Text, ",", ""), _
                                    Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), _
                                    Replace(txt_total.Text, ",", ""), Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), username, _
                                    Format(server_datetime(), "yyyy-MM-dd"), _
                                    0, "", "", 0, "", 0, 0, "", cbo_sales_no.Text, 0, 0, "INSERT", return_value_bef, Replace(txt_kurs.Text, ",", ""), cbo_filterwh_purch1.EditValue)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(8, i).Value = True Then
                    Call insert_sales_return(Trim(txt_return_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_idsupplier.Text), _
                                     var_paymethod, Replace(txt_subtotal.Text, ",", ""), _
                                    Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), _
                                    Replace(txt_total.Text, ",", ""), Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), username, _
                                    Format(server_datetime(), "yyyy-MM-dd"), _
                                    i, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, _
                                    DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, _
                                     Replace(DataGridView1.Item(6, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), _
                                     "", cbo_sales_no.Text, 1, 1, "INSERT", return_value_bef, Replace(txt_kurs.Text, ",", ""), cbo_filterwh_purch1.EditValue)
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "SALES_RETURN")
                pesan = MsgBox("Cetak Retur?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormReturJual
                    NoBuktiReturJual = Trim(txt_return_no.Text)
                    With DisplayNota
                        .Show()
                        '   .MdiParent = MainMenu
                        .WindowState = FormWindowState.Maximized
                    End With
                End If
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_sales_return(Trim(txt_return_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_idsupplier.Text), _
                                     var_paymethod, Replace(txt_subtotal.Text, ",", ""), _
                                    Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), _
                                    Replace(txt_total.Text, ",", ""), Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), username, _
                                    Format(server_datetime(), "yyyy-MM-dd"), _
                                    0, "", "", 0, "", 0, 0, "", cbo_sales_no.Text, 0, 0, "UPDATE", return_value_bef, Replace(txt_kurs.Text, ",", ""), cbo_filterwh_purch1.EditValue)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(8, i).Value = True Then
                    Call update_sales_return(Trim(txt_return_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_idsupplier.Text), _
                                     var_paymethod, Replace(txt_subtotal.Text, ",", ""), _
                                    Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), _
                                    Replace(txt_total.Text, ",", ""), Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), username, _
                                    Format(server_datetime(), "yyyy-MM-dd"), _
                                    i, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, _
                                    DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, _
                                    Replace(DataGridView1.Item(6, i).Value, ",", ""), Replace(DataGridView1.Item(7, i).Value, ",", ""), _
                                    "", cbo_sales_no.Text, 1, 1, "UPDATE", return_value_bef, Replace(txt_kurs.Text, ",", ""), cbo_filterwh_purch1.EditValue)
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "SALES_RETURN")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SALES_RETURN_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim var_paymethod As Integer
        var_paymethod = 0

        If edit = 1 Then
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_sales_return(Trim(txt_return_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_idsupplier.Text), _
                                     var_paymethod, Replace(txt_subtotal.Text, ",", ""), _
                                    Replace(txt_disc.Text, "%", ""), Replace(txt_tax.Text, "%", ""), _
                                    Replace(txt_total.Text, ",", ""), Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), username, _
                                    Format(server_datetime(), "yyyy-MM-dd"), _
                                    0, "", "", 0, "", 0, 0, "", cbo_sales_no.Text, 0, 0, "DELETE", return_value_bef)
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

            DT = select_sales_return(cbo_search.Text, txt_search.Text, 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
            GridControl.DataSource = DT
            GridList_Customer.Columns("no_sales_return").Caption = "No Retur"
            GridList_Customer.Columns("no_sales_return").Width = 165
            GridList_Customer.Columns("customer_name").Caption = "Pelanggan"
            GridList_Customer.Columns("customer_name").Width = 200
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 95
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("total").Caption = "Total"
            GridList_Customer.Columns("total").Width = 125
            GridList_Customer.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("total").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("subtotal").Caption = "Sub Total"
            GridList_Customer.Columns("subtotal").Width = 110
            GridList_Customer.Columns("subtotal").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("subtotal").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("tax").Caption = "PPN"
            GridList_Customer.Columns("tax").Width = 110
            GridList_Customer.Columns("tax").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("tax").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("disc").Caption = "Diskon"
            GridList_Customer.Columns("disc").Width = 110
            GridList_Customer.Columns("disc").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("disc").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 200
            GridList_Customer.Columns("id_customer").Visible = False
            GridList_Customer.Columns("customer_addr").Visible = False
            GridList_Customer.Columns("payment_method").Visible = False
            GridList_Customer.Columns("ref_status_name").Visible = False
            GridList_Customer.Columns("id_warehouse").Visible = False
            GridList_Customer.Columns("no_sales").Visible = False

            '  GridList_Customer.BestFitColumns()

            'Rows = DT.Rows.Count - 1
            'DataGridView2.Rows.Clear()
            'Dim i As Integer
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item("no_sales")
            '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item("no_sales_return")
            '        DataGridView2.Item(2, i).Value = DT.Rows(i).Item("customer_name")
            '        DataGridView2.Item(3, i).Value = Format(DT.Rows(i).Item("date_trn"), "dd-MM-yyyy")
            '        DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("subtotal"), 0)
            '        DataGridView2.Item(5, i).Value = FormatPercent(DT.Rows(i).Item("tax") / 100, 0)
            '        DataGridView2.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)
            '        DataGridView2.Item(7, i).Value = DT.Rows(i).Item("notes")

            '    Next
            'End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Public Sub detail(ByVal criteria As String)
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable

        insert = 0
        edit = 1
        Dim date_filter As Integer
        If chk_date.Checked = True Then
            date_filter = 1
        ElseIf chk_date.Checked = False Then
            date_filter = 0
        End If
        DT = select_sales_return("Detail", criteria, 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd")) 'ganti SP
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        cbo_sales_no.Text = DT.Rows(0).Item("no_sales")
        txt_cust_nm.Text = DT.Rows(0).Item("customer_name")
        txt_cust_address.Text = DT.Rows(0).Item("customer_addr")
        txt_date.Value = DT.Rows(0).Item("date_trn")
        cbo_paymethod.Text = DT.Rows(0).Item("ref_status_name")
        txt_comment.Text = DT.Rows(0).Item("notes")
        txt_subtotal.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
        txt_nett.Text = FormatNumber(DT.Rows(0).Item("subtotal") - (Replace(DT.Rows(0).Item("subtotal"), ",", "") * Replace(DT.Rows(0).Item("disc"), ",", "") / 100), 0)
        txt_tax.Text = FormatPercent(DT.Rows(0).Item("tax") / 100, 0)
        txt_tax_nom.Text = FormatNumber(DT.Rows(0).Item("tax") / 100 * Replace(txt_nett.Text, ",", ""), 0)
        txt_disc.Text = FormatPercent(DT.Rows(0).Item("disc") / 100, 0)
        txt_disc_nom.Text = FormatNumber(Replace(DT.Rows(0).Item("subtotal"), ",", "") * Replace(DT.Rows(0).Item("disc"), ",", "") / 100, 0)
        txt_idsupplier.Text = DT.Rows(0).Item("id_customer")
        txt_total.Text = FormatNumber(DT.Rows(0).Item("total"), 0)
        txt_return_no.Text = DT.Rows(0).Item("no_sales_return")
        txt_kurs.Text = DT.Rows(0).Item("kurs")
        cbo_filterwh_purch1.EditValue = DT.Rows(0).Item("id_warehouse")
        'txt_idpayment_method.Text = DT.Rows(0).Item("payment_method")
        Dim i As Integer
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = (i + 1)
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
            DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
            DataGridView1.Item(3, i).Value = DT.Rows(i).Item("notes_detail")
            DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("qty"), 0)
            DataGridView1.Item(5, i).Value = DT.Rows(i).Item("unit")
            DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
            DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("nominal"), 0)
            'DataGridView1.Item(8, i).Value = DT.Rows(i).Item("no_sales")
            DataGridView1.Item(8, i).Value = True
        Next

        If edit = 1 Then
            return_value_bef = CDbl(txt_total.Text)
        End If
        btn_del2.Enabled = True
        btn_cetak.Visible = True

    End Sub

    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        open_conn()
        Dim mRow As Integer
        TabControl1.SelectedTabPage = TabInput
        mRow = DataGridView2.CurrentCell.RowIndex
        detail(DataGridView2.Item(1, mRow).Value)
        'edit data

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
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(3).DefaultCellStyle.BackColor = Color.WhiteSmoke
            ' .Columns(4).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(5).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(6).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(7).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            '.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
        End With
    End Sub

    Private Sub cbo_purchase_no_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_sales_no.Click
        open_conn()
        ' Dim NewDisplayAcc As New frm_display_sales
        frm_display_sales.formsource_sales_return = True
        frm_display_sales.Show()
        ' MainMenu.Enabled = False
        '    Me.Enabled = False
        clean()
    End Sub

    Private Sub txt_idsupplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_idsupplier.TextChanged
        open_conn()
        'jika id supplier tidak kosong maka tampilkan detail data purchase
        If edit = 0 Then
            Dim Rows As Integer
            Dim DT As DataTable
            Dim qty_max As Double
            DT = select_sales2("Detail", cbo_sales_no.Text, 0)

            Rows = DT.Rows.Count - 1
            DataGridView1.Rows.Clear()
            Dim i As Integer
            For i = 0 To Rows
                qty_max = get_qtymax_returjual(cbo_sales_no.Text, DT.Rows(i).Item("id_item"))
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = (i + 1)
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("notes_detail")
                DataGridView1.Item(4, i).Value = FormatNumber(qty_max, 0)
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
                DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
                DataGridView1.Item(7, i).Value = FormatNumber(qty_max * DT.Rows(i).Item("price"), 0)
                'DataGridView1.Item(8, i).Value = DT.Rows(i).Item("no_sales")
            Next
            If edit = 1 Then
                return_value_bef = CDbl(txt_nett.Text)
            End If
            If qty_max = 0 Then
                Dim info As AlertInfo = New AlertInfo("Limit Data", "Faktur Qty tidak mencukupi")
                alertControl_error.Show(Me, info)
                clean()
                Exit Sub
            End If
        End If

    End Sub

    Private Sub cbo_paymethod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_paymethod.Click
        open_conn()
        'Dim NewDisplayAcc As New frm_display_payment_method
        'NewDisplayAcc.formsource_purchreturn = True
        'NewDisplayAcc.Show()
    End Sub

    Private Sub btn_save2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_SALES_RETURN_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SALES_RETURN_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim a, b As Integer
        Dim row As Integer
        row = DataGridView1.Rows.Count - 1

        If Trim(cbo_paymethod.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Pilih metode pembayaran")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        If cbo_filterwh_purch1.EditValue Is Nothing Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Pilih gudang")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        For a = 0 To row
            If DataGridView1.Item(8, a).Value = True Then
                b = b + 1
            End If
        Next
        If b = 0 Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item Kosong")
            alertControl_warning.Show(Me, info)
            Exit Sub
        ElseIf a > 0 Then
            insert_data()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        list_data()

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

    Dim start As Integer
    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        open_conn()
        'row_before = DataGridView1.CurrentCell.RowIndex
        start = 0
        If start = 0 Then
            If edit = 1 Then
                qty_max = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value + get_qtymax_returbeli(cbo_sales_no.Text, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
            End If

            If insert = 1 Then
                qty_max = get_qtymax_returbeli(cbo_sales_no.Text, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
                If qty_max = 0 Then
                    qty_max = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
                End If
            End If

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        open_conn()
        Dim rows As Integer
        Dim columnIndex, rowIndex As Integer
        rows = DataGridView1.Rows.Count - 1

        TSubTotal = 0

        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        rowIndex = DataGridView1.CurrentCell.RowIndex
        Dim i As Integer
        If columnIndex = 8 Then

            For i = 0 To rows
                Dim checkbox_cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(i).Cells(8), DataGridViewCheckBoxCell)
                If checkbox_cell.EditedFormattedValue = True Then
                    TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
                End If
            Next
            txt_subtotal.Text = FormatNumber(TSubTotal, 0)

            hitung_nominal()
        End If
    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("SALES_RETURN", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("SALES_RETURN", "TRANS")
            cbo_search.Text = "Return No"
            txt_return_no.Text = no_master
        End If
    End Sub

    Dim qty_max As Double
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim rows As Integer
        Dim columnIndex As Integer
        TSubTotal = 0
        columnIndex = DataGridView1.CurrentCell.ColumnIndex

        If qty_max < DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Qty melebihi sisa qty yang dikirim")
            alertControl_warning.Show(Me, info)
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = qty_max
        End If

        If columnIndex = 4 Then
            DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value * DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, 0)
        End If
        rows = DataGridView1.Rows.Count - 1
        Dim i As Integer
        For i = 0 To rows
            If DataGridView1.Item(8, i).Value = True Then
                TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
            End If
        Next
        txt_subtotal.Text = FormatNumber(TSubTotal, 0)
        hitung_nominal()
        start = 1
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
        cbo_search.Text = "No Faktur"
        txt_search.Text = ""
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        Dim DisplayNota As New FormReturJual
        NoBuktiReturJual = Trim(txt_return_no.Text)
        With DisplayNota
            .Show()
            '   .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        open_conn()
        Dim colIndex As Integer
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        If colIndex = 8 Then
            Dim DisplayNota As New FormReturJual
            NoBuktiReturJual = Trim(DataGridView2.Item(1, DataGridView2.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
        End If
    End Sub

    'Private Sub frmsalesreturn_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
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

    Private Sub cbo_sales_no_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_sales_no.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub btn_cari_cust_Click(sender As System.Object, e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        list_data()

    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_sales_return"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_sales_return"))
        End If
    End Sub

    Private Sub NavBarControl4_Click(sender As System.Object, e As System.EventArgs)

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

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl3.Visible = True
        disableMain()
        clean()
    End Sub


    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
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