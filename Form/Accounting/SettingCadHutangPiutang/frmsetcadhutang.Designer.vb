<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsetcadhutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsetcadhutang))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_blm_jt = New System.Windows.Forms.TextBox()
        Me.txt_1 = New System.Windows.Forms.TextBox()
        Me.txt_2 = New System.Windows.Forms.TextBox()
        Me.txt_3 = New System.Windows.Forms.TextBox()
        Me.txt_4 = New System.Windows.Forms.TextBox()
        Me.txt_5 = New System.Windows.Forms.TextBox()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.cbo_akun = New MTGCComboBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_unit = New MTGCComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabInput = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.TabList = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_reset2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridList_Customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_browse = New DevExpress.XtraEditors.SimpleButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_save_path = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabInput.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column1, Me.colid, Me.colsupplier})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(669, 533)
        Me.DataGridView2.TabIndex = 17
        '
        'column1
        '
        Me.column1.HeaderText = "id"
        Me.column1.Name = "column1"
        Me.column1.ReadOnly = True
        Me.column1.Visible = False
        '
        'colid
        '
        Me.colid.HeaderText = "Umur Hutang"
        Me.colid.Name = "colid"
        Me.colid.ReadOnly = True
        Me.colid.Width = 540
        '
        'colsupplier
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colsupplier.DefaultCellStyle = DataGridViewCellStyle2
        Me.colsupplier.HeaderText = "Prosentase"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.ReadOnly = True
        Me.colsupplier.Width = 103
        '
        'txt_blm_jt
        '
        Me.txt_blm_jt.BackColor = System.Drawing.Color.White
        Me.txt_blm_jt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_blm_jt.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_blm_jt.Location = New System.Drawing.Point(12, 43)
        Me.txt_blm_jt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_blm_jt.Name = "txt_blm_jt"
        Me.txt_blm_jt.Size = New System.Drawing.Size(630, 23)
        Me.txt_blm_jt.TabIndex = 0
        '
        'txt_1
        '
        Me.txt_1.BackColor = System.Drawing.Color.White
        Me.txt_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_1.Location = New System.Drawing.Point(12, 89)
        Me.txt_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(630, 23)
        Me.txt_1.TabIndex = 1
        '
        'txt_2
        '
        Me.txt_2.BackColor = System.Drawing.Color.White
        Me.txt_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_2.Location = New System.Drawing.Point(12, 135)
        Me.txt_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(630, 23)
        Me.txt_2.TabIndex = 2
        '
        'txt_3
        '
        Me.txt_3.BackColor = System.Drawing.Color.White
        Me.txt_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_3.Location = New System.Drawing.Point(12, 181)
        Me.txt_3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_3.Name = "txt_3"
        Me.txt_3.Size = New System.Drawing.Size(630, 23)
        Me.txt_3.TabIndex = 3
        '
        'txt_4
        '
        Me.txt_4.BackColor = System.Drawing.Color.White
        Me.txt_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_4.Location = New System.Drawing.Point(12, 227)
        Me.txt_4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_4.Name = "txt_4"
        Me.txt_4.Size = New System.Drawing.Size(630, 23)
        Me.txt_4.TabIndex = 4
        '
        'txt_5
        '
        Me.txt_5.BackColor = System.Drawing.Color.White
        Me.txt_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_5.Location = New System.Drawing.Point(12, 273)
        Me.txt_5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_5.Name = "txt_5"
        Me.txt_5.Size = New System.Drawing.Size(630, 23)
        Me.txt_5.TabIndex = 5
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Pengelompokan Akun"
        Me.NavBarGroup2.ControlContainer = Me.NavBarGroupControlContainer2
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.GroupClientHeight = 25
        Me.NavBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(803, 24)
        Me.NavBarGroupControlContainer2.TabIndex = 4
        '
        'cbo_akun
        '
        Me.cbo_akun.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_akun.ArrowColor = System.Drawing.Color.Black
        Me.cbo_akun.BindedControl = CType(resources.GetObject("cbo_akun.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_akun.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_akun.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_akun.ColumnNum = 2
        Me.cbo_akun.ColumnWidth = "160; 270"
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
        Me.cbo_akun.DropDownWidth = 510
        Me.cbo_akun.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_akun.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_akun.GridLineHorizontal = False
        Me.cbo_akun.GridLineVertical = True
        Me.cbo_akun.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_akun.HighlightBorderOnMouseEvents = True
        Me.cbo_akun.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_akun.Location = New System.Drawing.Point(0, 0)
        Me.cbo_akun.ManagingFastMouseMoving = True
        Me.cbo_akun.ManagingFastMouseMovingInterval = 30
        Me.cbo_akun.Name = "cbo_akun"
        Me.cbo_akun.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_akun.SelectedItem = Nothing
        Me.cbo_akun.SelectedValue = Nothing
        Me.cbo_akun.Size = New System.Drawing.Size(803, 24)
        Me.cbo_akun.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txt_5)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txt_4)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.txt_3)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txt_2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.txt_1)
        Me.GroupControl1.Controls.Add(Me.txt_blm_jt)
        Me.GroupControl1.Controls.Add(Me.ComboBox2)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.cbo_unit)
        Me.GroupControl1.Controls.Add(Me.Label18)
        Me.GroupControl1.Controls.Add(Me.Label24)
        Me.GroupControl1.Controls.Add(Me.Label29)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 6)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(650, 317)
        Me.GroupControl1.TabIndex = 299
        Me.GroupControl1.Text = "INFORMASI CADANGAN PENGHAPUSAN HUTANG"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 18)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "> 120 Hari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 18)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "91 s/d 120 Hari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "61 s/d 90 Hari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "31 s/d 60 Hari"
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
        Me.ComboBox2.Location = New System.Drawing.Point(-1763, 40)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox2.TabIndex = 131
        Me.ComboBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "<= 30 Hari"
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
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(681, 68)
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
        Me.Label24.Location = New System.Drawing.Point(681, 35)
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
        Me.Label29.Location = New System.Drawing.Point(9, 23)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(123, 18)
        Me.Label29.TabIndex = 102
        Me.Label29.Text = "Belum Jatuh Tempo"
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(-32768, -32768)
        Me.TabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.TabInput
        Me.TabControl1.Size = New System.Drawing.Size(671, 558)
        Me.TabControl1.TabIndex = 300
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabInput, Me.TabList})
        Me.TabControl1.Visible = False
        '
        'TabInput
        '
        Me.TabInput.Controls.Add(Me.Panel2)
        Me.TabInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabInput.Name = "TabInput"
        Me.TabInput.Size = New System.Drawing.Size(669, 533)
        Me.TabInput.Text = "TAMBAH / UBAH PROSENTASE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.btn_keluar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(669, 533)
        Me.Panel2.TabIndex = 0
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(9, 337)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(97, 35)
        Me.btn_keluar.TabIndex = 19
        Me.btn_keluar.Text = "KELUAR"
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.Panel4)
        Me.TabList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabList.Name = "TabList"
        Me.TabList.Size = New System.Drawing.Size(669, 533)
        Me.TabList.Text = "DAFTAR PROSENTASE"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.DataGridView2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(669, 533)
        Me.Panel4.TabIndex = 0
        '
        'btn_reset2
        '
        Me.btn_reset2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_reset2.Appearance.Options.UseFont = True
        Me.btn_reset2.Appearance.Options.UseForeColor = True
        Me.btn_reset2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset2.Location = New System.Drawing.Point(484, 333)
        Me.btn_reset2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_reset2.Name = "btn_reset2"
        Me.btn_reset2.Size = New System.Drawing.Size(82, 35)
        Me.btn_reset2.TabIndex = 18
        Me.btn_reset2.Text = "RESET"
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(572, 333)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 35)
        Me.btn_save2.TabIndex = 16
        Me.btn_save2.Text = "SIMPAN"
        '
        'PanelControl5
        '
        Me.PanelControl5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl5.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl5.Appearance.Options.UseBackColor = True
        Me.PanelControl5.Appearance.Options.UseForeColor = True
        Me.PanelControl5.Controls.Add(Me.SimpleButton3)
        Me.PanelControl5.Controls.Add(Me.SimpleButton4)
        Me.PanelControl5.Controls.Add(Me.SimpleButton8)
        Me.PanelControl5.Location = New System.Drawing.Point(13, 610)
        Me.PanelControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(993, 49)
        Me.PanelControl5.TabIndex = 303
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Appearance.Options.UseForeColor = True
        Me.SimpleButton3.Image = Global.SMARTACCOUNTING.My.Resources.Resources.add
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 6)
        Me.SimpleButton3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(145, 37)
        Me.SimpleButton3.TabIndex = 296
        Me.SimpleButton3.Text = "SET PROSENTASE"
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
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Location = New System.Drawing.Point(13, 33)
        Me.GridControl.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl.MainView = Me.GridList_Customer
        Me.GridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(993, 575)
        Me.GridControl.TabIndex = 301
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(9, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(395, 24)
        Me.Label4.TabIndex = 302
        Me.Label4.Text = "Prosentase Cadangan Penghapusan Hutang"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.Controls.Add(Me.SimpleButton1)
        Me.PanelControl3.Controls.Add(Me.GroupControl5)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.btn_reset2)
        Me.PanelControl3.Controls.Add(Me.btn_save2)
        Me.PanelControl3.Location = New System.Drawing.Point(52, 82)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(659, 381)
        Me.PanelControl3.TabIndex = 304
        Me.PanelControl3.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 333)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(82, 35)
        Me.SimpleButton1.TabIndex = 300
        Me.SimpleButton1.Text = "KELUAR"
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
        Me.GroupControl5.Controls.Add(Me.Label6)
        Me.GroupControl5.Controls.Add(Me.txt_save_path)
        Me.GroupControl5.Location = New System.Drawing.Point(91, -217)
        Me.GroupControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(822, 197)
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
        Me.btn_browse.Size = New System.Drawing.Size(69, 153)
        Me.btn_browse.TabIndex = 282
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 18)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Direktori Foto :"
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
        Me.txt_save_path.Size = New System.Drawing.Size(808, 25)
        Me.txt_save_path.TabIndex = 277
        Me.txt_save_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmsetcadhutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1018, 672)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmsetcadhutang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Prosentase Cadangan Penghapusan Hutang"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabInput.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_blm_jt As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents cbo_akun As MTGCComboBox
    Friend WithEvents txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_5 As System.Windows.Forms.TextBox
    Friend WithEvents column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_unit As MTGCComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reset2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridList_Customer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_save_path As System.Windows.Forms.TextBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
End Class
