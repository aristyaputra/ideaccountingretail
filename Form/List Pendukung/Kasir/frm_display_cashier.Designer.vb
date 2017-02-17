<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_display_cashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_display_cashier))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.col_nopurchase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nm_supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_addr_supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_freight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpaymethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltaxnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldiscnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbitem = New System.Windows.Forms.RadioButton()
        Me.rbservice = New System.Windows.Forms.RadioButton()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox1 = New MTGCComboBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbo_unit = New MTGCComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nopurchase, Me.col_date, Me.col_nm_supplier, Me.col_addr_supplier, Me.col_id_supplier, Me.col_payment, Me.col_subtotal, Me.col_freight, Me.col_tax, Me.col_total, Me.colpaymethod, Me.coltaxnom, Me.coldiscnom})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(571, 319)
        Me.DataGridView1.TabIndex = 7
        '
        'col_nopurchase
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_nopurchase.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_nopurchase.HeaderText = "No Transaksi"
        Me.col_nopurchase.Name = "col_nopurchase"
        Me.col_nopurchase.ReadOnly = True
        Me.col_nopurchase.Width = 175
        '
        'col_date
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_date.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_date.HeaderText = "Tanggal"
        Me.col_date.Name = "col_date"
        Me.col_date.ReadOnly = True
        Me.col_date.Width = 110
        '
        'col_nm_supplier
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_nm_supplier.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_nm_supplier.HeaderText = "Pelanggan"
        Me.col_nm_supplier.Name = "col_nm_supplier"
        Me.col_nm_supplier.ReadOnly = True
        Me.col_nm_supplier.Width = 230
        '
        'col_addr_supplier
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_addr_supplier.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_addr_supplier.HeaderText = "Supplier Address"
        Me.col_addr_supplier.Name = "col_addr_supplier"
        Me.col_addr_supplier.ReadOnly = True
        Me.col_addr_supplier.Visible = False
        Me.col_addr_supplier.Width = 150
        '
        'col_id_supplier
        '
        Me.col_id_supplier.HeaderText = "Supplier ID"
        Me.col_id_supplier.Name = "col_id_supplier"
        Me.col_id_supplier.ReadOnly = True
        Me.col_id_supplier.Visible = False
        '
        'col_payment
        '
        Me.col_payment.HeaderText = "Payment Method"
        Me.col_payment.Name = "col_payment"
        Me.col_payment.ReadOnly = True
        Me.col_payment.Visible = False
        '
        'col_subtotal
        '
        Me.col_subtotal.HeaderText = "Subtotal"
        Me.col_subtotal.Name = "col_subtotal"
        Me.col_subtotal.ReadOnly = True
        Me.col_subtotal.Visible = False
        '
        'col_freight
        '
        Me.col_freight.HeaderText = "Freight"
        Me.col_freight.Name = "col_freight"
        Me.col_freight.ReadOnly = True
        Me.col_freight.Visible = False
        '
        'col_tax
        '
        Me.col_tax.HeaderText = "Tax"
        Me.col_tax.Name = "col_tax"
        Me.col_tax.ReadOnly = True
        Me.col_tax.Visible = False
        '
        'col_total
        '
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        Me.col_total.Visible = False
        '
        'colpaymethod
        '
        Me.colpaymethod.HeaderText = "Payment"
        Me.colpaymethod.Name = "colpaymethod"
        Me.colpaymethod.ReadOnly = True
        Me.colpaymethod.Visible = False
        '
        'coltaxnom
        '
        Me.coltaxnom.HeaderText = "Tax Nom"
        Me.coltaxnom.Name = "coltaxnom"
        Me.coltaxnom.ReadOnly = True
        Me.coltaxnom.Visible = False
        '
        'coldiscnom
        '
        Me.coldiscnom.HeaderText = "discnom"
        Me.coldiscnom.Name = "coldiscnom"
        Me.coldiscnom.ReadOnly = True
        Me.coldiscnom.Visible = False
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(166, 47)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(404, 23)
        Me.txt_search.TabIndex = 6
        '
        'cbo_search
        '
        Me.cbo_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"Invoice No", "Customer"})
        Me.cbo_search.Location = New System.Drawing.Point(8, 44)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(149, 26)
        Me.cbo_search.TabIndex = 5
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.txt_search)
        Me.GroupControl2.Controls.Add(Me.cbo_search)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Controls.Add(Me.GroupBox1)
        Me.GroupControl2.Controls.Add(Me.ComboBox2)
        Me.GroupControl2.Controls.Add(Me.MtgcComboBox1)
        Me.GroupControl2.Location = New System.Drawing.Point(10, 8)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(575, 76)
        Me.GroupControl2.TabIndex = 294
        Me.GroupControl2.Text = "INFORMASI TRANSAKSI KASIR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(358, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 18)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "* Tekan Enter Untuk Mulai Pencarian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(163, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Teks Pencarian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Cari Berdasarkan"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbitem)
        Me.GroupBox1.Controls.Add(Me.rbservice)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(643, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(150, 43)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'rbitem
        '
        Me.rbitem.AutoSize = True
        Me.rbitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbitem.Location = New System.Drawing.Point(72, 16)
        Me.rbitem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbitem.Name = "rbitem"
        Me.rbitem.Size = New System.Drawing.Size(65, 19)
        Me.rbitem.TabIndex = 1
        Me.rbitem.TabStop = True
        Me.rbitem.Text = "Barang"
        Me.rbitem.UseVisualStyleBackColor = True
        '
        'rbservice
        '
        Me.rbservice.AutoSize = True
        Me.rbservice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbservice.Location = New System.Drawing.Point(10, 16)
        Me.rbservice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbservice.Name = "rbservice"
        Me.rbservice.Size = New System.Drawing.Size(51, 19)
        Me.rbservice.TabIndex = 0
        Me.rbservice.TabStop = True
        Me.rbservice.Text = "Jasa"
        Me.rbservice.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(-1838, 40)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox2.TabIndex = 131
        Me.ComboBox2.Visible = False
        '
        'MtgcComboBox1
        '
        Me.MtgcComboBox1.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox1.ArrowColor = System.Drawing.Color.Black
        Me.MtgcComboBox1.BackColor = System.Drawing.SystemColors.ControlLight
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
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.cbo_unit)
        Me.GroupControl1.Controls.Add(Me.DataGridView1)
        Me.GroupControl1.Location = New System.Drawing.Point(10, 92)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(575, 342)
        Me.GroupControl1.TabIndex = 295
        Me.GroupControl1.Text = "DATA ITEM"
        '
        'cbo_unit
        '
        Me.cbo_unit.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_unit.ArrowColor = System.Drawing.Color.Black
        Me.cbo_unit.BackColor = System.Drawing.SystemColors.ControlLight
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
        Me.cbo_unit.Location = New System.Drawing.Point(-11319, 41)
        Me.cbo_unit.ManagingFastMouseMoving = True
        Me.cbo_unit.ManagingFastMouseMovingInterval = 30
        Me.cbo_unit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_unit.Name = "cbo_unit"
        Me.cbo_unit.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_unit.SelectedItem = Nothing
        Me.cbo_unit.SelectedValue = Nothing
        Me.cbo_unit.Size = New System.Drawing.Size(121, 24)
        Me.cbo_unit.TabIndex = 130
        Me.cbo_unit.Visible = False
        '
        'frm_display_cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(596, 437)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_display_cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Transaksi Kasir"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents col_nopurchase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nm_supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_addr_supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_id_supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_payment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_freight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpaymethod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltaxnom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldiscnom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbitem As System.Windows.Forms.RadioButton
    Friend WithEvents rbservice As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox1 As MTGCComboBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbo_unit As MTGCComboBox
End Class
