<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmekspedisi
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmekspedisi))
        Me.chk_code = New System.Windows.Forms.CheckBox()
        Me.txt_serviceid = New System.Windows.Forms.TextBox()
        Me.txt_servicenm = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.txt_from_kota = New System.Windows.Forms.TextBox()
        Me.txt_to_kota = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tglakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tglawal = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colfromcity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltocity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Lookup_Kota2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lookup_kota1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabInput = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_junior_comm = New System.Windows.Forms.TextBox()
        Me.txt_senior_comm = New System.Windows.Forms.TextBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabList = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_reset_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cari_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reset2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridList_Customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_browse = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_save_path = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lookup_state = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_kecamatan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_state = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_acc = New System.Windows.Forms.ComboBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout
        Me.GroupBox3.SuspendLayout
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Lookup_Kota2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lookup_kota1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TabControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabControl1.SuspendLayout
        Me.TabInput.SuspendLayout
        Me.Panel3.SuspendLayout
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl2.SuspendLayout
        Me.TabList.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.GroupControl4,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl4.SuspendLayout
        CType(Me.PanelControl5,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl5.SuspendLayout
        CType(Me.GridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridList_Customer,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PanelControl3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl3.SuspendLayout
        CType(Me.GroupControl5,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl5.SuspendLayout
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.lookup_state.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'chk_code
        '
        Me.chk_code.AutoSize = true
        Me.chk_code.BackColor = System.Drawing.Color.Transparent
        Me.chk_code.Checked = true
        Me.chk_code.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_code.Location = New System.Drawing.Point(171, 58)
        Me.chk_code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_code.Name = "chk_code"
        Me.chk_code.Size = New System.Drawing.Size(100, 22)
        Me.chk_code.TabIndex = 12
        Me.chk_code.Text = "Manual Kode"
        Me.chk_code.UseVisualStyleBackColor = false
        '
        'txt_serviceid
        '
        Me.txt_serviceid.BackColor = System.Drawing.Color.Lavender
        Me.txt_serviceid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_serviceid.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_serviceid.Location = New System.Drawing.Point(169, 30)
        Me.txt_serviceid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_serviceid.Name = "txt_serviceid"
        Me.txt_serviceid.ReadOnly = true
        Me.txt_serviceid.Size = New System.Drawing.Size(457, 23)
        Me.txt_serviceid.TabIndex = 0
        '
        'txt_servicenm
        '
        Me.txt_servicenm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_servicenm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_servicenm.Location = New System.Drawing.Point(169, 86)
        Me.txt_servicenm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_servicenm.Name = "txt_servicenm"
        Me.txt_servicenm.Size = New System.Drawing.Size(457, 23)
        Me.txt_servicenm.TabIndex = 1
        '
        'txt_price
        '
        Me.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_price.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_price.Location = New System.Drawing.Point(169, 251)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(457, 23)
        Me.txt_price.TabIndex = 5
        '
        'txt_notes
        '
        Me.txt_notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_notes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_notes.Location = New System.Drawing.Point(169, 280)
        Me.txt_notes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_notes.Multiline = true
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Size = New System.Drawing.Size(457, 88)
        Me.txt_notes.TabIndex = 60
        '
        'txt_qty
        '
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_qty.Location = New System.Drawing.Point(169, 223)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(457, 23)
        Me.txt_qty.TabIndex = 6
        '
        'txt_from_kota
        '
        Me.txt_from_kota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_from_kota.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_from_kota.Location = New System.Drawing.Point(171, 114)
        Me.txt_from_kota.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_from_kota.Name = "txt_from_kota"
        Me.txt_from_kota.Size = New System.Drawing.Size(455, 23)
        Me.txt_from_kota.TabIndex = 2
        '
        'txt_to_kota
        '
        Me.txt_to_kota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_to_kota.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_to_kota.Location = New System.Drawing.Point(171, 142)
        Me.txt_to_kota.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_to_kota.Name = "txt_to_kota"
        Me.txt_to_kota.Size = New System.Drawing.Size(422, 23)
        Me.txt_to_kota.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.btn_simpan)
        Me.Panel1.Controls.Add(Me.btn_help)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_reset)
        Me.Panel1.Location = New System.Drawing.Point(-2, -580)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 59)
        Me.Panel1.TabIndex = 59
        Me.Panel1.Visible = false
        '
        'btn_simpan
        '
        Me.btn_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_simpan.BackColor = System.Drawing.Color.DimGray
        Me.btn_simpan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.Gold
        Me.btn_simpan.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x161
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(746, 5)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(76, 49)
        Me.btn_simpan.TabIndex = 49
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_simpan.UseVisualStyleBackColor = false
        '
        'btn_help
        '
        Me.btn_help.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btn_help.BackColor = System.Drawing.Color.DimGray
        Me.btn_help.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_help.ForeColor = System.Drawing.Color.Gold
        Me.btn_help.Image = Global.SMARTACCOUNTING.My.Resources.Resources.information_button
        Me.btn_help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_help.Location = New System.Drawing.Point(5, 5)
        Me.btn_help.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(65, 49)
        Me.btn_help.TabIndex = 50
        Me.btn_help.Text = "Info"
        Me.btn_help.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_help.UseVisualStyleBackColor = false
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_delete.BackColor = System.Drawing.Color.DimGray
        Me.btn_delete.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Gold
        Me.btn_delete.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Delete_16x16
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(665, 5)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 49)
        Me.btn_delete.TabIndex = 52
        Me.btn_delete.Text = "Hapus"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.UseVisualStyleBackColor = false
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_reset.BackColor = System.Drawing.Color.DimGray
        Me.btn_reset.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.Gold
        Me.btn_reset.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(584, 5)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(75, 49)
        Me.btn_reset.TabIndex = 51
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reset.UseVisualStyleBackColor = false
        '
        'Label28
        '
        Me.Label28.AutoSize = true
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(15, 27)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 18)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Cari Berdasarkan"
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_search.Location = New System.Drawing.Point(18, 102)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Multiline = true
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(155, 62)
        Me.txt_search.TabIndex = 23
        '
        'Label27
        '
        Me.Label27.AutoSize = true
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(15, 81)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 18)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "Teks Pencarian"
        '
        'cbo_search
        '
        Me.cbo_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_search.FormattingEnabled = true
        Me.cbo_search.Items.AddRange(New Object() {"ID Ekspedisi", "Nama Ekspedisi"})
        Me.cbo_search.Location = New System.Drawing.Point(18, 48)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(155, 26)
        Me.cbo_search.TabIndex = 19
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chk_date)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.tglakhir)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.tglawal)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 171)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(160, 173)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Filter Tanggal"
        '
        'chk_date
        '
        Me.chk_date.AutoSize = true
        Me.chk_date.Location = New System.Drawing.Point(23, 29)
        Me.chk_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(123, 22)
        Me.chk_date.TabIndex = 40
        Me.chk_date.Text = "Batasan Tanggal"
        Me.chk_date.UseVisualStyleBackColor = true
        '
        'Label25
        '
        Me.Label25.AutoSize = true
        Me.Label25.Location = New System.Drawing.Point(20, 113)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 18)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Sampai"
        '
        'tglakhir
        '
        Me.tglakhir.CustomFormat = "dd-MM-yyyy"
        Me.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglakhir.Location = New System.Drawing.Point(23, 134)
        Me.tglakhir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(111, 23)
        Me.tglakhir.TabIndex = 36
        '
        'Label26
        '
        Me.Label26.AutoSize = true
        Me.Label26.Location = New System.Drawing.Point(20, 60)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 18)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Dari"
        '
        'tglawal
        '
        Me.tglawal.CustomFormat = "dd-MM-yyyy"
        Me.tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglawal.Location = New System.Drawing.Point(23, 82)
        Me.tglawal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglawal.Name = "tglawal"
        Me.tglawal.Size = New System.Drawing.Size(111, 23)
        Me.tglawal.TabIndex = 34
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = false
        Me.DataGridView2.AllowUserToDeleteRows = false
        Me.DataGridView2.AllowUserToOrderColumns = true
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colid, Me.colsupplier, Me.colfromcity, Me.coltocity, Me.coldate, Me.qty})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55,Byte),Integer), CType(CType(58,Byte),Integer), CType(CType(61,Byte),Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Location = New System.Drawing.Point(198, 6)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = true
        Me.DataGridView2.RowHeadersVisible = false
        Me.DataGridView2.Size = New System.Drawing.Size(109, 482)
        Me.DataGridView2.TabIndex = 17
        '
        'colid
        '
        Me.colid.HeaderText = "Kode Ekspedisi"
        Me.colid.Name = "colid"
        Me.colid.ReadOnly = true
        Me.colid.Width = 160
        '
        'colsupplier
        '
        Me.colsupplier.HeaderText = "Nama Ekspedisi"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.ReadOnly = true
        Me.colsupplier.Width = 240
        '
        'colfromcity
        '
        Me.colfromcity.HeaderText = "Kota Asal"
        Me.colfromcity.Name = "colfromcity"
        Me.colfromcity.ReadOnly = true
        Me.colfromcity.Width = 120
        '
        'coltocity
        '
        Me.coltocity.HeaderText = "Tujuan"
        Me.coltocity.Name = "coltocity"
        Me.coltocity.ReadOnly = true
        Me.coltocity.Width = 120
        '
        'coldate
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.coldate.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldate.HeaderText = "Tarif"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = true
        Me.coldate.Width = 120
        '
        'qty
        '
        Me.qty.HeaderText = "Qty Unit (kg)"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = true
        Me.qty.Width = 120
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = true
        Me.GroupControl3.Appearance.Options.UseFont = true
        Me.GroupControl3.Appearance.Options.UseForeColor = true
        Me.GroupControl3.Location = New System.Drawing.Point(11, 12)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = false
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(296, 398)
        Me.GroupControl3.TabIndex = 281
        Me.GroupControl3.Text = "DATA EKSPEDISI"
        '
        'Lookup_Kota2
        '
        Me.Lookup_Kota2.Location = New System.Drawing.Point(169, 141)
        Me.Lookup_Kota2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Lookup_Kota2.Name = "Lookup_Kota2"
        Me.Lookup_Kota2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Lookup_Kota2.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Lookup_Kota2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Lookup_Kota2.Properties.Appearance.Options.UseBackColor = true
        Me.Lookup_Kota2.Properties.Appearance.Options.UseFont = true
        Me.Lookup_Kota2.Properties.Appearance.Options.UseForeColor = true
        Me.Lookup_Kota2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup_Kota2.Properties.View = Me.GridView2
        Me.Lookup_Kota2.Size = New System.Drawing.Size(424, 24)
        Me.Lookup_Kota2.TabIndex = 284
        Me.Lookup_Kota2.Visible = false
        '
        'GridView2
        '
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = true
        Me.GridView2.Appearance.ViewCaption.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GridView2.Appearance.ViewCaption.Options.UseFont = true
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = false
        Me.GridView2.OptionsCustomization.AllowGroup = false
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.GridView2.OptionsView.RowAutoHeight = true
        Me.GridView2.OptionsView.ShowGroupPanel = false
        Me.GridView2.PaintStyleName = "Skin"
        '
        'lookup_kota1
        '
        Me.lookup_kota1.Location = New System.Drawing.Point(169, 113)
        Me.lookup_kota1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lookup_kota1.Name = "lookup_kota1"
        Me.lookup_kota1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.lookup_kota1.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lookup_kota1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lookup_kota1.Properties.Appearance.Options.UseBackColor = true
        Me.lookup_kota1.Properties.Appearance.Options.UseFont = true
        Me.lookup_kota1.Properties.Appearance.Options.UseForeColor = true
        Me.lookup_kota1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookup_kota1.Properties.View = Me.GridView1
        Me.lookup_kota1.Size = New System.Drawing.Size(457, 24)
        Me.lookup_kota1.TabIndex = 283
        Me.lookup_kota1.Visible = false
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = true
        Me.GridView1.Appearance.ViewCaption.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GridView1.Appearance.ViewCaption.Options.UseFont = true
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = false
        Me.GridView1.OptionsCustomization.AllowGroup = false
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.GridView1.OptionsView.RowAutoHeight = true
        Me.GridView1.OptionsView.ShowGroupPanel = false
        Me.GridView1.PaintStyleName = "Skin"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "Keterangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Tarif Per Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 18)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Qty Pengiriman (Per Kg)"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Ke Kota"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Dari Kota"
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(15, 89)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 18)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Nama Ekspedisi"
        '
        'Label20
        '
        Me.Label20.AutoSize = true
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(15, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 18)
        Me.Label20.TabIndex = 102
        Me.Label20.Text = "Kode Ekspedisi"
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(-693, 0)
        Me.TabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TabControl1.LookAndFeel.UseDefaultLookAndFeel = false
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.TabInput
        Me.TabControl1.Size = New System.Drawing.Size(320, 525)
        Me.TabControl1.TabIndex = 282
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabInput, Me.TabList})
        Me.TabControl1.Visible = false
        '
        'TabInput
        '
        Me.TabInput.Controls.Add(Me.Panel3)
        Me.TabInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabInput.Name = "TabInput"
        Me.TabInput.Size = New System.Drawing.Size(318, 500)
        Me.TabInput.Text = "DATA INPUT EKSPEDISI"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.txt_junior_comm)
        Me.Panel3.Controls.Add(Me.txt_senior_comm)
        Me.Panel3.Controls.Add(Me.PanelControl2)
        Me.Panel3.Controls.Add(Me.GroupControl3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(318, 500)
        Me.Panel3.TabIndex = 0
        '
        'txt_junior_comm
        '
        Me.txt_junior_comm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_junior_comm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_junior_comm.Location = New System.Drawing.Point(83, -40)
        Me.txt_junior_comm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_junior_comm.Name = "txt_junior_comm"
        Me.txt_junior_comm.Size = New System.Drawing.Size(635, 23)
        Me.txt_junior_comm.TabIndex = 110
        Me.txt_junior_comm.Visible = false
        '
        'txt_senior_comm
        '
        Me.txt_senior_comm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senior_comm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_senior_comm.Location = New System.Drawing.Point(106, -59)
        Me.txt_senior_comm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_senior_comm.Name = "txt_senior_comm"
        Me.txt_senior_comm.Size = New System.Drawing.Size(635, 23)
        Me.txt_senior_comm.TabIndex = 109
        Me.txt_senior_comm.Visible = false
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl2.Appearance.Options.UseBackColor = true
        Me.PanelControl2.Appearance.Options.UseForeColor = true
        Me.PanelControl2.Controls.Add(Me.Button1)
        Me.PanelControl2.Location = New System.Drawing.Point(11, 419)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = false
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(296, 61)
        Me.PanelControl2.TabIndex = 285
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x161
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(318, -12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 59)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Simpan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = false
        Me.Button1.Visible = false
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.Panel2)
        Me.TabList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabList.Name = "TabList"
        Me.TabList.Size = New System.Drawing.Size(318, 500)
        Me.TabList.Text = "DAFTAR EKSPEDISI"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.GroupControl4)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 500)
        Me.Panel2.TabIndex = 0
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl4.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl4.Appearance.Options.UseBackColor = true
        Me.GroupControl4.Appearance.Options.UseFont = true
        Me.GroupControl4.Appearance.Options.UseForeColor = true
        Me.GroupControl4.Controls.Add(Me.btn_reset_cust)
        Me.GroupControl4.Controls.Add(Me.Label28)
        Me.GroupControl4.Controls.Add(Me.txt_search)
        Me.GroupControl4.Controls.Add(Me.btn_cari_cust)
        Me.GroupControl4.Controls.Add(Me.Label27)
        Me.GroupControl4.Controls.Add(Me.GroupBox3)
        Me.GroupControl4.Controls.Add(Me.cbo_search)
        Me.GroupControl4.Location = New System.Drawing.Point(6, 6)
        Me.GroupControl4.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl4.LookAndFeel.UseDefaultLookAndFeel = false
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(186, 482)
        Me.GroupControl4.TabIndex = 278
        Me.GroupControl4.Text = "PANEL PENCARIAN"
        '
        'btn_reset_cust
        '
        Me.btn_reset_cust.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_reset_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_reset_cust.Appearance.Options.UseFont = true
        Me.btn_reset_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset_cust.Location = New System.Drawing.Point(16, 351)
        Me.btn_reset_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset_cust.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btn_reset_cust.Name = "btn_reset_cust"
        Me.btn_reset_cust.Size = New System.Drawing.Size(79, 36)
        Me.btn_reset_cust.TabIndex = 276
        Me.btn_reset_cust.Text = "RESET"
        '
        'btn_cari_cust
        '
        Me.btn_cari_cust.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_cari_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_cari_cust.Appearance.Options.UseFont = true
        Me.btn_cari_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Search_16x16
        Me.btn_cari_cust.Location = New System.Drawing.Point(101, 351)
        Me.btn_cari_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cari_cust.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btn_cari_cust.Name = "btn_cari_cust"
        Me.btn_cari_cust.Size = New System.Drawing.Size(72, 36)
        Me.btn_cari_cust.TabIndex = 275
        Me.btn_cari_cust.Text = "CARI"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_keluar.Appearance.Options.UseFont = true
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(10, 419)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(82, 40)
        Me.btn_keluar.TabIndex = 19
        Me.btn_keluar.Text = "KELUAR"
        '
        'btn_reset2
        '
        Me.btn_reset2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_reset2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_reset2.Appearance.Options.UseFont = true
        Me.btn_reset2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset2.Location = New System.Drawing.Point(385, 419)
        Me.btn_reset2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset2.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btn_reset2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_reset2.Name = "btn_reset2"
        Me.btn_reset2.Size = New System.Drawing.Size(82, 40)
        Me.btn_reset2.TabIndex = 18
        Me.btn_reset2.Text = "RESET"
        '
        'btn_del2
        '
        Me.btn_del2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_del2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_del2.Appearance.Options.UseFont = true
        Me.btn_del2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Delete_16x16
        Me.btn_del2.Location = New System.Drawing.Point(473, 419)
        Me.btn_del2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_del2.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btn_del2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_del2.Name = "btn_del2"
        Me.btn_del2.Size = New System.Drawing.Size(82, 40)
        Me.btn_del2.TabIndex = 17
        Me.btn_del2.Text = "HAPUS"
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_save2.Appearance.Options.UseFont = true
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(561, 419)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 40)
        Me.btn_save2.TabIndex = 16
        Me.btn_save2.Text = "SIMPAN"
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PanelControl5.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl5.Appearance.Options.UseBackColor = true
        Me.PanelControl5.Appearance.Options.UseForeColor = true
        Me.PanelControl5.Controls.Add(Me.SimpleButton4)
        Me.PanelControl5.Controls.Add(Me.SimpleButton8)
        Me.PanelControl5.Controls.Add(Me.SimpleButton3)
        Me.PanelControl5.Location = New System.Drawing.Point(13, 615)
        Me.PanelControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl5.LookAndFeel.UseDefaultLookAndFeel = false
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(993, 49)
        Me.PanelControl5.TabIndex = 305
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton4.Appearance.Options.UseFont = true
        Me.SimpleButton4.Appearance.Options.UseForeColor = true
        Me.SimpleButton4.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.SimpleButton4.Location = New System.Drawing.Point(895, 6)
        Me.SimpleButton4.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton4.LookAndFeel.UseDefaultLookAndFeel = false
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 37)
        Me.SimpleButton4.TabIndex = 294
        Me.SimpleButton4.Text = "TUTUP"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SimpleButton8.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SimpleButton8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton8.Appearance.Options.UseFont = true
        Me.SimpleButton8.Appearance.Options.UseForeColor = true
        Me.SimpleButton8.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.SimpleButton8.Location = New System.Drawing.Point(796, 6)
        Me.SimpleButton8.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton8.LookAndFeel.UseDefaultLookAndFeel = false
        Me.SimpleButton8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(92, 37)
        Me.SimpleButton8.TabIndex = 295
        Me.SimpleButton8.Text = "REFRESH"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton3.Appearance.Options.UseFont = true
        Me.SimpleButton3.Appearance.Options.UseForeColor = true
        Me.SimpleButton3.Image = Global.SMARTACCOUNTING.My.Resources.Resources.add
        Me.SimpleButton3.Location = New System.Drawing.Point(7, 6)
        Me.SimpleButton3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton3.LookAndFeel.UseDefaultLookAndFeel = false
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(196, 37)
        Me.SimpleButton3.TabIndex = 293
        Me.SimpleButton3.Text = "TAMBAH DATA EKSPEDISI"
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Location = New System.Drawing.Point(13, 37)
        Me.GridControl.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GridControl.LookAndFeel.UseDefaultLookAndFeel = false
        Me.GridControl.MainView = Me.GridList_Customer
        Me.GridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(993, 576)
        Me.GridControl.TabIndex = 303
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridList_Customer})
        '
        'GridList_Customer
        '
        Me.GridList_Customer.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GridList_Customer.Appearance.ColumnFilterButton.Options.UseFont = true
        Me.GridList_Customer.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.ColumnFilterButtonActive.Options.UseFont = true
        Me.GridList_Customer.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.CustomizationFormHint.Options.UseFont = true
        Me.GridList_Customer.Appearance.DetailTip.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.DetailTip.Options.UseFont = true
        Me.GridList_Customer.Appearance.Empty.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.Empty.Options.UseFont = true
        Me.GridList_Customer.Appearance.EvenRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.EvenRow.Options.UseFont = true
        Me.GridList_Customer.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FilterCloseButton.Options.UseFont = true
        Me.GridList_Customer.Appearance.FilterPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FilterPanel.Options.UseFont = true
        Me.GridList_Customer.Appearance.FixedLine.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FixedLine.Options.UseFont = true
        Me.GridList_Customer.Appearance.FocusedCell.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FocusedCell.Options.UseFont = true
        Me.GridList_Customer.Appearance.FocusedRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FocusedRow.Options.UseFont = true
        Me.GridList_Customer.Appearance.FooterPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FooterPanel.Options.UseFont = true
        Me.GridList_Customer.Appearance.GroupButton.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupButton.Options.UseFont = true
        Me.GridList_Customer.Appearance.GroupFooter.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupFooter.Options.UseFont = true
        Me.GridList_Customer.Appearance.GroupPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupPanel.Options.UseFont = true
        Me.GridList_Customer.Appearance.GroupRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupRow.Options.UseFont = true
        Me.GridList_Customer.Appearance.HeaderPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.HeaderPanel.Options.UseFont = true
        Me.GridList_Customer.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.HideSelectionRow.Options.UseFont = true
        Me.GridList_Customer.Appearance.HorzLine.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.HorzLine.Options.UseFont = true
        Me.GridList_Customer.Appearance.OddRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.OddRow.Options.UseFont = true
        Me.GridList_Customer.Appearance.Preview.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.Preview.Options.UseFont = true
        Me.GridList_Customer.Appearance.Row.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.Row.Options.UseFont = true
        Me.GridList_Customer.Appearance.RowSeparator.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.RowSeparator.Options.UseFont = true
        Me.GridList_Customer.Appearance.SelectedRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.SelectedRow.Options.UseFont = true
        Me.GridList_Customer.Appearance.TopNewRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.TopNewRow.Options.UseFont = true
        Me.GridList_Customer.Appearance.VertLine.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.VertLine.Options.UseFont = true
        Me.GridList_Customer.Appearance.ViewCaption.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.ViewCaption.Options.UseFont = true
        Me.GridList_Customer.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridList_Customer.GridControl = Me.GridControl
        Me.GridList_Customer.Name = "GridList_Customer"
        Me.GridList_Customer.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridList_Customer.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridList_Customer.OptionsBehavior.Editable = false
        Me.GridList_Customer.OptionsBehavior.ReadOnly = true
        Me.GridList_Customer.OptionsBehavior.SummariesIgnoreNullValues = true
        Me.GridList_Customer.OptionsCustomization.AllowColumnMoving = false
        Me.GridList_Customer.OptionsCustomization.AllowGroup = false
        Me.GridList_Customer.OptionsDetail.AllowZoomDetail = false
        Me.GridList_Customer.OptionsDetail.SmartDetailHeight = true
        Me.GridList_Customer.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
        Me.GridList_Customer.OptionsFind.AllowFindPanel = false
        Me.GridList_Customer.OptionsMenu.EnableColumnMenu = false
        Me.GridList_Customer.OptionsMenu.EnableFooterMenu = false
        Me.GridList_Customer.OptionsMenu.EnableGroupPanelMenu = false
        Me.GridList_Customer.OptionsNavigation.AutoFocusNewRow = true
        Me.GridList_Customer.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridList_Customer.OptionsView.ShowAutoFilterRow = true
        Me.GridList_Customer.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridList_Customer.OptionsView.ShowGroupPanel = false
        Me.GridList_Customer.PaintStyleName = "Skin"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(9, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 24)
        Me.Label6.TabIndex = 304
        Me.Label6.Text = "Daftar Master Ekspedisi"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PanelControl3.Appearance.Options.UseFont = true
        Me.PanelControl3.Controls.Add(Me.btn_reset2)
        Me.PanelControl3.Controls.Add(Me.btn_keluar)
        Me.PanelControl3.Controls.Add(Me.btn_del2)
        Me.PanelControl3.Controls.Add(Me.GroupControl5)
        Me.PanelControl3.Controls.Add(Me.btn_save2)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Location = New System.Drawing.Point(56, 110)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = false
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(654, 466)
        Me.PanelControl3.TabIndex = 306
        Me.PanelControl3.Visible = false
        '
        'GroupControl5
        '
        Me.GroupControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupControl5.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl5.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl5.Appearance.Options.UseBackColor = true
        Me.GroupControl5.Appearance.Options.UseFont = true
        Me.GroupControl5.Appearance.Options.UseForeColor = true
        Me.GroupControl5.Controls.Add(Me.btn_browse)
        Me.GroupControl5.Controls.Add(Me.Label4)
        Me.GroupControl5.Controls.Add(Me.txt_save_path)
        Me.GroupControl5.Location = New System.Drawing.Point(91, -217)
        Me.GroupControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl5.LookAndFeel.UseDefaultLookAndFeel = false
        Me.GroupControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(817, 197)
        Me.GroupControl5.TabIndex = 268
        Me.GroupControl5.Text = "SETTING DIREKTORI FOTO"
        Me.GroupControl5.Visible = false
        '
        'btn_browse
        '
        Me.btn_browse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_browse.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btn_browse.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_browse.Appearance.Options.UseFont = true
        Me.btn_browse.Appearance.Options.UseForeColor = true
        Me.btn_browse.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_browse.Location = New System.Drawing.Point(8, 1239)
        Me.btn_browse.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_browse.LookAndFeel.UseDefaultLookAndFeel = false
        Me.btn_browse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(64, 153)
        Me.btn_browse.TabIndex = 282
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.Visible = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 279
        Me.Label4.Text = "Direktori Foto :"
        '
        'txt_save_path
        '
        Me.txt_save_path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txt_save_path.BackColor = System.Drawing.Color.White
        Me.txt_save_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_save_path.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_save_path.ForeColor = System.Drawing.Color.Black
        Me.txt_save_path.Location = New System.Drawing.Point(7, 60)
        Me.txt_save_path.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_save_path.Name = "txt_save_path"
        Me.txt_save_path.ReadOnly = true
        Me.txt_save_path.Size = New System.Drawing.Size(803, 25)
        Me.txt_save_path.TabIndex = 277
        Me.txt_save_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = true
        Me.GroupControl1.Appearance.Options.UseFont = true
        Me.GroupControl1.Appearance.Options.UseForeColor = true
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.lookup_state)
        Me.GroupControl1.Controls.Add(Me.txt_kecamatan)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.txt_state)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.Lookup_Kota2)
        Me.GroupControl1.Controls.Add(Me.cbo_acc)
        Me.GroupControl1.Controls.Add(Me.lookup_kota1)
        Me.GroupControl1.Controls.Add(Me.Label20)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txt_serviceid)
        Me.GroupControl1.Controls.Add(Me.txt_notes)
        Me.GroupControl1.Controls.Add(Me.Label18)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.chk_code)
        Me.GroupControl1.Controls.Add(Me.txt_price)
        Me.GroupControl1.Controls.Add(Me.txt_servicenm)
        Me.GroupControl1.Controls.Add(Me.txt_qty)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txt_from_kota)
        Me.GroupControl1.Controls.Add(Me.txt_to_kota)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(10, 9)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = false
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(633, 405)
        Me.GroupControl1.TabIndex = 281
        Me.GroupControl1.Text = "DATA MASTER EKSPEDISI"
        '
        'lookup_state
        '
        Me.lookup_state.Location = New System.Drawing.Point(169, 168)
        Me.lookup_state.Name = "lookup_state"
        Me.lookup_state.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.lookup_state.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lookup_state.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lookup_state.Properties.Appearance.Options.UseBackColor = true
        Me.lookup_state.Properties.Appearance.Options.UseFont = true
        Me.lookup_state.Properties.Appearance.Options.UseForeColor = true
        Me.lookup_state.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookup_state.Properties.View = Me.GridView3
        Me.lookup_state.Size = New System.Drawing.Size(424, 24)
        Me.lookup_state.TabIndex = 299
        Me.lookup_state.Visible = false
        '
        'GridView3
        '
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GridView3.Appearance.Row.Options.UseFont = true
        Me.GridView3.Appearance.ViewCaption.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GridView3.Appearance.ViewCaption.Options.UseFont = true
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowColumnMoving = false
        Me.GridView3.OptionsCustomization.AllowGroup = false
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.GridView3.OptionsView.RowAutoHeight = true
        Me.GridView3.OptionsView.ShowGroupPanel = false
        Me.GridView3.PaintStyleName = "Skin"
        '
        'txt_kecamatan
        '
        Me.txt_kecamatan.BackColor = System.Drawing.Color.White
        Me.txt_kecamatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kecamatan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_kecamatan.ForeColor = System.Drawing.Color.Black
        Me.txt_kecamatan.Location = New System.Drawing.Point(169, 196)
        Me.txt_kecamatan.Name = "txt_kecamatan"
        Me.txt_kecamatan.Size = New System.Drawing.Size(455, 23)
        Me.txt_kecamatan.TabIndex = 288
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 18)
        Me.Label9.TabIndex = 287
        Me.Label9.Text = "Ke Kecamatan"
        '
        'txt_state
        '
        Me.txt_state.BackColor = System.Drawing.Color.White
        Me.txt_state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_state.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_state.ForeColor = System.Drawing.Color.Black
        Me.txt_state.Location = New System.Drawing.Point(169, 169)
        Me.txt_state.Name = "txt_state"
        Me.txt_state.Size = New System.Drawing.Size(422, 23)
        Me.txt_state.TabIndex = 285
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 18)
        Me.Label8.TabIndex = 286
        Me.Label8.Text = "Ke Propinsi"
        '
        'cbo_acc
        '
        Me.cbo_acc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbo_acc.FormattingEnabled = true
        Me.cbo_acc.Location = New System.Drawing.Point(659, 142)
        Me.cbo_acc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_acc.Name = "cbo_acc"
        Me.cbo_acc.Size = New System.Drawing.Size(398, 26)
        Me.cbo_acc.TabIndex = 4
        Me.cbo_acc.Visible = false
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseFont = true
        Me.SimpleButton1.Appearance.Options.UseForeColor = true
        Me.SimpleButton1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(599, 142)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = false
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(22, 23)
        Me.SimpleButton1.TabIndex = 301
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.Appearance.Options.UseFont = true
        Me.SimpleButton2.Appearance.Options.UseForeColor = true
        Me.SimpleButton2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(599, 169)
        Me.SimpleButton2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = false
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(22, 23)
        Me.SimpleButton2.TabIndex = 302
        '
        'frmekspedisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 18!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1018, 672)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.Label6)
        Me.DoubleBuffered = true
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmekspedisi"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ekspedisi - Kurir Express"
        Me.Panel1.ResumeLayout(false)
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        CType(Me.DataGridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Lookup_Kota2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lookup_kota1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TabControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabControl1.ResumeLayout(false)
        Me.TabInput.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        CType(Me.PanelControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl2.ResumeLayout(false)
        Me.TabList.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        CType(Me.GroupControl4,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl4.ResumeLayout(false)
        Me.GroupControl4.PerformLayout
        CType(Me.PanelControl5,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl5.ResumeLayout(false)
        CType(Me.GridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridList_Customer,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanelControl3,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl3.ResumeLayout(false)
        CType(Me.GroupControl5,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl5.ResumeLayout(false)
        Me.GroupControl5.PerformLayout
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.GroupControl1.PerformLayout
        CType(Me.lookup_state.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView3,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txt_servicenm As System.Windows.Forms.TextBox
    Friend WithEvents txt_serviceid As System.Windows.Forms.TextBox
    Friend WithEvents btn_reset As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_help As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tglakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tglawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents chk_date As System.Windows.Forms.CheckBox
    Friend WithEvents txt_notes As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chk_code As System.Windows.Forms.CheckBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents txt_from_kota As System.Windows.Forms.TextBox
    Friend WithEvents txt_to_kota As System.Windows.Forms.TextBox
    Friend WithEvents colid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colfromcity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltocity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reset2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_reset_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_junior_comm As System.Windows.Forms.TextBox
    Friend WithEvents txt_senior_comm As System.Windows.Forms.TextBox
    Friend WithEvents Lookup_Kota2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lookup_kota1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridList_Customer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_save_path As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbo_acc As System.Windows.Forms.ComboBox
    Friend WithEvents txt_kecamatan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_state As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lookup_state As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
