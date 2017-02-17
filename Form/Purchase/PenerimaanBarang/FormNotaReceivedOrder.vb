Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports MySql.Data.MySqlClient

Public Class FormNotaReceivedOrder

    Private Sub FormNotaReceivedOrder_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = False
            Dim R As New ReportDocument
            Dim pathfilereport As String
            pathfilereport = Application.StartupPath & "\Report\NotaReceivedOrder.rpt"


            Dim da As New MySqlDataAdapter()
            Dim ds As New DataSet()
            Dim qryCompanies As String = "SELECT * FROM view_ctk_rec where no_received_order = '" & frmRecOrder.NoBuktiRec & "'"

            da.SelectCommand = New MySqlCommand(qryCompanies, conn)

            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)

            da.Fill(ds)

            R.Load(pathfilereport)
            R.SetDataSource(ds.Tables(0))

            R.Refresh()
            R.RecordSelectionFormula = "{view_ctk_so1.no_received_order} ='" & frmRecOrder.NoBuktiRec & "'"
            With CRviewer
                .ReportSource = R
                .ShowGroupTreeButton = False
                .ShowExportButton = False
                .DisplayGroupTree = False
                .ShowRefreshButton = False
                .ShowTextSearchButton = False
            End With
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
            alertControl_error.Show(Me, info)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub
End Class