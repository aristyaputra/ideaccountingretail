<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcashier
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcashier))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colnoinv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsupp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcetak = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_reset_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_cari_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tglakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tglawal = New System.Windows.Forms.DateTimePicker()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_inv_no = New System.Windows.Forms.TextBox()
        Me.txt_cust_address = New System.Windows.Forms.TextBox()
        Me.txt_customer_nm = New System.Windows.Forms.TextBox()
        Me.btn_cetak = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reset2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.NavBarControl3 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer5 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txt_totalcsh = New System.Windows.Forms.TextBox()
        Me.NavBarGroupControlContainer6 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NavBarGroupControlContainer8 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.NavBarGroup6 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup8 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_comment = New System.Windows.Forms.TextBox()
        Me.txt_ket = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.chk_ppn = New System.Windows.Forms.CheckBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_tax_nominal = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_netto = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_disc = New System.Windows.Forms.TextBox()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitemnm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colunit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalNet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colemployee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbarcode = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox1 = New MTGCComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbo_customer = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbo_unit = New MTGCComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabInput = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabList = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_tax = New System.Windows.Forms.TextBox()
        Me.txt_customer_phone = New System.Windows.Forms.TextBox()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_disc_pay = New System.Windows.Forms.TextBox()
        Me.txt_change = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.txt_curr = New System.Windows.Forms.ComboBox()
        Me.txt_discterm = New System.Windows.Forms.TextBox()
        Me.txt_paid = New System.Windows.Forms.TextBox()
        Me.txt_paymethod = New System.Windows.Forms.ComboBox()
        Me.txt_payterm = New System.Windows.Forms.TextBox()
        Me.txt_cust_id = New System.Windows.Forms.Label()
        Me.cbo_akun = New MTGCComboBox()
        Me.lbl_nm_akun = New System.Windows.Forms.Label()
        Me.chk_so = New System.Windows.Forms.CheckBox()
        Me.lbl_item_nm = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_browse = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_save_path = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NavBarControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl3.SuspendLayout()
        Me.NavBarGroupControlContainer5.SuspendLayout()
        Me.NavBarGroupControlContainer6.SuspendLayout()
        Me.NavBarGroupControlContainer8.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabInput.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnoinv, Me.colsupp, Me.coldate, Me.colsubtotal, Me.coldisc, Me.coltax, Me.colamount, Me.coldescript, Me.colcetak})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(597, 865)
        Me.DataGridView2.TabIndex = 13
        '
        'colnoinv
        '
        Me.colnoinv.HeaderText = "No Transaksi"
        Me.colnoinv.Name = "colnoinv"
        Me.colnoinv.ReadOnly = True
        Me.colnoinv.Width = 170
        '
        'colsupp
        '
        Me.colsupp.HeaderText = "Pelanggan"
        Me.colsupp.Name = "colsupp"
        Me.colsupp.ReadOnly = True
        Me.colsupp.Width = 160
        '
        'coldate
        '
        Me.coldate.HeaderText = "Tanggal"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        '
        'colsubtotal
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colsubtotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.colsubtotal.HeaderText = "Sub Total"
        Me.colsubtotal.Name = "colsubtotal"
        Me.colsubtotal.ReadOnly = True
        Me.colsubtotal.Width = 113
        '
        'coldisc
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.coldisc.DefaultCellStyle = DataGridViewCellStyle3
        Me.coldisc.HeaderText = "Diskon"
        Me.coldisc.Name = "coldisc"
        Me.coldisc.ReadOnly = True
        Me.coldisc.Width = 105
        '
        'coltax
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.coltax.DefaultCellStyle = DataGridViewCellStyle4
        Me.coltax.HeaderText = "PPN"
        Me.coltax.Name = "coltax"
        Me.coltax.ReadOnly = True
        Me.coltax.Width = 105
        '
        'colamount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colamount.DefaultCellStyle = DataGridViewCellStyle5
        Me.colamount.HeaderText = "Total"
        Me.colamount.Name = "colamount"
        Me.colamount.ReadOnly = True
        Me.colamount.Width = 113
        '
        'coldescript
        '
        Me.coldescript.HeaderText = "Keterangan"
        Me.coldescript.Name = "coldescript"
        Me.coldescript.ReadOnly = True
        Me.coldescript.Width = 210
        '
        'colcetak
        '
        Me.colcetak.HeaderText = "Lihat Nota"
        Me.colcetak.Name = "colcetak"
        Me.colcetak.ReadOnly = True
        Me.colcetak.Text = "Cetak Faktur"
        Me.colcetak.UseColumnTextForButtonValue = True
        Me.colcetak.Width = 130
        '
        'GroupControl7
        '
        Me.GroupControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl7.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl7.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl7.Appearance.Options.UseBackColor = True
        Me.GroupControl7.Appearance.Options.UseFont = True
        Me.GroupControl7.Appearance.Options.UseForeColor = True
        Me.GroupControl7.Controls.Add(Me.btn_reset_cust)
        Me.GroupControl7.Controls.Add(Me.Label28)
        Me.GroupControl7.Controls.Add(Me.txt_search)
        Me.GroupControl7.Controls.Add(Me.btn_cari_cust)
        Me.GroupControl7.Controls.Add(Me.Label27)
        Me.GroupControl7.Controls.Add(Me.GroupBox3)
        Me.GroupControl7.Controls.Add(Me.cbo_search)
        Me.GroupControl7.Location = New System.Drawing.Point(13, 12)
        Me.GroupControl7.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl7.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(226, 885)
        Me.GroupControl7.TabIndex = 295
        Me.GroupControl7.Text = "PANEL PENCARIAN"
        '
        'btn_reset_cust
        '
        Me.btn_reset_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_cust.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_reset_cust.Appearance.Options.UseFont = True
        Me.btn_reset_cust.Appearance.Options.UseForeColor = True
        Me.btn_reset_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset_cust.Location = New System.Drawing.Point(20, 457)
        Me.btn_reset_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_reset_cust.Name = "btn_reset_cust"
        Me.btn_reset_cust.Size = New System.Drawing.Size(89, 50)
        Me.btn_reset_cust.TabIndex = 276
        Me.btn_reset_cust.Text = "RESET"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(17, 33)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 18)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Cari Berdasarkan"
        '
        'txt_search
        '
        Me.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_search.BackColor = System.Drawing.Color.White
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.Color.Black
        Me.txt_search.Location = New System.Drawing.Point(21, 129)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(180, 71)
        Me.txt_search.TabIndex = 23
        '
        'btn_cari_cust
        '
        Me.btn_cari_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_cust.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cari_cust.Appearance.Options.UseFont = True
        Me.btn_cari_cust.Appearance.Options.UseForeColor = True
        Me.btn_cari_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Search_16x16
        Me.btn_cari_cust.Location = New System.Drawing.Point(115, 457)
        Me.btn_cari_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cari_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cari_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cari_cust.Name = "btn_cari_cust"
        Me.btn_cari_cust.Size = New System.Drawing.Size(91, 50)
        Me.btn_cari_cust.TabIndex = 275
        Me.btn_cari_cust.Text = "CARI"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(17, 102)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 18)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "Teks Pencarian"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chk_date)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.tglakhir)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.tglawal)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(20, 208)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(187, 228)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter Tanggal"
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.ForeColor = System.Drawing.Color.Black
        Me.chk_date.Location = New System.Drawing.Point(16, 46)
        Me.chk_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(123, 22)
        Me.chk_date.TabIndex = 38
        Me.chk_date.Text = "Batasan Tanggal"
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(22, 152)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 18)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Sampai"
        '
        'tglakhir
        '
        Me.tglakhir.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tglakhir.CustomFormat = "dd-MM-yyyy"
        Me.tglakhir.ForeColor = System.Drawing.Color.Black
        Me.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglakhir.Location = New System.Drawing.Point(26, 177)
        Me.tglakhir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(129, 23)
        Me.tglakhir.TabIndex = 36
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(22, 91)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 18)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Dari"
        '
        'tglawal
        '
        Me.tglawal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tglawal.CustomFormat = "dd-MM-yyyy"
        Me.tglawal.ForeColor = System.Drawing.Color.Black
        Me.tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglawal.Location = New System.Drawing.Point(26, 116)
        Me.tglawal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglawal.Name = "tglawal"
        Me.tglawal.Size = New System.Drawing.Size(129, 23)
        Me.tglawal.TabIndex = 34
        '
        'cbo_search
        '
        Me.cbo_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_search.BackColor = System.Drawing.Color.White
        Me.cbo_search.ForeColor = System.Drawing.Color.Black
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"Transaction No", "Customer"})
        Me.cbo_search.Location = New System.Drawing.Point(21, 62)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(180, 26)
        Me.cbo_search.TabIndex = 19
        '
        'GroupControl6
        '
        Me.GroupControl6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl6.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl6.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl6.Appearance.Options.UseBackColor = True
        Me.GroupControl6.Appearance.Options.UseFont = True
        Me.GroupControl6.Appearance.Options.UseForeColor = True
        Me.GroupControl6.Controls.Add(Me.DataGridView2)
        Me.GroupControl6.Location = New System.Drawing.Point(250, 12)
        Me.GroupControl6.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(601, 888)
        Me.GroupControl6.TabIndex = 294
        Me.GroupControl6.Text = "DAFTAR TRANSAKSI"
        '
        'txt_inv_no
        '
        Me.txt_inv_no.BackColor = System.Drawing.Color.White
        Me.txt_inv_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_inv_no.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inv_no.ForeColor = System.Drawing.Color.Black
        Me.txt_inv_no.Location = New System.Drawing.Point(14, 43)
        Me.txt_inv_no.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_inv_no.Name = "txt_inv_no"
        Me.txt_inv_no.ReadOnly = True
        Me.txt_inv_no.Size = New System.Drawing.Size(233, 23)
        Me.txt_inv_no.TabIndex = 50
        '
        'txt_cust_address
        '
        Me.txt_cust_address.BackColor = System.Drawing.Color.White
        Me.txt_cust_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cust_address.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust_address.ForeColor = System.Drawing.Color.Black
        Me.txt_cust_address.Location = New System.Drawing.Point(263, 43)
        Me.txt_cust_address.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cust_address.Multiline = True
        Me.txt_cust_address.Name = "txt_cust_address"
        Me.txt_cust_address.Size = New System.Drawing.Size(239, 98)
        Me.txt_cust_address.TabIndex = 2
        '
        'txt_customer_nm
        '
        Me.txt_customer_nm.BackColor = System.Drawing.Color.White
        Me.txt_customer_nm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_customer_nm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer_nm.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_nm.Location = New System.Drawing.Point(14, 118)
        Me.txt_customer_nm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_customer_nm.Name = "txt_customer_nm"
        Me.txt_customer_nm.Size = New System.Drawing.Size(240, 23)
        Me.txt_customer_nm.TabIndex = 1
        '
        'btn_cetak
        '
        Me.btn_cetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cetak.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cetak.Appearance.Options.UseFont = True
        Me.btn_cetak.Appearance.Options.UseForeColor = True
        Me.btn_cetak.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Print_16x16
        Me.btn_cetak.Location = New System.Drawing.Point(100, 606)
        Me.btn_cetak.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cetak.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cetak.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(121, 41)
        Me.btn_cetak.TabIndex = 20
        Me.btn_cetak.Text = "LIHAT - CETAK"
        '
        'btn_keluar
        '
        Me.btn_keluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(6, 606)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(88, 41)
        Me.btn_keluar.TabIndex = 19
        Me.btn_keluar.Text = "KELUAR"
        '
        'btn_reset2
        '
        Me.btn_reset2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_reset2.Appearance.Options.UseFont = True
        Me.btn_reset2.Appearance.Options.UseForeColor = True
        Me.btn_reset2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset2.Location = New System.Drawing.Point(741, 606)
        Me.btn_reset2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_reset2.Name = "btn_reset2"
        Me.btn_reset2.Size = New System.Drawing.Size(79, 41)
        Me.btn_reset2.TabIndex = 18
        Me.btn_reset2.Text = "RESET"
        '
        'btn_del2
        '
        Me.btn_del2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_del2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_del2.Appearance.Options.UseFont = True
        Me.btn_del2.Appearance.Options.UseForeColor = True
        Me.btn_del2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Delete_16x16
        Me.btn_del2.Location = New System.Drawing.Point(827, 606)
        Me.btn_del2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_del2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_del2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_del2.Name = "btn_del2"
        Me.btn_del2.Size = New System.Drawing.Size(79, 41)
        Me.btn_del2.TabIndex = 17
        Me.btn_del2.Text = "HAPUS"
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.payment
        Me.btn_save2.Location = New System.Drawing.Point(914, 606)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(75, 41)
        Me.btn_save2.TabIndex = 16
        Me.btn_save2.Text = "BAYAR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.NavBarControl3)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(206, 128)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(620, 339)
        Me.Panel2.TabIndex = 288
        Me.Panel2.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DimGray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Delete_16x161
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(191, 275)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 46)
        Me.Button5.TabIndex = 283
        Me.Button5.Text = "Batal"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'NavBarControl3
        '
        Me.NavBarControl3.ActiveGroup = Me.NavBarGroup5
        Me.NavBarControl3.Appearance.Background.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl3.Appearance.Background.Options.UseBackColor = True
        Me.NavBarControl3.Appearance.GroupBackground.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NavBarControl3.Appearance.GroupBackground.BackColor2 = System.Drawing.Color.DodgerBlue
        Me.NavBarControl3.Appearance.GroupBackground.BorderColor = System.Drawing.Color.Transparent
        Me.NavBarControl3.Appearance.GroupBackground.Options.UseBackColor = True
        Me.NavBarControl3.Appearance.GroupBackground.Options.UseBorderColor = True
        Me.NavBarControl3.Appearance.GroupHeader.BackColor = System.Drawing.Color.White
        Me.NavBarControl3.Appearance.GroupHeader.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.NavBarControl3.Appearance.GroupHeader.Options.UseBackColor = True
        Me.NavBarControl3.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NavBarControl3.Controls.Add(Me.NavBarGroupControlContainer5)
        Me.NavBarControl3.Controls.Add(Me.NavBarGroupControlContainer6)
        Me.NavBarControl3.Controls.Add(Me.NavBarGroupControlContainer8)
        Me.NavBarControl3.ForeColor = System.Drawing.Color.Black
        Me.NavBarControl3.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup5, Me.NavBarGroup6, Me.NavBarGroup8})
        Me.NavBarControl3.Location = New System.Drawing.Point(10, 9)
        Me.NavBarControl3.LookAndFeel.SkinName = "Office 2010 Black"
        Me.NavBarControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NavBarControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NavBarControl3.Name = "NavBarControl3"
        Me.NavBarControl3.OptionsNavPane.ExpandedWidth = 598
        Me.NavBarControl3.Size = New System.Drawing.Size(598, 239)
        Me.NavBarControl3.StoreDefaultPaintStyleName = True
        Me.NavBarControl3.TabIndex = 281
        Me.NavBarControl3.Text = "No Kas Umum / Bank"
        '
        'NavBarGroup5
        '
        Me.NavBarGroup5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup5.Appearance.Options.UseFont = True
        Me.NavBarGroup5.Caption = "Total"
        Me.NavBarGroup5.ControlContainer = Me.NavBarGroupControlContainer5
        Me.NavBarGroup5.Expanded = True
        Me.NavBarGroup5.GroupClientHeight = 44
        Me.NavBarGroup5.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup5.Name = "NavBarGroup5"
        '
        'NavBarGroupControlContainer5
        '
        Me.NavBarGroupControlContainer5.Controls.Add(Me.txt_totalcsh)
        Me.NavBarGroupControlContainer5.ForeColor = System.Drawing.Color.Black
        Me.NavBarGroupControlContainer5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NavBarGroupControlContainer5.Name = "NavBarGroupControlContainer5"
        Me.NavBarGroupControlContainer5.Size = New System.Drawing.Size(590, 40)
        Me.NavBarGroupControlContainer5.TabIndex = 0
        '
        'txt_totalcsh
        '
        Me.txt_totalcsh.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_totalcsh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_totalcsh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_totalcsh.Enabled = False
        Me.txt_totalcsh.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalcsh.ForeColor = System.Drawing.Color.White
        Me.txt_totalcsh.Location = New System.Drawing.Point(0, 0)
        Me.txt_totalcsh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_totalcsh.Name = "txt_totalcsh"
        Me.txt_totalcsh.ReadOnly = True
        Me.txt_totalcsh.Size = New System.Drawing.Size(590, 39)
        Me.txt_totalcsh.TabIndex = 92
        Me.txt_totalcsh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NavBarGroupControlContainer6
        '
        Me.NavBarGroupControlContainer6.Controls.Add(Me.TextBox1)
        Me.NavBarGroupControlContainer6.ForeColor = System.Drawing.Color.Black
        Me.NavBarGroupControlContainer6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NavBarGroupControlContainer6.Name = "NavBarGroupControlContainer6"
        Me.NavBarGroupControlContainer6.Size = New System.Drawing.Size(590, 40)
        Me.NavBarGroupControlContainer6.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(590, 39)
        Me.TextBox1.TabIndex = 134
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NavBarGroupControlContainer8
        '
        Me.NavBarGroupControlContainer8.Controls.Add(Me.TextBox2)
        Me.NavBarGroupControlContainer8.ForeColor = System.Drawing.Color.Black
        Me.NavBarGroupControlContainer8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NavBarGroupControlContainer8.Name = "NavBarGroupControlContainer8"
        Me.NavBarGroupControlContainer8.Size = New System.Drawing.Size(590, 39)
        Me.NavBarGroupControlContainer8.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(590, 39)
        Me.TextBox2.TabIndex = 136
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NavBarGroup6
        '
        Me.NavBarGroup6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup6.Appearance.Options.UseFont = True
        Me.NavBarGroup6.Caption = "Pembayaran"
        Me.NavBarGroup6.ControlContainer = Me.NavBarGroupControlContainer6
        Me.NavBarGroup6.Expanded = True
        Me.NavBarGroup6.GroupClientHeight = 44
        Me.NavBarGroup6.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup6.Name = "NavBarGroup6"
        '
        'NavBarGroup8
        '
        Me.NavBarGroup8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup8.Appearance.Options.UseFont = True
        Me.NavBarGroup8.Caption = "Kembalian"
        Me.NavBarGroup8.ControlContainer = Me.NavBarGroupControlContainer8
        Me.NavBarGroup8.Expanded = True
        Me.NavBarGroup8.GroupClientHeight = 43
        Me.NavBarGroup8.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup8.Name = "NavBarGroup8"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.SMARTACCOUNTING.My.Resources.Resources.payment
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(276, 275)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(136, 46)
        Me.btn_save.TabIndex = 12
        Me.btn_save.Text = "Bayar - Cetak"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl4.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl4.Appearance.Options.UseBackColor = True
        Me.GroupControl4.Appearance.Options.UseFont = True
        Me.GroupControl4.Appearance.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.txt_comment)
        Me.GroupControl4.Controls.Add(Me.txt_ket)
        Me.GroupControl4.Controls.Add(Me.TextBox7)
        Me.GroupControl4.Controls.Add(Me.Label3)
        Me.GroupControl4.Location = New System.Drawing.Point(6, 459)
        Me.GroupControl4.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(457, 123)
        Me.GroupControl4.TabIndex = 298
        Me.GroupControl4.Text = "NOTES"
        '
        'txt_comment
        '
        Me.txt_comment.BackColor = System.Drawing.Color.White
        Me.txt_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comment.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comment.ForeColor = System.Drawing.Color.Black
        Me.txt_comment.Location = New System.Drawing.Point(9, 47)
        Me.txt_comment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_comment.Multiline = True
        Me.txt_comment.Name = "txt_comment"
        Me.txt_comment.Size = New System.Drawing.Size(443, 70)
        Me.txt_comment.TabIndex = 8
        '
        'txt_ket
        '
        Me.txt_ket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_ket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ket.ForeColor = System.Drawing.Color.Black
        Me.txt_ket.Location = New System.Drawing.Point(13, -1558)
        Me.txt_ket.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ket.Multiline = True
        Me.txt_ket.Name = "txt_ket"
        Me.txt_ket.Size = New System.Drawing.Size(1132, 98)
        Me.txt_ket.TabIndex = 282
        Me.txt_ket.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.ForeColor = System.Drawing.Color.Black
        Me.TextBox7.Location = New System.Drawing.Point(-1216, 26)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(1132, 98)
        Me.TextBox7.TabIndex = 280
        Me.TextBox7.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "Keterangan:"
        '
        'GroupControl5
        '
        Me.GroupControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl5.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl5.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl5.Appearance.Options.UseBackColor = True
        Me.GroupControl5.Appearance.Options.UseFont = True
        Me.GroupControl5.Appearance.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.Label8)
        Me.GroupControl5.Controls.Add(Me.TextBox3)
        Me.GroupControl5.Controls.Add(Me.chk_ppn)
        Me.GroupControl5.Controls.Add(Me.TextBox5)
        Me.GroupControl5.Controls.Add(Me.Label7)
        Me.GroupControl5.Controls.Add(Me.TextBox6)
        Me.GroupControl5.Controls.Add(Me.Label20)
        Me.GroupControl5.Controls.Add(Me.Label23)
        Me.GroupControl5.Controls.Add(Me.txt_tax_nominal)
        Me.GroupControl5.Controls.Add(Me.txt_subtotal)
        Me.GroupControl5.Controls.Add(Me.txt_netto)
        Me.GroupControl5.Controls.Add(Me.txt_total)
        Me.GroupControl5.Controls.Add(Me.txt_disc)
        Me.GroupControl5.Location = New System.Drawing.Point(705, 442)
        Me.GroupControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(284, 149)
        Me.GroupControl5.TabIndex = 297
        Me.GroupControl5.Text = "TOTAL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(45, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(13, -1558)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(1132, 98)
        Me.TextBox3.TabIndex = 282
        Me.TextBox3.Visible = False
        '
        'chk_ppn
        '
        Me.chk_ppn.AutoSize = True
        Me.chk_ppn.BackColor = System.Drawing.Color.Transparent
        Me.chk_ppn.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ppn.ForeColor = System.Drawing.Color.Black
        Me.chk_ppn.Location = New System.Drawing.Point(32, 98)
        Me.chk_ppn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_ppn.Name = "chk_ppn"
        Me.chk_ppn.Size = New System.Drawing.Size(49, 22)
        Me.chk_ppn.TabIndex = 89
        Me.chk_ppn.Text = "PPN"
        Me.chk_ppn.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.ForeColor = System.Drawing.Color.Black
        Me.TextBox5.Location = New System.Drawing.Point(13, -1558)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(1132, 98)
        Me.TextBox5.TabIndex = 281
        Me.TextBox5.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(42, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Netto"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.ForeColor = System.Drawing.Color.Black
        Me.TextBox6.Location = New System.Drawing.Point(-1216, 26)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(1132, 98)
        Me.TextBox6.TabIndex = 280
        Me.TextBox6.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(10, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 18)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Diskon (%)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(15, 25)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 18)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Sub Total"
        '
        'txt_tax_nominal
        '
        Me.txt_tax_nominal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_tax_nominal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tax_nominal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tax_nominal.ForeColor = System.Drawing.Color.Black
        Me.txt_tax_nominal.Location = New System.Drawing.Point(95, 97)
        Me.txt_tax_nominal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_tax_nominal.Name = "txt_tax_nominal"
        Me.txt_tax_nominal.ReadOnly = True
        Me.txt_tax_nominal.Size = New System.Drawing.Size(187, 23)
        Me.txt_tax_nominal.TabIndex = 88
        Me.txt_tax_nominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.ForeColor = System.Drawing.Color.Black
        Me.txt_subtotal.Location = New System.Drawing.Point(95, 22)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(187, 23)
        Me.txt_subtotal.TabIndex = 27
        Me.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_netto
        '
        Me.txt_netto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_netto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_netto.Enabled = False
        Me.txt_netto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_netto.ForeColor = System.Drawing.Color.Black
        Me.txt_netto.Location = New System.Drawing.Point(95, 72)
        Me.txt_netto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_netto.Name = "txt_netto"
        Me.txt_netto.ReadOnly = True
        Me.txt_netto.Size = New System.Drawing.Size(187, 23)
        Me.txt_netto.TabIndex = 35
        Me.txt_netto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.Black
        Me.txt_total.Location = New System.Drawing.Point(95, 122)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(187, 23)
        Me.txt_total.TabIndex = 31
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_disc
        '
        Me.txt_disc.BackColor = System.Drawing.Color.White
        Me.txt_disc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_disc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disc.ForeColor = System.Drawing.Color.Black
        Me.txt_disc.Location = New System.Drawing.Point(95, 47)
        Me.txt_disc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_disc.Name = "txt_disc"
        Me.txt_disc.Size = New System.Drawing.Size(187, 23)
        Me.txt_disc.TabIndex = 9
        Me.txt_disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Appearance.Options.UseFont = True
        Me.GroupControl3.Appearance.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.DataGridView1)
        Me.GroupControl3.Location = New System.Drawing.Point(6, 164)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(984, 266)
        Me.GroupControl3.TabIndex = 295
        Me.GroupControl3.Text = "INFORMASI BARANG"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colno, Me.colitem, Me.colitemnm, Me.coldesc, Me.colqty, Me.colunit, Me.colprice, Me.coltotal, Me.coldiscount, Me.colTotalNet, Me.colemployee, Me.coltype})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(980, 243)
        Me.DataGridView1.TabIndex = 10
        '
        'colno
        '
        Me.colno.HeaderText = "No"
        Me.colno.Name = "colno"
        Me.colno.Width = 40
        '
        'colitem
        '
        Me.colitem.HeaderText = "Kode Barang"
        Me.colitem.Name = "colitem"
        Me.colitem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colitem.Width = 140
        '
        'colitemnm
        '
        Me.colitemnm.HeaderText = "Nama Barang"
        Me.colitemnm.Name = "colitemnm"
        Me.colitemnm.Width = 180
        '
        'coldesc
        '
        Me.coldesc.HeaderText = "Keterangan"
        Me.coldesc.Name = "coldesc"
        Me.coldesc.Visible = False
        Me.coldesc.Width = 250
        '
        'colqty
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colqty.DefaultCellStyle = DataGridViewCellStyle7
        Me.colqty.HeaderText = "Qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Width = 75
        '
        'colunit
        '
        Me.colunit.HeaderText = "Unit"
        Me.colunit.Name = "colunit"
        Me.colunit.Width = 70
        '
        'colprice
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colprice.DefaultCellStyle = DataGridViewCellStyle8
        Me.colprice.HeaderText = "Harga"
        Me.colprice.Name = "colprice"
        Me.colprice.Width = 114
        '
        'coltotal
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.coltotal.DefaultCellStyle = DataGridViewCellStyle9
        Me.coltotal.HeaderText = "Total"
        Me.coltotal.Name = "coltotal"
        Me.coltotal.Width = 118
        '
        'coldiscount
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.coldiscount.DefaultCellStyle = DataGridViewCellStyle10
        Me.coldiscount.HeaderText = "Diskon (%)"
        Me.coldiscount.Name = "coldiscount"
        Me.coldiscount.Width = 114
        '
        'colTotalNet
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTotalNet.DefaultCellStyle = DataGridViewCellStyle11
        Me.colTotalNet.HeaderText = "Netto"
        Me.colTotalNet.Name = "colTotalNet"
        Me.colTotalNet.Width = 118
        '
        'colemployee
        '
        Me.colemployee.HeaderText = "Salesman"
        Me.colemployee.Name = "colemployee"
        Me.colemployee.Visible = False
        '
        'coltype
        '
        Me.coltype.HeaderText = "type"
        Me.coltype.Name = "coltype"
        Me.coltype.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.txtbarcode)
        Me.GroupControl2.Controls.Add(Me.txt_inv_no)
        Me.GroupControl2.Controls.Add(Me.ComboBox4)
        Me.GroupControl2.Controls.Add(Me.MtgcComboBox1)
        Me.GroupControl2.Controls.Add(Me.Label32)
        Me.GroupControl2.Controls.Add(Me.Label33)
        Me.GroupControl2.Controls.Add(Me.Label34)
        Me.GroupControl2.Location = New System.Drawing.Point(733, 7)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(257, 151)
        Me.GroupControl2.TabIndex = 294
        Me.GroupControl2.Text = "NO. TRANSAKSI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 18)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Scan Kode Barang"
        '
        'txtbarcode
        '
        Me.txtbarcode.BackColor = System.Drawing.Color.White
        Me.txtbarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbarcode.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarcode.ForeColor = System.Drawing.Color.Black
        Me.txtbarcode.Location = New System.Drawing.Point(14, 92)
        Me.txtbarcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(233, 45)
        Me.txtbarcode.TabIndex = 1
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.ForeColor = System.Drawing.Color.Black
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(-2558, 46)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(174, 26)
        Me.ComboBox4.TabIndex = 131
        Me.ComboBox4.Visible = False
        '
        'MtgcComboBox1
        '
        Me.MtgcComboBox1.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox1.ArrowColor = System.Drawing.Color.Black
        Me.MtgcComboBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MtgcComboBox1.BindedControl = CType(resources.GetObject("MtgcComboBox1.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.MtgcComboBox1.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.MtgcComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MtgcComboBox1.ColumnNum = 4
        Me.MtgcComboBox1.ColumnWidth = "150; 110; 170 ;180"
        Me.MtgcComboBox1.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox1.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox1.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox1.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.MtgcComboBox1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.MtgcComboBox1.DisplayMember = "Text"
        Me.MtgcComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MtgcComboBox1.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.MtgcComboBox1.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MtgcComboBox1.DropDownForeColor = System.Drawing.Color.Black
        Me.MtgcComboBox1.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.MtgcComboBox1.DropDownWidth = 630
        Me.MtgcComboBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtgcComboBox1.ForeColor = System.Drawing.Color.Black
        Me.MtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox1.GridLineHorizontal = True
        Me.MtgcComboBox1.GridLineVertical = True
        Me.MtgcComboBox1.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox1.HighlightBorderOnMouseEvents = True
        Me.MtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.MtgcComboBox1.Location = New System.Drawing.Point(-13205, 47)
        Me.MtgcComboBox1.ManagingFastMouseMoving = True
        Me.MtgcComboBox1.ManagingFastMouseMovingInterval = 30
        Me.MtgcComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MtgcComboBox1.Name = "MtgcComboBox1"
        Me.MtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black
        Me.MtgcComboBox1.SelectedItem = Nothing
        Me.MtgcComboBox1.SelectedValue = Nothing
        Me.MtgcComboBox1.Size = New System.Drawing.Size(140, 24)
        Me.MtgcComboBox1.TabIndex = 130
        Me.MtgcComboBox1.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(727, 79)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(125, 18)
        Me.Label32.TabIndex = 129
        Me.Label32.Text = "Tanggal Permintaan"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(727, 40)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 18)
        Me.Label33.TabIndex = 128
        Me.Label33.Text = "No Permintaan"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(10, 23)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(89, 18)
        Me.Label34.TabIndex = 102
        Me.Label34.Text = "No. Transaksi"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txt_customer_nm)
        Me.GroupControl1.Controls.Add(Me.cbo_customer)
        Me.GroupControl1.Controls.Add(Me.CheckBox1)
        Me.GroupControl1.Controls.Add(Me.txt_cust_address)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.ComboBox2)
        Me.GroupControl1.Controls.Add(Me.Label12)
        Me.GroupControl1.Controls.Add(Me.cbo_unit)
        Me.GroupControl1.Controls.Add(Me.Label18)
        Me.GroupControl1.Controls.Add(Me.Label24)
        Me.GroupControl1.Controls.Add(Me.Label29)
        Me.GroupControl1.Location = New System.Drawing.Point(6, 7)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(509, 151)
        Me.GroupControl1.TabIndex = 293
        Me.GroupControl1.Text = "INFORMASI PELANGGAN"
        '
        'cbo_customer
        '
        Me.cbo_customer.BackColor = System.Drawing.Color.White
        Me.cbo_customer.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_customer.ForeColor = System.Drawing.Color.Black
        Me.cbo_customer.FormattingEnabled = True
        Me.cbo_customer.Location = New System.Drawing.Point(14, 66)
        Me.cbo_customer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_customer.Name = "cbo_customer"
        Me.cbo_customer.Size = New System.Drawing.Size(240, 26)
        Me.cbo_customer.TabIndex = 130
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(14, 43)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 22)
        Me.CheckBox1.TabIndex = 133
        Me.CheckBox1.Text = "Member Card"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(259, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Alamat"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(-2306, 46)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(174, 26)
        Me.ComboBox2.TabIndex = 131
        Me.ComboBox2.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(10, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 18)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Pelanggan"
        '
        'cbo_unit
        '
        Me.cbo_unit.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_unit.ArrowColor = System.Drawing.Color.Black
        Me.cbo_unit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbo_unit.BindedControl = CType(resources.GetObject("cbo_unit.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_unit.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_unit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_unit.ColumnNum = 4
        Me.cbo_unit.ColumnWidth = "150; 110; 170 ;180"
        Me.cbo_unit.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_unit.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cbo_unit.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cbo_unit.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbo_unit.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo_unit.DisplayMember = "Text"
        Me.cbo_unit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_unit.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cbo_unit.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbo_unit.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_unit.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_unit.DropDownWidth = 630
        Me.cbo_unit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_unit.ForeColor = System.Drawing.Color.Black
        Me.cbo_unit.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_unit.GridLineHorizontal = True
        Me.cbo_unit.GridLineVertical = True
        Me.cbo_unit.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_unit.HighlightBorderOnMouseEvents = True
        Me.cbo_unit.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_unit.Location = New System.Drawing.Point(-13205, 47)
        Me.cbo_unit.ManagingFastMouseMoving = True
        Me.cbo_unit.ManagingFastMouseMovingInterval = 30
        Me.cbo_unit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_unit.Name = "cbo_unit"
        Me.cbo_unit.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_unit.SelectedItem = Nothing
        Me.cbo_unit.SelectedValue = Nothing
        Me.cbo_unit.Size = New System.Drawing.Size(140, 24)
        Me.cbo_unit.TabIndex = 130
        Me.cbo_unit.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(727, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 18)
        Me.Label18.TabIndex = 129
        Me.Label18.Text = "Tanggal Permintaan"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(727, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 18)
        Me.Label24.TabIndex = 128
        Me.Label24.Text = "No Permintaan"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(10, 23)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 18)
        Me.Label29.TabIndex = 102
        Me.Label29.Text = "Status Member"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.cari
        Me.Button1.Location = New System.Drawing.Point(225, -26)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 26)
        Me.Button1.TabIndex = 134
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btn_plus
        '
        Me.btn_plus.BackColor = System.Drawing.Color.Transparent
        Me.btn_plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_plus.ForeColor = System.Drawing.Color.Black
        Me.btn_plus.Image = Global.SMARTACCOUNTING.My.Resources.Resources.add
        Me.btn_plus.Location = New System.Drawing.Point(224, -27)
        Me.btn_plus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(36, 26)
        Me.btn_plus.TabIndex = 132
        Me.btn_plus.UseVisualStyleBackColor = False
        Me.btn_plus.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(192, 434)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 18)
        Me.Label4.TabIndex = 285
        Me.Label4.Text = "* Tekan Delete untuk hapus barang"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(10, 434)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 18)
        Me.Label10.TabIndex = 284
        Me.Label10.Text = "* Tekan F5 untuk pilih barang"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Appearance.Options.UseBackColor = True
        Me.TabControl1.Appearance.Options.UseForeColor = True
        Me.TabControl1.Location = New System.Drawing.Point(-32768, -32768)
        Me.TabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.TabInput
        Me.TabControl1.Size = New System.Drawing.Size(864, 944)
        Me.TabControl1.TabIndex = 79
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabInput, Me.TabList})
        Me.TabControl1.Visible = False
        '
        'TabInput
        '
        Me.TabInput.Appearance.PageClient.ForeColor = System.Drawing.Color.Black
        Me.TabInput.Appearance.PageClient.Options.UseForeColor = True
        Me.TabInput.Controls.Add(Me.Panel3)
        Me.TabInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabInput.Name = "TabInput"
        Me.TabInput.Size = New System.Drawing.Size(862, 919)
        Me.TabInput.Text = "TAMBAH / UBAH TRANSAKSI"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(862, 919)
        Me.Panel3.TabIndex = 0
        '
        'TabList
        '
        Me.TabList.Appearance.PageClient.ForeColor = System.Drawing.Color.Black
        Me.TabList.Appearance.PageClient.Options.UseForeColor = True
        Me.TabList.Controls.Add(Me.Panel5)
        Me.TabList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabList.Name = "TabList"
        Me.TabList.Size = New System.Drawing.Size(862, 919)
        Me.TabList.Text = "DAFTAR TRANSAKSI"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Controls.Add(Me.GroupControl7)
        Me.Panel5.Controls.Add(Me.GroupControl6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(862, 919)
        Me.Panel5.TabIndex = 0
        '
        'txt_tax
        '
        Me.txt_tax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_tax.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tax.ForeColor = System.Drawing.Color.Black
        Me.txt_tax.Location = New System.Drawing.Point(-1332, -521)
        Me.txt_tax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_tax.Name = "txt_tax"
        Me.txt_tax.Size = New System.Drawing.Size(140, 23)
        Me.txt_tax.TabIndex = 80
        Me.txt_tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_tax.Visible = False
        '
        'txt_customer_phone
        '
        Me.txt_customer_phone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_customer_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_customer_phone.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer_phone.ForeColor = System.Drawing.Color.Black
        Me.txt_customer_phone.Location = New System.Drawing.Point(-1167, -384)
        Me.txt_customer_phone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_customer_phone.Name = "txt_customer_phone"
        Me.txt_customer_phone.Size = New System.Drawing.Size(260, 23)
        Me.txt_customer_phone.TabIndex = 301
        Me.txt_customer_phone.Visible = False
        '
        'txt_date
        '
        Me.txt_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_date.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_date.CustomFormat = "dd-MMM-yyyy"
        Me.txt_date.ForeColor = System.Drawing.Color.Black
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date.Location = New System.Drawing.Point(-1332, -343)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(198, 23)
        Me.txt_date.TabIndex = 302
        Me.txt_date.Visible = False
        '
        'txt_disc_pay
        '
        Me.txt_disc_pay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_disc_pay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_disc_pay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_disc_pay.ForeColor = System.Drawing.Color.Black
        Me.txt_disc_pay.Location = New System.Drawing.Point(-1021, -521)
        Me.txt_disc_pay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_disc_pay.Name = "txt_disc_pay"
        Me.txt_disc_pay.Size = New System.Drawing.Size(59, 23)
        Me.txt_disc_pay.TabIndex = 303
        Me.txt_disc_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_disc_pay.Visible = False
        '
        'txt_change
        '
        Me.txt_change.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_change.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_change.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_change.Enabled = False
        Me.txt_change.ForeColor = System.Drawing.Color.Black
        Me.txt_change.Location = New System.Drawing.Point(-1137, -496)
        Me.txt_change.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_change.Name = "txt_change"
        Me.txt_change.Size = New System.Drawing.Size(140, 23)
        Me.txt_change.TabIndex = 304
        Me.txt_change.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_change.Visible = False
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.ForeColor = System.Drawing.Color.Black
        Me.txt_qty.Location = New System.Drawing.Point(-1148, -12)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_qty.Multiline = True
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(1132, 98)
        Me.txt_qty.TabIndex = 305
        Me.txt_qty.Visible = False
        '
        'txt_curr
        '
        Me.txt_curr.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_curr.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_curr.ForeColor = System.Drawing.Color.Black
        Me.txt_curr.FormattingEnabled = True
        Me.txt_curr.Location = New System.Drawing.Point(-692, 18)
        Me.txt_curr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_curr.Name = "txt_curr"
        Me.txt_curr.Size = New System.Drawing.Size(219, 26)
        Me.txt_curr.TabIndex = 306
        Me.txt_curr.Visible = False
        '
        'txt_discterm
        '
        Me.txt_discterm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_discterm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_discterm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_discterm.ForeColor = System.Drawing.Color.Black
        Me.txt_discterm.Location = New System.Drawing.Point(-191, -87)
        Me.txt_discterm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_discterm.Name = "txt_discterm"
        Me.txt_discterm.Size = New System.Drawing.Size(57, 23)
        Me.txt_discterm.TabIndex = 307
        Me.txt_discterm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_discterm.Visible = False
        '
        'txt_paid
        '
        Me.txt_paid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_paid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_paid.ForeColor = System.Drawing.Color.Black
        Me.txt_paid.Location = New System.Drawing.Point(-191, -51)
        Me.txt_paid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_paid.Name = "txt_paid"
        Me.txt_paid.Size = New System.Drawing.Size(140, 23)
        Me.txt_paid.TabIndex = 308
        Me.txt_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_paid.Visible = False
        '
        'txt_paymethod
        '
        Me.txt_paymethod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_paymethod.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_paymethod.Enabled = False
        Me.txt_paymethod.ForeColor = System.Drawing.Color.Black
        Me.txt_paymethod.FormattingEnabled = True
        Me.txt_paymethod.Location = New System.Drawing.Point(-389, 75)
        Me.txt_paymethod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_paymethod.Name = "txt_paymethod"
        Me.txt_paymethod.Size = New System.Drawing.Size(198, 26)
        Me.txt_paymethod.TabIndex = 309
        Me.txt_paymethod.Visible = False
        '
        'txt_payterm
        '
        Me.txt_payterm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_payterm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_payterm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_payterm.ForeColor = System.Drawing.Color.Black
        Me.txt_payterm.Location = New System.Drawing.Point(-108, -87)
        Me.txt_payterm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_payterm.Name = "txt_payterm"
        Me.txt_payterm.Size = New System.Drawing.Size(57, 23)
        Me.txt_payterm.TabIndex = 310
        Me.txt_payterm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_payterm.Visible = False
        '
        'txt_cust_id
        '
        Me.txt_cust_id.AutoSize = True
        Me.txt_cust_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_cust_id.ForeColor = System.Drawing.Color.Black
        Me.txt_cust_id.Location = New System.Drawing.Point(-203, 108)
        Me.txt_cust_id.Name = "txt_cust_id"
        Me.txt_cust_id.Size = New System.Drawing.Size(71, 18)
        Me.txt_cust_id.TabIndex = 311
        Me.txt_cust_id.Text = "Cust Name"
        Me.txt_cust_id.Visible = False
        '
        'cbo_akun
        '
        Me.cbo_akun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbo_akun.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_akun.ArrowColor = System.Drawing.Color.Black
        Me.cbo_akun.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbo_akun.BindedControl = CType(resources.GetObject("cbo_akun.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_akun.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_akun.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_akun.ColumnNum = 2
        Me.cbo_akun.ColumnWidth = "110; 200"
        Me.cbo_akun.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_akun.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cbo_akun.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cbo_akun.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbo_akun.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo_akun.DisplayMember = "Text"
        Me.cbo_akun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_akun.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cbo_akun.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbo_akun.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_akun.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_akun.DropDownWidth = 630
        Me.cbo_akun.ForeColor = System.Drawing.Color.Black
        Me.cbo_akun.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_akun.GridLineHorizontal = True
        Me.cbo_akun.GridLineVertical = True
        Me.cbo_akun.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_akun.HighlightBorderOnMouseEvents = True
        Me.cbo_akun.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_akun.Location = New System.Drawing.Point(-248, -103)
        Me.cbo_akun.ManagingFastMouseMoving = True
        Me.cbo_akun.ManagingFastMouseMovingInterval = 30
        Me.cbo_akun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_akun.Name = "cbo_akun"
        Me.cbo_akun.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_akun.SelectedItem = Nothing
        Me.cbo_akun.SelectedValue = Nothing
        Me.cbo_akun.Size = New System.Drawing.Size(179, 24)
        Me.cbo_akun.TabIndex = 312
        Me.cbo_akun.Visible = False
        '
        'lbl_nm_akun
        '
        Me.lbl_nm_akun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_nm_akun.AutoSize = True
        Me.lbl_nm_akun.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_nm_akun.ForeColor = System.Drawing.Color.Black
        Me.lbl_nm_akun.Location = New System.Drawing.Point(-203, -55)
        Me.lbl_nm_akun.Name = "lbl_nm_akun"
        Me.lbl_nm_akun.Size = New System.Drawing.Size(73, 18)
        Me.lbl_nm_akun.TabIndex = 313
        Me.lbl_nm_akun.Text = "Akun Bayar"
        Me.lbl_nm_akun.Visible = False
        '
        'chk_so
        '
        Me.chk_so.AutoSize = True
        Me.chk_so.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chk_so.ForeColor = System.Drawing.Color.Black
        Me.chk_so.Location = New System.Drawing.Point(-124, 46)
        Me.chk_so.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_so.Name = "chk_so"
        Me.chk_so.Size = New System.Drawing.Size(88, 22)
        Me.chk_so.TabIndex = 314
        Me.chk_so.Text = "Dari Order"
        Me.chk_so.UseVisualStyleBackColor = False
        Me.chk_so.Visible = False
        '
        'lbl_item_nm
        '
        Me.lbl_item_nm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_item_nm.AutoSize = True
        Me.lbl_item_nm.BackColor = System.Drawing.Color.Transparent
        Me.lbl_item_nm.ForeColor = System.Drawing.Color.Black
        Me.lbl_item_nm.Location = New System.Drawing.Point(-11127, 464)
        Me.lbl_item_nm.Name = "lbl_item_nm"
        Me.lbl_item_nm.Size = New System.Drawing.Size(108, 18)
        Me.lbl_item_nm.TabIndex = 315
        Me.lbl_item_nm.Text = "Cari Berdasarkan"
        Me.lbl_item_nm.Visible = False
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.Controls.Add(Me.GroupControl8)
        Me.PanelControl3.Controls.Add(Me.btn_plus)
        Me.PanelControl3.Controls.Add(Me.Panel2)
        Me.PanelControl3.Controls.Add(Me.btn_cetak)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.GroupControl5)
        Me.PanelControl3.Controls.Add(Me.btn_keluar)
        Me.PanelControl3.Controls.Add(Me.GroupControl4)
        Me.PanelControl3.Controls.Add(Me.Label10)
        Me.PanelControl3.Controls.Add(Me.GroupControl3)
        Me.PanelControl3.Controls.Add(Me.btn_reset2)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.Label4)
        Me.PanelControl3.Controls.Add(Me.btn_save2)
        Me.PanelControl3.Controls.Add(Me.btn_del2)
        Me.PanelControl3.Location = New System.Drawing.Point(9, 5)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(997, 656)
        Me.PanelControl3.TabIndex = 316
        '
        'GroupControl8
        '
        Me.GroupControl8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl8.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl8.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl8.Appearance.Options.UseBackColor = True
        Me.GroupControl8.Appearance.Options.UseFont = True
        Me.GroupControl8.Appearance.Options.UseForeColor = True
        Me.GroupControl8.Controls.Add(Me.btn_browse)
        Me.GroupControl8.Controls.Add(Me.Label5)
        Me.GroupControl8.Controls.Add(Me.txt_save_path)
        Me.GroupControl8.Location = New System.Drawing.Point(106, -300)
        Me.GroupControl8.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl8.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl8.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(1187, 273)
        Me.GroupControl8.TabIndex = 268
        Me.GroupControl8.Text = "SETTING DIREKTORI FOTO"
        Me.GroupControl8.Visible = False
        '
        'btn_browse
        '
        Me.btn_browse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_browse.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_browse.Appearance.Options.UseFont = True
        Me.btn_browse.Appearance.Options.UseForeColor = True
        Me.btn_browse.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_browse.Location = New System.Drawing.Point(9, 1716)
        Me.btn_browse.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_browse.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_browse.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(353, 212)
        Me.btn_browse.TabIndex = 282
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 279
        Me.Label5.Text = "Direktori Foto :"
        '
        'txt_save_path
        '
        Me.txt_save_path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_save_path.BackColor = System.Drawing.Color.White
        Me.txt_save_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_save_path.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_save_path.ForeColor = System.Drawing.Color.Black
        Me.txt_save_path.Location = New System.Drawing.Point(8, 83)
        Me.txt_save_path.Margin = New System.Windows.Forms.Padding(6, 10, 6, 10)
        Me.txt_save_path.Name = "txt_save_path"
        Me.txt_save_path.ReadOnly = True
        Me.txt_save_path.Size = New System.Drawing.Size(1171, 25)
        Me.txt_save_path.TabIndex = 277
        Me.txt_save_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmcashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1018, 672)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.lbl_item_nm)
        Me.Controls.Add(Me.chk_so)
        Me.Controls.Add(Me.lbl_nm_akun)
        Me.Controls.Add(Me.cbo_akun)
        Me.Controls.Add(Me.txt_cust_id)
        Me.Controls.Add(Me.txt_payterm)
        Me.Controls.Add(Me.txt_paymethod)
        Me.Controls.Add(Me.txt_paid)
        Me.Controls.Add(Me.txt_discterm)
        Me.Controls.Add(Me.txt_curr)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.txt_change)
        Me.Controls.Add(Me.txt_disc_pay)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_customer_phone)
        Me.Controls.Add(Me.txt_tax)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmcashier"
        Me.Text = "Transaksi Kasir"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.NavBarControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl3.ResumeLayout(False)
        Me.NavBarGroupControlContainer5.ResumeLayout(False)
        Me.NavBarGroupControlContainer5.PerformLayout()
        Me.NavBarGroupControlContainer6.ResumeLayout(False)
        Me.NavBarGroupControlContainer6.PerformLayout()
        Me.NavBarGroupControlContainer8.ResumeLayout(False)
        Me.NavBarGroupControlContainer8.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabInput.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        Me.GroupControl8.PerformLayout()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_inv_no As System.Windows.Forms.TextBox
    Friend WithEvents txt_cust_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_customer_nm As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_comment As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_netto As System.Windows.Forms.TextBox
    Friend WithEvents txt_disc As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
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
    Friend WithEvents chk_ppn As System.Windows.Forms.CheckBox
    Friend WithEvents txt_tax_nominal As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalcsh As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_plus As System.Windows.Forms.Button
    Friend WithEvents cbo_customer As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents NavBarControl3 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer5 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroupControlContainer6 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroup6 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents NavBarGroupControlContainer8 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroup8 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents colno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitemnm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colunit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldiscount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotalNet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colemployee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox1 As MTGCComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbo_unit As MTGCComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_ket As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cetak As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reset2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_reset_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txt_tax As System.Windows.Forms.TextBox
    Friend WithEvents txt_customer_phone As System.Windows.Forms.TextBox
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_disc_pay As System.Windows.Forms.TextBox
    Friend WithEvents txt_change As System.Windows.Forms.TextBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents txt_curr As System.Windows.Forms.ComboBox
    Friend WithEvents txt_discterm As System.Windows.Forms.TextBox
    Friend WithEvents txt_paid As System.Windows.Forms.TextBox
    Friend WithEvents txt_paymethod As System.Windows.Forms.ComboBox
    Friend WithEvents txt_payterm As System.Windows.Forms.TextBox
    Friend WithEvents txt_cust_id As System.Windows.Forms.Label
    Friend WithEvents cbo_akun As MTGCComboBox
    Friend WithEvents lbl_nm_akun As System.Windows.Forms.Label
    Friend WithEvents chk_so As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_item_nm As System.Windows.Forms.Label
    Friend WithEvents colnoinv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsupp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldisc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcetak As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_save_path As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
