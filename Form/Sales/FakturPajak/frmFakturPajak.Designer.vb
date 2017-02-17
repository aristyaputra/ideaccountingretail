<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFakturPajak
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFakturPajak))
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_period = New System.Windows.Forms.DateTimePicker()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.gb_filtertgl_purch = New System.Windows.Forms.GroupBox()
        Me.cbo_aset2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.chk_filtertgl_purch = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_transaksi = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_jenis = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_status = New DevExpress.XtraEditors.LookUpEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbo_retur = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_um = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rb_um = New System.Windows.Forms.RadioButton()
        Me.rb_retur = New System.Windows.Forms.RadioButton()
        Me.rbfaktur = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.gb_filtertgl_purch.SuspendLayout()
        CType(Me.cbo_aset2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_transaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_jenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_retur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbo_um.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRviewer.DisplayGroupTree = False
        Me.CRviewer.Location = New System.Drawing.Point(0, 135)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.ShowPrintButton = False
        Me.CRviewer.Size = New System.Drawing.Size(883, 340)
        Me.CRviewer.TabIndex = 0
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pilih Transaksi"
        '
        'txt_period
        '
        Me.txt_period.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_period.CustomFormat = "MMM-yyyy"
        Me.txt_period.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_period.ForeColor = System.Drawing.Color.Black
        Me.txt_period.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_period.Location = New System.Drawing.Point(186, 10)
        Me.txt_period.Name = "txt_period"
        Me.txt_period.Size = New System.Drawing.Size(129, 23)
        Me.txt_period.TabIndex = 52
        Me.txt_period.Visible = False
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.DimGray
        Me.btn_simpan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.Gold
        Me.btn_simpan.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(695, 37)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(178, 29)
        Me.btn_simpan.TabIndex = 53
        Me.btn_simpan.Text = "Lihat Faktur Pajak"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'gb_filtertgl_purch
        '
        Me.gb_filtertgl_purch.BackColor = System.Drawing.Color.Transparent
        Me.gb_filtertgl_purch.Controls.Add(Me.cbo_aset2)
        Me.gb_filtertgl_purch.Controls.Add(Me.txt_period)
        Me.gb_filtertgl_purch.Controls.Add(Me.chk_filtertgl_purch)
        Me.gb_filtertgl_purch.Controls.Add(Me.Label8)
        Me.gb_filtertgl_purch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_filtertgl_purch.ForeColor = System.Drawing.Color.Black
        Me.gb_filtertgl_purch.Location = New System.Drawing.Point(656, 2)
        Me.gb_filtertgl_purch.Name = "gb_filtertgl_purch"
        Me.gb_filtertgl_purch.Size = New System.Drawing.Size(247, 72)
        Me.gb_filtertgl_purch.TabIndex = 56
        Me.gb_filtertgl_purch.TabStop = False
        Me.gb_filtertgl_purch.Text = "Filter Aset"
        Me.gb_filtertgl_purch.Visible = False
        '
        'cbo_aset2
        '
        Me.cbo_aset2.Location = New System.Drawing.Point(227, 42)
        Me.cbo_aset2.Name = "cbo_aset2"
        Me.cbo_aset2.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_aset2.Properties.Appearance.Options.UseFont = True
        Me.cbo_aset2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_aset2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_aset", "ID Aset", 67, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Aset", 42, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cbo_aset2.Properties.DisplayMember = "nama"
        Me.cbo_aset2.Properties.ValueMember = "id_aset"
        Me.cbo_aset2.Size = New System.Drawing.Size(160, 24)
        Me.cbo_aset2.TabIndex = 297
        '
        'chk_filtertgl_purch
        '
        Me.chk_filtertgl_purch.AutoSize = True
        Me.chk_filtertgl_purch.ForeColor = System.Drawing.Color.Black
        Me.chk_filtertgl_purch.Location = New System.Drawing.Point(11, 19)
        Me.chk_filtertgl_purch.Name = "chk_filtertgl_purch"
        Me.chk_filtertgl_purch.Size = New System.Drawing.Size(75, 22)
        Me.chk_filtertgl_purch.TabIndex = 59
        Me.chk_filtertgl_purch.Text = "Filter By"
        Me.chk_filtertgl_purch.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(173, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 18)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Sampai"
        '
        'cbo_transaksi
        '
        Me.cbo_transaksi.Location = New System.Drawing.Point(137, 69)
        Me.cbo_transaksi.Name = "cbo_transaksi"
        Me.cbo_transaksi.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_transaksi.Properties.Appearance.Options.UseFont = True
        Me.cbo_transaksi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_transaksi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("date_trn", "Tanggal", 73, DevExpress.Utils.FormatType.DateTime, "dd-MMM-yyyy", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_sales", "No Penjualan", 170, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_customer", "Pelanggan", 190, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("address", "Alamat", 250, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("city", "Kota", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("total", "Total", 100, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.cbo_transaksi.Properties.DisplayMember = "nm_customer"
        Me.cbo_transaksi.Properties.ValueMember = "no_sales"
        Me.cbo_transaksi.Size = New System.Drawing.Size(221, 24)
        Me.cbo_transaksi.TabIndex = 296
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(372, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 297
        Me.Label2.Text = "Jenis Transaksi"
        '
        'cbo_jenis
        '
        Me.cbo_jenis.Location = New System.Drawing.Point(486, 41)
        Me.cbo_jenis.Name = "cbo_jenis"
        Me.cbo_jenis.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_jenis.Properties.Appearance.Options.UseFont = True
        Me.cbo_jenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_jenis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("notes", "Notes", 300, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cbo_jenis.Properties.DisplayMember = "notes"
        Me.cbo_jenis.Properties.ValueMember = "kode"
        Me.cbo_jenis.Size = New System.Drawing.Size(191, 24)
        Me.cbo_jenis.TabIndex = 298
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(372, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 299
        Me.Label3.Text = "Status Faktur"
        '
        'cbo_status
        '
        Me.cbo_status.Location = New System.Drawing.Point(486, 69)
        Me.cbo_status.Name = "cbo_status"
        Me.cbo_status.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_status.Properties.Appearance.Options.UseFont = True
        Me.cbo_status.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_status.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode", "Kode", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("notes", "Notes", 300, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cbo_status.Properties.DisplayMember = "notes"
        Me.cbo_status.Properties.ValueMember = "kode"
        Me.cbo_status.Size = New System.Drawing.Size(191, 24)
        Me.cbo_status.TabIndex = 300
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Print_16x16
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(695, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 28)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Cetak Faktur Pajak"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbo_retur
        '
        Me.cbo_retur.Location = New System.Drawing.Point(137, 41)
        Me.cbo_retur.Name = "cbo_retur"
        Me.cbo_retur.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_retur.Properties.Appearance.Options.UseFont = True
        Me.cbo_retur.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_retur.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("date_trn", "Tanggal", 73, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_sales", "No. Penjualan", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_customer", "Pelanggan", 89, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("address", "Alamat", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("city", "Kota", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("total", "Total Faktur", 38, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.cbo_retur.Properties.DisplayMember = "nm_customer"
        Me.cbo_retur.Properties.ValueMember = "no_sales"
        Me.cbo_retur.Size = New System.Drawing.Size(221, 24)
        Me.cbo_retur.TabIndex = 302
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 301
        Me.Label4.Text = "Pilih Retur"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbo_um)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rb_um)
        Me.GroupBox1.Controls.Add(Me.rb_retur)
        Me.GroupBox1.Controls.Add(Me.rbfaktur)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbo_retur)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_simpan)
        Me.GroupBox1.Controls.Add(Me.cbo_status)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbo_transaksi)
        Me.GroupBox1.Controls.Add(Me.cbo_jenis)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(879, 130)
        Me.GroupBox1.TabIndex = 303
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setting Faktur Pajak"
        '
        'cbo_um
        '
        Me.cbo_um.Location = New System.Drawing.Point(137, 98)
        Me.cbo_um.Name = "cbo_um"
        Me.cbo_um.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_um.Properties.Appearance.Options.UseFont = True
        Me.cbo_um.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_um.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("date_trn", "Tanggal", 73, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_sales_order", "Sales Order", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_customer", "Pelanggan", 89, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("address", "Alamat", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("city", "Kota", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("uang_muka", "Uang Muka", 77, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.cbo_um.Properties.DisplayMember = "nm_customer"
        Me.cbo_um.Properties.ValueMember = "no_sales_order"
        Me.cbo_um.Size = New System.Drawing.Size(221, 24)
        Me.cbo_um.TabIndex = 306
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 305
        Me.Label5.Text = "Pilih Uang Muka"
        '
        'rb_um
        '
        Me.rb_um.AutoSize = True
        Me.rb_um.Location = New System.Drawing.Point(271, 15)
        Me.rb_um.Name = "rb_um"
        Me.rb_um.Size = New System.Drawing.Size(90, 22)
        Me.rb_um.TabIndex = 304
        Me.rb_um.TabStop = True
        Me.rb_um.Text = "Uang Muka"
        Me.rb_um.UseVisualStyleBackColor = True
        '
        'rb_retur
        '
        Me.rb_retur.AutoSize = True
        Me.rb_retur.Location = New System.Drawing.Point(207, 15)
        Me.rb_retur.Name = "rb_retur"
        Me.rb_retur.Size = New System.Drawing.Size(58, 22)
        Me.rb_retur.TabIndex = 303
        Me.rb_retur.TabStop = True
        Me.rb_retur.Text = "Retur"
        Me.rb_retur.UseVisualStyleBackColor = True
        '
        'rbfaktur
        '
        Me.rbfaktur.AutoSize = True
        Me.rbfaktur.Location = New System.Drawing.Point(137, 15)
        Me.rbfaktur.Name = "rbfaktur"
        Me.rbfaktur.Size = New System.Drawing.Size(64, 22)
        Me.rbfaktur.TabIndex = 303
        Me.rbfaktur.TabStop = True
        Me.rbfaktur.Text = "Faktur"
        Me.rbfaktur.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gold
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(696, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 28)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Perbesar / Perkecil View"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmFakturPajak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(883, 476)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb_filtertgl_purch)
        Me.Controls.Add(Me.CRviewer)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFakturPajak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Faktur/Retur Pajak Penjualan"
        Me.gb_filtertgl_purch.ResumeLayout(False)
        Me.gb_filtertgl_purch.PerformLayout()
        CType(Me.cbo_aset2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_transaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_jenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_retur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbo_um.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_period As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents gb_filtertgl_purch As System.Windows.Forms.GroupBox
    Friend WithEvents chk_filtertgl_purch As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbo_transaksi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbo_aset2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_jenis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_status As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbo_retur As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_retur As System.Windows.Forms.RadioButton
    Friend WithEvents rbfaktur As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbo_um As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rb_um As System.Windows.Forms.RadioButton
End Class
