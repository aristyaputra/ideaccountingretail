Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports System.IO.Path
Imports System.IO

Public Class frmEventMember

    Dim insert As Integer
    Dim edit As Integer
    Public param_focus As Integer
    Dim i As Integer
    Dim pesan As String

    Private Sub frmjenisbarang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
    End Sub

    Private Sub frmkatbarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.MdiParent = MainMenu
        insert = 1
        edit = 0
        btn_del2.Enabled = False
        view_data()
        addButtonGridView()
        datagridLayout()
        view_data_event()
        datagridLayoutEvent()
    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        txt_area.Text = ""
        txt_eventname.Text = ""
        txt_nama.Text = ""
        txt_nip.Text = ""
        txt_posisi.Text = ""
        txt_region.Text = ""
        txt_memberid.Text = getKodeEvent()
        btn_del2.Enabled = False
        btn_del2.Enabled = False
        btn_save2.Enabled = True
        btn_reset2.Enabled = True
        txt_save_path.Text = Application.StartupPath & "\" & txt_memberid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        filename = Replace(Application.StartupPath & "\photo\no-image.jpg", "\", "/")
        txt_photo.Image = Image.FromFile(filename)
    End Sub

    Public Sub insert_data()
        open_conn()
        filename = Trim(txt_temp.Text)
        txt_save_path.Text = Application.StartupPath & "\" & txt_memberid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        Dim FileToSaveAs As String = Trim(txt_save_path.Text)
        If insert = 1 Then
            Call insert_event_member(Trim(txt_memberid.Text), Trim(txt_eventid.EditValue), Trim(txt_nip.Text), Trim(txt_nama.Text), Trim(txt_posisi.Text), Trim(txt_area.Text), Trim(txt_region.Text), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, username, "INSERT", txt_save_path.Text)
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                ' If filename <> "" Then
                System.IO.File.Copy(filename, FileToSaveAs)
                'End If
                update_no_trans(server_datetime(), "MASTER_EVENT_MEMBER")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_event_member(Trim(txt_memberid.Text), Trim(txt_eventid.EditValue), Trim(txt_nip.Text), Trim(txt_nama.Text), Trim(txt_posisi.Text), Trim(txt_area.Text), Trim(txt_region.Text), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, username, "UPDATE", txt_save_path.Text)
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                System.IO.File.Copy(filename, FileToSaveAs)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
    End Sub


    Private Function getKodeEvent() As String
        Try
            var_bulan = Month(server_datetime())
            var_tahun = Year(server_datetime())
            Call insert_no_trans("MASTER_EVENT_MEMBER", var_bulan, var_tahun)
            Call select_control_no("MASTER_EVENT_MEMBER", "TRANS")
            Return no_master
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If Trim(txt_area.Text) = "" Then
            txt_area.Text = 0
        End If
        If insert = 1 Then
            If getTemplateAkses(username, "MN_EVENT_MEMBER_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_EVENT_MEMBER_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        insert_data()

    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_EVENT_MEMBER_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Data peserta akan di hapus?", "Hapus Data", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_event_member(Trim(txt_memberid.Text), Trim(txt_eventid.EditValue), Trim(txt_nip.Text), Trim(txt_nama.Text), Trim(txt_posisi.Text), Trim(txt_area.Text), Trim(txt_region.Text), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, username, "DELETE", txt_save_path.Text)
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

    Private Sub addButtonGridView()
        'add link view
        Dim colView As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.AddVisible("ViewButton", "LIHAT")
        colView.UnboundType = DevExpress.Data.UnboundColumnType.Object
        Dim repButtonView As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        repButtonView.Name = "btnView"
        repButtonView.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        repButtonView.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridControl1.RepositoryItems.Add(repButtonView)
        colView.ColumnEdit = repButtonView
        colView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        colView.AppearanceHeader.Options.UseTextOptions = True
        colView.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        'add link edit
        Dim colEdit As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.AddVisible("EditButton", "UBAH")
        colEdit.UnboundType = DevExpress.Data.UnboundColumnType.Object
        Dim repButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        repButtonEdit.Name = "btnEdit"
        repButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        repButtonEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridControl1.RepositoryItems.Add(repButtonEdit)
        colEdit.ColumnEdit = repButtonEdit
        colEdit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        colEdit.AppearanceHeader.Options.UseTextOptions = True
        colEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        'add link delete
        Dim colDelete As DevExpress.XtraGrid.Columns.GridColumn = GridView1.Columns.AddVisible("DeleteButton", "HAPUS")
        colDelete.UnboundType = DevExpress.Data.UnboundColumnType.Object
        Dim repButtonDel As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        repButtonDel.Name = "btnDel"
        repButtonDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        repButtonDel.Appearance.Options.UseTextOptions = True
        repButtonDel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        GridControl1.RepositoryItems.Add(repButtonDel)
        colDelete.ColumnEdit = repButtonDel
        colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        colDelete.AppearanceHeader.Options.UseTextOptions = True
        colDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        ' AddHandler GridView1.CustomUnboundColumnData, AddressOf mainView_CustomUnboundColumnData
    End Sub

    Private Sub view_data()
        open_conn()
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_event_member()
        GridControl1.DataSource = DT
    End Sub

    Private Sub view_data_event()
        open_conn()
        Dim i As Integer
        Dim Rows As Integer
        Dim DT As DataTable
        DT = select_event()
        txt_eventid.Properties.DataSource = DT
        txt_eventid.Properties.ValueMember = "id_event"
        txt_eventid.Properties.DisplayMember = "event_name"
        txt_eventid.Properties.PopulateViewColumns()
        datagridLayoutEvent()

    End Sub


    Private Sub datagridLayoutEvent()
        With txt_eventid
            .Properties.View.Columns("created_date").Visible = False
            .Properties.View.Columns("modified_date").Visible = False
            .Properties.View.Columns("created_user").Visible = False
            .Properties.View.Columns("modified_user").Visible = False
            .Properties.View.Columns("id_event").Caption = "KODE EVENT"
            .Properties.View.Columns("event_name").Caption = "NAMA EVENT"
            .Properties.View.Columns("start_date").Caption = "TGL MULAI"
            .Properties.View.Columns("end_date").Caption = "TGL SELESAI"
            .Properties.View.Columns("pic").Caption = "PIC"
            .Properties.View.Columns("event_name").FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            .Properties.View.Columns("id_event").OptionsColumn.AllowEdit = False
            .Properties.View.Columns("event_name").OptionsColumn.AllowEdit = False
            .Properties.View.Columns("start_date").OptionsColumn.AllowEdit = False
            .Properties.View.Columns("end_date").OptionsColumn.AllowEdit = False
            .Properties.View.Columns("pic").OptionsColumn.AllowEdit = False
            .Properties.View.Columns("id_event").OptionsFilter.AllowFilter = True
            .Properties.View.Columns("event_name").OptionsFilter.AllowFilter = True
            .Properties.View.Columns("start_date").OptionsFilter.AllowFilter = True
            .Properties.View.Columns("end_date").OptionsFilter.AllowFilter = True
            .Properties.View.Columns("pic").OptionsFilter.AllowFilter = True
            .Properties.View.Columns("id_event").OptionsFilter.AllowAutoFilter = True
            .Properties.View.Columns("event_name").OptionsFilter.AllowAutoFilter = True
            .Properties.View.Columns("start_date").OptionsFilter.AllowAutoFilter = True
            .Properties.View.Columns("end_date").OptionsFilter.AllowAutoFilter = True
            .Properties.View.Columns("pic").OptionsFilter.AllowAutoFilter = True
            .Properties.View.Columns("id_event").BestFit()
            .Properties.View.Columns("event_name").BestFit()
            .Properties.View.Columns("start_date").BestFit()
            .Properties.View.Columns("end_date").BestFit()
            .Properties.View.Columns("pic").BestFit()
            .Properties.View.OptionsCustomization.AllowGroup = False
            .Properties.View.OptionsCustomization.AllowFilter = True
            .Properties.View.OptionsCustomization.AllowColumnMoving = True
            .Properties.View.OptionsCustomization.AllowColumnResizing = True
            .Properties.View.OptionsCustomization.AllowSort = False
            .Properties.View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
            .Properties.View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
            .Properties.View.OptionsBehavior.Editable = False
            .Properties.View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            .Properties.View.OptionsView.ShowGroupPanel = False
            .Properties.View.OptionsFind.AllowFindPanel = True
            .Properties.View.OptionsFind.AlwaysVisible = True
            .Properties.View.OptionsFind.ClearFindOnClose = True
            .Properties.View.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
            .Properties.View.OptionsFind.ShowFindButton = False
            .Properties.View.OptionsFind.ShowClearButton = True
            .Properties.View.OptionsFind.ShowCloseButton = False
            .Properties.View.OptionsFind.HighlightFindResults = True
            .Properties.View.OptionsFind.SearchInPreview = True
            .Properties.PopupFormSize = New Size(txt_eventid.Width * 1.5, 300)
        End With
    End Sub

    Private Sub datagridLayout()
        With GridView1

            .Columns("created_date").Visible = False
            .Columns("modified_date").Visible = False
            .Columns("created_user").Visible = False
            .Columns("modified_user").Visible = False
            .Columns("id_member").Visible = False
            .Columns("id_event").Visible = False
            .Columns("photo_path").Visible = False
            .Columns("nip_member").Caption = "NIP"
            .Columns("member_name").Caption = "NAMA"
            .Columns("position").Caption = "POSISI"
            .Columns("area").Caption = "AREA"
            .Columns("region").Caption = "REGION"
            .Columns("member_name").FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            .Columns("nip_member").OptionsColumn.AllowEdit = False
            .Columns("member_name").OptionsColumn.AllowEdit = False
            .Columns("position").OptionsColumn.AllowEdit = False
            .Columns("area").OptionsColumn.AllowEdit = False
            .Columns("region").OptionsColumn.AllowEdit = False
            .Columns("nip_member").OptionsFilter.AllowFilter = True
            .Columns("member_name").OptionsFilter.AllowFilter = True
            .Columns("position").OptionsFilter.AllowFilter = True
            .Columns("area").OptionsFilter.AllowFilter = True
            .Columns("region").OptionsFilter.AllowFilter = True
            .Columns("ViewButton").OptionsFilter.AllowFilter = False
            .Columns("EditButton").OptionsFilter.AllowFilter = False
            .Columns("DeleteButton").OptionsFilter.AllowFilter = False
            .Columns("nip_member").OptionsFilter.AllowAutoFilter = True
            .Columns("member_name").OptionsFilter.AllowAutoFilter = True
            .Columns("position").OptionsFilter.AllowAutoFilter = True
            .Columns("area").OptionsFilter.AllowAutoFilter = True
            .Columns("region").OptionsFilter.AllowAutoFilter = True
            .Columns("ViewButton").OptionsFilter.AllowAutoFilter = False
            .Columns("EditButton").OptionsFilter.AllowAutoFilter = False
            .Columns("DeleteButton").OptionsFilter.AllowAutoFilter = False
            .Columns("ViewButton").Width = 100
            .Columns("EditButton").Width = 100
            .Columns("DeleteButton").Width = 100
            .Columns("nip_member").BestFit()
            .Columns("member_name").BestFit()
            .Columns("position").BestFit()
            .Columns("area").BestFit()
            .Columns("region").BestFit()
            .OptionsCustomization.AllowGroup = False
            .OptionsCustomization.AllowFilter = True
            .OptionsCustomization.AllowColumnMoving = True
            .OptionsCustomization.AllowColumnResizing = True
            .OptionsCustomization.AllowSort = True
            .OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
            .OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
            .OptionsBehavior.Editable = False
            .OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            .OptionsView.ShowGroupPanel = False
            .OptionsFind.AllowFindPanel = True
            .OptionsFind.AlwaysVisible = True
            .OptionsFind.ClearFindOnClose = True
            .OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
            .OptionsFind.ShowFindButton = False
            .OptionsFind.ShowClearButton = True
            .OptionsFind.ShowCloseButton = False
            .OptionsFind.HighlightFindResults = True
            .OptionsFind.SearchInPreview = True
        End With
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        Dim DT As DataTable
        DT = detail_event_member(criteria)
        txt_memberid.Text = DT.Rows(0).Item("id_member")
        txt_eventid.EditValue = DT.Rows(0).Item("id_event")
        txt_eventname.Text = DT.Rows(0).Item("event_name")
        txt_start_date.Value = DT.Rows(0).Item("start_date")
        txt_end_date.Value = DT.Rows(0).Item("end_date")
        txt_nip.Text = DT.Rows(0).Item("nip_member")
        txt_nama.Text = DT.Rows(0).Item("member_name")
        txt_posisi.Text = DT.Rows(0).Item("position")
        txt_area.Text = DT.Rows(0).Item("area")
        txt_region.Text = DT.Rows(0).Item("region")
        txt_temp.Text = DT.Rows(0).Item("photo_path")
        txt_save_path.Text = Application.StartupPath & "\" & txt_memberid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        If DT.Rows(0).Item("photo_path").ToString = "" Then
        Else
            'Dim msFoto1 As New MemoryStream(CType(DT.Rows(0).Item(14), Byte()))
            'frmcustomer.txt_photo.Image = Image.FromStream(msFoto1)
            ' Dim FileToSaveAs As String = Trim(txt_temp.Text)
            If System.IO.File.Exists(DT.Rows(0).Item("photo_path")) Then
                Using fs As New FileStream(DT.Rows(0).Item("photo_path"), FileMode.Open, FileAccess.Read)
                    txt_photo.Image = Image.FromStream(fs)
                End Using
            Else
                filename = Application.StartupPath & "\photo\no-image.jpg"
                txt_photo.Image = Image.FromFile(filename)
            End If
        End If
    End Sub

    Private Sub txtkode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_eventname.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub txtarea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_area.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    'Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
    '    open_conn()
    '    If TabControl1.SelectedTabPage Is TabList Then
    '        view_data()
    '    End If
    '    'open_conn()
    '    'Dim Total_Width_Column As Integer
    '    'Dim Width_Table As Integer
    '    'Dim selisih_col As Integer

    '    'With DataGridView1
    '    '    Total_Width_Column = .Columns(0).Width + .Columns(1).Width + .Columns(2).Width
    '    '    Width_Table = .Width
    '    '    selisih_col = Width_Table - Total_Width_Column - 65
    '    '    .Columns(2).Width = .Columns(2).Width + selisih_col
    '    'End With

    'End Sub


    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        enable_mainview()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data . . .")
            view_data()
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Error", ex.Message)
            alertControl_error.Show(MainMenu, info)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Panel1.Visible = True
        disable_mainview()
        clean()
        txt_nip.Enabled = True
        txt_eventid.Enabled = True
    End Sub

    Private Sub disable_mainview()
        txt_memberid.Text = Trim(getKodeEvent())
        GridControl1.Enabled = False
        SimpleButton1.Enabled = False
        SimpleButton2.Enabled = False
        Panel1.Visible = True
        
    End Sub

    Private Sub enable_mainview()
        GridControl1.Enabled = True
        GridView1.SelectCell(GridView1.FocusedRowHandle, GridView1.Columns("id_event"))
        SimpleButton1.Enabled = True
        SimpleButton2.Enabled = True
        Panel1.Visible = False
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub GridView1_Click(sender As Object, e As System.EventArgs) Handles GridView1.Click
        If GridView1.FocusedColumn.Name = "colViewButton" Then
            btn_del2.Enabled = False
            btn_save2.Enabled = False
            btn_reset2.Enabled = False
            txt_eventid.Enabled = False
            txt_nip.Enabled = False
            Panel1.Visible = True
            open_conn()
            insert = 0
            edit = 1
            disable_mainview()
            detail(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_member"))
        ElseIf GridView1.FocusedColumn.Name = "colEditButton" Then
            btn_del2.Enabled = False
            btn_save2.Enabled = True
            btn_reset2.Enabled = False
            txt_eventid.Enabled = False
            txt_nip.Enabled = False
            Panel1.Visible = True
            open_conn()
            insert = 0
            edit = 1
            disable_mainview()
            detail(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_member"))
        ElseIf GridView1.FocusedColumn.Name = "colDeleteButton" Then
            btn_del2.Enabled = True
            btn_save2.Enabled = False
            btn_reset2.Enabled = False
            txt_eventid.Enabled = False
            txt_nip.Enabled = False
            Panel1.Visible = True
            open_conn()
            insert = 0
            edit = 1
            disable_mainview()
            detail(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_member"))
        End If
    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_eventid.EditValueChanged
        Dim row As DataRowView
        row = TryCast(txt_eventid.Properties.GetRowByKeyValue(txt_eventid.EditValue), DataRowView)
        txt_eventname.Text = row.Item("event_name")
        txt_start_date.Value = row.Item("start_date")
        txt_end_date.Value = row.Item("end_date")
    End Sub

    Private Sub btn_upload2_Click(sender As System.Object, e As System.EventArgs) Handles btn_upload2.Click
        open_conn()
        Dim pb As New OpenFileDialog
        If pb.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = pb.FileName
            txt_photo.Image = Image.FromFile(filename)
            txt_temp.Text = filename
        End If
    End Sub

    Private Sub btn_reset_pic2_Click(sender As System.Object, e As System.EventArgs) Handles btn_reset_pic2.Click
        open_conn()
        filename = Application.StartupPath & "\photo\no-image.jpg"
        txt_photo.Image = Image.FromFile(filename)
        txt_temp.Text = filename
        txt_save_path.Text = Application.StartupPath & "\" & txt_memberid.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
    End Sub

    Private Sub txt_nama_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nama.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_posisi_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_posisi.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_region_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_region.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class