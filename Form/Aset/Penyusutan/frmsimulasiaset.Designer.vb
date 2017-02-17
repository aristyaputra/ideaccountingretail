<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsimulasiaset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsimulasiaset))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dasd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_nm_aset = New System.Windows.Forms.Label()
        Me.lbl_golongan = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.dasd, Me.Column5, Me.Column6})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(8, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.Size = New System.Drawing.Size(912, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Harga Perolehan"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Masa Manfaat"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 90
        '
        'Column3
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Rate Penyusutan"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 90
        '
        'Column4
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.HeaderText = "Masa Penyusutan"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 90
        '
        'dasd
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dasd.DefaultCellStyle = DataGridViewCellStyle6
        Me.dasd.HeaderText = "Penyusutan Per Th"
        Me.dasd.Name = "dasd"
        Me.dasd.Width = 150
        '
        'Column5
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column5.HeaderText = "Akumulasi"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column6.HeaderText = "Nilai Buku"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Simulasi aset ini menggunakan methode garis lurus"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Nama Aset:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Golongan  :"
        '
        'lbl_nm_aset
        '
        Me.lbl_nm_aset.AutoSize = True
        Me.lbl_nm_aset.Location = New System.Drawing.Point(100, 9)
        Me.lbl_nm_aset.Name = "lbl_nm_aset"
        Me.lbl_nm_aset.Size = New System.Drawing.Size(71, 18)
        Me.lbl_nm_aset.TabIndex = 53
        Me.lbl_nm_aset.Text = "Nama Aset"
        '
        'lbl_golongan
        '
        Me.lbl_golongan.AutoSize = True
        Me.lbl_golongan.Location = New System.Drawing.Point(100, 39)
        Me.lbl_golongan.Name = "lbl_golongan"
        Me.lbl_golongan.Size = New System.Drawing.Size(71, 18)
        Me.lbl_golongan.TabIndex = 54
        Me.lbl_golongan.Text = "Nama Aset"
        '
        'btn_simpan
        '
        Me.btn_simpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_simpan.BackColor = System.Drawing.Color.DimGray
        Me.btn_simpan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.Gold
        Me.btn_simpan.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(767, 351)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(157, 41)
        Me.btn_simpan.TabIndex = 50
        Me.btn_simpan.Text = "Koreksi Penyusutan"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'frmsimulasiaset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(932, 398)
        Me.Controls.Add(Me.lbl_golongan)
        Me.Controls.Add(Me.lbl_nm_aset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmsimulasiaset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulasi Aset"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dasd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_nm_aset As System.Windows.Forms.Label
    Friend WithEvents lbl_golongan As System.Windows.Forms.Label
End Class
