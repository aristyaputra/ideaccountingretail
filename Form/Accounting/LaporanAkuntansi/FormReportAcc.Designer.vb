<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportAcc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportAcc))
        Me.gb_filterbl_purch = New System.Windows.Forms.GroupBox()
        Me.chk_filterbl_purch = New System.Windows.Forms.CheckBox()
        Me.bl_purch2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bl_purch1 = New System.Windows.Forms.DateTimePicker()
        Me.From = New System.Windows.Forms.Label()
        Me.gb_filtersupp_purch = New System.Windows.Forms.GroupBox()
        Me.chk_filtersupp_purch = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_supp_purch1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cbo_supp_purch2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gb_filtertgl_purch = New System.Windows.Forms.GroupBox()
        Me.chk_filtertgl_purch = New System.Windows.Forms.CheckBox()
        Me.tgl_purch2 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tgl_purch1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gb_filterth_purch = New System.Windows.Forms.GroupBox()
        Me.th_purch = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_purch11 = New System.Windows.Forms.RadioButton()
        Me.rb_purch10 = New System.Windows.Forms.RadioButton()
        Me.rb_purch1 = New System.Windows.Forms.RadioButton()
        Me.rb_purch6 = New System.Windows.Forms.RadioButton()
        Me.rb_purch7 = New System.Windows.Forms.RadioButton()
        Me.rb_purch9 = New System.Windows.Forms.RadioButton()
        Me.rb_purch3 = New System.Windows.Forms.RadioButton()
        Me.rb_purch2 = New System.Windows.Forms.RadioButton()
        Me.rb_purch8 = New System.Windows.Forms.RadioButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ListReport = New DevExpress.XtraEditors.ListBoxControl()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_purch = New DevExpress.XtraEditors.SimpleButton()
        Me.gb_filterbl_purch.SuspendLayout()
        Me.gb_filtersupp_purch.SuspendLayout()
        CType(Me.cbo_supp_purch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_supp_purch2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_filtertgl_purch.SuspendLayout()
        Me.gb_filterth_purch.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ListReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_filterbl_purch
        '
        Me.gb_filterbl_purch.BackColor = System.Drawing.Color.Transparent
        Me.gb_filterbl_purch.Controls.Add(Me.chk_filterbl_purch)
        Me.gb_filterbl_purch.Controls.Add(Me.bl_purch2)
        Me.gb_filterbl_purch.Controls.Add(Me.Label2)
        Me.gb_filterbl_purch.Controls.Add(Me.bl_purch1)
        Me.gb_filterbl_purch.Controls.Add(Me.From)
        Me.gb_filterbl_purch.ForeColor = System.Drawing.Color.Black
        Me.gb_filterbl_purch.Location = New System.Drawing.Point(533, 24)
        Me.gb_filterbl_purch.Name = "gb_filterbl_purch"
        Me.gb_filterbl_purch.Size = New System.Drawing.Size(167, 158)
        Me.gb_filterbl_purch.TabIndex = 45
        Me.gb_filterbl_purch.TabStop = False
        Me.gb_filterbl_purch.Text = "Filter Bulan"
        '
        'chk_filterbl_purch
        '
        Me.chk_filterbl_purch.AutoSize = True
        Me.chk_filterbl_purch.ForeColor = System.Drawing.Color.Black
        Me.chk_filterbl_purch.Location = New System.Drawing.Point(13, 20)
        Me.chk_filterbl_purch.Name = "chk_filterbl_purch"
        Me.chk_filterbl_purch.Size = New System.Drawing.Size(75, 22)
        Me.chk_filterbl_purch.TabIndex = 58
        Me.chk_filterbl_purch.Text = "Filter By"
        Me.chk_filterbl_purch.UseVisualStyleBackColor = True
        '
        'bl_purch2
        '
        Me.bl_purch2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bl_purch2.CustomFormat = "MMM-yyyy"
        Me.bl_purch2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bl_purch2.ForeColor = System.Drawing.Color.Black
        Me.bl_purch2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bl_purch2.Location = New System.Drawing.Point(13, 110)
        Me.bl_purch2.Name = "bl_purch2"
        Me.bl_purch2.Size = New System.Drawing.Size(129, 23)
        Me.bl_purch2.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Sampai"
        '
        'bl_purch1
        '
        Me.bl_purch1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bl_purch1.CustomFormat = "MMM-yyyy"
        Me.bl_purch1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bl_purch1.ForeColor = System.Drawing.Color.Black
        Me.bl_purch1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bl_purch1.Location = New System.Drawing.Point(13, 65)
        Me.bl_purch1.Name = "bl_purch1"
        Me.bl_purch1.Size = New System.Drawing.Size(129, 23)
        Me.bl_purch1.TabIndex = 50
        '
        'From
        '
        Me.From.AutoSize = True
        Me.From.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.From.ForeColor = System.Drawing.Color.Black
        Me.From.Location = New System.Drawing.Point(13, 48)
        Me.From.Name = "From"
        Me.From.Size = New System.Drawing.Size(32, 18)
        Me.From.TabIndex = 49
        Me.From.Text = "Dari"
        '
        'gb_filtersupp_purch
        '
        Me.gb_filtersupp_purch.BackColor = System.Drawing.Color.Transparent
        Me.gb_filtersupp_purch.Controls.Add(Me.chk_filtersupp_purch)
        Me.gb_filtersupp_purch.Controls.Add(Me.Label10)
        Me.gb_filtersupp_purch.Controls.Add(Me.Label11)
        Me.gb_filtersupp_purch.Controls.Add(Me.cbo_supp_purch1)
        Me.gb_filtersupp_purch.Controls.Add(Me.cbo_supp_purch2)
        Me.gb_filtersupp_purch.ForeColor = System.Drawing.Color.Black
        Me.gb_filtersupp_purch.Location = New System.Drawing.Point(5, 24)
        Me.gb_filtersupp_purch.Name = "gb_filtersupp_purch"
        Me.gb_filtersupp_purch.Size = New System.Drawing.Size(222, 158)
        Me.gb_filtersupp_purch.TabIndex = 54
        Me.gb_filtersupp_purch.TabStop = False
        Me.gb_filtersupp_purch.Text = "Filter Akun"
        '
        'chk_filtersupp_purch
        '
        Me.chk_filtersupp_purch.AutoSize = True
        Me.chk_filtersupp_purch.ForeColor = System.Drawing.Color.Black
        Me.chk_filtersupp_purch.Location = New System.Drawing.Point(16, 20)
        Me.chk_filtersupp_purch.Name = "chk_filtersupp_purch"
        Me.chk_filtersupp_purch.Size = New System.Drawing.Size(105, 22)
        Me.chk_filtersupp_purch.TabIndex = 57
        Me.chk_filtersupp_purch.Text = "Dengan Filter"
        Me.chk_filtersupp_purch.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 18)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Sampai"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 18)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Dari"
        '
        'cbo_supp_purch1
        '
        Me.cbo_supp_purch1.Location = New System.Drawing.Point(14, 66)
        Me.cbo_supp_purch1.Name = "cbo_supp_purch1"
        Me.cbo_supp_purch1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_supp_purch1.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supp_purch1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cbo_supp_purch1.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_supp_purch1.Properties.Appearance.Options.UseFont = True
        Me.cbo_supp_purch1.Properties.Appearance.Options.UseForeColor = True
        Me.cbo_supp_purch1.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supp_purch1.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cbo_supp_purch1.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supp_purch1.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbo_supp_purch1.Properties.AppearanceFocused.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supp_purch1.Properties.AppearanceFocused.Options.UseFont = True
        Me.cbo_supp_purch1.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supp_purch1.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbo_supp_purch1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_supp_purch1.Properties.DisplayMember = "account_name"
        Me.cbo_supp_purch1.Properties.ValueMember = "id_account"
        Me.cbo_supp_purch1.Properties.View = Me.GridLookUpEdit1View
        Me.cbo_supp_purch1.Size = New System.Drawing.Size(184, 24)
        Me.cbo_supp_purch1.TabIndex = 59
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'cbo_supp_purch2
        '
        Me.cbo_supp_purch2.Location = New System.Drawing.Point(16, 111)
        Me.cbo_supp_purch2.Name = "cbo_supp_purch2"
        Me.cbo_supp_purch2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_supp_purch2.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supp_purch2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cbo_supp_purch2.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_supp_purch2.Properties.Appearance.Options.UseFont = True
        Me.cbo_supp_purch2.Properties.Appearance.Options.UseForeColor = True
        Me.cbo_supp_purch2.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supp_purch2.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cbo_supp_purch2.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supp_purch2.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbo_supp_purch2.Properties.AppearanceFocused.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supp_purch2.Properties.AppearanceFocused.Options.UseFont = True
        Me.cbo_supp_purch2.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_supp_purch2.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbo_supp_purch2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_supp_purch2.Properties.DisplayMember = "account_name"
        Me.cbo_supp_purch2.Properties.ValueMember = "id_account"
        Me.cbo_supp_purch2.Properties.View = Me.GridView1
        Me.cbo_supp_purch2.Size = New System.Drawing.Size(184, 24)
        Me.cbo_supp_purch2.TabIndex = 60
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'gb_filtertgl_purch
        '
        Me.gb_filtertgl_purch.BackColor = System.Drawing.Color.Transparent
        Me.gb_filtertgl_purch.Controls.Add(Me.chk_filtertgl_purch)
        Me.gb_filtertgl_purch.Controls.Add(Me.tgl_purch2)
        Me.gb_filtertgl_purch.Controls.Add(Me.Label8)
        Me.gb_filtertgl_purch.Controls.Add(Me.tgl_purch1)
        Me.gb_filtertgl_purch.Controls.Add(Me.Label9)
        Me.gb_filtertgl_purch.ForeColor = System.Drawing.Color.Black
        Me.gb_filtertgl_purch.Location = New System.Drawing.Point(234, 24)
        Me.gb_filtertgl_purch.Name = "gb_filtertgl_purch"
        Me.gb_filtertgl_purch.Size = New System.Drawing.Size(156, 158)
        Me.gb_filtertgl_purch.TabIndex = 55
        Me.gb_filtertgl_purch.TabStop = False
        Me.gb_filtertgl_purch.Text = "Filter Tanggal"
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
        'tgl_purch2
        '
        Me.tgl_purch2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tgl_purch2.CustomFormat = "dd-MMM-yyyy"
        Me.tgl_purch2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_purch2.ForeColor = System.Drawing.Color.Black
        Me.tgl_purch2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tgl_purch2.Location = New System.Drawing.Point(14, 109)
        Me.tgl_purch2.Name = "tgl_purch2"
        Me.tgl_purch2.Size = New System.Drawing.Size(126, 23)
        Me.tgl_purch2.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 18)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Sampai"
        '
        'tgl_purch1
        '
        Me.tgl_purch1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tgl_purch1.CustomFormat = "dd-MMM-yyyy"
        Me.tgl_purch1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_purch1.ForeColor = System.Drawing.Color.Black
        Me.tgl_purch1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tgl_purch1.Location = New System.Drawing.Point(14, 65)
        Me.tgl_purch1.Name = "tgl_purch1"
        Me.tgl_purch1.Size = New System.Drawing.Size(126, 23)
        Me.tgl_purch1.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(14, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 18)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Dari"
        '
        'gb_filterth_purch
        '
        Me.gb_filterth_purch.BackColor = System.Drawing.Color.Transparent
        Me.gb_filterth_purch.Controls.Add(Me.th_purch)
        Me.gb_filterth_purch.ForeColor = System.Drawing.Color.Black
        Me.gb_filterth_purch.Location = New System.Drawing.Point(396, 24)
        Me.gb_filterth_purch.Name = "gb_filterth_purch"
        Me.gb_filterth_purch.Size = New System.Drawing.Size(133, 158)
        Me.gb_filterth_purch.TabIndex = 55
        Me.gb_filterth_purch.TabStop = False
        Me.gb_filterth_purch.Text = "Filter Tahun"
        '
        'th_purch
        '
        Me.th_purch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.th_purch.CustomFormat = "yyyy"
        Me.th_purch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.th_purch.ForeColor = System.Drawing.Color.Black
        Me.th_purch.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.th_purch.Location = New System.Drawing.Point(13, 22)
        Me.th_purch.Name = "th_purch"
        Me.th_purch.Size = New System.Drawing.Size(114, 23)
        Me.th_purch.TabIndex = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rb_purch11)
        Me.GroupBox1.Controls.Add(Me.rb_purch10)
        Me.GroupBox1.Controls.Add(Me.rb_purch1)
        Me.GroupBox1.Controls.Add(Me.rb_purch6)
        Me.GroupBox1.Controls.Add(Me.rb_purch7)
        Me.GroupBox1.Controls.Add(Me.rb_purch9)
        Me.GroupBox1.Controls.Add(Me.rb_purch3)
        Me.GroupBox1.Controls.Add(Me.rb_purch2)
        Me.GroupBox1.Controls.Add(Me.rb_purch8)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(32723, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 308)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'rb_purch11
        '
        Me.rb_purch11.AutoSize = True
        Me.rb_purch11.BackColor = System.Drawing.Color.Transparent
        Me.rb_purch11.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_purch11.ForeColor = System.Drawing.Color.Black
        Me.rb_purch11.Location = New System.Drawing.Point(0, 96)
        Me.rb_purch11.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_purch11.Name = "rb_purch11"
        Me.rb_purch11.Size = New System.Drawing.Size(260, 24)
        Me.rb_purch11.TabIndex = 16
        Me.rb_purch11.Text = "Neraca Saldo Setelah Penyesuaian"
        Me.rb_purch11.UseVisualStyleBackColor = False
        '
        'rb_purch10
        '
        Me.rb_purch10.AutoSize = True
        Me.rb_purch10.BackColor = System.Drawing.Color.Transparent
        Me.rb_purch10.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_purch10.ForeColor = System.Drawing.Color.Black
        Me.rb_purch10.Location = New System.Drawing.Point(0, 123)
        Me.rb_purch10.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_purch10.Name = "rb_purch10"
        Me.rb_purch10.Size = New System.Drawing.Size(137, 24)
        Me.rb_purch10.TabIndex = 15
        Me.rb_purch10.Text = "Neraca (Staffel)"
        Me.rb_purch10.UseVisualStyleBackColor = False
        '
        'rb_purch1
        '
        Me.rb_purch1.AutoSize = True
        Me.rb_purch1.BackColor = System.Drawing.Color.Transparent
        Me.rb_purch1.Checked = True
        Me.rb_purch1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_purch1.ForeColor = System.Drawing.Color.Black
        Me.rb_purch1.Location = New System.Drawing.Point(0, 17)
        Me.rb_purch1.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_purch1.Name = "rb_purch1"
        Me.rb_purch1.Size = New System.Drawing.Size(140, 24)
        Me.rb_purch1.TabIndex = 5
        Me.rb_purch1.TabStop = True
        Me.rb_purch1.Text = "Jurnal Transaksi"
        Me.rb_purch1.UseVisualStyleBackColor = False
        '
        'rb_purch6
        '
        Me.rb_purch6.AutoSize = True
        Me.rb_purch6.BackColor = System.Drawing.Color.Transparent
        Me.rb_purch6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_purch6.ForeColor = System.Drawing.Color.Black
        Me.rb_purch6.Location = New System.Drawing.Point(0, 148)
        Me.rb_purch6.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_purch6.Name = "rb_purch6"
        Me.rb_purch6.Size = New System.Drawing.Size(143, 24)
        Me.rb_purch6.TabIndex = 11
        Me.rb_purch6.Text = "Neraca (Skontro)"
        Me.rb_purch6.UseVisualStyleBackColor = False
        '
        'rb_purch7
        '
        Me.rb_purch7.AutoSize = True
        Me.rb_purch7.BackColor = System.Drawing.Color.Transparent
        Me.rb_purch7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_purch7.ForeColor = System.Drawing.Color.Black
        Me.rb_purch7.Location = New System.Drawing.Point(0, 174)
        Me.rb_purch7.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_purch7.Name = "rb_purch7"
        Me.rb_purch7.Size = New System.Drawing.Size(186, 24)
        Me.rb_purch7.TabIndex = 12
        Me.rb_purch7.Text = "Harga Pokok Penjualan"
        Me.rb_purch7.UseVisualStyleBackColor = False
        '
        'rb_purch9
        '
        Me.rb_purch9.AutoSize = True
        Me.rb_purch9.BackColor = System.Drawing.Color.Transparent
        Me.rb_purch9.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_purch9.ForeColor = System.Drawing.Color.Black
        Me.rb_purch9.Location = New System.Drawing.Point(0, 226)
        Me.rb_purch9.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_purch9.Name = "rb_purch9"
        Me.rb_purch9.Size = New System.Drawing.Size(204, 24)
        Me.rb_purch9.TabIndex = 14
        Me.rb_purch9.Text = "Laporan Perubahan Modal"
        Me.rb_purch9.UseVisualStyleBackColor = False
        '
        'rb_purch3
        '
        Me.rb_purch3.AutoSize = True
        Me.rb_purch3.BackColor = System.Drawing.Color.Transparent
        Me.rb_purch3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_purch3.ForeColor = System.Drawing.Color.Black
        Me.rb_purch3.Location = New System.Drawing.Point(0, 70)
        Me.rb_purch3.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_purch3.Name = "rb_purch3"
        Me.rb_purch3.Size = New System.Drawing.Size(115, 24)
        Me.rb_purch3.TabIndex = 6
        Me.rb_purch3.Text = "Neraca Saldo"
        Me.rb_purch3.UseVisualStyleBackColor = False
        '
        'rb_purch2
        '
        Me.rb_purch2.AutoSize = True
        Me.rb_purch2.BackColor = System.Drawing.Color.Transparent
        Me.rb_purch2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_purch2.ForeColor = System.Drawing.Color.Black
        Me.rb_purch2.Location = New System.Drawing.Point(0, 44)
        Me.rb_purch2.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_purch2.Name = "rb_purch2"
        Me.rb_purch2.Size = New System.Drawing.Size(100, 24)
        Me.rb_purch2.TabIndex = 10
        Me.rb_purch2.Text = "Buku Besar"
        Me.rb_purch2.UseVisualStyleBackColor = False
        '
        'rb_purch8
        '
        Me.rb_purch8.AutoSize = True
        Me.rb_purch8.BackColor = System.Drawing.Color.Transparent
        Me.rb_purch8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_purch8.ForeColor = System.Drawing.Color.Black
        Me.rb_purch8.Location = New System.Drawing.Point(0, 200)
        Me.rb_purch8.Margin = New System.Windows.Forms.Padding(4)
        Me.rb_purch8.Name = "rb_purch8"
        Me.rb_purch8.Size = New System.Drawing.Size(154, 24)
        Me.rb_purch8.TabIndex = 13
        Me.rb_purch8.Text = "Laporan Laba Rugi"
        Me.rb_purch8.UseVisualStyleBackColor = False
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
        Me.GroupControl3.Controls.Add(Me.gb_filterbl_purch)
        Me.GroupControl3.Controls.Add(Me.gb_filtersupp_purch)
        Me.GroupControl3.Controls.Add(Me.gb_filterth_purch)
        Me.GroupControl3.Controls.Add(Me.gb_filtertgl_purch)
        Me.GroupControl3.Location = New System.Drawing.Point(11, 10)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(711, 187)
        Me.GroupControl3.TabIndex = 282
        Me.GroupControl3.Text = "FILTER LAPORAN"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.ListReport)
        Me.GroupControl1.Controls.Add(Me.GroupBox1)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 203)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(711, 322)
        Me.GroupControl1.TabIndex = 283
        Me.GroupControl1.Text = "PILIH LAPORAN"
        '
        'ListReport
        '
        Me.ListReport.Appearance.BackColor = System.Drawing.Color.White
        Me.ListReport.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListReport.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ListReport.Appearance.Options.UseBackColor = True
        Me.ListReport.Appearance.Options.UseFont = True
        Me.ListReport.Appearance.Options.UseForeColor = True
        Me.ListReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListReport.Location = New System.Drawing.Point(2, 21)
        Me.ListReport.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.ListReport.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ListReport.Name = "ListReport"
        Me.ListReport.Size = New System.Drawing.Size(707, 299)
        Me.ListReport.TabIndex = 56
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Appearance.Options.UseBackColor = True
        Me.TabControl1.Appearance.Options.UseForeColor = True
        Me.TabControl1.Location = New System.Drawing.Point(6, 4)
        Me.TabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.TabPage1
        Me.TabControl1.Size = New System.Drawing.Size(736, 600)
        Me.TabControl1.TabIndex = 284
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabPage1})
        '
        'TabPage1
        '
        Me.TabPage1.Appearance.PageClient.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Appearance.PageClient.Options.UseForeColor = True
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(734, 575)
        Me.TabPage1.Text = "LAPORAN AKUNTANSI"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.SimpleButton4)
        Me.Panel1.Controls.Add(Me.btn_purch)
        Me.Panel1.Controls.Add(Me.GroupControl3)
        Me.Panel1.Controls.Add(Me.GroupControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 575)
        Me.Panel1.TabIndex = 0
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Appearance.Options.UseForeColor = True
        Me.SimpleButton4.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.SimpleButton4.Location = New System.Drawing.Point(541, 531)
        Me.SimpleButton4.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(91, 36)
        Me.SimpleButton4.TabIndex = 297
        Me.SimpleButton4.Text = "TUTUP"
        '
        'btn_purch
        '
        Me.btn_purch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_purch.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_purch.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_purch.Appearance.Options.UseFont = True
        Me.btn_purch.Appearance.Options.UseForeColor = True
        Me.btn_purch.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Print_16x16
        Me.btn_purch.Location = New System.Drawing.Point(638, 531)
        Me.btn_purch.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_purch.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_purch.Name = "btn_purch"
        Me.btn_purch.Size = New System.Drawing.Size(82, 36)
        Me.btn_purch.TabIndex = 284
        Me.btn_purch.Text = "LIHAT"
        '
        'FormReportAcc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(748, 609)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormReportAcc"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Akuntansi"
        Me.gb_filterbl_purch.ResumeLayout(False)
        Me.gb_filterbl_purch.PerformLayout()
        Me.gb_filtersupp_purch.ResumeLayout(False)
        Me.gb_filtersupp_purch.PerformLayout()
        CType(Me.cbo_supp_purch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_supp_purch2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_filtertgl_purch.ResumeLayout(False)
        Me.gb_filtertgl_purch.PerformLayout()
        Me.gb_filterth_purch.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.ListReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_filterbl_purch As System.Windows.Forms.GroupBox
    Friend WithEvents chk_filterbl_purch As System.Windows.Forms.CheckBox
    Friend WithEvents bl_purch2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bl_purch1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents From As System.Windows.Forms.Label
    Friend WithEvents gb_filtersupp_purch As System.Windows.Forms.GroupBox
    Friend WithEvents chk_filtersupp_purch As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gb_filtertgl_purch As System.Windows.Forms.GroupBox
    Friend WithEvents chk_filtertgl_purch As System.Windows.Forms.CheckBox
    Friend WithEvents tgl_purch2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tgl_purch1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gb_filterth_purch As System.Windows.Forms.GroupBox
    Friend WithEvents th_purch As System.Windows.Forms.DateTimePicker
    Friend WithEvents rb_purch1 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_purch9 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_purch2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_purch8 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_purch3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_purch7 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_purch6 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_purch10 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_purch11 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_purch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListReport As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents cbo_supp_purch1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbo_supp_purch2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
