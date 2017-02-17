<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsetmarketing
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsetmarketing))
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.dg_marketing = New System.Windows.Forms.DataGridView()
        Me.dg_employee = New System.Windows.Forms.DataGridView()
        Me.colkodejenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coljenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jabatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departemen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_proses = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_download_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.cbo_kota = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.MarketingControl = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_komisi = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.komisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dg_marketing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_employee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbo_kota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarketingControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MarketingControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_prev
        '
        Me.btn_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_prev.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prev.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Previous_24x24
        Me.btn_prev.Location = New System.Drawing.Point(575, 205)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(49, 34)
        Me.btn_prev.TabIndex = 265
        Me.btn_prev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_prev.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_next.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Next_24x24
        Me.btn_next.Location = New System.Drawing.Point(575, 165)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(49, 34)
        Me.btn_next.TabIndex = 264
        Me.btn_next.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'dg_marketing
        '
        Me.dg_marketing.AllowUserToAddRows = False
        Me.dg_marketing.AllowUserToDeleteRows = False
        Me.dg_marketing.AllowUserToOrderColumns = True
        Me.dg_marketing.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_marketing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_marketing.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_marketing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_marketing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Kota, Me.komisi})
        Me.dg_marketing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_marketing.Location = New System.Drawing.Point(2, 21)
        Me.dg_marketing.Name = "dg_marketing"
        Me.dg_marketing.ReadOnly = True
        Me.dg_marketing.RowHeadersVisible = False
        Me.dg_marketing.Size = New System.Drawing.Size(372, 581)
        Me.dg_marketing.TabIndex = 9
        '
        'dg_employee
        '
        Me.dg_employee.AllowUserToAddRows = False
        Me.dg_employee.AllowUserToDeleteRows = False
        Me.dg_employee.AllowUserToOrderColumns = True
        Me.dg_employee.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_employee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_employee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colkodejenis, Me.coljenis, Me.jabatan, Me.Departemen})
        Me.dg_employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_employee.Location = New System.Drawing.Point(2, 21)
        Me.dg_employee.Name = "dg_employee"
        Me.dg_employee.ReadOnly = True
        Me.dg_employee.RowHeadersVisible = False
        Me.dg_employee.Size = New System.Drawing.Size(552, 581)
        Me.dg_employee.TabIndex = 9
        '
        'colkodejenis
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colkodejenis.DefaultCellStyle = DataGridViewCellStyle5
        Me.colkodejenis.HeaderText = "Kode"
        Me.colkodejenis.Name = "colkodejenis"
        Me.colkodejenis.ReadOnly = True
        Me.colkodejenis.Width = 125
        '
        'coljenis
        '
        Me.coljenis.HeaderText = "Nama"
        Me.coljenis.Name = "coljenis"
        Me.coljenis.ReadOnly = True
        Me.coljenis.Width = 240
        '
        'jabatan
        '
        Me.jabatan.HeaderText = "Jabatan"
        Me.jabatan.Name = "jabatan"
        Me.jabatan.ReadOnly = True
        Me.jabatan.Width = 160
        '
        'Departemen
        '
        Me.Departemen.HeaderText = "Departemen"
        Me.Departemen.Name = "Departemen"
        Me.Departemen.ReadOnly = True
        Me.Departemen.Width = 125
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Appearance.Options.UseFont = True
        Me.GroupControl3.Appearance.Options.UseForeColor = True
        Me.GroupControl3.Controls.Add(Me.dg_employee)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 6)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(556, 604)
        Me.GroupControl3.TabIndex = 283
        Me.GroupControl3.Text = "DAFTAR KARYAWAN"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MarketingControl)
        Me.Panel2.Controls.Add(Me.btn_keluar)
        Me.Panel2.Controls.Add(Me.btn_prev)
        Me.Panel2.Controls.Add(Me.GroupControl1)
        Me.Panel2.Controls.Add(Me.btn_next)
        Me.Panel2.Controls.Add(Me.GroupControl3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1018, 672)
        Me.Panel2.TabIndex = 284
        '
        'btn_keluar
        '
        Me.btn_keluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(917, 619)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(87, 36)
        Me.btn_keluar.TabIndex = 286
        Me.btn_keluar.Text = "TUTUP"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Appearance.Options.UseFont = True
        Me.GroupControl1.Appearance.Options.UseForeColor = True
        Me.GroupControl1.Controls.Add(Me.dg_marketing)
        Me.GroupControl1.Location = New System.Drawing.Point(630, 6)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(376, 604)
        Me.GroupControl1.TabIndex = 285
        Me.GroupControl1.Text = "DAFTAR MARKETING"
        '
        'btn_proses
        '
        Me.btn_proses.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proses.Appearance.Options.UseFont = True
        Me.btn_proses.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_proses.Location = New System.Drawing.Point(330, 159)
        Me.btn_proses.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_proses.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_proses.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(84, 30)
        Me.btn_proses.TabIndex = 289
        Me.btn_proses.Text = "Proses"
        '
        'btn_download_cust
        '
        Me.btn_download_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_download_cust.Appearance.Options.UseFont = True
        Me.btn_download_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.excel_icon
        Me.btn_download_cust.Location = New System.Drawing.Point(297, 651)
        Me.btn_download_cust.LookAndFeel.SkinName = "Metropolis"
        Me.btn_download_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_download_cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_download_cust.Name = "btn_download_cust"
        Me.btn_download_cust.Size = New System.Drawing.Size(292, 50)
        Me.btn_download_cust.TabIndex = 290
        Me.btn_download_cust.Text = "Download Template Excel (.xlsx)"
        Me.btn_download_cust.Visible = False
        '
        'cbo_kota
        '
        Me.cbo_kota.Location = New System.Drawing.Point(14, 72)
        Me.cbo_kota.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_kota.Name = "cbo_kota"
        Me.cbo_kota.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbo_kota.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_kota.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.cbo_kota.Properties.Appearance.Options.UseBackColor = True
        Me.cbo_kota.Properties.Appearance.Options.UseFont = True
        Me.cbo_kota.Properties.Appearance.Options.UseForeColor = True
        Me.cbo_kota.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_kota.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cbo_kota.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_kota.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbo_kota.Properties.AppearanceFocused.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_kota.Properties.AppearanceFocused.Options.UseFont = True
        Me.cbo_kota.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_kota.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbo_kota.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_kota.Properties.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cbo_kota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cbo_kota.Properties.View = Me.GridView3
        Me.cbo_kota.Size = New System.Drawing.Size(400, 24)
        Me.cbo_kota.TabIndex = 303
        Me.cbo_kota.Visible = False
        '
        'GridView3
        '
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Appearance.ViewCaption.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowColumnMoving = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.RowAutoHeight = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.PaintStyleName = "Skin"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(11, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(110, 18)
        Me.Label26.TabIndex = 304
        Me.Label26.Text = "Kota Penempatan"
        '
        'MarketingControl
        '
        Me.MarketingControl.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarketingControl.Appearance.Options.UseFont = True
        Me.MarketingControl.AppearanceCaption.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarketingControl.AppearanceCaption.Options.UseFont = True
        Me.MarketingControl.Controls.Add(Me.txt_komisi)
        Me.MarketingControl.Controls.Add(Me.Label1)
        Me.MarketingControl.Controls.Add(Me.Label26)
        Me.MarketingControl.Controls.Add(Me.cbo_kota)
        Me.MarketingControl.Controls.Add(Me.btn_download_cust)
        Me.MarketingControl.Controls.Add(Me.btn_proses)
        Me.MarketingControl.Location = New System.Drawing.Point(119, 58)
        Me.MarketingControl.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.MarketingControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MarketingControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MarketingControl.Name = "MarketingControl"
        Me.MarketingControl.Size = New System.Drawing.Size(430, 204)
        Me.MarketingControl.TabIndex = 288
        Me.MarketingControl.Text = "SETUP KOMISI DAN BASE KOTA"
        Me.MarketingControl.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 18)
        Me.Label1.TabIndex = 305
        Me.Label1.Text = "Prosentase Komisi dari Penjualan"
        '
        'txt_komisi
        '
        Me.txt_komisi.BackColor = System.Drawing.Color.White
        Me.txt_komisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_komisi.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_komisi.ForeColor = System.Drawing.Color.Black
        Me.txt_komisi.Location = New System.Drawing.Point(14, 124)
        Me.txt_komisi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_komisi.Name = "txt_komisi"
        Me.txt_komisi.Size = New System.Drawing.Size(400, 23)
        Me.txt_komisi.TabIndex = 306
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 220
        '
        'Kota
        '
        Me.Kota.HeaderText = "Kota"
        Me.Kota.Name = "Kota"
        Me.Kota.ReadOnly = True
        Me.Kota.Width = 120
        '
        'komisi
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.komisi.DefaultCellStyle = DataGridViewCellStyle3
        Me.komisi.HeaderText = "% Komisi"
        Me.komisi.Name = "komisi"
        Me.komisi.ReadOnly = True
        Me.komisi.Width = 80
        '
        'frmsetmarketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1018, 672)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmsetmarketing"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Marketing"
        CType(Me.dg_marketing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_employee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.cbo_kota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarketingControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MarketingControl.ResumeLayout(False)
        Me.MarketingControl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_marketing As System.Windows.Forms.DataGridView
    Friend WithEvents dg_employee As System.Windows.Forms.DataGridView
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_prev As System.Windows.Forms.Button
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents colkodejenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coljenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jabatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Departemen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MarketingControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cbo_kota As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_download_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_proses As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_komisi As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents komisi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
