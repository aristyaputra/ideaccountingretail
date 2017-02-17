<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialUsage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialUsage))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_cetak = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reset2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_ket = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.txt_supp_nm = New System.Windows.Forms.TextBox()
        Me.txt_comment = New System.Windows.Forms.TextBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Lookup_Unit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitemnm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colunit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Finished = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cbo_pic = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_supplier = New System.Windows.Forms.ComboBox()
        Me.cbo_unit = New MTGCComboBox()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_po_no = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_dep_id = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_reset_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_cari_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tglakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tglawal = New System.Windows.Forms.DateTimePicker()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colnoinv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabInput = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbo_idbarang = New MTGCComboBox()
        Me.cbo_nmbarang = New MTGCComboBox()
        Me.txt_supp_address = New System.Windows.Forms.TextBox()
        Me.TabList = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridList_Customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_item_prod = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_item_prod = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox1 = New MTGCComboBox()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbo_gudang = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_browse = New DevExpress.XtraEditors.SimpleButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_save_path = New System.Windows.Forms.TextBox()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Lookup_Unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbo_pic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabInput.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.cbo_item_prod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_gudang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseForeColor = True
        Me.PanelControl2.Controls.Add(Me.Button4)
        Me.PanelControl2.Location = New System.Drawing.Point(9, 682)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(52, 77)
        Me.PanelControl2.TabIndex = 295
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x161
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(79, -11)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 71)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Simpan"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'btn_cetak
        '
        Me.btn_cetak.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cetak.Appearance.Options.UseFont = True
        Me.btn_cetak.Appearance.Options.UseForeColor = True
        Me.btn_cetak.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Print_16x16
        Me.btn_cetak.Location = New System.Drawing.Point(108, 556)
        Me.btn_cetak.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cetak.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cetak.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(119, 42)
        Me.btn_cetak.TabIndex = 20
        Me.btn_cetak.Text = "LIHAT - CETAK"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(5, 556)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(97, 42)
        Me.btn_keluar.TabIndex = 19
        Me.btn_keluar.Text = "KELUAR"
        '
        'btn_reset2
        '
        Me.btn_reset2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_reset2.Appearance.Options.UseFont = True
        Me.btn_reset2.Appearance.Options.UseForeColor = True
        Me.btn_reset2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset2.Location = New System.Drawing.Point(737, 556)
        Me.btn_reset2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_reset2.Name = "btn_reset2"
        Me.btn_reset2.Size = New System.Drawing.Size(82, 42)
        Me.btn_reset2.TabIndex = 18
        Me.btn_reset2.Text = "RESET"
        '
        'btn_del2
        '
        Me.btn_del2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_del2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_del2.Appearance.Options.UseFont = True
        Me.btn_del2.Appearance.Options.UseForeColor = True
        Me.btn_del2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Delete_16x16
        Me.btn_del2.Location = New System.Drawing.Point(825, 556)
        Me.btn_del2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_del2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_del2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_del2.Name = "btn_del2"
        Me.btn_del2.Size = New System.Drawing.Size(82, 42)
        Me.btn_del2.TabIndex = 17
        Me.btn_del2.Text = "HAPUS"
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(913, 556)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 42)
        Me.btn_save2.TabIndex = 16
        Me.btn_save2.Text = "SIMPAN"
        '
        'GroupControl4
        '
        Me.GroupControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl4.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl4.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl4.Appearance.Options.UseBackColor = True
        Me.GroupControl4.Appearance.Options.UseFont = True
        Me.GroupControl4.Appearance.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.txt_ket)
        Me.GroupControl4.Controls.Add(Me.txt_qty)
        Me.GroupControl4.Controls.Add(Me.txt_supp_nm)
        Me.GroupControl4.Controls.Add(Me.txt_comment)
        Me.GroupControl4.Location = New System.Drawing.Point(5, 459)
        Me.GroupControl4.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(990, 83)
        Me.GroupControl4.TabIndex = 293
        Me.GroupControl4.Text = "NOTES"
        '
        'txt_ket
        '
        Me.txt_ket.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_ket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ket.ForeColor = System.Drawing.Color.Black
        Me.txt_ket.Location = New System.Drawing.Point(11, -1350)
        Me.txt_ket.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_ket.Multiline = True
        Me.txt_ket.Name = "txt_ket"
        Me.txt_ket.Size = New System.Drawing.Size(971, 85)
        Me.txt_ket.TabIndex = 282
        Me.txt_ket.Visible = False
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.ForeColor = System.Drawing.Color.Black
        Me.txt_qty.Location = New System.Drawing.Point(11, -1350)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_qty.Multiline = True
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(971, 85)
        Me.txt_qty.TabIndex = 281
        Me.txt_qty.Visible = False
        '
        'txt_supp_nm
        '
        Me.txt_supp_nm.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_supp_nm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_supp_nm.ForeColor = System.Drawing.Color.Black
        Me.txt_supp_nm.Location = New System.Drawing.Point(-1042, 23)
        Me.txt_supp_nm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_supp_nm.Multiline = True
        Me.txt_supp_nm.Name = "txt_supp_nm"
        Me.txt_supp_nm.Size = New System.Drawing.Size(971, 85)
        Me.txt_supp_nm.TabIndex = 280
        Me.txt_supp_nm.Visible = False
        '
        'txt_comment
        '
        Me.txt_comment.BackColor = System.Drawing.Color.White
        Me.txt_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comment.ForeColor = System.Drawing.Color.Black
        Me.txt_comment.Location = New System.Drawing.Point(8, 24)
        Me.txt_comment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_comment.Multiline = True
        Me.txt_comment.Name = "txt_comment"
        Me.txt_comment.Size = New System.Drawing.Size(977, 54)
        Me.txt_comment.TabIndex = 30
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.Lookup_Unit)
        Me.GroupControl2.Controls.Add(Me.DataGridView1)
        Me.GroupControl2.Location = New System.Drawing.Point(5, 176)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(992, 257)
        Me.GroupControl2.TabIndex = 292
        Me.GroupControl2.Text = "DETAIL BAHAN"
        '
        'Lookup_Unit
        '
        Me.Lookup_Unit.Location = New System.Drawing.Point(44, 47)
        Me.Lookup_Unit.Name = "Lookup_Unit"
        Me.Lookup_Unit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Lookup_Unit.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lookup_Unit.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Lookup_Unit.Properties.Appearance.Options.UseBackColor = True
        Me.Lookup_Unit.Properties.Appearance.Options.UseFont = True
        Me.Lookup_Unit.Properties.Appearance.Options.UseForeColor = True
        Me.Lookup_Unit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup_Unit.Properties.View = Me.GridLookUpEdit1View
        Me.Lookup_Unit.Size = New System.Drawing.Size(153, 24)
        Me.Lookup_Unit.TabIndex = 70
        Me.Lookup_Unit.Visible = False
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridLookUpEdit1View.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridLookUpEdit1View.Appearance.Empty.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridLookUpEdit1View.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridLookUpEdit1View.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridLookUpEdit1View.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridLookUpEdit1View.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridLookUpEdit1View.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridLookUpEdit1View.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridLookUpEdit1View.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridLookUpEdit1View.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridLookUpEdit1View.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridLookUpEdit1View.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = True
        Me.GridLookUpEdit1View.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridLookUpEdit1View.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridLookUpEdit1View.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridLookUpEdit1View.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.OddRow.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.OddRow.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.Preview.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.Preview.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridLookUpEdit1View.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridLookUpEdit1View.Appearance.Row.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.Row.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridLookUpEdit1View.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridLookUpEdit1View.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridLookUpEdit1View.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridLookUpEdit1View.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridLookUpEdit1View.Appearance.VertLine.Options.UseBackColor = True
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsCustomization.AllowColumnMoving = False
        Me.GridLookUpEdit1View.OptionsCustomization.AllowGroup = False
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = True
        Me.GridLookUpEdit1View.OptionsView.EnableAppearanceOddRow = True
        Me.GridLookUpEdit1View.OptionsView.RowAutoHeight = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.PaintStyleName = "Skin"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colno, Me.colitem, Me.colitemnm, Me.colqty, Me.colunit, Me.TotalCost, Me.Finished, Me.jenis})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 28
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(988, 234)
        Me.DataGridView1.TabIndex = 10
        '
        'colno
        '
        Me.colno.HeaderText = "No"
        Me.colno.Name = "colno"
        Me.colno.Width = 40
        '
        'colitem
        '
        Me.colitem.HeaderText = "Kode Bahan"
        Me.colitem.Name = "colitem"
        Me.colitem.Width = 154
        '
        'colitemnm
        '
        Me.colitemnm.HeaderText = "Keterangan"
        Me.colitemnm.Name = "colitemnm"
        Me.colitemnm.Width = 265
        '
        'colqty
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.colqty.DefaultCellStyle = DataGridViewCellStyle2
        Me.colqty.HeaderText = "Qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Width = 85
        '
        'colunit
        '
        Me.colunit.HeaderText = "Unit"
        Me.colunit.Name = "colunit"
        Me.colunit.Width = 90
        '
        'TotalCost
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TotalCost.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalCost.HeaderText = "HPP"
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.Width = 110
        '
        'Finished
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Finished.DefaultCellStyle = DataGridViewCellStyle4
        Me.Finished.HeaderText = "Total"
        Me.Finished.Name = "Finished"
        Me.Finished.Width = 140
        '
        'jenis
        '
        Me.jenis.HeaderText = "Jenis"
        Me.jenis.Name = "jenis"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.TextBox1)
        Me.GroupControl1.Controls.Add(Me.cbo_pic)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.cbo_supplier)
        Me.GroupControl1.Controls.Add(Me.cbo_unit)
        Me.GroupControl1.Controls.Add(Me.txt_date)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.txt_po_no)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 6)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(992, 77)
        Me.GroupControl1.TabIndex = 291
        Me.GroupControl1.Text = "INFORMASI PENGGUNAAN BAHAN"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(782, 49)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(202, 23)
        Me.TextBox1.TabIndex = 142
        '
        'cbo_pic
        '
        Me.cbo_pic.Location = New System.Drawing.Point(782, 22)
        Me.cbo_pic.Name = "cbo_pic"
        Me.cbo_pic.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_pic.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_pic.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cbo_pic.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_pic.Properties.Appearance.Options.UseFont = True
        Me.cbo_pic.Properties.Appearance.Options.UseForeColor = True
        Me.cbo_pic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_pic.Properties.View = Me.GridView1
        Me.cbo_pic.Size = New System.Drawing.Size(202, 24)
        Me.cbo_pic.TabIndex = 141
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "Skin"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(645, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 18)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "Departemen Produksi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(645, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 18)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Perintah Kerja"
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
        Me.cbo_supplier.Location = New System.Drawing.Point(-1421, 40)
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
        'txt_date
        '
        Me.txt_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_date.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_date.CustomFormat = "dd-MMM-yyyy"
        Me.txt_date.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.ForeColor = System.Drawing.Color.Black
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date.Location = New System.Drawing.Point(112, 49)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(202, 23)
        Me.txt_date.TabIndex = 90
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 18)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "Tanggal"
        '
        'txt_po_no
        '
        Me.txt_po_no.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_po_no.BackColor = System.Drawing.Color.White
        Me.txt_po_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_po_no.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_po_no.ForeColor = System.Drawing.Color.Black
        Me.txt_po_no.Location = New System.Drawing.Point(112, 23)
        Me.txt_po_no.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_po_no.Name = "txt_po_no"
        Me.txt_po_no.ReadOnly = True
        Me.txt_po_no.Size = New System.Drawing.Size(202, 23)
        Me.txt_po_no.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 18)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "No Penggunaan"
        '
        'lbl_dep_id
        '
        Me.lbl_dep_id.AutoSize = True
        Me.lbl_dep_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dep_id.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dep_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_dep_id.Location = New System.Drawing.Point(685, 436)
        Me.lbl_dep_id.Name = "lbl_dep_id"
        Me.lbl_dep_id.Size = New System.Drawing.Size(68, 18)
        Me.lbl_dep_id.TabIndex = 143
        Me.lbl_dep_id.Text = "Total Cost"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 997)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 18)
        Me.Label4.TabIndex = 290
        Me.Label4.Text = "* Tekan F5 untuk menambah item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 436)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 18)
        Me.Label5.TabIndex = 272
        Me.Label5.Text = "* Tekan Delete untuk menghapus item"
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Appearance.Options.UseFont = True
        Me.GroupControl3.Appearance.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.btn_reset_cust)
        Me.GroupControl3.Controls.Add(Me.Label20)
        Me.GroupControl3.Controls.Add(Me.txt_search)
        Me.GroupControl3.Controls.Add(Me.btn_cari_cust)
        Me.GroupControl3.Controls.Add(Me.Label12)
        Me.GroupControl3.Controls.Add(Me.GroupBox3)
        Me.GroupControl3.Controls.Add(Me.cbo_search)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 11)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(185, 743)
        Me.GroupControl3.TabIndex = 280
        Me.GroupControl3.Text = "PANEL PENCARIAN"
        '
        'btn_reset_cust
        '
        Me.btn_reset_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_cust.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_reset_cust.Appearance.Options.UseFont = True
        Me.btn_reset_cust.Appearance.Options.UseForeColor = True
        Me.btn_reset_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset_cust.Location = New System.Drawing.Point(11, 416)
        Me.btn_reset_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_reset_cust.Name = "btn_reset_cust"
        Me.btn_reset_cust.Size = New System.Drawing.Size(82, 43)
        Me.btn_reset_cust.TabIndex = 276
        Me.btn_reset_cust.Text = "RESET"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(14, 36)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 18)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Cari Berdasarkan"
        '
        'txt_search
        '
        Me.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_search.BackColor = System.Drawing.Color.White
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.Color.Black
        Me.txt_search.Location = New System.Drawing.Point(17, 124)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(155, 62)
        Me.txt_search.TabIndex = 23
        '
        'btn_cari_cust
        '
        Me.btn_cari_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_cust.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cari_cust.Appearance.Options.UseFont = True
        Me.btn_cari_cust.Appearance.Options.UseForeColor = True
        Me.btn_cari_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Search_16x16
        Me.btn_cari_cust.Location = New System.Drawing.Point(99, 416)
        Me.btn_cari_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cari_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cari_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cari_cust.Name = "btn_cari_cust"
        Me.btn_cari_cust.Size = New System.Drawing.Size(72, 43)
        Me.btn_cari_cust.TabIndex = 275
        Me.btn_cari_cust.Text = "CARI"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(14, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 18)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Teks Pencarian"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chk_date)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.tglakhir)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.tglawal)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(160, 184)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter Tanggal"
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.ForeColor = System.Drawing.Color.Black
        Me.chk_date.Location = New System.Drawing.Point(14, 26)
        Me.chk_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(123, 22)
        Me.chk_date.TabIndex = 38
        Me.chk_date.Text = "Batasan Tanggal"
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(19, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 18)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Sampai"
        '
        'tglakhir
        '
        Me.tglakhir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tglakhir.CustomFormat = "dd-MM-yyyy"
        Me.tglakhir.ForeColor = System.Drawing.Color.Black
        Me.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglakhir.Location = New System.Drawing.Point(22, 139)
        Me.tglakhir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(111, 23)
        Me.tglakhir.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(19, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 18)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Dari"
        '
        'tglawal
        '
        Me.tglawal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tglawal.CustomFormat = "dd-MM-yyyy"
        Me.tglawal.ForeColor = System.Drawing.Color.Black
        Me.tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglawal.Location = New System.Drawing.Point(22, 82)
        Me.tglawal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglawal.Name = "tglawal"
        Me.tglawal.Size = New System.Drawing.Size(111, 23)
        Me.tglawal.TabIndex = 34
        '
        'cbo_search
        '
        Me.cbo_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_search.BackColor = System.Drawing.Color.White
        Me.cbo_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_search.ForeColor = System.Drawing.Color.Black
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"Requisition No", "Notes"})
        Me.cbo_search.Location = New System.Drawing.Point(17, 62)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(155, 26)
        Me.cbo_search.TabIndex = 19
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnoinv, Me.coldate, Me.colamount, Me.coldescript, Me.colstatus, Me.colprint})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(778, 717)
        Me.DataGridView2.TabIndex = 17
        '
        'colnoinv
        '
        Me.colnoinv.HeaderText = "No Permintaan"
        Me.colnoinv.Name = "colnoinv"
        Me.colnoinv.ReadOnly = True
        Me.colnoinv.Width = 175
        '
        'coldate
        '
        Me.coldate.HeaderText = "Tanggal"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        '
        'colamount
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colamount.DefaultCellStyle = DataGridViewCellStyle6
        Me.colamount.HeaderText = "Keterangan"
        Me.colamount.Name = "colamount"
        Me.colamount.ReadOnly = True
        Me.colamount.Width = 270
        '
        'coldescript
        '
        Me.coldescript.HeaderText = "Keterangan"
        Me.coldescript.Name = "coldescript"
        Me.coldescript.ReadOnly = True
        Me.coldescript.Visible = False
        Me.coldescript.Width = 190
        '
        'colstatus
        '
        Me.colstatus.HeaderText = "Approval Status"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.ReadOnly = True
        Me.colstatus.Width = 125
        '
        'colprint
        '
        Me.colprint.HeaderText = "Lihat Nota"
        Me.colprint.Name = "colprint"
        Me.colprint.ReadOnly = True
        Me.colprint.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colprint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colprint.Text = "Cetak Nota"
        Me.colprint.UseColumnTextForButtonValue = True
        Me.colprint.Width = 110
        '
        'GroupControl5
        '
        Me.GroupControl5.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl5.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl5.Appearance.Options.UseBackColor = True
        Me.GroupControl5.Appearance.Options.UseFont = True
        Me.GroupControl5.Appearance.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.DataGridView2)
        Me.GroupControl5.Location = New System.Drawing.Point(208, 11)
        Me.GroupControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(782, 740)
        Me.GroupControl5.TabIndex = 293
        Me.GroupControl5.Text = "DAFTAR PERMINTAAN"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.TabControl1.Appearance.Options.UseBackColor = True
        Me.TabControl1.Appearance.Options.UseForeColor = True
        Me.TabControl1.Location = New System.Drawing.Point(-940, 0)
        Me.TabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.TabInput
        Me.TabControl1.Size = New System.Drawing.Size(74, 794)
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabInput, Me.TabList})
        Me.TabControl1.Visible = False
        '
        'TabInput
        '
        Me.TabInput.Appearance.PageClient.ForeColor = System.Drawing.Color.Black
        Me.TabInput.Appearance.PageClient.Options.UseForeColor = True
        Me.TabInput.Controls.Add(Me.Panel2)
        Me.TabInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabInput.Name = "TabInput"
        Me.TabInput.Size = New System.Drawing.Size(72, 769)
        Me.TabInput.Text = "TAMBAH / UBAH PR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.cbo_idbarang)
        Me.Panel2.Controls.Add(Me.cbo_nmbarang)
        Me.Panel2.Controls.Add(Me.txt_supp_address)
        Me.Panel2.Controls.Add(Me.PanelControl2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(72, 769)
        Me.Panel2.TabIndex = 0
        '
        'cbo_idbarang
        '
        Me.cbo_idbarang.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_idbarang.ArrowColor = System.Drawing.Color.Black
        Me.cbo_idbarang.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbo_idbarang.BindedControl = CType(resources.GetObject("cbo_idbarang.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_idbarang.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_idbarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_idbarang.ColumnNum = 4
        Me.cbo_idbarang.ColumnWidth = "150; 110; 170 ;180"
        Me.cbo_idbarang.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_idbarang.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cbo_idbarang.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cbo_idbarang.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbo_idbarang.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo_idbarang.DisplayMember = "Text"
        Me.cbo_idbarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_idbarang.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cbo_idbarang.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbo_idbarang.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_idbarang.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_idbarang.DropDownWidth = 630
        Me.cbo_idbarang.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_idbarang.ForeColor = System.Drawing.Color.Black
        Me.cbo_idbarang.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_idbarang.GridLineHorizontal = True
        Me.cbo_idbarang.GridLineVertical = True
        Me.cbo_idbarang.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_idbarang.HighlightBorderOnMouseEvents = True
        Me.cbo_idbarang.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_idbarang.Location = New System.Drawing.Point(-1329, 367)
        Me.cbo_idbarang.ManagingFastMouseMoving = True
        Me.cbo_idbarang.ManagingFastMouseMovingInterval = 30
        Me.cbo_idbarang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_idbarang.Name = "cbo_idbarang"
        Me.cbo_idbarang.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_idbarang.SelectedItem = Nothing
        Me.cbo_idbarang.SelectedValue = Nothing
        Me.cbo_idbarang.Size = New System.Drawing.Size(355, 24)
        Me.cbo_idbarang.TabIndex = 299
        Me.cbo_idbarang.Visible = False
        '
        'cbo_nmbarang
        '
        Me.cbo_nmbarang.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_nmbarang.ArrowColor = System.Drawing.Color.Black
        Me.cbo_nmbarang.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbo_nmbarang.BindedControl = CType(resources.GetObject("cbo_nmbarang.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_nmbarang.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_nmbarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_nmbarang.ColumnNum = 4
        Me.cbo_nmbarang.ColumnWidth = "150; 110; 170 ;180"
        Me.cbo_nmbarang.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_nmbarang.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cbo_nmbarang.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cbo_nmbarang.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbo_nmbarang.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo_nmbarang.DisplayMember = "Text"
        Me.cbo_nmbarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_nmbarang.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cbo_nmbarang.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbo_nmbarang.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_nmbarang.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_nmbarang.DropDownWidth = 630
        Me.cbo_nmbarang.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_nmbarang.ForeColor = System.Drawing.Color.Black
        Me.cbo_nmbarang.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_nmbarang.GridLineHorizontal = True
        Me.cbo_nmbarang.GridLineVertical = True
        Me.cbo_nmbarang.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_nmbarang.HighlightBorderOnMouseEvents = True
        Me.cbo_nmbarang.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_nmbarang.Location = New System.Drawing.Point(-1329, 367)
        Me.cbo_nmbarang.ManagingFastMouseMoving = True
        Me.cbo_nmbarang.ManagingFastMouseMovingInterval = 30
        Me.cbo_nmbarang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_nmbarang.Name = "cbo_nmbarang"
        Me.cbo_nmbarang.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_nmbarang.SelectedItem = Nothing
        Me.cbo_nmbarang.SelectedValue = Nothing
        Me.cbo_nmbarang.Size = New System.Drawing.Size(355, 24)
        Me.cbo_nmbarang.TabIndex = 298
        Me.cbo_nmbarang.Visible = False
        '
        'txt_supp_address
        '
        Me.txt_supp_address.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_supp_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_supp_address.ForeColor = System.Drawing.Color.Black
        Me.txt_supp_address.Location = New System.Drawing.Point(21, -340)
        Me.txt_supp_address.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_supp_address.Multiline = True
        Me.txt_supp_address.Name = "txt_supp_address"
        Me.txt_supp_address.Size = New System.Drawing.Size(971, 85)
        Me.txt_supp_address.TabIndex = 297
        Me.txt_supp_address.Visible = False
        '
        'TabList
        '
        Me.TabList.Appearance.PageClient.ForeColor = System.Drawing.Color.Black
        Me.TabList.Appearance.PageClient.Options.UseForeColor = True
        Me.TabList.Controls.Add(Me.Panel3)
        Me.TabList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabList.Name = "TabList"
        Me.TabList.Size = New System.Drawing.Size(72, 769)
        Me.TabList.Text = "DAFTAR PURCHASE REQUISITION"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.GroupControl5)
        Me.Panel3.Controls.Add(Me.GroupControl3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(72, 769)
        Me.Panel3.TabIndex = 0
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
        Me.PanelControl5.Location = New System.Drawing.Point(12, 599)
        Me.PanelControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(993, 59)
        Me.PanelControl5.TabIndex = 299
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Appearance.Options.UseForeColor = True
        Me.SimpleButton4.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.SimpleButton4.Location = New System.Drawing.Point(895, 7)
        Me.SimpleButton4.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 44)
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
        Me.SimpleButton8.Location = New System.Drawing.Point(796, 7)
        Me.SimpleButton8.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton8.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton8.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(92, 44)
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
        Me.SimpleButton3.Location = New System.Drawing.Point(7, 7)
        Me.SimpleButton3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(187, 44)
        Me.SimpleButton3.TabIndex = 293
        Me.SimpleButton3.Text = "TAMBAH PENGGUNAAN"
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GridControl.Location = New System.Drawing.Point(12, 40)
        Me.GridControl.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl.MainView = Me.GridList_Customer
        Me.GridControl.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(993, 557)
        Me.GridControl.TabIndex = 297
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
        Me.Label2.Location = New System.Drawing.Point(8, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 24)
        Me.Label2.TabIndex = 298
        Me.Label2.Text = "Daftar Penggunaan Bahan"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.Controls.Add(Me.GroupControl7)
        Me.PanelControl3.Controls.Add(Me.txt_total)
        Me.PanelControl3.Controls.Add(Me.lbl_dep_id)
        Me.PanelControl3.Controls.Add(Me.Label5)
        Me.PanelControl3.Controls.Add(Me.btn_cetak)
        Me.PanelControl3.Controls.Add(Me.GroupControl6)
        Me.PanelControl3.Controls.Add(Me.btn_keluar)
        Me.PanelControl3.Controls.Add(Me.btn_reset2)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.btn_del2)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.btn_save2)
        Me.PanelControl3.Controls.Add(Me.GroupControl4)
        Me.PanelControl3.Location = New System.Drawing.Point(10, 14)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1002, 608)
        Me.PanelControl3.TabIndex = 300
        Me.PanelControl3.Visible = False
        '
        'GroupControl7
        '
        Me.GroupControl7.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl7.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl7.Appearance.Options.UseBackColor = True
        Me.GroupControl7.Appearance.Options.UseFont = True
        Me.GroupControl7.Appearance.Options.UseForeColor = True
        Me.GroupControl7.Controls.Add(Me.Label6)
        Me.GroupControl7.Controls.Add(Me.lbl_item_prod)
        Me.GroupControl7.Controls.Add(Me.Label1)
        Me.GroupControl7.Controls.Add(Me.cbo_item_prod)
        Me.GroupControl7.Controls.Add(Me.Label3)
        Me.GroupControl7.Controls.Add(Me.ComboBox1)
        Me.GroupControl7.Controls.Add(Me.MtgcComboBox1)
        Me.GroupControl7.Controls.Add(Me.LookUpEdit1)
        Me.GroupControl7.Controls.Add(Me.cbo_gudang)
        Me.GroupControl7.Location = New System.Drawing.Point(5, 91)
        Me.GroupControl7.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(992, 77)
        Me.GroupControl7.TabIndex = 294
        Me.GroupControl7.Text = "PILIH PERUNTUKAN BARANG PRODUKSI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(645, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Gudang"
        '
        'lbl_item_prod
        '
        Me.lbl_item_prod.AutoSize = True
        Me.lbl_item_prod.BackColor = System.Drawing.Color.Transparent
        Me.lbl_item_prod.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item_prod.ForeColor = System.Drawing.Color.Black
        Me.lbl_item_prod.Location = New System.Drawing.Point(250, 53)
        Me.lbl_item_prod.Name = "lbl_item_prod"
        Me.lbl_item_prod.Size = New System.Drawing.Size(114, 18)
        Me.lbl_item_prod.TabIndex = 143
        Me.lbl_item_prod.Text = "Detail Barang Jadi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(144, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 18)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Ket. Barang Jadi:"
        '
        'cbo_item_prod
        '
        Me.cbo_item_prod.Location = New System.Drawing.Point(147, 24)
        Me.cbo_item_prod.Name = "cbo_item_prod"
        Me.cbo_item_prod.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_item_prod.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_item_prod.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cbo_item_prod.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_item_prod.Properties.Appearance.Options.UseFont = True
        Me.cbo_item_prod.Properties.Appearance.Options.UseForeColor = True
        Me.cbo_item_prod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_item_prod.Properties.View = Me.GridView2
        Me.cbo_item_prod.Size = New System.Drawing.Size(202, 24)
        Me.cbo_item_prod.TabIndex = 141
        '
        'GridView2
        '
        Me.GridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView2.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GridView2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseFont = True
        Me.GridView2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView2.Appearance.Preview.Options.UseBackColor = True
        Me.GridView2.Appearance.Preview.Options.UseForeColor = True
        Me.GridView2.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.Row.Options.UseBackColor = True
        Me.GridView2.Appearance.Row.Options.UseForeColor = True
        Me.GridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView2.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowColumnMoving = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.EnableAppearanceOddRow = True
        Me.GridView2.OptionsView.RowAutoHeight = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.PaintStyleName = "Skin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Pilih Barang Produksi"
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
        Me.ComboBox1.Location = New System.Drawing.Point(-1421, 40)
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
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(-32768, -32768)
        Me.LookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.LookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LookUpEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.LookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", "", Nothing, True)})
        Me.LookUpEdit1.Properties.Tag = ""
        Me.LookUpEdit1.Size = New System.Drawing.Size(154, 24)
        Me.LookUpEdit1.TabIndex = 126
        Me.LookUpEdit1.Visible = False
        '
        'cbo_gudang
        '
        Me.cbo_gudang.Location = New System.Drawing.Point(782, 24)
        Me.cbo_gudang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_gudang.Name = "cbo_gudang"
        Me.cbo_gudang.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_gudang.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_gudang.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cbo_gudang.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_gudang.Properties.Appearance.Options.UseFont = True
        Me.cbo_gudang.Properties.Appearance.Options.UseForeColor = True
        Me.cbo_gudang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", "", Nothing, True)})
        Me.cbo_gudang.Properties.Tag = ""
        Me.cbo_gudang.Properties.View = Me.GridView3
        Me.cbo_gudang.Size = New System.Drawing.Size(202, 24)
        Me.cbo_gudang.TabIndex = 146
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'txt_total
        '
        Me.txt_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.Black
        Me.txt_total.Location = New System.Drawing.Point(757, 434)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(151, 23)
        Me.txt_total.TabIndex = 143
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupControl6
        '
        Me.GroupControl6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl6.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl6.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl6.Appearance.Options.UseBackColor = True
        Me.GroupControl6.Appearance.Options.UseFont = True
        Me.GroupControl6.Appearance.Options.UseForeColor = True
        Me.GroupControl6.Controls.Add(Me.btn_browse)
        Me.GroupControl6.Controls.Add(Me.Label25)
        Me.GroupControl6.Controls.Add(Me.txt_save_path)
        Me.GroupControl6.Location = New System.Drawing.Point(91, -260)
        Me.GroupControl6.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(1165, 236)
        Me.GroupControl6.TabIndex = 268
        Me.GroupControl6.Text = "SETTING DIREKTORI FOTO"
        Me.GroupControl6.Visible = False
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
        Me.btn_browse.Location = New System.Drawing.Point(8, 1487)
        Me.btn_browse.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_browse.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_browse.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(346, 184)
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
        Me.Label25.Location = New System.Drawing.Point(6, 35)
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
        Me.txt_save_path.Location = New System.Drawing.Point(7, 72)
        Me.txt_save_path.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.txt_save_path.Name = "txt_save_path"
        Me.txt_save_path.ReadOnly = True
        Me.txt_save_path.Size = New System.Drawing.Size(1151, 25)
        Me.txt_save_path.TabIndex = 277
        Me.txt_save_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmMaterialUsage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1018, 672)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaterialUsage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penggunaan Bahan"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Lookup_Unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbo_pic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabInput.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabList.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.cbo_item_prod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_gudang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tglakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tglawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chk_date As System.Windows.Forms.CheckBox
    Friend WithEvents txt_comment As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_po_no As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents colnoinv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colprint As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_cetak As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reset2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_reset_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_supp_nm As System.Windows.Forms.TextBox
    Friend WithEvents txt_supp_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents txt_ket As System.Windows.Forms.TextBox
    Friend WithEvents cbo_unit As MTGCComboBox
    Friend WithEvents cbo_supplier As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_nmbarang As MTGCComboBox
    Friend WithEvents cbo_idbarang As MTGCComboBox
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridList_Customer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_save_path As System.Windows.Forms.TextBox
    Friend WithEvents Lookup_Unit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbo_pic As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_dep_id As System.Windows.Forms.Label
    Friend WithEvents colno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitemnm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colunit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Finished As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_item_prod As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_item_prod As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox1 As MTGCComboBox
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbo_gudang As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
