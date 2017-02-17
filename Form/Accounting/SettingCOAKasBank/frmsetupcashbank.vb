Imports DevExpress.XtraBars.Alerter

Public Class frmsetupcashbank

    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Public NoOpname As String

    Private Sub frmsetupcashbank_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmsetupcashbank_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmstockopname_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        insert = 1
        edit = 0
        Dim Rows As Integer
        Rows = select_warehouse.Rows.Count - 1
        datagrid_layout()
    End Sub
    Private Sub datagrid_layout()
        open_conn()
        With dgcash
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
        End With
        With dgbank
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
        End With
        dgbank.ReadOnly = False
        dgbank.Columns(0).ReadOnly = True
        dgbank.Columns(1).ReadOnly = True
        dgbank.Columns(2).ReadOnly = False

        dgcash.ReadOnly = False
        dgcash.Columns(0).ReadOnly = True
        dgcash.Columns(1).ReadOnly = True
        dgcash.Columns(2).ReadOnly = False
        view_data_cash()
        view_data_bank()
    End Sub
    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        insert_data()
    End Sub

    Private Sub view_data_cash()
        open_conn()
        Dim DT As DataTable
        Dim z As Integer
        DT = select_cash_set()
        dgcash.AutoGenerateColumns = False
        dgcash.DataSource = DT
        dgcash.Columns(0).DataPropertyName = "id_account"
        dgcash.Columns(1).DataPropertyName = "account_name"
        dgcash.Columns(2).DataPropertyName = "pilih"
        'z = DT.Rows.Count - 1
        'For b = 0 To z
        '    dgcash.Rows.Add(1)
        '    dgcash.Item(0, b).Value = DT.Rows(b).Item(0)
        '    dgcash.Item(1, b).Value = DT.Rows(b).Item(1)
        '    If DT.Rows(b).Item(2) = "true" Then
        '        dgcash.Item(2, b).Value = True
        '    ElseIf DT.Rows(b).Item(2) = "false" Then
        '        dgcash.Item(2, b).Value = False
        '    End If
        'Next
    End Sub

    Private Sub view_data_bank()
        open_conn()
        Dim DT As DataTable
        Dim z As Integer
        DT = select_bank_set()
        dgbank.AutoGenerateColumns = False
        dgbank.DataSource = DT
        dgbank.Columns(0).DataPropertyName = "id_account"
        dgbank.Columns(1).DataPropertyName = "account_name"
        dgbank.Columns(2).DataPropertyName = "pilih"

        'z = DT.Rows.Count - 1
        'For b = 0 To z
        '    dgbank.Rows.Add(1)
        '    dgbank.Item(0, b).Value = DT.Rows(b).Item(0)
        '    dgbank.Item(1, b).Value = DT.Rows(b).Item(1)
        '    If DT.Rows(b).Item(2) = "true" Then
        '        dgbank.Item(2, b).Value = True
        '    ElseIf DT.Rows(b).Item(2) = "false" Then
        '        dgbank.Item(2, b).Value = False
        '    End If
        'Next
    End Sub


    Private Sub insert_data()
        open_conn()
        If insert = 1 Then

            For i = 0 To dgcash.Rows.Count - 1
                If dgcash.Item(2, i).Value = True Then
                    Call insert_cashbank_setup(dgcash.Item(0, i).Value, i, username, server_datetime(), 1)
                End If
            Next

            For j = 0 To dgbank.Rows.Count - 1
                If dgbank.Item(2, j).Value = True Then
                    Call insert_cashbank_setup(dgbank.Item(0, j).Value, j, username, server_datetime(), 2)
                End If
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            For i = 0 To dgcash.Rows.Count - 1
                If dgcash.Item(2, i).Value = True Then
                    Call insert_cashbank_setup(dgcash.Item(0, i).Value, i, username, server_datetime(), 1)
                End If
            Next

            For j = 0 To dgbank.Rows.Count - 1
                If dgbank.Item(2, j).Value = True Then
                    Call insert_cashbank_setup(dgbank.Item(0, j).Value, j, username, server_datetime(), 2)
                End If
            Next

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        open_conn()
        Dim balance As Double
        Dim mRow As Integer
        mRow = dgcash.CurrentCell.RowIndex
        balance = dgcash.Item(4, mRow).Value

    End Sub


    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class