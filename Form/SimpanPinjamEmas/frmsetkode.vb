Public Class frmsetkode
    Public columnIndex, rowIndex As Integer

    Private Sub frmsetcoa_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' MainMenu.Activate()
    End Sub

    Private Sub frmsetcoa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        open_conn()
        view_data()
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub view_data()
        open_conn()
        On Error Resume Next
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable

        DT = select_kode_bayar()
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = DT.Rows(i).Item("kode")
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("angka")
                
                'DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
                'DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
            Next
        End If

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
        open_conn()
        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        rowIndex = DataGridView1.CurrentCell.RowIndex

        'If columnIndex = 1 Then

        '    Dim FrmAccount As New frm_display_acc_detail
        '    FrmAccount.Show()
        '    FrmAccount.formsource_setcoa = True
        '    'MainMenu.Enabled = False
        '    Me.Enabled = False
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        insert_data()
    End Sub

    Private Sub insert_data()
        open_conn()

        For i = 0 To DataGridView1.Rows.Count - 1
            Call set_kode_bayar(DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value)
        Next

        If param_sukses = True Then
            MsgBox("Data Was Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Success")
            view_data()
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class