<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsetcoa_aset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsetcoa_aset))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.aset = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.akun2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.akun3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.aset, Me.Column1, Me.Column4, Me.Column2, Me.akun2, Me.akun3})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.Size = New System.Drawing.Size(958, 423)
        Me.DataGridView1.TabIndex = 0
        '
        'aset
        '
        Me.aset.HeaderText = "Kode Aset"
        Me.aset.Name = "aset"
        Me.aset.ReadOnly = True
        Me.aset.Width = 130
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama Aset"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Golongan"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "No Akun Aset"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'akun2
        '
        Me.akun2.HeaderText = "No Akun Penyusutan"
        Me.akun2.Name = "akun2"
        Me.akun2.ReadOnly = True
        Me.akun2.Width = 130
        '
        'akun3
        '
        Me.akun3.HeaderText = "No Akun Akumulasi"
        Me.akun3.Name = "akun3"
        Me.akun3.ReadOnly = True
        Me.akun3.Width = 130
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Refresh_16x16
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(906, 504)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Update"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(885, 435)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 40)
        Me.btn_save2.TabIndex = 22
        Me.btn_save2.Text = "SIMPAN"
        '
        'btn_keluar
        '
        Me.btn_keluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(797, 435)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(82, 40)
        Me.btn_keluar.TabIndex = 23
        Me.btn_keluar.Text = "KELUAR"
        '
        'frmsetcoa_aset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(975, 485)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_save2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmsetcoa_aset"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Integrasi Akun Aset"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents aset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents akun2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents akun3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
End Class
