Imports DevExpress.XtraBars.Alerter

Public Class frmsimulasiaset
    Public columnIndex, rowIndex As Integer
    Public gol_aset As String
    Public nilai_perolehan, nilai_buku As Double
    Public tgl_perolehan As Date

    Private Sub frmsetcoa_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmaset.Activate()
        frmaset.Enabled = True
        MainMenu.Enabled = True
    End Sub

    Private Sub frmsetcoa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        open_conn()
        view_data()
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
    End Sub
    Private Sub view_data()
        open_conn()
        On Error Resume Next
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable

        DT = select_simulasi_aset(gol_aset, nilai_perolehan, Format(tgl_perolehan, "yyyy-MM-dd"))
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = FormatNumber(DT.Rows(i).Item("harga_perolehan"), 0)
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("masa_manfaat")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("rate_depr_th")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("masa_penyusutan")
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("depr_th"), 0)
                DataGridView1.Item(5, i).Value = FormatNumber(DT.Rows(i).Item("akumulasi_penyusutan"), 0)
                DataGridView1.Item(6, i).Value = FormatNumber(DT.Rows(i).Item("nilai_buku"), 0)
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
            Call set_def_account(DataGridView1.Item(3, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(0, i).Value, i)
        Next

        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
            alertControl_success.Show(Me, info)
            view_data()
        Else
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
            alertControl_error.Show(Me, info)
        End If

    End Sub

    Private Sub btn_simpan_Click(sender As System.Object, e As System.EventArgs) Handles btn_simpan.Click
        Dim frm As New frmadjustjournal
        frm.Show()
        frm.DataGridView1.Item(4, 0).Value = Math.Abs(nilai_buku - DataGridView1.Item(6, 0).Value)
        frm.DataGridView1.Item(5, 1).Value = Math.Abs(nilai_buku - DataGridView1.Item(6, 0).Value)
        Me.Close()
    End Sub
End Class