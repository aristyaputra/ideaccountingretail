Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmAPList

    Dim field As String
    Private Sub view_data()
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            Dim Rows As Integer
            Dim DT As DataTable

            Dim var_t_inv As Double
            Dim var_t_return As Double
            Dim var_t_disc As Double
            Dim var_t_paid As Double
            Dim var_t_balance As Double
            Dim var_t_lebih_bayar As Double

            Dim date_filter As Integer


            If cbo_search.Text = "Invoice No" Then
                field = "no_purchase"
            ElseIf cbo_search.Text = "Supplier" Then
                field = "nama"
            End If

            var_t_inv = 0
            var_t_return = 0
            var_t_disc = 0
            var_t_paid = 0
            var_t_balance = 0
            var_t_lebih_bayar = 0
            If chk_date.Checked = True Then
                date_filter = 1
            ElseIf chk_date.Checked = False Then
                date_filter = 0
            End If
            DT = view_ap_status(date_filter, field, txt_search.Text, tglawal.Value, tglakhir.Value)
            Rows = DT.Rows.Count - 1
            DataGridView2.Rows.Clear()
            For i = 0 To Rows
                DataGridView2.Rows.Add()
                DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
                DataGridView2.Item(1, i).Value = Format(DT.Rows(i).Item(1), "dd-MMM-yyyy")
                DataGridView2.Item(2, i).Value = DT.Rows(i).Item(2)
                DataGridView2.Item(3, i).Value = FormatNumber(DT.Rows(i).Item(3), 0)
                var_t_inv = var_t_inv + DT.Rows(i).Item(3)
                DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item(4), 0)
                var_t_return = var_t_return + DT.Rows(i).Item(4)
                DataGridView2.Item(5, i).Value = FormatNumber(DT.Rows(i).Item(5), 0)
                var_t_disc = var_t_disc + DT.Rows(i).Item(5)
                DataGridView2.Item(6, i).Value = FormatNumber(DT.Rows(i).Item(6), 0)
                var_t_paid = var_t_paid + DT.Rows(i).Item(6)
                DataGridView2.Item(7, i).Value = FormatNumber(DT.Rows(i).Item(7), 0)
                var_t_balance = var_t_balance + DT.Rows(i).Item(7)
                DataGridView2.Item(8, i).Value = DT.Rows(i).Item(8)
                DataGridView2.Item(9, i).Value = FormatNumber(DT.Rows(i).Item(9), 0)
                var_t_lebih_bayar = var_t_lebih_bayar + DT.Rows(i).Item(9)

            Next
            txt_ar.Text = FormatNumber(var_t_inv, 0)
            txt_return.Text = FormatNumber(var_t_return, 0)
            txt_disc.Text = FormatNumber(var_t_disc, 0)
            txt_paid.Text = FormatNumber(var_t_paid, 0)
            txt_balance.Text = FormatNumber(var_t_balance, 0)
            txt_lbh_byr.Text = FormatNumber(var_t_lebih_bayar, 0)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub frmAPList_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmARList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        cbo_search.Text = "Invoice No"
        view_data()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        datagrid_layout()
    End Sub
    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
        End With
    End Sub
    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        open_conn()
        view_data()
    End Sub

    Private Sub chk_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_date.CheckedChanged
        open_conn()
        date_filter()
    End Sub
    Private Sub date_filter()
        open_conn()
        If chk_date.Checked = True Then
            tglawal.Enabled = True
            tglakhir.Enabled = True
        ElseIf chk_date.Checked = False Then
            tglawal.Enabled = False
            tglakhir.Enabled = False
        End If
    End Sub
    Private Sub reset_list()
        open_conn()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        tglakhir.Value = Now
        tglawal.Value = Now
        cbo_search.Text = "Invoice No"
        txt_search.Text = ""
    End Sub
    Private Sub btn_reset_cust_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    'Private Sub frmAPList_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column As Integer
    '    Dim Width_Table As Integer
    '    Dim selisih_col As Integer

    '    With DataGridView2
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width + .Columns(6).Width + .Columns(7).Width + .Columns(8).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column - 65
    '        .Columns(8).Width = .Columns(8).Width + selisih_col
    '    End With

    'End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub NavBarControl6_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class