Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports System.IO
Imports DevExpress.XtraBars.Alerter

Public Class MainMenu
    'Dim WithEvents Workspace As XtremeCommandBars.TabWorkspace
    'Dim Pane As StatusBarPane
    'Dim statusBar As XtremeCommandBars.StatusBar

    Const LocationReg = "System\Windows\User" 'lokasi penyimpanan d registry (ubah sesuai selera)
    Const PasswordReg = "lbv1yolk" 'kode kunci registrasi
    Function GetInfoReg() As String 'fungsi utk mendapatkan info registrasi
        Dim Reg = CreateObject("WScript.Shell")
        Try
            GetInfoReg = Reg.RegRead("HKEY_CLASSES_ROOT\" & LocationReg & "\")
        Catch
            Reg.RegWrite("HKEY_CLASSES_ROOT\" & LocationReg & "\", Now.Date) 'memasukkan tgl sekarang
            GetInfoReg = Now.Date
        End Try
    End Function
    Function SuccessReg() As Boolean 'fungsi utk prosedur pemasukan kode registrasi
        Dim s As String
Lagi:
        s = InputBox("FillErrorEventArgs Activated Code", "Registrasi")
        If s = PasswordReg Then
            Dim Reg = CreateObject("WScript.Shell")
            Reg.RegWrite("HKEY_CLASSES_ROOT\" & LocationReg & "\", "Registered") 'mendaftarkan k registry
            Dim info As AlertInfo = New AlertInfo("Registrai Success", "Thank You to register")
            alertControl_success.Show(Me, info)
            SuccessReg = True

        ElseIf s = "" Then
            SuccessReg = False

        Else
            If MsgBox("Your Activated Code is not valid?", vbYesNo + vbExclamation, "Registrasi") = vbYes Then GoTo Lagi
            SuccessReg = False
        End If
    End Function


    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        Dim ChildForm As New System.Windows.Forms.Form
        ' ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        ChildForm.Show()
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private m_ChildFormNumber As Integer

    Dim ex As System.Windows.Forms.KeyPressEventArgs

    Private Sub MainMenu_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
            activated_existing_form()
        Start.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MainMenu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub MainMenu_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            'Dim timer As New Timer
            'timer.Interval = 1000
            'timer.Start()
            'AddHandler timer.Tick, AddressOf Timer_Tick
            If LCase(username) = "admin" Then
                lbl_user_aktif.Text = UCase(username)
                lbl_position.Text = "Administrator"
            ElseIf LCase(username) = "creator" Then
                lbl_user_aktif.Text = UCase(username)
                lbl_position.Text = "Vendor Administrator"
            Else
                lbl_user_aktif.Text = UCase(username)
                lbl_position.Text = get_user_position(username)
            End If
            Me.Text = "SMART ACCOUNTING SOFTWARE"
            'LoginForm.Show()
            'LoginForm.MdiParent = Me
            'LoginForm.Activate()

            'LoginForm.txt_server.Text = "localhost"
            'LoginForm.txt_user.Text = "admin"
            'LoginForm.txt_password.Text = "admin"
            'LoginForm.KeyPress_Login(sender, ex)


            'MenuClosed()

            FormLayout()
            var_blue = 247
            var_grey = 228
            var_red = 215

            Dim form1 As New FrmCommandPanel
            form1.Show()
            form1.MdiParent = Me
            form1.WindowState = FormWindowState.Maximized


            ' MenuOpened()
            'server_date = server_datetime()


            ' CreateRibbonBar()
            ' load_icon()
            Call default_io()

            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Me.WindowState = FormWindowState.Maximized
            Me.ControlBox = False
            'LoginForm.Hide()
            Me.NavBar_Menu.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            row_trial = 20
            trial = False
            Call notification()
            Dim DT As New DataTable
            If LCase(username) <> "creator" Then
                view_privilege(username)
                DT = select_path_userimg(username)
            Else
                view_privilege_vendorcreator(username)
                DT = select_path_userimg("admin")
            End If
            
            If LCase(username) <> "admin" And LCase(username) <> "creator" Then
                If DT.Rows(0).Item("photo").ToString = "" Then
                    PictureBox2.Image = Image.FromFile(Application.StartupPath & "\photo\no-image.jpg")
                Else
                    If System.IO.File.Exists(Replace(DT.Rows(0).Item("photo").ToString, "\", "/")) Then
                        Using fs As New FileStream(Replace(DT.Rows(0).Item("photo").ToString, "\", "/"), FileMode.Open, FileAccess.Read)
                            PictureBox2.Image = Image.FromStream(fs)
                        End Using
                    Else
                        PictureBox2.Image = Image.FromFile(Application.StartupPath & "\photo\no-image.jpg")
                    End If
                End If
            Else

            End If

        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick

        FrmCommandPanel.lbl_date.Text = Format(server_datetime(), "dd-MM-yyyy")
        FrmCommandPanel.lbl_time.Text = FormatDateTime(server_datetime(), DateFormat.ShortTime)


    End Sub
    'Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnLogin.Click
    '    LoginForm.Show()
    '    LoginForm.MdiParent = Me
    '    LoginForm.Activate()
    'End Sub

    Private Sub mnMasterCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnMasterCust.Click
        Call AksesToolstripMenu(mnMasterCust)
    End Sub

    Private Sub menuMasterSupp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterSupp.Click
        Call AksesToolstripMenu(menuMasterSupp)
    End Sub

    Private Sub menuMasterMktg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuMasterMktg.Click
        Call AksesToolstripMenu(menuMasterMktg)
    End Sub

    Private Sub mnItemCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnItemCat.Click
        Call AksesToolstripMenu(mnItemCat)
    End Sub

    Private Sub mnItemBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnItemBrand.Click
        Call AksesToolstripMenu(mnItemBrand)
    End Sub

    Private Sub mnMasterItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnMasterItem.Click
        Call AksesToolstripMenu(mnMasterItem)
    End Sub

    Private Sub mnStockAwal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnStockAwal.Click
        Call AksesToolstripMenu(mnStockAwal)
    End Sub

    Private Sub mnMasterService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnMasterService.Click
        Call AksesToolstripMenu(mnMasterService)
    End Sub

    Private Sub mnUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnUnit.Click
        Call AksesToolstripMenu(mnUnit)
    End Sub

    Private Sub mnUnitConvers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnUnitConvers.Click
        Call AksesToolstripMenu(mnUnitConvers)
    End Sub

    Private Sub mnWH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnWH.Click
        Call AksesToolstripMenu(mnWH)
    End Sub

    Private Sub mnCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCurrency.Click
        Call AksesToolstripMenu(mnCurrency)
    End Sub

    Private Sub mnConvertCurr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnConvertCurr.Click
        Call AksesToolstripMenu(mnConvertCurr)
    End Sub

    Private Sub mnStockOpname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnStockOpname.Click
        Call AksesToolstripMenu(mnStockOpname)
    End Sub

    Private Sub mnStockCorrection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnStockCorrection.Click
        Call AksesToolstripMenu(mnStockCorrection)
    End Sub

    Private Sub mnItemTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnItemTransfer.Click
        Call AksesToolstripMenu(mnItemTransfer)
    End Sub

    Private Sub mnItemList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnItemList.Click
        Call AksesToolstripMenu(mnItemList)
    End Sub

    Private Sub mnStockReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnStockReport.Click
        Call AksesToolstripMenu(mnStockReport)
    End Sub

    Private Sub mnRequestOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnRequestOrder.Click
        Call AksesToolstripMenu(mnRequestOrder)
    End Sub

    Private Sub mnPurchaseOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnPurchaseOrder.Click
        Call AksesToolstripMenu(mnPurchaseOrder)
    End Sub

    Private Sub mnReceivedItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnReceivedItem.Click
        Call AksesToolstripMenu(mnReceivedItem)
    End Sub

    Private Sub mnPurchaseInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnPurchaseInvoice.Click
        Call AksesToolstripMenu(mnPurchaseInvoice)
    End Sub

    Private Sub mnPurchaseReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnPurchaseReturn.Click
        Call AksesToolstripMenu(mnPurchaseReturn)
    End Sub

    Private Sub mnDebitNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDebitNotes.Click
        Call AksesToolstripMenu(mnDebitNotes)
    End Sub

    Private Sub mnAPPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAPPayment.Click
        Call AksesToolstripMenu(mnAPPayment)
    End Sub

    Private Sub mnAPStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAPStatus.Click
        Call AksesToolstripMenu(mnAPStatus)
    End Sub

    Private Sub mnAPAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call AksesToolstripMenu(mnAPAge)
    End Sub

    Private Sub mnPurchStdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnPurchStdReport.Click
        Call AksesToolstripMenu(mnPurchStdReport)
    End Sub

    Private Sub mnPurchAnalystReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnPurchAnalystReport.Click
        Call AksesToolstripMenu(mnPurchAnalystReport)
    End Sub

    Private Sub mnSalesOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSalesOrder.Click
        Call AksesToolstripMenu(mnSalesOrder)
    End Sub

    Private Sub mnSalesInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSalesInvoice.Click
        Call AksesToolstripMenu(mnSalesInvoice)
    End Sub

    Private Sub mnSalesReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSalesReturn.Click
        Call AksesToolstripMenu(mnSalesReturn)
    End Sub

    Private Sub mnCreditNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCreditNotes.Click
        Call AksesToolstripMenu(mnCreditNotes)
    End Sub

    Private Sub mnARPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnARPayment.Click
        Call AksesToolstripMenu(mnARPayment)
    End Sub

    Private Sub mnARStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnARStatus.Click
        Call AksesToolstripMenu(mnARStatus)
    End Sub

    Private Sub mnARAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnARAge.Click
        Call AksesToolstripMenu(mnARAge)
    End Sub

    Private Sub mnSalesStdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSalesStdReport.Click
        Call AksesToolstripMenu(mnSalesStdReport)
    End Sub

    Private Sub mnSalesAnalystReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSalesAnalystReport.Click
        Call AksesToolstripMenu(mnSalesAnalystReport)
    End Sub

    Private Sub mnReceivedMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnReceivedMoney.Click
        Call AksesToolstripMenu(mnReceivedMoney)
    End Sub

    Private Sub mnSpendMoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSpendMoney.Click
        Call AksesToolstripMenu(mnSpendMoney)
    End Sub

    Private Sub mnCashBankReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCashBankReg.Click
        Call AksesToolstripMenu(mnCashBankReg)
    End Sub

    Private Sub mnBankReconcile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnBankReconcile.Click
        Call AksesToolstripMenu(mnBankReconcile)
    End Sub

    Private Sub mnCashBankHistReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCashBankHistReport.Click
        Call AksesToolstripMenu(mnCashBankHistReport)
    End Sub

    Private Sub mnCashRecapReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCashRecapReport.Click
        Call AksesToolstripMenu(mnCashRecapReport)
    End Sub

    Private Sub mnCOA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCOA.Click
        Call AksesToolstripMenu(mnCOA)
    End Sub

    Private Sub mnJournal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnJournal.Click
        Call AksesToolstripMenu(mnJournal)
    End Sub

    Private Sub mnJournalList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnJournalList.Click
        Call AksesToolstripMenu(mnJournalList)
    End Sub

    Private Sub mnLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnLedger.Click
        Call AksesToolstripMenu(mnLedger)
    End Sub

    Private Sub mnStdAccReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnStdAccReport.Click
        Call AksesToolstripMenu(mnStdAccReport)
    End Sub

    Private Sub mnFinAnalystReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnFinAnalystReport.Click
        Call AksesToolstripMenu(mnFinAnalystReport)
    End Sub

    Private Sub mnBckup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnBckup.Click
        Call AksesToolstripMenu(mnBckup)
    End Sub

    Private Sub mnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnRestore.Click
        Call AksesToolstripMenu(mnRestore)
    End Sub

    Private Sub mnLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnLog.Click
        Call AksesToolstripMenu(mnLog)
    End Sub



    Private Sub mnItemJenis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnItemJenis.Click
        Call AksesToolstripMenu(mnItemJenis)
    End Sub

    Private Sub mnCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCompany.Click
        Call AksesToolstripMenu(mnCompany)
    End Sub

    Private Sub mnSalesReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSalesReport.Click

    End Sub

    Private Sub DaftarMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCardList.Click
        Call AksesToolstripMenu(mnCardList)
    End Sub

    Private Sub ReparasiPerhiasanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnReparasi.Click
        Call AksesToolstripMenu(mnReparasi)
    End Sub

    Private Sub LaporanDataMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnLapDataMaster.Click
        Call AksesToolstripMenu(mnLapDataMaster)
    End Sub

    Private Sub mnAPAge_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAPAge.Click
        Call AksesToolstripMenu(mnAPAge)
    End Sub


    Private Sub NavBarGroupControlContainer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CustomizationControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnApprovalPermintaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnApprovalPermintaan.Click
        Call AksesToolstripMenu(mnApprovalPermintaan)
    End Sub

    Private Sub mnCashRO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCashRO.Click
        Call AksesToolstripMenu(mnCashRO)
    End Sub

    Private Sub mnApprovalCashRO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnApprovalCashRO.Click
        Call AksesToolstripMenu(mnApprovalCashRO)
    End Sub

    Private Sub mnCashInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCashInvoice.Click
        Call AksesToolstripMenu(mnCashInvoice)
    End Sub

    Private Sub mnCashReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCashReturn.Click
        Call AksesToolstripMenu(mnCashReturn)
    End Sub

    Private Sub mnSuratJalan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSuratJalan.Click
        Call AksesToolstripMenu(mnSuratJalan)
    End Sub

    Private Sub mnCashier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCashier.Click
        Call AksesToolstripMenu(mnCashier)
    End Sub

    Private Sub mnCashierReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCashierReport.Click
        Call AksesToolstripMenu(mnCashierReport)
    End Sub

    'Dim TabMaster As RibbonTab
    'Dim GroupMaster As RibbonGroup
    'Private Sub CreateRibbonBar()

    '    Dim RibbonBar As RibbonBar
    '    RibbonBar = CommandBars.AddRibbonBar("The Ribbon")

    '    RibbonBar.Minimized = True
    '    RibbonBar.AllowMinimize = True
    '    'RibbonBar.DefaultButtonStyle = XTPButtonStyle.xtpButtonIconAndCaptionBelo
    '    RibbonBar.GroupsHeight = 100
    '    RibbonBar.AllowQuickAccessCustomization = False
    '    RibbonBar.ShowQuickAccess = False

    '    If getTemplateAkses(username, "MN_CARDFILE") = True Then
    '        TabMaster = RibbonBar.InsertTab(1, "DATA MASTER")
    '        TabMaster.Id = ID_TAB_MASTER
    '    End If
    '    If getTemplateAkses(username, "MN_CUSTOMER") = True Or getTemplateAkses(username, "MN_SUPPLIER") = True Or getTemplateAkses(username, "MN_EMPLOYEE") = True Or getTemplateAkses(username, "MN_CARD_LIST") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("CARD FILE MASTER", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_CUSTOMER") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_MASTERCUSTOMER, "Pelanggan", False, False)
    '    If getTemplateAkses(username, "MN_SUPPLIER") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_MASTERSUPPLIER, "Pemasok", False, False)
    '    If getTemplateAkses(username, "MN_EMPLOYEE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_MASTEREMPLOYEE, "Pegawai", False, False)
    '    If getTemplateAkses(username, "MN_CARD_LIST") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_MASTERCARDLIST, "Daftar", False, False)
    '    If getTemplateAkses(username, "MN_ITEM_TYPE") = True Or getTemplateAkses(username, "MN_ITEM_CAT") = True Or getTemplateAkses(username, "MN_ITEM_NAME") = True Or getTemplateAkses(username, "MN_BEGINING_BALANCE") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("DATA ITEM", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_ITEM_TYPE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_ITEM_TYPE, "Jenis Item", False, False)
    '    If getTemplateAkses(username, "MN_ITEM_CAT") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_ITEM_CAT, "Kategori Item", False, False)
    '    If getTemplateAkses(username, "MN_ITEM_BRAND") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_ITEM_BRAND, "Merek Item", False, False)
    '    If getTemplateAkses(username, "MN_ITEM_NAME") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_ITEM_NAME, "Item", False, False)
    '    If getTemplateAkses(username, "MN_BEGINING_BALANCE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_ITEMBEGINING_BALANCE, "Saldo Awal Item", False, False)
    '    If getTemplateAkses(username, "MN_JENIS_JASA") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("DATA JASA", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_JENIS_JASA") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_SERVICE, "Jenis Jasa", False, False)
    '    If getTemplateAkses(username, "MN_UNIT") = True Or getTemplateAkses(username, "MN_UNIT_CONVERSION") = True Or getTemplateAkses(username, "MN_WAREHOUSE") = True Or getTemplateAkses(username, "MN_EXPEDITION") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("UNIT DAN GUDANG", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_UNIT") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_UNIT, "Unit", False, False)
    '    If getTemplateAkses(username, "MN_UNIT_CONVERSION") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_UNIT_CONVERSION, "Konversi Unit", False, False)
    '    If getTemplateAkses(username, "MN_WAREHOUSE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_WAREHOUSE, "Gudang", False, False)
    '    If getTemplateAkses(username, "MN_EXPEDITION") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_EXPEDITION, "Expedisi dan Tarif", False, False)
    '    If getTemplateAkses(username, "MN_CURRENCY") = True Or getTemplateAkses(username, "MN_CURRENCY_CONVERSION") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("MATA UANG", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_CURRENCY") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CURRENCY, "Mata Uang", False, False)
    '    If getTemplateAkses(username, "MN_CURRENCY_CONVERSION") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CURRENCY_CONVERT, "Konversi Mata Uang", False, False)
    '    If getTemplateAkses(username, "MN_CARD_FILE_REPORT") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("LAPORAN", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_CARD_FILE_REPORT") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CARD_FILE_REPORT, "Laporan Data Master", False, False)

    '    If getTemplateAkses(username, "MN_STOCK") = True Then
    '        TabMaster = RibbonBar.InsertTab(2, "STOK ITEM")
    '        TabMaster.Id = ID_TAB_MASTER
    '    End If
    '    If getTemplateAkses(username, "MN_STOCK_OPNAME") = True Or getTemplateAkses(username, "MN_STOCK_CORRECTION") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("STOK OPNAME", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_STOCK_OPNAME") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_STOCK_OPNAME, "Stok Opname", False, False)
    '    If getTemplateAkses(username, "MN_STOCK_CORRECTION") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_STOCK_CORRECTION, "Koreksi Stok", False, False)
    '    If getTemplateAkses(username, "MN_MOVE_ITEM") = True Or getTemplateAkses(username, "MN_ITEM_LIST") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("ITEM TRANSACTION", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_MOVE_ITEM") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_MOVE_ITEM, "Pindah Gudang", False, False)
    '    If getTemplateAkses(username, "MN_ITEM_LIST") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_ITEM_LIST, "Daftar Item", False, False)
    '    If getTemplateAkses(username, "MN_LAPORAN_STOCK") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("LAPORAN", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_LAPORAN_STOCK") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_LAPORAN_STOCK, "Laporan Stok", False, False)


    '    If getTemplateAkses(username, "MN_PURCHASE") = True Then
    '        TabMaster = RibbonBar.InsertTab(3, "PEMBELIAN")
    '        TabMaster.Id = ID_TAB_MASTER
    '    End If
    '    If getTemplateAkses(username, "MN_RO") = True Or getTemplateAkses(username, "MN_APPROVAL_RO") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("REQUISITION", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_RO") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_RO, "Permintaan Pembelian", False, False)
    '    If getTemplateAkses(username, "MN_APPROVAL_RO") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_APP_RO, "Approval Permintaan", False, False)
    '    If getTemplateAkses(username, "MN_PO") = True Or getTemplateAkses(username, "MN_RECEIVED_ORDER") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("PURCHASE ORDER", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_PO") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_PO, "Purchase Order", False, False)
    '    If getTemplateAkses(username, "MN_RECEIVED_ORDER") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_RECEIVED_ORDER, "Penerimaan Barang", False, False)
    '    If getTemplateAkses(username, "MN_PURCHASE_INV") = True Or getTemplateAkses(username, "MN_PURCHASE_RETURN") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("FAKTUR", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_PURCHASE_INV") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_PURCHASE_INV, "Faktur Beli", False, False)
    '    If getTemplateAkses(username, "MN_PURCHASE_RETURN") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_PURCHASE_RETURN, "Retur Beli", False, False)
    '    If getTemplateAkses(username, "MN_PEMBAYARAN_HUTANG") = True Or getTemplateAkses(username, "MN_STATUS_HUTANG") = True Or getTemplateAkses(username, "MN_AP_INITBALANCE") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("MANAJEMEN HUTANG", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_AP_INITBALANCE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_AP_INITBALANCE, "Saldo Awal Hutang", False, False)
    '    If getTemplateAkses(username, "MN_PEMBAYARAN_HUTANG") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_PEMBAYARAN_HUTANG, "Pembayaran Hutang", False, False)
    '    If getTemplateAkses(username, "MN_STATUS_HUTANG") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_AP_STATUS, "Status Hutang", False, False)
    '    If getTemplateAkses(username, "MN_PURCHASE_REPORT") = True Or getTemplateAkses(username, "MN_AP_REPORT") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("LAPORAN", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_PURCHASE_REPORT") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_PURCHASE_REPORT, "Laporan Pembelian", False, False)
    '    If getTemplateAkses(username, "MN_AP_REPORT") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_AP_REPORT, "Laporan Hutang", False, False)

    '    'TabMaster = RibbonBar.InsertTab(4, "CASH PURCHASE")
    '    'TabMaster.Id = ID_TAB_MASTER
    '    'GroupMaster = TabMaster.Groups.AddGroup("REQUEST ORDER", ID_GROUP_MASTER)
    '    'If getTemplateAkses(username, "MN_CASH_RO") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CASH_RO, "Request Order", False, False)
    '    'If getTemplateAkses(username, "MN_CASH_APP_PURCHASE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CASH_APP_RO, "Approval RO", False, False)
    '    'GroupMaster = TabMaster.Groups.AddGroup("PURCHASE", ID_GROUP_MASTER)
    '    'If getTemplateAkses(username, "MN_CASH_PURCHASE_INVOICE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CASH_PURCHASE_INV, "Purchase Invoice", False, False)
    '    'If getTemplateAkses(username, "MN_CASH_PURCHASE_RETURN") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CASH_PURCHASE_RETURN, "Purchase Return", False, False)

    '    If getTemplateAkses(username, "MN_SALES") = True Then
    '        TabMaster = RibbonBar.InsertTab(5, "PENJUALAN")
    '        TabMaster.Id = ID_TAB_MASTER
    '    End If
    '    If getTemplateAkses(username, "MN_SO") = True Or getTemplateAkses(username, "MN_DELIVERED_ITEM") = True Or getTemplateAkses(username, "MN_SET_MARKETING") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("SALES ORDER", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_SET_MARKETING") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_SET_MARKETING, "Marketing", False, False)
    '    If getTemplateAkses(username, "MN_SO") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_SO, "Sales Order", False, False)
    '    If getTemplateAkses(username, "MN_DELIVERED_ITEM") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_DO, "Pengiriman Barang", False, False)
    '    If getTemplateAkses(username, "MN_SALES_INV") = True Or getTemplateAkses(username, "MN_SALES_RETURN") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("FAKTUR & RETUR", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_SALES_INV") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_SALES_INV, "Faktur Jual", False, False)
    '    If getTemplateAkses(username, "MN_SALES_RETURN") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_SALES_RETURN, "Retur Jual", False, False)
    '    If getTemplateAkses(username, "MN_PAYMENT_AR") = True Or getTemplateAkses(username, "MN_AR_STATUS") = True Or getTemplateAkses(username, "MN_AR_INITBALANCE") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("MANAJEMEN PIUTANG", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_AR_INITBALANCE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_AR_INITBALANCE, "Saldo Awal Piutang", False, False)
    '    If getTemplateAkses(username, "MN_PAYMENT_AR") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_PAYMENT_AR, "Pembayaran Piutang", False, False)
    '    If getTemplateAkses(username, "MN_AR_STATUS") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_AR_STATUS, "Status Piutang", False, False)
    '    If getTemplateAkses(username, "MN_LAPORAN_JUAL") = True Or getTemplateAkses(username, "MN_LAPORAN_PIUTANG") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("LAPORAN", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_LAPORAN_JUAL") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_LAPORAN_JUAL, "Sales Report", False, False)
    '    If getTemplateAkses(username, "MN_LAPORAN_PIUTANG") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_LAPORAN_PIUTANG, "AR Report", False, False)

    '    If getTemplateAkses(username, "MN_OUTLET_SALES") = True Then
    '        TabMaster = RibbonBar.InsertTab(6, "KASIR")
    '        TabMaster.Id = ID_TAB_MASTER
    '    End If
    '    If getTemplateAkses(username, "MN_CASHIER") = True Or getTemplateAkses(username, "MN_CASHIER_REGISTER") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("CASHIER OUTLET", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_CASHIER") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CASHIER, "Transaksi Kasir", False, False)
    '    If getTemplateAkses(username, "MN_CASHIER_REGISTER") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CASHIER_REGISTER, "Kasir Register", False, False)
    '    'If getTemplateAkses(username, "MN_SERVICE_TRANSACTION") = True Or getTemplateAkses(username, "MN_MUTASI_SERVICE") = True Then
    '    'GroupMaster = TabMaster.Groups.AddGroup("SERVICE OUTLET", ID_GROUP_MASTER)
    '    'End If
    '    'If getTemplateAkses(username, "MN_SERVICE_TRANSACTION") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_SERVICE_TRANSACTION, "Service Transaction", False, False)
    '    If getTemplateAkses(username, "MN_MUTASI_CASHIER") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_SERVICE_MUTATION, "Mutasi Kasir", False, False)
    '    If getTemplateAkses(username, "MN_CASHIER_RETURN") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CASHIER_RETURN, "Retur Kasir", False, False)

    '    If getTemplateAkses(username, "MN_CASH_BANK") = True Then
    '        TabMaster = RibbonBar.InsertTab(7, "KAS / BANK")
    '        TabMaster.Id = ID_TAB_MASTER
    '    End If
    '    If getTemplateAkses(username, "MN_RECEIPT_MONEY") = True Or getTemplateAkses(username, "MN_SPEND_MONEY") = True Or getTemplateAkses(username, "MN_BANK_RECONCILE") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("TRANSAKSI", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_RECEIPT_MONEY") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_RECEIPT_MONEY, "Penerimaan Umum", False, False)
    '    If getTemplateAkses(username, "MN_SPEND_MONEY") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_SPEND_MONEY, "Pengeluaran Umum", False, False)
    '    If getTemplateAkses(username, "MN_BANK_RECONCILE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_RECONCILE, "Rekonsiliasi Bank", False, False)
    '    If getTemplateAkses(username, "MN_CASHBANK_REGISTER") = True Or getTemplateAkses(username, "MN_CASHBANK_TRANS_REPORT") = True Or getTemplateAkses(username, "MN_CASHBANK_RECAP_REPORT") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("LAPORAN", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_CASHBANK_REGISTER") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CASH_REGISTER, "Kas / Bank Register", False, False)
    '    If getTemplateAkses(username, "MN_CASHBANK_TRANS_REPORT") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_TRANS_REPORT, "Laporan Transaksi", False, False)
    '    If getTemplateAkses(username, "MN_CASHBANK_RECAP_REPORT") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_RECAP_REPORT, "Laporan Rekapitulasi", False, False)

    '    If getTemplateAkses(username, "MN_ACCOUNT") = True Then
    '        TabMaster = RibbonBar.InsertTab(8, "AKUNTANSI")
    '        TabMaster.Id = ID_TAB_MASTER
    '    End If
    '    If getTemplateAkses(username, "MN_COA") = True Or getTemplateAkses(username, "MN_CASHBANK_SETUP") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("CHART OF ACCOUNT", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_COA") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_COA, "Chart Of Account", False, False)
    '    If getTemplateAkses(username, "MN_COA") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_COA_SETUP, "Setup Integrasi COA", False, False)
    '    If getTemplateAkses(username, "MN_CASHBANK_SETUP") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CASHBANK_SETUP, "Setup Kas / Bank", False, False)
    '    If getTemplateAkses(username, "MN_JOURNAL") = True Or getTemplateAkses(username, "MN_JOURNAL_LIST") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("JURNAL", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_JOURNAL") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_JOURNAL, "Journal Umum", False, False)
    '    If getTemplateAkses(username, "MN_JOURNAL_LIST") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_JOURNAL_LIST, "Daftar Journal", False, False)
    '    If getTemplateAkses(username, "MN_LEDGER") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("LEDGER & CLOSSING", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_CLOSE_PERIOD") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CLOSE_BOOK, "Tutup Periode Akuntansi", False, False)

    '    If getTemplateAkses(username, "MN_LEDGER") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_LEDGER, "Ledger", False, False)
    '    If getTemplateAkses(username, "MN_ACCOUNTING_REPORT") = True Or getTemplateAkses(username, "MN_ANALYST_REPORT") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("LAPORAN", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_ACCOUNTING_REPORT") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_ACC_REPORT, "Laporan Akuntansi", False, False)
    '    If getTemplateAkses(username, "MN_ANALYST_REPORT") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_FIN_REPORT, "Laporan Analisa", False, False)

    '    If getTemplateAkses(username, "MN_TOOLS") = True Then
    '        TabMaster = RibbonBar.InsertTab(9, "TOOLS")
    '        TabMaster.Id = ID_TAB_MASTER
    '    End If
    '    If getTemplateAkses(username, "MN_USERMANAGE") = True Or getTemplateAkses(username, "MN_BACKUP") = True Or getTemplateAkses(username, "MN_RESTORE") = True Or getTemplateAkses(username, "MN_LOG") = True Then
    '        GroupMaster = TabMaster.Groups.AddGroup("SETTING", ID_GROUP_MASTER)
    '    End If
    '    If getTemplateAkses(username, "MN_USERMANAGE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_USERRIGHT, "User Management", False, False)
    '    If getTemplateAkses(username, "MN_BACKUP") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_BACKUP, "Backup", False, False)
    '    If getTemplateAkses(username, "MN_RESTORE") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_RESTORE, "Restore", False, False)
    '    If getTemplateAkses(username, "MN_LOG") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_LOG, "Transaction Log", False, False)
    '    If getTemplateAkses(username, "MN_SET_PATH") = True Then GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_PATH, "Setup Image Directory", False, False)
    '    GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_CHANGE_PASSWORD, "Change Password", False, False)

    '    'logout
    '    TabMaster = RibbonBar.InsertTab(10, "EXIT")
    '    TabMaster.Id = ID_TAB_OUT
    '    GroupMaster = TabMaster.Groups.AddGroup("LOGOUT OR MINIMIZED", ID_GROUP_EXIT)
    '    GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_EXIT, "Log Out", False, False)
    '    GroupMaster.Add(XtremeCommandBars.XTPControlType.xtpControlButton, ID_MINIMIZED, "Minimized", False, False)


    '    Dim ctrl As Control
    '    For Each ctrl In Controls
    '        If (ctrl.GetType Is GetType(System.Windows.Forms.MdiClient)) Then
    '            CommandBars.SetMDIClient(ctrl.Handle.ToInt32)
    '        End If
    '    Next

    '    Workspace = CommandBars.ShowTabWorkspace(True)
    '    Workspace.EnableGroups()
    '    ' Workspace.ThemedBackColor = True
    '    CommandBars.EnableOffice2007Frame(False)
    '    RibbonBar.EnableFrameTheme()
    '    CommandBars.VisualTheme = XTPVisualTheme.xtpThemeVisualStudio2008

    '    'status bar
    '    CreateStatusBar()
    '    'CommandBars.StatusBar.Visible = True

    'End Sub

    'Private Sub CreateStatusBar()
    '    ' Set up the Statusbar Style

    '    StatusBar = CommandBars.StatusBar
    '    StatusBar.Visible = True
    '    StatusBar.RibbonDividerIndex = 2

    '    Pane = statusBar.AddPane(0)
    '    Pane.BeginGroup = True
    '    Pane.Button = False
    '    Pane.Text = "Ready"
    '    Pane.Width = 0
    '    Pane.Visible = True

    '    Pane = statusBar.AddPane(1)
    '    Pane.BeginGroup = True
    '    Pane.Button = False
    '    Pane.Text = UCase("Pi-Accounting Software - Copyright(c) ITPreneur Indonesia Technology")
    '    Pane.Width = 0
    '    Pane.Visible = True

    '    Pane = statusBar.AddPane(2)
    '    Pane.BeginGroup = True
    '    Pane.Button = False
    '    Pane.Text = UCase("Server Location: ") & UCase(server_temp)
    '    Pane.Width = 0
    '    Pane.Visible = True

    '    Pane = statusBar.AddPane(3)
    '    Pane.BeginGroup = True
    '    Pane.Button = False
    '    Pane.Text = UCase("User Aktif: ") & UCase(username)
    '    Pane.Width = 0
    '    Pane.Visible = True

    '    'Pane = statusBar.AddPane(4)
    '    'Pane.BeginGroup = True
    '    'Pane.Button = False
    '    'Pane.Text = UCase("Time Server: ") & lbl_date.Text & " " & lbl_time.Text
    '    'Pane.Width = 0
    '    'Pane.Visible = True

    '    MyStatusBar = StatusBar
    'End Sub

    'Private Sub load_icon()
    '    CommandBars.Options.UseSharedImageList = False
    '    RibbonBar.SetIconSize(16, 16)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\customer.png", New Object() {ID_MASTERCUSTOMER}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\supplier.png", New Object() {ID_MASTERSUPPLIER}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\pegawai.png", New Object() {ID_MASTEREMPLOYEE}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\cardlist.png", New Object() {ID_MASTERCARDLIST}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\item-type.png", New Object() {ID_ITEM_TYPE}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\item-cat.png", New Object() {ID_ITEM_CAT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\icon-brand.png", New Object() {ID_ITEM_BRAND}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\item-name.png", New Object() {ID_ITEM_NAME}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\item-beg-balance.png", New Object() {ID_ITEMBEGINING_BALANCE}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\unit.png", New Object() {ID_UNIT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\konversi-unit.png", New Object() {ID_UNIT_CONVERSION}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\gudang.png", New Object() {ID_WAREHOUSE}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\mata-uang.png", New Object() {ID_CURRENCY}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\konvert-matauang.png", New Object() {ID_CURRENCY_CONVERT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\card-filereport.png", New Object() {ID_CARD_FILE_REPORT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\do.png", New Object() {ID_EXPEDITION}, XtremeCommandBars.XTPImageState.xtpImageNormal)

    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\stock-opname.png", New Object() {ID_STOCK_OPNAME}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\stock-opname.png", New Object() {ID_STOCK_OPNAME}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\stock-correction.png", New Object() {ID_STOCK_CORRECTION}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\transferstock.png", New Object() {ID_MOVE_ITEM}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\item-list.png", New Object() {ID_ITEM_LIST}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\stock-report.png", New Object() {ID_LAPORAN_STOCK}, XtremeCommandBars.XTPImageState.xtpImageNormal)

    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\ro.png", New Object() {ID_RO}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\approval-ro.png", New Object() {ID_APP_RO}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\po.png", New Object() {ID_PO}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\received-order.png", New Object() {ID_RECEIVED_ORDER}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\invoice.png", New Object() {ID_PURCHASE_INV}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\return.png", New Object() {ID_PURCHASE_RETURN}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\payment.png", New Object() {ID_PEMBAYARAN_HUTANG}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\ap-status.png", New Object() {ID_AP_STATUS}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\purchase-report.png", New Object() {ID_PURCHASE_REPORT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\ap-report.png", New Object() {ID_AP_REPORT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\cost.png", New Object() {ID_AP_INITBALANCE}, XtremeCommandBars.XTPImageState.xtpImageNormal)

    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\ro.png", New Object() {ID_CASH_RO}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\approval-ro.png", New Object() {ID_CASH_APP_RO}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\invoice.png", New Object() {ID_CASH_PURCHASE_INV}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\return.png", New Object() {ID_CASH_PURCHASE_RETURN}, XtremeCommandBars.XTPImageState.xtpImageNormal)

    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\pegawai.png", New Object() {ID_SET_MARKETING}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\so.png", New Object() {ID_SO}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\do.png", New Object() {ID_DO}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\invoice.png", New Object() {ID_SALES_INV}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\return.png", New Object() {ID_SALES_RETURN}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\payment.png", New Object() {ID_PAYMENT_AR}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\ap-status.png", New Object() {ID_AR_STATUS}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\sales-report.png", New Object() {ID_LAPORAN_JUAL}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\ap-report.png", New Object() {ID_LAPORAN_PIUTANG}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\cost.png", New Object() {ID_AR_INITBALANCE}, XtremeCommandBars.XTPImageState.xtpImageNormal)

    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\cashier.png", New Object() {ID_CASHIER}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\cash-register.png", New Object() {ID_CASHIER_REGISTER}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\so.png", New Object() {ID_SERVICE}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\return.png", New Object() {ID_CASHIER_RETURN}, XtremeCommandBars.XTPImageState.xtpImageNormal)

    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\invoice.png", New Object() {ID_SERVICE_TRANSACTION}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\cash-register.png", New Object() {ID_SERVICE_MUTATION}, XtremeCommandBars.XTPImageState.xtpImageNormal)

    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\receipt-money.png", New Object() {ID_RECEIPT_MONEY}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\spend-money.png", New Object() {ID_SPEND_MONEY}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\cash-register.png", New Object() {ID_CASH_REGISTER}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\reconcile.png", New Object() {ID_RECONCILE}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\cash-report.png", New Object() {ID_TRANS_REPORT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\analyst-report.png", New Object() {ID_RECAP_REPORT}, XtremeCommandBars.XTPImageState.xtpImageNormal)

    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\coa.png", New Object() {ID_COA}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\reconcile.png", New Object() {ID_CASHBANK_SETUP}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\journal.png", New Object() {ID_JOURNAL}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\journal-list.png", New Object() {ID_JOURNAL_LIST}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\ledger.png", New Object() {ID_LEDGER}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\acc-report.png", New Object() {ID_ACC_REPORT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\report.png", New Object() {ID_FIN_REPORT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\coa.png", New Object() {ID_COA_SETUP}, XtremeCommandBars.XTPImageState.xtpImageNormal)

    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\user.png", New Object() {ID_USERRIGHT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\backup.png", New Object() {ID_BACKUP}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\restore.png", New Object() {ID_RESTORE}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\log.png", New Object() {ID_LOG}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\exit.png", New Object() {ID_EXIT}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\minimize.png", New Object() {ID_MINIMIZED}, XtremeCommandBars.XTPImageState.xtpImageNormal)

    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\user.png", New Object() {ID_CHANGE_PASSWORD}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    '    CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\analyst-report.png", New Object() {ID_PATH}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    'End Sub

    'Private Sub CommandBars_Execute(ByVal Control As XtremeCommandBars.ICommandBarControl)

    'End Sub

    'Public Function RibbonBar() As RibbonBar
    '    RibbonBar = CommandBars.ActiveMenuBar
    'End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'If conn.State.Open Then
        '    conn.Close()
        'End If
        'Me.Close()
    End Sub

    'Private Sub CommandBars_Execute1(ByVal sender As Object, ByVal e As AxXtremeCommandBars._DCommandBarsEvents_ExecuteEvent)

    '    Select Case e.control.Id
    '        Case ID_MASTERCUSTOMER
    '            Call AksesToolstripMenu(mnMasterCust)
    '        Case ID_MASTERSUPPLIER
    '            Call AksesToolstripMenu(menuMasterSupp)
    '        Case ID_MASTEREMPLOYEE
    '            Call AksesToolstripMenu(menuMasterMktg)
    '        Case ID_MASTERCARDLIST
    '            Call AksesToolstripMenu(mnCardList)
    '        Case ID_ITEM_TYPE
    '            Call AksesToolstripMenu(mnItemJenis)
    '        Case ID_ITEM_CAT
    '            Call AksesToolstripMenu(mnItemCat)
    '        Case ID_ITEM_BRAND
    '            If Application.OpenForms().OfType(Of frmbrandbarang).Any Then
    '                ' MsgBox("Menu Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
    '                frmbrandbarang.Activate()
    '            Else
    '                frmbrandbarang.Show()
    '                ' FormPassword.MdiParent = Me
    '            End If
    '        Case ID_ITEM_NAME
    '            Call AksesToolstripMenu(mnMasterItem)
    '        Case ID_ITEMBEGINING_BALANCE
    '            Call AksesToolstripMenu(mnStockAwal)
    '        Case ID_SERVICE
    '            Call AksesToolstripMenu(mnMasterService)
    '        Case ID_UNIT
    '            Call AksesToolstripMenu(mnUnit)
    '        Case ID_UNIT_CONVERSION
    '            Call AksesToolstripMenu(mnUnitConvers)
    '        Case ID_WAREHOUSE
    '            Call AksesToolstripMenu(mnWH)
    '        Case ID_CURRENCY
    '            Call AksesToolstripMenu(mnCurrency)
    '        Case ID_CURRENCY_CONVERT
    '            Call AksesToolstripMenu(mnConvertCurr)
    '        Case ID_CARD_FILE_REPORT
    '            Call AksesToolstripMenu(mnLapDataMaster)

    '        Case ID_STOCK_OPNAME
    '            Call AksesToolstripMenu(mnStockOpname)
    '        Case ID_STOCK_CORRECTION
    '            Call AksesToolstripMenu(mnStockCorrection)
    '        Case ID_MOVE_ITEM
    '            Call AksesToolstripMenu(mnItemTransfer)
    '        Case ID_ITEM_LIST
    '            Call AksesToolstripMenu(mnItemList)
    '        Case ID_LAPORAN_STOCK
    '            Call AksesToolstripMenu(mnStockReport)

    '        Case ID_RO
    '            Call AksesToolstripMenu(mnRequestOrder)
    '        Case ID_APP_RO
    '            Call AksesToolstripMenu(mnApprovalPermintaan)
    '        Case ID_PO
    '            Call AksesToolstripMenu(mnPurchaseOrder)
    '        Case ID_RECEIVED_ORDER
    '            Call AksesToolstripMenu(mnReceivedItem)
    '        Case ID_PURCHASE_INV
    '            Call AksesToolstripMenu(mnPurchaseInvoice)
    '        Case ID_PURCHASE_RETURN
    '            Call AksesToolstripMenu(mnPurchaseReturn)
    '        Case ID_PEMBAYARAN_HUTANG
    '            Call AksesToolstripMenu(mnAPPayment)
    '        Case ID_AP_STATUS
    '            Call AksesToolstripMenu(mnAPStatus)
    '        Case ID_PURCHASE_REPORT
    '            Call AksesToolstripMenu(mnPurchStdReport)
    '        Case ID_AP_REPORT
    '            Call AksesToolstripMenu(mnAPAge)
    '        Case ID_CASHIER
    '            Call AksesToolstripMenu(mnCashier)
    '        Case ID_CASHIER_REGISTER
    '            Call AksesToolstripMenu(mnCashierReport)
    '        Case ID_SO
    '            Call AksesToolstripMenu(mnSalesOrder)
    '        Case ID_DO
    '            Call AksesToolstripMenu(mnSuratJalan)
    '        Case ID_SALES_INV
    '            Call AksesToolstripMenu(mnSalesInvoice)
    '        Case ID_SALES_RETURN
    '            Call AksesToolstripMenu(mnSalesReturn)
    '        Case ID_PAYMENT_AR
    '            Call AksesToolstripMenu(mnARPayment)
    '        Case ID_AR_STATUS
    '            Call AksesToolstripMenu(mnARStatus)
    '        Case ID_LAPORAN_PIUTANG
    '            Call AksesToolstripMenu(mnARAge)
    '        Case ID_LAPORAN_JUAL
    '            Call AksesToolstripMenu(mnSalesStdReport)

    '        Case ID_SERVICE_TRANSACTION
    '            Call AksesToolstripMenu(mnReparasi)
    '        Case ID_SERVICE_MUTATION
    '            Call AksesToolstripMenu(mnServiceMutation)

    '        Case ID_RECEIPT_MONEY
    '            Call AksesToolstripMenu(mnReceivedMoney)
    '        Case ID_SPEND_MONEY
    '            Call AksesToolstripMenu(mnSpendMoney)
    '        Case ID_RECONCILE
    '            Call AksesToolstripMenu(mnBankReconcile)
    '        Case ID_CASH_REGISTER
    '            Call AksesToolstripMenu(mnCashBankReg)
    '        Case ID_TRANS_REPORT
    '            Call AksesToolstripMenu(mnCashBankHistReport)
    '        Case ID_RECAP_REPORT
    '            Call AksesToolstripMenu(mnCashRecapReport)

    '        Case ID_COA
    '            Call AksesToolstripMenu(mnCOA)
    '        Case ID_CASHBANK_SETUP
    '            Call AksesToolstripMenu(mnCashBank_set)
    '        Case ID_JOURNAL
    '            Call AksesToolstripMenu(mnJournal)
    '        Case ID_JOURNAL_LIST
    '            Call AksesToolstripMenu(mnJournalList)
    '        Case ID_LEDGER
    '            Call AksesToolstripMenu(mnLedger)
    '        Case ID_CLOSE_BOOK
    '            If Application.OpenForms().OfType(Of frmsetcoa).Any Then
    '                ' MsgBox("Menu Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
    '                ClosedPeriod.Activate()
    '            Else
    '                ClosedPeriod.Show()
    '                ' FormPassword.MdiParent = Me
    '            End If
    '        Case ID_ACC_REPORT
    '            Call AksesToolstripMenu(mnStdAccReport)
    '        Case ID_FIN_REPORT
    '            Call AksesToolstripMenu(mnFinAnalystReport)
    '        Case ID_COA_SETUP
    '            If Application.OpenForms().OfType(Of frmsetcoa).Any Then
    '                ' MsgBox("Menu Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
    '                frmsetcoa.Activate()
    '            Else
    '                frmsetcoa.Show()
    '                ' FormPassword.MdiParent = Me
    '            End If

    '        Case ID_USERRIGHT
    '            Call AksesToolstripMenu(mnManageUser)
    '        Case ID_BACKUP
    '            Call AksesToolstripMenu(mnBckup)
    '        Case ID_RESTORE
    '            Call AksesToolstripMenu(mnRestore)
    '        Case ID_LOG
    '            Call AksesToolstripMenu(mnLog)
    '        Case ID_EXIT
    '            Call AksesToolstripMenu(mnExit)
    '        Case ID_MINIMIZED
    '            Me.WindowState = FormWindowState.Minimized
    '        Case ID_CHANGE_PASSWORD
    '            If Application.OpenForms().OfType(Of FormPassword).Any Then
    '                ' MsgBox("Menu Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
    '                FormPassword.Activate()
    '            Else
    '                FormPassword.Show()
    '                ' FormPassword.MdiParent = Me
    '            End If
    '        Case ID_CASHIER_RETURN
    '            If Application.OpenForms().OfType(Of frmcashierreturn).Any Then
    '                ' MsgBox("Menu Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
    '                frmcashierreturn.Activate()
    '            Else
    '                frmcashierreturn.Show()
    '                ' FormPassword.MdiParent = Me
    '            End If
    '        Case ID_AP_INITBALANCE
    '            If Application.OpenForms().OfType(Of frmap_initbalance).Any Then
    '                ' MsgBox("Menu Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
    '                frmap_initbalance.Activate()
    '            Else
    '                frmap_initbalance.Show()
    '                ' FormPassword.MdiParent = Me
    '            End If
    '        Case ID_AR_INITBALANCE
    '            If Application.OpenForms().OfType(Of frmar_initbalance).Any Then
    '                ' MsgBox("Menu Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
    '                frmar_initbalance.Activate()
    '            Else
    '                frmar_initbalance.Show()
    '                ' FormPassword.MdiParent = Me
    '            End If
    '        Case ID_SET_MARKETING
    '            If Application.OpenForms().OfType(Of frmsetmarketing).Any Then
    '                ' MsgBox("Menu Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
    '                frmsetmarketing.Activate()
    '            Else
    '                frmsetmarketing.Show()
    '                ' FormPassword.MdiParent = Me
    '            End If
    '        Case ID_PATH
    '            If Application.OpenForms().OfType(Of frm_path_setup).Any Then
    '                ' MsgBox("Menu Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
    '                frm_path_setup.Activate()
    '            Else
    '                frm_path_setup.Show()
    '                ' FormPassword.MdiParent = Me
    '            End If
    '        Case ID_EXPEDITION
    '            If Application.OpenForms().OfType(Of frmekspedisi).Any Then
    '                ' MsgBox("Menu Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
    '                frmekspedisi.Activate()
    '            Else
    '                frmekspedisi.Show()
    '                ' FormPassword.MdiParent = Me
    '            End If
    '    End Select

    'End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCashBank_set.Click
        AksesToolstripMenu(mnCashBank_set)
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnManageUser.Click
        Call AksesToolstripMenu(mnManageUser)
    End Sub

    Private Sub ServiceMutationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnServiceMutation.Click
        Call AksesToolstripMenu(mnServiceMutation)
    End Sub


    Private Sub mnExit_Click(sender As System.Object, e As System.EventArgs) Handles mnExit.Click

    End Sub

    Private Sub activated_existing_form()

        If Application.OpenForms().OfType(Of frm_display_acc_cash).Any Then
            frm_display_acc_cash.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_acc_cashier).Any Then
            frm_display_acc_cashier.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_acc_detail).Any Then
            frm_display_acc_detail.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_brand).Any Then
            frm_display_brand.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_cashier).Any Then
            frm_display_cashier.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_category).Any Then
            frm_display_category.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_cust).Any Then
            frm_display_cust.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_grupacc).Any Then
            frm_display_grupacc.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_item).Any Then
            frm_display_item.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_material).Any Then
            frm_display_material.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_po).Any Then
            frm_display_po.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_purchase).Any Then
            frm_display_purchase.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_ro).Any Then
            frm_display_ro.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_sales).Any Then
            frm_display_sales.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_service).Any Then
            frm_display_service.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_so).Any Then
            frm_display_so.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_supp).Any Then
            frm_display_supp.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of frm_display_unit).Any Then
            frm_display_unit.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        'If Application.OpenForms().OfType(Of frmcustomer).Any Then
        '    frmcustomer.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmsupplier).Any Then
        '    frmsupplier.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmmarketing).Any Then
        '    frmmarketing.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmlistcard).Any Then
        '    '    frmlistcard.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmjenisbarang).Any Then
        '    frmjenisbarang.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmkatbarang).Any Then
        '    frmkatbarang.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmitem).Any Then
        '    frmitem.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmitem_beginning).Any Then
        '    frmitem_beginning.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmservice).Any Then
        '    frmservice.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmUnit).Any Then
        '    frmUnit.Activate()
        '    frmUnit.TabControl1.SelectedTabPage = frmUnit.TabInput
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of KasirSentral).Any Then
        '    KasirSentral.Activate()
        '    frmUnit.TabControl1.SelectedTabPage = KasirSentral.TabImport
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of Pembelian).Any Then
        '    Pembelian.Activate()
        '    frmUnit.TabControl1.SelectedTabPage = Pembelian.TabImport
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FrmSetKomponenCoaPurchase).Any Then
        '    FrmSetKomponenCoaPurchase.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmUnit).Any Then
        '    frmUnit.Activate()
        '    frmUnit.TabControl1.SelectedTabPage = frmUnit.TabKonversi
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmWH).Any Then
        '    frmWH.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmCurrency).Any Then
        '    frmCurrency.Activate()
        '    frmCurrency.TabControl1.SelectedTabPage = frmCurrency.TabInput
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmCurrency).Any Then
        '    frmCurrency.Activate()
        '    frmCurrency.TabControl1.SelectedTabPage = frmCurrency.tabconvert
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmekspedisi).Any Then
        '    frmekspedisi.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FormReportMaster).Any Then
        '    FormReportMaster.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmstockopname).Any Then
        '    frmstockopname.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmadjuststock).Any Then
        '    frmadjuststock.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmitemtransfer).Any Then
        '    frmitemtransfer.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmitem).Any Then
        '    frmitem.Activate()
        '    frmitem.TabControl1.SelectedTabPage = frmitem.TabList
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FormReportStock).Any Then
        '    FormReportStock.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmRO).Any Then
        '    frmRO.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmApproveRO).Any Then
        '    frmApproveRO.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmpo).Any Then
        '    frmpo.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmRecOrder).Any Then
        '    frmRecOrder.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmpurchase).Any Then
        '    frmpurchase.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmpurchase_langsung).Any Then
        '    frmpurchase_langsung.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmpurc_return).Any Then
        '    frmpurc_return.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmpayAP).Any Then
        '    frmpayAP.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmAPList).Any Then
        '    frmAPList.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FormReportPurch).Any Then
        '    FormReportPurch.Activate()
        '    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage1
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FormReportPurch).Any Then
        '    FormReportPurch.Activate()
        '    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage2
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmap_initbalance).Any Then
        '    frmap_initbalance.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmso).Any Then
        '    frmso.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmDPso).Any Then
        '    frmDPso.Activate()
        '    frmDPso.TabControl1.SelectedTabPage = frmDPso.TabList
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmDeliveredItem).Any Then
        '    frmDeliveredItem.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmBayarEkspedisi).Any Then
        '    frmBayarEkspedisi.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmsales).Any Then
        '    frmsales.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmsalesreturn).Any Then
        '    frmsalesreturn.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        If Application.OpenForms().OfType(Of frmFakturPajak).Any Then
            frmFakturPajak.Activate()
            frmFakturPajak.WindowState = FormWindowState.Maximized
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        'If Application.OpenForms().OfType(Of frmpayAR).Any Then
        '    frmpayAR.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmARList).Any Then
        '    frmARList.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FormReportSales).Any Then
        '    FormReportSales.Activate()
        '    FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage1
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FormReportSales).Any Then
        '    FormReportSales.Activate()
        '    FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage2
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmar_initbalance).Any Then
        '    frmar_initbalance.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmsetmarketing).Any Then
        '    frmsetmarketing.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmcashier).Any Then
        '    frmcashier.Activate()

        '    frmcashier.WindowState = FormWindowState.Maximized
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmcashierregister).Any Then
        '    frmcashierregister.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FormReportSales2).Any Then
        '    FormReportSales2.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmcashierreturn).Any Then
        '    frmcashierreturn.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmreceiptmoney).Any Then
        '    frmreceiptmoney.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmspendmoney).Any Then
        '    frmspendmoney.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmcashregister).Any Then
        '    frmcashregister.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmreconcile).Any Then
        '    frmreconcile.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FormReportCash).Any Then
        '    FormReportCash.Activate()
        '    FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage1
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FormReportCash).Any Then
        '    FormReportCash.Activate()
        '    FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage2
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmcoa).Any Then
        '    frmcoa.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmjournal).Any Then
        '    frmjournal.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmadjustjournal).Any Then
        '    frmadjustjournal.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmsetupcashbank).Any Then
        '    frmsetupcashbank.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        If Application.OpenForms().OfType(Of frmsetupcashflow).Any Then
            frmsetupcashflow.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        'If Application.OpenForms().OfType(Of frmledger).Any Then
        '    frmledger.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmsetcoa).Any Then
        '    frmsetcoa.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmsetupcashbank).Any Then
        '    frmsetupcashbank.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmsetcadpiutang).Any Then
        '    frmsetcadpiutang.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmsetcadhutang).Any Then
        '    frmsetcadhutang.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If



        'If Application.OpenForms().OfType(Of frmledger).Any Then
        '    frmledger.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        If Application.OpenForms().OfType(Of ClosedPeriod).Any Then
            ClosedPeriod.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        'If Application.OpenForms().OfType(Of FormReportAcc).Any And FormReportAcc.Visible = True Then
        '    FormReportAcc.Activate()
        '    FormReportAcc.TabControl1.SelectedTabPage = FormReportAcc.TabPage1
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of FormReportAcc).Any Then
        '    FormReportAcc.Activate()
        '    FormReportAcc.TabControl1.SelectedTabPage = FormReportAcc.TabPage1
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        If Application.OpenForms().OfType(Of backup).Any Then
            backup.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of restore).Any Then
            restore.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        'If Application.OpenForms().OfType(Of frmlog).Any Then
        '    frmlog.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of UserRight).Any Then
        '    UserRight.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        If Application.OpenForms().OfType(Of frm_path_setup).Any Then
            frm_path_setup.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of FormPassword).Any Then
            FormPassword.Activate()
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        'If Application.OpenForms().OfType(Of frmbrandbarang).Any Then
        '    frmbrandbarang.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmgolaset).Any Then
        '    frmgolaset.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmaset).Any Then
        '    frmaset.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmsetcoa_aset).Any Then
        '    frmsetcoa_aset.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        'If Application.OpenForms().OfType(Of frmpenyusutanaset).Any Then
        '    frmpenyusutanaset.Activate()
        '    Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
        '    alertControl_warning.Show(Me, info)
        'End If

        If Application.OpenForms().OfType(Of FormLapDepr).Any Then
            FormLapDepr.Activate()
            FormLapDepr.WindowState = FormWindowState.Maximized
            FormLapDepr.Text = "Laporan History Penyusutan Per Periode"
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

        If Application.OpenForms().OfType(Of FormLapAkumDepr).Any Then
            FormLapAkumDepr.Activate()
            FormLapAkumDepr.WindowState = FormWindowState.Maximized
            Dim info As AlertInfo = New AlertInfo("Child Form Active", "Silahkan tutup terlebih dahulu form yang aktif")
            alertControl_warning.Show(Me, info)
        End If

    End Sub

    Private Sub view_privilege(ByVal user_login As String)
        open_conn()
        Dim DT, DTChild, DTChild2, DTChild3 As DataTable
        Dim a, b, c, d As Integer
        DT = getParentKey_FromUser2(user_login)
        With NavBar_Menu
            a = 0
            Do While a <= DT.Rows.Count - 1
                Dim RootNode As New DevExpress.XtraNavBar.NavBarGroup
                RootNode.Name = DT.Rows(a).Item("childkey")
                RootNode.Caption = DT.Rows(a).Item("notes")
                RootNode.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                ' RootNode.SmallImage = Image.FromFile(load_icon("ARROW"))
                .Groups.Add(RootNode)
                If a = 0 Then
                    RootNode.Expanded = True
                End If
                DTChild = getChildKey_FromUser2(user_login, DT.Rows(a).Item("childkey"))

                If DTChild.Rows.Count > 0 Then
                    b = 0
                    Do While b <= DTChild.Rows.Count - 1
                        Dim ChildNode As New DevExpress.XtraNavBar.NavBarItem
                        ChildNode.Name = DTChild.Rows(b).Item("childkey")
                        ChildNode.Caption = DTChild.Rows(b).Item("notes")
                        ChildNode.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        ChildNode.SmallImage = Image.FromFile(load_icon(DTChild.Rows(b).Item("childkey").ToString))
                        RootNode.ItemLinks.Add(ChildNode)
                        b = b + 1
                    Loop
                End If
                Dim ChildNode2 As New DevExpress.XtraNavBar.NavBarItem
                Dim ChildNode3 As New DevExpress.XtraNavBar.NavBarItem
                If DT.Rows(a).Item("childkey") = "MN_TOOLS" Then
                    ChildNode2.Name = "CHANGE_PASS"
                    ChildNode2.Caption = "UBAH PASSWORD"
                    ChildNode2.SmallImage = Image.FromFile(load_icon("CHANGE_PASS"))
                    RootNode.ItemLinks.Add(ChildNode2)

                    Dim chr1, chr2, chr3, chr4 As String
                    chr1 = UCase(Mid(GetDriveSerialNumber(""), 1, 2)) & UCase(Mid(CpuId, 7, 1)) & "I"
                    chr2 = UCase(Mid(GetDriveSerialNumber(""), 3, 2)) & UCase(Mid(CpuId, 5, 1)) & "B"
                    chr3 = UCase(Mid(GetDriveSerialNumber(""), 5, 2)) & UCase(Mid(CpuId, 3, 1)) & "A"
                    chr4 = UCase(Mid(GetDriveSerialNumber(""), 7, 2)) & UCase(Mid(CpuId, 1, 1)) & "S"

                    If get_activated(chr1, chr2, chr3, chr4) = 0 Then
                        ChildNode3.Name = "ACTIVATED"
                        ChildNode3.Caption = "REGISTER PROGRAM"
                        ChildNode3.SmallImage = Image.FromFile(load_icon("ARROW"))
                        RootNode.ItemLinks.Add(ChildNode3)
                    End If
                End If
                a = a + 1
            Loop
            'Dim RootExit As New DevExpress.XtraNavBar.NavBarGroup
            'RootExit.Name = "EXIT"
            'RootExit.Caption = "EXIT"
            '.Groups.Add(RootExit)

            'Dim ChildLogout As New DevExpress.XtraNavBar.NavBarItem
            'ChildLogout.Name = "LOGOUT"
            'ChildLogout.Caption = "LOGOUT"
            'ChildLogout.SmallImage = Image.FromFile(load_icon("LOGOUT").ToString)
            'RootExit.ItemLinks.Add(ChildLogout)

            'Dim ChildMin As New DevExpress.XtraNavBar.NavBarItem
            'ChildMin.Name = "MINIMIZE"
            'ChildMin.Caption = "MINIMIZE"
            'ChildMin.SmallImage = Image.FromFile(load_icon("MINIMIZE").ToString)
            'RootExit.ItemLinks.Add(ChildMin)

        End With
    End Sub

    Private Sub view_privilege_vendorcreator(ByVal user_login As String)
        open_conn()
        Dim DT, DTChild, DTChild2, DTChild3 As DataTable
        Dim a, b, c, d As Integer
        DT = getParentKey_FromUser2(LCase("admin"))
        With NavBar_Menu
            a = 0
            Do While a <= DT.Rows.Count - 1
                Dim RootNode As New DevExpress.XtraNavBar.NavBarGroup
                RootNode.Name = DT.Rows(a).Item("childkey")
                RootNode.Caption = DT.Rows(a).Item("notes")
                RootNode.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .Groups.Add(RootNode)
                DTChild = getChildKey_FromUser2("admin", DT.Rows(a).Item("childkey"))

                If DTChild.Rows.Count > 0 Then
                    b = 0
                    Do While b <= DTChild.Rows.Count - 1
                        Dim ChildNode As New DevExpress.XtraNavBar.NavBarItem
                        ChildNode.Name = DTChild.Rows(b).Item("childkey")
                        ChildNode.Caption = DTChild.Rows(b).Item("notes")
                        ChildNode.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        ChildNode.SmallImage = Image.FromFile(load_icon(DTChild.Rows(b).Item("childkey").ToString))
                        RootNode.ItemLinks.Add(ChildNode)
                        b = b + 1
                    Loop
                End If
                Dim ChildNode2 As New DevExpress.XtraNavBar.NavBarItem
                If DT.Rows(a).Item("childkey") = "MN_TOOLS" Then
                    ChildNode2.Name = "CHANGE_PASS"
                    ChildNode2.Caption = "UBAH PASSWORD"
                    ChildNode2.SmallImage = Image.FromFile(load_icon("CHANGE_PASS"))
                    RootNode.ItemLinks.Add(ChildNode2)
                End If
                Dim ChildNode4, ChildNode5, ChildNode6 As New DevExpress.XtraNavBar.NavBarItem
                If DT.Rows(a).Item("childkey") = "MN_TOOLS" Then
                    ChildNode4.Name = "SETMODULE"
                    ChildNode4.Caption = "SET MODULE"
                    ChildNode4.SmallImage = Image.FromFile(load_icon(""))
                    RootNode.ItemLinks.Add(ChildNode4)
                    ChildNode5.Name = "ACTIVATED"
                    ChildNode5.Caption = "REGISTER PROGRAM"
                    ChildNode5.SmallImage = Image.FromFile(load_icon("ARROW"))
                    RootNode.ItemLinks.Add(ChildNode5)
                    ChildNode6.Name = "SETTRIAL"
                    ChildNode6.Caption = "SET TRIAL VERSION"
                    ChildNode6.SmallImage = Image.FromFile(load_icon("ARROW"))
                    RootNode.ItemLinks.Add(ChildNode6)
                End If
                a = a + 1
            Loop
            'Dim RootExit As New DevExpress.XtraNavBar.NavBarGroup
            'RootExit.Name = "EXIT"
            'RootExit.Caption = "EXIT"
            '.Groups.Add(RootExit)

            'Dim ChildLogout As New DevExpress.XtraNavBar.NavBarItem
            'ChildLogout.Name = "LOGOUT"
            'ChildLogout.Caption = "LOGOUT"
            'ChildLogout.SmallImage = Image.FromFile(load_icon("LOGOUT").ToString)
            'RootExit.ItemLinks.Add(ChildLogout)

            'Dim ChildMin As New DevExpress.XtraNavBar.NavBarItem
            'ChildMin.Name = "MINIMIZE"
            'ChildMin.Caption = "MINIMIZE"
            'ChildMin.SmallImage = Image.FromFile(load_icon("MINIMIZE").ToString)
            'RootExit.ItemLinks.Add(ChildMin)

        End With
    End Sub


    Private Function load_icon(ByVal menu_name As String) As String

        If menu_name = "MN_CUSTOMER" Then
            Return Application.StartupPath & "\icon\customer.png"
        ElseIf menu_name = "MN_SUPPLIER" Then
            Return Application.StartupPath & "\icon\supplier.png"
        ElseIf menu_name = "MN_EMPLOYEE" Then
            Return Application.StartupPath & "\icon\pegawai.png"
        ElseIf menu_name = "MN_CARD_LIST" Then
            Return Application.StartupPath & "\icon\cardlist.png"
        ElseIf menu_name = "MN_ITEM_TYPE" Then
            Return Application.StartupPath & "\icon\item-type.png"
        ElseIf menu_name = "MN_ITEM_CAT" Then
            Return Application.StartupPath & "\icon\item-cat.png"
        ElseIf menu_name = "MN_ITEM_BRAND" Then
            Return Application.StartupPath & "\icon\icon-brand.png"
        ElseIf menu_name = "MN_ITEM_NAME" Then
            Return Application.StartupPath & "\icon\item-name.png"
        ElseIf menu_name = "MN_BEGINING_BALANCE" Then
            Return Application.StartupPath & "\icon\item-beg-balance.png"
        ElseIf menu_name = "MN_UNIT" Then
            Return Application.StartupPath & "\icon\unit.png"
        ElseIf menu_name = "MN_UNIT_CONVERSION" Then
            Return Application.StartupPath & "\icon\konversi-unit.png"
        ElseIf menu_name = "MN_WAREHOUSE" Then
            Return Application.StartupPath & "\icon\gudang.png"
        ElseIf menu_name = "MN_CURRENCY" Then
            Return Application.StartupPath & "\icon\mata-uang.png"
        ElseIf menu_name = "MN_CURRENCY_CONVERSION" Then
            Return Application.StartupPath & "\icon\konvert-matauang.png"
        ElseIf menu_name = "MN_CARD_FILE_REPORT" Then
            Return Application.StartupPath & "\icon\card-filereport.png"
        ElseIf menu_name = "MN_EXPEDITION" Then
            Return Application.StartupPath & "\icon\DO.png"
        ElseIf menu_name = "MN_JENIS_JASA" Then
            Return Application.StartupPath & "\icon\payment.png"
        ElseIf menu_name = "MN_STOCK_OPNAME" Then
            Return Application.StartupPath & "\icon\stock-opname.png"
        ElseIf menu_name = "MN_STOCK_CORRECTION" Then
            Return Application.StartupPath & "\icon\stock-correction.png"
        ElseIf menu_name = "MN_MOVE_ITEM" Then
            Return Application.StartupPath & "\icon\transferstock.png"
        ElseIf menu_name = "MN_ITEM_LIST" Then
            Return Application.StartupPath & "\icon\item-list.png"
        ElseIf menu_name = "MN_STOCK_REPORT" Then
            Return Application.StartupPath & "\icon\stock-report.png"
        ElseIf menu_name = "MN_RO" Then
            Return Application.StartupPath & "\icon\ro.png"
        ElseIf menu_name = "MN_APPROVAL_RO" Then
            Return Application.StartupPath & "\icon\approval-ro.png"
        ElseIf menu_name = "MN_PO" Then
            Return Application.StartupPath & "\icon\po.png"
        ElseIf menu_name = "MN_RECEIVED_ORDER" Then
            Return Application.StartupPath & "\icon\received-order.png"
        ElseIf menu_name = "MN_PURCHASE_INV" Then
            Return Application.StartupPath & "\icon\invoice.png"
        ElseIf menu_name = "MN_PURCHASE_RETURN" Then
            Return Application.StartupPath & "\icon\return.png"
        ElseIf menu_name = "MN_PEMBAYARAN_HUTANG" Then
            Return Application.StartupPath & "\icon\payment.png"
        ElseIf menu_name = "MN_STATUS_HUTANG" Then
            Return Application.StartupPath & "\icon\ap-status.png"
        ElseIf menu_name = "MN_PURCHASE_REPORT" Then
            Return Application.StartupPath & "\icon\purchase-report.png"
        ElseIf menu_name = "MN_AP_REPORT" Then
            Return Application.StartupPath & "\icon\ap-report.png"
        ElseIf menu_name = "MN_AP_INITBALANCE" Then
            Return Application.StartupPath & "\icon\cost.png"
        ElseIf menu_name = "MN_SET_MARKETING" Then
            Return Application.StartupPath & "\icon\pegawai.png"
        ElseIf menu_name = "MN_SO" Then
            Return Application.StartupPath & "\icon\so.png"
        ElseIf menu_name = "MN_DP_SO" Then
            Return Application.StartupPath & "\icon\payment.png"
        ElseIf menu_name = "MN_DELIVERED_ITEM" Then
            Return Application.StartupPath & "\icon\do.png"
        ElseIf menu_name = "MN_EXPEDITION_PAYMENT" Then
            Return Application.StartupPath & "\icon\exp_payment.png"
        ElseIf menu_name = "MN_SALES_INV" Then
            Return Application.StartupPath & "\icon\invoice.png"
        ElseIf menu_name = "MN_SALES_RETURN" Then
            Return Application.StartupPath & "\icon\return.png"
        ElseIf menu_name = "MN_FAKTUR_PAJAK" Then
            Return Application.StartupPath & "\icon\item-list.png"
        ElseIf menu_name = "MN_PAYMENT_AR" Then
            Return Application.StartupPath & "\icon\payment.png"
        ElseIf menu_name = "MN_AR_STATUS" Then
            Return Application.StartupPath & "\icon\ap-status.png"
        ElseIf menu_name = "MN_LAPORAN_JUAL" Then
            Return Application.StartupPath & "\icon\sales-report.png"
        ElseIf menu_name = "MN_LAPORAN_PIUTANG" Then
            Return Application.StartupPath & "\icon\ap-report.png"
        ElseIf menu_name = "MN_AR_INITBALANCE" Then
            Return Application.StartupPath & "\icon\cost.png"
        ElseIf menu_name = "MN_CASHIER" Then
            Return Application.StartupPath & "\icon\cashier.png"
        ElseIf menu_name = "MN_CASHIER_REGISTER" Then
            Return Application.StartupPath & "\icon\cash-register.png"
        ElseIf menu_name = "MN_MUTASI_CASHIER" Then
            Return Application.StartupPath & "\icon\cash-register.png"
        ElseIf menu_name = "MN_CASHIER_RETURN" Then
            Return Application.StartupPath & "\icon\return.png"
        ElseIf menu_name = "MN_RECEIPT_MONEY" Then
            Return Application.StartupPath & "\icon\receipt-money.png"
        ElseIf menu_name = "MN_SPEND_MONEY" Then
            Return Application.StartupPath & "\icon\spend-money.png"
        ElseIf menu_name = "MN_CASHBANK_REGISTER" Then
            Return Application.StartupPath & "\icon\cash-register.png"
        ElseIf menu_name = "MN_BANK_RECONCILE" Then
            Return Application.StartupPath & "\icon\reconcile.png"
        ElseIf menu_name = "MN_CASHBANK_TRANS_REPORT" Then
            Return Application.StartupPath & "\icon\cash-report.png"
        ElseIf menu_name = "MN_CASHBANK_RECAP_REPORT" Then
            Return Application.StartupPath & "\icon\analyst-report.png"
        ElseIf menu_name = "MN_COA" Then
            Return Application.StartupPath & "\icon\coa.png"
        ElseIf menu_name = "MN_CASHBANK_SETUP" Then
            Return Application.StartupPath & "\icon\setting.png"
        ElseIf menu_name = "MN_JOURNAL" Then
            Return Application.StartupPath & "\icon\journal.png"
        ElseIf menu_name = "MN_ADJUST_JOURNAL" Then
            Return Application.StartupPath & "\icon\item-list.png"
        ElseIf menu_name = "MN_JOURNAL_LIST" Then
            Return Application.StartupPath & "\icon\journal-list.png"
        ElseIf menu_name = "MN_LEDGER" Then
            Return Application.StartupPath & "\icon\ledger.png"
        ElseIf menu_name = "MN_ACCOUNTING_REPORT" Then
            Return Application.StartupPath & "\icon\acc-report.png"
        ElseIf menu_name = "MN_ANALYST_REPORT" Then
            Return Application.StartupPath & "\icon\sales-report.png"
        ElseIf menu_name = "MN_COA_SETUP" Then
            Return Application.StartupPath & "\icon\setting.png"
        ElseIf menu_name = "MN_CASHBANK_SETUP" Then
            Return Application.StartupPath & "\icon\setting.png"
        ElseIf menu_name = "MN_CASHFLOW_SETUP" Then
            Return Application.StartupPath & "\icon\setting.png"
        ElseIf menu_name = "MN_AR_SETUP" Then
            Return Application.StartupPath & "\icon\setting.png"
        ElseIf menu_name = "MN_AP_SETUP" Then
            Return Application.StartupPath & "\icon\setting.png"
        ElseIf menu_name = "MN_COA_ASET_SETUP" Then
            Return Application.StartupPath & "\icon\setting.png"
        ElseIf menu_name = "MN_SET_COA_DEPPRODUKSI" Then
            Return Application.StartupPath & "\icon\setting.png"
        ElseIf menu_name = "MN_SET_PATH" Then
            Return Application.StartupPath & "\icon\setting.png"
        ElseIf menu_name = "MN_CLOSE_PERIOD" Or menu_name = "MN_CLOSE_PERIOD_SIMRS" Then
            Return Application.StartupPath & "\icon\refresh.png"
        ElseIf menu_name = "MN_USERMANAGE" Then
            Return Application.StartupPath & "\icon\user.png"
        ElseIf menu_name = "MN_BACKUP" Then
            Return Application.StartupPath & "\icon\backup.png"
        ElseIf menu_name = "MN_RESTORE" Then
            Return Application.StartupPath & "\icon\restore.png"
        ElseIf menu_name = "MN_NAMA_ASET" Then
            Return Application.StartupPath & "\icon\item-name.png"
        ElseIf menu_name = "MN_GOLONGAN_ASET" Then
            Return Application.StartupPath & "\icon\item-cat.png"
        ElseIf menu_name = "MN_LOG" Then
            Return Application.StartupPath & "\icon\log.png"
        ElseIf menu_name = "MN_CONVERSION_COST" Then
            Return Application.StartupPath & "\icon\cost-icon.png"
        ElseIf menu_name = "MN_ASSEMBLY_COST" Then
            Return Application.StartupPath & "\icon\cost-icon.png"
        ElseIf menu_name = "MN_PRODUCT_FORMULA" Then
            Return Application.StartupPath & "\icon\bom.png"
        ElseIf menu_name = "MN_WORKING_ORDER" Then
            Return Application.StartupPath & "\icon\wo.png"
        ElseIf menu_name = "MN_ITEM_ASSEMBLY" Then
            Return Application.StartupPath & "\icon\item-usage.png"
        ElseIf menu_name = "MN_MATERIAL_USAGE" Then
            Return Application.StartupPath & "\icon\item-usage.png"
        ElseIf menu_name = "MN_PRODUCTION" Then
            Return Application.StartupPath & "\icon\manufacture.png"
        ElseIf menu_name = "MN_MANUFACTURE_REPORT" Then
            Return Application.StartupPath & "\icon\item-list.png"
        ElseIf menu_name = "LOGOUT" Then
            Return Application.StartupPath & "\icon\exit.png"
        ElseIf menu_name = "MN_CARDFILE" Then
            Return Application.StartupPath & "\icon\card file.png"
        ElseIf menu_name = "MN_STOCK" Then
            Return Application.StartupPath & "\icon\stock.png"
        ElseIf menu_name = "MN_PURCHASE" Then
            Return Application.StartupPath & "\icon\purchase.jpg"
        ElseIf menu_name = "MN_SALES" Then
            Return Application.StartupPath & "\icon\sales.png"
        ElseIf menu_name = "MN_OUTLET_SALES" Then
            Return Application.StartupPath & "\icon\outlet-sales.png"
        ElseIf menu_name = "MN_CASH_BANK" Then
            Return Application.StartupPath & "\icon\finance.png"
        ElseIf menu_name = "MN_ASET" Then
            Return Application.StartupPath & "\icon\aset.png"
        ElseIf menu_name = "MN_DEPR_ASET" Then
            Return Application.StartupPath & "\icon\depr-aset.png"
        ElseIf menu_name = "MN_DEPR_HISTORY" Then
            Return Application.StartupPath & "\icon\depr-report.png"
        ElseIf menu_name = "MN_ACCUMDEPR_REPORT" Then
            Return Application.StartupPath & "\icon\accum-depr.png"
        ElseIf menu_name = "MN_ACCOUNT" Then
            Return Application.StartupPath & "\icon\accounting.png"
        ElseIf menu_name = "MN_TOOLS" Then
            Return Application.StartupPath & "\icon\tools.png"
        ElseIf menu_name = "MINIMIZE" Then
            Return Application.StartupPath & "\icon\minimize.png"
        ElseIf menu_name = "MINIMIZE" Then
            Return Application.StartupPath & "\icon\minimize.png"
        ElseIf menu_name = "CHANGE_PASS" Then
            Return Application.StartupPath & "\icon\key.png"
        Else
            Return Application.StartupPath & "\icon\navigate.png"
        End If



        'CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\user.png", New Object() {ID_CHANGE_PASSWORD}, XtremeCommandBars.XTPImageState.xtpImageNormal)
        'CommandBars.Icons.LoadBitmap(Application.StartupPath & "\icon\analyst-report.png", New Object() {ID_PATH}, XtremeCommandBars.XTPImageState.xtpImageNormal)
    End Function

    Private Sub NavBar_Menu_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar_Menu.LinkClicked
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Form . . .")
            If e.Link.ItemName = "LOGOUT" Then
                Dim pesan As String
                pesan = MsgBox("Logout Aplikasi?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
                If pesan = vbYes Then
                    Me.Close()
                    close_conn()
                    With LoginFormSambung
                        .Show()
                        .txt_user.Text = ""
                        .txt_password.Text = ""
                        .txt_user.Focus()
                    End With
                End If
            End If
            If e.Link.ItemName = "MN_CUSTOMER" Then
                If Application.OpenForms().OfType(Of frmcustomer).Any Then
                    frmcustomer.Activate()
                Else
                    frmcustomer.Show()
                End If
            End If
            If e.Link.ItemName = "MN_SUPPLIER" Then
                If Application.OpenForms().OfType(Of frmsupplier).Any Then
                    frmsupplier.Activate()
                Else
                    frmsupplier.Show()
                End If
            End If

            If e.Link.ItemName = "MN_EMPLOYEE" Then

                If Application.OpenForms().OfType(Of frmmarketing).Any Then
                    frmmarketing.Activate()
                Else
                    frmmarketing.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CARD_LIST" Then
                'If Application.OpenForms().OfType(Of frmlistcard).Any Then
                '    '    frmlistcard.Activate()
                'Else
                '    '   frmlistcard.Show()
                'End If
            End If
            If e.Link.ItemName = "MN_ITEM_TYPE" Then
                If Application.OpenForms().OfType(Of frmjenisbarang).Any Then
                    frmjenisbarang.Activate()
                Else
                    frmjenisbarang.Show()
                End If
            End If
            If e.Link.ItemName = "MN_ITEM_CAT" Then
                If Application.OpenForms().OfType(Of frmkatbarang).Any Then
                    frmkatbarang.Activate()
                Else
                    frmkatbarang.Show()
                End If
            End If
            If e.Link.ItemName = "MN_ITEM_NAME" Then
                If Application.OpenForms().OfType(Of frmitem).Any Then
                    frmitem.Activate()
                Else
                    frmitem.Show()
                End If
            End If
            If e.Link.ItemName = "MN_BEGINING_BALANCE" Then
                If Application.OpenForms().OfType(Of frmitem_beginning).Any Then
                    frmitem_beginning.Activate()
                Else
                    frmitem_beginning.Show()
                End If
            End If
            If e.Link.ItemName = "MN_PURCHASE_UM_LUNAS" Then
                If Application.OpenForms().OfType(Of frmPayUMPO).Any Then
                    frmPayUMPO.Activate()
                Else
                    frmPayUMPO.Show()
                End If
            End If
            If e.Link.ItemName = "MN_JENIS_JASA" Then
                If Application.OpenForms().OfType(Of frmservice).Any Then
                    frmservice.Activate()
                Else
                    frmservice.Show()
                End If
            End If
            If e.Link.ItemName = "MN_UNIT" Then
                If Application.OpenForms().OfType(Of frmUnit).Any Then
                    frmUnit.Activate()
                    frmUnit.TabControl1.SelectedTabPage = frmUnit.TabInput
                Else
                    frmUnit.Show()
                    frmUnit.TabControl1.SelectedTabPage = frmUnit.TabInput
                End If
            End If
            If e.Link.ItemName = "MN_UNIT_CONVERSION" Then
                If Application.OpenForms().OfType(Of frmUnit).Any Then
                    frmUnit.Activate()
                    frmUnit.TabControl1.SelectedTabPage = frmUnit.TabKonversi
                Else
                    frmUnit.Show()
                    frmUnit.TabControl1.SelectedTabPage = frmUnit.TabKonversi
                End If
            End If
            If e.Link.ItemName = "MN_WAREHOUSE" Then
                If Application.OpenForms().OfType(Of frmWH).Any Then
                    frmWH.Activate()
                Else
                    frmWH.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CURRENCY" Then
                If Application.OpenForms().OfType(Of frmCurrency).Any Then
                    frmCurrency.Activate()
                    frmCurrency.TabControl1.SelectedTabPage = frmCurrency.TabInput
                Else
                    frmCurrency.Show()
                    frmCurrency.TabControl1.SelectedTabPage = frmCurrency.TabInput
                End If
            End If
            If e.Link.ItemName = "MN_CURRENCY_CONVERSION" Then
                If Application.OpenForms().OfType(Of frmCurrency).Any Then
                    frmCurrency.Activate()
                    frmCurrency.TabControl1.SelectedTabPage = frmCurrency.tabconvert
                Else
                    frmCurrency.Show()
                    frmCurrency.TabControl1.SelectedTabPage = frmCurrency.tabconvert
                End If
            End If
            If e.Link.ItemName = "MN_EXPEDITION" Then
                If Application.OpenForms().OfType(Of frmekspedisi).Any Then
                    frmekspedisi.Activate()
                Else
                    frmekspedisi.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CARD_FILE_REPORT" Then
                If Application.OpenForms().OfType(Of FormReportMaster).Any Then
                    FormReportMaster.Activate()
                Else
                    FormReportMaster.Show()
                End If
            End If
            If e.Link.ItemName = "MN_STOCK_OPNAME" Then
                If Application.OpenForms().OfType(Of frmstockopname).Any Then
                    frmstockopname.Activate()
                Else
                    frmstockopname.Show()
                End If
            End If
            If e.Link.ItemName = "MN_STOCK_CORRECTION" Then
                If Application.OpenForms().OfType(Of frmadjuststock).Any Then
                    frmadjuststock.Activate()
                Else
                    frmadjuststock.Show()
                End If
            End If
            If e.Link.ItemName = "MN_MOVE_ITEM" Then
                If Application.OpenForms().OfType(Of frmitemtransfer).Any Then
                    frmitemtransfer.Activate()
                Else
                    frmitemtransfer.Show()
                End If
            End If
            If e.Link.ItemName = "MN_ITEM_LIST" Then
                If Application.OpenForms().OfType(Of frmitem).Any Then
                    frmitem.Activate()
                    frmitem.TabControl1.SelectedTabPage = frmitem.TabList
                Else
                    frmitem.Show()
                    frmitem.TabControl1.SelectedTabPage = frmitem.TabList
                End If
            End If
            If e.Link.ItemName = "MN_STOCK_REPORT" Then
                If Application.OpenForms().OfType(Of FormReportStock).Any Then
                    FormReportStock.Activate()
                Else
                    FormReportStock.Show()
                End If
            End If
            If e.Link.ItemName = "MN_RO" Then
                If Application.OpenForms().OfType(Of frmRO).Any Then
                    frmRO.Activate()
                Else
                    frmRO.Show()
                End If
            End If
            If e.Link.ItemName = "MN_APPROVAL_RO" Then
                If Application.OpenForms().OfType(Of frmApproveRO).Any Then
                    frmApproveRO.Activate()
                Else
                    frmApproveRO.Show()
                End If
            End If
            If e.Link.ItemName = "MN_PO" Then
                If Application.OpenForms().OfType(Of frmpo).Any Then
                    frmpo.Activate()
                Else
                    frmpo.Show()
                End If
            End If
            If e.Link.ItemName = "MN_RECEIVED_ORDER" Then
                If Application.OpenForms().OfType(Of frmRecOrder).Any Then
                    frmRecOrder.Activate()
                Else
                    frmRecOrder.Show()
                End If
            End If
            If e.Link.ItemName = "MN_PURCHASE_INV" Then
                If Application.OpenForms().OfType(Of frmpurchase).Any Then
                    frmpurchase.Activate()
                Else
                    frmpurchase.Show()
                End If
            End If
            If e.Link.ItemName = "MN_PURCHASE_DIRECT" Then
                If Application.OpenForms().OfType(Of frmpurchase_langsung).Any Then
                    frmpurchase_langsung.Activate()
                Else
                    frmpurchase_langsung.Show()
                End If
            End If
            If e.Link.ItemName = "MN_PURCHASE_RETURN" Then
                If Application.OpenForms().OfType(Of frmpurc_return).Any Then
                    frmpurc_return.Activate()
                Else
                    frmpurc_return.Show()
                End If
            End If
            If e.Link.ItemName = "MN_PEMBAYARAN_HUTANG" Then
                If Application.OpenForms().OfType(Of frmpayAP).Any Then
                    frmpayAP.Activate()
                Else
                    frmpayAP.Show()
                End If
            End If
            If e.Link.ItemName = "MN_STATUS_HUTANG" Then
                If Application.OpenForms().OfType(Of frmAPList).Any Then
                    frmAPList.Activate()
                Else
                    frmAPList.Show()
                End If
            End If
            If e.Link.ItemName = "MN_PURCHASE_REPORT" Then
                If Application.OpenForms().OfType(Of FormReportPurch).Any Then
                    FormReportPurch.Activate()
                    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage1
                Else
                    FormReportPurch.Show()
                    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage1
                End If
            End If
            If e.Link.ItemName = "MN_AP_REPORT" Then
                If Application.OpenForms().OfType(Of FormReportPurch).Any Then
                    FormReportPurch.Activate()
                    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage2
                Else
                    FormReportPurch.Show()
                    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage2
                End If
            End If
            If e.Link.ItemName = "MN_AP_INITBALANCE" Then
                If Application.OpenForms().OfType(Of frmap_initbalance).Any Then
                    frmap_initbalance.Activate()
                Else
                    frmap_initbalance.Show()
                End If
            End If
            If e.Link.ItemName = "MN_SO" Then
                If Application.OpenForms().OfType(Of frmso).Any Then
                    frmso.Activate()
                Else
                    frmso.Show()
                End If
            End If
            If e.Link.ItemName = "MN_DP_SO" Then
                If Application.OpenForms().OfType(Of frmDPso).Any Then
                    frmDPso.Activate()
                    frmDPso.TabControl1.SelectedTabPage = frmDPso.TabList
                Else
                    frmDPso.Show()
                    frmDPso.TabControl1.SelectedTabPage = frmDPso.TabList
                End If
            End If
            If e.Link.ItemName = "MN_DELIVERED_ITEM" Then
                If Application.OpenForms().OfType(Of frmDeliveredItem).Any Then
                    frmDeliveredItem.Activate()
                Else
                    frmDeliveredItem.Show()
                End If
            End If
            If e.Link.ItemName = "MN_EXPEDITION_PAYMENT" Then
                If Application.OpenForms().OfType(Of frmBayarEkspedisi).Any Then
                    frmBayarEkspedisi.Activate()
                Else
                    frmBayarEkspedisi.Show()
                End If
            End If
            If e.Link.ItemName = "MN_SALES_INV" Then
                If Application.OpenForms().OfType(Of frmsales).Any Then
                    frmsales.Activate()
                Else
                    frmsales.Show()
                End If
            End If
            If e.Link.ItemName = "MN_SALES_RETURN" Then
                If Application.OpenForms().OfType(Of frmsalesreturn).Any Then
                    frmsalesreturn.Activate()
                Else
                    frmsalesreturn.Show()
                End If
            End If
            If e.Link.ItemName = "MN_FAKTUR_PAJAK" Then
                If Application.OpenForms().OfType(Of frmFakturPajak).Any Then
                    frmFakturPajak.Activate()
                    frmFakturPajak.WindowState = FormWindowState.Maximized
                Else
                    frmFakturPajak.Show()
                    frmFakturPajak.WindowState = FormWindowState.Maximized
                End If
            End If
            If e.Link.ItemName = "MN_PAYMENT_AR" Then
                If Application.OpenForms().OfType(Of frmpayAR).Any Then
                    frmpayAR.Activate()
                Else
                    frmpayAR.Show()
                End If
            End If
            If e.Link.ItemName = "MN_AR_STATUS" Then
                If Application.OpenForms().OfType(Of frmARList).Any Then
                    frmARList.Activate()
                Else
                    frmARList.Show()
                End If
            End If
            If e.Link.ItemName = "MN_LAPORAN_JUAL" Then
                If Application.OpenForms().OfType(Of FormReportSales).Any Then
                    FormReportSales.Activate()
                    FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage1
                Else
                    FormReportSales.Show()
                    FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage1
                End If
            End If
            If e.Link.ItemName = "MN_LAPORAN_PIUTANG" Then
                If Application.OpenForms().OfType(Of FormReportSales).Any Then
                    FormReportSales.Activate()
                    FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage2
                Else
                    FormReportSales.Show()
                    FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage2
                End If
            End If
            If e.Link.ItemName = "MN_AR_INITBALANCE" Then
                If Application.OpenForms().OfType(Of frmar_initbalance).Any Then
                    frmar_initbalance.Activate()
                Else
                    frmar_initbalance.Show()
                End If
            End If
            If e.Link.ItemName = "MN_SET_MARKETING" Then
                If Application.OpenForms().OfType(Of frmsetmarketing).Any Then
                    frmsetmarketing.Activate()
                Else
                    frmsetmarketing.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CASHIER" Then
                If Application.OpenForms().OfType(Of frmcashier).Any Then
                    frmcashier.Activate()
                    '  frmcashier.WindowState = FormWindowState.Maximized
                Else
                    frmcashier.Show()
                    ' frmcashier.WindowState = FormWindowState.Maximized
                End If
            End If
            If e.Link.ItemName = "MN_CASHIER_REGISTER" Then
                If Application.OpenForms().OfType(Of frmcashierregister).Any Then
                    frmcashierregister.Activate()
                Else
                    frmcashierregister.Show()
                End If
            End If
            If e.Link.ItemName = "MN_MUTASI_CASHIER" Then
                If Application.OpenForms().OfType(Of FormReportSales2).Any Then
                    FormReportSales2.Activate()
                Else
                    FormReportSales2.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CASHIER_RETURN" Then
                If Application.OpenForms().OfType(Of frmcashierreturn).Any Then
                    frmcashierreturn.Activate()
                Else
                    frmcashierreturn.Show()
                End If
            End If
            If e.Link.ItemName = "MN_RECEIPT_MONEY" Then
                If Application.OpenForms().OfType(Of frmreceiptmoney).Any Then
                    frmreceiptmoney.Activate()
                Else
                    frmreceiptmoney.Show()
                End If
            End If
            If e.Link.ItemName = "MN_SPEND_MONEY" Then
                If Application.OpenForms().OfType(Of frmspendmoney).Any Then
                    frmspendmoney.Activate()
                Else
                    frmspendmoney.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CASHBANK_REGISTER" Then
                If Application.OpenForms().OfType(Of frmcashregister).Any Then
                    frmcashregister.Activate()
                Else
                    frmcashregister.Show()
                End If
            End If
            If e.Link.ItemName = "MN_BANK_RECONCILE" Then
                If Application.OpenForms().OfType(Of frmreconcile).Any Then
                    frmreconcile.Activate()
                Else
                    frmreconcile.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CASHBANK_TRANS_REPORT" Then
                If Application.OpenForms().OfType(Of FormReportCash).Any Then
                    FormReportCash.Activate()
                    FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage1
                Else
                    FormReportCash.Show()
                    FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage1
                End If
            End If
            If e.Link.ItemName = "MN_CASHBANK_RECAP_REPORT" Then
                If Application.OpenForms().OfType(Of FormReportCash).Any Then
                    FormReportCash.Activate()
                    FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage2
                Else
                    FormReportCash.Show()
                    FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage2
                End If
            End If
            If e.Link.ItemName = "MN_CONVERSION_COST" Then
                If Application.OpenForms().OfType(Of frmstdcost).Any Then
                    frmstdcost.Activate()
                Else
                    frmstdcost.Show()
                End If
            End If
            If e.Link.ItemName = "MN_WORKING_ORDER" Then
                If Application.OpenForms().OfType(Of frmWO).Any Then
                    frmWO.Activate()
                Else
                    frmWO.Show()
                End If
            End If
            If e.Link.ItemName = "MN_MATERIAL_USAGE" Then
                If Application.OpenForms().OfType(Of frmMaterialUsage).Any Then
                    frmMaterialUsage.Activate()
                Else
                    frmMaterialUsage.Show()
                End If
            End If
            If e.Link.ItemName = "MN_PRODUCTION" Then
                If Application.OpenForms().OfType(Of frmRealisasiWO).Any Then
                    frmRealisasiWO.Activate()
                Else
                    frmRealisasiWO.Show()
                End If
            End If
            If e.Link.ItemName = "MN_MANUFACTURE_REPORT" Then
                If Application.OpenForms().OfType(Of FormReportProduksi).Any Then
                    FormReportProduksi.Activate()
                Else
                    FormReportProduksi.Show()
                End If
            End If
            If e.Link.ItemName = "MN_PRODUCT_FORMULA" Then
                If Application.OpenForms().OfType(Of frmbom).Any Then
                    frmbom.Activate()
                Else
                    frmbom.Show()
                End If
            End If
            If e.Link.ItemName = "MN_ITEM_ASSEMBLY" Then
                If Application.OpenForms().OfType(Of frmassemblyitem).Any Then
                    frmassemblyitem.Activate()
                Else
                    frmassemblyitem.Show()
                End If
            End If
            If e.Link.ItemName = "MN_ASSEMBLY_COST" Then
                If Application.OpenForms().OfType(Of frmstdcost).Any Then
                    frmstdcost.Activate()
                Else
                    frmstdcost.Show()
                End If
            End If
            If e.Link.ItemName = "MN_COA" Then
                If Application.OpenForms().OfType(Of frmcoa).Any Then
                    frmcoa.Activate()
                Else
                    frmcoa.Show()
                End If
            End If
            If e.Link.ItemName = "MN_JOURNAL" Then
                If Application.OpenForms().OfType(Of frmjournal).Any Then
                    frmjournal.Activate()
                Else
                    frmjournal.Show()
                End If
            End If
            If e.Link.ItemName = "MN_ADJUST_JOURNAL" Then
                If Application.OpenForms().OfType(Of frmadjustjournal).Any Then
                    frmadjustjournal.Activate()
                Else
                    frmadjustjournal.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CASHBANK_SETUP" Then
                If Application.OpenForms().OfType(Of frmsetupcashbank).Any Then
                    frmsetupcashbank.Activate()
                Else
                    frmsetupcashbank.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CASHFLOW_SETUP" Then
                If Application.OpenForms().OfType(Of frmsetupcashflow).Any Then
                    frmsetupcashflow.Activate()
                Else
                    frmsetupcashflow.Show()
                End If
            End If
            If e.Link.ItemName = "MN_LEDGER" Then
                If Application.OpenForms().OfType(Of frmledger).Any Then
                    frmledger.Activate()
                Else
                    frmledger.Show()
                End If
            End If
            If e.Link.ItemName = "MN_COA_SETUP" Then
                If Application.OpenForms().OfType(Of frmsetcoa).Any Then
                    frmsetcoa.Activate()
                Else
                    frmsetcoa.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CASHBANK_SETUP" Then
                If Application.OpenForms().OfType(Of frmsetupcashbank).Any Then
                    frmsetupcashbank.Activate()
                Else
                    frmsetupcashbank.Show()
                End If
            End If
            If e.Link.ItemName = "MN_AR_SETUP" Then
                If Application.OpenForms().OfType(Of frmsetcadpiutang).Any Then
                    frmsetcadpiutang.Activate()
                Else
                    frmsetcadpiutang.Show()
                End If
            End If
            If e.Link.ItemName = "MN_AP_SETUP" Then
                If Application.OpenForms().OfType(Of frmsetcadhutang).Any Then
                    frmsetcadhutang.Activate()
                Else
                    frmsetcadhutang.Show()
                End If
            End If

            If e.Link.ItemName = "MN_LEDGER" Then
                If Application.OpenForms().OfType(Of frmledger).Any Then
                    frmledger.Activate()
                Else
                    frmledger.Show()
                End If
            End If
            If e.Link.ItemName = "MN_CLOSE_PERIOD" Then
                If Application.OpenForms().OfType(Of ClosedPeriod).Any Then
                    ClosedPeriod.Activate()
                Else
                    ClosedPeriod.Show()
                End If
            End If
            If e.Link.ItemName = "MN_ACCOUNTING_REPORT" Then
                If Application.OpenForms().OfType(Of FormReportAcc).Any And FormReportAcc.Visible = True Then
                    FormReportAcc.Activate()
                    FormReportAcc.TabControl1.SelectedTabPage = FormReportAcc.TabPage1
                ElseIf FormReportAcc.Visible = False Then
                    FormReportAcc.Show()
                    FormReportAcc.TabControl1.SelectedTabPage = FormReportAcc.TabPage1
                Else
                    FormReportAcc.Show()
                    FormReportAcc.TabControl1.SelectedTabPage = FormReportAcc.TabPage1
                End If
            End If
            If e.Link.ItemName = "MN_ANALYST_REPORT" Then
                If Application.OpenForms().OfType(Of FormReportAcc).Any Then
                    FormReportAcc.Activate()
                    FormReportAcc.TabControl1.SelectedTabPage = FormReportAcc.TabPage1
                Else
                    FormReportAcc.Show()
                    FormReportAcc.TabControl1.SelectedTabPage = FormReportAcc.TabPage1
                End If
            End If
            If e.Link.ItemName = "MN_BACKUP" Then
                If Application.OpenForms().OfType(Of backup).Any Then
                    backup.Activate()
                Else
                    backup.Show()
                End If
            End If
            If e.Link.ItemName = "MN_AUTOBACKUP" Then
                If Application.OpenForms().OfType(Of autoBackup).Any Then
                    autoBackup.Activate()
                Else
                    autoBackup.Show()
                End If
            End If
            If e.Link.ItemName = "MN_RESTORE" Then
                If Application.OpenForms().OfType(Of restore).Any Then
                    restore.Activate()
                Else
                    restore.Show()
                End If
            End If
            If e.Link.ItemName = "MN_LOG" Then
                If Application.OpenForms().OfType(Of frmlog).Any Then
                    frmlog.Activate()
                Else
                    frmlog.Show()
                End If
            End If
            If e.Link.ItemName = "MN_USERMANAGE" Then
                If Application.OpenForms().OfType(Of UserRight).Any Then
                    UserRight.Activate()
                Else
                    UserRight.Show()
                End If
            End If
            If e.Link.ItemName = "MN_SET_PATH" Then
                If Application.OpenForms().OfType(Of frm_path_setup).Any Then
                    frm_path_setup.Activate()
                Else
                    frm_path_setup.Show()
                End If
            End If
            If e.Link.ItemName = "CHANGE_PASS" Then
                If Application.OpenForms().OfType(Of FormPassword).Any Then
                    FormPassword.Activate()
                Else
                    FormPassword.Show()
                End If
            End If
            If e.Link.ItemName = "MN_ITEM_BRAND" Then
                If Application.OpenForms().OfType(Of frmbrandbarang).Any Then
                    frmbrandbarang.Activate()
                Else
                    frmbrandbarang.Show()
                End If
            End If
            If e.Link.ItemName = "MN_GOLONGAN_ASET" Then
                If Application.OpenForms().OfType(Of frmgolaset).Any Then
                    frmgolaset.Activate()
                Else
                    frmgolaset.Show()
                End If
            End If
            If e.Link.ItemName = "MN_NAMA_ASET" Then
                If Application.OpenForms().OfType(Of frmaset).Any Then
                    frmaset.Activate()
                Else
                    frmaset.Show()
                End If
            End If
            If e.Link.ItemName = "MN_COA_ASET_SETUP" Then
                If Application.OpenForms().OfType(Of frmsetcoa_depProduksi).Any Then
                    frmsetcoa_depProduksi.Activate()
                Else
                    frmsetcoa_depProduksi.Show()
                End If
            End If
            If e.Link.ItemName = "MN_DEPR_ASET" Then
                If Application.OpenForms().OfType(Of frmpenyusutanaset).Any Then
                    frmpenyusutanaset.Activate()
                Else
                    frmpenyusutanaset.Show()
                End If
            End If
            If e.Link.ItemName = "MN_DEPR_HISTORY" Then
                If Application.OpenForms().OfType(Of FormLapDepr).Any Then
                    FormLapDepr.Activate()
                    FormLapDepr.WindowState = FormWindowState.Maximized
                    FormLapDepr.Text = "Laporan History Penyusutan Per Periode"
                Else
                    FormLapDepr.Show()
                    FormLapDepr.WindowState = FormWindowState.Maximized
                    FormLapDepr.Text = "Laporan History Penyusutan Per Periode"
                End If
            End If
            If e.Link.ItemName = "MN_ACCUMDEPR_REPORT" Then
                If Application.OpenForms().OfType(Of FormLapAkumDepr).Any Then
                    FormLapAkumDepr.Activate()
                    FormLapAkumDepr.WindowState = FormWindowState.Maximized
                Else
                    FormLapAkumDepr.Show()
                    FormLapAkumDepr.WindowState = FormWindowState.Maximized
                End If
            End If
            'If e.Link.ItemName = "MN_DS_PELAYANAN_KASIR_SENTRAL" Then
            '    If Application.OpenForms().OfType(Of KasirSentral).Any Then
            '        KasirSentral.Activate()
            '    Else
            '        KasirSentral.Show()
            '    End If
            'End If
            'If e.Link.ItemName = "MN_PURCHASING_SIMRS" Then
            '    If Application.OpenForms().OfType(Of Pembelian).Any Then
            '        Pembelian.Activate()
            '    Else
            '        Pembelian.Show()
            '    End If
            'End If
            'If e.Link.ItemName = "MN_RESPONSIBLE_COST" Then
            '    If Application.OpenForms().OfType(Of ImportAplikasiPemrov).Any Then
            '        ImportAplikasiPemrov.Activate()
            '    Else
            '        ImportAplikasiPemrov.Show()
            '    End If
            'End If
            'If e.Link.ItemName = "MN_COA_SETUP_PURCHSIMRS" Then
            '    If Application.OpenForms().OfType(Of FrmSetKomponenCoaPurchase).Any Then
            '        FrmSetKomponenCoaPurchase.Activate()
            '    Else
            '        FrmSetKomponenCoaPurchase.Show()
            '    End If
            'End If
            'If e.Link.ItemName = "MN_PAY_AP_SIMRS" Then
            '    If Application.OpenForms().OfType(Of frmpayAPSIMRS).Any Then
            '        frmpayAPSIMRS.Activate()
            '    Else
            '        frmpayAPSIMRS.Show()
            '    End If
            'End If
            If e.Link.ItemName = "MN_SETTING_KONEKSI_DATABASE_SIMRS" Then
                Process.Start(Application.StartupPath & "\configora.exe")
            End If
            If e.Link.ItemName = "MN_EVENT" Then
                If Application.OpenForms().OfType(Of frmEvent).Any Then
                    frmEvent.Activate()
                Else
                    frmEvent.Show()
                End If
            End If
            If e.Link.ItemName = "MN_EVENT_MEMBER" Then
                If Application.OpenForms().OfType(Of frmEventMember).Any Then
                    frmEventMember.Activate()
                Else
                    frmEventMember.Show()
                End If
            End If
            If e.Link.ItemName = "MN_ATTENDANCE_EVENT" Then
                If Application.OpenForms().OfType(Of frmEventAttendance).Any Then
                    frmEventAttendance.Activate()
                Else
                    frmEventAttendance.Show()
                End If
            End If

            If e.Link.ItemName = "MN_CLEANSING_DB" Then
                If Application.OpenForms().OfType(Of CleansingDB).Any Then
                    CleansingDB.Activate()
                Else
                    CleansingDB.Show()
                End If
            End If
            If e.Link.ItemName = "SETMODULE" Then
                If Application.OpenForms().OfType(Of SetModule).Any Then
                    SetModule.Activate()
                Else
                    SetModule.Show()
                End If
            End If
            If e.Link.ItemName = "MN_SET_COA_DEPPRODUKSI" Then
                If Application.OpenForms().OfType(Of frmsetcoa_depProduksi).Any Then
                    frmsetcoa_depProduksi.Activate()
                Else
                    frmsetcoa_depProduksi.Show()
                End If
            End If
            If e.Link.ItemName = "MN_SIMPAN_PINJAM" Then
                If Application.OpenForms().OfType(Of frmPinjam).Any Then
                    frmPinjam.Activate()
                Else
                    frmPinjam.Show()
                End If
            End If
            If e.Link.ItemName = "ACTIVATED" Then
                If Application.OpenForms().OfType(Of RegisterSoftware).Any Then
                    RegisterSoftware.Activate()
                Else
                    RegisterSoftware.Show()
                End If
            End If
            If e.Link.ItemName = "SETTRIAL" Then
                My.Settings.Activated = False
                My.Settings.ActivationCode = ""
                My.Settings.SerialNumber = ""
                My.Settings.IsExpired = False
                My.Settings.Save()
                MsgBox("Berhasil melakukan set trial", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

               
            End If
            If e.Link.ItemName = "MINIMIZE" Then
                WindowState = FormWindowState.Minimized
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub lbl_logout_Click(sender As System.Object, e As System.EventArgs) Handles lbl_logout.Click
        Dim pesan As String
        pesan = MsgBox("Logout Aplikasi?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi")
        If pesan = vbYes Then
            Me.Close()
            close_conn()
            With LoginFormSambung
                .Show()
                .txt_user.Text = ""
                .txt_password.Text = ""
                .txt_user.Focus()
            End With
        End If
    End Sub

    Private Sub lbl_logout_MouseHover(sender As Object, e As System.EventArgs) Handles lbl_logout.MouseHover
        lbl_logout.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As System.EventArgs) Handles PictureBox2.Click
        If LCase(username) <> "admin" Then
            Try
                SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
                SplashScreenManager.Default.SetWaitFormDescription("Loading Image . . .")
                Dim form As New frmchangephoto
                form.Show()
            Finally
                SplashScreenManager.CloseForm(False)
            End Try
        Else
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Tidak dapat mengubah image Administrator")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Cursor = Cursors.Hand
    End Sub

    Private Sub NavBar_Menu_MouseHover(sender As Object, e As System.EventArgs) Handles NavBar_Menu.MouseHover


    End Sub

    Private Sub MainMenu_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub MainMenu_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick

    End Sub

    Private Sub MainMenu_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Application.OpenForms().OfType(Of SendEmail).Any Then
            SendEmail.Activate()
        Else
            SendEmail.Show()
            SendEmail.MdiParent = Me
        End If
    End Sub

    'Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
    '    FrmCommandPanel.Activate()
    'End Sub

    Private Sub NavBar_Menu_Click(sender As System.Object, e As System.EventArgs) Handles NavBar_Menu.Click

    End Sub
End Class
