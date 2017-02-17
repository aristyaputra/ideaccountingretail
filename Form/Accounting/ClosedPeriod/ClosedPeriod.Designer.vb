<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClosedPeriod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClosedPeriod))
        Me.cbo_akun = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.period = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_date2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_date1 = New System.Windows.Forms.DateTimePicker()
        Me.chk_lock = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbo_akun
        '
        Me.cbo_akun.BackColor = System.Drawing.Color.White
        Me.cbo_akun.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_akun.ForeColor = System.Drawing.Color.Black
        Me.cbo_akun.FormattingEnabled = True
        Me.cbo_akun.Location = New System.Drawing.Point(12, 176)
        Me.cbo_akun.Name = "cbo_akun"
        Me.cbo_akun.Size = New System.Drawing.Size(326, 27)
        Me.cbo_akun.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Ikhtisar Laba - Rugi"
        '
        'period
        '
        Me.period.BackColor = System.Drawing.Color.WhiteSmoke
        Me.period.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight
        Me.period.CustomFormat = "MMMM-yyyyy"
        Me.period.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.period.ForeColor = System.Drawing.Color.Black
        Me.period.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.period.Location = New System.Drawing.Point(86, 12)
        Me.period.Name = "period"
        Me.period.Size = New System.Drawing.Size(252, 31)
        Me.period.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Periode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(196, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tanggal Selesai"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Tanggal Mulai"
        '
        'txt_date2
        '
        Me.txt_date2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_date2.CustomFormat = "dd-MMM-yyyy"
        Me.txt_date2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date2.ForeColor = System.Drawing.Color.Black
        Me.txt_date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date2.Location = New System.Drawing.Point(200, 91)
        Me.txt_date2.Name = "txt_date2"
        Me.txt_date2.Size = New System.Drawing.Size(138, 27)
        Me.txt_date2.TabIndex = 18
        '
        'txt_date1
        '
        Me.txt_date1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_date1.CustomFormat = "dd-MMM-yyyy"
        Me.txt_date1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date1.ForeColor = System.Drawing.Color.Black
        Me.txt_date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_date1.Location = New System.Drawing.Point(13, 91)
        Me.txt_date1.Name = "txt_date1"
        Me.txt_date1.Size = New System.Drawing.Size(138, 27)
        Me.txt_date1.TabIndex = 17
        '
        'chk_lock
        '
        Me.chk_lock.AutoSize = True
        Me.chk_lock.BackColor = System.Drawing.Color.Transparent
        Me.chk_lock.Checked = True
        Me.chk_lock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_lock.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_lock.ForeColor = System.Drawing.Color.Black
        Me.chk_lock.Location = New System.Drawing.Point(12, 129)
        Me.chk_lock.Name = "chk_lock"
        Me.chk_lock.Size = New System.Drawing.Size(128, 23)
        Me.chk_lock.TabIndex = 27
        Me.chk_lock.Text = "Kunci Transaksi"
        Me.chk_lock.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(161, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "s/d"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Refresh_16x16
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(-91, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 40)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Proses"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(328, 80)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Proses ini akan memproses rekapitulasi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "transaksi penjualan / pendapatan dan bia" & _
    "ya" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dengan menghitung laba - rugi sebagai " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hasil usaha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 264)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 85)
        Me.Panel1.TabIndex = 30
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_save2.Location = New System.Drawing.Point(12, 211)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 40)
        Me.btn_save2.TabIndex = 31
        Me.btn_save2.Text = "PROSES"
        '
        'ClosedPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(353, 349)
        Me.Controls.Add(Me.btn_save2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chk_lock)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbo_akun)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.period)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_date2)
        Me.Controls.Add(Me.txt_date1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClosedPeriod"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proses Periode Tutup Buku"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbo_akun As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents period As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_lock As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
End Class
