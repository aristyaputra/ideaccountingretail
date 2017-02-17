<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkatbarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmkatbarang))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colkodejenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coljenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coljns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colketerangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label5 = New System.Windows.Forms.Label()
        Me.cbo_noakun = New MTGCComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtket = New System.Windows.Forms.TextBox()
        Me.txt_disc = New System.Windows.Forms.TextBox()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reset2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabInput = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabList = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_browse = New DevExpress.XtraEditors.SimpleButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_save_path = New System.Windows.Forms.TextBox()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridList_Customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabInput.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabList.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colkodejenis, Me.coljenis, Me.coljns, Me.disc, Me.colketerangan})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(38, 392)
        Me.DataGridView1.TabIndex = 8
        '
        'colkodejenis
        '
        Me.colkodejenis.HeaderText = "Kode Kategori"
        Me.colkodejenis.Name = "colkodejenis"
        Me.colkodejenis.ReadOnly = True
        Me.colkodejenis.Width = 120
        '
        'coljenis
        '
        Me.coljenis.HeaderText = "Kategori"
        Me.coljenis.Name = "coljenis"
        Me.coljenis.ReadOnly = True
        Me.coljenis.Width = 210
        '
        'coljns
        '
        Me.coljns.HeaderText = "Jenis"
        Me.coljns.Name = "coljns"
        Me.coljns.ReadOnly = True
        Me.coljns.Width = 165
        '
        'disc
        '
        Me.disc.HeaderText = "Diskon (%)"
        Me.disc.Name = "disc"
        Me.disc.ReadOnly = True
        Me.disc.Width = 120
        '
        'colketerangan
        '
        Me.colketerangan.HeaderText = "Keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.ReadOnly = True
        Me.colketerangan.Width = 360
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(161, 54)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(36, 18)
        Me.label5.TabIndex = 78
        Me.label5.Text = "Type"
        '
        'cbo_noakun
        '
        Me.cbo_noakun.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_noakun.ArrowColor = System.Drawing.Color.Black
        Me.cbo_noakun.BindedControl = CType(resources.GetObject("cbo_noakun.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_noakun.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_noakun.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_noakun.ColumnNum = 2
        Me.cbo_noakun.ColumnWidth = "160; 270"
        Me.cbo_noakun.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_noakun.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cbo_noakun.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cbo_noakun.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbo_noakun.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo_noakun.DisplayMember = "Text"
        Me.cbo_noakun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_noakun.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cbo_noakun.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbo_noakun.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_noakun.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_noakun.DropDownWidth = 510
        Me.cbo_noakun.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_noakun.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_noakun.GridLineHorizontal = False
        Me.cbo_noakun.GridLineVertical = True
        Me.cbo_noakun.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_noakun.HighlightBorderOnMouseEvents = True
        Me.cbo_noakun.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_noakun.Location = New System.Drawing.Point(163, 26)
        Me.cbo_noakun.ManagingFastMouseMoving = True
        Me.cbo_noakun.ManagingFastMouseMovingInterval = 30
        Me.cbo_noakun.Name = "cbo_noakun"
        Me.cbo_noakun.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_noakun.SelectedItem = Nothing
        Me.cbo_noakun.SelectedValue = Nothing
        Me.cbo_noakun.Size = New System.Drawing.Size(600, 24)
        Me.cbo_noakun.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(163, 108)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 22)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Manual Kode"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'txtkode
        '
        Me.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkode.Enabled = False
        Me.txtkode.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(163, 83)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(600, 23)
        Me.txtkode.TabIndex = 1
        '
        'txtnama
        '
        Me.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnama.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(163, 135)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(600, 23)
        Me.txtnama.TabIndex = 2
        '
        'txtket
        '
        Me.txtket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtket.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtket.Location = New System.Drawing.Point(163, 161)
        Me.txtket.Multiline = True
        Me.txtket.Name = "txtket"
        Me.txtket.Size = New System.Drawing.Size(600, 66)
        Me.txtket.TabIndex = 3
        '
        'txt_disc
        '
        Me.txt_disc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_disc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disc.Location = New System.Drawing.Point(163, 230)
        Me.txt_disc.Name = "txt_disc"
        Me.txt_disc.Size = New System.Drawing.Size(600, 23)
        Me.txt_disc.TabIndex = 13
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
        Me.GroupControl3.Controls.Add(Me.txt_disc)
        Me.GroupControl3.Controls.Add(Me.txtket)
        Me.GroupControl3.Controls.Add(Me.CheckBox1)
        Me.GroupControl3.Controls.Add(Me.txtnama)
        Me.GroupControl3.Controls.Add(Me.Label1)
        Me.GroupControl3.Controls.Add(Me.label5)
        Me.GroupControl3.Controls.Add(Me.txtkode)
        Me.GroupControl3.Controls.Add(Me.cbo_noakun)
        Me.GroupControl3.Controls.Add(Me.Label22)
        Me.GroupControl3.Controls.Add(Me.Label20)
        Me.GroupControl3.Controls.Add(Me.Label18)
        Me.GroupControl3.Controls.Add(Me.Label17)
        Me.GroupControl3.Location = New System.Drawing.Point(14, 13)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(773, 298)
        Me.GroupControl3.TabIndex = 278
        Me.GroupControl3.Text = "DATA JENIS BARANG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 264
        Me.Label1.Text = "Nama Kategori"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(7, 232)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(145, 18)
        Me.Label22.TabIndex = 263
        Me.Label22.Text = "Diskon (%) Per Kategori"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(7, 163)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 18)
        Me.Label20.TabIndex = 262
        Me.Label20.Text = "Keterangan"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(7, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 18)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Kode Kategori"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(7, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 18)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Jenis Barang"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseForeColor = True
        Me.PanelControl2.Location = New System.Drawing.Point(10, 316)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(19, 60)
        Me.PanelControl2.TabIndex = 284
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(14, 318)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(82, 36)
        Me.btn_keluar.TabIndex = 21
        Me.btn_keluar.Text = "KELUAR"
        '
        'btn_reset2
        '
        Me.btn_reset2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset2.Appearance.Options.UseFont = True
        Me.btn_reset2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset2.Location = New System.Drawing.Point(529, 318)
        Me.btn_reset2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset2.Name = "btn_reset2"
        Me.btn_reset2.Size = New System.Drawing.Size(82, 36)
        Me.btn_reset2.TabIndex = 20
        Me.btn_reset2.Text = "RESET"
        '
        'btn_del2
        '
        Me.btn_del2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_del2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del2.Appearance.Options.UseFont = True
        Me.btn_del2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Delete_16x16
        Me.btn_del2.Location = New System.Drawing.Point(617, 318)
        Me.btn_del2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_del2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_del2.Name = "btn_del2"
        Me.btn_del2.Size = New System.Drawing.Size(82, 36)
        Me.btn_del2.TabIndex = 19
        Me.btn_del2.Text = "HAPUS"
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(705, 318)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 36)
        Me.btn_save2.TabIndex = 18
        Me.btn_save2.Text = "SIMPAN"
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(-752, -4)
        Me.TabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.TabInput
        Me.TabControl1.Size = New System.Drawing.Size(40, 417)
        Me.TabControl1.TabIndex = 285
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabInput, Me.TabList})
        Me.TabControl1.Visible = False
        '
        'TabInput
        '
        Me.TabInput.Controls.Add(Me.Panel1)
        Me.TabInput.Name = "TabInput"
        Me.TabInput.Size = New System.Drawing.Size(38, 392)
        Me.TabInput.Text = "TAMBAH / EDIT KATEGORI"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.PanelControl2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(38, 392)
        Me.Panel1.TabIndex = 0
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.DataGridView1)
        Me.TabList.Name = "TabList"
        Me.TabList.Size = New System.Drawing.Size(38, 392)
        Me.TabList.Text = "DAFTAR KATEGORI"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.Controls.Add(Me.btn_reset2)
        Me.PanelControl3.Controls.Add(Me.btn_keluar)
        Me.PanelControl3.Controls.Add(Me.btn_del2)
        Me.PanelControl3.Controls.Add(Me.GroupControl3)
        Me.PanelControl3.Controls.Add(Me.btn_save2)
        Me.PanelControl3.Controls.Add(Me.GroupControl5)
        Me.PanelControl3.Location = New System.Drawing.Point(59, 117)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(802, 365)
        Me.PanelControl3.TabIndex = 286
        Me.PanelControl3.Visible = False
        '
        'GroupControl5
        '
        Me.GroupControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl5.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl5.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl5.Appearance.Options.UseBackColor = True
        Me.GroupControl5.Appearance.Options.UseFont = True
        Me.GroupControl5.Appearance.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.btn_browse)
        Me.GroupControl5.Controls.Add(Me.Label25)
        Me.GroupControl5.Controls.Add(Me.txt_save_path)
        Me.GroupControl5.Location = New System.Drawing.Point(91, -217)
        Me.GroupControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(965, 197)
        Me.GroupControl5.TabIndex = 268
        Me.GroupControl5.Text = "SETTING DIREKTORI FOTO"
        Me.GroupControl5.Visible = False
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
        Me.btn_browse.Size = New System.Drawing.Size(146, 153)
        Me.btn_browse.TabIndex = 282
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(6, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(99, 18)
        Me.Label25.TabIndex = 279
        Me.Label25.Text = "Direktori Foto :"
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
        Me.txt_save_path.Size = New System.Drawing.Size(951, 25)
        Me.txt_save_path.TabIndex = 277
        Me.txt_save_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Location = New System.Drawing.Point(12, 28)
        Me.GridControl.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl.MainView = Me.GridList_Customer
        Me.GridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(993, 454)
        Me.GridControl.TabIndex = 289
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(8, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 24)
        Me.Label2.TabIndex = 290
        Me.Label2.Text = "Daftar Kategori Barang"
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
        Me.PanelControl5.Location = New System.Drawing.Point(13, 485)
        Me.PanelControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(993, 49)
        Me.PanelControl5.TabIndex = 297
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
        Me.SimpleButton3.Size = New System.Drawing.Size(217, 37)
        Me.SimpleButton3.TabIndex = 293
        Me.SimpleButton3.Text = "TAMBAH KATEGORI BARANG"
        '
        'frmkatbarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1018, 662)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmkatbarang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kategori Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabInput.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtket As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_noakun As MTGCComboBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_disc As System.Windows.Forms.TextBox
    Friend WithEvents colkodejenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coljenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coljns As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents disc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colketerangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reset2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_save_path As System.Windows.Forms.TextBox
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridList_Customer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton

End Class
