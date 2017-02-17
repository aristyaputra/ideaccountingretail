<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreconcile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmreconcile))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_balance = New System.Windows.Forms.TextBox()
        Me.btn_cetak2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reset2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_comment = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_tax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txt_reconcile = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txt_adjustment = New System.Windows.Forms.TextBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lookup_acc = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.MtgcComboBox2 = New MTGCComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colaccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colaccnm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colamountout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lb_cashbank_name = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_curr = New System.Windows.Forms.ComboBox()
        Me.txt_kurs = New System.Windows.Forms.TextBox()
        Me.cbo_acc = New MTGCComboBox()
        Me.txt_no_reconcile = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.cbo_unit = New MTGCComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_reset_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_cari_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tglakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tglawal = New System.Windows.Forms.DateTimePicker()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colnospend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbalancehist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabInput = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabList = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridList_Customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_browse = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_save_path = New System.Windows.Forms.TextBox()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.lookup_acc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabInput.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_balance
        '
        Me.txt_balance.BackColor = System.Drawing.Color.Lavender
        Me.txt_balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_balance.Enabled = False
        Me.txt_balance.Location = New System.Drawing.Point(111, 29)
        Me.txt_balance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.ReadOnly = True
        Me.txt_balance.Size = New System.Drawing.Size(152, 23)
        Me.txt_balance.TabIndex = 31
        Me.txt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_cetak2
        '
        Me.btn_cetak2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cetak2.Appearance.Options.UseFont = True
        Me.btn_cetak2.Appearance.Options.UseForeColor = True
        Me.btn_cetak2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Print_16x16
        Me.btn_cetak2.Location = New System.Drawing.Point(108, 578)
        Me.btn_cetak2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cetak2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cetak2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_cetak2.Name = "btn_cetak2"
        Me.btn_cetak2.Size = New System.Drawing.Size(119, 40)
        Me.btn_cetak2.TabIndex = 20
        Me.btn_cetak2.Text = "LIHAT - CETAK"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(5, 578)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(97, 40)
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
        Me.btn_reset2.Location = New System.Drawing.Point(1011, 578)
        Me.btn_reset2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_reset2.Name = "btn_reset2"
        Me.btn_reset2.Size = New System.Drawing.Size(82, 40)
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
        Me.btn_del2.Location = New System.Drawing.Point(1099, 578)
        Me.btn_del2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_del2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_del2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_del2.Name = "btn_del2"
        Me.btn_del2.Size = New System.Drawing.Size(82, 40)
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
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x161
        Me.btn_save2.Location = New System.Drawing.Point(1187, 578)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 40)
        Me.btn_save2.TabIndex = 16
        Me.btn_save2.Text = "SIMPAN"
        '
        'GroupControl4
        '
        Me.GroupControl4.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl4.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl4.Appearance.Options.UseBackColor = True
        Me.GroupControl4.Appearance.Options.UseFont = True
        Me.GroupControl4.Appearance.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.txt_comment)
        Me.GroupControl4.Controls.Add(Me.TextBox2)
        Me.GroupControl4.Controls.Add(Me.TextBox7)
        Me.GroupControl4.Controls.Add(Me.Label17)
        Me.GroupControl4.Location = New System.Drawing.Point(5, 444)
        Me.GroupControl4.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(530, 122)
        Me.GroupControl4.TabIndex = 306
        Me.GroupControl4.Text = "NOTES"
        '
        'txt_comment
        '
        Me.txt_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comment.Location = New System.Drawing.Point(6, 50)
        Me.txt_comment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_comment.Multiline = True
        Me.txt_comment.Name = "txt_comment"
        Me.txt_comment.Size = New System.Drawing.Size(520, 64)
        Me.txt_comment.TabIndex = 39
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(11, -1350)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(971, 85)
        Me.TextBox2.TabIndex = 282
        Me.TextBox2.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.ForeColor = System.Drawing.Color.Black
        Me.TextBox7.Location = New System.Drawing.Point(-1042, 23)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(971, 85)
        Me.TextBox7.TabIndex = 280
        Me.TextBox7.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(3, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 18)
        Me.Label17.TabIndex = 279
        Me.Label17.Text = "Keterangan:"
        '
        'GroupControl5
        '
        Me.GroupControl5.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl5.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl5.Appearance.Options.UseBackColor = True
        Me.GroupControl5.Appearance.Options.UseFont = True
        Me.GroupControl5.Appearance.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.Label7)
        Me.GroupControl5.Controls.Add(Me.txt_tax)
        Me.GroupControl5.Controls.Add(Me.Label3)
        Me.GroupControl5.Controls.Add(Me.TextBox3)
        Me.GroupControl5.Controls.Add(Me.Label2)
        Me.GroupControl5.Controls.Add(Me.TextBox5)
        Me.GroupControl5.Controls.Add(Me.txt_balance)
        Me.GroupControl5.Controls.Add(Me.txt_reconcile)
        Me.GroupControl5.Controls.Add(Me.TextBox6)
        Me.GroupControl5.Controls.Add(Me.txt_adjustment)
        Me.GroupControl5.Location = New System.Drawing.Point(723, 420)
        Me.GroupControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(270, 146)
        Me.GroupControl5.TabIndex = 305
        Me.GroupControl5.Text = "BALANCE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(26, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "End Balance"
        '
        'txt_tax
        '
        Me.txt_tax.BackColor = System.Drawing.Color.Lavender
        Me.txt_tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tax.Enabled = False
        Me.txt_tax.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tax.Location = New System.Drawing.Point(39, 7200)
        Me.txt_tax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_tax.Name = "txt_tax"
        Me.txt_tax.ReadOnly = True
        Me.txt_tax.Size = New System.Drawing.Size(150, 23)
        Me.txt_tax.TabIndex = 283
        Me.txt_tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_tax.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Adjustment"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(11, -1350)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(971, 85)
        Me.TextBox3.TabIndex = 282
        Me.TextBox3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "System Balance"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.ForeColor = System.Drawing.Color.Black
        Me.TextBox5.Location = New System.Drawing.Point(11, -1350)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(971, 85)
        Me.TextBox5.TabIndex = 281
        Me.TextBox5.Visible = False
        '
        'txt_reconcile
        '
        Me.txt_reconcile.BackColor = System.Drawing.Color.Lavender
        Me.txt_reconcile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_reconcile.Enabled = False
        Me.txt_reconcile.Location = New System.Drawing.Point(111, 59)
        Me.txt_reconcile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_reconcile.Name = "txt_reconcile"
        Me.txt_reconcile.ReadOnly = True
        Me.txt_reconcile.Size = New System.Drawing.Size(152, 23)
        Me.txt_reconcile.TabIndex = 34
        Me.txt_reconcile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.ForeColor = System.Drawing.Color.Black
        Me.TextBox6.Location = New System.Drawing.Point(-1042, 23)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(971, 85)
        Me.TextBox6.TabIndex = 280
        Me.TextBox6.Visible = False
        '
        'txt_adjustment
        '
        Me.txt_adjustment.BackColor = System.Drawing.Color.Lavender
        Me.txt_adjustment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_adjustment.Enabled = False
        Me.txt_adjustment.Location = New System.Drawing.Point(111, 89)
        Me.txt_adjustment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_adjustment.Name = "txt_adjustment"
        Me.txt_adjustment.ReadOnly = True
        Me.txt_adjustment.Size = New System.Drawing.Size(152, 23)
        Me.txt_adjustment.TabIndex = 36
        Me.txt_adjustment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.lookup_acc)
        Me.GroupControl2.Controls.Add(Me.ComboBox4)
        Me.GroupControl2.Controls.Add(Me.MtgcComboBox2)
        Me.GroupControl2.Controls.Add(Me.DataGridView1)
        Me.GroupControl2.Location = New System.Drawing.Point(5, 184)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(989, 227)
        Me.GroupControl2.TabIndex = 300
        Me.GroupControl2.Text = "DETAIL REKONSILIASI"
        '
        'lookup_acc
        '
        Me.lookup_acc.Location = New System.Drawing.Point(48, 82)
        Me.lookup_acc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lookup_acc.Name = "lookup_acc"
        Me.lookup_acc.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.lookup_acc.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lookup_acc.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lookup_acc.Properties.Appearance.Options.UseBackColor = True
        Me.lookup_acc.Properties.Appearance.Options.UseFont = True
        Me.lookup_acc.Properties.Appearance.Options.UseForeColor = True
        Me.lookup_acc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookup_acc.Properties.View = Me.GridView4
        Me.lookup_acc.Size = New System.Drawing.Size(126, 24)
        Me.lookup_acc.TabIndex = 310
        Me.lookup_acc.Visible = False
        '
        'GridView4
        '
        Me.GridView4.Appearance.Row.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView4.Appearance.Row.Options.UseFont = True
        Me.GridView4.Appearance.ViewCaption.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView4.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsCustomization.AllowColumnMoving = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.RowAutoHeight = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.PaintStyleName = "Skin"
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.ForeColor = System.Drawing.Color.Black
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(-1424, 40)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox4.TabIndex = 131
        Me.ComboBox4.Visible = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colno, Me.colaccount, Me.colaccnm, Me.coldesc, Me.colamt, Me.colamountout})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(985, 204)
        Me.DataGridView1.TabIndex = 10
        '
        'colno
        '
        Me.colno.HeaderText = "No"
        Me.colno.Name = "colno"
        Me.colno.Width = 45
        '
        'colaccount
        '
        Me.colaccount.HeaderText = "No Akun"
        Me.colaccount.Name = "colaccount"
        Me.colaccount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colaccount.Width = 125
        '
        'colaccnm
        '
        Me.colaccnm.HeaderText = "Nama Akun"
        Me.colaccnm.Name = "colaccnm"
        Me.colaccnm.Width = 210
        '
        'coldesc
        '
        Me.coldesc.HeaderText = "Keterangan"
        Me.coldesc.Name = "coldesc"
        Me.coldesc.Width = 320
        '
        'colamt
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.NullValue = "0"
        Me.colamt.DefaultCellStyle = DataGridViewCellStyle2
        Me.colamt.HeaderText = "Debet"
        Me.colamt.Name = "colamt"
        Me.colamt.Width = 130
        '
        'colamountout
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = "0"
        Me.colamountout.DefaultCellStyle = DataGridViewCellStyle3
        Me.colamountout.HeaderText = "Kredit"
        Me.colamountout.Name = "colamountout"
        Me.colamountout.Width = 130
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.lb_cashbank_name)
        Me.GroupControl1.Controls.Add(Me.Label16)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.cbo_curr)
        Me.GroupControl1.Controls.Add(Me.txt_kurs)
        Me.GroupControl1.Controls.Add(Me.cbo_acc)
        Me.GroupControl1.Controls.Add(Me.txt_no_reconcile)
        Me.GroupControl1.Controls.Add(Me.Label13)
        Me.GroupControl1.Controls.Add(Me.Label14)
        Me.GroupControl1.Controls.Add(Me.ComboBox3)
        Me.GroupControl1.Controls.Add(Me.Label15)
        Me.GroupControl1.Controls.Add(Me.txt_date)
        Me.GroupControl1.Controls.Add(Me.cbo_unit)
        Me.GroupControl1.Controls.Add(Me.Label18)
        Me.GroupControl1.Controls.Add(Me.Label24)
        Me.GroupControl1.Controls.Add(Me.Label29)
        Me.GroupControl1.Location = New System.Drawing.Point(609, 5)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(385, 172)
        Me.GroupControl1.TabIndex = 299
        Me.GroupControl1.Text = "INFORMASI REKONSILIASI"
        '
        'lb_cashbank_name
        '
        Me.lb_cashbank_name.AutoSize = True
        Me.lb_cashbank_name.BackColor = System.Drawing.Color.Transparent
        Me.lb_cashbank_name.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cashbank_name.Location = New System.Drawing.Point(93, 119)
        Me.lb_cashbank_name.Name = "lb_cashbank_name"
        Me.lb_cashbank_name.Size = New System.Drawing.Size(87, 18)
        Me.lb_cashbank_name.TabIndex = 36
        Me.lb_cashbank_name.Text = "nm_cashbank"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(244, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 18)
        Me.Label16.TabIndex = 264
        Me.Label16.Text = "Mata Uang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Kas / Bank :"
        '
        'cbo_curr
        '
        Me.cbo_curr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_curr.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_curr.FormattingEnabled = True
        Me.cbo_curr.Location = New System.Drawing.Point(247, 91)
        Me.cbo_curr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_curr.Name = "cbo_curr"
        Me.cbo_curr.Size = New System.Drawing.Size(127, 26)
        Me.cbo_curr.TabIndex = 260
        '
        'txt_kurs
        '
        Me.txt_kurs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_kurs.BackColor = System.Drawing.Color.Lavender
        Me.txt_kurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_kurs.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kurs.Location = New System.Drawing.Point(247, 141)
        Me.txt_kurs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_kurs.Name = "txt_kurs"
        Me.txt_kurs.ReadOnly = True
        Me.txt_kurs.Size = New System.Drawing.Size(127, 23)
        Me.txt_kurs.TabIndex = 263
        '
        'cbo_acc
        '
        Me.cbo_acc.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_acc.ArrowColor = System.Drawing.Color.Black
        Me.cbo_acc.BindedControl = CType(resources.GetObject("cbo_acc.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_acc.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_acc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_acc.ColumnNum = 2
        Me.cbo_acc.ColumnWidth = "55; 180"
        Me.cbo_acc.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_acc.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cbo_acc.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cbo_acc.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbo_acc.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo_acc.DisplayMember = "Text"
        Me.cbo_acc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_acc.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cbo_acc.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbo_acc.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_acc.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_acc.DropDownWidth = 255
        Me.cbo_acc.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_acc.GridLineHorizontal = True
        Me.cbo_acc.GridLineVertical = True
        Me.cbo_acc.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_acc.HighlightBorderOnMouseEvents = True
        Me.cbo_acc.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_acc.Location = New System.Drawing.Point(12, 92)
        Me.cbo_acc.ManagingFastMouseMoving = True
        Me.cbo_acc.ManagingFastMouseMovingInterval = 30
        Me.cbo_acc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_acc.Name = "cbo_acc"
        Me.cbo_acc.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_acc.SelectedItem = Nothing
        Me.cbo_acc.SelectedValue = Nothing
        Me.cbo_acc.Size = New System.Drawing.Size(223, 24)
        Me.cbo_acc.TabIndex = 40
        '
        'txt_no_reconcile
        '
        Me.txt_no_reconcile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_no_reconcile.BackColor = System.Drawing.Color.Lavender
        Me.txt_no_reconcile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_no_reconcile.Location = New System.Drawing.Point(12, 44)
        Me.txt_no_reconcile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_no_reconcile.Name = "txt_no_reconcile"
        Me.txt_no_reconcile.Size = New System.Drawing.Size(223, 23)
        Me.txt_no_reconcile.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(244, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 18)
        Me.Label13.TabIndex = 256
        Me.Label13.Text = "Kurs"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(244, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 18)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Tanggal"
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
        Me.ComboBox3.Location = New System.Drawing.Point(-2028, 40)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox3.TabIndex = 131
        Me.ComboBox3.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(9, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 18)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Akun Bank"
        '
        'txt_date
        '
        Me.txt_date.CustomFormat = "dd-MMM-yyyy"
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date.Location = New System.Drawing.Point(247, 44)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(127, 23)
        Me.txt_date.TabIndex = 7
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
        Me.Label18.Location = New System.Drawing.Point(623, 68)
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
        Me.Label24.Location = New System.Drawing.Point(623, 35)
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
        Me.Label29.Location = New System.Drawing.Point(9, 22)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(97, 18)
        Me.Label29.TabIndex = 102
        Me.Label29.Text = "No Rekonsiliasi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(217, 415)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 18)
        Me.Label10.TabIndex = 295
        Me.Label10.Text = "* Tekan Delete untuk menghapus item"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(4, 415)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(207, 18)
        Me.Label11.TabIndex = 294
        Me.Label11.Text = "* Tekan F5 untuk menambah item"
        '
        'GroupControl7
        '
        Me.GroupControl7.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl7.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl7.Appearance.Options.UseBackColor = True
        Me.GroupControl7.Appearance.Options.UseFont = True
        Me.GroupControl7.Appearance.Options.UseForeColor = True
        Me.GroupControl7.Controls.Add(Me.btn_reset_cust)
        Me.GroupControl7.Controls.Add(Me.Label28)
        Me.GroupControl7.Controls.Add(Me.txt_search)
        Me.GroupControl7.Controls.Add(Me.btn_cari_cust)
        Me.GroupControl7.Controls.Add(Me.Label27)
        Me.GroupControl7.Controls.Add(Me.GroupBox3)
        Me.GroupControl7.Controls.Add(Me.cbo_search)
        Me.GroupControl7.Location = New System.Drawing.Point(9, 11)
        Me.GroupControl7.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl7.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(194, 763)
        Me.GroupControl7.TabIndex = 299
        Me.GroupControl7.Text = "PANEL PENCARIAN"
        '
        'btn_reset_cust
        '
        Me.btn_reset_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_cust.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_reset_cust.Appearance.Options.UseFont = True
        Me.btn_reset_cust.Appearance.Options.UseForeColor = True
        Me.btn_reset_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset_cust.Location = New System.Drawing.Point(17, 396)
        Me.btn_reset_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_reset_cust.Name = "btn_reset_cust"
        Me.btn_reset_cust.Size = New System.Drawing.Size(76, 43)
        Me.btn_reset_cust.TabIndex = 276
        Me.btn_reset_cust.Text = "RESET"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(19, 42)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(141, 18)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Pencarian Berdasarkan"
        '
        'txt_search
        '
        Me.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(22, 121)
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
        Me.btn_cari_cust.Location = New System.Drawing.Point(99, 396)
        Me.btn_cari_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cari_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cari_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cari_cust.Name = "btn_cari_cust"
        Me.btn_cari_cust.Size = New System.Drawing.Size(78, 43)
        Me.btn_cari_cust.TabIndex = 275
        Me.btn_cari_cust.Text = "CARI"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(19, 100)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 18)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "Teks Pencarian"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chk_date)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.tglakhir)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.tglawal)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 190)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(160, 185)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter Tanggal"
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.Location = New System.Drawing.Point(15, 28)
        Me.chk_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(125, 22)
        Me.chk_date.TabIndex = 38
        Me.chk_date.Text = "Rentang Tanggal"
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(18, 119)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 18)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Sampai"
        '
        'tglakhir
        '
        Me.tglakhir.CustomFormat = "dd-MM-yyyy"
        Me.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglakhir.Location = New System.Drawing.Point(21, 140)
        Me.tglakhir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(111, 23)
        Me.tglakhir.TabIndex = 36
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(18, 66)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 18)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Dari"
        '
        'tglawal
        '
        Me.tglawal.CustomFormat = "dd-MM-yyyy"
        Me.tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglawal.Location = New System.Drawing.Point(21, 88)
        Me.tglawal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglawal.Name = "tglawal"
        Me.tglawal.Size = New System.Drawing.Size(111, 23)
        Me.tglawal.TabIndex = 34
        '
        'cbo_search
        '
        Me.cbo_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"Reconcile No", "Notes"})
        Me.cbo_search.Location = New System.Drawing.Point(22, 67)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnospend, Me.coldate, Me.coldescript, Me.colbalancehist})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(787, 741)
        Me.DataGridView2.TabIndex = 13
        '
        'colnospend
        '
        Me.colnospend.HeaderText = "No Rekonsiliasi"
        Me.colnospend.Name = "colnospend"
        Me.colnospend.ReadOnly = True
        Me.colnospend.Width = 175
        '
        'coldate
        '
        Me.coldate.HeaderText = "Tanggal"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        Me.coldate.Width = 110
        '
        'coldescript
        '
        Me.coldescript.HeaderText = "Keterangan"
        Me.coldescript.Name = "coldescript"
        Me.coldescript.ReadOnly = True
        Me.coldescript.Width = 355
        '
        'colbalancehist
        '
        Me.colbalancehist.HeaderText = "Nominal"
        Me.colbalancehist.Name = "colbalancehist"
        Me.colbalancehist.ReadOnly = True
        Me.colbalancehist.Width = 125
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(118, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Kota"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(67, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(156, 23)
        Me.Panel2.TabIndex = 208
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(118, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Kota"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(85, 218)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(156, 23)
        Me.Panel3.TabIndex = 208
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(97, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 18)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Propinsi"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel10.Controls.Add(Me.Label12)
        Me.Panel10.Location = New System.Drawing.Point(110, 242)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(156, 23)
        Me.Panel10.TabIndex = 207
        '
        'GroupControl6
        '
        Me.GroupControl6.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl6.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl6.Appearance.Options.UseBackColor = True
        Me.GroupControl6.Appearance.Options.UseFont = True
        Me.GroupControl6.Appearance.Options.UseForeColor = True
        Me.GroupControl6.Controls.Add(Me.DataGridView2)
        Me.GroupControl6.Location = New System.Drawing.Point(211, 11)
        Me.GroupControl6.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(791, 764)
        Me.GroupControl6.TabIndex = 300
        Me.GroupControl6.Text = "DAFTAR TRANSAKSI"
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(-32768, -32768)
        Me.TabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.TabInput
        Me.TabControl1.Size = New System.Drawing.Size(879, 818)
        Me.TabControl1.TabIndex = 86
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabInput, Me.TabList})
        Me.TabControl1.Visible = False
        '
        'TabInput
        '
        Me.TabInput.Controls.Add(Me.Panel5)
        Me.TabInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabInput.Name = "TabInput"
        Me.TabInput.Size = New System.Drawing.Size(877, 793)
        Me.TabInput.Text = "TAMBAH / UBAH REKONSILIASI"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(877, 793)
        Me.Panel5.TabIndex = 0
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.Panel6)
        Me.TabList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabList.Name = "TabList"
        Me.TabList.Size = New System.Drawing.Size(877, 793)
        Me.TabList.Text = "DAFTAR REKONSILIASI"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.Controls.Add(Me.GroupControl6)
        Me.Panel6.Controls.Add(Me.GroupControl7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(877, 793)
        Me.Panel6.TabIndex = 0
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
        Me.PanelControl5.Location = New System.Drawing.Point(12, 612)
        Me.PanelControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(993, 49)
        Me.PanelControl5.TabIndex = 302
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
        Me.SimpleButton3.Size = New System.Drawing.Size(168, 37)
        Me.SimpleButton3.TabIndex = 293
        Me.SimpleButton3.Text = "TAMBAH REKONSILIASI"
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Location = New System.Drawing.Point(12, 35)
        Me.GridControl.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl.MainView = Me.GridList_Customer
        Me.GridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(993, 575)
        Me.GridControl.TabIndex = 300
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
        Me.Label4.Location = New System.Drawing.Point(8, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 24)
        Me.Label4.TabIndex = 301
        Me.Label4.Text = "Daftar Rekonsiliasi Bank"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.Controls.Add(Me.btn_cetak2)
        Me.PanelControl3.Controls.Add(Me.GroupControl3)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.btn_keluar)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.GroupControl4)
        Me.PanelControl3.Controls.Add(Me.Label10)
        Me.PanelControl3.Controls.Add(Me.btn_reset2)
        Me.PanelControl3.Controls.Add(Me.btn_save2)
        Me.PanelControl3.Controls.Add(Me.Label11)
        Me.PanelControl3.Controls.Add(Me.GroupControl5)
        Me.PanelControl3.Controls.Add(Me.btn_del2)
        Me.PanelControl3.Location = New System.Drawing.Point(7, 16)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1001, 627)
        Me.PanelControl3.TabIndex = 303
        Me.PanelControl3.Visible = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Appearance.Options.UseFont = True
        Me.GroupControl3.Appearance.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.btn_browse)
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Controls.Add(Me.txt_save_path)
        Me.GroupControl3.Location = New System.Drawing.Point(91, -217)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1164, 197)
        Me.GroupControl3.TabIndex = 268
        Me.GroupControl3.Text = "SETTING DIREKTORI FOTO"
        Me.GroupControl3.Visible = False
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
        Me.btn_browse.Size = New System.Drawing.Size(411, 153)
        Me.btn_browse.TabIndex = 282
        Me.btn_browse.Text = "BROWSE"
        Me.btn_browse.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 279
        Me.Label5.Text = "Direktori Foto :"
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
        Me.txt_save_path.Size = New System.Drawing.Size(1150, 25)
        Me.txt_save_path.TabIndex = 277
        Me.txt_save_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmreconcile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1015, 672)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmreconcile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rekonsiliasi Bank"
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.lookup_acc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabInput.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_balance As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_no_reconcile As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_reconcile As System.Windows.Forms.TextBox
    Friend WithEvents txt_adjustment As System.Windows.Forms.TextBox
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tglakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tglawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents chk_date As System.Windows.Forms.CheckBox
    Friend WithEvents txt_comment As System.Windows.Forms.TextBox
    Friend WithEvents cbo_acc As MTGCComboBox
    Friend WithEvents lb_cashbank_name As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents txt_kurs As System.Windows.Forms.TextBox
    Friend WithEvents cbo_curr As System.Windows.Forms.ComboBox
    Friend WithEvents colno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colaccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colaccnm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colamt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colamountout As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnospend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colbalancehist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbo_unit As MTGCComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents MtgcComboBox2 As MTGCComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_tax As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_cetak2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reset2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_reset_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lookup_acc As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridList_Customer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_save_path As System.Windows.Forms.TextBox
End Class
