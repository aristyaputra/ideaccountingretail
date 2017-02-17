Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Public Class frm_display_category
    Dim i As Integer
    Public formsource_item As Boolean

    Private Sub frm_display_acc_detail_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If formsource_item = True Then
        '    formsource_item = False
        '    frmitem.Enabled = True
        'End If
    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Down Then
            DataGridView1.Focus()
            SendKeys.Send(Keys.Down)
        End If
    End Sub

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub
    Private Sub frm_display_acc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            cbo_search.Text = "Category Name"
            view_data()
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.ReadOnly = True
            datagrid_layout()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub view_data()
        open_conn()
        Dim i As Integer
        'If TabControl1.SelectedTab Is TabList Then
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_category("mst_itemjenis_id", Trim(txt_search.Text))
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item(2)
        Next
        ' End If
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        open_conn()
        view_data()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        MainMenu.Enabled = True
        If formsource_item = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmitem
                .Enabled = True
                .Activate()
                .cbo_kategori.Text = DataGridView1.Item(0, i).Value
            End With
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            MainMenu.Enabled = True
            If formsource_item = True Then
                i = DataGridView1.CurrentCell.RowIndex
                With frmitem
                    .Enabled = True
                    .Activate()
                    .cbo_kategori.Text = DataGridView1.Item(0, i).Value
                End With
            End If
            Me.Close()
        End If
    End Sub
End Class