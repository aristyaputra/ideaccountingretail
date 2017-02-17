<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_display_material
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_display_material))
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbitem = New System.Windows.Forms.RadioButton()
        Me.rbservice = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colaccno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colaccnm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colidbarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.NavBarControl2 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarGroupControlContainer2 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl1.SuspendLayout()
        Me.NavBarGroupControlContainer1.SuspendLayout()
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBarControl2.SuspendLayout()
        Me.NavBarGroupControlContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(0, 39)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(436, 21)
        Me.txt_search.TabIndex = 19
        '
        'cbo_search
        '
        Me.cbo_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Items.AddRange(New Object() {"ID", "Name"})
        Me.cbo_search.Location = New System.Drawing.Point(0, 0)
        Me.cbo_search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(159, 23)
        Me.cbo_search.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbitem)
        Me.GroupBox1.Controls.Add(Me.rbservice)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(435, 40)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'rbitem
        '
        Me.rbitem.AutoSize = True
        Me.rbitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbitem.Location = New System.Drawing.Point(90, 10)
        Me.rbitem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbitem.Name = "rbitem"
        Me.rbitem.Size = New System.Drawing.Size(49, 19)
        Me.rbitem.TabIndex = 1
        Me.rbitem.TabStop = True
        Me.rbitem.Text = "Item"
        Me.rbitem.UseVisualStyleBackColor = True
        '
        'rbservice
        '
        Me.rbservice.AutoSize = True
        Me.rbservice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbservice.Location = New System.Drawing.Point(7, 10)
        Me.rbservice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rbservice.Name = "rbservice"
        Me.rbservice.Size = New System.Drawing.Size(65, 19)
        Me.rbservice.TabIndex = 0
        Me.rbservice.TabStop = True
        Me.rbservice.Text = "Service"
        Me.rbservice.UseVisualStyleBackColor = True
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
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colaccno, Me.colaccnm, Me.colidbarcode})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(1, 100)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(634, 475)
        Me.DataGridView1.TabIndex = 20
        '
        'colaccno
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colaccno.DefaultCellStyle = DataGridViewCellStyle2
        Me.colaccno.HeaderText = "Item ID"
        Me.colaccno.Name = "colaccno"
        Me.colaccno.ReadOnly = True
        Me.colaccno.Width = 160
        '
        'colaccnm
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colaccnm.DefaultCellStyle = DataGridViewCellStyle3
        Me.colaccnm.HeaderText = "Item Name"
        Me.colaccnm.Name = "colaccnm"
        Me.colaccnm.ReadOnly = True
        Me.colaccnm.Width = 350
        '
        'colidbarcode
        '
        Me.colidbarcode.HeaderText = "Type"
        Me.colidbarcode.Name = "colidbarcode"
        Me.colidbarcode.ReadOnly = True
        Me.colidbarcode.Width = 135
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(1, 100)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(634, 475)
        Me.DataGridView2.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Service"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 160
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Service"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 380
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Appearance.Background.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl1.Appearance.Background.Options.UseBackColor = True
        Me.NavBarControl1.Appearance.GroupBackground.BackColor = System.Drawing.Color.Ivory
        Me.NavBarControl1.Appearance.GroupBackground.BackColor2 = System.Drawing.Color.Lavender
        Me.NavBarControl1.Appearance.GroupBackground.BorderColor = System.Drawing.Color.Transparent
        Me.NavBarControl1.Appearance.GroupBackground.Options.UseBackColor = True
        Me.NavBarControl1.Appearance.GroupBackground.Options.UseBorderColor = True
        Me.NavBarControl1.Appearance.GroupHeader.BackColor = System.Drawing.Color.Ivory
        Me.NavBarControl1.Appearance.GroupHeader.BackColor2 = System.Drawing.Color.Orange
        Me.NavBarControl1.Appearance.GroupHeader.Options.UseBackColor = True
        Me.NavBarControl1.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NavBarControl1.Controls.Add(Me.NavBarGroupControlContainer1)
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Location = New System.Drawing.Point(1, 39)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 183
        Me.NavBarControl1.Size = New System.Drawing.Size(183, 54)
        Me.NavBarControl1.TabIndex = 275
        Me.NavBarControl1.Text = "No Kas Umum / Bank"
        Me.NavBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.AdvExplorerBarViewInfoRegistrator()
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Filter By"
        Me.NavBarGroup1.ControlContainer = Me.NavBarGroupControlContainer1
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupClientHeight = 24
        Me.NavBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarGroupControlContainer1
        '
        Me.NavBarGroupControlContainer1.Controls.Add(Me.cbo_search)
        Me.NavBarGroupControlContainer1.Name = "NavBarGroupControlContainer1"
        Me.NavBarGroupControlContainer1.Size = New System.Drawing.Size(159, 23)
        Me.NavBarGroupControlContainer1.TabIndex = 0
        '
        'NavBarControl2
        '
        Me.NavBarControl2.ActiveGroup = Me.NavBarGroup2
        Me.NavBarControl2.Appearance.Background.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl2.Appearance.Background.Options.UseBackColor = True
        Me.NavBarControl2.Appearance.GroupBackground.BackColor = System.Drawing.Color.Ivory
        Me.NavBarControl2.Appearance.GroupBackground.BackColor2 = System.Drawing.Color.Lavender
        Me.NavBarControl2.Appearance.GroupBackground.BorderColor = System.Drawing.Color.Transparent
        Me.NavBarControl2.Appearance.GroupBackground.Options.UseBackColor = True
        Me.NavBarControl2.Appearance.GroupBackground.Options.UseBorderColor = True
        Me.NavBarControl2.Appearance.GroupHeader.BackColor = System.Drawing.Color.Ivory
        Me.NavBarControl2.Appearance.GroupHeader.BackColor2 = System.Drawing.Color.Orange
        Me.NavBarControl2.Appearance.GroupHeader.Options.UseBackColor = True
        Me.NavBarControl2.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.NavBarControl2.Controls.Add(Me.NavBarGroupControlContainer2)
        Me.NavBarControl2.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup2})
        Me.NavBarControl2.Location = New System.Drawing.Point(175, 1)
        Me.NavBarControl2.Name = "NavBarControl2"
        Me.NavBarControl2.OptionsNavPane.ExpandedWidth = 460
        Me.NavBarControl2.Size = New System.Drawing.Size(460, 99)
        Me.NavBarControl2.TabIndex = 276
        Me.NavBarControl2.Text = "No Kas Umum / Bank"
        Me.NavBarControl2.View = New DevExpress.XtraNavBar.ViewInfo.AdvExplorerBarViewInfoRegistrator()
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Filter Key"
        Me.NavBarGroup2.ControlContainer = Me.NavBarGroupControlContainer2
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.GroupClientHeight = 62
        Me.NavBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarGroupControlContainer2
        '
        Me.NavBarGroupControlContainer2.Controls.Add(Me.txt_search)
        Me.NavBarGroupControlContainer2.Controls.Add(Me.GroupBox1)
        Me.NavBarGroupControlContainer2.Name = "NavBarGroupControlContainer2"
        Me.NavBarGroupControlContainer2.Size = New System.Drawing.Size(436, 61)
        Me.NavBarGroupControlContainer2.TabIndex = 0
        '
        'frm_display_material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(636, 577)
        Me.Controls.Add(Me.NavBarControl2)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frm_display_material"
        Me.Text = "Material List"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl1.ResumeLayout(False)
        Me.NavBarGroupControlContainer1.ResumeLayout(False)
        CType(Me.NavBarControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBarControl2.ResumeLayout(False)
        Me.NavBarGroupControlContainer2.ResumeLayout(False)
        Me.NavBarGroupControlContainer2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents cbo_search As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbitem As System.Windows.Forms.RadioButton
    Friend WithEvents rbservice As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents NavBarControl2 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroupControlContainer2 As DevExpress.XtraNavBar.NavBarGroupControlContainer
    Friend WithEvents colaccno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colaccnm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colidbarcode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
