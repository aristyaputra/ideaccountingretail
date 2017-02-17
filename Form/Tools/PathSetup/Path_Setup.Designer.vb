<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_path_setup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_path_setup))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_logo = New System.Windows.Forms.Button()
        Me.txt_save_logo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_Item = New System.Windows.Forms.Button()
        Me.txt_save_item = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Employee = New System.Windows.Forms.Button()
        Me.txt_save_employee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Supplier = New System.Windows.Forms.Button()
        Me.txt_save_supplier = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Customer = New System.Windows.Forms.Button()
        Me.txt_save_customer = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnProsess2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.panel = New DevExpress.XtraEditors.GroupControl()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.cbo_unit = New MTGCComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(32741, 244)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 45)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "SETUP"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(18, 154)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 287
        Me.Label5.Text = "Logo "
        '
        'Button_logo
        '
        Me.Button_logo.BackColor = System.Drawing.Color.LightBlue
        Me.Button_logo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_logo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_logo.Location = New System.Drawing.Point(442, 154)
        Me.Button_logo.Name = "Button_logo"
        Me.Button_logo.Size = New System.Drawing.Size(81, 26)
        Me.Button_logo.TabIndex = 286
        Me.Button_logo.Text = "Browse"
        Me.Button_logo.UseVisualStyleBackColor = False
        '
        'txt_save_logo
        '
        Me.txt_save_logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_save_logo.BackColor = System.Drawing.Color.White
        Me.txt_save_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_save_logo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_save_logo.Location = New System.Drawing.Point(137, 155)
        Me.txt_save_logo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_save_logo.Name = "txt_save_logo"
        Me.txt_save_logo.ReadOnly = True
        Me.txt_save_logo.Size = New System.Drawing.Size(297, 25)
        Me.txt_save_logo.TabIndex = 285
        Me.txt_save_logo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(18, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 284
        Me.Label4.Text = "Foto Barang"
        '
        'Button_Item
        '
        Me.Button_Item.BackColor = System.Drawing.Color.LightBlue
        Me.Button_Item.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Item.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Item.Location = New System.Drawing.Point(442, 125)
        Me.Button_Item.Name = "Button_Item"
        Me.Button_Item.Size = New System.Drawing.Size(81, 26)
        Me.Button_Item.TabIndex = 283
        Me.Button_Item.Text = "Browse"
        Me.Button_Item.UseVisualStyleBackColor = False
        '
        'txt_save_item
        '
        Me.txt_save_item.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_save_item.BackColor = System.Drawing.Color.White
        Me.txt_save_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_save_item.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_save_item.Location = New System.Drawing.Point(137, 126)
        Me.txt_save_item.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_save_item.Name = "txt_save_item"
        Me.txt_save_item.ReadOnly = True
        Me.txt_save_item.Size = New System.Drawing.Size(297, 25)
        Me.txt_save_item.TabIndex = 282
        Me.txt_save_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 281
        Me.Label3.Text = "Foto Karyawan"
        '
        'Button_Employee
        '
        Me.Button_Employee.BackColor = System.Drawing.Color.LightBlue
        Me.Button_Employee.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Employee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Employee.Location = New System.Drawing.Point(442, 96)
        Me.Button_Employee.Name = "Button_Employee"
        Me.Button_Employee.Size = New System.Drawing.Size(81, 26)
        Me.Button_Employee.TabIndex = 280
        Me.Button_Employee.Text = "Browse"
        Me.Button_Employee.UseVisualStyleBackColor = False
        '
        'txt_save_employee
        '
        Me.txt_save_employee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_save_employee.BackColor = System.Drawing.Color.White
        Me.txt_save_employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_save_employee.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_save_employee.Location = New System.Drawing.Point(137, 97)
        Me.txt_save_employee.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_save_employee.Name = "txt_save_employee"
        Me.txt_save_employee.ReadOnly = True
        Me.txt_save_employee.Size = New System.Drawing.Size(297, 25)
        Me.txt_save_employee.TabIndex = 279
        Me.txt_save_employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 278
        Me.Label2.Text = "Foto Supplier"
        '
        'Button_Supplier
        '
        Me.Button_Supplier.BackColor = System.Drawing.Color.LightBlue
        Me.Button_Supplier.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Supplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Supplier.Location = New System.Drawing.Point(442, 67)
        Me.Button_Supplier.Name = "Button_Supplier"
        Me.Button_Supplier.Size = New System.Drawing.Size(81, 26)
        Me.Button_Supplier.TabIndex = 277
        Me.Button_Supplier.Text = "Browse"
        Me.Button_Supplier.UseVisualStyleBackColor = False
        '
        'txt_save_supplier
        '
        Me.txt_save_supplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_save_supplier.BackColor = System.Drawing.Color.White
        Me.txt_save_supplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_save_supplier.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_save_supplier.Location = New System.Drawing.Point(137, 68)
        Me.txt_save_supplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_save_supplier.Name = "txt_save_supplier"
        Me.txt_save_supplier.ReadOnly = True
        Me.txt_save_supplier.Size = New System.Drawing.Size(297, 25)
        Me.txt_save_supplier.TabIndex = 276
        Me.txt_save_supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 275
        Me.Label1.Text = "Foto Pelanggan"
        '
        'Button_Customer
        '
        Me.Button_Customer.BackColor = System.Drawing.Color.LightBlue
        Me.Button_Customer.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Customer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Customer.Location = New System.Drawing.Point(442, 38)
        Me.Button_Customer.Name = "Button_Customer"
        Me.Button_Customer.Size = New System.Drawing.Size(81, 26)
        Me.Button_Customer.TabIndex = 274
        Me.Button_Customer.Text = "Browse"
        Me.Button_Customer.UseVisualStyleBackColor = False
        '
        'txt_save_customer
        '
        Me.txt_save_customer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_save_customer.BackColor = System.Drawing.Color.White
        Me.txt_save_customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_save_customer.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_save_customer.Location = New System.Drawing.Point(137, 39)
        Me.txt_save_customer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_save_customer.Name = "txt_save_customer"
        Me.txt_save_customer.ReadOnly = True
        Me.txt_save_customer.Size = New System.Drawing.Size(297, 25)
        Me.txt_save_customer.TabIndex = 273
        Me.txt_save_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gold
        Me.Button2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(32767, 243)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 45)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "CLOSE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'btnProsess2
        '
        Me.btnProsess2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProsess2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProsess2.Appearance.Options.UseFont = True
        Me.btnProsess2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btnProsess2.Location = New System.Drawing.Point(474, 256)
        Me.btnProsess2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btnProsess2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnProsess2.Name = "btnProsess2"
        Me.btnProsess2.Size = New System.Drawing.Size(82, 36)
        Me.btnProsess2.TabIndex = 287
        Me.btnProsess2.Text = "PROSES"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(381, 256)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(86, 36)
        Me.btn_keluar.TabIndex = 288
        Me.btn_keluar.Text = "KELUAR"
        '
        'panel
        '
        Me.panel.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.panel.Appearance.Options.UseBackColor = True
        Me.panel.Appearance.Options.UseFont = True
        Me.panel.Appearance.Options.UseForeColor = True
        Me.panel.Controls.Add(Me.Button_logo)
        Me.panel.Controls.Add(Me.Label5)
        Me.panel.Controls.Add(Me.Button_Item)
        Me.panel.Controls.Add(Me.ComboBox3)
        Me.panel.Controls.Add(Me.Button_Employee)
        Me.panel.Controls.Add(Me.cbo_unit)
        Me.panel.Controls.Add(Me.Button_Supplier)
        Me.panel.Controls.Add(Me.txt_save_logo)
        Me.panel.Controls.Add(Me.Button_Customer)
        Me.panel.Controls.Add(Me.Label18)
        Me.panel.Controls.Add(Me.Label4)
        Me.panel.Controls.Add(Me.Label24)
        Me.panel.Controls.Add(Me.Label1)
        Me.panel.Controls.Add(Me.txt_save_item)
        Me.panel.Controls.Add(Me.txt_save_customer)
        Me.panel.Controls.Add(Me.Label3)
        Me.panel.Controls.Add(Me.txt_save_supplier)
        Me.panel.Controls.Add(Me.Label2)
        Me.panel.Controls.Add(Me.txt_save_employee)
        Me.panel.Location = New System.Drawing.Point(12, 3)
        Me.panel.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.panel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(544, 245)
        Me.panel.TabIndex = 301
        Me.panel.Text = "SETTING DIREKTORI FOTO"
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
        Me.ComboBox3.Location = New System.Drawing.Point(-1869, 33)
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
        'frm_path_setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(568, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btnProsess2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_path_setup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Path Photo Directory"
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button_Customer As System.Windows.Forms.Button
    Friend WithEvents txt_save_customer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button_Item As System.Windows.Forms.Button
    Friend WithEvents txt_save_item As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button_Employee As System.Windows.Forms.Button
    Friend WithEvents txt_save_employee As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button_Supplier As System.Windows.Forms.Button
    Friend WithEvents txt_save_supplier As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button_logo As System.Windows.Forms.Button
    Friend WithEvents txt_save_logo As System.Windows.Forms.TextBox
    Friend WithEvents btnProsess2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panel As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_unit As MTGCComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
