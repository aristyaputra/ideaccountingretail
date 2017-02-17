<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_display_ro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_display_ro))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbitem = New System.Windows.Forms.RadioButton()
        Me.rbservice = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colaccno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colaccnm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colidbarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colunit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idbarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbo_supplier = New System.Windows.Forms.ComboBox()
        Me.cbo_unit = New MTGCComboBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox1 = New MTGCComboBox()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.cbo_search_item = New System.Windows.Forms.ComboBox()
        Me.txt_search_item = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox2 = New MTGCComboBox()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox3 = New MTGCComboBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(166, 46)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(760, 23)
        Me.txt_search.TabIndex = 19
        '
        'cbo_search
        '
        Me.cbo_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"Requisition No", "Item ID", "Item Name", "Barcode"})
        Me.cbo_search.Location = New System.Drawing.Point(8, 44)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(151, 26)
        Me.cbo_search.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbitem)
        Me.GroupBox1.Controls.Add(Me.rbservice)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 274)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(713, 53)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'rbitem
        '
        Me.rbitem.AutoSize = True
        Me.rbitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbitem.Location = New System.Drawing.Point(90, 18)
        Me.rbitem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbitem.Name = "rbitem"
        Me.rbitem.Size = New System.Drawing.Size(49, 19)
        Me.rbitem.TabIndex = 1
        Me.rbitem.TabStop = True
        Me.rbitem.Text = "Item"
        Me.rbitem.UseVisualStyleBackColor = True
        '
        'rbservice
        '
        Me.rbservice.AutoSize = True
        Me.rbservice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbservice.Location = New System.Drawing.Point(7, 18)
        Me.rbservice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbservice.Name = "rbservice"
        Me.rbservice.Size = New System.Drawing.Size(65, 19)
        Me.rbservice.TabIndex = 0
        Me.rbservice.TabStop = True
        Me.rbservice.Text = "Service"
        Me.rbservice.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colaccno, Me.colaccnm, Me.colidbarcode, Me.colqty, Me.colunit, Me.idbarcode})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(927, 313)
        Me.DataGridView1.TabIndex = 20
        '
        'colaccno
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colaccno.DefaultCellStyle = DataGridViewCellStyle2
        Me.colaccno.HeaderText = "Kode Barang"
        Me.colaccno.Name = "colaccno"
        Me.colaccno.ReadOnly = True
        Me.colaccno.Width = 165
        '
        'colaccnm
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colaccnm.DefaultCellStyle = DataGridViewCellStyle3
        Me.colaccnm.HeaderText = "Nama Barang"
        Me.colaccnm.Name = "colaccnm"
        Me.colaccnm.ReadOnly = True
        Me.colaccnm.Width = 260
        '
        'colidbarcode
        '
        Me.colidbarcode.HeaderText = "No Permintaan"
        Me.colidbarcode.Name = "colidbarcode"
        Me.colidbarcode.ReadOnly = True
        Me.colidbarcode.Width = 175
        '
        'colqty
        '
        Me.colqty.HeaderText = "Qty Approve"
        Me.colqty.Name = "colqty"
        Me.colqty.ReadOnly = True
        Me.colqty.Width = 110
        '
        'colunit
        '
        Me.colunit.HeaderText = "Unit"
        Me.colunit.Name = "colunit"
        Me.colunit.ReadOnly = True
        Me.colunit.Width = 70
        '
        'idbarcode
        '
        Me.idbarcode.HeaderText = "Barcode"
        Me.idbarcode.Name = "idbarcode"
        Me.idbarcode.ReadOnly = True
        Me.idbarcode.Width = 110
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
        Me.GroupControl1.Controls.Add(Me.DataGridView1)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 90)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(931, 336)
        Me.GroupControl1.TabIndex = 293
        Me.GroupControl1.Text = "DETAIL PERMINTAAN BARANG"
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
        Me.cbo_supplier.Location = New System.Drawing.Point(-1482, 40)
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
        Me.GroupControl2.Controls.Add(Me.txt_search)
        Me.GroupControl2.Controls.Add(Me.cbo_search)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Controls.Add(Me.ComboBox2)
        Me.GroupControl2.Controls.Add(Me.MtgcComboBox1)
        Me.GroupControl2.Location = New System.Drawing.Point(11, 6)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(931, 76)
        Me.GroupControl2.TabIndex = 294
        Me.GroupControl2.Text = "INFORMASI PURCHASE REQUISITION"
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
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(-1482, 40)
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
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.TabControl1.Size = New System.Drawing.Size(955, 455)
        Me.TabControl1.TabIndex = 295
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(953, 425)
        Me.XtraTabPage1.Text = "Dari Permintaan Barang"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(953, 425)
        Me.XtraTabPage2.Text = "Dari Barang Langsung"
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Appearance.Options.UseFont = True
        Me.GroupControl3.Appearance.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.Label3)
        Me.GroupControl3.Controls.Add(Me.Label4)
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Controls.Add(Me.GroupBox2)
        Me.GroupControl3.Controls.Add(Me.cbo_search_item)
        Me.GroupControl3.Controls.Add(Me.txt_search_item)
        Me.GroupControl3.Controls.Add(Me.ComboBox3)
        Me.GroupControl3.Controls.Add(Me.MtgcComboBox2)
        Me.GroupControl3.Location = New System.Drawing.Point(4, 4)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(943, 76)
        Me.GroupControl3.TabIndex = 295
        Me.GroupControl3.Text = "INFORMASI FILTER PENCARIAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(712, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 18)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "* Tekan Enter Untuk Mulai Pencarian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(163, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Teks Pencarian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(5, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 18)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Cari Berdasarkan"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(643, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(150, 43)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(72, 16)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(65, 19)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Barang"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(10, 16)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(51, 19)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Jasa"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'cbo_search_item
        '
        Me.cbo_search_item.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search_item.FormattingEnabled = True
        Me.cbo_search_item.Items.AddRange(New Object() {"ID", "Name"})
        Me.cbo_search_item.Location = New System.Drawing.Point(5, 44)
        Me.cbo_search_item.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search_item.Name = "cbo_search_item"
        Me.cbo_search_item.Size = New System.Drawing.Size(152, 26)
        Me.cbo_search_item.TabIndex = 18
        '
        'txt_search_item
        '
        Me.txt_search_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search_item.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_item.Location = New System.Drawing.Point(163, 46)
        Me.txt_search_item.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search_item.Name = "txt_search_item"
        Me.txt_search_item.Size = New System.Drawing.Size(775, 23)
        Me.txt_search_item.TabIndex = 19
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.ForeColor = System.Drawing.Color.Black
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(-1470, 40)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox3.TabIndex = 131
        Me.ComboBox3.Visible = False
        '
        'MtgcComboBox2
        '
        Me.MtgcComboBox2.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox2.ArrowColor = System.Drawing.Color.Black
        Me.MtgcComboBox2.BackColor = System.Drawing.SystemColors.ControlLight
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
        Me.MtgcComboBox2.ForeColor = System.Drawing.Color.Black
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
        'GroupControl4
        '
        Me.GroupControl4.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl4.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl4.Appearance.Options.UseBackColor = True
        Me.GroupControl4.Appearance.Options.UseFont = True
        Me.GroupControl4.Appearance.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.ComboBox4)
        Me.GroupControl4.Controls.Add(Me.MtgcComboBox3)
        Me.GroupControl4.Controls.Add(Me.DataGridView3)
        Me.GroupControl4.Location = New System.Drawing.Point(4, 85)
        Me.GroupControl4.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(943, 336)
        Me.GroupControl4.TabIndex = 294
        Me.GroupControl4.Text = "DATA ITEM"
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.ForeColor = System.Drawing.Color.Black
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(-1470, 40)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox4.TabIndex = 131
        Me.ComboBox4.Visible = False
        '
        'MtgcComboBox3
        '
        Me.MtgcComboBox3.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox3.ArrowColor = System.Drawing.Color.Black
        Me.MtgcComboBox3.BackColor = System.Drawing.SystemColors.ControlLight
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
        Me.MtgcComboBox3.ForeColor = System.Drawing.Color.Black
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
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.type, Me.Cat, Me.Brand, Me.jenis, Me.kategori, Me.merek})
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(939, 313)
        Me.DataGridView3.TabIndex = 20
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kode Barang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 135
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 135
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
        'frm_display_ro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(955, 455)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_display_ro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Permintaan Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbitem As System.Windows.Forms.RadioButton
    Friend WithEvents rbservice As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents colaccno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colaccnm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidbarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colunit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idbarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbo_supplier As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_unit As MTGCComboBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox1 As MTGCComboBox
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents cbo_search_item As System.Windows.Forms.ComboBox
    Friend WithEvents txt_search_item As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox2 As MTGCComboBox
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox3 As MTGCComboBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kategori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents merek As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
