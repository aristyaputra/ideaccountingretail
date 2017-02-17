Imports System.IO
Imports System.Text
Imports System.Drawing
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frmsetcadhutang

    Private Sub btn_reset2_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset2.Click
        txt_1.Text = 0
        txt_2.Text = 0
        txt_3.Text = 0
        txt_4.Text = 0
        txt_5.Text = 0
        txt_blm_jt.Text = 0
    End Sub

    Private Sub view_data()
        Dim DT As New DataTable
        DT = select_set_cadangan_ap()
        GridControl.DataSource = DT
        GridList_Customer.Columns("id_cadangan").Caption = "ID Cadangan"
        GridList_Customer.Columns("id_cadangan").Width = 100
        GridList_Customer.Columns("umur_hutang").Caption = "Umur Hutang"
        GridList_Customer.Columns("umur_hutang").Width = 120
        GridList_Customer.Columns("prosentase").Caption = "Prosentase"
        GridList_Customer.Columns("prosentase").Width = 180
        GridList_Customer.Columns("prosentase").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GridList_Customer.Columns("prosentase").DisplayFormat.FormatString = "N2"
        GridList_Customer.Columns("modified_date").Visible = False
        GridList_Customer.Columns("modified_user").Visible = False

        'DataGridView2.Rows.Clear()
        'If DT.Rows.Count > 0 Then
        '    For i As Integer = 0 To DT.Rows.Count - 1
        '        DataGridView2.Rows.Add(1)
        '        DataGridView2.Item(0, i).Value = DT.Rows(i).Item("id_cadangan")
        '        DataGridView2.Item(1, i).Value = DT.Rows(i).Item("umur_hutang")
        '        DataGridView2.Item(2, i).Value = FormatNumber(DT.Rows(i).Item("prosentase"), 2)
        '    Next
        'End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        If TabControl1.SelectedTabPage Is TabList Then
            view_data()
        End If
    End Sub

    Private Sub btn_save2_Click(sender As System.Object, e As System.EventArgs) Handles btn_save2.Click
        If Trim(txt_1.Text) = "" Or IsNumeric(txt_1.Text) = False Then
            txt_1.Text = 0
        End If
        If Trim(txt_2.Text) = "" Or IsNumeric(txt_2.Text) = False Then
            txt_2.Text = 0
        End If
        If Trim(txt_3.Text) = "" Or IsNumeric(txt_3.Text) = False Then
            txt_3.Text = 0
        End If
        If Trim(txt_4.Text) = "" Or IsNumeric(txt_4.Text) = False Then
            txt_4.Text = 0
        End If
        If Trim(txt_5.Text) = "" Or IsNumeric(txt_5.Text) = False Then
            txt_5.Text = 0
        End If
        If Trim(txt_blm_jt.Text) = "" Or IsNumeric(txt_blm_jt.Text) = False Then
            txt_blm_jt.Text = 0
        End If

        Call update_set_cadangan_ap(Replace(txt_blm_jt.Text, ",", ""), Replace(txt_1.Text, ",", ""), Replace(txt_2.Text, ",", ""), Replace(txt_3.Text, ",", ""), Replace(txt_4.Text, ",", ""), Replace(txt_5.Text, ",", ""), Format(server_datetime(), "yyyy-MM-dd"), username)
        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
            alertControl_success.Show(Me, info)
        Else
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
            alertControl_error.Show(Me, info)
        End If
    End Sub


    Private Sub detail()
        Try
            Dim DT As New DataTable
            DT = select_set_cadangan_ap()
            If DT.Rows.Count > 0 Then
                For i As Integer = 0 To DT.Rows.Count - 1
                    If DT.Rows(i).Item("id_cadangan") = 1 Then
                        txt_blm_jt.Text = FormatNumber(DT.Rows(i).Item("prosentase"), 2)
                    End If
                    If DT.Rows(i).Item("id_cadangan") = 2 Then
                        txt_1.Text = FormatNumber(DT.Rows(i).Item("prosentase"), 2)
                    End If
                    If DT.Rows(i).Item("id_cadangan") = 3 Then
                        txt_2.Text = FormatNumber(DT.Rows(i).Item("prosentase"), 2)
                    End If
                    If DT.Rows(i).Item("id_cadangan") = 4 Then
                        txt_3.Text = FormatNumber(DT.Rows(i).Item("prosentase"), 2)
                    End If
                    If DT.Rows(i).Item("id_cadangan") = 5 Then
                        txt_4.Text = FormatNumber(DT.Rows(i).Item("prosentase"), 2)
                    End If
                    If DT.Rows(i).Item("id_cadangan") = 6 Then
                        txt_5.Text = FormatNumber(DT.Rows(i).Item("prosentase"), 2)
                    End If
                Next
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(Me, info)
        End Try
    End Sub

    Private Sub frmsetcadhutang_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmsetcadpiutang_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        Me.MdiParent = MainMenu
        PanelControl3.Visible = False
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        DataGridView2.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(var_red, var_grey, var_blue)
        DataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black
        view_data()
    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        PanelControl3.Visible = False
        enableMain()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            view_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton8_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton8.Click
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            view_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl3.Visible = True
        disableMain()
        detail()
    End Sub

    Private Sub GridControl_Click(sender As System.Object, e As System.EventArgs) Handles GridControl.Click

    End Sub
End Class