<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcashregister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcashregister))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colnospend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_search = New MTGCComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tglakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tglawal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnospend, Me.coldate, Me.coldescript, Me.colin, Me.colout, Me.colbalance})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(796, 621)
        Me.DataGridView2.TabIndex = 17
        '
        'colnospend
        '
        Me.colnospend.HeaderText = "No Kas / Bank"
        Me.colnospend.Name = "colnospend"
        Me.colnospend.ReadOnly = True
        Me.colnospend.Width = 175
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
        Me.coldescript.Width = 180
        '
        'colin
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colin.DefaultCellStyle = DataGridViewCellStyle2
        Me.colin.HeaderText = "Masuk"
        Me.colin.Name = "colin"
        Me.colin.ReadOnly = True
        Me.colin.Width = 106
        '
        'colout
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colout.DefaultCellStyle = DataGridViewCellStyle3
        Me.colout.HeaderText = "Keluar"
        Me.colout.Name = "colout"
        Me.colout.ReadOnly = True
        Me.colout.Width = 106
        '
        'colbalance
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colbalance.DefaultCellStyle = DataGridViewCellStyle4
        Me.colbalance.HeaderText = "Saldo"
        Me.colbalance.Name = "colbalance"
        Me.colbalance.ReadOnly = True
        Me.colbalance.Width = 116
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(18, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nama Akun:"
        '
        'cbo_search
        '
        Me.cbo_search.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_search.ArrowColor = System.Drawing.Color.Black
        Me.cbo_search.BindedControl = CType(resources.GetObject("cbo_search.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_search.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_search.ColumnNum = 2
        Me.cbo_search.ColumnWidth = "110; 250"
        Me.cbo_search.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_search.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cbo_search.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cbo_search.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbo_search.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo_search.DisplayMember = "Text"
        Me.cbo_search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_search.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cbo_search.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbo_search.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_search.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_search.DropDownWidth = 380
        Me.cbo_search.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_search.GridLineHorizontal = True
        Me.cbo_search.GridLineVertical = True
        Me.cbo_search.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_search.HighlightBorderOnMouseEvents = True
        Me.cbo_search.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_search.Location = New System.Drawing.Point(21, 56)
        Me.cbo_search.ManagingFastMouseMoving = True
        Me.cbo_search.ManagingFastMouseMovingInterval = 30
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_search.SelectedItem = Nothing
        Me.cbo_search.SelectedValue = Nothing
        Me.cbo_search.Size = New System.Drawing.Size(150, 24)
        Me.cbo_search.TabIndex = 39
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 135)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(160, 179)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Tanggal"
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.Location = New System.Drawing.Point(13, 24)
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
        Me.Label11.Location = New System.Drawing.Point(13, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 18)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Sampai"
        '
        'tglakhir
        '
        Me.tglakhir.CustomFormat = "dd-MM-yyyy"
        Me.tglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglakhir.Location = New System.Drawing.Point(16, 131)
        Me.tglakhir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tglakhir.Name = "tglakhir"
        Me.tglakhir.Size = New System.Drawing.Size(111, 23)
        Me.tglakhir.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Dari"
        '
        'tglawal
        '
        Me.tglawal.CustomFormat = "dd-MM-yyyy"
        Me.tglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglawal.Location = New System.Drawing.Point(16, 78)
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
        Me.Label5.Location = New System.Drawing.Point(18, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Cari Akun"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.print
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(189, 698)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 44)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Cetak Kas/Bank Register"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.GroupControl7.Controls.Add(Me.cbo_search)
        Me.GroupControl7.Controls.Add(Me.btn_reset_cust)
        Me.GroupControl7.Controls.Add(Me.Label5)
        Me.GroupControl7.Controls.Add(Me.btn_cari_cust)
        Me.GroupControl7.Controls.Add(Me.Label1)
        Me.GroupControl7.Controls.Add(Me.GroupBox1)
        Me.GroupControl7.Location = New System.Drawing.Point(9, 5)
        Me.GroupControl7.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl7.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(194, 644)
        Me.GroupControl7.TabIndex = 302
        Me.GroupControl7.Text = "PANEL PENCARIAN"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(17, 375)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(90, 35)
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
        Me.btn_reset_cust.Location = New System.Drawing.Point(17, 330)
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
        Me.btn_cari_cust.Location = New System.Drawing.Point(99, 330)
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
        Me.GroupControl6.Location = New System.Drawing.Point(209, 5)
        Me.GroupControl6.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(800, 644)
        Me.GroupControl6.TabIndex = 303
        Me.GroupControl6.Text = "DAFTAR TRANSAKSI"
        '
        'frmcashregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1014, 662)
        Me.Controls.Add(Me.GroupControl6)
        Me.Controls.Add(Me.GroupControl7)
        Me.Controls.Add(Me.Button2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmcashregister"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kas / Bank Register"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tglakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tglawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chk_date As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbo_search As MTGCComboBox
    Friend WithEvents colnospend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescript As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colout As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colbalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_reset_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
End Class
