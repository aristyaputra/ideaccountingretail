<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserRight))
        Me.TreeUser = New System.Windows.Forms.TreeView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.coluserid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.collevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDepartemen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpilih = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtdepartment = New System.Windows.Forms.TextBox()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.cbo_noakun = New MTGCComboBox()
        Me.panel = New DevExpress.XtraEditors.GroupControl()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.cbo_unit = New MTGCComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btn_reset2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox1 = New MTGCComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox2 = New MTGCComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeUser
        '
        Me.TreeUser.BackColor = System.Drawing.Color.DimGray
        Me.TreeUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeUser.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeUser.ForeColor = System.Drawing.Color.Gold
        Me.TreeUser.Location = New System.Drawing.Point(2, 21)
        Me.TreeUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TreeUser.Name = "TreeUser"
        Me.TreeUser.Size = New System.Drawing.Size(271, 649)
        Me.TreeUser.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coluserid, Me.colname, Me.collevel, Me.ColDepartemen, Me.colpilih})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(731, 593)
        Me.DataGridView1.TabIndex = 1
        '
        'coluserid
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coluserid.DefaultCellStyle = DataGridViewCellStyle2
        Me.coluserid.HeaderText = "Username"
        Me.coluserid.Name = "coluserid"
        Me.coluserid.Width = 120
        '
        'colname
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colname.DefaultCellStyle = DataGridViewCellStyle3
        Me.colname.HeaderText = "Karyawan"
        Me.colname.Name = "colname"
        Me.colname.Width = 190
        '
        'collevel
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collevel.DefaultCellStyle = DataGridViewCellStyle4
        Me.collevel.HeaderText = "Posisi"
        Me.collevel.Name = "collevel"
        Me.collevel.Width = 140
        '
        'ColDepartemen
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDepartemen.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColDepartemen.HeaderText = "Departemen"
        Me.ColDepartemen.Name = "ColDepartemen"
        Me.ColDepartemen.Width = 170
        '
        'colpilih
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.NullValue = False
        Me.colpilih.DefaultCellStyle = DataGridViewCellStyle6
        Me.colpilih.HeaderText = "Pilih"
        Me.colpilih.Name = "colpilih"
        Me.colpilih.Width = 60
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Location = New System.Drawing.Point(108, 121)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(285, 22)
        Me.txtpassword.TabIndex = 9
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.White
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.Black
        Me.txtuser.Location = New System.Drawing.Point(108, 97)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(285, 22)
        Me.txtuser.TabIndex = 8
        '
        'txtdepartment
        '
        Me.txtdepartment.BackColor = System.Drawing.Color.White
        Me.txtdepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdepartment.Enabled = False
        Me.txtdepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepartment.ForeColor = System.Drawing.Color.Black
        Me.txtdepartment.Location = New System.Drawing.Point(108, 73)
        Me.txtdepartment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdepartment.Name = "txtdepartment"
        Me.txtdepartment.ReadOnly = True
        Me.txtdepartment.Size = New System.Drawing.Size(285, 22)
        Me.txtdepartment.TabIndex = 7
        '
        'txtposition
        '
        Me.txtposition.BackColor = System.Drawing.Color.White
        Me.txtposition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtposition.Enabled = False
        Me.txtposition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposition.ForeColor = System.Drawing.Color.Black
        Me.txtposition.Location = New System.Drawing.Point(108, 49)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.ReadOnly = True
        Me.txtposition.Size = New System.Drawing.Size(285, 22)
        Me.txtposition.TabIndex = 6
        '
        'cbo_noakun
        '
        Me.cbo_noakun.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_noakun.ArrowColor = System.Drawing.Color.Black
        Me.cbo_noakun.BackColor = System.Drawing.Color.White
        Me.cbo_noakun.BindedControl = CType(resources.GetObject("cbo_noakun.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_noakun.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_noakun.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_noakun.ColumnNum = 2
        Me.cbo_noakun.ColumnWidth = "90; 200"
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
        Me.cbo_noakun.DropDownWidth = 310
        Me.cbo_noakun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_noakun.ForeColor = System.Drawing.Color.Black
        Me.cbo_noakun.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_noakun.GridLineHorizontal = False
        Me.cbo_noakun.GridLineVertical = False
        Me.cbo_noakun.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_noakun.HighlightBorderOnMouseEvents = True
        Me.cbo_noakun.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_noakun.Location = New System.Drawing.Point(108, 24)
        Me.cbo_noakun.ManagingFastMouseMoving = True
        Me.cbo_noakun.ManagingFastMouseMovingInterval = 30
        Me.cbo_noakun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_noakun.Name = "cbo_noakun"
        Me.cbo_noakun.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_noakun.SelectedItem = Nothing
        Me.cbo_noakun.SelectedValue = Nothing
        Me.cbo_noakun.Size = New System.Drawing.Size(285, 23)
        Me.cbo_noakun.TabIndex = 5
        '
        'panel
        '
        Me.panel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.panel.Appearance.Options.UseBackColor = True
        Me.panel.Appearance.Options.UseFont = True
        Me.panel.Appearance.Options.UseForeColor = True
        Me.panel.Controls.Add(Me.btn_keluar)
        Me.panel.Controls.Add(Me.btn_save2)
        Me.panel.Controls.Add(Me.Label9)
        Me.panel.Controls.Add(Me.Label8)
        Me.panel.Controls.Add(Me.Label7)
        Me.panel.Controls.Add(Me.txtpassword)
        Me.panel.Controls.Add(Me.Label6)
        Me.panel.Controls.Add(Me.txtuser)
        Me.panel.Controls.Add(Me.ComboBox3)
        Me.panel.Controls.Add(Me.cbo_unit)
        Me.panel.Controls.Add(Me.Label18)
        Me.panel.Controls.Add(Me.txtdepartment)
        Me.panel.Controls.Add(Me.Label24)
        Me.panel.Controls.Add(Me.txtposition)
        Me.panel.Controls.Add(Me.Label29)
        Me.panel.Controls.Add(Me.cbo_noakun)
        Me.panel.Location = New System.Drawing.Point(319, 406)
        Me.panel.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.panel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(400, 200)
        Me.panel.TabIndex = 300
        Me.panel.Text = "REGISTRASI USER"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(218, 154)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(86, 36)
        Me.btn_keluar.TabIndex = 137
        Me.btn_keluar.Text = "BATAL"
        '
        'btn_save2
        '
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(311, 154)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 36)
        Me.btn_save2.TabIndex = 136
        Me.btn_save2.Text = "SIMPAN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 18)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Departemen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 18)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Posisi"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.ForeColor = System.Drawing.Color.Black
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(-2415, 46)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(174, 26)
        Me.ComboBox3.TabIndex = 131
        Me.ComboBox3.Visible = False
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
        Me.Label24.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(10, 27)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(63, 18)
        Me.Label29.TabIndex = 102
        Me.Label29.Text = "Karyawan"
        '
        'btn_reset2
        '
        Me.btn_reset2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_reset2.Appearance.Options.UseFont = True
        Me.btn_reset2.Appearance.Options.UseForeColor = True
        Me.btn_reset2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.add
        Me.btn_reset2.Location = New System.Drawing.Point(519, 620)
        Me.btn_reset2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset2.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.btn_reset2.Name = "btn_reset2"
        Me.btn_reset2.Size = New System.Drawing.Size(64, 38)
        Me.btn_reset2.TabIndex = 302
        Me.btn_reset2.Text = "USER"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.SimpleButton1.Location = New System.Drawing.Point(589, 620)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(143, 38)
        Me.SimpleButton1.TabIndex = 301
        Me.SimpleButton1.Text = "UBAH HAK AKSES"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.ComboBox1)
        Me.GroupControl1.Controls.Add(Me.MtgcComboBox1)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.TreeUser)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(275, 672)
        Me.GroupControl1.TabIndex = 303
        Me.GroupControl1.Text = "DAFTAR MODULE"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(-2540, 46)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(174, 26)
        Me.ComboBox1.TabIndex = 131
        Me.ComboBox1.Visible = False
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(727, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 18)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Tanggal Permintaan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(727, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 18)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "No Permintaan"
        Me.Label10.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.SimpleButton4)
        Me.GroupControl2.Controls.Add(Me.ComboBox2)
        Me.GroupControl2.Controls.Add(Me.MtgcComboBox2)
        Me.GroupControl2.Controls.Add(Me.btn_reset2)
        Me.GroupControl2.Controls.Add(Me.Label11)
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Controls.Add(Me.Label12)
        Me.GroupControl2.Controls.Add(Me.panel)
        Me.GroupControl2.Controls.Add(Me.DataGridView1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(275, 0)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(743, 672)
        Me.GroupControl2.TabIndex = 304
        Me.GroupControl2.Text = "REGISTRASI USER"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Appearance.Options.UseForeColor = True
        Me.SimpleButton4.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.SimpleButton4.Location = New System.Drawing.Point(6, 624)
        Me.SimpleButton4.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(90, 33)
        Me.SimpleButton4.TabIndex = 303
        Me.SimpleButton4.Text = "TUTUP"
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
        Me.ComboBox2.Location = New System.Drawing.Point(-2478, 46)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(174, 26)
        Me.ComboBox2.TabIndex = 131
        Me.ComboBox2.Visible = False
        '
        'MtgcComboBox2
        '
        Me.MtgcComboBox2.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox2.ArrowColor = System.Drawing.Color.Black
        Me.MtgcComboBox2.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.MtgcComboBox2.Location = New System.Drawing.Point(-13205, 47)
        Me.MtgcComboBox2.ManagingFastMouseMoving = True
        Me.MtgcComboBox2.ManagingFastMouseMovingInterval = 30
        Me.MtgcComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MtgcComboBox2.Name = "MtgcComboBox2"
        Me.MtgcComboBox2.NormalBorderColor = System.Drawing.Color.Black
        Me.MtgcComboBox2.SelectedItem = Nothing
        Me.MtgcComboBox2.SelectedValue = Nothing
        Me.MtgcComboBox2.Size = New System.Drawing.Size(140, 24)
        Me.MtgcComboBox2.TabIndex = 130
        Me.MtgcComboBox2.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(880, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 18)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Tanggal Permintaan"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(880, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 18)
        Me.Label12.TabIndex = 128
        Me.Label12.Text = "No Permintaan"
        Me.Label12.Visible = False
        '
        'UserRight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1018, 672)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserRight"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengaturan User dan Hak Akses"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeUser As System.Windows.Forms.TreeView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_noakun As MTGCComboBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtdepartment As System.Windows.Forms.TextBox
    Friend WithEvents txtposition As System.Windows.Forms.TextBox
    Friend WithEvents coluserid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents collevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDepartemen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpilih As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents panel As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_unit As MTGCComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reset2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox1 As MTGCComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox2 As MTGCComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
