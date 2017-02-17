Public Class FormServiceReport
    Dim CurrentIndexList As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        open_conn()
        'If CurrentIndexList = 0 Then
        '    MyReportFormula = "{trn_service_head.date_trn} In Date (" & Format(DateTimePicker1.Value, "yyyy,MM,dd") & ") To Date (" & Format(DateTimePicker2.Value, "yyyy,MM,dd") & ")"
        '    Dim LapService1 As New FormServiceReport1
        '    LapService1.Show()
        '    LapService1.MdiParent = MainMenu
        '    LapService1.WindowState = FormWindowState.Maximized
        'ElseIf CurrentIndexList = 1 Then
        '    MyReportFormula = "{trn_service_head.date_trn} In Date (" & Format(DateTimePicker1.Value, "yyyy,MM,dd") & ") To Date (" & Format(DateTimePicker2.Value, "yyyy,MM,dd") & ")"
        '    Dim LapService1 As New FormServiceReport2
        '    LapService1.Show()
        '    LapService1.MdiParent = MainMenu
        '    LapService1.WindowState = FormWindowState.Maximized
        'ElseIf CurrentIndexList = 2 Then
        '    MyReportFormula = "{commission_report_view.date_trn} In Date (" & Format(DateTimePicker1.Value, "yyyy,MM,dd") & ") To Date (" & Format(DateTimePicker2.Value, "yyyy,MM,dd") & ")"
        '    Dim LapService1 As New FormServiceReport3
        '    LapService1.Show()
        '    LapService1.MdiParent = MainMenu
        '    LapService1.WindowState = FormWindowState.Maximized
        'End If
    End Sub

    Private Sub FormServiceReport_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If panel_servicereport = True Then
            panel_servicereport = False
            FrmCommandPanel.Enabled = True
        End If
        close_conn()
    End Sub

    Private Sub FormServiceReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        open_conn()
        CurrentIndexList = ListView1.FocusedItem.Index
    End Sub
End Class