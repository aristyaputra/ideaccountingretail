Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmitem_beginning

    Private Sub frmitem_beginning_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ' open_conn()
        Me.WindowState = FormWindowState.Maximized
        'Dim Rows As Integer
        'Dim DT As DataTable
        'DT = select_warehouse("", 0)
        'For i = 0 To Rows
        '    cbo_warehouse.Items.Add(DT.Rows(i).Item(0))
        'Next
    End Sub

    Private Sub frmitem_beginning_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmitem_beginning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMenu
        Me.WindowState = FormWindowState.Maximized
        Dim Rows As Integer
        open_conn()
        cbo_warehouse.Items.Clear()
        Rows = select_warehouse.Rows.Count - 1
        For i = 0 To Rows
            cbo_warehouse.Items.Add(select_warehouse.Rows(i).Item(0))
        Next
        view_data()
        datagrid_layout()
        Label5.Visible = False
    End Sub

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = Color.WhiteSmoke
            .Columns(2).ReadOnly = True
            .Columns(2).DefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
    End Sub

    Private Sub view_data()
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim Rows As Integer
            Dim DT As DataTable
            DT = select_beg_balance(cbo_warehouse.Text, Trim(txt_search.Text))
            Rows = DT.Rows.Count - 1
            DataGridView1.Rows.Clear()
            For i = 0 To Rows
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
                DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
                DataGridView1.Item(2, i).Value = DT.Rows(i).Item(2)
                DataGridView1.Item(3, i).Value = FormatNumber(DT.Rows(i).Item(3), 0)
                DataGridView1.Item(4, i).Value = FormatNumber(DT.Rows(i).Item(4), 0)
                DataGridView1.Item(5, i).Value = DT.Rows(i).Item(5)
            Next
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub cbo_warehouse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_warehouse.SelectedIndexChanged
        open_conn()
        Dim DT As DataTable
        Dim var_code As String
        var_code = cbo_warehouse.SelectedItem
        DT = select_warehouse_list(var_code, 1)
        Label5.Visible = True
        Label5.Text = DT.Rows(0).Item(1).ToString
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        Dim rows As Integer
        Dim i As Integer
        rows = DataGridView1.Rows.Count - 1
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            For i = 0 To rows
                If DataGridView1.Item(0, i).Value.ToString <> "" Then
                    Call update_begbalance(DataGridView1.Item(0, i).Value, DataGridView1.Item(1, i).Value, DataGridView1.Item(3, i).Value, DataGridView1.Item(5, i).Value, DataGridView1.Item(4, i).Value, i)
                End If
            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        open_conn()
        Dim mRow As Integer
        Dim balance, price As Double
        mRow = DataGridView1.CurrentCell.RowIndex
        If DataGridView1.CurrentCell.ColumnIndex = 3 Then
            If Not IsNumeric(DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value) Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan Format Numerik")
                alertControl_warning.Show(Me, info)
                DataGridView1.Item(3, DataGridView1.CurrentCell.RowIndex).Value = 0
                Exit Sub
            End If
        End If
        If DataGridView1.CurrentCell.ColumnIndex = 4 Then
            If Not IsNumeric(DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value) Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan Format Numerik")
                alertControl_warning.Show(Me, info)
                DataGridView1.Item(4, DataGridView1.CurrentCell.RowIndex).Value = 0
                Exit Sub
            End If
        End If
        price = DataGridView1.Item(4, mRow).Value
        DataGridView1.Item(4, mRow).Value = FormatNumber(price, 0)
        balance = DataGridView1.Item(3, mRow).Value
        DataGridView1.Item(3, mRow).Value = FormatNumber(balance, 0)
    End Sub

    'Private Sub frmitem_beginning_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column As Integer
    '    Dim Width_Table As Integer
    '    Dim selisih_col As Integer

    '    With DataGridView1
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(5).Width = .Columns(5).Width + selisih_col
    '    End With
    'End Sub


    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_cari_cust_Click(sender As System.Object, e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub

    Private Sub PanelControl2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelControl2.Paint

    End Sub
End Class