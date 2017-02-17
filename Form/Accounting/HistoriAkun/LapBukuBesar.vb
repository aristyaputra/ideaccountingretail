Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Public Class LapBukuBesar

    Private Sub FormNotaPO_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Dim cryRpt As New ReportDocument
        Dim pathfilereport As String

        pathfilereport = Application.StartupPath & "\Report\LapBukuBesar.rpt"
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            cryRpt.Load(pathfilereport)
            cryRpt.Refresh()
            Dim DTA, DTB As DataTable

            DTA = select_first_account()
            DTB = select_last_account()
            If FormReportAcc.chk_filtersupp_purch.Checked = False Then
                FormReportAcc.cbo_supp_purch1.EditValue = DTA.Rows(0).Item(0)
                FormReportAcc.cbo_supp_purch2.EditValue = DTB.Rows(0).Item(0)
            End If

            cryRpt.SetParameterValue(0, FormReportAcc.cbo_supp_purch1.EditValue)
            cryRpt.SetParameterValue(1, FormReportAcc.cbo_supp_purch2.EditValue)
            cryRpt.SetParameterValue(2, Format(FormReportAcc.tgl_purch1.Value, "yyyy-MM-dd"))
            cryRpt.SetParameterValue(3, Format(FormReportAcc.tgl_purch2.Value, "yyyy-MM-dd"))
            If FormReportAcc.chk_filtertgl_purch.Checked = True Then
                cryRpt.SetParameterValue(4, 1)
            ElseIf FormReportAcc.chk_filtertgl_purch.Checked = False Then
                cryRpt.SetParameterValue(4, 0)
            End If

            Me.Text = "Laporan Buku Besar"
            Me.WindowState = FormWindowState.Maximized
            With Me.CRviewer
                .ReportSource = cryRpt
                .ShowGroupTreeButton = False
                .ShowExportButton = True
                .DisplayGroupTree = False
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub
End Class