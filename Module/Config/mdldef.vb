Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter
Imports System.Net.NetworkInformation

Module mdldef
    Public Const HKEY_CLASSES_ROOT = &H80000000
    Public Const HKEY_CURRENT_USER = &H80000001
    Public Const HKEY_LOCAL_MACHINE = &H80000002
    Public Const HKEY_USERS = &H80000003
    Public Const HKEY_CURRENT_CONFIG As Long = &H80000005
    Public Const HKEY_DYN_DATA As Long = &H80000006
    Public row_trial As Integer
    Public trial As Boolean
    Public Const ERROR_NO_MORE_ITEMS = 259&
    Public Const BUFFER_SIZE = 255
    Public server_temp As String
    Public openChildForm As Boolean
    Public Const REG_NONE = 0
    Public Const REG_SZ = 1
    Public Const REG_EXPAND_SZ = 2
    Public Const REG_BINARY = 3
    Public Const REG_DWORD = 4
    Public Const REG_DWORD_LITTLE_ENDIAN = 4
    Public Const REG_DWORD_BIG_ENDIAN = 5
    Public Const REG_LINK = 6
    Public Const REG_MULTI_SZ = 7
    Public Const REG_RESOURCE_LIST = 8
    Public Const REG_FULL_RESOURCE_DESCRIPTOR = 9
    Public Const REG_RESOURCE_REQUIREMENTS_LIST = 10
    Public limitPage As Integer = 10

    Public username As String
    Public param_sukses As Boolean
    Public server_date As Date
    Public filename As String
    Public formsource As String
    Public MyReportFormula As String
    Public MyReportFormula_stock As String
    Public Rpt_Stock_Date1 As Date
    Public Rpt_Stock_Date2 As Date
    Public Rpt_Date1 As Date
    Public Rpt_Date2 As Date
    Public Rpt_Stock_Item As String
    Public id_item_rpt As Date
    Dim mysql_command As New MySqlCommand
    Dim mysql_reader As MySqlDataReader


    Dim cmd_sqlselect As New MySqlCommand
    Dim mysql_select As MySqlDataReader
    Dim mysql_adapter As New MySqlDataAdapter
    Public Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long) As Long
    Public Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
    Public Declare Function SetLayeredWindowAttributes Lib "user32" (ByVal hwnd As Long, ByVal crKey As Long, ByVal bAlpha As Byte, ByVal dwFlags As Long) As Long
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
    Public Declare Sub ReleaseCapture Lib "user32" ()
    Public Const WM_NCLBUTTONDOWN = &HA1
    Public Const HTCAPTION = 2

    'use parameter
    Public panel_servicereport As Boolean
    Public panel_stockreport As Boolean
    Public panel_salesreport As Boolean
    Public panel_purchreport As Boolean
    Public panel_accreport As Boolean

    'use RGB
    Public var_red As Integer
    Public var_grey As Integer
    Public var_blue As Integer

    'use RGB Button
    Public var_red_btn As Integer
    Public var_grey_btn As Integer
    Public var_blue_btn As Integer

    'use key
    Public key_cust As String
    Public key_marketing As String
    Public key_supp As String
    Public key_po As String
    Public key_purchase As String
    Public key_ap_pay As String
    Public key_purchase_return As String
    Public key_so As String
    Public key_sales As String
    Public key_sales_return As String
    Public key_service As String
    Public key_ar_pay As String
    Public key_beg_balance As String
    Public key_item As String
    Public key_opname As String
    Public key_adjust_stock As String
    Public key_spend_cash As String
    Public key_receive_cash As String
    Public key_cash_register As String
    Public key_reconcile_bank As String
    Public key_coa As String
    Public key_journal As String
    Public key_all_journal As String
    Public key_ledger As String
    Public key_service_setup As String

    'use constanta
    Public Const ID_TAB_MASTER = 100
    Public Const ID_TAB_OUT = 1000
    Public Const ID_GROUP_MASTER = 200

    Public Const ID_MASTERCUSTOMER = 300
    Public Const ID_MASTERSUPPLIER = 301
    Public Const ID_MASTEREMPLOYEE = 302
    Public Const ID_MASTERCARDLIST = 303
    Public Const ID_MASTER_ITEM = 304
    Public Const ID_ITEM_TYPE = 305
    Public Const ID_ITEM_CAT = 306
    Public Const ID_ITEM_BRAND = 3061

    Public Const ID_ITEM_NAME = 307
    Public Const ID_ITEMBEGINING_BALANCE = 308
    Public Const ID_SERVICE = 608
    Public Const ID_UNIT = 309
    Public Const ID_UNIT_CONVERSION = 310
    Public Const ID_WAREHOUSE = 311
    Public Const ID_EXPEDITION = 3111
    Public Const ID_CURRENCY = 312
    Public Const ID_CURRENCY_CONVERT = 313
    Public Const ID_CARD_FILE_REPORT = 314

    Public Const ID_STOCK_OPNAME = 315
    Public Const ID_STOCK_CORRECTION = 316
    Public Const ID_MOVE_ITEM = 317
    Public Const ID_ITEM_LIST = 318
    Public Const ID_STOCK_REPORT = 319
    Public Const ID_LAPORAN_STOCK = 320

    Public Const ID_RO = 321
    Public Const ID_APP_RO = 322
    Public Const ID_PO = 323
    Public Const ID_RECEIVED_ORDER = 324
    Public Const ID_PURCHASE_INV = 325
    Public Const ID_PURCHASE_RETURN = 326
    Public Const ID_PEMBAYARAN_HUTANG = 327
    Public Const ID_AP_STATUS = 328
    Public Const ID_PURCHASE_REPORT = 329
    Public Const ID_AP_REPORT = 330

    Public Const ID_CASH_RO = 331
    Public Const ID_CASH_APP_RO = 332
    Public Const ID_CASH_PURCHASE_INV = 333
    Public Const ID_CASH_PURCHASE_RETURN = 334

    Public Const ID_SO = 335
    Public Const ID_DO = 336
    Public Const ID_SALES_INV = 337
    Public Const ID_SALES_RETURN = 338
    Public Const ID_PAYMENT_AR = 339
    Public Const ID_AR_STATUS = 340
    Public Const ID_LAPORAN_PIUTANG = 341
    Public Const ID_LAPORAN_JUAL = 342

    Public Const ID_CASHIER = 343
    Public Const ID_CASHIER_REGISTER = 344

    Public Const ID_SERVICE_TRANSACTION = 443
    Public Const ID_SERVICE_MUTATION = 444
    Public Const ID_CASHIER_RETURN = 445
    Public Const ID_AP_INITBALANCE = 446
    Public Const ID_AR_INITBALANCE = 447
    Public Const ID_SET_MARKETING = 448
    Public Const ID_RECEIPT_MONEY = 345
    Public Const ID_SPEND_MONEY = 346
    Public Const ID_RECONCILE = 347
    Public Const ID_CASH_REGISTER = 348
    Public Const ID_TRANS_REPORT = 349
    Public Const ID_RECAP_REPORT = 350

    Public Const ID_COA = 351
    Public Const ID_COA_SETUP = 491
    Public Const ID_CASHBANK_SETUP = 490
    Public Const ID_JOURNAL = 352
    Public Const ID_JOURNAL_LIST = 353
    Public Const ID_LEDGER = 354
    Public Const ID_CLOSE_BOOK = 953
    Public Const ID_ACC_REPORT = 355
    Public Const ID_FIN_REPORT = 356

    Public Const ID_BACKUP = 357
    Public Const ID_RESTORE = 358
    Public Const ID_LOG = 359
    Public Const ID_PATH = 999
    Public Const ID_USERRIGHT = 360
    Public Const ID_EXIT = 361
    Public Const ID_MINIMIZED = 362

    Public Const ID_GROUP_EXIT = 507
    Public Const ID_CHANGE_PASSWORD = 509

    Public no_master As String
    Public no_account As String

    Public var_bulan As Integer
    Public var_tahun As Integer

    Public Sub open_conn()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub default_io()
        If (Not System.IO.Directory.Exists(Application.StartupPath & "\photo\customer\")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\photo\customer\")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath & "\photo\supplier\")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\photo\supplier\")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath & "\photo\marketing\")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\photo\marketing\")
        End If
        If (Not System.IO.Directory.Exists(Application.StartupPath & "\photo\item\")) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\photo\item\")
        End If
    End Sub

    Public Function get_count_data(table As String, field As String) As Integer
        Dim DT As New DataTable

        Try
            With cmd_sqlselect
                .Connection = conn
                .CommandText = "select count(" & field & ") from " & table & ""
                .CommandType = CommandType.Text
            End With
            mysql_adapter.SelectCommand = cmd_sqlselect
            mysql_adapter.Fill(DT)
            Return DT.Rows(0).Item(0)

        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return DT.Rows(0).Item(0)
        End Try

    End Function

    Public Function getIPAddress() As String
        Try
            Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface
            Dim myMac As String = String.Empty

            For Each adapter In adapters
                Select Case adapter.NetworkInterfaceType
                    'Exclude Tunnels, Loopbacks and PPP
                    Case NetworkInterfaceType.Tunnel, NetworkInterfaceType.Loopback, NetworkInterfaceType.Ppp
                    Case Else
                        If Not adapter.GetPhysicalAddress.ToString = String.Empty And Not adapter.GetPhysicalAddress.ToString = "00000000000000E0" Then
                            myMac = adapter.GetPhysicalAddress.ToString
                            Exit For ' Got a mac so exit for
                        End If

                End Select
            Next adapter

            Return myMac
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Function GetDriveSerialNumber(ByVal DriveLetter As String) As String
        Dim fso As Object, Drv As Object
        Dim DriveSerial As String
        'Create a FileSystemObject object
        fso = CreateObject("Scripting.FileSystemObject")

        'Assign the current drive letter if not specified
        If DriveLetter <> "" Then
            Drv = fso.GetDrive(DriveLetter)
        Else
            Drv = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
        End If

        With Drv
            If .IsReady Then
                DriveSerial = Math.Abs(.SerialNumber)
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With

        'Clean up
        Drv = Nothing
        fso = Nothing

        GetDriveSerialNumber = Hex(DriveSerial)
    End Function


    Public Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & _
            "{impersonationLevel=impersonate}!\\" & _
            computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from " & _
            "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids = _
            cpu_ids.Substring(2)

        Return cpu_ids
    End Function



    Public Declare Function RegCreateKey Lib "advapi32.dll" Alias "RegCreateKeyA" (ByVal hKey As Long, ByVal lpSubKey As String, phkResult As Long) As Long
    Public Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal Reserved As Long, ByVal dwType As Long, lpData As String, ByVal cbData As Long) As Long
    Public Declare Function RegSetValueEx Lib "advapi32.dll" Alias "RegSetValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal Reserved As Long, ByVal dwType As Long, lpData As Long, ByVal cbData As Long) As Long
    Public Declare Function RegOpenKey Lib "advapi32.dll" Alias "RegOpenKeyA" (ByVal hKey As Long, ByVal lpSubKey As String, phkResult As Long) As Long
    Public Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal lpReserved As Long, lpType As Long, lpData As String, lpcbData As Long) As Long
    Public Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Long, ByVal lpValueName As String, ByVal lpReserved As Long, lpType As Long, lpData As Long, lpcbData As Long) As Long
    Public Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Long) As Long
    Public Declare Function RegEnumKeyEx Lib "advapi32.dll" Alias "RegEnumKeyExA" (ByVal hKey As Long, ByVal dwIndex As Long, ByVal lpName As String, lpcbName As Long, ByVal lpReserved As Long, ByVal lpClass As String, lpcbClass As Long, lpftLastWriteTime As String) As Long
    Public Declare Function RegEnumValue Lib "advapi32.dll" Alias "RegEnumValueA" (ByVal hKey As Long, ByVal dwIndex As Long, ByVal lpValueName As String, lpcbValueName As Long, ByVal lpReserved As Long, lpType As Long, lpData As String, lpcbData As Long) As Long
    Public Declare Function RegEnumValue Lib "advapi32.dll" Alias "RegEnumValueA" (ByVal hKey As Long, ByVal dwIndex As Long, ByVal lpValueName As String, lpcbValueName As Long, ByVal lpReserved As Long, lpType As Long, lpData As Long, lpcbData As Long) As Long
    Public Declare Function RegDeleteKey Lib "advapi32.dll" Alias "RegDeleteKeyA" (ByVal hKey As Long, ByVal lpSubKey As String) As Long
    Public Declare Function RegDeleteValue Lib "advapi32.dll" Alias "RegDeleteValueA" (ByVal hKey As Long, ByVal lpValueName As String) As Long


    Public Function SaveString(subkey As String, strPath As String, strvalue As String, strData As String)
        Dim hregkey As Long
        Dim Y As Long
        Call RegCreateKey(subkey, strPath, hregkey)
        Call RegSetValueEx(hregkey, strvalue, 0, REG_SZ, strData, Len(strData))
        Call RegCloseKey(hregkey)
    End Function


    Public db_name As String
    Public db_server As String
    Public db_port As String
    Public db_user As String
    Public db_pass As String
    Public Sub MySQLDSN(tempdata As String, dbserver As String)
        Dim Database As String, driverpath As String, port As String, pwd As String, server As String, uid As String, Driver As String
        Database = tempdata
        'driverpath = "C:\Program Files\MySQL\Connector ODBC 5.1\myodbc5.dll"
        driverpath = "C:\WINDOWS\system32\myodbc5.dll"

        Database = "yolkaccounting"
        port = "3306"
        pwd = "L1v326110711"
        server = dbserver
        uid = "root"
        Driver = "MySQL ODBC 5.1 Driver"
        Call SaveString(HKEY_LOCAL_MACHINE, "Software\ODBC\ODBC.INI\yolkaccounting", "DATABASE", Database)
        Call SaveString(HKEY_LOCAL_MACHINE, "Software\ODBC\ODBC.INI\yolkaccounting", "DESCRIPTION", "Database")
        Call SaveString(HKEY_LOCAL_MACHINE, "Software\ODBC\ODBC.INI\yolkaccounting", "Driver", driverpath)
        Call SaveString(HKEY_LOCAL_MACHINE, "Software\ODBC\ODBC.INI\yolkaccounting", "PORT", port)
        Call SaveString(HKEY_LOCAL_MACHINE, "Software\ODBC\ODBC.INI\yolkaccounting", "PWD", pwd)
        Call SaveString(HKEY_LOCAL_MACHINE, "Software\ODBC\ODBC.INI\yolkaccounting", "SERVER", server)
        Call SaveString(HKEY_LOCAL_MACHINE, "Software\ODBC\ODBC.INI\yolkaccounting", "UID", uid)
        Call SaveString(HKEY_LOCAL_MACHINE, "Software\ODBC\ODBC.INI\ODBC Data Sources", "yolkaccounting", Driver)
    End Sub



    Public Function get_activated(serial1 As String, serial2 As String, serial3 As String, serial4 As String) As Integer
        'Dim DT As New DataTable

        Try
            '    With cmd_sqlselect
            '        .Connection = conn
            '        .CommandText = "select count(ip_address) from i_activation where serial1=md5('" & serial1 & "') and serial2=md5('" & serial2 & "') and serial3=md5('" & serial3 & "') and serial4=md5('" & serial4 & "')"
            '        .CommandType = CommandType.Text
            '    End With
            '    mysql_adapter.SelectCommand = cmd_sqlselect
            '    mysql_adapter.Fill(DT)
            '    Return DT.Rows(0).Item(0)
            Dim act1, act2, act3, act4 As String
            act1 = EnkripsiID(LCase(serial1))
            act2 = EnkripsiID(LCase(serial2))
            act3 = EnkripsiID(LCase(serial3))
            act4 = EnkripsiID(LCase(serial4))

            If My.Settings.SerialNumber <> serial1 & serial2 & serial3 & serial4 And My.Settings.ActivationCode <> act1 & act2 & act3 & act4 And My.Settings.Activated <> True Then
                My.Settings.Activated = False
                My.Settings.SerialNumber = ""
                My.Settings.ActivationCode = ""
                My.Settings.Save()
                Return 0
            Else
                Return 1
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
            Return 0
        End Try

    End Function

    Public dayusetrial As Integer
    Public Sub is_expired()
        Dim dt As Date = My.Settings.StartDate
        Dim days As Double = (Date.Now.AddDays(-14).Subtract(dt)).TotalDays

        If days <= 0 Then
            My.Settings.IsExpired = False
            My.Settings.Save()
        Else
            My.Settings.IsExpired = True
            My.Settings.Save()
        End If

        If My.Settings.StartDate = "#12:00:00 AM#" Then
            My.Settings.IsExpired = False
            My.Settings.Save()
            'days = 0
        End If

        dayusetrial = Math.Abs(days)
    End Sub

    Public Sub akses()
        key_cust = "MN_INPUT_CUSTOMER"
        key_marketing = "MN_INPUT_MARKETING"
        key_supp = "MN_INPUT_SUPPLIER"
        key_po = "MN_INPUT_PO"
        key_purchase = "MN_INPUT_PURCHASE"
        key_ap_pay = "MN_INPUT_PAYMENT_AP"
        key_purchase_return = "MN_PURCHASE_RETURN"
        key_so = "MN_INPUT_SO"
        key_sales = "MN_SALES_INV"
        key_sales_return = "MN_INPUT_SALES_RETURN"
        key_service = "MN_SERVICE_TRN"
        key_ar_pay = "MN_INPUT_PAYMENT_AR"
        key_beg_balance = "MN_BEG_BALANCE"
        key_item = "MN_INPUT_ITEM"
        key_opname = "MN_STOK_OPNAME"
        key_adjust_stock = "MN_INPUT_ADJUST"
        key_spend_cash = "MN_INPUT_SPEND_MONEY"
        key_receive_cash = "MN_INPUT_RECEIVE_MONEY"
        key_cash_register = "MN_CASH_REGISTER"
        key_reconcile_bank = "MN_RECONCILE"
        key_coa = "MN_COA"
        key_journal = "MN_JURNAL"
        key_ledger = "MN_LEDGER"
        key_service_setup = "MN_SETUP_SERVICE"
    End Sub

    Public Sub close_conn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Function server_datetime() As Date
        open_conn()
        With mysql_command
            .Connection = conn
            .CommandText = "select now()"
            .CommandType = CommandType.Text
        End With
        mysql_reader = mysql_command.ExecuteReader
        If mysql_reader.HasRows Then
            mysql_reader.Read()
            server_date = mysql_reader.Item(0)
            mysql_reader.Close()
            Return server_date
        End If
    End Function

    Public Sub pic_layout_single()
        With FrmCommandPanel
            .pic_accounts.BorderStyle = BorderStyle.None
            .pic_banking.BorderStyle = BorderStyle.None
            .pic_cardfile.BorderStyle = BorderStyle.None
            .pic_inventory.BorderStyle = BorderStyle.None
            .pic_purchase.BorderStyle = BorderStyle.None
            .pic_sales.BorderStyle = BorderStyle.None
            .pic_setting.BorderStyle = BorderStyle.None
        End With
    End Sub

    Public Sub pic_color_default()
        With FrmCommandPanel
            .pic_accounts.BackColor = Color.Transparent
            .pic_banking.BackColor = Color.Transparent
            .pic_cardfile.BackColor = Color.Transparent
            .pic_inventory.BackColor = Color.Transparent
            .pic_purchase.BackColor = Color.Transparent
            .pic_sales.BackColor = Color.Transparent
            .pic_setting.BackColor = Color.Transparent
        End With
    End Sub

    Public Sub mn_layut_def(ByVal lbl As Control)
        lbl.ForeColor = Color.Black
        lbl.Cursor = Cursors.Arrow
    End Sub

    Public Sub mn_layut_hover(ByVal lbl As Control)
        lbl.ForeColor = Color.MediumSeaGreen
        lbl.Cursor = Cursors.Hand
    End Sub

    Public Sub MenuClosed()
        With MainMenu
            .mnReparasi.Visible = False
            .mnAccounting.Visible = False
            .menuMasterMktg.Visible = False
            .menuMasterSupp.Visible = False
            .mnAccReport.Visible = False
            .mnAP.Visible = False
            .mnAPAge.Visible = False
            .mnAPPayment.Visible = False
            .mnAPStatus.Visible = False
            .mnAR.Visible = False
            .mnARAge.Visible = False
            .mnARPayment.Visible = False
            .mnARStatus.Visible = False
            .mnBankReconcile.Visible = False
            .mnBckup.Visible = False
            .mnCashBank.Visible = False
            .mnCashBankHistReport.Visible = False
            .mnCashBankReg.Visible = False
            .mnCashBankReport.Visible = False
            .mnCashRecapReport.Visible = False
            .mnCOA.Visible = False
            .mnCompany.Visible = False
            .mnConvertCurr.Visible = False
            .mnCreditNotes.Visible = False
            .mnCurrency.Visible = False
            .mnDebitNotes.Visible = False
            .mnExit.Visible = True
            .mnFile.Visible = True
            .mnFinAnalystReport.Visible = False

            .mnItemBrand.Visible = False
            .mnItemCat.Visible = False
            .mnItemList.Visible = False
            .mnItemReport.Visible = False
            .mnItemTransfer.Visible = False
            .mnJournal.Visible = False
            .mnJournalList.Visible = False
            .mnLedger.Visible = False
            .mnLog.Visible = False
            .mnLogin.Visible = True

            .mnMaster.Visible = False
            .mnMasterCust.Visible = False
            .mnMasterInventory.Visible = False
            .mnMasterItem.Visible = False
            .mnMasterService.Visible = False

            .mnPurchAnalystReport.Visible = False
            .mnPurchase.Visible = False
            .mnPurchaseInvoice.Visible = False
            .mnPurchaseOrder.Visible = False
            .mnPurchaseReturn.Visible = False
            .mnPurchReport.Visible = False
            .mnPurchStdReport.Visible = False
            .mnReceivedItem.Visible = False
            .mnReceivedMoney.Visible = False
            .mnRequestOrder.Visible = False
            .mnRestore.Visible = False
            .mnSales.Visible = False
            .mnSalesAnalystReport.Visible = False
            .mnSalesInvoice.Visible = False
            .mnSalesOrder.Visible = False
            .mnSalesReport.Visible = False
            .mnSalesReturn.Visible = False
            .mnSalesStdReport.Visible = False
            .mnSpendMoney.Visible = False
            .mnStdAccReport.Visible = False
            .mnStock.Visible = False
            .mnStockAwal.Visible = False
            .mnStockCorrection.Visible = False
            .mnStockOpname.Visible = False
            .mnStockReport.Visible = False
            .mnTools.Visible = False
            .mnUnit.Visible = False
            .mnUnitConvers.Visible = False
            .mnWH.Visible = False
            .mnItemJenis.Visible = False
            .mnReparasi.Visible = False
            .mnService.Visible = False
        End With
    End Sub

    Public Sub FormLayout()
        var_blue_btn = 255
        var_grey_btn = 241
        var_red_btn = 232
    End Sub


    Public Sub MenuOpened()

        With MainMenu
            .mnAccounting.Visible = True
            .menuMasterMktg.Visible = True
            .menuMasterSupp.Visible = True
            .mnAccReport.Visible = True
            .mnAP.Visible = True
            .mnAPAge.Visible = True
            .mnAPPayment.Visible = True
            .mnAPStatus.Visible = True
            .mnAR.Visible = True
            .mnARAge.Visible = True
            .mnARPayment.Visible = True
            .mnARStatus.Visible = True
            .mnBankReconcile.Visible = True
            .mnBckup.Visible = True
            .mnCashBank.Visible = True
            .mnCashBankHistReport.Visible = True
            .mnCashBankReg.Visible = True
            .mnCashBankReport.Visible = True
            .mnCashRecapReport.Visible = True
            .mnCOA.Visible = True
            .mnCompany.Visible = True
            .mnConvertCurr.Visible = True
            '.mnCreditNotes.Visible = True
            .mnCurrency.Visible = True
            '.mnDebitNotes.Visible = True
            '.mnDeliveredItem.Visible = True
            .mnExit.Visible = True
            .mnFile.Visible = True
            '.mnFinAnalystReport.Visible = True

            .mnItemBrand.Visible = False
            .mnItemCat.Visible = True
            .mnItemList.Visible = True
            .mnItemReport.Visible = True
            .mnItemTransfer.Visible = True
            .mnJournal.Visible = True
            .mnJournalList.Visible = True
            .mnLedger.Visible = True
            .mnLog.Visible = True
            .mnLogin.Visible = True

            .mnMaster.Visible = True
            .mnMasterCust.Visible = True
            .mnMasterInventory.Visible = True
            .mnMasterItem.Visible = True
            .mnMasterService.Visible = True

            '.mnPurchAnalystReport.Visible = True
            .mnPurchase.Visible = True
            .mnPurchaseInvoice.Visible = True
            .mnPurchaseOrder.Visible = True
            .mnPurchaseReturn.Visible = True
            .mnPurchReport.Visible = True
            .mnPurchStdReport.Visible = True
            .mnReceivedItem.Visible = True
            .mnReceivedMoney.Visible = True
            .mnRequestOrder.Visible = True
            .mnRestore.Visible = True
            .mnSales.Visible = True
            '.mnSalesAnalystReport.Visible = True
            .mnSalesInvoice.Visible = True
            .mnSalesOrder.Visible = True
            .mnSalesReport.Visible = True
            .mnSalesReturn.Visible = True
            .mnSalesStdReport.Visible = True
            .mnSpendMoney.Visible = True
            .mnStdAccReport.Visible = True
            .mnStock.Visible = True
            .mnStockAwal.Visible = True
            .mnStockCorrection.Visible = True
            .mnStockOpname.Visible = True
            .mnStockReport.Visible = True
            .mnTools.Visible = True
            .mnUnit.Visible = True
            .mnUnitConvers.Visible = True
            .mnWH.Visible = True
            .mnItemJenis.Visible = True
            .mnReparasi.Visible = True
            '.mnService.Visible = True
            '.mnPeleburan.Visible = True
            '.mnPeleburanBahan.Visible = True
        End With
    End Sub

    Public Function onlyNumbers(ByVal KeyChar As Char) As Boolean
        Dim allowedChars As String

        allowedChars = "0123456789."

        If allowedChars.IndexOf(KeyChar) = -1 And (Asc(KeyChar)) <> 8 Then
            Return True
        End If

        Return False
    End Function

    Public Sub validate_cell_keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then
            e.Handled = True
        End If

    End Sub


    Public Sub ProcessKey(ByVal FormString As String, ByVal keyData As System.Windows.Forms.Keys)
        Select Case keyData
            Case Keys.F5
                If FormString = "Cashier" Then
                    Dim new_list_item As New frm_display_item
                    new_list_item.Show()
                    new_list_item.WindowState = FormWindowState.Maximized
                    new_list_item.formsource_sales_item = True
                    frmcashier.Enabled = False
                End If
            Case Keys.F2
                ' Do something 

            Case Keys.F3
                ' Do more

            Case Keys.Escape
                ' Crap

            Case Else


        End Select

    End Sub

End Module
