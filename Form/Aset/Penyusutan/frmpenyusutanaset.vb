Imports DevExpress.XtraBars.Alerter
Public Class frmpenyusutanaset
    Public columnIndex, rowIndex As Integer
    Public gol_aset As String
    Public nilai_perolehan, nilai_buku As Double
    Public tgl_perolehan As Date
    Dim no_bukti As String

    Private Sub frmpenyusutanaset_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmsetcoa_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainMenu.Enabled = True
    End Sub

    Private Sub frmsetcoa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        open_conn()
        view_data()
        txt_period.Value = Now
        DataGridView1.ReadOnly = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
        DataGridView1.Columns(5).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = True
        DataGridView1.Columns(7).ReadOnly = True
        DataGridView1.Columns(8).ReadOnly = False
        var_bulan = Month(txt_period.Value)
        var_tahun = Year(txt_period.Value)
        Call insert_no_trans("DEPR_JOURNAL", var_bulan, var_tahun)
        Call select_control_no("DEPR_JOURNAL", "TRANS")
        no_bukti = no_master
    End Sub
    Private Sub view_data()
        open_conn()
        On Error Resume Next
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        var_bulan = Month(txt_period.Value)
        var_tahun = Year(txt_period.Value)

        DT = select_pra_penyusutan(var_bulan, var_tahun)
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = DT.Rows(i).Item("id_aset")
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("nama")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("department_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("type")
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("rate_penyusutan"), 2)
                DataGridView1.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("penyusutan"), 0)
                DataGridView1.Item(6, i).Value = DT.Rows(i).Item("id_coa_penyusutan")
                DataGridView1.Item(7, i).Value = DT.Rows(i).Item("id_coa_akumulasi")
                'DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
                'DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
            Next
        End If

    End Sub

    'Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
    '    open_conn()
    '    columnIndex = DataGridView1.CurrentCell.ColumnIndex
    '    rowIndex = DataGridView1.CurrentCell.RowIndex

    '    If columnIndex = 1 Then

    '        Dim FrmAccount As New frm_display_acc_detail
    '        FrmAccount.Show()
    '        FrmAccount.formsource_setcoa = True
    '        ' MainMenu.Enabled = False
    '        Me.Enabled = False
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs)
        insert_data()
    End Sub
    Private Sub insert_data()
        open_conn()
        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Item(8, i).Value = True Then
                If Trim(DataGridView1.Item(6, i).Value) = "" Or Trim(DataGridView1.Item(7, i).Value) = "" Then
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Kode Aset " & DataGridView1.Item(0, i).Value & vbCrLf & "Belum di setting akun")
                    alertControl_warning.Show(Me, info)
                    Exit Sub
                End If
            End If
        Next
        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Item(8, i).Value = True Then
                Call insert_penyusutan(no_bukti, Format(Now(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), username, Format(server_datetime(), "yyyy-MM-dd"), DataGridView1.Item(0, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, "Penyusutan Aset", Replace(DataGridView1.Item(5, i).Value, ",", ""), 1, "INSERT", i, Replace(DataGridView1.Item(5, i).Value, ",", ""), get_def_curr(), 1, var_bulan, var_tahun)

            End If
        Next

        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
            alertControl_success.Show(Me, info)
            update_no_trans(txt_period.Value, "DEPR_JOURNAL")
            view_data()
        Else
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
            alertControl_error.Show(Me, info)
        End If

    End Sub

    Private Sub btn_simpan2_Click(sender As System.Object, e As System.EventArgs) Handles btn_simpan2.Click
        insert_data()
    End Sub

    Private Sub btn_chk_all2_Click(sender As System.Object, e As System.EventArgs) Handles btn_chk_all2.Click
        open_conn()
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Item(8, i).Value = True
        Next
    End Sub

    Private Sub btn_clear2_Click(sender As System.Object, e As System.EventArgs) Handles btn_clear2.Click
        open_conn()
        Dim i As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Item(8, i).Value = False
        Next
    End Sub

    Private Sub txt_period_ValueChanged(sender As Object, e As System.EventArgs) Handles txt_period.ValueChanged
        view_data()
    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class