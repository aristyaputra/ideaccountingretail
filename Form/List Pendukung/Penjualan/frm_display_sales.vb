Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Public Class frm_display_sales
    Dim i As Integer
    Public formsource_sales_return As Boolean

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
        If e.KeyCode = Keys.Enter Then
            open_conn()
            view_data()
        End If
    End Sub

    Public Sub view_data()
        open_conn()
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_sales2(cbo_search.Text, txt_search.Text, 0)
        Rows = DT.Rows.Count - 1
        open_conn()

        DataGridView1.Rows.Clear()
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
            DataGridView1.Item(1, i).Value = Format(DT.Rows(i).Item(3), "dd-MMM-yyyy")
            DataGridView1.Item(2, i).Value = DT.Rows(i).Item(1)
            DataGridView1.Item(3, i).Value = DT.Rows(i).Item("addr_customer")
            DataGridView1.Item(4, i).Value = DT.Rows(i).Item("id_customer")
            DataGridView1.Item(5, i).Value = DT.Rows(i).Item("payment_method")
            DataGridView1.Item(6, i).Value = DT.Rows(i).Item("subtotal")
            DataGridView1.Item(7, i).Value = DT.Rows(i).Item("discount")
            DataGridView1.Item(8, i).Value = DT.Rows(i).Item("tax")
            DataGridView1.Item(9, i).Value = DT.Rows(i).Item("total")
            ' DataGridView1.Item(10, i).Value = DT.Rows(i).Item(18)
            DataGridView1.Item(11, i).Value = DT.Rows(i).Item("tax_nom")
            DataGridView1.Item(12, i).Value = DT.Rows(i).Item("discount_nom")
        Next
    End Sub

    Private Sub frm_display_purchase_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'open_conn()
        'If formsource_sales_return = True Then
        '    formsource_sales_return = False
        '    With frmsalesreturn
        '        .Enabled = True
        '        .Activate()
        '    End With
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

    Private Sub generate()
        open_conn()
        MainMenu.Enabled = True
        If formsource_sales_return = True Then
            i = DataGridView1.CurrentCell.RowIndex
            With frmsalesreturn
                .Enabled = True
                .Activate()
                .cbo_sales_no.Text = DataGridView1.Item(0, i).Value
                .txt_cust_nm.Text = DataGridView1.Item(2, i).Value
                .txt_cust_address.Text = DataGridView1.Item(3, i).Value
                .txt_idsupplier.Text = DataGridView1.Item(4, i).Value
                '.txt_subtotal.Text = FormatNumber(DataGridView1.Item(6, i).Value, 0)
                .txt_disc.Text = FormatPercent(DataGridView1.Item(7, i).Value / 100, 0)
                '.txt_nett.Text = FormatNumber(Replace(DataGridView1.Item(6, i).Value, ",", "") - (Replace(DataGridView1.Item(6, i).Value, ",", "") * Replace(DataGridView1.Item(7, i).Value, ",", "") / 100), 0)
                .txt_tax.Text = FormatPercent(DataGridView1.Item(8, i).Value / 100, 0)
                '.txt_total.Text = FormatNumber(DataGridView1.Item(9, i).Value, 0)
                '.txt_disc_nom.Text = FormatNumber(DataGridView1.Item(12, i).Value, 0)
                '.txt_tax_nom.Text = FormatNumber(DataGridView1.Item(11, i).Value, 0)
                .txt_subtotal.Text = FormatNumber(0, 0)
                '.txt_disc.Text = FormatPercent(0, 0)
                .txt_nett.Text = FormatNumber(0, 0)
                '.txt_tax.Text = FormatPercent(0, 0)
                .txt_total.Text = FormatNumber(0, 0)
                .txt_disc_nom.Text = FormatNumber(0, 0)
                .txt_tax_nom.Text = FormatNumber(0, 0)
                If DataGridView1.Item(5, i).Value = 1 Then
                    .cbo_paymethod.Text = "Cash"
                ElseIf DataGridView1.Item(10, i).Value = 2 Then
                    .cbo_paymethod.Text = "Credit"
                End If
                .txt_kurs.Text = FormatNumber(get_kurs_sales(DataGridView1.Item(0, i).Value))
            End With
            MainMenu.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        open_conn()
        generate()
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        open_conn()
        If e.KeyCode = Keys.Enter Then
            generate()
        End If
    End Sub

End Class