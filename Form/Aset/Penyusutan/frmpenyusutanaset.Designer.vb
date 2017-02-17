<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpenyusutanaset
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpenyusutanaset))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dasd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_depr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pilih = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txt_period = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_chk_all = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_chk_all2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_clear2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_simpan2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.dasd, Me.col_depr, Me.Column5, Me.Column6, Me.Pilih})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.Size = New System.Drawing.Size(912, 293)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Kode Aset"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 140
        '
        'Column2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Nama"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 220
        '
        'Column3
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Departemen"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 160
        '
        'Column4
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.HeaderText = "Golongan"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 130
        '
        'dasd
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dasd.DefaultCellStyle = DataGridViewCellStyle6
        Me.dasd.HeaderText = "Rate(%)"
        Me.dasd.Name = "dasd"
        Me.dasd.Width = 55
        '
        'col_depr
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col_depr.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_depr.HeaderText = "Penyusutan"
        Me.col_depr.Name = "col_depr"
        Me.col_depr.Width = 140
        '
        'Column5
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column5.HeaderText = "acc_depr"
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        Me.Column5.Width = 150
        '
        'Column6
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column6.HeaderText = "acc_akum"
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        Me.Column6.Width = 150
        '
        'Pilih
        '
        Me.Pilih.HeaderText = "Pilih"
        Me.Pilih.Name = "Pilih"
        Me.Pilih.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Pilih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Pilih.Width = 35
        '
        'txt_period
        '
        Me.txt_period.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_period.CustomFormat = "MMM-yyyy"
        Me.txt_period.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_period.ForeColor = System.Drawing.Color.Black
        Me.txt_period.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_period.Location = New System.Drawing.Point(74, 12)
        Me.txt_period.Name = "txt_period"
        Me.txt_period.Size = New System.Drawing.Size(129, 23)
        Me.txt_period.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Periode"
        '
        'btn_simpan
        '
        Me.btn_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_simpan.BackColor = System.Drawing.Color.DimGray
        Me.btn_simpan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.Gold
        Me.btn_simpan.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(32741, 351)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(157, 39)
        Me.btn_simpan.TabIndex = 50
        Me.btn_simpan.Text = "Proses Penyusutan"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_simpan.UseVisualStyleBackColor = False
        Me.btn_simpan.Visible = False
        '
        'btn_chk_all
        '
        Me.btn_chk_all.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_chk_all.BackColor = System.Drawing.Color.DimGray
        Me.btn_chk_all.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_chk_all.ForeColor = System.Drawing.Color.Gold
        Me.btn_chk_all.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_chk_all.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_chk_all.Location = New System.Drawing.Point(32741, 351)
        Me.btn_chk_all.Name = "btn_chk_all"
        Me.btn_chk_all.Size = New System.Drawing.Size(90, 39)
        Me.btn_chk_all.TabIndex = 53
        Me.btn_chk_all.Text = "Check All"
        Me.btn_chk_all.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_chk_all.UseVisualStyleBackColor = False
        Me.btn_chk_all.Visible = False
        '
        'btn_clear
        '
        Me.btn_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear.BackColor = System.Drawing.Color.DimGray
        Me.btn_clear.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Gold
        Me.btn_clear.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Properties_16x16
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(32741, 351)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(113, 39)
        Me.btn_clear.TabIndex = 54
        Me.btn_clear.Text = "Clear Check"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = False
        Me.btn_clear.Visible = False
        '
        'btn_keluar
        '
        Me.btn_keluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(8, 351)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(97, 36)
        Me.btn_keluar.TabIndex = 55
        Me.btn_keluar.Text = "KELUAR"
        '
        'btn_chk_all2
        '
        Me.btn_chk_all2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_chk_all2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_chk_all2.Appearance.Options.UseFont = True
        Me.btn_chk_all2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_chk_all2.Location = New System.Drawing.Point(496, 351)
        Me.btn_chk_all2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_chk_all2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_chk_all2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_chk_all2.Name = "btn_chk_all2"
        Me.btn_chk_all2.Size = New System.Drawing.Size(109, 36)
        Me.btn_chk_all2.TabIndex = 288
        Me.btn_chk_all2.Text = "Pilih Semua"
        '
        'btn_clear2
        '
        Me.btn_clear2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear2.Appearance.Options.UseFont = True
        Me.btn_clear2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Properties_16x16
        Me.btn_clear2.Location = New System.Drawing.Point(611, 351)
        Me.btn_clear2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_clear2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_clear2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_clear2.Name = "btn_clear2"
        Me.btn_clear2.Size = New System.Drawing.Size(142, 36)
        Me.btn_clear2.TabIndex = 289
        Me.btn_clear2.Text = "Bersihkan Pilihan"
        '
        'btn_simpan2
        '
        Me.btn_simpan2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_simpan2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan2.Appearance.Options.UseFont = True
        Me.btn_simpan2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Send_16x16
        Me.btn_simpan2.Location = New System.Drawing.Point(759, 351)
        Me.btn_simpan2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_simpan2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_simpan2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_simpan2.Name = "btn_simpan2"
        Me.btn_simpan2.Size = New System.Drawing.Size(161, 36)
        Me.btn_simpan2.TabIndex = 290
        Me.btn_simpan2.Text = "Proses Penyusutan"
        '
        'frmpenyusutanaset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(932, 398)
        Me.Controls.Add(Me.btn_chk_all2)
        Me.Controls.Add(Me.btn_clear2)
        Me.Controls.Add(Me.btn_simpan2)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_chk_all)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_period)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmpenyusutanaset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penyusutan Aset"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents txt_period As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_chk_all As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dasd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_depr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pilih As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_chk_all2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_clear2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_simpan2 As DevExpress.XtraEditors.SimpleButton
End Class
