Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraBars.Alerter

Public Class FormLapAkumDepr

    Private Sub FormFakturBeli_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataBarang.Aset' table. You can move, or remove it, as needed.
        chk_filtertgl_purch.Checked = False
        fillComboBox()
    End Sub

    Private Sub fillComboBox()
        Dim DT As DataTable
        DT = getComboAset()
        cbo_aset1.Properties.DataSource = DT
        cbo_aset1.Properties.DisplayMember = "nama"
        cbo_aset1.Properties.ValueMember = "id_aset"
        cbo_aset1.Properties.PopulateColumns()
        cbo_aset1.Properties.Columns("id_aset").Caption = "Kode"
        cbo_aset1.Properties.Columns("nama").Caption = "Aset"

        cbo_aset2.Properties.DataSource = DT
        cbo_aset2.Properties.DisplayMember = "nama"
        cbo_aset2.Properties.ValueMember = "id_aset"
        cbo_aset2.Properties.PopulateColumns()
        cbo_aset2.Properties.Columns("id_aset").Caption = "Kode"
        cbo_aset2.Properties.Columns("nama").Caption = "Aset"
    End Sub

    Private Sub btn_simpan_Click(sender As System.Object, e As System.EventArgs) Handles btn_simpan.Click
        open_conn()
        Dim cryRpt As New ReportDocument
        Dim pathfilereport As String

        pathfilereport = Application.StartupPath & "\Report\LapAkumPenyusutanAset.rpt"
        Try
            cryRpt.Load(pathfilereport)
            cryRpt.Refresh()

            If chk_filtertgl_purch.Checked = True Then
                cryRpt.SetParameterValue(0, cbo_aset1.EditValue)
                cryRpt.SetParameterValue(1, cbo_aset2.EditValue)
            ElseIf chk_filtertgl_purch.Checked = False Then
                cryRpt.SetParameterValue(0, get_first_aset())
                cryRpt.SetParameterValue(1, get_last_aset())
            End If

            cryRpt.SetParameterValue(2, Month(txt_period.Value))
            cryRpt.SetParameterValue(3, Year(txt_period.Value))


            Me.Text = "Laporan Akumulasi Penyusutan Aset"
            ' LapDataCustomer_1.MdiParent = MainMenu
            Me.WindowState = FormWindowState.Maximized
            With CRviewer
                .ReportSource = cryRpt
                .ShowGroupTreeButton = False
                .ShowExportButton = True
                .DisplayGroupTree = False
            End With

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
            alertControl_error.Show(Me, info)
        End Try

    End Sub

    Private Sub chk_filtertgl_purch_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If chk_filtertgl_purch.Checked = True Then
            cbo_aset1.Enabled = True
            cbo_aset2.Enabled = True
        Else
            cbo_aset1.Enabled = False
            cbo_aset2.Enabled = False
        End If
    End Sub
End Class