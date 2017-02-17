Imports DevExpress.XtraBars.Alerter

Public Class frmmarketing2
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Dim status_reset_img As Boolean

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_EMPLOYEE_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_EMPLOYEE_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        'If Trim(cbo_grade.Text) = "" Then
        '    pesan = MsgBox("Please fill employee grade", MsgBoxStyle.Information, "Validation")
        '    Exit Sub
        'End If
        If Trim(cbo_departemen.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih departemen")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(cbo_jabatan.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih Posisi")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(txt_fname.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih nama depan")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(txt_save_path.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih direktori folder foto")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If trial = True Then
            If get_count_data("mst_employee", "id_employee") > row_trial Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Batas untuk input versi trial telah habis, silahkan membeli produk ini")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        insert_data()
    End Sub

    Public Sub insert_data()
        open_conn()
        Dim var_status_aktif As Integer

        'If Trim(cbo_grade.Text) = "" Then
        '    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Fill Employee Grade")
        '    alertControl_warning.Show(Me, info)
        '    Exit Sub
        'End If
        If Trim(cbo_departemen.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih departemen")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(cbo_jabatan.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih posisi")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(txt_fname.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih nama depan")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If CheckBox1.Checked = True Then
            var_status_aktif = 1
        Else
            var_status_aktif = 0
        End If

        filename = Trim(txt_temp.Text)
        Dim FileToSaveAs As String = Trim(txt_save_path.Text)


        If insert = 1 Then
            Call insert_marketing(Trim(txt_marketing_id.Text), Trim(txt_fname.Text), Trim(txt_lname.Text), Trim(txt_address.Text), _
                 Trim(txt_city.Text), Trim(txt_state.Text), Trim(txt_poscode.Text), Trim(txt_country.Text), Trim(txt_phone_1.Text), Trim(txt_phone_2.Text), Trim(txt_phone_3.Text), _
                 Trim(txt_fax.Text), Trim(txt_email.Text), Trim(txt_website.Text), FileToSaveAs, txt_target.Text, Trim(cbo_account_id.Text), _
                 username, server_datetime(), server_datetime(), username, var_status_aktif, txt_notes.Text, cbo_grade.Text, cbo_jabatan.Text, cbo_departemen.Text)
            If param_sukses = True Then
                If filename <> "" Then
                    txt_photo.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
                Dim info As AlertInfo = New AlertInfo(msgtitle_save_success, msgbox_save_success)
                alertControl_success.Show(Me, info)
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
            Call update_marketing(Trim(txt_marketing_id.Text), Trim(txt_fname.Text), Trim(txt_lname.Text), Trim(txt_address.Text), _
                 Trim(txt_city.Text), Trim(txt_state.Text), Trim(txt_poscode.Text), Trim(txt_country.Text), Trim(txt_phone_1.Text), Trim(txt_phone_2.Text), Trim(txt_phone_3.Text), _
                 Trim(txt_fax.Text), Trim(txt_email.Text), Trim(txt_website.Text), FileToSaveAs, txt_target.Text, Trim(cbo_account_id.Text), _
                 username, server_datetime(), server_datetime(), username, var_status_aktif, txt_notes.Text, cbo_grade.Text, cbo_jabatan.Text, cbo_departemen.Text)
            If param_sukses = True Then
                'If filename <> "" Then
                'txt_photo.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
                If System.IO.File.Exists(filename) Then
                    System.IO.File.Copy(filename, FileToSaveAs)
                Else
                    System.IO.File.Copy(Application.StartupPath & "\photo\no-image.jpg", FileToSaveAs)
                End If
                'End If
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
    End Sub

    Private Sub txt_photo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_photo.Click

    End Sub

    Private Sub txt_photo_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_photo.MouseHover
        open_conn()
        Cursor = Cursors.Hand
    End Sub

    Private Sub txt_photo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_photo.MouseLeave
        open_conn()
        Cursor = Cursors.Arrow
    End Sub

    Private Sub frmmarketing_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Enabled = True
        ' frmlistcard.Enabled = True
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        fillComboBox2()
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        fillComboBox1()
    End Sub

    Private Sub fillComboBox()

        lookup_state.Properties.DataSource = getComboStateAll()
        lookup_state.Properties.DisplayMember = "state_name"
        lookup_state.Properties.ValueMember = "state_code"
        lookup_state.Properties.PopulateViewColumns()
        lookup_state.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lookup_state.Properties.View.OptionsView.ShowAutoFilterRow = True
        lookup_state.Properties.View.Columns("state_code").Caption = "Kode"
        lookup_state.Properties.View.Columns("state_name").Caption = "Propinsi"

        lookup_kota.Properties.DataSource = getComboCityAll()
        lookup_kota.Properties.DisplayMember = "city_name"
        lookup_kota.Properties.ValueMember = "city_code"
        lookup_kota.Properties.PopulateViewColumns()
        lookup_kota.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lookup_kota.Properties.View.OptionsView.ShowAutoFilterRow = True
        lookup_kota.Properties.View.Columns("city_code").Caption = "Kode"
        lookup_kota.Properties.View.Columns("city_name").Caption = "Kota"
    End Sub

    Private Sub fillComboBox1()
        lookup_state.Properties.DataSource = getComboStateAll()
        lookup_state.Properties.DisplayMember = "state_name"
        lookup_state.Properties.ValueMember = "state_code"
        lookup_state.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lookup_state.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub fillComboBox2()
        lookup_kota.Properties.DataSource = getComboCityAll()
        lookup_kota.Properties.DisplayMember = "city_name"
        lookup_kota.Properties.ValueMember = "city_code"
        lookup_kota.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lookup_kota.Properties.View.OptionsView.ShowAutoFilterRow = True
    End Sub

    Private Sub lookup_kota_EditValueChanged(sender As Object, e As System.EventArgs) Handles lookup_kota.EditValueChanged
        Dim row As DataRowView
        row = TryCast(lookup_kota.Properties.GetRowByKeyValue(lookup_kota.EditValue), DataRowView)
        txt_city.Text = row.Item("city_name")
        lookup_state.Properties.DataSource = getComboState(row.Item("city_code"))
        lookup_state.Properties.DisplayMember = "state_name"
        lookup_state.Properties.ValueMember = "state_code"
        lookup_state.Properties.PopulateViewColumns()
        lookup_state.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lookup_state.Properties.View.OptionsView.ShowAutoFilterRow = True
        lookup_kota.Visible = False
    End Sub

    Private Sub lookup_state_EditValueChanged(sender As Object, e As System.EventArgs) Handles lookup_state.EditValueChanged
        Dim row As DataRowView
        row = TryCast(lookup_state.Properties.GetRowByKeyValue(lookup_state.EditValue), DataRowView)
        txt_state.Text = row.Item("state_name")
        lookup_kota.Properties.DataSource = getComboCity(row.Item("state_code"))
        lookup_kota.Properties.DisplayMember = "city_name"
        lookup_kota.Properties.ValueMember = "city_code"
        lookup_kota.Properties.PopulateViewColumns()
        lookup_kota.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lookup_kota.Properties.View.OptionsView.ShowAutoFilterRow = True
        lookup_state.Visible = False
    End Sub

    Private Sub txt_city_GotFocus(sender As Object, e As System.EventArgs) Handles txt_city.GotFocus
        lookup_kota.Width = txt_city.Width
        lookup_kota.Top = txt_city.Top
        lookup_kota.Left = txt_city.Left
        'fillComboBox2()
        lookup_kota.Visible = True
    End Sub

    Private Sub txt_state_GotFocus(sender As Object, e As System.EventArgs) Handles txt_state.GotFocus
        lookup_state.Width = txt_state.Width
        lookup_state.Top = txt_state.Top
        lookup_state.Left = txt_state.Left
        'fillComboBox1()
        lookup_state.Visible = True
        lookup_state.BringToFront()
    End Sub

    Private Sub frmcustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Call select_control_no("MASTER MARKETING", "MASTER")
        txt_marketing_id.Text = no_master
        txt_fname.Focus()
        insert = 1
        edit = 0
        txt_target.Text = 0
        If insert = 1 Then
            filename = Replace(Application.StartupPath & "\photo\no-image.jpg", "\", "/")
            txt_photo.Image = Image.FromFile(filename)
        ElseIf edit = 1 Then
            '    filename = ""
        End If
        LoadComboBox_Department()
        LoadComboBox_Position()
        cbo_grade.Text = "Senior"
        txt_target.Text = 0
        btn_del2.Enabled = True
        fillComboBox()
    End Sub

    Private Sub LoadComboBox_Department()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_list_depart()

        cbo_departemen.SelectedIndex = -1
        cbo_departemen.Items.Clear()
        cbo_departemen.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_departemen.SourceDataString = New String(1) {"department_id", "department_name"}
        cbo_departemen.SourceDataTable = dtLoading
        cbo_departemen.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList

    End Sub

    Private Sub LoadComboBox_Position()
        open_conn()
        Dim dtLoading As New DataTable("UsStates")
        dtLoading = select_list_position()

        cbo_jabatan.SelectedIndex = -1
        cbo_jabatan.Items.Clear()
        cbo_jabatan.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_jabatan.SourceDataString = New String(1) {"position_id", "position_name"}
        cbo_jabatan.SourceDataTable = dtLoading
        cbo_jabatan.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub txt_address_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_address.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_balance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_balance.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txt_city_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_city.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_country_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_country.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_email_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_email.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_fax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_fax.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub txt_fname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_fname.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_lname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lname.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_marketing_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_marketing_id.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_notes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_notes.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_phone_1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_phone_1.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub txt_phone_2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_phone_2.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub txt_phone_3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub txt_poscode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_poscode.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub txt_state_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_state.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_target_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_target.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub txt_website_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_website.KeyDown
        'open_conn()
        'If e.KeyCode = Keys.Tab Then
        '    TabControl1.SelectedTab = TabPage2
        '    cbo_jabatan.Focus()
        'End If
    End Sub

    Private Sub txt_website_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_website.KeyPress
        'open_conn()
        'If e.KeyChar = Chr(13) Then
        '    TabControl1.SelectedTab = TabPage2
        '    cbo_jabatan.Focus()
        'End If
    End Sub

    Private Sub clean()
        open_conn()
        status_reset_img = False
        insert = 1
        edit = 0
        With Me
            .txt_save_path.Text = ""
            .txt_address.Text = ""
            .txt_balance.Text = 0
            .txt_country.Text = ""
            .txt_city.Text = ""
            Call select_control_no("MASTER MARKETING", "MASTER")
            .txt_marketing_id.Text = no_master
            .txt_email.Text = ""
            .txt_fax.Text = ""
            .txt_fname.Text = ""
            .txt_lname.Text = ""
            .txt_notes.Text = ""
            .txt_phone_1.Text = ""
            .txt_phone_2.Text = ""
            .txt_phone_3.Text = ""
            .txt_photo.Image = Nothing
            .txt_poscode.Text = ""
            .txt_state.Text = ""
            .txt_website.Text = ""
            .cbo_account_id.Text = ""
            .CheckBox1.Checked = False
            .cbo_grade.Text = ""
            ' filename = ""
            .cbo_departemen.Text = ""
            .cbo_jabatan.Text = ""
            .btn_del2.Enabled = False

        End With
        If insert = 1 Then
            filename = Application.StartupPath & "\photo\no-image.jpg"
            txt_photo.Image = Image.FromFile(filename)
        End If
        If get_def_path("Employee") = "" Then
            txt_save_path.Text = "C:" & "\" & txt_marketing_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        Else
            txt_save_path.Text = Replace(get_def_path("Employee"), "/", "\") & "\" & txt_marketing_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        End If
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_EMPLOYEE_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If


        If edit = 1 Then
            pesan = MessageBox.Show("Delete Confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_marketing(Trim(txt_marketing_id.Text), Trim(txt_fname.Text), Trim(txt_lname.Text), Trim(txt_address.Text), _
                 Trim(txt_city.Text), Trim(txt_state.Text), Trim(txt_poscode.Text), Trim(txt_country.Text), Trim(txt_phone_1.Text), Trim(txt_phone_2.Text), Trim(txt_phone_3.Text), _
                 Trim(txt_fax.Text), Trim(txt_email.Text), Trim(txt_website.Text), "", txt_target.Text, Trim(cbo_account_id.Text), _
                 username, server_datetime(), server_datetime(), username, 1, txt_notes.Text, cbo_grade.Text, cbo_jabatan.Text, cbo_departemen.Text)
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

    Private Sub cbo_account_id_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_account_id.Click
        open_conn()
        Dim FrmAccount As New frm_display_acc_detail
        FrmAccount.Show()
        FrmAccount.formsource_marketing = True
        ' FrmAccount.MdiParent = MainMenu
        ' MainMenu.Enabled = False
    End Sub

    Private Sub btn_reset_pic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_pic2.Click
        open_conn()
        filename = Application.StartupPath & "\photo\no-image.jpg"
        txt_photo.Image = Image.FromFile(filename)
        txt_temp.Text = filename
        status_reset_img = True

    End Sub

    Private Sub btn_upload2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_upload2.Click
        open_conn()
        Dim pb As New OpenFileDialog
        If pb.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = pb.FileName
            txt_photo.Image = Image.FromFile(filename)
            txt_temp.Text = filename
        End If
    End Sub

    Private Sub btn_browse_Click(sender As System.Object, e As System.EventArgs) Handles btn_browse.Click
        open_conn()
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Images Configuration Files Path"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_save_path.Text = dialog.SelectedPath & "\" & txt_marketing_id.Text & ".jpg"
        End If
    End Sub

    Private Sub NavBarControl3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class