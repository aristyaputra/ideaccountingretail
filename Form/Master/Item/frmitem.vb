Imports System.IO
Imports System.Text
Imports System.Drawing
Imports Ozeki.Camera
Imports Ozeki.Media.IPCamera
Imports Ozeki.Media.MediaHandlers
Imports Ozeki.Media.MediaHandlers.Video
Imports Ozeki.Media.Video.Controls
Imports System.IO.Path
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraBars.Alerter
Imports Microsoft.Office.Interop
Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data
Imports ThoughtWorks.QRCode.Codec.Util
Imports System.Data.OleDb

Public Class frmitem
    Dim index_importingfield_jenis, index_importingfield_cat, index_importingfield_brand As Integer
    Dim DTExcel As New DataTable
    Dim FilenameExcel As String
    Dim MyConnection As New OleDbConnection
    Dim command_excel As New OleDbCommand
    Dim sqlreader_excel As New OleDbDataAdapter
    Dim importingField As String
    Dim importingValue As String
    Dim rowIndex As Integer
    Dim colIndex As Integer
    Dim sukses_qr As Integer
    Dim insert As Integer
    Dim edit As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan, pesan2 As String
    Dim Def_Kode As String
    Dim Kode1, Kode2, Kode3 As String
    Dim FileName_Edit As String
    Dim status_reset_img As Boolean
    Public zRow, zCol As Integer
    Dim timer As New Timer
    Dim id_category As Integer
    Dim id_jenis As Integer
    Dim id_brand As Integer
    Dim id_account As Integer
    Dim main_unit As Integer
    Dim buy_unit As Integer
    Dim sell_unit As Integer
    Dim flag_buy As Integer
    Dim flag_sell As Integer
    Dim flag_inv As Integer
    Dim max_qty As Integer
    Dim min_qty As Integer
    Dim id_account_cogs As Integer
    Dim account_cogs As Integer

    Dim var_id_category As String
    Dim var_id_jenis As String
    Dim var_id_account As String
    Dim var_main_unit As String
    Dim var_buy_unit As String
    Dim var_sell_unit As String
    Dim var_flag_buy As Integer
    Dim var_flag_sell As Integer
    Dim var_flag_inv As Integer
    Dim var_max_qty As Integer
    Dim var_min_qty As Integer


    'ozeki camera
    'Ozeki Camera
    Private _camera As OzekiCamera
    'USB
    Private _imageProvider As New DrawingImageProvider
    Private _connector As New MediaConnector
    Private _videoViewerWF1 As New VideoViewerWF
    'IP atau RTSP
    'USB
    Private _imageProvider2 As New DrawingImageProvider
    Private _connector2 As New MediaConnector
    Private _videoViewerWF2 As New VideoViewerWF

    'QRCode USB Camera
    Private _imageProvider3 As New DrawingImageProvider
    Private _connector3 As New MediaConnector
    Private _videoViewerWF3 As New VideoViewerWF

    Private _myCameraUrlBuilder As New CameraURLBuilderWF
    Private OnvifCamera As IIPCamera
    Private speaker As Speaker
    Dim cuurentCameraStat As Integer

    Private Sub detail(ByVal criteria As String, ByVal sender As Object, ByVal e As EventArgs)
        open_conn()
        'On Error Resume Next
        'Dim current_row As Integer
        'current_row = DataGridView2.CurrentCell.RowIndex
        Dim DT As DataTable
        Dim DT_stock As DataTable
        Dim var_chk As Integer
        btn_set_bonus.Visible = True
        If chk_date.Checked = True Then
            var_chk = 1
        Else
            var_chk = 0
        End If
        edit = 1
        insert = 0
        btn_del2.Enabled = True
        DT = select_master("select_item", "id_item", criteria, 1, var_chk, tglawal.Value, tglakhir.Value)
        DT_stock = select_get_stock(criteria)
        If DT.Rows.Count > 0 Then
            txt_itemid.Text = DT.Rows(0).Item("id_item").ToString
            txt_itemname.Text = DT.Rows(0).Item("item_name").ToString
            cbo_jenis.EditValue = DT.Rows(0).Item("id_jenis")
            cbo_kategori.EditValue = DT.Rows(0).Item("id_category")
            txt_kadar.Text = DT.Rows(0).Item("kadar")
            cbo_brand.EditValue = DT.Rows(0).Item("id_brand")
            If DT.Rows(0).Item("use_notifminqty") = 0 Then
                chkwhithoutnotif.Checked = True
            Else
                chkwhithoutnotif.Checked = False
            End If
            cbo_acc.EditValue = DT.Rows(0).Item("id_account")
            cbo_acc2.EditValue = DT.Rows(0).Item("id_account_cogs")
            cbo_mainunit.EditValue = LCase(DT.Rows(0).Item("main_unit"))
            If cbo_mainunit.Text = "" Then
                cbo_mainunit.EditValue = LCase(DT.Rows(0).Item("main_unit"))
            End If
            cbo_sellunit.EditValue = DT.Rows(0).Item("sell_unit")
            If cbo_sellunit.Text = "" Then
                cbo_sellunit.EditValue = LCase(DT.Rows(0).Item("sell_unit"))
            End If
            cbounit_min_qty.EditValue = DT.Rows(0).Item("min_qty_unit").ToString
            If cbounit_min_qty.Text = "" Then
                cbounit_min_qty.EditValue = LCase(DT.Rows(0).Item("min_qty_unit").ToString)
            End If
            cbo_buyunit.EditValue = DT.Rows(0).Item("buy_unit")
            If cbo_buyunit.Text = "" Then
                cbo_buyunit.EditValue = LCase(DT.Rows(0).Item("buy_unit"))
            End If
            txt_price.Text = FormatNumber(DT.Rows(0).Item("sell_price"), 0)
            cbo_wh.EditValue = DT.Rows(0).Item("id_warehouse")
            txt_max_qty.Text = FormatNumber(DT.Rows(0).Item("max_qty"), 0)
            txt_min_qty.Text = FormatNumber(DT.Rows(0).Item("min_qty"), 0)
            txt_keterangan.Text = DT.Rows(0).Item("notes").ToString
            txt_save_path.Text = DT.Rows(0).Item("blob_image").ToString
            If DT.Rows(0).Item("flag_buy") = 1 Then
                chk_penolong.Checked = True
            Else
                chk_penolong.Checked = False
            End If
            If DT.Rows(0).Item("flag_sell") = 1 Then
                chk_sellitem.Checked = True
            Else
                chk_sellitem.Checked = False
            End If
            If DT.Rows(0).Item("flag_inv") = 1 Then
                chk_invitem.Checked = True
            Else
                chk_invitem.Checked = False
            End If
            txt_length.Text = DT.Rows(0).Item("length")
            txt_width.Text = DT.Rows(0).Item("width")
            txt_height.Text = DT.Rows(0).Item("height")
            txt_weight.Text = DT.Rows(0).Item("weight")
        End If
        FileName_Edit = DT.Rows(0).Item("blob_image").ToString
        If DT.Rows(0).Item("blob_image").ToString = "" Then
            filename = Replace(Application.StartupPath & "\photo\no-image2.jpg", "\", "/")
            txt_photo.Image = Image.FromFile(Application.StartupPath & "\photo\no-image2.jpg")
        Else
            Dim FileToSaveAs As String = Trim(txt_save_path.Text)
            If System.IO.File.Exists(FileToSaveAs) Then
                Using fs As New FileStream(FileToSaveAs, FileMode.Open, FileAccess.Read)
                    txt_photo.Image = Image.FromStream(fs)
                End Using
                filename = Replace(DT.Rows(0).Item("blob_image"), "/", "\")
            Else
                filename = Replace(Application.StartupPath & "\photo\no-image2.jpg", "\", "/")
                txt_photo.Image = Image.FromFile(Application.StartupPath & "\photo\no-image2.jpg")
            End If
        End If
        txt_photo.SizeMode = PictureBoxSizeMode.StretchImage

        If get_def_path("Item") = "" Then
            txt_save_path.Text = "C:" & "\" & txt_itemid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        Else
            txt_save_path.Text = Replace(get_def_path("Item"), "/", "\") & "\" & txt_itemid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        End If

        If DT_stock.Rows.Count > 0 Then
            txt_stock.Text = DT_stock.Rows(0).Item(0)
        End If
        If DT.Rows(0).Item("active_status") = 0 Then
            CheckBox4.Checked = True
        ElseIf DT.Rows(0).Item("active_status") = 1 Then
            CheckBox4.Checked = False
        End If
        txt_qty_bought.Text = DT.Rows(0).Item("qty_to_disc")
        cbo_unitbonus.Text = ""
        cbo_unitbonus.SelectedText = DT.Rows(0).Item("item_disc_unit")
        view_disc_item()
    End Sub

    Private Sub frmitem_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmitem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        'On Error Resume Next
        If _camera Is Nothing Then
            Return
        End If

        _camera.Disconnect()
        _connector.Disconnect(_camera.VideoChannel, _imageProvider)
        _connector3.Disconnect(_camera.VideoChannel, _imageProvider3)
        _camera = Nothing

        If OnvifCamera Is Nothing Then
            Return
        End If

        OnvifCamera.Disconnect()
        _connector2.Disconnect(_camera.VideoChannel, _imageProvider2)
        _camera = Nothing

        MainMenu.Activate()

    End Sub

    Private Sub frmitem_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmitem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        open_conn()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Item . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            Call notification()
            txt_kadar.Text = 0
            insert = 1
            edit = 0
            Dim Rows As Integer
            Dim i As Integer
            Me.WindowState = FormWindowState.Maximized
            Me.MdiParent = MainMenu
            btn_set_bonus.Visible = False
            Rows = select_unit.Rows.Count - 1
            Panel1.Visible = False

            btn_del2.Enabled = False
            cbo_search.Text = "Item ID"
            DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            txt_price.Text = 0
            chk_date.Checked = False
            tglakhir.Enabled = False
            tglawal.Enabled = False
            datagrid_layout()
            filename = Replace(Application.StartupPath & "\photo\no-image2.jpg", "\", "/")
            txt_photo.Image = Image.FromFile(filename)
            txt_max_qty.Text = 0
            txt_min_qty.Text = 0
            txt_length.Text = 0
            txt_width.Text = 0
            txt_height.Text = 0
            txt_weight.Text = 0
            chkbarcode.Checked = True
            txt_stock.Text = 0
            cbo_acc.EditValue = GetInventoryDefAcc()
            cbo_acc2.EditValue = GetCOGSDefAcc()
            cbo_wh.EditValue = GetWHDef()
            If get_def_path("Item") = "" Then
                txt_save_path.Text = "C:" & "\" & txt_itemid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
            Else
                txt_save_path.Text = Replace(get_def_path("Item"), "/", "\") & "\" & txt_itemid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
            End If
            chk_sellitem.Checked = True
            'setting usb camera
            _connector = New MediaConnector()
            _imageProvider = New DrawingImageProvider()
            _videoViewerWF1 = New VideoViewerWF()
            _videoViewerWF1.Size = Panel4.Size
            Panel4.Controls.Add(_videoViewerWF1)
            _videoViewerWF1.FrameStretch = FrameStretch.Fill

            'setting ip camera
            _connector2 = New MediaConnector()
            _imageProvider2 = New DrawingImageProvider()
            _videoViewerWF2 = New VideoViewerWF()
            _videoViewerWF2.Size = Panel5.Size
            Panel5.Controls.Add(_videoViewerWF2)
            _videoViewerWF2.FrameStretch = FrameStretch.Fill

            'setting qrcode
            _connector3 = New MediaConnector()
            _imageProvider3 = New DrawingImageProvider()
            _videoViewerWF3 = New VideoViewerWF()
            _videoViewerWF3.Size = Panel7.Size
            Panel7.Controls.Add(_videoViewerWF3)
            _videoViewerWF3.FrameStretch = FrameStretch.Fill

            speaker = speaker.GetDefaultDevice()
            cuurentCameraStat = 0
            panel_item_disc.Visible = False
            cbo_search_item.Text = "Item ID"
            cbo_wh.EditValue = GetWHDef()
            '    GridList_Customer.OptionsView.ColumnAutoWidth = False
            view_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub


    Private Sub Load_MtgcComboBoxUnitItem()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_combo_unit_item(Trim(txt_itemid.Text))

        cbo_unitbonus.SelectedIndex = -1
        cbo_unitbonus.Items.Clear()
        cbo_unitbonus.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_unitbonus.SourceDataString = New String(1) {"id_unit", "unit"}
        cbo_unitbonus.SourceDataTable = dtLoading
        cbo_unitbonus.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        cbo_unitbonus.GridLineVertical = True
        cbo_unitbonus.GridLineHorizontal = True
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If get_def_path("Item") = "" Then
            txt_save_path.Text = "C:" & "\" & txt_itemid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        Else
            txt_save_path.Text = Replace(get_def_path("Item"), "/", "\") & "\" & txt_itemid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        End If
        If insert = 1 Then
            If getTemplateAkses(username, "MN_ITEM_NAME_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_ITEM_NAME_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If IsNumeric(txt_kadar.Text) = False Then
            txt_kadar.Text = 0
        End If

        If cbo_acc.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih akun persediaan")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If cbo_jenis.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih Jenis Persediaan")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If cbo_kategori.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih Kategori Persediaan")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        'If cbo_brand.EditValue = Nothing Then
        '    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih merek persediaan")
        '    alertControl_warning.Show(Me, info)
        '    Exit Sub
        'End If
        If cbo_acc2.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih akun harga pokok persediaan")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        If Trim(txt_qty_bought.Text) = "" Then
            txt_qty_bought.Text = 0
        End If

        If trial = True Then
            If get_count_data("mst_item", "id_item") > row_trial Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Batas untuk input versi trial telah habis, silahkan membeli produk ini")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        Try
            insert_data()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(Me, info)
        End Try

    End Sub

    Private Sub txt_photo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_photo.MouseHover
        open_conn()
        Cursor = Cursors.Hand
    End Sub

    Private Sub txt_photo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_photo.MouseLeave
        open_conn()
        Cursor = Cursors.Arrow
    End Sub

    Public Sub insert_data()
        open_conn()
        Dim var_status_aktif As Integer
        Dim var_buy As Integer
        Dim var_sell As Integer
        Dim var_inv As Integer
        Dim var_use_minqty As Integer

        If chkwhithoutnotif.Checked = True Then
            var_use_minqty = 0
        Else
            var_use_minqty = 1
        End If

        If CheckBox4.Checked = True Then
            var_status_aktif = 0
        Else
            var_status_aktif = 1
        End If

        If chk_invitem.Checked = True Then
            var_inv = 1
        Else
            var_inv = 0
        End If

        If chk_sellitem.Checked = True Then
            var_sell = 1
        Else
            var_sell = 0
        End If

        If chk_penolong.Checked = True Then
            var_buy = 1
        Else
            var_buy = 0
        End If

        Dim FileToSaveAs As String = Trim(txt_save_path.Text)
        Dim rowJenis, rowKategori, rowBrand, rowAccount, rowAccount2, rowWH, rowMainUnit, rowBuyUnit, rowSellUnit, rowMinQtyUnit As DataRowView
        rowJenis = TryCast(cbo_jenis.Properties.GetRowByKeyValue(cbo_jenis.EditValue), DataRowView)
        rowKategori = TryCast(cbo_kategori.Properties.GetRowByKeyValue(cbo_kategori.EditValue), DataRowView)
        Dim BrandString As String
        If cbo_brand.EditValue = Nothing Then
            BrandString = ""
        Else
            rowBrand = TryCast(cbo_brand.Properties.GetRowByKeyValue(cbo_brand.EditValue), DataRowView)
            BrandString = rowBrand.Item("mst_itembrand_id").ToString
        End If
        rowAccount = TryCast(cbo_acc.Properties.GetRowByKeyValue(cbo_acc.EditValue), DataRowView)
        rowAccount2 = TryCast(cbo_acc2.Properties.GetRowByKeyValue(cbo_acc2.EditValue), DataRowView)
        rowWH = TryCast(cbo_wh.Properties.GetRowByKeyValue(cbo_wh.EditValue), DataRowView)
        rowMainUnit = TryCast(cbo_mainunit.Properties.GetRowByKeyValue(cbo_mainunit.EditValue), DataRowView)
        rowBuyUnit = TryCast(cbo_buyunit.Properties.GetRowByKeyValue(cbo_buyunit.EditValue), DataRowView)
        rowSellUnit = TryCast(cbo_sellunit.Properties.GetRowByKeyValue(cbo_sellunit.EditValue), DataRowView)
        Dim UnitQty_Min As String
        If chkwhithoutnotif.Checked = True Then
            UnitQty_Min = ""
        Else
            rowMinQtyUnit = TryCast(cbounit_min_qty.Properties.GetRowByKeyValue(cbounit_min_qty.EditValue), DataRowView)
            UnitQty_Min = rowMinQtyUnit.Item("id_unit")
        End If


        If insert = 1 Then
            Call insert_item(Trim(txt_itemid.Text), Trim(txt_itemname.Text), rowKategori.Item("mst_itemcat_id"), rowJenis.Item("mst_itemjenis_id"), _
                 rowAccount.Item("id_account"), rowMainUnit.Item("id_unit"), rowBuyUnit.Item("id_unit"), rowSellUnit.Item("id_unit"), var_buy, var_sell, var_inv, _
                 FileToSaveAs, username, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, rowWH.Item("id_warehouse"), Replace(txt_price.Text, ",", ""), rowWH.Item("id_warehouse"), Replace(txt_max_qty.Text, ",", ""), Replace(txt_min_qty.Text, ",", ""), txt_keterangan.Text, Replace(txt_length.Text, ",", ""), Replace(txt_width.Text, ",", ""), Replace(txt_height.Text, ",", ""), Replace(txt_weight.Text, ",", ""), rowAccount2.Item("id_account"), rowAccount2.Item("account_name"), UnitQty_Min, BrandString, Replace(txt_qty_bought.Text, ",", ""), Trim(txt_itemid.Text), 0, 0, "", cbo_unitbonus.Text, var_status_aktif, txt_kadar.Text, var_use_minqty)

            Dim rows_itemdisc, x As Integer
            rows_itemdisc = DataGridView3.Rows.Count
            If rows_itemdisc > 0 Then
                For x = 0 To DataGridView3.Rows.Count - 1
                    Call insert_item(Trim(txt_itemid.Text), Trim(txt_itemname.Text), rowKategori.Item("mst_itemcat_id"), rowJenis.Item("mst_itemjenis_id"), _
                         rowAccount.Item("id_account"), rowMainUnit.Item("id_unit"), rowBuyUnit.Item("id_unit"), rowSellUnit.Item("id_unit"), var_buy, var_sell, var_inv, _
                        FileToSaveAs, username, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, rowWH.Item("id_warehouse"), Replace(txt_price.Text, ",", ""), rowWH.Item("id_warehouse"), Replace(txt_max_qty.Text, ",", ""), Replace(txt_min_qty.Text, ",", ""), txt_keterangan.Text, Replace(txt_length.Text, ",", ""), Replace(txt_width.Text, ",", ""), Replace(txt_height.Text, ",", ""), Replace(txt_weight.Text, ",", ""), rowAccount2.Item("id_account"), rowAccount2.Item("account_name"), UnitQty_Min, BrandString, Replace(txt_qty_bought.Text, ",", ""), DataGridView3.Item(0, x).Value, DataGridView3.Item(2, x).Value, 1, DataGridView3.Item(3, x).Value, cbo_unitbonus.Text, var_status_aktif, txt_kadar.Text, var_use_minqty)
                Next
            End If

            If param_sukses = True Then
                If filename <> "" Then
                    txt_photo.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(server_datetime(), "MASTER_ITEM")
                If rowMainUnit.Item("id_unit") <> rowBuyUnit.Item("id_unit") Or rowMainUnit.Item("id_unit") <> rowSellUnit.Item("id_unit") Then
                    pesan = MsgBox("Main Unit, Sell Unit & Buy Unit Default was different, " & vbCrLf & "Do you want to set unit conversion?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Save Success")
                    If pesan = vbYes Then
                        If Application.OpenForms().OfType(Of frmUnit).Any Then
                            'MsgBox("Menu Konversi Unit Sudah Di Buka", MsgBoxStyle.Information, "Warning - Akses Menu")
                            frmUnit.Activate()
                        Else
                            frmUnit.Show()
                            frmUnit.TabControl1.SelectedTabPage = frmUnit.TabKonversi
                            'frmUnit.MdiParent = MainMenu
                        End If
                    End If
                End If
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            If filename <> "" Or status_reset_img = True Then
                If System.IO.File.Exists(FileToSaveAs) = True Then
                    System.IO.File.Delete(FileToSaveAs)
                End If
            End If
            'FileToSaveAs = pb.FileName
            Call update_item(Trim(txt_itemid.Text), Trim(txt_itemname.Text), rowKategori.Item("mst_itemcat_id"), rowJenis.Item("mst_itemjenis_id"), _
                  rowAccount.Item("id_account"), rowMainUnit.Item("id_unit"), rowBuyUnit.Item("id_unit"), rowSellUnit.Item("id_unit"), var_buy, var_sell, var_inv, _
                 FileToSaveAs, username, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, rowWH.Item("id_warehouse"), Replace(txt_price.Text, ",", ""), rowWH.Item("id_warehouse"), Replace(txt_max_qty.Text, ",", ""), Replace(txt_min_qty.Text, ",", ""), txt_keterangan.Text, Replace(txt_length.Text, ",", ""), Replace(txt_width.Text, ",", ""), Replace(txt_height.Text, ",", ""), Replace(txt_weight.Text, ",", ""), rowAccount2.Item("id_account"), rowAccount2.Item("account_name"), UnitQty_Min, BrandString, Replace(txt_qty_bought.Text, ",", ""), Trim(txt_itemid.Text), 0, 0, "", cbo_unitbonus.Text, var_status_aktif, txt_kadar.Text, var_use_minqty)

            Dim rows_itemdisc, x As Integer
            rows_itemdisc = DataGridView3.Rows.Count
            If rows_itemdisc > 0 Then
                For x = 0 To DataGridView3.Rows.Count - 1
                    Call update_item(Trim(txt_itemid.Text), Trim(txt_itemname.Text), rowKategori.Item("mst_itemcat_id"), rowJenis.Item("mst_itemjenis_id"), _
                     rowAccount.Item("id_account"), rowMainUnit.Item("id_unit"), rowBuyUnit.Item("id_unit"), rowSellUnit.Item("id_unit"), var_buy, var_sell, var_inv, _
                    FileToSaveAs, username, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, rowWH.Item("id_warehouse"), Replace(txt_price.Text, ",", ""), rowWH.Item("id_warehouse"), Replace(txt_max_qty.Text, ",", ""), Replace(txt_min_qty.Text, ",", ""), txt_keterangan.Text, Replace(txt_length.Text, ",", ""), Replace(txt_width.Text, ",", ""), Replace(txt_height.Text, ",", ""), Replace(txt_weight.Text, ",", ""), rowAccount2.Item("id_account"), rowAccount2.Item("account_name"), UnitQty_Min, BrandString, Replace(txt_qty_bought.Text, ",", ""), DataGridView3.Item(0, x).Value, DataGridView3.Item(2, x).Value, 1, DataGridView3.Item(3, x).Value, cbo_unitbonus.Text, var_status_aktif, txt_kadar.Text, var_use_minqty)
                Next
            End If

            If param_sukses = True Then
                If filename <> "" Then
                    'txt_photo.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
                    System.IO.File.Copy(filename, FileToSaveAs)
                End If
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
    End Sub

    Private Sub clean()
        open_conn()
        status_reset_img = False
        With Me
            insert = 1
            edit = 0
            .txt_save_path.Text = ""
            '.txt_itemid.Text = ""
            .txt_itemname.Text = ""
            filename = Replace(Application.StartupPath & "\photo\no-image2.jpg", "\", "/")
            btn_set_bonus.Visible = False
            .txt_photo.Image = Image.FromFile(filename)
            .txt_search.Text = ""
            .cbo_kategori.EditValue = Nothing
            .cbo_buyunit.EditValue = Nothing
            .cbo_jenis.EditValue = Nothing
            .cbo_brand.EditValue = Nothing
            .cbo_mainunit.EditValue = Nothing
            .cbo_sellunit.EditValue = Nothing
            .chk_invitem.Checked = False
            .txt_price.Text = 0
            .txt_kadar.Text = 0
            txt_itemid.Enabled = True
            .txt_max_qty.Text = 0
            .txt_min_qty.Text = 0
            .txt_keterangan.Text = ""
            filename = ""
            .txt_length.Text = 0
            .txt_width.Text = 0
            .txt_height.Text = 0
            .txt_weight.Text = 0
            .chkbarcode.Checked = True
            .cbounit_min_qty.EditValue = Nothing
            .txt_stock.Text = 0
            .txt_qty_bought.Text = 0
            .CheckBox4.Checked = False
        End With
        cbo_acc.EditValue = GetInventoryDefAcc()
        cbo_acc2.EditValue = GetCOGSDefAcc()
        cbo_wh.EditValue = GetWHDef()
        filename = Application.StartupPath & "\photo\no-image2.jpg"
        txt_photo.Image = Image.FromFile(filename)
        If get_def_path("Item") = "" Then
            txt_save_path.Text = "C:" & "\" & txt_itemid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        Else
            txt_save_path.Text = Replace(get_def_path("Item"), "/", "\") & "\" & txt_itemid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        End If
        'DataGridView1.Rows.Clear()
        DataGridView3.Rows.Clear()
        Call select_control_no("MASTER_ITEM", "TRANS")
        txt_itemid.Text = no_master
        btn_del2.Enabled = False
    End Sub

    Dim pb As New OpenFileDialog
    Private Sub txt_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_photo.Click

    End Sub

    Private Sub view_disc_item()
        open_conn()
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        Dim var_chk As Integer
        If chk_date.Checked = True Then
            var_chk = 1
        Else
            var_chk = 0
        End If
        DT = select_item_disc(Trim(txt_itemid.Text))
        Rows = DT.Rows.Count - 1
        DataGridView3.Rows.Clear()
        For i = 0 To Rows
            DataGridView3.Rows.Add()
            DataGridView3.Item(0, i).Value = DT.Rows(i).Item("id_item_disc")
            DataGridView3.Item(1, i).Value = DT.Rows(i).Item("item_name_disc")
            DataGridView3.Item(2, i).Value = DT.Rows(i).Item("qty")
            DataGridView3.Item(3, i).Value = DT.Rows(i).Item("id_unit")
        Next
    End Sub

    Private Sub DataGridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        open_conn()
        panel_item_disc.Visible = False
        edit = 1
        insert = 0
        i = DataGridView2.CurrentCell.RowIndex
        TabControl1.SelectedTabPage = TabInput
        txt_itemid.Enabled = False
        btn_del2.Enabled = True
        detail(DataGridView2.Item(0, i).Value, sender, e)
    End Sub

    Private Sub txt_itemid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_itemid.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_itemname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_itemname.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_buyunit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_category_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_mainunit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_sellunit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        open_conn()
        If TabControl1.SelectedTabPage Is TabList Then
            view_data()
            txt_stock.Text = 0
        End If
    End Sub

    Private Sub view_data()
        open_conn()

        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        Dim var_chk As Integer
        If chk_date.Checked = True Then
            var_chk = 1
        Else
            var_chk = 0
        End If

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Item . . .")
            SplashScreenManager.ActivateParentOnSplashFormClosing = True
            If chkIncludeInActive.Checked = True Then
                DT = select_master("select_item_all", Trim(cbo_search.Text), Trim(txt_search.Text), 0, var_chk, tglawal.Value, tglakhir.Value)
            Else
                DT = select_master("select_item", Trim(cbo_search.Text), Trim(txt_search.Text), 0, var_chk, tglawal.Value, tglakhir.Value)
            End If
            GridControl.DataSource = DT
            GridList_Customer.Columns("id_item").Caption = "Kode Barang"
            GridList_Customer.Columns("id_item").Width = 130
            GridList_Customer.Columns("item_name").Caption = "Nama Barang"
            GridList_Customer.Columns("item_name").Width = 200
            GridList_Customer.Columns("main_unit").Caption = "Unit Utama"
            GridList_Customer.Columns("main_unit").Width = 90
            GridList_Customer.Columns("mst_itemcat_nm").Caption = "Kategori Barang"
            GridList_Customer.Columns("mst_itemcat_nm").Width = 180
            GridList_Customer.Columns("mst_itemjenis_nm").Caption = "Jenis Barang"
            GridList_Customer.Columns("id_barcode").Caption = "Barcode"
            GridList_Customer.Columns("id_barcode").Width = 120
            GridList_Customer.Columns("mst_itembrand_nm").Caption = "Merek"
            GridList_Customer.Columns("mst_itembrand_nm").Width = 180
            'GridList_Customer.BestFitColumns()

            'Rows = DT.Rows.Count - 1
            'DataGridView2.Rows.Clear()
            'For i = 0 To Rows
            '    DataGridView2.Rows.Add()
            '    DataGridView2.Item(0, i).Value = DT.Rows(i).Item(0)
            '    DataGridView2.Item(1, i).Value = DT.Rows(i).Item(1)
            '    DataGridView2.Item(2, i).Value = DT.Rows(i).Item(2)
            '    DataGridView2.Item(3, i).Value = DT.Rows(i).Item(3)
            '    DataGridView2.Item(4, i).Value = DT.Rows(i).Item(4)
            '    DataGridView2.Item(6, i).Value = DT.Rows(i).Item(6)

            'Next
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub view_data_disc()
        open_conn()
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        Dim var_chk As Integer
        If chk_date.Checked = True Then
            var_chk = 1
        Else
            var_chk = 0
        End If
        DT = select_master("select_item", Trim(cbo_search_item.Text), Trim(txt_search_item.Text), 0, 0, tglawal.Value, tglakhir.Value)
        Rows = DT.Rows.Count - 1
        DataGridView1.Rows.Clear()
        For i = 0 To Rows
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = DT.Rows(i).Item(0)
            DataGridView1.Item(1, i).Value = DT.Rows(i).Item(1)
        Next
    End Sub

    Private Sub datagrid_layout()
        open_conn()
        With DataGridView2
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        End With
        With DataGridView1
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke
        End With
        With DataGridView3
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(var_red, var_grey, var_blue)
            .DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
            .Columns(0).ReadOnly = True
            .Columns(0).DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns(1).ReadOnly = True
            .Columns(1).DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke
            .Columns(2).ReadOnly = False
            .Columns(2).DefaultCellStyle.BackColor = System.Drawing.Color.White
            .Columns(3).ReadOnly = True
            .Columns(3).DefaultCellStyle.BackColor = System.Drawing.Color.White
        End With

    End Sub

    Private Sub btn_reset2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()
        Dim var_buy As Integer
        Dim var_sell As Integer
        Dim var_inv As Integer
        Dim rowJenis, rowKategori, rowAccount, rowWH, rowMainUnit, rowBuyUnit, rowSellUnit, rowMinQtyUnit As DataRowView
        rowJenis = TryCast(cbo_jenis.Properties.GetRowByKeyValue(cbo_jenis.EditValue), DataRowView)
        rowKategori = TryCast(cbo_kategori.Properties.GetRowByKeyValue(cbo_kategori.EditValue), DataRowView)
        rowAccount = TryCast(cbo_acc.Properties.GetRowByKeyValue(cbo_acc.EditValue), DataRowView)
        rowWH = TryCast(cbo_wh.Properties.GetRowByKeyValue(cbo_wh.EditValue), DataRowView)
        rowMainUnit = TryCast(cbo_mainunit.Properties.GetRowByKeyValue(cbo_mainunit.EditValue), DataRowView)
        rowBuyUnit = TryCast(cbo_buyunit.Properties.GetRowByKeyValue(cbo_buyunit.EditValue), DataRowView)
        rowSellUnit = TryCast(cbo_sellunit.Properties.GetRowByKeyValue(cbo_sellunit.EditValue), DataRowView)
        rowMinQtyUnit = TryCast(cbounit_min_qty.Properties.GetRowByKeyValue(cbounit_min_qty.EditValue), DataRowView)

        If edit = 1 Then
            If getTemplateAkses(username, "MN_ITEM_NAME_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim FileToSaveAs As String = Application.StartupPath & "\photo\item\" & txt_itemid.Text & ".jpg"
        If edit = 1 Then
            pesan = MessageBox.Show("Data Akan di hapus?", "Hapus Data", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                If filename <> "" Or status_reset_img = True Then
                    If System.IO.File.Exists(FileToSaveAs) = True Then
                        System.IO.File.Delete(FileToSaveAs)
                    End If
                End If

                Call delete_item(Trim(txt_itemid.Text), Trim(txt_itemname.Text), rowKategori.Item("mst_itemcat_id"), rowJenis.Item("mst_itemjenis_id"), _
                rowAccount.Item("id_account"), rowMainUnit.Item("id_unit"), rowBuyUnit.Item("id_unit"), rowSellUnit.Item("id_unit"), var_buy, var_sell, var_inv, _
                FileToSaveAs, username, Format(server_datetime(), "yyyy-MM-dd"), Format(server_datetime(), "yyyy-MM-dd"), username, rowWH.Item("id_warehouse"), Replace(txt_price.Text, ",", ""), rowWH.Item("id_warehouse"), Replace(txt_max_qty.Text, ",", ""), Replace(txt_min_qty.Text, ",", ""), txt_keterangan.Text, Replace(txt_length.Text, ",", ""), Replace(txt_width.Text, ",", ""), Replace(txt_height.Text, ",", ""), Replace(txt_weight.Text, ",", ""), "", "")

                If param_sukses = True Then
                    Dim info As AlertInfo = New AlertInfo(msgtitle_delete_success, msgbox_delete_success)
                    alertControl_success.Show(Me, info)
                    clean()
                Else
                    Dim info As AlertInfo = New AlertInfo(msgtitle_delete_failed, msgbox_delete_failed)
                    alertControl_error.Show(Me, info)
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txt_search_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        view_data()
    End Sub

    Private Sub txt_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_price.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_price_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_price.LostFocus
        open_conn()
        Dim var_price As Double
        If txt_price.Text = "" Then
            txt_price.Text = 0
        End If
        var_price = txt_price.Text
        txt_price.Text = FormatNumber(var_price, 0)
    End Sub

    Private Sub chk_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_date.CheckedChanged
        open_conn()
        date_filter()
    End Sub
    Private Sub date_filter()
        open_conn()
        If chk_date.Checked = True Then
            tglawal.Enabled = True
            tglakhir.Enabled = True
        ElseIf chk_date.Checked = False Then
            tglawal.Enabled = False
            tglakhir.Enabled = False
        End If
    End Sub
    Private Sub reset_list()
        open_conn()
        chk_date.Checked = False
        tglakhir.Enabled = False
        tglawal.Enabled = False
        tglakhir.Value = Now
        tglawal.Value = Now
        cbo_search.Text = "ID Barang"
        txt_search.Text = ""
    End Sub
    Private Sub btn_reset_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_cust.Click
        open_conn()
        reset_list()
    End Sub

    Private Sub btn_cari_cust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_cust.Click
        open_conn()
        view_data()
    End Sub

    Private Sub DataGridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView2.KeyDown
        open_conn()
        panel_item_disc.Visible = False
        If e.KeyCode = Keys.Enter Then
            edit = 1
            insert = 0
            i = DataGridView2.CurrentCell.RowIndex
            TabControl1.SelectedTabPage = TabInput
            txt_itemid.Enabled = False
            btn_del2.Enabled = True
            detail(DataGridView2.Item(0, i).Value, sender, e)

        End If
    End Sub

    Private Sub txt_max_qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_min_qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_min_qty.KeyPress
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub cbo_acc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_jenis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_buyunit_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_sellunit_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub default_code(ByVal criteria As String)
        open_conn()
        Def_Kode = Nothing
        Dim Yolk As String
        Yolk = "Yolk"
        If criteria.Length = 1 Then
            Kode1 = (Mid(criteria, 1, 1))
        ElseIf criteria.Length = 2 Then
            Kode2 = EnkripsiID(Mid(criteria, 2, 1))
        ElseIf criteria.Length = 3 Then
            Kode3 = EnkripsiID(Mid(criteria, 4, 1))
        End If
        If criteria.Length = 0 Then
            Def_Kode = ""
        Else
            Def_Kode = EnkripsiID(Yolk) + "-" + Kode1 + Kode2 + Kode3 + EnkripsiID(CStr(CInt(Format(Now, "dd")))) + EnkripsiID(CStr(CInt(Format(Now, "yy")))) + (Format(Now, "hh")) + (Format(Now, "mm")) + (Format(Now, "ss"))
        End If
    End Sub

    Private Sub txt_min_qty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_min_qty.LostFocus
        open_conn()
        Dim number As Integer
        number = Val(txt_min_qty.Text)
        txt_min_qty.Text = Format(number, 0)
    End Sub

    Private Sub txt_max_qty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim number As Integer
        number = Val(txt_max_qty.Text)
        txt_max_qty.Text = Format(number, 0)
    End Sub

    Private Sub txt_height_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_height.KeyPress
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_height_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_height.LostFocus
        open_conn()
        If txt_height.Text = "" Then
            txt_height.Text = 0
        End If
    End Sub

    Private Sub txt_length_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_length.KeyPress
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_length_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_length.LostFocus
        open_conn()
        If txt_length.Text = "" Then
            txt_length.Text = 0
        End If
    End Sub

    Private Sub txt_weight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_weight.KeyPress
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_weight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_weight.LostFocus
        open_conn()
        If txt_weight.Text = "" Then
            txt_weight.Text = 0
        End If
    End Sub

    Private Sub txt_width_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_width.KeyPress
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
    End Sub

    Private Sub txt_width_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_width.LostFocus
        open_conn()
        If txt_width.Text = "" Then
            txt_width.Text = 0
        End If
    End Sub

    Private Sub btn_upload2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_upload2.Click
        open_conn()
        If pb.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = Replace(pb.FileName, "\", "/")
            txt_photo.Image = Image.FromFile(filename)
        End If
    End Sub

    Private Sub btn_reset2_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ambil_foto.Click
        open_conn()
        speaker = speaker.GetDefaultDevice()
        Panel1.Visible = True
        _myCameraUrlBuilder = New CameraURLBuilderWF()
        'If cuurentCameraStat = 0 Then
        Dim result = _myCameraUrlBuilder.ShowDialog()

        If result <> DialogResult.OK Then
            Return
        End If

        If result = Windows.Forms.DialogResult.OK Then
            If _camera IsNot Nothing Then
                'RemoveHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged
                _camera.Disconnect()
                _connector.Disconnect(_camera.VideoChannel, _imageProvider)
                _camera.Dispose()
                _camera = Nothing
                _videoViewerWF1.Stop()
            End If

            If OnvifCamera IsNot Nothing Then
                'RemoveHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged
                OnvifCamera.Disconnect()
                _connector2.Disconnect(OnvifCamera.VideoChannel, _imageProvider2)
                OnvifCamera.Dispose()
                OnvifCamera = Nothing
                _videoViewerWF2.Stop()
            End If


            _camera = New OzekiCamera(_myCameraUrlBuilder.CameraURL)
            If _camera.Type <> CameraType.USB Then
                'AddHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged

                OnvifCamera = IPCameraFactory.GetCamera("rtsp://192.168.100.9/video.mp4", "admin", "admin", Ozeki.Media.IPCamera.Data.CameraTransportType.TCP)
                _videoViewerWF2.SetImageProvider(_imageProvider2)
                _connector2.Connect(OnvifCamera.AudioChannel, speaker)
                _connector2.Connect(OnvifCamera.VideoChannel, _imageProvider2)

                OnvifCamera.Start()
                _videoViewerWF2.Start()

                speaker.Start()
                Panel4.Visible = False
                Panel5.Visible = True
                txt_photo.Visible = False
            ElseIf _camera.Type <> CameraType.RTSP Then
                _videoViewerWF1.SetImageProvider(_imageProvider)

                _connector.Connect(_camera.AudioChannel, speaker)
                _connector.Connect(_camera.VideoChannel, _imageProvider)

                _camera.Start()
                _videoViewerWF1.Start()

                speaker.Start()
                txt_photo.Visible = False
                Panel4.Visible = True
                Panel5.Visible = False
            End If
            PictureBox2.Visible = False
        End If
        'Else
        'Panel4.Visible = True
        'Panel5.Visible = False
        'End If

        ' load_video()
        cuurentCameraStat = 1
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub chk_nonchecked()
        chk_invitem.Checked = False
        chk_penolong.Checked = False
        chk_sellitem.Checked = False
    End Sub

    Private Sub chk_invitem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_invitem.CheckedChanged
        'chk_nonchecked()
        chk_penolong.Checked = False
        chk_sellitem.Checked = False
        'chk_invitem.Checked = True
    End Sub

    Private Sub chk_penolong_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_penolong.CheckedChanged
        'chk_nonchecked()
        chk_invitem.Checked = False
        'chk_penolong.Checked = False
        chk_sellitem.Checked = False
        'chk_penolong.Checked = True
    End Sub

    Private Sub chk_sellitem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_sellitem.CheckedChanged
        ' chk_nonchecked()
        'chk_sellitem.Checked = True
        chk_invitem.Checked = False
        chk_penolong.Checked = False
        'chk_sellitem.Checked = False
    End Sub

    Private Sub chkbarcode_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbarcode.CheckedChanged
        If chkbarcode.Checked = True Then
            txt_itemid.Enabled = False
            txt_itemid.ReadOnly = True
            txt_itemid.Focus()
            txt_itemid.BackColor = System.Drawing.Color.Lavender
            txt_itemid.Text = ""
        ElseIf chkbarcode.Checked = False Then
            txt_itemid.Enabled = True
            txt_itemid.ReadOnly = False
            txt_itemid.BackColor = System.Drawing.Color.White
        End If
        open_conn()
        If insert = 1 And chkbarcode.Checked = True Then
            var_bulan = Month(server_datetime())
            var_tahun = Year(server_datetime())
            Call insert_no_trans("MASTER_ITEM", Month(server_datetime()), Year(server_datetime()))
            Call select_control_no("MASTER_ITEM", "TRANS")
            txt_itemid.Text = no_master
            If get_def_path("Item") = "" Then
                txt_save_path.Text = "C:" & "\" & txt_itemid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
            Else
                txt_save_path.Text = Replace(get_def_path("Item"), "/", "\") & "\" & txt_itemid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
            End If
        Else
            txt_itemid.Text = ""
        End If
    End Sub

    Private Sub fillComboBox_Unit()
        Lookup_Unit.Properties.DataSource = select_combo_unit_item(DataGridView3.Item(0, DataGridView3.CurrentCell.RowIndex).Value)
        Lookup_Unit.Properties.DisplayMember = "unit"
        Lookup_Unit.Properties.ValueMember = "id_unit"
        Lookup_Unit.Properties.PopulateViewColumns()
        Lookup_Unit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Lookup_Unit.Properties.View.OptionsView.ShowAutoFilterRow = True
        Lookup_Unit.Properties.View.Columns("id_unit").Caption = "ID Unit"
        Lookup_Unit.Properties.View.Columns("unit").Caption = "Unit"
    End Sub

    Private Sub fillComboBox()
        cbo_jenis.Properties.DataSource = getComboJenisAll()
        cbo_jenis.Properties.DisplayMember = "mst_itemjenis_nm"
        cbo_jenis.Properties.ValueMember = "mst_itemjenis_id"
        cbo_jenis.Properties.PopulateViewColumns()
        cbo_jenis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_jenis.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_jenis.Properties.View.Columns("mst_itemjenis_id").Caption = "Kode"
        cbo_jenis.Properties.View.Columns("mst_itemjenis_nm").Caption = "Jenis"

        cbo_kategori.Properties.DataSource = getComboCatAll()
        cbo_kategori.Properties.DisplayMember = "mst_itemcat_nm"
        cbo_kategori.Properties.ValueMember = "mst_itemcat_id"
        cbo_kategori.Properties.PopulateViewColumns()
        cbo_kategori.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_kategori.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_kategori.Properties.View.Columns("mst_itemcat_id").Caption = "Kode"
        cbo_kategori.Properties.View.Columns("mst_itemcat_nm").Caption = "Kategori"
        cbo_kategori.Properties.View.Columns("mst_itemjenis_id").Visible = False

        cbo_brand.Properties.DataSource = getComboBrandAll()
        cbo_brand.Properties.DisplayMember = "mst_itembrand_nm"
        cbo_brand.Properties.ValueMember = "mst_itembrand_id"
        cbo_brand.Properties.PopulateViewColumns()
        cbo_brand.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_brand.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_brand.Properties.View.Columns("mst_itembrand_id").Caption = "Kode"
        cbo_brand.Properties.View.Columns("mst_itembrand_nm").Caption = "Merek"

        Dim DTAccount As DataTable
        DTAccount = getComboAccount()
        cbo_acc.Properties.DataSource = DTAccount
        cbo_acc.Properties.DisplayMember = "account_name"
        cbo_acc.Properties.ValueMember = "id_account"
        cbo_acc.Properties.PopulateViewColumns()
        cbo_acc.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_acc.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_acc.Properties.View.Columns("id_account").Caption = "No Akun"
        cbo_acc.Properties.View.Columns("account_name").Caption = "Nama Akun"

        cbo_acc2.Properties.DataSource = DTAccount
        cbo_acc2.Properties.DisplayMember = "account_name"
        cbo_acc2.Properties.ValueMember = "id_account"
        cbo_acc2.Properties.PopulateViewColumns()
        cbo_acc2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_acc2.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_acc2.Properties.View.Columns("id_account").Caption = "No Akun"
        cbo_acc2.Properties.View.Columns("account_name").Caption = "Nama Akun"

        cbo_wh.Properties.DataSource = getComboGudang()
        cbo_wh.Properties.DisplayMember = "warehouse_name"
        cbo_wh.Properties.ValueMember = "id_warehouse"
        cbo_wh.Properties.PopulateViewColumns()
        cbo_wh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_wh.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_wh.Properties.View.Columns("id_warehouse").Caption = "Kode"
        cbo_wh.Properties.View.Columns("warehouse_name").Caption = "Gudang"

        Dim DTUnit As DataTable
        DTUnit = getComboUnit()
        cbo_mainunit.Properties.DataSource = DTUnit
        cbo_mainunit.Properties.DisplayMember = "unit"
        cbo_mainunit.Properties.ValueMember = "id_unit"
        cbo_mainunit.Properties.PopulateViewColumns()
        cbo_mainunit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_mainunit.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_mainunit.Properties.View.Columns("id_unit").Caption = "Kode"
        cbo_mainunit.Properties.View.Columns("unit").Caption = "Unit"

        cbo_buyunit.Properties.DataSource = DTUnit
        cbo_buyunit.Properties.DisplayMember = "unit"
        cbo_buyunit.Properties.ValueMember = "id_unit"
        cbo_buyunit.Properties.PopulateViewColumns()
        cbo_buyunit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_buyunit.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_buyunit.Properties.View.Columns("id_unit").Caption = "Kode"
        cbo_buyunit.Properties.View.Columns("unit").Caption = "Unit"

        cbo_sellunit.Properties.DataSource = DTUnit
        cbo_sellunit.Properties.DisplayMember = "unit"
        cbo_sellunit.Properties.ValueMember = "id_unit"
        cbo_sellunit.Properties.PopulateViewColumns()
        cbo_sellunit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_sellunit.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_sellunit.Properties.View.Columns("id_unit").Caption = "Kode"
        cbo_sellunit.Properties.View.Columns("unit").Caption = "Unit"

        cbounit_min_qty.Properties.DataSource = DTUnit
        cbounit_min_qty.Properties.DisplayMember = "unit"
        cbounit_min_qty.Properties.ValueMember = "id_unit"
        cbounit_min_qty.Properties.PopulateViewColumns()
        cbounit_min_qty.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbounit_min_qty.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbounit_min_qty.Properties.View.Columns("id_unit").Caption = "Kode"
        cbounit_min_qty.Properties.View.Columns("unit").Caption = "Unit"
    End Sub

    Private Sub fillComboBox1()
        cbo_jenis.Properties.DataSource = getComboJenisAll()
        cbo_jenis.Properties.DisplayMember = "mst_itemjenis_nm"
        cbo_jenis.Properties.ValueMember = "mst_itemjenis_id"
        cbo_jenis.Properties.PopulateViewColumns()
        cbo_jenis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_jenis.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub fillComboBox2()
        cbo_kategori.Properties.DataSource = getComboCatAll()
        cbo_kategori.Properties.DisplayMember = "mst_itemcat_nm"
        cbo_kategori.Properties.ValueMember = "mst_itemcat_id"
        cbo_kategori.Properties.PopulateViewColumns()
        cbo_kategori.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_kategori.Properties.View.OptionsView.ShowAutoFilterRow = True
        cbo_kategori.Properties.View.Columns("mst_itemjenis_id").Visible = False
    End Sub

    Private Sub fillComboBox3()
        cbo_brand.Properties.DataSource = getComboBrandAll()
        cbo_brand.Properties.DisplayMember = "mst_itembrand_nm"
        cbo_brand.Properties.ValueMember = "mst_itembrand_id"
        cbo_brand.Properties.PopulateViewColumns()
        cbo_brand.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_brand.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub fillComboBox4()
        cbo_acc.Properties.DataSource = getComboAccount()
        cbo_acc.Properties.DisplayMember = "account_name"
        cbo_acc.Properties.ValueMember = "id_account"
        cbo_acc.Properties.PopulateViewColumns()
        cbo_acc.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_acc.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub fillComboBox5()
        cbo_acc2.Properties.DataSource = getComboAccount()
        cbo_acc2.Properties.DisplayMember = "account_name"
        cbo_acc2.Properties.ValueMember = "id_account"
        cbo_acc2.Properties.PopulateViewColumns()
        cbo_acc2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_acc2.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub fillComboBox6()
        cbo_wh.Properties.DataSource = getComboGudang()
        cbo_wh.Properties.DisplayMember = "warehouse_name"
        cbo_wh.Properties.ValueMember = "id_warehouse"
        cbo_wh.Properties.PopulateViewColumns()
        cbo_wh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_wh.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub btn_browse_Click(sender As System.Object, e As System.EventArgs) Handles btn_browse.Click
        open_conn()
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Images Configuration Files Path"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_save_path.Text = dialog.SelectedPath & "\" & txt_itemid.Text & ".jpg"
        End If
    End Sub

    Private Sub btn_reset_pic2_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset_pic2.Click
        open_conn()
        filename = Application.StartupPath & "\photo\no-image2.jpg"
        txt_photo.Image = Image.FromFile(filename)
        status_reset_img = True
    End Sub

    Private Sub btn_take2_Click1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_closeimg2_Click1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_browse4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_closeimg2_Click(sender As System.Object, e As System.EventArgs) Handles btn_closeimg2.Click
        Panel1.Visible = False
        txt_photo.Visible = True
        'If _camera Is Nothing Then
        '    Return
        'End If

        '_camera.Disconnect()
        '_connector.Disconnect(_camera.VideoChannel, _imageProvider)
        '_camera = Nothing
        filename = Replace(Application.StartupPath & "\photo\no-image2.jpg", "\", "/")
        txt_photo.Image = Image.FromFile(filename)
    End Sub

    Private Sub btn_take2_Click(sender As System.Object, e As System.EventArgs) Handles btn_take2.Click
        Dim Random As String
        If _camera Is Nothing Then
            Return
        End If

        Random = Replace(Rnd(9999), ".", "")
        If _camera.Type = CameraType.USB Then
            '_camera.Disconnect()
            '_connector.Disconnect(_camera.VideoChannel, _imageProvider)
            '_camera = Nothing
            _videoViewerWF1.Frame.Save(GetTempPath() & "\" & Trim(txt_itemid.Text) & Random & "D.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            If System.IO.File.Exists(GetTempPath() & "\" & Trim(txt_itemid.Text) & Random & "D.jpg") = True Then
                txt_photo.Image = Image.FromFile(GetTempPath() & "\" & Trim(txt_itemid.Text) & Random & "D.jpg")
                txt_photo.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Else
            'OnvifCamera.Disconnect()
            '_connector2.Disconnect(_camera.VideoChannel, _imageProvider2)
            'OnvifCamera = Nothing
            _videoViewerWF2.Frame.Save(GetTempPath() & "\" & Trim(txt_itemid.Text) & Random & "D.jpg")
            If System.IO.File.Exists(GetTempPath() & "\" & Trim(txt_itemid.Text) & Random & "D.jpg") = True Then
                txt_photo.Image = Image.FromFile(GetTempPath() & "\" & Trim(txt_itemid.Text) & Random & "D.jpg")
                txt_photo.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If
        txt_photo.Visible = True
        Panel1.Visible = False
        filename = "Webcam"
        _myCameraUrlBuilder.Hide()
    End Sub

    Private Sub btn_change_cam_Click(sender As System.Object, e As System.EventArgs) Handles btn_change_cam.Click
        open_conn()
        speaker = speaker.GetDefaultDevice()
        Panel1.Visible = True
        _myCameraUrlBuilder = New CameraURLBuilderWF()

        Dim result = _myCameraUrlBuilder.ShowDialog()

        If result <> DialogResult.OK Then
            Return
        End If
        _camera = Nothing
        OnvifCamera = Nothing
        If result = Windows.Forms.DialogResult.OK Then
            If _camera IsNot Nothing Then
                'RemoveHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged
                _camera.Disconnect()
                _connector.Disconnect(_camera.VideoChannel, _imageProvider)
                _camera.Dispose()
                _camera = Nothing
                _videoViewerWF1.Stop()
            End If

            If OnvifCamera IsNot Nothing Then
                'RemoveHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged
                OnvifCamera.Disconnect()
                _connector2.Disconnect(OnvifCamera.VideoChannel, _imageProvider2)
                OnvifCamera.Dispose()
                OnvifCamera = Nothing
                _videoViewerWF2.Stop()
            End If


            _camera = New OzekiCamera(_myCameraUrlBuilder.CameraURL)
            If _camera.Type <> CameraType.USB Then
                'AddHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged

                OnvifCamera = IPCameraFactory.GetCamera("rtsp://192.168.0.9/video.mp4", "admin", "admin", Ozeki.Media.IPCamera.Data.CameraTransportType.TCP)
                _videoViewerWF2.SetImageProvider(_imageProvider2)
                _connector2.Connect(OnvifCamera.AudioChannel, speaker)
                _connector2.Connect(OnvifCamera.VideoChannel, _imageProvider2)

                OnvifCamera.Start()
                _videoViewerWF2.Start()

                speaker.Start()
                Panel4.Visible = False
                Panel5.Visible = True
            ElseIf _camera.Type <> CameraType.RTSP Then
                _videoViewerWF1.SetImageProvider(_imageProvider)

                _connector.Connect(_camera.AudioChannel, speaker)
                _connector.Connect(_camera.VideoChannel, _imageProvider)

                _camera.Start()
                _videoViewerWF1.Start()

                speaker.Start()
                Panel4.Visible = True
                Panel5.Visible = False
            End If
            PictureBox2.Visible = False
        End If

        ' load_video()
        cuurentCameraStat = 1
    End Sub

    Private Sub btn_set_bonus_Click(sender As System.Object, e As System.EventArgs) Handles btn_set_bonus.Click
        panel_item_disc.Visible = True
        Load_MtgcComboBoxUnitItem()
        view_data_disc()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If Trim(txt_qty_bought.Text) = "" Then
            pesan = MsgBox("You haven't fill qty of customer have to buy for getting other item" & vbCrLf & " Do you want to continue anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
            If pesan = vbYes Then
                Dim a As Integer
                For z = 0 To DataGridView3.Rows.Count - 1
                    If Trim(DataGridView3.Item(2, z).Value) = "" Or DataGridView3.Item(2, z).Value = 0 Then
                        pesan2 = MsgBox("Some qty in item discount list has empty" & vbCrLf & " Do you want to continue anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
                        If pesan2 = vbYes Then
                            panel_item_disc.Visible = False
                            a = a + 1
                            Exit For
                        Else
                            a = a + 1
                            Exit For
                        End If
                    End If
                    If Trim(DataGridView3.Item(3, z).Value) = "" Then
                        pesan2 = MsgBox("Units in item discount list has empty" & vbCrLf & " Do you want to continue anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
                        If pesan2 = vbYes Then
                            panel_item_disc.Visible = False
                            a = a + 1
                            Exit For
                        Else
                            a = a + 1
                            Exit For
                        End If
                    End If
                Next
                If a = 0 Then
                    panel_item_disc.Visible = False
                End If
            Else
                txt_qty_bought.Focus()
            End If
        ElseIf Trim(cbo_unitbonus.Text) = "" Then
            pesan = MsgBox("You haven't fill unit of customer have to buy for getting other item" & vbCrLf & " Do you want to continue anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
            If pesan = vbYes Then
                Dim a As Integer
                For z = 0 To DataGridView3.Rows.Count - 1
                    If Trim(DataGridView3.Item(2, z).Value) = "" Or DataGridView3.Item(2, z).Value = 0 Then
                        pesan2 = MsgBox("Some qty in item discount list has empty" & vbCrLf & " Do you want to continue anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
                        If pesan2 = vbYes Then
                            panel_item_disc.Visible = False
                            a = a + 1
                            Exit For
                        Else
                            a = a + 1
                            Exit For
                        End If
                    End If
                    If Trim(DataGridView3.Item(3, z).Value) = "" Then
                        pesan2 = MsgBox("Units in item discount list has empty" & vbCrLf & " Do you want to continue anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
                        If pesan2 = vbYes Then
                            panel_item_disc.Visible = False
                            a = a + 1
                            Exit For
                        Else
                            a = a + 1
                            Exit For
                        End If
                    End If
                Next
                If a = 0 Then
                    panel_item_disc.Visible = False
                End If
            Else
                cbo_unitbonus.Focus()
            End If
        Else
            Dim a As Integer
            a = 0
            For z = 0 To DataGridView3.Rows.Count - 1
                If Trim(DataGridView3.Item(2, z).Value) = "" Or DataGridView3.Item(2, z).Value = 0 Then
                    pesan2 = MsgBox("Some qty in item discount list has empty" & vbCrLf & " Do you want to continue anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
                    If pesan2 = vbYes Then
                        panel_item_disc.Visible = False
                        a = a + 1
                        Exit For
                    Else
                        a = a + 1
                        Exit For
                    End If
                End If
                If Trim(DataGridView3.Item(3, z).Value) = "" Then
                    pesan2 = MsgBox("Units in item discount list has empty" & vbCrLf & " Do you want to continue anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
                    If pesan2 = vbYes Then
                        panel_item_disc.Visible = False
                        a = a + 1
                        Exit For
                    Else
                        a = a + 1
                        Exit For
                    End If
                End If
            Next
            If a = 0 Then
                panel_item_disc.Visible = False
            End If
        End If
    End Sub

    Private Sub txt_search_item_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_search_item.KeyPress
        If e.KeyChar = Chr(13) Then
            view_data_disc()
        End If
    End Sub

    Private Sub txt_search_item_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_search_item.TextChanged

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim cRow As Integer
        cRow = DataGridView3.Rows.Count - 1
        If cRow >= 0 Then
            For i As Integer = 0 To cRow
                If DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value = DataGridView3.Item(0, i).Value Then
                    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Item was found in discount item list")
                    alertControl_success.Show(Me, info)
                    Exit Sub
                End If
            Next
        End If
        DataGridView3.Rows.Add(1)
        cRow = DataGridView3.Rows.Count - 1
        DataGridView3.Item(0, cRow).Value = DataGridView1.Item(0, DataGridView1.CurrentCell.RowIndex).Value
        DataGridView3.Item(1, cRow).Value = DataGridView1.Item(1, DataGridView1.CurrentCell.RowIndex).Value
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        DataGridView3.Rows.RemoveAt(DataGridView3.CurrentCell.RowIndex)
    End Sub

    Private Sub DataGridView3_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellEnter
        rowIndex = DataGridView3.CurrentCell.RowIndex
        colIndex = DataGridView3.CurrentCell.ColumnIndex
        If colIndex = 3 Then
            fillComboBox_Unit()
            Lookup_Unit.Visible = True
            Lookup_Unit.Left = DataGridView3.GetCellDisplayRectangle(colIndex, rowIndex, True).Right + 402
            Lookup_Unit.Top = DataGridView3.GetCellDisplayRectangle(colIndex, rowIndex, True).Bottom + 35
        Else
            Lookup_Unit.Visible = False
        End If
    End Sub

    Private Sub DataGridView3_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView3.DoubleClick
        open_conn()

        zRow = DataGridView3.CurrentCell.RowIndex
        zCol = DataGridView3.CurrentCell.ColumnIndex
        Dim Rows As Integer
        If zCol = 3 Then
            Dim NewDisplayAcc As New frm_display_unit
            NewDisplayAcc.formsource_itemdisc_unit = True
            NewDisplayAcc.Show()
            ' ' MainMenu.Enabled = False
            ' Me.Enabled = False
        End If
    End Sub

    Private Sub btn_add_type_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton8.Click
        Dim form As New frmjenisbarang
        form.Show()
        Me.Enabled = False
        '  ' MainMenu.Enabled = False
    End Sub

    Private Sub btn_add_cat_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton9.Click
        Dim form As New frmkatbarang
        form.Show()
        form.cbo_noakun.Text = ""
        form.cbo_noakun.SelectedText = cbo_jenis.EditValue
        Me.Enabled = False
        '   ' MainMenu.Enabled = False
    End Sub

    Private Sub btn_add_brand_Click(sender As System.Object, e As System.EventArgs)
        Dim form As New frmbrandbarang
        form.Show()
    End Sub

    Private Sub btn_imp_supp2_Click(sender As System.Object, e As System.EventArgs) Handles btn_imp_supp2.Click
        open_conn()
        Dim pb As New OpenFileDialog
        pb.Title = "Pilih file excel"
        pb.Filter = "Excel Files|*.xls;*.xlsx"
        If pb.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_path_item.Text = pb.FileName
        End If
    End Sub

    Private Sub btn_download(sender As System.Object, e As System.EventArgs) Handles btn_download_supp2.Click
        Try
            Process.Start(Application.StartupPath & "\download\template_item.xlsx")
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Informasi", ex.Message)
            alertControl_error.Show(Me, info)
        End Try
    End Sub

    Private Sub btn_proses_supp2_Click(sender As System.Object, e As System.EventArgs) Handles btn_proses_supp2.Click
        If Trim(txt_path_item.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "File excel belum di upload")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Report . . .")
            Dim fso, inputFile, outputFile
            Dim str As String
            fso = CreateObject("Scripting.FileSystemObject")

            Dim sInfo As New ProcessStartInfo
            Dim excelApplication As New Excel.Application
            Dim excelWrkBook As Excel.Workbook

            sInfo.CreateNoWindow = False
            With excelApplication
                .Visible = False
                .DisplayAlerts = False
            End With

            Dim output As String = Application.StartupPath & "\" & "itemexp" & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".csv"
            excelWrkBook = excelApplication.Workbooks.Open(Trim(txt_path_item.Text))
            excelWrkBook.SaveAs(Filename:=output, FileFormat:=Microsoft.Office.Interop.Excel.XlFileFormat.xlTextMSDOS)

            excelWrkBook.Close()
            excelApplication.DisplayAlerts = True
            excelApplication.Quit()

            inputFile = fso.OpenTextFile(output, 1)
            str = inputFile.ReadAll
            str = Replace(str, vbTab, ";")
            outputFile = fso.CreateTextFile(output, True)
            outputFile.Write(str)

            load_csv_item(Replace(output, "\", "/"))

            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                txt_path_item.Text = ""
                Try
                    Call insert_item_import()
                Catch ex As Exception
                    Dim info2 As AlertInfo = New AlertInfo("Error", ex.Message)
                    alertControl_error.Show(Me, info2)
                End Try
                view_data()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, ex.Message)
            alertControl_error.Show(Me, info)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub txtkode_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtnama_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtnama_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtket_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GroupControl3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl3.Paint

    End Sub


    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        PanelControl3.Visible = False
        enableMain()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            view_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub panel_item_disc_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles panel_item_disc.Paint

    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        open_conn()
        sukses_qr = 0
        speaker = speaker.GetDefaultDevice()
        'Panel1.Visible = True
        _myCameraUrlBuilder = New CameraURLBuilderWF()

        Dim result = _myCameraUrlBuilder.ShowDialog()

        If result <> DialogResult.OK Then
            Panel2.Visible = True
            Panel7.Visible = True
            Return
        End If

        _camera = Nothing
        OnvifCamera = Nothing
        If result = Windows.Forms.DialogResult.OK Then
            If _camera IsNot Nothing Then
                'RemoveHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged
                _camera.Disconnect()
                _connector3.Disconnect(_camera.VideoChannel, _imageProvider3)
                _camera.Dispose()
                _camera = Nothing
                _videoViewerWF3.Stop()
            End If

            If OnvifCamera IsNot Nothing Then
                'RemoveHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged
                OnvifCamera.Disconnect()
                _connector2.Disconnect(OnvifCamera.VideoChannel, _imageProvider2)
                OnvifCamera.Dispose()
                OnvifCamera = Nothing
                _videoViewerWF2.Stop()
            End If


            _camera = New OzekiCamera(_myCameraUrlBuilder.CameraURL)
            If _camera.Type <> CameraType.USB Then
                'AddHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged

                OnvifCamera = IPCameraFactory.GetCamera("rtsp://192.168.0.9/video.mp4", "admin", "admin", Ozeki.Media.IPCamera.Data.CameraTransportType.TCP)
                _videoViewerWF2.SetImageProvider(_imageProvider2)
                _connector2.Connect(OnvifCamera.AudioChannel, speaker)
                _connector2.Connect(OnvifCamera.VideoChannel, _imageProvider2)

                OnvifCamera.Start()
                _videoViewerWF2.Start()

                speaker.Start()
                Panel2.Visible = True
                Panel7.Visible = True
            ElseIf _camera.Type <> CameraType.RTSP Then
                _videoViewerWF3.SetImageProvider(_imageProvider3)

                _connector3.Connect(_camera.AudioChannel, speaker)
                _connector3.Connect(_camera.VideoChannel, _imageProvider3)

                _camera.Start()
                _videoViewerWF3.Start()

                speaker.Start()
                txt_qrcode.Visible = False
                Panel2.Visible = True
                Panel7.Visible = True
                Timer1.Stop()
                Timer1.Interval = 5800
                Timer1.Start()
                AddHandler Timer1.Tick, AddressOf Timer1_Tick
            End If

        End If

        ' load_video()
        cuurentCameraStat = 1
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Try

            Dim Random As String
            If _camera Is Nothing Then
                Return
            End If

            Random = Replace(Rnd(9999), ".", "")
            If _camera.Type = CameraType.USB Then
                '_camera.Disconnect()
                '_connector.Disconnect(_camera.VideoChannel, _imageProvider)
                '_camera = Nothing
                _videoViewerWF3.Frame.Save(GetTempPath() & "\QRCODE" & Random & "U.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                If System.IO.File.Exists(GetTempPath() & "\QRCODE" & Random & "U.jpg") = True Then
                    txt_qrcode.Image = Image.FromFile(GetTempPath() & "\QRCODE" & Random & "U.jpg")
                    txt_qrcode.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            Else
                'OnvifCamera.Disconnect()
                '_connector2.Disconnect(_camera.VideoChannel, _imageProvider2)
                'OnvifCamera = Nothing
                _videoViewerWF2.Frame.Save(GetTempPath() & "\QRCODE" & Random & "U.jpg")
                If System.IO.File.Exists(GetTempPath() & "\QRCODE" & Random & "U.jpg") = True Then
                    txt_qrcode.Image = Image.FromFile(GetTempPath() & "\QRCODE" & Random & "U.jpg")
                    txt_qrcode.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End If
            filename = "Webcam"
            _myCameraUrlBuilder.Hide()
            ' txt_qrcode.Visible = True

            Dim QRCodeDecoder As QRCodeDecoder = New QRCodeDecoder
            'QRCodeDecoder.Canvas = new ConsoleCanvas();
            Dim decodedString As String = QRCodeDecoder.decode(New QRCodeBitmapImage(New Bitmap(txt_qrcode.Image)))
            txt_itemid.Text = decodedString
            'Panel2.Visible = False

        Catch ex As Exception
            sukses_qr = 0
            'Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            'alertControl_error.Show(Me, info)
            Exit Sub
        End Try
        sukses_qr = 1
        Dim info As AlertInfo = New AlertInfo("Successfully Generate", txt_itemid.Text)
        alertControl_success.Show(Me, info)

        Timer1.Stop()

    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        Try

            Dim Random As String
            If _camera Is Nothing Then
                Return
            End If

            Random = Replace(Rnd(9999), ".", "")
            If _camera.Type = CameraType.USB Then
                '_camera.Disconnect()
                '_connector.Disconnect(_camera.VideoChannel, _imageProvider)
                '_camera = Nothing
                _videoViewerWF3.Frame.Save(GetTempPath() & "\QRCODE" & Random & "U.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                If System.IO.File.Exists(GetTempPath() & "\QRCODE" & Random & "U.jpg") = True Then
                    txt_qrcode.Image = Image.FromFile(GetTempPath() & "\QRCODE" & Random & "U.jpg")
                    txt_qrcode.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            Else
                'OnvifCamera.Disconnect()
                '_connector2.Disconnect(_camera.VideoChannel, _imageProvider2)
                'OnvifCamera = Nothing
                _videoViewerWF2.Frame.Save(GetTempPath() & "\QRCODE" & Random & "U.jpg")
                If System.IO.File.Exists(GetTempPath() & "\QRCODE" & Random & "U.jpg") = True Then
                    txt_qrcode.Image = Image.FromFile(GetTempPath() & "\QRCODE" & Random & "U.jpg")
                    txt_qrcode.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End If
            filename = "Webcam"
            _myCameraUrlBuilder.Hide()
            ' txt_qrcode.Visible = True

            Dim QRCodeDecoder As QRCodeDecoder = New QRCodeDecoder
            'QRCodeDecoder.Canvas = new ConsoleCanvas();
            Dim decodedString As String = QRCodeDecoder.decode(New QRCodeBitmapImage(New Bitmap(txt_qrcode.Image)))
            txt_itemid.Text = decodedString
            'Panel2.Visible = False

        Catch ex As Exception
            'Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            'alertControl_error.Show(Me, info)
            Exit Sub
        End Try
        Dim info As AlertInfo = New AlertInfo("Successfully Generate", txt_itemid.Text)
        alertControl_success.Show(Me, info)

    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        open_conn()
        speaker = speaker.GetDefaultDevice()
        'Panel1.Visible = True
        _myCameraUrlBuilder = New CameraURLBuilderWF()

        Dim result = _myCameraUrlBuilder.ShowDialog()

        If result <> DialogResult.OK Then
            Return
        End If
        _camera = Nothing
        OnvifCamera = Nothing
        If result = Windows.Forms.DialogResult.OK Then
            If _camera IsNot Nothing Then
                'RemoveHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged
                _camera.Disconnect()
                _connector3.Disconnect(_camera.VideoChannel, _imageProvider3)
                _camera.Dispose()
                _camera = Nothing
                _videoViewerWF3.Stop()
            End If

            If OnvifCamera IsNot Nothing Then
                'RemoveHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged
                OnvifCamera.Disconnect()
                _connector2.Disconnect(OnvifCamera.VideoChannel, _imageProvider2)
                OnvifCamera.Dispose()
                OnvifCamera = Nothing
                _videoViewerWF2.Stop()
            End If


            _camera = New OzekiCamera(_myCameraUrlBuilder.CameraURL)
            If _camera.Type <> CameraType.USB Then
                'AddHandler _camera.CameraStateChanged, AddressOf _camera_CameraStateChanged

                OnvifCamera = IPCameraFactory.GetCamera("rtsp://192.168.0.9/video.mp4", "admin", "admin", Ozeki.Media.IPCamera.Data.CameraTransportType.TCP)
                _videoViewerWF2.SetImageProvider(_imageProvider2)
                _connector2.Connect(OnvifCamera.AudioChannel, speaker)
                _connector2.Connect(OnvifCamera.VideoChannel, _imageProvider2)

                OnvifCamera.Start()
                _videoViewerWF2.Start()

                speaker.Start()
                Panel2.Visible = True
                Panel7.Visible = True
            ElseIf _camera.Type <> CameraType.RTSP Then
                _videoViewerWF3.SetImageProvider(_imageProvider3)

                _connector3.Connect(_camera.AudioChannel, speaker)
                _connector3.Connect(_camera.VideoChannel, _imageProvider3)

                _camera.Start()
                _videoViewerWF3.Start()

                speaker.Start()
                txt_qrcode.Visible = False
                Panel2.Visible = True
                Panel7.Visible = True
                Timer1.Stop()
                Timer1.Interval = 5800
                Timer1.Start()
                AddHandler Timer1.Tick, AddressOf Timer1_Tick
            End If
            'PictureBox2.Visible = False
        End If

        ' load_video()
        cuurentCameraStat = 1
    End Sub

    Private Sub SimpleButton5_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton5.Click
        open_conn()
        timer.Stop()
        If pb.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = Replace(pb.FileName, "\", "/")
            txt_qrcode.Image = Image.FromFile(filename)
            txt_qrcode.Visible = True
            Try
                Dim QRCodeDecoder As QRCodeDecoder = New QRCodeDecoder
                'QRCodeDecoder.Canvas = new ConsoleCanvas();
                Dim decodedString As String = QRCodeDecoder.decode(New QRCodeBitmapImage(New Bitmap(txt_qrcode.Image)))
                txt_itemid.Text = decodedString
                'Panel2.Visible = False

            Catch ex As Exception
                Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
                alertControl_error.Show(Me, info)
            End Try

        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        cuurentCameraStat = 1
        Panel2.Visible = False
    End Sub

    Private Sub chkIncludeInActive_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkIncludeInActive.CheckedChanged
        view_data()
        txt_stock.Text = 0
    End Sub

    Private Sub chkwhithoutnotif_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkwhithoutnotif.CheckedChanged
        If chkwhithoutnotif.Checked = True Then
            txt_min_qty.Enabled = False
            txt_min_qty.Text = 0
            cbounit_min_qty.SelectedText = ""
            cbounit_min_qty.Text = ""
            cbounit_min_qty.Enabled = False
        Else
            txt_min_qty.Enabled = True
            cbounit_min_qty.Enabled = True
        End If
    End Sub

    Private Sub cbo_jenis_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_jenis.EditValueChanged
        If cbo_jenis.EditValue <> Nothing Then
            Dim row As String
            '  row.Clear()
            row = cbo_jenis.EditValue.ToString
            cbo_kategori.Properties.DataSource = getComboCategory(row)
            cbo_kategori.Properties.DisplayMember = "mst_itemcat_nm"
            cbo_kategori.Properties.ValueMember = "mst_itemcat_id"
            cbo_kategori.Properties.PopulateViewColumns()
            cbo_kategori.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            cbo_kategori.Properties.View.OptionsView.ShowAutoFilterRow = True
        End If
    End Sub

    Private Sub cbo_kategori_EditValueChanged(sender As Object, e As System.EventArgs) Handles cbo_kategori.EditValueChanged
        If cbo_kategori.EditValue <> Nothing Then
            Dim row As DataRowView
            row = TryCast(cbo_kategori.Properties.GetRowByKeyValue(cbo_kategori.EditValue), DataRowView)
            cbo_jenis.Properties.DataSource = getComboJenis(row.Item("mst_itemjenis_id"))
            cbo_jenis.Properties.DisplayMember = "mst_itemjenis_nm"
            cbo_jenis.Properties.ValueMember = "mst_itemjenis_id"
            cbo_jenis.Properties.PopulateViewColumns()
            cbo_jenis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            cbo_jenis.Properties.View.OptionsView.ShowAutoFilterRow = True
        End If
    End Sub

    Public Sub SimpleButton7_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton7.Click
        fillComboBox1()
        cbo_kategori.EditValue = Nothing
    End Sub

    Public Sub SimpleButton6_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton6.Click
        fillComboBox2()
        cbo_jenis.EditValue = Nothing
    End Sub

    Public Sub SimpleButton11_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton11.Click
        fillComboBox3()
    End Sub

    Private Sub SimpleButton10_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton10.Click
        Dim form As New frmbrandbarang
        form.Show()
        Me.Enabled = False
        '' MainMenu.Enabled = False
    End Sub

    Private Sub SimpleButton12_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton12.Click
        fillComboBox4()
    End Sub

    Private Sub SimpleButton14_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton14.Click
        fillComboBox5()
    End Sub

    Private Sub SimpleButton13_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton13.Click
        fillComboBox6()
    End Sub

    Private Sub SimpleButton17_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton17.Click
        PanelControl3.Visible = True

        disableMain()
        clean()
        fillComboBox()
    End Sub

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl5.Enabled = False
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl5.Enabled = True
    End Sub

    Private Sub SimpleButton16_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton16.Click
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            view_data()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton15_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton15.Click
        Me.Close()
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_item"), sender, e)
        fillComboBox()
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_item"), sender, e)
        End If
    End Sub

    Private Sub DataGridView3_LostFocus(sender As Object, e As System.EventArgs) Handles DataGridView3.LostFocus
        Lookup_Unit.Visible = False
    End Sub

    Private Sub Lookup_Unit_EditValueChanged(sender As Object, e As System.EventArgs) Handles Lookup_Unit.EditValueChanged
        DataGridView3.Item(colIndex, rowIndex).Value = Lookup_Unit.EditValue
        Lookup_Unit.Visible = False
    End Sub

    Private Sub SimpleButton18_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton18.Click
        ImportControl.Visible = True
        disableMain()
        clean()
    End Sub

    Private Sub btn_imp_cust_Click(sender As System.Object, e As System.EventArgs) Handles btn_imp_cust.Click
        Dim pb As New OpenFileDialog
        pb.Title = "Pilih file excel"
        pb.Filter = "Excel Files|*.xls;*.xlsx"
        If pb.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim sc As String
                sc = (System.Threading.Thread.CurrentThread.CurrentCulture.ToString)
                If sc <> "en-US" Then
                    My.Application.ChangeCulture("en-US")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"
                Else
                    My.Application.ChangeCulture("id-ID")
                    My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                    My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                    My.Application.Culture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy"
                End If

                SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
                SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
                txt_path_cust.Text = pb.FileName


                If Trim(pb.FileName) <> "" Then
                    FilenameExcel = pb.FileName
                    MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pb.FileName + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';")
                    MyConnection.Open()

                    PanelControl4.Visible = True
                    cmbsheets.Items.Clear()
                    cmbsheets.Items.AddRange(MyConnection.GetSchema("Tables", New String() {Nothing, Nothing, Nothing, "TABLE"}
                                             ).AsEnumerable().Select(Function(d) d("TABLE_NAME").ToString.Replace("$", "")).ToArray)

                    cmbsheets.SelectedIndex = 0
                    getFieldExcel()
                    getFieldMysql()
                End If
            Catch ex As Exception
                Dim info As AlertInfo = New AlertInfo("Warning", ex.Message)
                alertControl_warning.Show(MainMenu, info)
            Finally
                My.Application.ChangeCulture("en-US")
                My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"
                SplashScreenManager.CloseForm(False)
            End Try
        End If
    End Sub

    Private Sub getFieldExcel()
        Dim DTField As DataTable
        Dim rootNode As TreeNode
        DTField = MyConnection.GetSchema("Columns", New String() {Nothing, Nothing, cmbsheets.SelectedItem.ToString & "$", Nothing})
        With DataGridView4
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
            .AutoGenerateColumns = False
            Dim a As Integer = 0
            .DataSource = DTField
            .Columns(0).DataPropertyName = "COLUMN_NAME"
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = False
        End With
    End Sub

    Private Sub getFieldMysql()
        Dim DTField As DataTable
        Dim column As New DevExpress.XtraGrid.Columns.GridColumn
        column.VisibleIndex = 0
        DTField = getFieldName("mst_item")
        With Lookup_field
            .Properties.AutoComplete = True
            .Properties.DataSource = DTField
            .Properties.DisplayMember = "Field"
            .Properties.ValueMember = "Field"
            .Properties.View.OptionsView.ShowAutoFilterRow = True
            .Properties.View.Columns.Add(column)
            .Properties.View.Columns(0).Caption = "Destination Field"
            .Properties.View.Columns(0).FieldName = "Field"
            .Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        End With

        For i As Integer = 0 To DataGridView4.Rows.Count - 1
            For y As Integer = 0 To DTField.Rows.Count - 1
                If DataGridView4.Item(0, i).Value = DTField.Rows(y).Item("Field") Then
                    DataGridView4.Item(1, i).Value = DTField.Rows(y).Item("Field")
                    DataGridView4.Item(2, i).Value = True
                End If
            Next
        Next

    End Sub

    Private Sub cmbsheets_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbsheets.SelectedIndexChanged
        getFieldExcel()
    End Sub

    Private Sub SimpleButton20_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton20.Click
        Dim a As Integer
        a = 0
        For i As Integer = 0 To DataGridView4.Rows.Count - 1
            If DataGridView4.Item(1, i).Value <> Nothing Or DataGridView4.Item(2, i).Value <> False Then
                a = a + 1
            End If
        Next
        If a = 0 Then
            Dim info As AlertInfo = New AlertInfo("Warning", "Tujuan Field Belum di setting/di pilih")
            alertControl_warning.Show(MainMenu, info)
            Exit Sub
        End If
        generateUploadExcel()
        PanelControl4.Visible = False
    End Sub

    Private Sub generateUploadExcel()
        Dim rootKey(10000), fieldKey(10000) As String
        Dim Field As String
        Dim a, b As Integer
        Dim DTColumns As Integer


        DTColumns = DTExcel.Columns.Count
        For i As Integer = 0 To DTColumns - 1
            DTExcel.Columns.RemoveAt(0)
        Next
        DTExcel.Clear()
        Field = ""
        For Each nodes As DataGridViewRow In DataGridView4.Rows
            rootKey(a) = ""
            fieldKey(a) = ""
            If DataGridView4.Item(0, b).Value <> Nothing And DataGridView4.Item(1, b).Value <> Nothing And DataGridView4.Item(2, b).Value = True Then
                rootKey(a) = DataGridView4.Item(0, b).Value
                fieldKey(a) = DataGridView4.Item(1, b).Value
                If a > 0 Then
                    Field = Field & "," & rootKey(a)
                    importingField = importingField & "," & fieldKey(a)
                    If DataGridView4.Item(1, b).Value = "id_category" Then
                        id_category = id_category + 1
                        index_importingfield_cat = b
                    End If
                    If DataGridView4.Item(1, b).Value = "id_jenis" Then
                        id_jenis = id_jenis + 1
                        index_importingfield_jenis = b
                    End If
                    If DataGridView4.Item(1, b).Value = "id_brand" Then
                        id_brand = id_brand + 1
                        index_importingfield_brand = b
                    End If
                    If DataGridView4.Item(1, b).Value = "main_unit" Then
                        main_unit = main_unit + 1
                    End If
                    If DataGridView4.Item(1, b).Value = "buy_unit" Then
                        buy_unit = buy_unit + 1
                    End If
                    If DataGridView4.Item(1, b).Value = "sell_unit" Then
                        sell_unit = sell_unit + 1
                    End If
                    If DataGridView4.Item(1, b).Value = "flag_buy" Then
                        flag_buy = flag_buy + 1
                    End If
                    If DataGridView4.Item(1, b).Value = "flag_sell" Then
                        flag_sell = flag_sell + 1
                    End If
                    If DataGridView4.Item(1, b).Value = "flag_inv" Then
                        flag_inv = flag_inv + 1
                    End If
                    If DataGridView4.Item(1, b).Value = "flag_inv" Then
                        flag_inv = flag_inv + 1
                    End If
                    If DataGridView4.Item(1, b).Value = "max_qty" Then
                        max_qty = max_qty + 1
                    End If
                    If DataGridView4.Item(1, b).Value = "min_qty" Then
                        min_qty = min_qty + 1
                    End If

                Else
                        Field = rootKey(a)
                        importingField = fieldKey(a)
                End If
                a = a + 1
            End If
            b = b + 1
        Next
        If id_jenis = 0 Then
            index_importingfield_jenis = -1
        End If
        If id_category = 0 Then
            index_importingfield_cat = -1
        End If
        If id_brand = 0 Then
            index_importingfield_brand = -1
        End If

        Try
            With command_excel
                .Connection = MyConnection
                .CommandText = "select " & Field & "  from [" & Trim(cmbsheets.SelectedItem) & "$]"
                .CommandType = CommandType.Text
            End With
            sqlreader_excel.SelectCommand = command_excel
            sqlreader_excel.Fill(DTExcel)
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            'sqlreader_excel = command_excel.ExecuteReader
            'If sqlreader_excel.HasRows Then
            '    While sqlreader_excel.Read
            '        GridViewUpload.DataSource.rowAdd(Format(CDate(sqlreader_excel.Item(0)), "dd-MMM-yyyy"), sqlreader_excel.Item(1), sqlreader_excel.Item(2), sqlreader_excel.Item(3), sqlreader_excel.Item(4), sqlreader_excel.Item(5), sqlreader_excel.Item(6), FormatNumber(sqlreader_excel.Item(7)), FormatNumber(sqlreader_excel.Item(8)), "Menunggu Proses Import", Format(CDate(sqlreader_excel.Item(0)), "yyyy-MM-dd"), 0)
            '    End While
            'End If
            'datagrid_kasirsentral.Columns(11).Visible = False
            Dim sc As String
            sc = (System.Threading.Thread.CurrentThread.CurrentCulture.ToString)
            If sc <> "en-US" Then
                My.Application.ChangeCulture("en-US")
                My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"
            Else
                My.Application.ChangeCulture("id-ID")
                My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
                My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
                My.Application.Culture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy"
            End If
            GridUpload.DataSource = DTExcel
            GridUpload.DefaultView.PopulateColumns()
            MyConnection.Close()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Warning", ex.Message)
            alertControl_warning.Show(MainMenu, info)
        Finally
            My.Application.ChangeCulture("en-US")
            My.Application.Culture.NumberFormat.NumberDecimalSeparator = "."
            My.Application.Culture.NumberFormat.NumberGroupSeparator = ","
            My.Application.Culture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy"
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub btn_prosesimp_cust_Click(sender As System.Object, e As System.EventArgs) Handles btn_prosesimp_cust.Click
        Dim rootKey(1000) As String
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            'sqlreader_excel = command_excel.ExecuteReader
            Dim id_customer As String
            Dim var_id_category As String
            Dim var_id_jenis As String
            Dim var_id_brand As String

            For i As Integer = 0 To GridViewUpload.RowCount - 1
                Call insert_no_trans("MASTER_ITEM", Month(server_datetime()), Year(server_datetime()))
                Call select_control_no("MASTER_ITEM", "TRANS")
                id_customer = no_master
                For y As Integer = 0 To GridViewUpload.Columns.Count - 1
                    rootKey(y) = ""
                    rootKey(y) = GridViewUpload.GetRowCellValue(i, GridViewUpload.Columns(y).FieldName).ToString

                    If index_importingfield_cat = y Then
                        If cek_itemcat_nm(rootKey(y)) = 0 Then
                            If cek_itemcat_id(rootKey(y)) = 1 Then
                                var_id_category = select_itemcat_id(rootKey(y))
                                rootKey(y) = var_id_category
                            ElseIf cek_itemcat_id(rootKey(y)) = 0 Then
                                rootKey(y) = "NA"
                            End If
                        End If
                    End If

                    If index_importingfield_jenis = y Then
                        If cek_itemjenis_nm(rootKey(y)) = 0 Then
                            If cek_itemjenis_id(rootKey(y)) = 1 Then
                                var_id_jenis = select_itemjenis_id(rootKey(y))
                                rootKey(y) = var_id_jenis
                            ElseIf cek_itemjenis_id(rootKey(y)) = 0 Then
                                rootKey(y) = "NA"
                            End If
                        End If
                    End If

                    If index_importingfield_brand = y Then
                        If cek_itembrand_nm(rootKey(y)) = 0 Then
                            If cek_itembrand_id(rootKey(y)) = 1 Then
                                var_id_brand = select_itembrand_id(rootKey(y))
                                rootKey(y) = var_id_brand
                            ElseIf cek_itembrand_id(rootKey(y)) = 0 Then
                                rootKey(y) = "NA"
                            End If
                        End If
                    End If


                    If y > 0 And y < GridViewUpload.Columns.Count - 1 Then
                        importingValue = importingValue & "','" & rootKey(y) & ""
                    ElseIf y = GridViewUpload.Columns.Count - 1 Then
                        importingValue = importingValue & "','" & rootKey(y) & "'"
                    Else
                        importingValue = "'" & rootKey(y) & ""
                    End If
                Next

                Dim var_main_unit As String
                Dim var_buy_unit As String
                Dim var_sell_unit As String
                Dim var_flag_buy As Integer
                Dim var_flag_sell As Integer
                Dim var_flag_inv As Integer
                Dim var_max_qty As Integer
                Dim var_min_qty As Integer
                Dim var_use_notifminqty As Integer

                var_use_notifminqty = 0

                If main_unit = 0 Then
                    var_main_unit = "pcs"
                End If
                If buy_unit = 0 Then
                    var_buy_unit = "pcs"
                End If
                If sell_unit = 0 Then
                    var_sell_unit = "pcs"
                End If
                If flag_buy = 0 Then
                    var_flag_buy = 1
                End If
                If flag_sell = 0 Then
                    var_flag_sell = 1
                End If
                If flag_inv = 0 Then
                    var_flag_inv = 0
                End If
                If max_qty = 0 Then
                    var_max_qty = 0
                End If
                If min_qty = 0 Then
                    var_min_qty = 0
                End If

                Dim add_importingfieldjenis, add_importingfieldcat, add_importingfieldbrand As String
                If id_jenis = 0 And (id_category = 0 Or id_brand = 0) Then
                    var_id_jenis = "NA"
                    add_importingfieldjenis = "id_jenis"
                    importingValue = importingValue & ",'" & var_id_jenis & "'"
                    If i = 0 Then
                        importingField = importingField & "," & add_importingfieldjenis & ""
                    End If
                ElseIf id_jenis = 0 And id_category <> 0 And id_brand <> 0 Then
                    var_id_jenis = "NA"
                    add_importingfieldjenis = "id_jenis"
                    importingValue = importingValue & ",'" & var_id_jenis & ""
                    If i = 0 Then
                        importingField = importingField & "," & add_importingfieldjenis & ""
                    End If
                End If
                If id_category = 0 And (id_jenis = 0 Or id_brand = 0) Then
                    var_id_category = "NA"
                    add_importingfieldcat = "id_category"
                    importingValue = importingValue & ",'" & var_id_category & "'"
                    If i = 0 Then
                        importingField = importingField & "," & add_importingfieldcat & ""
                    End If
                ElseIf id_category = 0 And id_jenis <> 0 And id_brand <> 0 Then
                    var_id_category = "NA"
                    add_importingfieldcat = "id_category"
                    importingValue = importingValue & ",'" & var_id_category & ""
                    If i = 0 Then
                        importingField = importingField & "," & add_importingfieldcat & ""
                    End If
                End If
                If id_brand = 0 And (id_category = 0 Or id_brand = 0) Then
                    var_id_brand = "NA"
                    add_importingfieldbrand = "id_brand"
                    importingValue = importingValue & ",'" & var_id_brand & "'"
                    If i = 0 Then
                        importingField = importingField & "," & add_importingfieldbrand & ""
                    End If
                ElseIf id_brand = 0 And id_category <> 0 And id_jenis <> 0 Then
                    var_id_brand = "NA"
                    add_importingfieldbrand = "id_brand"
                    importingValue = importingValue & ",'" & var_id_brand & ""
                    If i = 0 Then
                        importingField = importingField & "," & add_importingfieldbrand & ""
                    End If
                End If

                Call import_item("id_item," & importingField & ",id_account,id_account_cogs,account_cogs,created_user,modified_user,created_date, modified_date, active_status,main_unit,buy_unit,sell_unit,flag_buy,flag_sell,flag_inv,max_qty,min_qty,use_notifminqty,id_warehouse,item_disc_qty,item_disc_unit", "'" & id_customer & "'," & importingValue & ",'" & select_def_accitem() & "','" & select_def_accitemcogs() & "','" & GetAccount_Name(select_def_accitemcogs()) & "','" & username & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd hh:mm:ss") & "','" & Format(server_datetime(), "yyyy-MM-dd hh:mm:ss") & "',1,'" & var_main_unit & "','" & var_buy_unit & "','" & var_sell_unit & "'," & var_flag_buy & "," & var_flag_sell & "," & var_flag_inv & "," & var_max_qty & "," & var_min_qty & "," & var_use_notifminqty & ",'" & GetWHDef() & "',0,'pcs'")
                Call import_item_unit(id_customer, "pcs", 1, "", username, server_datetime())
                Call import_item_begbalance(id_customer, "pcs", GetWHDef(), 0, "")
            Next
            If param_sukses = True Then
                Dim info2 As AlertInfo = New AlertInfo("Sukses", "Sukses Import Data Item")
                alertControl_success.Show(MainMenu, info2)
                view_data()
                ImportControl.Visible = False
                enableMain()
                MyConnection.Close()
            End If
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton21_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton21.Click
        ImportControl.Visible = False
        enableMain()
        PanelControl4.Visible = False
        MyConnection.Close()
    End Sub

    Private Sub DataGridView4_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellEnter
        rowIndex = DataGridView4.CurrentCell.RowIndex
        colIndex = DataGridView4.CurrentCell.ColumnIndex
        If colIndex = 1 Then
            Lookup_field.Visible = True
            Lookup_field.Left = DataGridView4.GetCellDisplayRectangle(colIndex, rowIndex, False).Left + DataGridView4.Left
            Lookup_field.Top = DataGridView4.GetCellDisplayRectangle(colIndex, rowIndex, False).Top + DataGridView4.Top
        Else
            Lookup_field.Visible = False
        End If
    End Sub

    Private Sub DataGridView4_LostFocus(sender As Object, e As System.EventArgs) Handles DataGridView4.LostFocus
        Lookup_field.Visible = False
        Lookup_field.ClosePopup()
    End Sub

    Private Sub Lookup_field_EditValueChanged(sender As Object, e As System.EventArgs) Handles Lookup_field.EditValueChanged
        DataGridView4.Item(colIndex, rowIndex).Value = Lookup_field.EditValue
        DataGridView4.Item(1, rowIndex).Value = Lookup_field.EditValue
        Lookup_field.Visible = False
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub GridControl_Click(sender As System.Object, e As System.EventArgs) Handles GridControl.Click

    End Sub
End Class