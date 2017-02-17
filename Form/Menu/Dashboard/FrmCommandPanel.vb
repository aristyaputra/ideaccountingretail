Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports System.IO
Imports System.Diagnostics

Public Class FrmCommandPanel
    Dim card_file As Boolean
    Dim purchase As Boolean
    Dim sales As Boolean
    Dim inventory As Boolean
    Dim cash_bank As Boolean
    Dim accounting As Boolean
    Dim tools As Boolean
    Dim manufacture As Boolean
    Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
    Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
    Dim DT_Current_Asset As DataTable
    Dim DT_AR_DueDate As DataTable
    Dim DT_AP_DueDate As DataTable
    Dim DT_Grafik_Biaya_Tahun As DataTable
    Dim DT_SO_thisMonth As DataTable
    Dim DT_rekapPembelian As DataTable
    Dim DT_rekapPenjualanPerCategory As DataTable
    Dim DT_rekapPenjualan As DataTable
    Dim DT_100CurrentSales As DataTable

    Private Sub menu_visible()
        card_file = False
        purchase = False
        sales = False
        inventory = False
        cash_bank = False
        accounting = False
        tools = False
        manufacture = False
    End Sub

    Private Sub menu_tools()
        List_Menu.Items.Clear()
        If getTemplateAkses(username, "MN_USERMANAGE") = True Then
            List_Menu.Items.Add("User Management")
            List_Menu.SmallImageList = ImageList_Tools
            List_Menu.Items(0).ImageIndex = 4
        End If
        If getTemplateAkses(username, "MN_BACKUP") = True Then
            List_Menu.Items.Add("Backup Database")
            List_Menu.SmallImageList = ImageList_Tools
            List_Menu.Items(1).ImageIndex = 0
        End If
        If getTemplateAkses(username, "MN_RESTORE") = True Then
            List_Menu.Items.Add("Restore Database")
            List_Menu.SmallImageList = ImageList_Tools
            List_Menu.Items(2).ImageIndex = 3
        End If
        If getTemplateAkses(username, "MN_LOG") = True Then
            List_Menu.Items.Add("Log Transaksi")
            List_Menu.SmallImageList = ImageList_Tools
            List_Menu.Items(3).ImageIndex = 1
        End If
    End Sub

    Private Sub menu_accounting()
        List_Menu.Items.Clear()
        If getTemplateAkses(username, "MN_COA") = True Then
            List_Menu.Items.Add("Chart Of Account")
            List_Menu.SmallImageList = ImageList_Account
            List_Menu.Items(0).ImageIndex = 1
        End If
        If getTemplateAkses(username, "MN_CASHBANK_SETUP") = True Then
            List_Menu.Items.Add("Cash Bank Setup")
            List_Menu.SmallImageList = ImageList_Account
            List_Menu.Items(1).ImageIndex = 0
        End If
        If getTemplateAkses(username, "MN_JOURNAL") = True Then
            List_Menu.Items.Add("General Journal")
            List_Menu.SmallImageList = ImageList_Account
            List_Menu.Items(2).ImageIndex = 2
        End If
        If getTemplateAkses(username, "MN_JOURNAL_LIST") = True Then
            List_Menu.Items.Add("Journal List")
            List_Menu.SmallImageList = ImageList_Account
            List_Menu.Items(3).ImageIndex = 3
        End If
        If getTemplateAkses(username, "MN_LEDGER") = True Then
            List_Menu.Items.Add("Ledger")
            List_Menu.SmallImageList = ImageList_Account
            List_Menu.Items(4).ImageIndex = 4
        End If
        If getTemplateAkses(username, "MN_ACCOUNTING_REPORT") = True Then
            List_Menu.Items.Add("Accounting Report")
            List_Menu.SmallImageList = ImageList_Account
            List_Menu.Items(5).ImageIndex = 5
        End If
        If getTemplateAkses(username, "MN_ANALYST_REPORT") = True Then
            List_Menu.Items.Add("Financial Analysis Report")
            List_Menu.SmallImageList = ImageList_Account
            List_Menu.Items(6).ImageIndex = 5
        End If
        If getTemplateAkses(username, "MN_ACCOUNTING_REPORT") = True Then
            List_Menu.Items.Add("Close Period")
            List_Menu.SmallImageList = ImageList_Account
            List_Menu.Items(7).ImageIndex = 3
        End If
        If getTemplateAkses(username, "MN_COA") = True Then
            List_Menu.Items.Add("COA Transaction Setup")
            List_Menu.SmallImageList = ImageList_Account
            List_Menu.Items(8).ImageIndex = 1
        End If
    End Sub

    Private Sub menu_cashbank()
        List_Menu.Items.Clear()
        If getTemplateAkses(username, "MN_RECEIPT_MONEY") = True Then
            List_Menu.Items.Add("Receipt Cash / Bank")
            List_Menu.SmallImageList = ImageList_Cash
            List_Menu.Items(0).ImageIndex = 1
        End If
        If getTemplateAkses(username, "MN_SPEND_MONEY") = True Then
            List_Menu.Items.Add("Spend Cash / Bank")
            List_Menu.SmallImageList = ImageList_Cash
            List_Menu.Items(1).ImageIndex = 5
        End If
        If getTemplateAkses(username, "MN_BANK_RECONCILE") = True Then
            List_Menu.Items.Add("Bank Reconciliation")
            List_Menu.SmallImageList = ImageList_Cash
            List_Menu.Items(2).ImageIndex = 3
        End If
        If getTemplateAkses(username, "MN_CASHBANK_REGISTER") = True Then
            List_Menu.Items.Add("Cash / Bank Register")
            List_Menu.SmallImageList = ImageList_Cash
            List_Menu.Items(3).ImageIndex = 0
        End If
        If getTemplateAkses(username, "MN_CASHBANK_TRANS_REPORT") = True Then
            List_Menu.Items.Add("Detail Report")
            List_Menu.SmallImageList = ImageList_Cash
            List_Menu.Items(4).ImageIndex = 4
        End If
        If getTemplateAkses(username, "MN_CASHBANK_RECAP_REPORT") = True Then
            List_Menu.Items.Add("Summary Report")
            List_Menu.SmallImageList = ImageList_Cash
            List_Menu.Items(5).ImageIndex = 4
        End If

    End Sub

    Private Sub menu_sales()
        List_Menu.Items.Clear()

        If getTemplateAkses(username, "MN_SO") = True Then
            List_Menu.Items.Add("Sales Order")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(0).ImageIndex = 5
        End If
        If getTemplateAkses(username, "MN_DELIVERED_ITEM") = True Then
            List_Menu.Items.Add("Delivered Item")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(1).ImageIndex = 1
        End If
        If getTemplateAkses(username, "MN_SALES_INV") = True Then
            List_Menu.Items.Add("Sales Invoice")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(2).ImageIndex = 2
        End If
        If getTemplateAkses(username, "MN_SALES_RETURN") = True Then
            List_Menu.Items.Add("Sales Return")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(3).ImageIndex = 4
        End If
        If getTemplateAkses(username, "MN_PAYMENT_AR") = True Then
            List_Menu.Items.Add("Account Receivable Payment")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(4).ImageIndex = 6
        End If
        If getTemplateAkses(username, "MN_AR_STATUS") = True Then
            List_Menu.Items.Add("Account Receivable Status")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(5).ImageIndex = 7
        End If
        If getTemplateAkses(username, "MN_LAPORAN_JUAL") = True Then
            List_Menu.Items.Add("Sales Report")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(6).ImageIndex = 3
        End If
        If getTemplateAkses(username, "MN_LAPORAN_PIUTANG") = True Then
            List_Menu.Items.Add("Account Receivable Report")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(7).ImageIndex = 3
        End If
        If getTemplateAkses(username, "MN_CASHIER") = True Then
            List_Menu.Items.Add("Cashier")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(8).ImageIndex = 0
        End If
        If getTemplateAkses(username, "MN_CASHIER_REGISTER") = True Then
            List_Menu.Items.Add("Cashier Register")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(9).ImageIndex = 8
        End If
        If getTemplateAkses(username, "MN_MUTASI_SERVICE") = True Then
            List_Menu.Items.Add("Cashier Mutation")
            List_Menu.SmallImageList = ImageList_Sales
            List_Menu.Items(10).ImageIndex = 3
        End If
    End Sub

    Private Sub menu_purchase()
        List_Menu.Items.Clear()
        If getTemplateAkses(username, "MN_RO") = True Then
            List_Menu.Items.Add("Purchase Requisition")
            List_Menu.SmallImageList = ImageList_Purchase
            List_Menu.Items(0).ImageIndex = 6
        End If
        If getTemplateAkses(username, "MN_APPROVAL_RO") = True Then
            List_Menu.Items.Add("Approval Purchase Requisition")
            List_Menu.SmallImageList = ImageList_Purchase
            List_Menu.Items(1).ImageIndex = 0
        End If
        If getTemplateAkses(username, "MN_PO") = True Then
            List_Menu.Items.Add("Purchase Order")
            List_Menu.SmallImageList = ImageList_Purchase
            List_Menu.Items(2).ImageIndex = 3
        End If
        If getTemplateAkses(username, "MN_RECEIVED_ORDER") = True Then
            List_Menu.Items.Add("Received Item")
            List_Menu.SmallImageList = ImageList_Purchase
            List_Menu.Items(3).ImageIndex = 4
        End If
        If getTemplateAkses(username, "MN_PURCHASE_INV") = True Then
            List_Menu.Items.Add("Purchase Invoice")
            List_Menu.SmallImageList = ImageList_Purchase
            List_Menu.Items(4).ImageIndex = 7
        End If
        If getTemplateAkses(username, "MN_PURCHASE_RETURN") = True Then
            List_Menu.Items.Add("Purchase Return")
            List_Menu.SmallImageList = ImageList_Purchase
            List_Menu.Items(5).ImageIndex = 5
        End If
        If getTemplateAkses(username, "MN_PEMBAYARAN_HUTANG") = True Then
            List_Menu.Items.Add("Account Payable Payment")
            List_Menu.SmallImageList = ImageList_Purchase
            List_Menu.Items(6).ImageIndex = 2
        End If
        If getTemplateAkses(username, "MN_STATUS_HUTANG") = True Then
            List_Menu.Items.Add("Account Payable Status")
            List_Menu.SmallImageList = ImageList_Purchase
            List_Menu.Items(7).ImageIndex = 1
        End If
        If getTemplateAkses(username, "MN_PURCHASE_REPORT") = True Then
            List_Menu.Items.Add("Purchase Report")
            List_Menu.SmallImageList = ImageList_Purchase
            List_Menu.Items(8).ImageIndex = 8
        End If
        If getTemplateAkses(username, "MN_AP_REPORT") = True Then
            List_Menu.Items.Add("Account Payable Report")
            List_Menu.SmallImageList = ImageList_Purchase
            List_Menu.Items(9).ImageIndex = 8
        End If

    End Sub

    Private Sub menu_stock()
        List_Menu.Items.Clear()
        If getTemplateAkses(username, "MN_STOCK_OPNAME") = True Then
            List_Menu.Items.Add("Stock Opname")
            List_Menu.SmallImageList = ImageList_Stock
            List_Menu.Items(0).ImageIndex = 2
        End If
        If getTemplateAkses(username, "MN_STOCK_CORRECTION") = True Then
            List_Menu.Items.Add("Stock Adjustment")
            List_Menu.SmallImageList = ImageList_Stock
            List_Menu.Items(1).ImageIndex = 1
        End If
        If getTemplateAkses(username, "MN_MOVE_ITEM") = True Then
            List_Menu.Items.Add("Move Item")
            List_Menu.SmallImageList = ImageList_Stock
            List_Menu.Items(2).ImageIndex = 0
        End If
        If getTemplateAkses(username, "MN_ITEM_LIST") = True Then
            List_Menu.Items.Add("Item List")
            List_Menu.SmallImageList = ImageList_Stock
            List_Menu.Items(3).ImageIndex = 3
        End If
        If getTemplateAkses(username, "MN_LAPORAN_STOCK") = True Then
            List_Menu.Items.Add("Stock Report")
            List_Menu.SmallImageList = ImageList_Stock
            List_Menu.Items(4).ImageIndex = 4
        End If
    End Sub

    Private Sub menu_cardfile()
        List_Menu.Items.Clear()
        If getTemplateAkses(username, "MN_CUSTOMER") = True Then
            List_Menu.Items.Add("Customer")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(0).ImageIndex = 0
        End If

        If getTemplateAkses(username, "MN_SUPPLIER") = True Then
            List_Menu.Items.Add("Supplier")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(1).ImageIndex = 11
        End If

        If getTemplateAkses(username, "MN_EMPLOYEE") = True Then
            List_Menu.Items.Add("Employee")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(2).ImageIndex = 10
        End If

        If getTemplateAkses(username, "MN_ITEM_TYPE") = True Then
            List_Menu.Items.Add("Item Type")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(3).ImageIndex = 6
        End If

        If getTemplateAkses(username, "MN_ITEM_CAT") = True Then
            List_Menu.Items.Add("Item Category")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(4).ImageIndex = 3
        End If

        If getTemplateAkses(username, "MN_ITEM_NAME") = True Then
            List_Menu.Items.Add("Item Name")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(5).ImageIndex = 5
        End If

        If getTemplateAkses(username, "MN_BEGINING_BALANCE") = True Then
            List_Menu.Items.Add("Item Beginning Balance")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(6).ImageIndex = 2
        End If

        If getTemplateAkses(username, "MN_JENIS_JASA") = True Then
            List_Menu.Items.Add("Service Card")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(7).ImageIndex = 13
        End If

        If getTemplateAkses(username, "MN_UNIT") = True Then
            List_Menu.Items.Add("Item Unit")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(8).ImageIndex = 12
        End If

        If getTemplateAkses(username, "MN_UNIT_CONVERSION") = True Then
            List_Menu.Items.Add("Unit Conversion")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(9).ImageIndex = 7
        End If

        If getTemplateAkses(username, "MN_WAREHOUSE") = True Then
            List_Menu.Items.Add("Warehouse")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(10).ImageIndex = 1
        End If

        If getTemplateAkses(username, "MN_CURRENCY") = True Then
            List_Menu.Items.Add("Currency")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(11).ImageIndex = 9
        End If

        If getTemplateAkses(username, "MN_CURRENCY_CONVERSION") = True Then
            List_Menu.Items.Add("Currency Conversion")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(12).ImageIndex = 8
        End If

        If getTemplateAkses(username, "MN_CARD_FILE_REPORT") = True Then
            List_Menu.Items.Add("Card File Report")
            List_Menu.SmallImageList = ImageList_Card
            List_Menu.Items(13).ImageIndex = 14
        End If

    End Sub

    Private Sub menu_produksi()
        List_Menu.Items.Clear()
        If getTemplateAkses(username, "MN_CONVERSION_COST") = True Then
            List_Menu.Items.Add("Jenis & Estimasi Biaya Konversi")
            List_Menu.SmallImageList = ImageList_Manufacture
            List_Menu.Items(0).ImageIndex = 4
        End If
        If getTemplateAkses(username, "MN_COST_FORMULA") = True Then
            List_Menu.Items.Add("BOM dan Cost Formula")
            List_Menu.SmallImageList = ImageList_Manufacture
            List_Menu.Items(1).ImageIndex = 6
        End If
        If getTemplateAkses(username, "MN_SPK") = True Then
            List_Menu.Items.Add("Surat Perintah Kerja / SPK")
            List_Menu.SmallImageList = ImageList_Manufacture
            List_Menu.Items(2).ImageIndex = 3
        End If
        If getTemplateAkses(username, "MN_MATERIAL_USE") = True Then
            List_Menu.Items.Add("Penggunaan Bahan Baku")
            List_Menu.SmallImageList = ImageList_Manufacture
            List_Menu.Items(3).ImageIndex = 2
        End If
        If getTemplateAkses(username, "MN_REAL_COST") = True Then
            List_Menu.Items.Add("Realisasi Biaya Konversi")
            List_Menu.SmallImageList = ImageList_Manufacture
            List_Menu.Items(4).ImageIndex = 1
        End If
        If getTemplateAkses(username, "MN_SPK_CANCEL") = True Then
            List_Menu.Items.Add("Pembatalan SPK")
            List_Menu.SmallImageList = ImageList_Manufacture
            List_Menu.Items(5).ImageIndex = 0
        End If

    End Sub

    Private Sub pic_cardfile_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_cardfile.MouseHover
        Cursor = Cursors.Hand
        pic_cardfile.BackColor = Color.SandyBrown
        ' lbl_title.Text = "Card File Menu"
        menu_cardfile()
        menu_visible()
        card_file = True
        Panel_Dashboard_1.Visible = False
        List_Menu.Visible = True
        List_Menu.View = View.List
    End Sub

    Private Sub pic_cardfile_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_cardfile.MouseLeave
        Cursor = Cursors.Arrow
        pic_cardfile.BackColor = Color.Transparent
        'lbl_title.Text = "Command Panel"
    End Sub

    Private Sub pic_accounts_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_accounts.MouseHover
        Cursor = Cursors.Hand
        pic_accounts.BackColor = Color.SandyBrown
        ' lbl_title.Text = "Accounting Menu"
        menu_accounting()
        menu_visible()
        accounting = True
        Panel_Dashboard_1.Visible = False
        List_Menu.Visible = True
        List_Menu.View = View.List
    End Sub

    Private Sub pic_accounts_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_accounts.MouseLeave
        Cursor = Cursors.Arrow
        pic_accounts.BackColor = Color.Transparent
        'lbl_title.Text = "Command Panel"
    End Sub

    Private Sub pic_banking_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_banking.MouseHover
        Cursor = Cursors.Hand
        pic_banking.BackColor = Color.SandyBrown
        '   lbl_title.Text = "Cash / Bank Menu"
        menu_cashbank()
        menu_visible()
        cash_bank = True
        Panel_Dashboard_1.Visible = False
        List_Menu.Visible = True
        List_Menu.View = View.List
    End Sub

    Private Sub pic_banking_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_banking.MouseLeave
        Cursor = Cursors.Arrow
        pic_banking.BackColor = Color.Transparent
        'lbl_title.Text = "Command Panel"
    End Sub

    Private Sub pic_inventory_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_inventory.MouseHover
        Cursor = Cursors.Hand
        pic_inventory.BackColor = Color.SandyBrown
        ' lbl_title.Text = "Inventory Menu"
        menu_stock()
        menu_visible()
        inventory = True
        Panel_Dashboard_1.Visible = False
        List_Menu.Visible = True
        List_Menu.View = View.List
    End Sub

    Private Sub pic_inventory_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_inventory.MouseLeave
        Cursor = Cursors.Arrow
        pic_inventory.BackColor = Color.Transparent
        'lbl_title.Text = "Command Panel"
    End Sub

    Private Sub pic_purchase_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_purchase.MouseHover
        Cursor = Cursors.Hand
        pic_purchase.BackColor = Color.SandyBrown
        'lbl_title.Text = "Purchasing Menu"
        menu_purchase()
        menu_visible()
        purchase = True
        Panel_Dashboard_1.Visible = False
        List_Menu.Visible = True
        List_Menu.View = View.List
    End Sub

    Private Sub pic_purchase_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_purchase.MouseLeave
        Cursor = Cursors.Arrow
        pic_purchase.BackColor = Color.Transparent
        ' lbl_title.Text = "Command Panel"
    End Sub

    Private Sub pic_sales_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_sales.MouseHover
        Cursor = Cursors.Hand
        pic_sales.BackColor = Color.SandyBrown
        'lbl_title.Text = "Sales Menu"
        menu_sales()
        menu_visible()
        sales = True
        Panel_Dashboard_1.Visible = False
        List_Menu.Visible = True
        List_Menu.View = View.List
    End Sub

    Private Sub pic_sales_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_sales.MouseLeave
        Cursor = Cursors.Arrow
        pic_sales.BackColor = Color.Transparent
        'lbl_title.Text = "Command Panel"
    End Sub

    Private Sub pic_setting_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_setting.MouseHover
        Cursor = Cursors.Hand
        pic_setting.BackColor = Color.SandyBrown
        ' lbl_title.Text = "Tools Menu"
        menu_tools()
        menu_visible()
        tools = True
        Panel_Dashboard_1.Visible = False
        List_Menu.Visible = True
        List_Menu.View = View.List
    End Sub

    Private Sub pic_setting_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_setting.MouseLeave
        Cursor = Cursors.Arrow
        pic_setting.BackColor = Color.Transparent
        'lbl_title.Text = "Command Panel"
    End Sub


    Private Sub menu_action()
        On Error Resume Next
        If card_file = True Then
            If List_Menu.Items(0).Selected = True Then
                If Application.OpenForms().OfType(Of frmcustomer).Any Then
                    '  MsgBox("Menu Customer Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmcustomer.Activate()
                Else
                    frmcustomer.Show()
                    ' frmcustomer.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(1).Selected = True Then
                If Application.OpenForms().OfType(Of frmsupplier).Any Then
                    'MsgBox("Menu Supplier Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmsupplier.Activate()
                Else
                    frmsupplier.Show()
                    ' frmsupplier.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(2).Selected = True Then
                If Application.OpenForms().OfType(Of frmmarketing).Any Then
                    'MsgBox("Menu Marketing Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmmarketing.Activate()
                Else
                    frmmarketing.Show()
                    ' frmmarketing.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(3).Selected = True Then
                If Application.OpenForms().OfType(Of frmjenisbarang).Any Then
                    'MsgBox("Menu Jenis Barang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmjenisbarang.Activate()
                Else
                    frmjenisbarang.Show()
                    ' frmjenisbarang.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(4).Selected = True Then
                If Application.OpenForms().OfType(Of frmkatbarang).Any Then
                    'MsgBox("Menu Item Category Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmkatbarang.Activate()
                Else
                    frmkatbarang.Show()
                    ' frmkatbarang.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(5).Selected = True Then
                If Application.OpenForms().OfType(Of frmitem).Any Then
                    ' MsgBox("Menu Master Item Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmitem.Activate()
                Else
                    frmitem.Show()
                    ' frmitem.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(6).Selected = True Then
                If Application.OpenForms().OfType(Of frmitem_beginning).Any Then
                    'MsgBox("Menu Stock Awal Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmitem_beginning.Activate()
                Else
                    frmitem_beginning.Show()
                    ' frmitem_beginning.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(7).Selected = True Then
                If Application.OpenForms().OfType(Of frmservice).Any Then
                    'MsgBox("Menu Master Service Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmservice.Activate()
                Else
                    frmservice.Show()
                    ' frmservice.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(8).Selected = True Then
                If Application.OpenForms().OfType(Of frmUnit).Any Then
                    'MsgBox("Menu Unit Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmUnit.Activate()
                Else
                    frmUnit.Show()
                    ' frmUnit.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(9).Selected = True Then
                If Application.OpenForms().OfType(Of frmUnit).Any Then
                    'MsgBox("Menu Konversi Unit Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmUnit.Activate()
                Else
                    frmUnit.Show()
                    frmUnit.TabControl1.SelectedTabPage = frmUnit.TabKonversi
                    ' frmUnit.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(10).Selected = True Then
                If Application.OpenForms().OfType(Of frmWH).Any Then
                    ' MsgBox("Menu Gudang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmWH.Activate()
                Else
                    frmWH.Show()
                    ' frmWH.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(11).Selected = True Then
                If Application.OpenForms().OfType(Of frmCurrency).Any Then
                    'MsgBox("Menu Mata Uang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmCurrency.Activate()
                Else
                    frmCurrency.Show()
                    ' frmCurrency.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(12).Selected = True Then
                If Application.OpenForms().OfType(Of frmCurrency).Any Then
                    'MsgBox("Menu Konversi Mata Uang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmCurrency.Activate()
                Else
                    frmCurrency.Show()
                    frmCurrency.TabControl1.SelectedTabPage = frmCurrency.tabconvert
                    ' frmCurrency.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(13).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportMaster).Any Then
                    'MsgBox("Menu Laporan Data Master Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportMaster.Activate()
                Else
                    FormReportMaster.Show()
                    ' FormReportMaster.MdiParent = MainMenu
                End If
            End If
        End If

        If purchase = True Then
            If List_Menu.Items(0).Selected = True Then
                If Application.OpenForms().OfType(Of frmRO).Any Then
                    'MsgBox("Menu Request Order Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmRO.Activate()
                Else
                    frmRO.Show()
                    ' frmRO.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(1).Selected = True Then
                If Application.OpenForms().OfType(Of frmApproveRO).Any Then
                    'MsgBox("Menu Approval RO Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmApproveRO.Activate()
                Else
                    frmApproveRO.Show()
                    ' frmApproveRO.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(2).Selected = True Then
                If Application.OpenForms().OfType(Of frmpo).Any Then
                    'MsgBox("Menu Purchase Order Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmpo.Activate()
                Else
                    frmpo.Show()
                    ' frmpo.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(3).Selected = True Then
                If Application.OpenForms().OfType(Of frmRecOrder).Any Then
                    'MsgBox("Menu Penerimaan Barang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmRecOrder.Activate()
                Else
                    frmRecOrder.Show()
                    ' frmRecOrder.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(4).Selected = True Then
                If Application.OpenForms().OfType(Of frmpurchase).Any Then
                    'MsgBox("Menu Purchase Invoice Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmpurchase.Activate()
                Else
                    frmpurchase.Show()
                    ' frmpurchase.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(5).Selected = True Then
                If Application.OpenForms().OfType(Of frmpurc_return).Any Then
                    'MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmpurc_return.Activate()
                Else
                    frmpurc_return.Show()
                    ' frmpurc_return.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(6).Selected = True Then
                If Application.OpenForms().OfType(Of frmpayAP).Any Then
                    '    MsgBox("Menu Pembayaran Hutang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmpayAP.Activate()
                Else
                    frmpayAP.Show()
                    ' frmpayAP.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(7).Selected = True Then
                If Application.OpenForms().OfType(Of frmAPList).Any Then
                    '    MsgBox("Menu Status Hutang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmAPList.Activate()
                Else
                    frmAPList.Show()
                    ' frmAPList.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(8).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportPurch).Any Then
                    'MsgBox("Menu Laporan Pembelian Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportPurch.Activate()
                Else
                    FormReportPurch.Show()
                    'Rpt.MdiParent = MainMenu
                    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage1
                    FormReportPurch.rb_purch1.Checked = True
                End If
            End If
            If List_Menu.Items(9).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportPurch).Any Then
                    'MsgBox("Menu Laporan Hutang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportPurch.Activate()
                Else

                    FormReportPurch.Show()
                    'Rpt.MdiParent = MainMenu
                    FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage2
                    FormReportPurch.rb_ap1.Checked = True
                End If
            End If
        End If

        If sales = True Then
            If List_Menu.Items(0).Selected = True Then
                If Application.OpenForms().OfType(Of frmso).Any Then
                    'MsgBox("Menu Sales Order Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmso.Activate()
                Else
                    frmso.Show()
                    ' frmso.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(1).Selected = True Then
                If Application.OpenForms().OfType(Of frmDeliveredItem).Any Then
                    'MsgBox("Menu Delivered Item Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmDeliveredItem.Activate()
                Else
                    frmDeliveredItem.Show()
                    ' frmDeliveredItem.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(2).Selected = True Then
                If Application.OpenForms().OfType(Of frmsales).Any Then
                    'MsgBox("Menu Penjualan Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmsales.Activate()
                Else
                    frmsales.Show()
                    ' frmsales.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(3).Selected = True Then
                If Application.OpenForms().OfType(Of frmsalesreturn).Any Then
                    ' MsgBox("Menu Rertur Penjualan Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmsalesreturn.Activate()
                Else
                    frmsalesreturn.Show()
                    ' frmsalesreturn.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(4).Selected = True Then
                If Application.OpenForms().OfType(Of frmpayAR).Any Then
                    'MsgBox("Menu Pembayaran Piutang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmpayAR.Activate()
                Else
                    frmpayAR.Show()
                    ' frmpayAR.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(5).Selected = True Then
                If Application.OpenForms().OfType(Of frmARList).Any Then
                    'MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmARList.Activate()
                Else
                    frmARList.Show()
                    ' frmARList.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(6).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportSales).Any Then
                    'MsgBox("Menu Laporan Penjualan Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportSales.Activate()
                Else

                    FormReportSales.Show()
                    '
                    ' Rpt.MdiParent = MainMenu
                    FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage1
                    FormReportSales.rb_purch1.Checked = True
                End If
            End If
            If List_Menu.Items(7).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportSales).Any Then
                    'MsgBox("Menu Laporan Piutang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportSales.Activate()
                Else

                    FormReportSales.Show()
                    ' Rpt.MdiParent = MainMenu
                    FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage2
                    FormReportSales.rb_ap1.Checked = True
                End If
            End If
            If List_Menu.Items(8).Selected = True Then
                If Application.OpenForms().OfType(Of frmcashier).Any Then
                    'MsgBox("Menu Kasir Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmcashier.Activate()
                Else
                    frmcashier.Show()
                    ' frmcashier.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(9).Selected = True Then
                If Application.OpenForms().OfType(Of frmcashierregister).Any Then
                    ' MsgBox("Menu Kasir Register Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmcashierregister.Activate()
                Else
                    frmcashierregister.Show()
                    ' frmcashierregister.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(10).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportSales2).Any Then
                    'MsgBox("Menu Laporan Mutasi Kasir Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportSales2.Activate()
                Else
                    'Dim Rpt As New FormReportSales2
                    FormReportSales2.Show()
                    ' Rpt.MdiParent = MainMenu
                    FormReportSales2.TabControl1.SelectedTabPage = FormReportSales2.TabPage1
                    FormReportSales2.rb_purch9.Checked = True
                End If
            End If
        End If

        If inventory = True Then
            If List_Menu.Items(0).Selected = True Then
                If Application.OpenForms().OfType(Of frmstockopname).Any Then
                    'MsgBox("Menu Stock Opname Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmstockopname.Activate()
                Else
                    frmstockopname.Show()
                    ' frmstockopname.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(1).Selected = True Then
                If Application.OpenForms().OfType(Of frmadjuststock).Any Then
                    'MsgBox("Menu Koreksi Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmadjuststock.Activate()
                Else
                    frmadjuststock.Show()
                    ' frmadjuststock.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(2).Selected = True Then
                If Application.OpenForms().OfType(Of frmitemtransfer).Any Then
                    ' MsgBox("Menu Transfer Item Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmitemtransfer.Activate()
                Else
                    frmitemtransfer.Show()
                    ' frmitemtransfer.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(3).Selected = True Then
                If Application.OpenForms().OfType(Of frmitem).Any Then
                    ' MsgBox("Menu Daftar Item Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmitem.Activate()
                Else
                    frmitem.Show()
                    frmitem.TabControl1.SelectedTabPage = frmitem.TabList
                    ' frmitem.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(4).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportStock).Any Then
                    '   MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")

                    FormReportStock.Activate()
                Else
                    ' Dim Rpt As New FormReportStock
                    FormReportStock.Show()
                    ' Rpt.MdiParent = MainMenu
                    FormReportStock.rb_purch1.Checked = True
                End If
            End If
        End If

        If cash_bank = True Then
            If List_Menu.Items(0).Selected = True Then
                If Application.OpenForms().OfType(Of frmreceiptmoney).Any Then
                    'MsgBox("Menu Penerimaan Uang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmreceiptmoney.Activate()
                Else
                    frmreceiptmoney.Show()
                    ' frmreceiptmoney.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(1).Selected = True Then
                If Application.OpenForms().OfType(Of frmspendmoney).Any Then
                    'MsgBox("Menu Pengeluaran Uang Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmspendmoney.Activate()
                Else
                    frmspendmoney.Show()
                    ' frmspendmoney.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(3).Selected = True Then
                If Application.OpenForms().OfType(Of frmcashregister).Any Then
                    'MsgBox("Menu Kas/Bank Register Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmcashregister.Activate()
                Else
                    frmcashregister.Show()
                    ' frmcashregister.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(2).Selected = True Then
                If Application.OpenForms().OfType(Of frmreconcile).Any Then
                    'MsgBox("Menu Rekonsiliasi Bank Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmreconcile.Activate()
                Else
                    frmreconcile.Show()
                    ' frmreconcile.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(4).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportCash).Any Then
                    ' MsgBox("Menu History Cash Bank Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportCash.Activate()
                Else
                    'Dim Rpt As New FormReportCash
                    FormReportCash.Show()
                    ' Rpt.MdiParent = MainMenu
                    FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage1
                    FormReportCash.rb_purch1.Checked = True
                End If
            End If
            If List_Menu.Items(5).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportCash).Any Then
                    ' MsgBox("Menu Rekap Kas/Bank Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportCash.Activate()
                Else
                    ' Dim Rpt As New FormReportCash
                    FormReportCash.Show()
                    ' Rpt.MdiParent = MainMenu
                    FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage2
                    FormReportCash.rb_ap1.Checked = True
                End If
            End If
        End If

        If accounting = True Then
            If List_Menu.Items(0).Selected = True Then
                If Application.OpenForms().OfType(Of frmcoa).Any Then
                    'MsgBox("Menu COA Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmcoa.Activate()
                Else
                    frmcoa.Show()
                    ' frmcoa.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(1).Selected = True Then
                If Application.OpenForms().OfType(Of frmsetupcashbank).Any Then
                    ' MsgBox("Menu Setup Kas Bank Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmsetupcashbank.Activate()
                Else
                    frmsetupcashbank.Show()
                    ' frmsetupcashbank.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(2).Selected = True Then
                If Application.OpenForms().OfType(Of frmjournal).Any Then
                    'MsgBox("Menu Jurnal Umum Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmjournal.Activate()
                Else
                    frmjournal.Show()
                    ' frmjournal.MdiParent = MainMenu
                End If
            End If

            If List_Menu.Items(4).Selected = True Then
                If Application.OpenForms().OfType(Of frmledger).Any Then
                    'MsgBox("Menu Ledger Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmledger.Activate()
                Else
                    frmledger.Show()
                    ' frmledger.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(5).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportAcc).Any Then
                    '     MsgBox("Menu Laporan Akuntansi Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportAcc.Activate()
                Else
                    '  Dim Rpt As New FormReportAcc
                    FormReportAcc.Show()
                    ' Rpt.MdiParent = MainMenu
                    FormReportAcc.TabControl1.SelectedTabPage = FormReportAcc.TabPage1
                    FormReportAcc.rb_purch1.Checked = True
                End If
            End If
            If List_Menu.Items(6).Selected = True Then
                If Application.OpenForms().OfType(Of FormReportAcc).Any Then
                    'MsgBox("Menu Laporan Analisa Keuangan Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    FormReportAcc.Activate()
                Else
                    ' Dim Rpt As New FormReportAcc
                    FormReportAcc.Show()
                    ' Rpt.MdiParent = MainMenu
                    ' Rpt.TabControl1.SelectedTab = Rpt.TabPage2
                    ' Rpt.rb_ap1.Checked = True
                End If
            End If
            If List_Menu.Items(7).Selected = True Then
                If Application.OpenForms().OfType(Of ClosedPeriod).Any Then
                    'MsgBox("Menu Tutup Periode Akuntansi Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    ClosedPeriod.Activate()
                Else
                    'Dim Rpt As New ClosedPeriod
                    ClosedPeriod.Show()
                    ' Rpt.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(8).Selected = True Then
                If Application.OpenForms().OfType(Of frmsetcoa).Any Then
                    'MsgBox("Menu Tutup Periode Akuntansi Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmsetcoa.Activate()
                Else
                    'Dim Rpt As New ClosedPeriod
                    frmsetcoa.Show()
                    ' Rpt.MdiParent = MainMenu
                End If
            End If
        End If

        If tools = True Then
            If List_Menu.Items(0).Selected = True Then
                If Application.OpenForms().OfType(Of UserRight).Any Then
                    'MsgBox("Menu Backup Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    UserRight.Activate()
                Else
                    ' Dim Rpt As New backup
                    UserRight.Show()
                    ' Rpt.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(1).Selected = True Then
                If Application.OpenForms().OfType(Of backup).Any Then
                    '   MsgBox("Menu Restore Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    backup.Activate()
                Else
                    'Dim Rpt As New restore
                    backup.Show()
                    ' Rpt.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(3).Selected = True Then
                If Application.OpenForms().OfType(Of frmlog).Any Then
                    'MsgBox("Menu Log Transaksi Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmlog.Activate()
                Else
                    frmlog.Show()
                    ' frmlog.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(2).Selected = True Then
                If Application.OpenForms().OfType(Of restore).Any Then
                    ' MsgBox("Menu Manajemen User Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    restore.Activate()
                Else
                    restore.Show()
                    ' UserRight.MdiParent = MainMenu
                End If
            End If
        End If

        If manufacture = True Then
            If List_Menu.Items(0).Selected = True Then
                If Application.OpenForms().OfType(Of frmstdcost).Any Then
                    ' MsgBox("Menu Jenis Biaya Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmstdcost.Activate()
                Else
                    frmstdcost.Show()
                    ' frmstdcost.MdiParent = MainMenu
                End If
            End If
            If List_Menu.Items(1).Selected = True Then
                If Application.OpenForms().OfType(Of frmbom).Any Then
                    'MsgBox("Menu Formula Konversi dan BOM Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                    frmbom.Activate()
                Else
                    frmbom.Show()
                    ' frmbom.MdiParent = MainMenu
                End If
            End If
        End If
    End Sub

    Private Sub List_Menu_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles List_Menu.DoubleClick
        menu_action()

    End Sub

    Private Sub FrmCommandPanel_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        'open_conn()
        'Dim panel As String
        'Panel = get_panel()
        'If Panel = "Dashboard" Then
        '    binding_data()
        'ElseIf Panel = "Panel Logo" Then
        '    Panel_Accounting_DSH.Visible = False
        '    Panel_Dashboard_1.Visible = False
        '    Button1.Visible = False
        '    panel_logo.Visible = True
        'End If
    End Sub

    Private Sub FrmCommandPanel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim logo_path, panel As String
        '  If connec_open() = True Then
        logo_path = Replace(get_logo(), "/", "\")
        panel = get_panel()
        'Try
        '    If System.IO.File.Exists(logo_path) Then
        '        logo.Image = Image.FromFile(logo_path)
        '        logo2.Image = Image.FromFile(logo_path)
        '    Else
        '        logo.Image = Image.FromFile(Application.StartupPath & "\pi-accounting-small.png")
        '        logo2.Image = Image.FromFile(Application.StartupPath & "\pi-accounting-small.png")
        '    End If
        'Catch ex As Exception

        'End Try

        Me.Text = "Dashboard"
        Dim timer As New Timer
        timer.Interval = 1000
        timer.Start()
        AddHandler timer.Tick, AddressOf Timer1_Tick


        If Panel = "Dashboard" Then
            binding_data()
        ElseIf panel = "Panel Logo" Then
            Panel_Accounting_DSH.Visible = False
            Panel_Dashboard_1.Visible = False
            Button1.Visible = False
            panel_logo.Visible = True
        End If
        'ambil workflow
        'Dim DTRight As DataTable
        'DTRight = getParentKey_FromUser(username)
        'cbo_workflow.Items.Clear()
        'For c As Integer = 0 To DTRight.Rows.Count - 1
        '    cbo_workflow.Items.Add(DTRight.Rows(c).Item(0))
        'Next
        'cbo_workflow.Text = "PENJUALAN"
    End Sub

    Private Sub pic_manufacture_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_manufacture.MouseHover
        Cursor = Cursors.Hand
        pic_manufacture.BackColor = Color.SandyBrown
        '   lbl_title.Text = "Manufacture Menu"
        menu_produksi()
        menu_visible()
        manufacture = True
        Panel_Dashboard_1.Visible = False
        List_Menu.Visible = True
    End Sub

    Private Sub pic_manufacture_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic_manufacture.MouseLeave
        Cursor = Cursors.Arrow
        pic_manufacture.BackColor = Color.Transparent
        'lbl_title.Text = "Command Panel"
    End Sub

    Private Sub pic_manufacture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_manufacture.Click
        List_Menu.Visible = True
        List_Menu.View = View.List
    End Sub

    Private Sub List_Menu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles List_Menu.KeyPress
        If e.KeyChar = Chr(13) Then
            menu_action()
        End If
    End Sub

    Private Sub List_Menu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List_Menu.SelectedIndexChanged

    End Sub

    Private Sub Dashboard_MouseHover(sender As Object, e As System.EventArgs) Handles Dashboard.MouseHover
        Panel_Dashboard_1.Visible = True
        List_Menu.View = False
        Cursor = Cursors.Hand
        Dashboard.BackColor = Color.SandyBrown
        ' lbl_title.Text = "DASHBOARD"
    End Sub

    Private Sub linkPurchaseReport_Click(sender As Object, e As System.EventArgs) Handles linkPurchaseReport.Click
        If getTemplateAkses(username, "MN_PURCHASE_REPORT") = True Then
            FormReportPurch.Show()
            'Rpt.MdiParent = MainMenu
            FormReportPurch.TabControl1.SelectedTabPage = FormReportPurch.TabPage1
            FormReportPurch.rb_purch1.Checked = True
        Else
            MsgBox("Anda tidak berhak mengakses Laporan Pembelian", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkSalesReport_Click(sender As Object, e As System.EventArgs) Handles linkSalesReport.Click
        If getTemplateAkses(username, "MN_LAPORAN_JUAL") = True Then
            FormReportSales.Show()
            '
            ' Rpt.MdiParent = MainMenu
            FormReportSales.TabControl1.SelectedTabPage = FormReportSales.TabPage1
            FormReportSales.rb_purch1.Checked = True
        Else
            MsgBox("Anda tidak berhak mengakses Laporan Penjualan", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If

    End Sub

    Private Sub linkStockReport_Click(sender As Object, e As System.EventArgs) Handles linkStockReport.Click
        If getTemplateAkses(username, "MN_LAPORAN_STOCK") = True Then
            ' Dim Rpt As New FormReportStock
            FormReportStock.Show()
            ' Rpt.MdiParent = MainMenu
            FormReportStock.rb_purch1.Checked = True
        Else
            MsgBox("Anda tidak berhak mengakses Laporan Stok Barang", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkCashReport_Click(sender As Object, e As System.EventArgs) Handles linkCashReport.Click
        If getTemplateAkses(username, "MN_CASHBANK_TRANS_REPORT") = True Then
            'Dim Rpt As New FormReportCash
            FormReportCash.Show()
            ' Rpt.MdiParent = MainMenu
            FormReportCash.TabControl1.SelectedTabPage = FormReportCash.TabPage1
            FormReportCash.rb_purch1.Checked = True
        Else
            MsgBox("Anda tidak berhak mengakses Laporan Kas Bank", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkaccountingreport_Click(sender As Object, e As System.EventArgs) Handles linkaccountingreport.Click
        If getTemplateAkses(username, "MN_ACCOUNTING_REPORT") = True Then
            '  Dim Rpt As New FormReportAcc
            FormReportAcc.Show()
            ' Rpt.MdiParent = MainMenu
            FormReportAcc.TabControl1.SelectedTabPage = FormReportAcc.TabPage1
            FormReportAcc.rb_purch1.Checked = True
        Else
            MsgBox("Anda tidak berhak mengakses Laporan Akuntansi", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkKasir_Click(sender As Object, e As System.EventArgs) Handles linkKasir.Click
        If getTemplateAkses(username, "MN_CASHIER") = True Then
            If Application.OpenForms().OfType(Of frmcashier).Any Then
                'MsgBox("Menu Kasir Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                frmcashier.Activate()
            Else
                frmcashier.Show()
                ' frmcashier.MdiParent = MainMenu
            End If
        Else
            MsgBox("Anda tidak berhak mengakses Transaksi Kasir", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkRO_Click(sender As Object, e As System.EventArgs) Handles linkRO.Click
        If getTemplateAkses(username, "MN_RO") = True Then
            If Application.OpenForms().OfType(Of frmRO).Any Then
                'MsgBox("Menu Request Order Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                frmRO.Activate()
            Else
                frmRO.Show()
                ' frmRO.MdiParent = MainMenu
            End If
        Else
            MsgBox("Anda tidak berhak mengakses Permintaan Barang", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkSO_Click(sender As Object, e As System.EventArgs) Handles linkSO.Click
        If getTemplateAkses(username, "MN_SO") = True Then
            If Application.OpenForms().OfType(Of frmso).Any Then
                'MsgBox("Menu Sales Order Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                frmso.Activate()
            Else
                frmso.Show()
                ' frmso.MdiParent = MainMenu
            End If
        Else
            MsgBox("Anda tidak berhak mengakses Sales Order", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkMutasiKasir_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkMutasiKasir.LinkClicked
        If getTemplateAkses(username, "MN_CASHIER_REGISTER") = True Then
            If Application.OpenForms().OfType(Of frmcashierregister).Any Then
                ' MsgBox("Menu Kasir Register Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                frmcashierregister.Activate()
            Else
                frmcashierregister.Show()
                ' frmcashierregister.MdiParent = MainMenu
            End If
        Else
            MsgBox("Anda tidak berhak mengakses Cashier Register", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkHutang_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkHutang.LinkClicked
        If getTemplateAkses(username, "MN_STATUS_HUTANG") = True Then
            If Application.OpenForms().OfType(Of frmAPList).Any Then
                'MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                frmAPList.Activate()
            Else
                frmAPList.Show()
                ' frmARList.MdiParent = MainMenu
            End If
        Else
            MsgBox("Anda tidak berhak mengakses Daftar Hutang", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkPiutang_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkPiutang.LinkClicked
        If getTemplateAkses(username, "MN_AR_STATUS") = True Then
            If Application.OpenForms().OfType(Of frmARList).Any Then
                'MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                frmARList.Activate()
            Else
                frmARList.Show()
                ' frmARList.MdiParent = MainMenu
            End If
        Else
            MsgBox("Anda tidak berhak mengakses Daftar Piutang", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkBarang_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkBarang.LinkClicked
        If getTemplateAkses(username, "MN_ITEM_NAME") = True Then
            If Application.OpenForms().OfType(Of frmitem).Any Then
                'MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                frmitem.Activate()
            Else
                frmitem.Show()
                ' frmARList.MdiParent = MainMenu
            End If
        Else
            MsgBox("Anda tidak berhak mengakses Daftar Barang", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub linkLedger_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLedger.LinkClicked
        If getTemplateAkses(username, "MN_LEDGER") = True Then
            If Application.OpenForms().OfType(Of frmledger).Any Then
                'MsgBox("Menu Laporan Stock Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                frmledger.Activate()
            Else
                frmledger.Show()
                ' frmARList.MdiParent = MainMenu
            End If
        Else
            MsgBox("Anda tidak berhak mengakses History Account", MsgBoxStyle.Critical, "Hak Akses")
            Exit Sub
        End If
    End Sub

    Private Sub Dashboard_MouseLeave(sender As Object, e As System.EventArgs) Handles Dashboard.MouseLeave
        Cursor = Cursors.Arrow
        Dashboard.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Dashboard . . .")

            DT_SO_thisMonth = notifSOThisMonth()
            DT_rekapPembelian = grafikRekapPembelian()
            DT_rekapPenjualanPerCategory = grafikRekapPenjualanPerCategory()
            DT_rekapPenjualan = grafikRekapPenjualan()
            DT_Current_Asset = current_grafik_assetreturn()
            DT_AR_DueDate = piutangJtTempo()
            DT_AP_DueDate = hutangJtTempo()
            DT_Grafik_Biaya_Tahun = grafikBiayaTahunan()

            Me.GridControl1.DataSource = DT_SO_thisMonth
            Me.GridControl2.DataSource = DT_AP_DueDate
            Me.GridControl3.DataSource = DT_AR_DueDate

            Me.ChartControl6.DataSource = DT_rekapPenjualan
            Me.ChartControl2.DataSource = DT_rekapPenjualanPerCategory
            Me.ChartControl3.DataSource = DT_rekapPembelian
            Me.ChartControl4.DataSource = DT_Grafik_Biaya_Tahun
            Me.ChartControl5.DataSource = DT_Current_Asset

            TileItemElement1.Text = DT_AR_DueDate.Rows.Count
            TileItemElement2.Text = DT_AP_DueDate.Rows.Count
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub


    Private Sub binding_data()
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Dashboard . . .")
            DT_SO_thisMonth = notifSOThisMonth()
            ' DT_rekapPembelian = grafikRekapPembelian()
            DT_rekapPenjualanPerCategory = grafikRekapPenjualanPerCategory()
            DT_rekapPenjualan = grafikRekapPenjualan()
            'DT_Current_Asset = current_grafik_assetreturn()
            DT_AR_DueDate = piutangJtTempo()
            DT_AP_DueDate = hutangJtTempo()
            DT_100CurrentSales = OneHundredCurrentSales()

            'TileItemElement1.Text = DT_AR_DueDate.Rows.Count
            'TileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            'TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
            'TileItemElement2.Text = DT_AP_DueDate.Rows.Count
            'TileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            'TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
            'TileItem1.Elements.Add(TileItemElement1)
            'TileItem2.Elements.Add(TileItemElement2)
            'DT_Grafik_Biaya_Tahun = grafikBiayaTahunan()

            Me.GridControl1.DataSource = DT_SO_thisMonth
            'Me.GridControl2.DataSource = DT_AP_DueDate
            'Me.GridControl3.DataSource = DT_AR_DueDate

            Me.ChartControl6.DataSource = DT_rekapPenjualan
            Me.ChartControl2.DataSource = DT_rekapPenjualanPerCategory
            'Me.ChartControl3.DataSource = DT_rekapPembelian
            'Me.ChartControl4.DataSource = DT_Grafik_Biaya_Tahun
            'Me.ChartControl5.DataSource = DT_Current_Asset


            '100 penjualan terakhir
            ListSales.DataSource = DT_100CurrentSales
            GridList_Sales.Columns("no_sales").Caption = "No Penjualan"
            GridList_Sales.Columns("no_sales").Width = 180
            GridList_Sales.Columns("date_trn").Caption = "Tanggal"
            GridList_Sales.Columns("date_trn").Width = 120
            GridList_Sales.Columns("date_trn").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridList_Sales.Columns("date_trn").DisplayFormat.FormatString = "dd-MM-yyyy"
            GridList_Sales.Columns("customer").Caption = "Pelanggan"
            GridList_Sales.Columns("customer").Width = 200
            GridList_Sales.Columns("total").Caption = "Total"
            GridList_Sales.Columns("total").Width = 170
            GridList_Sales.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridList_Sales.Columns("total").DisplayFormat.FormatString = "N0"


        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub lbl_ro_Click(sender As System.Object, e As System.EventArgs) Handles lbl_ro.Click

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles lbl_ap_payment.Click

    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles lbl_purch_report.Click

    End Sub

    Private Sub cbo_workflow_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_workflow.SelectedIndexChanged
        On Error Resume Next
        Call panel_workflow_visible()
        Panel_Accounting_DSH.Visible = False
        'Panel_Dashboard_1.Visible = False
        If Trim(cbo_workflow.Text) = "STOK" Then
            Panel_Stock.Visible = True
            Panel_Accounting_DSH.Visible = False
            ' Panel_Dashboard_1.Visible = True
        ElseIf Trim(cbo_workflow.Text) = "PEMBELIAN" Then
            Panel_Pembelian.Visible = True
            Panel_Accounting_DSH.Visible = False
            'Panel_Dashboard_1.Visible = True
        ElseIf Trim(cbo_workflow.Text) = "PENJUALAN" Then
            panel_sales.Visible = True
            Panel_Accounting_DSH.Visible = False
            '   Panel_Dashboard_1.Visible = True
        ElseIf Trim(cbo_workflow.Text) = "KASIR" Then
            Panel_OutletSales.Visible = True
            Panel_Accounting_DSH.Visible = False
            ' Panel_Dashboard_1.Visible = True
        ElseIf Trim(cbo_workflow.Text) = "KEUANGAN" Then
            Panel_Finance.Visible = True
            Panel_Accounting_DSH.Visible = True
            'Panel_Dashboard_1.Visible = False
        ElseIf Trim(cbo_workflow.Text) = "AKUNTANSI" Then
            Panel_Accounting.Visible = True
            Panel_Accounting_DSH.Visible = True
            'Panel_Dashboard_1.Visible = False
        ElseIf Trim(cbo_workflow.Text) = "ASET" Then
            Panel_Accounting.Visible = True
            Panel_Accounting_DSH.Visible = True
            'Panel_Dashboard_1.Visible = False
        End If
    End Sub

    Private Sub PictureBox26_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox26.Click

    End Sub

    Private Sub Label19_Click(sender As System.Object, e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub panel_workflow_visible()
        Panel_Accounting.Visible = False
        Panel_Finance.Visible = False
        Panel_OutletSales.Visible = False
        Panel_Pembelian.Visible = False
        panel_sales.Visible = False
        Panel_Stock.Visible = False
    End Sub

    Private Sub backup_run(ByVal path As String)
        Dim myProcess As New Process()
        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        If (Not System.IO.Directory.Exists("C:\PROGRAM Files (x86)\MySQL Server Yolk\bin\")) Then
            myProcess.StartInfo.WorkingDirectory = "C:\PROGRAM Files\MySQL Server Yolk\bin\"
        Else
            myProcess.StartInfo.WorkingDirectory = "C:\PROGRAM Files (x86)\MySQL Server Yolk\bin\"
        End If
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.Start()
        Me.Activate()
        Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        'Dim mystreamreader As StreamReader = myProcess.StandardOutput
        myStreamWriter.WriteLine("mysqldump --opt --routines -u " & userdb_config & " --password=" & passdb_config & " -h " & server_config & " --port=" & port_config & " " & db_config & " > """ + path + """ ")
        myStreamWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles timer.Tick
        open_conn()
        Dim var_date As Date
        var_date = Now
        lbl_date.Text = Format(var_date, "dd-MM-yyyy")
        lbl_time.Text = Format(var_date, "hh:mm:ss")
        lbl_date2.Text = Format(var_date, "dd-MM-yyyy")
        lbl_time2.Text = Format(var_date, "hh:mm:ss")

        Dim DT As DataTable
        DT = getAutoBackup()
        If DT.Rows.Count > 0 And username = "admin" Then
            If DT.Rows(0).Item("Type") = "Harian" Then
                Dim Jam As TimeSpan
                Dim Path As String
                Jam = DT.Rows(0).Item("time")
                Path = Replace(DT.Rows(0).Item("filepath"), "/", "\")
                If Format(var_date, "hh:mm:ss") = Jam.ToString Then
                    Try
                        SplashScreenManager.ShowForm(MainMenu, GetType(WaitForm1), True, True, False)
                        SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
                        SplashScreenManager.Default.SetWaitFormDescription("Processing Auto Backup . . .")
                        backup_run(Path & "\baksmart" & Format(var_date, "ddMMyyyy") & ".sql")
                    Catch ex As Exception
                        Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
                        alertControl_error.Show(Me, info)
                    Finally
                        SplashScreenManager.CloseForm(False)
                        Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, "Auto Backup Selesai")
                        alertControl_success.Show(Me, info)
                        Me.Enabled = True
                        MainMenu.Enabled = True
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick, TileItem2.ItemClick, TileItem3.ItemClick, TileItem4.ItemClick
        If Panel_Accounting_DSH.Visible = False Then
            Panel_Accounting_DSH.Visible = True
        ElseIf Panel_Accounting_DSH.Visible = True Then
            Panel_Accounting_DSH.Visible = False
        End If
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem5.ItemClick
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Form . . .")
            If Application.OpenForms().OfType(Of frmso).Any Then
                frmso.Activate()
            Else
                frmso.Show()
            End If
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub TileControl1_Click(sender As System.Object, e As System.EventArgs) Handles TileControl1.Click

    End Sub

    Private Sub GroupControl5_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl5.Paint

    End Sub

    Private Sub GroupControl8_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl8.Paint

    End Sub

    Private Sub Panel_Accounting_DSH_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel_Accounting_DSH.Paint

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub FrmCommandPanel_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub GroupControl3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl3.Paint

    End Sub
End Class
