<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmARList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmARList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_lbh_byr = New System.Windows.Forms.TextBox()
        Me.txt_balance = New System.Windows.Forms.TextBox()
        Me.txt_paid = New System.Windows.Forms.TextBox()
        Me.txt_disc = New System.Windows.Forms.TextBox()
        Me.txt_return = New System.Windows.Forms.TextBox()
        Me.txt_ar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colnopay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colreturn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.collebihbyr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.cbo_supplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_reset_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_cari_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tglakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tglawal = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.GroupControl1)
        Me.Panel1.Controls.Add(Me.GroupControl8)
        Me.Panel1.Controls.Add(Me.GroupControl7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 672)
        Me.Panel1.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txt_lbh_byr)
        Me.GroupControl1.Controls.Add(Me.txt_balance)
        Me.GroupControl1.Controls.Add(Me.txt_paid)
        Me.GroupControl1.Controls.Add(Me.txt_disc)
        Me.GroupControl1.Controls.Add(Me.txt_return)
        Me.GroupControl1.Controls.Add(Me.txt_ar)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(206, 588)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(799, 68)
        Me.GroupControl1.TabIndex = 310
        Me.GroupControl1.Text = "SUMMARY"
        '
        'txt_lbh_byr
        '
        Me.txt_lbh_byr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lbh_byr.BackColor = System.Drawing.Color.Lavender
        Me.txt_lbh_byr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lbh_byr.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lbh_byr.Location = New System.Drawing.Point(668, 41)
        Me.txt_lbh_byr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_lbh_byr.Name = "txt_lbh_byr"
        Me.txt_lbh_byr.ReadOnly = True
        Me.txt_lbh_byr.Size = New System.Drawing.Size(119, 23)
        Me.txt_lbh_byr.TabIndex = 46
        Me.txt_lbh_byr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_balance
        '
        Me.txt_balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_balance.BackColor = System.Drawing.Color.Lavender
        Me.txt_balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_balance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_balance.Location = New System.Drawing.Point(543, 41)
        Me.txt_balance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.ReadOnly = True
        Me.txt_balance.Size = New System.Drawing.Size(119, 23)
        Me.txt_balance.TabIndex = 23
        Me.txt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_paid
        '
        Me.txt_paid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_paid.BackColor = System.Drawing.Color.Lavender
        Me.txt_paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_paid.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_paid.Location = New System.Drawing.Point(419, 41)
        Me.txt_paid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_paid.Name = "txt_paid"
        Me.txt_paid.ReadOnly = True
        Me.txt_paid.Size = New System.Drawing.Size(119, 23)
        Me.txt_paid.TabIndex = 19
        Me.txt_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_disc
        '
        Me.txt_disc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_disc.BackColor = System.Drawing.Color.Lavender
        Me.txt_disc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_disc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disc.Location = New System.Drawing.Point(295, 41)
        Me.txt_disc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_disc.Name = "txt_disc"
        Me.txt_disc.ReadOnly = True
        Me.txt_disc.Size = New System.Drawing.Size(119, 23)
        Me.txt_disc.TabIndex = 18
        Me.txt_disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_return
        '
        Me.txt_return.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_return.BackColor = System.Drawing.Color.Lavender
        Me.txt_return.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_return.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_return.Location = New System.Drawing.Point(172, 41)
        Me.txt_return.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_return.Name = "txt_return"
        Me.txt_return.ReadOnly = True
        Me.txt_return.Size = New System.Drawing.Size(118, 23)
        Me.txt_return.TabIndex = 17
        Me.txt_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ar
        '
        Me.txt_ar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ar.BackColor = System.Drawing.Color.Lavender
        Me.txt_ar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ar.Location = New System.Drawing.Point(47, 41)
        Me.txt_ar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ar.Name = "txt_ar"
        Me.txt_ar.ReadOnly = True
        Me.txt_ar.Size = New System.Drawing.Size(119, 23)
        Me.txt_ar.TabIndex = 22
        Me.txt_ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(700, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "SELISIH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(560, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "SALDO AKHIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(445, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "TERBAYAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(318, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "DISC TOTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(187, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "RETUR TOTAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(57, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "FAKTUR TOTAL"
        '
        'GroupControl8
        '
        Me.GroupControl8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl8.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl8.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl8.Appearance.Options.UseBackColor = True
        Me.GroupControl8.Appearance.Options.UseFont = True
        Me.GroupControl8.Appearance.Options.UseForeColor = True
        Me.GroupControl8.Controls.Add(Me.DataGridView2)
        Me.GroupControl8.Location = New System.Drawing.Point(206, 10)
        Me.GroupControl8.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl8.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(798, 572)
        Me.GroupControl8.TabIndex = 309
        Me.GroupControl8.Text = "DAFTAR HUTANG"
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnopay, Me.coldate, Me.colsupplier, Me.colamount, Me.colreturn, Me.coldisc, Me.colpaid, Me.colbalance, Me.coldescript, Me.collebihbyr})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(794, 549)
        Me.DataGridView2.TabIndex = 13
        '
        'colnopay
        '
        Me.colnopay.HeaderText = "No Faktur"
        Me.colnopay.Name = "colnopay"
        Me.colnopay.ReadOnly = True
        Me.colnopay.Width = 175
        '
        'coldate
        '
        Me.coldate.HeaderText = "Tanggal"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        '
        'colsupplier
        '
        Me.colsupplier.HeaderText = "Pelanggan"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.ReadOnly = True
        Me.colsupplier.Width = 200
        '
        'colamount
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colamount.DefaultCellStyle = DataGridViewCellStyle2
        Me.colamount.HeaderText = "Nominal"
        Me.colamount.Name = "colamount"
        Me.colamount.ReadOnly = True
        Me.colamount.Width = 115
        '
        'colreturn
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colreturn.DefaultCellStyle = DataGridViewCellStyle3
        Me.colreturn.HeaderText = "Retur"
        Me.colreturn.Name = "colreturn"
        Me.colreturn.ReadOnly = True
        Me.colreturn.Width = 115
        '
        'coldisc
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.coldisc.DefaultCellStyle = DataGridViewCellStyle4
        Me.coldisc.HeaderText = "Diskon Bayar"
        Me.coldisc.Name = "coldisc"
        Me.coldisc.ReadOnly = True
        Me.coldisc.Width = 115
        '
        'colpaid
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colpaid.DefaultCellStyle = DataGridViewCellStyle5
        Me.colpaid.HeaderText = "Terbayar"
        Me.colpaid.Name = "colpaid"
        Me.colpaid.ReadOnly = True
        Me.colpaid.Width = 115
        '
        'colbalance
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colbalance.DefaultCellStyle = DataGridViewCellStyle6
        Me.colbalance.HeaderText = "Saldo"
        Me.colbalance.Name = "colbalance"
        Me.colbalance.ReadOnly = True
        Me.colbalance.Width = 115
        '
        'coldescript
        '
        Me.coldescript.HeaderText = "Keterangan"
        Me.coldescript.Name = "coldescript"
        Me.coldescript.ReadOnly = True
        Me.coldescript.Width = 230
        '
        'collebihbyr
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.collebihbyr.DefaultCellStyle = DataGridViewCellStyle7
        Me.collebihbyr.HeaderText = "Selisih"
        Me.collebihbyr.Name = "collebihbyr"
        Me.collebihbyr.ReadOnly = True
        Me.collebihbyr.Width = 115
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
        Me.GroupControl7.Controls.Add(Me.btn_keluar)
        Me.GroupControl7.Controls.Add(Me.cbo_supplier)
        Me.GroupControl7.Controls.Add(Me.Label4)
        Me.GroupControl7.Controls.Add(Me.btn_reset_cust)
        Me.GroupControl7.Controls.Add(Me.txt_search)
        Me.GroupControl7.Controls.Add(Me.btn_cari_cust)
        Me.GroupControl7.Controls.Add(Me.GroupBox1)
        Me.GroupControl7.Controls.Add(Me.Label9)
        Me.GroupControl7.Controls.Add(Me.cbo_search)
        Me.GroupControl7.Location = New System.Drawing.Point(10, 10)
        Me.GroupControl7.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(186, 646)
        Me.GroupControl7.TabIndex = 286
        Me.GroupControl7.Text = "PANEL PENCARIAN"
        '
        'cbo_supplier
        '
        Me.cbo_supplier.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_supplier.FormattingEnabled = True
        Me.cbo_supplier.Items.AddRange(New Object() {"Received No", "Supplier"})
        Me.cbo_supplier.Location = New System.Drawing.Point(16, -1292)
        Me.cbo_supplier.Name = "cbo_supplier"
        Me.cbo_supplier.Size = New System.Drawing.Size(155, 26)
        Me.cbo_supplier.TabIndex = 277
        Me.cbo_supplier.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(16, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Cari Berdasarkan"
        '
        'btn_reset_cust
        '
        Me.btn_reset_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_cust.Appearance.Options.UseFont = True
        Me.btn_reset_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset_cust.Location = New System.Drawing.Point(13, 373)
        Me.btn_reset_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset_cust.Name = "btn_reset_cust"
        Me.btn_reset_cust.Size = New System.Drawing.Size(84, 36)
        Me.btn_reset_cust.TabIndex = 276
        Me.btn_reset_cust.Text = "RESET"
        '
        'txt_search
        '
        Me.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(14, 106)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(155, 60)
        Me.txt_search.TabIndex = 16
        '
        'btn_cari_cust
        '
        Me.btn_cari_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_cust.Appearance.Options.UseFont = True
        Me.btn_cari_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Search_16x16
        Me.btn_cari_cust.Location = New System.Drawing.Point(103, 373)
        Me.btn_cari_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cari_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cari_cust.Name = "btn_cari_cust"
        Me.btn_cari_cust.Size = New System.Drawing.Size(70, 36)
        Me.btn_cari_cust.TabIndex = 275
        Me.btn_cari_cust.Text = "CARI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chk_date)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tglakhir)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tglawal)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 185)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(160, 187)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Tanggal"
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.Location = New System.Drawing.Point(17, 29)
        Me.chk_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(120, 22)
        Me.chk_date.TabIndex = 38
        Me.chk_date.Text = "Dengan Batasan"
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 18)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Sampai"
        '
        'tglakhir
        '
        Me.tglakhir.CustomFormat = "dd-MM-yyyy"
        Me.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglakhir.Location = New System.Drawing.Point(22, 139)
        Me.tglakhir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(111, 23)
        Me.tglakhir.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Dari"
        '
        'tglawal
        '
        Me.tglawal.CustomFormat = "dd-MM-yyyy"
        Me.tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglawal.Location = New System.Drawing.Point(22, 86)
        Me.tglawal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglawal.Name = "tglawal"
        Me.tglawal.Size = New System.Drawing.Size(111, 23)
        Me.tglawal.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(16, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 18)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Teks Pencarian"
        '
        'cbo_search
        '
        Me.cbo_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"Invoice No", "Customer"})
        Me.cbo_search.Location = New System.Drawing.Point(14, 52)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(155, 26)
        Me.cbo_search.TabIndex = 15
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(13, 418)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(84, 35)
        Me.btn_keluar.TabIndex = 279
        Me.btn_keluar.Text = "KELUAR"
        '
        'frmARList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 672)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmARList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Status Piutang"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_paid As System.Windows.Forms.TextBox
    Friend WithEvents txt_disc As System.Windows.Forms.TextBox
    Friend WithEvents txt_return As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_ar As System.Windows.Forms.TextBox
    Friend WithEvents txt_balance As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tglakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tglawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents chk_date As System.Windows.Forms.CheckBox
    Friend WithEvents txt_lbh_byr As System.Windows.Forms.TextBox
    Friend WithEvents colnopay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colreturn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldisc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colbalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents collebihbyr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbo_supplier As System.Windows.Forms.ComboBox
    Friend WithEvents btn_reset_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
End Class
