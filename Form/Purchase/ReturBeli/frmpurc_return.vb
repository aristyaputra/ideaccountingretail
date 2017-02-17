Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmpurc_return

    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Dim TSubTotal As Double
    Public NoBuktiRetur As String
    Dim return_value_bef As Double
    Dim var_id_supplier As String
    Dim var_nm_supplier As String
    Dim var_add_supplier As String

    Private Sub frmpurc_return_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmpurc_return_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
        cbo_filterwh_purch1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_filterwh_purch1.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_filterwh_purch1.Properties.View.Columns("id_warehouse").Caption = "Kode"
        cbo_filterwh_purch1.Properties.View.Columns("warehouse_name").Caption = "Gudang"
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataGudang.DataTableWH' table. You can move, or remove it, as needed.

        open_conn()
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        Call insert_no_trans("PURCHASE_RETURN", Month(txt_date.Value), Year(txt_date.Value))
        Call select_control_no("PURCHASE_RETURN", "TRANS")
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        cbo_search.Text = "Return No"
        txt_return_no.Text = no_master
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Button1.Visible = False
        txt_tax.Enabled = False
        txt_freight.Enabled = False
        list_data()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        ' LoadComboBox_MtgcComboBoxPurchase()
        lbl_kurs.Text = get_def_curr()
        txt_kurs.Text = 1
        fillComboBox()
        fillComboBox1()
        GridList_Customer.OptionsView.ColumnAutoWidth = False
        list_data()
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxPurchase()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_list_purch()

        cbo_purchase_no.SelectedIndex = -1
        cbo_purchase_no.Items.Clear()
        cbo_purchase_no.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_purchase_no.SourceDataString = New String(3) {"no_purchase", "id_supplier", "supplier_name", "address"}
        cbo_purchase_no.SourceDataTable = dtLoading
        cbo_purchase_no.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub list_data_purchase(ByVal Criteria As String)
        open_conn()
        Try
            Dim Rows As Integer
            Dim DT As DataTable

            Dim date_filter As Integer
            date_filter = 0
            DT = select_purch_purchreturn("No Pembelian", Criteria, date_filter, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"))
            Rows = DT.Rows.Count - 1

            var_id_supplier = DT.Rows(0).Item("id_supplier")
            txt_idsupplier.Text = DT.Rows(0).Item("id_supplier")
            var_nm_supplier = DT.Rows(0).Item("nm_supplier")
            txt_supp_nm.Text = DT.Rows(0).Item("nm_supplier")
            var_add_supplier = DT.Rows(0).Item("addr_supplier")
            txt_supp_address.Text = DT.Rows(0).Item("addr_supplier")
            txt_curr.Text = DT.Rows(0).Item("id_curr")
            cbo_paymethod.Text = DT.Rows(0).Item("nm_payment")
            Dim i As Integer
            DataGridView1.Rows.Clear()
            If DT.Rows().Count > 0 Then
                For i = 0 To Rows
                    DataGridView1.Rows.Add()
                    DataGridView1.Item(0, i).Value = i + 1
                    DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                    DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                    DataGridView1.Item(3, i).Value = DT.Rows(i).Item("notes_detail")
                    DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("qty_received"), 0)
                    DataGridView1.Item(5, i).Value = FormatNumber(0, 0)
                    DataGridView1.Item(6, i).Value = DT.Rows(i).Item("id_unit")
                    DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
                    DataGridView1.Item(8, i).Value = FormatNumber(DT.Rows(i).Item("price") * Val(DataGridView1.Item(5, i).Value), 0)
                    DataGridView1.Item(9, i).Value = DT.Rows(i).Item(0)
                    TSubTotal = TSubTotal + Replace(DataGridView1.Item(8, i).Value, ",", "")
                Next
            End If
            txt_total.Text = FormatNumber(TSubTotal, 0)
            txt_freight.Text = FormatNumber(DT.Rows(0).Item("freight"), 0)
            txt_disc.Text = FormatPercent(DT.Rows(0).Item("disc") / 100, 0)
            txt_tax.Text = FormatPercent(DT.Rows(0).Item("tax") / 100, 0)
            txt_kurs.Text = FormatNumber(DT.Rows(0).Item("kurs"), 0)
            hitung_nominal()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
        End Try
    End Sub
    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        With Me
            .txt_idsupplier.Text = ""
            '.txt_idpayment_method.Text = ""
            .txt_comment.Text = ""
            .txt_supp_nm.Text = ""
            .txt_supp_address.Text = ""
            .DataGridView1.Rows.Clear()
            .txt_total.Text = 0
            '.cbo_purchase_no.Text = ""
            Lookup_Pelanggan.EditValue = Nothing
            .txt_nett.Text = 0
            .txt_netto.Text = 0
            .txt_disc.Text = 0
            .txt_tax.Text = 0
            .txt_freight.Text = 0
            .txt_return_no.Text = ""
            .cbo_paymethod.Text = ""
            .txt_curr.Text = ""
        End With
        Call select_control_no("PURCHASE_RETURN", "TRANS")
        txt_return_no.Text = no_master
        txt_date.Value = Now
        init_number()
        btn_del2.Enabled = False
        btn_cetak.Enabled = False
        txt_kurs.Text = 1
        fillComboBox1()
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
            Call insert_purchase_return(Trim(txt_return_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_idsupplier.Text), _
                                     var_paymethod, Replace(txt_total.Text, ",", ""), Replace(txt_freight.Text, ",", ""), Replace(txt_disc.Text, "%", ""), _
                                    Replace(txt_tax.Text, "%", ""), Replace(txt_nett.Text, ",", ""), _
                                    Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), username, _
                                    Format(server_datetime(), "yyyy-MM-dd"), _
                                    0, "", "", 0, "", 0, 0, "", Lookup_Pelanggan.EditValue, 0, 0, "INSERT", 0, return_value_bef, 0, Replace(txt_kurs.Text, ",", ""), cbo_filterwh_purch1.EditValue)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(10, i).Value = True Then
                    Call insert_purchase_return(Trim(txt_return_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Lookup_Pelanggan.EditValue, _
                                    var_paymethod, 0, 0, 0, 0, 0, "", username, Format(server_datetime(), "yyyy-MM-dd"), username, _
                                    Format(server_datetime(), "yyyy-MM-dd"), _
                                    i + 1, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, _
                                    DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, _
                                    Replace(DataGridView1.Item(7, i).Value, ",", ""), Replace(DataGridView1.Item(8, i).Value, ",", ""), _
                                    txt_curr.Text, Lookup_Pelanggan.EditValue, 1, i, "INSERT", 0, return_value_bef, Replace(DataGridView1.Item(4, i).Value, ",", ""), Replace(txt_kurs.Text, ",", ""), cbo_filterwh_purch1.EditValue)
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(txt_date.Value, "PURCHASE_RETURN")
                pesan = MsgBox("Cetak Retur?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormReturBeli
                    NoBuktiRetur = Trim(txt_return_no.Text)
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
            Call update_purchase_return(Trim(txt_return_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_idsupplier.Text), _
                                    var_paymethod, Replace(txt_total.Text, ",", ""), Replace(txt_freight.Text, ",", ""), Replace(txt_disc.Text, "%", ""), _
                                    Replace(txt_tax.Text, ",", ""), Replace(txt_nett.Text, ",", ""), _
                                    Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), username, _
                                    Format(server_datetime(), "yyyy-MM-dd"), _
                                    0, "", "", 0, "", 0, 0, "", Lookup_Pelanggan.EditValue, 0, 0, "UPDATE", 0, return_value_bef, 0, Replace(txt_kurs.Text, ",", ""), cbo_filterwh_purch1.EditValue)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(10, i).Value = True Then
                    Call update_purchase_return(Trim(txt_return_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Lookup_Pelanggan.EditValue, _
                                    var_paymethod, 0, 0, 0, 0, 0, "", username, Format(server_datetime(), "yyyy-MM-dd"), username, _
                                    Format(server_datetime(), "yyyy-MM-dd"), _
                                    i + 1, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, _
                                    DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, _
                                    Replace(DataGridView1.Item(7, i).Value, ",", ""), Replace(DataGridView1.Item(8, i).Value, ",", ""), _
                                    txt_curr.Text, Lookup_Pelanggan.EditValue, 1, i, "UPDATE", 0, return_value_bef, Replace(DataGridView1.Item(4, i).Value, ",", ""), Replace(txt_kurs.Text, ",", ""), cbo_filterwh_purch1.EditValue)
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                'update_no_trans(txt_date.Value, "PURCHASE_RETURN")
                pesan = MsgBox("Cetak Retur?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormReturBeli
                    NoBuktiRetur = Trim(txt_return_no.Text)
                    With DisplayNota
                        .Show()
                        '  .MdiParent = MainMenu
                        .WindowState = FormWindowState.Maximized
                    End With
                End If
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
            If getTemplateAkses(username, "MN_PURCHASE_RETURN_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If


        Dim var_paymethod As Integer
        If cbo_paymethod.Text = "Cash" Then
            var_paymethod = 1
        ElseIf cbo_paymethod.Text = "Credit" Then
            var_paymethod = 2
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_purchase_return(Trim(txt_return_no.Text), Format(txt_date.Value, "yyyy-MM-dd"), Trim(txt_idsupplier.Text), _
                                     var_paymethod, Replace(txt_total.Text, ",", ""), Replace(txt_freight.Text, ",", ""), Replace(txt_disc.Text, "%", ""), _
                                    Replace(txt_tax.Text, "%", ""), Replace(txt_nett.Text, ",", ""), _
                                    Trim(txt_comment.Text), username, Format(server_datetime(), "yyyy-MM-dd"), username, _
                                    Format(server_datetime(), "yyyy-MM-dd"), _
                                    0, "", "", 0, "", 0, 0, "", Lookup_Pelanggan.EditValue, 0, 0, "DELETE", 0, return_value_bef, 0)
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

            DT = select_purchase_return(cbo_search.Text, txt_search.Text, 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
            GridControl.DataSource = DT
            GridList_Customer.Columns("no_purchase_return").Caption = "No Retur"
            GridList_Customer.Columns("no_purchase_return").Width = 170
            GridList_Customer.Columns("supplier_name").Caption = "Pemasok"
            GridList_Customer.Columns("supplier_name").Width = 200
            GridList_Customer.Columns("supplier_addr").Visible = False
            GridList_Customer.Columns("no_purchase_return").Caption = "No Retur"
            GridList_Customer.Columns("no_purchase_return").Width = 170
            GridList_Customer.Columns("no_purchase").Caption = "No Faktur"
            GridList_Customer.Columns("no_purchase").Width = 170
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 100
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            GridList_Customer.Columns("subtotal").Visible = False
            GridList_Customer.Columns("freight").Visible = False
            GridList_Customer.Columns("tax").Visible = False
            GridList_Customer.Columns("total").Caption = "Total"
            GridList_Customer.Columns("total").Width = 170
            GridList_Customer.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Customer.Columns("total").DisplayFormat.FormatString = "N0"
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 300
            GridList_Customer.Columns("notes1").Visible = False
            GridList_Customer.Columns("ref_status_name").Visible = False
            GridList_Customer.Columns("sum(prd.qty)").Visible = False
            GridList_Customer.Columns("sum(prd.price)").Visible = False
            GridList_Customer.Columns("sum(prd.nominal)").Visible = False
            GridList_Customer.Columns("disc").Visible = False
            GridList_Customer.Columns("unit").Visible = False
            GridList_Customer.Columns("number_asc").Visible = False
            GridList_Customer.Columns("id_item").Visible = False
            GridList_Customer.Columns("item_name").Visible = False
            GridList_Customer.Columns("id_warehouse").Visible = False
            GridList_Customer.Columns("id_supplier").Visible = False
            GridList_Customer.Columns("payment_method").Visible = False

            'GridList_Customer.BestFitColumns()

            'Dim i As Integer
            'Rows = DT.Rows.Count - 1

            'DataGridView2.Rows.Clear()
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item("no_purchase")
            '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item("no_purchase_return")
            '        DataGridView2.Item(2, i).Value = DT.Rows(i).Item("supplier_name")
            '        DataGridView2.Item(3, i).Value = Format(DT.Rows(i).Item("date_trn"), "dd-MM-yyyy")
            '        DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("subtotal"), 0)
            '        DataGridView2.Item(5, i).Value = FormatPercent(DT.Rows(i).Item("tax") / 100, 0)
            '        DataGridView2.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("freight"), 0)
            '        DataGridView2.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("total"), 0)
            '        DataGridView2.Item(8, i).Value = DT.Rows(i).Item("notes")
            '    Next
            'End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Public Sub detail(ByVal criteria As String)
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable
        Dim i As Integer

        insert = 0
        edit = 1
        Dim date_filter As Integer
        If chk_date.Checked = True Then
            date_filter = 1
        ElseIf chk_date.Checked = False Then
            date_filter = 0
        End If
        'edit data
        DT = select_purchase_return("detail", criteria, 1, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd")) 'ganti SP
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        fillComboBox1All()
        'cbo_purchase_no.Text = ""
        Lookup_Pelanggan.EditValue = DT.Rows(0).Item("no_purchase")
        txt_supp_nm.Text = DT.Rows(0).Item("supplier_name")
        txt_supp_address.Text = DT.Rows(0).Item("supplier_addr")
        txt_curr.Text = DT.Rows(0).Item("id_curr")
        txt_date.Value = DT.Rows(0).Item("date_trn")
        txt_return_no.Text = DT.Rows(0).Item("no_purchase_return")
        cbo_paymethod.Text = DT.Rows(0).Item("ref_status_name")
        txt_comment.Text = DT.Rows(0).Item("notes")
        txt_total.Text = FormatNumber(DT.Rows(0).Item("subtotal"), 0)
        txt_freight.Text = FormatNumber(DT.Rows(0).Item("freight"), 0)
        txt_nett.Text = FormatNumber(DT.Rows(0).Item("total"), 0)
        txt_disc.Text = FormatPercent(DT.Rows(0).Item("disc") / 100, 0)
        txt_tax.Text = FormatNumber(DT.Rows(0).Item("tax"), 0)
        txt_idsupplier.Text = DT.Rows(0).Item("id_supplier")
        txt_netto.Text = FormatNumber(DT.Rows(0).Item("subtotal") - (DT.Rows(0).Item("disc") / 100 * (DT.Rows(0).Item("subtotal"))), 0)
        'txt_idpayment_method.Text = DT.Rows(0).Item("payment_method")
        txt_kurs.Text = FormatNumber(DT.Rows(0).Item("kurs"), 0)
        cbo_filterwh_purch1.EditValue = DT.Rows(0).Item("id_warehouse")
        DataGridView1.Rows.Clear()
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = (i + 1)
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
            DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
            DataGridView1.Item(3, i).Value = DT.Rows(i).Item("notes_detail")
            DataGridView1.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("qty"), 0)
            DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("qty_purch"), 0)
            DataGridView1.Item(6, i).Value = DT.Rows(i).Item("id_unit")
            DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
            DataGridView1.Item(8, i).Value = FormatNumber(DT.Rows(i).Item("nominal"), 0)
            DataGridView1.Item(9, i).Value = DT.Rows(i).Item("no_purchase")
            DataGridView1.Item(10, i).Value = True
        Next

        If edit = 1 Then
            return_value_bef = CDbl(txt_nett.Text)
        End If
        btn_del2.Enabled = True
        btn_cetak.Enabled = True
    End Sub


    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick

        open_conn()
        Dim mRow As Integer
        mRow = DataGridView2.CurrentCell.RowIndex
        TabControl1.SelectedTabPage = TabInput

        detail(DataGridView2.Item(1, mRow).Value)


    End Sub
    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ReadOnly = True

        End With
        With DataGridView1
            .ReadOnly = False
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        With DataGridView1
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = False
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = False
            .Columns(6).ReadOnly = True
            .Columns(7).ReadOnly = True
            .Columns(8).ReadOnly = True
            .Columns(9).ReadOnly = False
            ' .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
        DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(4).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(7).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(6).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(8).DefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub cbo_purchase_no_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim NewDisplayAcc As New frm_display_purchase
        NewDisplayAcc.formsource_purchase_return = True
        NewDisplayAcc.Show()
        '    NewDisplayAcc.MdiParent = MainMenu
        clean()
    End Sub

    Private Sub txt_idsupplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ''jika id supplier tidak kosong maka tampilkan detail data purchase
        'If edit = 0 Then
        '    Dim Rows As Integer
        '    Dim DT As DataTable
        '    Dim qty_max As Double

        '    DT = select_purchase2("Detail", cbo_purchase_no.Text, 0)
        '    Rows = DT.Rows.Count - 1
        '    open_conn()
        '    DataGridView1.Rows.Clear()
        '    For i = 0 To Rows
        '        qty_max = get_qtymax_returbeli(cbo_purchase_no.Text, DT.Rows(i).Item("id_item"))
        '        DataGridView1.Rows.Add()
        '        DataGridView1.Item(0, i).Value = (i + 1)
        '        DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
        '        DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
        '        DataGridView1.Item(3, i).Value = DT.Rows(i).Item("notes_detail")
        '        DataGridView1.Item(4, i).Value = FormatNumber(qty_max, 0)
        '        DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
        '        DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("price"), 0)
        '        DataGridView1.Item(7, i).Value = FormatNumber(DT.Rows(i).Item("price") * qty_max, 0)
        '        DataGridView1.Item(8, i).Value = DT.Rows(i).Item("no_purchase")
        '    Next
        '    If edit = 1 Then
        '        return_value_bef = CDbl(txt_nett.Text)
        '    End If
        '    If qty_max = 0 Then
        '        MsgBox("Limit Data Qty Retur telah habis", MsgBoxStyle.Information + MsgBoxStyle.Exclamation, "Limit Data")
        '        clean()
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub cbo_paymethod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_paymethod.Click
        'Dim NewDisplayAcc As New frm_display_payment_method
        'NewDisplayAcc.formsource_purchreturn = True
        'NewDisplayAcc.Show()
    End Sub

    Private Sub btn_save2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_PURCHASE_RETURN_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_PURCHASE_RETURN_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim a, b As Integer
        Dim row As Integer
        row = DataGridView1.Rows.Count - 1

        If cbo_filterwh_purch1.EditValue Is Nothing Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Silahkan pilih gudang")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        For a = 0 To row
            If DataGridView1.Item(10, a).Value = True Then
                b = b + 1
            End If
        Next
        If b = 0 Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Item belum di isi")
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
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(9).Width + .Columns(10).Width
        '    Width_Table = .Width
        '    selisih_col = (Width_Table - Total_Width_Column - 65) / 2
        '    .Columns(3).Width = .Columns(3).Width + selisih_col
        '    .Columns(2).Width = .Columns(2).Width + selisih_col
        'End With
        'With DataGridView2
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(9).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
        '    .Columns(8).Width = .Columns(8).Width + selisih_col2
        'End With
    End Sub

    Private Sub txt_date_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_date.ValueChanged
        open_conn()
        If insert = 1 Then
            var_bulan = Month(txt_date.Value)
            var_tahun = Year(txt_date.Value)
            Call insert_no_trans("PURCHASE_RETURN", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("PURCHASE_RETURN", "TRANS")
            cbo_search.Text = "Return No"
            txt_return_no.Text = no_master
        End If
    End Sub

    Private Sub txt_tax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_tax.GotFocus
        open_conn()
        txt_tax.SelectionStart = 0
        txt_tax.SelectionLength = Len(txt_tax.Text)
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

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        list_data()
    End Sub

    Dim start As Integer
    'Dim row_before As Integer
    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        'row_before = DataGridView1.CurrentCell.RowIndex
        'start = 0
        'If start = 0 Then
        '    If edit = 1 Then
        '        qty_max = DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value + get_qtymax_returbeli(cbo_purchase_no.Text, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
        '    End If

        '    If insert = 1 Then
        '        qty_max = get_qtymax_returbeli(cbo_purchase_no.Text, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
        '        If qty_max = 0 Then
        '            qty_max = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
        '        End If
        '    End If

        'End If
    End Sub

    Dim qty_max As Double

    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        open_conn()
        Dim i As Integer
        Dim rows As Integer
        Dim columnIndex, rowIndex As Integer
        rows = DataGridView1.Rows.Count - 1

        TSubTotal = 0

        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        rowIndex = DataGridView1.CurrentCell.RowIndex
        If columnIndex = 10 Then

            For i = 0 To rows
                Dim checkbox_cell As DataGridViewCheckBoxCell = CType(DataGridView1.Rows(i).Cells(10), DataGridViewCheckBoxCell)
                If checkbox_cell.EditedFormattedValue = True Then
                    TSubTotal = TSubTotal + Replace(DataGridView1.Item(8, i).Value, ",", "")
                End If
            Next
            txt_total.Text = FormatNumber(TSubTotal, 0)

            hitung_nominal()
        End If
    End Sub
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim rows As Integer
        Dim columnIndex As Integer

        TSubTotal = 0
        columnIndex = DataGridView1.CurrentCell.ColumnIndex

        If edit = 1 Then
            qty_max = DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value + get_qtymax_returbeli(Lookup_Pelanggan.EditValue, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
        End If

        If insert = 1 Then
            qty_max = get_qtymax_returbeli(Lookup_Pelanggan.EditValue, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
            If qty_max = 0 Then
                qty_max = DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value
            End If
        End If


        If qty_max < DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Qty retur melebihi qty faktur")
            alertControl_warning.Show(Me, info)
            DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value = qty_max
        End If
        If columnIndex = 5 Then
            DataGridView1.Item(8, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value * DataGridView1.Item(5, DataGridView1.CurrentCell.RowIndex).Value, 0)
        End If
        rows = DataGridView1.Rows.Count - 1
        Dim i As Integer
        For i = 0 To rows
            If DataGridView1.Item(10, i).Value = True Then
                TSubTotal = TSubTotal + Replace(DataGridView1.Item(8, i).Value, ",", "")
            End If
        Next
        txt_total.Text = FormatNumber(TSubTotal, 0)
        hitung_nominal()
        start = 1
    End Sub

    Public Sub hitung_nominal()
        open_conn()
        Dim TNett As Double
        Dim Ttotal As Double
        Dim Tchange As Double

        TNett = 0
        Ttotal = 0
        Tchange = 0

        'menghitung netto
        TNett = CDbl(Replace(txt_total.Text, ",", "")) - ((CDbl(Replace(txt_total.Text, ",", ""))) * CDbl(Replace(txt_disc.Text, "%", "")) / 100)
        txt_netto.Text = FormatNumber(TNett, 0)
        Ttotal = TNett + (TNett * (CDbl(Replace(txt_tax.Text, "%", "")) / 100))

        'menghitung total
        txt_nett.Text = FormatNumber(Ttotal, 0)

    End Sub

    Private Sub btn_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak.Click
        open_conn()
        Dim DisplayNota As New FormReturBeli
        NoBuktiRetur = Trim(txt_return_no.Text)
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
        If colIndex = 9 Then
            Dim DisplayNota As New FormReturBeli
            NoBuktiRetur = Trim(DataGridView2.Item(1, DataGridView2.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
        End If
    End Sub

    Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            Dim mRow As Integer
            TabControl1.SelectedTabPage = TabInput

            detail(DataGridView2.Item(1, mRow).Value)
        End If
    End Sub

    Private Sub cbo_purchase_no_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_purchase_no.SelectedIndexChanged
        open_conn()
        list_data_purchase(cbo_purchase_no.Text)
    End Sub

    'Private Sub frmpurc_return_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column, Total_Width_Column2 As Integer
    '    Dim Width_Table, Width_Table2 As Integer
    '    Dim selisih_col, selisih_col2 As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(9).Width + .Columns(10).Width
    '        Width_Table = .Width
    '        selisih_col = (Width_Table - Total_Width_Column - 65) / 2
    '        .Columns(3).Width = .Columns(3).Width + selisih_col
    '        .Columns(2).Width = .Columns(2).Width + selisih_col
    '    End With
    '    With DataGridView2
    '        Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width + .Columns(9).Width
    '        Width_Table2 = .Width
    '        selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
    '        .Columns(8).Width = .Columns(8).Width + selisih_col2
    '    End With
    'End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

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
        Lookup_Pelanggan.EditValue = Nothing
    End Sub

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_purchase_return"))
    End Sub

    Private Sub fillComboBox1()
        Dim DT As DataTable
        DT = select_list_purch()
        Lookup_Pelanggan.Properties.DataSource = DT
        Lookup_Pelanggan.Properties.DisplayMember = "id_supplier"
        Lookup_Pelanggan.Properties.ValueMember = "no_purchase"
        Lookup_Pelanggan.Properties.PopulateViewColumns()
        Lookup_Pelanggan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Lookup_Pelanggan.Properties.View.OptionsView.ShowAutoFilterRow = True
        Lookup_Pelanggan.Properties.View.Columns("id_supplier").Caption = "ID Supplier"
        Lookup_Pelanggan.Properties.View.Columns("supplier_name").Caption = "Nama"
        Lookup_Pelanggan.Properties.View.Columns("address").Caption = "Alamat"
        Lookup_Pelanggan.Properties.View.Columns("date_trn").Caption = "Tanggal"
        Lookup_Pelanggan.Properties.View.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Lookup_Pelanggan.Properties.View.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
        Lookup_Pelanggan.Properties.View.Columns("no_purchase").Caption = "No Faktur"
    End Sub

    Private Sub fillComboBox1All()
        Dim DT As DataTable
        DT = select_list_purch_all()
        Lookup_Pelanggan.Properties.DataSource = DT
        Lookup_Pelanggan.Properties.DisplayMember = "id_supplier"
        Lookup_Pelanggan.Properties.ValueMember = "no_purchase"
        Lookup_Pelanggan.Properties.PopulateViewColumns()
        Lookup_Pelanggan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Lookup_Pelanggan.Properties.View.OptionsView.ShowAutoFilterRow = True
        Lookup_Pelanggan.Properties.View.Columns("id_supplier").Caption = "ID Supplier"
        Lookup_Pelanggan.Properties.View.Columns("supplier_name").Caption = "Nama"
        Lookup_Pelanggan.Properties.View.Columns("address").Caption = "Alamat"
        Lookup_Pelanggan.Properties.View.Columns("date_trn").Caption = "Tanggal"
        Lookup_Pelanggan.Properties.View.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Lookup_Pelanggan.Properties.View.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
        Lookup_Pelanggan.Properties.View.Columns("no_purchase").Caption = "No Faktur"
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_purchase_return"))
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

    Private Sub Lookup_Pelanggan_EditValueChanged(sender As Object, e As System.EventArgs) Handles Lookup_Pelanggan.EditValueChanged
        open_conn()
        If Lookup_Pelanggan.EditValue <> Nothing Then
            list_data_purchase(Lookup_Pelanggan.EditValue)
        End If
    End Sub
End Class