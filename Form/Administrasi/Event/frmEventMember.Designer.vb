<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEventMember))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.txt_eventname = New System.Windows.Forms.TextBox()
        Me.txt_area = New System.Windows.Forms.TextBox()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_reset_pic2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_upload2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_photo = New System.Windows.Forms.PictureBox()
        Me.txt_region = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_posisi = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nip = New System.Windows.Forms.TextBox()
        Me.txt_eventid = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_end_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_start_date = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_keluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reset2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_save_path = New System.Windows.Forms.TextBox()
        Me.txt_memberid = New System.Windows.Forms.TextBox()
        Me.txt_temp = New System.Windows.Forms.TextBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txt_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_eventid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btn_save)
        Me.Panel4.Controls.Add(Me.btn_delete)
        Me.Panel4.Controls.Add(Me.btn_reset)
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(-289, 310)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(268, 44)
        Me.Panel4.TabIndex = 79
        Me.Panel4.Visible = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_save.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(180, 3)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(81, 38)
        Me.btn_save.TabIndex = 76
        Me.btn_save.Text = "Simpan"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_delete.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Delete_16x16
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(98, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(79, 38)
        Me.btn_delete.TabIndex = 78
        Me.btn_delete.Text = "Hapus"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_reset.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.Black
        Me.btn_reset.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset.Location = New System.Drawing.Point(23, 3)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(72, 38)
        Me.btn_reset.TabIndex = 77
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'txt_eventname
        '
        Me.txt_eventname.BackColor = System.Drawing.Color.White
        Me.txt_eventname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_eventname.Enabled = False
        Me.txt_eventname.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_eventname.ForeColor = System.Drawing.Color.Black
        Me.txt_eventname.Location = New System.Drawing.Point(285, -2)
        Me.txt_eventname.Name = "txt_eventname"
        Me.txt_eventname.Size = New System.Drawing.Size(334, 25)
        Me.txt_eventname.TabIndex = 11
        Me.txt_eventname.Visible = False
        '
        'txt_area
        '
        Me.txt_area.BackColor = System.Drawing.Color.White
        Me.txt_area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_area.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_area.ForeColor = System.Drawing.Color.Black
        Me.txt_area.Location = New System.Drawing.Point(138, 226)
        Me.txt_area.Name = "txt_area"
        Me.txt_area.Size = New System.Drawing.Size(474, 25)
        Me.txt_area.TabIndex = 12
        '
        'GroupControl3
        '
        Me.GroupControl3.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupControl3.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GroupControl3.Appearance.Options.UseBackColor = True
        Me.GroupControl3.Appearance.Options.UseFont = True
        Me.GroupControl3.Appearance.Options.UseForeColor = True
        Me.GroupControl3.Appearance.Options.UseTextOptions = True
        Me.GroupControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl3.Controls.Add(Me.btn_reset_pic2)
        Me.GroupControl3.Controls.Add(Me.btn_upload2)
        Me.GroupControl3.Controls.Add(Me.txt_photo)
        Me.GroupControl3.Controls.Add(Me.txt_region)
        Me.GroupControl3.Controls.Add(Me.Label4)
        Me.GroupControl3.Controls.Add(Me.txt_posisi)
        Me.GroupControl3.Controls.Add(Me.txt_nama)
        Me.GroupControl3.Controls.Add(Me.Label3)
        Me.GroupControl3.Controls.Add(Me.txt_nip)
        Me.GroupControl3.Controls.Add(Me.txt_eventid)
        Me.GroupControl3.Controls.Add(Me.txt_end_date)
        Me.GroupControl3.Controls.Add(Me.txt_start_date)
        Me.GroupControl3.Controls.Add(Me.Label2)
        Me.GroupControl3.Controls.Add(Me.txt_area)
        Me.GroupControl3.Controls.Add(Me.Label22)
        Me.GroupControl3.Controls.Add(Me.Label20)
        Me.GroupControl3.Controls.Add(Me.Label18)
        Me.GroupControl3.Controls.Add(Me.Label17)
        Me.GroupControl3.Location = New System.Drawing.Point(18, 52)
        Me.GroupControl3.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GroupControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(855, 317)
        Me.GroupControl3.TabIndex = 277
        Me.GroupControl3.Text = "REGISTRASI DATA PESERTA"
        '
        'btn_reset_pic2
        '
        Me.btn_reset_pic2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reset_pic2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_pic2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_reset_pic2.Appearance.Options.UseFont = True
        Me.btn_reset_pic2.Appearance.Options.UseForeColor = True
        Me.btn_reset_pic2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset_pic2.Location = New System.Drawing.Point(739, 252)
        Me.btn_reset_pic2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset_pic2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset_pic2.Name = "btn_reset_pic2"
        Me.btn_reset_pic2.Size = New System.Drawing.Size(82, 36)
        Me.btn_reset_pic2.TabIndex = 283
        Me.btn_reset_pic2.Text = "RESET"
        '
        'btn_upload2
        '
        Me.btn_upload2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_upload2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upload2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_upload2.Appearance.Options.UseFont = True
        Me.btn_upload2.Appearance.Options.UseForeColor = True
        Me.btn_upload2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Upload_16x16
        Me.btn_upload2.Location = New System.Drawing.Point(651, 252)
        Me.btn_upload2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_upload2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_upload2.Name = "btn_upload2"
        Me.btn_upload2.Size = New System.Drawing.Size(82, 36)
        Me.btn_upload2.TabIndex = 282
        Me.btn_upload2.Text = "UPLOAD"
        '
        'txt_photo
        '
        Me.txt_photo.BackColor = System.Drawing.Color.Lavender
        Me.txt_photo.ForeColor = System.Drawing.Color.Black
        Me.txt_photo.Location = New System.Drawing.Point(634, 43)
        Me.txt_photo.Name = "txt_photo"
        Me.txt_photo.Size = New System.Drawing.Size(200, 200)
        Me.txt_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.txt_photo.TabIndex = 274
        Me.txt_photo.TabStop = False
        '
        'txt_region
        '
        Me.txt_region.BackColor = System.Drawing.Color.White
        Me.txt_region.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_region.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_region.ForeColor = System.Drawing.Color.Black
        Me.txt_region.Location = New System.Drawing.Point(138, 263)
        Me.txt_region.Name = "txt_region"
        Me.txt_region.Size = New System.Drawing.Size(474, 25)
        Me.txt_region.TabIndex = 272
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 273
        Me.Label4.Text = "REGION"
        '
        'txt_posisi
        '
        Me.txt_posisi.BackColor = System.Drawing.Color.White
        Me.txt_posisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_posisi.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_posisi.ForeColor = System.Drawing.Color.Black
        Me.txt_posisi.Location = New System.Drawing.Point(138, 189)
        Me.txt_posisi.Name = "txt_posisi"
        Me.txt_posisi.Size = New System.Drawing.Size(474, 25)
        Me.txt_posisi.TabIndex = 271
        '
        'txt_nama
        '
        Me.txt_nama.BackColor = System.Drawing.Color.White
        Me.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nama.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama.ForeColor = System.Drawing.Color.Black
        Me.txt_nama.Location = New System.Drawing.Point(138, 153)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(474, 25)
        Me.txt_nama.TabIndex = 270
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 269
        Me.Label3.Text = "NAMA"
        '
        'txt_nip
        '
        Me.txt_nip.BackColor = System.Drawing.Color.White
        Me.txt_nip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nip.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nip.ForeColor = System.Drawing.Color.Black
        Me.txt_nip.Location = New System.Drawing.Point(138, 117)
        Me.txt_nip.Name = "txt_nip"
        Me.txt_nip.Size = New System.Drawing.Size(474, 25)
        Me.txt_nip.TabIndex = 268
        '
        'txt_eventid
        '
        Me.txt_eventid.Location = New System.Drawing.Point(138, 42)
        Me.txt_eventid.Name = "txt_eventid"
        Me.txt_eventid.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_eventid.Properties.Appearance.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_eventid.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_eventid.Properties.Appearance.Options.UseBackColor = True
        Me.txt_eventid.Properties.Appearance.Options.UseFont = True
        Me.txt_eventid.Properties.Appearance.Options.UseForeColor = True
        Me.txt_eventid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_eventid.Properties.View = Me.GridLookUpEdit1View
        Me.txt_eventid.Size = New System.Drawing.Size(474, 26)
        Me.txt_eventid.TabIndex = 267
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txt_end_date
        '
        Me.txt_end_date.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_end_date.CustomFormat = "dd-MM-yyyy hh:mm"
        Me.txt_end_date.Enabled = False
        Me.txt_end_date.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_end_date.ForeColor = System.Drawing.Color.Black
        Me.txt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_end_date.Location = New System.Drawing.Point(309, 80)
        Me.txt_end_date.Name = "txt_end_date"
        Me.txt_end_date.Size = New System.Drawing.Size(163, 25)
        Me.txt_end_date.TabIndex = 266
        '
        'txt_start_date
        '
        Me.txt_start_date.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_start_date.CustomFormat = "dd-MM-yyyy hh:mm"
        Me.txt_start_date.Enabled = False
        Me.txt_start_date.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_start_date.ForeColor = System.Drawing.Color.Black
        Me.txt_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_start_date.Location = New System.Drawing.Point(138, 80)
        Me.txt_start_date.Name = "txt_start_date"
        Me.txt_start_date.Size = New System.Drawing.Size(165, 25)
        Me.txt_start_date.TabIndex = 265
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = "POSISI"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(13, 228)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 20)
        Me.Label22.TabIndex = 263
        Me.Label22.Text = "AREA"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(13, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 20)
        Me.Label20.TabIndex = 262
        Me.Label20.Text = "NIP"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(13, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 20)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "DURASI EVENT"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(13, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 20)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "PILIH ITEM"
        '
        'btn_keluar
        '
        Me.btn_keluar.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_keluar.Appearance.Options.UseFont = True
        Me.btn_keluar.Appearance.Options.UseForeColor = True
        Me.btn_keluar.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.btn_keluar.Location = New System.Drawing.Point(17, 375)
        Me.btn_keluar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_keluar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(82, 36)
        Me.btn_keluar.TabIndex = 21
        Me.btn_keluar.Text = "TUTUP"
        '
        'btn_reset2
        '
        Me.btn_reset2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_reset2.Appearance.Options.UseFont = True
        Me.btn_reset2.Appearance.Options.UseForeColor = True
        Me.btn_reset2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.arrow_circle_double
        Me.btn_reset2.Location = New System.Drawing.Point(615, 375)
        Me.btn_reset2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reset2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reset2.Name = "btn_reset2"
        Me.btn_reset2.Size = New System.Drawing.Size(82, 36)
        Me.btn_reset2.TabIndex = 20
        Me.btn_reset2.Text = "RESET"
        '
        'btn_del2
        '
        Me.btn_del2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_del2.Appearance.Options.UseFont = True
        Me.btn_del2.Appearance.Options.UseForeColor = True
        Me.btn_del2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Delete_16x16
        Me.btn_del2.Location = New System.Drawing.Point(703, 375)
        Me.btn_del2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_del2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_del2.Name = "btn_del2"
        Me.btn_del2.Size = New System.Drawing.Size(82, 36)
        Me.btn_del2.TabIndex = 19
        Me.btn_del2.Text = "HAPUS"
        '
        'btn_save2
        '
        Me.btn_save2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_save2.Appearance.Options.UseFont = True
        Me.btn_save2.Appearance.Options.UseForeColor = True
        Me.btn_save2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Save_16x16
        Me.btn_save2.Location = New System.Drawing.Point(791, 375)
        Me.btn_save2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(82, 36)
        Me.btn_save2.TabIndex = 18
        Me.btn_save2.Text = "SIMPAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 29)
        Me.Label1.TabIndex = 284
        Me.Label1.Text = "FORM REGISTRASI DATA PESERTA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.txt_save_path)
        Me.Panel1.Controls.Add(Me.txt_memberid)
        Me.Panel1.Controls.Add(Me.txt_temp)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_keluar)
        Me.Panel1.Controls.Add(Me.btn_save2)
        Me.Panel1.Controls.Add(Me.GroupControl3)
        Me.Panel1.Controls.Add(Me.btn_reset2)
        Me.Panel1.Controls.Add(Me.btn_del2)
        Me.Panel1.Controls.Add(Me.txt_eventname)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(93, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(894, 421)
        Me.Panel1.TabIndex = 285
        Me.Panel1.Visible = False
        '
        'txt_save_path
        '
        Me.txt_save_path.BackColor = System.Drawing.Color.White
        Me.txt_save_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_save_path.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_save_path.ForeColor = System.Drawing.Color.Black
        Me.txt_save_path.Location = New System.Drawing.Point(210, 198)
        Me.txt_save_path.Name = "txt_save_path"
        Me.txt_save_path.Size = New System.Drawing.Size(474, 25)
        Me.txt_save_path.TabIndex = 286
        Me.txt_save_path.Visible = False
        '
        'txt_memberid
        '
        Me.txt_memberid.BackColor = System.Drawing.Color.White
        Me.txt_memberid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_memberid.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_memberid.ForeColor = System.Drawing.Color.Black
        Me.txt_memberid.Location = New System.Drawing.Point(325, 29)
        Me.txt_memberid.Name = "txt_memberid"
        Me.txt_memberid.Size = New System.Drawing.Size(474, 25)
        Me.txt_memberid.TabIndex = 285
        Me.txt_memberid.Visible = False
        '
        'txt_temp
        '
        Me.txt_temp.BackColor = System.Drawing.Color.White
        Me.txt_temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_temp.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_temp.ForeColor = System.Drawing.Color.Black
        Me.txt_temp.Location = New System.Drawing.Point(615, 0)
        Me.txt_temp.Name = "txt_temp"
        Me.txt_temp.Size = New System.Drawing.Size(279, 23)
        Me.txt_temp.TabIndex = 284
        Me.txt_temp.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridControl1.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.GridControl1.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.GridControl1.Location = New System.Drawing.Point(1, 1)
        Me.GridControl1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1017, 471)
        Me.GridControl1.TabIndex = 286
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Image = Global.SMARTACCOUNTING.My.Resources.Resources.add
        Me.SimpleButton1.Location = New System.Drawing.Point(10, 479)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(146, 36)
        Me.SimpleButton1.TabIndex = 287
        Me.SimpleButton1.Text = "TAMBAH PESERTA"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.Image = Global.SMARTACCOUNTING.My.Resources.Resources.Actions_session_exit_icon__3_
        Me.SimpleButton2.Location = New System.Drawing.Point(162, 479)
        Me.SimpleButton2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 36)
        Me.SimpleButton2.TabIndex = 288
        Me.SimpleButton2.Text = "KELUAR"
        '
        'frmEventMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1018, 572)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEventMember"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Even Member"
        Me.Panel4.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txt_photo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_eventid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_reset As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_eventname As System.Windows.Forms.TextBox
    Friend WithEvents txt_area As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_keluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reset2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_end_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_start_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_eventid As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_region As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_posisi As System.Windows.Forms.TextBox
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nip As System.Windows.Forms.TextBox
    Friend WithEvents txt_photo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_reset_pic2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_upload2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_temp As System.Windows.Forms.TextBox
    Friend WithEvents txt_memberid As System.Windows.Forms.TextBox
    Friend WithEvents txt_save_path As System.Windows.Forms.TextBox
End Class
