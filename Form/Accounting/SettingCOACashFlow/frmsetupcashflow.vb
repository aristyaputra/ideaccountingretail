Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Public Class frmsetupcashflow

    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Public NoOpname As String

    Private Sub frmsetupcashflow_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmsetupcashbank_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmstockopname_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        MdiParent = MainMenu
        insert = 1
        edit = 0
        view_data_cash()
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
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End With
        With dgbank
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            .AllowUserToResizeColumns = True
        End With
        dgbank.ReadOnly = False
        dgbank.Columns(0).ReadOnly = True
        dgbank.Columns(1).ReadOnly = True
        dgbank.Columns(2).ReadOnly = False

        dgcash.ReadOnly = False
        dgcash.Columns(0).ReadOnly = True
        dgcash.Columns(1).ReadOnly = True
        dgcash.Columns(2).ReadOnly = False
    End Sub
    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            view_data_bank(dgcash.Item(0, dgcash.CurrentCell.RowIndex).Value, 1, "")
            insert_data()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Warning..", ex.Message)
            alertControl_error.Show(Me, info)
            Exit Sub
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub view_data_cash()
        open_conn()
        Dim DT As DataTable
        Dim z As Integer
        DT = select_component_cashflow()
        dgcash.Columns.Clear()
        dgcash.DataSource = DT
        dgcash.Columns(0).Visible = False
        dgcash.Columns(1).HeaderText = "Keterangan"
        dgcash.Columns(2).HeaderText = "Jenis Aktivitas"
        dgcash.Columns(3).HeaderText = "Transaksi"
    End Sub

    Private Sub view_data_bank(ByVal criteria As String, ByVal before_insert As Integer, ByVal id_account As String)
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim DT As DataTable
            Dim z As Integer
            DT = select_detail_component_cashflow(criteria, before_insert, id_account)
            dgbank.AutoGenerateColumns = False
            dgbank.DataSource = DT.DefaultView
            dgbank.Columns(0).DataPropertyName = "id_account"
            dgbank.Columns(1).DataPropertyName = "account_name"
            dgbank.Columns(2).DataPropertyName = "id_component"
            dgbank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Warning..", ex.Message)
            alertControl_error.Show(Me, info)
            Exit Sub
        Finally
            SplashScreenManager.CloseForm(False)
        End Try

    End Sub


    Private Sub insert_data()
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            If insert = 1 Then

                Dim id_component As String
                id_component = dgcash.Item(0, dgcash.CurrentCell.RowIndex).Value
                For j = 0 To dgbank.Rows.Count - 1
                    If dgbank.Item(2, j).Value = 1 Then
                        Call insert_cashflow_setup(id_component, dgbank.Item(0, j).Value, j, username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"))
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

                Dim id_component As String
                id_component = dgcash.Item(0, dgcash.CurrentCell.RowIndex).Value
                For j = 0 To dgbank.Rows.Count - 1
                    If dgbank.Item(2, j).Value = True Then
                        Call insert_cashflow_setup(id_component, dgbank.Item(0, j).Value, j, username, Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"))
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
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        open_conn()
        Dim mRow As Integer
        mRow = dgcash.CurrentCell.RowIndex
    End Sub

    Private Sub dgcash_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgcash.CellClick
        view_data_bank(dgcash.Item(0, e.RowIndex).Value, 0, "")
    End Sub

    Private Sub txt_acc_name_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_acc_name.TextChanged
        view_data_bank(dgcash.Item(0, dgcash.CurrentCell.RowIndex).Value, 0, Trim(txt_acc_name.Text))
    End Sub
End Class