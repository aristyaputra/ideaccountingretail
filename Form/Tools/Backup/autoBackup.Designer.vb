<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class autoBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(autoBackup))
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnProsess = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProsess2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBackup2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_time = New System.Windows.Forms.DateTimePicker()
        Me.cbo_days = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.Lavender
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.Location = New System.Drawing.Point(32741, 117)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(156, 37)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "Pilih Direktori Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBackup.UseVisualStyleBackColor = False
        Me.btnBackup.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lavender
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 151)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(588, 23)
        Me.TextBox1.TabIndex = 1
        '
        'btnProsess
        '
        Me.btnProsess.BackColor = System.Drawing.Color.Lavender
        Me.btnProsess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProsess.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btnProsess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProsess.Location = New System.Drawing.Point(9344, 117)
        Me.btnProsess.Name = "btnProsess"
        Me.btnProsess.Size = New System.Drawing.Size(74, 37)
        Me.btnProsess.TabIndex = 2
        Me.btnProsess.Text = "Proses"
        Me.btnProsess.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProsess.UseVisualStyleBackColor = False
        Me.btnProsess.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, -38)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(406, 23)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(15, -50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pastikan user tidak ada yang memakai sistem agar backup" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "berjalan dengan sempurna" & _
    ""
        Me.Label1.Visible = False
        '
        'btnProsess2
        '
        Me.btnProsess2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProsess2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProsess2.Appearance.Options.UseFont = True
        Me.btnProsess2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btnProsess2.Location = New System.Drawing.Point(518, 180)
        Me.btnProsess2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btnProsess2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnProsess2.Name = "btnProsess2"
        Me.btnProsess2.Size = New System.Drawing.Size(82, 36)
        Me.btnProsess2.TabIndex = 285
        Me.btnProsess2.Text = "SIMPAN"
        '
        'btnBackup2
        '
        Me.btnBackup2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackup2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup2.Appearance.Options.UseFont = True
        Me.btnBackup2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btnBackup2.Location = New System.Drawing.Point(12, 180)
        Me.btnBackup2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btnBackup2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBackup2.Name = "btnBackup2"
        Me.btnBackup2.Size = New System.Drawing.Size(198, 36)
        Me.btnBackup2.TabIndex = 286
        Me.btnBackup2.Text = "PILIH DIREKTORI BACKUP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 287
        Me.Label2.Text = "Atur Waktu Backup"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(9, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 288
        Me.Label3.Text = "Setiap Hari"
        '
        'cbo_type
        '
        Me.cbo_type.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Items.AddRange(New Object() {"Harian", "Mingguan", "Bulanan"})
        Me.cbo_type.Location = New System.Drawing.Point(141, 9)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(459, 26)
        Me.cbo_type.TabIndex = 289
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(331, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 18)
        Me.Label4.TabIndex = 291
        Me.Label4.Text = "Setiap Jam"
        '
        'cbo_time
        '
        Me.cbo_time.CustomFormat = "hh:mm:ss"
        Me.cbo_time.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cbo_time.Location = New System.Drawing.Point(414, 43)
        Me.cbo_time.Name = "cbo_time"
        Me.cbo_time.Size = New System.Drawing.Size(186, 23)
        Me.cbo_time.TabIndex = 292
        '
        'cbo_days
        '
        Me.cbo_days.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_days.FormattingEnabled = True
        Me.cbo_days.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"})
        Me.cbo_days.Location = New System.Drawing.Point(141, 41)
        Me.cbo_days.Name = "cbo_days"
        Me.cbo_days.Size = New System.Drawing.Size(186, 26)
        Me.cbo_days.TabIndex = 293
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(9, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 294
        Me.Label5.Text = "Setiap Tanggal"
        '
        'cbo_tanggal
        '
        Me.cbo_tanggal.CustomFormat = "dd-MMM-yyyy"
        Me.cbo_tanggal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cbo_tanggal.Location = New System.Drawing.Point(141, 73)
        Me.cbo_tanggal.Name = "cbo_tanggal"
        Me.cbo_tanggal.Size = New System.Drawing.Size(459, 23)
        Me.cbo_tanggal.TabIndex = 295
        '
        'autoBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(609, 226)
        Me.Controls.Add(Me.cbo_tanggal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbo_days)
        Me.Controls.Add(Me.cbo_time)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbo_type)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBackup2)
        Me.Controls.Add(Me.btnProsess2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnProsess)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBackup)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "autoBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Option"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnProsess As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProsess2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBackup2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_days As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_tanggal As System.Windows.Forms.DateTimePicker
End Class
