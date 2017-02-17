<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLapAkumDepr
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLapAkumDepr))
        Me.CRviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_period = New System.Windows.Forms.DateTimePicker()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.gb_filtertgl_purch = New System.Windows.Forms.GroupBox()
        Me.cbo_aset2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbo_aset1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.chk_filtertgl_purch = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gb_filtertgl_purch.SuspendLayout()
        CType(Me.cbo_aset2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_aset1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRviewer
        '
        Me.CRviewer.ActiveViewIndex = -1
        Me.CRviewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRviewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRviewer.DisplayGroupTree = False
        Me.CRviewer.Location = New System.Drawing.Point(0, 82)
        Me.CRviewer.Name = "CRviewer"
        Me.CRviewer.SelectionFormula = ""
        Me.CRviewer.Size = New System.Drawing.Size(883, 394)
        Me.CRviewer.TabIndex = 0
        Me.CRviewer.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Periode:"
        '
        'txt_period
        '
        Me.txt_period.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_period.CustomFormat = "MMM-yyyy"
        Me.txt_period.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_period.ForeColor = System.Drawing.Color.Black
        Me.txt_period.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_period.Location = New System.Drawing.Point(66, 5)
        Me.txt_period.Name = "txt_period"
        Me.txt_period.Size = New System.Drawing.Size(129, 23)
        Me.txt_period.TabIndex = 52
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.DimGray
        Me.btn_simpan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.Gold
        Me.btn_simpan.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(6, 34)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(189, 40)
        Me.btn_simpan.TabIndex = 53
        Me.btn_simpan.Text = "Lihat Lap. Penyusutan"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'gb_filtertgl_purch
        '
        Me.gb_filtertgl_purch.BackColor = System.Drawing.Color.Transparent
        Me.gb_filtertgl_purch.Controls.Add(Me.cbo_aset2)
        Me.gb_filtertgl_purch.Controls.Add(Me.cbo_aset1)
        Me.gb_filtertgl_purch.Controls.Add(Me.chk_filtertgl_purch)
        Me.gb_filtertgl_purch.Controls.Add(Me.Label8)
        Me.gb_filtertgl_purch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_filtertgl_purch.ForeColor = System.Drawing.Color.Black
        Me.gb_filtertgl_purch.Location = New System.Drawing.Point(203, 2)
        Me.gb_filtertgl_purch.Name = "gb_filtertgl_purch"
        Me.gb_filtertgl_purch.Size = New System.Drawing.Size(393, 72)
        Me.gb_filtertgl_purch.TabIndex = 56
        Me.gb_filtertgl_purch.TabStop = False
        Me.gb_filtertgl_purch.Text = "Filter Aset"
        '
        'cbo_aset2
        '
        Me.cbo_aset2.Location = New System.Drawing.Point(227, 42)
        Me.cbo_aset2.Name = "cbo_aset2"
        Me.cbo_aset2.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_aset2.Properties.Appearance.Options.UseFont = True
        Me.cbo_aset2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_aset2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_aset", "ID Aset", 67, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Aset", 42, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cbo_aset2.Properties.DisplayMember = "nama"
        Me.cbo_aset2.Properties.ValueMember = "id_aset"
        Me.cbo_aset2.Size = New System.Drawing.Size(160, 24)
        Me.cbo_aset2.TabIndex = 297
        '
        'cbo_aset1
        '
        Me.cbo_aset1.Location = New System.Drawing.Point(11, 42)
        Me.cbo_aset1.Name = "cbo_aset1"
        Me.cbo_aset1.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_aset1.Properties.Appearance.Options.UseFont = True
        Me.cbo_aset1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_aset1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_aset", "ID Aset", 67, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Aset", 42, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cbo_aset1.Properties.DisplayMember = "nama"
        Me.cbo_aset1.Properties.ValueMember = "id_aset"
        Me.cbo_aset1.Size = New System.Drawing.Size(160, 24)
        Me.cbo_aset1.TabIndex = 296
        '
        'chk_filtertgl_purch
        '
        Me.chk_filtertgl_purch.AutoSize = True
        Me.chk_filtertgl_purch.ForeColor = System.Drawing.Color.Black
        Me.chk_filtertgl_purch.Location = New System.Drawing.Point(11, 19)
        Me.chk_filtertgl_purch.Name = "chk_filtertgl_purch"
        Me.chk_filtertgl_purch.Size = New System.Drawing.Size(75, 22)
        Me.chk_filtertgl_purch.TabIndex = 59
        Me.chk_filtertgl_purch.Text = "Filter By"
        Me.chk_filtertgl_purch.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(173, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 18)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Sampai"
        '
        'FormLapAkumDepr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(883, 476)
        Me.Controls.Add(Me.gb_filtertgl_purch)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_period)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CRviewer)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLapAkumDepr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bukti Faktur Pembelian"
        Me.gb_filtertgl_purch.ResumeLayout(False)
        Me.gb_filtertgl_purch.PerformLayout()
        CType(Me.cbo_aset2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_aset1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private WithEvents CRviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_period As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents gb_filtertgl_purch As System.Windows.Forms.GroupBox
    Friend WithEvents chk_filtertgl_purch As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbo_aset1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbo_aset2 As DevExpress.XtraEditors.LookUpEdit
End Class
