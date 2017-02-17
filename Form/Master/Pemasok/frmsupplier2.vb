Imports DevExpress.XtraBars.Alerter

Public Class frmsupplier2
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Dim status_reset_img As Boolean

    Public Sub insert_data()
        open_conn()
        Dim var_status_aktif As Integer
        Dim var_credit_limit As Integer
        Dim flag_credit_limit As Integer
        If CheckBox2.Checked = True Then
            flag_credit_limit = 1
        ElseIf CheckBox2.Checked = False Then
            flag_credit_limit = 0
        End If

        If cbo_pay_method.Text = "Cash" Then
            var_credit_limit = 1
        ElseIf cbo_pay_method.Text = "Credit" Then
            var_credit_limit = 2
        End If
        If chk_aktif.Checked = True Then
            var_status_aktif = 1
        Else
            var_status_aktif = 0
        End If

        filename = Trim(txt_temp.Text)
        Dim FileToSaveAs As String = Trim(txt_save_path.Text)
        Dim rowAccount As DataRowView
        rowAccount = TryCast(cbo_account.Properties.GetRowByKeyValue(cbo_account.EditValue), DataRowView)

        If insert = 1 Then
            Call insert_supplier(Trim(txt_sup_id.Text), Trim(txt_fname.Text), Trim(txt_lname.Text), Trim(txt_address.Text), _
                 Trim(txt_city.Text), Trim(txt_state.Text), Trim(txt_poscode.Text), Trim(txt_country.Text), Trim(txt_phone_1.Text), Trim(txt_phone_2.Text), Trim(txt_phone_3.Text), _
                 Trim(txt_fax.Text), Trim(txt_email.Text), Trim(txt_website.Text), FileToSaveAs, rowAccount.Item("id_account"), Trim(txt_contact.Text), Replace(txt_credit_limit.Text, ",", ""), txt_due_date.Value, var_credit_limit, _
                 username, server_datetime(), server_datetime(), username, var_status_aktif, txt_notes.Text, Replace(txt_balance.Text, ",", ""), flag_credit_limit)
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
            Call update_supplier(Trim(txt_sup_id.Text), Trim(txt_fname.Text), Trim(txt_lname.Text), Trim(txt_address.Text), _
                 Trim(txt_city.Text), Trim(txt_state.Text), Trim(txt_poscode.Text), Trim(txt_country.Text), Trim(txt_phone_1.Text), Trim(txt_phone_2.Text), Trim(txt_phone_3.Text), _
                 Trim(txt_fax.Text), Trim(txt_email.Text), Trim(txt_website.Text), FileToSaveAs, rowAccount.Item("id_account"), Trim(txt_contact.Text), Replace(txt_credit_limit.Text, ",", ""), txt_due_date.Value, var_credit_limit, _
                 username, server_datetime(), server_datetime(), username, var_status_aktif, txt_notes.Text, Replace(txt_balance.Text, ",", ""), flag_credit_limit)
            If param_sukses = True Then
                ' If filename <> "" Then
                'txt_photo.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)

                If System.IO.File.Exists(filename) Then
                    System.IO.File.Copy(filename, FileToSaveAs)
                Else
                    System.IO.File.Copy(Application.StartupPath & "\photo\no-image.jpg", FileToSaveAs)
                End If
                ' End If
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_success, msgbox_update_success)
                alertControl_success.Show(Me, info)
                clean()
            Else
                Dim info As AlertInfo = New AlertInfo(msgtitle_update_failed, msgbox_update_failed)
                alertControl_error.Show(Me, info)
            End If
        End If
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

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        fillComboBox2()
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        fillComboBox1()
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

    Private Sub fillComboBox()
        Dim DT As DataTable
        DT = getComboAccount()

        cbo_account.Properties.DataSource = DT
        cbo_account.Properties.DisplayMember = "account_name"
        cbo_account.Properties.ValueMember = "id_account"
        cbo_account.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbo_account.Properties.View.OptionsView.ShowAutoFilterRow = True

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

    Private Sub frmsupplier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Enabled = True
        ' frmlistcard.Enabled = True
    End Sub

    Private Sub frmsupplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Dim Rows As Integer
        Rows = select_pay_method.Rows.Count - 1
        For i = 0 To Rows
            cbo_pay_method.Items.Add(select_pay_method.Rows(i).Item(1))
        Next
        Call select_control_no("MASTER SUPPLIER", "MASTER")
        txt_sup_id.Text = no_master
        txt_fname.Focus()
        insert = 1
        edit = 0
        cbo_pay_method.Text = "Cash"
        txt_credit_limit.Text = 0
        txt_balance.Text = 0
        If insert = 1 Then
            filename = Replace(Application.StartupPath & "\photo\no-image.jpg", "\", "/")
            txt_photo.Image = Image.FromFile(filename)
        ElseIf edit = 1 Then
            '  filename = ""
        End If
        fillComboBox()
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        open_conn()
        If insert = 1 Then
            If getTemplateAkses(username, "MN_SUPPLIER_ADD") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SUPPLIER_EDIT") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        If cbo_account.EditValue = Nothing Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih akun hutang")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If cbo_pay_method.Text = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih metode pembayaran")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If txt_fname.Text = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Masukkan nama depan")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If Trim(txt_save_path.Text) = "" Then
            Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Pilih direktori folder foto")
            alertControl_warning.Show(Me, info)
            Exit Sub
        End If
        If trial = True Then
            If get_count_data("mst_supplier", "id_supplier") > row_trial Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Batas untuk input versi trial telah habis, silahkan membeli produk ini")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If
        insert_data()
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

    Private Sub txt_address_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_address.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_ap_balance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ap_balance.KeyPress
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

    Private Sub txt_contact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_contact.KeyPress
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

    Private Sub txt_cp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_credit_limit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_credit_limit.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        Else
            e.Handled = onlyNumbers(e.KeyChar)
        End If
    End Sub

    Private Sub txt_due_date_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_due_date.KeyPress
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

    Private Sub txt_sup_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_sup_id.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txt_website_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_website.KeyDown
        'open_conn()
        'If e.KeyCode = Keys.Tab Then
        '    TabControl1.SelectedTab = TabPage2
        '    txt_credit_limit.Focus()
        'End If
    End Sub

    Private Sub txt_website_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_website.KeyPress
        'open_conn()
        'If e.KeyChar = Chr(13) Then
        '    TabControl1.SelectedTab = TabPage2
        '    txt_credit_limit.Focus()
        'End If
    End Sub

    Private Sub clean()
        open_conn()
        status_reset_img = False
        insert = 1
        edit = 0
        With Me
            .txt_save_path.Text = ""
            .CheckBox2.Checked = False
            .txt_credit_limit.Enabled = True
            .txt_address.Text = ""
            .txt_ap_balance.Text = 0
            .txt_city.Text = ""
            .txt_country.Text = ""
            .txt_credit_limit.Text = 0
            Call select_control_no("MASTER SUPPLIER", "MASTER")
            .txt_sup_id.Text = no_master
            .txt_due_date.Value = Now
            .txt_email.Text = ""
            .txt_ap_balance.Text = 0
            .txt_fax.Text = ""
            .txt_fname.Text = ""
            .txt_lname.Text = ""
            .txt_notes.Text = ""
            .txt_contact.Text = ""
            .txt_phone_1.Text = ""
            .txt_phone_2.Text = ""
            .txt_phone_3.Text = ""
            .txt_photo.Image = Nothing
            .txt_poscode.Text = ""
            .txt_state.Text = ""
            .txt_website.Text = ""
            .cbo_pay_method.Text = ""
            .chk_aktif.Checked = False
            '  filename = ""
            cbo_pay_method.Text = "Cash"
            txt_balance.Text = 0
            cbo_account.Text = get_default_hutang()
        End With
        If insert = 1 Then
            filename = Application.StartupPath & "\photo\no-image.jpg"
            txt_photo.Image = Image.FromFile(filename)
        End If
        If get_def_path("Supplier") = "" Then
            txt_save_path.Text = "C:" & "\" & txt_sup_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        Else
            txt_save_path.Text = Replace(get_def_path("Supplier"), "/", "\") & "\" & txt_sup_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        End If
    End Sub

    Private Sub btn_reset2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        clean()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()

        If edit = 1 Then
            If getTemplateAkses(username, "MN_SUPPLIER_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim var_credit_limit As Integer
        var_credit_limit = 1

        Dim rowAccount As DataRowView
        rowAccount = TryCast(cbo_account.Properties.GetRowByKeyValue(cbo_account.EditValue), DataRowView)

        If edit = 1 Then
            pesan = MessageBox.Show("Delete Confirm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pesan = vbYes Then
                Call delete_supplier(Trim(txt_sup_id.Text), Trim(txt_fname.Text), Trim(txt_lname.Text), Trim(txt_address.Text), _
                     Trim(txt_city.Text), Trim(txt_state.Text), Trim(txt_poscode.Text), Trim(txt_country.Text), Trim(txt_phone_1.Text), Trim(txt_phone_2.Text), Trim(txt_phone_3.Text), _
                     Trim(txt_fax.Text), Trim(txt_email.Text), Trim(txt_website.Text), filename, rowAccount.Item("id_account"), Trim(txt_contact.Text), Replace(txt_credit_limit.Text, ",", ""), txt_due_date.Value, var_credit_limit, _
                     username, server_datetime(), server_datetime(), username, 1, txt_notes.Text, Replace(txt_ap_balance.Text, ",", ""))
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

    Private Sub cbo_account_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        open_conn()
        Dim FrmAccount As New frm_display_acc_detail
        FrmAccount.Show()
        FrmAccount.formsource_supplier = True
        '  FrmAccount.MdiParent = MainMenu
        ' MainMenu.Enabled = False
    End Sub

    Private Sub txt_ap_balance_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ap_balance.TextChanged
        open_conn()
        If Not IsNumeric(txt_ap_balance.Text) Then
            txt_ap_balance.Text = ""
        End If
    End Sub

    Private Sub txt_balance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_balance.KeyPress
        open_conn()
        e.Handled = onlyNumbers(e.KeyChar)
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

    Private Sub txt_credit_limit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_credit_limit.LostFocus
        open_conn()
        Dim var_limit As Double
        var_limit = txt_credit_limit.Text
        txt_credit_limit.Text = FormatNumber(var_limit, 0)
        If Trim(txt_credit_limit.Text) = "" Then
            txt_credit_limit.Text = 0
        End If
    End Sub

    Private Sub txt_balance_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_balance.LostFocus
        open_conn()
        Dim var_limit As Double
        var_limit = txt_balance.Text
        txt_balance.Text = FormatNumber(var_limit, 0)
        If Trim(txt_balance.Text) = "" Then
            txt_balance.Text = 0
        End If
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txt_credit_limit.Enabled = False
            txt_credit_limit.Text = 0
        ElseIf CheckBox2.Checked = False Then
            txt_credit_limit.Enabled = True
            txt_credit_limit.Text = 0
        End If
    End Sub

    Private Sub cbo_account_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_account_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cbo_pay_method_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_pay_method.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btn_browse_Click(sender As System.Object, e As System.EventArgs) Handles btn_browse.Click
        open_conn()
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Images Configuration Files Path"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_save_path.Text = dialog.SelectedPath & "\" & txt_sup_id.Text & ".jpg"
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class