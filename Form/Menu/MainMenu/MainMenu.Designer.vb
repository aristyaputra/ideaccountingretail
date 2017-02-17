<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbluser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnCommandPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMasterCust = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMasterSupp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMasterMktg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCardList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnMasterInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItemJenis = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItemCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItemBrand = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMasterItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnStockAwal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMasterService = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnUnit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnUnitConvers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnWH = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnCurrency = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnConvertCurr = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLaporanMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLapDataMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.LapHistoryNilaiMataUangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnStockOpname = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnStockCorrection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItemTransfer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnItemList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnItemReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnStockReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnRequestOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnApprovalPermintaan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnPurchaseOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnReceivedItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnPurchaseInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnPurchaseReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDebitNotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnAP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAPPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAPStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPurchReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPurchStdReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPurchAnalystReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAPAge = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCashPurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCashRO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnApprovalCashRO = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnCashInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCashReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalesOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnSuratJalan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalesInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnSalesReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCreditNotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnARPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnARStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalesReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalesStdReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalesAnalystReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnARAge = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalesOutlet = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCashier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCashierReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnService = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnReparasi = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnServiceMutation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCashBank = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnReceivedMoney = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSpendMoney = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnCashBankReg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnBankReconcile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCashBankReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCashBankHistReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCashRecapReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAccounting = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCOA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCashBank_set = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnJournal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnJournalList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnLedger = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAccReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnStdAccReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFinAnalystReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnBckup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnManageUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ChartBarController1 = New DevExpress.XtraCharts.UI.ChartBarController()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.NavBar_Menu = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_logout = New System.Windows.Forms.Label()
        Me.lbl_user_aktif = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ChartBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBar_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl1.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StatusStrip.ForeColor = System.Drawing.Color.Black
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_time, Me.lbl_date, Me.ToolStripStatusLabel2, Me.lbluser, Me.ToolStripStatusLabel3})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 658)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1344, 23)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        Me.StatusStrip.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Teal
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(95, 18)
        Me.ToolStripStatusLabel1.Text = "System Date : "
        '
        'lbl_time
        '
        Me.lbl_time.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(0, 18)
        '
        'lbl_date
        '
        Me.lbl_date.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(0, 18)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Teal
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(120, 18)
        Me.ToolStripStatusLabel2.Text = "   User Operator :  "
        '
        'lbluser
        '
        Me.lbluser.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.Maroon
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(0, 18)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Teal
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(224, 18)
        Me.ToolStripStatusLabel3.Text = "Point Of Sales System - Main Menu"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.ForeColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnFile, Me.mnMaster, Me.mnStock, Me.mnPurchase, Me.mnCashPurchase, Me.mnSales, Me.mnSalesOutlet, Me.mnService, Me.mnCashBank, Me.mnAccounting, Me.mnTools})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1344, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'mnFile
        '
        Me.mnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnLogin, Me.mnCompany, Me.ToolStripSeparator1, Me.mnCommandPanel, Me.mnExit})
        Me.mnFile.Name = "mnFile"
        Me.mnFile.Size = New System.Drawing.Size(41, 20)
        Me.mnFile.Text = "File"
        '
        'mnLogin
        '
        Me.mnLogin.Image = Global.SMARTACCOUNTING.My.Resources.Resources.login1
        Me.mnLogin.Name = "mnLogin"
        Me.mnLogin.Size = New System.Drawing.Size(175, 22)
        Me.mnLogin.Text = "Login"
        '
        'mnCompany
        '
        Me.mnCompany.Image = Global.SMARTACCOUNTING.My.Resources.Resources.home1
        Me.mnCompany.Name = "mnCompany"
        Me.mnCompany.Size = New System.Drawing.Size(175, 22)
        Me.mnCompany.Text = "Company Set Up"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(172, 6)
        '
        'mnCommandPanel
        '
        Me.mnCommandPanel.Image = Global.SMARTACCOUNTING.My.Resources.Resources.pindah_gudang
        Me.mnCommandPanel.Name = "mnCommandPanel"
        Me.mnCommandPanel.Size = New System.Drawing.Size(175, 22)
        Me.mnCommandPanel.Text = "Command Panel"
        '
        'mnExit
        '
        Me.mnExit.Image = Global.SMARTACCOUNTING.My.Resources.Resources.tutup
        Me.mnExit.Name = "mnExit"
        Me.mnExit.Size = New System.Drawing.Size(175, 22)
        Me.mnExit.Text = "Exit"
        '
        'mnMaster
        '
        Me.mnMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnMasterCust, Me.menuMasterSupp, Me.menuMasterMktg, Me.mnCardList, Me.ToolStripSeparator2, Me.mnMasterInventory, Me.mnMasterService, Me.ToolStripSeparator3, Me.mnUnit, Me.mnUnitConvers, Me.mnWH, Me.ToolStripSeparator4, Me.mnCurrency, Me.mnConvertCurr, Me.mnLaporanMaster})
        Me.mnMaster.Name = "mnMaster"
        Me.mnMaster.Size = New System.Drawing.Size(72, 20)
        Me.mnMaster.Text = "Card File"
        '
        'mnMasterCust
        '
        Me.mnMasterCust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.suppier
        Me.mnMasterCust.Name = "mnMasterCust"
        Me.mnMasterCust.Size = New System.Drawing.Size(195, 22)
        Me.mnMasterCust.Text = "Customer"
        '
        'menuMasterSupp
        '
        Me.menuMasterSupp.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Customer
        Me.menuMasterSupp.Name = "menuMasterSupp"
        Me.menuMasterSupp.Size = New System.Drawing.Size(195, 22)
        Me.menuMasterSupp.Text = "Supplier"
        '
        'menuMasterMktg
        '
        Me.menuMasterMktg.Image = Global.SMARTACCOUNTING.My.Resources.Resources.pegawai
        Me.menuMasterMktg.Name = "menuMasterMktg"
        Me.menuMasterMktg.Size = New System.Drawing.Size(195, 22)
        Me.menuMasterMktg.Text = "Employee"
        '
        'mnCardList
        '
        Me.mnCardList.Image = Global.SMARTACCOUNTING.My.Resources.Resources.daftar_master
        Me.mnCardList.Name = "mnCardList"
        Me.mnCardList.Size = New System.Drawing.Size(195, 22)
        Me.mnCardList.Text = "Card List"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        'mnMasterInventory
        '
        Me.mnMasterInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnItemJenis, Me.mnItemCat, Me.mnItemBrand, Me.mnMasterItem, Me.mnStockAwal})
        Me.mnMasterInventory.Image = Global.SMARTACCOUNTING.My.Resources.Resources.barang
        Me.mnMasterInventory.Name = "mnMasterInventory"
        Me.mnMasterInventory.Size = New System.Drawing.Size(195, 22)
        Me.mnMasterInventory.Text = "Item"
        '
        'mnItemJenis
        '
        Me.mnItemJenis.Image = Global.SMARTACCOUNTING.My.Resources.Resources.jenis
        Me.mnItemJenis.Name = "mnItemJenis"
        Me.mnItemJenis.Size = New System.Drawing.Size(177, 22)
        Me.mnItemJenis.Text = "Item Type"
        '
        'mnItemCat
        '
        Me.mnItemCat.Image = Global.SMARTACCOUNTING.My.Resources.Resources.kategori
        Me.mnItemCat.Name = "mnItemCat"
        Me.mnItemCat.Size = New System.Drawing.Size(177, 22)
        Me.mnItemCat.Text = "Item Category"
        '
        'mnItemBrand
        '
        Me.mnItemBrand.Name = "mnItemBrand"
        Me.mnItemBrand.Size = New System.Drawing.Size(177, 22)
        Me.mnItemBrand.Text = "Brand"
        Me.mnItemBrand.Visible = False
        '
        'mnMasterItem
        '
        Me.mnMasterItem.Image = Global.SMARTACCOUNTING.My.Resources.Resources.data_barang
        Me.mnMasterItem.Name = "mnMasterItem"
        Me.mnMasterItem.Size = New System.Drawing.Size(177, 22)
        Me.mnMasterItem.Text = "Item Name"
        '
        'mnStockAwal
        '
        Me.mnStockAwal.Image = Global.SMARTACCOUNTING.My.Resources.Resources.saldo
        Me.mnStockAwal.Name = "mnStockAwal"
        Me.mnStockAwal.Size = New System.Drawing.Size(177, 22)
        Me.mnStockAwal.Text = "Begining Balance"
        '
        'mnMasterService
        '
        Me.mnMasterService.Image = Global.SMARTACCOUNTING.My.Resources.Resources.services
        Me.mnMasterService.Name = "mnMasterService"
        Me.mnMasterService.Size = New System.Drawing.Size(195, 22)
        Me.mnMasterService.Text = "Jenis Jasa"
        Me.mnMasterService.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(192, 6)
        '
        'mnUnit
        '
        Me.mnUnit.Image = Global.SMARTACCOUNTING.My.Resources.Resources.unit
        Me.mnUnit.Name = "mnUnit"
        Me.mnUnit.Size = New System.Drawing.Size(195, 22)
        Me.mnUnit.Text = "Unit"
        '
        'mnUnitConvers
        '
        Me.mnUnitConvers.Image = Global.SMARTACCOUNTING.My.Resources.Resources.konversi_unit
        Me.mnUnitConvers.Name = "mnUnitConvers"
        Me.mnUnitConvers.Size = New System.Drawing.Size(195, 22)
        Me.mnUnitConvers.Text = "Unit Conversion"
        '
        'mnWH
        '
        Me.mnWH.Image = Global.SMARTACCOUNTING.My.Resources.Resources.gudang
        Me.mnWH.Name = "mnWH"
        Me.mnWH.Size = New System.Drawing.Size(195, 22)
        Me.mnWH.Text = "Warehouse"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(192, 6)
        '
        'mnCurrency
        '
        Me.mnCurrency.Image = Global.SMARTACCOUNTING.My.Resources.Resources.mata_uang
        Me.mnCurrency.Name = "mnCurrency"
        Me.mnCurrency.Size = New System.Drawing.Size(195, 22)
        Me.mnCurrency.Text = "Currency"
        '
        'mnConvertCurr
        '
        Me.mnConvertCurr.Image = Global.SMARTACCOUNTING.My.Resources.Resources.konvert_matauang
        Me.mnConvertCurr.Name = "mnConvertCurr"
        Me.mnConvertCurr.Size = New System.Drawing.Size(195, 22)
        Me.mnConvertCurr.Text = "Currency Conversion"
        '
        'mnLaporanMaster
        '
        Me.mnLaporanMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnLapDataMaster, Me.LapHistoryNilaiMataUangToolStripMenuItem})
        Me.mnLaporanMaster.Image = Global.SMARTACCOUNTING.My.Resources.Resources.report
        Me.mnLaporanMaster.Name = "mnLaporanMaster"
        Me.mnLaporanMaster.Size = New System.Drawing.Size(195, 22)
        Me.mnLaporanMaster.Text = "Report"
        '
        'mnLapDataMaster
        '
        Me.mnLapDataMaster.Image = Global.SMARTACCOUNTING.My.Resources.Resources.daftar_master
        Me.mnLapDataMaster.Name = "mnLapDataMaster"
        Me.mnLapDataMaster.Size = New System.Drawing.Size(240, 22)
        Me.mnLapDataMaster.Text = "Card File Report"
        '
        'LapHistoryNilaiMataUangToolStripMenuItem
        '
        Me.LapHistoryNilaiMataUangToolStripMenuItem.Image = Global.SMARTACCOUNTING.My.Resources.Resources.mata_uang
        Me.LapHistoryNilaiMataUangToolStripMenuItem.Name = "LapHistoryNilaiMataUangToolStripMenuItem"
        Me.LapHistoryNilaiMataUangToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.LapHistoryNilaiMataUangToolStripMenuItem.Text = "History Currency Conversion"
        '
        'mnStock
        '
        Me.mnStock.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnStockOpname, Me.ToolStripSeparator12, Me.mnStockCorrection, Me.mnItemTransfer, Me.ToolStripSeparator13, Me.mnItemList, Me.mnItemReport})
        Me.mnStock.Name = "mnStock"
        Me.mnStock.Size = New System.Drawing.Size(54, 20)
        Me.mnStock.Text = "Stock"
        '
        'mnStockOpname
        '
        Me.mnStockOpname.Image = Global.SMARTACCOUNTING.My.Resources.Resources.opname
        Me.mnStockOpname.Name = "mnStockOpname"
        Me.mnStockOpname.Size = New System.Drawing.Size(173, 22)
        Me.mnStockOpname.Text = "Stock Opname"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(170, 6)
        '
        'mnStockCorrection
        '
        Me.mnStockCorrection.Image = Global.SMARTACCOUNTING.My.Resources.Resources.koreksi_stok
        Me.mnStockCorrection.Name = "mnStockCorrection"
        Me.mnStockCorrection.Size = New System.Drawing.Size(173, 22)
        Me.mnStockCorrection.Text = "Stock Correction"
        '
        'mnItemTransfer
        '
        Me.mnItemTransfer.Image = Global.SMARTACCOUNTING.My.Resources.Resources.pindah_gudang
        Me.mnItemTransfer.Name = "mnItemTransfer"
        Me.mnItemTransfer.Size = New System.Drawing.Size(173, 22)
        Me.mnItemTransfer.Text = "Move Item"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(170, 6)
        '
        'mnItemList
        '
        Me.mnItemList.Image = Global.SMARTACCOUNTING.My.Resources.Resources.list_barang
        Me.mnItemList.Name = "mnItemList"
        Me.mnItemList.Size = New System.Drawing.Size(173, 22)
        Me.mnItemList.Text = "Item List"
        '
        'mnItemReport
        '
        Me.mnItemReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnStockReport})
        Me.mnItemReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.report
        Me.mnItemReport.Name = "mnItemReport"
        Me.mnItemReport.Size = New System.Drawing.Size(173, 22)
        Me.mnItemReport.Text = "Report"
        '
        'mnStockReport
        '
        Me.mnStockReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.stock_report
        Me.mnStockReport.Name = "mnStockReport"
        Me.mnStockReport.Size = New System.Drawing.Size(160, 22)
        Me.mnStockReport.Text = "Laporan Stock"
        '
        'mnPurchase
        '
        Me.mnPurchase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnRequestOrder, Me.mnApprovalPermintaan, Me.ToolStripSeparator17, Me.mnPurchaseOrder, Me.mnReceivedItem, Me.ToolStripSeparator20, Me.mnPurchaseInvoice, Me.ToolStripSeparator5, Me.mnPurchaseReturn, Me.mnDebitNotes, Me.ToolStripSeparator6, Me.mnAP, Me.mnPurchReport})
        Me.mnPurchase.Name = "mnPurchase"
        Me.mnPurchase.Size = New System.Drawing.Size(75, 20)
        Me.mnPurchase.Text = "Purchase"
        '
        'mnRequestOrder
        '
        Me.mnRequestOrder.Image = Global.SMARTACCOUNTING.My.Resources.Resources.ro
        Me.mnRequestOrder.Name = "mnRequestOrder"
        Me.mnRequestOrder.Size = New System.Drawing.Size(183, 22)
        Me.mnRequestOrder.Text = "Purchase Request"
        '
        'mnApprovalPermintaan
        '
        Me.mnApprovalPermintaan.Image = Global.SMARTACCOUNTING.My.Resources.Resources.baru
        Me.mnApprovalPermintaan.Name = "mnApprovalPermintaan"
        Me.mnApprovalPermintaan.Size = New System.Drawing.Size(183, 22)
        Me.mnApprovalPermintaan.Text = "Request Approval"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(180, 6)
        '
        'mnPurchaseOrder
        '
        Me.mnPurchaseOrder.Image = Global.SMARTACCOUNTING.My.Resources.Resources.ro
        Me.mnPurchaseOrder.Name = "mnPurchaseOrder"
        Me.mnPurchaseOrder.Size = New System.Drawing.Size(183, 22)
        Me.mnPurchaseOrder.Text = "Purchase Order"
        '
        'mnReceivedItem
        '
        Me.mnReceivedItem.Image = Global.SMARTACCOUNTING.My.Resources.Resources.received_item
        Me.mnReceivedItem.Name = "mnReceivedItem"
        Me.mnReceivedItem.Size = New System.Drawing.Size(183, 22)
        Me.mnReceivedItem.Text = "Received Order"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(180, 6)
        '
        'mnPurchaseInvoice
        '
        Me.mnPurchaseInvoice.Image = Global.SMARTACCOUNTING.My.Resources.Resources.faktur
        Me.mnPurchaseInvoice.Name = "mnPurchaseInvoice"
        Me.mnPurchaseInvoice.Size = New System.Drawing.Size(183, 22)
        Me.mnPurchaseInvoice.Text = "Purchase Invoice"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(180, 6)
        '
        'mnPurchaseReturn
        '
        Me.mnPurchaseReturn.Image = Global.SMARTACCOUNTING.My.Resources.Resources.retur
        Me.mnPurchaseReturn.Name = "mnPurchaseReturn"
        Me.mnPurchaseReturn.Size = New System.Drawing.Size(183, 22)
        Me.mnPurchaseReturn.Text = "Purchase Return"
        '
        'mnDebitNotes
        '
        Me.mnDebitNotes.Name = "mnDebitNotes"
        Me.mnDebitNotes.Size = New System.Drawing.Size(183, 22)
        Me.mnDebitNotes.Text = "Debit Notes"
        Me.mnDebitNotes.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(180, 6)
        '
        'mnAP
        '
        Me.mnAP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAPPayment, Me.mnAPStatus})
        Me.mnAP.Image = Global.SMARTACCOUNTING.My.Resources.Resources.kredit
        Me.mnAP.Name = "mnAP"
        Me.mnAP.Size = New System.Drawing.Size(183, 22)
        Me.mnAP.Text = "Account Payable"
        '
        'mnAPPayment
        '
        Me.mnAPPayment.Name = "mnAPPayment"
        Me.mnAPPayment.Size = New System.Drawing.Size(194, 22)
        Me.mnAPPayment.Text = "Pembayaran Hutang"
        '
        'mnAPStatus
        '
        Me.mnAPStatus.Image = Global.SMARTACCOUNTING.My.Resources.Resources.status_credit
        Me.mnAPStatus.Name = "mnAPStatus"
        Me.mnAPStatus.Size = New System.Drawing.Size(194, 22)
        Me.mnAPStatus.Text = "Status Hutang"
        '
        'mnPurchReport
        '
        Me.mnPurchReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPurchStdReport, Me.mnPurchAnalystReport, Me.mnAPAge})
        Me.mnPurchReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.report
        Me.mnPurchReport.Name = "mnPurchReport"
        Me.mnPurchReport.Size = New System.Drawing.Size(183, 22)
        Me.mnPurchReport.Text = "Report"
        '
        'mnPurchStdReport
        '
        Me.mnPurchStdReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.std_report
        Me.mnPurchStdReport.Name = "mnPurchStdReport"
        Me.mnPurchStdReport.Size = New System.Drawing.Size(229, 22)
        Me.mnPurchStdReport.Text = "Purchase Report"
        '
        'mnPurchAnalystReport
        '
        Me.mnPurchAnalystReport.Name = "mnPurchAnalystReport"
        Me.mnPurchAnalystReport.Size = New System.Drawing.Size(229, 22)
        Me.mnPurchAnalystReport.Text = "Laporan Analisa Penjualan"
        Me.mnPurchAnalystReport.Visible = False
        '
        'mnAPAge
        '
        Me.mnAPAge.Image = Global.SMARTACCOUNTING.My.Resources.Resources.timer
        Me.mnAPAge.Name = "mnAPAge"
        Me.mnAPAge.Size = New System.Drawing.Size(229, 22)
        Me.mnAPAge.Text = "Account Payable Report"
        '
        'mnCashPurchase
        '
        Me.mnCashPurchase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnCashRO, Me.mnApprovalCashRO, Me.ToolStripSeparator22, Me.mnCashInvoice, Me.mnCashReturn})
        Me.mnCashPurchase.Name = "mnCashPurchase"
        Me.mnCashPurchase.Size = New System.Drawing.Size(109, 20)
        Me.mnCashPurchase.Text = "Cash Purchase"
        '
        'mnCashRO
        '
        Me.mnCashRO.Image = Global.SMARTACCOUNTING.My.Resources.Resources.daftar_master
        Me.mnCashRO.Name = "mnCashRO"
        Me.mnCashRO.Size = New System.Drawing.Size(183, 22)
        Me.mnCashRO.Text = "Purchase Request"
        '
        'mnApprovalCashRO
        '
        Me.mnApprovalCashRO.Image = Global.SMARTACCOUNTING.My.Resources.Resources.rekon
        Me.mnApprovalCashRO.Name = "mnApprovalCashRO"
        Me.mnApprovalCashRO.Size = New System.Drawing.Size(183, 22)
        Me.mnApprovalCashRO.Text = "Request Approval"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(180, 6)
        '
        'mnCashInvoice
        '
        Me.mnCashInvoice.Image = Global.SMARTACCOUNTING.My.Resources.Resources.received_item
        Me.mnCashInvoice.Name = "mnCashInvoice"
        Me.mnCashInvoice.Size = New System.Drawing.Size(183, 22)
        Me.mnCashInvoice.Text = "Purchase Invoice"
        '
        'mnCashReturn
        '
        Me.mnCashReturn.Image = Global.SMARTACCOUNTING.My.Resources.Resources.retur
        Me.mnCashReturn.Name = "mnCashReturn"
        Me.mnCashReturn.Size = New System.Drawing.Size(183, 22)
        Me.mnCashReturn.Text = "Purchase Return"
        '
        'mnSales
        '
        Me.mnSales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnSalesOrder, Me.ToolStripSeparator21, Me.mnSuratJalan, Me.mnSalesInvoice, Me.ToolStripSeparator7, Me.mnSalesReturn, Me.mnCreditNotes, Me.ToolStripSeparator8, Me.mnAR, Me.mnSalesReport})
        Me.mnSales.Name = "mnSales"
        Me.mnSales.Size = New System.Drawing.Size(53, 20)
        Me.mnSales.Text = "Sales"
        '
        'mnSalesOrder
        '
        Me.mnSalesOrder.Image = Global.SMARTACCOUNTING.My.Resources.Resources.ro
        Me.mnSalesOrder.Name = "mnSalesOrder"
        Me.mnSalesOrder.Size = New System.Drawing.Size(190, 22)
        Me.mnSalesOrder.Text = "Sales Order"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(187, 6)
        '
        'mnSuratJalan
        '
        Me.mnSuratJalan.Image = Global.SMARTACCOUNTING.My.Resources.Resources.pindah_gudang
        Me.mnSuratJalan.Name = "mnSuratJalan"
        Me.mnSuratJalan.Size = New System.Drawing.Size(190, 22)
        Me.mnSuratJalan.Text = "Delivered Item"
        '
        'mnSalesInvoice
        '
        Me.mnSalesInvoice.Image = Global.SMARTACCOUNTING.My.Resources.Resources.faktur
        Me.mnSalesInvoice.Name = "mnSalesInvoice"
        Me.mnSalesInvoice.Size = New System.Drawing.Size(190, 22)
        Me.mnSalesInvoice.Text = "Sales Invoice"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(187, 6)
        '
        'mnSalesReturn
        '
        Me.mnSalesReturn.Image = Global.SMARTACCOUNTING.My.Resources.Resources.retur
        Me.mnSalesReturn.Name = "mnSalesReturn"
        Me.mnSalesReturn.Size = New System.Drawing.Size(190, 22)
        Me.mnSalesReturn.Text = "Sales Return"
        '
        'mnCreditNotes
        '
        Me.mnCreditNotes.Name = "mnCreditNotes"
        Me.mnCreditNotes.Size = New System.Drawing.Size(190, 22)
        Me.mnCreditNotes.Text = "Credit Notes"
        Me.mnCreditNotes.Visible = False
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(187, 6)
        '
        'mnAR
        '
        Me.mnAR.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnARPayment, Me.mnARStatus})
        Me.mnAR.Image = Global.SMARTACCOUNTING.My.Resources.Resources.kredit
        Me.mnAR.Name = "mnAR"
        Me.mnAR.Size = New System.Drawing.Size(190, 22)
        Me.mnAR.Text = "Account Receivable"
        '
        'mnARPayment
        '
        Me.mnARPayment.Image = Global.SMARTACCOUNTING.My.Resources.Resources.saldo
        Me.mnARPayment.Name = "mnARPayment"
        Me.mnARPayment.Size = New System.Drawing.Size(197, 22)
        Me.mnARPayment.Text = "Pembayaran Piutang"
        '
        'mnARStatus
        '
        Me.mnARStatus.Image = Global.SMARTACCOUNTING.My.Resources.Resources.status_credit
        Me.mnARStatus.Name = "mnARStatus"
        Me.mnARStatus.Size = New System.Drawing.Size(197, 22)
        Me.mnARStatus.Text = "Status Piutang"
        '
        'mnSalesReport
        '
        Me.mnSalesReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnSalesStdReport, Me.mnSalesAnalystReport, Me.mnARAge})
        Me.mnSalesReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.report
        Me.mnSalesReport.Name = "mnSalesReport"
        Me.mnSalesReport.Size = New System.Drawing.Size(190, 22)
        Me.mnSalesReport.Text = "Report"
        '
        'mnSalesStdReport
        '
        Me.mnSalesStdReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.std_report
        Me.mnSalesStdReport.Name = "mnSalesStdReport"
        Me.mnSalesStdReport.Size = New System.Drawing.Size(232, 22)
        Me.mnSalesStdReport.Text = "Sales Report"
        '
        'mnSalesAnalystReport
        '
        Me.mnSalesAnalystReport.Name = "mnSalesAnalystReport"
        Me.mnSalesAnalystReport.Size = New System.Drawing.Size(232, 22)
        Me.mnSalesAnalystReport.Text = "Analyst Report"
        Me.mnSalesAnalystReport.Visible = False
        '
        'mnARAge
        '
        Me.mnARAge.Image = Global.SMARTACCOUNTING.My.Resources.Resources.timer
        Me.mnARAge.Name = "mnARAge"
        Me.mnARAge.Size = New System.Drawing.Size(232, 22)
        Me.mnARAge.Text = "Account Receiveble Report"
        '
        'mnSalesOutlet
        '
        Me.mnSalesOutlet.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnCashier, Me.mnCashierReport})
        Me.mnSalesOutlet.Name = "mnSalesOutlet"
        Me.mnSalesOutlet.Size = New System.Drawing.Size(92, 20)
        Me.mnSalesOutlet.Text = "Outlet Sales"
        '
        'mnCashier
        '
        Me.mnCashier.Image = Global.SMARTACCOUNTING.My.Resources.Resources.terima
        Me.mnCashier.Name = "mnCashier"
        Me.mnCashier.Size = New System.Drawing.Size(172, 22)
        Me.mnCashier.Text = "Cashier"
        '
        'mnCashierReport
        '
        Me.mnCashierReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.status_credit
        Me.mnCashierReport.Name = "mnCashierReport"
        Me.mnCashierReport.Size = New System.Drawing.Size(172, 22)
        Me.mnCashierReport.Text = "Cashier Register"
        '
        'mnService
        '
        Me.mnService.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnReparasi, Me.mnServiceMutation})
        Me.mnService.Name = "mnService"
        Me.mnService.Size = New System.Drawing.Size(62, 20)
        Me.mnService.Text = "Service"
        Me.mnService.Visible = False
        '
        'mnReparasi
        '
        Me.mnReparasi.Image = Global.SMARTACCOUNTING.My.Resources.Resources.reparasi
        Me.mnReparasi.Name = "mnReparasi"
        Me.mnReparasi.Size = New System.Drawing.Size(172, 22)
        Me.mnReparasi.Text = "Transaksi Jasa"
        '
        'mnServiceMutation
        '
        Me.mnServiceMutation.Name = "mnServiceMutation"
        Me.mnServiceMutation.Size = New System.Drawing.Size(172, 22)
        Me.mnServiceMutation.Text = "Service Mutation"
        '
        'mnCashBank
        '
        Me.mnCashBank.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnReceivedMoney, Me.mnSpendMoney, Me.ToolStripSeparator11, Me.mnCashBankReg, Me.mnBankReconcile, Me.mnCashBankReport})
        Me.mnCashBank.Name = "mnCashBank"
        Me.mnCashBank.Size = New System.Drawing.Size(84, 20)
        Me.mnCashBank.Text = "Cash Bank"
        '
        'mnReceivedMoney
        '
        Me.mnReceivedMoney.Image = Global.SMARTACCOUNTING.My.Resources.Resources.terima
        Me.mnReceivedMoney.Name = "mnReceivedMoney"
        Me.mnReceivedMoney.Size = New System.Drawing.Size(192, 22)
        Me.mnReceivedMoney.Text = "Receipt Money"
        '
        'mnSpendMoney
        '
        Me.mnSpendMoney.Image = Global.SMARTACCOUNTING.My.Resources.Resources.bayar
        Me.mnSpendMoney.Name = "mnSpendMoney"
        Me.mnSpendMoney.Size = New System.Drawing.Size(192, 22)
        Me.mnSpendMoney.Text = "Spent Money"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(189, 6)
        '
        'mnCashBankReg
        '
        Me.mnCashBankReg.Image = Global.SMARTACCOUNTING.My.Resources.Resources.cash_his
        Me.mnCashBankReg.Name = "mnCashBankReg"
        Me.mnCashBankReg.Size = New System.Drawing.Size(192, 22)
        Me.mnCashBankReg.Text = "Cash Bank Register"
        '
        'mnBankReconcile
        '
        Me.mnBankReconcile.Image = Global.SMARTACCOUNTING.My.Resources.Resources.rekon
        Me.mnBankReconcile.Name = "mnBankReconcile"
        Me.mnBankReconcile.Size = New System.Drawing.Size(192, 22)
        Me.mnBankReconcile.Text = "Bank Reconcile"
        '
        'mnCashBankReport
        '
        Me.mnCashBankReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnCashBankHistReport, Me.mnCashRecapReport})
        Me.mnCashBankReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.report
        Me.mnCashBankReport.Name = "mnCashBankReport"
        Me.mnCashBankReport.Size = New System.Drawing.Size(192, 22)
        Me.mnCashBankReport.Text = "Report"
        '
        'mnCashBankHistReport
        '
        Me.mnCashBankHistReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.list_barang
        Me.mnCashBankHistReport.Name = "mnCashBankHistReport"
        Me.mnCashBankHistReport.Size = New System.Drawing.Size(200, 22)
        Me.mnCashBankHistReport.Text = "Transaction Report"
        '
        'mnCashRecapReport
        '
        Me.mnCashRecapReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.list_barang
        Me.mnCashRecapReport.Name = "mnCashRecapReport"
        Me.mnCashRecapReport.Size = New System.Drawing.Size(200, 22)
        Me.mnCashRecapReport.Text = "Rekapitulation Report"
        '
        'mnAccounting
        '
        Me.mnAccounting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnCOA, Me.mnCashBank_set, Me.ToolStripSeparator14, Me.mnJournal, Me.mnJournalList, Me.ToolStripSeparator15, Me.mnLedger, Me.mnAccReport})
        Me.mnAccounting.Name = "mnAccounting"
        Me.mnAccounting.Size = New System.Drawing.Size(85, 20)
        Me.mnAccounting.Text = "Accounting"
        '
        'mnCOA
        '
        Me.mnCOA.Image = Global.SMARTACCOUNTING.My.Resources.Resources.jenis
        Me.mnCOA.Name = "mnCOA"
        Me.mnCOA.Size = New System.Drawing.Size(178, 22)
        Me.mnCOA.Text = "Chart Of Account"
        '
        'mnCashBank_set
        '
        Me.mnCashBank_set.Name = "mnCashBank_set"
        Me.mnCashBank_set.Size = New System.Drawing.Size(178, 22)
        Me.mnCashBank_set.Text = "Cash Bank Setup"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(175, 6)
        '
        'mnJournal
        '
        Me.mnJournal.Image = Global.SMARTACCOUNTING.My.Resources.Resources.faktur
        Me.mnJournal.Name = "mnJournal"
        Me.mnJournal.Size = New System.Drawing.Size(178, 22)
        Me.mnJournal.Text = "General Journal"
        '
        'mnJournalList
        '
        Me.mnJournalList.Image = Global.SMARTACCOUNTING.My.Resources.Resources.daftar_master
        Me.mnJournalList.Name = "mnJournalList"
        Me.mnJournalList.Size = New System.Drawing.Size(178, 22)
        Me.mnJournalList.Text = "Journal List"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(175, 6)
        '
        'mnLedger
        '
        Me.mnLedger.Image = Global.SMARTACCOUNTING.My.Resources.Resources.report
        Me.mnLedger.Name = "mnLedger"
        Me.mnLedger.Size = New System.Drawing.Size(178, 22)
        Me.mnLedger.Text = "Ledger"
        '
        'mnAccReport
        '
        Me.mnAccReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnStdAccReport, Me.mnFinAnalystReport})
        Me.mnAccReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.report
        Me.mnAccReport.Name = "mnAccReport"
        Me.mnAccReport.Size = New System.Drawing.Size(178, 22)
        Me.mnAccReport.Text = "Report"
        '
        'mnStdAccReport
        '
        Me.mnStdAccReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.rekon
        Me.mnStdAccReport.Name = "mnStdAccReport"
        Me.mnStdAccReport.Size = New System.Drawing.Size(183, 22)
        Me.mnStdAccReport.Text = "Accounting Report"
        '
        'mnFinAnalystReport
        '
        Me.mnFinAnalystReport.Image = Global.SMARTACCOUNTING.My.Resources.Resources.rekon
        Me.mnFinAnalystReport.Name = "mnFinAnalystReport"
        Me.mnFinAnalystReport.Size = New System.Drawing.Size(183, 22)
        Me.mnFinAnalystReport.Text = "Analyst Report"
        Me.mnFinAnalystReport.Visible = False
        '
        'mnTools
        '
        Me.mnTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnBckup, Me.mnRestore, Me.ToolStripSeparator16, Me.mnLog, Me.mnManageUser})
        Me.mnTools.Name = "mnTools"
        Me.mnTools.Size = New System.Drawing.Size(50, 20)
        Me.mnTools.Text = "Tools"
        '
        'mnBckup
        '
        Me.mnBckup.Name = "mnBckup"
        Me.mnBckup.Size = New System.Drawing.Size(182, 22)
        Me.mnBckup.Text = "Backup"
        '
        'mnRestore
        '
        Me.mnRestore.Name = "mnRestore"
        Me.mnRestore.Size = New System.Drawing.Size(182, 22)
        Me.mnRestore.Text = "Restore"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(179, 6)
        '
        'mnLog
        '
        Me.mnLog.Image = Global.SMARTACCOUNTING.My.Resources.Resources.jenis
        Me.mnLog.Name = "mnLog"
        Me.mnLog.Size = New System.Drawing.Size(182, 22)
        Me.mnLog.Text = "History Transaksi"
        '
        'mnManageUser
        '
        Me.mnManageUser.Name = "mnManageUser"
        Me.mnManageUser.Size = New System.Drawing.Size(182, 22)
        Me.mnManageUser.Text = "User Management"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.Image = Global.SMARTACCOUNTING.My.Resources.Resources.status_credit
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton3.Location = New System.Drawing.Point(7, 5)
        Me.SimpleButton3.LookAndFeel.SkinName = "Metropolis"
        Me.SimpleButton3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(42, 33)
        Me.SimpleButton3.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.tutup
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(139, 5)
        Me.SimpleButton1.LookAndFeel.SkinName = "Metropolis"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(42, 33)
        Me.SimpleButton1.TabIndex = 0
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.timer
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(91, 6)
        Me.SimpleButton2.LookAndFeel.SkinName = "Metropolis"
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(42, 33)
        Me.SimpleButton2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(134, 551)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton4.Appearance.Options.UseForeColor = True
        Me.SimpleButton4.Image = Global.SMARTACCOUNTING.My.Resources.Resources.reset
        Me.SimpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton4.Location = New System.Drawing.Point(51, 5)
        Me.SimpleButton4.LookAndFeel.SkinName = "Metropolis"
        Me.SimpleButton4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(42, 33)
        Me.SimpleButton4.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(308, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 29)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Accounting"
        Me.Label2.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseForeColor = True
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton4)
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.SimpleButton3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 637)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1344, 44)
        Me.PanelControl1.TabIndex = 20
        Me.PanelControl1.Visible = False
        '
        'Timer
        '
        '
        'NavBar_Menu
        '
        Me.NavBar_Menu.ActiveGroup = Nothing
        Me.NavBar_Menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NavBar_Menu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NavBar_Menu.ForeColor = System.Drawing.Color.Black
        Me.NavBar_Menu.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1})
        Me.NavBar_Menu.Location = New System.Drawing.Point(0, 131)
        Me.NavBar_Menu.LookAndFeel.SkinName = "Metropolis"
        Me.NavBar_Menu.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NavBar_Menu.Name = "NavBar_Menu"
        Me.NavBar_Menu.OptionsNavPane.ExpandedWidth = 232
        Me.NavBar_Menu.Size = New System.Drawing.Size(232, 506)
        Me.NavBar_Menu.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar
        Me.NavBar_Menu.StoreDefaultPaintStyleName = True
        Me.NavBar_Menu.TabIndex = 34
        Me.NavBar_Menu.Text = "NavBarControl1"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "NavBarItem1"
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(90, 90)
        Me.Panel2.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.ForeColor = System.Drawing.Color.Black
        Me.PictureBox2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Capture
        Me.PictureBox2.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'lbl_logout
        '
        Me.lbl_logout.AutoSize = True
        Me.lbl_logout.BackColor = System.Drawing.Color.Red
        Me.lbl_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_logout.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_logout.Location = New System.Drawing.Point(95, 76)
        Me.lbl_logout.Name = "lbl_logout"
        Me.lbl_logout.Size = New System.Drawing.Size(50, 14)
        Me.lbl_logout.TabIndex = 3
        Me.lbl_logout.Text = "LOGOUT"
        '
        'lbl_user_aktif
        '
        Me.lbl_user_aktif.AutoSize = True
        Me.lbl_user_aktif.BackColor = System.Drawing.Color.Transparent
        Me.lbl_user_aktif.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user_aktif.ForeColor = System.Drawing.Color.Black
        Me.lbl_user_aktif.Location = New System.Drawing.Point(95, 5)
        Me.lbl_user_aktif.Name = "lbl_user_aktif"
        Me.lbl_user_aktif.Size = New System.Drawing.Size(56, 14)
        Me.lbl_user_aktif.TabIndex = 1
        Me.lbl_user_aktif.Text = "Muslimah"
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.BackColor = System.Drawing.Color.Transparent
        Me.lbl_position.ForeColor = System.Drawing.Color.Black
        Me.lbl_position.Location = New System.Drawing.Point(95, 29)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(102, 14)
        Me.lbl_position.TabIndex = 2
        Me.lbl_position.Text = "Accounting Officer"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel1.Controls.Add(Me.NavBarControl1)
        Me.Panel1.Controls.Add(Me.NavBar_Menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 637)
        Me.Panel1.TabIndex = 36
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.NavBarControl1.ForeColor = System.Drawing.Color.Black
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem2})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.LookAndFeel.SkinName = "Metropolis"
        Me.NavBarControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 232
        Me.NavBarControl1.Size = New System.Drawing.Size(232, 134)
        Me.NavBarControl1.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar
        Me.NavBarControl1.StoreDefaultPaintStyleName = True
        Me.NavBarControl1.TabIndex = 35
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Selamat Bekerja!"
        Me.NavBarGroup1.ControlContainer = Me.NavBarGroupControlContainer1
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupClientHeight = 102
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.LinkLabel1)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.Panel2)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.lbl_logout)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.lbl_position)
        Me.NavBarGroupControlContainer1.Controls.Add(Me.lbl_user_aktif)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(224, 95)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(150, 76)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 14)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "SEND EMAIL"
        Me.LinkLabel1.Visible = False
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "NavBarItem1"
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenu"
        Me.Text = "Pi-Accounting (Registered)"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.ChartBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBar_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnMasterCust As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMasterSupp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuMasterMktg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnMasterInventory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnItemCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnItemBrand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnMasterItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnStockAwal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnMasterService As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnUnit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnUnitConvers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnWH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnCurrency As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnConvertCurr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPurchase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnRequestOrder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPurchaseOrder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCompany As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnReceivedItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPurchaseInvoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnPurchaseReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnDebitNotes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnAP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSalesOrder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSalesInvoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnSalesReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCreditNotes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnAR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCashBank As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnAPPayment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnAPStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnARPayment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnARStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnReceivedMoney As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSpendMoney As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnCashBankReg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnBankReconcile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnAccounting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnStockOpname As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnStockCorrection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnItemTransfer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnItemList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnJournal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPurchReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPurchStdReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPurchAnalystReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSalesReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSalesStdReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCOA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnJournalList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnLedger As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnAccReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnStdAccReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnFinAnalystReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSalesAnalystReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCashBankReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCashBankHistReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCashRecapReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnBckup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnItemReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnStockReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnItemJenis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnAPAge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnARAge As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCardList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnService As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnReparasi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCommandPanel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLaporanMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnLapDataMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LapHistoryNilaiMataUangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnApprovalPermintaan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnSuratJalan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCashPurchase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCashRO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnApprovalCashRO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnCashInvoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCashReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnSalesOutlet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCashier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnCashierReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_time As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnCashBank_set As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnManageUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents ChartBarController1 As DevExpress.XtraCharts.UI.ChartBarController
    Friend WithEvents mnServiceMutation As System.Windows.Forms.ToolStripMenuItem
    'Public WithEvents MyStatusBar As XtremeCommandBars.StatusBar
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents NavBar_Menu As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_position As System.Windows.Forms.Label
    Friend WithEvents lbl_user_aktif As System.Windows.Forms.Label
    Friend WithEvents lbl_logout As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
