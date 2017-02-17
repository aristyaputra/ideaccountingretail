Imports DevExpress.XtraBars.Alerter
Public Class frmsetcoa
    Public columnIndex, rowIndex As Integer

    Private Sub frmsetcoa_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmsetcoa_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainMenu.Activate()
    End Sub

    Private Sub frmsetcoa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        view_data()

        DataGridView1.ReadOnly = True
        DataGridView1.Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub view_data()
        open_conn()
        On Error Resume Next
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable

        DT = select_def_account()
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = DT.Rows(i).Item("notes")
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("id_account")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("account_name")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("acc_parameter")

                'DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
                'DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
            Next
        End If

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
        open_conn()
        columnIndex = DataGridView1.CurrentCell.ColumnIndex
        rowIndex = DataGridView1.CurrentCell.RowIndex

        If columnIndex = 1 Then

            'Dim FrmAccount As New frm_display_acc_detail
            frm_display_acc_detail.Show()
            '   FrmAccount.formsource_setcoa = True
            '   ' MainMenu.Enabled = False
            '   Me.Enabled = False
        End If
    End Sub

    Private Sub btn_save2_Click(sender As Object, e As System.EventArgs) Handles btn_save2.Click
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

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class