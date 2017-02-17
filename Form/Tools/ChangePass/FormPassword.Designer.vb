<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPassword))
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnew = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.panel = New DevExpress.XtraEditors.GroupControl()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.cbo_unit = New MTGCComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.Location = New System.Drawing.Point(114, 57)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(303, 23)
        Me.txtpassword.TabIndex = 13
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.White
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuser.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.Black
        Me.txtuser.Location = New System.Drawing.Point(114, 31)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.ReadOnly = True
        Me.txtuser.Size = New System.Drawing.Size(303, 23)
        Me.txtuser.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Username"
        '
        'txtnew
        '
        Me.txtnew.BackColor = System.Drawing.Color.White
        Me.txtnew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnew.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnew.ForeColor = System.Drawing.Color.Black
        Me.txtnew.Location = New System.Drawing.Point(114, 83)
        Me.txtnew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnew.Size = New System.Drawing.Size(303, 23)
        Me.txtnew.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "New Password"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x161
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(32767, 107)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(74, 42)
        Me.btn_save.TabIndex = 18
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        Me.btn_save.Visible = False
        '
        'panel
        '
        Me.panel.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.panel.Appearance.Options.UseBackColor = True
        Me.panel.Appearance.Options.UseFont = True
        Me.panel.Appearance.Options.UseForeColor = True
        Me.panel.Controls.Add(Me.btn_keluar)
        Me.panel.Controls.Add(Me.btn_save2)
        Me.panel.Controls.Add(Me.txtnew)
        Me.panel.Controls.Add(Me.ComboBox3)
        Me.panel.Controls.Add(Me.Label1)
        Me.panel.Controls.Add(Me.cbo_unit)
        Me.panel.Controls.Add(Me.txtpassword)
        Me.panel.Controls.Add(Me.Label18)
        Me.panel.Controls.Add(Me.txtuser)
        Me.panel.Controls.Add(Me.Label24)
        Me.panel.Controls.Add(Me.Label3)
        Me.panel.Controls.Add(Me.Label2)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.panel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(429, 165)
        Me.panel.TabIndex = 301
        Me.panel.Text = "REGISTRASI USER"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(243, 125)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(86, 30)
        Me.btn_keluar.TabIndex = 137
        Me.btn_keluar.Text = "BATAL"
        '
        'btn_save2
        '
        Me.btn_save2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(335, 125)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 30)
        Me.btn_save2.TabIndex = 136
        Me.btn_save2.Text = "SIMPAN"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.ForeColor = System.Drawing.Color.Black
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(-1984, 33)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(150, 26)
        Me.ComboBox3.TabIndex = 131
        Me.ComboBox3.Visible = False
        '
        'cbo_unit
        '
        Me.cbo_unit.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_unit.ArrowColor = System.Drawing.Color.Black
        Me.cbo_unit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbo_unit.BindedControl = CType(resources.GetObject("cbo_unit.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_unit.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.cbo_unit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_unit.ColumnNum = 4
        Me.cbo_unit.ColumnWidth = "150; 110; 170 ;180"
        Me.cbo_unit.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_unit.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cbo_unit.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cbo_unit.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbo_unit.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo_unit.DisplayMember = "Text"
        Me.cbo_unit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_unit.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.cbo_unit.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cbo_unit.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_unit.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_unit.DropDownWidth = 630
        Me.cbo_unit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_unit.ForeColor = System.Drawing.Color.Black
        Me.cbo_unit.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_unit.GridLineHorizontal = True
        Me.cbo_unit.GridLineVertical = True
        Me.cbo_unit.HighlightBorderColor = System.Drawing.Color.LightGray
        Me.cbo_unit.HighlightBorderOnMouseEvents = True
        Me.cbo_unit.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_unit.Location = New System.Drawing.Point(-11319, 34)
        Me.cbo_unit.ManagingFastMouseMoving = True
        Me.cbo_unit.ManagingFastMouseMovingInterval = 30
        Me.cbo_unit.Name = "cbo_unit"
        Me.cbo_unit.NormalBorderColor = System.Drawing.Color.Black
        Me.cbo_unit.SelectedItem = Nothing
        Me.cbo_unit.SelectedValue = Nothing
        Me.cbo_unit.Size = New System.Drawing.Size(121, 24)
        Me.cbo_unit.TabIndex = 130
        Me.cbo_unit.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(623, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 18)
        Me.Label18.TabIndex = 129
        Me.Label18.Text = "Tanggal Permintaan"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(623, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 18)
        Me.Label24.TabIndex = 128
        Me.Label24.Text = "No Permintaan"
        '
        'FormPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(429, 165)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.btn_save)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnew As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents panel As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_unit As MTGCComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
