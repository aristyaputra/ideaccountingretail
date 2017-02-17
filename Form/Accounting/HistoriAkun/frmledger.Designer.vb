<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmledger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmledger))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colnojournal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tglakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tglawal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.lbl_acc_nm = New System.Windows.Forms.Label()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reset_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cari_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnojournal, Me.coldate, Me.coldescript, Me.coldb, Me.colcr, Me.colbalance})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(785, 621)
        Me.DataGridView2.TabIndex = 28
        '
        'colnojournal
        '
        Me.colnojournal.HeaderText = "No Transaksi"
        Me.colnojournal.Name = "colnojournal"
        Me.colnojournal.ReadOnly = True
        Me.colnojournal.Width = 165
        '
        'coldate
        '
        Me.coldate.HeaderText = "Tanggal"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        '
        'coldescript
        '
        Me.coldescript.HeaderText = "Keterangan"
        Me.coldescript.Name = "coldescript"
        Me.coldescript.ReadOnly = True
        Me.coldescript.Width = 160
        '
        'coldb
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.coldb.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldb.HeaderText = "Debet"
        Me.coldb.Name = "coldb"
        Me.coldb.ReadOnly = True
        Me.coldb.Width = 112
        '
        'colcr
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colcr.DefaultCellStyle = DataGridViewCellStyle3
        Me.colcr.HeaderText = "Kredit"
        Me.colcr.Name = "colcr"
        Me.colcr.ReadOnly = True
        Me.colcr.Width = 112
        '
        'colbalance
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colbalance.DefaultCellStyle = DataGridViewCellStyle4
        Me.colbalance.HeaderText = "Saldo"
        Me.colbalance.Name = "colbalance"
        Me.colbalance.ReadOnly = True
        Me.colbalance.Width = 128
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chk_date)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tglakhir)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tglawal)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(16, 137)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(160, 174)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Tanggal"
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.ForeColor = System.Drawing.Color.Black
        Me.chk_date.Location = New System.Drawing.Point(15, 24)
        Me.chk_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(125, 22)
        Me.chk_date.TabIndex = 38
        Me.chk_date.Text = "Rentang Tanggal"
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(18, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 18)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Sampai"
        '
        'tglakhir
        '
        Me.tglakhir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tglakhir.CustomFormat = "dd-MM-yyyy"
        Me.tglakhir.ForeColor = System.Drawing.Color.Black
        Me.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglakhir.Location = New System.Drawing.Point(21, 128)
        Me.tglakhir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(111, 23)
        Me.tglakhir.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(18, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Dari"
        '
        'tglawal
        '
        Me.tglawal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tglawal.CustomFormat = "dd-MM-yyyy"
        Me.tglawal.ForeColor = System.Drawing.Color.Black
        Me.tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglawal.Location = New System.Drawing.Point(21, 75)
        Me.tglawal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglawal.Name = "tglawal"
        Me.tglawal.Size = New System.Drawing.Size(111, 23)
        Me.tglawal.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Cari Akun"
        '
        'cbo_search
        '
        Me.cbo_search.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbo_search.BackColor = System.Drawing.Color.White
        Me.cbo_search.ForeColor = System.Drawing.Color.Black
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"No Akun"})
        Me.cbo_search.Location = New System.Drawing.Point(17, 58)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(154, 26)
        Me.cbo_search.TabIndex = 19
        '
        'lbl_acc_nm
        '
        Me.lbl_acc_nm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_acc_nm.AutoSize = True
        Me.lbl_acc_nm.BackColor = System.Drawing.Color.Transparent
        Me.lbl_acc_nm.ForeColor = System.Drawing.Color.Black
        Me.lbl_acc_nm.Location = New System.Drawing.Point(18, 89)
        Me.lbl_acc_nm.Name = "lbl_acc_nm"
        Me.lbl_acc_nm.Size = New System.Drawing.Size(79, 18)
        Me.lbl_acc_nm.TabIndex = 20
        Me.lbl_acc_nm.Text = "Nama Akun:"
        '
        'GroupControl7
        '
        Me.GroupControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl7.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl7.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl7.Appearance.Options.UseBackColor = True
        Me.GroupControl7.Appearance.Options.UseFont = True
        Me.GroupControl7.Appearance.Options.UseForeColor = True
        Me.GroupControl7.Controls.Add(Me.btn_keluar)
        Me.GroupControl7.Controls.Add(Me.btn_reset_cust)
        Me.GroupControl7.Controls.Add(Me.Label5)
        Me.GroupControl7.Controls.Add(Me.cbo_search)
        Me.GroupControl7.Controls.Add(Me.btn_cari_cust)
        Me.GroupControl7.Controls.Add(Me.lbl_acc_nm)
        Me.GroupControl7.Controls.Add(Me.GroupBox1)
        Me.GroupControl7.Location = New System.Drawing.Point(12, 6)
        Me.GroupControl7.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(194, 644)
        Me.GroupControl7.TabIndex = 300
        Me.GroupControl7.Text = "PANEL PENCARIAN"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(16, 368)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(89, 35)
        Me.btn_keluar.TabIndex = 277
        Me.btn_keluar.Text = "KELUAR"
        '
        'btn_reset_cust
        '
        Me.btn_reset_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_cust.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_reset_cust.Appearance.Options.UseFont = True
        Me.btn_reset_cust.Appearance.Options.UseForeColor = True
        Me.btn_reset_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset_cust.Location = New System.Drawing.Point(17, 323)
        Me.btn_reset_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset_cust.Name = "btn_reset_cust"
        Me.btn_reset_cust.Size = New System.Drawing.Size(76, 36)
        Me.btn_reset_cust.TabIndex = 276
        Me.btn_reset_cust.Text = "RESET"
        '
        'btn_cari_cust
        '
        Me.btn_cari_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_cust.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cari_cust.Appearance.Options.UseFont = True
        Me.btn_cari_cust.Appearance.Options.UseForeColor = True
        Me.btn_cari_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Search_16x16
        Me.btn_cari_cust.Location = New System.Drawing.Point(99, 323)
        Me.btn_cari_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cari_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cari_cust.Name = "btn_cari_cust"
        Me.btn_cari_cust.Size = New System.Drawing.Size(78, 36)
        Me.btn_cari_cust.TabIndex = 275
        Me.btn_cari_cust.Text = "CARI"
        '
        'GroupControl6
        '
        Me.GroupControl6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl6.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl6.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl6.Appearance.Options.UseBackColor = True
        Me.GroupControl6.Appearance.Options.UseFont = True
        Me.GroupControl6.Appearance.Options.UseForeColor = True
        Me.GroupControl6.Controls.Add(Me.DataGridView2)
        Me.GroupControl6.Location = New System.Drawing.Point(213, 6)
        Me.GroupControl6.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(789, 644)
        Me.GroupControl6.TabIndex = 301
        Me.GroupControl6.Text = "DAFTAR TRANSAKSI"
        '
        'frmledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1014, 662)
        Me.Controls.Add(Me.GroupControl6)
        Me.Controls.Add(Me.GroupControl7)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmledger"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buku Besar (Detail Transaksi Akun)"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tglakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tglawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_acc_nm As System.Windows.Forms.Label
    Friend WithEvents chk_date As System.Windows.Forms.CheckBox
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_reset_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents colnojournal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colbalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
End Class
