Imports DevExpress.XtraBars.Alerter

Public Class frmsetcoa_depProduksi
    Public columnIndex, rowIndex As Integer

    Private Sub frmsetcoa_aset_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
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
        DataGridView1.Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
        '  DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub view_data()
        open_conn()
        On Error Resume Next
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable

        DT = select_coa_depproduksi()
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        If DT.Rows().Count > 0 Then
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = DT.Rows(i).Item("department_id")
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item("department_name")
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item("id_account_bdp")
                DataGridView1.Item(3, i).Value = DT.Rows(i).Item("id_account_material_cost")
                DataGridView1.Item(4, i).Value = DT.Rows(i).Item("id_account_wip_cost")
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item("id_account_bop_std")
                DataGridView1.Item(6, i).Value = DT.Rows(i).Item("id_account_bop_real")
                DataGridView1.Item(7, i).Value = DT.Rows(i).Item("id_account_directlabor")
                DataGridView1.Item(8, i).Value = DT.Rows(i).Item("id_account_wages_payable")

                'DataGridView1.Item(3, i).Value = DT.Rows(i).Item(3)
                'DataGridView1.Item(4, i).Value = DT.Rows(i).Item(4)
            Next
        End If

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
        open_conn()
        If DataGridView1.Rows.Count > 0 Then
            columnIndex = DataGridView1.CurrentCell.ColumnIndex
            rowIndex = DataGridView1.CurrentCell.RowIndex

            If columnIndex <> 0 Or columnIndex <> 1 Then

                'Dim FrmAccount As New frm_display_acc_detail
                frm_display_acc_detail.Show()
                If columnIndex = 2 Then
                    frm_display_acc_detail.formsource_setcoa_depprod1 = True
                End If
                If columnIndex = 3 Then
                    frm_display_acc_detail.formsource_setcoa_depprod2 = True
                End If
                If columnIndex = 4 Then
                    frm_display_acc_detail.formsource_setcoa_depprod3 = True
                End If
                If columnIndex = 5 Then
                    frm_display_acc_detail.formsource_setcoa_depprod4 = True
                End If
                If columnIndex = 6 Then
                    frm_display_acc_detail.formsource_setcoa_depprod5 = True
                End If
                If columnIndex = 7 Then
                    frm_display_acc_detail.formsource_setcoa_depprod6 = True
                End If
                If columnIndex = 8 Then
                    frm_display_acc_detail.formsource_setcoa_depprod7 = True
                End If
                '  ' MainMenu.Enabled = False
                '  Me.Enabled = False
            End If
        End If
    End Sub

    Private Sub btn_save2_Click(sender As Object, e As System.EventArgs) Handles btn_save2.Click
        insert_data()
    End Sub
    Private Sub insert_data()
        open_conn()

        For i = 0 To DataGridView1.Rows.Count - 1
            Call set_coa_depproduksi(DataGridView1.Item(0, i).Value, DataGridView1.Item(2, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(4, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(6, i).Value, DataGridView1.Item(7, i).Value, DataGridView1.Item(8, i).Value, username, server_datetime(), "UPDATE")
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