Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Public Class frmsetmarketing

    Private Sub view_data_employee()
        open_conn()
        Dim Rows As Integer
        Dim dtcust As DataTable

        dtcust = select_not_marketing()
        Rows = dtcust.Rows.Count - 1
        dg_employee.Rows.Clear()
        For i = 0 To Rows
            dg_employee.Rows.Add()
            dg_employee.Item(0, i).Value = dtcust.Rows(i).Item("id_employee")
            dg_employee.Item(1, i).Value = dtcust.Rows(i).Item("nama")
            dg_employee.Item(2, i).Value = dtcust.Rows(i).Item("position_name")
            dg_employee.Item(3, i).Value = dtcust.Rows(i).Item("department_name")
        Next
    End Sub

    Private Sub view_data_marketing()
        open_conn()
        Dim Rows As Integer
        Dim dtcust As DataTable

        dtcust = select_set_marketing()
        Rows = dtcust.Rows.Count - 1
        dg_marketing.Rows.Clear()
        For i = 0 To Rows
            dg_marketing.Rows.Add()
            dg_marketing.Item(0, i).Value = dtcust.Rows(i).Item("id_employee")
            dg_marketing.Item(1, i).Value = dtcust.Rows(i).Item("nama")
            dg_marketing.Item(2, i).Value = dtcust.Rows(i).Item("city")
            dg_marketing.Item(3, i).Value = dtcust.Rows(i).Item("comission")
        Next
    End Sub

    Private Sub frmsetmarketing_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub frmsetmarketing_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
      
            view_data_employee()
            view_data_marketing()
            dg_employee.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dg_marketing.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            With dg_employee
                .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
                .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
                .DefaultCellStyle.SelectionForeColor = Color.Black
            End With
            With dg_marketing
                .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
                .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
                .DefaultCellStyle.SelectionForeColor = Color.Black
            End With

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(Me, info)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub btn_next_Click(sender As System.Object, e As System.EventArgs) Handles btn_next.Click
        open_conn()
        fillComboBox()
        'Dim index_row As Integer
        'index_row = dg_employee.CurrentCell.RowIndex
        'Call update_set_marketing(dg_employee.Item(0, index_row).Value, username, server_datetime(), server_datetime(), username, "UPDATE")
        MarketingControl.Visible = True
        'view_data_marketing()
        'view_data_employee()
        Me.Visible = False
    End Sub

    Private Sub btn_prev_Click(sender As System.Object, e As System.EventArgs) Handles btn_prev.Click
        open_conn()
        Dim index_row As Integer
        index_row = dg_marketing.CurrentCell.RowIndex
        Call update_set_marketing(dg_marketing.Item(0, index_row).Value, username, server_datetime(), server_datetime(), username, "DELETE", cbo_kota.EditValue, Replace(txt_komisi.Text, ",", ""))
        view_data_marketing()
        view_data_employee()
    End Sub

    Private Sub dg_marketing_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_marketing.CellContentClick

    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub


    Private Sub fillComboBox()
        cbo_kota.Properties.DataSource = getComboCityAll()
        cbo_kota.Properties.DisplayMember = "city_name"
        cbo_kota.Properties.ValueMember = "city_code"
        cbo_kota.Properties.PopulateViewColumns()
        cbo_kota.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_kota.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_kota.Properties.View.Columns("city_code").Caption = "Kode"
        cbo_kota.Properties.View.Columns("city_name").Caption = "Kota"
    End Sub

    Private Sub btn_prosesimp_cust_Click(sender As System.Object, e As System.EventArgs) Handles btn_proses.Click
        open_conn()

        If IsNumeric(txt_komisi.Text) = False Then
            Dim info As AlertInfo = New AlertInfo("Warning", "Masukkan Nominal Prosentase Komisi!")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        Dim index_row As Integer
        index_row = dg_employee.CurrentCell.RowIndex
        Call update_set_marketing(dg_employee.Item(0, index_row).Value, username, server_datetime(), server_datetime(), username, "UPDATE", cbo_kota.EditValue, Replace(txt_komisi.Text, ",", ""))
        MarketingControl.Visible = False
        Me.Visible = True
        view_data_marketing()
        view_data_employee()
    End Sub
End Class