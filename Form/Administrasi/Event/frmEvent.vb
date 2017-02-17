Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm

Public Class frmEvent

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

    End Sub

    Private Sub clean()
        open_conn()
        insert = 1
        edit = 0
        txt_pic.Text = ""
        txt_eventname.Text = ""
        txt_eventid.Text = getKodeEvent()
        btn_del2.Enabled = False
        txt_eventid.Enabled = False
        txt_eventid.BackColor = Color.Lavender
        txt_eventid.ReadOnly = False
        btn_del2.Enabled = False
        btn_save2.Enabled = True
        btn_reset2.Enabled = True
    End Sub

    Public Sub insert_data()
        open_conn()
        If insert = 1 Then
            Call insert_event(Trim(txt_eventid.Text), Trim(txt_eventname.Text), Format(txt_start_date.Value, "yyyy-MM-dd hh:mm:ss"), Format(txt_end_date.Value, "yyyy-MM-dd hh:mm:ss"), Trim(txt_pic.Text), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, username, "INSERT")
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
                update_no_trans(server_datetime(), "MASTER_EVENT")
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_failed, msgbox_save_failed)
                alertControl_error.Show(Me, info)
            End If
        ElseIf edit = 1 Then
            Call update_event(Trim(txt_eventid.Text), Trim(txt_eventname.Text), Format(txt_start_date.Value, "yyyy-MM-dd hh:mm:ss"), Format(txt_end_date.Value, "yyyy-MM-dd hh:mm:ss"), Trim(txt_pic.Text), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, username, "UPDATE")
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
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
            Call insert_no_trans("MASTER_EVENT", var_bulan, var_tahun)
            Call select_control_no("MASTER_EVENT", "TRANS")
            Return no_master
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If Trim(txt_pic.Text) = "" Then
            txt_pic.Text = 0
        End If
        If insert = 1 Then
            If getTemplateAkses(username, "MN_EVENT_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_EVENT_EDIT") <> True Then
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
            If getTemplateAkses(username, "MN_EVENT_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data Hak Akses", "Anda tidak memiliki hak akses!")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            pesan = MessageBox.Show("Data Event Akan di hapus?", "Hapus Data", MessageBoxButtons.YesNo)
            If pesan = vbYes Then
                Call delete_event(Trim(txt_eventid.Text), Trim(txt_eventname.Text), Format(txt_start_date.Value, "yyyy-MM-dd hh:mm:ss"), Format(txt_end_date.Value, "yyyy-MM-dd hh:mm:ss"), Trim(txt_pic.Text), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), Format(server_datetime(), "yyyy-MM-dd hh:mm:ss"), username, username, "DELETE")
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
        DT = select_event()
        GridControl1.DataSource = DT
    End Sub

    Private Sub datagridLayout()
        With GridView1
            .Columns("created_date").Visible = False
            .Columns("modified_date").Visible = False
            .Columns("created_user").Visible = False
            .Columns("modified_user").Visible = False
            .Columns("id_event").Caption = "KODE EVENT"
            .Columns("event_name").Caption = "NAMA EVENT"
            .Columns("start_date").Caption = "TGL MULAI"
            .Columns("end_date").Caption = "TGL SELESAI"
            .Columns("pic").Caption = "PIC"
            .Columns("event_name").FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            .Columns("id_event").OptionsColumn.AllowEdit = False
            .Columns("event_name").OptionsColumn.AllowEdit = False
            .Columns("start_date").OptionsColumn.AllowEdit = False
            .Columns("end_date").OptionsColumn.AllowEdit = False
            .Columns("pic").OptionsColumn.AllowEdit = False
            .Columns("id_event").OptionsFilter.AllowFilter = True
            .Columns("event_name").OptionsFilter.AllowFilter = True
            .Columns("start_date").OptionsFilter.AllowFilter = True
            .Columns("end_date").OptionsFilter.AllowFilter = True
            .Columns("ViewButton").OptionsFilter.AllowFilter = False
            .Columns("EditButton").OptionsFilter.AllowFilter = False
            .Columns("DeleteButton").OptionsFilter.AllowFilter = False
            .Columns("pic").OptionsFilter.AllowFilter = True
            .Columns("id_event").OptionsFilter.AllowAutoFilter = True
            .Columns("event_name").OptionsFilter.AllowAutoFilter = True
            .Columns("start_date").OptionsFilter.AllowAutoFilter = True
            .Columns("end_date").OptionsFilter.AllowAutoFilter = True
            .Columns("pic").OptionsFilter.AllowAutoFilter = True
            .Columns("ViewButton").OptionsFilter.AllowAutoFilter = False
            .Columns("EditButton").OptionsFilter.AllowAutoFilter = False
            .Columns("DeleteButton").OptionsFilter.AllowAutoFilter = False
            .Columns("ViewButton").Width = 100
            .Columns("EditButton").Width = 100
            .Columns("DeleteButton").Width = 100
            .Columns("id_event").BestFit()
            .Columns("event_name").BestFit()
            .Columns("start_date").BestFit()
            .Columns("end_date").BestFit()
            .Columns("pic").BestFit()
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
        DT = detail_event(criteria)
        txt_eventid.Text = DT.Rows(0).Item("id_event")
        txt_eventname.Text = DT.Rows(0).Item("event_name")
        txt_start_date.Value = DT.Rows(0).Item("start_date")
        txt_end_date.Value = DT.Rows(0).Item("end_date")
        txt_pic.Text = DT.Rows(0).Item("pic")
    End Sub

    Private Sub txtkode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_eventid.KeyPress
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
    End Sub

    Private Sub disable_mainview()
        txt_eventid.Text = Trim(getKodeEvent())
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
            Panel1.Visible = True
            open_conn()
            insert = 0
            edit = 1
            disable_mainview()
            detail(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_event"))
        ElseIf GridView1.FocusedColumn.Name = "colEditButton" Then
            btn_del2.Enabled = False
            btn_save2.Enabled = True
            btn_reset2.Enabled = False
            txt_eventid.Enabled = False
            Panel1.Visible = True
            open_conn()
            insert = 0
            edit = 1
            disable_mainview()
            detail(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_event"))
        ElseIf GridView1.FocusedColumn.Name = "colDeleteButton" Then
            btn_del2.Enabled = True
            btn_save2.Enabled = False
            btn_reset2.Enabled = False
            txt_eventid.Enabled = False
            Panel1.Visible = True
            open_conn()
            insert = 0
            edit = 1
            disable_mainview()
            detail(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "id_event"))
        End If
    End Sub
End Class