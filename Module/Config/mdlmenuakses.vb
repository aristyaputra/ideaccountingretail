Module mdlmenuakses
    Public NoBuktiRO As String

    Public Sub AksesToolstripMenu(ByVal MenuName As ToolStripMenuItem)
        With MainMenu
            If MenuName Is .mnMasterCust Then
                If Application.OpenForms().OfType(Of frmcustomer).Any Then
                    'MsgBox("Menu Customer Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmcustomer.Activate()
                Else
                    frmcustomer.Show()
                    'frmcustomer.MdiParent = MainMenu
                End If

            ElseIf MenuName Is .mnApprovalPermintaan Then
                If Application.OpenForms().OfType(Of frmApproveRO).Any Then
                    'MsgBox("Menu Approval RO Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmApproveRO.Activate()
                Else
                    frmApproveRO.Show()
                    'frmApproveRO.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .menuMasterSupp Then
                If Application.OpenForms().OfType(Of frmsupplier).Any Then
                    'MsgBox("Menu Supplier Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmsupplier.Activate()
                Else
                    frmsupplier.Show()
                    'frmsupplier.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .menuMasterMktg Then
                If Application.OpenForms().OfType(Of frmmarketing).Any Then
                    'MsgBox("Menu Marketing Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmmarketing.Activate()
                Else
                    frmmarketing.Show()
                    'frmmarketing.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnItemJenis Then
                If Application.OpenForms().OfType(Of frmjenisbarang).Any Then
                    'MsgBox("Menu Jenis Barang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmjenisbarang.Activate()
                Else
                    frmjenisbarang.Show()
                    'frmjenisbarang.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnItemCat Then
                If Application.OpenForms().OfType(Of frmkatbarang).Any Then
                    'MsgBox("Menu Item Category Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmkatbarang.Activate()
                Else
                    frmkatbarang.Show()
                    'frmkatbarang.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnItemBrand Then
                If Application.OpenForms().OfType(Of frmcustomer).Any Then
                    'MsgBox("Menu Item Brand Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                Else
                   
                End If
            ElseIf MenuName Is .mnMasterItem Then
                If Application.OpenForms().OfType(Of frmitem).Any Then
                    'MsgBox("Menu Master Item Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmitem.Activate()
                Else
                    frmitem.Show()
                    'frmitem.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnStockAwal Then
                If Application.OpenForms().OfType(Of frmitem_beginning).Any Then
                    'MsgBox("Menu Stock Awal Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmitem_beginning.Activate()
                Else
                    frmitem_beginning.Show()
                    'frmitem_beginning.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnMasterService Then
                If Application.OpenForms().OfType(Of frmservice).Any Then
                    'MsgBox("Menu Master Service Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmservice.Activate()
                Else
                    frmservice.Show()
                    'frmservice.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnUnit Then
                If Application.OpenForms().OfType(Of frmUnit).Any Then
                    'MsgBox("Menu Unit Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmUnit.Activate()
                Else
                    frmUnit.Show()
                    'frmUnit.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnUnitConvers Then
                If Application.OpenForms().OfType(Of frmUnit).Any Then
                    'MsgBox("Menu Konversi Unit Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmUnit.Activate()
                Else
                    frmUnit.Show()
                    frmUnit.TabControl1.SelectedTabPage = frmUnit.TabKonversi
                    'frmUnit.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnWH Then
                If Application.OpenForms().OfType(Of frmWH).Any Then
                    'MsgBox("Menu Gudang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmWH.Activate()
                Else
                    frmWH.Show()
                    'frmWH.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnCurrency Then
                If Application.OpenForms().OfType(Of frmCurrency).Any Then
                    'MsgBox("Menu Mata Uang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmCurrency.Activate()
                Else
                    frmCurrency.Show()
                    'frmCurrency.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnConvertCurr Then
                If Application.OpenForms().OfType(Of frmCurrency).Any Then
                    'MsgBox("Menu Konversi Mata Uang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmCurrency.Activate()
                Else
                    frmCurrency.Show()
                    frmCurrency.TabControl1.SelectedTabPage = frmCurrency.tabconvert
                    'frmCurrency.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnStockOpname Then
                If Application.OpenForms().OfType(Of frmstockopname).Any Then
                    'MsgBox("Menu Stock Opname Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmstockopname.Activate()
                Else
                    frmstockopname.Show()
                    'frmstockopname.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnStockCorrection Then
                If Application.OpenForms().OfType(Of frmadjuststock).Any Then
                    'MsgBox("Menu Koreksi Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmadjuststock.Activate()
                Else
                    frmadjuststock.Show()
                    'frmadjuststock.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnItemTransfer Then
                If Application.OpenForms().OfType(Of frmitemtransfer).Any Then
                    'MsgBox("Menu Transfer Item Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmitemtransfer.Activate()
                Else
                    frmitemtransfer.Show()
                    'frmitemtransfer.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnItemList Then
                If Application.OpenForms().OfType(Of frmitem).Any Then
                    'MsgBox("Menu Daftar Item Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmitem.Activate()
                Else
                    frmitem.Show()
                    frmitem.TabControl1.SelectedTabPage = frmitem.TabList
                    'frmitem.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnStockReport Then
                If Application.OpenForms().OfType(Of FormReportStock).Any Then
                    'MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportStock.Activate()
                Else

                    FormReportStock.Show()
                    'Rpt.MdiParent = MainMenu
                    FormReportStock.rb_purch1.Checked = True
                End If
            ElseIf MenuName Is .mnRequestOrder Then
                If Application.OpenForms().OfType(Of frmRO).Any Then
                    'MsgBox("Menu Request Order Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmRO.Activate()
                Else
                    frmRO.Show()
                    'frmRO.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnPurchaseOrder Then
                If Application.OpenForms().OfType(Of frmpo).Any Then
                    'MsgBox("Menu Purchase Order Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmpo.Activate()
                Else
                    frmpo.Show()
                    'frmpo.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnReceivedItem Then
                If Application.OpenForms().OfType(Of frmRecOrder).Any Then
                    'MsgBox("Menu Penerimaan Barang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmRecOrder.Activate()
                Else
                    frmRecOrder.Show()
                    'frmRecOrder.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnPurchaseInvoice Then
                If Application.OpenForms().OfType(Of frmpurchase).Any Then
                    'MsgBox("Menu Purchase Invoice Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmpurchase.Activate()
                Else
                    frmpurchase.Show()
                    'frmpurchase.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnPurchaseReturn Then
                If Application.OpenForms().OfType(Of frmpurc_return).Any Then
                    'MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmpurc_return.Activate()
                Else
                    frmpurc_return.Show()
                    'frmpurc_return.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnDebitNotes Then
                If Application.OpenForms().OfType(Of frmpurc_return).Any Then
                    'MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                Else
                End If
            ElseIf MenuName Is .mnAPPayment Then
                If Application.OpenForms().OfType(Of frmpayAP).Any Then
                    'MsgBox("Menu Pembayaran Hutang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmpayAP.Activate()
                Else
                    frmpayAP.Show()
                    'frmpayAP.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnAPStatus Then
                If Application.OpenForms().OfType(Of frmAPList).Any Then
                    'MsgBox("Menu Status Hutang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmAPList.Activate()
                Else
                    frmAPList.Show()
                    'frmAPList.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnAPAge Then
                If Application.OpenForms().OfType(Of FormReportPurch).Any Then
                    '   MsgBox("Menu Laporan Hutang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportPurch.Activate()
                    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage2
                    FormReportPurch.rb_ap1.Checked = True
                Else
                    'Dim Rpt As New FormReportPurch
                    FormReportPurch.Show()
                    'Rpt.MdiParent = MainMenu
                    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage2
                    FormReportPurch.rb_ap1.Checked = True
                End If
            ElseIf MenuName Is .mnPurchStdReport Then
                If Application.OpenForms().OfType(Of FormReportPurch).Any Then
                    '    MsgBox("Menu Laporan Pembelian Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportPurch.Activate()
                Else
                    'Dim Rpt As New FormReportPurch
                    FormReportPurch.Show()
                    'Rpt.MdiParent = MainMenu
                    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage1
                    FormReportPurch.rb_purch1.Checked = True
                End If
            ElseIf MenuName Is .mnPurchAnalystReport Then

            ElseIf MenuName Is .mnSalesOrder Then
                If Application.OpenForms().OfType(Of frmso).Any Then
                    '   MsgBox("Menu Sales Order Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmso.Activate()
                Else
                    frmso.Show()
                    'frmso.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnSuratJalan Then
                If Application.OpenForms().OfType(Of frmDeliveredItem).Any Then
                    '  MsgBox("Menu Delivered Item Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmDeliveredItem.Activate()
                Else
                    frmDeliveredItem.Show()
                    'frmDeliveredItem.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnSalesInvoice Then
                If Application.OpenForms().OfType(Of frmsales).Any Then
                    ' MsgBox("Menu Penjualan Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmsales.Activate()
                Else
                    frmsales.Show()
                    'frmsales.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnSalesReturn Then
                If Application.OpenForms().OfType(Of frmcashier).Any Then
                    'MsgBox("Menu Rertur Penjualan Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmsalesreturn.Activate()
                Else
                    frmsalesreturn.Show()
                    'frmsalesreturn.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnARPayment Then
                If Application.OpenForms().OfType(Of frmpayAR).Any Then
                    ' MsgBox("Menu Pembayaran Piutang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmpayAR.Activate()
                Else
                    frmpayAR.Show()
                    'frmpayAR.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnARStatus Then
                If Application.OpenForms().OfType(Of frmARList).Any Then
                    ' MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmARList.Activate()
                Else
                    frmARList.Show()
                    'frmARList.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnARAge Then
                If Application.OpenForms().OfType(Of FormReportSales).Any Then
                    ' MsgBox("Menu Laporan Piutang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportSales.Activate()
                Else
                    'Dim Rpt As New FormReportSales
                    FormReportSales.Show()
                    'Rpt.MdiParent = MainMenu
                    FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage2
                    FormReportSales.rb_ap1.Checked = True
                End If
            ElseIf MenuName Is .mnSalesStdReport Then
                If Application.OpenForms().OfType(Of FormReportSales).Any Then
                    ' MsgBox("Menu Laporan Penjualan Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportSales.Activate()
                Else
                    ' Dim Rpt As New FormReportSales
                    FormReportSales.Show()
                    '
                    'Rpt.MdiParent = MainMenu
                    FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage1
                    FormReportSales.rb_purch1.Checked = True
                End If
            ElseIf MenuName Is .mnServiceMutation Then
                If Application.OpenForms().OfType(Of FormReportSales2).Any Then
                    'MsgBox("Menu Laporan Mutasi Kasir Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportSales2.Activate()
                Else
                    'Dim Rpt As New FormReportSales2
                    FormReportSales2.Show()
                    'Rpt.MdiParent = MainMenu
                    FormReportSales2.TabControl1.SelectedTabPage = FormReportSales2.TabPage1
                    FormReportSales2.rb_purch9.Checked = True
                End If
            ElseIf MenuName Is .mnReceivedMoney Then
                If Application.OpenForms().OfType(Of frmreceiptmoney).Any Then
                    ' MsgBox("Menu Penerimaan Uang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmreceiptmoney.Activate()
                Else
                    frmreceiptmoney.Show()
                    'frmreceiptmoney.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnSpendMoney Then
                If Application.OpenForms().OfType(Of frmspendmoney).Any Then
                    ' MsgBox("Menu Pengeluaran Uang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmspendmoney.Activate()
                Else
                    frmspendmoney.Show()
                    'frmspendmoney.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnCashBankReg Then
                If Application.OpenForms().OfType(Of frmcashregister).Any Then
                    ' MsgBox("Menu Kas/Bank Register Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmcashregister.Activate()
                Else
                    frmcashregister.Show()
                    'frmcashregister.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnBankReconcile Then
                If Application.OpenForms().OfType(Of frmreconcile).Any Then
                    ' MsgBox("Menu Rekonsiliasi Bank Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmreconcile.Activate()
                Else
                    frmreconcile.Show()
                    'frmreconcile.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnCashBankHistReport Then
                If Application.OpenForms().OfType(Of FormReportCash).Any Then
                    ' MsgBox("Menu History Cash Bank Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportCash.Activate()
                Else
                    'Dim Rpt As New FormReportCash
                    FormReportCash.Show()
                    'Rpt.MdiParent = MainMenu
                    FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage1
                    FormReportCash.rb_purch1.Checked = True
                End If
            ElseIf MenuName Is .mnCashRecapReport Then
                If Application.OpenForms().OfType(Of FormReportCash).Any Then
                    'MsgBox("Menu Rekap Kas/Bank Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportCash.Activate()
                Else
                    'Dim Rpt As New FormReportCash
                    FormReportCash.Show()
                    'Rpt.MdiParent = MainMenu
                    FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage2
                    FormReportCash.rb_ap1.Checked = True
                End If
            ElseIf MenuName Is .mnCOA Then
                If Application.OpenForms().OfType(Of frmcoa).Any Then
                    'MsgBox("Menu COA Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmcoa.Activate()
                Else
                    frmcoa.Show()
                    'frmcoa.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnCashBank_set Then
                If Application.OpenForms().OfType(Of frmsetupcashbank).Any Then
                    'MsgBox("Menu Setup Kas Bank Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmsetupcashbank.Activate()
                Else
                    frmsetupcashbank.Show()
                    '  frmsetupcashbank.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnJournal Then
                If Application.OpenForms().OfType(Of frmjournal).Any Then
                    'MsgBox("Menu Jurnal Umum Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmjournal.Activate()

                Else
                    frmjournal.Show()
                    'frmjournal.MdiParent = MainMenu
                End If

            ElseIf MenuName Is .mnLedger Then
                If Application.OpenForms().OfType(Of frmledger).Any Then
                    'MsgBox("Menu Ledger Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmledger.Activate()
                Else
                    frmledger.Show()
                    ' frmledger.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnStdAccReport Then
                If Application.OpenForms().OfType(Of FormReportAcc).Any Then
                    'MsgBox("Menu Laporan Akuntansi Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportAcc.Activate()
                Else
                    ' Dim Rpt As New FormReportAcc
                    FormReportAcc.Show()
                    'Rpt.MdiParent = MainMenu
                    FormReportAcc.TabControl1.SelectedTabPage = FormReportAcc.TabPage1
                    FormReportAcc.rb_purch1.Checked = True
                End If
            ElseIf MenuName Is .mnFinAnalystReport Then
                If Application.OpenForms().OfType(Of FormReportAcc).Any Then
                    'MsgBox("Menu Laporan Analisa Keuangan Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportAcc.Activate()
                Else
                    'Dim Rpt As New FormReportAcc
                    FormReportAcc.Show()
                    'Rpt.MdiParent = MainMenu
                    ' Rpt.TabControl1.SelectedTab = Rpt.TabPage2
                    ' Rpt.rb_ap1.Checked = True
                End If
            ElseIf MenuName Is .mnBckup Then
                If Application.OpenForms().OfType(Of backup).Any Then
                    'MsgBox("Menu Backup Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    backup.Activate()
                Else
                    backup.Show()
                    'Rpt.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnRestore Then
                If Application.OpenForms().OfType(Of Restore).Any Then
                    'MsgBox("Menu Restore Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    restore.Activate()
                Else
                    restore.Show()
                    'Rpt.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnLog Then

           
            ElseIf MenuName Is .mnCardList Then
                'If Application.OpenForms().OfType(Of frmlistcard).Any Then
                '    'MsgBox("Menu Data Master Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                '    '    frmlistcard.Activate()
                'Else
                '    '     frmlistcard.Show()
                '    'frmlistcard.MdiParent = MainMenu
                'End If
            ElseIf MenuName Is .mnReparasi Then
                'If Application.OpenForms().OfType(Of frmsalonservice).Any Then
                '    'MsgBox("Menu Reparasi Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                '    frmsalonservice.Activate()
                'Else
                '    frmsalonservice.Show()
                '    'frmsalonservice.MdiParent = MainMenu
                'End If
            ElseIf MenuName Is .mnLapDataMaster Then
                If Application.OpenForms().OfType(Of FormReportMaster).Any Then
                    'MsgBox("Menu Laporan Data Master Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportMaster.Activate()
                Else
                    FormReportMaster.Show()
                    'FormReportMaster.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnManageUser Then
                If Application.OpenForms().OfType(Of UserRight).Any Then
                    'MsgBox("Menu Manajemen User Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    UserRight.Activate()
                Else
                    UserRight.Show()
                    'UserRight.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnCashier Then
                If Application.OpenForms().OfType(Of frmcashier).Any Then
                    'MsgBox("Menu Kasir Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmcashier.Activate()
                Else
                    frmcashier.Show()
                    'frmcashier.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnCashierReport Then
                If Application.OpenForms().OfType(Of frmcashierregister).Any Then
                    'MsgBox("Menu Kasir Register Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmcashierregister.Activate()
                Else
                    frmcashierregister.Show()
                    'frmcashierregister.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnLog Then
                If Application.OpenForms().OfType(Of frmlog).Any Then
                    'MsgBox("Menu Log User Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmlog.Activate()
                Else
                    frmlog.Show()
                    'frmlog.MdiParent = MainMenu
                End If
            ElseIf MenuName Is .mnExit Then
                Dim pesan As String
                pesan = MsgBox("Logout Aplikasi?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    MainMenu.Close()
                    close_conn()
                    With LoginFormSambung
                        .Show()
                        .txt_user.Text = ""
                        .txt_password.Text = ""
                        .txt_user.Focus()
                    End With
                End If
            End If
        End With

    End Sub
   
End Module
