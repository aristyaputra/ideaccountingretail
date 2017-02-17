<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendEmail))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelInbox = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_penerima = New DevExpress.XtraEditors.TextEdit()
        Me.btn_browse = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_email = New DevExpress.XtraEditors.MemoEdit()
        Me.list_penerima = New DevExpress.XtraEditors.ListBoxControl()
        Me.list_attachment = New DevExpress.XtraEditors.ListBoxControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_subject = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navSendEmail = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridList_Customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelInbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInbox.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_penerima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_penerima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_attachment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_subject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.PanelInbox)
        Me.Panel1.Controls.Add(Me.PanelControl1)
        Me.Panel1.Controls.Add(Me.NavBarControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 602)
        Me.Panel1.TabIndex = 30
        '
        'PanelInbox
        '
        Me.PanelInbox.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelInbox.Appearance.Options.UseBackColor = True
        Me.PanelInbox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelInbox.Controls.Add(Me.LabelControl8)
        Me.PanelInbox.Controls.Add(Me.LabelControl7)
        Me.PanelInbox.Controls.Add(Me.MemoEdit1)
        Me.PanelInbox.Controls.Add(Me.GridControl)
        Me.PanelInbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelInbox.Location = New System.Drawing.Point(186, 0)
        Me.PanelInbox.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelInbox.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelInbox.Name = "PanelInbox"
        Me.PanelInbox.Size = New System.Drawing.Size(700, 602)
        Me.PanelInbox.TabIndex = 293
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txt_penerima)
        Me.PanelControl1.Controls.Add(Me.btn_browse)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.txt_email)
        Me.PanelControl1.Controls.Add(Me.list_penerima)
        Me.PanelControl1.Controls.Add(Me.list_attachment)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.btn_save2)
        Me.PanelControl1.Controls.Add(Me.txt_subject)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(209, 25)
        Me.PanelControl1.LookAndFeel.SkinName = "Metropolis"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(200, 100)
        Me.PanelControl1.TabIndex = 292
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl6.Location = New System.Drawing.Point(16, 5)
        Me.LabelControl6.LookAndFeel.SkinName = "Metropolis"
        Me.LabelControl6.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(91, 22)
        Me.LabelControl6.TabIndex = 292
        Me.LabelControl6.Text = "KIRIM EMAIL"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(16, 36)
        Me.LabelControl1.LookAndFeel.SkinName = "Metropolis"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 18)
        Me.LabelControl1.TabIndex = 33
        Me.LabelControl1.Text = "Penerima" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_penerima
        '
        Me.txt_penerima.Location = New System.Drawing.Point(133, 33)
        Me.txt_penerima.Name = "txt_penerima"
        Me.txt_penerima.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_penerima.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_penerima.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_penerima.Properties.Appearance.Options.UseBackColor = True
        Me.txt_penerima.Properties.Appearance.Options.UseFont = True
        Me.txt_penerima.Properties.Appearance.Options.UseForeColor = True
        Me.txt_penerima.Properties.LookAndFeel.SkinName = "Metropolis"
        Me.txt_penerima.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_penerima.Size = New System.Drawing.Size(535, 24)
        Me.txt_penerima.TabIndex = 37
        '
        'btn_browse
        '
        Me.btn_browse.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_browse.Appearance.Options.UseFont = True
        Me.btn_browse.Appearance.Options.UseForeColor = True
        Me.btn_browse.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Upload_16x16
        Me.btn_browse.Location = New System.Drawing.Point(133, 436)
        Me.btn_browse.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_browse.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_browse.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(559, 30)
        Me.btn_browse.TabIndex = 291
        Me.btn_browse.Text = "Browse Attachment File"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.add
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(670, 33)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(22, 23)
        Me.SimpleButton1.TabIndex = 285
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(133, 167)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_email.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_email.Properties.Appearance.Options.UseBackColor = True
        Me.txt_email.Properties.Appearance.Options.UseFont = True
        Me.txt_email.Properties.Appearance.Options.UseForeColor = True
        Me.txt_email.Properties.LookAndFeel.SkinName = "Metropolis"
        Me.txt_email.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_email.Size = New System.Drawing.Size(559, 264)
        Me.txt_email.TabIndex = 288
        '
        'list_penerima
        '
        Me.list_penerima.AllowDrop = True
        Me.list_penerima.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.list_penerima.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_penerima.Appearance.ForeColor = System.Drawing.Color.Black
        Me.list_penerima.Appearance.Options.UseBackColor = True
        Me.list_penerima.Appearance.Options.UseFont = True
        Me.list_penerima.Appearance.Options.UseForeColor = True
        Me.list_penerima.Location = New System.Drawing.Point(133, 61)
        Me.list_penerima.LookAndFeel.SkinName = "Metropolis"
        Me.list_penerima.LookAndFeel.UseDefaultLookAndFeel = False
        Me.list_penerima.Name = "list_penerima"
        Me.list_penerima.Size = New System.Drawing.Size(559, 74)
        Me.list_penerima.TabIndex = 36
        '
        'list_attachment
        '
        Me.list_attachment.AllowDrop = True
        Me.list_attachment.Appearance.BackColor = System.Drawing.Color.Lavender
        Me.list_attachment.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_attachment.Appearance.ForeColor = System.Drawing.Color.Black
        Me.list_attachment.Appearance.Options.UseBackColor = True
        Me.list_attachment.Appearance.Options.UseFont = True
        Me.list_attachment.Appearance.Options.UseForeColor = True
        Me.list_attachment.Location = New System.Drawing.Point(133, 471)
        Me.list_attachment.LookAndFeel.SkinName = "Metropolis"
        Me.list_attachment.LookAndFeel.UseDefaultLookAndFeel = False
        Me.list_attachment.Name = "list_attachment"
        Me.list_attachment.Size = New System.Drawing.Size(559, 74)
        Me.list_attachment.TabIndex = 290
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Location = New System.Drawing.Point(16, 61)
        Me.LabelControl3.LookAndFeel.SkinName = "Metropolis"
        Me.LabelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(96, 18)
        Me.LabelControl3.TabIndex = 286
        Me.LabelControl3.Text = "Daftar Penerima"
        '
        'btn_save2
        '
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Check_16x16
        Me.btn_save2.Location = New System.Drawing.Point(622, 553)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(70, 40)
        Me.btn_save2.TabIndex = 31
        Me.btn_save2.Text = "KIRIM"
        '
        'txt_subject
        '
        Me.txt_subject.Location = New System.Drawing.Point(133, 139)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_subject.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subject.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_subject.Properties.Appearance.Options.UseBackColor = True
        Me.txt_subject.Properties.Appearance.Options.UseFont = True
        Me.txt_subject.Properties.Appearance.Options.UseForeColor = True
        Me.txt_subject.Properties.LookAndFeel.SkinName = "Metropolis"
        Me.txt_subject.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_subject.Size = New System.Drawing.Size(559, 24)
        Me.txt_subject.TabIndex = 35
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Location = New System.Drawing.Point(16, 434)
        Me.LabelControl5.LookAndFeel.SkinName = "Metropolis"
        Me.LabelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 18)
        Me.LabelControl5.TabIndex = 289
        Me.LabelControl5.Text = "Attachment"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Location = New System.Drawing.Point(16, 169)
        Me.LabelControl4.LookAndFeel.SkinName = "Metropolis"
        Me.LabelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 18)
        Me.LabelControl4.TabIndex = 287
        Me.LabelControl4.Text = "Isi Email"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Location = New System.Drawing.Point(16, 142)
        Me.LabelControl2.LookAndFeel.SkinName = "Metropolis"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(45, 18)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Subject"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Appearance.GroupHeader.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl1.Appearance.GroupHeader.Options.UseFont = True
        Me.NavBarControl1.Appearance.GroupHeaderActive.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl1.Appearance.GroupHeaderActive.Options.UseFont = True
        Me.NavBarControl1.Appearance.Item.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl1.Appearance.Item.Options.UseFont = True
        Me.NavBarControl1.Appearance.ItemActive.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavBarControl1.Appearance.ItemActive.Options.UseFont = True
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2, Me.NavBarGroup3})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navSendEmail, Me.NavBarItem2, Me.NavBarItem3, Me.NavBarItem4, Me.NavBarItem5, Me.NavBarItem6})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.LookAndFeel.SkinName = "Office 2010 Black"
        Me.NavBarControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 186
        Me.NavBarControl1.Size = New System.Drawing.Size(186, 602)
        Me.NavBarControl1.TabIndex = 292
        Me.NavBarControl1.Text = "NavBarControl1"
        Me.NavBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2010 Silver")
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "KIRIM EMAIL"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navSendEmail)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'navSendEmail
        '
        Me.navSendEmail.Caption = "Kirim Email"
        Me.navSendEmail.Name = "navSendEmail"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "FITUR EMAIL"
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem4)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "Kotak Masuk"
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = "Kotak Keluar"
        Me.NavBarItem3.Name = "NavBarItem3"
        '
        'NavBarItem4
        '
        Me.NavBarItem4.Caption = "Draft"
        Me.NavBarItem4.Name = "NavBarItem4"
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Caption = "KONFIGURASI"
        Me.NavBarGroup3.Expanded = True
        Me.NavBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem6)})
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'NavBarItem5
        '
        Me.NavBarItem5.Caption = "Setting Email"
        Me.NavBarItem5.Name = "NavBarItem5"
        '
        'NavBarItem6
        '
        Me.NavBarItem6.Caption = "Akun Email"
        Me.NavBarItem6.Name = "NavBarItem6"
        '
        'GridControl
        '
        Me.GridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Location = New System.Drawing.Point(0, 25)
        Me.GridControl.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl.MainView = Me.GridList_Customer
        Me.GridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(700, 280)
        Me.GridControl.TabIndex = 314
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridList_Customer})
        '
        'GridList_Customer
        '
        Me.GridList_Customer.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridList_Customer.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridList_Customer.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.GridList_Customer.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.GridList_Customer.Appearance.DetailTip.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.DetailTip.Options.UseFont = True
        Me.GridList_Customer.Appearance.Empty.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.Empty.Options.UseFont = True
        Me.GridList_Customer.Appearance.EvenRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.EvenRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FilterCloseButton.Options.UseFont = True
        Me.GridList_Customer.Appearance.FilterPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FilterPanel.Options.UseFont = True
        Me.GridList_Customer.Appearance.FixedLine.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FixedLine.Options.UseFont = True
        Me.GridList_Customer.Appearance.FocusedCell.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FocusedCell.Options.UseFont = True
        Me.GridList_Customer.Appearance.FocusedRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FocusedRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.FooterPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.FooterPanel.Options.UseFont = True
        Me.GridList_Customer.Appearance.GroupButton.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupButton.Options.UseFont = True
        Me.GridList_Customer.Appearance.GroupFooter.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupFooter.Options.UseFont = True
        Me.GridList_Customer.Appearance.GroupPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupPanel.Options.UseFont = True
        Me.GridList_Customer.Appearance.GroupRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.GroupRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.HeaderPanel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridList_Customer.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.HorzLine.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.HorzLine.Options.UseFont = True
        Me.GridList_Customer.Appearance.OddRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.OddRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.Preview.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.Preview.Options.UseFont = True
        Me.GridList_Customer.Appearance.Row.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.Row.Options.UseFont = True
        Me.GridList_Customer.Appearance.RowSeparator.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.RowSeparator.Options.UseFont = True
        Me.GridList_Customer.Appearance.SelectedRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.SelectedRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.TopNewRow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.TopNewRow.Options.UseFont = True
        Me.GridList_Customer.Appearance.VertLine.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.VertLine.Options.UseFont = True
        Me.GridList_Customer.Appearance.ViewCaption.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GridList_Customer.Appearance.ViewCaption.Options.UseFont = True
        Me.GridList_Customer.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridList_Customer.GridControl = Me.GridControl
        Me.GridList_Customer.Name = "GridList_Customer"
        Me.GridList_Customer.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridList_Customer.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridList_Customer.OptionsBehavior.Editable = False
        Me.GridList_Customer.OptionsBehavior.ReadOnly = True
        Me.GridList_Customer.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GridList_Customer.OptionsCustomization.AllowColumnMoving = False
        Me.GridList_Customer.OptionsCustomization.AllowGroup = False
        Me.GridList_Customer.OptionsDetail.AllowZoomDetail = False
        Me.GridList_Customer.OptionsDetail.SmartDetailHeight = True
        Me.GridList_Customer.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
        Me.GridList_Customer.OptionsFind.AllowFindPanel = False
        Me.GridList_Customer.OptionsMenu.EnableColumnMenu = False
        Me.GridList_Customer.OptionsMenu.EnableFooterMenu = False
        Me.GridList_Customer.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridList_Customer.OptionsNavigation.AutoFocusNewRow = True
        Me.GridList_Customer.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridList_Customer.OptionsView.ShowAutoFilterRow = True
        Me.GridList_Customer.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridList_Customer.OptionsView.ShowGroupPanel = False
        Me.GridList_Customer.PaintStyleName = "Skin"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 330)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(700, 272)
        Me.MemoEdit1.TabIndex = 315
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(5, 312)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl7.TabIndex = 316
        Me.LabelControl7.Text = "Detail Konten"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(5, 6)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl8.TabIndex = 317
        Me.LabelControl8.Text = "Kotak Masuk"
        '
        'SendEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(886, 602)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SendEmail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Email Feature"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelInbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInbox.ResumeLayout(False)
        Me.PanelInbox.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_penerima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_penerima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_attachment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_subject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridList_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_penerima As DevExpress.XtraEditors.TextEdit
    Friend WithEvents list_penerima As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents txt_subject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_email As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents list_attachment As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents navSendEmail As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelInbox As DevExpress.XtraEditors.PanelControl
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem5 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridList_Customer As DevExpress.XtraGrid.Views.Grid.GridView
End Class
