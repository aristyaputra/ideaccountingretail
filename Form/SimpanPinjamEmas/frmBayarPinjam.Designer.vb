<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBayarPinjam
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBayarPinjam))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabInput = New System.Windows.Forms.TabPage()
        Me.NavBarControl9 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txt_pemb_before = New DevExpress.XtraEditors.LookUpEdit()
        Me.ListPinjamanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataPenjualan = New smartaccounting.DataPenjualan()
        Me.NavBarGroupControlContainer9 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txt_nota_pinjam = New System.Windows.Forms.TextBox()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txt_id_item = New System.Windows.Forms.TextBox()
        Me.NavBarGroupControlContainer3 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txt_item_name = New System.Windows.Forms.TextBox()
        Me.NavBarGroupControlContainer4 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txt_nominal = New System.Windows.Forms.TextBox()
        Me.NavBarGroupControlContainer5 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.NavBarGroupControlContainer6 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txt_berat = New System.Windows.Forms.TextBox()
        Me.NavBarGroupControlContainer7 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txt_bayar = New System.Windows.Forms.TextBox()
        Me.NavBarGroup9 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup6 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroup7 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.TabList = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colkode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnmbarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nominal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListJualPinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListJualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListJual = New smartaccounting.DataPenjualanTableAdapters.ListJual()
        Me.ListJualPinjam = New smartaccounting.DataPenjualanTableAdapters.ListJualPinjam()
        Me.ListPinjamanTableAdapter = New smartaccounting.DataPenjualanTableAdapters.ListPinjamanTableAdapter()
        Me.NavBarGroup8 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer8 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.txt_bunga = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabInput.SuspendLayout()
        CType(Me.NavBarControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl9.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.txt_pemb_before.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListPinjamanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer9.SuspendLayout()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        Me.NavBarGroupControlContainer3.SuspendLayout()
        Me.NavBarGroupControlContainer4.SuspendLayout()
        Me.NavBarGroupControlContainer5.SuspendLayout()
        Me.NavBarGroupControlContainer6.SuspendLayout()
        Me.NavBarGroupControlContainer7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabList.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListJualPinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListJualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarGroupControlContainer8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabInput)
        Me.TabControl1.Controls.Add(Me.TabList)
        Me.TabControl1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 63)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1000, 637)
        Me.TabControl1.TabIndex = 0
        '
        'TabInput
        '
        Me.TabInput.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabInput.Controls.Add(Me.NavBarControl9)
        Me.TabInput.Controls.Add(Me.Panel1)
        Me.TabInput.Location = New System.Drawing.Point(4, 29)
        Me.TabInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabInput.Name = "TabInput"
        Me.TabInput.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabInput.Size = New System.Drawing.Size(992, 604)
        Me.TabInput.TabIndex = 0
        Me.TabInput.Text = "Add / Edit Bayar Pinjaman"
        '
        'NavBarControl9
        '
        Me.NavBarControl9.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl9.Appearance.Background.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl9.Appearance.Background.Options.UseBackColor = True
        Me.NavBarControl9.Appearance.GroupBackground.BackColor = System.Drawing.Color.Ivory
        Me.NavBarControl9.Appearance.GroupBackground.BackColor2 = System.Drawing.Color.Lavender
        Me.NavBarControl9.Appearance.GroupBackground.BorderColor = System.Drawing.Color.Transparent
        Me.NavBarControl9.Appearance.GroupBackground.Options.UseBackColor = True
        Me.NavBarControl9.Appearance.GroupBackground.Options.UseBorderColor = True
        Me.NavBarControl9.Appearance.GroupHeader.BackColor = System.Drawing.Color.Ivory
        Me.NavBarControl9.Appearance.GroupHeader.BackColor2 = System.Drawing.Color.Orange
        Me.NavBarControl9.Appearance.GroupHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl9.Appearance.GroupHeader.Options.UseBackColor = True
        Me.NavBarControl9.Appearance.GroupHeader.Options.UseFont = True
        Me.NavBarControl9.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NavBarControl9.Controls.Add(Me.NavBarGroupControlContainer9)
        Me.NavBarControl9.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.NavBarControl9.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.NavBarControl9.Controls.Add(Me.NavBarGroupControlContainer3)
        Me.NavBarControl9.Controls.Add(Me.NavBarGroupControlContainer4)
        Me.NavBarControl9.Controls.Add(Me.NavBarGroupControlContainer5)
        Me.NavBarControl9.Controls.Add(Me.NavBarGroupControlContainer6)
        Me.NavBarControl9.Controls.Add(Me.NavBarGroupControlContainer7)
        Me.NavBarControl9.Controls.Add(Me.NavBarGroupControlContainer8)
        Me.NavBarControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavBarControl9.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup9, Me.NavBarGroup1, Me.NavBarGroup2, Me.NavBarGroup3, Me.NavBarGroup6, Me.NavBarGroup4, Me.NavBarGroup5, Me.NavBarGroup7, Me.NavBarGroup8})
        Me.NavBarControl9.Location = New System.Drawing.Point(3, 4)
        Me.NavBarControl9.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NavBarControl9.LookAndFeel.UseWindowsXPTheme = True
        Me.NavBarControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NavBarControl9.Name = "NavBarControl9"
        Me.NavBarControl9.OptionsNavPane.ExpandedWidth = 986
        Me.NavBarControl9.Size = New System.Drawing.Size(986, 541)
        Me.NavBarControl9.StoreDefaultPaintStyleName = True
        Me.NavBarControl9.TabIndex = 261
        Me.NavBarControl9.Text = "NavBarControl9"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup1.Appearance.Options.UseFont = True
        Me.NavBarGroup1.Caption = "No Nota Pinjam"
        Me.NavBarGroup1.ControlContainer = Me.NavBarGroupControlContainer1
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupClientHeight = 33
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.txt_pemb_before)
        Me.NavBarGroupControlContainer1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroupControlContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(962, 32)
        Me.NavBarGroupControlContainer1.TabIndex = 1
        '
        'txt_pemb_before
        '
        Me.txt_pemb_before.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_pemb_before.Location = New System.Drawing.Point(-1, 0)
        Me.txt_pemb_before.Name = "txt_pemb_before"
        Me.txt_pemb_before.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pemb_before.Properties.Appearance.Options.UseFont = True
        Me.txt_pemb_before.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pemb_before.Properties.AppearanceDropDown.Options.UseFont = True
        Me.txt_pemb_before.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pemb_before.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.txt_pemb_before.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.txt_pemb_before.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_pemb_before.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_pemb_before.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("No Pinjaman", "No Pinjaman", 112, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode Item", "Kode Item", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama Item", "Nama Item", 105, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nominal", "Nominal", 77, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tanggal", "Tanggal", 84, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Berat", "Berat", 56, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far)})
        Me.txt_pemb_before.Properties.DataSource = Me.ListPinjamanBindingSource
        Me.txt_pemb_before.Properties.DisplayMember = "No Pinjaman"
        Me.txt_pemb_before.Properties.LookAndFeel.SkinName = "Metropolis"
        Me.txt_pemb_before.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_pemb_before.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.txt_pemb_before.Properties.ValueMember = "Kode Item"
        Me.txt_pemb_before.Size = New System.Drawing.Size(963, 32)
        Me.txt_pemb_before.TabIndex = 0
        '
        'ListPinjamanBindingSource
        '
        Me.ListPinjamanBindingSource.DataMember = "ListPinjaman"
        Me.ListPinjamanBindingSource.DataSource = Me.DataPenjualan
        '
        'DataPenjualan
        '
        Me.DataPenjualan.DataSetName = "DataPenjualan"
        Me.DataPenjualan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NavBarGroupControlContainer9
        '
        Me.NavBarGroupControlContainer9.Controls.Add(Me.txt_nota_pinjam)
        Me.NavBarGroupControlContainer9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NavBarGroupControlContainer9.Name = "NavBarGroupControlContainer9"
        Me.NavBarGroupControlContainer9.Size = New System.Drawing.Size(962, 32)
        Me.NavBarGroupControlContainer9.TabIndex = 0
        '
        'txt_nota_pinjam
        '
        Me.txt_nota_pinjam.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nota_pinjam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nota_pinjam.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nota_pinjam.Location = New System.Drawing.Point(0, 0)
        Me.txt_nota_pinjam.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nota_pinjam.Name = "txt_nota_pinjam"
        Me.txt_nota_pinjam.ReadOnly = True
        Me.txt_nota_pinjam.Size = New System.Drawing.Size(962, 30)
        Me.txt_nota_pinjam.TabIndex = 2
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Controls.Add(Me.txt_id_item)
        Me.NavBarGroupControlContainer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(962, 30)
        Me.NavBarGroupControlContainer2.TabIndex = 2
        '
        'txt_id_item
        '
        Me.txt_id_item.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id_item.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_item.Location = New System.Drawing.Point(0, 0)
        Me.txt_id_item.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_id_item.Name = "txt_id_item"
        Me.txt_id_item.ReadOnly = True
        Me.txt_id_item.Size = New System.Drawing.Size(962, 30)
        Me.txt_id_item.TabIndex = 3
        '
        'NavBarGroupControlContainer3
        '
        Me.NavBarGroupControlContainer3.Controls.Add(Me.txt_item_name)
        Me.NavBarGroupControlContainer3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NavBarGroupControlContainer3.Name = "NavBarGroupControlContainer3"
        Me.NavBarGroupControlContainer3.Size = New System.Drawing.Size(962, 30)
        Me.NavBarGroupControlContainer3.TabIndex = 3
        '
        'txt_item_name
        '
        Me.txt_item_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_item_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_item_name.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_item_name.Location = New System.Drawing.Point(0, 0)
        Me.txt_item_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_item_name.Name = "txt_item_name"
        Me.txt_item_name.ReadOnly = True
        Me.txt_item_name.Size = New System.Drawing.Size(962, 30)
        Me.txt_item_name.TabIndex = 4
        '
        'NavBarGroupControlContainer4
        '
        Me.NavBarGroupControlContainer4.Controls.Add(Me.txt_nominal)
        Me.NavBarGroupControlContainer4.Name = "NavBarGroupControlContainer4"
        Me.NavBarGroupControlContainer4.Size = New System.Drawing.Size(962, 30)
        Me.NavBarGroupControlContainer4.TabIndex = 4
        '
        'txt_nominal
        '
        Me.txt_nominal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nominal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nominal.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nominal.Location = New System.Drawing.Point(0, 0)
        Me.txt_nominal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_nominal.Name = "txt_nominal"
        Me.txt_nominal.ReadOnly = True
        Me.txt_nominal.Size = New System.Drawing.Size(962, 30)
        Me.txt_nominal.TabIndex = 5
        '
        'NavBarGroupControlContainer5
        '
        Me.NavBarGroupControlContainer5.Controls.Add(Me.txt_date)
        Me.NavBarGroupControlContainer5.Name = "NavBarGroupControlContainer5"
        Me.NavBarGroupControlContainer5.Size = New System.Drawing.Size(962, 30)
        Me.NavBarGroupControlContainer5.TabIndex = 5
        '
        'txt_date
        '
        Me.txt_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_date.CustomFormat = "dd-MMM-yyyy"
        Me.txt_date.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date.Location = New System.Drawing.Point(0, 0)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(962, 30)
        Me.txt_date.TabIndex = 8
        '
        'NavBarGroupControlContainer6
        '
        Me.NavBarGroupControlContainer6.Controls.Add(Me.txt_berat)
        Me.NavBarGroupControlContainer6.Name = "NavBarGroupControlContainer6"
        Me.NavBarGroupControlContainer6.Size = New System.Drawing.Size(962, 30)
        Me.NavBarGroupControlContainer6.TabIndex = 6
        '
        'txt_berat
        '
        Me.txt_berat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_berat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_berat.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_berat.Location = New System.Drawing.Point(0, 0)
        Me.txt_berat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_berat.Name = "txt_berat"
        Me.txt_berat.ReadOnly = True
        Me.txt_berat.Size = New System.Drawing.Size(962, 30)
        Me.txt_berat.TabIndex = 5
        '
        'NavBarGroupControlContainer7
        '
        Me.NavBarGroupControlContainer7.Controls.Add(Me.txt_bayar)
        Me.NavBarGroupControlContainer7.Name = "NavBarGroupControlContainer7"
        Me.NavBarGroupControlContainer7.Size = New System.Drawing.Size(962, 30)
        Me.NavBarGroupControlContainer7.TabIndex = 7
        '
        'txt_bayar
        '
        Me.txt_bayar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_bayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bayar.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bayar.Location = New System.Drawing.Point(0, 0)
        Me.txt_bayar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_bayar.Name = "txt_bayar"
        Me.txt_bayar.Size = New System.Drawing.Size(962, 30)
        Me.txt_bayar.TabIndex = 6
        '
        'NavBarGroup9
        '
        Me.NavBarGroup9.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup9.Appearance.Options.UseFont = True
        Me.NavBarGroup9.Caption = "No Pembayaran"
        Me.NavBarGroup9.ControlContainer = Me.NavBarGroupControlContainer9
        Me.NavBarGroup9.Expanded = True
        Me.NavBarGroup9.GroupClientHeight = 33
        Me.NavBarGroup9.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup9.Name = "NavBarGroup9"
        Me.NavBarGroup9.Visible = False
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup2.Appearance.Options.UseFont = True
        Me.NavBarGroup2.Caption = "Kode Barang"
        Me.NavBarGroup2.ControlContainer = Me.NavBarGroupControlContainer2
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.GroupClientHeight = 31
        Me.NavBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup3.Appearance.Options.UseFont = True
        Me.NavBarGroup3.Caption = "Nama Barang"
        Me.NavBarGroup3.ControlContainer = Me.NavBarGroupControlContainer3
        Me.NavBarGroup3.Expanded = True
        Me.NavBarGroup3.GroupClientHeight = 31
        Me.NavBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'NavBarGroup6
        '
        Me.NavBarGroup6.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup6.Appearance.Options.UseFont = True
        Me.NavBarGroup6.Caption = "Berat"
        Me.NavBarGroup6.ControlContainer = Me.NavBarGroupControlContainer6
        Me.NavBarGroup6.Expanded = True
        Me.NavBarGroup6.GroupClientHeight = 31
        Me.NavBarGroup6.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup6.Name = "NavBarGroup6"
        '
        'NavBarGroup4
        '
        Me.NavBarGroup4.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup4.Appearance.Options.UseFont = True
        Me.NavBarGroup4.Caption = "Saldo Pinjaman"
        Me.NavBarGroup4.ControlContainer = Me.NavBarGroupControlContainer4
        Me.NavBarGroup4.Expanded = True
        Me.NavBarGroup4.GroupClientHeight = 31
        Me.NavBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup4.Name = "NavBarGroup4"
        '
        'NavBarGroup5
        '
        Me.NavBarGroup5.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup5.Appearance.Options.UseFont = True
        Me.NavBarGroup5.Caption = "Tanggal Bayar"
        Me.NavBarGroup5.ControlContainer = Me.NavBarGroupControlContainer5
        Me.NavBarGroup5.Expanded = True
        Me.NavBarGroup5.GroupClientHeight = 31
        Me.NavBarGroup5.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup5.Name = "NavBarGroup5"
        '
        'NavBarGroup7
        '
        Me.NavBarGroup7.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup7.Appearance.Options.UseFont = True
        Me.NavBarGroup7.Caption = "Nominal Bayar Pokok"
        Me.NavBarGroup7.ControlContainer = Me.NavBarGroupControlContainer7
        Me.NavBarGroup7.Expanded = True
        Me.NavBarGroup7.GroupClientHeight = 31
        Me.NavBarGroup7.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup7.Name = "NavBarGroup7"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_help)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_reset)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 545)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 55)
        Me.Panel1.TabIndex = 59
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Image = Global.smartaccounting.My.Resources.Resources.Save_16x16
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(905, 4)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(78, 46)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_help
        '
        Me.btn_help.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_help.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_help.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_help.Image = Global.smartaccounting.My.Resources.Resources.information_button
        Me.btn_help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_help.Location = New System.Drawing.Point(10, 4)
        Me.btn_help.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(74, 46)
        Me.btn_help.TabIndex = 8
        Me.btn_help.Text = "Info"
        Me.btn_help.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_help.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_delete.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Image = Global.smartaccounting.My.Resources.Resources.Delete_16x16
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(796, 4)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(103, 46)
        Me.btn_delete.TabIndex = 7
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_reset.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.Image = Global.smartaccounting.My.Resources.Resources.arrow_circle_double
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(704, 4)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(86, 46)
        Me.btn_reset.TabIndex = 6
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'TabList
        '
        Me.TabList.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabList.Controls.Add(Me.DataGridView1)
        Me.TabList.Location = New System.Drawing.Point(4, 29)
        Me.TabList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabList.Size = New System.Drawing.Size(992, 604)
        Me.TabList.TabIndex = 2
        Me.TabList.Text = "Daftar Bayar Pinjaman"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.colkode, Me.colnmbarang, Me.Nominal})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 4)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(986, 596)
        Me.DataGridView1.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No Nota Pinjam"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 180
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "No Pembelian"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tanggal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 105
        '
        'colkode
        '
        Me.colkode.HeaderText = "Kode Barang"
        Me.colkode.Name = "colkode"
        Me.colkode.ReadOnly = True
        Me.colkode.Width = 165
        '
        'colnmbarang
        '
        Me.colnmbarang.HeaderText = "Nama Barang"
        Me.colnmbarang.Name = "colnmbarang"
        Me.colnmbarang.ReadOnly = True
        Me.colnmbarang.Width = 230
        '
        'Nominal
        '
        Me.Nominal.HeaderText = "Nominal"
        Me.Nominal.Name = "Nominal"
        Me.Nominal.ReadOnly = True
        Me.Nominal.Width = 140
        '
        'ListJualPinjamBindingSource
        '
        Me.ListJualPinjamBindingSource.DataMember = "ListJualPinjam"
        Me.ListJualPinjamBindingSource.DataSource = Me.DataPenjualan
        '
        'ListJualBindingSource
        '
        Me.ListJualBindingSource.DataMember = "ListJual"
        Me.ListJualBindingSource.DataSource = Me.DataPenjualan
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Image = Global.smartaccounting.My.Resources.Resources.Cancel_24x24
        Me.Button4.Location = New System.Drawing.Point(968, 62)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 11, 4, 11)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(33, 27)
        Me.Button4.TabIndex = 274
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        'Me.PictureBox1.Image = Global.smartaccounting.My.Resources.Resources.New_Picture__16_1
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(999, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 288
        Me.PictureBox1.TabStop = False
        '
        'ListJual
        '
        Me.ListJual.ClearBeforeFill = True
        '
        'ListJualPinjam
        '
        Me.ListJualPinjam.ClearBeforeFill = True
        '
        'ListPinjamanTableAdapter
        '
        Me.ListPinjamanTableAdapter.ClearBeforeFill = True
        '
        'NavBarGroup8
        '
        Me.NavBarGroup8.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarGroup8.Appearance.Options.UseFont = True
        Me.NavBarGroup8.Caption = "Nominal Bayar Bunga"
        Me.NavBarGroup8.ControlContainer = Me.NavBarGroupControlContainer8
        Me.NavBarGroup8.Expanded = True
        Me.NavBarGroup8.GroupClientHeight = 35
        Me.NavBarGroup8.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup8.Name = "NavBarGroup8"
        '
        'NavBarGroupControlContainer8
        '
        Me.NavBarGroupControlContainer8.Controls.Add(Me.txt_bunga)
        Me.NavBarGroupControlContainer8.Name = "NavBarGroupControlContainer8"
        Me.NavBarGroupControlContainer8.Size = New System.Drawing.Size(962, 34)
        Me.NavBarGroupControlContainer8.TabIndex = 8
        '
        'txt_bunga
        '
        Me.txt_bunga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_bunga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_bunga.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bunga.Location = New System.Drawing.Point(0, 0)
        Me.txt_bunga.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_bunga.Name = "txt_bunga"
        Me.txt_bunga.Size = New System.Drawing.Size(962, 30)
        Me.txt_bunga.TabIndex = 7
        '
        'frmBayarPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBayarPinjam"
        Me.Text = "Currency Setup"
        Me.TabControl1.ResumeLayout(False)
        Me.TabInput.ResumeLayout(False)
        CType(Me.NavBarControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl9.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        CType(Me.txt_pemb_before.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListPinjamanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer9.ResumeLayout(False)
        Me.NavBarGroupControlContainer9.PerformLayout()
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        Me.NavBarGroupControlContainer2.PerformLayout()
        Me.NavBarGroupControlContainer3.ResumeLayout(False)
        Me.NavBarGroupControlContainer3.PerformLayout()
        Me.NavBarGroupControlContainer4.ResumeLayout(False)
        Me.NavBarGroupControlContainer4.PerformLayout()
        Me.NavBarGroupControlContainer5.ResumeLayout(False)
        Me.NavBarGroupControlContainer6.ResumeLayout(False)
        Me.NavBarGroupControlContainer6.PerformLayout()
        Me.NavBarGroupControlContainer7.ResumeLayout(False)
        Me.NavBarGroupControlContainer7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListJualPinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListJualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarGroupControlContainer8.ResumeLayout(False)
        Me.NavBarGroupControlContainer8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabInput As System.Windows.Forms.TabPage
    Friend WithEvents txt_nota_pinjam As System.Windows.Forms.TextBox
    Friend WithEvents btn_reset As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_help As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_item_name As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_id_item As System.Windows.Forms.TextBox
    Friend WithEvents TabList As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NavBarControl9 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup9 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer9 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroupControlContainer3 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NavBarGroupControlContainer4 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroupControlContainer5 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents txt_pemb_before As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nominal As System.Windows.Forms.TextBox
    Friend WithEvents DataPenjualan As SMARTACCOUNTING.DataPenjualan
    Friend WithEvents ListJualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListJual As SMARTACCOUNTING.DataPenjualanTableAdapters.ListJual
    Friend WithEvents NavBarGroupControlContainer6 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txt_berat As System.Windows.Forms.TextBox
    Friend WithEvents NavBarGroup6 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents ListJualPinjamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListJualPinjam As SMARTACCOUNTING.DataPenjualanTableAdapters.ListJualPinjam
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colkode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnmbarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nominal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NavBarGroupControlContainer7 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txt_bayar As System.Windows.Forms.TextBox
    Friend WithEvents NavBarGroup7 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents ListPinjamanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListPinjamanTableAdapter As SMARTACCOUNTING.DataPenjualanTableAdapters.ListPinjamanTableAdapter
    Friend WithEvents NavBarGroupControlContainer8 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents txt_bunga As System.Windows.Forms.TextBox
    Friend WithEvents NavBarGroup8 As DevExpress.XtraNavBar.NavBarGroup
End Class
