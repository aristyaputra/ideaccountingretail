Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraBars.Alerter
Imports System.Drawing.Printing

Public Class frmFakturPajak
    Dim cryRpt As New ReportDocument
    Dim pathfilereport As String
    Dim no_faktur_pajak As String
    Dim yloc As Integer
    Dim CRwidth, CRheight As Integer

    Private Sub FormFakturBeli_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
    End Sub

    Private Sub fillComboBox()
        cbo_um.Properties.DataSource = getComboSOUm()
        cbo_um.Properties.DisplayMember = "nm_customer"
        cbo_um.Properties.ValueMember = "no_sales_order"
        cbo_um.Properties.PopulateColumns()

        cbo_status.Properties.DataSource = getComboStatusCodeFP()
        cbo_status.Properties.DisplayMember = "notes"
        cbo_status.Properties.ValueMember = "kode"
        cbo_status.Properties.PopulateColumns()

        cbo_jenis.Properties.DataSource = getComboJenisTransFP()
        cbo_jenis.Properties.DisplayMember = "notes"
        cbo_jenis.Properties.ValueMember = "kode"
        cbo_jenis.Properties.PopulateColumns()

        cbo_transaksi.Properties.DataSource = getComboSalesFP()
        cbo_transaksi.Properties.DisplayMember = "notes"
        cbo_transaksi.Properties.ValueMember = "kode"
        cbo_transaksi.Properties.PopulateColumns()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbfaktur.Checked = True
        yloc = Button2.Location.Y
        fillComboBox()
    End Sub

    Private Sub btn_simpan_Click(sender As System.Object, e As System.EventArgs) Handles btn_simpan.Click

        Dim a As Integer
        If rb_retur.Checked = True Then

        ElseIf rb_um.Checked = True Then
            If cbo_um.EditValue = Nothing Then
                Dim info As AlertInfo = New AlertInfo("Warning . .", "Silahkan Pilih Transaksi")
                alertControl_warning.Show(Me, info)
                a = a + 1
            End If
        ElseIf rbfaktur.Checked = True Then
            If cbo_transaksi.EditValue = Nothing Then
                Dim info As AlertInfo = New AlertInfo("Warning . .", "Silahkan Pilih Transaksi")
                alertControl_warning.Show(Me, info)
                a = a + 1
            End If
        End If
        
        If cbo_jenis.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Warning . .", "Silahkan Pilih Jenis Transaksi")
            alertControl_warning.Show(Me, info)
            a = a + 1
        End If
        If cbo_status.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Warning . .", "Silahkan Pilih Status Faktur")
            alertControl_warning.Show(Me, info)
            a = a + 1
        End If

        If a = 0 Then
            show_faktur()
        End If
    End Sub

    Private Sub show_faktur()
        open_conn()
        Try
            If rbfaktur.Checked = True Then
                var_bulan = Month(cbo_transaksi.GetColumnValue("date_trn"))
                var_tahun = Year(cbo_transaksi.GetColumnValue("date_trn"))

                If cbo_status.EditValue = "0" Then
                    Call insert_no_trans("FAKTUR_PAJAK_NORMAL", var_bulan, var_tahun)
                    Call select_control_no("FAKTUR_PAJAK_NORMAL", "TRANS")
                Else
                    Call insert_no_trans("FAKTUR_PAJAK_PENGGANTI", var_bulan, var_tahun)
                    Call select_control_no("FAKTUR_PAJAK_PENGGANTI", "TRANS")
                End If

                no_faktur_pajak = cbo_jenis.EditValue & cbo_status.EditValue & "." & get_tax_branch_code() & "-" & Format(cbo_transaksi.GetColumnValue("date_trn"), "MM") & "." & no_master

                pathfilereport = Application.StartupPath & "\Report\FakturPajak.rpt"
                Try
                    cryRpt.Load(pathfilereport)
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue("tax_serries", no_faktur_pajak)
                    cryRpt.RecordSelectionFormula = "{view_ctk_so1.no_sales} ='" & cbo_transaksi.GetColumnValue("no_sales") & "'"
                    Me.Text = "Faktur Pajak"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    Me.WindowState = FormWindowState.Maximized
                    With CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = False
                        .DisplayGroupTree = False
                        .ShowCloseButton = False
                        .ShowGroupTreeButton = False
                        .ShowRefreshButton = False
                        .ShowZoomButton = False
                        .ShowPrintButton = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            ElseIf rb_retur.Checked = True Then

            ElseIf rb_um.Checked = True Then
                var_bulan = Month(cbo_um.GetColumnValue("date_trn"))
                var_tahun = Year(cbo_um.GetColumnValue("date_trn"))

                If cbo_status.EditValue = "0" Then
                    Call insert_no_trans("FAKTUR_PAJAK_NORMAL", var_bulan, var_tahun)
                    Call select_control_no("FAKTUR_PAJAK_NORMAL", "TRANS")
                Else
                    Call insert_no_trans("FAKTUR_PAJAK_PENGGANTI", var_bulan, var_tahun)
                    Call select_control_no("FAKTUR_PAJAK_PENGGANTI", "TRANS")
                End If

                no_faktur_pajak = cbo_jenis.EditValue & cbo_status.EditValue & "." & get_tax_branch_code() & "-" & Format(cbo_um.GetColumnValue("date_trn"), "MM") & "." & no_master

                pathfilereport = Application.StartupPath & "\Report\FakturPajakUM.rpt"
                Try
                    cryRpt.Load(pathfilereport)
                    cryRpt.Refresh()
                    cryRpt.SetParameterValue("tax_serries", no_faktur_pajak)
                    cryRpt.RecordSelectionFormula = "{view_ctk_so1.no_sales_order} ='" & cbo_um.GetColumnValue("no_sales_order") & "'"
                    Me.Text = "Faktur Pajak"
                    ' LapDataCustomer_1.MdiParent = MainMenu
                    Me.WindowState = FormWindowState.Maximized
                    With CRviewer
                        .ReportSource = cryRpt
                        .ShowGroupTreeButton = False
                        .ShowExportButton = False
                        .DisplayGroupTree = False
                        .ShowCloseButton = False
                        .ShowGroupTreeButton = False
                        .ShowRefreshButton = False
                        .ShowZoomButton = False
                        .ShowPrintButton = False
                    End With

                Catch ex As Exception
                    Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                    alertControl_error.Show(Me, info)
                End Try
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
            alertControl_error.Show(Me, info)
        End Try
    End Sub


    Private Sub chk_filtertgl_purch_CheckedChanged(sender As System.Object, e As System.EventArgs)
        If chk_filtertgl_purch.Checked = True Then
            cbo_transaksi.Enabled = True
            cbo_aset2.Enabled = True
        Else
            cbo_transaksi.Enabled = False
            cbo_aset2.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim a As Integer
        If cbo_transaksi.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Warning . .", "Silahkan Pilih Transaksi")
            alertControl_warning.Show(Me, info)
            a = a + 1
        End If
        If cbo_jenis.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Warning . .", "Silahkan Pilih Jenis Transaksi")
            alertControl_warning.Show(Me, info)
            a = a + 1
        End If
        If cbo_status.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Warning . .", "Silahkan Pilih Status Faktur")
            alertControl_warning.Show(Me, info)
            a = a + 1
        End If
        If getTemplateAkses(username, "MN_FAKTUR_PAJAK_PRINT") <> True Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses cetak faktur pajak!")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        If a = 0 Then
            show_faktur()

            Try
                Dim printerSettings As New PrinterSettings
                Dim printDialog As New PrintDialog
                printDialog.PrinterSettings = printerSettings
                printDialog.AllowPrintToFile = False
                printDialog.AllowSomePages = True
                printDialog.UseEXDialog = True

                Dim result As DialogResult = printDialog.ShowDialog

                If result = DialogResult.OK Then
                    cryRpt.PrintOptions.PrinterName = printerSettings.PrinterName
                    cryRpt.PrintToPrinter(printerSettings.Copies, False, 0, 0)
                End If

            Catch ex As Exception
                Dim info As AlertInfo = New AlertInfo("Error . .", ex.Message)
                alertControl_error.Show(Me, info)
            Finally
                If rbfaktur.Checked = True Then
                    If cbo_status.EditValue = "0" Then
                        update_no_trans(cbo_transaksi.GetColumnValue("date_trn"), "FAKTUR_PAJAK_NORMAL")
                    Else
                        update_no_trans(cbo_transaksi.GetColumnValue("date_trn"), "FAKTUR_PAJAK_PENGGANTI")
                    End If
                ElseIf rb_retur.Checked = True Then

                End If
            End Try
            
        End If
    End Sub

    Private Sub rbfaktur_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbfaktur.CheckedChanged
        If rbfaktur.Checked = True Then
            cbo_transaksi.Enabled = True
            cbo_retur.Enabled = False
            cbo_um.Enabled = False
        ElseIf rb_retur.Checked = True Then
            cbo_transaksi.Enabled = False
            cbo_retur.Enabled = True
            cbo_um.Enabled = False
        ElseIf rb_um.Checked = True Then
            cbo_transaksi.Enabled = False
            cbo_retur.Enabled = False
            cbo_um.Enabled = True
        End If
    End Sub

    Private Sub cbo_transaksi_Popup(sender As Object, e As System.EventArgs) Handles cbo_transaksi.Popup
        cbo_transaksi.Properties.BestFit()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If CRviewer.Dock = DockStyle.None Then
            CRviewer.Dock = DockStyle.Fill
            GroupBox1.Visible = False
            Button2.Location = New System.Drawing.Point(Button2.Location.X, 0)
            CRwidth = CRviewer.Width
            CRheight = CRviewer.Height
        Else
            GroupBox1.Visible = True
            CRviewer.Dock = DockStyle.None
            CRviewer.Width = CRwidth
            CRviewer.Height = CRheight
            Button2.Location = New System.Drawing.Point(Button2.Location.X, yloc)
        End If
    End Sub

    Private Sub cbo_um_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbo_um.EditValueChanged

    End Sub

    Private Sub CRviewer_Load(sender As System.Object, e As System.EventArgs) Handles CRviewer.Load

    End Sub
End Class