Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmApproveRO

    Dim i As Integer
    Dim a As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Public NoBuktiPO As String
    Dim qty_before_edit As Integer

    Private Sub frmApproveRO_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmApproveRO_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        Dim DT As New DataTable
        insert = 1
        edit = 0
        DataGridView2.ReadOnly = False
        DataGridView2.Columns(0).ReadOnly = True
        DataGridView2.Columns(1).ReadOnly = True
        DataGridView2.Columns(2).ReadOnly = True
        DataGridView2.Columns(3).ReadOnly = True
        DataGridView2.Columns(4).ReadOnly = False
        DataGridView2.Columns(5).ReadOnly = True
        DataGridView2.Columns(6).ReadOnly = True

        cbo_search.Text = "Requisition No"
        view_data()
        view_cancel_data()

        'Rows = select_supplier().Rows.Count - 1
        'For i = 0 To Rows
        '    cbo_supplier.Items.Add(select_supplier.Rows(i).Item(0))
        'Next
        'fill datagridview
        'Rows_item = select_item("1", "").Rows.Count - 1
        'For a = 0 To Rows_item
        '    ComboBox1.Items.Add(select_item("1", "").Rows(a).Item(0))
        'Next
        'DataGridView1.Item(1, Collection.Equals(ComboBox1, "")).ValueType()

        'Call select_control_no("RO", "TRANS")
        cbo_search.Text = "Requisition No"
        insert = 1
        edit = 0
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Call init_number()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
    End Sub

    Private Sub init_number()

    End Sub
    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        With DataGridView1
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
        DataGridView2.Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView2.Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView2.Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView2.Columns(3).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView2.Columns(5).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView2.Columns(6).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView2.Columns(7).DefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub cbo_supplier_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim NewDisplayAcc As New frm_display_supp
        NewDisplayAcc.formsource_ro = True
        NewDisplayAcc.Show()
        '   NewDisplayAcc.MdiParent = MainMenu
        Me.Enabled = False
    End Sub

    'Private Sub cbo_supplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_supplier.SelectedIndexChanged
    '    Dim Rows As Integer
    '    Dim DT As DataTable
    '    DT = select_master("select_supplier", "ID Supplier", cbo_supplier.SelectedItem, 0)
    '    Rows = DT.Rows.Count - 1
    '    open_conn()
    '    For i = 0 To Rows
    '        txt_supp_nm.Text = DT.Rows(i).Item("NAME")
    '        txt_supp_address.Text = DT.Rows(i).Item("address")
    '    Next
    '    'txt_supp_nm.Text = cbo_supplier.SelectedItem
    '    'DataGridView1.Rows.Clear()
    '    'For i = 0 To Rows
    '    '    DataGridView1.
    '    'Next

    'End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        insert_data()
    End Sub
    'fungsi simpan
    Private Sub insert_data()
        open_conn()
        If insert = 1 Then
            'Call insert_ro(Trim(txt_po_no.Text), Trim(cbo_supplier.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
            '               Trim(txt_comment.Text), _
            '               username, server_datetime(), server_datetime(), username, 0, "", "", 0, "", 0, 0, 0)
            'For i = 0 To DataGridView1.Rows.Count - 2
            '    If DataGridView1.Item(1, i).Value.ToString <> "" Then
            '        Call insert_ro(Trim(txt_po_no.Text), Trim(cbo_supplier.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
            '              "", username, server_datetime(), server_datetime(), _
            '              username, DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, _
            '              DataGridView1.Item(5, i).Value, 1, i, 0)
            '    End If
            'Next
            'If param_sukses = True Then
            '    MsgBox("Data Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
            '    update_no_trans(txt_date.Value, "RO")
            '    clean()
            'Else
            '    MsgBox("Data Failed to Save", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Failed")
            'End If
        ElseIf edit = 1 Then
            'If select_validate("Request Order", Trim(txt_po_no.Text)) > 0 Then
            '    MsgBox("RO Sudah Di Approval", MsgBoxStyle.Information, "Validate")
            '    Exit Sub
            'End If
            'Call update_ro(Trim(txt_po_no.Text), Trim(cbo_supplier.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
            '              Trim(txt_comment.Text), _
            '              username, server_datetime(), server_datetime(), username, 0, "", "", 0, "", 0, 0, 0)

            'For i = 0 To DataGridView1.Rows.Count - 2
            '    If DataGridView1.Item(1, i).Value.ToString <> "" Then
            '        Call update_ro(Trim(txt_po_no.Text), Trim(cbo_supplier.Text), Format(txt_date.Value, "yyyy-MM-dd"), _
            '              "", username, server_datetime(), server_datetime(), _
            '              username, DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, _
            '              DataGridView1.Item(5, i).Value, 1, i, 0)
            '    End If
            'Next
            'If param_sukses = True Then
            '    MsgBox("Data Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Update Success")
            '    clean()
            'Else
            '    MsgBox("Data Failed to Update", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Update Failed")
            'End If
        End If
    End Sub

    Private Sub clean()
        open_conn()
        view_data()
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        clean()
    End Sub

    Private Sub txt_search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        'ganti ke text changed

        'Dim Rows As Integer
        'Dim DT As DataTable
        'DT = select_view_po()
        'Rows = DT.Rows.Count - 1
        'open_conn()
        'DataGridView2.Rows.Clear()
        'For i = 0 To Rows
        '    DataGridView2.Rows.Add()
        '    DataGridView2.Item(0, i).Value = DT.Rows(i).Item("no_purchase_order")
        '    DataGridView2.Item(1, i).Value = DT.Rows(i).Item("nm_supplier")
        '    DataGridView2.Item(2, i).Value = DT.Rows(i).Item("date_trn")
        'Next
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        view_data()
    End Sub

    Dim TSubTotal As Double
    Private Sub hitung_nominal()
        open_conn()
        Dim TNett As Double
        Dim Ttotal As Double
        Dim Tchange As Double

        TNett = 0
        Ttotal = 0
        Tchange = 0

        'menghitung netto
        'TNett = TSubTotal - (TSubTotal * CDbl(Replace(txt_disc.Text, "%", "")) / 100)
        'txt_netto.Text = FormatNumber(TNett, 0)
        'Ttotal = (TSubTotal + Replace(txt_freight.Text, ",", "")) + ((TSubTotal + Replace(txt_freight.Text, ",", "")) * (CDbl(Replace(txt_tax.Text, "%", "")) / 100))

        'menghitung total
        'txt_amount.Text = FormatNumber(Ttotal, 0)

        'menghitung change
        'Tchange = (CDbl(txt_paid.Text)) - Ttotal
        'txt_change.Text = FormatNumber(Tchange, 0)
    End Sub

    Private Sub txt_tax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If txt_tax.Text = "" Then
        '    txt_tax.Text = FormatPercent(0, 0)
        'Else
        '    txt_tax.Text = FormatPercent(CDbl(Replace(txt_tax.Text, "%", "")) / 100, 0)
        'End If
        'hitung_nominal()
    End Sub

    Private Sub txt_freight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'If txt_freight.Text = "" Then
        '    txt_freight.Text = FormatNumber(0, 0)
        'Else
        '    txt_freight.Text = FormatNumber(CDbl(Replace(txt_freight.Text, ",", "")), 0)
        'End If
        'hitung_nominal()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        view_data()
    End Sub

    Private Sub view_data()
        open_conn()
        ' If TabControl1.SelectedTab Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            Dim i As Integer
            Dim Rows As Integer
            Dim DT As DataTable
            Dim date_filter As Integer
            If chk_date.Checked = True Then
                date_filter = 1
            ElseIf chk_date.Checked = False Then
                date_filter = 0
            End If
            DT = select_approve_RO(Trim(cbo_search.Text), Trim(txt_search.Text), 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
            Rows = DT.Rows.Count - 1
            DataGridView2.Rows.Clear()
            If DT.Rows().Count > 0 Then
                For i = 0 To Rows
                    DataGridView2.Rows.Add()
                    DataGridView2.Item(0, i).Value = DT.Rows(i).Item("no_request_order")
                    DataGridView2.Item(1, i).Value = DT.Rows(i).Item("id_item")
                    DataGridView2.Item(2, i).Value = DT.Rows(i).Item("item_name")
                    DataGridView2.Item(3, i).Value = Format(DT.Rows(i).Item("date_trn"), "yyyy-MM-dd")
                    DataGridView2.Item(4, i).Value = DT.Rows(i).Item("qty")
                    DataGridView2.Item(5, i).Value = DT.Rows(i).Item("id_unit")
                    DataGridView2.Item(6, i).Value = DT.Rows(i).Item("notes")
                Next
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Private Sub view_cancel_data()
        open_conn()
        ' If TabControl1.SelectedTab Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            Dim i As Integer
            Dim Rows As Integer
            Dim DT As DataTable
            Dim date_filter As Integer
            If chk_date.Checked = True Then
                date_filter = 1
            ElseIf chk_date.Checked = False Then
                date_filter = 0
            End If
            DT = select_cancel_RO(Trim(cbo_search.Text), Trim(txt_search.Text), 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
            Rows = DT.Rows.Count - 1
            DataGridView1.Rows.Clear()
            If DT.Rows().Count > 0 Then
                For i = 0 To Rows
                    DataGridView1.Rows.Add()
                    DataGridView1.Item(0, i).Value = DT.Rows(i).Item("no_request_order")
                    DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_item")
                    DataGridView1.Item(2, i).Value = DT.Rows(i).Item("item_name")
                    DataGridView1.Item(3, i).Value = Format(DT.Rows(i).Item("date_trn"), "yyyy-MM-dd")
                    DataGridView1.Item(4, i).Value = DT.Rows(i).Item("qty")
                    DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_unit")
                    DataGridView1.Item(6, i).Value = DT.Rows(i).Item("notes")
                Next
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        'End If
    End Sub

    Private Sub DataGridView2_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        open_conn()
        Dim Max_Qty As Integer
        Max_Qty = get_max_approve_ro(DataGridView2.Item(0, DataGridView2.CurrentCell.RowIndex).Value, DataGridView2.Item(1, DataGridView2.CurrentCell.RowIndex).Value)
        If IsNumeric(DataGridView2.Item(4, DataGridView2.CurrentCell.RowIndex).Value) = False Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan Nilai Numeric")
            alertControl_warning.Show(Me, info)
            DataGridView2.Item(4, DataGridView2.CurrentCell.RowIndex).Value = qty_before_edit
        End If
        If DataGridView2.Item(4, DataGridView2.CurrentCell.RowIndex).Value > Max_Qty Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Melebihi Qty yang diminta")
            alertControl_warning.Show(Me, info)
            DataGridView2.Item(4, DataGridView2.CurrentCell.RowIndex).Value = qty_before_edit
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
        cbo_search.Text = "Requisition No"
        txt_search.Text = ""
    End Sub
    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        insert_data()
    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub

    Private Sub btn_approve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_approve.Click
        open_conn()
        Dim a As Integer
        Dim i As Integer
        a = 0
        If insert = 1 Then
            For i = 0 To DataGridView2.Rows.Count - 1
                If DataGridView2.Item(7, i).Value = True Then
                    Call update_approve_ro(Trim(DataGridView2.Item(0, i).Value), Trim(DataGridView2.Item(1, i).Value), Format(server_datetime(), "yyyy-MM-dd"), Trim(DataGridView2.Item(4, i).Value))
                    a = a + 1
                    'deleteRowApproved(b)
                End If

            Next
            If a = 0 Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Data Kosong")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo("Informasi", "Data berhasil di approve")
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo("Informasi", "Data gagal di approve")
                alertControl_error.Show(Me, info)
            End If
        End If
    End Sub

    Public Sub deleteRowApproved(ByVal index As Integer)
        open_conn()
        DataGridView2.Rows.RemoveAt(index)
    End Sub


    Private Sub btn_chk_all2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_chk_all2.Click
        open_conn()
        Dim i As Integer
        For i = 0 To DataGridView2.Rows.Count - 1
            DataGridView2.Item(7, i).Value = True
        Next
    End Sub

    Private Sub btn_clear2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear2.Click
        open_conn()
        Dim i As Integer
        For i = 0 To DataGridView2.Rows.Count - 1
            DataGridView2.Item(7, i).Value = False
        Next
    End Sub

    Private Sub DataGridView2_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        open_conn()
        qty_before_edit = DataGridView2.Item(4, DataGridView2.CurrentCell.RowIndex).Value
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    'Private Sub frmApproveRO_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column As Integer
    '    Dim Width_Table As Integer
    '    Dim selisih_col As Integer

    '    With DataGridView2
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(6).Width = .Columns(6).Width + selisih_col
    '    End With

    'End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class