Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Public Class LapPembelian

    Private Sub LapPembelian_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If FormReportAcc.report_acc_source = True Then
        '    If FormReportAcc.Visible = False Then
        '        FormReportAcc.Visible = True
        '    End If
        '    FormReportAcc.report_acc_source = False
        'End If
        'If FormReportCash.report_cashbank_source = True Then
        '    If FormReportCash.Visible = False Then
        '        FormReportCash.Visible = True
        '    End If
        '    FormReportCash.report_cashbank_source = False
        'End If
    End Sub


    Private Sub CRviewer_ReportRefresh(source As Object, e As CrystalDecisions.Windows.Forms.ViewerEventArgs) Handles CRviewer.ReportRefresh
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub LapPembelian_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub
End Class