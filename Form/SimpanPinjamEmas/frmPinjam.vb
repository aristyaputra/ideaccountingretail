Imports CrystalDecisions.CrystalReports.Engine

Public Class frmPinjam

    Dim insert, insert_bayar As Integer
    Dim edit, edit_bayar As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan As String
    Public NoFakturJual As String
    Public no_bayar As String
    Private Sub datagrid_layout()
        open_conn()

        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.WhiteSmoke
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub frmPinjam_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmCurrency_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        'MainMenu.Activate()
    End Sub


    Private Sub tutup_akses_button()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_SIMPAN_PINJAM_ADD") <> True Then
                btn_save.Visible = False
            Else
                btn_save.Visible = True
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SIMPAN_PINJAM_EDIT") <> True Then
                btn_save.Visible = False
            Else
                btn_save.Visible = True
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SIMPAN_PINJAM_DELETE") <> True Then
                btn_delete.Visible = False
            Else
                btn_delete.Visible = True
            End If
        End If
    End Sub

    Private Sub fillComboBox()
        Dim DT As DataTable
        DT = getComboPelanggan()
        txt_pemb_before.Properties.DataSource = DT
        txt_pemb_before.Properties.DisplayMember = "nama"
        txt_pemb_before.Properties.ValueMember = "id_customer"
        txt_pemb_before.Properties.PopulateViewColumns()
        txt_pemb_before.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        txt_pemb_before.Properties.View.OptionsView.ShowAutoFilterRow = True
        txt_pemb_before.Properties.View.Columns("id_customer").Caption = "ID"
        txt_pemb_before.Properties.View.Columns("nama").Caption = "Nama"
    End Sub

    Private Sub frmkatbarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataCustomer.Customer' table. You can move, or remove it, as needed.
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        Me.Customer.Fill(Me.DataCustomer.Customer)
        'TODO: This line of code loads data into the 'DataCustomer.Customer' table. You can move, or remove it, as needed.
        open_conn()
        datagrid_layout()
        fillComboBox()
        insert = 1
        edit = 0
        btn_delete.Enabled = False
        Me.WindowState = FormWindowState.Maximized
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        If insert = 1 Then
            Call insert_no_trans("PINJAMAN", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("PINJAMAN", "TRANS")
            txt_nota_pinjam.Text = no_master
        End If
        'DataGridView2.Rows.Add(36)
        insert_bayar = 1
        edit_bayar = 0
        'If username <> "admin" Then
        '    Button5.Visible = False
        'End If

        If getTemplateAkses(username, "MN_BAYAR_PINJAMAN_EDIT") <> True Then
            Button2.Visible = False
        Else
            Button2.Visible = True
            DataGridView2.Columns(2).ReadOnly = False
        End If

        tutup_akses_button()
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        Button1.Enabled = False
        btn_help.Enabled = False
        txt_item_name.Text = ""
        txt_nota_pinjam.Text = ""
        txt_alamat.Text = ""
        btn_delete.Enabled = False
        CheckBox1.Checked = False
        txt_item_name.Enabled = True
        txt_nominal.Text = 0
        txt_berat.Text = 0
        txt_date.Enabled = True
        Call select_control_no("PINJAMAN", "TRANS")
        txt_nota_pinjam.Text = no_master
        txt_pemb_before.EditValue = Nothing
        DataGridView2.Rows.Clear()
        txt_nominal.Enabled = True
        txt_sisalunas.Text = 0
        txt_belum_bayar.Text = 0
        tutup_akses_button()
        If username <> "admin" Then
            Button5.Visible = False
        End If
    End Sub

    Public Sub insert_data()
        open_conn()
        Dim flag As Integer
        If cbo_surat.Text = "Dengan Surat" Then
            flag = 1
        ElseIf cbo_surat.Text = "Tidak Ada Surat" Then
            flag = 0
        End If
        If insert = 1 Then
            Call insert_pinjam(Trim(txt_nota_pinjam.Text), Trim(txt_pemb_before.EditValue), "", Trim(txt_item_name.Text), Replace(txt_nominal.Text, ",", ""), Format(txt_date.Value, "yyyy-MM-dd"), flag, Replace(txt_berat.Text, ",", ""), "INSERT", username, server_datetime(), username, server_datetime())
            If param_sukses = True Then
                MsgBox("Data Was Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
                update_no_trans(txt_date.Value, "PINJAMAN")
                pesan = MsgBox("Print Kartu?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New NotaKoperasi
                    NoFakturJual = Trim(txt_nota_pinjam.Text)
                    With DisplayNota
                        .Show()
                        '  .MdiParent = MainMenu
                        .WindowState = FormWindowState.Maximized
                    End With

                    'Dim R As New ReportDocument
                    'Dim pathfilereport As String
                    'pathfilereport = Application.StartupPath & "\Report\KartuPinjam.rpt"
                    'R.Load(pathfilereport)
                    'R.Refresh()
                    'R.RecordSelectionFormula = "{trn_pinjam1.no_pinjam} ='" & Trim(txt_nota_pinjam.Text) & "'"
                    'R.PrintToPrinter(1, False, 1, 1)
                End If
                clean()
            End If
        ElseIf edit = 1 Then
            Call update_pinjam(Trim(txt_nota_pinjam.Text), Trim(txt_pemb_before.EditValue), "", Trim(txt_item_name.Text), Replace(txt_nominal.Text, ",", ""), txt_date.Value, flag, Replace(txt_berat.Text, ",", ""), "UPDATE", username, server_datetime(), username, server_datetime())
            If param_sukses = True Then
                MsgBox("Data Was Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
                pesan = MsgBox("Print Kartu?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Dim DisplayNota As New NotaKoperasi
                    NoFakturJual = Trim(txt_nota_pinjam.Text)
                    With DisplayNota
                        .Show()
                        '  .MdiParent = MainMenu
                        .WindowState = FormWindowState.Maximized
                    End With
                    'Dim R As New ReportDocument
                    'Dim pathfilereport As String
                    'pathfilereport = Application.StartupPath & "\Report\KartuPinjam.rpt"
                    'R.Load(pathfilereport)
                    'R.Refresh()
                    'R.RecordSelectionFormula = "{trn_pinjam1.no_pinjam} ='" & Trim(txt_nota_pinjam.Text) & "'"
                    'R.PrintToPrinter(1, False, 1, 1)
                End If
                clean()
            End If
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_SIMPAN_PINJAM_ADD") <> True Then
                MsgBox("you do not have access rights!", MsgBoxStyle.Information, "User Right")
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SIMPAN_PINJAM_EDIT") <> True Then
                MsgBox("you do not have access rights!", MsgBoxStyle.Information, "User Right")
                Exit Sub
            End If
        End If
        If Trim(txt_pemb_before.Text.ToString) = "" Then
            MsgBox("Penjual belum dipilih", MsgBoxStyle.Information, "Perhatian")
            Exit Sub
        End If
        If Trim(txt_item_name.Text.ToString) = "" Then
            MsgBox("Keterangan barang belum di isi", MsgBoxStyle.Information, "Perhatian")
            Exit Sub
        End If
        If Trim(txt_nominal.Text) = "" Or txt_nominal.Text = 0 Then
            MsgBox("Nominal belum di isi", MsgBoxStyle.Information, "Perhatian")
            Exit Sub
        End If
        If Trim(cbo_surat.Text) = "" Then
            MsgBox("Keterangan ada / tidak surat harus di pilih", MsgBoxStyle.Information, "Perhatian")
            Exit Sub
        End If
        insert_data()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SIMPAN_PINJAM_DELETE") <> True Then
                MsgBox("you do not have access rights!", MsgBoxStyle.Information, "User Right")
                Exit Sub
            End If
        End If

        Dim flag As Integer
        If cbo_surat.Text = "Dengan Surat" Then
            flag = 1
        ElseIf cbo_surat.Text = "Tidak Ada Surat" Then
            flag = 0
        End If
        If edit = 1 Then
            pesan = MessageBox.Show("Ingin hapus data?", "Delete", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_pinjam(Trim(txt_nota_pinjam.Text), Trim(txt_pemb_before.Text), "", Trim(txt_item_name.Text), Replace(txt_nominal.Text, ",", ""), txt_date.Value, flag, Replace(txt_berat.Text, ",", ""), "DELETE", username, server_datetime(), username, server_datetime())
                If param_sukses = True Then
                    MsgBox("Data Was Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
                    clean()
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
        DT = select_pinjam("", 0)
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = DT.Rows(i).Item("no_pinjam")
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_customer")
            DataGridView1.Item(2, i).Value = Format(DT.Rows(i).Item("date_trn"), "dd-MMM-yyyy")
            DataGridView1.Item(3, i).Value = DT.Rows(i).Item("id_item")
            DataGridView1.Item(4, i).Value = DT.Rows(i).Item("item_name")
            DataGridView1.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("nominal"), 2)

        Next
    End Sub

    'Private Sub view_konversi_data()
    '    open_conn()
    '    Dim i As Integer
    '    Dim Rows As Integer
    '    Dim DT As DataTable
    '    DT = select_currency("", 2)
    '    Rows = DT.Rows.Count - 1
    '    DataGridView2.Rows.Clear()
    '    For i = 0 To Rows
    '        DataGridView2.Rows.Add()
    '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
    '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
    '        DataGridView2.Item(2, i).Value = DT.Rows(i).Item(2)
    '        DataGridView2.Item(3, i).Value = DT.Rows(i).Item(3)
    '        DataGridView2.Item(4, i).Value = DT.Rows(i).Item(4)
    '    Next
    'End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        Dim DT, DT_Bayar As DataTable
        DT = select_pinjam(criteria, 1)
        txt_nota_pinjam.Text = DT.Rows(0).Item("no_pinjam")
        txt_pemb_before.EditValue = DT.Rows(0).Item("id_customer")
        txt_item_name.Text = DT.Rows(0).Item("item_name")
        txt_alamat.Text = DT.Rows(0).Item("address")
        txt_nominal.Text = FormatNumber(DT.Rows(0).Item("nominal"), 2)
        txt_berat.Text = DT.Rows(0).Item("berat")
        txt_date.Text = DT.Rows(0).Item("date_trn")
        txt_sisalunas.Text = FormatNumber(DT.Rows(0).Item("nominal"), 2)
        If DT.Rows(0).Item("flag_surat") = 1 Then
            cbo_surat.Text = "Dengan Surat"
        ElseIf DT.Rows(0).Item("flag_surat") = 0 Then
            cbo_surat.Text = "Tidak Ada Surat"
        End If
        btn_help.Enabled = True
        Button1.Enabled = True
        txt_nominal.Enabled = False

        Dim total_angsuran As Double
        DataGridView2.Rows.Clear()
        DT_Bayar = select_pinjam_bayar(criteria, 1)
        If DT_Bayar.Rows.Count > 0 Then
            For b As Integer = 0 To DT_Bayar.Rows.Count - 1
                DataGridView2.Rows.Add(1)
                DataGridView2.Item(0, b).Value = Format(DT_Bayar.Rows(b).Item("date_trn"), "dd-MM-yyyy")
                DataGridView2.Item(8, b).Value = Format(DT_Bayar.Rows(b).Item("date_trn"), "yyyy-MM-dd")
                DataGridView2.Item(1, b).Value = Format(DT_Bayar.Rows(b).Item("due_date"), "dd-MM-yyyy")
                DataGridView2.Item(9, b).Value = Format(DT_Bayar.Rows(b).Item("due_date"), "yyyy-MM-dd")
                DataGridView2.Item(2, b).Value = FormatNumber(DT_Bayar.Rows(b).Item("bunga"), 2)
                DataGridView2.Item(3, b).Value = FormatNumber(DT_Bayar.Rows(b).Item("nominal_bunga"), 2)
                'total_angsuran = total_angsuran + DT_Bayar.Rows(b).Item("nominal_bunga")
                DataGridView2.Item(4, b).Value = True
            Next
        End If

        Dim current_row As Integer
        current_row = DT_Bayar.Rows.Count

        Dim akan_bayar As Integer
        Dim tgl_akhir As Date
        Dim var_bulan As String
        akan_bayar = select_akan_bayar(criteria)

        If jml_terbayar_koperasi(criteria) > 0 Then
            tgl_akhir = tgl_akhir_bayar(criteria)
        Else
            tgl_akhir = tgl_pinjam(criteria)
        End If


        If akan_bayar > 0 Then
            For i As Integer = 0 To akan_bayar - 1
                DataGridView2.Rows.Add(1)

                DataGridView2.Item(0, i + current_row).Value = Format(Now, "dd-MM-yyyy")
                DataGridView2.Item(8, i + current_row).Value = Format(Now, "yyyy-MM-dd")
                Dim bulan_skrg, bulan_due, tahun_skrg, tahun_akhir_byr, tahun_due, day_due As Integer
                Dim due_date As Date
                bulan_skrg = CInt(Format(tgl_akhir, "MM"))
                day_due = CInt(Format(tgl_akhir, "dd"))
                tahun_skrg = CInt(Format(Now, "yyyy"))
                tahun_akhir_byr = CInt(Format(tgl_akhir, "yyyy"))
                If bulan_due >= 12 Then
                    bulan_due = 1
                Else
                    bulan_due = bulan_skrg + i + 1
                End If
                If tahun_skrg > tahun_akhir_byr Then
                    tahun_due = tahun_due + 1
                Else
                    tahun_due = tahun_akhir_byr
                End If
                due_date = bulan_due & "-" & day_due & "-" & tahun_due
                DataGridView2.Item(1, i + current_row).Value = Format(due_date, "dd-MM-yyyy")
                DataGridView2.Item(9, i + current_row).Value = Format(due_date, "yyyy-MM-dd")
                DataGridView2.Item(2, i + current_row).Value = FormatNumber(0, 2)
                DataGridView2.Item(3, i + current_row).Value = FormatNumber(0, 2)
                ' total_angsuran = total_angsuran + DT_Bayar.Rows(i).Item("nominal_bunga")
                DataGridView2.Item(4, i + current_row).Value = False
            Next

        End If


        txt_belum_bayar.Text = FormatNumber(total_angsuran, 2)
        txt_lunas.Text = txt_sisalunas.Text

        For a As Integer = 0 To DataGridView2.Rows.Count - 1
            If DataGridView2.Item(4, a).Value = True Then
                DataGridView2.Item(2, a).ReadOnly = True
                'DataGridView2.Columns(5).TE = Color.White
                'DataGridView2.Columns(5).DefaultCellStyle.ForeColor = Color.White
            Else
                DataGridView2.Item(2, a).ReadOnly = False

            End If
        Next
        tutup_akses_button()
        If username <> "admin" Then
            Button5.Visible = False
        End If
    End Sub

    Private Sub txtket_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_item_name.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtkode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nota_pinjam.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        open_conn()
        clean()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        insert = 0
        edit = 1
        i = DataGridView1.CurrentCell.RowIndex
        detail(DataGridView1.Item(0, i).Value)
        TabControl1.SelectedTab = TabInput
        btn_delete.Enabled = True
        txt_date.Enabled = False


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        open_conn()
        If TabControl1.SelectedTab Is TabList Then
            view_data()
        End If
        'Dim Total_Width_Column2 As Integer
        'Dim Width_Table2 As Integer
        'Dim selisih_col2 As Integer

        'With DataGridView1
        '    Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(4).Width + .Columns(5).Width
        '    Width_Table2 = .Width
        '    selisih_col2 = Width_Table2 - Total_Width_Column2
        '    .Columns(4).Width = .Columns(4).Width + selisih_col2 + 400
        'End With
    End Sub

    'Private Sub btn_save_konversi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    open_conn()
    '    Dim rows As Integer
    '    Dim i As Integer
    '    rows = DataGridView2.Rows.Count - 1
    '    For i = 0 To rows
    '        If DataGridView2.Item(0, i).Value.ToString <> "" Then
    '            If DataGridView2.Item(0, i).Value <> DataGridView2.Item(3, i).Value Then
    '                Call update_setcurrency(DataGridView2.Item(0, i).Value, DataGridView2.Item(2, i).Value)
    '            End If
    '        End If
    '    Next
    '    If param_sukses = True Then
    '        MsgBox("Update Success", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
    '    End If
    'End Sub

    Private Sub txtnegara_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_alamat.KeyPress
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
            TabControl1.SelectedTab = TabInput
            btn_delete.Enabled = True
            txt_date.Enabled = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.CurrentCell.ColumnIndex = 6 Then
            Dim DisplayNota As New NotaKoperasi
            NoFakturJual = Trim(DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value)
            With DisplayNota
                .Show()
                '  .MdiParent = MainMenu
                .WindowState = FormWindowState.Maximized
            End With
        End If
    End Sub

    Private Sub txtnama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nota_pinjam.TextChanged

    End Sub

    Private Sub frmCurrency_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

    End Sub

    Private Sub TabConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NavBarControl9_Click(sender As System.Object, e As System.EventArgs) Handles NavBarControl9.Click

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub txt_pemb_before_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_pemb_before.EditValueChanged
        Dim id_customer, nama_customer, alamat As String
        Dim row As DataRowView
        Dim total_cost As Double
        row = TryCast(txt_pemb_before.Properties.GetRowByKeyValue(txt_pemb_before.EditValue), DataRowView)

        id_customer = row.Item("id_customer")
        nama_customer = row.Item("nama")
        alamat = row.Item("address")
        txt_alamat.Text = alamat
        ' txt_pemb_before.Text = id_customer
    End Sub

    Private Sub txt_berat_LostFocus(sender As Object, e As System.EventArgs) Handles txt_berat.LostFocus
        Dim berat As Double
        berat = Replace(txt_berat.Text, ",", "")
        txt_berat.Text = FormatNumber(berat, 2)
    End Sub

    Private Sub txt_nominal_LostFocus(sender As Object, e As System.EventArgs) Handles txt_nominal.LostFocus
        Dim nominal As Double
        nominal = Replace(txt_nominal.Text, ",", "")
        txt_nominal.Text = FormatNumber(nominal, 2)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim lastindex As Integer
        Dim bln_jt, bln_now As Integer
        Dim bln_jt_str As String
        Dim tgl_jt As Date
        bln_now = Month(server_datetime())
        bln_jt = bln_now + 1
        If Len(CStr(bln_now)) = 1 Then
            bln_jt_str = "0" & CStr(bln_now)
        Else
            bln_jt_str = CStr(bln_now)
        End If
        tgl_jt = bln_jt_str & "-" & Format(server_datetime(), "dd") & "-" & Format(server_datetime(), "yyyy")


        lastindex = DataGridView2.Rows.Count - 1
        DataGridView2.Rows.Add(1)
        DataGridView2.Item(0, lastindex + 1).Value = Format(Now, "dd-MM-yyyy")
        DataGridView2.Item(1, lastindex + 1).Value = Format(tgl_jt, "dd-MM-yyyy")
        DataGridView2.Item(8, lastindex + 1).Value = Format(Now, "yyyy-MM-dd")
        DataGridView2.Item(9, lastindex + 1).Value = Format(tgl_jt, "yyyy-MM-dd")

    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If DataGridView2.Item(4, DataGridView2.CurrentCell.RowIndex).Value = False Then
            If DataGridView2.CurrentCell.ColumnIndex = 6 Then
                DataGridView2.Rows.RemoveAt(DataGridView2.CurrentCell.RowIndex)
            ElseIf DataGridView2.CurrentCell.ColumnIndex = 5 Then
                insert_data_bayar()
            End If
        Else
            If DataGridView2.CurrentCell.ColumnIndex = 6 Then
                MsgBox("Data angsuran yang sudah masuk tidak dapat dihapus", MsgBoxStyle.Critical, "Warning")
            End If
        End If

    End Sub


    Public Sub insert_data_bayar()
        open_conn()
        Dim colIndex, rowIndex As Integer
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        rowIndex = DataGridView2.CurrentCell.RowIndex

        If Replace(DataGridView2.Item(2, rowIndex).Value, ",", "") = 0 Or Replace(DataGridView2.Item(2, rowIndex).Value, ",", "") = "" Then
            MsgBox("Masukkan Bunga", MsgBoxStyle.Critical, "Information")
            Exit Sub
        End If


        Call insert_no_trans("BAYAR_PINJAMAN", Month(DataGridView2.Item(8, rowIndex).Value), Year(DataGridView2.Item(8, rowIndex).Value))
        Call select_control_no("BAYAR_PINJAMAN", "TRANS")
        no_bayar = no_master

        If insert_bayar = 1 Then
            Call insert_bayarpinjam(no_bayar, txt_nota_pinjam.Text, Replace(txt_nominal.Text, ",", ""), DataGridView2.Item(8, rowIndex).Value, Replace(0, ",", ""), "INSERT", Replace(DataGridView2.Item(3, rowIndex).Value, ",", ""), DataGridView2.Item(9, rowIndex).Value)
            If param_sukses = True Then
                MsgBox("Data Was Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
                update_no_trans(txt_date.Value, "BAYAR_PINJAMAN")
                'clean()
                DataGridView2.Item(4, rowIndex).Value = True
                Dim DisplayNota As New NotaBayarKoperasi
                'NoFakturJual = Trim(txt_nota_pinjam.Text)
                With DisplayNota
                    .Show()
                    '  .MdiParent = MainMenu
                    .WindowState = FormWindowState.Maximized
                End With

                'pesan = MsgBox("Print Pembayaran?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                'If pesan = vbYes Then
                '    Dim R As New ReportDocument
                '    Dim pathfilereport As String
                '    pathfilereport = Application.StartupPath & "\Report\KartuBayar.rpt"
                '    R.Load(pathfilereport)
                '    R.Refresh()
                '    R.RecordSelectionFormula = "{view_kartu_bayar1.no_bayar} ='" & Trim(no_bayar) & "'"
                '    R.PrintToPrinter(1, False, 1, 1)
                '    update_printstatus(no_bayar)
                'End If
            End If
        ElseIf edit_bayar = 1 Then
            Call update_bayarpinjam(DataGridView2.Item(6, rowIndex).Value, txt_nota_pinjam.Text, Replace(txt_nominal.Text, ",", ""), DataGridView2.Item(7, rowIndex).Value, Replace(0, ",", ""), "UPDATE", Replace(DataGridView2.Item(2, rowIndex).Value, ",", ""))
            If param_sukses = True Then
                MsgBox("Data Was Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
                'clean()
                DataGridView2.Item(3, rowIndex).Value = True
            End If
        End If
    End Sub

    Public Sub insert_data_lunas()
        open_conn()
        
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            If Replace(DataGridView2.Item(2, i).Value, ",", "") = 0 Or Replace(DataGridView2.Item(2, i).Value, ",", "") = "" Then
                MsgBox("Masukkan Bunga", MsgBoxStyle.Critical, "Information")
                Exit Sub
            End If
        Next

        Dim due_date As Date
        If insert_bayar = 1 Then
            For a As Integer = 0 To DataGridView2.Rows.Count - 1
                If DataGridView2.Item(3, a).Value > 0 Then
                    Call insert_no_trans("BAYAR_PINJAMAN", Month(server_datetime()), Year(server_datetime()))
                    Call select_control_no("BAYAR_PINJAMAN", "TRANS")
                    no_bayar = no_master
                    Call insert_bayarpinjam(no_bayar, txt_nota_pinjam.Text, Replace(txt_nominal.Text, ",", ""), server_datetime(), Replace(txt_sisalunas.Text, ",", ""), "INSERT", Replace(txt_belum_bayar.Text, ",", ""), due_date)
                    If param_sukses = True Then
                        update_no_trans(server_datetime(), "BAYAR_PINJAMAN")
                        DataGridView2.Item(4, a).Value = True
                    End If
                End If
            Next



            If param_sukses = True Then
                MsgBox("Data Was Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")


                Dim DisplayNota As New NotaLunasKoperasi
                'NoFakturJual = Trim(txt_nota_pinjam.Text)
                With DisplayNota
                    .Show()
                    '  .MdiParent = MainMenu
                    .WindowState = FormWindowState.Maximized
                End With

                'pesan = MsgBox("Print Pembayaran?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                'If pesan = vbYes Then
                '    Dim R As New ReportDocument
                '    Dim pathfilereport As String
                '    pathfilereport = Application.StartupPath & "\Report\KartuBayar.rpt"
                '    R.Load(pathfilereport)
                '    R.Refresh()
                '    R.RecordSelectionFormula = "{view_kartu_bayar1.no_bayar} ='" & Trim(no_bayar) & "'"
                '    R.PrintToPrinter(1, False, 1, 1)
                '    update_printstatus(no_bayar)
                'End If
            End If
        ElseIf edit_bayar = 1 Then
            'Call update_bayarpinjam(DataGridView2.Item(6, rowIndex).Value, txt_nota_pinjam.Text, Replace(txt_nominal.Text, ",", ""), DataGridView2.Item(7, rowIndex).Value, Replace(0, ",", ""), "UPDATE", Replace(DataGridView2.Item(2, rowIndex).Value, ",", ""))
            'If param_sukses = True Then
            '    MsgBox("Data Was Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
            '    'clean()
            '    DataGridView2.Item(3, rowIndex).Value = True
            'End If
        End If
    End Sub


    Private Sub DataGridView2_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        Dim colIndex, rowIndex As Integer
        Dim nomPinjaman, total_tunggak, sisa_pokok As Double
        colIndex = DataGridView2.CurrentCell.ColumnIndex
        rowIndex = DataGridView2.CurrentCell.RowIndex
        If colIndex = 2 Then
            nomPinjaman = Replace(txt_nominal.Text, ",", "") * DataGridView2.Item(2, rowIndex).Value / 100
            DataGridView2.Item(2, rowIndex).Value = FormatNumber(DataGridView2.Item(2, rowIndex).Value, 2)
            DataGridView2.Item(3, rowIndex).Value = FormatNumber(nomPinjaman, 2)
        End If
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            If DataGridView2.Item(4, i).Value = False Then
                total_tunggak = total_tunggak + Replace(DataGridView2.Item(3, i).Value, ",", "")
            End If
        Next
        sisa_pokok = Replace(txt_sisalunas.Text, ",", "")
        txt_belum_bayar.Text = FormatNumber(total_tunggak, 2)
        txt_lunas.Text = FormatNumber(sisa_pokok + total_tunggak, 2)

    End Sub

    Private Sub TabInput_Click(sender As System.Object, e As System.EventArgs) Handles TabInput.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        edit_bayar = 1
        insert_bayar = 0
        If getTemplateAkses(username, "MN_BAYAR_PINJAMAN_EDIT") <> True Then
            DataGridView2.Columns(2).ReadOnly = True
        Else
            DataGridView2.Columns(2).ReadOnly = False
        End If


    End Sub

    Private Sub DataGridView2_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs)

    End Sub

    Private Sub btn_help_Click(sender As System.Object, e As System.EventArgs) Handles btn_help.Click
        Dim DisplayNota As New NotaKoperasi
        NoFakturJual = Trim(txt_nota_pinjam.Text)
        With DisplayNota
            .Show()
            '  .MdiParent = MainMenu
            .WindowState = FormWindowState.Maximized
        End With
        'open_conn()
        'Dim R As New ReportDocument
        'Dim pathfilereport As String
        'pathfilereport = Application.StartupPath & "\Report\KartuPinjam.rpt"
        'R.Load(pathfilereport)
        'R.Refresh()
        'R.RecordSelectionFormula = "{trn_pinjam1.no_pinjam} ='" & Trim(txt_nota_pinjam.Text) & "'"
        'R.PrintToPrinter(1, False, 1, 1)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If Application.OpenForms().OfType(Of frmsetkode).Any Then
            frmsetkode.Activate()
        Else
            frmsetkode.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        insert_data_lunas()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class