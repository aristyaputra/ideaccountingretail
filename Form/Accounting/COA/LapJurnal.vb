Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Public Class LapJurnal

    Private Sub FormNotaPO_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()

        Dim cryRpt As New ReportDocument
        Dim pathfilereport As String
        Dim ReportFormula As String
        Dim filter1, filter2 As String

        pathfilereport = Application.StartupPath & "\Report\LapJurnal.rpt"
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            cryRpt.Load(pathfilereport)

            If FormReportAcc.chk_filtersupp_purch.Checked = True Then
                filter1 = "{view_lap_datacustomer.id_account} >= '" & Trim(FormReportAcc.cbo_supp_purch1.EditValue) & "' and {view_lap_datacustomer.id_account} <= '" & Trim(FormReportAcc.cbo_supp_purch2.EditValue) & "'"
            Else
                filter1 = ""
            End If

            If FormReportAcc.chk_filtertgl_purch.Checked = True Then
                If filter1 <> "" Then
                    filter2 = " and {view_lap_datacustomer.date_trn} >= #" & Format(FormReportAcc.tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(FormReportAcc.tgl_purch2.Value, "yyyy-MM-dd") & "#"
                Else
                    filter2 = "{view_lap_datacustomer.date_trn} >= #" & Format(FormReportAcc.tgl_purch1.Value, "yyyy-MM-dd") & "# and {view_lap_datacustomer.date_trn} <= #" & Format(FormReportAcc.tgl_purch2.Value, "yyyy-MM-dd") & "#"
                End If
            Else
                filter2 = ""
            End If

            If filter1 <> "" Or filter2 <> "" Then
                ReportFormula = filter1 + filter2
                cryRpt.RecordSelectionFormula = ReportFormula
            End If

            cryRpt.Refresh()
            Me.Text = "Laporan Daftar Jurnal"
            ' LapDataCustomer_1.MdiParent = MainMenu
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