Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class ClosedPeriod

    Dim pesan As String
    Private Sub FormClosedBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_acc_close()
        Rows = DT.Rows.Count - 1
        For i = 0 To Rows
            cbo_akun.Items.Add(DT.Rows(i).Item(0))
        Next
        cbo_akun.Text = DT.Rows(0).Item(0)
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub insert_data()

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            Dim var_lock As Integer
            If chk_lock.Checked = True Then
                var_lock = 1
            Else
                var_lock = 0
            End If

            Call insert_close_table(server_datetime(), cbo_akun.Text, txt_date1.Value, txt_date2.Value, Month(period.Value), Year(period.Value), var_lock)
            Call closed_journal(server_datetime(), cbo_akun.Text, txt_date1.Value, txt_date2.Value, Month(period.Value), Year(period.Value))
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo("Sukses Closing", "Proses tutup periode berhasil")
            alertControl_warning.Show(Me, info)
        End If
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        pesan = MsgBox("Apakah Anda ingin menutup periode akuntansi?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Tutup Periode")
        If pesan = vbYes Then
            insert_data()
        End If
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub
End Class