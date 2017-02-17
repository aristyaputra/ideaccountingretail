Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraBars.Alerter

Public Class FormLapDepr

    Private Sub FormFakturBeli_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub btn_simpan_Click(sender As System.Object, e As System.EventArgs) Handles btn_simpan.Click
        open_conn()
        Dim R As New ReportDocument
        Dim pathfilereport As String
        pathfilereport = Application.StartupPath & "\Report\LapDaftarPenyusutan.rpt"
        R.Load(pathfilereport)
        R.Refresh()
        R.RecordSelectionFormula = "{view_lap_datacustomer.period} =" & Month(txt_period.Value) & " and {view_lap_datacustomer.years} =" & Year(txt_period.Value) & ""
        With CRviewer
            .ReportSource = R
            .ShowGroupTreeButton = False
            .ShowExportButton = False
            .DisplayGroupTree = False
        End With

    End Sub
End Class