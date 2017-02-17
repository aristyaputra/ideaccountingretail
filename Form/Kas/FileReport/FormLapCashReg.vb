Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormLapCashReg

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim R As New ReportDocument
        'Dim pathfilereport As String
        'pathfilereport = Application.StartupPath & "\Report\LapCashRegister.rpt"
        ''  Dim A As New frmcashregister

        'Try
        '    R.Load(pathfilereport)
        '    R.Refresh()
        '    R.RecordSelectionFormula = "{general_ledger1.no_ledger} ='" & frmcashregister.NoAkun & "'"
        '    With CRviewer
        '        .ReportSource = R
        '        .ShowGroupTreeButton = False
        '        .ShowExportButton = True
        '        .DisplayGroupTree = False
        '    End With
        '    R.SetParameterValue(0, frmcashregister.NoAkun)
        '    R.SetParameterValue(1, frmcashregister.tglawal.Value)
        '    R.SetParameterValue(2, frmcashregister.tglakhir.Value)
        '    R.SetParameterValue(3, frmcashregister.filterdate)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub
End Class