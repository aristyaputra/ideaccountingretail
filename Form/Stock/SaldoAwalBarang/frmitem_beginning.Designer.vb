<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmitem_beginning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmitem_beginning))
        Me.cbo_warehouse = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colpersen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_cari_cust = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbo_warehouse
        '
        Me.cbo_warehouse.FormattingEnabled = True
        Me.cbo_warehouse.Location = New System.Drawing.Point(10, 44)
        Me.cbo_warehouse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_warehouse.Name = "cbo_warehouse"
        Me.cbo_warehouse.Size = New System.Drawing.Size(196, 26)
        Me.cbo_warehouse.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colid, Me.colnm, Me.colsales, Me.colpersen, Me.colprice, Me.colnotes})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(986, 441)
        Me.DataGridView1.TabIndex = 6
        '
        'colid
        '
        Me.colid.HeaderText = "Kode Barang"
        Me.colid.Name = "colid"
        Me.colid.Width = 140
        '
        'colnm
        '
        Me.colnm.HeaderText = "Nama Barang"
        Me.colnm.Name = "colnm"
        Me.colnm.Width = 200
        '
        'colsales
        '
        Me.colsales.HeaderText = "Unit"
        Me.colsales.Name = "colsales"
        '
        'colpersen
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colpersen.DefaultCellStyle = DataGridViewCellStyle2
        Me.colpersen.HeaderText = "Stok"
        Me.colpersen.Name = "colpersen"
        Me.colpersen.Width = 80
        '
        'colprice
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colprice.DefaultCellStyle = DataGridViewCellStyle3
        Me.colprice.HeaderText = "Harga"
        Me.colprice.Name = "colprice"
        Me.colprice.Width = 110
        '
        'colnotes
        '
        Me.colnotes.HeaderText = "Keterangan"
        Me.colnotes.Name = "colnotes"
        Me.colnotes.Width = 600
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-32768, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(889, 794)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Gold
        Me.Button3.Image = Global.SMARTACCOUNTING.My.Resources.Resources.information_button
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(913, 738)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 49)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Info"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.DimGray
        Me.btn_save.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Gold
        Me.btn_save.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x161
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(725, 811)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(81, 49)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "Simpan"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        Me.btn_save.Visible = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseForeColor = True
        Me.PanelControl2.Controls.Add(Me.btn_keluar)
        Me.PanelControl2.Controls.Add(Me.btn_save2)
        Me.PanelControl2.Controls.Add(Me.Button1)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 604)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(990, 58)
        Me.PanelControl2.TabIndex = 286
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(10, 8)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(82, 43)
        Me.btn_keluar.TabIndex = 20
        Me.btn_keluar.Text = "KELUAR"
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(900, 8)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 43)
        Me.btn_save2.TabIndex = 16
        Me.btn_save2.Text = "SIMPAN"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x161
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1012, -3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 49)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Simpan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.DataGridView1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 135)
        Me.GroupControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(990, 464)
        Me.GroupControl2.TabIndex = 285
        Me.GroupControl2.Text = "DATA BARANG"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.btn_cari_cust)
        Me.GroupControl1.Controls.Add(Me.txt_search)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.cbo_warehouse)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 33)
        Me.GroupControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(990, 97)
        Me.GroupControl1.TabIndex = 284
        Me.GroupControl1.Text = "FILTER DATA"
        '
        'btn_cari_cust
        '
        Me.btn_cari_cust.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cari_cust.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_cust.Appearance.Options.UseFont = True
        Me.btn_cari_cust.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Search_16x16
        Me.btn_cari_cust.Location = New System.Drawing.Point(919, 45)
        Me.btn_cari_cust.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cari_cust.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cari_cust.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_cari_cust.Name = "btn_cari_cust"
        Me.btn_cari_cust.Size = New System.Drawing.Size(66, 26)
        Me.btn_cari_cust.TabIndex = 287
        Me.btn_cari_cust.Text = "CARI"
        '
        'txt_search
        '
        Me.txt_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(212, 46)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(701, 23)
        Me.txt_search.TabIndex = 286
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 285
        Me.Label2.Text = "Cari Item"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 284
        Me.Label1.Text = "Pilih Gudang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 283
        Me.Label5.Text = "Up To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(8, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 24)
        Me.Label3.TabIndex = 291
        Me.Label3.Text = "Saldo Awal dan Harga Barang"
        '
        'frmitem_beginning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1014, 672)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmitem_beginning"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item - Saldo Awal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents colid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colpersen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_cari_cust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
