<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpayAR
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
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpayAR))
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_cetak = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reset2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_total_ap = New System.Windows.Forms.TextBox()
        Me.txt_payment = New System.Windows.Forms.TextBox()
        Me.txt_total_return = New System.Windows.Forms.TextBox()
        Me.txt_total_net = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_total_disc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colinvoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colreturn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbayar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colkurs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnilai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcurr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_billno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_idAccpayment = New System.Windows.Forms.Label()
        Me.cbo_acc = New MTGCComboBox()
        Me.txt_curr = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckKurs = New System.Windows.Forms.CheckBox()
        Me.MtgcComboBox1 = New MTGCComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_idsupplier = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_comment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cbo_supplier = New System.Windows.Forms.ComboBox()
        Me.txt_supplier_address = New System.Windows.Forms.TextBox()
        Me.txt_supplier_nm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_unit = New MTGCComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_reset_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_cari_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tglakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tglawal = New System.Windows.Forms.DateTimePicker()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colnopay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcetak = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.TabInput = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabList = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridList_Customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_browse = New DevExpress.XtraEditors.SimpleButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_save_path = New System.Windows.Forms.TextBox()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabInput.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        'btn_cetak
        '
        Me.btn_cetak.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.Appearance.Options.UseFont = True
        Me.btn_cetak.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Print_16x16
        Me.btn_cetak.Location = New System.Drawing.Point(110, 570)
        Me.btn_cetak.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cetak.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cetak.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(119, 36)
        Me.btn_cetak.TabIndex = 20
        Me.btn_cetak.Text = "LIHAT - CETAK"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(7, 570)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(97, 36)
        Me.btn_keluar.TabIndex = 19
        Me.btn_keluar.Text = "KELUAR"
        '
        'btn_reset2
        '
        Me.btn_reset2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset2.Appearance.Options.UseFont = True
        Me.btn_reset2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset2.Location = New System.Drawing.Point(729, 570)
        Me.btn_reset2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_reset2.Name = "btn_reset2"
        Me.btn_reset2.Size = New System.Drawing.Size(82, 36)
        Me.btn_reset2.TabIndex = 18
        Me.btn_reset2.Text = "RESET"
        '
        'btn_del2
        '
        Me.btn_del2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_del2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del2.Appearance.Options.UseFont = True
        Me.btn_del2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Delete_16x16
        Me.btn_del2.Location = New System.Drawing.Point(817, 570)
        Me.btn_del2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_del2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_del2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_del2.Name = "btn_del2"
        Me.btn_del2.Size = New System.Drawing.Size(82, 36)
        Me.btn_del2.TabIndex = 17
        Me.btn_del2.Text = "HAPUS"
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(905, 570)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 36)
        Me.btn_save2.TabIndex = 16
        Me.btn_save2.Text = "SIMPAN"
        '
        'GroupControl5
        '
        Me.GroupControl5.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl5.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl5.Appearance.Options.UseBackColor = True
        Me.GroupControl5.Appearance.Options.UseFont = True
        Me.GroupControl5.Appearance.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.Label12)
        Me.GroupControl5.Controls.Add(Me.Label18)
        Me.GroupControl5.Controls.Add(Me.Label23)
        Me.GroupControl5.Controls.Add(Me.Label21)
        Me.GroupControl5.Controls.Add(Me.Label22)
        Me.GroupControl5.Controls.Add(Me.Label24)
        Me.GroupControl5.Controls.Add(Me.txt_total_ap)
        Me.GroupControl5.Controls.Add(Me.txt_payment)
        Me.GroupControl5.Controls.Add(Me.txt_total_return)
        Me.GroupControl5.Controls.Add(Me.txt_total_net)
        Me.GroupControl5.Controls.Add(Me.txt_total)
        Me.GroupControl5.Controls.Add(Me.txt_total_disc)
        Me.GroupControl5.Location = New System.Drawing.Point(194, 455)
        Me.GroupControl5.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(792, 82)
        Me.GroupControl5.TabIndex = 313
        Me.GroupControl5.Text = "SUMMARY"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(655, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 18)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "TOTAL PEMBAYARAN"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(552, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 18)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "SALDO AKHIR"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(430, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 18)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "TERBAYAR"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(294, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 18)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "DISC TOTAL"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(156, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 18)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "RETUR TOTAL"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(25, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(98, 18)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "FAKTUR TOTAL"
        '
        'txt_total_ap
        '
        Me.txt_total_ap.BackColor = System.Drawing.Color.Lavender
        Me.txt_total_ap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_ap.Enabled = False
        Me.txt_total_ap.Location = New System.Drawing.Point(7, 48)
        Me.txt_total_ap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_total_ap.Name = "txt_total_ap"
        Me.txt_total_ap.Size = New System.Drawing.Size(126, 23)
        Me.txt_total_ap.TabIndex = 37
        Me.txt_total_ap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_payment
        '
        Me.txt_payment.BackColor = System.Drawing.Color.Lavender
        Me.txt_payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_payment.Enabled = False
        Me.txt_payment.Location = New System.Drawing.Point(658, 48)
        Me.txt_payment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_payment.Name = "txt_payment"
        Me.txt_payment.Size = New System.Drawing.Size(125, 23)
        Me.txt_payment.TabIndex = 39
        Me.txt_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_total_return
        '
        Me.txt_total_return.BackColor = System.Drawing.Color.Lavender
        Me.txt_total_return.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_return.Enabled = False
        Me.txt_total_return.Location = New System.Drawing.Point(135, 48)
        Me.txt_total_return.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_total_return.Name = "txt_total_return"
        Me.txt_total_return.Size = New System.Drawing.Size(130, 23)
        Me.txt_total_return.TabIndex = 36
        Me.txt_total_return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_total_net
        '
        Me.txt_total_net.BackColor = System.Drawing.Color.Lavender
        Me.txt_total_net.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_net.Enabled = False
        Me.txt_total_net.Location = New System.Drawing.Point(397, 48)
        Me.txt_total_net.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_total_net.Name = "txt_total_net"
        Me.txt_total_net.Size = New System.Drawing.Size(130, 23)
        Me.txt_total_net.TabIndex = 34
        Me.txt_total_net.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.Lavender
        Me.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total.Location = New System.Drawing.Point(529, 48)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(127, 23)
        Me.txt_total.TabIndex = 33
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_total_disc
        '
        Me.txt_total_disc.BackColor = System.Drawing.Color.Lavender
        Me.txt_total_disc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_total_disc.Enabled = False
        Me.txt_total_disc.Location = New System.Drawing.Point(267, 48)
        Me.txt_total_disc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_total_disc.Name = "txt_total_disc"
        Me.txt_total_disc.Size = New System.Drawing.Size(128, 23)
        Me.txt_total_disc.TabIndex = 35
        Me.txt_total_disc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(2, 450)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 36)
        Me.Label10.TabIndex = 312
        Me.Label10.Text = "Format Tanggal Pada Detail " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Faktur ""tahun-bulan-tanggal"""
        '
        'GroupControl4
        '
        Me.GroupControl4.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl4.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl4.Appearance.Options.UseBackColor = True
        Me.GroupControl4.Appearance.Options.UseFont = True
        Me.GroupControl4.Appearance.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.DataGridView1)
        Me.GroupControl4.Location = New System.Drawing.Point(5, 214)
        Me.GroupControl4.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(982, 234)
        Me.GroupControl4.TabIndex = 299
        Me.GroupControl4.Text = "DETAIL FAKTUR"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle37.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle37
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colno, Me.colinvoice, Me.coltotal, Me.colap, Me.colreturn, Me.coldesc, Me.colprice, Me.colqty, Me.colpayment, Me.colbayar, Me.colkurs, Me.colnilai, Me.colcurr})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(978, 211)
        Me.DataGridView1.TabIndex = 10
        '
        'colno
        '
        Me.colno.HeaderText = "No"
        Me.colno.Name = "colno"
        Me.colno.Width = 46
        '
        'colinvoice
        '
        Me.colinvoice.HeaderText = "No Faktur"
        Me.colinvoice.Name = "colinvoice"
        Me.colinvoice.Width = 175
        '
        'coltotal
        '
        Me.coltotal.HeaderText = "Tanggal"
        Me.coltotal.Name = "coltotal"
        Me.coltotal.Width = 95
        '
        'colap
        '
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colap.DefaultCellStyle = DataGridViewCellStyle38
        Me.colap.HeaderText = "Nominal"
        Me.colap.Name = "colap"
        Me.colap.Width = 107
        '
        'colreturn
        '
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colreturn.DefaultCellStyle = DataGridViewCellStyle39
        Me.colreturn.HeaderText = "Retur"
        Me.colreturn.Name = "colreturn"
        Me.colreturn.Width = 103
        '
        'coldesc
        '
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.coldesc.DefaultCellStyle = DataGridViewCellStyle40
        Me.coldesc.HeaderText = "Diskon"
        Me.coldesc.Name = "coldesc"
        Me.coldesc.Width = 105
        '
        'colprice
        '
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colprice.DefaultCellStyle = DataGridViewCellStyle41
        Me.colprice.HeaderText = "Terbayar"
        Me.colprice.Name = "colprice"
        Me.colprice.Width = 108
        '
        'colqty
        '
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colqty.DefaultCellStyle = DataGridViewCellStyle42
        Me.colqty.HeaderText = "Saldo"
        Me.colqty.Name = "colqty"
        Me.colqty.Width = 108
        '
        'colpayment
        '
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colpayment.DefaultCellStyle = DataGridViewCellStyle43
        Me.colpayment.HeaderText = "Bayar"
        Me.colpayment.Name = "colpayment"
        Me.colpayment.Width = 108
        '
        'colbayar
        '
        Me.colbayar.HeaderText = "Pilih"
        Me.colbayar.Name = "colbayar"
        Me.colbayar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colbayar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colbayar.Width = 60
        '
        'colkurs
        '
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colkurs.DefaultCellStyle = DataGridViewCellStyle44
        Me.colkurs.HeaderText = "Rate"
        Me.colkurs.Name = "colkurs"
        Me.colkurs.Width = 97
        '
        'colnilai
        '
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colnilai.DefaultCellStyle = DataGridViewCellStyle45
        Me.colnilai.HeaderText = "Konversi"
        Me.colnilai.Name = "colnilai"
        Me.colnilai.Width = 107
        '
        'colcurr
        '
        Me.colcurr.HeaderText = "Mata Uang"
        Me.colcurr.Name = "colcurr"
        Me.colcurr.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl2.Appearance.Options.UseBackColor = True
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.Controls.Add(Me.txt_date)
        Me.GroupControl2.Controls.Add(Me.Label8)
        Me.GroupControl2.Controls.Add(Me.txt_billno)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.lb_idAccpayment)
        Me.GroupControl2.Controls.Add(Me.cbo_acc)
        Me.GroupControl2.Controls.Add(Me.txt_curr)
        Me.GroupControl2.Controls.Add(Me.ComboBox2)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.CheckKurs)
        Me.GroupControl2.Controls.Add(Me.MtgcComboBox1)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Location = New System.Drawing.Point(532, 6)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(455, 149)
        Me.GroupControl2.TabIndex = 295
        Me.GroupControl2.Text = "INFORMASI PEMBAYARAN"
        '
        'txt_date
        '
        Me.txt_date.CustomFormat = "dd-MMM-yyyy"
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date.Location = New System.Drawing.Point(234, 115)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(212, 23)
        Me.txt_date.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(231, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 275
        Me.Label8.Text = "Tanggal"
        '
        'txt_billno
        '
        Me.txt_billno.BackColor = System.Drawing.Color.Lavender
        Me.txt_billno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_billno.Location = New System.Drawing.Point(12, 115)
        Me.txt_billno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_billno.Name = "txt_billno"
        Me.txt_billno.ReadOnly = True
        Me.txt_billno.Size = New System.Drawing.Size(212, 23)
        Me.txt_billno.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 274
        Me.Label2.Text = "No Pembayaran"
        '
        'lb_idAccpayment
        '
        Me.lb_idAccpayment.AutoSize = True
        Me.lb_idAccpayment.BackColor = System.Drawing.Color.Transparent
        Me.lb_idAccpayment.ForeColor = System.Drawing.Color.Black
        Me.lb_idAccpayment.Location = New System.Drawing.Point(231, 68)
        Me.lb_idAccpayment.Name = "lb_idAccpayment"
        Me.lb_idAccpayment.Size = New System.Drawing.Size(91, 18)
        Me.lb_idAccpayment.TabIndex = 21
        Me.lb_idAccpayment.Text = "Account Name"
        '
        'cbo_acc
        '
        Me.cbo_acc.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_acc.ArrowColor = System.Drawing.Color.Black
        Me.cbo_acc.BindedControl = CType(resources.GetObject("cbo_acc.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_acc.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_acc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_acc.ColumnNum = 2
        Me.cbo_acc.ColumnWidth = "110; 200"
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
        Me.cbo_acc.DropDownWidth = 630
        Me.cbo_acc.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_acc.GridLineHorizontal = True
        Me.cbo_acc.GridLineVertical = True
        Me.cbo_acc.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_acc.HighlightBorderOnMouseEvents = True
        Me.cbo_acc.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_acc.Location = New System.Drawing.Point(234, 41)
        Me.cbo_acc.ManagingFastMouseMoving = True
        Me.cbo_acc.ManagingFastMouseMovingInterval = 30
        Me.cbo_acc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_acc.Name = "cbo_acc"
        Me.cbo_acc.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_acc.SelectedItem = Nothing
        Me.cbo_acc.SelectedValue = Nothing
        Me.cbo_acc.Size = New System.Drawing.Size(212, 24)
        Me.cbo_acc.TabIndex = 85
        '
        'txt_curr
        '
        Me.txt_curr.FormattingEnabled = True
        Me.txt_curr.Location = New System.Drawing.Point(12, 41)
        Me.txt_curr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_curr.Name = "txt_curr"
        Me.txt_curr.Size = New System.Drawing.Size(212, 26)
        Me.txt_curr.TabIndex = 273
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(-1958, 40)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox2.TabIndex = 131
        Me.ComboBox2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(231, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Akun Pembayaran"
        '
        'CheckKurs
        '
        Me.CheckKurs.AutoSize = True
        Me.CheckKurs.BackColor = System.Drawing.Color.Transparent
        Me.CheckKurs.Location = New System.Drawing.Point(12, 67)
        Me.CheckKurs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckKurs.Name = "CheckKurs"
        Me.CheckKurs.Size = New System.Drawing.Size(134, 22)
        Me.CheckKurs.TabIndex = 272
        Me.CheckKurs.Text = "Use Currency Rate"
        Me.CheckKurs.UseVisualStyleBackColor = False
        '
        'MtgcComboBox1
        '
        Me.MtgcComboBox1.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.MtgcComboBox1.ArrowColor = System.Drawing.Color.Black
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(623, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 18)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Tanggal Permintaan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(623, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "No Permintaan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Mata Uang"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.txt_idsupplier)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.txt_comment)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.ComboBox1)
        Me.GroupControl1.Controls.Add(Me.cbo_supplier)
        Me.GroupControl1.Controls.Add(Me.txt_supplier_address)
        Me.GroupControl1.Controls.Add(Me.txt_supplier_nm)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.cbo_unit)
        Me.GroupControl1.Controls.Add(Me.Label13)
        Me.GroupControl1.Controls.Add(Me.Label14)
        Me.GroupControl1.Controls.Add(Me.Label15)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 6)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(466, 202)
        Me.GroupControl1.TabIndex = 294
        Me.GroupControl1.Text = "INFORMASI PELANGGAN"
        '
        'txt_idsupplier
        '
        Me.txt_idsupplier.BackColor = System.Drawing.Color.Lavender
        Me.txt_idsupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_idsupplier.Location = New System.Drawing.Point(-32768, 103)
        Me.txt_idsupplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_idsupplier.Name = "txt_idsupplier"
        Me.txt_idsupplier.ReadOnly = True
        Me.txt_idsupplier.Size = New System.Drawing.Size(212, 23)
        Me.txt_idsupplier.TabIndex = 133
        Me.txt_idsupplier.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "Keterangan"
        '
        'txt_comment
        '
        Me.txt_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comment.Location = New System.Drawing.Point(11, 137)
        Me.txt_comment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_comment.Multiline = True
        Me.txt_comment.Name = "txt_comment"
        Me.txt_comment.Size = New System.Drawing.Size(446, 58)
        Me.txt_comment.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(213, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alamat"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(-1947, 40)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox1.TabIndex = 131
        Me.ComboBox1.Visible = False
        '
        'cbo_supplier
        '
        Me.cbo_supplier.FormattingEnabled = True
        Me.cbo_supplier.Location = New System.Drawing.Point(11, 42)
        Me.cbo_supplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_supplier.Name = "cbo_supplier"
        Me.cbo_supplier.Size = New System.Drawing.Size(197, 26)
        Me.cbo_supplier.TabIndex = 22
        '
        'txt_supplier_address
        '
        Me.txt_supplier_address.BackColor = System.Drawing.Color.Lavender
        Me.txt_supplier_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_supplier_address.Location = New System.Drawing.Point(216, 43)
        Me.txt_supplier_address.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_supplier_address.Multiline = True
        Me.txt_supplier_address.Name = "txt_supplier_address"
        Me.txt_supplier_address.ReadOnly = True
        Me.txt_supplier_address.Size = New System.Drawing.Size(241, 71)
        Me.txt_supplier_address.TabIndex = 3
        '
        'txt_supplier_nm
        '
        Me.txt_supplier_nm.BackColor = System.Drawing.Color.Lavender
        Me.txt_supplier_nm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_supplier_nm.Location = New System.Drawing.Point(11, 91)
        Me.txt_supplier_nm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_supplier_nm.Name = "txt_supplier_nm"
        Me.txt_supplier_nm.ReadOnly = True
        Me.txt_supplier_nm.Size = New System.Drawing.Size(197, 23)
        Me.txt_supplier_nm.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Nama Pelanggan"
        '
        'cbo_unit
        '
        Me.cbo_unit.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_unit.ArrowColor = System.Drawing.Color.Black
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(623, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 18)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "Tanggal Permintaan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(623, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 18)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "No Permintaan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 18)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Pilih Pelanggan"
        '
        'GroupControl6
        '
        Me.GroupControl6.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl6.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl6.Appearance.Options.UseBackColor = True
        Me.GroupControl6.Appearance.Options.UseFont = True
        Me.GroupControl6.Appearance.Options.UseForeColor = True
        Me.GroupControl6.Controls.Add(Me.btn_reset_cust)
        Me.GroupControl6.Controls.Add(Me.Label20)
        Me.GroupControl6.Controls.Add(Me.txt_search)
        Me.GroupControl6.Controls.Add(Me.btn_cari_cust)
        Me.GroupControl6.Controls.Add(Me.Label19)
        Me.GroupControl6.Controls.Add(Me.GroupBox3)
        Me.GroupControl6.Controls.Add(Me.cbo_search)
        Me.GroupControl6.Location = New System.Drawing.Point(11, 14)
        Me.GroupControl6.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(194, 736)
        Me.GroupControl6.TabIndex = 283
        Me.GroupControl6.Text = "PANEL PENCARIAN"
        '
        'btn_reset_cust
        '
        Me.btn_reset_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_cust.Appearance.Options.UseFont = True
        Me.btn_reset_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset_cust.Location = New System.Drawing.Point(17, 396)
        Me.btn_reset_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_reset_cust.Name = "btn_reset_cust"
        Me.btn_reset_cust.Size = New System.Drawing.Size(89, 43)
        Me.btn_reset_cust.TabIndex = 276
        Me.btn_reset_cust.Text = "RESET"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(19, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 18)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Cari Berdasarkan"
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(22, 116)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(155, 62)
        Me.txt_search.TabIndex = 23
        '
        'btn_cari_cust
        '
        Me.btn_cari_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_cust.Appearance.Options.UseFont = True
        Me.btn_cari_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Search_16x16
        Me.btn_cari_cust.Location = New System.Drawing.Point(112, 396)
        Me.btn_cari_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cari_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cari_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cari_cust.Name = "btn_cari_cust"
        Me.btn_cari_cust.Size = New System.Drawing.Size(65, 43)
        Me.btn_cari_cust.TabIndex = 275
        Me.btn_cari_cust.Text = "CARI"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(19, 95)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 18)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Teks Pencarian"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chk_date)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.tglakhir)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.tglawal)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 185)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(160, 192)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter Tanggal"
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.Location = New System.Drawing.Point(16, 36)
        Me.chk_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(120, 22)
        Me.chk_date.TabIndex = 38
        Me.chk_date.Text = "Dengan Batasan"
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 18)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Sampai"
        '
        'tglakhir
        '
        Me.tglakhir.CustomFormat = "dd-MM-yyyy"
        Me.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglakhir.Location = New System.Drawing.Point(24, 149)
        Me.tglakhir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(111, 23)
        Me.tglakhir.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(21, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 18)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Dari"
        '
        'tglawal
        '
        Me.tglawal.CustomFormat = "dd-MM-yyyy"
        Me.tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglawal.Location = New System.Drawing.Point(24, 96)
        Me.tglawal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglawal.Name = "tglawal"
        Me.tglawal.Size = New System.Drawing.Size(111, 23)
        Me.tglawal.TabIndex = 34
        '
        'cbo_search
        '
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"Payment No", "Customer"})
        Me.cbo_search.Location = New System.Drawing.Point(22, 62)
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
        DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle46.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle46.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle46.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle46
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnopay, Me.colcust, Me.coldate, Me.colamount, Me.colpaid, Me.coldescript, Me.colcetak})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(782, 713)
        Me.DataGridView2.TabIndex = 0
        '
        'colnopay
        '
        Me.colnopay.HeaderText = "No Pembayaran"
        Me.colnopay.Name = "colnopay"
        Me.colnopay.ReadOnly = True
        Me.colnopay.Width = 175
        '
        'colcust
        '
        Me.colcust.HeaderText = "Pelanggan"
        Me.colcust.Name = "colcust"
        Me.colcust.ReadOnly = True
        Me.colcust.Width = 210
        '
        'coldate
        '
        Me.coldate.HeaderText = "Tanggal"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        Me.coldate.Width = 105
        '
        'colamount
        '
        DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colamount.DefaultCellStyle = DataGridViewCellStyle47
        Me.colamount.HeaderText = "Faktur"
        Me.colamount.Name = "colamount"
        Me.colamount.ReadOnly = True
        Me.colamount.Width = 115
        '
        'colpaid
        '
        DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colpaid.DefaultCellStyle = DataGridViewCellStyle48
        Me.colpaid.HeaderText = "Terbayar"
        Me.colpaid.Name = "colpaid"
        Me.colpaid.ReadOnly = True
        Me.colpaid.Width = 115
        '
        'coldescript
        '
        Me.coldescript.HeaderText = "Keterangan"
        Me.coldescript.Name = "coldescript"
        Me.coldescript.ReadOnly = True
        Me.coldescript.Width = 155
        '
        'colcetak
        '
        Me.colcetak.HeaderText = "Lihat Nota"
        Me.colcetak.Name = "colcetak"
        Me.colcetak.ReadOnly = True
        Me.colcetak.Text = "Cetak Bukti"
        Me.colcetak.UseColumnTextForButtonValue = True
        Me.colcetak.Width = 95
        '
        'GroupControl7
        '
        Me.GroupControl7.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl7.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl7.Appearance.Options.UseBackColor = True
        Me.GroupControl7.Appearance.Options.UseFont = True
        Me.GroupControl7.Appearance.Options.UseForeColor = True
        Me.GroupControl7.Controls.Add(Me.DataGridView2)
        Me.GroupControl7.Location = New System.Drawing.Point(213, 14)
        Me.GroupControl7.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(786, 736)
        Me.GroupControl7.TabIndex = 296
        Me.GroupControl7.Text = "DAFTAR PEMBAYARAN"
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(-32768, -32768)
        Me.TabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.TabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.TabInput
        Me.TabControl1.Size = New System.Drawing.Size(780, 658)
        Me.TabControl1.TabIndex = 80
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabInput, Me.TabList})
        Me.TabControl1.Visible = False
        '
        'TabInput
        '
        Me.TabInput.Controls.Add(Me.Panel2)
        Me.TabInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabInput.Name = "TabInput"
        Me.TabInput.Size = New System.Drawing.Size(778, 633)
        Me.TabInput.Text = "TAMBAH / UBAH PEMBAYARAN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 633)
        Me.Panel2.TabIndex = 0
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.Panel3)
        Me.TabList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabList.Name = "TabList"
        Me.TabList.Size = New System.Drawing.Size(1012, 769)
        Me.TabList.Text = "DAFTAR PEMBAYARAN"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.GroupControl7)
        Me.Panel3.Controls.Add(Me.GroupControl6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1012, 769)
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
        Me.PanelControl5.Location = New System.Drawing.Point(9, 615)
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
        Me.SimpleButton3.Size = New System.Drawing.Size(180, 37)
        Me.SimpleButton3.TabIndex = 293
        Me.SimpleButton3.Text = "TAMBAH PEMBAYARAN"
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Location = New System.Drawing.Point(9, 35)
        Me.GridControl.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl.MainView = Me.GridList_Customer
        Me.GridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(993, 578)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(5, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(259, 24)
        Me.Label7.TabIndex = 301
        Me.Label7.Text = "Daftar Pembayaran Piutang"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelControl3.Appearance.Options.UseFont = True
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.btn_cetak)
        Me.PanelControl3.Controls.Add(Me.GroupControl3)
        Me.PanelControl3.Controls.Add(Me.GroupControl5)
        Me.PanelControl3.Controls.Add(Me.GroupControl4)
        Me.PanelControl3.Controls.Add(Me.btn_keluar)
        Me.PanelControl3.Controls.Add(Me.btn_save2)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.btn_del2)
        Me.PanelControl3.Controls.Add(Me.btn_reset2)
        Me.PanelControl3.Controls.Add(Me.Label10)
        Me.PanelControl3.Location = New System.Drawing.Point(9, 32)
        Me.PanelControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(993, 612)
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
        Me.GroupControl3.Controls.Add(Me.Label25)
        Me.GroupControl3.Controls.Add(Me.txt_save_path)
        Me.GroupControl3.Location = New System.Drawing.Point(91, -217)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1156, 197)
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
        Me.btn_browse.Size = New System.Drawing.Size(403, 153)
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
        Me.txt_save_path.Size = New System.Drawing.Size(1142, 25)
        Me.txt_save_path.TabIndex = 277
        Me.txt_save_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmpayAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1014, 672)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.Label7)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmpayAR"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran Piutang"
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabInput.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
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
    Friend WithEvents cbo_supplier As System.Windows.Forms.ComboBox
    Friend WithEvents txt_billno As System.Windows.Forms.TextBox
    Friend WithEvents lb_idAccpayment As System.Windows.Forms.Label
    Friend WithEvents txt_comment As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_supplier_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_supplier_nm As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_payment As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_ap As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_return As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_disc As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_net As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tglakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tglawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chk_date As System.Windows.Forms.CheckBox
    Friend WithEvents cbo_acc As MTGCComboBox
    Friend WithEvents txt_curr As System.Windows.Forms.ComboBox
    Friend WithEvents CheckKurs As System.Windows.Forms.CheckBox
    Friend WithEvents colno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colinvoice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colreturn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colqty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpayment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colbayar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colkurs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnilai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcurr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnopay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcetak As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MtgcComboBox1 As MTGCComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbo_unit As MTGCComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btn_cetak As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reset2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_reset_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabInput As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_idsupplier As System.Windows.Forms.TextBox
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridList_Customer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_save_path As System.Windows.Forms.TextBox
End Class
