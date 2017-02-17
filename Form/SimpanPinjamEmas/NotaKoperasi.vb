Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class NotaKoperasi

    Private Sub FormFakturBeli_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Dim R As New ReportDocument
        Dim pathfilereport As String
        pathfilereport = Application.StartupPath & "\Report\KartuPinjam.rpt"
        R.Load(pathfilereport)
        R.Refresh()
        R.RecordSelectionFormula = "{trn_pinjam1.no_pinjam} ='" & frmPinjam.NoFakturJual & "'"
        With CRviewer
            .ReportSource = R
            .ShowGroupTreeButton = False
            .ShowExportButton = False
            .PrintReport()
        End With

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class