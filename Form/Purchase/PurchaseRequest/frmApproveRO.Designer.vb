<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApproveRO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApproveRO))
        Me.btn_approve = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_clear2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_chk_all2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colnoinv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsupp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colunit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpilih = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_reset_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cari_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tglakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tglawal = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_approve
        '
        Me.btn_approve.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approve.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_approve.Appearance.Options.UseFont = True
        Me.btn_approve.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Send_16x16
        Me.btn_approve.Location = New System.Drawing.Point(911, 621)
        Me.btn_approve.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_approve.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_approve.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_approve.Name = "btn_approve"
        Me.btn_approve.Size = New System.Drawing.Size(91, 40)
        Me.btn_approve.TabIndex = 287
        Me.btn_approve.Text = "Approve"
        '
        'btn_clear2
        '
        Me.btn_clear2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear2.Appearance.Options.UseFont = True
        Me.btn_clear2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Properties_16x16
        Me.btn_clear2.Location = New System.Drawing.Point(763, 621)
        Me.btn_clear2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_clear2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_clear2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_clear2.Name = "btn_clear2"
        Me.btn_clear2.Size = New System.Drawing.Size(142, 40)
        Me.btn_clear2.TabIndex = 286
        Me.btn_clear2.Text = "Bersihkan Pilihan"
        '
        'btn_chk_all2
        '
        Me.btn_chk_all2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_chk_all2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_chk_all2.Appearance.Options.UseFont = True
        Me.btn_chk_all2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_chk_all2.Location = New System.Drawing.Point(648, 621)
        Me.btn_chk_all2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_chk_all2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_chk_all2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_chk_all2.Name = "btn_chk_all2"
        Me.btn_chk_all2.Size = New System.Drawing.Size(109, 40)
        Me.btn_chk_all2.TabIndex = 285
        Me.btn_chk_all2.Text = "Pilih Semua"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.DataGridView2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(984, 328)
        Me.GroupControl1.TabIndex = 284
        Me.GroupControl1.Text = "DATA PERMINTAAN GUDANG"
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
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnoinv, Me.colsupp, Me.colitem, Me.coldate, Me.colqty, Me.colunit, Me.coldescript, Me.colpilih})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(980, 305)
        Me.DataGridView2.TabIndex = 17
        '
        'colnoinv
        '
        Me.colnoinv.HeaderText = "No Permintaan"
        Me.colnoinv.Name = "colnoinv"
        Me.colnoinv.ReadOnly = True
        Me.colnoinv.Width = 160
        '
        'colsupp
        '
        Me.colsupp.HeaderText = "Kode Barang"
        Me.colsupp.Name = "colsupp"
        Me.colsupp.ReadOnly = True
        Me.colsupp.Width = 150
        '
        'colitem
        '
        Me.colitem.HeaderText = "Nama Barang"
        Me.colitem.Name = "colitem"
        Me.colitem.ReadOnly = True
        Me.colitem.Width = 170
        '
        'coldate
        '
        Me.coldate.HeaderText = "Tanggal"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        Me.coldate.Width = 92
        '
        'colqty
        '
        Me.colqty.HeaderText = "Qty"
        Me.colqty.Name = "colqty"
        Me.colqty.ReadOnly = True
        Me.colqty.Width = 70
        '
        'colunit
        '
        Me.colunit.HeaderText = "Unit"
        Me.colunit.Name = "colunit"
        Me.colunit.ReadOnly = True
        Me.colunit.Width = 75
        '
        'coldescript
        '
        Me.coldescript.HeaderText = "Keterangan"
        Me.coldescript.Name = "coldescript"
        Me.coldescript.ReadOnly = True
        Me.coldescript.Width = 175
        '
        'colpilih
        '
        Me.colpilih.HeaderText = "Pilih"
        Me.colpilih.Name = "colpilih"
        Me.colpilih.ReadOnly = True
        Me.colpilih.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colpilih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colpilih.Width = 60
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Appearance.Options.UseFont = True
        Me.GroupControl3.Appearance.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.btn_reset_cust)
        Me.GroupControl3.Controls.Add(Me.btn_cari_cust)
        Me.GroupControl3.Controls.Add(Me.GroupBox3)
        Me.GroupControl3.Controls.Add(Me.Label20)
        Me.GroupControl3.Controls.Add(Me.cbo_search)
        Me.GroupControl3.Controls.Add(Me.Label12)
        Me.GroupControl3.Controls.Add(Me.txt_search)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 37)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(990, 209)
        Me.GroupControl3.TabIndex = 283
        Me.GroupControl3.Text = "FILTER DATA"
        '
        'btn_reset_cust
        '
        Me.btn_reset_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_cust.Appearance.Options.UseFont = True
        Me.btn_reset_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset_cust.Location = New System.Drawing.Point(89, 167)
        Me.btn_reset_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_reset_cust.Name = "btn_reset_cust"
        Me.btn_reset_cust.Size = New System.Drawing.Size(82, 30)
        Me.btn_reset_cust.TabIndex = 278
        Me.btn_reset_cust.Text = "RESET"
        '
        'btn_cari_cust
        '
        Me.btn_cari_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_cust.Appearance.Options.UseFont = True
        Me.btn_cari_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Search_16x16
        Me.btn_cari_cust.Location = New System.Drawing.Point(14, 167)
        Me.btn_cari_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cari_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cari_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cari_cust.Name = "btn_cari_cust"
        Me.btn_cari_cust.Size = New System.Drawing.Size(72, 30)
        Me.btn_cari_cust.TabIndex = 277
        Me.btn_cari_cust.Text = "CARI"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chk_date)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.tglakhir)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.tglawal)
        Me.GroupBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(186, 30)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(263, 167)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter Tanggal"
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.ForeColor = System.Drawing.Color.Black
        Me.chk_date.Location = New System.Drawing.Point(14, 24)
        Me.chk_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(123, 22)
        Me.chk_date.TabIndex = 38
        Me.chk_date.Text = "Batasan Tanggal"
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(141, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 18)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Sampai"
        '
        'tglakhir
        '
        Me.tglakhir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tglakhir.CustomFormat = "dd-MM-yyyy"
        Me.tglakhir.ForeColor = System.Drawing.Color.Black
        Me.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglakhir.Location = New System.Drawing.Point(144, 74)
        Me.tglakhir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(111, 23)
        Me.tglakhir.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(18, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 18)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Dari"
        '
        'tglawal
        '
        Me.tglawal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tglawal.CustomFormat = "dd-MM-yyyy"
        Me.tglawal.ForeColor = System.Drawing.Color.Black
        Me.tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglawal.Location = New System.Drawing.Point(21, 74)
        Me.tglawal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglawal.Name = "tglawal"
        Me.tglawal.Size = New System.Drawing.Size(111, 23)
        Me.tglawal.TabIndex = 34
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(11, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 18)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Cari Berdasarkan"
        '
        'cbo_search
        '
        Me.cbo_search.BackColor = System.Drawing.Color.White
        Me.cbo_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search.ForeColor = System.Drawing.Color.Black
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"Requisition No", "Item ID", "Item Name"})
        Me.cbo_search.Location = New System.Drawing.Point(14, 48)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(157, 26)
        Me.cbo_search.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(11, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 18)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Teks Pencarian"
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.White
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.Color.Black
        Me.txt_search.Location = New System.Drawing.Point(14, 99)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(157, 62)
        Me.txt_search.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 617)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Dobel Klik untuk merubah Qty"
        Me.Label1.Visible = False
        '
        'btn_keluar
        '
        Me.btn_keluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(12, 622)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(82, 40)
        Me.btn_keluar.TabIndex = 288
        Me.btn_keluar.Text = "KELUAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(8, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 24)
        Me.Label2.TabIndex = 299
        Me.Label2.Text = "Approval Purchase Requisition"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 253)
        Me.XtraTabControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(990, 361)
        Me.XtraTabControl1.TabIndex = 300
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.HeaderActive.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage1.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(984, 328)
        Me.XtraTabPage1.Text = "Belum di Approve"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Appearance.HeaderActive.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage2.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage2.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(984, 328)
        Me.XtraTabPage2.Text = "Qty di Batalkan"
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.DataGridView1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(984, 328)
        Me.GroupControl2.TabIndex = 285
        Me.GroupControl2.Text = "DATA PERMINTAAN GUDANG BATAL"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(980, 305)
        Me.DataGridView1.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No Permintaan"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 160
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Kode Barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 170
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tanggal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 92
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Keterangan"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 175
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Pilih"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'frmApproveRO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1014, 672)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_chk_all2)
        Me.Controls.Add(Me.btn_clear2)
        Me.Controls.Add(Me.btn_approve)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmApproveRO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approval Permintaan Barang"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tglakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tglawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chk_date As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colnoinv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsupp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colunit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpilih As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_reset_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_chk_all2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_clear2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_approve As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
