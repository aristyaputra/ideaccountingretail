Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmcashregister

    Public NoAkun As String
    Public filterdate As Integer
    Dim pageIndex As Integer
    Dim pageLoad As Integer
    Dim saldoAkhir(500000) As Double

    Private Sub ComboBox4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        'Dim FrmAccount As New frm_display_acc_cash
        'FrmAccount.Show()
        ''   FrmAccount.MdiParent = MainMenu
        'FrmAccount.formsource_ledger = True
        'datagrid_layout()
        'Me.Enabled = False
    End Sub

    Private Sub frmcashregister_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmcashregister_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmledger_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        '        lbl_acc_nm.Text = ""
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        LoadComboBox_MtgcComboBoxAcc()
        datagrid_layout()
        pageLoad = 25
        pageIndex = 1
        'txtPage2.Text = 1
        'txtPage2.Enabled = False
    End Sub
    Private Sub LoadComboBox_MtgcComboBoxAcc()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_cashbank()

        cbo_search.SelectedIndex = -1
        cbo_search.Items.Clear()
        cbo_search.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_search.SourceDataString = New String(1) {"id_account", "account_name"}
        cbo_search.SourceDataTable = dtLoading
        cbo_search.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
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

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()

        If Trim(cbo_search.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Informasi", "Masukkan akun terlebih dahulu")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

       
        '   txtPage2.Text = 1
        '   pageIndex = (pageLoad * CInt(txtPage2.Text)) - pageLoad
        view_data(pageIndex, pageLoad)
        If DataGridView2.Rows.Count > 0 Then
            '      saldoAkhir(CInt(txtPage2.Text)) = DataGridView2.Item(5, DataGridView2.Rows.Count - 1).Value
        End If
        
    End Sub

    Private Sub view_data(ByVal pageIndex As Integer, ByVal pageLoad As Integer)
        Dim defposition As New DataTable
        Dim DT As DataTable
        Dim Rows As Integer

        If chk_date.Checked = True Then
            filterdate = 1
        ElseIf chk_date.Checked = False Then
            filterdate = 0
        End If

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            DT = select_general_ledger(cbo_search.Text, tglawal.Value, tglakhir.Value, filterdate, pageIndex, pageLoad)
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
                    '    If CInt(txtPage2.Text) = 1 Then
                    If defposition.Rows(0).Item(0) = "D" Then
                        DataGridView2.Item(5, i).Value = FormatNumber(DataGridView2.Item(3, i).Value - DataGridView2.Item(4, i).Value, 0)
                    ElseIf defposition.Rows(0).Item(0) = "K" Then
                        DataGridView2.Item(5, i).Value = FormatNumber(DataGridView2.Item(4, i).Value - DataGridView2.Item(3, i).Value, 0)
                    End If
                    '    Else
                    '        If defposition.Rows(0).Item(0) = "D" Then
                    '            DataGridView2.Item(5, i).Value = FormatNumber(saldoAkhir(CInt(txtPage2.Text) - 1) + DataGridView2.Item(3, i).Value - DataGridView2.Item(4, i).Value, 0)
                    '        ElseIf defposition.Rows(0).Item(0) = "K" Then
                    '            DataGridView2.Item(5, i).Value = FormatNumber(saldoAkhir(CInt(txtPage2.Text) - 1) - DataGridView2.Item(4, i).Value - DataGridView2.Item(3, i).Value, 0)
                    '        End If
                    '    End If
                Else
                    If defposition.Rows(0).Item(0) = "D" Then
                        DataGridView2.Item(5, i).Value = FormatNumber(DataGridView2.Item(5, i - 1).Value + (DataGridView2.Item(3, i).Value - DataGridView2.Item(4, i).Value), 0)
                    ElseIf defposition.Rows(0).Item(0) = "K" Then
                        DataGridView2.Item(5, i).Value = FormatNumber(DataGridView2.Item(5, i - 1).Value + (DataGridView2.Item(4, i).Value - DataGridView2.Item(3, i).Value), 0)
                    End If
                End If
            Next
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
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
        cbo_search.Text = ""
    End Sub
    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        open_conn()
        Dim R As New ReportDocument
        Dim pathfilereport As String
        pathfilereport = Application.StartupPath & "\Report\LapCashRegister.rpt"

        Try
            R.Load(pathfilereport)
            R.Refresh()
            R.SetParameterValue(0, Trim(cbo_search.Text))
            R.SetParameterValue(1, tglawal.Value)
            R.SetParameterValue(2, tglakhir.Value)
            R.SetParameterValue(3, filterdate)
            Dim LapDataCustomer_1 As New FormLapCashReg
            LapDataCustomer_1.Show()
            LapDataCustomer_1.Text = "Laporan Kas/Bank Register"
            LapDataCustomer_1.WindowState = FormWindowState.Maximized
            With LapDataCustomer_1.CRviewer
                .ReportSource = R
                .ShowGroupTreeButton = False
                .ShowExportButton = False
                .DisplayGroupTree = False
            End With

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(Me, info)
        End Try
    End Sub

    Private Sub cbo_search_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmcashregister_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        'open_conn()
        'Dim Total_Width_Column As Integer
        'Dim Width_Table As Integer
        'Dim selisih_col As Integer

        'With DataGridView2
        '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width + .Columns(5).Width
        '    Width_Table = .Width
        '    selisih_col = Width_Table - Total_Width_Column
        '    .Columns(2).Width = .Columns(2).Width + selisih_col
        'End With
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
        'pageIndex = (pageLoad * CInt(txtPage2.Text)) - pageLoad
        view_data(pageIndex, pageLoad)
    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class