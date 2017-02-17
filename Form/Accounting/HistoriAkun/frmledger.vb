Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmledger
    Dim pageIndex As Integer
    Dim pageLoad As Integer
    Dim saldoAkhir(500000) As Double

    Private Sub frmledger_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmledger_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmledger_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        lbl_acc_nm.Text = ""
        chk_date.Checked = False
        tglawal.Enabled = False
        tglakhir.Enabled = False
        datagrid_layout()
        pageLoad = 25
        pageIndex = 1
        ' txtPage2.Text = 1
        ' txtPage2.Enabled = False
    End Sub
    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
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

    Private Sub view_data(ByVal pageIndex As Integer, ByVal pageLoad As Integer)
        open_conn()
        Dim Rows As Integer
        Dim defposition As New DataTable
        Dim DT As DataTable
        Dim date_filter As Integer

        If chk_date.Checked = True Then
            date_filter = 1
        ElseIf chk_date.Checked = False Then
            date_filter = 0
        End If
        DT = select_general_ledger(cbo_search.Text, tglawal.Value, tglakhir.Value, date_filter, pageIndex, pageLoad)
        defposition = select_def_accpos(cbo_search.Text)
        Rows = DT.Rows.Count - 1
        DataGridView2.Rows.Clear()
        For i = 0 To Rows
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = DT.Rows(i).Item("no_ledger")
            DataGridView2.Item(1, i).Value = Format(DT.Rows(i).Item("date_trn"), "dd-MMM-yyyy")
            DataGridView2.Item(2, i).Value = DT.Rows(i).Item("notes")
            DataGridView2.Item(3, i).Value = FormatNumber(DT.Rows(i).Item("debet"), 0)
            DataGridView2.Item(4, i).Value = FormatNumber(DT.Rows(i).Item("kredit"), 0)
            If i = 0 Then
                '    'If CInt(txtPage2.Text) = 1 Then
                If defposition.Rows(0).Item(0) = "D" Then
                    DataGridView2.Item(5, i).Value = FormatNumber(DataGridView2.Item(3, i).Value - DataGridView2.Item(4, i).Value, 0)
                ElseIf defposition.Rows(0).Item(0) = "K" Then
                    DataGridView2.Item(5, i).Value = FormatNumber(DataGridView2.Item(4, i).Value - DataGridView2.Item(3, i).Value, 0)
                End If
                '    'Else
                'If defposition.Rows(0).Item(0) = "D" Then
                '    DataGridView2.Item(5, i).Value = FormatNumber(saldoAkhir(CInt(txtPage2.Text) - 1) + DataGridView2.Item(3, i).Value - DataGridView2.Item(4, i).Value, 0)
                'ElseIf defposition.Rows(0).Item(0) = "K" Then
                '    DataGridView2.Item(5, i).Value = FormatNumber(saldoAkhir(CInt(txtPage2.Text) - 1) - DataGridView2.Item(4, i).Value - DataGridView2.Item(3, i).Value, 0)
                'End If
                'End If
            Else
                If defposition.Rows(0).Item(0) = "D" Then
                    DataGridView2.Item(5, i).Value = FormatNumber(DataGridView2.Item(5, i - 1).Value + (DataGridView2.Item(3, i).Value - DataGridView2.Item(4, i).Value), 0)
                ElseIf defposition.Rows(0).Item(0) = "K" Then
                    DataGridView2.Item(5, i).Value = FormatNumber(DataGridView2.Item(5, i - 1).Value + (DataGridView2.Item(4, i).Value - DataGridView2.Item(3, i).Value), 0)
                End If
            End If
        Next
    End Sub

    Private Sub chk_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_date.CheckedChanged
        open_conn()
        date_filter()
    End Sub

    Private Sub reset_list()
        open_conn()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        tglakhir.Value = Now
        tglawal.Value = Now
        cbo_search.Text = "No Akun"
    End Sub

    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_cari_cust_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        If Trim(cbo_search.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Masukkan akun terlebih dahulu")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            'txtPage2.Text = 1
            'pageIndex = (pageLoad * CInt(txtPage2.Text)) - pageLoad
            view_data(pageIndex, pageLoad)
            'If DataGridView2.Rows.Count > 0 Then
            '    saldoAkhir(CInt(txtPage2.Text)) = DataGridView2.Item(5, DataGridView2.Rows.Count - 1).Value
            'End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_warning.Show(Me, info)
            Exit Sub
        Finally
            SplashScreenManager.CloseForm(False)
        End Try

    End Sub

    Private Sub cbo_search_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_search.Click
        open_conn()
        'Dim FrmAccount As New frm_display_acc_detail

        frm_display_acc_detail.Show()
        '     FrmAccount.MdiParent = MainMenu
        frm_display_acc_detail.formsource_ledger = True
        ' ' MainMenu.Enabled = False
        ' Me.Enabled = False
        datagrid_layout()

    End Sub

    'Private Sub frmledger_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    open_conn()
    '    Dim Total_Width_Column As Integer
    '    Dim Width_Table As Integer
    '    Dim selisih_col As Integer

    '    With DataGridView2
    '        Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
    '        Width_Table = .Width
    '        selisih_col = Width_Table - Total_Width_Column
    '        .Columns(2).Width = .Columns(2).Width + selisih_col
    '    End With

    'End Sub

    Private Sub cbo_search_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_search.SelectedIndexChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub SimpleButton11_Click(sender As System.Object, e As System.EventArgs)
        'If DataGridView2.Rows.Count > 0 Then
        '    txtPage2.Text = txtPage2.Text + 1
        'End If
        ' pageIndex = (pageLoad * CInt(txtPage2.Text)) - pageLoad
        view_data(pageIndex, pageLoad)
        'If DataGridView2.Rows.Count > 0 Then
        '    saldoAkhir(CInt(txtPage2.Text)) = DataGridView2.Item(5, DataGridView2.Rows.Count - 1).Value
        'End If

    End Sub

    Private Sub SimpleButton10_Click(sender As System.Object, e As System.EventArgs)
        'If CInt(txtPage2.Text) > 1 Then
        '    txtPage2.Text = txtPage2.Text - 1
        'End If
        '   pageIndex = (pageLoad * CInt(txtPage2.Text)) - pageLoad
        view_data(pageIndex, pageLoad)
    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class