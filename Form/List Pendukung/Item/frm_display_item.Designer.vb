<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_display_item
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_display_item))
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbitem = New System.Windows.Forms.RadioButton()
        Me.rbservice = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colaccno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colaccnm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colidbarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbo_supplier = New System.Windows.Forms.ComboBox()
        Me.cbo_unit = New MTGCComboBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox1 = New MTGCComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(163, 46)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(629, 23)
        Me.txt_search.TabIndex = 19
        '
        'cbo_search
        '
        Me.cbo_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"ID", "Name"})
        Me.cbo_search.Location = New System.Drawing.Point(5, 44)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(152, 26)
        Me.cbo_search.TabIndex = 18
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colaccno, Me.colaccnm, Me.colidbarcode, Me.type, Me.Cat, Me.Brand, Me.jenis, Me.kategori, Me.merek})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(807, 398)
        Me.DataGridView1.TabIndex = 20
        '
        'colaccno
        '
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colaccno.DefaultCellStyle = DataGridViewCellStyle8
        Me.colaccno.HeaderText = "Kode Barang"
        Me.colaccno.Name = "colaccno"
        Me.colaccno.ReadOnly = True
        Me.colaccno.Width = 135
        '
        'colaccnm
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colaccnm.DefaultCellStyle = DataGridViewCellStyle9
        Me.colaccnm.HeaderText = "Nama Barang"
        Me.colaccnm.Name = "colaccnm"
        Me.colaccnm.ReadOnly = True
        Me.colaccnm.Width = 250
        '
        'colidbarcode
        '
        Me.colidbarcode.HeaderText = "Barcode"
        Me.colidbarcode.Name = "colidbarcode"
        Me.colidbarcode.ReadOnly = True
        Me.colidbarcode.Visible = False
        Me.colidbarcode.Width = 135
        '
        'type
        '
        Me.type.HeaderText = "Jenis"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.Width = 125
        '
        'Cat
        '
        Me.Cat.HeaderText = "Kategori"
        Me.Cat.Name = "Cat"
        Me.Cat.ReadOnly = True
        Me.Cat.Width = 125
        '
        'Brand
        '
        Me.Brand.HeaderText = "Merek"
        Me.Brand.Name = "Brand"
        Me.Brand.ReadOnly = True
        Me.Brand.Width = 125
        '
        'jenis
        '
        Me.jenis.HeaderText = "jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.ReadOnly = True
        Me.jenis.Visible = False
        '
        'kategori
        '
        Me.kategori.HeaderText = "kategori"
        Me.kategori.Name = "kategori"
        Me.kategori.ReadOnly = True
        Me.kategori.Visible = False
        '
        'merek
        '
        Me.merek.HeaderText = "merek"
        Me.merek.Name = "merek"
        Me.merek.ReadOnly = True
        Me.merek.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(807, 398)
        Me.DataGridView2.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Jasa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 160
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn2.HeaderText = "Jenis Jasa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 600
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.cbo_supplier)
        Me.GroupControl1.Controls.Add(Me.cbo_unit)
        Me.GroupControl1.Controls.Add(Me.DataGridView2)
        Me.GroupControl1.Controls.Add(Me.DataGridView1)
        Me.GroupControl1.Location = New System.Drawing.Point(10, 88)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(811, 421)
        Me.GroupControl1.TabIndex = 292
        Me.GroupControl1.Text = "DATA ITEM"
        '
        'cbo_supplier
        '
        Me.cbo_supplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_supplier.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbo_supplier.Enabled = False
        Me.cbo_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_supplier.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supplier.ForeColor = System.Drawing.Color.Black
        Me.cbo_supplier.FormattingEnabled = True
        Me.cbo_supplier.Location = New System.Drawing.Point(-1602, 40)
        Me.cbo_supplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_supplier.Name = "cbo_supplier"
        Me.cbo_supplier.Size = New System.Drawing.Size(150, 26)
        Me.cbo_supplier.TabIndex = 131
        Me.cbo_supplier.Visible = False
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
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Controls.Add(Me.GroupBox1)
        Me.GroupControl2.Controls.Add(Me.cbo_search)
        Me.GroupControl2.Controls.Add(Me.txt_search)
        Me.GroupControl2.Controls.Add(Me.ComboBox1)
        Me.GroupControl2.Controls.Add(Me.MtgcComboBox1)
        Me.GroupControl2.Location = New System.Drawing.Point(11, 4)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(810, 76)
        Me.GroupControl2.TabIndex = 293
        Me.GroupControl2.Text = "INFORMASI FILTER PENCARIAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(570, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 18)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "* Tekan Enter Untuk Mulai Pencarian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(163, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Teks Pencarian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Cari Berdasarkan"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(-1603, 40)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox1.TabIndex = 131
        Me.ComboBox1.Visible = False
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
        'frm_display_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(830, 515)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_display_item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Jenis Jasa & Item"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbitem As System.Windows.Forms.RadioButton
    Friend WithEvents rbservice As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents colaccno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colaccnm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidbarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kategori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents merek As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbo_supplier As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_unit As MTGCComboBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox1 As MTGCComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
