<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsetupcashflow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsetupcashflow))
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgbank = New System.Windows.Forms.DataGridView()
        Me.dgcash = New System.Windows.Forms.DataGridView()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnotes = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txt_acc_name = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgbank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgcash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(309, 19)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(118, 20)
        Me.DateTimePicker2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Date:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(96, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Warehouse:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Location = New System.Drawing.Point(8, 48)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Size = New System.Drawing.Size(930, 342)
        Me.DataGridView2.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Main Unit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Opname"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 240
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Pilih Akun"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Komponen Arus Kas"
        '
        'dgbank
        '
        Me.dgbank.AllowUserToAddRows = False
        Me.dgbank.AllowUserToDeleteRows = False
        Me.dgbank.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgbank.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgbank.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgbank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1})
        Me.dgbank.Location = New System.Drawing.Point(10, 312)
        Me.dgbank.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgbank.Name = "dgbank"
        Me.dgbank.Size = New System.Drawing.Size(1017, 335)
        Me.dgbank.TabIndex = 7
        '
        'dgcash
        '
        Me.dgcash.AllowUserToAddRows = False
        Me.dgcash.AllowUserToDeleteRows = False
        Me.dgcash.AllowUserToOrderColumns = True
        Me.dgcash.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgcash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgcash.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgcash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colid, Me.colnm, Me.colnotes})
        Me.dgcash.Location = New System.Drawing.Point(10, 44)
        Me.dgcash.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgcash.Name = "dgcash"
        Me.dgcash.Size = New System.Drawing.Size(1017, 237)
        Me.dgcash.TabIndex = 6
        '
        'colid
        '
        Me.colid.HeaderText = "ID Account"
        Me.colid.Name = "colid"
        Me.colid.ReadOnly = True
        Me.colid.Width = 120
        '
        'colnm
        '
        Me.colnm.HeaderText = "Account Name"
        Me.colnm.Name = "colnm"
        Me.colnm.ReadOnly = True
        Me.colnm.Width = 300
        '
        'colnotes
        '
        Me.colnotes.HeaderText = "Check"
        Me.colnotes.Name = "colnotes"
        Me.colnotes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colnotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colnotes.Visible = False
        Me.colnotes.Width = 55
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x161
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(937, 717)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 42)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Save"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_acc_name)
        Me.GroupBox1.Controls.Add(Me.btn_save2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgbank)
        Me.GroupBox1.Controls.Add(Me.dgcash)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 700)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(945, 654)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 40)
        Me.btn_save2.TabIndex = 22
        Me.btn_save2.Text = "SIMPAN"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "No Akun"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nama Akun"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 270
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Pilih"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 55
        '
        'txt_acc_name
        '
        Me.txt_acc_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_acc_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_acc_name.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acc_name.Location = New System.Drawing.Point(98, 286)
        Me.txt_acc_name.Name = "txt_acc_name"
        Me.txt_acc_name.Size = New System.Drawing.Size(929, 23)
        Me.txt_acc_name.TabIndex = 23
        '
        'frmsetupcashflow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1038, 700)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmsetupcashflow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash / Bank Registration"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgbank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgcash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgbank As System.Windows.Forms.DataGridView
    Friend WithEvents dgcash As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnotes As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txt_acc_name As System.Windows.Forms.TextBox
End Class
