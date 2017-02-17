Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class frm_set_init

    Private Sub frm_set_init_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        open_conn()
        chk_setup_def_acc.Checked = True
        rb_id.Checked = True
        If get_count_period() > 0 Then
            chk_setup_def_acc.Enabled = False
            chk_setup_def_curr.Enabled = False
            rb_id.Enabled = False
            rb_int.Enabled = False
            rb_id2.Enabled = False
            rb_int2.Enabled = False
        End If
        If cek_is_bumn() > 0 Then
            chk_setup_def_acc.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim lang As Integer
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            If rb_id.Checked = True Then
                lang = 1
            End If
            If rb_int.Checked = True Then
                lang = 2
            End If

            If chk_setup_def_acc.Checked = True Then
                If get_company_type() = 1 Then
                    Call insert_init_account_retail(Month(period.Value), Year(years.Value), server_datetime(), lang)
                ElseIf get_company_type() = 2 Then
                    Call insert_init_account_manufacture(Month(period.Value), Year(years.Value), server_datetime(), lang)
                End If
            Else
                Call insert_init_period(Month(period.Value), Year(years.Value), server_datetime())
            End If

            If chk_setup_def_curr.Checked = True Then
                Call set_def_curr()
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try

        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
            alertControl_success.Show(Me, info)
            Me.Hide()
            MainMenu.Enabled = True
            MainMenu.Activate()
        Else
            Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
            alertControl_error.Show(Me, info)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub chk_setup_def_acc_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_setup_def_acc.CheckedChanged
        If chk_setup_def_acc.Checked = False Then
            rb_id.Checked = False
            rb_int.Checked = False
        End If
    End Sub
End Class