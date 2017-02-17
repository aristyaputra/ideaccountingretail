<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_set_init
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_set_init))
        Me.chk_setup_def_acc = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.period = New System.Windows.Forms.DateTimePicker()
        Me.years = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rb_int = New System.Windows.Forms.RadioButton()
        Me.rb_id = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_int2 = New System.Windows.Forms.RadioButton()
        Me.rb_id2 = New System.Windows.Forms.RadioButton()
        Me.chk_setup_def_curr = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk_setup_def_acc
        '
        Me.chk_setup_def_acc.AutoSize = True
        Me.chk_setup_def_acc.Checked = True
        Me.chk_setup_def_acc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_setup_def_acc.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_setup_def_acc.ForeColor = System.Drawing.Color.Gold
        Me.chk_setup_def_acc.Location = New System.Drawing.Point(16, 22)
        Me.chk_setup_def_acc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chk_setup_def_acc.Name = "chk_setup_def_acc"
        Me.chk_setup_def_acc.Size = New System.Drawing.Size(103, 24)
        Me.chk_setup_def_acc.TabIndex = 0
        Me.chk_setup_def_acc.Text = "Setup Akun"
        Me.chk_setup_def_acc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Periode Akuntansi"
        '
        'period
        '
        Me.period.CustomFormat = "MMMM"
        Me.period.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.period.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.period.Location = New System.Drawing.Point(232, 24)
        Me.period.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.period.Name = "period"
        Me.period.Size = New System.Drawing.Size(191, 25)
        Me.period.TabIndex = 2
        '
        'years
        '
        Me.years.CustomFormat = "yyyy"
        Me.years.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.years.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.years.Location = New System.Drawing.Point(431, 24)
        Me.years.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.years.Name = "years"
        Me.years.Size = New System.Drawing.Size(108, 25)
        Me.years.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(18, 361)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(510, 40)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = """Akun harus di setting berdasarkan jenis perusahaan yang diregistrasi dan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bahas" & _
    "a bisnis dan mata uang yang akan digunakan oleh perusahaan"""
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(477, 420)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 45)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "SETUP"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.rb_int)
        Me.GroupBox1.Controls.Add(Me.rb_id)
        Me.GroupBox1.Controls.Add(Me.chk_setup_def_acc)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Location = New System.Drawing.Point(25, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 186)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setup Akun Default"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(16, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 60)
        Me.Panel1.TabIndex = 3
        Me.Panel1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "11101"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "1-1101"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(169, 7)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(138, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Tanpa Separator"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 7)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(146, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Dengan Separator"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rb_int
        '
        Me.rb_int.AutoSize = True
        Me.rb_int.Location = New System.Drawing.Point(128, 57)
        Me.rb_int.Name = "rb_int"
        Me.rb_int.Size = New System.Drawing.Size(112, 24)
        Me.rb_int.TabIndex = 2
        Me.rb_int.Text = "International"
        Me.rb_int.UseVisualStyleBackColor = True
        '
        'rb_id
        '
        Me.rb_id.AutoSize = True
        Me.rb_id.Checked = True
        Me.rb_id.Location = New System.Drawing.Point(16, 57)
        Me.rb_id.Name = "rb_id"
        Me.rb_id.Size = New System.Drawing.Size(89, 24)
        Me.rb_id.TabIndex = 1
        Me.rb_id.TabStop = True
        Me.rb_id.Text = "Indonesia"
        Me.rb_id.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_int2)
        Me.GroupBox2.Controls.Add(Me.rb_id2)
        Me.GroupBox2.Controls.Add(Me.chk_setup_def_curr)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.SandyBrown
        Me.GroupBox2.Location = New System.Drawing.Point(25, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 105)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Setup Mata Uang Default"
        '
        'rb_int2
        '
        Me.rb_int2.AutoSize = True
        Me.rb_int2.Location = New System.Drawing.Point(128, 57)
        Me.rb_int2.Name = "rb_int2"
        Me.rb_int2.Size = New System.Drawing.Size(112, 24)
        Me.rb_int2.TabIndex = 2
        Me.rb_int2.Text = "International"
        Me.rb_int2.UseVisualStyleBackColor = True
        '
        'rb_id2
        '
        Me.rb_id2.AutoSize = True
        Me.rb_id2.Checked = True
        Me.rb_id2.Location = New System.Drawing.Point(16, 57)
        Me.rb_id2.Name = "rb_id2"
        Me.rb_id2.Size = New System.Drawing.Size(89, 24)
        Me.rb_id2.TabIndex = 1
        Me.rb_id2.TabStop = True
        Me.rb_id2.Text = "Indonesia"
        Me.rb_id2.UseVisualStyleBackColor = True
        '
        'chk_setup_def_curr
        '
        Me.chk_setup_def_curr.AutoSize = True
        Me.chk_setup_def_curr.Checked = True
        Me.chk_setup_def_curr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_setup_def_curr.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_setup_def_curr.ForeColor = System.Drawing.Color.Gold
        Me.chk_setup_def_curr.Location = New System.Drawing.Point(16, 22)
        Me.chk_setup_def_curr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chk_setup_def_curr.Name = "chk_setup_def_curr"
        Me.chk_setup_def_curr.Size = New System.Drawing.Size(142, 24)
        Me.chk_setup_def_curr.TabIndex = 0
        Me.chk_setup_def_curr.Text = "Setup Mata Uang"
        Me.chk_setup_def_curr.UseVisualStyleBackColor = True
        '
        'frm_set_init
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(568, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.years)
        Me.Controls.Add(Me.period)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_set_init"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Initialisasi Periode Akuntansi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_setup_def_acc As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents period As System.Windows.Forms.DateTimePicker
    Friend WithEvents years As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_int As System.Windows.Forms.RadioButton
    Friend WithEvents rb_id As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_int2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_id2 As System.Windows.Forms.RadioButton
    Friend WithEvents chk_setup_def_curr As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
