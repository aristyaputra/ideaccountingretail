Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frm_display_purchase
    Dim i As Integer
    Public formsource_purchase_return As Boolean

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub txt_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Down Then
            DataGridView1.Focus()
            SendKeys.Send(Keys.Down)
        End If
    End Sub

    Public Sub view_data()
        open_conn()
        Dim Rows As Integer
        Dim DT As DataTable
        Dim i As Integer
        DT = select_purchase2(cbo_search.Text, txt_search.Text, 0)

        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
            DataGridView1.Item(1, i).Value = Format(DT.Rows(i).Item(4), "dd-MM-yyyy")
            DataGridView1.Item(2, i).Value = DT.Rows(i).Item(1)
            DataGridView1.Item(3, i).Value = DT.Rows(i).Item(2)
            DataGridView1.Item(4, i).Value = DT.Rows(i).Item(16)
            DataGridView1.Item(5, i).Value = DT.Rows(i).Item(10)
            DataGridView1.Item(6, i).Value = DT.Rows(i).Item(5)
            DataGridView1.Item(7, i).Value = DT.Rows(i).Item(6)
            DataGridView1.Item(8, i).Value = DT.Rows(i).Item(7)
            DataGridView1.Item(9, i).Value = DT.Rows(i).Item(8)
            DataGridView1.Item(10, i).Value = DT.Rows(i).Item(17)
            DataGridView1.Item(11, i).Value = DT.Rows(i).Item(18)
        Next
    End Sub

    Private Sub frm_display_purchase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'open_conn()
        'If formsource_purchase_return = True Then
        '    formsource_purchase_return = False
        '    formsource_purchase_return = True
        'End If
    End Sub

    Private Sub frm_display_purchase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            cbo_search.Text = "Invoice No"
            view_data() 'isi grid
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.ReadOnly = True
            datagrid_layout()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Dim var_method As String
    Private Sub generate()
        Dim i As Integer
        open_conn()
        MainMenu.Enabled = True
        If formsource_purchase_return = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmpurc_return
                .Enabled = True
                .Activate()
                .cbo_purchase_no.Text = DataGridView1.Item(0, i).Value
                .txt_supp_nm.Text = DataGridView1.Item(2, i).Value
                .txt_supp_address.Text = DataGridView1.Item(3, i).Value
                .txt_idsupplier.Text = DataGridView1.Item(4, i).Value
                If DataGridView1.Item(5, i).Value = 1 Then
                    var_method = "Cash"
                ElseIf DataGridView1.Item(5, i).Value = 2 Then
                    var_method = "Credit"
                End If
                .cbo_paymethod.Text = var_method
                .txt_total.Text = FormatNumber(DataGridView1.Item(6, i).Value, 0)
                .txt_curr.Text = DataGridView1.Item(11, i).Value
                .txt_freight.Text = FormatNumber(DataGridView1.Item(7, i).Value, 0)
                .txt_tax.Text = FormatPercent(DataGridView1.Item(8, i).Value / 100, 0)
                .txt_nett.Text = FormatNumber(DataGridView1.Item(9, i).Value, 0)
                .txt_disc.Text = FormatPercent(DataGridView1.Item(10, i).Value / 100, 0)
                .txt_netto.Text = FormatNumber((DataGridView1.Item(6, i).Value) + (DataGridView1.Item(7, i).Value) - ((((DataGridView1.Item(6, i).Value) + (DataGridView1.Item(7, i).Value)) * (DataGridView1.Item(10, i).Value)) / 100), 0)
                Dim rows As Integer
                Dim TSubTotal As Double
                rows = DataGridView1.Rows.Count - 1
                For i = 0 To rows
                    TSubTotal = TSubTotal + Replace(.DataGridView1.Item(7, i).Value, ",", "")
                Next
                .txt_total.Text = FormatNumber(TSubTotal, 0)
                .hitung_nominal()
            End With
        End If
        Me.Close()
    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        generate()

    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged
        open_conn()
        view_data()
    End Sub


    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            generate()
        End If
    End Sub
End Class