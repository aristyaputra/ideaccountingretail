Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm
Imports System.Data.OleDb
Imports DevExpress.XtraBars.Alerter
Imports System.IO
Imports DevExpress.XtraBars

Public Class frmsupplier
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

    Private Sub view_data()
        Dim dtcust As DataTable
        dtcust = select_master("select_supplier", "Supplier ID", "", 2, 0, server_datetime(), server_datetime())
        GridControl.DataSource = dtcust
        GridList_Customer.Columns("id_supplier").Caption = "ID Pemasok"
        GridList_Customer.Columns("id_supplier").Width = 120
        GridList_Customer.Columns("NAME").Caption = "Nama"
        GridList_Customer.Columns("NAME").Width = 260
        GridList_Customer.Columns("phone").Caption = "Telepon"
        GridList_Customer.Columns("phone").Width = 300
        GridList_Customer.Columns("address").Caption = "Alamat"
        GridList_Customer.Columns("address").Width = 380
        GridList_Customer.Columns("city").Caption = "Kota"
        GridList_Customer.Columns("city").Width = 125
    End Sub

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
            var_status_aktif = 0
        Else
            var_status_aktif = 1
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

    Private Sub frmsupplier_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.WindowState = FormWindowState.Maximized
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

    Private Sub getFieldMysql()
        Dim DTField As DataTable
        Dim column As New DevExpress.XtraGrid.Columns.GridColumn
        column.VisibleIndex = 0
        DTField = getFieldName("mst_supplier")
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
                Call select_control_no("MASTER SUPPLIER", "MASTER")
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
                Call import_supplier("id_supplier," & importingField & ",id_account,created_user,modified_user,created_date, modified_date,status", "'" & id_customer & "'," & importingValue & ",'" & get_default_piutang() & "','" & username & "','" & username & "','" & Format(server_datetime(), "yyyy-MM-dd hh:mm:ss") & "','" & Format(server_datetime(), "yyyy-MM-dd hh:mm:ss") & "',1")

            Next
            If param_sukses = True Then
                Dim info As AlertInfo = New AlertInfo("Sukses", "Sukses Import Data Supplier")
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
        PanelControl4.Visible = False
    End Sub

    Private Sub frmsupplier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        close_conn()
        MainMenu.Activate()
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
    End Sub

    Private Sub txt_city_GotFocus(sender As Object, e As System.EventArgs) Handles txt_city.GotFocus
        lookup_kota.Width = txt_city.Width
        lookup_kota.Top = txt_city.Top
        lookup_kota.Left = txt_city.Left
        'fillComboBox2()
        lookup_kota.Visible = True
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

    Private Sub disableMain()
        GridControl.Enabled = False
        PanelControl2.Enabled = False
    End Sub

    Private Sub GridList_Customer_DoubleClick(sender As Object, e As System.EventArgs) Handles GridList_Customer.DoubleClick
        disableMain()
        PanelControl1.Visible = True
        detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_supplier"))
    End Sub

    Private Sub enableMain()
        GridControl.Enabled = True
        PanelControl2.Enabled = True
    End Sub

    Private Sub frmsupplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        open_conn()
        Me.WindowState = FormWindowState.Maximized
        Dim Rows As Integer
        PanelControl1.Visible = False
        Me.MdiParent = MainMenu

        Rows = select_pay_method.Rows.Count - 1
        For i = 0 To Rows
            cbo_pay_method.Items.Add(select_pay_method.Rows(i).Item(1))
        Next
        Call select_control_no("MASTER SUPPLIER", "MASTER")
        txt_sup_id.Text = no_master
        txt_fname.Focus()
        txt_country.Text = "INDONESIA"
        insert = 1
        edit = 0
        cbo_pay_method.Text = "Cash"
        txt_credit_limit.Text = 0
        txt_balance.Text = 0
        If insert = 1 Then
            filename = Replace(Application.StartupPath & "\photo\no-image.jpg", "\", "/")
            txt_photo.Image = Image.FromFile(filename)
        ElseIf edit = 1 Then
            filename = ""
        End If
        cbo_account.Text = get_default_hutang()
        txt_ap_balance.Text = 0
        btn_del2.Enabled = False
        If get_def_path("Supplier") = "" Then
            txt_save_path.Text = "C:" & "\" & txt_sup_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        Else
            txt_save_path.Text = Replace(get_def_path("Supplier"), "/", "\") & "\" & txt_sup_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
        End If
        CheckBox2.Checked = True
        fillComboBox()
        GridList_Customer.OptionsView.ColumnAutoWidth = False
        view_data()

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

        If cbo_account.Text = "" Then
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

    Private Sub txt_due_date_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txt_sup_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_sup_id.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub clean()
        open_conn()
        status_reset_img = False
        insert = 1
        edit = 0
        With Me
            ' .txt_save_path.Text = ""
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
            filename = ""
            cbo_account.Text = get_default_hutang()
            cbo_pay_method.Text = "Cash"
            txt_balance.Text = 0
            If insert = 1 Then
                filename = Application.StartupPath & "\photo\no-image.jpg"
                txt_photo.Image = Image.FromFile(filename)
            End If
            If get_def_path("Supplier") = "" Then
                txt_save_path.Text = "C:" & "\" & txt_sup_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
            Else
                txt_save_path.Text = Replace(get_def_path("Supplier"), "/", "\") & "\" & txt_sup_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
            End If
        End With
        view_data()
        fillComboBox1()
        fillComboBox2()
        btn_del2.Enabled = False
    End Sub

    Private Sub detail(ByVal criteria As String)
        open_conn()
        On Error Resume Next
        Dim DT As DataTable

        insert = 0
        edit = 1
        btn_del2.Enabled = True
        DT = select_master("select_supplier", "id_supplier", criteria, 1, 0, server_datetime(), server_datetime())
        If DT.Rows.Count > 0 Then
            txt_sup_id.Text = DT.Rows(0).Item(0).ToString
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
            If get_def_path("Supplier") = "" Then
                txt_save_path.Text = "C:" & "\" & txt_sup_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
            Else
                txt_save_path.Text = Replace(get_def_path("Supplier"), "/", "\") & "\" & txt_sup_id.Text & Format(server_datetime(), "dd") & Format(server_datetime(), "MM") & Format(server_datetime(), "yyyy") & Format(server_datetime(), "ss") & ".jpg"
            End If

            If DT.Rows(0).Item("flag_credit_limit") = 0 Then
                CheckBox2.Checked = False
            ElseIf DT.Rows(0).Item("flag_credit_limit") = 1 Then
                CheckBox2.Checked = True
            End If
            txt_balance.Text = FormatNumber(DT.Rows(0).Item("ap_balance"), 0)
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

            txt_notes.Text = DT.Rows(0).Item(16).ToString
            cbo_account.EditValue = DT.Rows(0).Item(15).ToString
            txt_contact.Text = DT.Rows(0).Item(17).ToString
            txt_credit_limit.Text = FormatNumber(DT.Rows(0).Item(18), 0)
            txt_due_date.Value = DT.Rows(0).Item(19)
            If DT.Rows(0).Item(20) = 1 Then
                cbo_pay_method.Text = "Cash"
            Else
                cbo_pay_method.Text = "Credit"
            End If

            If DT.Rows(0).Item(21) = 1 Then
                chk_aktif.Checked = True
            Else
                chk_aktif.Checked = False
            End If

            ' filename = ""

        End If
    End Sub

    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset2.Click
        clean()
    End Sub

    Private Sub btn_del2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del2.Click
        open_conn()
        Dim rowAccount As DataRowView
        rowAccount = TryCast(cbo_account.Properties.GetRowByKeyValue(cbo_account.EditValue), DataRowView)
        If edit = 1 Then
            If getTemplateAkses(username, "MN_SUPPLIER_DELETE") <> True Then
                Dim info As AlertInfo = New AlertInfo("Cek Kevaliditasan Data", "Anda tidak memiliki hak akses")
                alertControl_warning.Show(Me, info)
                Exit Sub
            End If
        End If

        Dim var_credit_limit As Integer
        var_credit_limit = 1

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
        Me.Enabled = False
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

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

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

    Private Sub cbo_account_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbo_account_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

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

    Private Sub cbo_pay_method_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_pay_method.KeyPress
        open_conn()
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_browse.Click
        On Error Resume Next
        open_conn()
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select Images Configuration Files Path"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_save_path.Text = dialog.SelectedPath & "\" & txt_sup_id.Text & ".jpg"
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btn_keluar.Click
        PanelControl1.Visible = False
        enableMain()
    End Sub

    Private Sub GroupControl2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupControl2.Paint

    End Sub

    Private Sub GridList_Customer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridList_Customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            disableMain()
            PanelControl1.Visible = True
            detail(GridList_Customer.GetRowCellValue(GridList_Customer.FocusedRowHandle, "id_customer"))
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        PanelControl1.Visible = True
        disableMain()
        clean()
    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton5_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton5.Click
        ImportControl.Visible = True
        disableMain()
        clean()
    End Sub

    Private Sub SimpleButton6_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton6.Click
        ImportControl.Visible = False
        enableMain()
        MyConnection.Close()
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

    Private Sub Lookup_field_EditValueChanged(sender As Object, e As System.EventArgs) Handles Lookup_field.EditValueChanged
        DataGridView1.Item(colIndex, rowIndex).Value = Lookup_field.EditValue
        DataGridView1.Item(1, rowIndex).Value = Lookup_field.EditValue
        Lookup_field.Visible = False
    End Sub

    Private Sub DataGridView1_LostFocus(sender As Object, e As System.EventArgs) Handles DataGridView1.LostFocus
        Lookup_field.Visible = False
        Lookup_field.ClosePopup()
    End Sub

    Private Sub SimpleButton8_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton8.Click
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            SplashScreenManager.Default.SetWaitFormCaption("Please Wait")
            SplashScreenManager.Default.SetWaitFormDescription("Refresh Data . . .")
            Dim dtcust As DataTable
            dtcust = select_master("select_supplier", "Supplier ID", "", 2, 0, server_datetime(), server_datetime())
            GridControl.DataSource = dtcust
            GridView1.RefreshData()
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
        
    End Sub

   
    Private Sub cmbsheets_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbsheets.SelectedIndexChanged
        getFieldExcel()
    End Sub

    Private Sub GridControl_Click(sender As System.Object, e As System.EventArgs) Handles GridControl.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PanelControl4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelControl4.Paint

    End Sub

    Private Sub btn_download_cust_Click(sender As System.Object, e As System.EventArgs) Handles btn_download_cust.Click
        Try
            Process.Start(Application.StartupPath & "\download\template_supplier.xlsx")
        Catch ex As Exception
            Dim info As AlertInfo = New AlertInfo("Informasi", ex.Message)
            alertControl_error.Show(Me, info)
        End Try
    End Sub

    Private Sub PanelControl2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelControl2.Paint

    End Sub
End Class