Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Alerter

Public Class frmbom
    Dim i As Integer
    Public mCol As Integer
    Public mRow As Integer
    Public insert As Integer
    Public edit As Integer
    Public NoBuktiSO As String
    Dim pesan As String
    Dim IndexRowDg As Integer

    Private Sub frmbom_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmso_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub frmreceiptmoney_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        PanelControl3.Visible = False
        Me.MdiParent = MainMenu
        Call select_control_no("FORMULA PRODUCT", "MASTER")
        cbo_search.Text = "No Formula"
        txt_bom_no.Text = no_master
        'DataGridView1.Item(0, 0).Value = 1
        btn_del.Enabled = False
        Button1.Enabled = False
        insert = 1
        edit = 0
        btn_del.Enabled = False
        Call init_number()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
        fillComboBox()
        view_data()
    End Sub

    Private Sub cbo_customer_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim NewDisplayAcc As New frm_display_item
        NewDisplayAcc.formsource_bom_item = True
        NewDisplayAcc.Show()
        ' ' MainMenu.Enabled = False
        ' NewDisplayAcc.MdiParent = MainMenu
    End Sub

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView4
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = True
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(3).ReadOnly = False
            .Columns(4).ReadOnly = False
            .Columns(6).ReadOnly = True
            .Columns(6).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(5).ReadOnly = True
            .Columns(5).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Rows.Clear()
            .Rows.Add(250)
        End With
        With DataGridView3
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = False
            .Columns(4).ReadOnly = False
            .Columns(6).ReadOnly = False
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(5).ReadOnly = True
            .Columns(7).ReadOnly = True
            .Columns(7).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Rows.Clear()
            .Rows.Add(250)
        End With
        'DataGridView1.ReadOnly = True
        With DataGridView1
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = False
            .Columns(4).ReadOnly = False
            .Columns(6).ReadOnly = True
            .Columns(6).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(5).ReadOnly = True
            .Columns(7).ReadOnly = True
            .Columns(7).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Rows.Clear()
            .Rows.Add(250)
        End With

    End Sub

    Private Sub init_number()
        open_conn()
        txt_tax.Text = FormatPercent(0, 0)
        txt_total.Text = 0
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        open_conn()
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex

        If mCol = 1 Then
            cbo_material.Visible = True
            cbo_material.Left = DataGridView1.GetCellDisplayRectangle(mCol, mRow, False).Left
            cbo_material.Top = DataGridView1.GetCellDisplayRectangle(mCol, mRow, False).Top - 1
        Else
            cbo_material.Visible = False
        End If

        If mCol = 5 Then
            cbo_unit_material.Visible = True
            cbo_unit_material.Left = DataGridView1.GetCellDisplayRectangle(mCol, mRow, False).Left
            cbo_unit_material.Top = DataGridView1.GetCellDisplayRectangle(mCol, mRow, False).Top - 1
        Else
            cbo_unit_material.Visible = False
        End If
    End Sub

    Private Sub cek_qty_stock(ByVal input_qty As Integer, ByVal item_id As String)
        Dim DT_stock As DataTable
        DT_stock = select_get_stock(item_id)
        If DT_stock.Rows(0).Item(0) < input_qty Then
            MsgBox("Jumlah Stock " & DT_stock.Rows(0).Item(0) & " Tidak Mencukupi")
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
        End If
    End Sub

    Dim TSubTotal As Double
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        isi_hitung_nominal()
    End Sub

    Private Sub isi_hitung_nominal()
        Dim rows As Integer
        Dim columnIndex As Integer
        TSubTotal = 0
        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        If columnIndex = 4 Or columnIndex = 6 Or columnIndex = 1 Or columnIndex = 2 Then
            If IsNumeric(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value) = False Then
                DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
            End If
            If IsNumeric(DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value) = False Then
                DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = 0
            End If

            'cek_qty_stock(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
            DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = FormatNumber(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value * DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value, 0)
        End If
        If Trim(DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView1.Item(2, DataGridView1.CurrentCell.RowIndex).Value) = "" Then
            DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
            DataGridView1.Item(6, DataGridView1.CurrentCell.RowIndex).Value = 0
            DataGridView1.Item(7, DataGridView1.CurrentCell.RowIndex).Value = 0
            MsgBox("Item is Empty!", MsgBoxStyle.Critical, "Masukkan Bahan Baku")
            Exit Sub
        End If
        rows = DataGridView1.Rows.Count - 1
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next

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

        'menghitung netto
        'TNett = TSubTotal - (TSubTotal * CDbl(Replace(txt_disc.Text, "%", "")) / 100)
        'txt_netto.Text = FormatNumber(TNett, 0)
        Ttotal = TSubTotal

        'menghitung total
        txt_total.Text = FormatNumber(Ttotal, 0)

        'menghitung change
        'Tchange = (CDbl(txt_paid.Text)) - Ttotal
        'txt_change.Text = FormatNumber(Tchange, 0)
    End Sub

    Private Sub hitung_nominal_wip()
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
        Ttotal = TSubTotal

        'menghitung total
        txt_total_wip.Text = FormatNumber(Ttotal, 0)

        'menghitung change
        'Tchange = (CDbl(txt_paid.Text)) - Ttotal
        'txt_change.Text = FormatNumber(Tchange, 0)
    End Sub

    Private Sub hitung_nominal_konversi()
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
        Ttotal = TSubTotal

        'menghitung total
        txt_total_konversi.Text = FormatNumber(Ttotal, 0)

        'menghitung change
        'Tchange = (CDbl(txt_paid.Text)) - Ttotal
        'txt_change.Text = FormatNumber(Tchange, 0)
    End Sub

    Private Sub txt_tax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_tax.GotFocus
        open_conn()
        txt_tax.SelectionStart = 0
        txt_tax.SelectionLength = Len(txt_tax.Text)
    End Sub

    Private Sub txt_tax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_tax.LostFocus
        open_conn()
        TSubTotal = 0
        Dim i As Integer
        If txt_tax.Text = "" Then
            txt_tax.Text = FormatPercent(0, 0)
        Else
            txt_tax.Text = FormatPercent(CDbl(Replace(txt_tax.Text, "%", "")) / 100, 0)
        End If
        For i = 0 To DataGridView1.Rows.Count - 1
            TSubTotal = TSubTotal + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        hitung_nominal()
    End Sub

    Private Sub clean()
        open_conn()
        With Me
            .cbo_item.EditValue = Nothing
            .txt_item_nm.Text = ""
            .txt_qty.Text = 0
            .cbo_unit_produksi.EditValue = Nothing
            .txt_comment.Text = ""
        End With
        ' For i = 0 To DataGridView1.Rows.Count - 1
        'DataGridView1.Item(0, i).Value = ""
        'DataGridView1.Item(1, i).Value = ""
        'DataGridView1.Item(2, i).Value = ""
        'DataGridView1.Item(3, i).Value = ""
        'DataGridView1.Item(4, i).Value = 0
        'DataGridView1.Item(5, i).Value = ""
        'DataGridView1.Item(6, i).Value = 0
        'DataGridView1.Item(7, i).Value = 0
        'DataGridView1.Rows.RemoveAt(i)
        'Next
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        DataGridView3.Rows.Clear()
        DataGridView3.Rows.Add(250)
        DataGridView4.Rows.Clear()
        DataGridView4.Rows.Add(250)
        Call select_control_no("FORMULA PRODUCT", "MASTER")
        txt_bom_no.Text = no_master
        insert = 1
        edit = 0
        btn_del2.Enabled = False
        btn_cetak2.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_bom"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "no_bom"))
        End If
    End Sub

    Private Sub insert_data()
        open_conn()
        Dim i As Integer
        If insert = 1 Then
            Call insert_billofmaterial(txt_bom_no.Text, cbo_item.EditValue, txt_comment.Text, txt_qty.Text, cbo_unit_produksi.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                                        username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, "", 0, "", _
                                        0, "", 0, "", 0, _
                                        "", 0, _
                                        "", 0, _
                                        "", 0, _
                                        0, _
                                        "", 0, _
                                        0, 0, _
                                       "INSERT", (CDbl(Replace(txt_total.Text, ",", "")) + CDbl(Replace(txt_total_wip.Text, ",", "")) + CDbl(Replace(txt_total_konversi.Text, ",", ""))))
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then
                    Call insert_billofmaterial(txt_bom_no.Text, cbo_item.EditValue, txt_comment.Text, txt_qty.Text, cbo_unit_produksi.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                                        username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, _
                                        DataGridView1.Item(1, i).Value, _
                                        Replace(DataGridView1.Item(4, i).Value, ",", ""), _
                                        DataGridView1.Item(5, i).Value, _
                                        Replace(DataGridView1.Item(6, i).Value, ",", ""), _
                                        DataGridView1.Item(3, i).Value, _
                                        Replace(DataGridView1.Item(7, i).Value, ",", ""), _
                                        "", _
                                        0, _
                                        "", 0, _
                                        "", 0, _
                                        "", 0, _
                                        0, _
                                        "", 0, _
                                        1, i, _
                                        "INSERT", (CDbl(Replace(txt_total.Text, ",", "")) + CDbl(Replace(txt_total_wip.Text, ",", "")) + CDbl(Replace(txt_total_konversi.Text, ",", ""))))
                End If
            Next

            For i = 0 To DataGridView3.Rows.Count - 1
                If DataGridView3.Item(1, i).Value <> "" Then
                    Call insert_billofmaterial(txt_bom_no.Text, cbo_item.EditValue, txt_comment.Text, txt_qty.Text, cbo_unit_produksi.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                                        username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        DataGridView3.Item(1, i).Value, _
                                        Replace(DataGridView3.Item(4, i).Value, ",", ""), _
                                        DataGridView3.Item(5, i).Value, _
                                        Replace(DataGridView3.Item(6, i).Value, ",", ""), _
                                        DataGridView3.Item(3, i).Value, _
                                        Replace(DataGridView3.Item(7, i).Value, ",", ""), _
                                        "", 0, _
                                        0, _
                                        "", 0, _
                                        2, i, _
                                        "INSERT", (CDbl(Replace(txt_total.Text, ",", "")) + CDbl(Replace(txt_total_wip.Text, ",", "")) + CDbl(Replace(txt_total_konversi.Text, ",", ""))))
                End If
            Next

            For i = 0 To DataGridView4.Rows.Count - 1
                If DataGridView4.Item(1, i).Value <> "" Then
                    Call insert_billofmaterial(txt_bom_no.Text, cbo_item.EditValue, txt_comment.Text, txt_qty.Text, cbo_unit_produksi.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                                        username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        DataGridView4.Item(1, i).Value, Replace(DataGridView4.Item(4, i).Value, ",", ""), _
                                        Replace(DataGridView4.Item(5, i).Value, ",", ""), _
                                        DataGridView4.Item(3, i).Value, Replace(DataGridView4.Item(6, i).Value, ",", ""), _
                                        3, i, _
                                        "INSERT", (CDbl(Replace(txt_total.Text, ",", "")) + CDbl(Replace(txt_total_wip.Text, ",", "")) + CDbl(Replace(txt_total_konversi.Text, ",", ""))))
                End If
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                'update_no_trans(txt_date.Value, "SALES_ORDER")
                pesan = MsgBox("Print Bill Of Material?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New FormNotaSO
                    NoBuktiSO = Trim(txt_bom_no.Text)
                    With DisplayNota
                        .Show()
                        ' .MdiParent = MainMenu
                        .WindowState = FormWindowState.Maximized
                    End With
                End If
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            'If select_validate("Sales Order", Trim(txt_bom_no.Text)) > 0 Then
            '    MsgBox("SO Sudah Digunakan Di Sales", MsgBoxStyle.Information, "Validate")
            '    Exit Sub
            'End If
            Call update_billofmaterial(txt_bom_no.Text, cbo_item.EditValue, txt_comment.Text, txt_qty.Text, cbo_unit_produksi.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                                        username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, "", 0, "", _
                                        0, "", 0, "", 0, _
                                        "", 0, _
                                        "", 0, _
                                        "", 0, _
                                        0, _
                                        "", 0, _
                                        0, 0, _
                                       "UPDATE", (CDbl(Replace(txt_total.Text, ",", "")) + CDbl(Replace(txt_total_wip.Text, ",", "")) + CDbl(Replace(txt_total_konversi.Text, ",", ""))))
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(1, i).Value <> "" Then
                    Call update_billofmaterial(txt_bom_no.Text, cbo_item.EditValue, txt_comment.Text, txt_qty.Text, cbo_unit_produksi.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                                        username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, _
                                        DataGridView1.Item(1, i).Value, _
                                        Replace(DataGridView1.Item(4, i).Value, ",", ""), _
                                        DataGridView1.Item(5, i).Value, _
                                        Replace(DataGridView1.Item(6, i).Value, ",", ""), _
                                        DataGridView1.Item(3, i).Value, _
                                        Replace(DataGridView1.Item(7, i).Value, ",", ""), _
                                        "", _
                                        0, _
                                        "", 0, _
                                        "", 0, _
                                        "", 0, _
                                        0, _
                                        "", 0, _
                                        1, i, _
                                        "UPDATE", (CDbl(Replace(txt_total.Text, ",", "")) + CDbl(Replace(txt_total_wip.Text, ",", "")) + CDbl(Replace(txt_total_konversi.Text, ",", ""))))
                End If
            Next

            For i = 0 To DataGridView3.Rows.Count - 1
                If DataGridView3.Item(1, i).Value <> "" Then
                    Call update_billofmaterial(txt_bom_no.Text, cbo_item.EditValue, txt_comment.Text, txt_qty.Text, cbo_unit_produksi.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                                        username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        DataGridView3.Item(1, i).Value, _
                                        Replace(DataGridView3.Item(4, i).Value, ",", ""), _
                                        DataGridView3.Item(5, i).Value, _
                                        Replace(DataGridView3.Item(6, i).Value, ",", ""), _
                                        DataGridView3.Item(3, i).Value, _
                                        Replace(DataGridView3.Item(7, i).Value, ",", ""), _
                                        "", 0, _
                                        0, _
                                        "", 0, _
                                        2, i, _
                                        "UPDATE", (CDbl(Replace(txt_total.Text, ",", "")) + CDbl(Replace(txt_total_wip.Text, ",", "")) + CDbl(Replace(txt_total_konversi.Text, ",", ""))))
                End If
            Next

            For i = 0 To DataGridView4.Rows.Count - 1
                If DataGridView4.Item(1, i).Value <> "" Then
                    Call update_billofmaterial(txt_bom_no.Text, cbo_item.EditValue, txt_comment.Text, txt_qty.Text, cbo_unit_produksi.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                                        username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        "", _
                                        0, _
                                        DataGridView4.Item(1, i).Value, Replace(DataGridView4.Item(4, i).Value, ",", ""), _
                                        Replace(DataGridView4.Item(5, i).Value, ",", ""), _
                                        DataGridView4.Item(3, i).Value, Replace(DataGridView4.Item(6, i).Value, ",", ""), _
                                        3, i, _
                                        "UPDATE", (CDbl(Replace(txt_total.Text, ",", "")) + CDbl(Replace(txt_total_wip.Text, ",", "")) + CDbl(Replace(txt_total_konversi.Text, ",", ""))))
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

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        open_conn()
        'For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '    If DataGridView1.Item(2, i).Value = "" And DataGridView1.Item(1, i).Value <> "" Then
        '        MsgBox("Data Unit Belum Lengkap", MsgBoxStyle.Information, "Informasi")
        '        Exit Sub
        '    End If
        'Next
        insert_data()
    End Sub

    Private Sub view_data()
        open_conn()
        'If TabControl1.SelectedTab Is TabList Then
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            Dim Rows As Integer
            Dim DT As DataTable
            Dim date_filter As Integer
            If chk_date.Checked = True Then
                date_filter = 1
            ElseIf chk_date.Checked = False Then
                date_filter = 0
            End If
            DT = select_billofmaterial(Trim(txt_search.Text), 0, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
            GridControl.DataSource = DT
            GridList_Customer.Columns("no_bom").Caption = "No BOM"
            GridList_Customer.Columns("no_bom").Width = 180
            GridList_Customer.Columns("id_item").Caption = "Kode Produk"
            GridList_Customer.Columns("id_item").Width = 200
            GridList_Customer.Columns("item_name").Caption = "Deskripsi Produk"
            GridList_Customer.Columns("item_name").Width = 300
            GridList_Customer.Columns("qty_item_production").Caption = "Jumlah Produksi"
            GridList_Customer.Columns("qty_item_production").Width = 150
            GridList_Customer.Columns("unit").Caption = "Unit"
            GridList_Customer.Columns("unit").Width = 100
            GridList_Customer.Columns("notes").Caption = "Keterangan"
            GridList_Customer.Columns("notes").Width = 300
            GridList_Customer.Columns("date_trn").Caption = "Tanggal"
            GridList_Customer.Columns("date_trn").Width = 90
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Customer.Columns("date_trn").DisplayFormat.FormatString = "dd-MMM-yyyy"
            'GridList_Customer.BestFitColumns()
            'Rows = DT.Rows.Count - 1

            'DataGridView2.Rows.Clear()
            'Dim i As Integer
            'If DT.Rows().Count > 0 Then
            '    For i = 0 To Rows
            '        DataGridView2.Rows.Add()
            '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            '        DataGridView2.Item(2, i).Value = Format(DT.Rows(i).Item(2), "yyyy-MM-dd")
            '        DataGridView2.Item(3, i).Value = FormatNumber(DT.Rows(i).Item(3), 0)
            '        DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item(4), 0)
            '        DataGridView2.Item(5, i).Value = FormatNumber(DT.Rows(i).Item(5), 0)
            '        DataGridView2.Item(6, i).Value = DT.Rows(i).Item(6)
            '    Next
            'End If
            'End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        open_conn()
        view_data()

        Dim Total_Width_Column, Total_Width_Column2 As Integer
        Dim Width_Table, Width_Table2 As Integer
        Dim selisih_col, selisih_col2 As Integer

        With DataGridView1
            Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width
            Width_Table = .Width
            selisih_col = Width_Table - Total_Width_Column - 65
            .Columns(3).Width = .Columns(3).Width + selisih_col
        End With
        With DataGridView2
            Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width
            Width_Table2 = .Width
            selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
            .Columns(6).Width = .Columns(6).Width + selisih_col2
        End With
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        TSubTotal = 0
        edit = 1
        insert = 0
        'current_row = cbo_acc_group.SelectedIndex
        Dim DT, DTDetail1, DTDetail2, DTDetail3 As DataTable
        Dim rows As Integer
        Dim date_filter As Integer
        If chk_date.Checked = True Then
            date_filter = 1
        ElseIf chk_date.Checked = False Then
            date_filter = 0
        End If
        btn_del2.Enabled = True
        btn_cetak2.Enabled = True
        DT = select_billofmaterial(criteria, 1, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rows = DT.Rows.Count - 1
        If DT.Rows.Count > 0 Then
            cbo_item.EditValue = DT.Rows(0).Item("id_item")
            txt_bom_no.Text = DT.Rows(0).Item("no_bom")
            txt_comment.Text = DT.Rows(0).Item("notes")
            txt_date.Value = DT.Rows(0).Item("date_trn")
            txt_qty.Text = FormatNumber(DT.Rows(0).Item("qty_item_production"), 0)
            cbo_unit_produksi.EditValue = DT.Rows(0).Item("id_unit")
        End If
        DTDetail1 = select_billofmaterial(criteria, 2, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rows = DTDetail1.Rows.Count - 1
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(250)
        Dim i As Integer
        If DTDetail1.Rows.Count > 0 Then
            For i = 0 To rows
                DataGridView1.Item(0, i).Value = i + 1
                If IsDBNull(DTDetail1.Rows(i).Item("id_item_material")) = False Then
                    DataGridView1.Item(1, i).Value = DTDetail1.Rows(i).Item("id_item_material")
                End If
                If IsDBNull(DTDetail1.Rows(i).Item("item_name")) = False Then
                    DataGridView1.Item(2, i).Value = DTDetail1.Rows(i).Item("item_name")
                End If
                If IsDBNull(DTDetail1.Rows(i).Item("notes_material")) = False Then
                    DataGridView1.Item(3, i).Value = DTDetail1.Rows(i).Item("notes_material")
                End If
                If IsDBNull(DTDetail1.Rows(i).Item("qty_material")) = False Then
                    DataGridView1.Item(4, i).Value = FormatNumber(DTDetail1.Rows(i).Item("qty_material"), 0)
                End If
                If IsDBNull(DTDetail1.Rows(i).Item("id_unit_material")) = False Then
                    DataGridView1.Item(5, i).Value = DTDetail1.Rows(i).Item("id_unit_material")
                End If
                If IsDBNull(DTDetail1.Rows(i).Item("material_cost")) = False Then
                    DataGridView1.Item(6, i).Value = FormatNumber(DTDetail1.Rows(i).Item("material_cost"), 0)
                End If
                If IsDBNull(DTDetail1.Rows(i).Item("total_cost_material")) = False Then
                    DataGridView1.Item(7, i).Value = FormatNumber(DTDetail1.Rows(i).Item("total_cost_material"), 0)
                End If
            Next
        End If
        DTDetail2 = select_billofmaterial(criteria, 3, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rows = DTDetail2.Rows.Count - 1
        DataGridView3.Rows.Clear()
        DataGridView3.Rows.Add(250)
        If DTDetail2.Rows.Count > 0 Then
            For i = 0 To rows
                DataGridView3.Item(0, i).Value = i + 1
                If IsDBNull(DTDetail2.Rows(i).Item("id_item_wip")) = False Then
                    DataGridView3.Item(1, i).Value = DTDetail2.Rows(i).Item("id_item_wip")
                End If
                If IsDBNull(DTDetail2.Rows(i).Item("item_name")) = False Then
                    DataGridView3.Item(2, i).Value = DTDetail2.Rows(i).Item("item_name")
                End If
                If IsDBNull(DTDetail2.Rows(i).Item("notes_wip")) = False Then
                    DataGridView3.Item(3, i).Value = DTDetail2.Rows(i).Item("notes_wip")
                End If
                If IsDBNull(DTDetail2.Rows(i).Item("qty_wip")) = False Then
                    DataGridView3.Item(4, i).Value = FormatNumber(DTDetail2.Rows(i).Item("qty_wip"), 0)
                End If
                If IsDBNull(DTDetail2.Rows(i).Item("id_unit_wip")) = False Then
                    DataGridView3.Item(5, i).Value = DTDetail2.Rows(i).Item("id_unit_wip")
                End If
                If IsDBNull(DTDetail2.Rows(i).Item("wip_cost")) = False Then
                    DataGridView3.Item(6, i).Value = FormatNumber(DTDetail2.Rows(i).Item("wip_cost"), 0)
                End If
                If IsDBNull(DTDetail2.Rows(i).Item("total_cost_wip")) = False Then
                    DataGridView3.Item(7, i).Value = FormatNumber(DTDetail2.Rows(i).Item("total_cost_wip"), 0)
                End If
            Next
        End If

        DTDetail3 = select_billofmaterial(criteria, 4, date_filter, Format(tglawal.Value, "yyyy-MM-dd"), Format(tglakhir.Value, "yyyy-MM-dd"))
        rows = DTDetail3.Rows.Count - 1
        DataGridView4.Rows.Clear()
        DataGridView4.Rows.Add(250)
        If DTDetail3.Rows.Count > 0 Then
            For i = 0 To rows
                DataGridView4.Item(0, i).Value = i + 1
                If IsDBNull(DTDetail3.Rows(i).Item("id_cost_konversi")) = False Then
                    DataGridView4.Item(1, i).Value = DTDetail3.Rows(i).Item("id_cost_konversi")
                End If
                If IsDBNull(DTDetail3.Rows(i).Item("cost_name")) = False Then
                    DataGridView4.Item(2, i).Value = DTDetail3.Rows(i).Item("cost_name")
                End If
                If IsDBNull(DTDetail3.Rows(i).Item("qty_hour")) = False Then
                    DataGridView4.Item(4, i).Value = FormatNumber(DTDetail3.Rows(i).Item("qty_hour"), 0)
                End If
                If IsDBNull(DTDetail3.Rows(i).Item("cost_konversi")) = False Then
                    DataGridView4.Item(5, i).Value = FormatNumber(DTDetail3.Rows(i).Item("cost_konversi"), 0)
                End If
                If IsDBNull(DTDetail3.Rows(i).Item("notes_konversi")) = False Then
                    DataGridView4.Item(3, i).Value = DTDetail3.Rows(i).Item("notes_konversi")
                End If
                If IsDBNull(DTDetail3.Rows(i).Item("total_cost_konversi")) = False Then
                    DataGridView4.Item(6, i).Value = FormatNumber(DTDetail3.Rows(i).Item("total_cost_konversi"), 0)
                End If
            Next
        End If
        Dim tsubmaterial, tsubwip, tsubkonversi As Double
        For i = 0 To DataGridView1.Rows.Count - 1
            tsubmaterial = tsubmaterial + Replace(DataGridView1.Item(7, i).Value, ",", "")
        Next
        txt_total.Text = FormatNumber(tsubmaterial, 0)
        rows = DataGridView3.Rows.Count - 1
        For i = 0 To rows
            tsubwip = tsubwip + Replace(DataGridView3.Item(7, i).Value, ",", "")
        Next
        txt_total_wip.Text = FormatNumber(tsubwip, 0)
        rows = DataGridView4.Rows.Count - 1
        For i = 0 To rows
            tsubkonversi = tsubkonversi + Replace(DataGridView4.Item(6, i).Value, ",", "")
        Next
        txt_total_konversi.Text = FormatNumber(tsubkonversi, 0)
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        open_conn()
        clean()
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click

        open_conn()
        If edit = 1 Then
            If select_validate("Sales Order", Trim(txt_bom_no.Text)) > 0 Then
                MsgBox("SO Sudah Digunakan Di Sales", MsgBoxStyle.Information, "Validate")
                Exit Sub
            End If
            pesan = MessageBox.Show("Delete Confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                'Call delete_sales_order(Trim(txt_so_no.Text), cbo_customer.Text, txt_date.Value, txt_comment.Text, Replace(txt_subtotal.Text, ",", ""), _
                '                Replace(txt_tax.Text, "%", ""), Replace(txt_total.Text, ",", ""), username, server_datetime(), server_datetime(), username, _
                '                0, "", "", 0, "", 0, 0, "", 0, 0)
                'If param_sukses = True Then
                '    MsgBox("Data Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Delete Success")
                '    clean()
                'End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick


    End Sub

    Private Sub DataGridView2_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEnter

    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        edit = 1
        insert = 0
        Dim a As Integer
        btn_del.Enabled = True
        Button1.Enabled = True
        a = DataGridView2.CurrentCell.RowIndex
        detail(DataGridView2.Item(0, a).Value)
        TabControl1.SelectedTab = TabInput
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
        cbo_search.Text = "No SO"
        txt_search.Text = ""
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        open_conn()
        view_data()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cetak2.Click
        open_conn()
        'Dim cryRpt3 As New ReportDocument
        'Dim pathfilereport As String
        'Dim pathfilepdf As String
        'Dim ReportFormula As String

        'pathfilereport = Application.StartupPath & "\Report\NotaSO.rpt"
        'pathfilepdf = Application.StartupPath & "\Report\NotaSO.pdf"

        'Try
        '    cryRpt3.Load(pathfilereport)

        '    ReportFormula = "{view_ctk_so1.no_sales_order} = '" & Trim(txt_so_no.Text) & "'"
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
        '    MsgBox("Nota Sudah Di buka, tutup nota terlebih dahulu", vbInformation, "Information")
        'End Try

        Dim DisplayNota As New FormNotaSO
        NoBuktiSO = Trim(txt_bom_no.Text)
        With DisplayNota
            .Show()
            ' .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub cbo_idbarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_nmbarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_unit_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_unit.GotFocus
        open_conn()
        cbo_unit.DroppedDown = True
    End Sub

    Private Sub txt_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_price.KeyPress
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_qty2.KeyPress
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub fillComboBox()
        Dim DTItem As DataTable
        Dim DTGood, DTRaw, DTWIP As DataRow()
        DTItem = getComboItem()
        DTGood = DTItem.Select("flag_sell = 1")
        If DTGood.Count > 0 Then
            cbo_item.Properties.DataSource = DTGood.CopyToDataTable
            cbo_item.Properties.DisplayMember = "item_name"
            cbo_item.Properties.ValueMember = "id_item"
            cbo_item.Properties.PopulateViewColumns()
            cbo_item.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            cbo_item.Properties.View.OptionsView.ShowAutoFilterRow = True
            cbo_item.Properties.View.Columns("id_item").Caption = "Kode Bahan"
            cbo_item.Properties.View.Columns("item_name").Caption = "Deskripsi"
            cbo_item.Properties.View.Columns("id_barcode").Caption = "Kode Barcode"
            cbo_item.Properties.View.Columns("mst_itemcat_nm").Caption = "Jenis"
            cbo_item.Properties.View.Columns("flag_sell").Visible = False
            cbo_item.Properties.View.Columns("flag_buy").Visible = False
            cbo_item.Properties.View.Columns("flag_inv").Visible = False
            cbo_item.Properties.View.Columns("sell_unit").Visible = False
        End If

        DTRaw = DTItem.Select("flag_inv = 1")
        If DTRaw.Count > 0 Then
            cbo_material.Properties.DataSource = DTRaw.CopyToDataTable
            cbo_material.Properties.DisplayMember = "item_name"
            cbo_material.Properties.ValueMember = "id_item"
            cbo_material.Properties.PopulateViewColumns()
            cbo_material.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            cbo_material.Properties.View.OptionsView.ShowAutoFilterRow = True
            cbo_material.Properties.View.Columns("id_item").Caption = "Kode Barang"
            cbo_material.Properties.View.Columns("item_name").Caption = "Deskripsi"
            cbo_material.Properties.View.Columns("id_barcode").Caption = "Kode Barcode"
            cbo_material.Properties.View.Columns("mst_itemcat_nm").Caption = "Jenis"
            cbo_material.Properties.View.Columns("sell_unit").Caption = "Unit Produksi"
            cbo_material.Properties.View.Columns("flag_sell").Visible = False
            cbo_material.Properties.View.Columns("flag_buy").Visible = False
            cbo_material.Properties.View.Columns("flag_inv").Visible = False
        End If

        DTWIP = DTItem.Select("flag_buy = 1")
        If DTWIP.Count > 0 Then
            cbo_wip.Properties.DataSource = DTWIP.CopyToDataTable
            cbo_wip.Properties.DisplayMember = "item_name"
            cbo_wip.Properties.ValueMember = "id_item"
            cbo_wip.Properties.PopulateViewColumns()
            cbo_wip.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            cbo_wip.Properties.View.OptionsView.ShowAutoFilterRow = True
            cbo_wip.Properties.View.Columns("id_item").Caption = "Kode Barang"
            cbo_wip.Properties.View.Columns("item_name").Caption = "Deskripsi"
            cbo_wip.Properties.View.Columns("id_barcode").Caption = "Kode Barcode"
            cbo_wip.Properties.View.Columns("mst_itemcat_nm").Caption = "Jenis"
            cbo_wip.Properties.View.Columns("sell_unit").Caption = "Unit Produksi"
            cbo_wip.Properties.View.Columns("flag_sell").Visible = False
            cbo_wip.Properties.View.Columns("flag_buy").Visible = False
            cbo_wip.Properties.View.Columns("flag_inv").Visible = False
            cbo_wip.Properties.View.Columns("sell_unit").Visible = False
        End If

        Dim DTUnit As DataTable
        DTUnit = getComboUnit()
        cbo_unit_produksi.Properties.DataSource = DTUnit
        cbo_unit_produksi.Properties.DisplayMember = "unit"
        cbo_unit_produksi.Properties.ValueMember = "id_unit"
        cbo_unit_produksi.Properties.PopulateViewColumns()
        cbo_unit_produksi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_unit_produksi.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_unit_produksi.Properties.View.Columns("id_unit").Caption = "ID Unit"
        cbo_unit_produksi.Properties.View.Columns("unit").Caption = "Unit"

        cbo_unit_material.Properties.DataSource = DTUnit
        cbo_unit_material.Properties.DisplayMember = "unit"
        cbo_unit_material.Properties.ValueMember = "id_unit"
        cbo_unit_material.Properties.PopulateViewColumns()
        cbo_unit_material.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_unit_material.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_unit_material.Properties.View.Columns("id_unit").Caption = "ID Unit"
        cbo_unit_material.Properties.View.Columns("unit").Caption = "Unit"

        cbo_unit_wip.Properties.DataSource = DTUnit
        cbo_unit_wip.Properties.DisplayMember = "unit"
        cbo_unit_wip.Properties.ValueMember = "id_unit"
        cbo_unit_wip.Properties.PopulateViewColumns()
        cbo_unit_wip.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_unit_wip.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_unit_wip.Properties.View.Columns("id_unit").Caption = "ID Unit"
        cbo_unit_wip.Properties.View.Columns("unit").Caption = "Unit"

        Dim DTBiayaKonversi As DataTable
        DTBiayaKonversi = getComboBiayaKonversi()
        cbo_konversi.Properties.DataSource = DTBiayaKonversi
        cbo_konversi.Properties.DisplayMember = "cost_name"
        cbo_konversi.Properties.ValueMember = "id_cost"
        cbo_konversi.Properties.PopulateViewColumns()
        cbo_konversi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_konversi.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_konversi.Properties.View.Columns("id_cost").Caption = "ID Biaya"
        cbo_konversi.Properties.View.Columns("cost_name").Caption = "Biaya"
        cbo_konversi.Properties.View.Columns("cost_def").Caption = "Nominal"
        cbo_konversi.Properties.View.Columns("cost_def").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        cbo_konversi.Properties.View.Columns("cost_def").DisplayFormat.FormatString = "N0"
    End Sub

    Private Sub cbo_customer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_curr_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim FrmAccount As New frm_display_unit
        FrmAccount.Show()
        FrmAccount.formsource_BOM = True
        '  FrmAccount.MdiParent = MainMenu
        ' ' MainMenu.Enabled = False
    End Sub

    Private Sub txt_curr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView4_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        open_conn()
        mRow = DataGridView4.CurrentCell.RowIndex
        mCol = DataGridView4.CurrentCell.ColumnIndex

        If mCol = 1 Then
            cbo_konversi.Visible = True
            cbo_konversi.Left = DataGridView4.GetCellDisplayRectangle(mCol, mRow, False).Left
            cbo_konversi.Top = DataGridView4.GetCellDisplayRectangle(mCol, mRow, False).Top - 1
        Else
            cbo_konversi.Visible = False
        End If

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

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
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

    Private Sub cbo_item_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_item.EditValueChanged
        If cbo_item.EditValue <> Nothing Then
            Dim row As DataRowView
            row = TryCast(cbo_item.Properties.GetRowByKeyValue(cbo_item.EditValue), DataRowView)
            txt_item_nm.Text = row.Item("mst_itemcat_nm") & ": " & row.Item("item_name")
        End If
    End Sub

    Private Sub cbo_unit_wip_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_unit_wip.EditValueChanged
        Dim row As DataRowView
        row = TryCast(cbo_unit_wip.Properties.GetRowByKeyValue(cbo_unit_wip.EditValue), DataRowView)
        DataGridView2.Item(mCol, mRow).Value = cbo_unit_wip.EditValue
        DataGridView2.Item(5, mRow).Value = row.Item("unit")
        cbo_unit_wip.Visible = False
    End Sub

    Private Sub cbo_unit_material_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_unit_material.EditValueChanged
        Dim row As DataRowView
        row = TryCast(cbo_unit_material.Properties.GetRowByKeyValue(cbo_unit_material.EditValue), DataRowView)
        DataGridView1.Item(mCol, mRow).Value = cbo_unit_material.EditValue
        DataGridView1.Item(5, mRow).Value = row.Item("unit")
        cbo_unit_material.Visible = False
    End Sub

    Private Sub cbo_wip_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_wip.EditValueChanged
        Dim row As DataRowView
        row = TryCast(cbo_wip.Properties.GetRowByKeyValue(cbo_wip.EditValue), DataRowView)
        DataGridView3.Item(mCol, mRow).Value = cbo_wip.EditValue
        DataGridView3.Item(1, mRow).Value = row.Item("id_item")
        DataGridView3.Item(2, mRow).Value = row.Item("item_name")
        DataGridView3.Item(5, mRow).Value = row.Item("sell_unit")
        set_cogs_avg(row.Item("id_item"), Format(txt_date.Value, "yyyy-MM-dd"))
        DataGridView3.Item(6, mRow).Value = FormatNumber(get_cogs_avg(row.Item("id_item")), 0)
        cbo_wip.Visible = False
        isi_hitung_wip()
    End Sub

    Private Sub cbo_material_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_material.EditValueChanged
        Dim row As DataRowView
        row = TryCast(cbo_material.Properties.GetRowByKeyValue(cbo_material.EditValue), DataRowView)
        DataGridView1.Item(mCol, mRow).Value = cbo_material.EditValue
        DataGridView1.Item(1, mRow).Value = row.Item("id_item")
        DataGridView1.Item(2, mRow).Value = row.Item("item_name")
        DataGridView1.Item(5, mRow).Value = row.Item("sell_unit")
        set_cogs_avg(row.Item("id_item"), Format(txt_date.Value, "yyyy-MM-dd"))
        DataGridView1.Item(6, mRow).Value = FormatNumber(get_cogs_avg(row.Item("id_item")), 0)
        cbo_material.Visible = False

        isi_hitung_nominal()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        mRow = DataGridView1.CurrentCell.RowIndex
        mCol = DataGridView1.CurrentCell.ColumnIndex

        DataGridView1.Item(0, mRow).Value = mRow + 1
    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        open_conn()
        mRow = DataGridView3.CurrentCell.RowIndex
        mCol = DataGridView3.CurrentCell.ColumnIndex

        If mCol = 1 Then
            cbo_wip.Visible = True
            cbo_wip.Left = DataGridView3.GetCellDisplayRectangle(mCol, mRow, False).Left
            cbo_wip.Top = DataGridView3.GetCellDisplayRectangle(mCol, mRow, False).Top - 1
        Else
            cbo_wip.Visible = False
        End If

        If mCol = 5 Then
            cbo_unit_wip.Visible = True
            cbo_unit_wip.Left = DataGridView3.GetCellDisplayRectangle(mCol, mRow, False).Left
            cbo_unit_wip.Top = DataGridView3.GetCellDisplayRectangle(mCol, mRow, False).Top - 1
        Else
            cbo_unit_wip.Visible = False
        End If
    End Sub

    Private Sub DataGridView3_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellEndEdit
        open_conn()
        isi_hitung_wip()
    End Sub

    Private Sub isi_hitung_wip()
        Dim rows As Integer
        Dim columnIndex As Integer
        TSubTotal = 0
        columnIndex = DataGridView3.CurrentCell.ColumnIndex
        If columnIndex = 4 Or columnIndex = 6 Or columnIndex = 1 Or columnIndex = 2 Then
            If IsNumeric(DataGridView3.Item(4, DataGridView3.CurrentCell.RowIndex).Value) = False Then
                DataGridView3.Item(4, DataGridView3.CurrentCell.RowIndex).Value = 0
            End If
            If IsNumeric(DataGridView3.Item(6, DataGridView3.CurrentCell.RowIndex).Value) = False Then
                DataGridView3.Item(6, DataGridView3.CurrentCell.RowIndex).Value = 0
            End If
            'cek_qty_stock(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
            DataGridView3.Item(7, DataGridView3.CurrentCell.RowIndex).Value = FormatNumber(DataGridView3.Item(4, DataGridView3.CurrentCell.RowIndex).Value * DataGridView3.Item(6, DataGridView3.CurrentCell.RowIndex).Value, 0)
        End If
        If Trim(DataGridView3.Item(1, DataGridView3.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView3.Item(2, DataGridView3.CurrentCell.RowIndex).Value) = "" Then
            DataGridView3.Item(4, DataGridView3.CurrentCell.RowIndex).Value = 0
            DataGridView3.Item(6, DataGridView3.CurrentCell.RowIndex).Value = 0
            DataGridView3.Item(7, DataGridView3.CurrentCell.RowIndex).Value = 0
            MsgBox("Item is Empty!", MsgBoxStyle.Critical, "Masukkan Bahan Baku")
            Exit Sub
        End If
        rows = DataGridView3.Rows.Count - 1
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView3.Item(7, i).Value, ",", "")
        Next

        hitung_nominal_wip()
    End Sub

    Private Sub DataGridView3_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellEnter
        mRow = DataGridView3.CurrentCell.RowIndex
        mCol = DataGridView3.CurrentCell.ColumnIndex

        DataGridView3.Item(0, mRow).Value = mRow + 1
    End Sub

    Private Sub DataGridView4_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellDoubleClick

    End Sub

    Private Sub DataGridView4_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellEndEdit
        open_conn()
        isi_hitung_konversi()
    End Sub

    Private Sub isi_hitung_konversi()
        Dim rows As Integer
        Dim columnIndex As Integer
        TSubTotal = 0
        columnIndex = DataGridView4.CurrentCell.ColumnIndex
        If columnIndex = 4 Or columnIndex = 6 Or columnIndex = 1 Or columnIndex = 2 Then
            'cek_qty_stock(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value, DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value)
            If IsNumeric((DataGridView4.Item(4, DataGridView4.CurrentCell.RowIndex).Value)) = False Then
                DataGridView4.Item(4, DataGridView4.CurrentCell.RowIndex).Value = 0
            End If
            If IsNumeric((DataGridView4.Item(5, DataGridView4.CurrentCell.RowIndex).Value)) = False Then
                DataGridView4.Item(5, DataGridView4.CurrentCell.RowIndex).Value = 0
            End If

            DataGridView4.Item(6, DataGridView4.CurrentCell.RowIndex).Value = FormatNumber(DataGridView4.Item(4, DataGridView4.CurrentCell.RowIndex).Value * DataGridView4.Item(5, DataGridView4.CurrentCell.RowIndex).Value, 0)
        End If
        If Trim(DataGridView4.Item(1, DataGridView4.CurrentCell.RowIndex).Value) = "" Or Trim(DataGridView4.Item(2, DataGridView4.CurrentCell.RowIndex).Value) = "" Then
            DataGridView4.Item(4, DataGridView4.CurrentCell.RowIndex).Value = 0
            DataGridView4.Item(6, DataGridView4.CurrentCell.RowIndex).Value = 0
            DataGridView4.Item(7, DataGridView4.CurrentCell.RowIndex).Value = 0
            MsgBox("Item is Empty!", MsgBoxStyle.Critical, "Masukkan Bahan Baku")
            Exit Sub
        End If
        rows = DataGridView4.Rows.Count - 1
        For i = 0 To rows
            TSubTotal = TSubTotal + Replace(DataGridView4.Item(6, i).Value, ",", "")
        Next

        hitung_nominal_konversi()
    End Sub

    Private Sub DataGridView4_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellEnter
        mRow = DataGridView4.CurrentCell.RowIndex
        mCol = DataGridView4.CurrentCell.ColumnIndex

        DataGridView4.Item(0, mRow).Value = mRow + 1
    End Sub

    Private Sub cbo_konversi_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_konversi.EditValueChanged
        Dim row As DataRowView
        row = TryCast(cbo_konversi.Properties.GetRowByKeyValue(cbo_konversi.EditValue), DataRowView)
        DataGridView4.Item(mCol, mRow).Value = cbo_konversi.EditValue
        DataGridView4.Item(1, mRow).Value = row.Item("id_cost")
        DataGridView4.Item(2, mRow).Value = row.Item("cost_name")
        DataGridView4.Item(5, mRow).Value = FormatNumber(row.Item("cost_def"), 0)
        cbo_konversi.Visible = False
        isi_hitung_konversi()
    End Sub

    Private Sub btn_save2_Click(sender As System.Object, e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_PRODUCT_FORMULA_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_PRODUCT_FORMULA_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If cbo_unit_produksi.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Unit Produksi Belum Dipilih")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        If Trim(txt_qty.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Qty Produksi Belum Diisi")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        insert_data()
    End Sub

    Private Sub btn_del2_Click(sender As System.Object, e As System.EventArgs) Handles btn_del2.Click
        open_conn()
        If edit = 1 Then
            If getTemplateAkses(username, "MN_PRODUCT_FORMULA_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If

            'If select_validate("Purchase", Trim(txt_inv_no.Text)) > 0 Then
            '    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Faktur ini telah lunas")
            '    alertControl_warning.Show(Me, info)
            '    Exit Sub
            'End If
            pesan = MessageBox.Show("Hapus Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_billofmaterial(txt_bom_no.Text, cbo_item.EditValue, txt_comment.Text, txt_qty.Text, cbo_unit_produksi.EditValue, Format(txt_date.Value, "yyyy-MM-dd"), _
                                         username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, "", 0, "", _
                                         0, "", 0, "", 0, _
                                         "", 0, _
                                         "", 0, _
                                         "", 0, _
                                         0, _
                                         "", 0, _
                                         0, 0, _
                                        "DELETE", (CDbl(Replace(txt_total.Text, ",", "")) + CDbl(Replace(txt_total_wip.Text, ",", "")) + CDbl(Replace(txt_total_konversi.Text, ",", ""))))
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

    Private Sub btn_reset2_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub
End Class