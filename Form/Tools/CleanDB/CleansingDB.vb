Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter

Public Class CleansingDB

    Dim pesan As String
    Private Sub insert_data()

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            cleansing_db()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        If param_sukses = True Then
            Dim info As AlertInfo = New AlertInfo("Sukses Cleansing", "Proses cleansing database berhasil")
            alertControl_success.Show(Me, info)
        End If
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        pesan = MsgBox("Apakah Anda ingin melakukan cleansing database?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Tutup Periode")
        If pesan = vbYes Then
            insert_data()
        End If
    End Sub


End Class