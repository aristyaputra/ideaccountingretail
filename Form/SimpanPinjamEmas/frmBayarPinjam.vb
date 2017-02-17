Public Class frmBayarPinjam

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
            .RowsDefaultCellStyle.SelectionBackColor = Color.WhiteSmoke
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub frmCurrency_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        'MainMenu.Activate()
    End Sub

    Private Sub frmkatbarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataPenjualan.ListPinjaman' table. You can move, or remove it, as needed.
        Me.ListPinjamanTableAdapter.Fill(Me.DataPenjualan.ListPinjaman)
        'TODO: This line of code loads data into the 'DataPenjualan.ListJualPinjam' table. You can move, or remove it, as needed.
        Me.ListJualPinjam.Fill(Me.DataPenjualan.ListJualPinjam)
        'TODO: This line of code loads data into the 'DataPenjualan.ListJual' table. You can move, or remove it, as needed.
        Me.ListJual.Fill(Me.DataPenjualan.ListJual)
        open_conn()
        datagrid_layout()
        insert = 1
        edit = 0
        btn_delete.Enabled = False
        Me.WindowState = FormWindowState.Maximized
        var_bulan = Month(txt_date.Value)
        var_tahun = Year(txt_date.Value)
        If insert = 1 Then
            Call insert_no_trans("BAYAR_PINJAMAN", Month(txt_date.Value), Year(txt_date.Value))
            Call select_control_no("BAYAR_PINJAMAN", "TRANS")
            txt_nota_pinjam.Text = no_master
        End If
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        txt_item_name.Text = ""
        txt_nota_pinjam.Text = ""
        txt_id_item.Text = ""
        btn_delete.Enabled = False
        txt_item_name.Enabled = True
        txt_nominal.Text = 0
        txt_berat.Text = 0
        txt_bunga.Text = 0
        txt_date.Enabled = True
        Call select_control_no("BAYAR_PINJAMAN", "TRANS")
        txt_nota_pinjam.Text = no_master
        txt_pemb_before.Text = ""
    End Sub

    Public Sub insert_data()
        open_conn()

        'If insert = 1 Then
        '    Call insert_bayarpinjam(txt_pemb_before.Text, txt_nota_pinjam.Text, Replace(txt_nominal.Text, ",", ""), txt_date.Value, Replace(txt_bayar.Text, ",", ""), "INSERT", Replace(txt_bunga.Text, ",", ""))
        '    If param_sukses = True Then
        '        MsgBox("Data Was Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
        '        update_no_trans(txt_date.Value, "BAYAR_PINJAMAN")
        '        clean()
        '    End If
        'ElseIf edit = 1 Then
        '    Call update_bayarpinjam(txt_pemb_before.Text, txt_nota_pinjam.Text, Replace(txt_nominal.Text, ",", ""), txt_date.Value, Replace(txt_bayar.Text, ",", ""), "UPDATE", Replace(txt_bunga.Text, ",", ""))
        '    If param_sukses = True Then
        '        MsgBox("Data Was Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
        '        clean()
        '    End If
        'End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_BAYAR_PINJAMAN_ADD") <> True Then
                MsgBox("you do not have access rights!", MsgBoxStyle.Information, "User Right")
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_BAYAR_PINJAMAN_EDIT") <> True Then
                MsgBox("you do not have access rights!", MsgBoxStyle.Information, "User Right")
                Exit Sub
            End If
        End If

        insert_data()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_BAYAR_PINJAMAN_DELETE") <> True Then
                MsgBox("you do not have access rights!", MsgBoxStyle.Information, "User Right")
                Exit Sub
            End If
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Ingin hapus data?", "Delete", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_bayarpinjam(txt_pemb_before.Text, txt_nota_pinjam.Text, Replace(txt_nominal.Text, ",", ""), txt_date.Value, Replace(txt_bayar.Text, ",", ""), "DELETE")
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
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item("no_jual")
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
        Dim DT As DataTable
        DT = select_pinjam(criteria, 1)
        txt_nota_pinjam.Text = DT.Rows(0).Item("no_pinjam")
        txt_pemb_before.Text = DT.Rows(0).Item("no_jual")
        txt_item_name.Text = DT.Rows(0).Item("item_name")
        txt_id_item.Text = DT.Rows(0).Item("id_item")
        txt_nominal.Text = DT.Rows(0).Item("nominal")
        txt_berat.Text = DT.Rows(0).Item("berat")
        txt_date.Text = DT.Rows(0).Item("date_trn")
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
        Dim Total_Width_Column2 As Integer
        Dim Width_Table2 As Integer
        Dim selisih_col2 As Integer

        With DataGridView1
            Total_Width_Column2 = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
            Width_Table2 = .Width
            selisih_col2 = Width_Table2 - Total_Width_Column2 - 65
            .Columns(4).Width = .Columns(4).Width + selisih_col2
        End With
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

    Private Sub txtnegara_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_id_item.KeyPress
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

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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
        Dim kode_barang, nama_barang As String
        Dim berat, saldo As Double
        If txt_pemb_before.GetColumnValue("Status Pinjam") = "Barang Dalam Proses Gadai" Then
            MsgBox("Barang sudah dalam proses gadai", MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        kode_barang = txt_pemb_before.GetColumnValue("Kode Item")
        nama_barang = txt_pemb_before.GetColumnValue("Nama Item")
        berat = txt_pemb_before.GetColumnValue("Berat")
        saldo = get_saldo_pinjam(txt_pemb_before.GetColumnValue("No Pinjaman"))
        txt_id_item.Text = kode_barang
        txt_item_name.Text = nama_barang
        txt_nominal.Text = FormatNumber(saldo, 2)
        txt_berat.Text = FormatNumber(berat, 2)
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

    Private Function CheckBox1() As Object
        Throw New NotImplementedException
    End Function

End Class