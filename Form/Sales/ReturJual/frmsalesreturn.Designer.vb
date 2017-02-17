<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsalesreturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsalesreturn))
        Me.cbo_paymethod = New System.Windows.Forms.ComboBox()
        Me.cbo_sales_no = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitemnm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colunit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colconfirm = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colnoinv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsalesreturnno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsupp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcetak = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_return_no = New System.Windows.Forms.TextBox()
        Me.btn_cetak = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reset2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_kurs = New System.Windows.Forms.Label()
        Me.txt_disc = New System.Windows.Forms.TextBox()
        Me.txt_idsupplier = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chk_po = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.txt_tax_nom = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_disc_nom = New System.Windows.Forms.TextBox()
        Me.txt_nett = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_comment = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox3 = New MTGCComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_kurs = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MtgcComboBox2 = New MTGCComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_ket = New System.Windows.Forms.TextBox()
        Me.txt_cust_address = New System.Windows.Forms.TextBox()
        Me.txt_cust_nm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.txt_so_no = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MtgcComboBox1 = New MTGCComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabInput = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_tax = New System.Windows.Forms.TextBox()
        Me.TabList = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridList_Customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_browse = New DevExpress.XtraEditors.SimpleButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_save_path = New System.Windows.Forms.TextBox()
        Me.cbo_filterwh_purch1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabInput.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.cbo_filterwh_purch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbo_paymethod
        '
        Me.cbo_paymethod.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_paymethod.FormattingEnabled = True
        Me.cbo_paymethod.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cbo_paymethod.Location = New System.Drawing.Point(8, 90)
        Me.cbo_paymethod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_paymethod.Name = "cbo_paymethod"
        Me.cbo_paymethod.Size = New System.Drawing.Size(151, 26)
        Me.cbo_paymethod.TabIndex = 10
        '
        'cbo_sales_no
        '
        Me.cbo_sales_no.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_sales_no.FormattingEnabled = True
        Me.cbo_sales_no.Location = New System.Drawing.Point(8, 42)
        Me.cbo_sales_no.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_sales_no.Name = "cbo_sales_no"
        Me.cbo_sales_no.Size = New System.Drawing.Size(207, 26)
        Me.cbo_sales_no.TabIndex = 70
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colno, Me.colitem, Me.colitemnm, Me.coldesc, Me.colqty, Me.colunit, Me.colprice, Me.coltotal, Me.colconfirm})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(973, 206)
        Me.DataGridView1.TabIndex = 10
        '
        'colno
        '
        Me.colno.HeaderText = "No"
        Me.colno.Name = "colno"
        Me.colno.ReadOnly = True
        Me.colno.Width = 40
        '
        'colitem
        '
        Me.colitem.HeaderText = "Kode Barang"
        Me.colitem.Name = "colitem"
        Me.colitem.ReadOnly = True
        Me.colitem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colitem.Width = 140
        '
        'colitemnm
        '
        Me.colitemnm.HeaderText = "Nama Barang"
        Me.colitemnm.Name = "colitemnm"
        Me.colitemnm.ReadOnly = True
        Me.colitemnm.Width = 190
        '
        'coldesc
        '
        Me.coldesc.HeaderText = "Keterangan"
        Me.coldesc.Name = "coldesc"
        Me.coldesc.ReadOnly = True
        Me.coldesc.Width = 155
        '
        'colqty
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colqty.DefaultCellStyle = DataGridViewCellStyle2
        Me.colqty.HeaderText = "Qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Width = 75
        '
        'colunit
        '
        Me.colunit.HeaderText = "Unit"
        Me.colunit.Name = "colunit"
        Me.colunit.ReadOnly = True
        Me.colunit.Width = 90
        '
        'colprice
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colprice.DefaultCellStyle = DataGridViewCellStyle3
        Me.colprice.HeaderText = "Harga"
        Me.colprice.Name = "colprice"
        Me.colprice.ReadOnly = True
        Me.colprice.Width = 115
        '
        'coltotal
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.coltotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.coltotal.HeaderText = "Total"
        Me.coltotal.Name = "coltotal"
        Me.coltotal.ReadOnly = True
        Me.coltotal.Width = 120
        '
        'colconfirm
        '
        Me.colconfirm.HeaderText = "Pilih"
        Me.colconfirm.Name = "colconfirm"
        Me.colconfirm.Width = 50
        '
        'GroupControl7
        '
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
        Me.GroupControl7.Location = New System.Drawing.Point(13, 14)
        Me.GroupControl7.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(194, 749)
        Me.GroupControl7.TabIndex = 286
        Me.GroupControl7.Text = "PANEL PENCARIAN"
        '
        'btn_reset_cust
        '
        Me.btn_reset_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_cust.Appearance.Options.UseFont = True
        Me.btn_reset_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset_cust.Location = New System.Drawing.Point(16, 396)
        Me.btn_reset_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_reset_cust.Name = "btn_reset_cust"
        Me.btn_reset_cust.Size = New System.Drawing.Size(75, 43)
        Me.btn_reset_cust.TabIndex = 276
        Me.btn_reset_cust.Text = "RESET"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(18, 41)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 18)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Cari Berdasarkan"
        '
        'txt_search
        '
        Me.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(21, 116)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(155, 62)
        Me.txt_search.TabIndex = 23
        '
        'btn_cari_cust
        '
        Me.btn_cari_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_cust.Appearance.Options.UseFont = True
        Me.btn_cari_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Search_16x16
        Me.btn_cari_cust.Location = New System.Drawing.Point(97, 396)
        Me.btn_cari_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cari_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cari_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cari_cust.Name = "btn_cari_cust"
        Me.btn_cari_cust.Size = New System.Drawing.Size(79, 43)
        Me.btn_cari_cust.TabIndex = 275
        Me.btn_cari_cust.Text = "CARI"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(18, 95)
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
        Me.GroupBox3.Location = New System.Drawing.Point(16, 185)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(160, 202)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter Tanggal"
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.Location = New System.Drawing.Point(19, 37)
        Me.chk_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(120, 22)
        Me.chk_date.TabIndex = 38
        Me.chk_date.Text = "Dengan Batasan"
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(21, 134)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 18)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Sampai"
        '
        'tglakhir
        '
        Me.tglakhir.CustomFormat = "dd-MM-yyyy"
        Me.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglakhir.Location = New System.Drawing.Point(24, 156)
        Me.tglakhir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(111, 23)
        Me.tglakhir.TabIndex = 36
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(21, 82)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 18)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Dari"
        '
        'tglawal
        '
        Me.tglawal.CustomFormat = "dd-MM-yyyy"
        Me.tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglawal.Location = New System.Drawing.Point(24, 103)
        Me.tglawal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglawal.Name = "tglawal"
        Me.tglawal.Size = New System.Drawing.Size(111, 23)
        Me.tglawal.TabIndex = 34
        '
        'cbo_search
        '
        Me.cbo_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"Return No", "Customer"})
        Me.cbo_search.Location = New System.Drawing.Point(21, 62)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(155, 26)
        Me.cbo_search.TabIndex = 19
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnoinv, Me.colsalesreturnno, Me.colsupp, Me.coldate, Me.colsubtotal, Me.coltax, Me.colamount, Me.coldescript, Me.colcetak})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(780, 726)
        Me.DataGridView2.TabIndex = 13
        '
        'colnoinv
        '
        Me.colnoinv.HeaderText = "No Faktur"
        Me.colnoinv.Name = "colnoinv"
        Me.colnoinv.ReadOnly = True
        Me.colnoinv.Width = 170
        '
        'colsalesreturnno
        '
        Me.colsalesreturnno.HeaderText = "No Retur"
        Me.colsalesreturnno.Name = "colsalesreturnno"
        Me.colsalesreturnno.ReadOnly = True
        Me.colsalesreturnno.Width = 170
        '
        'colsupp
        '
        Me.colsupp.HeaderText = "Pelanggan"
        Me.colsupp.Name = "colsupp"
        Me.colsupp.ReadOnly = True
        Me.colsupp.Width = 190
        '
        'coldate
        '
        Me.coldate.HeaderText = "Tanggal"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        Me.coldate.Width = 95
        '
        'colsubtotal
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colsubtotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.colsubtotal.HeaderText = "Sub Total"
        Me.colsubtotal.Name = "colsubtotal"
        Me.colsubtotal.ReadOnly = True
        Me.colsubtotal.Width = 105
        '
        'coltax
        '
        Me.coltax.HeaderText = "PPN"
        Me.coltax.Name = "coltax"
        Me.coltax.ReadOnly = True
        Me.coltax.Width = 60
        '
        'colamount
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colamount.DefaultCellStyle = DataGridViewCellStyle7
        Me.colamount.HeaderText = "Total"
        Me.colamount.Name = "colamount"
        Me.colamount.ReadOnly = True
        Me.colamount.Width = 108
        '
        'coldescript
        '
        Me.coldescript.HeaderText = "Keterangan"
        Me.coldescript.Name = "coldescript"
        Me.coldescript.ReadOnly = True
        '
        'colcetak
        '
        Me.colcetak.HeaderText = "Lihat Retur"
        Me.colcetak.Name = "colcetak"
        Me.colcetak.ReadOnly = True
        Me.colcetak.Text = "Cetak Bukti"
        Me.colcetak.UseColumnTextForButtonValue = True
        Me.colcetak.Width = 95
        '
        'txt_date
        '
        Me.txt_date.CustomFormat = "dd-MMM-yyyy"
        Me.txt_date.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date.Location = New System.Drawing.Point(8, 44)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(151, 23)
        Me.txt_date.TabIndex = 7
        '
        'txt_return_no
        '
        Me.txt_return_no.BackColor = System.Drawing.Color.Lavender
        Me.txt_return_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_return_no.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_return_no.Location = New System.Drawing.Point(172, 44)
        Me.txt_return_no.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_return_no.Name = "txt_return_no"
        Me.txt_return_no.ReadOnly = True
        Me.txt_return_no.Size = New System.Drawing.Size(186, 23)
        Me.txt_return_no.TabIndex = 5
        '
        'btn_cetak
        '
        Me.btn_cetak.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.Appearance.Options.UseFont = True
        Me.btn_cetak.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Print_16x16
        Me.btn_cetak.Location = New System.Drawing.Point(108, 589)
        Me.btn_cetak.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cetak.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cetak.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(119, 39)
        Me.btn_cetak.TabIndex = 20
        Me.btn_cetak.Text = "LIHAT - CETAK"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(5, 589)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(97, 39)
        Me.btn_keluar.TabIndex = 19
        Me.btn_keluar.Text = "KELUAR"
        '
        'btn_reset2
        '
        Me.btn_reset2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset2.Appearance.Options.UseFont = True
        Me.btn_reset2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset2.Location = New System.Drawing.Point(724, 589)
        Me.btn_reset2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_reset2.Name = "btn_reset2"
        Me.btn_reset2.Size = New System.Drawing.Size(82, 39)
        Me.btn_reset2.TabIndex = 18
        Me.btn_reset2.Text = "RESET"
        '
        'btn_del2
        '
        Me.btn_del2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del2.Appearance.Options.UseFont = True
        Me.btn_del2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Delete_16x16
        Me.btn_del2.Location = New System.Drawing.Point(812, 589)
        Me.btn_del2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_del2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_del2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_del2.Name = "btn_del2"
        Me.btn_del2.Size = New System.Drawing.Size(82, 39)
        Me.btn_del2.TabIndex = 17
        Me.btn_del2.Text = "HAPUS"
        '
        'btn_save2
        '
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(900, 589)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 39)
        Me.btn_save2.TabIndex = 16
        Me.btn_save2.Text = "SIMPAN"
        '
        'GroupControl6
        '
        Me.GroupControl6.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl6.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl6.Appearance.Options.UseBackColor = True
        Me.GroupControl6.Appearance.Options.UseFont = True
        Me.GroupControl6.Appearance.Options.UseForeColor = True
        Me.GroupControl6.Controls.Add(Me.lbl_kurs)
        Me.GroupControl6.Controls.Add(Me.txt_disc)
        Me.GroupControl6.Controls.Add(Me.txt_idsupplier)
        Me.GroupControl6.Controls.Add(Me.Label17)
        Me.GroupControl6.Controls.Add(Me.TextBox4)
        Me.GroupControl6.Controls.Add(Me.Label19)
        Me.GroupControl6.Controls.Add(Me.chk_po)
        Me.GroupControl6.Controls.Add(Me.Label21)
        Me.GroupControl6.Controls.Add(Me.Label36)
        Me.GroupControl6.Controls.Add(Me.Label22)
        Me.GroupControl6.Controls.Add(Me.TextBox16)
        Me.GroupControl6.Controls.Add(Me.Label23)
        Me.GroupControl6.Controls.Add(Me.TextBox17)
        Me.GroupControl6.Controls.Add(Me.txt_tax_nom)
        Me.GroupControl6.Controls.Add(Me.TextBox18)
        Me.GroupControl6.Controls.Add(Me.txt_subtotal)
        Me.GroupControl6.Controls.Add(Me.txt_disc_nom)
        Me.GroupControl6.Controls.Add(Me.txt_nett)
        Me.GroupControl6.Controls.Add(Me.txt_total)
        Me.GroupControl6.Location = New System.Drawing.Point(765, 425)
        Me.GroupControl6.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(217, 150)
        Me.GroupControl6.TabIndex = 318
        Me.GroupControl6.Text = "TOTAL"
        '
        'lbl_kurs
        '
        Me.lbl_kurs.AutoSize = True
        Me.lbl_kurs.BackColor = System.Drawing.Color.Transparent
        Me.lbl_kurs.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kurs.ForeColor = System.Drawing.Color.Black
        Me.lbl_kurs.Location = New System.Drawing.Point(-32768, 78)
        Me.lbl_kurs.Name = "lbl_kurs"
        Me.lbl_kurs.Size = New System.Drawing.Size(56, 18)
        Me.lbl_kurs.TabIndex = 288
        Me.lbl_kurs.Text = "Subtotal"
        Me.lbl_kurs.Visible = False
        '
        'txt_disc
        '
        Me.txt_disc.BackColor = System.Drawing.Color.Lavender
        Me.txt_disc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_disc.Enabled = False
        Me.txt_disc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disc.Location = New System.Drawing.Point(-32768, 76)
        Me.txt_disc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_disc.Name = "txt_disc"
        Me.txt_disc.ReadOnly = True
        Me.txt_disc.Size = New System.Drawing.Size(136, 23)
        Me.txt_disc.TabIndex = 287
        Me.txt_disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_disc.Visible = False
        '
        'txt_idsupplier
        '
        Me.txt_idsupplier.BackColor = System.Drawing.Color.Lavender
        Me.txt_idsupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idsupplier.Enabled = False
        Me.txt_idsupplier.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idsupplier.Location = New System.Drawing.Point(-32768, 76)
        Me.txt_idsupplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_idsupplier.Name = "txt_idsupplier"
        Me.txt_idsupplier.ReadOnly = True
        Me.txt_idsupplier.Size = New System.Drawing.Size(136, 23)
        Me.txt_idsupplier.TabIndex = 286
        Me.txt_idsupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_idsupplier.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(10, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 18)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Subtotal"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(-1255, 92)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(143, 23)
        Me.TextBox4.TabIndex = 285
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox4.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(28, 124)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 18)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Total"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_po
        '
        Me.chk_po.AutoSize = True
        Me.chk_po.BackColor = System.Drawing.Color.Transparent
        Me.chk_po.Enabled = False
        Me.chk_po.ForeColor = System.Drawing.Color.Black
        Me.chk_po.Location = New System.Drawing.Point(-14102, 92)
        Me.chk_po.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_po.Name = "chk_po"
        Me.chk_po.Size = New System.Drawing.Size(49, 22)
        Me.chk_po.TabIndex = 284
        Me.chk_po.Text = "PPN"
        Me.chk_po.UseVisualStyleBackColor = False
        Me.chk_po.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(36, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 18)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "PPN"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(95, -1535)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(63, 18)
        Me.Label36.TabIndex = 283
        Me.Label36.Text = "Sub Total"
        Me.Label36.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(26, 75)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 18)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Netto"
        '
        'TextBox16
        '
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox16.Location = New System.Drawing.Point(11, -1350)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(971, 85)
        Me.TextBox16.TabIndex = 282
        Me.TextBox16.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(19, 49)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 18)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "Diskon"
        '
        'TextBox17
        '
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox17.Location = New System.Drawing.Point(11, -1350)
        Me.TextBox17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox17.Multiline = True
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(971, 85)
        Me.TextBox17.TabIndex = 281
        Me.TextBox17.Visible = False
        '
        'txt_tax_nom
        '
        Me.txt_tax_nom.BackColor = System.Drawing.Color.Lavender
        Me.txt_tax_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tax_nom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tax_nom.Location = New System.Drawing.Point(74, 97)
        Me.txt_tax_nom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_tax_nom.Name = "txt_tax_nom"
        Me.txt_tax_nom.ReadOnly = True
        Me.txt_tax_nom.Size = New System.Drawing.Size(136, 23)
        Me.txt_tax_nom.TabIndex = 79
        Me.txt_tax_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox18
        '
        Me.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox18.Location = New System.Drawing.Point(-1042, 23)
        Me.TextBox18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox18.Multiline = True
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(971, 85)
        Me.TextBox18.TabIndex = 280
        Me.TextBox18.Visible = False
        '
        'txt_subtotal
        '
        Me.txt_subtotal.BackColor = System.Drawing.Color.Lavender
        Me.txt_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(74, 22)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(136, 23)
        Me.txt_subtotal.TabIndex = 39
        Me.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_disc_nom
        '
        Me.txt_disc_nom.BackColor = System.Drawing.Color.Lavender
        Me.txt_disc_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_disc_nom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disc_nom.Location = New System.Drawing.Point(74, 47)
        Me.txt_disc_nom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_disc_nom.Name = "txt_disc_nom"
        Me.txt_disc_nom.ReadOnly = True
        Me.txt_disc_nom.Size = New System.Drawing.Size(136, 23)
        Me.txt_disc_nom.TabIndex = 78
        Me.txt_disc_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_nett
        '
        Me.txt_nett.BackColor = System.Drawing.Color.Lavender
        Me.txt_nett.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nett.Enabled = False
        Me.txt_nett.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nett.Location = New System.Drawing.Point(74, 72)
        Me.txt_nett.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nett.Name = "txt_nett"
        Me.txt_nett.ReadOnly = True
        Me.txt_nett.Size = New System.Drawing.Size(136, 23)
        Me.txt_nett.TabIndex = 45
        Me.txt_nett.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.Lavender
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(74, 122)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(136, 23)
        Me.txt_total.TabIndex = 42
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupControl5
        '
        Me.GroupControl5.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl5.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl5.Appearance.Options.UseBackColor = True
        Me.GroupControl5.Appearance.Options.UseFont = True
        Me.GroupControl5.Appearance.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.txt_comment)
        Me.GroupControl5.Controls.Add(Me.TextBox9)
        Me.GroupControl5.Controls.Add(Me.TextBox14)
        Me.GroupControl5.Controls.Add(Me.TextBox15)
        Me.GroupControl5.Controls.Add(Me.Label35)
        Me.GroupControl5.Location = New System.Drawing.Point(5, 425)
        Me.GroupControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(497, 150)
        Me.GroupControl5.TabIndex = 317
        Me.GroupControl5.Text = "NOTES"
        '
        'txt_comment
        '
        Me.txt_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comment.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comment.Location = New System.Drawing.Point(8, 50)
        Me.txt_comment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_comment.Multiline = True
        Me.txt_comment.Name = "txt_comment"
        Me.txt_comment.Size = New System.Drawing.Size(484, 92)
        Me.txt_comment.TabIndex = 20
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Location = New System.Drawing.Point(11, -1350)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(971, 85)
        Me.TextBox9.TabIndex = 282
        Me.TextBox9.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox14.Location = New System.Drawing.Point(11, -1350)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(971, 85)
        Me.TextBox14.TabIndex = 281
        Me.TextBox14.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox15.Location = New System.Drawing.Point(-1042, 23)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(971, 85)
        Me.TextBox15.TabIndex = 280
        Me.TextBox15.Visible = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(5, 25)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(79, 18)
        Me.Label35.TabIndex = 279
        Me.Label35.Text = "Keterangan:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Appearance.Options.UseFont = True
        Me.GroupControl3.Appearance.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.TextBox3)
        Me.GroupControl3.Controls.Add(Me.Label34)
        Me.GroupControl3.Controls.Add(Me.TextBox10)
        Me.GroupControl3.Controls.Add(Me.TextBox11)
        Me.GroupControl3.Controls.Add(Me.TextBox12)
        Me.GroupControl3.Controls.Add(Me.TextBox13)
        Me.GroupControl3.Controls.Add(Me.ComboBox5)
        Me.GroupControl3.Controls.Add(Me.MtgcComboBox3)
        Me.GroupControl3.Controls.Add(Me.Label37)
        Me.GroupControl3.Controls.Add(Me.Label38)
        Me.GroupControl3.Controls.Add(Me.DataGridView1)
        Me.GroupControl3.Location = New System.Drawing.Point(5, 184)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(977, 229)
        Me.GroupControl3.TabIndex = 315
        Me.GroupControl3.Text = "DATA BARANG"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(212, 23)
        Me.TextBox3.TabIndex = 137
        Me.TextBox3.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(-32768, 65)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(95, 18)
        Me.Label34.TabIndex = 136
        Me.Label34.Text = "Cari Pelanggan"
        Me.Label34.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Enabled = False
        Me.TextBox10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(212, 23)
        Me.TextBox10.TabIndex = 135
        Me.TextBox10.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Enabled = False
        Me.TextBox11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(212, 23)
        Me.TextBox11.TabIndex = 134
        Me.TextBox11.Visible = False
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(212, 23)
        Me.TextBox12.TabIndex = 133
        Me.TextBox12.Visible = False
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.White
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox13.Enabled = False
        Me.TextBox13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(212, 23)
        Me.TextBox13.TabIndex = 132
        Me.TextBox13.Visible = False
        '
        'ComboBox5
        '
        Me.ComboBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(-1436, 40)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox5.TabIndex = 131
        Me.ComboBox5.Visible = False
        '
        'MtgcComboBox3
        '
        Me.MtgcComboBox3.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox3.ArrowColor = System.Drawing.Color.Black
        Me.MtgcComboBox3.BindedControl = CType(resources.GetObject("MtgcComboBox3.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.MtgcComboBox3.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.MtgcComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MtgcComboBox3.ColumnNum = 4
        Me.MtgcComboBox3.ColumnWidth = "150; 110; 170 ;180"
        Me.MtgcComboBox3.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox3.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox3.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox3.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.MtgcComboBox3.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.MtgcComboBox3.DisplayMember = "Text"
        Me.MtgcComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MtgcComboBox3.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.MtgcComboBox3.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MtgcComboBox3.DropDownForeColor = System.Drawing.Color.Black
        Me.MtgcComboBox3.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.MtgcComboBox3.DropDownWidth = 630
        Me.MtgcComboBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtgcComboBox3.GridLineColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox3.GridLineHorizontal = True
        Me.MtgcComboBox3.GridLineVertical = True
        Me.MtgcComboBox3.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox3.HighlightBorderOnMouseEvents = True
        Me.MtgcComboBox3.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.MtgcComboBox3.Location = New System.Drawing.Point(-11319, 41)
        Me.MtgcComboBox3.ManagingFastMouseMoving = True
        Me.MtgcComboBox3.ManagingFastMouseMovingInterval = 30
        Me.MtgcComboBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MtgcComboBox3.Name = "MtgcComboBox3"
        Me.MtgcComboBox3.NormalBorderColor = System.Drawing.Color.Black
        Me.MtgcComboBox3.SelectedItem = Nothing
        Me.MtgcComboBox3.SelectedValue = Nothing
        Me.MtgcComboBox3.Size = New System.Drawing.Size(121, 24)
        Me.MtgcComboBox3.TabIndex = 130
        Me.MtgcComboBox3.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(1014, 73)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(125, 18)
        Me.Label37.TabIndex = 129
        Me.Label37.Text = "Tanggal Permintaan"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(1014, 40)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(94, 18)
        Me.Label38.TabIndex = 128
        Me.Label38.Text = "No Permintaan"
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.Label15)
        Me.GroupControl2.Controls.Add(Me.txt_kurs)
        Me.GroupControl2.Controls.Add(Me.Label14)
        Me.GroupControl2.Controls.Add(Me.txt_return_no)
        Me.GroupControl2.Controls.Add(Me.cbo_paymethod)
        Me.GroupControl2.Controls.Add(Me.txt_date)
        Me.GroupControl2.Controls.Add(Me.TextBox1)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.TextBox5)
        Me.GroupControl2.Controls.Add(Me.TextBox6)
        Me.GroupControl2.Controls.Add(Me.TextBox7)
        Me.GroupControl2.Controls.Add(Me.TextBox8)
        Me.GroupControl2.Controls.Add(Me.Label8)
        Me.GroupControl2.Controls.Add(Me.ComboBox4)
        Me.GroupControl2.Controls.Add(Me.Label9)
        Me.GroupControl2.Controls.Add(Me.MtgcComboBox2)
        Me.GroupControl2.Controls.Add(Me.Label11)
        Me.GroupControl2.Controls.Add(Me.Label12)
        Me.GroupControl2.Controls.Add(Me.Label13)
        Me.GroupControl2.Controls.Add(Me.cbo_filterwh_purch1)
        Me.GroupControl2.Location = New System.Drawing.Point(614, 6)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(368, 170)
        Me.GroupControl2.TabIndex = 314
        Me.GroupControl2.Text = "INFORMASI RETUR"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(5, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 18)
        Me.Label15.TabIndex = 292
        Me.Label15.Text = "Gudang"
        '
        'txt_kurs
        '
        Me.txt_kurs.BackColor = System.Drawing.Color.Lavender
        Me.txt_kurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kurs.Location = New System.Drawing.Point(172, 92)
        Me.txt_kurs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_kurs.Name = "txt_kurs"
        Me.txt_kurs.ReadOnly = True
        Me.txt_kurs.Size = New System.Drawing.Size(186, 23)
        Me.txt_kurs.TabIndex = 291
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(169, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 18)
        Me.Label14.TabIndex = 138
        Me.Label14.Text = "Kurs Default"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(212, 23)
        Me.TextBox1.TabIndex = 137
        Me.TextBox1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-32768, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Cari Pelanggan"
        Me.Label3.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(212, 23)
        Me.TextBox5.TabIndex = 135
        Me.TextBox5.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(212, 23)
        Me.TextBox6.TabIndex = 134
        Me.TextBox6.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(212, 23)
        Me.TextBox7.TabIndex = 133
        Me.TextBox7.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Enabled = False
        Me.TextBox8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(212, 23)
        Me.TextBox8.TabIndex = 132
        Me.TextBox8.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(169, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "No Retur"
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(-2045, 40)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox4.TabIndex = 131
        Me.ComboBox4.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(5, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cara Pembayaran"
        '
        'MtgcComboBox2
        '
        Me.MtgcComboBox2.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox2.ArrowColor = System.Drawing.Color.Black
        Me.MtgcComboBox2.BindedControl = CType(resources.GetObject("MtgcComboBox2.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.MtgcComboBox2.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.MtgcComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MtgcComboBox2.ColumnNum = 4
        Me.MtgcComboBox2.ColumnWidth = "150; 110; 170 ;180"
        Me.MtgcComboBox2.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox2.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox2.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox2.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.MtgcComboBox2.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.MtgcComboBox2.DisplayMember = "Text"
        Me.MtgcComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MtgcComboBox2.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.MtgcComboBox2.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MtgcComboBox2.DropDownForeColor = System.Drawing.Color.Black
        Me.MtgcComboBox2.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.MtgcComboBox2.DropDownWidth = 630
        Me.MtgcComboBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtgcComboBox2.GridLineColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox2.GridLineHorizontal = True
        Me.MtgcComboBox2.GridLineVertical = True
        Me.MtgcComboBox2.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox2.HighlightBorderOnMouseEvents = True
        Me.MtgcComboBox2.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.MtgcComboBox2.Location = New System.Drawing.Point(-11319, 41)
        Me.MtgcComboBox2.ManagingFastMouseMoving = True
        Me.MtgcComboBox2.ManagingFastMouseMovingInterval = 30
        Me.MtgcComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MtgcComboBox2.Name = "MtgcComboBox2"
        Me.MtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black
        Me.MtgcComboBox2.SelectedItem = Nothing
        Me.MtgcComboBox2.SelectedValue = Nothing
        Me.MtgcComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.MtgcComboBox2.TabIndex = 130
        Me.MtgcComboBox2.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(623, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 18)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Tanggal Permintaan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(623, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 18)
        Me.Label12.TabIndex = 128
        Me.Label12.Text = "No Permintaan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(5, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 18)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Tanggal"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.cbo_sales_no)
        Me.GroupControl1.Controls.Add(Me.txt_ket)
        Me.GroupControl1.Controls.Add(Me.txt_cust_address)
        Me.GroupControl1.Controls.Add(Me.txt_cust_nm)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.TextBox2)
        Me.GroupControl1.Controls.Add(Me.txt_price)
        Me.GroupControl1.Controls.Add(Me.txt_qty)
        Me.GroupControl1.Controls.Add(Me.txt_so_no)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.ComboBox2)
        Me.GroupControl1.Controls.Add(Me.Label16)
        Me.GroupControl1.Controls.Add(Me.MtgcComboBox1)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 6)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(520, 125)
        Me.GroupControl1.TabIndex = 313
        Me.GroupControl1.Text = "INFORMASI PELANGGAN"
        '
        'txt_ket
        '
        Me.txt_ket.BackColor = System.Drawing.Color.White
        Me.txt_ket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ket.Enabled = False
        Me.txt_ket.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ket.Location = New System.Drawing.Point(-32768, 62)
        Me.txt_ket.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ket.Name = "txt_ket"
        Me.txt_ket.ReadOnly = True
        Me.txt_ket.Size = New System.Drawing.Size(212, 23)
        Me.txt_ket.TabIndex = 137
        Me.txt_ket.Visible = False
        '
        'txt_cust_address
        '
        Me.txt_cust_address.BackColor = System.Drawing.Color.Lavender
        Me.txt_cust_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cust_address.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust_address.Location = New System.Drawing.Point(225, 42)
        Me.txt_cust_address.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cust_address.Multiline = True
        Me.txt_cust_address.Name = "txt_cust_address"
        Me.txt_cust_address.ReadOnly = True
        Me.txt_cust_address.Size = New System.Drawing.Size(283, 73)
        Me.txt_cust_address.TabIndex = 3
        '
        'txt_cust_nm
        '
        Me.txt_cust_nm.BackColor = System.Drawing.Color.Lavender
        Me.txt_cust_nm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cust_nm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust_nm.Location = New System.Drawing.Point(8, 92)
        Me.txt_cust_nm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cust_nm.Name = "txt_cust_nm"
        Me.txt_cust_nm.ReadOnly = True
        Me.txt_cust_nm.Size = New System.Drawing.Size(207, 23)
        Me.txt_cust_nm.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-32768, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Cari Pelanggan"
        Me.Label4.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(-32768, 62)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(212, 23)
        Me.TextBox2.TabIndex = 135
        Me.TextBox2.Visible = False
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.Color.White
        Me.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_price.Enabled = False
        Me.txt_price.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(-32768, 62)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(212, 23)
        Me.txt_price.TabIndex = 134
        Me.txt_price.Visible = False
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.Color.White
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Enabled = False
        Me.txt_qty.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(-32768, 62)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.ReadOnly = True
        Me.txt_qty.Size = New System.Drawing.Size(212, 23)
        Me.txt_qty.TabIndex = 133
        Me.txt_qty.Visible = False
        '
        'txt_so_no
        '
        Me.txt_so_no.BackColor = System.Drawing.Color.White
        Me.txt_so_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_so_no.Enabled = False
        Me.txt_so_no.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_so_no.Location = New System.Drawing.Point(-32768, 62)
        Me.txt_so_no.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_so_no.Name = "txt_so_no"
        Me.txt_so_no.ReadOnly = True
        Me.txt_so_no.Size = New System.Drawing.Size(212, 23)
        Me.txt_so_no.TabIndex = 132
        Me.txt_so_no.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(222, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Alamat"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(-1893, 40)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox2.TabIndex = 131
        Me.ComboBox2.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(5, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 18)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Nama Pelanggan"
        '
        'MtgcComboBox1
        '
        Me.MtgcComboBox1.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox1.ArrowColor = System.Drawing.Color.Black
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
        Me.MtgcComboBox1.GridLineColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox1.GridLineHorizontal = True
        Me.MtgcComboBox1.GridLineVertical = True
        Me.MtgcComboBox1.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.MtgcComboBox1.HighlightBorderOnMouseEvents = True
        Me.MtgcComboBox1.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.MtgcComboBox1.Location = New System.Drawing.Point(-11319, 41)
        Me.MtgcComboBox1.ManagingFastMouseMoving = True
        Me.MtgcComboBox1.ManagingFastMouseMovingInterval = 30
        Me.MtgcComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MtgcComboBox1.Name = "MtgcComboBox1"
        Me.MtgcComboBox1.NormalBorderColor = System.Drawing.Color.Black
        Me.MtgcComboBox1.SelectedItem = Nothing
        Me.MtgcComboBox1.SelectedValue = Nothing
        Me.MtgcComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.MtgcComboBox1.TabIndex = 130
        Me.MtgcComboBox1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(623, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 18)
        Me.Label6.TabIndex = 129
        Me.Label6.Text = "Tanggal Permintaan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(623, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "No Permintaan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "No Faktur Jual"
        '
        'GroupControl8
        '
        Me.GroupControl8.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl8.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl8.Appearance.Options.UseBackColor = True
        Me.GroupControl8.Appearance.Options.UseFont = True
        Me.GroupControl8.Appearance.Options.UseForeColor = True
        Me.GroupControl8.Controls.Add(Me.DataGridView2)
        Me.GroupControl8.Location = New System.Drawing.Point(217, 16)
        Me.GroupControl8.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl8.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(784, 749)
        Me.GroupControl8.TabIndex = 299
        Me.GroupControl8.Text = "DAFTAR PENGIRIMAN"
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(-32768, -32768)
        Me.TabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.TabInput
        Me.TabControl1.Size = New System.Drawing.Size(929, 806)
        Me.TabControl1.TabIndex = 82
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabInput, Me.TabList})
        Me.TabControl1.Visible = False
        '
        'TabInput
        '
        Me.TabInput.Controls.Add(Me.Panel2)
        Me.TabInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabInput.Name = "TabInput"
        Me.TabInput.Size = New System.Drawing.Size(927, 781)
        Me.TabInput.Text = "TAMBAH / UBAH RETUR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.txt_tax)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(927, 781)
        Me.Panel2.TabIndex = 0
        '
        'txt_tax
        '
        Me.txt_tax.BackColor = System.Drawing.Color.Lavender
        Me.txt_tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tax.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tax.Location = New System.Drawing.Point(23438, 374)
        Me.txt_tax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_tax.Name = "txt_tax"
        Me.txt_tax.ReadOnly = True
        Me.txt_tax.Size = New System.Drawing.Size(136, 23)
        Me.txt_tax.TabIndex = 320
        Me.txt_tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_tax.Visible = False
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.Panel3)
        Me.TabList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabList.Name = "TabList"
        Me.TabList.Size = New System.Drawing.Size(927, 781)
        Me.TabList.Text = "DAFTAR RETUR"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.GroupControl8)
        Me.Panel3.Controls.Add(Me.GroupControl7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(927, 781)
        Me.Panel3.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl5.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl5.Appearance.Options.UseBackColor = True
        Me.PanelControl5.Appearance.Options.UseForeColor = True
        Me.PanelControl5.Controls.Add(Me.SimpleButton4)
        Me.PanelControl5.Controls.Add(Me.SimpleButton8)
        Me.PanelControl5.Controls.Add(Me.SimpleButton3)
        Me.PanelControl5.Location = New System.Drawing.Point(10, 607)
        Me.PanelControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(993, 49)
        Me.PanelControl5.TabIndex = 299
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Appearance.Options.UseForeColor = True
        Me.SimpleButton4.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.SimpleButton4.Location = New System.Drawing.Point(895, 6)
        Me.SimpleButton4.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 37)
        Me.SimpleButton4.TabIndex = 294
        Me.SimpleButton4.Text = "TUTUP"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton8.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton8.Appearance.Options.UseFont = True
        Me.SimpleButton8.Appearance.Options.UseForeColor = True
        Me.SimpleButton8.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.SimpleButton8.Location = New System.Drawing.Point(796, 6)
        Me.SimpleButton8.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton8.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(92, 37)
        Me.SimpleButton8.TabIndex = 295
        Me.SimpleButton8.Text = "REFRESH"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.Image = Global.SMARTACCOUNTING.My.Resources.Resources.add
        Me.SimpleButton3.Location = New System.Drawing.Point(7, 6)
        Me.SimpleButton3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(182, 37)
        Me.SimpleButton3.TabIndex = 293
        Me.SimpleButton3.Text = "TAMBAH RETUR JUAL"
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Location = New System.Drawing.Point(10, 32)
        Me.GridControl.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl.MainView = Me.GridList_Customer
        Me.GridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(993, 573)
        Me.GridControl.TabIndex = 297
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridList_Customer})
        '
        'GridList_Customer
        '
        Me.GridList_Customer.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridList_Customer.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridList_Customer.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.GridList_Customer.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.GridList_Customer.Appearance.DetailTip.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.DetailTip.Options.UseFont = True
        Me.GridList_Customer.Appearance.Empty.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.Empty.Options.UseFont = True
        Me.GridList_Customer.Appearance.EvenRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.EvenRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FilterCloseButton.Options.UseFont = True
        Me.GridList_Customer.Appearance.FilterPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FilterPanel.Options.UseFont = True
        Me.GridList_Customer.Appearance.FixedLine.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FixedLine.Options.UseFont = True
        Me.GridList_Customer.Appearance.FocusedCell.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FocusedCell.Options.UseFont = True
        Me.GridList_Customer.Appearance.FocusedRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FocusedRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.FooterPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FooterPanel.Options.UseFont = True
        Me.GridList_Customer.Appearance.GroupButton.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupButton.Options.UseFont = True
        Me.GridList_Customer.Appearance.GroupFooter.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupFooter.Options.UseFont = True
        Me.GridList_Customer.Appearance.GroupPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupPanel.Options.UseFont = True
        Me.GridList_Customer.Appearance.GroupRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.HeaderPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridList_Customer.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.HorzLine.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.HorzLine.Options.UseFont = True
        Me.GridList_Customer.Appearance.OddRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.OddRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.Preview.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.Preview.Options.UseFont = True
        Me.GridList_Customer.Appearance.Row.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.Row.Options.UseFont = True
        Me.GridList_Customer.Appearance.RowSeparator.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.RowSeparator.Options.UseFont = True
        Me.GridList_Customer.Appearance.SelectedRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.SelectedRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.TopNewRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.TopNewRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.VertLine.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.VertLine.Options.UseFont = True
        Me.GridList_Customer.Appearance.ViewCaption.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.ViewCaption.Options.UseFont = True
        Me.GridList_Customer.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridList_Customer.GridControl = Me.GridControl
        Me.GridList_Customer.Name = "GridList_Customer"
        Me.GridList_Customer.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridList_Customer.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridList_Customer.OptionsBehavior.Editable = False
        Me.GridList_Customer.OptionsBehavior.ReadOnly = True
        Me.GridList_Customer.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GridList_Customer.OptionsCustomization.AllowColumnMoving = False
        Me.GridList_Customer.OptionsCustomization.AllowGroup = False
        Me.GridList_Customer.OptionsDetail.AllowZoomDetail = False
        Me.GridList_Customer.OptionsDetail.SmartDetailHeight = True
        Me.GridList_Customer.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
        Me.GridList_Customer.OptionsFind.AllowFindPanel = False
        Me.GridList_Customer.OptionsMenu.EnableColumnMenu = False
        Me.GridList_Customer.OptionsMenu.EnableFooterMenu = False
        Me.GridList_Customer.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridList_Customer.OptionsNavigation.AutoFocusNewRow = True
        Me.GridList_Customer.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridList_Customer.OptionsView.ShowAutoFilterRow = True
        Me.GridList_Customer.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridList_Customer.OptionsView.ShowGroupPanel = False
        Me.GridList_Customer.PaintStyleName = "Skin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 24)
        Me.Label1.TabIndex = 298
        Me.Label1.Text = "Daftar Retur Jual"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.Controls.Add(Me.btn_cetak)
        Me.PanelControl3.Controls.Add(Me.GroupControl4)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.btn_keluar)
        Me.PanelControl3.Controls.Add(Me.GroupControl3)
        Me.PanelControl3.Controls.Add(Me.btn_reset2)
        Me.PanelControl3.Controls.Add(Me.GroupControl6)
        Me.PanelControl3.Controls.Add(Me.GroupControl5)
        Me.PanelControl3.Controls.Add(Me.btn_del2)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.btn_save2)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 13)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(991, 637)
        Me.PanelControl3.TabIndex = 300
        Me.PanelControl3.Visible = False
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl4.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl4.Appearance.Options.UseBackColor = True
        Me.GroupControl4.Appearance.Options.UseFont = True
        Me.GroupControl4.Appearance.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.btn_browse)
        Me.GroupControl4.Controls.Add(Me.Label10)
        Me.GroupControl4.Controls.Add(Me.txt_save_path)
        Me.GroupControl4.Location = New System.Drawing.Point(91, -217)
        Me.GroupControl4.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1154, 197)
        Me.GroupControl4.TabIndex = 268
        Me.GroupControl4.Text = "SETTING DIREKTORI FOTO"
        Me.GroupControl4.Visible = False
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
        Me.btn_browse.Location = New System.Drawing.Point(8, 1239)
        Me.btn_browse.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_browse.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_browse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(335, 153)
        Me.btn_browse.TabIndex = 282
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 18)
        Me.Label10.TabIndex = 279
        Me.Label10.Text = "Direktori Foto :"
        '
        'txt_save_path
        '
        Me.txt_save_path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_save_path.BackColor = System.Drawing.Color.White
        Me.txt_save_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_save_path.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_save_path.ForeColor = System.Drawing.Color.Black
        Me.txt_save_path.Location = New System.Drawing.Point(7, 60)
        Me.txt_save_path.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_save_path.Name = "txt_save_path"
        Me.txt_save_path.ReadOnly = True
        Me.txt_save_path.Size = New System.Drawing.Size(1140, 25)
        Me.txt_save_path.TabIndex = 277
        Me.txt_save_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbo_filterwh_purch1
        '
        Me.cbo_filterwh_purch1.Location = New System.Drawing.Point(8, 139)
        Me.cbo_filterwh_purch1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_filterwh_purch1.Name = "cbo_filterwh_purch1"
        Me.cbo_filterwh_purch1.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_filterwh_purch1.Properties.Appearance.Options.UseFont = True
        Me.cbo_filterwh_purch1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_filterwh_purch1.Properties.DisplayMember = "Name"
        Me.cbo_filterwh_purch1.Properties.ValueMember = "ID"
        Me.cbo_filterwh_purch1.Properties.View = Me.GridLookUpEdit1View
        Me.cbo_filterwh_purch1.Size = New System.Drawing.Size(151, 24)
        Me.cbo_filterwh_purch1.TabIndex = 295
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'frmsalesreturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1018, 672)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmsalesreturn"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retur Penjualan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabInput.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabList.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.cbo_filterwh_purch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_paymethod As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_sales_no As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_return_no As System.Windows.Forms.TextBox
    Friend WithEvents txt_cust_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_cust_nm As System.Windows.Forms.TextBox
    Friend WithEvents txt_nett As System.Windows.Forms.TextBox
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
    Friend WithEvents txt_tax_nom As System.Windows.Forms.TextBox
    Friend WithEvents txt_disc_nom As System.Windows.Forms.TextBox
    Friend WithEvents txt_kurs As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_comment As System.Windows.Forms.TextBox
    Friend WithEvents colno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitemnm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colunit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colconfirm As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colnoinv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsalesreturnno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsupp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcetak As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_ket As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents txt_so_no As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MtgcComboBox1 As MTGCComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MtgcComboBox2 As MTGCComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox3 As MTGCComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents chk_po As System.Windows.Forms.CheckBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents btn_cetak As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reset2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_reset_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_tax As System.Windows.Forms.TextBox
    Friend WithEvents txt_idsupplier As System.Windows.Forms.TextBox
    Friend WithEvents txt_disc As System.Windows.Forms.TextBox
    Friend WithEvents lbl_kurs As System.Windows.Forms.Label
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridList_Customer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_save_path As System.Windows.Forms.TextBox
    Friend WithEvents cbo_filterwh_purch1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
End Class
