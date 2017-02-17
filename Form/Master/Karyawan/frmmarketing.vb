Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports System.Data.OleDb
Imports DevExpress.XtraBars.Alerter
Imports System.IO
Imports DevExpress.XtraBars

Public Class frmmarketing
    Public insert As Integer
    Public edit As Integer
    Dim pesan As String
    Dim status_reset_img As Boolean
    Dim DTExcel As New DataTable
    Dim FilenameExcel As String
    Dim MyConnection As New OleDbConnection
    Dim command_excel As New OleDbCommand
    Dim sqlreader_excel As New OleDbDataAdapter
    Dim importingField As String
    Dim importingValue As String
    Dim rowIndex As Integer
    Dim colIndex As Integer

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
        '    Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Please fill employee grade")
        '    alertControl_warning.Show(Me, info)
        '    Exit Sub
        'End If

        If CheckBox1.Checked = True Then
            var_status_aktif = 0
        Else
            var_status_aktif = 1
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
                If filename <> "" Then
                    txt_photo.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
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

    Private Sub frmmarketing_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmmarketing_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        '  MainMenu.Activate()
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl3.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_employee"))
    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl3.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_employee"))
        End If
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        On Error Resume Next
        Dim DT As DataTable

        insert = 0
        edit = 1
        btn_del2.Enabled = True

        DT = select_master("select_marketing", "id_marketing", criteria, 1, 0, server_datetime(), server_datetime())
        If DT.Rows.Count > 0 Then
            txt_marketing_id.Text = DT.Rows(0).Item(0).ToString
            txt_fname.Text = DT.Rows(0).Item(1).ToString
            txt_lname.Text = DT.Rows(0).Item(2).ToString
            txt_address.Text = DT.Rows(0).Item(3).ToString
            txt_city.Text = DT.Rows(0).Item(4).ToString
            txt_state.Text = DT.Rows(0).Item(5).ToString
            txt_poscode.Text = DT.Rows(0).Item(6).ToString
            txt_country.Text = DT.Rows(0).Item(7).ToString
            txt_phone_1.Text = DT.Rows(0).Item(8).ToString
            txt_phone_2.Text = DT.Rows(0).Item(9).ToString
            txt_phone_3.Text = DT.Rows(0).Item(10).ToString
            txt_fax.Text = DT.Rows(0).Item(11).ToString
            txt_email.Text = DT.Rows(0).Item(12).ToString
            txt_website.Text = DT.Rows(0).Item(13).ToString
            filename = Replace(DT.Rows(0).Item("photo"), "/", "\")
            txt_temp.Text = filename
            If get_def_path("Employee") = "" Then
                txt_save_path.Text = "C:" & "\" & txt_marketing_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
            Else
                txt_save_path.Text = Replace(get_def_path("Employee"), "/", "\") & "\" & txt_marketing_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
            End If
            If DT.Rows(0).Item(14).ToString = "" Then
            Else
                Dim FileToSaveAs As String = Trim(txt_save_path.Text)
                If System.IO.File.Exists(DT.Rows(0).Item("photo")) Then
                    Using fs As New FileStream(DT.Rows(0).Item("photo"), FileMode.Open, FileAccess.Read)
                        txt_photo.Image = Image.FromStream(fs)
                    End Using
                Else
                    filename = Application.StartupPath & "\photo\no-image.jpg"
                    txt_photo.Image = Image.FromFile(filename)
                End If
            End If


            txt_target.Text = DT.Rows(0).Item(15)
            txt_notes.Text = DT.Rows(0).Item(18).ToString
            cbo_account_id.Text = DT.Rows(0).Item(16).ToString
            cbo_grade.Text = DT.Rows(0).Item(17).ToString
            If DT.Rows(0).Item(19) = 1 Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
            cbo_departemen.Text = DT.Rows(0).Item("department_id")
            cbo_jabatan.Text = DT.Rows(0).Item("position_id")

            'filename = ""

        End If
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

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        fillComboBox2()
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        fillComboBox1()
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

        Me.WindowState = FormWindowState.Maximized
        Dim Rows As Integer
        PanelControl1.Visible = False
        Me.MdiParent = MainMenu

        Call select_control_no("MASTER MARKETING", "MASTER")
        txt_marketing_id.Text = no_master
        txt_fname.Focus()
        txt_country.Text = "INDONESIA"
        insert = 1
        edit = 0
        txt_target.Text = 0
        If insert = 1 Then
            filename = Replace(Application.StartupPath & "\photo\no-image.jpg", "\", "/")
            txt_photo.Image = Image.FromFile(filename)
        ElseIf edit = 1 Then
            filename = ""
        End If
        LoadComboBox_Department()
        LoadComboBox_Position()
        cbo_grade.Text = "Senior"
        txt_target.Text = 0
        btn_del2.Enabled = False


        If get_def_path("Employee") = "" Then
            txt_save_path.Text = "C:" & "\" & txt_marketing_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        Else
            txt_save_path.Text = Replace(get_def_path("Employee"), "/", "\") & "\" & txt_marketing_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        End If

        fillComboBox()
        GridList_Customer.OptionsView.ColumnAutoWidth = False
        view_data()
        txt_country.Text = "Indonesia"
    End Sub

    Private Sub view_data()
        Dim dtcust As DataTable
        dtcust = select_master("select_marketing", "Employee ID", "", 2, 0, server_datetime(), server_datetime())

        GridControl.DataSource = dtcust
        GridList_Customer.Columns("id_employee").Caption = "ID Karyawan"
        GridList_Customer.Columns("id_employee").Width = 120
        GridList_Customer.Columns("NAME").Caption = "Nama"
        GridList_Customer.Columns("NAME").Width = 260
        GridList_Customer.Columns("phone").Caption = "Telepon"
        GridList_Customer.Columns("phone").Width = 300
        GridList_Customer.Columns("address").Caption = "Alamat"
        GridList_Customer.Columns("address").Width = 300
        GridList_Customer.Columns("city").Caption = "Kota"
        GridList_Customer.Columns("city").Width = 125
        GridList_Customer.Columns("department_name").Caption = "Departemen"
        GridList_Customer.Columns("department_name").Width = 150
        GridList_Customer.Columns("position_name").Caption = "Posisi"
        GridList_Customer.Columns("position_name").Width = 150
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

    Private Sub txt_phone_3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_phone_3.KeyPress
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
            filename = ""
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
        refresh_data()
        fillComboBox1()
        fillComboBox2()
        btn_del2.Enabled = False
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        open_conn()
        clean()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click, btn_del2.Click
        open_conn()

        If edit = 1 Then
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

    Private Sub btn_reset_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_pic2.Click
        open_conn()
        filename = Application.StartupPath & "\photo\no-image.jpg"
        txt_photo.Image = Image.FromFile(filename)
        txt_temp.Text = filename
        status_reset_img = True
    End Sub

    Private Sub btn_upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_upload2.Click
        open_conn()
        Dim pb As New OpenFileDialog
        If pb.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = pb.FileName
            txt_photo.Image = Image.FromFile(filename)
            txt_temp.Text = filename
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_browse.Click
        open_conn()
        On Error Resume Next
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Images Configuration Files Path"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_save_path.Text = dialog.SelectedPath & "\" & txt_marketing_id.Text & ".jpg"
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        PanelControl3.Visible = False
        enableMain()
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl4.Enabled = True
    End Sub

    Private Sub txt_save_path_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_save_path.TextChanged

    End Sub

    Private Sub txt_marketing_id_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_marketing_id.TextChanged

    End Sub

    Private Sub PanelControl2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl3.Visible = True
        disableMain()
        clean()
    End Sub

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl4.Enabled = False
    End Sub

    Private Sub SimpleButton5_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton5.Click
        ImportControl.Visible = True
        disableMain()
        clean()
    End Sub

    Private Sub SimpleButton8_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton8.Click
        refresh_data()
    End Sub

    Private Sub refresh_data()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            Dim dtcust As DataTable
            dtcust = select_master("select_marketing", "Employee ID", "", 2, 0, server_datetime(), server_datetime())
            GridControl.DataSource = dtcust
            GridView1.RefreshData()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub getFieldMysql()
        Dim DTField As DataTable
        Dim column As New DevExpress.XtraGrid.Columns.GridColumn
        column.VisibleIndex = 0
        DTField = getFieldName("mst_employee")
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

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            For y As Integer = 0 To DTField.Rows.Count - 1
                If DataGridView1.Item(0, i).Value = DTField.Rows(y).Item("Field") Then
                    DataGridView1.Item(1, i).Value = DTField.Rows(y).Item("Field")
                    DataGridView1.Item(2, i).Value = True
                End If
            Next
        Next

    End Sub

    Private Sub getFieldExcel()
        Dim DTField As DataTable
        Dim rootNode As TreeNode
        DTField = MyConnection.GetSchema("Columns", New String() {Nothing, Nothing, cmbsheets.SelectedItem.ToString & "$", Nothing})
        With DataGridView1
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

                    PanelControl5.Visible = True
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

    Private Sub cmbsheets_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbsheets.SelectedIndexChanged
        getFieldExcel()
    End Sub

    Private Sub SimpleButton6_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton6.Click
        ImportControl.Visible = False
        enableMain()
        MyConnection.Close()
    End Sub

    Private Sub SimpleButton7_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton7.Click
        Dim a As Integer
        a = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Item(1, i).Value <> Nothing Or DataGridView1.Item(2, i).Value <> False Then
                a = a + 1
            End If
        Next
        If a = 0 Then
            Dim info As AlertInfo = New AlertInfo("Warning", "Tujuan Field Belum di setting/di pilih")
            alertControl_warning.Show(MainMenu, info)
            Exit Sub
        End If
        generateUploadExcel()
        PanelControl5.Visible = False
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
        For Each nodes As DataGridViewRow In DataGridView1.Rows
            rootKey(a) = ""
            fieldKey(a) = ""
            If DataGridView1.Item(0, b).Value <> Nothing And DataGridView1.Item(1, b).Value <> Nothing And DataGridView1.Item(2, b).Value = True Then
                rootKey(a) = DataGridView1.Item(0, b).Value
                fieldKey(a) = DataGridView1.Item(1, b).Value
                If a > 0 Then
                    Field = Field & "," & rootKey(a)
                    importingField = importingField & "," & fieldKey(a)
                Else
                    Field = rootKey(a)
                    importingField = fieldKey(a)
                End If
                a = a + 1
            End If
            b = b + 1
        Next

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
            For i As Integer = 0 To GridViewUpload.RowCount - 1
                Call select_control_no("MASTER MARKETING", "MASTER")
                id_customer = no_master
                For y As Integer = 0 To GridViewUpload.Columns.Count - 1
                    rootKey(y) = ""
                    rootKey(y) = GridViewUpload.GetRowCellValue(i, GridViewUpload.Columns(y).FieldName).ToString
                    If y > 0 And y < GridViewUpload.Columns.Count - 1 Then
                        importingValue = importingValue & "','" & rootKey(y) & ""
                    ElseIf y = GridViewUpload.Columns.Count - 1 Then
                        importingValue = importingValue & "','" & rootKey(y) & "'"
                    Else
                        importingValue = "'" & rootKey(y) & ""
                    End If
                Next
                Call import_employee("id_employee," & importingField & ",created_user,modified_user,created_date, modified_date,status", "'" & id_customer & "'," & importingValue & ",'" & username & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd hh:mm:ss") & "','" & Format(server_datetime(), "yyyy-MM-dd hh:mm:ss") & "',1")

            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo("Sukses", "Sukses Import Data Karyawan")
                alertControl_success.Show(MainMenu, info)
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

    Private Sub Lookup_field_EditValueChanged(sender As Object, e As System.EventArgs) Handles Lookup_field.EditValueChanged
        DataGridView1.Item(colIndex, rowIndex).Value = Lookup_field.EditValue
        DataGridView1.Item(1, rowIndex).Value = Lookup_field.EditValue
        Lookup_field.Visible = False
    End Sub

    Private Sub DataGridView1_LostFocus(sender As Object, e As System.EventArgs) Handles DataGridView1.LostFocus
        Lookup_field.Visible = False
        Lookup_field.ClosePopup()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        rowIndex = DataGridView1.CurrentCell.RowIndex
        colIndex = DataGridView1.CurrentCell.ColumnIndex
        If colIndex = 1 Then
            Lookup_field.Visible = True
            Lookup_field.Left = DataGridView1.GetCellDisplayRectangle(colIndex, rowIndex, False).Left + DataGridView1.Left
            Lookup_field.Top = DataGridView1.GetCellDisplayRectangle(colIndex, rowIndex, False).Top + DataGridView1.Top
        Else
            Lookup_field.Visible = False
        End If
    End Sub

    Private Sub GridControl_Click(sender As System.Object, e As System.EventArgs) Handles GridControl.Click

    End Sub

    Private Sub PanelControl3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelControl3.Paint

    End Sub

    Private Sub btn_download_cust_Click(sender As System.Object, e As System.EventArgs) Handles btn_download_cust.Click
        Try
            Process.Start(Application.StartupPath & "\download\template_employee.xlsx")
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Informasi", ex.Message)
            alertControl_error.Show(Me, info)
        End Try
    End Sub

    Private Sub PanelControl5_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelControl5.Paint

    End Sub
End Class