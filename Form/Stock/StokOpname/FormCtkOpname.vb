Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormCtkOpname

    Private Sub FormCtkOpname_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Dim R As New ReportDocument
        Dim pathfilereport As String
        pathfilereport = Application.StartupPath & "\Report\LapStockOpname.rpt"
        R.Load(pathfilereport)
        R.Refresh()
        R.RecordSelectionFormula = "{view_lap_datacustomer.no_opname} ='" & frmsetupcashbank.NoOpname & "'"
        With CRviewer
            .ReportSource = R
            .ShowGroupTreeButton = False
            .ShowExportButton = False
            .DisplayGroupTree = False
        End With
    End Sub
End Class