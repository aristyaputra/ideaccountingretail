﻿Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormNotaUM

    Private Sub FormNotaSO_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Dim R As New ReportDocument
        Dim pathfilereport As String
        pathfilereport = Application.StartupPath & "\Report\NotaUMSO.rpt"
        R.Load(pathfilereport)
        R.Refresh()
        R.RecordSelectionFormula = "{view_ctk_so1.no_sales_order} ='" & frmDPso.NoBuktiSO & "'"
        With CRviewer
            .ReportSource = R
            .ShowGroupTreeButton = False
            .ShowExportButton = False
            .DisplayGroupTree = False
            .ShowTextSearchButton = False
        End With
    End Sub
End Class