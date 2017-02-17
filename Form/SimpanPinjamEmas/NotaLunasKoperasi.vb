Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class NotaLunasKoperasi

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Dim R As New ReportDocument
        Dim pathfilereport As String
        pathfilereport = Application.StartupPath & "\Report\KartuBayar.rpt"
        R.Load(pathfilereport)
        R.Refresh()
        '   R.RecordSelectionFormula = "{view_kartu_bayar1.no_bayar} ='" & Trim(frmPinjam.no_bayar) & "'"
        With CRviewer
            .ReportSource = R
            .ShowGroupTreeButton = False
            .ShowExportButton = False
            .PrintReport()
        End With
        update_printstatus(frmPinjam.no_bayar)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class